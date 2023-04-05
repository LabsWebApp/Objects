using DelegateRelease;

Pet? pet = null;
var shop = new PetShop();

Func<Pet> getPet = shop.CatCreator;
pet = getPet.Invoke();

WriteLine($"Купили питомца - {pet.GetType().Name}");

Thread.Sleep(500);
WriteLine("\n*****\n");
Thread.Sleep(1500);

var cat = pet as Cat;
Action<Cat> sCat = Vet.Sterilize;

sCat.Invoke(cat!);

ReadKey();