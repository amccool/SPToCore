﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SPToCore.Model
{
    class SpException
    {
        public string Method { get; set; }
        public string FullName { get; set; }
        public string Schema { get; set; }
        public string StoreProcedure { get; set; }
        public string Message { get; set; }
    }
}