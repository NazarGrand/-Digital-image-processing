using System.Drawing;

namespace Digital_image_processing
{
    class OtsusMethod : IProcessingImage
    {
        private readonly Bitmap _image;

        public OtsusMethod(Bitmap image)
        {
            _image = new Bitmap(image);
        }

        public Bitmap Algorithm()
        {
            int[] histogram = new int[256];

            for (int i = 0; i < _image.Width; i++)
            {
                for (int j = 0; j < _image.Height; j++)
                {
                    Color pixel = _image.GetPixel(i, j);
                    int grayValue = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);
                    histogram[grayValue]++;
                }
            }

            int totalPixels = _image.Width * _image.Height;

            int sum = 0;
            for (int i = 0; i < histogram.Length; i++)
            {
                sum += i * histogram[i];
            }

            int foregroundPixels = 0;
            int backgroundPixels = 0;
            int foregroundSum = 0;
            int backgroundSum = 0;
            double maxVariance = 0;
            int threshold = 0;

            for (int i = 0; i < histogram.Length; i++)
            {
                foregroundPixels += histogram[i];
                backgroundPixels = totalPixels - foregroundPixels;

                if (backgroundPixels == 0)
                    break;

                foregroundSum += i * histogram[i];
                backgroundSum = sum - foregroundSum;

                double foregroundMean = (double)foregroundSum / foregroundPixels;
                double backgroundMean = (double)backgroundSum / backgroundPixels;

                double variance = (double)foregroundPixels * backgroundPixels * (foregroundMean - backgroundMean) * (foregroundMean - backgroundMean);

                if (variance > maxVariance)
                {
                    maxVariance = variance;
                    threshold = i;
                }
            }

            Bitmap binaryImage = new Bitmap(_image.Width, _image.Height);

            for (int i = 0; i < _image.Width; i++)
            {
                for (int j = 0; j < _image.Height; j++)
                {
                    Color pixel = _image.GetPixel(i, j);
                    int grayValue = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);

                    if (grayValue < threshold)
                    {
                        binaryImage.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        binaryImage.SetPixel(i, j, Color.White);
                    }
                }
            }
            return binaryImage;
        }

        public override string ToString()
        {
            return "Метод Оцу";
        }
    }
}
