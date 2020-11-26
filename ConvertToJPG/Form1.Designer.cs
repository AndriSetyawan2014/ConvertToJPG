namespace ConvertToJPG
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxBMP = new System.Windows.Forms.CheckBox();
            this.checkBoxPNG = new System.Windows.Forms.CheckBox();
            this.buttonConvertToJPG = new System.Windows.Forms.Button();
            this.labelWarning = new System.Windows.Forms.Label();
            this.checkBoxJPEG = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxJPEG);
            this.groupBox1.Controls.Add(this.checkBoxBMP);
            this.groupBox1.Controls.Add(this.checkBoxPNG);
            this.groupBox1.Location = new System.Drawing.Point(45, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Image Type";
            // 
            // checkBoxBMP
            // 
            this.checkBoxBMP.AutoSize = true;
            this.checkBoxBMP.Location = new System.Drawing.Point(6, 48);
            this.checkBoxBMP.Name = "checkBoxBMP";
            this.checkBoxBMP.Size = new System.Drawing.Size(52, 17);
            this.checkBoxBMP.TabIndex = 1;
            this.checkBoxBMP.Text = ".BMP";
            this.checkBoxBMP.UseVisualStyleBackColor = true;
            this.checkBoxBMP.CheckedChanged += new System.EventHandler(this.checkBoxBMP_CheckedChanged);
            // 
            // checkBoxPNG
            // 
            this.checkBoxPNG.AutoSize = true;
            this.checkBoxPNG.Location = new System.Drawing.Point(6, 25);
            this.checkBoxPNG.Name = "checkBoxPNG";
            this.checkBoxPNG.Size = new System.Drawing.Size(52, 17);
            this.checkBoxPNG.TabIndex = 0;
            this.checkBoxPNG.Text = ".PNG";
            this.checkBoxPNG.UseVisualStyleBackColor = true;
            this.checkBoxPNG.CheckedChanged += new System.EventHandler(this.checkBoxPNG_CheckedChanged);
            // 
            // buttonConvertToJPG
            // 
            this.buttonConvertToJPG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvertToJPG.Location = new System.Drawing.Point(192, 131);
            this.buttonConvertToJPG.Name = "buttonConvertToJPG";
            this.buttonConvertToJPG.Size = new System.Drawing.Size(147, 47);
            this.buttonConvertToJPG.TabIndex = 1;
            this.buttonConvertToJPG.Text = "Convert To JPG";
            this.buttonConvertToJPG.UseVisualStyleBackColor = true;
            this.buttonConvertToJPG.Click += new System.EventHandler(this.buttonConvertToJPG_Click);
            // 
            // labelWarning
            // 
            this.labelWarning.AutoSize = true;
            this.labelWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWarning.Location = new System.Drawing.Point(42, 189);
            this.labelWarning.Name = "labelWarning";
            this.labelWarning.Size = new System.Drawing.Size(98, 13);
            this.labelWarning.TabIndex = 2;
            this.labelWarning.Text = "label WARNING";
            this.labelWarning.Visible = false;
            // 
            // checkBoxJPEG
            // 
            this.checkBoxJPEG.AutoSize = true;
            this.checkBoxJPEG.Location = new System.Drawing.Point(6, 71);
            this.checkBoxJPEG.Name = "checkBoxJPEG";
            this.checkBoxJPEG.Size = new System.Drawing.Size(56, 17);
            this.checkBoxJPEG.TabIndex = 2;
            this.checkBoxJPEG.Text = ".JPEG";
            this.checkBoxJPEG.UseVisualStyleBackColor = true;
            this.checkBoxJPEG.CheckedChanged += new System.EventHandler(this.checkBoxJPEG_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 211);
            this.Controls.Add(this.labelWarning);
            this.Controls.Add(this.buttonConvertToJPG);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Convert To JPG";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxBMP;
        private System.Windows.Forms.CheckBox checkBoxPNG;
        private System.Windows.Forms.Button buttonConvertToJPG;
        private System.Windows.Forms.Label labelWarning;
        private System.Windows.Forms.CheckBox checkBoxJPEG;
    }
}

