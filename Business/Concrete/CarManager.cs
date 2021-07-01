using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.CarName.Length<2 && car.DailyPrice<=0)
            {
                return new ErrorResult(Messages.ErrorMessage);
            }
            _carDal.Add(car);
            return new SuccessResult(Messages.AddedMessage);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.DeletedMessage);
        }

        public IDataResult<List<Car>> GetAll()
        {
            //.............
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(),Messages.ListedMessage);
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            if (DateTime.Now.Hour > 00 && DateTime.Now.Hour < 06)
            {
                return new ErrorDataResult<List<CarDetailDto>>(Messages.MaintenanceMessage);
            }
            return new SuccessDataResult<List< CarDetailDto >>(_carDal.GetCarDetails(),Messages.ListedMessage);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.BrandId == id), Messages.ListedMessage);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(c => c.ColorId == id),Messages.ListedMessage);
        }

        public IResult Modify(Car car)
        {            
            _carDal.Modify(car);
            return new SuccessResult(Messages.ModifiedMessage);
        }
    }
}
