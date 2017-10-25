using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Vehicle_management.models
{
    public class Make
    {
        public int Id { get; set; }     
        public string name { get; set; }

        public ICollection<Model>  models { get; set; }

        public Make ()
        {
            models=new Collection<Model>();
            
        }
    }
}