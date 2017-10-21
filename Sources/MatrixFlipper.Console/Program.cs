using System.IO;

using AGrynCo.Lib.Console;
using AGrynCo.Lib.Console.CommandLineParameters;

using Autofac;

namespace MatrixFlipper.Console
{
    internal static class Program
    {
        private const int _NO_ERROR = 0;
        private const int _COMMAND_LINE_PARAMETERS_ARE_NOT_VALID = 1;
        private static readonly ICommandLineParameter<string> _INPUT = new StringCommandLineParameter("input", @"C:\Temp\input.csv");
        private static readonly ICommandLineParameter<string> _OUTPUT = new StringCommandLineParameter("output", @"C:\Temp\output.csv");

        private static readonly ICommandLineParameter[] _COMMAND_LINE_PARAMETERS = { _INPUT, _OUTPUT };

        private static readonly ICommandLineParameter[][] _SET_OF_SEQUENCES_OF_COMMAND_LINE_PARAMETERS =
        {
            _COMMAND_LINE_PARAMETERS
        };

        private static int Main(string[] args)
        {
            CommandLineProcessingResult processingResult = CommandLineParametersPrcessor.Process(args, _COMMAND_LINE_PARAMETERS);
            if (processingResult.IsValid)
            {
                IContainer container = DependencyConfigurator.Configure();

                var matrixFlipperController = container.Resolve<MatrixFlipperController>();

                //var matrixFlipperController = new MatrixFlipperController(new MatrixUtils.MatrixFlipper(),
                //    new MatrixReaderFromCsv(),
                //    new MatrixWriterToCsv());

                matrixFlipperController.FlipClockwise(new StreamReader(_INPUT.Value), new StreamWriter(_OUTPUT.Value));

                return _NO_ERROR;
            }

            ConsoleExtensions.WriteError("Please specify command line parameters");
            CommandLineParametersPrcessor.PrintCommandLineParamsInfo(_SET_OF_SEQUENCES_OF_COMMAND_LINE_PARAMETERS);

            System.Console.ReadLine();
            return _COMMAND_LINE_PARAMETERS_ARE_NOT_VALID;
        }
    }
}