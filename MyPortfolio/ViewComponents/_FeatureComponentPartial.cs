using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using MyPortfolio.DAL.Context;

namespace MyPortfolio.ViewComponents
{
    public class _FeatureComponentPartial:ViewComponent
    {
        MyPortfolioContext portfolioContext= new MyPortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values= portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
