//  --------------------------------
//  Copyright (c) Microsoft Corporation. All rights reserved.
//  This source code is made available under the terms of the Microsoft Public License (Ms-PL)
//  http://www.codeplex.com/oxite/license
//  ---------------------------------
using System;
using System.Collections.Specialized;

namespace QX.Comm
{
    public class AppSettingsHelper
    {
        private readonly NameValueCollection appSettings;
        
        

        public AppSettingsHelper(NameValueCollection appSettings)
        {
            this.appSettings = appSettings;
        }

        #region GetString

        public string GetString(string name)
        {
            return getValue(name, true, null);
        }

        public string GetString(string name, string defaultValue)
        {
            return getValue(name, false, defaultValue);
        }

        #endregion

        #region GetStringArray

        public string[] GetStringArray(string name, string separator)
        {
            return getStringArray(name, separator, true, null);
        }

        public string[] GetStringArray(string name, string separator, string[] defaultValue)
        {
            return getStringArray(name, separator, false, defaultValue);
        }

        private string[] getStringArray(string name, string separator, bool valueRequired, string[] defaultValue)
        {
            string value = getValue(name, valueRequired, null);

            if (!string.IsNullOrEmpty(value))
                return value.Split(new[] { separator }, StringSplitOptions.RemoveEmptyEntries);
            else if (!valueRequired)
                return defaultValue;

            throw generateRequiredSettingException(name);
        }

        #endregion

        #region GetInt32

        public int GetInt32(string name)
        {
            return getInt32(name, null);
        }

        public int GetInt32(string name, int defaultValue)
        {
            return getInt32(name, defaultValue);
        }

        private int getInt32(string name, int? defaultValue)
        {
            return getValue<int>(name, (v, pv) => int.TryParse(v, out pv), defaultValue);
        }

        #endregion

        #region GetBoolean

        public bool GetBoolean(string name)
        {
            return getBoolean(name, null);
        }

        public bool GetBoolean(string name, bool defaultValue)
        {
            return getBoolean(name, defaultValue);
        }

        private bool getBoolean(string name, bool? defaultValue)
        {
            return getValue<bool>(name, (v, pv) => bool.TryParse(v, out pv), defaultValue);
        }

        #endregion

        #region GetTimeSpan

        public TimeSpan GetTimeSpan(string name)
        {
            return TimeSpan.Parse(getValue(name, true, null));
        }

        public TimeSpan GetTimeSpan(string name, TimeSpan defaultValue)
        {
            string val = getValue(name, false, null);

            if (val == null)
                return defaultValue;

            return TimeSpan.Parse(val);
        }

        #endregion

        #region Private Methods

        private T getValue<T>(string name, Func<string, T, bool> parseValue, T? defaultValue) where T : struct
        {
            string value = appSettings[name];

            if (value != null)
            {
                T parsedValue = default(T);

                if (parseValue(value, parsedValue))
                    return parsedValue;
                else
                    throw new InvalidOperationException(string.Format("Setting '{0}' was not a valid {1}", name, typeof(T).FullName));
            }

            if (!defaultValue.HasValue)
                throw generateRequiredSettingException(name);
            else
                return defaultValue.Value;
        }

        private string getValue(string name, bool valueRequired, string defaultValue)
        {
            string value = appSettings[name];

            if (value != null)
                return value;
            else if (!valueRequired)
                return defaultValue;

            throw generateRequiredSettingException(name);
        }

        private Exception generateRequiredSettingException(string name)
        {
            return new InvalidOperationException(string.Format("Could not find required setting '{0}'", name));
        }



        #endregion
    }
}
