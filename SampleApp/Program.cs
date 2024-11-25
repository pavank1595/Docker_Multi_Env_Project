var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios.
    // app.UseHsts(); // Uncomment this in production for better security.
}

// We remove HTTPS redirection for now to avoid issues in containers, but you can keep it in production if needed
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

// Ensure the application binds to all network interfaces (0.0.0.0) and listens on port 80
app.Run("http://0.0.0.0:80");