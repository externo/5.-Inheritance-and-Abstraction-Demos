﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Company_Hierarchy
{
    interface ISalesEmployee
    {
        List<Sale> SetOfSales { get; set; }
    }
}
