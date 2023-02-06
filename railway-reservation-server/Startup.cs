using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using railwayReservation.Models;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using railwayReservation.Business.Services;
using railwayReservation.Business.Services.DataServices;
using railwayReservation.Business.DataServices;
using railwayReservation.Business.Services.Services;

namespace railwayReservation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddSwaggerGen();

            services.AddMvc();
            services.AddDbContext<ApplicationDBContext>(item => item.UseSqlServer(Configuration.GetConnectionString("myconn")));
            services.AddScoped<IPassengerService, PassengerService>();
            services.AddScoped<IPassengerDataService, PassengerDataService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserDataService, UserDataService>();
            services.AddScoped<ITrainService, TrainService>();
            services.AddScoped<ITrainDataService, TrainDataService>(); 
            services.AddScoped<IStationService, StationService>();
            services.AddScoped<IStationDataService, StationDataService>();
            services.AddScoped<ITrainTypeService, TrainTypeService>();
            services.AddScoped<ITrainTypeDataService, TrainTypeDataService>();
            services.AddScoped<ITicketService, TicketService>();
            services.AddScoped<ITicketDataService, TicketDataService>();

            services.AddCors();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "railwayReservation v1"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(x => x
                 .AllowAnyMethod()
                 .AllowAnyHeader()
                 .SetIsOriginAllowed(origin => true) // allow any origin
                 .AllowCredentials()); // allow credentials


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
