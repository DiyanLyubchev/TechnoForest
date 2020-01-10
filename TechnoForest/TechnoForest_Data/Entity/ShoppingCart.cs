using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TechnoForest_Data.Util;

namespace TechnoForest_Data.Entity
{
    public class ShoppingCart : BaseIdEntity
    {
        [ForeignKey("User")]
        public string UserId { get; set; }

        public User User { get; set; }

        [ForeignKey("TV")]
        public int? TVsId { get; set; }

        public virtual TV TVs { get; set; }

        [ForeignKey("WashingMachine")]
        public int? WashingMachineId  { get; set; }

        public virtual WashingMachine WashingMachines { get; set; }

        [ForeignKey("MobilePhone")]
        public int? MobilePhoneId  { get; set; }

        public virtual MobilePhone MobilePhones { get; set; }

        public decimal? TotalPrice { get; set; }

        public DateTime? AddTOCart { get; set; }
       
    }
}
