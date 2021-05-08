using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EXERCISE_02___ENUM_COMPOSITION.Entities.Enums;
namespace EXERCISE_02___ENUM_COMPOSITION.Entities {
    //------------------------------- START -------------------------------//
    class Client {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
    //------------------------------- CONST -------------------------------//        
        public Client() { }
        public Client(string name, string email, DateTime birthDate) {
            Name = name;
            Email = email;
            BirthDate = birthDate;
        }
    //------------------------------- MET -------------------------------//
        public override string ToString() {
            return Name + ", (" + BirthDate.ToString("dd/MM/yyyy") + ") -" + Email;
        }
    }
    //-------------------------------- END -------------------------------//
}
