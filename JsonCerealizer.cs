using System;
using Newtonsoft.Json;

namespace Cerealizer
{
    public static class JsonCerealizer
    {
        public static string CerealizeObject(object value)
        {
            return JsonConvert.SerializeObject(value);
        }

        public static string CerealizeObject(object value, Formatting formatting)
        {
            return JsonConvert.SerializeObject(value, formatting);
        }

        public static string CerealizeObject(object value, params JsonConverter[] converters)
        {
            return JsonConvert.SerializeObject(value, converters);
        }

        public static string CerealizeObject(object value, Formatting formatting, params JsonConverter[] converters)
        {
            return JsonConvert.SerializeObject(value, formatting, converters);
        }

        public static string CerealizeObject(object value, JsonSerializerSettings settings)
        {
            return JsonConvert.SerializeObject(value, settings);
        }

        public static string CerealizeObject(object value, Type type, JsonSerializerSettings settings)
        {
            return JsonConvert.SerializeObject(value, type, settings);
        }

        public static string CerealizeObject(object value, Formatting formatting, JsonSerializerSettings settings)
        {
            return JsonConvert.SerializeObject(value, formatting, settings);
        }

        public static string CerealizeObject(object value, Type type, Formatting formatting, JsonSerializerSettings settings)
        {
            return JsonConvert.SerializeObject(value, type, formatting, settings);
        }

        public static object DecerealizeObject(string value)
        {
            return JsonConvert.DeserializeObject(value);
        }

        public static object DecerealizeObject(string value, JsonSerializerSettings settings)
        {
            return JsonConvert.DeserializeObject(value, settings);
        }

        public static object DecerealizeObject(string value, Type type)
        {
            return JsonConvert.DeserializeObject(value, type);
        }

        public static T DecerealizeObject<T>(string value)
        {
            return JsonConvert.DeserializeObject<T>(value);
        }

        public static T DecerealizeAnonymousType<T>(string value, T anonymousTypeObject)
        {
            return JsonConvert.DeserializeAnonymousType<T>(value, anonymousTypeObject);
        }

        public static T DecerealizeAnonymousType<T>(string value, T anonymousTypeObject, JsonSerializerSettings settings)
        {
            return JsonConvert.DeserializeAnonymousType<T>(value, anonymousTypeObject, settings);
        }

        public static T DecerealizeObject<T>(string value, params JsonConverter[] converters)
        {
            return JsonConvert.DeserializeObject<T>(value, converters);
        }

        public static T DecerealizeObject<T>(string value, JsonSerializerSettings settings)
        {
            return JsonConvert.DeserializeObject<T>(value, settings);
        }

        public static object DecerealizeObject(string value, Type type, params JsonConverter[] converters)
        {
            return JsonConvert.DeserializeObject(value, type, converters);
        }
    }
}
