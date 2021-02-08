﻿using CukCuk.Common.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CukCuk.DataLayer.Interfaces
{
    /// <summary>
    /// Interface khách hàng
    /// </summary>
    public interface ICustomerDL:IDbConnector<Customer>
    {
    }
}
