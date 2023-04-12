
using BusinessLayer.Concrete;
using CengizShip.Models;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CengizShip.ViewComponents
{
    public class CommentListByBlog:ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id)
        {
         
            var values = cm.GetList(id);
            
          return View(values);
        }
    }
}
