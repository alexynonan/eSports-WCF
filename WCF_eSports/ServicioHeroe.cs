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
        eSportsEntities entity = new eSportsEntities();

        public List<HeroeBE> HeroeComplejidad(String complejidad)
        {
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

        public bool HeroeDelete(int id)
        {
            try
            {
                var query = entity.EliminarHeroe(id);
                if (query != null) { return true; } else { return false; };

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public bool HeroeUpdate(HeroeBE objHeroe)
        {
            try
            {
                
                var query = entity.ActualizarHeroe(objHeroe.Id, objHeroe.Nombre, objHeroe.Atributo, objHeroe.Tipo, objHeroe.Complejidad);

                if (query != null) { return true; } else { return false; };

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<HeroeBE> ListarHerores()
        {
            try
            {
                List<HeroeBE> listarHeroe = new List<HeroeBE>();
                var query = entity.HEROE.ToList();

                foreach (var resultado in query)
                {
                    HeroeBE objHeroe = new HeroeBE();
                    objHeroe.Id = Convert.ToInt16(resultado.IdHeroe);
                    objHeroe.Nombre = resultado.NomHeroe;
                    objHeroe.Atributo = resultado.Atributo;
                    objHeroe.Tipo = resultado.Tipo;
                    objHeroe.Complejidad = resultado.Complejidad;
                    listarHeroe.Add(objHeroe);
                }
                return listarHeroe;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
