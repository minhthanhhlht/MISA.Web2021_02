using Microsoft.AspNetCore.Mvc;
using MISA.CukCuk.ApplitionCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;



// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MISA.CukCuk.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class BaseController<T> : ControllerBase
    {
        #region Declare
        IBaseService<T> _baseService;
        #endregion

        #region Method
        
        #endregion


    }
}
