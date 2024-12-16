using Microsoft.EntityFrameworkCore;
using oop2.Contracts;
using oop2.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("LearninhAppDBConnection");
builder.Services.AddDbContextPool<RepositoryContext>(
    options => options.UseMySql(connectionString,
    ServerVersion.AutoDetect(connectionString)));
    
    builder.Services.AddScoped<IClientRepository, ClientRepository>();
    builder.Services.AddScoped<IEquipmentRepository, EquipmentRepository>();
    //builder.Services.AddScoped<IEquipmentServiceRepository, EquipmentServiceRepository>(); 
    builder.Services.AddScoped<IMasterRepository, MasterRepository>();
    builder.Services.AddScoped<IOrderRepository, OrderRepository>();
    builder.Services.AddScoped<IServiceRepository, ServiceRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.MapControllers();


app.UseAuthorization();


app.Run();
