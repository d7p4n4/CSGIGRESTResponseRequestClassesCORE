using CSGIGUserServer;
using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSGIGRESTResponseRequestClassesCORE
{
    public class SignUpRequestRequest : Ac4yServiceRequest
    {
        public string fbToken { get; set; }
        public User User { get; set; }

    }
}
