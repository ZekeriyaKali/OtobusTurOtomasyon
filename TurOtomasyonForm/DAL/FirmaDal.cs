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
    public class FirmaDal
    {
        SqlConnection _conn = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog=TurOtomasyonDb; integrated security=true;");

        public void ConnectionControl()
        {

            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
        }
        public List<Firma> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * From Firmalar", _conn);
            SqlDataReader reader = command.ExecuteReader();
            List<Firma> firmalar = new List<Firma>();
            while (reader.Read())
            {
                Firma firma = new Firma
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    FirmaAd = reader["FirmaAd"].ToString(),
                    FirmaIletisim = Convert.ToInt64(reader["FirmaIletisim"]),
                    PersonelId = Convert.ToInt32(reader["PersonelId"])
                };
                firmalar.Add(firma);
            }
            reader.Close();
            _conn.Close();
            return firmalar;

        }

        public void Add(Firma firma)
        {
            string procedureName = "InsertFirmalar";
            ConnectionControl();
            SqlCommand command = new SqlCommand(procedureName, _conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FirmaAd", firma.FirmaAd);
            command.Parameters.AddWithValue("@FirmaIletisim", firma.FirmaIletisim);
            command.Parameters.AddWithValue("@PersonelId", firma.PersonelId);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void Update(Firma firma)
        {
            string procedureName = "UpdateFirmalar";
            ConnectionControl();
            SqlCommand command = new SqlCommand(procedureName, _conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@FirmaAd", firma.FirmaAd);
            command.Parameters.AddWithValue("@FirmaIletisim", firma.FirmaIletisim);
            command.Parameters.AddWithValue("@PersonelId", firma.PersonelId);
            command.Parameters.AddWithValue("@Id", firma.Id);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void Delete(int id)
        {
            string procedureName = "DeleteFirmalar";
            ConnectionControl();
            SqlCommand command = new SqlCommand(procedureName, _conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
