using System;

namespace Interfaces
{
    class Program
    {
        //interface new'lenemez
        static void Main(string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();
            

            //IPersonManager employeeManager = new EmployeeManager();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
        }
    }

    interface IPersonManager
    {
        //unimplemented operation
        void Add();
        void Update();

    }

    //inherits - class ---------------implements - inteface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //Müşteri Ekleme Kodları
            Console.WriteLine("Müşteri Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri Güncellendi");
        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //Personel Ekleme Kodları
            Console.WriteLine("Personel Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel Güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer Eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer Güncellendi");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager personManager)
        {
            
            personManager.Add();
        }

    }
}