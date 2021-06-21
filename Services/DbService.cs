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
        #region Employee
        public static void EmployeeInsert(EmployeeDTOModel employeeModel)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<EmployeeDTOModel>("dbo.ProcEmployeeInsert", employeeModel, commandType: CommandType.StoredProcedure);
            }
        }
        public static List<EmployeeDTOModel> Employees()
        {
            using (var db = OpenSqlConnection())
            {
                return db.Query<EmployeeDTOModel>("dbo.ProcEmployees", commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public static void EmployeeUpdate(EmployeeDTOModel employee)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<EmployeeDTOModel>("dbo.ProcEmployeeUpdate", employee, commandType: CommandType.StoredProcedure);
            }
        }
        public static void EmployeeDelete(int Id)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<EmployeeDTOModel>("dbo.ProcEmployeeDelete", new { Id }, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion
        #region Institute
        public static List<Institute> Institutes()
        {
            using (var db = OpenSqlConnection())
            {
                return db.Query<Institute>("dbo.ProcInstitutes", commandType: CommandType.StoredProcedure).ToList();
            }
        }
        #endregion
        #region Subject
        public static void SubjectInsert(SubjectModel subject)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<EmployeeDTOModel>("dbo.ProcSubjectInsert", subject, commandType: CommandType.StoredProcedure);
            }
        }
        public static List<SubjectModel> Subjects()
        {
            using (var db = OpenSqlConnection())
            {
                return db.Query<SubjectModel>("dbo.ProcSubjects", commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public static void SubjectUpdate(SubjectModel subject)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<EmployeeDTOModel>("dbo.ProcSubjectUpdate", subject, commandType: CommandType.StoredProcedure);
            }
        }
        public static void SubjectDelete(int Id)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<SubjectModel>("dbo.ProcSubjectDelete", new { Id }, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion
    }
}
