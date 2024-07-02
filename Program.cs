var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //mvc sablonu icin 

var app = builder.Build();

// mvc
// rest api
// razor pages

// {controller=Home}/{action=Index}/{id?}
// app.MapDefaultControllerRoute(); kısa yol default pattern

//aynı seyi libman yerine node modülü ile de yapabilirdik ama ekstra statik fileleri dışarı açmak için komutlar gerekirdi
//google dan bakarsın gerekirse

app.UseStaticFiles();  //wwwroot altındaki static dosyaları aktif etmek için gerekli

app.UseRouting(); //middleware aktif etmek için doğru sıra ile
//mutlaka yönlendirilmeden önce çalışmalı

app.MapControllerRoute(
  name: "default",
  pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
