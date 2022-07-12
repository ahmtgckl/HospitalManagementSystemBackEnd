
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfAppointmentDal : EfEntityRepositoryBase<Appointment, HospitalContext>, IAppointmentDal
    {
        public List<AppointmentDetailDto> GetAppointmentDetails()
        {
            using (HospitalContext context = new HospitalContext())
            {
                var result = from a in context.Appointments
                             join d in context.Doctors
                             on a.DoctorId equals d.Id
                             join p in context.Patients
                             on a.PatientId equals p.Id

                             select new AppointmentDetailDto
                             {
                                 Id = a.Id,
                                 DoctorId = d.Id,
                                 PatientId = p.Id,
                                 AppointmentDate = a.AppointmentDate,
                                 DoctorFirstName = d.DoctorFirstName,
                                 DoctorLastName = d.DoctorLastName,
                                 DoctorAdress = d.DoctorAdress,
                                 DoctorPhoheNumber = d.DoctorPhoheNumber,
                                 PatientFirstName = p.PatientFirstName,
                                 PatientLastName = p.PatientLastName,
                                 PatientInsurance = p.PatientInsurance,
                                 PatientAdress = p.PatientAdress,
                                 PatientPhoheNumber = p.PatientPhoneNumber
                             };
                return result.ToList();
            }
        }
    }
}
