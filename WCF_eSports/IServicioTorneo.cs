using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCF_eSports
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IServicioTorneo" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IServicioTorneo
    {
        [OperationContract]
        List<TorneoBE> FechaTorneo(DateTime FecIni, DateTime FecFin);
    }

    [DataContract]
    [Serializable]
    public class TorneoBE
    {
        private String mvarNomTorneo;
        private String mvarOrgTorneo;
        private String mvarPaisTorneo;
        private String mvarLugarTorneo;
        [DataMember]
        public String Nombre
        {
            get { return mvarNomTorneo; }
            set { mvarNomTorneo = value; }
        }
        [DataMember]
        public String Org
        {
            get { return mvarOrgTorneo; }
            set { mvarOrgTorneo = value; }
        }
        [DataMember]
        public String Pais
        {
            get { return mvarPaisTorneo; }
            set { mvarPaisTorneo = value; }
        }
        [DataMember]
        public String Lugar
        {
            get { return mvarLugarTorneo; }
            set { mvarLugarTorneo = value; }
        }
    }
}
