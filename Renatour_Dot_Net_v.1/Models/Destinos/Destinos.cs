using System.ComponentModel.DataAnnotations;

namespace Renatour_Dot_Net_v._1.Views.Destinos
{
    public class Destinos
    {
        public int Id { get; set; }
        public string? Nome { get; set; }
              
        public string Descricao { get; set; }
        public string? Preco { get; set; }
        
    }
}
