using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.Dto_s;

namespace DataAccess.Abstract
{
    public interface IPatientDal : IEntityRepository<Patient>
    {
        public PatientToDietDto GetPatientToDietDto(int id);
        public DietToPatientDto GetDietToPatientDto(int id);
    } 
}
