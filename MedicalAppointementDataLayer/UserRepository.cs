using MedicalAppointementDataLayer.Interfaces;
using MedicalAppointementDataLayer.Repositories;
using SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointementDataLayer
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly MedicalAppContext _context;

        public UserRepository(MedicalAppContext context) : base(context) 
        {
            _context = context;
        }
        

        public string GetFirstUsername()
        {
            return _context.Users
                .Select(u => u.FirstName)
                .FirstOrDefault();
        }
     

    }
}
