using ApiBaseReceitas.application;
using ApiBaseReceitas.application.Interfaces;
using ApiBaseReceitas.application.Mapper;
using ApiBaseReceitas.Domain.Core.Interface.Repositories;
using ApiBaseReceitas.Domain.Core.Interface.Services;
using ApiBaseReceitas.Domain.Service;
using ApiBaseReceitas.Infrastructure.Data.Repositories;
using Autofac;
using AutoMapper;

namespace ApiBaseReceitas.Infrastructure.CrossCutting.IOC
{
    public class ConfigurationIOC
    {
        public static void Load(ContainerBuilder builder)
        {
            #region IOC

            builder.RegisterType<CategoriaApplication>().As<ICategoriaApplication>();
            builder.RegisterType<CategoriaIngredienteApplication>().As<ICategoriaIngredienteApplication>();
            builder.RegisterType<IngredienteApplication>().As<IIngredienteApplication>();
            builder.RegisterType<ModoPreparoApplication>().As<IModoPreparoApplication>();
            builder.RegisterType<MontagemApplication>().As<IMontagemApplication>();
            builder.RegisterType<ReceitaApplication>().As<IReceitaApplication>();

            builder.RegisterType<CategoriaService>().As<ICategoriaService>();
            builder.RegisterType<CategoriaIngredienteService>().As<ICategoriaIngredienteService>();
            builder.RegisterType<IngredienteService>().As<IIngredienteService>();
            builder.RegisterType<ModoPreparoService>().As<IModoPreparoService>();
            builder.RegisterType<MontagemService>().As<IMontagemService>();
            builder.RegisterType<ReceitaService>().As<IReceitaService>();

            builder.RegisterType<CategoriaRepository>().As<ICategoriaRepository>();
            builder.RegisterType<CategoriaIngredienteRepository>().As<ICategoriaIngredienteRepository>();
            builder.RegisterType<IngredienteRepository>().As<IIngredienteRepository>();
            builder.RegisterType<ModoPreparoRepository>().As<IModoPreparoRepository>();
            builder.RegisterType<MontagemRepository>().As<IMontagemRepository>();
            builder.RegisterType<ReceitaRepository>().As<IReceitaRepository>();

            builder.Register(ctx => new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new CategoriaDtoToModelMapping());
                cfg.AddProfile(new CategoriaModelToDtoMapping());
                cfg.AddProfile(new CategoriaIngredienteDtoToModelMapping());
                cfg.AddProfile(new CategoriaIngredienteModelToDtoMapping());
                cfg.AddProfile(new IngredienteDtoToModelMapping());
                cfg.AddProfile(new IngredienteModelToDtoMapping());
                cfg.AddProfile(new ModoPreparoDtoToModelMapping());
                cfg.AddProfile(new ModoPreparoModelToDtoMapping());
                cfg.AddProfile(new MontagemDtoToModelMapping());
                cfg.AddProfile(new MontagemModelToDtoMapping());
                cfg.AddProfile(new ReceitaDtoToModelMapping());
                cfg.AddProfile(new ReceitaModelToDtoMapping());

            }));

            builder.Register(ctx => ctx.Resolve<MapperConfiguration>().CreateMapper()).As<IMapper>().InstancePerLifetimeScope();

            #endregion IOC
        }
    }
}
