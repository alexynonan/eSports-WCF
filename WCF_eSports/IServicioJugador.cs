using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_eSports
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioJugador" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioJugador
    {
        [OperationContract]
        List<JugadorEstadistica> RankingJugador(Int16 top);

    }

    [DataContract]
    [Serializable]
    public class JugadorEstadistica
    {
        private String mvarround;
        private String mvarnickname;
        private String mvarnomheroe;
        private Single mvartotalkills;
        private Single mvartotaldeaths;
        private Single mvartotalassists;
        [DataMember]
        public String Round
        {
            get { return mvarround; }
            set { mvarround = value; }
        }
        [DataMember]
        public String Nickname
        {
            get { return mvarnickname; }
            set { mvarnickname = value; }
        }
        [DataMember]
        public String NomHeroe
        {
            get { return mvarnomheroe; }
            set { mvarnomheroe = value; }
        }
        [DataMember]
        public Single TotalKills
        {
            get { return mvartotalkills; }
            set { mvartotalkills = value; }
        }
        [DataMember]
        public Single TotalDeaths
        {
            get { return mvartotaldeaths; }
            set { mvartotaldeaths = value; }
        }
        [DataMember]
        public Single TotalAssists
        {
            get { return mvartotalassists; }
            set { mvartotalassists = value; }
        }
    }
}
