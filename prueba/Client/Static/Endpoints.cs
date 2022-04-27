using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prueba.Client.Static
{
    public static class Endpoints
    {

        public static string Prefix = "api";

        public static string PersonsEndpoint = $"{Prefix}/people";
        public static string CountrysEndpoint = $"{Prefix}/countries";
    }
}
