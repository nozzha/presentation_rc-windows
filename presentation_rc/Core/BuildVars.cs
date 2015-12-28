namespace NozzhaPRC.Core
{
    /// <summary>
    /// Contains application information consts
    /// </summary>
    public class BuildVars
    {
        /// <summary>
        /// Application API version
        /// </summary>
        public static readonly int APP_API = 1;

        /// <summary>
        /// Application version name
        /// </summary>
        public static readonly string APP_VER = "151227" + APP_API;

        /// <summary>
        /// Android application url on Google Play Store
        /// </summary>
        public static readonly string PLAY_STORE_URL = @"https://play.google.com/store/apps/details?id=com.nozzha.presentation_rc";

        /// <summary>
        /// Used to get the latest version of the application,
        /// and the direct download url of it.
        /// </summary>
        public static readonly string APP_VERSION_URL = @"http://store.nozzha.com/apps/latest-version-number/presentation_rc/";
    }
}
