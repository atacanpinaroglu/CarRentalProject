using Business.Concrete;
using Core.Utilities.Results;
using DataAccess.Concrete.EntityFramework;
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
            //CarTest();
            //UserTest();
            //RentalTest();

            Console.ReadLine();
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            var result = userManager.GetAll();
            foreach (var user in result.Data)
            {
                Console.WriteLine("{0} {1}", user.FirstName, user.LastName);
            }
            Console.WriteLine("\n{0}\n", result.Message);
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetAll();
            foreach (var car in result.Data)
            {
                Console.WriteLine("{0} {1}", car.Description, car.Name);
            }
            Console.WriteLine("\n{0}\n", result.Message);
        }

        private static void RentalTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetAll();
            foreach (var rental in result.Data)
            {
                Console.WriteLine("{0} - {1} {2}", rental.CarId, rental.CustomerId, rental.RentDate);
            }
            Console.WriteLine(result.Message);
        }
    }
}
