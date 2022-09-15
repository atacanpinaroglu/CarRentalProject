using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        {
            using (CarRentalContext context = new CarRentalContext())
            {
                var result = from car in context.Cars
                             join b in context.Brands
                             on car.BrandId equals b.Id
                             join c in context.Colors
                             on car.ColorId equals c.Id
                             select new CarDetailDto
                             {
                                 Id = car.Id,
                                 CarName = car.Name,
                                 BrandName = b.Name,
                                 ColorName = c.Name,
                                 DailyPrice = car.DailyPrice,
                                 ModelYear = car.ModelYear,
                                 Description = car.Description
                             };
                return result.ToList();
            }
        }
    }
}
