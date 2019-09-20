using System;
using System.Collections.Generic;
using System.Text;

namespace PxxCore.Entity
{
    class Base_User
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Sex { get; set; }

        public string Password { get; set; }

        public string Age { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime UpdateDate { get; set; }
    }
}
