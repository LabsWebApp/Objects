public static class UserTypeExtensions
{
    public static UserType Add(this UserType userType, params UserType[] typesToAdd)
    {
        foreach (var item in typesToAdd) userType |= item;
        return userType;
    }

    public static UserType Remove(this UserType userType, params UserType[] typesToRemove)
    {
        foreach (var item in typesToRemove) userType &= ~item;
        return userType;
    }

    public static bool CustomHasFlag(this UserType userType, UserType typeToCompare)
        => (userType & typeToCompare) == typeToCompare;

    public static void Print(this UserType userType)
        => WriteLine($"Это сообщение для пользователей типа: {userType}.");
}