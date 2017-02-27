using System.Collections;
using System.Collections.Generic;

namespace MiniLib
{
    class Shapes : IEnumerable<Shape>
    {
        List<Shape> _shapes;

        public Shapes()
        {
            _shapes = new List<Shape>();
        }

        public Shape this[int index]
        {
            get
            {
                return _shapes[index];
            }
            set{
                if(_shapes.Count-1<index)
                {
                    _shapes.Add(value);
                } else {
                    _shapes[index].Position.X = value.Position.X;
                    _shapes[index].Position.Y = value.Position.Y;
                    _shapes[index].Size.Height = value.Size.Height;
                    _shapes[index].Size.Width = value.Size.Width;
                }
            }
        }
        public IEnumerator<Shape> GetEnumerator()
        {
            foreach(var shape in _shapes)
            {
                yield return shape;
            }
        }


        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


    }
}