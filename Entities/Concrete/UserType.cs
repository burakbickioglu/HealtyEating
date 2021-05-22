using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class UserType : IEntity
    {
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }

    }
}
