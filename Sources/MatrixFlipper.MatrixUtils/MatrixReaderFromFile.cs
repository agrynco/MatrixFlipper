using System.IO;

namespace MatrixFlipper.MatrixUtils {
    public abstract class MatrixReaderFromFile : IMatrixReader
    {
        public TextReader TextReader { get; }

        protected MatrixReaderFromFile(TextReader textReader)
        {
            TextReader = textReader;
        }

        public abstract int[,] Read();
    }
}