using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.Data;
using Supermarket_MVP.Models;
using System.Data;

namespace Supermarket_MVP._Repositories
{
    internal class ProvidersRepository : BaseRepository, IProvidersRepository
    {
        public ProvidersRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(ProvidersModel providersModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Providers 
                                        VALUES (@docNum, @name, @address, @phoneNum, @eMail)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providersModel.ProviderName;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = providersModel.ProviderAddress;
                command.Parameters.Add("@phoneNum", SqlDbType.NVarChar).Value = providersModel.ProviderPhoneNum;
                command.Parameters.Add("@eMail", SqlDbType.NVarChar).Value = providersModel.ProvidereMail;
                command.ExecuteNonQuery();
            };
        }
        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Providers WHERE Provider_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            };
        }
        public void Edit(ProvidersModel providersModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Providers
                                        SET Provider_DocNum = @docNum,
                                            Provider_Name = @name,
                                            Provider_Address = @address,
                                            Provider_PhoneNum = @phoneNum,
                                            Provider_eMail = @eMail,
                                        WHERE Provider_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providersModel.ProviderName;
                command.Parameters.Add("@address", SqlDbType.NVarChar).Value = providersModel.ProviderAddress;
                command.Parameters.Add("@phoneNum", SqlDbType.NVarChar).Value = providersModel.ProviderPhoneNum;
                command.Parameters.Add("@eMail", SqlDbType.NVarChar).Value = providersModel.ProvidereMail;
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<ProvidersModel> GetAll()
        {
            var providersList = new List<ProvidersModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Providers ORDER BY Provider_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providersModel = new ProvidersModel();
                        providersModel.ProviderId = (int)reader["Provider_Id"];
                        providersModel.ProviderDocNum = reader["Provider_DocNum"].ToString();
                        providersModel.ProviderName = reader["Provider_Name"].ToString();
                        providersModel.ProviderAddress = reader["Provider_Address"].ToString();
                        providersModel.ProviderPhoneNum = reader["Provider_PhoneNum"].ToString();
                        providersModel.ProvidereMail = reader["Provider_eMail"].ToString();
                        providersList.Add(providersModel);
                    }
                }
            }
            return providersList;
        }
        public IEnumerable<ProvidersModel> GetByValue(string value)
        {
            var providersList = new List<ProvidersModel>();
            int providersId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string providersName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Providers
                                        WHERE provider_Id=@id or Provider_Name LIKE @name+ '%'
                                        ORDER BY Provider_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = providersId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = providersName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var providersModel = new ProvidersModel();
                        providersModel.ProviderId = (int)reader["Provider_Id"];
                        providersModel.ProviderDocNum = reader["Provider_DocNum"].ToString();
                        providersModel.ProviderName = reader["Provider_Name"].ToString();
                        providersModel.ProviderAddress = reader["Provider_Address"].ToString();
                        providersModel.ProviderPhoneNum = reader["Provider_Phone"].ToString();
                        providersModel.ProvidereMail = reader["Provider_eMail"].ToString();
                        providersList.Add(providersModel);
                    }
                }
            }
            return providersList;
        }
    }
}
