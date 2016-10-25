using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Disciplina
    {
        string[] numar_disciplina;
        string[] credite;

        public Disciplina(string[] nr_d, string[] cred)
        {
            nr_d = numar_disciplina;
            cred = credite;
        
        }
        public string _numar_disciplina
        {


            get { return _numar_disciplina; }
            set { _numar_disciplina = value; }
        }
        public string _credite
        {


            get { return _credite; }
            set { _credite = value; }
        }
    }
}