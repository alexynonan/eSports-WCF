using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_eSports
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioJugador" en el código y en el archivo de configuración a la vez.
    public class ServicioJugador : IServicioJugador
    {
        public List<JugadorEstadistica> RankingJugador(Int16 top)
        {
            try
            {
                eSportsEntities entity = new eSportsEntities();
                List<JugadorEstadistica> objLista = new List<JugadorEstadistica>();

                var query = (from obj in entity.vw_RankingKillsPorPartida
                             select new
                             {
                                 obj.RoundPartida,
                                 obj.NickJugador,
                                 obj.NomHeroe,
                                 obj.TotalKills,
                                 obj.TotalDeaths,
                                 obj.TotalAssists
                             }).Take(top);
                foreach (var item in query)
                {
                    JugadorEstadistica objItem = new JugadorEstadistica();
                    objItem.Round = item.RoundPartida;
                    objItem.Nickname = item.NickJugador;
                    objItem.NomHeroe = item.NomHeroe;
                    objItem.TotalKills = Convert.ToSingle(item.TotalKills);
                    objItem.TotalDeaths = Convert.ToSingle(item.TotalDeaths);
                    objItem.TotalAssists = Convert.ToSingle(item.TotalAssists);

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
