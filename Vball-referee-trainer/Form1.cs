using static System.Net.Mime.MediaTypeNames;

namespace Vball_referee_trainer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            RotationPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            RotationPictureBox.ImageLocation = "C:\\Users\\Owner\\Vball-referee-trainer\\ReceiveRotations\\Rot 1 - correct(1).png";
        }
    }
}
