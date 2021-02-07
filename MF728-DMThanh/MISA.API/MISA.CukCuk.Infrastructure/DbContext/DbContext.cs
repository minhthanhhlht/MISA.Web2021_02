using Dapper;
using MISA.CukCuk.ApplitionCore.Interfaces.DbContext;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MISA.CukCuk.Infrastructure.DbContext
{   /// <summary>
    /// Lớp tương tác với Database
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// CreatesBy: DMThanh (06/02/2021)
    public class DbContext<T> : IDatabaseContext<T>
    {
        
        #region Declare

        /// <summary>
        /// Khởi tạo đối tượng tương tác 
        /// </summary>
        IDbConnection _dbConnection;
        /// <summary>
        /// Khởi tạo tên lớp
        /// </summary>
        string className;

        #endregion

        #region Constructor
        /// <summary>
        /// Khởi tạo kết nối
        /// </summary>
        /// <param name="dbConnection"></param>
        public DbContext(IDbConnection dbConnection)
        {
            _dbConnection = dbConnection ?? throw new ArgumentNullException(nameof(MySqlConnection));
            className = typeof(T).Name;
        }
        #endregion

        #region Method
        /// <summary>
        /// Lấy dữ liệu
        /// </summary>
        /// <typeparam name="T">Type của object</typeparam>
        /// <param name="sqlcommand">Tên Store hoặc mã Sql</param>
        /// <param name="parameters">Đối tượng chưa thông tin tham số  Store</param>
        /// <param name="commandType">Mặc định là CommandType.Text</param>
        /// <returns></returns>
        /// CreatedBy: DMThanh (06/02/2021)
        public IEnumerable<T> GetData(string sqlcommand = null, object parameters = null, CommandType commandType = CommandType.Text)
        {
            var className = typeof(T).Name;
            if (sqlcommand == null)
            {
                sqlcommand = $"Select * from {className}";
            }
            //Lấy dữ liệu
            var data =  _dbConnection.Query<T>(sqlcommand, param: parameters, commandType: commandType);
            return data;
        }
       
        public int Insert(T entity)
        {
            var sqlPropName = string.Empty;
            var sqlPropValue = string.Empty;
            var className = typeof(T).Name;
            var sqlCommand = string.Empty;
            //Lấy ra các property cảu object
            var properties = typeof(T).GetProperties();
            //Duyệt từng Property - lấy tên và giá trị của property
                //Tên đặt là tên param trong câu truy vấn sql
                //Value sẽ gán là giá trị của param tương ứng trong câu lệnh SQL
            foreach(var property in properties)
            {
                var propName = property.Name;
                var propValue = property.GetValue(entity);
                sqlPropName = sqlPropName + $",{ propName}";
                if (property.PropertyType == typeof(Guid) || property.PropertyType == typeof(string))
                {
                    if (propName.ToLower() == $"{className}Id".ToLower())
                        sqlPropValue = sqlPropValue + $",'{Guid.NewGuid()}'";
                    else
                        sqlPropValue = sqlPropValue + $",'{propValue}'";
                }
                else if (property.PropertyType == typeof(Guid?)) 
                {
                    if (propValue == null)
                        sqlPropValue = sqlPropValue + $",NULL";
                    else
                        sqlPropValue = sqlPropValue + $",'{propValue}'";
                }
                else if (property.PropertyType==typeof(DateTime)||property.PropertyType==typeof(DateTime?))
                {
                    var dateTime = (DateTime)propValue;
                    string dateTimeString = dateTime.ToString("yyyy-MM-dd hh:mm:ss");
                    sqlPropValue = sqlPropValue + $",'{dateTimeString}'";
                }
                else
                {
                    sqlPropValue = sqlPropValue + $",{propValue}";
                }
            }
            sqlPropName = sqlPropName.Remove(0, 1);
            sqlPropValue = sqlPropValue.Remove(0, 1);

            sqlCommand = $"INSERT INTO {className} ({sqlPropName}) VALUE ({sqlPropValue})";

            var res = _dbConnection.Execute(sqlCommand, commandType: CommandType.Text);
            return res;
        }
        #endregion
    }
}
