using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;
        
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = "2010"
                ,DailyPrice = 30000, Description = "Dark Black BMW",  },
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = "2001"
                ,DailyPrice = 10000, Description = "Doğan",  },
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = "2014"
                ,DailyPrice = 5000, Description = "FIAT Linea",  },
                new Car{Id = 1, BrandId = 1, ColorId = 1, ModelYear = "2018"
                ,DailyPrice = 200000, Description = "Dark Black BMW",  },

            };
        }


        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;

        }
    }
}
