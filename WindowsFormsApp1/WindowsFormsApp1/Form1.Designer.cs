
namespace Digital_image_processing
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputImage = new System.Windows.Forms.PictureBox();
            this.outputImage = new System.Windows.Forms.PictureBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btnProcessing = new System.Windows.Forms.Button();
            this.lblInputImage = new System.Windows.Forms.Label();
            this.lblOutputImage = new System.Windows.Forms.Label();
            this.lblMethod = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inputImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).BeginInit();
            this.SuspendLayout();
            // 
            // inputImage
            // 
            this.inputImage.Location = new System.Drawing.Point(64, 102);
            this.inputImage.Name = "inputImage";
            this.inputImage.Size = new System.Drawing.Size(133, 96);
            this.inputImage.TabIndex = 0;
            this.inputImage.TabStop = false;
            // 
            // outputImage
            // 
            this.outputImage.Location = new System.Drawing.Point(750, 102);
            this.outputImage.Name = "outputImage";
            this.outputImage.Size = new System.Drawing.Size(100, 50);
            this.outputImage.TabIndex = 1;
            this.outputImage.TabStop = false;
            // 
            // openFile
            // 
            this.openFile.FileName = "openFile";
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectImage.Location = new System.Drawing.Point(3, 6);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(245, 73);
            this.btnSelectImage.TabIndex = 2;
            this.btnSelectImage.Text = "Вибрати зображення";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // comboBox
            // 
            this.comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(254, 26);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(378, 34);
            this.comboBox.TabIndex = 3;
            // 
            // btnProcessing
            // 
            this.btnProcessing.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnProcessing.Location = new System.Drawing.Point(3, 99);
            this.btnProcessing.Name = "btnProcessing";
            this.btnProcessing.Size = new System.Drawing.Size(245, 53);
            this.btnProcessing.TabIndex = 4;
            this.btnProcessing.Text = "Обробка";
            this.btnProcessing.UseVisualStyleBackColor = true;
            this.btnProcessing.Click += new System.EventHandler(this.btnProcessing_Click);
            // 
            // lblInputImage
            // 
            this.lblInputImage.AutoSize = true;
            this.lblInputImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblInputImage.Location = new System.Drawing.Point(351, 135);
            this.lblInputImage.Name = "lblInputImage";
            this.lblInputImage.Size = new System.Drawing.Size(256, 29);
            this.lblInputImage.TabIndex = 5;
            this.lblInputImage.Text = "Вхідне зображення";
            this.lblInputImage.Visible = false;
            // 
            // lblOutputImage
            // 
            this.lblOutputImage.AutoSize = true;
            this.lblOutputImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOutputImage.Location = new System.Drawing.Point(941, 26);
            this.lblOutputImage.Name = "lblOutputImage";
            this.lblOutputImage.Size = new System.Drawing.Size(272, 29);
            this.lblOutputImage.TabIndex = 6;
            this.lblOutputImage.Text = "Вихідне зображення";
            this.lblOutputImage.Visible = false;
            // 
            // lblMethod
            // 
            this.lblMethod.AutoSize = true;
            this.lblMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMethod.Location = new System.Drawing.Point(651, 26);
            this.lblMethod.Name = "lblMethod";
            this.lblMethod.Size = new System.Drawing.Size(92, 29);
            this.lblMethod.TabIndex = 7;
            this.lblMethod.Text = "Метод";
            this.lblMethod.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 563);
            this.Controls.Add(this.lblMethod);
            this.Controls.Add(this.lblOutputImage);
            this.Controls.Add(this.lblInputImage);
            this.Controls.Add(this.btnProcessing);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.outputImage);
            this.Controls.Add(this.inputImage);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Обробка цифрових зображень";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox inputImage;
        private System.Windows.Forms.PictureBox outputImage;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btnProcessing;
        private System.Windows.Forms.Label lblInputImage;
        private System.Windows.Forms.Label lblOutputImage;
        private System.Windows.Forms.Label lblMethod;
    }
}

