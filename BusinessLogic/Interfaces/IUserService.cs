﻿using BusinessLogic.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface IUserService
    {
       Task<RegistrationResult> RegisterUser(RegisterDto registerDto);
    }
}
