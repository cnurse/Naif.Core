using System;
using System.Globalization;
using System.Reflection;
using Naif.Core.Resources;

namespace FamilyTreeProject.Core.Contracts
{
    public static class Requires
    {
        public static void InRange(string parameter, bool rangeCheck)
        {
            if (!rangeCheck)
            {
                throw new ArgumentOutOfRangeException(String.Format(CultureInfo.CurrentCulture, CommonErrors.ArgumentOutOfRange, parameter), parameter);
            }
        }

        public static void IsTypeOf<T>(string parameter, object value)
        {
            if (!(value is T))
            {
                throw new ArgumentException(String.Format(CultureInfo.CurrentCulture, CommonErrors.ArgumentTypeOf, parameter, typeof(T).FullName), parameter);
            }
        }

        public static void NotNegative(string parameter, int value)
        {
            if (value < 0)
            {
                throw new IndexOutOfRangeException(String.Format(CultureInfo.CurrentCulture, CommonErrors.ValueCannotBeNegative, parameter));
            }
        }

        public static void NotNull<T>(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(typeof(T).Name);
            }
        }

        public static void NotNull(string parameter, object value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(String.Format(CultureInfo.CurrentCulture, CommonErrors.StringArgumentNull, parameter), parameter);
            }
        }

        public static void NotNullOrEmpty(string parameter, string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                throw new ArgumentException(String.Format(CultureInfo.CurrentCulture, CommonErrors.StringArgumentNullOrEmpty, parameter), parameter);
            }
        }

        public static void PropertyNotEqualTo<TValue>(string parameter, string propertyName, TValue propertyValue, TValue testValue) where TValue : IEquatable<TValue>
        {
            if (!propertyValue.Equals(testValue))
            {
                throw new ArgumentException(String.Format(CultureInfo.CurrentCulture, CommonErrors.PropertyNotEqualTo, parameter, propertyName), parameter);
            }
        }

        public static void PropertyNotNegative<T>(T item, string propertyName)
        {
            //Check first if the item is null
            NotNull(item);

            var type = typeof(T);
            var typeInfo = type.GetTypeInfo();
            var property = typeInfo.GetDeclaredProperty(propertyName);
            var propertyValue = property.GetValue(item);

            var intValue = (int)propertyValue;

            if (intValue < 0)
            {
                throw new IndexOutOfRangeException(String.Format(CultureInfo.CurrentCulture, CommonErrors.PropertyCannotBeNegative, type.Name, propertyName));
            }
        }

        public static void PropertyNotNegative(string parameter, string propertyName, int propertyValue)
        {
            if (propertyValue < 0)
            {
                throw new IndexOutOfRangeException(String.Format(CultureInfo.CurrentCulture, CommonErrors.PropertyCannotBeNegative, parameter, propertyName));
            }
        }

        public static void PropertyNotNull<T>(T item, string propertyName) where T : class
        {
            //Check first if the item is null
            NotNull(item);

            var type = typeof(T);
            var typeInfo = type.GetTypeInfo();
            var property = typeInfo.GetDeclaredProperty(propertyName);
            var propertyValue = property.GetValue(item);

            if (propertyValue == null)
            {
                throw new ArgumentNullException(propertyName);
            }
        }

        public static void PropertyNotNullOrEmpty(string parameter, string propertyName, string propertyValue)
        {
            if (String.IsNullOrEmpty(propertyValue))
            {
                throw new ArgumentException(String.Format(CultureInfo.CurrentCulture, CommonErrors.PropertyCannotBeNullOrEmpty, parameter, propertyName), parameter);
            }
        }

        public static void PropertyNotNullOrEmpty<T>(T item, string propertyName)
        {
            //Check first if the item is null
            NotNull(item);

            var type = typeof(T);
            var typeInfo = type.GetTypeInfo();
            var property = typeInfo.GetDeclaredProperty(propertyName);
            var propertyValue = property.GetValue(item);
            var stringValue = propertyValue as string;

            if (string.IsNullOrEmpty(stringValue))
            {
                throw new ArgumentException(String.Format(CultureInfo.CurrentCulture, CommonErrors.PropertyCannotBeNullOrEmpty, type.Name, propertyName), type.Name);
            }
        }
    }
}