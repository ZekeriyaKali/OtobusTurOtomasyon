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
    public class YolcuDal
    {
        SqlConnection _conn = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog=TurOtomasyonDb; integrated security=true;");

        public void ConnectionControl()
        {

            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
        }
        public List<Yolcu> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * From Yolcular", _conn);
            SqlDataReader reader = command.ExecuteReader();
            List<Yolcu> yolcular = new List<Yolcu>();
            while (reader.Read())
            {
                Yolcu yolcu = new Yolcu
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    YolcuAd = reader["YolcuAd"].ToString(),
                    YolcuSoyad = reader["YolcuSoyad"].ToString(),
                    YolcuTelefon = Convert.ToInt64(reader["YolcuTelefon"]),
                };
                yolcular.Add(yolcu);
            }
            reader.Close();
            _conn.Close();
            return yolcular;

        }

        public void Add(Yolcu yolcu)
        {
            string procedureName = "InsertYolcular";
            ConnectionControl();
            SqlCommand command = new SqlCommand(procedureName, _conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@YolcuAd", yolcu.YolcuAd);
            command.Parameters.AddWithValue("@YolcuSoyad", yolcu.YolcuSoyad);
            command.Parameters.AddWithValue("@YolcuTelefon", yolcu.YolcuTelefon);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void Update(Yolcu yolcu)
        {
            string procedureName = "UpdateYolcular";
            ConnectionControl();
            SqlCommand command = new SqlCommand(procedureName, _conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@YolcuAd", yolcu.YolcuAd);
            command.Parameters.AddWithValue("@YolcuSoyad", yolcu.YolcuSoyad);
            command.Parameters.AddWithValue("@YolcuTelefon", yolcu.YolcuTelefon);
            command.Parameters.AddWithValue("@Id", yolcu.Id);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void Delete(int id)
        {
            string procedureName = "DeleteYolcular";
            ConnectionControl();
            SqlCommand command = new SqlCommand(procedureName, _conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
