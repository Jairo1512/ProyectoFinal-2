﻿namespace Empleados.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string NombreCompleto { get; set; }
        public string correo { get; set; }
        public DateOnly FechaContrato { get; set; }
        public bool Activo { get; set; }

    }
}
