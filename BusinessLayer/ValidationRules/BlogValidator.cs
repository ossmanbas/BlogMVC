using EntityLayer.Concreate;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator: AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x=>x.BlogTitle).NotEmpty().WithMessage("Blog Başlığını Boş Bırakamazsınız !");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog İçeriğini Boş Bırakamazsınız !");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Blog Resmini Boş Bırakamazsınız !");
            RuleFor(x => x.Image).NotEmpty().WithMessage("Blog Resmini Boş Bırakamazsınız !");


        }
    }
}
