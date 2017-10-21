using System;
using System.IO;

namespace MatrixFlipper.MatrixUtils
{
    public class MatrixReaderFromCsv : MatrixReaderFromFile
    {
        public MatrixReaderFromCsv(TextReader textReader) : base(textReader) { }

        public override int[,] Read()
        {
            string wholeFile = TextReader.ReadToEnd();

            wholeFile = wholeFile.Replace('\n', '\r');
            if (string.IsNullOrEmpty(wholeFile))
            {
                return new int[0, 0];
            }

            string[] lines = wholeFile.Split(new[] { '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            int numRows = lines.Length;
            int numCols = lines[0].Split(',').Length;

            int[,] values = new int[numRows, numCols];

            for (int r = 0; r < numRows; r++)
            {
                string[] lineR = lines[r].Split(',');
                for (int c = 0; c < numCols; c++)
                {
                    values[r, c] = int.Parse(lineR[c]);
                }
            }

            return values;
        }
    }
}