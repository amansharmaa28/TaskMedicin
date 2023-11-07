using System.ComponentModel.DataAnnotations;

namespace TaskMedicin.Models
{
    public class Customer
    {
        [Key]
        public int CId { get; set; }

        public string? Name { get; set; }

        public int? Age { get; set;}

        public string doctorname { get; set; }  

        public string? DateOfBirth { get; set; }

        public string? Problem { get; set; }



    }
}
