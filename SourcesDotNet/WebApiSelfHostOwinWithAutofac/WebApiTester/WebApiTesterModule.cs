using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;

namespace WebApiTester
{
    class WebApiTesterModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<TestFunctions>().AsSelf();

            base.Load(builder);
        }
    }
}
