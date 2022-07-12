using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class AppointmentDetailDto : IDto
    {
        public int Id { get; set; }
        public int DoctorId { get; set; }
        public int PatientId { get; set; }
        public DateTime AppointmentDate { get; set; }


        public string DoctorFirstName { get; set; }
        public string DoctorLastName { get; set; }
        public string DoctorAdress { get; set; }
        public string DoctorPhoheNumber { get; set; }


        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string PatientInsurance { get; set; }
        public string PatientAdress { get; set; }
        public string PatientPhoheNumber { get; set; }
    }
}
