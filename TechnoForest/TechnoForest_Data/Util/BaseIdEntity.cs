using System;
using System.ComponentModel.DataAnnotations;

namespace TechnoForest_Data.Util
{
    public class BaseIdEntity
    {
        [Key]
        public string Id { get; set; } 

        public bool IsBought { get; set; }
    }
}