using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAppointmentService
    {
        IResult Add(Appointment appointment);
        IResult Update(Appointment appointment);
        IResult Delete(Appointment appointment);


        IDataResult<List<Appointment>> GetAll();
        IDataResult<List<AppointmentDetailDto>> GetAppointmentDetails();
        
    }
}
