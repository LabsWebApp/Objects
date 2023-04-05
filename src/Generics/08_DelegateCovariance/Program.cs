// Ковариантность обобщений. (delegate)

// ReSharper disable All
Pet? pet = null;
PetCreator<Pet>? delegatePet = null;

var shop = new PetShop();

var delegateCat = new PetCreator<Cat>(shop.CatProvider);
PetCreator<Dog> delegateDog = shop.DogProvider;

delegatePet = delegateCat;    // От производного к базовому.
// ****
delegatePet = delegateDog;    // От производного к базовому.
// ***
delegatePet = delegateCat;

pet = delegatePet.Invoke();

Console.WriteLine("Мы купили: " + pet.GetType().Name);

Console.ReadKey();

abstract class Pet { }
class Cat : Pet { }
class Dog : Pet { }
class Hamster : Pet { }

class PetShop
{
    public Cat CatProvider() => new Cat();
    public Dog DogProvider() => new Dog();
    // public Hamster HamsterCreator() => new();
}

delegate TResult PetCreator<out TResult>();   // out - Для возвращаемого значения.