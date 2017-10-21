using System.IO;

namespace MatrixFlipper.MatrixUtils
{
    public interface IMatrixWriter
    {
        void Write(int[,] matrix, TextWriter textWriter);
    }
}