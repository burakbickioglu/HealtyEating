using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Account : IEntity
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int UserTypeId { get; set; }

    }
}
