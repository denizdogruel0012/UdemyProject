using HoteilerProject.BusinessLayer.Abstract;
using HoteilerProject.BusinessLayer.Concreate;
using HoteilerProject.DataaccessLayer.Abstract;
using HoteilerProject.DataaccessLayer.Concreate;
using HoteilerProject.DataaccessLayer.EntityFramework;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors(opt =>
{
    opt.AddPolicy("OtelProjeKampi", opt =>
    {
        opt.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader();
    });
});
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<Context>();
//Staff
builder.Services.AddScoped<IStaffDal, EfStaffDal>();
builder.Services.AddScoped<IStaffService, StaffManager>();
//Testimonial
builder.Services.AddScoped<ITestimonialDal, EfTestimonialDal>();
builder.Services.AddScoped<ITestimonialService, TestimonialManager>();
//Service
builder.Services.AddScoped<IServiceDal, EfServiceDal>();
builder.Services.AddScoped<Iserviceservice, ServiceManager>();
//Subscribed
builder.Services.AddScoped<ISubscribeService, Subscribemanager>();
builder.Services.AddScoped<ISubscribeDal, EfSubscribedDal>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.UseCors("OtelProjeKampi");
app.MapControllers();

app.Run();
