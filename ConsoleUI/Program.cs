using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entity.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //BrandAdd();
            //ColorAdd();
            //GetCarDetails();
            //CustomerAdd();
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.GetAll();

            if (result.Success)
            {
                foreach (var customer in result.Data)
                {
                    Console.WriteLine(customer);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
            

        }

        private static void CustomerAdd()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            var result = customerManager.Add(new Customer { UserId = 2, CompanyName = "BMW" });
            if (result.Success == true)
            {
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void GetCarDetails()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success==true)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine(car.CarName + "\n" + car.BrandName + "\n" + car.ColorName + "\n" + car.DailyPrice + "\n ----------");
                }
                Console.WriteLine("\n" + result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            
        }

        private static void ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Kırmızı" });
            colorManager.Add(new Color { ColorName = "Mavi" });
            colorManager.Add(new Color { ColorName = "Siyah" });
            colorManager.Add(new Color { ColorName = "Beyaz" });
            colorManager.Add(new Color { ColorName = "Gri" });
        }

        private static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Add(new Brand { BrandName = "" });
        }
    }
}
