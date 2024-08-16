using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Person
    {
        //Construtor:
        public Person(string name, string lastName, int age) {
            Name = name;
            LastName = lastName;
            Age = age;
        }

        //Desconstrutor: separa os valores do objeto em variaveis, um para cada valor informado:
        public void Deconstruct(out string name, out string lastName, out int age) {
            name = Name;
            lastName = LastName;
            age = Age;
        }

        //campo
        private string _name;

        //propriedade
        public string Name {
            //body expression:
            get => _name;

            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Name can't be empty!");
                }
                _name = value;
            }
        }

        private string _lastName;
        public string LastName {
            get => _lastName;

            set {
                if (string.IsNullOrEmpty(value)) {
                    throw new ArgumentException("Name can't be empty!");
                }
                _lastName = value;
            }
        }

        //propriedade somente leitura, pois o set é omitido possuindo apenas get.
        public string CompleteName => $"{Name} {LastName}";

        //campo
        private int _age;

        //propriedade
        public int Age {
            get => _age;

            set {
                if (value <= 0) {
                    throw new ArgumentException("Age can't be negative or zero!");
                } else if (value < 18) {
                    throw new ArgumentException("Age can't be under 18!");
                }
                _age = value;
            }
        }

        //método
        public void Show() {
            Console.WriteLine($"Hi, I'm {CompleteName} and am {Age} years old.");
        }
    }
}
