using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCrud.Data
{
    public partial class Cerveza
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
    }
}
