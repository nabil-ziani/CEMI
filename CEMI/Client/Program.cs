global using CEMI.Client.Services.StudentService;
global using CEMI.Shared;
global using CEMI.Client.Shared;
using CEMI.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Supabase;

Environment.SetEnvironmentVariable("SUPABASE_URL", "https://kkhoyqvvndblqafamfyy.supabase.co");
Environment.SetEnvironmentVariable("SUPABASE_KEY", "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImtraG95cXZ2bmRibHFhZmFtZnl5Iiwicm9sZSI6ImFub24iLCJpYXQiOjE2ODcxODg0NjYsImV4cCI6MjAwMjc2NDQ2Nn0.PAfD8uOu5ThJYCNRfniFIQSR2OQQod_WSEFpWyJVVRg");

var builder = WebAssemblyHostBuilder.CreateDefault(args);

var url = Environment.GetEnvironmentVariable("SUPABASE_URL");
var key = Environment.GetEnvironmentVariable("SUPABASE_KEY");
var options = new SupabaseOptions
{
    AutoRefreshToken = true,
    AutoConnectRealtime = true,
    // SessionHandler = new SupabaseSessionHandler() <-- This must be implemented by the developer
};

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddSingleton(provider => new Client(url, key, options));
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();
builder.Services.AddScoped<IStudentService, StudentService>();

await builder.Build().RunAsync();