
namespace Project.V14
{
    partial class FormRoute
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRoute));
            panelRouteDescription_TDE = new Panel();
            groupBoxRouteDescription_TDE = new GroupBox();
            groupBox1 = new GroupBox();
            textBoxRouteTime_TDE = new TextBox();
            textBoxRouteType_TDE = new TextBox();
            textBox4 = new TextBox();
            textBoxRouteEnd_TDE = new TextBox();
            textBoxRouteStart_TDE = new TextBox();
            textBoxRouteId_TDE = new TextBox();
            panelRouteImage_TDE = new Panel();
            pictureBoxRoute_TDE = new PictureBox();
            panelRouteStops_TDE = new Panel();
            groupBoxRouteList_TDE = new GroupBox();
            flowLayoutPanel_TDE = new FlowLayoutPanel();
            panelRouteDescription_TDE.SuspendLayout();
            groupBoxRouteDescription_TDE.SuspendLayout();
            groupBox1.SuspendLayout();
            panelRouteImage_TDE.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoute_TDE).BeginInit();
            panelRouteStops_TDE.SuspendLayout();
            groupBoxRouteList_TDE.SuspendLayout();
            SuspendLayout();
            // 
            // panelRouteDescription_TDE
            // 
            panelRouteDescription_TDE.Controls.Add(groupBoxRouteDescription_TDE);
            panelRouteDescription_TDE.Dock = DockStyle.Left;
            panelRouteDescription_TDE.Location = new Point(0, 0);
            panelRouteDescription_TDE.Margin = new Padding(3, 4, 3, 4);
            panelRouteDescription_TDE.Name = "panelRouteDescription_TDE";
            panelRouteDescription_TDE.Padding = new Padding(6, 7, 6, 7);
            panelRouteDescription_TDE.Size = new Size(229, 424);
            panelRouteDescription_TDE.TabIndex = 1;
            // 
            // groupBoxRouteDescription_TDE
            // 
            groupBoxRouteDescription_TDE.Controls.Add(groupBox1);
            groupBoxRouteDescription_TDE.Controls.Add(textBoxRouteType_TDE);
            groupBoxRouteDescription_TDE.Controls.Add(textBox4);
            groupBoxRouteDescription_TDE.Controls.Add(textBoxRouteEnd_TDE);
            groupBoxRouteDescription_TDE.Controls.Add(textBoxRouteStart_TDE);
            groupBoxRouteDescription_TDE.Controls.Add(textBoxRouteId_TDE);
            groupBoxRouteDescription_TDE.Dock = DockStyle.Fill;
            groupBoxRouteDescription_TDE.Location = new Point(6, 7);
            groupBoxRouteDescription_TDE.Margin = new Padding(3, 4, 3, 4);
            groupBoxRouteDescription_TDE.Name = "groupBoxRouteDescription_TDE";
            groupBoxRouteDescription_TDE.Padding = new Padding(3, 4, 3, 4);
            groupBoxRouteDescription_TDE.Size = new Size(217, 410);
            groupBoxRouteDescription_TDE.TabIndex = 0;
            groupBoxRouteDescription_TDE.TabStop = false;
            groupBoxRouteDescription_TDE.Text = "Описание";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxRouteTime_TDE);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(3, 273);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(211, 133);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Время";
            // 
            // textBoxRouteTime_TDE
            // 
            textBoxRouteTime_TDE.BorderStyle = BorderStyle.None;
            textBoxRouteTime_TDE.Dock = DockStyle.Fill;
            textBoxRouteTime_TDE.Location = new Point(3, 24);
            textBoxRouteTime_TDE.Margin = new Padding(3, 4, 3, 4);
            textBoxRouteTime_TDE.Multiline = true;
            textBoxRouteTime_TDE.Name = "textBoxRouteTime_TDE";
            textBoxRouteTime_TDE.ReadOnly = true;
            textBoxRouteTime_TDE.Size = new Size(205, 105);
            textBoxRouteTime_TDE.TabIndex = 5;
            textBoxRouteTime_TDE.Text = "Примерное время ожидания автобуса - ";
            // 
            // textBoxRouteType_TDE
            // 
            textBoxRouteType_TDE.BorderStyle = BorderStyle.None;
            textBoxRouteType_TDE.Location = new Point(3, 180);
            textBoxRouteType_TDE.Margin = new Padding(3, 4, 3, 4);
            textBoxRouteType_TDE.Multiline = true;
            textBoxRouteType_TDE.Name = "textBoxRouteType_TDE";
            textBoxRouteType_TDE.ReadOnly = true;
            textBoxRouteType_TDE.Size = new Size(210, 52);
            textBoxRouteType_TDE.TabIndex = 4;
            textBoxRouteType_TDE.Text = "Вид транспорта - ";
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(3, 185);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(210, 52);
            textBox4.TabIndex = 3;
            textBox4.Text = "Вид транспорта - ";
            // 
            // textBoxRouteEnd_TDE
            // 
            textBoxRouteEnd_TDE.BorderStyle = BorderStyle.None;
            textBoxRouteEnd_TDE.Location = new Point(3, 120);
            textBoxRouteEnd_TDE.Margin = new Padding(3, 4, 3, 4);
            textBoxRouteEnd_TDE.Multiline = true;
            textBoxRouteEnd_TDE.Name = "textBoxRouteEnd_TDE";
            textBoxRouteEnd_TDE.ReadOnly = true;
            textBoxRouteEnd_TDE.Size = new Size(210, 52);
            textBoxRouteEnd_TDE.TabIndex = 2;
            textBoxRouteEnd_TDE.Text = "Конечная остановка - ";
            // 
            // textBoxRouteStart_TDE
            // 
            textBoxRouteStart_TDE.BorderStyle = BorderStyle.None;
            textBoxRouteStart_TDE.Location = new Point(3, 68);
            textBoxRouteStart_TDE.Margin = new Padding(3, 4, 3, 4);
            textBoxRouteStart_TDE.Multiline = true;
            textBoxRouteStart_TDE.Name = "textBoxRouteStart_TDE";
            textBoxRouteStart_TDE.ReadOnly = true;
            textBoxRouteStart_TDE.Size = new Size(210, 49);
            textBoxRouteStart_TDE.TabIndex = 1;
            textBoxRouteStart_TDE.Text = "Начальная остановка - ";
            // 
            // textBoxRouteId_TDE
            // 
            textBoxRouteId_TDE.BorderStyle = BorderStyle.None;
            textBoxRouteId_TDE.Location = new Point(3, 29);
            textBoxRouteId_TDE.Margin = new Padding(3, 4, 3, 4);
            textBoxRouteId_TDE.Multiline = true;
            textBoxRouteId_TDE.Name = "textBoxRouteId_TDE";
            textBoxRouteId_TDE.ReadOnly = true;
            textBoxRouteId_TDE.Size = new Size(210, 31);
            textBoxRouteId_TDE.TabIndex = 0;
            textBoxRouteId_TDE.Text = "Номер маршрута -";
            // 
            // panelRouteImage_TDE
            // 
            panelRouteImage_TDE.Controls.Add(pictureBoxRoute_TDE);
            panelRouteImage_TDE.Location = new Point(229, 0);
            panelRouteImage_TDE.Margin = new Padding(3, 4, 3, 4);
            panelRouteImage_TDE.Name = "panelRouteImage_TDE";
            panelRouteImage_TDE.Padding = new Padding(6, 7, 6, 7);
            panelRouteImage_TDE.Size = new Size(255, 212);
            panelRouteImage_TDE.TabIndex = 2;
            // 
            // pictureBoxRoute_TDE
            // 
            pictureBoxRoute_TDE.Dock = DockStyle.Fill;
            pictureBoxRoute_TDE.ErrorImage = null;
            pictureBoxRoute_TDE.Location = new Point(6, 7);
            pictureBoxRoute_TDE.Margin = new Padding(3, 4, 3, 4);
            pictureBoxRoute_TDE.Name = "pictureBoxRoute_TDE";
            pictureBoxRoute_TDE.Size = new Size(243, 198);
            pictureBoxRoute_TDE.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxRoute_TDE.TabIndex = 0;
            pictureBoxRoute_TDE.TabStop = false;
            // 
            // panelRouteStops_TDE
            // 
            panelRouteStops_TDE.Controls.Add(groupBoxRouteList_TDE);
            panelRouteStops_TDE.Dock = DockStyle.Bottom;
            panelRouteStops_TDE.Location = new Point(229, 213);
            panelRouteStops_TDE.Margin = new Padding(3, 4, 3, 4);
            panelRouteStops_TDE.Name = "panelRouteStops_TDE";
            panelRouteStops_TDE.Padding = new Padding(6, 7, 6, 7);
            panelRouteStops_TDE.Size = new Size(254, 211);
            panelRouteStops_TDE.TabIndex = 3;
            // 
            // groupBoxRouteList_TDE
            // 
            groupBoxRouteList_TDE.Controls.Add(flowLayoutPanel_TDE);
            groupBoxRouteList_TDE.Dock = DockStyle.Fill;
            groupBoxRouteList_TDE.Location = new Point(6, 7);
            groupBoxRouteList_TDE.Margin = new Padding(3, 4, 3, 4);
            groupBoxRouteList_TDE.Name = "groupBoxRouteList_TDE";
            groupBoxRouteList_TDE.Padding = new Padding(3, 4, 3, 4);
            groupBoxRouteList_TDE.Size = new Size(242, 197);
            groupBoxRouteList_TDE.TabIndex = 0;
            groupBoxRouteList_TDE.TabStop = false;
            groupBoxRouteList_TDE.Text = "Остановки";
            // 
            // flowLayoutPanel_TDE
            // 
            flowLayoutPanel_TDE.Dock = DockStyle.Fill;
            flowLayoutPanel_TDE.Location = new Point(3, 24);
            flowLayoutPanel_TDE.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel_TDE.Name = "flowLayoutPanel_TDE";
            flowLayoutPanel_TDE.Size = new Size(236, 169);
            flowLayoutPanel_TDE.TabIndex = 4;
            flowLayoutPanel_TDE.Paint += flowLayoutPanel_TDE_Paint;
            // 
            // FormRoute
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 424);
            Controls.Add(panelRouteStops_TDE);
            Controls.Add(panelRouteImage_TDE);
            Controls.Add(panelRouteDescription_TDE);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(499, 460);
            Name = "FormRoute";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Маршруты";
            Load += FormRoute_Load;
            panelRouteDescription_TDE.ResumeLayout(false);
            groupBoxRouteDescription_TDE.ResumeLayout(false);
            groupBoxRouteDescription_TDE.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panelRouteImage_TDE.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxRoute_TDE).EndInit();
            panelRouteStops_TDE.ResumeLayout(false);
            groupBoxRouteList_TDE.ResumeLayout(false);
            ResumeLayout(false);
        }

        private void flowLayoutPanel_TDE_Paint(object sender, PaintEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void FormRouteLoad(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private Panel panelRouteDescription_TDE;
        private GroupBox groupBoxRouteDescription_TDE;
        private Panel panelRouteImage_TDE;
        private PictureBox pictureBoxRoute_TDE;
        private GroupBox groupBox1;
        private TextBox textBoxRouteTime_TDE;
        private TextBox textBoxRouteType_TDE;
        private TextBox textBox4;
        private TextBox textBoxRouteEnd_TDE;
        private TextBox textBoxRouteStart_TDE;
        private TextBox textBoxRouteId_TDE;
        private Panel panelRouteStops_TDE;
        private GroupBox groupBoxRouteList_TDE;
        private FlowLayoutPanel flowLayoutPanel_TDE;
    }
}
