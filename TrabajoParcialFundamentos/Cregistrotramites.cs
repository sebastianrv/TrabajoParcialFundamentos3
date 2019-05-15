using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoParcialFundamentos
{
    public class Cregistrotramites
    {
        public static List<Ccontribuyente> Contribuyentes { get; set; }
        public static List<Cmunicipalidad> Municipalidades { get; set; }
        public static List<Ctramite> Tramites { get; set; }
        public Cregistrotramites()
        {
            if (Tramites == null)
                Tramites = new List<Ctramite>();
            if (Municipalidades == null)
                Municipalidades = new List<Cmunicipalidad>();
            if (Contribuyentes == null)
                Contribuyentes = new List<Ccontribuyente>();
        }
        public void registrar_muni(Cmunicipalidad nueva) {
            Municipalidades.Add(nueva);
        }
        public void registrar_tramite_en_muni(string nombre_muni,Ctramite tramite) {
            Cmunicipalidad muni = Municipalidades.Find(delegate (Cmunicipalidad value)
              { return value.nombre == nombre_muni; }
            );
            if (muni != null)
                muni.tramites.Add(tramite);
        }
        public void registrar_contribu_en_muni(string nombre_muni, Ccontribuyente contribu)
        {
            Cmunicipalidad muni = Municipalidades.Find(delegate (Cmunicipalidad value)
            { return value.nombre == nombre_muni; }
            );
            if (muni != null)
                muni.contribuyentes.Add(contribu);
        }
        public List<Ctramite> listratramites_en_munis(string nom) { 
            Cmunicipalidad muni = Municipalidades.Find(delegate (Cmunicipalidad value)
              {  return value.nombre == nom; }
            );
            if (muni != null)
                return muni.tramites;
            else
                return null;

        }
        public List<Ccontribuyente> listar_contribuyentes_en_munis(string nom) {
            Cmunicipalidad muni = Municipalidades.Find(delegate (Cmunicipalidad value)
              { return value.nombre == nom; });
            if (muni != null)
                return muni.contribuyentes;
            else
                return null;
        }
        

        public List<Cmunicipalidad>buscar_enque_muni_esta_tramite(string cod_tra) {
            List<Cmunicipalidad> muni = new List<Cmunicipalidad>();
            
                foreach (Ctramite trami in Tramites) {
                if (trami.cod_tramite == cod_tra)
                {
                    foreach (Cmunicipalidad munici in Municipalidades)
                    {
                        if (munici.tramites.Contains(trami))
                            muni.Add(munici);
                    }
                }
                    }
            return muni;


        }
        /////ver si existe contribuyente y tramite
        public bool existe_tramite(string cod_tra) {
            return Tramites.Exists(delegate (Ctramite value)
            { return value.cod_tramite == cod_tra; });
        }
        public bool existe_contribuyente(string DNI) {
            return Contribuyentes.Exists(delegate (Ccontribuyente value)
            { return value.DNI == DNI; });
        }
        public bool existe_municipalidad(string nombre)
        {
            return Municipalidades.Exists(delegate (Cmunicipalidad value)
            { return value.nombre == nombre; });
        }
        public List<Ctramite> listar_tramites_por_contribuyente(string DNIcontri) {
            List<Ctramite> tramiteporcon = new List<Ctramite>();
            foreach (Ctramite trami in Tramites)
                if (trami.dnideContri == DNIcontri)
                    tramiteporcon.Add(trami);
               
            return tramiteporcon;
        }
        public List<Cmunicipalidad> muni_mas_tramites_por_tipo(string tipo) {
            List<Cmunicipalidad> munitramitipo = new List<Cmunicipalidad>();
            int[] conta;
            conta = new int[Municipalidades.Count];
            int a = 0;
            int b = 0;
            foreach (Cmunicipalidad muni in Municipalidades)
            {foreach (Ctramite trami in muni.tramites)
                {
                    if (trami.tipo == tipo)
                        conta[a]++;
                }
                a++;
            }
            a = 0;
            foreach (Cmunicipalidad muni in Municipalidades)
            {
                if (conta[a] > b)
                {
                    b = conta[a];
                    a++;
                }
            }
            a = 0;
            foreach (Cmunicipalidad muni in Municipalidades)
            {
                if (conta[a] == b)
                {
                    munitramitipo.Add(Municipalidades.ElementAt(a));
                    
                }
            }
            return munitramitipo;
        }
        public List<Cmunicipalidad> lista_muni_por_trami(string tipo) {
            List<Cmunicipalidad> munitramitipo = new List<Cmunicipalidad>();
            foreach (Cmunicipalidad muni in Municipalidades)
            {foreach (Ctramite trami in muni.tramites)
                    if (trami.tipo == tipo)
                        munitramitipo.Add(muni);
            }
            return munitramitipo;
        }
        public List<Ccontribuyente> revisar_si_es_aprobado( Ccontribuyente cont) {
            List<Ccontribuyente> contriapro = new List<Ccontribuyente>();
            foreach (Ccontribuyente contri in Contribuyentes)
            {if (Contribuyentes.Exists(delegate(Ccontribuyente value)
            {
                return value.DNI == cont.DNI;
            }))
                    contriapro.Add(cont);
            }
            return contriapro;
        }
        public bool verificar_dni(string dni) {
            bool exist =false;
             exist = Contribuyentes.Exists(delegate (Ccontribuyente value)
               { return value.DNI == dni; });

            return exist;
               
                    
        }
        public bool verificar_contra(string contras) {
            bool exist = false;
            exist = Contribuyentes.Exists(delegate (Ccontribuyente value)
            { return value.contra == contras; });

            return exist;
        }
    }

}
