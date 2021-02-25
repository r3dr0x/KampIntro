using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Collections.Generic;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());
            List<Car> cars = carManager.GetAll();

            Console.WriteLine("Sistemdeki Arabalar Listelendi : \n");
            foreach (Car car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + " " + car.DailyPrice + " " + car.ModelYear);
            }
            Console.WriteLine("--------------------");

            Console.WriteLine("Sistemdeki Arabaların İd'si Listelendi \n");
            foreach (Car car in carManager.GetById(1))
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("--------------------");

            Console.WriteLine("Araba Sisteme Eklendi");
            carManager.Add(new Car
            {
                Id = 3,
                BrandId = 3,
                ColorId = 3,
                ModelYear = "2020",
                DailyPrice = 15000,
                Description = "2020 Moden Ford Fiesta"

            });

            foreach (Car car in carManager.GetAll())
            {
                Console.WriteLine(car.Description);
            }
            Console.WriteLine("--------------------");

            Console.WriteLine("Gönderdiğiniz Bilgilere Göre Güncelleme Başlatıldı");
            carManager.Update(new Car
            {
                Id=4,
                BrandId=4,
                ColorId=4,
                ModelYear="2020",
                DailyPrice=45000,
                Description="Tesla Model S"
            });

            foreach (Car car in carManager.GetAll())
            {
                Console.WriteLine(car.Description + "\n" + car.DailyPrice + "\n" + car.ModelYear);
            }
        }
    }
}
