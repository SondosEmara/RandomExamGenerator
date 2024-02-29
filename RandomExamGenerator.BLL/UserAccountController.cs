﻿using RandomExamGenerator.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomExamGenerator.BLL
{
    public class UserAccountController : BaseController
    {
        public static void AddStudent(UserAccount us)
        {

            Ctxt.UserAccounts.Add(us);
            try
            {
                Ctxt.SaveChanges();
            }
            catch(Exception e)
            {
                
            }
            

        }

        public static void AddDepartment(Department department)
        {

            Ctxt.Departments.Add(department);
            Ctxt.SaveChanges();
        }
    }
}
