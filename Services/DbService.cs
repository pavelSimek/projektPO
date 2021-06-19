using projektPO.Models;
using System.Data.SqlClient;
using Dapper;
using System.Data;
using System.Collections.Generic;
using System.Linq;

namespace projektPO.Services
{
    public static class DbService
    {
        private static SqlConnection OpenSqlConnection()
        { 
            return new SqlConnection(GetConnectionString());
        }

        static private string GetConnectionString()
        {

            return "Server= localhost; Database= databasePO; Integrated Security=True;";
        }
        public static void EmployeeInsert(EmployeeModel employeeModel)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<EmployeeModel>("dbo.ProcEmployeeInsert", employeeModel, commandType: CommandType.StoredProcedure);
            }
        }
        public static List<Employee> Employees()
        {
            using (var db = OpenSqlConnection())
            {
                return db.Query<Employee>("dbo.ProcEmployees", commandType: CommandType.StoredProcedure).ToList();
            }
        }
    }
}
