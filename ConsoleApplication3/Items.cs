using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public class Items
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public string Description { get; set; }
        public string PlaceOfID { get; set; }
        public string Area { get; set; }
        public string Category { get; set; }
        public Items (string name, int iD, string description, string placeOfID, string area, string category)
        {
            Name = name;
            ID = iD;
            Description = description;
            PlaceOfID = placeOfID;
            Area = area;
            Category = category;

        }


    }
}
