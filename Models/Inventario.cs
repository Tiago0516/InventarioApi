using System.ComponentModel.DataAnnotations;

namespace InventarioApi.Models
{
    public class Inventario
    {
        [Key]
        public int InventarioId { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; } = "";

        [StringLength(255)]
        public string? Descripcion { get; set; }

        public int Cantidad_Stock { get; set; }
        public decimal Precio_Unitario { get; set; }
    }
}
