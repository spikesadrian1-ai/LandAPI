using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Serialization;
using OG_LandAPI.Interfaces;
using OG_LandAPI.Models;
using OG_LandAPI.Repositories;


internal class Program
{
    
    private static void Main(string[] args)
    {

        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers();

        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();

        // ENABLE C.O.R.S
        builder.Services.AddCors(c =>
        {
            c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
        });


        // JSON SERIALIZER
        builder.Services.AddControllersWithViews().AddNewtonsoftJson(options =>
        options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore)
            .AddNewtonsoftJson(options => options.SerializerSettings.ContractResolver
            = new DefaultContractResolver());

        /// ADDED SWAGGER/OPEN API
        ///builder.Services.AddSwaggerGen(c =>
        ///{
        ///    c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebAPI", Version = "v1" });
        ///});

        //builder.Services.AddConnections();
        
        ///
        builder.Services.AddScoped<ITractMainRepository, TractMainRepository>();

        // DATABASE CONNECTION: ADD TO CONNECT TO SPECIFIC CLASSES USING EFCORE
        //You have to save DBConnectionString in the appsettings.json file
        builder.Services.AddDbContext<OGDatabaseSchemaV2Context>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("Test")));

        var app = builder.Build();

        
        // ENABLE CORS
        app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());


        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            //app.UseDeveloperExceptionPage();

            /// ADDED SWAGGER ENDPOINTS
            //app.UseSwagger();
            //app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "WebAPI v1"));
        }

        //app.UseDefaultFiles();
        //app.UseStaticFiles();

        app.UseHttpsRedirection();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}
