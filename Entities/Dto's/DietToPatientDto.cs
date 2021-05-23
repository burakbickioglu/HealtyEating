using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Dto_s
{
    public class DietToPatientDto : IDto
    {
        public string DietName { get; set; }
        public string Pazartesi { get; set; }
        public string Sali { get; set; }
        public string Carsamba { get; set; }
        public string Persembe { get; set; }
        public string Cuma { get; set; }
        public string Cumartesi { get; set; }
        public string Pazar { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PatientDescription { get; set; }
        
    }
}
