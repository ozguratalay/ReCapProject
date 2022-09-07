using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car {BrandId=1,ColorId=1,Id=1,ModelYear=2022,DailyPrice=800,Description="En fazla 250km"},
                new Car {BrandId=1,ColorId=2,Id=2,ModelYear=2020,DailyPrice=800,Description="En fazla 250km"},
                new Car {BrandId=1,ColorId=2,Id=3,ModelYear=2021,DailyPrice=800,Description="En fazla 250km"},
                new Car {BrandId=1,ColorId=1,Id=4,ModelYear=2019,DailyPrice=800,Description="En fazla 250km"},
                new Car {BrandId=1,ColorId=1,Id=5,ModelYear=2018,DailyPrice=800,Description="En fazla 250km"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
           Car carsToDelete = _cars.FirstOrDefault(x => x.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(x => x.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carsToUpdate = _cars.FirstOrDefault(x => x.Id == car.Id);
            carsToUpdate.BrandId = car.BrandId;
            carsToUpdate.ColorId = car.ColorId;
            carsToUpdate.DailyPrice = car.DailyPrice;
            carsToUpdate.Description = car.Description;
        }
    }
}
