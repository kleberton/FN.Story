using System;

namespace FN.Store.UI.Models
{
    public class Entity
    {        
        public int Id { get; set; }
        public DateTime DataCadastro { get; set; } = DateTime.Now;
    }
}
