using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IResult Delete(Color color);
        IResult Add(Color color);
        IResult Modify(Color color);
        IDataResult<List<Color>> GetAll();
    }
}
