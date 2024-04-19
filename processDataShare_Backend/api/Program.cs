using api.DbData;
using api.Interfaces.CollectFromDb;
using api.Interfaces.CollectToDb;
using api.Interfaces.Live;
using api.Repository;
using api.Repository.DataFromDb;
using api.Repository.DataToDb;
using api.Repository.DataToDB;
using api.Services;
using Microsoft.EntityFrameworkCore;
// SK3180WS0160\\SQLEXPRESS
// SK3180WS0205\\SQLEXPRESS


var builder = WebApplication.CreateBuilder(args);

// builder.WebHost.UseUrls("http://10.184.147.55:5147");
// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHostedService<AsqCollectorDb>();
builder.Services.AddHostedService<EqcCollectorDb>();


//DB IMPLEMENTATION
builder.Services.AddDbContext<ApplicationDBContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));

});
// 
// INTERFACES IMPLEMENTATION
// 
//Live interfaces
builder.Services.AddScoped<IMainLiveDataService, MainLiveDataService>();
builder.Services.AddScoped<IAsqLiveDataService, AsqLiveDataRepo>();
builder.Services.AddScoped<IEqcLiveDataService, EqcLiveDataRepo>();
builder.Services.AddScoped<IOpelLiveDataService, OpelLiveDataRepo>();
//Db interfaces
builder.Services.AddTransient<IAsqDataDb, AsqDbDataRepo>();
builder.Services.AddTransient<IEqcDataDb, EqcDbDataRepo>();
//Db from interfaces
builder.Services.AddScoped<IDataFromDb, DataFromDbRepo>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder =>
{
    builder.WithOrigins("http://10.184.147.55:3009", "http://localhost:5173")
           .AllowAnyHeader()
           .AllowAnyMethod()
           .AllowCredentials();
});

app.UseCors("CorsPolicy");
app.UseHttpsRedirection();
app.MapControllers();

app.Urls.Add("http://10.184.147.55:5147");
// app.Urls.Add("http://localhost:5147");

app.Run();

// "Kestrel": {
//     "Endpoints": {
//         "Http": {
//             "Url": "http://10.184.147.55:5147",
//         "Urls": "http://localhost:5147"
//         }
//     }
// },


// "Kestrel": {
//     "Endpoints": {
//         "Http": {
//             "Url": "http://localhost:5147"
//         }
//     }
// }