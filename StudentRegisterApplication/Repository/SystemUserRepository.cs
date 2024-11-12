using Microsoft.EntityFrameworkCore;
using StudentRegisterApplication.Data;
using StudentRegisterApplication.Model;

namespace StudentRegisterApplication.Repository
{
    internal class SystemUserRepository
    {
        private readonly UserContext _context;

        public SystemUserRepository()
        {
            _context = new UserContext();
        }

        public List<SystemUser> GetAllSystemUsers()
        {
            return [.. _context.SystemUsers];
        }

        public SystemUser GetSystemUser(int id)
        {
            return _context.SystemUsers.Where(i => i.SystemUserId == id).Include(u => u.UserRole).First();
        }

        public void Update(SystemUser user)
        {
            _context.Update(user);
            Save();
        }
        private void Save()
        {
            _context.SaveChanges();
        }
    }
}
