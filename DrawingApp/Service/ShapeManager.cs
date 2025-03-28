using DrawingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Service
{
    public class ShapeManager
    {
        public List<Shape> Shapes { get; private set; } = new List<Shape>();
        public Shape SelectedShape { get; private set; }

        public void AddShape(Shape shape)
        {
            Shapes.Add(shape);
        }

        public void RemoveShape(Shape shape)
        {
            if (shape != null)
                Shapes.Remove(shape);
        }

        public void ClearShapes()
        {
            Shapes.Clear();
        }

        public void SelectShape(Point clickPoint)
        {
            SelectedShape = null;
            foreach (var shape in Shapes)
            {
                if (shape.ContainsPoint(clickPoint))
                {
                    SelectedShape = shape;
                    break;
                }
            }
        }

        public void SaveToFile(string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var shape in Shapes)
                {
                    string shapeValue = $"{shape.Start.X},{shape.Start.Y},{shape.End.X},{shape.End.Y},{shape.Color.Name},{shape.ShapeImageFile}";
                    writer.WriteLine(shapeValue);
                }
            }
        }

        public void LoadFromFile(string filePath)
        {
            Shapes.Clear();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    if (data.Length >= 7)
                    {
                        Shape shape = new Shape
                        {
                            Start = new Point(int.Parse(data[0]), int.Parse(data[1])),
                            End = new Point(int.Parse(data[2]), int.Parse(data[3])),
                            Color = Color.FromName(data[4]),
                            ShapeImageFile = data[5],
                            ShapeBitmap = new Bitmap(Image.FromFile(data[5]))
                        };
                        Shapes.Add(shape);
                    }
                }
            }
        }
    }
}

