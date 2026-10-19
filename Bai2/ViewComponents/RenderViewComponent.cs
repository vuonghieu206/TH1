using Microsoft.AspNetCore.Mvc;
using THLab1.Models;
namespace THLab1.ViewComponents;
public class RenderViewComponent : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        var items = new List<MenuItem>
        {
            new() { Id=1, Name="Dashboard", Link="/", Icon="bi bi-speedometer2" },
            new() { Id=2, Name="Students", Link="/Admin/Student/List", Icon="bi bi-people" },
            new() { Id=3, Name="Add Student", Link="/Admin/Student/Add", Icon="bi bi-person-plus" }
        };
        return View("RenderLeftMenu", items);
    }
}
