using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXERCISE_02___ENUM_COMPOSITION.Entities.Enums;
namespace EXERCISE_02___ENUM_COMPOSITION.Entities {
    //------------------------------- START -------------------------------//
    class Order {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public Client Client { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        //------------------------------- CONST -------------------------------//
        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client, List<OrderItem> items) {
            Moment = moment;
            Status = status;
            Client = client;
            Items = items;
        }
        //------------------------------- MET -------------------------------//
        public void Additem(OrderItem item) {
            Items.Add(item);
        }
        public void RemoveItem(OrderItem item) {
            Items.Remove(item);
        }
    }
    //-------------------------------- END -------------------------------//
}
