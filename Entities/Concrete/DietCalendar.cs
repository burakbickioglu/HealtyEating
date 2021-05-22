using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class DietCalendar : IEntity
    {
        [Key]
        public int DietId { get; set; }
        public string Pazartesi { get; set; }
        public string Sali { get; set; }
        public string Carsamba { get; set; }
        public string Persembe { get; set; }
        public string Cuma { get; set; }
        public string Cumartesi { get; set; }
        public string Pazar { get; set; }

    }
}
