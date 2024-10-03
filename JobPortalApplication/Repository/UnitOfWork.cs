﻿using JobPortalApplication.Data;
using JobPortalApplication.Repository.IRepository;

namespace JobPortalApplication.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _context;
        public ISkillRepository SkillRepo { get; private set; }
        public ILevelRepository LevelRepo { get; private set; }
        public ISeekerRepository SeekerRepo { get; private set; }


        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            SkillRepo = new SkillRepository(_context);
            LevelRepo = new LevelRepository(_context);
            SeekerRepo = new SeekerRepository(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
