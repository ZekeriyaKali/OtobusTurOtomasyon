using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurOtomasyonForm.Entities;

namespace TurOtomasyonForm.DAL
{
    public class BiletDal
    {
          SqlConnection _conn = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog=TurOtomasyonDb; integrated security=true;");

        public void ConnectionControl()
        {

            if (_conn.State == ConnectionState.Closed)
            {
                _conn.Open();
            }
        }
        public List<Bilet> GetAll()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * From Biletler", _conn);
            SqlDataReader reader = command.ExecuteReader();
            List<Bilet> biletler = new List<Bilet>();
            while (reader.Read())
            {
                Bilet bilet = new Bilet
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    KoltukNo = Convert.ToInt32(reader["KoltukNo"]),
                    KalkisYeriId = Convert.ToInt32(reader["KalkisYeriId"]),
                    VarisYeriId = Convert.ToInt32(reader["VarisYeriId"]),
                    FirmaId = Convert.ToInt32(reader["FirmaId"]),
                    YolcuId = Convert.ToInt32(reader["YolcuId"]),
                    KalkisZamani = Convert.ToDateTime(reader["KalkisZamani"]),
                    VarisZamani = Convert.ToDateTime(reader["VarisZamani"])
                };
                biletler.Add(bilet);
            }
            reader.Close();
            _conn.Close();
            return biletler;

        }

        public void Add(Bilet bilet)
        {
            string procedureName = "InsertBiletler";
            ConnectionControl();
            SqlCommand command = new SqlCommand(procedureName, _conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@KoltukNo", bilet.KoltukNo);
            command.Parameters.AddWithValue("@KalkisYeriId", bilet.KalkisYeriId);
            command.Parameters.AddWithValue("@VarisYeriId", bilet.VarisYeriId);
            command.Parameters.AddWithValue("@FirmaId", bilet.FirmaId);
            command.Parameters.AddWithValue("@YolcuId", bilet.YolcuId);
            command.Parameters.AddWithValue("@KalkisZamani", bilet.KalkisZamani);
            command.Parameters.AddWithValue("@VarisZamani", bilet.VarisZamani);

            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void Update(Bilet bilet)
        {
            string procedureName = "UpdateBiletler";
            ConnectionControl();
            SqlCommand command = new SqlCommand(procedureName, _conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@KoltukNo", bilet.KoltukNo);
            command.Parameters.AddWithValue("@KalkisYeriId", bilet.KalkisYeriId);
            command.Parameters.AddWithValue("@VarisYeriId", bilet.VarisYeriId);
            command.Parameters.AddWithValue("@FirmaId", bilet.FirmaId);
            command.Parameters.AddWithValue("@YolcuId", bilet.YolcuId);
            command.Parameters.AddWithValue("@KalkisZamani", bilet.KalkisZamani);
            command.Parameters.AddWithValue("@VarisZamani", bilet.VarisZamani);
            command.Parameters.AddWithValue("@Id", bilet.Id);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        public void Delete(int id)
        {
            string procedureName = "DeleteBiletler";
            ConnectionControl();
            SqlCommand command = new SqlCommand(procedureName, _conn);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@Id", id);
            command.ExecuteNonQuery();
            _conn.Close();
        }
    }
}
