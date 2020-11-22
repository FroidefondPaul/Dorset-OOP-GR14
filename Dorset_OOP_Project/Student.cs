﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Dorset_OOP_Project
{
    public class Student : User
    {
        public List<Classroom> ClassroomStudying { get; set; }
        public List<Attendance> Attendances { get; set; }

        public Student(string lastName, string firstName) : base(lastName, firstName)
        {
            Attendances = new List<Attendance>();
            ClassroomStudying = new List<Classroom>();
        }
        public Student(string lastName, string firstName, string email, string password) : base(lastName, firstName, email, password)
        {
            
        }

        public Student(string lastName, string firstName, string email, string password, int userID) : base(lastName, firstName, email, password, userID)
        {
            
        }
    }
}
