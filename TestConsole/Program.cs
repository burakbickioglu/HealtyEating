using System;
using Business.Concrete;
using DataAccess.Concrete;
using Entities.Concrete;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        { 
           PatientManager patientManager = new PatientManager(new EfPatientDal());
           var result = patientManager.Add(new Patient{DietId = 1, illnessid = 1, Id = 1});
           Console.Write(result.ToString());
        }
    }
}
