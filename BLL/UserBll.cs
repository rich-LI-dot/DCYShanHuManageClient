﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class UserBll
    {
        UserDal udal = new();
        public bool UserLogin(string uid, string pwd,int userkind)
        {
            int res = udal.UserLogin(uid,pwd,userkind).Rows.Count;
            if(res>=1)
                return true;
            return false;
        }

        public DataTable GetAllUser()
        {
            return udal.GetAllUser();
        }
    }
}
