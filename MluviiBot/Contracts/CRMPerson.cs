﻿using System;

namespace MluviiBot.Contracts
{
    public class CRMPerson
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}