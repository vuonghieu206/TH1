BAI THUC HANH 2 - ASP.NET CORE MVC .NET 10

Mo THLab1.csproj bang Visual Studio 2022 co ho tro .NET 10.
Chay Build > Rebuild Solution, sau do F5.

URL:
- Danh sach sinh vien: /Admin/Student/List
- Them sinh vien: /Admin/Student/Add

Cac phan trong bai:
- MyLayout.cshtml, TopNav.cshtml, LeftMenu.cshtml, Footer.cshtml
- RenderSectionAsync va section Scripts trong Student/Index.cshtml
- Model MenuItem, RenderViewComponent va RenderLeftMenu.cshtml
- MyLayoutHelper.cshtml goi ViewComponent
- AdminLTE 4 CSS/JS va hinh anh tu template duoc cung cap

Luu y:
- Bootstrap va Bootstrap Icons duoc nap tu CDN, can co Internet khi chay giao dien.
- Du lieu sinh vien dang luu trong bo nho, khong phai database; du lieu them moi mat khi khoi dong lai.
- Moi truong tao file khong co dotnet SDK de build thuc te; vui long Rebuild trong Visual Studio.
