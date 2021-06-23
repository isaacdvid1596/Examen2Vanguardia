using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hotel.Rates.Data;
using Hotel.Rates.Data.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Hotel.Rates.Api.Controllers
{
    public class BaseApiController : ControllerBase
    {
        public IActionResult GetResult<T>(ServiceResult<T> result)
        {
            return result.ResponseCode switch
            {
                ResponseCode.Success => Ok(result.Result),
                ResponseCode.Error => BadRequest(result.Error),
                ResponseCode.InternalServerError => StatusCode(500, result.Error),
                ResponseCode.NotFound => NotFound(result.Error),
                _ => throw new ArgumentOutOfRangeException()
            };
        }
    }
}
