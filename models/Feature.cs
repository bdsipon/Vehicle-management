using System.ComponentModel.DataAnnotations;

namespace Vehicle_management.models
{
    public class Feature
    {
        public int Id{get;set;}
        [Required]
        [StringLength(255)]
        
        public string Name { get; set; }
    }
}