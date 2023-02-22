// Конструктор "protected" - невозможно использовать - new Singleton() 
using Statics;

Singleton instance1 = Singleton.Instance();
Singleton instance2 = Singleton.Instance();

if (instance1 == instance2)
    Console.WriteLine("Ссылки указывают на один экземпляр объекта.");

// Delay.
Console.ReadKey();