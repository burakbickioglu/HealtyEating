using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class illness : IEntity
    {
        public int illnessid { get; set; }
        public string illnessName { get; set; }
        public string illnessDescription { get; set; }
    }
}
