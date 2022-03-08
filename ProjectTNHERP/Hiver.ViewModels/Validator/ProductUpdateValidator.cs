using FluentValidation;
using Hiver.ViewModels.Catalog.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hiver.ViewModels.Validator
{
    public class ProductUpdateValidator : AbstractValidator<ProductUpdateRequest>
    {
        public ProductUpdateValidator()
        {
            RuleFor(x => x.Symbol).NotEmpty().WithMessage("Không được để trống");
            RuleFor(x => x.Width).NotEmpty().WithMessage("Không được để trống");
            RuleFor(x => x.Height).NotEmpty().WithMessage("Không được để trống");
        }
    }
}
