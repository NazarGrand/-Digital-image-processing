using System;


namespace Digital_image_processing
{
    public static class MethodNames
    {
        public const string NegativeImageName = "Негативне зображення";

        public const string OtsusMethodName = "Метод Оцу";

        public const string FloydSteinbergAlgorithmName = "Алгоритм Флойда-Стейнберга";

        public const string BlurringName = "Розмивання зображення";

        public const string IncreasingClarityName = "Збільшення чіткості зображення";

        public const string StampingName = "Тиснення зображення";

        public const string MedianFilterName = "Медіанний фільтр";

        public static string[] AllMethodNames()
        {
            return new string[] { NegativeImageName, OtsusMethodName, FloydSteinbergAlgorithmName, BlurringName,
            IncreasingClarityName, StampingName, MedianFilterName};
        }
    }
}
