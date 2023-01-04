using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace EconomizeAqui.Localization
{
    public static class EconomizeAquiLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(EconomizeAquiConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(EconomizeAquiLocalizationConfigurer).GetAssembly(),
                        "EconomizeAqui.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
