using BusinessLayer.Concreate;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace MvcLayer.ViewComponents.Notification
{
    public class NotificationList : ViewComponent
    {
        NotificationManager nm = new NotificationManager(new EFNotificationRepository());

        public IViewComponentResult Invoke()
        {
            var values = nm.GetList();
            return View(values);
        }
    }
}
