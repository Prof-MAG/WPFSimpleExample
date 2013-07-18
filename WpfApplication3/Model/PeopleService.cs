using System.Collections.Generic;

namespace WpfApplication3.Model
{
    public class PeopleService
    {
        public IEnumerable<StudentModel> GetStudents()
        {
            return new List<StudentModel>
            {
                new StudentModel
                {
                    Name = "Vasua",
                    Cource = 2,
                    IsOt4islen = false

                },
                new StudentModel
                {
                    Name = "Jorik",
                    Cource = 4,
                    IsOt4islen = true
                }
            };
        }     
        
        public IEnumerable<WorkerModel> GetWorkers()
        {
            return new List<WorkerModel>
            {
                new WorkerModel
                {
                    Name = "Oleg",
                    Status = "Student"
                },
                new WorkerModel
                {
                    Name = "Alex",
                    Status = "Middle"
                }
            };
        } 
    }
}
