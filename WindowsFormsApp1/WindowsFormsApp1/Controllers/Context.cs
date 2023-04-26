using System;
using System.Drawing;
using System.Windows.Forms;

namespace Digital_image_processing
{
    class Context
    {
        private readonly string _methodName;
        private readonly Bitmap _image;
        private IProcessingImage _processingImage;

        public Context(string methodName, Bitmap image)
        {
            _methodName = methodName;

            _image = new Bitmap(image);

            ChoiceMethod();
        }

        public IProcessingImage ProcessingImage
        {
            get => _processingImage;
        }

        private void ChoiceMethod()
        {
            switch (_methodName)
            {
                case "Негативне зображення":
                    {
                        _processingImage = new NegativeImage(_image);
                        break;
                    }

                case "Метод Оцу":
                    {
                        _processingImage = new OtsusMethod(_image);
                        break;
                    }

                case "Алгоритм Флойда-Стейнберга":
                    {
                        _processingImage = new FloydSteinbergAlgorithm(_image);
                        break;
                    }

                case "Розмивання зображення":
                    {
                        _processingImage = new Blurring(_image);
                        break;
                    }

                case "Збільшення чіткості зображення":
                    {
                        _processingImage = new IncreasingClarity(_image);
                        break;
                    }

                case "Тиснення зображення":
                    {
                        _processingImage = new Stamping(_image);
                        break;
                    }

                case "Медіанний фільтр":
                    {
                        _processingImage = new MedianFilter(_image);
                        break;
                    }
                case "":
                    MessageBox.Show("Ви не обрали алгоритм обробки зображення!");
                    break;
            }
        }
    }
}
