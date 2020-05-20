using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSGIGRESTResponseRequestClassesCORE
{
    public class IsUnknownOrInvalidTokenRequest : Ac4yServiceRequest
    {
        public string fbToken { get; set; }
    }
}
