using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DataModel
{
    public class Item
    {
        public System.Guid id { get; set; }
        public long sku { get; set; }
        public string name { get; set; }
        public bool isRecipe { get; set; }
        public Category category { get; set; }
    }
}
