using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_eSports
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioHeroe" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioHeroe
    {
        [OperationContract]
        List<HeroeBE> HeroeComplejidad(String complejidad);
        [OperationContract]
        List<HeroeBE> ListarHerores();
        [OperationContract]
        Boolean HeroeUpdate(HeroeBE objHeroe);
        [OperationContract]
        Boolean HeroeDelete(int id);
    }

    [DataContract]
    [Serializable]
    public class HeroeBE
    {
        private Int16 mvarId;
        private String mvarNombre;
        private String mvarAtributo;
        private String mvarTipo;
        private String mvarComplejidad;
        [DataMember]
        public Int16 Id
        {
            get { return mvarId; }
            set { mvarId = value; }
        }
        [DataMember]
        public String Nombre
        {
            get { return mvarNombre; }
            set { mvarNombre = value; }
        }
        [DataMember]
        public String Atributo
        {
            get { return mvarAtributo; }
            set { mvarAtributo = value; }
        }
        [DataMember]
        public String Tipo
        {
            get { return mvarTipo; }
            set { mvarTipo = value; }
        }

        [DataMember]
        public String Complejidad
        {
            get { return mvarComplejidad; }
            set { mvarComplejidad = value; }
        }
    }
}
