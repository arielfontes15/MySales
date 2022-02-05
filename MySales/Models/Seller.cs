using System;

namespace MySales.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime? BithDate { get; set; }
        public double BaseSalary { get; set; }
    }
}
