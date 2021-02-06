using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.ApplitionCore.Models
{
    /// <summary>
    /// Nhân viên
    /// CreatedBy: DMThanh (01/02/2021)
    /// </summary>
    public class Employee
    {
        #region Constructor

        #endregion

        #region Method

        #endregion

        #region Property
        /// <summary>
        /// Khoá chính
        /// </summary>
        public Guid EmployeeId { get; set; }
        /// <summary>
        /// Mã nhân viên
        /// </summary>
        public string EmployeeCode { get; set; }
        /// <summary>
        /// Họ và tên
        /// </summary>
        public string FullName { get; set; }
        /// <summary>
        /// Giới tính
        /// </summary>
        public int Gender { get; set; }
        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime DateOfBirth { get; set; }
        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string PhoneNumber { get; set; }
        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// Số chứng minh nhân dân
        /// </summary>
        public string IdentityNumber { get; set; }
        /// <summary>
        /// Ngày cấp
        /// </summary>
        public DateTime IdentityDate { get; set; }
        /// <summary>
        /// Nơi cấp
        /// </summary>
        public string IdentityPlace { get; set; }
        /// <summary>
        /// Ngày gia nhập
        /// </summary>
        public DateTime JoinDate { get; set; }
        /// <summary>
        /// Mã số thuế
        /// </summary>
        public string PersonalTaxCode { get; set; }
        /// <summary>
        /// Tiền lương
        /// </summary>
        public double Salary { get; set; }
        /// <summary>
        /// Khoá ngoài Vị trí
        /// </summary>
        public Guid PositionId { get; set; }
        /// <summary>
        /// Khoá ngoài Phòng ban
        /// </summary>
        public Guid DepartmentId { get; set; }
        /// <summary>
        /// Tình trạng làm việc
        /// </summary>
        public string WorkStatusName { get; set; }
        #endregion

        #region Other

        #endregion
    }
}
