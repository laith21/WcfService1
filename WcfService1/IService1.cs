using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string InsertUserData(getwatchdata userInfo);
        [OperationContract]
        string SelectAllUserData();
        [OperationContract]
        string SelectOxygenData();
        [OperationContract]
        string SelectHeartData();
        [OperationContract]
        string SelectBloodData();
        [OperationContract]
        string SelectStepsData();
        [OperationContract]
        string SelectStairsData();
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class getwatchdata
    {
        string oxygen_saturation;
        string heart_rate;
        string blood_pressure;
        string steps_walked;
        string stairs_climbed;

        [DataMember]
        public string Oxygen_Saturation
        {
            get { return oxygen_saturation; }
            set { oxygen_saturation = value; }
        }
        [DataMember]
        public string Heart_Rate
        {
            get { return heart_rate; }
            set { heart_rate = value; }
        }
        [DataMember]
        public string Blood_Pressure
        {
            get { return blood_pressure; }
            set { blood_pressure = value; }
        }
        [DataMember]
        public string Steps_Walked
        {
            get { return steps_walked; }
            set { steps_walked = value; }
        }
        [DataMember]
        public string Stairs_Climbed
        {
            get { return stairs_climbed; }
            set { stairs_climbed = value; }
        }
    }
}
