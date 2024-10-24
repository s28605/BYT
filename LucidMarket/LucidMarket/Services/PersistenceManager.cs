using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.IO;

namespace LucidMarket.Services
{
    public static class PersistenceManager
    {
        private static JsonSerializerOptions options = new()
        {
            WriteIndented = true
        };

        public static void Save<T>(IEnumerable<T> objects, string fileName)
        {
            using var fileStream = File.Create(fileName);
            JsonSerializer.Serialize(fileStream, objects, options);
        }

        public static List<T> Load<T>(string fileName)
        {
            using var fileStream = File.OpenRead(fileName);
            return JsonSerializer.Deserialize<List<T>>(fileStream, options);
        }
    }
}
