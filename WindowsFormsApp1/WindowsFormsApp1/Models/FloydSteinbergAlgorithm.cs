using System;
using System.Drawing;
using System.Linq;

namespace Digital_image_processing
{
    class FloydSteinbergAlgorithm : IProcessingImage
    {
        private readonly Bitmap _originalImage;

        public FloydSteinbergAlgorithm(Bitmap originalImage)
        {
            _originalImage = new Bitmap(originalImage);
        }

        public Bitmap Algorithm()
        {
            Bitmap resultImage = new Bitmap(_originalImage.Width, _originalImage.Height);

            int width = _originalImage.Width;
            int height = _originalImage.Height;

            int[] paletteColors = CreateGrayscalePalette(256);

            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    Color pixel = _originalImage.GetPixel(x, y);

                    int closestColor = GetClosestPaletteColor(pixel, paletteColors);

                    resultImage.SetPixel(x, y, Color.FromArgb(closestColor));

                    int quantError = pixel.ToArgb() - closestColor;

                    if (x < width - 1)
                    {
                        DistributeError(resultImage, quantError, x + 1, y, 7.0 / 16.0);
                    }
                    if (x > 0 && y < height - 1)
                    {
                        DistributeError(resultImage, quantError, x - 1, y + 1, 3.0 / 16.0);
                    }
                    if (y < height - 1)
                    {
                        DistributeError(resultImage, quantError, x, y + 1, 5.0 / 16.0);
                    }
                    if (x < width - 1 && y < height - 1)
                    {
                        DistributeError(resultImage, quantError, x + 1, y + 1, 1.0 / 16.0);
                    }
                }
            }

            return resultImage;
        }

        private static int[] CreateGrayscalePalette(int levels)
        {
            int[] palette = new int[levels];

            for (int i = 0; i < levels; i++)
            {
                int grayValue = (int)(255 * (i / (levels - 1.0)));
                Color grayColor = Color.FromArgb(grayValue, grayValue, grayValue);
                palette[i] = grayColor.ToArgb();
            }

            return palette;
        }

        private int GetClosestPaletteColor(Color color, int[] paletteColors)
        {
            int argb = color.ToArgb();
            int closestColor = paletteColors.OrderBy(x => ColorDistance(Color.FromArgb(x), color)).First();
            return closestColor;
        }

        private int ColorDistance(Color a, Color b)
        {
            int redDiff = a.R - b.R;
            int greenDiff = a.G - b.G;
            int blueDiff = a.B - b.B;

            return redDiff * redDiff + greenDiff * greenDiff + blueDiff * blueDiff;
        }

        private void DistributeError(Bitmap image, int quantError, int x, int y, double weight)
        {
            Color pixel = image.GetPixel(x, y);

            int newRed = (int)Math.Round(pixel.R + quantError * weight);
            int newGreen = (int)Math.Round(pixel.G + quantError * weight);
            int newBlue = (int)Math.Round(pixel.B + quantError * weight);

            newRed = Math.Max(0, Math.Min(255, newRed));
            newGreen = Math.Max(0, Math.Min(255, newGreen));
            newBlue = Math.Max(0, Math.Min(255, newBlue));

            image.SetPixel(x, y, Color.FromArgb(newRed, newGreen, newBlue));
        }

        public override string ToString()
        {
            return "Алгоритм Флойда-Стейнберга для створення напівтонового зображення";
        }
    }
}
