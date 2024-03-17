using Estoque.Application.Produto.Data;
using Mapster;

namespace Estoque.Application.Produto.Mappings
{
    internal class ListarProdutosMapping : IRegister
    {
        public void Register(TypeAdapterConfig config)
        {
            config.NewConfig<ListarProdutosEntity, ListarProdutosResponse>()
                .Map(dest => dest.Id, src => src.Id)
                .Map(dest => dest.Nome_Produto, src => src.NomeProduto)
                .Map(dest => dest.Tipo_Produto, src => src.TipoProduto)
                .Map(dest => dest.Qnt_Produto, src => src.QntProduto);
        }
    }
}