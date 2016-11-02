using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var studentContainer = new StudentApplicationClassLibary.StudentContainer();
            var operations = new StudentApplicationClassLibary.Operations();
            StudentApplicationClassLibary.StudentIdGenerator CreateObject = StudentApplicationClassLibary.StudentIdGenerator.CreateObject();
            int id = CreateObject.Id_br;
            string odabir = string.Empty;
            string ime;
            string prezime;
            string gpa;
            Start:
            Console.Clear();
            Console.WriteLine("Please enter your choice - ENLIST or DISPLAY");

            odabir = Console.ReadLine().ToUpper();

            switch (odabir)
            {
                case "ENLIST":
                    Console.Write("Student\n");

                    do
                    {
                        Console.Write("First name: ");
                        ime = StudentApplicationClassLibary.Operations.AddIme(Console.ReadLine());
                    } while(ime == "");
                    do
                    {
                        Console.Write("Last name: ");
                        prezime = StudentApplicationClassLibary.Operations.AddPrezime(Console.ReadLine());
                    } while (prezime == "");
                    do
                    {
                        Console.Write("GPA: ");
                        gpa = StudentApplicationClassLibary.Operations.AddGpa(Console.ReadLine());
                    } while (gpa  == "");

                    studentContainer.Add(id, ime, prezime, gpa);
                    id = id + 1;

                    goto Start;
                case "DISPLAY":
                    Console.Write("Students in a system\n");
                    studentContainer.ShowAll();
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Non-existing operation, and allow to try it again ");
                    Console.ReadKey();
                    goto Start;
            }
        }
    }
}
