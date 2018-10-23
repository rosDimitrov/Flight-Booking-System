﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABS.Interfaces
{
    public interface IAirportValidator
    {
        string Message
        {
            get;
        }
        bool ValidateAirportName(string name);
    }
}
