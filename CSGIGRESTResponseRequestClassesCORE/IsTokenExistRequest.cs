﻿using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSGIGRESTResponseRequestClassesCORE
{
    public class IsTokenExistRequest : Ac4yServiceRequest
    {
        public string fbToken { get; set; }
    }
}