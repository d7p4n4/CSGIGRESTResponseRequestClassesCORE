using CSGIGUserServer;
using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSGIGRESTResponseRequestClassesCORE
{
    public class LoginRequestResponse : Ac4yServiceResponse
    {
        public AuthenticationRequest AuthenticationRequest { get; set; }
        public string fbToken { get; set; }
    }
}

