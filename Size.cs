namespace MiniLib
{
    class Size
    {
        public int Height {get;set;}
        public int Width {get;set;}

        public override string ToString() => $"(height:{Height},width:{Width})";
    }
}