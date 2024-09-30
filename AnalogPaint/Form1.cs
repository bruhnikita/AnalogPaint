namespace AnalogPaint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetSize();
        }

        private ArrayPoints points = new ArrayPoints(2);
        private bool isMouse = false;

        private Bitmap bitmap;
        private Graphics g;
        private Pen pen = new Pen(Color.Black, 3f);

        private void SetSize()
        {
            Rectangle rectangle = Screen.PrimaryScreen.Bounds;
            bitmap = new Bitmap(rectangle.Width, rectangle.Height);
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isMouse = true;
            points.Setpoint(e.X, e.Y);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouse = false;
            points.ResetPoints();
            pictureBox1.Image = bitmap;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isMouse) return;

            points.Setpoint(e.X, e.Y);
            if (points.GetCountPoints() >= 2)
            {
                g.DrawLines(pen, points.GetPoints());
                points.ResetPoints(); 
                pictureBox1.Image = bitmap; 
                pictureBox1.Invalidate(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pen.Color = ((Button)sender).BackColor;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pen.Color = colorDialog1.Color;
                ((Button)sender).BackColor = colorDialog1.Color;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pictureBox1.Image = bitmap; 
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = trackBar1.Value;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "JPG(*.JPG)|*.jpg";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                bitmap.Save(saveFileDialog1.FileName);
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            g.Dispose();
            bitmap.Dispose();
            base.OnFormClosed(e);
        }
    }
}
