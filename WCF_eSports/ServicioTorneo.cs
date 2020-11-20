using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_eSports
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioTorneo" en el código y en el archivo de configuración a la vez.
    public class ServicioTorneo : IServicioTorneo
    {
        public List<TorneoBE> FechaTorneo(DateTime FecIni, DateTime FecFin)
        {
            eSportsEntities entity = new eSportsEntities();
            try
            {
                List<TorneoBE> objLista = new List<TorneoBE>();

                var query = entity.ConsultarFechaTorneo(FecIni, FecFin);

                foreach (var item in query)
                {
                    TorneoBE objItem = new TorneoBE();
                    objItem.Nombre = item.NomTorneo;
                    objItem.Org = item.OrgTorneo;
                    objItem.Pais = item.PaisTorneo;
                    objItem.Lugar = item.LugarTorneo;
                    

                    objLista.Add(objItem);
                }
                return objLista;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
