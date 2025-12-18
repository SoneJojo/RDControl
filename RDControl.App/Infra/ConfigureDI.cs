using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging.Abstractions;
using RDControl.App.Others;
using RDControl.App.Register;
using RDControl.App.ViewModel;
using RDControl.Domain.Base;
using RDControl.Domain.Entities;
using RDControl.Repository.Context;
using RDControl.Repository.Repository;
using RDControl.Service.Service;


namespace RDControl.App.Infra
{
    public static class ConfigureDI
    {
        #region Variables
        public static ServiceCollection? services;
        public static IServiceProvider? serviceProvider;
        #endregion

        #region AutoMapper
        public static void ConfigureServices()
        {
            //Database Config
            var DBConfigFile = "Config/DbConfig.txt";
            var strCon = File.ReadAllText(DBConfigFile); //Config do copiar se for mais novo em dbconfig.txt
            services = new ServiceCollection();



            services.AddDbContext<RDControlContext>(options =>
            {
                options.LogTo(Console.WriteLine);
                options.UseMySQL(strCon);
            });
            services.AddScoped<IBaseRepository<Client>, BaseRepository<Client>>();
            services.AddScoped<IBaseService<Client>, BaseService<Client>>();
            services.AddScoped<ClientForm, ClientForm>();
            services.AddScoped<IBaseRepository<Equipment>, BaseRepository<Equipment>>();
            services.AddScoped<IBaseService<Equipment>, BaseService<Equipment>>();
            services.AddScoped<EquipmentForm, EquipmentForm>();
            services.AddScoped<IBaseRepository<Place>, BaseRepository<Place>>();
            services.AddScoped<IBaseService<Place>, BaseService<Place>>();
            services.AddScoped<PlaceForm, PlaceForm>();

            services.AddScoped<IBaseRepository<Report>, BaseRepository<Report>>();
            services.AddScoped<IBaseService<Report>, BaseService<Report>>();
            services.AddScoped<ReportForm, ReportForm>();

            services.AddScoped<IBaseRepository<Technician>, BaseRepository<Technician>>();
            services.AddScoped<IBaseService<Technician>, BaseService<Technician>>();
            services.AddScoped<TechnicianForm, TechnicianForm>();

            services.AddScoped<IBaseRepository<User>, BaseRepository<User>>();
            services.AddScoped<IBaseService<User>, BaseService<User>>();
            services.AddScoped<UserForm, UserForm>();


            services.AddTransient<LoginForm, LoginForm>();

            services.AddSingleton(
                new MapperConfiguration(
                    config => {
                        config.CreateMap<Client, ClientViewModel>();
                        config.CreateMap<Technician, TechnicianViewModel>();
                        config.CreateMap<User, UserViewModel>();
                        config.CreateMap<Place, PlaceViewModel>()
                            .ForMember(m => m._Client, m => m.MapFrom(e => e._Client!.Name));
                        config.CreateMap<Equipment, EquipmentViewModel>()
                            .ForMember(m => m._Place, m => m.MapFrom(e => e._Place!.Pname));
                        config.CreateMap<Report, ReportViewModel>()
                            .ForMember(m => m._Technician, m => m.MapFrom(e => e._Technician!.Name))
                            .ForMember(m => m.Equip, m => m.MapFrom(e => $"{e.Equip!.Id} - {e.Equip!.Model}"))
                            .ForMember(m => m._User, m => m.MapFrom(e => e._User!.Name));
                    },
                    NullLoggerFactory.Instance).CreateMapper());

            serviceProvider = services.BuildServiceProvider();
        }
#endregion
    }
}
