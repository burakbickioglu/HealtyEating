using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Patient : IEntity
    {
        public int Id { get; set; }
        public int illnesid { get; set; }
        public int DietId { get; set; }
       

    }
}
