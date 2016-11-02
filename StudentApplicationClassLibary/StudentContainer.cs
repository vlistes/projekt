using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentApplicationClassLibary
{
    public class StudentContainer
    {
        private List<Student> _studentiBaza;

        public StudentContainer()
        {
            _studentiBaza = new List<Student>();
        }
            public void Add(int id, string ime, string prezime, string gpa)
            {
                var gpa_d = Convert.ToDouble(gpa);

                var studentUnos = new Student(id, ime, prezime, gpa_d);

                _studentiBaza.Add(studentUnos);
            }
            public void ShowAll()
            {
                var j = 1;
                var listaStudenata = from student in _studentiBaza
                                     orderby student.Prezime
                                     select student;
                foreach (var student in listaStudenata)
                {
                    Console.WriteLine(" {0}. {1}, {2} - {3:F}", j, student.Prezime, student.Ime, student.Gpa);
                    j = j + 1;
                }
           }
    }
}
