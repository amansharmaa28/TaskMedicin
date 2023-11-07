using System.ComponentModel.DataAnnotations;

namespace TaskMedicin.Models
{
    public class Medicin
    {

        [Key]
        public int? MedicinId { get; set; }
        public string? MedicinName { get; set; }

        public string MedicinPrice { get; set; }


    }
}
