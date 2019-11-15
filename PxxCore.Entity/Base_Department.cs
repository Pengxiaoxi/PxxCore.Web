using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PxxCore.Entity
{
    [Table("Base_Department")]
    public class Base_Department : BaseEntity
    {
        #region Property
        /// <summary>
        /// ID
        /// </summary>
        [Key] //特性|数据注释
        public int ID { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [MaxLength(32)]
        public string Name { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [MaxLength(2)]
        public string Sex { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required] //必需属性
        [MaxLength(50)]
        public string Password { get; set; }

        /// <summary>
        /// 年龄
        /// </summary>
        public int? Age { get; set; }

        /// <summary>
        /// 创建日期
        /// </summary>
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 修改日期
        /// </summary>
        public DateTime ModifyDate { get; set; }

        /// <summary>
        /// 添加人
        /// </summary>
        [MaxLength(32)]
        public string AddBy { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        [MaxLength(32)]
        public string ModifyBy { get; set; }

        #endregion

        #region override Create\Modify
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
