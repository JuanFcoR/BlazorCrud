﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Data
{
    public class Respuesta
    {
        public int Exito { get; set; }
        public string Mensaje { get; set; }
        public List<Cerveza> CervezaData { get; set; }
        public List<Producto> ProductoData { get; set; } 


        public Respuesta()
        {
            this.Exito = 0;
        }
    }
}
