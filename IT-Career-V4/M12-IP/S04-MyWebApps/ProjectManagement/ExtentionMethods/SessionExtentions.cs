using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace ProjectManagement.ExtentionMethods
{
    public static class SessionExtentions
    {
        public static void SetObject<T>(this ISession instance, string key, T value)
            where T : class
        {
            if (value == null)
            {
                instance.Remove(key);
                return;
            }

            string jsonData = JsonSerializer.Serialize(value);
            instance.SetString(key, jsonData);
        }

        public static T GetObject<T>(this ISession instance, string key)
            where T : class
        {
            if (!instance.Keys.Contains(key))
                return null;

            string jsonData = instance.GetString(key);

            if (String.IsNullOrEmpty(jsonData))
                return null;

            return JsonSerializer.Deserialize<T>(jsonData);
        }
    }
}
