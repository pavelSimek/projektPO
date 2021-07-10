using projektPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektPO.Services
{
    public static class EventGenerator
    {
        public static void GenerateEventsAfterPairing(StudyGroupSubjectModel model)
        {
            var subject = DbService.Subject(model.SubjectID.Value);
            var studyGroup = DbService.StudyGroup(model.StudyGroupID.Value);
            DbService.StudyGroupSubjectDelete( 
                new StudyGroupSubjectModel() 
                {
                    StudyGroupID = model.StudyGroupID, 
                    SubjectID = model.SubjectID 
                });

            double numberOfEvents = Math.Ceiling(((double)studyGroup.NumberOfStudents / (double)subject.ClassSize));
            double studentsRemaining = studyGroup.NumberOfStudents;
            
            for (int i = 0; i < numberOfEvents; i++)
            {
                var finalStudentsNumber = Math.Ceiling(studentsRemaining / (numberOfEvents - i));
                studentsRemaining = studentsRemaining - finalStudentsNumber;

                if (subject.ExerciseHours > 0)
                {
                    var createdEvent = PrepareEvent(subject, Enums.ScheduleEventType.Exercise);
                    createdEvent.Hours = subject.ExerciseHours;
                    createdEvent.NumberOfStudents = (int)finalStudentsNumber;
                    createdEvent.StudyGroupId = model.StudyGroupID;
                    DbService.EventInsert(createdEvent);
                }
                if (subject.SeminarHours > 0)
                {
                    var createdEvent = PrepareEvent(subject, Enums.ScheduleEventType.Seminar);
                    createdEvent.Hours = subject.SeminarHours;
                    createdEvent.NumberOfStudents = (int)finalStudentsNumber;
                    createdEvent.StudyGroupId = model.StudyGroupID;
                    DbService.EventInsert(createdEvent);
                }
            }

            if (subject.LectureHours > 0)
            {
                var createdEvent = PrepareEvent(subject, Enums.ScheduleEventType.Lecture);
                createdEvent.Hours = subject.LectureHours;
                createdEvent.NumberOfStudents = studyGroup.NumberOfStudents;
                createdEvent.StudyGroupId = model.StudyGroupID;
                DbService.EventInsert(createdEvent);
            }
        }

        public static EventModel PrepareEvent(SubjectModel subject, Enums.ScheduleEventType eventType)
        {
            var name = string.Empty;
            switch (eventType)
            {
                case Enums.ScheduleEventType.Lecture:
                    name = "Přednáška - ";
                    break;
                case Enums.ScheduleEventType.Seminar:
                    name = "Seminář - ";
                    break;
                case Enums.ScheduleEventType.Exercise:
                    name = "Cvičení - ";
                    break;
                case Enums.ScheduleEventType.Exam:
                    name = "Zkošuka - ";
                    break;
                case Enums.ScheduleEventType.GradedCredit:
                    name = "Klasifikovaný žápočet - ";
                    break;
                case Enums.ScheduleEventType.Credit:
                    name = "Zápočet - ";
                    break;
            }

            var eventM = new EventModel()
            {
                SubjectID = subject.Id,
                Name = name + subject.Name,
                Weeks = subject.Weeks,
                ScheduleEventType = eventType,
                Language = subject.Language,
                Active = true,
                EmployeeID = null
            };
            return eventM;
        }
        public static void GenerateEventsAfterStudyGroupChange(int studyGroupId)
        {
            var studyGroup = DbService.StudyGroup(studyGroupId);
            var events = DbService.EventByStudyGroupSubject(studyGroupId, null);
            var subjects = new List<SubjectModel>();
            foreach (var subjectId in events.Select(x => x.SubjectID).Distinct())
            {
                if(subjectId.HasValue)
                    subjects.Add(DbService.Subject(subjectId.Value));
            }

            foreach (var subject in subjects)
            {
                double numberOfEvents = Math.Ceiling(((double)studyGroup.NumberOfStudents / (double)subject.ClassSize));
                double studentsRemaining = studyGroup.NumberOfStudents;

                var selectedEvents = events.Where(x => x.SubjectID == subject.Id.Value).ToList();
                var seminarEvents = selectedEvents.Where(x => x.ScheduleEventType == Enums.ScheduleEventType.Seminar).OrderByDescending(x => x.EmployeeID).ToList();
                var exerciseEvents = selectedEvents.Where(x => x.ScheduleEventType == Enums.ScheduleEventType.Exercise).OrderByDescending(x => x.EmployeeID).ToList();
                for (int i = 0; i < numberOfEvents; i++)
                {
                    var finalStudentsNumber = Math.Ceiling(studentsRemaining / (numberOfEvents - i));
                    studentsRemaining = studentsRemaining - finalStudentsNumber;
                    if (subject.ExerciseHours > 0) { 
                        var createdEvent = PrepareEvent(subject, Enums.ScheduleEventType.Exercise);
                        createdEvent.Hours = subject.ExerciseHours;
                        createdEvent.NumberOfStudents = (int)finalStudentsNumber;
                        createdEvent.StudyGroupId = studyGroupId;
                        if (exerciseEvents[i] != null)
                            createdEvent.EmployeeID = exerciseEvents[i].EmployeeID;
                        DbService.EventInsert(createdEvent);
                    }
                    if (subject.SeminarHours > 0)
                    { 
                        var createdEvent = PrepareEvent(subject, Enums.ScheduleEventType.Seminar);
                        createdEvent.Hours = subject.SeminarHours;
                        createdEvent.NumberOfStudents = (int)finalStudentsNumber;
                        createdEvent.StudyGroupId = studyGroupId;
                        if (seminarEvents[i] != null)
                            createdEvent.EmployeeID = seminarEvents[i].EmployeeID;
                        DbService.EventInsert(createdEvent);
                    }
                }

                if (subject.LectureHours > 0)
                {
                    var createdEvent = PrepareEvent(subject, Enums.ScheduleEventType.Lecture);
                    createdEvent.Hours = subject.LectureHours;
                    createdEvent.NumberOfStudents = studyGroup.NumberOfStudents;
                    createdEvent.StudyGroupId = studyGroupId;
                    createdEvent.EmployeeID = selectedEvents.Where(x=> x.ScheduleEventType == Enums.ScheduleEventType.Lecture).FirstOrDefault()?.EmployeeID;
                    DbService.EventInsert(createdEvent);
                }

                if ( selectedEvents.Count > 0)
                {
                    foreach(var sEvent in selectedEvents)
                    {
                        DbService.EventDelete(sEvent.Id);
                    }
                }
            }  
        }

        public static void GenerateEventAfterSubjectChanged(int subjectId)
        {
            var events = DbService.EventByStudyGroupSubject(null, subjectId);
            var studyGroups = new List<StudyGroupModel>();
            foreach (var studyGroupId in events.Select(x => x.StudyGroupId).Distinct())
            {
                if (studyGroupId.HasValue)
                    studyGroups.Add(DbService.StudyGroup(studyGroupId.Value));
            }
            var subject = DbService.Subject(subjectId);

            foreach (var studyGroup in studyGroups)
            {
                double numberOfEvents = Math.Ceiling(((double)studyGroup.NumberOfStudents / (double)subject.ClassSize));
                double studentsRemaining = studyGroup.NumberOfStudents;

                var selectedEvents = events.Where(x => x.StudyGroupId == studyGroup.Id).ToList();
                var seminarEvents = selectedEvents.Where(x => x.ScheduleEventType == Enums.ScheduleEventType.Seminar).OrderByDescending(x => x.EmployeeID).ToList();
                var exerciseEvents = selectedEvents.Where(x => x.ScheduleEventType == Enums.ScheduleEventType.Exercise).OrderByDescending(x => x.EmployeeID).ToList();

                for (int i = 0; i < numberOfEvents; i++)
                {
                    var finalStudentsNumber = Math.Ceiling(studentsRemaining / (numberOfEvents - i));
                    studentsRemaining = studentsRemaining - finalStudentsNumber;
                    if (subject.ExerciseHours > 0)
                    {
                        var createdEvent = PrepareEvent(subject, Enums.ScheduleEventType.Exercise);
                        createdEvent.Hours = subject.ExerciseHours;
                        createdEvent.NumberOfStudents = (int)finalStudentsNumber;
                        createdEvent.StudyGroupId = studyGroup.Id;
                        if (exerciseEvents[i] != null)
                            createdEvent.EmployeeID = exerciseEvents[i].EmployeeID;
                        DbService.EventInsert(createdEvent);
                    }
                    if (subject.SeminarHours > 0)
                    {
                        var createdEvent = PrepareEvent(subject, Enums.ScheduleEventType.Seminar);
                        createdEvent.Hours = subject.SeminarHours;
                        createdEvent.NumberOfStudents = (int)finalStudentsNumber;
                        createdEvent.StudyGroupId = studyGroup.Id;
                        if (seminarEvents[i] != null)
                            createdEvent.EmployeeID = seminarEvents[i].EmployeeID;
                        DbService.EventInsert(createdEvent);
                    }
                }

                if (subject.LectureHours > 0)
                {
                    var createdEvent = PrepareEvent(subject, Enums.ScheduleEventType.Lecture);
                    createdEvent.Hours = subject.LectureHours;
                    createdEvent.NumberOfStudents = studyGroup.NumberOfStudents;
                    createdEvent.StudyGroupId = studyGroup.Id;
                    createdEvent.EmployeeID = selectedEvents.Where(x => x.ScheduleEventType == Enums.ScheduleEventType.Lecture).FirstOrDefault()?.EmployeeID;
                    DbService.EventInsert(createdEvent);
                }

                if (selectedEvents.Count > 0)
                {
                    foreach (var sEvent in selectedEvents)
                    {
                        DbService.EventDelete(sEvent.Id);
                    }
                }
            }
        }
    }
}
