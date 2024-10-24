using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LucidMarket.Services;
using System.IO;

namespace LucidMarket.Abstractions
{
    public abstract class ClassExtent<T> where T : ClassExtent<T>
    {
        private static readonly string Filename = typeof(T).Name + ".json";
        private static List<T> _objects = new List<T>();

        protected ClassExtent()
        {
            _objects.Add((T)this);
        }

        public static List<T> GetObjects()
        {
            if (File.Exists(Filename))
            {
                Load();
            }

            return new List<T>(_objects);
        }

        public static void Persist()
        {
            PersistenceManager.Save(_objects, Filename);
        }

        private static void Load()
        {
            _objects = PersistenceManager.Load<T>(Filename);
        }
    }
}
