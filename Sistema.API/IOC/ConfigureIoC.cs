using Sistema.Infraestrutura;
using Sistema.Negocio.PessoaNegocio;
using Sistema.Dados.PessoaDados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace Sistema.WebAPI.IOC
{
    public class ConfigureIoC
    {
        UnityContainer container = null;

        public ConfigureIoC()
        {
            container = new UnityContainer();
        }

        public UnityContainer register()
        {
            this.regiterDB();
            this.registerDependencies();

            return container;
        }
        private void regiterDB()
        {
            container.RegisterFactory<EstudodbEntities>(c => { return new EstudodbEntities(); }, FactoryLifetime.Hierarchical);
        }

        private void registerDependencies()
        {
            container.RegisterType<IPessoaNegocio, PessoaNegocio>(TypeLifetime.Hierarchical);
            container.RegisterType<IPessoaDados, PessoaDados>(TypeLifetime.Hierarchical);
        }
    }
}