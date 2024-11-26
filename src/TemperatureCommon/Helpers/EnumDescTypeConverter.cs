﻿using System.ComponentModel;
using System.Globalization;

namespace TemperatureCommon.Helpers
{
    public class EnumDescTypeConverter : EnumConverter
    {
        public EnumDescTypeConverter(Type type)
            : base(type)
        {
        }

        public override object ConvertTo(ITypeDescriptorContext? context, CultureInfo? culture, object? value, Type destinationType)
        {
            if (destinationType == typeof(string))
            {
                if (value != null)
                {
                    var field = value?.GetType()?.GetField(value.ToString()!);
                    if (null != field)
                    {
                        DescriptionAttribute[] array = (DescriptionAttribute[])field.GetCustomAttributes(typeof(DescriptionAttribute), inherit: false);
                        return array.Length != 0 && !string.IsNullOrEmpty(array[0].Description!) ? array[0].Description : value.ToString()!;
                    }
                }

                return string.Empty;
            }

            return base.ConvertTo(context, culture, value, destinationType)!;
        }
    }
}