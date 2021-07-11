using projektPO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektPO.Services
{
    public static class WorkingPointsCalculator
    {
        public static double CalculatePoints(WorkingPointEventModel workingPointEventModel)
        {
            double points = 0;
            var workingPointsValues = XmlService.GetWorkingPoints();
            if (workingPointEventModel.Language == Enums.Language.CZ)
            {
                switch (workingPointEventModel.ScheduleEventType)
                {
                    case Enums.ScheduleEventType.Lecture:
                        points = workingPointEventModel.Hours * workingPointsValues.LectureHour;
                        break;
                    case Enums.ScheduleEventType.Seminar:
                        points = workingPointEventModel.Hours * workingPointsValues.SeminarHour;
                        break;
                    case Enums.ScheduleEventType.Exercise:
                        points = workingPointEventModel.Hours * workingPointsValues.ExcerciseHour;
                        break;
                    case Enums.ScheduleEventType.Exam:
                        points = workingPointEventModel.NumberOfStudents * workingPointsValues.ExamGrant;
                        break;
                    case Enums.ScheduleEventType.GradedCredit:
                        points = workingPointEventModel.NumberOfStudents * workingPointsValues.GradedCreditGrant;
                        break;
                    case Enums.ScheduleEventType.Credit:
                        points = workingPointEventModel.NumberOfStudents * workingPointsValues.CreditGrant;
                        break;
                }
            }
            else
            {
                switch (workingPointEventModel.ScheduleEventType)
                {
                    case Enums.ScheduleEventType.Lecture:
                        points = workingPointEventModel.Hours * workingPointsValues.LectureHourEN;
                        break;
                    case Enums.ScheduleEventType.Seminar:
                        points = workingPointEventModel.Hours * workingPointsValues.SeminarHourEN;
                        break;
                    case Enums.ScheduleEventType.Exercise:
                        points = workingPointEventModel.Hours * workingPointsValues.ExcerciseHourEN;
                        break;
                    case Enums.ScheduleEventType.Exam:
                        points = workingPointEventModel.NumberOfStudents * workingPointsValues.ExamGrantEN;
                        break;
                    case Enums.ScheduleEventType.GradedCredit:
                        points = workingPointEventModel.NumberOfStudents * workingPointsValues.GradedCreditGrantEN;
                        break;
                    case Enums.ScheduleEventType.Credit:
                        points = workingPointEventModel.NumberOfStudents * workingPointsValues.CreditGrantEN;
                        break;
                }
            }

            return points;
        }

        public static double CalculateEvent(EventModel model)
        {
            var workingPointModel = new WorkingPointEventModel()
            {
                Hours = model.Hours,
                Language = model.Language,
                NumberOfStudents = model.NumberOfStudents,
                ScheduleEventType = model.ScheduleEventType
            };
            return CalculatePoints(workingPointModel);
        }

        public static double CalculateEvents(int employeeId, Enums.Language? language)
        {
            var employeeEvents = DbService.EmployeeEvents(employeeId);
            double points = 0;
            if (language == Enums.Language.CZ)
            {
                employeeEvents = employeeEvents.Where(x => x.Language == Enums.Language.CZ).ToList();
            }
            foreach (var employeeEvent in employeeEvents.Where(x=> x.Active))
            {
                points += CalculatePoints(employeeEvent);
            }
            return points;
        }

        public static int WorkingHoursCalculation(int employeeId)
        {
            var employeeEvents = DbService.EmployeeEvents(employeeId);
            var hours = 0;
            foreach (var employeeEvent in employeeEvents.Where(x => x.Active))
            {
                hours += employeeEvent.Hours;
            }
            return hours;
        }
    }

}
