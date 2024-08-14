using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Person
    {
        private string _name;
        public string Name {
            get {
                return _name;
            }

            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Name can't be empty!");
                }
                _name = value;
            }
        }

        private int _age;
        public int Age {
            get {
                return _age;
            }

            set {
                if (int.IsNegative(value) || value == 0) {
                    throw new ArgumentException("Age can't be negative or zero!");
                } else if (value < 18) {
                    throw new ArgumentException("Age can't be under 18!");
                }
                _age = value;
            }
        }

        public void Show() {
            Console.WriteLine("");
        }
    }
}
