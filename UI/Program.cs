using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //DoctorTest();
            //DoctorAll();
            //PatientAdd();
            //AppointmenAdd();

            PatientManager patientManager = new PatientManager(new EfPatientDal());
            patientManager.GetAll();
            foreach (var patient in patientManager.GetAll().Data)
            {
                Console.WriteLine(patient.Id + " " + patient.PatientFirstName + "  " + patient.PatientLastName + "  " + patient.PatientInsurance + " " + patient.PatientPhoneNumber);
            }
        }

        private static void AppointmenAdd()
        {
            AppointmentManager appointmentManager = new AppointmentManager(new EfAppointmentDal());
            appointmentManager.Add(new Appointment
            {
                
                DoctorId=4,
                PatientId=2,
                AppointmentDate= new DateTime(2008, 3, 1, 7, 0, 0) //DateTime.Now

            });

            foreach (var appointment in appointmentManager.GetAppointmentDetails().Data)
            {
                Console.WriteLine(appointment.Id+" "+appointment.PatientFirstName+" "+appointment.PatientLastName+" "+appointment.PatientInsurance+" "+appointment.DoctorFirstName+" "+appointment.DoctorLastName);
            }



        }

        private static void PatientAdd()
        {
            PatientManager patientManager = new PatientManager(new EfPatientDal());
            patientManager.GetAll();
            foreach (var patient in patientManager.GetAll().Data)
            {
                Console.WriteLine(patient.Id + " " + patient.PatientFirstName + "  " + patient.PatientLastName + "  " + patient.PatientInsurance + " " + patient.PatientPhoneNumber);
            }
        }

        private static void DoctorAll()
        {
            DoctorManager doctorManager = new DoctorManager(new EfDoctorDal());
            doctorManager.GetAll();

            foreach (var doctor in doctorManager.GetAll().Data)
            {
                Console.WriteLine(doctor.DoctorFirstName + " " + doctor.DoctorLastName);
            }
        }

        private static void DoctorTest()
        {
            DoctorManager doctorManager = new DoctorManager(new EfDoctorDal());
            doctorManager.Add(new Doctor
            {

                DoctorFirstName = "Osman",
                DoctorLastName = "Oyan",
                DoctorAdress = "Karaköprü",
                DoctorPhoheNumber = "05392595000"
            });

            foreach (var doctor in doctorManager.GetAll().Data)
            {
                Console.WriteLine(doctor.Id+"  "+ doctor.DoctorFirstName + " "+ doctor.DoctorLastName + "  "+doctor.DoctorAdress + " "+doctor.DoctorPhoheNumber);
            }
        }
    }
}
