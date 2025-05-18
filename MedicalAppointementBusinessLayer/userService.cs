using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MedicalAppointementBusinessLayer.Interfaces;
using MedicalAppointementDataLayer;
using MedicalAppointementDataLayer.Interfaces;
using SharedLayer;

namespace MedicalAppointementBusinessLayer
{
    public class userService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public userService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // Business Layer / Services / UserService.cs
        public IEnumerable<UserDto> GetAllUsers()
        {
            var users = _userRepository.GetAll(); // Gets User entities

            return users.Select(u => new UserDto
            {
                firstName = u.FirstName,
                lastName = u.LastName,
                email = u.Email
            }).ToList();
        }
        /*public string getUserName()
        {
            return _userRepository.GetFirstUsername();
        }*/
    }
}
