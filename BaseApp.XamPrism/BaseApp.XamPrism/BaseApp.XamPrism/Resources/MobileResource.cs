using BaseApp.XamPrism.Constant;
using System;
using System.Collections.Generic;
using System.Text;

namespace BaseApp.XamPrism.Resources
{
    public partial class MobileResource
    {
        private static MobileResource instance = null;

        protected static MobileResource Instance
        {
            get
            {
                // Lazy load => design Pattern
                if (instance == null)
                {
                    instance = new MobileResource();
                }
                return instance;
            }
        }

        public static string Get(string key)
        {
            try
            {
                string value = Instance.GetType().GetProperty(key).GetValue(Instance)?.ToString() ?? key;
                return value;
            }
            catch
            {
                return key;
            }
        }

        public static string Get(string defaultValue, string defaultValueEng)
        {
            var val = App.CurrentLanguage == CultureCountry.Vietnamese ? defaultValue : defaultValueEng;
            return val;
        }
    }
}
