using System;
using System.Drawing;

namespace Digital_image_processing
{
    class MedianFilter : IProcessingImage
    {
        private readonly Bitmap _image;

        public MedianFilter(Bitmap image)
        {
            _image = new Bitmap(image);
        }

        public Bitmap Algorithm()
        {
            Bitmap filteredImage = MedianFilterAlgorithm(_image);

            int counter = 0;
            while (counter++ < 5)
            {
                filteredImage = MedianFilterAlgorithm(filteredImage);
            }

            return filteredImage;
        }

        private Bitmap MedianFilterAlgorithm(Bitmap image)
        {
            int filterSize = 3;

            Bitmap filteredImage = new Bitmap(image.Width, image.Height);

            for (int x = 0; x < image.Width; x++)
            {
                for (int y = 0; y < image.Height; y++)
                {
                    Color[] pixelValues = new Color[filterSize * filterSize];

                    int index = 0;
                    for (int fx = x - filterSize / 2; fx <= x + filterSize / 2; fx++)
                    {
                        for (int fy = y - filterSize / 2; fy <= y + filterSize / 2; fy++)
                        {
                            if (fx >= 0 && fx < image.Width && fy >= 0 && fy < image.Height)
                            {
                                pixelValues[index] = image.GetPixel(fx, fy);
                                index++;
                            }
                        }
                    }

                    Array.Sort(pixelValues, (a, b) => a.GetBrightness().CompareTo(b.GetBrightness()));

                    Color medianValue = pixelValues[pixelValues.Length / 2];

                    filteredImage.SetPixel(x, y, medianValue);
                }
            }
            return filteredImage;
        }
    }
}
