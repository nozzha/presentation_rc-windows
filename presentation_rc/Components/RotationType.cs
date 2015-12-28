namespace NozzhaPRC.Components
{
    /// <summary>
    /// An enum used to indicate the rotational direction of the control.
    /// <see cref="http://www.codeproject.com/Articles/30625/Circular-Progress-Indicator">Circular Progress Indicator (Article)</see>
    /// <seealso cref="http://www.codeproject.com/info/cpol10.aspx">The Code Project Open License (CPOL)</seealso>
    /// </summary>
    public enum RotationType
    {
        /// <summary>
        /// Indicates that the rotation should move clockwise.
        /// </summary>
        Clockwise = 1,
        /// <summary>
        /// Indicates that the rotation should move counter-clockwise.
        /// </summary>
        CounterClockwise = -1,
    }
}