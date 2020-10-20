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

        [OperationContract]
        List<JugadorBE> ListarPaisJugadores(String pais);

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

    public class JugadorBE
    {
        private String mvarApe_Jugador;
        private String mvarNom_Jugador;
        private String mvarNick_Jugador;
        private String mvarPais_Jugador;
        private String mvarRol_Jugador;
        private String mvarNom_Equipo;
        [DataMember]
        public String Apellido
        {
            get { return mvarApe_Jugador; }
            set { mvarApe_Jugador = value; }
        }
        [DataMember]
        public String Nombre
        {
            get { return mvarNom_Jugador; }
            set { mvarNom_Jugador = value; }
        }
        [DataMember]
        public String NickName
        {
            get { return mvarNick_Jugador; }
            set { mvarNick_Jugador = value; }
        }
        [DataMember]
        public String Pais
        {
            get { return mvarPais_Jugador; }
            set { mvarPais_Jugador = value; }
        }
        [DataMember]
        public String Rol
        {
            get { return mvarRol_Jugador; }
            set { mvarRol_Jugador = value; }
        }
        [DataMember]
        public String Equipo
        {
            get { return mvarNom_Equipo; }
            set { mvarNom_Equipo = value; }
        }
    }
}
