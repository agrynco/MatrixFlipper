using System.IO;

using MatrixFlipper.MatrixUtils;

namespace MatrixFlipper.Console
{
    public class MatrixFlipperController
    {
        private readonly MatrixFlipperBase _matrixFlipper;
        private readonly IMatrixReader _matrixReader;
        private readonly IMatrixWriter _matrixWriter;

        public MatrixFlipperController(MatrixFlipperBase matrixFlipper, IMatrixReader matrixReader,
            IMatrixWriter matrixWriter)
        {
            _matrixFlipper = matrixFlipper;
            _matrixReader = matrixReader;
            _matrixWriter = matrixWriter;
        }

        public void FlipClockwise(TextReader textReader, TextWriter textWriter)
        {
            int[,] matrix = _matrixReader.Read(textReader);
            _matrixFlipper.FlipClockwise(ref matrix);
            _matrixWriter.Write(matrix, textWriter);
        }
    }
}