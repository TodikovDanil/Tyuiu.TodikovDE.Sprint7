using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project.V14
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            panelGuideImage_TDE = new Panel();
            pictureBoxGuide_TDE = new PictureBox();
            panelGuideDescription_TDE = new Panel();
            groupBoxGuideDescription_TDE = new GroupBox();
            textBoxGuide_TDE = new TextBox();
            panelGuideImage_TDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuide_TDE).BeginInit();
            panelGuideDescription_TDE.SuspendLayout();
            groupBoxGuideDescription_TDE.SuspendLayout();
            SuspendLayout();
            // 
            // panelGuideImage_TDE
            // 
            panelGuideImage_TDE.Controls.Add(pictureBoxGuide_TDE);
            panelGuideImage_TDE.Dock = DockStyle.Top;
            panelGuideImage_TDE.Location = new Point(0, 0);
            panelGuideImage_TDE.Margin = new Padding(3, 4, 3, 4);
            panelGuideImage_TDE.Name = "panelGuideImage_TDE";
            panelGuideImage_TDE.Padding = new Padding(6, 7, 6, 7);
            panelGuideImage_TDE.Size = new Size(846, 300);
            panelGuideImage_TDE.TabIndex = 0;
            // 
            // pictureBoxGuide_TDE
            // 
            pictureBoxGuide_TDE.Dock = DockStyle.Fill;
            pictureBoxGuide_TDE.Image = (System.Drawing.Image)resources.GetObject("pictureBoxGuide_TDE.Image");
            pictureBoxGuide_TDE.Location = new Point(6, 7);
            pictureBoxGuide_TDE.Margin = new Padding(3, 4, 3, 4);
            pictureBoxGuide_TDE.Name = "pictureBoxGuide_TDE";
            pictureBoxGuide_TDE.Size = new Size(834, 286);
            pictureBoxGuide_TDE.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxGuide_TDE.TabIndex = 0;
            pictureBoxGuide_TDE.TabStop = false;
            pictureBoxGuide_TDE.Click += pictureBoxGuide_TDE_Click;
            // 
            // panelGuideDescription_TDE
            // 
            panelGuideDescription_TDE.Controls.Add(groupBoxGuideDescription_TDE);
            panelGuideDescription_TDE.Dock = DockStyle.Bottom;
            panelGuideDescription_TDE.Location = new Point(0, 299);
            panelGuideDescription_TDE.Margin = new Padding(3, 4, 3, 4);
            panelGuideDescription_TDE.Name = "panelGuideDescription_TDE";
            panelGuideDescription_TDE.Padding = new Padding(6, 7, 6, 7);
            panelGuideDescription_TDE.Size = new Size(846, 292);
            panelGuideDescription_TDE.TabIndex = 1;
            // 
            // groupBoxGuideDescription_TDE
            // 
            groupBoxGuideDescription_TDE.Controls.Add(textBoxGuide_TDE);
            groupBoxGuideDescription_TDE.Dock = DockStyle.Fill;
            groupBoxGuideDescription_TDE.Location = new Point(6, 7);
            groupBoxGuideDescription_TDE.Margin = new Padding(3, 4, 3, 4);
            groupBoxGuideDescription_TDE.Name = "groupBoxGuideDescription_TDE";
            groupBoxGuideDescription_TDE.Padding = new Padding(3, 4, 3, 4);
            groupBoxGuideDescription_TDE.Size = new Size(834, 278);
            groupBoxGuideDescription_TDE.TabIndex = 0;
            groupBoxGuideDescription_TDE.TabStop = false;
            groupBoxGuideDescription_TDE.Text = "Описание";
            // 
            // textBoxGuide_TDE
            // 
            textBoxGuide_TDE.BorderStyle = BorderStyle.None;
            textBoxGuide_TDE.Dock = DockStyle.Fill;
            textBoxGuide_TDE.Location = new Point(3, 24);
            textBoxGuide_TDE.Margin = new Padding(3, 4, 3, 4);
            textBoxGuide_TDE.Multiline = true;
            textBoxGuide_TDE.Name = "textBoxGuide_TDE";
            textBoxGuide_TDE.ReadOnly = true;
            textBoxGuide_TDE.Size = new Size(828, 250);
            textBoxGuide_TDE.TabIndex = 0;
            textBoxGuide_TDE.Text = resources.GetString("textBoxGuide_TDE.Text");
            textBoxGuide_TDE.TextChanged += textBoxGuide_TDE_TextChanged;
            textBoxGuide_TDE.Enter += textBoxGuide_TDE_Enter;
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 591);
            Controls.Add(panelGuideDescription_TDE);
            Controls.Add(panelGuideImage_TDE);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MaximumSize = new Size(1000, 1000);
            MinimumSize = new Size(671, 638);
            Name = "FormGuide";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Руководство";
            panelGuideImage_TDE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxGuide_TDE).EndInit();
            panelGuideDescription_TDE.ResumeLayout(false);
            groupBoxGuideDescription_TDE.ResumeLayout(false);
            groupBoxGuideDescription_TDE.PerformLayout();
            ResumeLayout(false);
        }

        private void textBoxGuide_TDE_Enter(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Panel panelGuideImage_TDE;
    private Panel panelGuideDescription_TDE;
    private PictureBox pictureBoxGuide_TDE;
    private GroupBox groupBoxGuideDescription_TDE;
    private TextBox textBoxGuide_TDE;
}
}
