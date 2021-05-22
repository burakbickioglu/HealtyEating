using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto_s;

namespace DataAccess.Concrete
{
    public class EfUserDal : EfRepositoryBase<User, HealtyEatingContext> , IUserDal
    {
        public List<DietitianDto> GetDietitianDetail()
        {
            using (HealtyEatingContext context = new HealtyEatingContext())
            {
                var result = from user in context.tblUsers
                    join account in context.TblAccounts on user.Id equals account.Id
                    join usertype in context.tblUserTypes on account.UserTypeId equals usertype.UserTypeId
                    where usertype.UserTypeName == "Diyetisyen"
                    select new DietitianDto
                    {
                        Id = user.Id,
                        FirstName = user.FirstName,
                        LastName = user.LastName,
                        NationalIdentity = user.NationalIdentity,
                        Email = user.Email,
                        PhoneNumber = user.PhoneNumber,
                    };
                return result.ToList();
            }

        }
    }
}
