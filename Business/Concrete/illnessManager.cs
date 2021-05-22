using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class illnessManager : IillnessService
    {
        IillnesDal _illnesDal;

        public illnessManager(IillnesDal illnesDal)
        {
            _illnesDal = illnesDal;
        }
        public List<illness> GetAll()
        {
            return _illnesDal.GetAll();
        }

        public illness Get(illness entity)
        {
            return _illnesDal.Get(p => p.illnessid == entity.illnessid);
        }

        public bool Add(illness entity)
        {
            return _illnesDal.Add(entity);
        }

        public bool Update(illness entity)
        {
            return _illnesDal.Update(entity);
        } 

        public bool Delete(illness entity)
        {
            return _illnesDal.Delete(entity);
        }
    }
}
