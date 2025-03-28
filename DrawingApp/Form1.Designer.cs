namespace DrawingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ButtonsGroup = new GroupBox();
            groupBox4 = new GroupBox();
            btnFolder = new Button();
            btnSave = new Button();
            groupBox2 = new GroupBox();
            btnRed = new Button();
            btnBlack = new Button();
            btnBlue = new Button();
            btnWhite = new Button();
            btnOrange = new Button();
            btnBrown = new Button();
            btnGreen = new Button();
            btnPurple = new Button();
            btnYellow = new Button();
            groupBox1 = new GroupBox();
            btnSquare = new Button();
            btnTringle = new Button();
            btnHexagon = new Button();
            btnCircle = new Button();
            groupBox3 = new GroupBox();
            btnObjectDelete = new Button();
            btnClearObject = new Button();
            btnObjectSelected = new Button();
            pictureBox1 = new PictureBox();
            ButtonsGroup.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ButtonsGroup
            // 
            ButtonsGroup.BackColor = SystemColors.Menu;
            ButtonsGroup.Controls.Add(groupBox4);
            ButtonsGroup.Controls.Add(groupBox2);
            ButtonsGroup.Controls.Add(groupBox1);
            ButtonsGroup.Controls.Add(groupBox3);
            ButtonsGroup.Location = new Point(939, 12);
            ButtonsGroup.Name = "ButtonsGroup";
            ButtonsGroup.Size = new Size(266, 723);
            ButtonsGroup.TabIndex = 1;
            ButtonsGroup.TabStop = false;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnFolder);
            groupBox4.Controls.Add(btnSave);
            groupBox4.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox4.Location = new Point(36, 603);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(224, 103);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "Dosya İşlemleri";
            // 
            // btnFolder
            // 
            btnFolder.Image = Properties.Resources.foldericon;
            btnFolder.Location = new Point(6, 33);
            btnFolder.Name = "btnFolder";
            btnFolder.Size = new Size(66, 66);
            btnFolder.TabIndex = 17;
            btnFolder.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Image = Properties.Resources.saveicon;
            btnSave.Location = new Point(78, 33);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(66, 66);
            btnSave.TabIndex = 18;
            btnSave.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnRed);
            groupBox2.Controls.Add(btnBlack);
            groupBox2.Controls.Add(btnBlue);
            groupBox2.Controls.Add(btnWhite);
            groupBox2.Controls.Add(btnOrange);
            groupBox2.Controls.Add(btnBrown);
            groupBox2.Controls.Add(btnGreen);
            groupBox2.Controls.Add(btnPurple);
            groupBox2.Controls.Add(btnYellow);
            groupBox2.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox2.Location = new Point(36, 247);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(224, 248);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Renk Seçimi";
            // 
            // btnRed
            // 
            btnRed.BackColor = Color.Red;
            btnRed.FlatAppearance.BorderColor = Color.Gray;
            btnRed.FlatAppearance.BorderSize = 2;
            btnRed.Location = new Point(6, 33);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(66, 66);
            btnRed.TabIndex = 6;
            btnRed.UseVisualStyleBackColor = false;
            // 
            // btnBlack
            // 
            btnBlack.BackColor = Color.Black;
            btnBlack.FlatAppearance.BorderColor = Color.Gray;
            btnBlack.FlatAppearance.BorderSize = 2;
            btnBlack.Location = new Point(74, 105);
            btnBlack.Name = "btnBlack";
            btnBlack.Size = new Size(66, 66);
            btnBlack.TabIndex = 5;
            btnBlack.UseVisualStyleBackColor = false;
            // 
            // btnBlue
            // 
            btnBlue.BackColor = Color.Blue;
            btnBlue.FlatAppearance.BorderColor = Color.Gray;
            btnBlue.FlatAppearance.BorderSize = 2;
            btnBlue.Location = new Point(74, 33);
            btnBlue.Name = "btnBlue";
            btnBlue.Size = new Size(66, 66);
            btnBlue.TabIndex = 7;
            btnBlue.UseVisualStyleBackColor = false;
            // 
            // btnWhite
            // 
            btnWhite.FlatAppearance.BorderColor = Color.Gray;
            btnWhite.FlatAppearance.BorderSize = 2;
            btnWhite.Location = new Point(146, 177);
            btnWhite.Name = "btnWhite";
            btnWhite.Size = new Size(66, 66);
            btnWhite.TabIndex = 13;
            btnWhite.UseVisualStyleBackColor = true;
            // 
            // btnOrange
            // 
            btnOrange.BackColor = Color.FromArgb(255, 128, 0);
            btnOrange.FlatAppearance.BorderColor = Color.Gray;
            btnOrange.FlatAppearance.BorderSize = 2;
            btnOrange.Location = new Point(6, 105);
            btnOrange.Name = "btnOrange";
            btnOrange.Size = new Size(66, 66);
            btnOrange.TabIndex = 8;
            btnOrange.UseVisualStyleBackColor = false;
            // 
            // btnBrown
            // 
            btnBrown.BackColor = Color.FromArgb(128, 64, 0);
            btnBrown.FlatAppearance.BorderColor = Color.Gray;
            btnBrown.FlatAppearance.BorderSize = 2;
            btnBrown.Location = new Point(74, 177);
            btnBrown.Name = "btnBrown";
            btnBrown.Size = new Size(66, 66);
            btnBrown.TabIndex = 12;
            btnBrown.UseVisualStyleBackColor = false;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.Green;
            btnGreen.FlatAppearance.BorderColor = Color.Gray;
            btnGreen.FlatAppearance.BorderSize = 2;
            btnGreen.Location = new Point(146, 33);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(66, 66);
            btnGreen.TabIndex = 9;
            btnGreen.UseVisualStyleBackColor = false;
            // 
            // btnPurple
            // 
            btnPurple.BackColor = Color.Purple;
            btnPurple.FlatAppearance.BorderColor = Color.Gray;
            btnPurple.FlatAppearance.BorderSize = 2;
            btnPurple.Location = new Point(6, 177);
            btnPurple.Name = "btnPurple";
            btnPurple.Size = new Size(66, 66);
            btnPurple.TabIndex = 11;
            btnPurple.UseVisualStyleBackColor = false;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = Color.Yellow;
            btnYellow.FlatAppearance.BorderColor = Color.Gray;
            btnYellow.FlatAppearance.BorderSize = 2;
            btnYellow.Location = new Point(146, 105);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(66, 66);
            btnYellow.TabIndex = 10;
            btnYellow.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnSquare);
            groupBox1.Controls.Add(btnTringle);
            groupBox1.Controls.Add(btnHexagon);
            groupBox1.Controls.Add(btnCircle);
            groupBox1.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox1.Location = new Point(36, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(224, 241);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Çizim Şekli";
            // 
            // btnSquare
            // 
            btnSquare.FlatAppearance.BorderColor = Color.Gray;
            btnSquare.FlatAppearance.BorderSize = 2;
            btnSquare.Image = Properties.Resources.btnSquare;
            btnSquare.Location = new Point(6, 29);
            btnSquare.Name = "btnSquare";
            btnSquare.Size = new Size(100, 100);
            btnSquare.TabIndex = 2;
            btnSquare.UseVisualStyleBackColor = true;
            // 
            // btnTringle
            // 
            btnTringle.FlatAppearance.BorderColor = Color.Gray;
            btnTringle.FlatAppearance.BorderSize = 2;
            btnTringle.Image = Properties.Resources.btnTringle;
            btnTringle.Location = new Point(112, 29);
            btnTringle.Name = "btnTringle";
            btnTringle.Size = new Size(100, 100);
            btnTringle.TabIndex = 1;
            btnTringle.UseVisualStyleBackColor = true;
            // 
            // btnHexagon
            // 
            btnHexagon.FlatAppearance.BorderColor = Color.Gray;
            btnHexagon.FlatAppearance.BorderSize = 2;
            btnHexagon.Image = Properties.Resources.btnHexagon;
            btnHexagon.Location = new Point(112, 135);
            btnHexagon.Name = "btnHexagon";
            btnHexagon.Size = new Size(100, 100);
            btnHexagon.TabIndex = 3;
            btnHexagon.UseVisualStyleBackColor = true;
            // 
            // btnCircle
            // 
            btnCircle.FlatAppearance.BorderColor = Color.Gray;
            btnCircle.FlatAppearance.BorderSize = 2;
            btnCircle.Image = Properties.Resources.btnCircle;
            btnCircle.Location = new Point(6, 135);
            btnCircle.Name = "btnCircle";
            btnCircle.Size = new Size(100, 100);
            btnCircle.TabIndex = 4;
            btnCircle.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnObjectDelete);
            groupBox3.Controls.Add(btnClearObject);
            groupBox3.Controls.Add(btnObjectSelected);
            groupBox3.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            groupBox3.Location = new Point(36, 496);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(224, 101);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Şekil İşlemleri";
            // 
            // btnObjectDelete
            // 
            btnObjectDelete.FlatAppearance.BorderColor = Color.Gray;
            btnObjectDelete.FlatAppearance.BorderSize = 2;
            btnObjectDelete.Image = Properties.Resources.beverageIcon;
            btnObjectDelete.Location = new Point(78, 29);
            btnObjectDelete.Name = "btnObjectDelete";
            btnObjectDelete.Size = new Size(66, 66);
            btnObjectDelete.TabIndex = 16;
            btnObjectDelete.UseVisualStyleBackColor = true;
            // 
            // btnClearObject
            // 
            btnClearObject.FlatAppearance.BorderColor = Color.Gray;
            btnClearObject.FlatAppearance.BorderSize = 2;
            btnClearObject.Image = Properties.Resources.PenIcon;
            btnClearObject.Location = new Point(150, 29);
            btnClearObject.Name = "btnClearObject";
            btnClearObject.Size = new Size(66, 66);
            btnClearObject.TabIndex = 15;
            btnClearObject.UseVisualStyleBackColor = true;
            // 
            // btnObjectSelected
            // 
            btnObjectSelected.FlatAppearance.BorderColor = Color.Gray;
            btnObjectSelected.FlatAppearance.BorderSize = 2;
            btnObjectSelected.Image = Properties.Resources.MouseIcon;
            btnObjectSelected.Location = new Point(6, 29);
            btnObjectSelected.Name = "btnObjectSelected";
            btnObjectSelected.Size = new Size(66, 66);
            btnObjectSelected.TabIndex = 14;
            btnObjectSelected.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(921, 723);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += pictureBox1_Paint;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1217, 747);
            Controls.Add(pictureBox1);
            Controls.Add(ButtonsGroup);
            Font = new Font("Segoe UI", 15F);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ButtonsGroup.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox ButtonsGroup;
        private Button btnTringle;
        private Button btnWhite;
        private Button btnBrown;
        private Button btnPurple;
        private Button btnYellow;
        private Button btnGreen;
        private Button btnOrange;
        private Button btnBlue;
        private Button btnRed;
        private Button btnBlack;
        private Button btnCircle;
        private Button btnHexagon;
        private Button btnSquare;
        private PictureBox pictureBox1;
        private Button btnObjectSelected;
        private Button btnObjectDelete;
        private Button btnClearObject;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnFolder;
        private Button btnSave;
        private GroupBox groupBox4;
    }
}
