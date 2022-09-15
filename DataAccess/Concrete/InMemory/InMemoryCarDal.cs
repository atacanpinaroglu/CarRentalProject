using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        List<Brand> _brands;
        List<Color> _colors;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car{ Id=1 ,BrandId=1 ,ColorId=1 ,ModelYear=1994 ,DailyPrice=100, Name="Supra MK4", Description="Hatasız boyasız temiz"},
                new Car{ Id=2 ,BrandId=2 ,ColorId=2 ,ModelYear=1998 ,DailyPrice=150, Name="GT-R R34", Description="Öğretmenden temiz"},
                new Car{ Id=3 ,BrandId=2 ,ColorId=3 ,ModelYear=2022 ,DailyPrice=200, Name="GT-R R35", Description="Doktordan değişensiz temiz"}
            };
            _brands = new List<Brand>()
            {
                new Brand{ Id=1 ,Name="Nissan"},
                new Brand{ Id=2 ,Name="Toyota"},
            };
            _colors = new List<Color>()
            {
                new Color{ Id=1 ,Name="Midnight Purple"},
                new Color{ Id=2 ,Name="Black"},
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(car);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {

            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
