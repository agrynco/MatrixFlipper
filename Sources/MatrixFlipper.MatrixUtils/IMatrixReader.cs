using System.IO;

namespace MatrixFlipper.MatrixUtils
{
    public interface IMatrixReader
    {
        int[,] Read(TextReader textReader);
    }
}