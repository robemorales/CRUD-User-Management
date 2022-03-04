using CRUD_USER_MANAGEMENT.Context;
using CRUD_USER_MANAGEMENT.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CRUD_USER_MANAGEMENT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : Controller
    {
        //HERE I CATCH THE CONTEXT AND I INITIALISE IN CONTRUCTOR
        private readonly APPDBContext context;
        public ManagerController(APPDBContext context)
        {
                this.context = context;
        }
        //The GET methods will help us obtain one or more resources from our database
        //with the difference that the first will return all existing resources and
        //the second will return only a specific one
        // GET: api/<ManagerController>
        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok(context.user_table.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
            
        }

        // GET api/<ManagerController>/5
        [HttpGet("{id}",Name ="GetUser")]
        public ActionResult Get(int id)
        {
            try
            {
                //LINQ USE
                var user = context.user_table.FirstOrDefault(g => g.id == id);
                return Ok(user);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
               

        }
        //The post method will help us to add a new resource
        // POST api/<ManagerController>
        [HttpPost]
        public ActionResult Post([FromBody]manager user)
        {
            try
            {
                context.user_table.Add(user);
                context.SaveChanges();
                return CreatedAtRoute("GetUser", new { id = user.id }, user);   

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
        //The PUT method will allow us to update or modify an existing element
        // PUT api/<ManagerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] manager user)
        {
            try
            {
                context.Entry(user).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return CreatedAtRoute("GetUser", new { id = user.id }, user);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
        //Delete an element from the database through its id
        // DELETE api/<ManagerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var user = context.user_table.FirstOrDefault(g => g.id == id);
                if (user != null) 
                {
                    context.user_table.Remove(user);
                    context.SaveChanges();
                    return Ok(id);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }
        }
    }
}
