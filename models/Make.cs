using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace Vehicle_management.models
{
    public class Make
    {
        public int Id { get; set; }  
        [Required]
           [StringLength(255)]
        public string name { get; set; }

        public ICollection<Model>  models { get; set; }

        public Make ()
        {
            models=new Collection<Model>();
            
        }
    }
}