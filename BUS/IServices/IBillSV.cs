﻿using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.IServices
{
    internal interface IBillSV
    {
        public List<Hoadon> GetHoadons(string search);
    }
}