
using Microsoft.Data.SqlClient;
using System.Data;

namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        string connectionString = "Data Source=DESKTOP-A1NJHOG;Initial Catalog=EmployeeDetails;Integrated Security=True;Encrypt=False;";
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            //int input = int.Parse(Console.ReadLine());
            string query1 = "SELECT * FROM EmployeeInfo WHERE employee_id=1";
            using (SqlCommand command = new SqlCommand(query1, connection))
            { 
                /*
                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.Parameters.Add("id",SqlDbType.Int).Value=input;
                */
                Console.Write(command.ExecuteNonQuery());
                //SqlDataReader reader = command.ExecuteNonQuery();
                //while (reader.Read())
                //{
                  //  Console.WriteLine(reader.GetString(0));
                //}
            }



































/*
            string query2 = "SELECT Employee_id,EmployeeDept, Salary FROM EmployeeInfo";
            using (SqlCommand command = new SqlCommand(query2, connection))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    Dictionary<int, string[]> myDetails = new Dictionary<int, string[]>();
                    while (reader.Read())
                    {
                        myDetails.Add(reader.GetInt32(0),new string[] { reader.GetString(1),reader.GetString(2)});
                    }
                    foreach(var key in myDetails.Keys)
                    {
                        Console.WriteLine(key + "      " + myDetails[key][0]+"        "+ myDetails[key][1]);
                    }
                }
            }
*/
        }
        Console.ReadLine();
    }
}