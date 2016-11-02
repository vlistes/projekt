using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentApplicationClassLibary
{
    public class Operations
    {
            public static string AddIme(string ime)
            {
                string FirstNameUnos = ime;

                if (FirstNameUnos == "") Console.Write("You need to insert value.\n");

                return ime;
            }
            public static string AddPrezime(string prezime)
            {
                string LastNameUnos = prezime;

                if (LastNameUnos == "") Console.Write("You need to insert value.\n");

                return prezime;
            }
            public static string AddGpa(string gpa)
            {
                string GpaUnos = gpa;

                try
                {
                    double UnosGpa = Convert.ToDouble(GpaUnos);
                }
                catch
                {
                    Console.Write("You need to insert numerical value.\n");
                    gpa = "";
                }

                return gpa;
            }
        
    }
}
