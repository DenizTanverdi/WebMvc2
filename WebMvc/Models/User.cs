﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMvc.Models
{
    public class User:BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}