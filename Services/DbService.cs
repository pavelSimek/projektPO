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
        public static SubjectModel Subject(int id)
        {
            using (var db = OpenSqlConnection())
            {
                return db.Query<SubjectModel>("dbo.ProcSubject", new { id }, commandType: CommandType.StoredProcedure).FirstOrDefault();
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
        public static void EventInsert(EventModel model)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<EventModel>("dbo.ProcEventInsert", model, commandType: CommandType.StoredProcedure);
            }
        }
        public static List<EventModel> Events()
        {
            using (var db = OpenSqlConnection())
            {
                return db.Query<EventModel>("dbo.ProcEvents", commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static List<EventModel> EventsByEmployee(int employeeId)
        {
            using (var db = OpenSqlConnection())
            {
                return db.Query<EventModel>("dbo.ProcEventsByEmployee", new { EmployeeId = employeeId}, commandType: CommandType.StoredProcedure).ToList();
            }
        }

        public static void EventUpdate(EventModel model)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<EmployeeModel>("dbo.ProcEventUpdate", model, commandType: CommandType.StoredProcedure);
            }
        }
        public static void EventDelete(int Id)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<SubjectModel>("dbo.ProcEventDelete", new { Id }, commandType: CommandType.StoredProcedure);
            }
        }

        public static List<EventModel> EventByStudyGroupSubject(int? StudyGroupId, int? SubjectId)
        {
            using (var db = OpenSqlConnection())
            {
               return db.Query<EventModel>("dbo.ProcEventByStudyGroupSubject", new { StudyGroupId = StudyGroupId, SubjectId = SubjectId }, commandType: CommandType.StoredProcedure).ToList();
            }
            
        }
        #endregion

        #region StudyGroups
        public static List<StudyGroupModel> SubjectStudyGroups(int SubjectId)
        {
            using (var db = OpenSqlConnection())
            {
                return db.Query<StudyGroupModel>("dbo.ProcStudyGroupBySubject", new { SubjectId = SubjectId }, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public static StudyGroupModel StudyGroup(int Id)
        {
            using (var db = OpenSqlConnection())
            {
                return db.Query<StudyGroupModel>("dbo.ProcStudyGroup", new { Id },commandType: CommandType.StoredProcedure).FirstOrDefault();
            }
        }

        public static List<StudyGroupModel> StudyGroups()
        {
            using (var db = OpenSqlConnection())
            {
                return db.Query<StudyGroupModel>("dbo.ProcStudyGroups", commandType: CommandType.StoredProcedure).ToList();
            }
        }
        public static void StudyGroupUpdate(StudyGroupModel subject)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<StudyGroupModel>("dbo.ProcStudyGroupUpdate", subject, commandType: CommandType.StoredProcedure);
            }
        }
        public static void StudyGroupInsert(StudyGroupModel subject)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<StudyGroupModel>("dbo.ProcStudyGroupInsert", subject, commandType: CommandType.StoredProcedure);
            }
        }

        public static void StudyGroupDelete(int Id)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<StudyGroupModel>("dbo.ProcStudyGroupDelete", new { Id }, commandType: CommandType.StoredProcedure);
            }
        }
        #endregion

        #region SubjectStudyGroups
        public static void StudyGroupSubjectInsert(StudyGroupSubjectModel model)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<StudyGroupSubjectModel>("dbo.ProcSubjectStudyGroupInsert", model, commandType: CommandType.StoredProcedure);
            }
        }

        public static void StudyGroupSubjectDelete(StudyGroupSubjectModel model)
        {
            using (var db = OpenSqlConnection())
            {
                db.Query<StudyGroupSubjectModel>("dbo.ProcSubjectStudyGroupDelete",  model , commandType: CommandType.StoredProcedure);
            }
        }
        #endregion

        #region WorkingPointsSelection
        public static List<WorkingPointEventModel> EmployeeEvents(int EmployeeId)
        {
            using (var db = OpenSqlConnection())
            {
                return db.Query<WorkingPointEventModel>("dbo.ProcEmployeeEvents", new { EmployeeId = EmployeeId }, commandType: CommandType.StoredProcedure).ToList();
            }
        }
        #endregion
    }
}
