using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AbpTestGround.Localization
{
    public static class AbpTestGroundLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AbpTestGroundConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AbpTestGroundLocalizationConfigurer).GetAssembly(),
                        "AbpTestGround.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
