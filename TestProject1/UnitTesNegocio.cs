using System;
using Xunit;
using Entidades;
using ReglasDeNegocio;

namespace TestProject1
{
    public class UnitTesNegocio
    {
        [Fact]
        public void Test1()
        {
            Comunidad comunidad = new Comunidad();
            comunidad.Nombre = "Noche Buena";
            comunidad.Precio = 1500.00;
            string connectionString = "workstation id=WokAndRoll.mssql.somee.com;packet size=4096;user id=chesky22_SQLLogin_1;pwd=44a9mwmwsr;data source=WokAndRoll.mssql.somee.com;persist security info=False;initial catalog=WokAndRoll";

            ComunidadReglasDeNegocio negocio = new ComunidadReglasDeNegocio(connectionString);
            negocio.crearComunidad(comunidad);
            
        }
    }
}
