using System.Collections.Generic;
using System.Collections.ObjectModel;


namespace Vehicle_management.Controllers.Resources
{
    public class MakeResource
    {
         public int Id { get; set; }  
    
        public string name { get; set; }

        public ICollection<ModelResouce>  models { get; set; }

        public MakeResource ()
        {
            models=new Collection<ModelResouce>();
            
        }
    }
}