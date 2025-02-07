﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Globalization;

namespace CORE.APP.Features
{
    public abstract class Handler
    {
        protected Handler(CultureInfo cultureInfo)
        {
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            Thread.CurrentThread.CurrentUICulture = cultureInfo;
        }

        public CommandResponse Success(string message = "", int id = 0) => new CommandResponse(true, message, id);
        public CommandResponse Error(string message = "") => new CommandResponse(false, message);
    }
}