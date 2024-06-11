using DevelopmentChallenge.Data.Classes.enums;
using System.Resources;
using System.Globalization;
using System.Reflection;

namespace DevelopmentChallenge.Data.Util
{
    public class UtilResources
    {
        private static ResourceManager _instance = null;

        // singleton in order to get the resouece manager instance
        public static ResourceManager ResourceInstance
        {
            get
            {
                if (_instance == null) {
                   _instance = new ResourceManager("DevelopmentChallenge.Data.Resources.Resources", Assembly.GetExecutingAssembly());
                }
                return _instance;
            }
        }

        // method to get the culture language
        private static string ChangeCurrentLanguage(Language language)
        {
            switch (language)
            {
                case Language.SPANISH:
                    {
                        return "es";
                    }
                case Language.ENGLISH:
                    {
                        return "en";
                    }
                case Language.ITALIAN:
                    {
                        return "it";
                    }
                default:
                    {
                        break;
                    }
            }
            return "";
        }

        //method used to get the value of an specific key
        public static string GetValue(string key, Language language)
        {
            try
            {
                string value = ResourceInstance.GetString(key, new CultureInfo(ChangeCurrentLanguage(language)));

                return value;
            }
            catch {}

            return "";
        }

        //method used to get the value of an specific key and then format it with N parameters
        public static string GetValueFormat(string key, Language language, params object[] parameters)
        {
            try
            {
                string value = GetValue(key, language);

                string valueFormatted = string.Format(value, parameters);

                return valueFormatted;
            }
            catch { }

            return "";
        }
    }
}
