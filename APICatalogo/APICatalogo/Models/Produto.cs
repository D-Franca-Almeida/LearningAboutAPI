using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APICatalogo.Models
{
    [Table("Produtos")]
    public class Produto 
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required]
        [StringLength(80)]
        public string Nome { get; set; }

        [Required]
        [StringLength(300)]
        public string Descricao { get; set; }

        [Required]
        public decimal Preco { get; set; }

        [Required]
        [StringLength(300)]
        public string ImagemUrl { get; set; }

        public float Estoque { get; set; }
        public DateTime DataCadastro { get; set; }

        //public DateTime DataCadastro
        //{
        //    get
        //    {
        //        return this.dataCadastro.HasValue
        //           ? this.dataCadastro.Value
        //           : DateTime.Now;
        //    }

        //    set { this.dataCadastro = value; }
        //}

        //private DateTime? dataCadastro = null;

        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
    }
}
