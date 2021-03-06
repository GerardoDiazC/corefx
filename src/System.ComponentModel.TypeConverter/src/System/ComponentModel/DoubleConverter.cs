// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Globalization;

namespace System.ComponentModel
{
    /// <summary>
    ///    <para>Provides a type
    ///       converter to convert double-precision, floating point number objects to and from various
    ///       other representations.</para>
    /// </summary>
    public class DoubleConverter : BaseNumberConverter
    {
        /// <summary>
        /// Determines whether this editor will attempt to convert hex (0x or #) strings
        /// </summary>
        internal override bool AllowHex
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// The Type this converter is targeting (e.g. Int16, UInt32, etc.)
        /// </summary>
        internal override Type TargetType
        {
            get
            {
                return typeof(Double);
            }
        }

        /// <summary>
        /// Convert the given value to a string using the given radix
        /// </summary>
        internal override object FromString(string value, int radix)
        {
            return Convert.ToDouble(value, CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Convert the given value to a string using the given formatInfo
        /// </summary>
        internal override object FromString(string value, NumberFormatInfo formatInfo)
        {
            return Double.Parse(value, NumberStyles.Float, formatInfo);
        }


        /// <summary>
        /// Convert the given value to a string using the given CultureInfo
        /// </summary>
        internal override object FromString(string value, CultureInfo culture)
        {
            return Double.Parse(value, culture);
        }

        /// <summary>
        /// Convert the given value from a string using the given formatInfo
        /// </summary>
        internal override string ToString(object value, NumberFormatInfo formatInfo)
        {
            return ((Double)value).ToString("R", formatInfo);
        }
    }
}

