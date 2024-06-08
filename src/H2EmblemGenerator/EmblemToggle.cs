namespace H2EmblemGenerator
{
    /// <summary>
    /// The player emblem toggle.
    /// </summary>
    public enum EmblemToggle : byte
    {
        /// <summary>
        /// This shouldn't happen?
        /// </summary>
        None = 0,

        /// <summary>
        /// Display both primary and secondary emblem parts.
        /// </summary>
        Default = 2,

        /// <summary>
        /// Display only the secondary emblem part.
        /// </summary>
        PrimaryDisabled = 3
    }
}
