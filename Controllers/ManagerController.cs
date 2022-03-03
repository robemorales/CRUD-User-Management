using CRUD_USER_MANAGEMENT.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD_USER_MANAGEMENT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        //IMPORT THE CONTEXT
        private readonly APP_DBContext context;

        public ManagerController(APP_DBContext context)
        {
            this.context = context;
        }
        //NOW I CAN START WITH THE REQUESTS
        [HttpGet]
        public IActionResult Get() =>
            Ok(context.user_table.ToList());
        //MAKE OTHER METHOD!!!!!!!!!!
    }
}
