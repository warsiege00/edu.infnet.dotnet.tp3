using System;
namespace dotnet.tp3.GestaoDeLaboratorios.Models
{
    public class Computador
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Processador { get; set; }
        public string PlacaMae { get; set; }
        public string Memoria { get; set; }
        public string HD { get; set; }
        public string NumeroPatrimonio { get; set; }
        public DateTime DataCompra { get; set; }
    }
}

