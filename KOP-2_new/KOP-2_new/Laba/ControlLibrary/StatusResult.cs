﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlLibrary
{
    public enum StatusResult
    {
        EmailsSend,
        NoSubject,
        NoMessage,
        NoAddressees,
        HaveError
    }
}
