using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        IResult Delete(Customer customer);
        IResult Add(Customer customer);
        IResult Modify(Customer customer);
        IDataResult<List<Customer>> GetAll();
    }
}
