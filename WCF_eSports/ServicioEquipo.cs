using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_eSports
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioEquipo" en el código y en el archivo de configuración a la vez.
    public class ServicioEquipo : IServicioEquipo
    {
        public List<EquipoPuntos> RankingEquipoPartida(Int16 partida)
        {
            try
            {
                eSportsEntities entity = new eSportsEntities();
                List<EquipoPuntos> objLista = new List<EquipoPuntos>();

                var query = entity.usp_KillsEquipoPorPartida(partida);

                foreach (var item in query)
                {
                    EquipoPuntos objItem = new EquipoPuntos();
                    objItem.Enfrentamiento = item.Enfrentamiento;
                    objItem.Equipo = item.NomEquipo;
                    objItem.Resultado = Convert.ToSingle(item.Resultado);

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
