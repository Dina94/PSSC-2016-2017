using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3
{
    public class Profesor
    {
        string[] nume;
        string[] prenume;
        string[] cnp;
        string[] adresa;
        float proportie;
        public Profesor(string[] n, string[] p, string[] c ,string[] adr, float prop)
        {
            n = nume;
            p = prenume;
            c = cnp;
            adr=adresa;
            prop = proportie;

        }
        public string _nume
        {


            get { return _nume; }
            set { _nume = value; }
        }
        public string _prenume
        {


            get { return _prenume; }
            set { _prenume = value; }
        }
        public string _cnp
        {


            get { return _cnp; }
            set { _cnp = value; }
        }
        public string _adresa
        {


            get { return _adresa; }
            set { _adresa = value; }
        }
        public float _proportie
        {


            get { return _proportie; }
            set { _proportie = value; }
        }
    }
    }
}