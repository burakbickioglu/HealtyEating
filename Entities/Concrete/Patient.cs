using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Patient : IEntity
    {
        public int Id { get; set; } 
        public int illnessid { get; set; }
        public int DietId { get; set; }

        public string PatientDescription { get; set; }

    }
}
