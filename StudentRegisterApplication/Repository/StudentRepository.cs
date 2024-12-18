﻿using Microsoft.EntityFrameworkCore;
using StudentRegisterApplication.Data;
using StudentRegisterApplication.Model;

namespace StudentRegisterApplication.Repository
{
    internal class StudentRepository
    {
        private readonly StudentContext _context;

        public StudentRepository()
        {
            _context = new StudentContext();
        }

        public void Create(Student student)
        {
            _context.Add(student);
            Save();
        }

        public void Delete(Student student)
        {
            _context.Remove(student);
            Save();
        }

        public void Edit(Student student)
        {
            _context.Update(student);
            Save();
        }

        public List<Student> GetByPhrase(string phrase)
        {
            return _context.Students.Where(f => f.FirstName.Contains(phrase) || f.LastName.Contains(phrase) || f.Address.City.Contains(phrase) || f.Address.Street.Contains(phrase) || f.ProgrammingKnowledge.Any(k => k.Language.Contains(phrase))).ToList();
        }
        public Student GetById(int id)
        {
            return _context.Students.FirstOrDefault(i => i.Id == id);
        }

        public Student GetFullById(int id)
        {
            return _context.Students.Where(i => i.Id == id).Include(a => a.Address).Include(p => p.ProgrammingKnowledge).First();
        }

        public List<Student> GetAll()
        {
            return [.. _context.Students.Include(a => a.Address).Include(p => p.ProgrammingKnowledge) ];
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
