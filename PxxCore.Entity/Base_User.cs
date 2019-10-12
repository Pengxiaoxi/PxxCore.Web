using System;
using System.Collections.Generic;
using System.Text;

namespace PxxCore.Entity
{

    public class Base_User : BaseEntity
    {
        #region Property
        public int ID { get; set; }

        public string Name { get; set; }

        public string Sex { get; set; }

        public string Password { get; set; }

        public string Age { get; set; }

        public DateTime CreateDate { get; set; }

        public DateTime ModifyDate { get; set; }

        public string AddBy { get; set; }

        public string ModifyBy { get; set; }

        #endregion

        #region Create\Modify
        public override void Create()
        {
            this.CreateDate = DateTime.Now;
            this.AddBy = "";
        }

        public override void Modify(string KeyValue)
        {
            this.ModifyDate = DateTime.Now;
            this.ModifyBy = "";
        }
        #endregion
    }
}
