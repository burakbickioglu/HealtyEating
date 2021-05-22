using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Diet : IEntity
    {
        public int DietId { get; set; }
        public string DietName { get; set; } 

    }
}
