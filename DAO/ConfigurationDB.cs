using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace DAO
{
    public static class ConfigurationDB
    {
        public static string getJugadoresConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["EquipoFutbol"].ConnectionString;
        }
    }
}
