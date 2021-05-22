using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Dto_s
{
    public class DietitianDto : IDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalIdentity { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }


    }
}
