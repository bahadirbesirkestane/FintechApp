using DrawingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Service
{
    public class FileManager
    {
        public void SaveShapes(string filePath, List<Shape> shapes)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var shape in shapes)
                {
                    string shapeValue = $"{shape.Start.X},{shape.Start.Y},{shape.End.X},{shape.End.Y},{shape.Color.Name},{shape.ShapeImageFile}";

                    writer.WriteLine(shapeValue);
                }
            }
        }

        public List<Shape> LoadShapes(string filePath)
        {
            List<Shape> shapes = new List<Shape>();

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] data = line.Split(',');

                    if (data.Length >= 6)
                    {
                        Shape shape = new Shape
                        {
                            Start = new Point(int.Parse(data[0]), int.Parse(data[1])),
                            End = new Point(int.Parse(data[2]), int.Parse(data[3])),
                            Color = Color.FromName(data[4]),
                            ShapeImageFile = data[5],
                            ShapeBitmap = new Bitmap(Image.FromFile(data[5])),
                        };

                        shapes.Add(shape);
                    }
                }
            }

            return shapes;
        }
    }
}
