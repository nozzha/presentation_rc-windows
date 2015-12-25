namespace NozzhaPRC.Statuses
{
    /// <summary>
    /// Holds all possible statuses of the target server
    /// </summary>
    public enum ServerStatus
    {
        NotConnected,
        Connecting,
        Disconnecting,
        Connected,
        Failed
    }
}
