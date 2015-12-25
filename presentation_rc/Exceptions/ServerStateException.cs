using System;

namespace NozzhaPRC.Exceptions
{
    /// <summary>
    /// Thrown if trying to start a server that is already running
    /// or when trying to stop a server that hasn't been started yet
    /// </summary>
    public class ServerStateException : Exception
    {
        public ServerStateException()
            : base()
        {
        }

        public ServerStateException(string message)
            : base(message)
        {
        }
    }
}
