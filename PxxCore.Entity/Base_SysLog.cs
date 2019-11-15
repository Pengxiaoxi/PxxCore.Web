using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PxxCore.Entity
{
    [Table("Base_SysLog")]
    public class Base_SysLog : BaseEntity
    {
        #region 获取/设置 字段值
        /// <summary>
        /// 日志主键
        /// </summary>
        /// <returns></returns>
        [Key]
        public string SysLogId { get; set; }
        /// <summary>
        /// 对象主键
        /// </summary>
        /// <returns></returns>

        [MaxLength(32)]
        public string ObjectId { get; set; }
        /// <summary>
        /// 日志类型
        /// </summary>
        /// <returns></returns>
        [MaxLength(2)]
        public string LogType { get; set; }
        /// <summary>
        /// 操作IP
        /// </summary>
        /// <returns></returns>
        [MaxLength(32)]
        public string IPAddress { get; set; }
        /// <summary>
        /// IP地址所在地址
        /// </summary>
        /// <returns></returns>
        [MaxLength(32)]
        public string IPAddressName { get; set; }
        /// <summary>
        /// 工厂主键
        /// </summary>
        /// <returns></returns>
        [MaxLength(32)]
        public string CompanyId { get; set; }
        /// <summary>
        /// 车间主键
        /// </summary>
        /// <returns></returns>
        [MaxLength(32)]
        public string DepartmentId { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        /// <returns></returns>
        [MaxLength(32)]
        public DateTime? CreateDate { get; set; }
        /// <summary>
        /// 创建用户主键
        /// </summary>
        /// <returns></returns>
        [MaxLength(32)]
        public string CreateUserId { get; set; }
        /// <summary>
        /// 创建用户
        /// </summary>
        /// <returns></returns>
        [MaxLength(32)]
        public string CreateUserName { get; set; }
        /// <summary>
        /// 模块主键
        /// </summary>
        /// <returns></returns>
        [MaxLength(32)]
        public string ModuleId { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        /// <returns></returns>
        [MaxLength(32)]
        public string Remark { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        /// <returns></returns>
        [MaxLength(32)]
        public string Status { get; set; }
        #endregion


        #region override Create\Modify
        public override void Create()
        {
            this.CreateDate = DateTime.Now;
        }

        public override void Modify(string KeyValue)
        {

        }
        #endregion
    }
}
