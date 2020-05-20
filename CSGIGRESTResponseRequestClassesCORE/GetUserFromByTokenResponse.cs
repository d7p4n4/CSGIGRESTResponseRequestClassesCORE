using CSGIGUserServer;
using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSGIGRESTResponseRequestClassesCORE
{
    public class GetUserFromByTokenResponse : Ac4yServiceResponse
    {
        public User User { get; set; }
        public string Json { get; set; }
    }
}
