namespace AnalogPaint
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
            pictureBox1 = new PictureBox();
            buttonSave = new Button();
            clearButton = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            panel1 = new Panel();
            label1 = new Label();
            trackBar1 = new TrackBar();
            colorDialog1 = new ColorDialog();
            saveFileDialog1 = new SaveFileDialog();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(828, 450);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            pictureBox1.MouseUp += pictureBox1_MouseUp;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(5, 415);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(192, 23);
            buttonSave.TabIndex = 1;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(5, 386);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(192, 23);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button5);
            flowLayoutPanel1.Controls.Add(button6);
            flowLayoutPanel1.Controls.Add(button7);
            flowLayoutPanel1.Controls.Add(button8);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.Location = new Point(0, 100);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(200, 100);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            button1.MouseClick += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(39, 3);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.MouseClick += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(75, 3);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.MouseClick += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Blue;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(111, 3);
            button4.Name = "button4";
            button4.Size = new Size(30, 30);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = false;
            button4.MouseClick += button1_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Fuchsia;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(147, 3);
            button5.Name = "button5";
            button5.Size = new Size(30, 30);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = false;
            button5.MouseClick += button1_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Yellow;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(3, 39);
            button6.Name = "button6";
            button6.Size = new Size(30, 30);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = false;
            button6.MouseClick += button1_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Black;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(39, 39);
            button7.Name = "button7";
            button7.Size = new Size(30, 30);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.MouseClick += button1_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Gray;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Location = new Point(75, 39);
            button8.Name = "button8";
            button8.Size = new Size(30, 30);
            button8.TabIndex = 7;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            button8.MouseClick += button1_Click;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(trackBar1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("XO Courser", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 15);
            label1.TabIndex = 1;
            label1.Text = "Выбор толщины";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // trackBar1
            // 
            trackBar1.Dock = DockStyle.Bottom;
            trackBar1.Location = new Point(0, 51);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(196, 45);
            trackBar1.TabIndex = 0;
            trackBar1.ValueChanged += trackBar1_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(clearButton);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(buttonSave);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(628, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 450);
            panel2.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 450);
            Controls.Add(panel2);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        public Button buttonSave;
        public Button clearButton;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Panel panel1;
        private Label label1;
        private TrackBar trackBar1;
        private ColorDialog colorDialog1;
        private SaveFileDialog saveFileDialog1;
        private Panel panel2;
    }
}
