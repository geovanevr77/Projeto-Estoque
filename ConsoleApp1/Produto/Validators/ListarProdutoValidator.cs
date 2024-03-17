using Estoque.Application.Produto.Queries;
using FluentValidation;

namespace Estoque.Application.Produto.Validators
{
    public class ListarProdutoValidator : 
        AbstractValidator<ListarProdutoQuery>
    {
        public ListarProdutoValidator() 
        {
            When(x => string.IsNullOrEmpty(x.NomeProduto) is false, () =>
            {
                CascadeMode = CascadeMode.Stop;

                RuleFor(x => x.NomeProduto).SetAsyncValidator();
            });
        }
    }
}