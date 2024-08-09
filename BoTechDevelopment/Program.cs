using Microsoft.Extensions.FileProviders;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "pup")), // Instead of Using the wwwroot Folder we are Using the pup Folder for Public resources.
    RequestPath = "/pup",// We only let client access this Folder when they request the pup Folder as the Root-Folder
    ServeUnknownFileTypes = true, // This allows serving files with unknown extensions
    DefaultContentType = "application/octet-stream" // Default content type for unknown extensions
});
// Using index.html when available in the wwwroot Path
//app.UseDefaultFiles();
// Using Standard Directory Browsing but only for our pre defined pup Folder!
app.UseDirectoryBrowser( new DirectoryBrowserOptions
{
    FileProvider = new PhysicalFileProvider(
        Path.Combine(Directory.GetCurrentDirectory(), "pup")), // Instead of Using the wwwroot Folder w Using the pup Folder for Public resources.
    RequestPath = "/pup" // We only let client access this Folder when they request the pup Folder as the Root-Folder
});

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "3D_Library",
    pattern: "3D_library/{action = Index}/",
    defaults: new {controller = "ThreeDLibrary", action = "Index"}
    );


//Ausgabe der Wichtigen Ordner
Console.WriteLine($"ContentRoot Path: {builder.Environment.ContentRootPath}");
Console.WriteLine($"WebRootPath: {builder.Environment.WebRootPath}");

app.Run();
