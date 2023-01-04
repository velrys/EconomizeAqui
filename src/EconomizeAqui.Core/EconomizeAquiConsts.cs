using EconomizeAqui.Debugging;

namespace EconomizeAqui
{
    public class EconomizeAquiConsts
    {
        public const string LocalizationSourceName = "EconomizeAqui";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "d6eaec1e17e14041aaa5943b61a2c4a3";
    }
}
