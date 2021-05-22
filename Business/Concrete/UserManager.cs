using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dto_s;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public User Get(User entity)
        {
            return _userDal.Get(p => p.Id == entity.Id);
        }

        public bool Add(User entity)
        {
            return _userDal.Add(entity);
        }

        public bool Update(User entity)
        {
            return _userDal.Update(entity);
        }

        public bool Delete(User entity) 
        {
            return _userDal.Delete(entity);
        }

        public List<DietitianDto> GetDietitianDetail()
        {
            return _userDal.GetDietitianDetail();
        }
    }
}
