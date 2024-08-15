using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Models
{
    public class Course
    {
        public Course(string name, List<Person> students){
            Name = name;
            Students = students;
        }

        public string Name { get; set; }

        //propriedade como coleção: uma lista composta de objetos.
        public List<Person> Students { get; set; }

        public void AddPerson(Person student) {
            Students.Add(student);
        }

        public bool RemovePerson(Person student) {
            return Students.Remove(student);
        }

        public int GetNumberStudents() {
            return Students.Count;
        }

        public void ListStudents() {
            for (int i=0; i<=Students.Count; i++) {
                //interporlação de strings:
                Console.WriteLine($"Students of {Name} Course:\nN°{i+1} → {Students[i].CompleteName}");
            }
        }

    }
}