using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto_s;

namespace Business.Concrete
{ 
    public class PatientManager : IPatientService
    {
        IPatientDal _patientDal;

        public PatientManager(IPatientDal patientDal)
        {
            _patientDal = patientDal;
        }
        public List<Patient> GetAll()
        {
            return _patientDal.GetAll();
        }

        public Patient Get(Patient entity)
        {
            return _patientDal.Get(p => p.Id == entity.Id);
        }

        public bool Add(Patient entity)
        {
            return _patientDal.Add(entity);
        }

        public bool Update(Patient entity)
        {
            return _patientDal.Update(entity);
        }

        public bool Delete(Patient entity) 
        {
            return _patientDal.Delete(entity);
        }

        public PatientToDietDto GetPatientToDietDto(int id)
        {
            return _patientDal.GetPatientToDietDto(id);
        }

        public DietToPatientDto GetDietToPatientDto(int id)
        {
            return _patientDal.GetDietToPatientDto(id);
        }
    }
}
