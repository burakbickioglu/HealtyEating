using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class DietCalendarManager : IDietCalendarService
    {
        IDietCalendarDal _dietCalendarDal;

        public DietCalendarManager(IDietCalendarDal dietCalendarDal)
        {
            _dietCalendarDal = dietCalendarDal;
        }
        public List<DietCalendar> GetAll()
        {
            return _dietCalendarDal.GetAll();
        }

        public DietCalendar Get(DietCalendar entity)
        {
            return _dietCalendarDal.Get(p => p.DietId == entity.DietId);
        }

        public bool Add(DietCalendar entity)
        {
            return _dietCalendarDal.Add(entity);
        }

        public bool Update(DietCalendar entity)
        {
            return _dietCalendarDal.Update(entity);
        }

        public bool Delete(DietCalendar entity)
        {
            return _dietCalendarDal.Delete(entity);
        }
    }
}
