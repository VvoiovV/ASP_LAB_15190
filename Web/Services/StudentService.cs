using Data;
using Data.Entities;
using System;
using WebApplication1.Mappers;
using WebApplication1.Models;

namespace WebApplication1.Services
{
    public class StudentService : IStudentService
    {
        private UniversityContext _context;

        public StudentService(UniversityContext context)
        {
            _context = context;
        }

        public int Add(StudentViewModel contact)
        {
            var e = _context.Users.Add(StudentMapper.ToEntity(contact));
            _context.SaveChanges();
            return e.Entity.Id;
        }

        public void Delete(int id)
        {
            UserEntity? find = _context.Users.Find(id);
            if (find != null)
            {
                _context.Users.Remove(find);
            }
        }

        public List<StudentViewModel> FindAll()
        {
            return _context.Users.Select(e => StudentMapper.FromEntity(e)).ToList(); ;
        }

        public StudentViewModel? FindById(int id)
        {
            return StudentMapper.FromEntity(_context.Users.Find(id));
        }

        public void Update(StudentViewModel contact)
        {
            _context.Users.Update(StudentMapper.ToEntity(contact));
        }
    }
}
