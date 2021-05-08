using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace EXERCISE_02___ENUM_COMPOSITION.Entities.Enums{
    enum  OrderStatus : int {
    //------------------------------- START -------------------------------//
        PendingPeyment = 0,
        Processing = 1,
        Shipped = 2,
        Delivered = 3,
    }
    //-------------------------------- END -------------------------------//
}
