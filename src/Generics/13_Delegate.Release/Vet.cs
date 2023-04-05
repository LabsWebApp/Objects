namespace DelegateRelease;

internal class Vet
{
    public static void Sterilize(Pet pet) =>
        WriteLine($"У {pet.GetType().Name} больше не будет деток(((");
}