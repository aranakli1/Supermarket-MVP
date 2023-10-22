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
    internal class ProductsRepository : BaseRepository, IProductsRepository
    {
        public ProductsRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(ProductsModel productsModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"INSERT INTO Products 
                                        VALUES (@name, @price, @stock, @catId)";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsModel.ProductName;
                command.Parameters.Add("@price", SqlDbType.Int).Value = productsModel.ProductPrice;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productsModel.ProductStock;
                command.Parameters.Add("@catId", SqlDbType.Int).Value = productsModel.ProductCatId;
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
                command.CommandText = "DELETE FROM Products WHERE Product_Id = @id";
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                command.ExecuteNonQuery();
            };
        }
        public void Edit(ProductsModel productsModel)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"UPDATE Products
                                        SET Product_Name = @name,
                                            Product_Price = @price,
                                            Product_Stock = @stock,
                                            Product_Cat_Id = @catId
                                        WHERE Product_Id = @id";
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsModel.ProductName;
                command.Parameters.Add("@price", SqlDbType.Int).Value = productsModel.ProductPrice;
                command.Parameters.Add("@stock", SqlDbType.Int).Value = productsModel.ProductStock;
                command.Parameters.Add("@catId", SqlDbType.Int).Value = productsModel.ProductCatId;
                command.ExecuteNonQuery();
            }
        }
        public IEnumerable<ProductsModel> GetAll()
        {
            var productsList = new List<ProductsModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Products ORDER BY Product_Id DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.ProductId = (int)reader["Product_Id"];
                        productsModel.ProductName = reader["Product_Name"].ToString();
                        productsModel.ProductPrice = (int)reader["Product_Price"];
                        productsModel.ProductStock = (int)reader["Product_Stock"];
                        productsModel.ProductCatId = (int)reader["Product_Cat_Id"];
                        productsList.Add(productsModel);
                    }
                }
            }
            return productsList;
        }
        public IEnumerable<ProductsModel> GetByValue(string value)
        {
            var productsList = new List<ProductsModel>();
            int productsId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string productsName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT * FROM Products
                                        WHERE Product_Id=@id or Product_Name LIKE @name+ '%'
                                        ORDER BY Product_Id DESC";
                command.Parameters.Add("@id", SqlDbType.Int).Value = productsId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = productsName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var productsModel = new ProductsModel();
                        productsModel.ProductId = (int)reader["Product_Id"];
                        productsModel.ProductName = reader["Product_Name"].ToString();
                        productsModel.ProductPrice = (int)reader["Product_Price"];
                        productsList.Add(productsModel);
                    }
                }
            }
            return productsList;
        }
    }
}
