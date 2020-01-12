using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechnoForest_Data.Entity
{
    public class ShoppingCart 
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }

        public User User { get; set; }

        [ForeignKey("TV")]
        public string TVsId { get; set; }

        public virtual TV TVs { get; set; }

        [ForeignKey("WashingMachine")]
        public string WashingMachineId  { get; set; }

        public virtual WashingMachine WashingMachines { get; set; }

        [ForeignKey("MobilePhone")]
        public string MobilePhoneId  { get; set; } 

        public virtual MobilePhone MobilePhones { get; set; }

        public decimal? TotalPrice { get; set; }

        public DateTime? AddTOCart { get; set; }
       
    }
}
