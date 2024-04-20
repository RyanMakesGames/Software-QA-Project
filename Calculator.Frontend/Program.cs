using Calculator.Frontend.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>();

app.Run();

//Methods
//A + B
static float plus(float a, float b){
    return a + b;
}
//A - B
static float minus(float a,float b){
    return a - b;
}
//A * B
static float multiply(float a, float b){
    return a * b;
}
//A / B
static float divide(float a, float b){
    return a / b;
}