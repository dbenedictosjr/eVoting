using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using OSPI.Domain;
using OSPI.Domain.Interfaces;
using OSPI.Domain.Repositories;
using OSPI.Infrastructure.Interfaces;
using OSPI.Infrastructure.Mapper;
using OSPI.Infrastructure.Services;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace OSPI.eVoting
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
            // Enable cookie authentication
            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie();

            services.AddHttpContextAccessor();

            services.AddControllersWithViews();

            services.AddAutoMapper(typeof(AutoMapperProfile));

            services.AddEntityFrameworkSqlServer()
            .AddDbContext<ApplicationDbContext>((serviceProvider, options) =>
            options.UseSqlServer(Configuration["ConnectionStrings:DefaultConnection"],
            b => b.MigrationsAssembly("OSPI.Domain"))
            .UseInternalServiceProvider(serviceProvider));

            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            //Module
            services.AddScoped<IModuleRepository, ModuleRepository>();
            services.AddScoped<IModuleService, ModuleService>();

            //Role
            services.AddScoped<IRoleRepository, RoleRepository>();
            services.AddScoped<IRoleService, RoleService>();

            //Role Access
            services.AddScoped<IRoleAccessRepository, RoleAccessRepository>();
            services.AddScoped<IRoleAccessService, RoleAccessService>();

            //Member
            services.AddScoped<IMemberRepository, MemberRepository>();
            services.AddScoped<IMemberService, MemberService>();

            //Ballot
            services.AddScoped<IBallotRepository, BallotRepository>();
            services.AddScoped<IBallotService, BallotService>();

            //Position
            services.AddScoped<IPositionRepository, PositionRepository>();
            services.AddScoped<IPositionService, PositionService>();

            //Candidate
            services.AddScoped<ICandidateRepository, CandidateRepository>();
            services.AddScoped<ICandidateService, CandidateService>();

            //Election
            services.AddScoped<IElectionRepository, ElectionRepository>();
            services.AddScoped<IElectionService, ElectionService>();

            //ElectionDetail
            services.AddScoped<IElectionDetailRepository, ElectionDetailRepository>();
            services.AddScoped<IElectionDetailService, ElectionDetailService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
