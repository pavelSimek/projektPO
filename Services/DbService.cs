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
        public static void EmployeeInsert(EmployeeModel employeeModel)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<EmployeeModel>("dbo.ProcEmployeeInsert", employeeModel, commandType: CommandType.StoredProcedure);
            }
        }
        public static List<EmployeeModel> Employees()
        {
            using (var db = OpenSqlConnection())
            {
                return db.Query<EmployeeModel>("dbo.ProcEmployees", commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public static void EmployeeUpdate(EmployeeModel employee)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<EmployeeModel>("dbo.ProcEmployeeUpdate", employee, commandType: CommandType.StoredProcedure);
            }
        }
        public static void EmployeeDelete(int Id)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<EmployeeModel>("dbo.ProcEmployeeDelete", new { Id }, commandType: CommandType.StoredProcedure);
            }
        }

        public static EmployeeModel EmployeeExists(string PartyCode, int Id)
        {
            using (var db = OpenSqlConnection())
            {
                return db.Query<EmployeeModel>("dbo.ProcEmployeeExists", new { PartyCode, Id }, commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }
                #endregion

                #region Institute
                public static List<InstituteModel> Institutes()
        {
            using (var db = OpenSqlConnection())
            {
                return db.Query<InstituteModel>("dbo.ProcInstitutes", commandType: CommandType.StoredProcedure).ToList();
            }
        }
        #endregion

        #region Subject
        public static void SubjectInsert(SubjectModel subject)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<SubjectModel>("dbo.ProcSubjectInsert", subject, commandType: CommandType.StoredProcedure);
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
                db.Query<SubjectModel>("dbo.ProcSubjectUpdate", subject, commandType: CommandType.StoredProcedure);
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

        #region Event
        public static void EventInsert(SubjectModel subject)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<EmployeeModel>("dbo.ProcEventInsert", subject, commandType: CommandType.StoredProcedure);
            }
        }
        public static List<ScheduleEventModel> Events()
        {
            using (var db = OpenSqlConnection())
            {
                return db.Query<ScheduleEventModel>("dbo.ProcEvents", commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public static void EventUpdate(SubjectModel subject)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<EmployeeModel>("dbo.ProcEventUpdate", subject, commandType: CommandType.StoredProcedure);
            }
        }
        public static void EventDelete(int Id)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<SubjectModel>("dbo.ProcEventDelete", new { Id }, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion

        #region StudyGroups
        public static void SubjectStudyGroups(int Id)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<SubjectModel>("dbo.ProcSubjectStudyGroups", new { Id }, commandType: CommandType.StoredProcedure);
            }
        }

        public static void EventInsert(StudyGroupModel subject)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<EmployeeModel>("dbo.ProcEventInsert", subject, commandType: CommandType.StoredProcedure);
            }
        }
        public static List<SubjectModel> StudyGroups()
        {
            using (var db = OpenSqlConnection())
            {
                return db.Query<SubjectModel>("dbo.ProcStudyGroups", commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public static void StudyGroupUpdate(SubjectModel subject)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<EmployeeModel>("dbo.ProcStudyGroupUpdate", subject, commandType: CommandType.StoredProcedure);
            }
        }
        public static void StudyGroupDelete(int Id)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<SubjectModel>("dbo.ProcStudyGroupDelete", new { Id }, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion

        #region 

        #endregion
    }
}
