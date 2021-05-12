using System;

namespace Dominio {
    public class Mesero
    {
        string Nombre { get; set; }
        string Apellido { get; set; }
        string TipoDocumento { get; set; }
        string Documento { get; set; }
        string NivelAcademico { get; set; }
        string TelefonoFijo { get; set; }
        string TelefonoCel { get; set; }
        string EmailEmpresa { get; set; }
        string EmailPersonal { get; set; }
        string Direccion { get; set; }
        string Barrio { get; set; }
        string Ciudad { get; set; }
        bool Estado { get; set; }
        bool Estudia { get; set; }
        DateTime FechaNacimiento { get; set; }

        public Mesero()
        {
            
        }
    }
}