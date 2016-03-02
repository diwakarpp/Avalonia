// Copyright (c) The Perspex Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;
using System.Globalization;
using OmniXaml.TypeConversion;
using Perspex.Media;

namespace Perspex.Markup.Xaml.Converters
{
    public class SolidColorBrushTypeConverter : ITypeConverter
    {
        public bool CanConvertFrom(IValueContext context, Type sourceType)
        {
            return sourceType == typeof(string);
        }

        public bool CanConvertTo(IValueContext context, Type destinationType)
        {
            return false;
        }

        public object ConvertFrom(IValueContext context, CultureInfo culture, object value)
        {
            return Brush.Parse((string)value);
        }

        public object ConvertTo(IValueContext context, CultureInfo culture, object value, Type destinationType)
        {
            throw new NotImplementedException();
        }
    }
}