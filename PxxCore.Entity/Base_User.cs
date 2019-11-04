using System;
using System.Collections.Generic;
using System.Text;

namespace PxxCore.Entity
{
    /// <summary>
    /// 用户实体
    /// </summary>
    public class Base_User : BaseEntity
    {
        #region Property
        /// <summary>
        /// ID
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Name
        /// </summary>
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
