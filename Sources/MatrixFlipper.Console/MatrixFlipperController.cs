using MatrixFlipper.MatrixUtils;

namespace MatrixFlipper.Console
{
    public class MatrixFlipperController
    {
        private readonly MatrixUtils.MatrixFlipper _matrixFlipper;
        private readonly IMatrixReader _matrixReader;
        private readonly IMatrixWriter _matrixWriter;

        public MatrixFlipperController(MatrixUtils.MatrixFlipper matrixFlipper, IMatrixReader matrixReader,
            IMatrixWriter matrixWriter)
        {
            _matrixFlipper = matrixFlipper;
            _matrixReader = matrixReader;
            _matrixWriter = matrixWriter;
        }

        public void FlipClockwise()
        {
            int[,] matrix = _matrixReader.Read();
            _matrixFlipper.FlipClockwise(ref matrix);
            _matrixWriter.Write(matrix);
        }
    }
}