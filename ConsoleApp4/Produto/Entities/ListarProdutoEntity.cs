namespace Estoque.Domain.Model.Produto.Entities
{
    internal class ListarProdutoEntity
    {
        public int Id { get; set; }
        public string? Nome_Produto { get; set; }
        public bool Tipo_Produto { get; set; }
        public int Qnt_Produto { get; set; }
    }
}