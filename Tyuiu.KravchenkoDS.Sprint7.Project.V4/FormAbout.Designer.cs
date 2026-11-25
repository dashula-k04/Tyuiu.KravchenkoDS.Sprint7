namespace Tyuiu.KravchenkoDS.Sprint7.Project.V4
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar_KDS = new PictureBox();
            labelAvatar_KDS = new Label();
            buttonOK_KDS = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KDS).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar_KDS
            // 
            pictureBoxAvatar_KDS.Image = (Image)resources.GetObject("pictureBoxAvatar_KDS.Image");
            pictureBoxAvatar_KDS.InitialImage = null;
            pictureBoxAvatar_KDS.Location = new Point(12, 12);
            pictureBoxAvatar_KDS.Name = "pictureBoxAvatar_KDS";
            pictureBoxAvatar_KDS.Size = new Size(207, 280);
            pictureBoxAvatar_KDS.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar_KDS.TabIndex = 0;
            pictureBoxAvatar_KDS.TabStop = false;
            // 
            // labelAvatar_KDS
            // 
            labelAvatar_KDS.AutoSize = true;
            labelAvatar_KDS.Location = new Point(225, 28);
            labelAvatar_KDS.Name = "labelAvatar_KDS";
            labelAvatar_KDS.Size = new Size(595, 180);
            labelAvatar_KDS.TabIndex = 1;
            labelAvatar_KDS.Text = resources.GetString("labelAvatar_KDS.Text");
            // 
            // buttonOK_KDS
            // 
            buttonOK_KDS.Location = new Point(694, 388);
            buttonOK_KDS.Name = "buttonOK_KDS";
            buttonOK_KDS.Size = new Size(94, 29);
            buttonOK_KDS.TabIndex = 2;
            buttonOK_KDS.Text = "OK";
            buttonOK_KDS.UseVisualStyleBackColor = true;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(861, 450);
            Controls.Add(buttonOK_KDS);
            Controls.Add(labelAvatar_KDS);
            Controls.Add(pictureBoxAvatar_KDS);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_KDS).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar_KDS;
        private Label labelAvatar_KDS;
        private Button buttonOK_KDS;
    }
}