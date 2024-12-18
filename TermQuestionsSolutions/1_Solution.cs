using System;

//Here get + set methods will help to achieve the Encapsulation

public class Person
{
    // Fields
    private string firstName;
    private string lastName;
    private DateTime dateOfBirth;
    private Gender gender;
    private string address;
    private string nIDCardNumber;

    // Properties
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }

    public string LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }

   public DateTime DateOfBirth
   {
       get { return dateOfBirth; }
       set
       {
           if (value > DateTime.Today)
           {
               throw new ArgumentException("Date of birth cannot be in the future.");
           }
           dateOfBirth = value;
       }
  }

    public Gender Gender
    {
        get { return gender; }
        set { gender = value; }
    }

    public string Address
    {
        get { return address; }
        set { address = value; }
    }

    // Age calculation considering year, month, and day
    public int Age
    {
        get
        {
            int age = DateTime.Today.Year - dateOfBirth.Year;
            if (dateOfBirth > DateTime.Today.AddYears(-age)) age--;
            return age;
        }
    }

    // Private method to check if the person is 18 years old
    private bool IsAdult()
    {
        return Age >= 18;
    }
    // Method to check if all values are set
   public bool IsComplete()
{
    // Checking if each important field is set
    if (firstName == null || lastName == null || address == null || nIDCardNumber == null)
    {
        return false; // If any of these fields are null, return false
    }

    // Checking if the date of birth is a valid date
    if (dateOfBirth == DateTime.MinValue) // MinValue is like the "default" date
    {
        return false;
    }

    // Checking if the gender is set
    if (gender == Gender.Male || gender == Gender.Female || gender == Gender.Other)
    {
        return true; //(person is complete)
    }

    return false; 
}
  // Here "IsComplete()" method helps to achieve data validation.
  
    // Get method for NIDCardNumber only if person is 17 or older
    public string NIDCardNumber
    {
        get
        {
            if (Age >= 17)
                return nIDCardNumber;
            else
                return null;
        }
        set { nIDCardNumber = value; }
    }
}
// Enum for Gender
public enum Gender
{
    Male,
    Female,
    Other
}
