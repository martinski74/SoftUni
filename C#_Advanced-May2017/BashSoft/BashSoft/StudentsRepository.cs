using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BashSoft
{
    public class StudentsRepository
    {
        public  bool isDataInitialized = false;
        private  Dictionary<string, Dictionary<string, List<int>>> studentsByCourse;

        public  void LoadData(string fileName)
        {
            if (isDataInitialized)
            {
                OutputWriter.DisplayExeption(ExceptionMessages.DataAlreadyInitialisedException);
            return;
               
            }
            else
            {
                OutputWriter.WriteMessageOnNewLine("Reading data...");
            }
        }

        public void UnloadData()
        {
            if (!this.isDataInitialized)
            {
                OutputWriter.DisplayExeption(ExceptionMessages.DataNotInitializedExceptionMessage);
            }
            this.studentsByCourse = new Dictionary<string, Dictionary<string, List<int>>>();
            this.isDataInitialized = false;
        }

        private void ReadData()
        {
            string input = Console.ReadLine();

            while (!string.IsNullOrEmpty(input))
            {
                string[] tokens = input.Split(' ');
                string course = tokens[0];
                string student = tokens[1];
                int mark = int.Parse(tokens[2]);
                //02 Exercise File
                if (studentsByCourse.ContainsKey(course))
                {
                    if (studentsByCourse[course].ContainsKey(student))
                    {
                        studentsByCourse[course][student].Add(mark);
                    }
                    else
                    {
                        studentsByCourse[course].Add(student, new List<int>() { mark });
                    }
                }
                else
                {
                    studentsByCourse.Add(course, new Dictionary<string, List<int>> { { student, new List<int>() { mark } } });
                }

                input = Console.ReadLine();
            }

            isDataInitialized = true;
            OutputWriter.WriteMessageOnNewLine("Data read!");
        }

        private  bool IsQueryForCoursePossible(string courseName)
        {
            if (isDataInitialized)
            {
                if (studentsByCourse.ContainsKey(courseName))
                {
                    return true;
                }
                else
                {
                    OutputWriter.DisplayExeption(ExceptionMessages.InexistingCourseInDataBase);
                }
            }
            else
            {
                OutputWriter.DisplayExeption(ExceptionMessages.DataNotInitializedExceptionMessage);
            }

            return false;
        }

        private  bool IsQueryForStudentPossible(string courseName, string studentUserName)
        {
            if (IsQueryForCoursePossible(courseName) && studentsByCourse[courseName].ContainsKey(studentUserName))
            {
                return true;
            }
            else
            {
                OutputWriter.DisplayExeption(ExceptionMessages.InexistingStudentInDataBase);
            }

            return false;
        }

        public  void GetStudentScoresFromCourse(string courseName, string username)
        {
            if (IsQueryForStudentPossible(courseName, username))
            {
                OutputWriter.PrintStudent(new KeyValuePair<string, List<int>>(username, studentsByCourse[courseName][username]));
            }
        }

        public  void GetAllStudentsFromCourse(string courseName)
        {
            if (IsQueryForCoursePossible(courseName))
            {
                OutputWriter.WriteMessageOnNewLine($"{courseName}:");
                foreach (var studentMarksEntry in studentsByCourse[courseName])
                {
                    OutputWriter.PrintStudent(studentMarksEntry);
                }
            }
        }
    }
}
