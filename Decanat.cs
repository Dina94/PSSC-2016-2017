using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Decanat
    {
        List<string> Profesor = new List<string>();
        List<string> Student = new List<string>();
        List<string> Disciplina = new List<string>();
        public Decanat(List<string> prof, List<string> stud, List<string> dis)
        {
            prof = Profesor;
            stud = Student;
            dis = Disciplina;
        }
        public List<string> _Profesor
        {
            get { return _Profesor; }
            set { _Profesor = value; }
        }
        public List<string> _Student
        {
            get { return _Student; }
            set { _Student = value; }
        }
        public List<string> _Disciplina
        {
            get { return _Disciplina; }
            set { _Disciplina = value; }
        }
    }

}