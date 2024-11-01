using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOtomasyonForm.Entities;

namespace TurOtomasyonForm.DAL
{
    public class SehirDal
    {
        SqlConnection _conn = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog=TurOtomasyonDb; integrated security=true;");

        public void ConnectionControl()
        {

            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
        }
        public List<Sehir> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * From Sehirler", _conn);
            SqlDataReader reader = command.ExecuteReader();
            List<Sehir> sehirler = new List<Sehir>();
            while (reader.Read())
            {
                Sehir sehir = new Sehir
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    SehirAd = reader["SehirAd"].ToString(),
                };
                sehirler.Add(sehir);
            }
            reader.Close();
            _conn.Close();
            return sehirler;

        }

        public void Add(Sehir sehir)
        {
            string procedureName = "InsertSehirler";
            ConnectionControl();
            SqlCommand command = new SqlCommand(procedureName, _conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@SehirAd", sehir.SehirAd);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void Update(Sehir sehir)
        {
            string procedureName = "UpdateSehirler";
            ConnectionControl();
            SqlCommand command = new SqlCommand(procedureName, _conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@SehirAd", sehir.SehirAd);
            command.Parameters.AddWithValue("@Id", sehir.Id);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void Delete(int id)
        {
            string procedureName = "DeleteSehirler";
            ConnectionControl();
            SqlCommand command = new SqlCommand(procedureName, _conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}

