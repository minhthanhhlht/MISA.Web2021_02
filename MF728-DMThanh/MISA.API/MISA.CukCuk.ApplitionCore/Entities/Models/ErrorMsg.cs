using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.ApplitionCore.Models
{
    public class ErrorMsg
    {
        /// <summary>
        /// Thông báo lỗi
        /// CreatedBy: DMThanh (01/02/2021)
        /// </summary>

        #region ErrorMsg
        /// <summary>
        /// Thông báo cho Dev
        /// </summary>
        public string DevMsg { get; set; }
        /// <summary>
        /// Thông báo cho người dùng
        /// </summary>
        public string UserMsg { get; set; }
        /// <summary>
        /// Mã lỗi
        /// </summary>
        public string ErrorCode { get; set; }
        /// <summary>
        /// Thông tin thêm
        /// </summary>
        public string MoreInfo { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string TraceId { get; set; }
        #endregion
    }
    
}
