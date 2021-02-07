using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.CukCuk.ApplitionCore.Entities.Models
{
    public class ServiceResult
    {
        /// <summary>
        /// Trạng thái của Services True= thành công, False= thất bại
        /// </summary>
        public bool Succes { get; set; }

        /// <summary>
        /// Dữ liệu trả về cho client
        /// </summary>
        public object Data { get; set; }

        /// <summary>
        /// Mã code 
        /// </summary>
        public string MISACODE { get; set; }
    }
}
