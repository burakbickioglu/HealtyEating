using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.Dto_s;

namespace Business.Abstract
{
    public interface IPatientService : IBaseService<Patient>
    {
        PatientToDietDto GetPatientToDietDto(int id);
        DietToPatientDto GetDietToPatientDto(int id);
    }
}
 