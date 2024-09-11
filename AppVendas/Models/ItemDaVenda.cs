namespace AppVendas.Models
{
    public class ItemDaVenda
    {
        public Guid ItemDaVendaId { get; set; }
        public Guid Vendaid { get; set; }
        //relacionamento com a tabela produto//
        public Guid? Venda { get; set; }
        public Guid ProdutoId { get; set; }
        public Produto? Produto { get; set; }

        public double QtdadeVendida { get; set; }
        public double ValorTotalDoItem { get; set; }

    }
}
