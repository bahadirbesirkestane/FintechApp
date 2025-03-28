using DrawingApp.Models;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace DrawingApp
{
    public partial class Form1 : Form
    {
        private List<Shape> shapes = new List<Shape>(); // Çizilmiş şekillerin listesi
        private Shape currentShape = new Shape(); // Geçici şekil

        // Mouse hareketleri için
        Point start;
        Point end;
        bool isMouseDown = false; // Mouse tıklanmış mı?
        bool shapeSelected = false; // Şekil seçildi mi?

        // Şekilllerin rengi(başlangıçta siyah)
        Color Shapecolor = Color.Black;

        // Seçilen resim
        public Bitmap selectedImage = null;
        public Bitmap selectedBitmap = null;
        public string selectedImageFile = null;

        // Nese seçimi
        private bool selectionMode = false; // Seçim modu aktif mi?
        private Shape selectedShapeObject = null; // Seçilen şekil
        private SolidBrush selectionBrush = new SolidBrush(Color.FromArgb(70, Color.Blue)); // Seçim rengi


        //Şekil taşıma
        private bool isDragging = false;  // Şekil taşınıyor mu?
        private Point MouseStartPoint;     // Mouse'un ilk tıkladığı yer

        // Geçici butonlar
        public Button tempShapeButton = new Button();
        public Button tempColorButton = new Button();
        public Button tempSelectionButton = new Button();


        public Form1()
        {
            this.DoubleBuffered = true;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Buton eventleri
            AddButtonEvents(ButtonsGroup);
        }

        // Buton eventlerini ekleme
        private void AddButtonEvents(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Button btn)
                {

                    btn.Click -= Button_Click;
                    btn.Click += Button_Click;
                }
                else if (control is GroupBox)
                {
                    AddButtonEvents(control); // recursive(iç içe groupBox) 
                }
            }
        }

        // Butonların genel click eventi
        private void Button_Click(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                switch (clickedButton.Name)
                {
                    case "btnCircle":
                    case "btnTringle":
                    case "btnHexagon":
                    case "btnSquare":
                        SelectShape(clickedButton);
                        break;

                    case "btnRed":
                    case "btnBlue":
                    case "btnGreen":
                    case "btnOrange":
                    case "btnBlack":
                    case "btnYellow":
                    case "btnPurple":
                    case "btnBrown":
                    case "btnWhite":
                        SelectColor(clickedButton);
                        break;

                    case "btnObjectSelected":
                        tempSelectionButton.FlatStyle = FlatStyle.Standard;
                        clickedButton.FlatStyle = FlatStyle.Flat;
                        tempSelectionButton = clickedButton;
                        if (!selectionMode)
                        {
                            selectedImageFile = "";
                            selectedImage = null;
                        }

                        selectionMode = !selectionMode;
                        break;

                    case "btnObjectDelete":
                        if (selectionMode && selectedShapeObject != null)
                        {
                            shapes.Remove(selectedShapeObject);
                            selectedShapeObject = null;
                            pictureBox1.Refresh();
                        }
                        break;

                    case "btnClearObject":

                        shapes.Clear();
                        selectedImageFile = "";
                        selectedImage = null;
                        pictureBox1.Refresh();

                        break;

                    case "btnSave":
                        SaveScreen();
                        break;

                    case "btnFolder":
                        LoadScreen();
                        break;

                    default:
                        MessageBox.Show($"Tıklanan butonun işlemi tanımlanmamış: {clickedButton.Name}");
                        break;
                }
            }
        }

        // Şekil seçme
        private void SelectShape(Button button)
        {
            tempSelectionButton.FlatStyle = FlatStyle.Standard;

            tempShapeButton.FlatStyle = FlatStyle.Standard;
            button.FlatStyle = FlatStyle.Flat;
            tempShapeButton = button;

            shapeSelected = true;
            selectionMode = false;

            Bitmap bmp = new Bitmap(button.Image);

            var value = button.Image.RawFormat;
            //var value2 = button.Name;

            //var value=button
            //imageFilePath=button.ImageLocation;

            //var value = Image.FromFile("../../../Resources/hexagon.png");

            selectedImageFile = "../../../Resources/" + button.Name + ".png";
            selectedImage = SwapColor(bmp, Shapecolor);
        }

        // Renk seçme
        private void SelectColor(Button button)
        {
            tempColorButton.FlatStyle = FlatStyle.Standard;
            button.FlatStyle = FlatStyle.Flat;
            tempColorButton = button;

            Shapecolor = button.BackColor;

            if (selectedImage != null)
            {
                selectedImage = SwapColor(selectedImage, Shapecolor);
            }

        }

        // Resim renk değiştirme
        private static Bitmap SwapColor(Bitmap bmp, Color newColor)
        {
            Bitmap scrBitmap = bmp;

            Color actualColor;

            Bitmap newBitmap = new Bitmap(scrBitmap.Width, scrBitmap.Height);
            for (int i = 0; i < scrBitmap.Width; i++)
            {
                for (int j = 0; j < scrBitmap.Height; j++)
                {
                    actualColor = scrBitmap.GetPixel(i, j);
                    if (actualColor.A > 150)
                        newBitmap.SetPixel(i, j, newColor);
                    else
                        newBitmap.SetPixel(i, j, actualColor);
                }
            }
            return newBitmap;
        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!shapeSelected)
            {
                return;
            }

            if (selectionMode)
            {
                SelectShape(e.Location); // Şekil seçme metodu

                /// Taşıma işlemi
                if (selectedShapeObject != null)
                {
                    isDragging = true; // Taşıma aktif
                    MouseStartPoint = e.Location;
                }
            }
            else
            {
                start = e.Location;

                isMouseDown = true;

                currentShape = new Shape();

                currentShape.Start = start;
                currentShape.End = end;

                if (selectedImage != null)
                {
                    currentShape.ShapeImageFile = selectedImageFile;
                    currentShape.Color = Shapecolor;
                    currentShape.ShapeBitmap = new Bitmap(selectedImage);
                }
            }

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!shapeSelected)
            {
                return;
            }


            // Taşıma işlemi
            if (isDragging && selectedShapeObject != null)
            {
                int offsetX = e.X - MouseStartPoint.X;
                int offsetY = e.Y - MouseStartPoint.Y;

                // Şeklin başlangıç ve bitiş noktalarını güncelle
                selectedShapeObject.Start = new Point(selectedShapeObject.Start.X + offsetX, selectedShapeObject.Start.Y + offsetY);
                selectedShapeObject.End = new Point(selectedShapeObject.End.X + offsetX, selectedShapeObject.End.Y + offsetY);

                MouseStartPoint = e.Location;

                pictureBox1.Refresh();
            }

            if (isMouseDown)
            {
                end = e.Location;
            }



            if (isMouseDown && currentShape != null)
            {
                currentShape.End = e.Location;

                pictureBox1.Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!shapeSelected)
            {
                return;
            }


            // Taşıma işlemi
            if (isDragging)
            {
                isDragging = false;
                return;
            }

            if (isMouseDown)
            {
                end = e.Location;
                if (currentShape != null)
                {
                    shapes.Add(currentShape);
                    currentShape = null;
                    pictureBox1.Refresh();
                }
                isMouseDown = false;
            }

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (!shapeSelected)
            {
                return;
            }


            foreach (var shape in shapes)
            {
                if (shape.ShapeBitmap == null)
                {
                    return;
                }

                e.Graphics.DrawImage(shape.ShapeBitmap,
                        Math.Min(shape.Start.X, shape.End.X),
                        Math.Min(shape.Start.Y, shape.End.Y),
                        Math.Abs(shape.End.X - shape.Start.X),
                        Math.Abs(shape.End.Y - shape.Start.Y));


            }


            // Seçilen şelin gölgesi
            if (selectedShapeObject != null)
            {
                int padding = 5; 
                Rectangle selectedRect = new Rectangle(
                    Math.Min(selectedShapeObject.Start.X, selectedShapeObject.End.X) - padding,
                    Math.Min(selectedShapeObject.Start.Y, selectedShapeObject.End.Y) - padding,
                    Math.Abs(selectedShapeObject.End.X - selectedShapeObject.Start.X) + 2 * padding,
                    Math.Abs(selectedShapeObject.End.Y - selectedShapeObject.Start.Y) + 2 * padding
                );

                e.Graphics.FillRectangle(selectionBrush, selectedRect);
            }


            if (selectedImage != null)
            {
                e.Graphics.DrawImage(selectedImage,
                    Math.Min(start.X, end.X),
                    Math.Min(start.Y, end.Y),
                    Math.Abs(end.X - start.X),
                    Math.Abs(end.Y - start.Y));
            }




        }

        private void SelectShape(Point clickPoint)
        {
            selectedShapeObject = null;
            foreach (var shape in shapes)
            {
                if (shape.ContainsPoint(clickPoint)) 
                {
                    selectedShapeObject = shape;
                    break;
                }
            }
            pictureBox1.Refresh();
        }

        private void SaveScreen()
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();

            saveFileDialog.Filter = "Metin Dosyası (*.txt)|*.txt";
            saveFileDialog.Title = "Dosya Kaydet";
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.AddExtension = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //StreamWriter writer2 = new StreamWriter(saveFileDialog.FileName, true);

                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (var shape in shapes)
                    {
                        
                        string shapeValue = $"{shape.Start.X},{shape.Start.Y},{shape.End.X},{shape.End.Y},{shape.Color.Name},{shape.ShapeImageFile}";

                        writer.WriteLine(shapeValue);

                    }
                }

            }

        }

  
        private void LoadScreen()
        {
            OpenFileDialog file = new OpenFileDialog();
            //file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            file.Filter = "Txt Dosyası |*.txt";
            //file.RestoreDirectory = true;
            file.ShowDialog();

            if (file.ShowDialog() == DialogResult.OK)
            {
                shapes.Clear(); 

                using (StreamReader reader = new StreamReader(file.FileName))
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
                                Color= Color.FromName(data[4]), 
                                ShapeImageFile=data[5], 
                                ShapeBitmap = new Bitmap(Image.FromFile(data[5])),
                            };

                            shapes.Add(shape);
                        }
                    }
                }
                pictureBox1.Refresh();
            }

            
        }

    }
}
