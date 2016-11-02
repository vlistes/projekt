using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StudentApplicationClassLibary
{
    public class StudentIdGenerator
    {
        private static StudentIdGenerator _object;
        public int Id_br { get; set; }
        private StudentIdGenerator()
        {
            Id_br = Id_br + 1;
        }
        public static StudentIdGenerator CreateObject()
        {
            if (_object == null)
            {
                _object = new StudentIdGenerator();
            }

            return _object;
        }
    }
}
