using System.ComponentModel.DataAnnotations;
namespace TaskMedicin.Models
{
    public class Catg
    {
        [Key]
        public int Id { get; set; }

        public string cName { get; set; }

    }
}
