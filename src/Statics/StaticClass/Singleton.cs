using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Statics
{
    // "Singleton"
    internal class Singleton
    {
        private static Singleton _instance = null;

        // Конструктор - "protected" 
        protected Singleton()
        {
        }

        // Фабричный метод.
        // Если: объект еще не создан, создаётся новый объект
        // Иначе: возвращаем ссылку на существующий объект
        public static Singleton Instance() => _instance ??= new Singleton();
    }
}
