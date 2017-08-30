﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UowMVC.Domain
{
    public class DepartmentRelationship : BaseEntity
    {
        public virtual Department Department
        {
            set; get;
        }

        public virtual ApplicationUser User
        {
            set; get;
        }
    }
}
