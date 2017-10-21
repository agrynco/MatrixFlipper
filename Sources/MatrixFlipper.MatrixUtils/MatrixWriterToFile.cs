using System.IO;

namespace MatrixFlipper.MatrixUtils {
    public abstract class MatrixWriterToFile : IMatrixWriter
    {
        protected TextWriter TextWriter { get; }

        protected MatrixWriterToFile(TextWriter textWriter)
        {
            TextWriter = textWriter;
        }

        public abstract void Write(int[,] matrix);
    }
}