using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using RepositoryPattern.Models;
using System.Data.Entity;

namespace RepositoryPattern.DAL
{
    public class StudentRepository : IStudentRepository, IDisposable
    {
        private RepositoryPatternContext _context;
        private bool disposed = false;

        public StudentRepository(RepositoryPatternContext c)
        {
            this._context = c;
        }


        public void DeleteStudent(int StudentId)
        {
            Student s = _context.Students.Find(StudentId);
            _context.Students.Remove(s);
        }

        public Task<List<Student>> GetStudents()
        {
            return _context.Students.ToListAsync();
        }

        public Task<Student> GetStudenttByID(int? studentId)
        {
            return _context.Students.FindAsync(studentId);
        }

        public void InsertStudent(Student student)
        {
            _context.Students.Add(student);
        }

        public Task<int> Save()
        {
            return _context.SaveChangesAsync();
        }

        public void UpdateStudent(Student student)
        {
            _context.Entry(student).State = EntityState.Modified;
        }

        //CLEAN UP
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}