using static System.Net.Mime.MediaTypeNames;

namespace Vball_referee_trainer
{
    public partial class Form1 : Form
    {
        private bool correctRotation;
        public Form1()
        {
            InitializeComponent();

            RotationPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            RotationPictureBox.BorderStyle = BorderStyle.FixedSingle;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            RotationPictureBox.ImageLocation = "C:\\Users\\Owner\\Vball-referee-trainer\\ReceiveRotations\\Rot 1 - correct(1).png";

            correctRotation = true;
        }

        private void CorrectButton_Click(object sender, EventArgs e)
        {
            if (RotationPictureBox.Image != null)
            {
                if (correctRotation)
                {
                    AnswerTextbox.Text = "Correct!";
                }
                else
                {
                    AnswerTextbox.Text = "Incorrect.";
                }
            }
        }


        private void IncorrectButton_Click(object sender, EventArgs e)
        {
            if (RotationPictureBox.Image != null)
            {
                if (!correctRotation)
                {
                    AnswerTextbox.Text = "Correct!";
                }
                else
                {
                    AnswerTextbox.Text = "Incorrect";
                }
            }
        }
    }
}
