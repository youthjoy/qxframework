using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Utilities;

using System.Globalization;
using Newtonsoft.Json;

namespace QX.Comm
{
    /// <summary>
    /// Converts a <see cref="DateTime"/> to and from the ISO 8601 date format (e.g. 2008-04-12T12:53Z).
    /// </summary>
    public class JsonDateConverter : DateTimeConverterBase
    {
        private const string DefaultDateTimeFormat = "yyyy'-'MM'-'dd HH':'mm':'ss.FFFFFFFK";

        private DateTimeStyles _dateTimeStyles = DateTimeStyles.RoundtripKind;
        private string _dateTimeFormat;
        private CultureInfo _culture;

        /// <summary>
        /// Gets or sets the date time styles used when converting a date to and from JSON.
        /// </summary>
        /// <value>The date time styles used when converting a date to and from JSON.</value>
        public DateTimeStyles DateTimeStyles
        {
            get { return _dateTimeStyles; }
            set { _dateTimeStyles = value; }
        }

        /// <summary>
        /// Gets or sets the date time format used when converting a date to and from JSON.
        /// </summary>
        /// <value>The date time format used when converting a date to and from JSON.</value>
        public string DateTimeFormat
        {
            get { return _dateTimeFormat ?? string.Empty; }
            set { _dateTimeFormat = (string.IsNullOrEmpty(value)) ? null : value; }
        }

        /// <summary>
        /// Gets or sets the culture used when converting a date to and from JSON.
        /// </summary>
        /// <value>The culture used when converting a date to and from JSON.</value>
        public CultureInfo Culture
        {
            get { return _culture ?? CultureInfo.CurrentCulture; }
            set { _culture = value; }
        }
        public JsonDateConverter()
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dateFormat">时间格式(yyyy-mm-dd)</param>
        public JsonDateConverter(string dateFormat)
        {
            this.DateTimeFormat = dateFormat;
        }
        /// <summary>
        /// Writes the JSON representation of the object.
        /// </summary>
        /// <param name="writer">The <see cref="JsonWriter"/> to write to.</param>
        /// <param name="value">The value.</param>
        /// <param name="serializer">The calling serializer.</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            string text;

            if (value is DateTime)
            {
                DateTime dateTime = (DateTime)value;

                if ((_dateTimeStyles & DateTimeStyles.AdjustToUniversal) == DateTimeStyles.AdjustToUniversal
                  || (_dateTimeStyles & DateTimeStyles.AssumeUniversal) == DateTimeStyles.AssumeUniversal)
                    dateTime = dateTime.ToUniversalTime();

                text = dateTime.ToString(_dateTimeFormat ?? DefaultDateTimeFormat, Culture);
            }
            else
            {
                text = string.Empty;
            }

            writer.WriteValue(text);
        }



        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}
