using System.ComponentModel.DataAnnotations;
namespace TaskMedicin.Models
{
    public class Doctors
    {
     [Key]
        public int dId { get; set; }

        public string dName { get; set; }

        public string dSpecification { get; set; }
        public string dQualification { get; set; }

        public int categoryId { get; set; }

        public Catg category { get; set; }
    }
}
