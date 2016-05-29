using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebAPI.Models
{
    public class patientRepository
    {
        public List<patient> GetAllPatients()
        {
            SqlConnection con = new SqlConnection("Data Source=HONGKONG-PC\\SANATH;Initial Catalog=Hospital;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Hospital].[dbo].[Patient]",con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            List<patient> pat = new List<patient>();
            foreach (DataRow row in ds.Tables[0].Rows)
            { 
                pat.Add(new patient {
                    ID= Convert.ToInt32(row[0]),
                    Name = row[1].ToString(),
                    Address =row[2].ToString(),
                    DateOfBirth=row[3].ToString(),
                    Phone=row[4].ToString(),
                    EmergencyContact = row[5].ToString(),
                    DateOfRegistration = row[6].ToString()
                });
            }
            con.Close();

            return pat;
            
        }

        public patient GetPatient(int patientid)
        {
            //Name,Address,DateOfBirth,Phone,EmergencyContact,DateOfRegistration
               SqlConnection con = new SqlConnection("Data Source=HONGKONG-PC\\SANATH;Initial Catalog=Hospital;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM [Hospital].[dbo].[Patient] WHERE PATIENTID="+patientid, con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sda = new SqlDataAdapter();
            DataSet ds = new DataSet();
            sda.SelectCommand = cmd;
            sda.Fill(ds);
            patient pat = new patient();
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                pat.ID = Convert.ToInt32(row[0]);
                pat.Name = row[1].ToString();
                pat.Address = row[2].ToString();
                pat.DateOfBirth = row[3].ToString();
                pat.Phone = row[4].ToString();
                pat.EmergencyContact = row[5].ToString();
                pat.DateOfRegistration = row[6].ToString();
                
            }
            con.Close();

            return pat;

        }


    }
}