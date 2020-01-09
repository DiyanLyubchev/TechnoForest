using System.ComponentModel.DataAnnotations;

namespace TechnoForest_Data.Util
{
    public class BaseIdEntity
    {
        [Key]
        public int Id { get; set; }
    }
}
