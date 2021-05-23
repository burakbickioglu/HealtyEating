using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Abstract;
using Entities.Concrete;
using Entities.Dto_s;

namespace DataAccess.Concrete
{
    public class EfPatientDal : EfRepositoryBase<Patient, HealtyEatingContext>, IPatientDal
    {
        
        public PatientToDietDto GetPatientToDietDto(int id)
        {
            using (HealtyEatingContext context = new HealtyEatingContext())
            {
                var result = from user in context.tblUsers
                    join patient in context.tblPatients on user.Id equals patient.Id
                    join diet in context.tblDiets on patient.DietId equals diet.DietId
                    join dietCalendar in context.tblDietCalendar on diet.DietId equals dietCalendar.DietId
                    where patient.Id == id
                    select new PatientToDietDto
                    {
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        NationalIdentity = user.NationalIdentity,
                        Email = user.Email,
                        PhoneNumber = user.PhoneNumber,
                        PatientDescription = patient.PatientDescription,
                        DietName = diet.DietName,
                        Pazartesi = dietCalendar.Pazartesi,
                        Sali = dietCalendar.Sali,
                        Carsamba = dietCalendar.Carsamba,
                        Persembe = dietCalendar.Persembe,
                        Cuma = dietCalendar.Cuma,
                        Cumartesi = dietCalendar.Cumartesi,
                        Pazar = dietCalendar.Pazar
                    };
                return result.SingleOrDefault();
            }
        }

        public DietToPatientDto GetDietToPatientDto(int id)
        {
            using (HealtyEatingContext context = new HealtyEatingContext())
            {
                var result = from user in context.tblUsers
                    join patient in context.tblPatients on user.Id equals patient.Id
                    join diet in context.tblDiets on patient.DietId equals diet.DietId
                    join dietCalendar in context.tblDietCalendar on diet.DietId equals dietCalendar.DietId
                    where patient.Id == id
                    select new DietToPatientDto
                    {
                        DietName = diet.DietName,
                        Pazartesi = dietCalendar.Pazartesi,
                        Sali = dietCalendar.Sali,
                        Carsamba = dietCalendar.Carsamba,
                        Persembe = dietCalendar.Persembe,
                        Cuma = dietCalendar.Cuma,
                        Cumartesi = dietCalendar.Cumartesi,
                        Pazar = dietCalendar.Pazar,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        NationalIdentity = user.NationalIdentity,
                        Email = user.Email,
                        PhoneNumber = user.PhoneNumber,
                        PatientDescription = patient.PatientDescription
                    };
                return result.SingleOrDefault();
            }



        }
    }
}
