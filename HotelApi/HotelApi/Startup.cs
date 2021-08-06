using HotelApi.Data;
using HotelApi.Models.Interfaces;
using HotelApi.Models.Services;
using HotelApi.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;

namespace HotelApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<HotelDbContext>(options => {
                // Our DATABASE_URL from js days
                string connectionString = Configuration.GetConnectionString("DefaultConnection");
                options.UseSqlServer(connectionString);

            });

            //Dependency Injection Goes here

            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                // Other things are possible
                options.User.RequireUniqueEmail = true;
            }).AddEntityFrameworkStores<HotelDbContext>();

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
       .AddJwtBearer(options =>
       {
          // Tell the authenticaion scheme "how/where" to validate the token + secret
          options.TokenValidationParameters = JwtTokenService.GetValidationParameters(Configuration);
       });

            services.AddAuthorization(options =>
            {
                // Add "Name of Policy", and the Lambda returns a definition
                options.AddPolicy("create", policy => policy.RequireClaim("permissions", "create"));
                options.AddPolicy("update", policy => policy.RequireClaim("permissions", "update"));
                options.AddPolicy("delete", policy => policy.RequireClaim("permissions", "delete"));
            });

            services.AddTransient<IHotel, HotelServices>();
            services.AddTransient<IAmenities, AmenitiesServices>();
            services.AddTransient<IRooms, RoomServices>();
            services.AddTransient<IUser, IdentityUserService>();
            services.AddScoped<JwtTokenService>();

            services.AddControllers().AddNewtonsoftJson(options =>
            options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
      ); 
            services.AddSwaggerGen(options => options.SwaggerDoc("v1", new Microsoft.OpenApi.Models.OpenApiInfo()
            {
                Title = "Swaggin",
                Version = "v1",

            }));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();

                //endpoints.MapGet("/", async context =>
                //{
                //    await context.Response.WriteAsync("Hello World!");
                //});
            });
            app.UseSwagger(options =>
            {
                options.RouteTemplate = "/api/{documentName}/swagger.json";
            });
            app.UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("api/v1/swagger.json", "swaggin");
                options.RoutePrefix = "";
            });
        }
    }
}
