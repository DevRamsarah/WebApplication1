using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using System.Net;
using WebApplication1.Auth;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [BasicAuthorization]
    [Route("v1")]
    public class checkController : Controller
    {

        [HttpGet("")]
        public string GetCheck()
        {
            return "I am Alive";
        }
        [HttpGet("check/legal")]
        public ActionResult checklegal(string? name, string? address)
        {
            try
            {
                if (name != null & address != null)
                {
                    return Ok("success");
                }
                else
                {
                    return NotFound("Mandatory field missing");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("check/person")]
        public ActionResult checkperson(string? forename, string? surname, string? date )
        {
            try
            {
                if (forename != null & surname != null & date != null )
                {
                    //String datePickerInput = "31.07.2015";
                    //String format = "dd.MM.yyyy";
                    //DateTime dte = DateTime.ParseExact(date, format, CultureInfo.InvariantCulture);
                    return Ok("success");
                }
                else
                {
                    return NotFound("Mandatory field missing");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
