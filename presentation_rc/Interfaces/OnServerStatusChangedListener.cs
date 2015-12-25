using NozzhaPRC.Servers;
using NozzhaPRC.Statuses;

namespace NozzhaPRC.Interfaces
{
    /// <summary>
    /// Used to listen to the target server status
    /// </summary>
    public interface OnServerStatusChangedListener
    {
        /// <summary>
        /// Called when the target server status changes
        /// </summary>
        /// <param name="server">Target server object</param>
        /// <param name="status">Server status</param>
        void OnServerStatusChanged(Server server, ServerStatus status);
    }
}
