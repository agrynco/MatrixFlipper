using System.IO;
using System.Text;

namespace MatrixFlipper.MatrixUtils
{
    public class MatrixWriterToCsv : MatrixWriterToFile
    {
        public MatrixWriterToCsv(TextWriter textWriter) : base(textWriter) { }

        public override void Write(int[,] matrix)
        {
            int length = matrix.GetLength(0);
            var rowBuilder = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    if (rowBuilder.Length > 0)
                    {
                        rowBuilder.Append(", ");
                    }
                    rowBuilder.Append(matrix[i, j].ToString());
                }

                TextWriter.WriteLine(rowBuilder.ToString());
                rowBuilder.Clear();
            }

            TextWriter.Flush();
        }
    }
}