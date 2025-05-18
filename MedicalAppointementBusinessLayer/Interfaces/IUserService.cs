using SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalAppointementBusinessLayer.Interfaces
{
    public interface IUserService
    {
         IEnumerable<UserDto> GetAllUsers();
    }
}
