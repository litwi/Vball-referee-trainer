using Microsoft.VisualBasic.ApplicationServices;
using System.Security.Cryptography.Xml;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

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
            var random = new Random();
            var rotationFiles = Directory.GetFiles("C:\\Users\\Owner\\Vball-referee-trainer\\ReceiveRotations\\", "*.png", SearchOption.AllDirectories);

            RotationPictureBox.ImageLocation = rotationFiles[random.Next(rotationFiles.Length)];

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
