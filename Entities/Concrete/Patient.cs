using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Patient : IEntity
    {
        public int Id { get; set; }
        public string PatientFirstName { get; set; }
        public string PatientLastName { get; set; }
        public string PatientInsurance { get; set; }
        public string PatientAdress { get; set; }
        public string PatientPhoneNumber { get; set; }
    }
}
