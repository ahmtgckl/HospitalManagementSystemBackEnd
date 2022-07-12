using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDoctorService
    {
        IResult Add(Doctor doctor); 
        IResult Update(Doctor doctor);
        IResult Delete(Doctor doctor);

        IDataResult<List<Doctor>> GetAll();
    }
}
