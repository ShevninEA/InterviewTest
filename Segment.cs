namespace InterviewTest
{
    public class Segment
    {
        #region Models

        public double StartX { get; set; }
        public double StartY { get; set; }
        public double EndX { get; set; }
        public double EndY { get; set; }

        #endregion

        #region Ctor

        public Segment(double StartX, double StartY, double EndX, double EndY) =>
            (this.StartX, this.StartY, this.EndX, this.EndY) = (StartX, StartY, EndX, EndY);


        #endregion

        // Необходимо реализовать метод, который возвращает true, если два отрезка параллельны, иначе - false.
        public static bool AreParallel(Segment first, Segment second)
        {
            double kFirst = (first.EndY - first.StartY) / (first.EndX - first.StartX); // Расчет углового коэффициента для первого отрезка
            double kSecond = (second.EndY - second.StartY) / (second.EndX - second.StartX); // Расчет углового коэффициента для второго отрезка

            if (kFirst == kSecond) // Отрезки параллельны, если их угловые коэффициенты равны
            {
                return true;
            }
            return false;
        }
    }
}