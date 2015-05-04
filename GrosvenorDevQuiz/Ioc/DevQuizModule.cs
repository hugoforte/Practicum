using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using GrosvenorDevQuiz.BusinessObjects;

namespace GrosvenorDevQuiz.Ioc
{
    public class DevQuizModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Server>().As<IServer>().InstancePerDependency();
            builder.RegisterType<MealProcessorStaticData>().As<IMealProcessor>().InstancePerDependency();
            base.Load(builder);
        }
    }
}
