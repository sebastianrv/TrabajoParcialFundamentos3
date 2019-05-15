using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoParcialFundamentos
{
    public class Cmunicipalidad
    {
        public string nombre { set; get; }
        public string[] tipo { get; set; }
        public List<Ctramite> tramites { set; get; }
        public List<Ccontribuyente> contribuyentes { set; get; }
        
        public Cmunicipalidad()
        {
            contribuyentes = new List<Ccontribuyente>();
            tramites = new List<Ctramite>();
            tipo = new string[2]; 
        }
    }
}
