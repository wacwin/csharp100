namespace MiniLib
{  
    interface IShapeCreator<out T>
        where T:Shape
        {
            T Create();
        }
}