﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Entity
{
    public  class ContactDb
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string? Subject { get; set; }
        public string? Message { get; set; }
        public DateTime  Date   { get; set; }

    }
}
