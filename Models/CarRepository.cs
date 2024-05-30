using Microsoft.Data.SqlClient;
using Models;
using System.Data.SqlTypes;
using System.Text;
namespace Repositories
{
    public class CarRepository
    {
        string strConn = "Server=127.0.0.1; Database=ProjetoAula02; User Id=sa; Password=SqlServer2019!; TrustServerCertificate=True";
        SqlConnection conn;
        public CarRepository()
        {
            conn = new SqlConnection(strConn);
            conn.Open();
        }
        public bool Insert(Car car)
        {
            try
            {
                string sql = "INSERT INTO TB_Car (Name, Color, Year) VALUES (@Name, @Color, @Year)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@Name", car.Name));
                cmd.Parameters.Add(new SqlParameter("@Color", car.Color));
                cmd.Parameters.Add(new SqlParameter("@Year", car.Year));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool Update(Car car)
        {
            try
            {
                string sql = "UPDATE TB_Car SET Name = @Name, Color = @Color, Year = @Year WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@Name", car.Name));
                cmd.Parameters.Add(new SqlParameter("@Color", car.Color));
                cmd.Parameters.Add(new SqlParameter("@Year", car.Year));
                cmd.Parameters.Add(new SqlParameter("@Id", car.Id));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public bool Delete(int id)
        {
            try
            {
                string sql = "DELETE FROM TB_Car WHERE Id = @Id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.Add(new SqlParameter("@Id", id));
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
            finally
            {
                conn.Close();
            }
        }
        public List<Car> GetAll(int id)
        {
            List<Car> cars = new List<Car>();
            StringBuilder sb = new StringBuilder();
            sb.Append("SELECT Id, Name, Color, Year FROM TB_Car WHERE Id = @Id");
            try
            {
                SqlCommand cmd = new SqlCommand(sb.ToString(), conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Car car = new Car();
                    car.Id = reader.GetInt32(0);
                    car.Name = reader.GetString(1);
                    car.Color = reader.GetString(2);
                    car.Year = reader.GetInt32(3);
                    cars.Add(car);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conn.Close();
            }
            return cars;
        }
        public List<Car> Get()
        {
            return new List<Car>();
        }
    }
}