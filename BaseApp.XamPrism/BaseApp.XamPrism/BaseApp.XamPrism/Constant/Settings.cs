using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Essentials;

namespace BaseApp.XamPrism.Constant
{
    public static class Settings
    {
        private const string CurrentLanguageKey = "current_language_key";
        private static readonly string CurrentLanguageDefault = CultureCountry.Vietnamese;

        /// <summary>
        /// ngôn ngữ hiện tại được chọn
        /// </summary>
        public static string CurrentLanguage
        {
            get => Preferences.Get(CurrentLanguageKey, CurrentLanguageDefault);
            set => Preferences.Set(CurrentLanguageKey, value);
        }
    }
}
