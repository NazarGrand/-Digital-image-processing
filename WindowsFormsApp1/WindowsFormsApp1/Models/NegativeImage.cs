using System.Drawing;


namespace Digital_image_processing
{
    class NegativeImage : IProcessingImage
    {
        private readonly Bitmap _image;

        public NegativeImage(Bitmap image)
        {
            _image = new Bitmap(image);
        }

        public Bitmap Algorithm()
        {
            Bitmap negativeImage = new Bitmap(_image.Width, _image.Height);

            for (int x = 0; x < _image.Width; x++)
            {
                for (int y = 0; y < _image.Height; y++)
                {
                    Color pixelColor = _image.GetPixel(x, y);

                    int red = 255 - pixelColor.R;
                    int green = 255 - pixelColor.G;
                    int blue = 255 - pixelColor.B;

                    Color negativeColor = Color.FromArgb(red, green, blue);

                    negativeImage.SetPixel(x, y, negativeColor);
                }
            }

            return negativeImage;
        }

        public override string ToString()
        {
            return "Негативне зображення";
        }
    }
}
