using Microsoft.AspNetCore.Mvc;
using Beautique.DataAccess.Repository.IRepository;
using Beautique.Utility;
using System.Security.Claims;
namespace BeautiqueWeb.ViewComponents
{
    public class ShoppingCartViewComponent : ViewComponent {

        private readonly IUnitOfWork _unitOfWork;
        public ShoppingCartViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity?.FindFirst(ClaimTypes.NameIdentifier);

            if (claim != null)
            {
                int count = _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == claim.Value).Count();
                HttpContext.Session.SetInt32(SD.SessionCart, count);
                return View(count);
            }
            else
            {
                HttpContext.Session.Clear();
                return View(0);
            }
        }


    }
}
