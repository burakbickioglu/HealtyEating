using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class DietManager : IDietService
    {
        IDietDal _dietDal;

        public DietManager(IDietDal dietDal)
        {
            _dietDal = dietDal;
        }
        public List<Diet> GetAll()
        {
            return _dietDal.GetAll();
        }

        public Diet Get(Diet entity)
        {
            return _dietDal.Get(p => p.DietId == entity.DietId);
        }

        public bool Add(Diet entity)
        {
            return _dietDal.Add(entity);
        }

        public bool Update(Diet entity)
        {
            return _dietDal.Update(entity);
        }

        public bool Delete(Diet entity)
        {
            return _dietDal.Delete(entity);
        }
    }
}
