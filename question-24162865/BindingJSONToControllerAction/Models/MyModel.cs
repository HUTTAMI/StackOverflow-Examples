using System;

namespace BindingJSONToControllerAction.Models
{
    public class MyModel
    {
        public Int32? ID { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public String Name { get; set; }
        public String Status { get; set; }
    }
}