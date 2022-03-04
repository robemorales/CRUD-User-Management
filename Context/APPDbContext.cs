using CRUD_USER_MANAGEMENT.Models;
using Microsoft.EntityFrameworkCore;
namespace CRUD_USER_MANAGEMENT.Context
{
    public class APPDBContext :DbContext          
    {
        //HERE I WILL REPRESENT THE TABLE IN THE DATABASE
        //
        public APPDBContext(DbContextOptions<APPDBContext> options): base(options)
        {

        }
        //NOW I REPRESENT THE TABLE OF MY DATABASE
        //INSIDE THE DbSet METHOD I WILL INSERT THE NAME OF MY MODEL IN THIS CASE "manager"
        //IMPORTANT NAME OF THE  TABLE IN THE DATABASE MUST MATCH THE NAME OF THE METHOD 

        public DbSet<manager> user_table  { get; set; }
    }
}
