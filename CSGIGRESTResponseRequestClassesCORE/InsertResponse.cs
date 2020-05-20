using CSGIGUserServer;
using Modul.Final.Class;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSGIGRESTResponseRequestClassesCORE
{
    public class InsertResponse : Ac4yServiceResponse
    {
        public User User { get; set; }
    }
}
