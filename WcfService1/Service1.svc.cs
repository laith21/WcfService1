using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string SelectAllUserData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-AFE7T16;Initial Catalog=AppleWatchData;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select * from HealthData", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            con.Close();
            return JsonConvert.SerializeObject(dt);
        }
        public string SelectOxygenData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-AFE7T16;Initial Catalog=AppleWatchData;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Oxygen_Saturation from HealthData", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            con.Close();
            return JsonConvert.SerializeObject(dt);
        }
        public string SelectHeartData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-AFE7T16;Initial Catalog=AppleWatchData;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Heart_Rate from HealthData", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            con.Close();
            return JsonConvert.SerializeObject(dt);
        }
        public string SelectBloodData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-AFE7T16;Initial Catalog=AppleWatchData;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Blood_Pressure from HealthData", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            con.Close();
            return JsonConvert.SerializeObject(dt);
        }
        public string SelectStepsData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-AFE7T16;Initial Catalog=AppleWatchData;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Steps_Walked from HealthData", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            con.Close();
            return JsonConvert.SerializeObject(dt);
        }
        public string SelectStairsData()
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-AFE7T16;Initial Catalog=AppleWatchData;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Select Stairs_Climbed from HealthData", con);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            cmd.ExecuteNonQuery();
            con.Close();
            return JsonConvert.SerializeObject(dt);
        }
        public string InsertUserData(getwatchdata userInfo)
        {
            string Message;
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-AFE7T16;Initial Catalog=AppleWatchData;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into HealthData(Oxygen_Saturation,Heart_Rate,Blood_Pressure,Steps_Walked,Stairs_Climbed) values(@Oxygen_Saturation,@Heart_Rate,@Blood_Pressure,@Steps_Walked,@Stairs_Climbed)", con);
            cmd.Parameters.AddWithValue("@Oxygen_Saturation", userInfo.Oxygen_Saturation);
            cmd.Parameters.AddWithValue("@Heart_Rate", userInfo.Heart_Rate);
            cmd.Parameters.AddWithValue("@Blood_Pressure", userInfo.Blood_Pressure);
            cmd.Parameters.AddWithValue("@Steps_Walked", userInfo.Steps_Walked);
            cmd.Parameters.AddWithValue("@Stairs_Climbed", userInfo.Stairs_Climbed);
            int result = cmd.ExecuteNonQuery();
            if (result == 1)
            {
                Message = userInfo.Oxygen_Saturation + " Details inserted successfully";
            }
            else
            {
                Message = userInfo.Oxygen_Saturation + " Details not inserted successfully";
            }
            con.Close();
            return Message;
        }
    }
}
