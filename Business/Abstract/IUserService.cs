using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult Delete(User user);
        IResult Add(User user);
        IResult Modify(User user);
        IDataResult<List<User>> GetAll();
    }
}
