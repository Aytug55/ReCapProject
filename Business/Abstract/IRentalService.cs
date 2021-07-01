using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IResult Delete(Rental rental);
        IResult Add(Rental rental);
        IResult Modify(Rental rental);
        IDataResult<List<Rental>> GetAll();
    }
}
