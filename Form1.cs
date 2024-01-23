using System.Windows.Forms;

namespace base64ToImg
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConvertBase64_Click(object sender, EventArgs e)
        {
            try
            {
                string base64String = richTextBox1.Text;

                byte[] imageBytes = Convert.FromBase64String(base64String);

                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    // Create an Image from the MemoryStream
                    Image originalImage = Image.FromStream(ms);

                    // Resize the image to fit in the PictureBox
                    Image resizedImage = ResizeImage(originalImage, pictureBox1.Width, pictureBox1.Height);

                    // Display the resized image in the PictureBox
                    pictureBox1.Image = resizedImage;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Image ResizeImage(Image image, int width, int height)
        {
            Bitmap result = new Bitmap(width, height);

            using (Graphics g = Graphics.FromImage(result))
            {
                g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                g.DrawImage(image, 0, 0, width, height);
            }

            return result;
        }
    }
}
