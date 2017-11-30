namespace ValueReference
{
    internal class Rectangle
    {
        public int Height;
        public int Width;

        public Rectangle(int height, int width)
        {
            this.Height = height;
            this.Width = width;
        }

        public int Field()
        {
            return Height * Width;
        }

        public string Write()
        {
            return "x=" + Height + " y=" + Width;
        }

    }
}