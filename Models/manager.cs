using System.ComponentModel.DataAnnotations;

namespace CRUD_USER_MANAGEMENT.Models
{
    public class manager
    {
        // I DECLARE THAT ID IS THE PRIMARY KEY
        //AFTER THAT I REPRESENT ALL THE ATTRIBUTES IN DATABASE WITH THE SAME NAME AS I WROTE THEM
        [Key]  
        public int id { get; set; }

        public string name { get; set; }

        public string last { get; set; }

        public string address { get; set; }

        public string phone { get; set; }

    }
}
