using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using Entities.Dto_s;

namespace Business.Abstract
{
    public interface IUserService : IBaseService<User>
    {
        List<DietitianDto> GetDietitianDetail();
    } 
}
 