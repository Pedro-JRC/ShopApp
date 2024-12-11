

using Shop.data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Shop.data.Entities
{
    [Table("Customers")]
    public class Customer : Person
    {
        [Key]
        public int CustId { get; set; }
        public string ContactTitle { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Fax { get; set; }
    }
}
