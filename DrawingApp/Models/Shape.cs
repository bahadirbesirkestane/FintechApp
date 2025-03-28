using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Models
{
    public class Shape
    {
        public int ShapeId { get; set; }
        public string ShapeImageFile { get; set; }
        public Bitmap ShapeBitmap { get; set; }
        public Point Start { get; set; }
        public Point End { get; set; }
        public Color Color { get; set; } = Color.Black;

        
        public bool ContainsPoint(Point point)
        {
            Rectangle bounds = new Rectangle(
                Math.Min(Start.X, End.X),
                Math.Min(Start.Y, End.Y),
                Math.Abs(End.X - Start.X),
                Math.Abs(End.Y - Start.Y)
            );
            return bounds.Contains(point);
        }

    }
}
