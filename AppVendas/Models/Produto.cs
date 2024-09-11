namespace AppVendas.Models
{
    public class Produto
    {
        public Guid ProdutoId { get; set; }
        public string ProdutoNome { get; set; }
        public double Valor { get; set; }
        public double QntdeEstoque { get; set; }
        public Boolean CadastroAtivo { get; set; }
        //chave estrangeira //
        public Guid CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

    }
}
