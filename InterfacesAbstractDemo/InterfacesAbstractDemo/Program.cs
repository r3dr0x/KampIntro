using InterfacesAbstractDemo.Abstract;
using InterfacesAbstractDemo.Concrete;
using System;

namespace InterfacesAbstractDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Entities.Customer {DateOfBirth = new DateTime(1985,1,6), FirstName = "Engin", LastName = "Demiroğ", NationalityId = "28861400108" } );
            Console.ReadLine();
        }
    }

    
}
