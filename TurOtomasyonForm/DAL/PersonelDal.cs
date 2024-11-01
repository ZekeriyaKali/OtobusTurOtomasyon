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
    public class PersonelDal
    {
        SqlConnection _conn = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog=TurOtomasyonDb; integrated security=true;");

        public void ConnectionControl()
        {

            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
        }
        public List<Personel> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * From Personeller", _conn);
            SqlDataReader reader = command.ExecuteReader();
            List<Personel> personeller = new List<Personel>();
            while (reader.Read())
            {
                Personel personel = new Personel
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    PersonelAd = reader["PersonelAd"].ToString(),
                    PersonelSoyad = reader["PersonelSoyad"].ToString(),
                    PersonelTur = reader["PersonelTur"].ToString(),
                };
                personeller.Add(personel);
            }
            reader.Close();
            _conn.Close();
            return personeller;

        }

        public void Add(Personel personel)
        {
            string procedureName = "InsertPersoneller";
            ConnectionControl();
            SqlCommand command = new SqlCommand(procedureName, _conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PersonelAd", personel.PersonelAd);
            command.Parameters.AddWithValue("@PersonelSoyad", personel.PersonelSoyad);
            command.Parameters.AddWithValue("@PersonelTur", personel.PersonelTur);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void Update(Personel personel)
        {
            string procedureName = "UpdatePersoneller";
            ConnectionControl();
            SqlCommand command = new SqlCommand(procedureName, _conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@PersonelAd", personel.PersonelAd);
            command.Parameters.AddWithValue("@PersonelSoyad", personel.PersonelSoyad);
            command.Parameters.AddWithValue("@PersonelTur", personel.PersonelTur);
            command.Parameters.AddWithValue("@Id", personel.Id);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void Delete(int id)
        {
            string procedureName = "DeletePersoneller";
            ConnectionControl();
            SqlCommand command = new SqlCommand(procedureName, _conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
