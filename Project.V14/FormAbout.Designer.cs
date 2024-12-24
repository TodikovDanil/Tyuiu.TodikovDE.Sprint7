namespace Project.V14
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
            panelAboutText_TDE = new Panel();
            groupBoxAbout_TDE = new GroupBox();
            textBox1 = new TextBox();
            pictureBoxAbout_TDE = new PictureBox();
            panelAboutText_TDE.SuspendLayout();
            groupBoxAbout_TDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_TDE).BeginInit();
            SuspendLayout();
            // 
            // panelAboutText_TDE
            // 
            panelAboutText_TDE.Controls.Add(groupBoxAbout_TDE);
            panelAboutText_TDE.Dock = DockStyle.Right;
            panelAboutText_TDE.Location = new Point(270, 0);
            panelAboutText_TDE.Margin = new Padding(3, 4, 3, 4);
            panelAboutText_TDE.Name = "panelAboutText_TDE";
            panelAboutText_TDE.Padding = new Padding(6, 0, 0, 0);
            panelAboutText_TDE.Size = new Size(312, 353);
            panelAboutText_TDE.TabIndex = 0;
            // 
            // groupBoxAbout_TDE
            // 
            groupBoxAbout_TDE.Controls.Add(textBox1);
            groupBoxAbout_TDE.Dock = DockStyle.Fill;
            groupBoxAbout_TDE.Location = new Point(6, 0);
            groupBoxAbout_TDE.Margin = new Padding(3, 4, 3, 4);
            groupBoxAbout_TDE.Name = "groupBoxAbout_TDE";
            groupBoxAbout_TDE.Padding = new Padding(3, 4, 3, 4);
            groupBoxAbout_TDE.Size = new Size(306, 353);
            groupBoxAbout_TDE.TabIndex = 1;
            groupBoxAbout_TDE.TabStop = false;
            groupBoxAbout_TDE.Text = "Описание";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 24);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(300, 325);
            textBox1.TabIndex = 1;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // pictureBoxAbout_TDE
            // 
            pictureBoxAbout_TDE.Dock = DockStyle.Fill;
            pictureBoxAbout_TDE.Image = (Image)resources.GetObject("pictureBoxAbout_TDE.Image");
            pictureBoxAbout_TDE.Location = new Point(0, 0);
            pictureBoxAbout_TDE.Margin = new Padding(3, 4, 3, 4);
            pictureBoxAbout_TDE.Name = "pictureBoxAbout_TDE";
            pictureBoxAbout_TDE.Size = new Size(270, 353);
            pictureBoxAbout_TDE.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAbout_TDE.TabIndex = 1;
            pictureBoxAbout_TDE.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 353);
            Controls.Add(pictureBoxAbout_TDE);
            Controls.Add(panelAboutText_TDE);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximumSize = new Size(600, 400);
            MinimumSize = new Size(537, 364);
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            Load += FormAbout_Load;
            panelAboutText_TDE.ResumeLayout(false);
            groupBoxAbout_TDE.ResumeLayout(false);
            groupBoxAbout_TDE.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAbout_TDE).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelAboutText_TDE;
        private PictureBox pictureBoxAbout_TDE;
        private GroupBox groupBoxAbout_TDE;
        private TextBox textBox1;
    }
}

