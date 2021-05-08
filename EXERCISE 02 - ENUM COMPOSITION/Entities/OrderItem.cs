using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXERCISE_02___ENUM_COMPOSITION.Entities.Enums;
namespace EXERCISE_02___ENUM_COMPOSITION.Entities {
    //------------------------------- START -------------------------------//
    class OrderItem {
        public  int Quantity { get; set; }
        public double Price { get; set; }
        public Product Product { get; set; }
    //------------------------------- CONST -------------------------------//     
        public OrderItem() { }

        public OrderItem(int quantity, double price, Product product) {
            Quantity = quantity;
            Price = price;
            Product = product;
        }
    //------------------------------- MET -------------------------------//
        public double SubTotal() {
            return Price * Quantity;
        }
        public override string ToString() {
            return Product.Name + ", $" + Price.ToString("F2") + ", Quantity: " + Quantity + ", Subtotal: $" + SubTotal().ToString("F2");
        }
    }
    //-------------------------------- END -------------------------------//
}
