using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserTypeManager : IUserTypeService
    {
        IUserTypeDal _userTypeDal;

        public UserTypeManager(IUserTypeDal userTypeDal)
        {
            _userTypeDal = userTypeDal;
        }

        public List<UserType> GetAll()
        {
            return _userTypeDal.GetAll();
        }

        public UserType Get(UserType entity)
        {
            return _userTypeDal.Get(p => p.UserTypeId == entity.UserTypeId);
        }

        public bool Add(UserType entity)
        {
            return _userTypeDal.Add(entity);
        }

        public bool Update(UserType entity)
        {
            return _userTypeDal.Update(entity);
        }

        public bool Delete(UserType entity)
        {
            return _userTypeDal.Delete(entity);
        }
    }
}
