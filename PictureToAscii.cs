using System;
using System.Drawing;

namespace FacebookApplicationLogic
{
    public class PictureToAscii
    {
        public Bitmap InputImage { get; set; }

        public bool BlackToWhite { get; set; }

        public int AsciiHeight { get; set; }

        public int AsciiWidth { get; set; }

        private string AsciiValues { get; set; }

        private int[,] FinalImage { get; set; }

        private int[,] GrayScaleValues { get; set; }

        private readonly string[] r_StringCharOptions = 
            {
            "@%#*+=-:. ",
            "@BR*#$PX0woIcv:+!~., ",
            "$@B %8&WM#*oahkbdpqwmZO0QLC(1{}[]?-_+~<>i!lI;:,^'. ",
            @"$@B%8&WM#*oahkbdpqwmZO0QLCJUYXzcvunxrjft/\|()1{}[]?-_+~<>i!lI;:,^'. "
        };

        private const int k_DefaultAsciiCharNumber = 0;

        private const int k_NoHightWasChoosen = 0;

        public PictureToAscii(Image i_GivenImage)
        {
            InputImage = (Bitmap)i_GivenImage;
            AsciiHeight = 80;
            AsciiWidth = 40;
            AsciiValues = r_StringCharOptions[0];
            BlackToWhite = true;
        }

        public void SetSettings(int i_AsciiHeight, int i_AsciiWidth, int i_IndexCharChoosen, bool i_BlackToWhite)
        {
            if (i_AsciiHeight == k_NoHightWasChoosen) 
            {
                AsciiHeight = 80;
                AsciiWidth = 40;
            }
            else
            {
                AsciiHeight = i_AsciiHeight;
                AsciiWidth = i_AsciiWidth;
            }

            if (i_IndexCharChoosen == k_DefaultAsciiCharNumber) 
            {
                AsciiValues = r_StringCharOptions[k_DefaultAsciiCharNumber];
            }
            else
            {
                AsciiValues = r_StringCharOptions[i_IndexCharChoosen];
            }

            BlackToWhite = i_BlackToWhite;
        }

        public string MakeToAscii()
        {
            GrayScaleValues = new int[InputImage.Width, InputImage.Height];

            makeGrayScale();

            if (BlackToWhite == false)
            {
                char[] charArray = AsciiValues.ToCharArray();
                Array.Reverse(charArray);
                AsciiValues = new string(charArray);
            }

            return avgBlocks(AsciiHeight, AsciiWidth);
        }

        private char grayScaleToAscii(int i_GrayScale)
        {
            return AsciiValues[(i_GrayScale * AsciiValues.Length / 255)];
        }

        private string avgBlocks(int i_AsciiImageRow, int i_AsciiImageCol)
        {
            string finalString = string.Empty;

            int[,] tempSubMatirx;
            int rows = InputImage.Width;
            int cols = InputImage.Height;

            int newRows = rows / (rows / i_AsciiImageRow);
            int newCols = cols / (cols / i_AsciiImageCol);

            int rowinc = rows / i_AsciiImageRow;
            int colinc = cols / i_AsciiImageCol;

            FinalImage = new int[newRows, newCols];

            int row = 0;
            int col = 0;

            for (int i = 0; i < rows; i += rowinc)
            {
                for (int j = 0; j < cols; j += colinc)
                {
                    if (colinc + j > cols || rowinc + i > rows)
                    {
                        break;
                    }

                    tempSubMatirx = getSubGrayScaleMatrix(i, rowinc, j, colinc, GrayScaleValues);
                    FinalImage[row, col++] = avgGrayScaleValue(tempSubMatirx);
                }

                row++;
                col = 0;
            }

            for (int j = 0; j < newCols; j++)
            {
                for (int i = newRows - 1; i >= 0; i--)
                {
                    finalString = string.Format("{0}{1}", finalString, grayScaleToAscii((int)FinalImage[i, j]));
                }

                finalString = string.Format("{0}{1}", finalString, Environment.NewLine);
            }

            return finalString;
        }

        private void makeGrayScale()
        {
            Color color;
            int grayscale;
            int rows = InputImage.Height;
            int cols = InputImage.Width;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    color = InputImage.GetPixel(i, j);
                    grayscale = (int)(color.R * 0.299) + (int)(color.G * 0.587) + (int)(color.B * 0.114);  // make each pixel to gray
                    GrayScaleValues[i, j] = grayscale;
                }
            }
        }

        private int avgGrayScaleValue(int[,] i_GrayScaleMatrix)
        {
            int count = 0;
            int sum = 0;

            foreach (int cell in i_GrayScaleMatrix) 
            {
                count++;
                sum += cell;
            }

            return sum / count;
        }

        private int[,] getSubGrayScaleMatrix(int i_StartingRow, int i_NumberOfRowElements, int i_StartingCol, int i_NumberOfColElements, int[,] i_Matrix)
        {
            int[,] subMatrix = new int[i_NumberOfRowElements, i_NumberOfColElements];
            int startRow = i_StartingRow;
            int startCol = i_StartingCol;
            
            for (int i = 0; i < i_NumberOfRowElements; i++) 
            {
                for (int j = 0; j < i_NumberOfColElements; j++)
                {
                    subMatrix[i, j] = i_Matrix[startRow, startCol++];
                }

                startRow++;
                startCol = i_StartingCol;
            }

            return subMatrix;
        }
    }
}