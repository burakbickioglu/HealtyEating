using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.Dto_s;

namespace DataAccess.Abstract
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<DietitianDto> GetDietitianDetail();
    }
}
