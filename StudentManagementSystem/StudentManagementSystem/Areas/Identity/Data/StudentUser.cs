﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace StudentManagementSystem.Areas.Identity.Data;

// Add profile data for application users by adding properties to the StudentUser class
public class StudentUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

