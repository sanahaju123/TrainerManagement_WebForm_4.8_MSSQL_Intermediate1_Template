﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrainerManagementApp.Model
{
    public class TrainerModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}