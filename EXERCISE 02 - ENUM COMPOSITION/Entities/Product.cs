using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXERCISE_02___ENUM_COMPOSITION.Entities.Enums;
namespace EXERCISE_02___ENUM_COMPOSITION.Entities {
    //------------------------------- START -------------------------------//
    class Product {
        public string Name { get; set; }
        public double Price { get; set; }
        //------------------------------- CONST -------------------------------//        
        public Product() { }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }
    }
    //-------------------------------- END -------------------------------//
}
