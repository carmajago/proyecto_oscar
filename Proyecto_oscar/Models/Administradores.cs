﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_oscar.Models
{
    public class Administradores
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string contrasena { get; set; }
        public int privilegios { get; set; }
    }
}