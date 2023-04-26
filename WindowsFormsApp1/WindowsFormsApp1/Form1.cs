using System;
using System.Drawing;
using System.Windows.Forms;

namespace Digital_image_processing
{
    public partial class Form1 : Form
    {
        private Bitmap image;

        IProcessingImage processingImage { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;

            inputImage.Image = null;
            outputImage.Image = null;

            lblMethod.Top = comboBox.Top + lblMethod.Height + 15;

            btnSelectImage.TextAlign = ContentAlignment.MiddleCenter;

            string[] methodNames = MethodNames.AllMethodNames();

            foreach(string method in methodNames)
            comboBox.Items.Add(method);
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            lblInputImage.Visible = false;
            lblOutputImage.Visible = false;
            lblMethod.Visible = false;
            inputImage.Image = null;

            try
            {
                outputImage.Image = null;

                openFile.Filter = "Image Files(*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG)|*.BMP;*.JPG;*.JPEG;*.GIF;*.PNG";

                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    image = new Bitmap(openFile.FileName);
                }

                inputImage.Size = image.Size;
                inputImage.Left = ClientSize.Width / 2 - inputImage.Width - 30;
                inputImage.Top = (ClientSize.Height - inputImage.Height) / 2;

                inputImage.Image = image;

                lblInputImage.Visible = true;
                lblInputImage.AutoSize = true;
                lblInputImage.TextAlign = ContentAlignment.MiddleCenter;
                lblInputImage.Left = inputImage.Left + (inputImage.ClientSize.Width - lblInputImage.Width) / 2;
                lblInputImage.Top = inputImage.Top - lblInputImage.Height - 10;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Не вдалось завантажити зображення!");
            }
        }

        private void btnProcessing_Click(object sender, EventArgs e)
        {
            outputImage.Image = null;

            string selectedValue = "";
            if (image != null)
            {
                Bitmap resultImage = new Bitmap(image.Width, image.Height);

                if (comboBox.SelectedItem != null)
                    selectedValue = comboBox.SelectedItem.ToString();

                Context context = new Context(selectedValue, image);
                processingImage = context.ProcessingImage;

                if (processingImage != null)
                {
                    resultImage = processingImage.Algorithm();
                    lblMethod.Text = processingImage.ToString();

                    outputImage.Size = resultImage.Size;
                    outputImage.Left = ClientSize.Width / 2 + 30;
                    outputImage.Top = (ClientSize.Height - outputImage.Height) / 2;
                    outputImage.Image = resultImage;

                    lblInputImage.Visible = true;
                    lblOutputImage.Visible = true;
                    lblOutputImage.AutoSize = true;
                    lblOutputImage.TextAlign = ContentAlignment.MiddleCenter;
                    lblOutputImage.Left = outputImage.Left + (outputImage.ClientSize.Width - lblOutputImage.Width) / 2;
                    lblOutputImage.Top = outputImage.Top - lblOutputImage.Height - 10;

                    lblMethod.Visible = true;
                    int distanceGreaterThanBetweenImages = 0;
                    if (lblMethod.Width > 60)
                        distanceGreaterThanBetweenImages = lblMethod.Width - 60;

                    lblMethod.Left = ClientSize.Width / 2 - 30 - distanceGreaterThanBetweenImages / 2;
                }
            }
            else
            {
                MessageBox.Show("Не вибрано зображення!");
            }
        }
    }
}

