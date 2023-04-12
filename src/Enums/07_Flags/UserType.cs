[Flags]
public enum UserType
{
    None = 0, 
    Customer = 1,
    Driver = 2,
    Admin = 2<<1, //4
    Sysadmin = 2<<2, //8
    Employee = Driver | Admin
}

[Flags]
public enum BadType
{
    None,
    Customer,
    Driver,
    Admin,
    Sysadmin,
    Employee = Driver | Admin
}