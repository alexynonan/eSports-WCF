using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_eSports
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioEquipo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioEquipo
    {
        [OperationContract]
        List<EquipoPuntos> RankingEquipoPartida(Int16 partida);
    }

    [DataContract]
    [Serializable]
    public class EquipoPuntos
    {
        private String mvarenfrentamiento;
        private String mvarequipo;
        private Single mvarresultado;
        [DataMember]
        public String Enfrentamiento
        {
            get { return mvarenfrentamiento; }
            set { mvarenfrentamiento = value; }
        }
        [DataMember]
        public String Equipo
        {
            get { return mvarequipo; }
            set { mvarequipo = value; }
        }
        [DataMember]
        public Single Resultado
        {
            get { return mvarresultado; }
            set { mvarresultado = value; }
        }
    }
}
