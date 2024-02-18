using CRMSampleApp.Interfaces;
using CRMSampleApp.Models;
using Microsoft.AspNetCore.Mvc;
 

namespace CRMSampleApp.Controllers
{
    public class UserController : Controller
    {
        //private readonly IUserDetails _UserDetails;


        //public UserController(IUserDetails userDetails) { 
        
        //    _UserDetails = userDetails;
        //}
        public IActionResult Index()
        {
            
            return View();
        }

        [HttpPost]
        public Response SaveUserDetails(CRMSampleApp.Models.UserDetails user)
        {
            Response response = new Response();

            try
            {


            }catch (Exception ex)
            {

            }

            return response;
        }

}
}
