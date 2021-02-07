using MISA.CukCuk.ApplitionCore.Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.CukCuk.ApplitionCore.Interfaces
{
    public interface IBaseService<T>
    {
        #region Get
        /// <summary>
        /// Lấy ra tất cả bản ghi
        /// </summary>
        /// <returns></returns>
        /// CreatedBy: DMThanh (06/02/2021)
        ServiceResult GetEntities();
        #endregion

        #region Insert
        #endregion

        #region Update
        #endregion
         
        #region Delete
        #endregion
    }
}
