namespace Estoque.Application.Produto.Data
{
    public class ListarProdutosResponse
    {
        public int Id { get; set; }
        public string? NomeProduto { get; set; }
        public bool TipoProduto { get; set; }
        public int QntProduto { get; set; }
    }
}