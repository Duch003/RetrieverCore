namespace RetrieverCore.Models.Common
{
    public struct Resolution
    {
        public int Width { get; private set; }
        public int Height { get; private set; }

        public Resolution(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public override string ToString()
            => $"{Width} x {Height}";
        public override bool Equals(object model)
        {
            if (model is Resolution resolution)
            {
                return Height == resolution.Height && Width == resolution.Width;
            }
            return base.Equals(model);
        }
    }
}
