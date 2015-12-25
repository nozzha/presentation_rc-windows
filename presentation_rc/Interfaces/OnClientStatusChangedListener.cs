using NozzhaPRC.Core;
using NozzhaPRC.Statuses;

namespace NozzhaPRC.Interfaces
{
    /// <summary>
    /// Used to listen to the client status
    /// </summary>
    public interface OnClientStatusChangedListener
    {
        /// <summary>
        /// Called when the client status changes
        /// </summary>
        /// <param name="status">Client status</param>
        /// <param name="clientInfo">Client information</param>
        void OnClientStatusChanged(ClientStatus status, ClientInfo clientInfo);
    }
}
