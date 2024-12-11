

using Shop.data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.data.Entities
{
    [Table("Employees")]
    public class Employee : Person
    {
        [Key]
        public int EmpId { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public int? MgrId { get; set; }
    }
}
