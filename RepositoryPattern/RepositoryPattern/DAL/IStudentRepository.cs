using RepositoryPattern.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace RepositoryPattern.DAL
{
    public interface IStudentRepository:IDisposable
    {
        //READ
        Task<List<Student>> GetStudents();
        Task<Student> GetStudenttByID(int? studentId);
        //CREATE
        void InsertStudent(Student student);
        //DELETE
        void DeleteStudent(int StudentId);
        //UPDATE
        void UpdateStudent(Student student);

        Task<int> Save();

    }
}