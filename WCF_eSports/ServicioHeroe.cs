using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_eSports
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioHeroe" en el código y en el archivo de configuración a la vez.
    public class ServicioHeroe : IServicioHeroe
    {
        public List<HeroeBE> HeroeComplejidad(String complejidad)
        {
            eSportsEntities entity = new eSportsEntities();
            try
            {
                List<HeroeBE> objLista = new List<HeroeBE>();

                var query = entity.ConsultarHeroeComplejidad(complejidad);

                foreach (var item in query)
                {
                    HeroeBE objItem = new HeroeBE();
                    objItem.Id = Convert.ToInt16(item.idHeroe);
                    objItem.Nombre = item.NomHeroe;
                    objItem.Atributo = item.Atributo;
                    objItem.Tipo = item.Tipo;
                    objItem.Complejidad = item.Complejidad;

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
