using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentApplicationClassLibary
{
    public class Student : Person
    {
        public Student(int id, string ime, string prezime, double gpa)
        {
            this.Id = id;
            this.Ime = ime;
            this.Prezime = prezime;
            this.Gpa = gpa;
        }

        public int Id { get; private set; }
        public string Ime { get; private set; }
        public string Prezime { get; private set; }
        public double Gpa { get; private set; }

        public override string DisplayInformation()
        {
            return "ID: "+ Id + " Ime: " + Ime + " Prezime: " + Prezime + " Gpa: " + Gpa;
        }

    }
}