using System.Drawing;
using System;

namespace Digital_image_processing
{
    class IncreasingClarity : IProcessingImage
    {
        private readonly Bitmap _image;
        private readonly double[,] _kernel;

        public IncreasingClarity(Bitmap image)
        {
            _image = new Bitmap(image);

            _kernel = new double[,]
                {
                {-1, -1, -1},
                {-1,  9, -1},
                {-1, -1, -1}
                };
        }

        public Bitmap Algorithm()
        {
            Bitmap imageModified = new Bitmap(_image.Width + 2, _image.Height + 2);

            for (int i = 1; i < imageModified.Width - 1; i++)
                for (int j = 1; j < imageModified.Height - 1; j++)
                    imageModified.SetPixel(i, j, _image.GetPixel(i - 1, j - 1));

            for (int i = 0; i < imageModified.Height - 1; i++)
            {
                imageModified.SetPixel(0, i, imageModified.GetPixel(1, i));
                imageModified.SetPixel(imageModified.Width - 1, i, imageModified.GetPixel(imageModified.Width - 2, i));
            }

            for (int i = 0; i < imageModified.Width - 1; i++)
            {
                imageModified.SetPixel(i, 0, imageModified.GetPixel(i, 1));
                imageModified.SetPixel(i, imageModified.Height - 2, imageModified.GetPixel(i, imageModified.Height - 3));
            }

            Bitmap result = new Bitmap(imageModified.Width, imageModified.Height);

            for (int x = 1; x < imageModified.Width - 1; x++)
            {
                for (int y = 1; y < imageModified.Height - 1; y++)
                {
                    double red = 0;
                    double green = 0;
                    double blue = 0;

                    for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            Color pixelColor = imageModified.GetPixel(x + i - 1, y + j - 1);

                            red += pixelColor.R * _kernel[i, j];
                            green += pixelColor.G * _kernel[i, j];
                            blue += pixelColor.B * _kernel[i, j];
                        }
                    }

                    red = Math.Min(Math.Max(red, 0), 255);
                    green = Math.Min(Math.Max(green, 0), 255);
                    blue = Math.Min(Math.Max(blue, 0), 255);

                    Color newColor = Color.FromArgb((int)red, (int)green, (int)blue);
                    result.SetPixel(x, y, newColor);
                }
            }

            Bitmap sourceImage = new Bitmap(result.Width - 2, result.Height - 2);

            for (int i = 0; i < sourceImage.Width; i++)
                for (int j = 0; j < sourceImage.Height; j++)
                    sourceImage.SetPixel(i, j, result.GetPixel(i + 1, j + 1));

            return sourceImage;
        }

        public override string ToString()
        {
            return "Алгоритм для збільшення чіткості";
        }
    }
}
