using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class AccountManager : IAccountService
    {
        IAccountDal _accountDal;

        public AccountManager(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }
        public List<Account> GetAll()
        {
            return _accountDal.GetAll();
        } 

        public Account Get(Account entity)
        {
            return _accountDal.Get(p=>p.Id == entity.Id);
        }

        public bool Add(Account entity)
        {
            return _accountDal.Add(entity);
        }

        public bool Update(Account entity)
        {
            return _accountDal.Update(entity);
        }

        public bool Delete(Account entity)
        {
            return _accountDal.Delete(entity);
        }

        public Account getByUserName(Account account)
        {
            return _accountDal.Get(p => p.UserName == account.UserName);
        }
    }
}
