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
        public string DevMsg { get; set; }
        public string UserMsg { get; set; }
        public string ErrorCode { get; set; }
        public string MoreInfo { get; set; }
        public string TraceId { get; set; }
    }
}
