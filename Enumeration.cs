using System;

/*
=> Enumeration is a value data type and helps to assign the string value/name to integer constants. "enum" keyword is used for creating an enumeration. 
=> Basic syntax –

enum enum_name
{
// enumeration list
}

=> Enum Declaration: Enums do not need to be declared within a class to be used. By default, they are internal in scope when declared outside a class 
and within the same namespace, meaning they are accessible within the same project or assembly . By default, the first item of an enum has the value 0.
The second has the value 1, and so on. To get the integer value from an item, one must explicitly convert the item to an int .

=> User can also assign his own enum values, and the next items will update their numbers accordingly .

*/

public class Program
{
    enum Months
       {
           January,
           February,
           March,
           April,
           May,
           June,
           July,
           August,
       }
    public static void Main(string[] args)
    {
       Months BirthMonth = Months.March;
       int myMonth = (int)Months.March;
       Console.WriteLine(BirthMonth);
       Console.WriteLine(myMonth);
       int myGender = (int)Gender.Female;
       Console.WriteLine(myGender);
       
    }
}
enum Gender
{
    Male=10, // As the Male variable has been assignd 10 value the next varialbes will be assigned 11 , 12 ....
    Female,
    Other
}

//In this case, both Months and Gender enums are accessible in the Program class without "Public" Access modifier.
