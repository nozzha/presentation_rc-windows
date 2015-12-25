using NozzhaPRC.Core;
using NozzhaPRC.Exceptions;
using NozzhaPRC.Interfaces;
using NozzhaPRC.Statuses;
using System;
using System.Diagnostics;

namespace NozzhaPRC.Servers
{
    /// <summary>
    /// An abstract class for servers
    /// </summary>
    public abstract class Server
    {
        /// <summary>
        /// To show logs
        /// </summary>
        public bool DebugMode = false;

        /// <summary>
        /// Indicates server status
        /// </summary>
        public bool Running { get; protected set; }

        /// <summary>
        /// Indicates server failed to start
        /// </summary>
        protected bool FailedToStart { get; set; }

        /// <summary>
        /// Registered server status listener
        /// </summary>
        public OnServerStatusChangedListener ServerStatusListener { private get; set; }

        /// <summary>
        /// Registered client status listener
        /// </summary>
        public OnClientStatusChangedListener ClientStatusListener { private get; set; }

        /// <summary>
        /// Registered received command listener
        /// </summary>
        public OnCommandReceivedListener CommandReceivedListener { private get; set; }

        /// <summary>
        /// The name of the server
        /// </summary>
        public string ServerName { get; private set; }

        /// <summary>
        /// Main constructor
        /// </summary>
        /// <param name="name">Server name</param>
        protected Server(string name)
        {
            this.ServerName = name;
        }

        /// <summary>
        /// Publishes the status of the server to the registered listener
        /// </summary>
        /// <param name="status">Server status</param>
        protected void updateServerStatus(ServerStatus status)
        {
            if (ServerStatusListener == null)
                return;

            ServerStatusListener.OnServerStatusChanged(this, status);
        }

        /// <summary>
        /// Publishes the status of the connected client to the registered listener
        /// </summary>
        /// <param name="status">Client status</param>
        /// <param name="clientInfo">Client information</param>
        protected void updateClientStatus(ClientStatus status, ClientInfo clientInfo)
        {
            if (ClientStatusListener == null)
                return;

            ClientStatusListener.OnClientStatusChanged(status, clientInfo);
        }

        /// <summary>
        /// Processes and publishes the received command to the registered listener
        /// </summary>
        /// <param name="response">The received command/request</param>
        protected void processCommand(string request)
        {
            if (CommandReceivedListener == null)
                // If there is not registered listener
                // then there's no need to process the command/request
                return;

            Command cmd = Command.Unknown;

            if (request == "n")
                cmd = Command.NextSlide;
            else if (request == "p")
                cmd = Command.PreviousSlide;
            else if (request == "k")
                cmd = Command.KeepAlive;
            else
                cmd = Command.Unknown;

            CommandReceivedListener.OnCommandReceived(cmd);
        }

        /// <summary>
        /// Starts the server up
        /// </summary>
        /// <exception cref="NozzhaRPC.Exceptions.ServerStateException">
        /// Thrown if called and the server already running.
        /// Note: This is not suppose to be thrown in a released version,
        /// so make sure the server is not running using <c>Server.Running</c> property
        /// or stop it using <c>Server.Stop()</c> method before calling this method
        /// </exception>
        public void Start()
        {
            try { StartOrThrow(); }
            catch (ServerStateException e) { throw e; }
            catch (Exception)
            {
                // There shouldn't be any thrown exceptions during the starting process
                // so if there are any, that usually means that the server hasn't started
                // and therefore should stop the server from running and mark it as `FailedToStart`
                // Note: the starting process is done in the main thread
                Running = false;
                FailedToStart = true;
                updateServerStatus(ServerStatus.Failed);
            }
        }

        /// <summary>
        /// Stops the server
        /// </summary>
        /// <exception cref="NozzhaRPC.Exceptions.ServerStateException">
        /// Thrown if called and the server is not running and hasn't started yet.
        /// Note: This is not suppose to be thrown in a released version,
        /// so make sure the server is running using <c>Server.Running</c> property
        /// before calling this method
        /// </exception>
        public void Stop()
        {
            try { StopOrThrow(); }
            catch (ServerStateException e) { throw e; }
            catch (Exception e)
            {
                // TODO: should handle this properly
                throw e;
            }
        }

        /// <summary>
        /// Process and starts the server
        /// Note: Used internally.
        /// </summary>
        abstract protected void StartOrThrow();

        /// <summary>
        /// Process and handles clients incoming connections
        /// Note: Used internally.
        /// </summary>
        abstract protected void WaitingForClientOrThrow();


        /// <summary>
        /// Stops the server
        /// Note: Used internally.
        /// </summary>
        abstract protected void StopOrThrow();


        /// <summary>
        /// Processes and displays server running and error logs
        /// Note: Used internally.
        /// </summary>
        protected void Log(string message)
        {
            // Ignroe if not in debug mode
            if (!DebugMode)
                return;

            Debug.WriteLine(message, ServerName);
        }
    }
}
