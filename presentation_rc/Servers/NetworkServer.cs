using NozzhaPRC.Core;
using NozzhaPRC.Exceptions;
using NozzhaPRC.Statuses;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace NozzhaPRC.Servers
{
    /// <summary>
    /// The WiFi/Network server that handles clients' incoming connection 
    /// through network adapter
    /// </summary>
    public class NetworkServer : Server
    {
        /// <summary>
        /// Maximum number of allowed connections
        /// set to <c>1</c> as there can't be more than one remote control
        /// client currently
        /// </summary>
        static readonly int MAX_CONNECTIONS_NUMBER = 1;

        /// <summary>
        /// Characters encoder
        /// </summary>
        static readonly Encoding CHAR_ENCODER = Encoding.UTF8;

        /// <summary>
        /// An IP address for the server to bind on
        /// </summary>
        public IPAddress IPAddress { get; set; }

        /// <summary>
        /// A port for the server to bind on
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// The maximum waiting time for both server/client recieve/send operations
        /// it's default value is set using the main constructor
        /// </summary>
        public int Timeout { get; set; }

        /// <summary>
        /// Holds the running server socket
        /// </summary>
        private Socket serverSocket;

        /// <summary>
        /// Holds the connected client socket
        /// </summary>
        private Socket clientSocket;

        /// <summary>
        /// Main constructor
        /// </summary>
        public NetworkServer()
            : base("Network Server")
        {
            //
            // Set default values
            //
            Timeout = 5 * 1000;
        }

        /// <summary>
        /// Process and starts the server
        /// Note: Used internally.
        /// </summary>
        protected override void StartOrThrow()
        {
            if (Running)
                // You can't start a running server
                throw new ServerStateException("Cannot start server that is currently running");

            Running = true;
            updateServerStatus(ServerStatus.Connecting);


            Log("Setting server up...");
            serverSocket = new Socket(
                AddressFamily.InterNetwork,
                SocketType.Stream,
                ProtocolType.Tcp
                );

            Log("Binding IPAddress: " + IPAddress.ToString());
            Log("Binding Port: " + Port);
            Log("Binding server socket...");
            serverSocket.Bind(new IPEndPoint(IPAddress, Port));

            Log("Set listening max connections number...");
            Log("Max connections number: " + MAX_CONNECTIONS_NUMBER);
            serverSocket.Listen(MAX_CONNECTIONS_NUMBER);

            Log("Set receive and send timeout settings...");
            Log("Receive and send timeout: " + Timeout);
            serverSocket.ReceiveTimeout = Timeout;
            serverSocket.SendTimeout = Timeout;

            Log("Finished setting up server");

            Log("Starting server...");
            updateServerStatus(ServerStatus.Connected);

            // Start a thread that handles incoming client connections
            new Thread(() =>
            {
                // This keeps the server ready for incoming clients' connections
                // and if a client has diconnected it the loops again to start
                // waiting for a new incoming connections
                while (Running)
                {
                    try { WaitingForClientOrThrow(); }
                    catch { }

                    // Being here means that the client has disconnected
                    // no matter how (either connection dropped,
                    // connection timedout or server stoped etc.)

                    Log("Client has disconnected!");
                    updateClientStatus(ClientStatus.NotConnected, null);
                }


                // If the flag `FailedToStart` is true
                // then do not publish the `ServerStatus.NotConnected` status
                // as this will override the `ServerStatus.Failed` status
                if (!FailedToStart)
                    updateServerStatus(ServerStatus.NotConnected);

                // Reset flag
                FailedToStart = false;
            }).Start();
        }

        /// <summary>
        /// Process and handles clients incoming connections
        /// Note: Used internally.
        /// </summary>
        protected override void WaitingForClientOrThrow()
        {
            Log("Waiting for a client connection...");
            clientSocket = serverSocket.Accept();
            Log("A client has connected!");

            // Prepares client's info
            ClientInfo clientInfo = new ClientInfo();
            // TODO: provide a client name to show it to the user
            clientInfo.Name = "N/A";

            updateClientStatus(ClientStatus.Connected, clientInfo);

            Log("Set receive and send timeout settings for client socket...");
            Log("Client socket receive and send timeout: " + Timeout);
            clientSocket.ReceiveTimeout = Timeout;
            clientSocket.SendTimeout = Timeout;

            Log("All setup!");

            // An array of one byte because all commands are currently
            // presented as one character
            byte[] buffer = new byte[1];
            int length;

            Log("Handling the connection...");

            while (Running && (length = clientSocket.Receive(buffer)) > 0)
            {
                string data = CHAR_ENCODER.GetString(buffer, 0, length);

                Log("Received data: " + data);

                // Process the received char to determine to which command does it
                // belong
                processCommand(data);
            }

            // Being here it means that the `clientSocket` has either disconnected
            // or timedout

            clientSocket.Close();

            // reset client socket
            clientSocket = null;
        }

        /// <summary>
        /// Stops the server
        /// Note: Used internally.
        /// </summary>
        protected override void StopOrThrow()
        {
            if (!Running)
                // You can't stop a server that is not running and hasn't been started yet
                throw new ServerStateException("Cannot stop server that is not running yet");

            Running = false;

            updateServerStatus(ServerStatus.Disconnecting);

            Log("Stopping Server...");

            try
            {
                if (clientSocket != null)
                    clientSocket.Close();
            }
            catch { }

            // make sure to reset the client socket
            clientSocket = null;

            try
            {
                serverSocket.Close();

                Log("Server stopped!");
                updateServerStatus(ServerStatus.NotConnected);
            }
            catch { }

            // reset server socket
            serverSocket = null;
        }

    }
}
