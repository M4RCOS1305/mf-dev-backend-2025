using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace mf_dev_backend_2025.Models
{
    [Table("Veiculo")]
    public class Veiculos
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o nome.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Obrigatório informar a placa.")]
        public string Placa { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o ano da fabricação.")]
        [Display(Name = "Ano de fabricação")]
        public int AnoFabricacao { get; set; }

        [Required(ErrorMessage = "Obrigatório informar o ano do modelo.")]
        [Display(Name = "Ano do modelo")]
        public int AnoModelo { get; set; }
    }
}
