using Business.Concrete;
using Entities.Concrete;
using System;
using System.IO.Pipes;

internal class Program
{
    private static void Main(string[] args)
    {
        
        Console.ReadLine();
        
        Person person1 = new Person();
        person1.FirstName = "Mehmet";
        person1.LastName = "Keskin";
        person1.BirthYear = 1988;
        person1.NationalIdentity = 12345678910;

        PttManager pttManager = new PttManager (new PersonManager());
        pttManager.GiveMask(person1);

    }

      
}


