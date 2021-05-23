using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class EfDietCalendarDal : EfRepositoryBase<DietCalendar, HealtyEatingContext>, IDietCalendarDal
    {
    }
}
