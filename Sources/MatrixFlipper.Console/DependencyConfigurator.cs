using Autofac;

using MatrixFlipper.MatrixUtils;

namespace MatrixFlipper.Console
{
    public static class DependencyConfigurator
    {
        public static IContainer Configure()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterType<MatrixReaderFromCsv>().As<IMatrixReader>();
            containerBuilder.RegisterType<MatrixWriterToCsv>().As<IMatrixWriter>();
            containerBuilder.RegisterType<MatrixUtils.MatrixFlipper>().As<MatrixFlipperBase>();
            containerBuilder.RegisterType<MatrixFlipperController>();

            return containerBuilder.Build();
        }
    }
}