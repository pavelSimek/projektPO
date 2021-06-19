using projektPO.Models;
using System.Data.SqlClient;
using Dapper;
using System.Data;

namespace projektPO.Services
{
    public class DbService
    {
        private SqlConnection OpenSqlConnection()
        { 
            return new SqlConnection(GetConnectionString());
        }

        static private string GetConnectionString()
        {

            return "Server= localhost; Database= databasePO; Integrated Security=True;";
        }
        public void EmployeeInsert(EmployeeModel employeeModel)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<EmployeeModel>("dbo.ProcEmployeeInsert", employeeModel, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
