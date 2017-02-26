namespace MiniLib
{  
    class Position
    {
        public int X {get;set;}
        public int Y {get;set;}

        public override string ToString() => $"(x:{X},y:{Y})";
    }

}