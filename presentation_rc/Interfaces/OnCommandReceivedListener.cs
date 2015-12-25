using NozzhaPRC.Statuses;

namespace NozzhaPRC.Interfaces
{
    /// <summary>
    /// Used to listen to the received commands
    /// </summary>
    public interface OnCommandReceivedListener
    {
        /// <summary>
        /// Called when the server receives a command from the connected client
        /// </summary>
        /// <param name="command">The type of the received command</param>
        void OnCommandReceived(Command command);
    }
}
