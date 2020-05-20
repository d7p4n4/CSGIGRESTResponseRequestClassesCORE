using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSGIGRESTResponseRequestClassesCORE
{
    public class CheckSerialNumberObjectRequest : Ac4yServiceRequest
    {
        public int SerialNumber { get; set; }
        public string fbToken { get; set; }
    }
}
