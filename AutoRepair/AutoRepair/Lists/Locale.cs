namespace AutoRepair.Lists {
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Text;


    public class Locale {

        /// <summary>
        /// Keyed by locale id (language code), values are human readable strings.
        /// </summary>
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1025:Code should not contain multiple whitespace in a row", Justification = "List alignment.")]
        [SuppressMessage("StyleCop.CSharp.SpacingRules", "SA1001:Commas should be spaced correctly", Justification = "List alignment.")]
        public static readonly Dictionary<string, string> FromId = new Dictionary<string, string>() {
            { "*"    , "Suitable for all languages" },
            { "cz"   , "Czech" }, // czech
            { "da"   , "Dansk"}, // danish
            { "de"   , "Deutsch" }, // german
            { "de-at", "Wiener" }, // vienesse
            { "de-ch", "Schweiz" }, // german (swiss)
            { "el"   , "Ελληνικά" }, // greek
            { "el-gr", "Ελληνικά" }, // greek (greece)
            { "en"   , "English" },
            { "en-ca", "Canadian" },
            { "en-gb", "British" },
            { "en-us", "American" },
            { "es"   , "Español" }, // spanish
            { "eu"   , "Europe" }, // probably not a real locale, but useful for road mods heh
            { "fa"   , "فارسی" }, // farsi
            { "fa-af", "دری" }, // dari
            { "fr"   , "Français" }, // french
            { "fr-ca", "Français (Canada)" }, // french (canadian)
            { "fr-ch", "Suisse" }, // french (swiss)
            { "hu"   , "Magyar" }, // hungarian
            { "hy"   , "հայերեն" }, // armenian
            { "hy-am", "հայերեն" }, // armenian (armenia)
            { "it"   , "Italiano" }, // italian
            { "it-ch", "Svizzera" }, // italian (swiss)
            { "ja"   , "日本語" }, // japanese
            { "ko"   , "한국어" }, // korean (south?)
            { "kr"   , "Yekgirtú" }, // kurdish
            { "ms-my", "بهاس مليسيا‎" }, // bahasa malaysia
            { "nl"   , "Nederlands" }, // dutch
            { "no"   , "Norsk" }, // norwegian
            { "pl"   , "Polski" }, // polish
            { "ps"   , "پښتو" }, // pashto
            { "pt"   , "Português" }, // portuguese
            { "ru"   , "Русский язык" }, // russian
            { "sk"   , "Slovenčina" }, // slovak
            { "sv-se", "svenska" }, // swedish
            { "th"   , "ภาษาไทย" }, // thai
            { "tl-ph", "Wikang Filipino" }, // wikang filipino
            { "tr"   , "Türkçe" }, // turkish
            { "tw"   , "國語" }, // taiwanese
            { "uk"   , "Українська" }, // ukrainian
            { "uz"   , "oʻzbek tili" }, // uzbek
            { "zh-tw", "中文 (繁體)" }, // traditional chinese / taiwanese?
            { "zh-cn", "中文 (简体)" }, // simplified chinese
            { "zh"   , "中文 (简体)" }, // chinese
        };

        /// <summary>
        /// Checks if the local dictionary has the given locale.
        /// </summary>
        /// 
        /// <param name="locale">The locale to check for.</param>
        /// 
        /// <returns>Returns <c>true</c> if present, otherwise <c>false</c>.</returns>
        public static bool Has(string locale) {
            return FromId.ContainsKey(locale);
        }

        /// <summary>
        /// Convert a language code in to the name of the language (in that language).
        /// </summary>
        /// 
        /// <param name="locale">The locale to get language name for.</param>
        /// 
        /// <returns>The languge name, if found, otherwise the locale code.</returns>
        public static string ToString(string locale) {
            if (FromId.TryGetValue(locale, out var name)) {
                return name;
            } else {
                return locale;
            }
        }

        /// <summary>
        /// Given a string array of locale codes, it returns a list of language names for those locales.
        /// </summary>
        /// 
        /// <param name="locales">String array containing the locale codes.</param>
        /// 
        /// <returns>List containing language name (in that language) for each locale.</returns>
        public static List<string> FromStringArray(string[] locales) {
            List<string> result = new List<string>();

            foreach (string locale in locales) {
                result.Add(ToString(locale));
            }

            return result;
        }

    }
}
