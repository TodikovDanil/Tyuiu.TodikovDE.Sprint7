using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project.V14
{
    partial class FormMain
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            menuStrip_TDE = new MenuStrip();
            ToolStripMenuItemProgramm_TDE = new ToolStripMenuItem();
            ToolStripMenuAbout_TDE = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            ToolStripMenuExit_TDE = new ToolStripMenuItem();
            ToolStripMenuItemFile_TDE = new ToolStripMenuItem();
            ToolStripMenuOpenNewFileTool_TDE = new ToolStripMenuItem();
            ToolStripMenuOpenNewFile_TDE = new ToolStripMenuItem();
            ToolStripMenuImages_TDE = new ToolStripMenuItem();
            ToolStripMenuSaveFile_TDE = new ToolStripMenuItem();
            ToolStripMenuRefresh_TDE = new ToolStripMenuItem();
            ToolStripMenuOpenFile_TDE = new ToolStripMenuItem();
            tableLayoutPanel_TDE = new TableLayoutPanel();
            panelControl_TDE = new Panel();
            groupBox1 = new GroupBox();
            buttonHelp_TDE = new Button();
            groupBoxFile_TDE = new GroupBox();
            buttonUpdateFile_TDE = new Button();
            buttonSaveFile_TDE = new Button();
            buttonOpenFile_TDE = new Button();
            groupBoxSearch_TDE = new GroupBox();
            buttonSearch_TDE = new Button();
            textBoxSearch_TDE = new TextBox();
            tabControlRoutes_TDE = new TabControl();
            tabPageRoutes = new TabPage();
            dataGridViewRoutes_TDE = new DataGridView();
            ColumnNumber = new DataGridViewTextBoxColumn();
            ColumnStart = new DataGridViewTextBoxColumn();
            ColumnEnd = new DataGridViewTextBoxColumn();
            ColumnType = new DataGridViewTextBoxColumn();
            tabPageFeatures = new TabPage();
            dataGridViewFeatures_TDE = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            toolTip_TDE = new ToolTip(components);
            openFileDialog_TDE = new OpenFileDialog();
            saveFileDialog_TDE = new SaveFileDialog();
            buttonSetFeature_TDE = new Button();
            menuStrip_TDE.SuspendLayout();
            tableLayoutPanel_TDE.SuspendLayout();
            panelControl_TDE.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBoxFile_TDE.SuspendLayout();
            groupBoxSearch_TDE.SuspendLayout();
            tabControlRoutes_TDE.SuspendLayout();
            tabPageRoutes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes_TDE).BeginInit();
            tabPageFeatures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFeatures_TDE).BeginInit();
            SuspendLayout();
            // 
            // menuStrip_TDE
            // 
            menuStrip_TDE.ImageScalingSize = new Size(20, 20);
            menuStrip_TDE.Items.AddRange(new ToolStripItem[] { ToolStripMenuItemProgramm_TDE, ToolStripMenuItemFile_TDE });
            menuStrip_TDE.Location = new Point(0, 0);
            menuStrip_TDE.Name = "menuStrip_TDE";
            menuStrip_TDE.Padding = new Padding(7, 3, 0, 3);
            menuStrip_TDE.RenderMode = ToolStripRenderMode.System;
            menuStrip_TDE.Size = new Size(923, 30);
            menuStrip_TDE.TabIndex = 0;
            menuStrip_TDE.Text = "menuStrip1";
            // 
            // ToolStripMenuItemProgramm_TDE
            // 
            ToolStripMenuItemProgramm_TDE.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuAbout_TDE, toolStripSeparator1, ToolStripMenuExit_TDE });
            ToolStripMenuItemProgramm_TDE.Name = "ToolStripMenuItemProgramm_TDE";
            ToolStripMenuItemProgramm_TDE.Size = new Size(105, 24);
            ToolStripMenuItemProgramm_TDE.Text = "Программа";
            // 
            // ToolStripMenuAbout_TDE
            // 
            ToolStripMenuAbout_TDE.Name = "ToolStripMenuAbout_TDE";
            ToolStripMenuAbout_TDE.Size = new Size(187, 26);
            ToolStripMenuAbout_TDE.Text = "О программе";
            ToolStripMenuAbout_TDE.Click += ToolStripMenuAbout_TDE_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(184, 6);
            // 
            // ToolStripMenuExit_TDE
            // 
            ToolStripMenuExit_TDE.Name = "ToolStripMenuExit_TDE";
            ToolStripMenuExit_TDE.Size = new Size(187, 26);
            ToolStripMenuExit_TDE.Text = "Выход";
            ToolStripMenuExit_TDE.Click += ToolStripMenuExit_TDE_Click;
            // 
            // ToolStripMenuItemFile_TDE
            // 
            ToolStripMenuItemFile_TDE.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuOpenNewFileTool_TDE, ToolStripMenuSaveFile_TDE, ToolStripMenuRefresh_TDE, ToolStripMenuOpenFile_TDE });
            ToolStripMenuItemFile_TDE.Name = "ToolStripMenuItemFile_TDE";
            ToolStripMenuItemFile_TDE.Size = new Size(59, 24);
            ToolStripMenuItemFile_TDE.Text = "Файл";
            // 
            // ToolStripMenuOpenNewFileTool_TDE
            // 
            ToolStripMenuOpenNewFileTool_TDE.DropDownItems.AddRange(new ToolStripItem[] { ToolStripMenuOpenNewFile_TDE, ToolStripMenuImages_TDE });
            ToolStripMenuOpenNewFileTool_TDE.Name = "ToolStripMenuOpenNewFileTool_TDE";
            ToolStripMenuOpenNewFileTool_TDE.Size = new Size(247, 26);
            ToolStripMenuOpenNewFileTool_TDE.Text = "Открыть новый файл";
            ToolStripMenuOpenNewFileTool_TDE.Click += buttonOpenFile_TDE_Click;
            // 
            // ToolStripMenuOpenNewFile_TDE
            // 
            ToolStripMenuOpenNewFile_TDE.Name = "ToolStripMenuOpenNewFile_TDE";
            ToolStripMenuOpenNewFile_TDE.Size = new Size(327, 26);
            ToolStripMenuOpenNewFile_TDE.Text = "Открыть файл машрутов";
            ToolStripMenuOpenNewFile_TDE.Click += buttonOpenFile_TDE_Click;
            // 
            // ToolStripMenuImages_TDE
            // 
            ToolStripMenuImages_TDE.Name = "ToolStripMenuImages_TDE";
            ToolStripMenuImages_TDE.Size = new Size(327, 26);
            ToolStripMenuImages_TDE.Text = "Выбрать папку с изображениями";
            ToolStripMenuImages_TDE.Click += ToolStripMenuImages_TDE_Click;
            // 
            // ToolStripMenuSaveFile_TDE
            // 
            ToolStripMenuSaveFile_TDE.Enabled = false;
            ToolStripMenuSaveFile_TDE.Name = "ToolStripMenuSaveFile_TDE";
            ToolStripMenuSaveFile_TDE.Size = new Size(247, 26);
            ToolStripMenuSaveFile_TDE.Text = "Сохранить как";
            ToolStripMenuSaveFile_TDE.Click += buttonSaveFile_TDE_Click;
            // 
            // ToolStripMenuRefresh_TDE
            // 
            ToolStripMenuRefresh_TDE.Enabled = false;
            ToolStripMenuRefresh_TDE.Name = "ToolStripMenuRefresh_TDE";
            ToolStripMenuRefresh_TDE.Size = new Size(247, 26);
            ToolStripMenuRefresh_TDE.Text = "Обновить";
            ToolStripMenuRefresh_TDE.Click += buttonUpdateFile_TDE_Click;
            // 
            // ToolStripMenuOpenFile_TDE
            // 
            ToolStripMenuOpenFile_TDE.Enabled = false;
            ToolStripMenuOpenFile_TDE.Name = "ToolStripMenuOpenFile_TDE";
            ToolStripMenuOpenFile_TDE.Size = new Size(247, 26);
            ToolStripMenuOpenFile_TDE.Text = "Открыть данный файл";
            ToolStripMenuOpenFile_TDE.Click += ToolStripMenuOpenFile_TDE_Click;
            // 
            // tableLayoutPanel_TDE
            // 
            tableLayoutPanel_TDE.ColumnCount = 2;
            tableLayoutPanel_TDE.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel_TDE.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel_TDE.Controls.Add(panelControl_TDE, 0, 0);
            tableLayoutPanel_TDE.Controls.Add(tabControlRoutes_TDE, 1, 0);
            tableLayoutPanel_TDE.Dock = DockStyle.Fill;
            tableLayoutPanel_TDE.Location = new Point(0, 30);
            tableLayoutPanel_TDE.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel_TDE.Name = "tableLayoutPanel_TDE";
            tableLayoutPanel_TDE.Padding = new Padding(6, 7, 6, 7);
            tableLayoutPanel_TDE.RowCount = 1;
            tableLayoutPanel_TDE.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel_TDE.Size = new Size(923, 650);
            tableLayoutPanel_TDE.TabIndex = 1;
            // 
            // panelControl_TDE
            // 
            panelControl_TDE.Controls.Add(groupBox1);
            panelControl_TDE.Controls.Add(groupBoxFile_TDE);
            panelControl_TDE.Controls.Add(groupBoxSearch_TDE);
            panelControl_TDE.Dock = DockStyle.Fill;
            panelControl_TDE.Location = new Point(9, 11);
            panelControl_TDE.Margin = new Padding(3, 4, 3, 4);
            panelControl_TDE.Name = "panelControl_TDE";
            panelControl_TDE.Padding = new Padding(6, 0, 6, 7);
            panelControl_TDE.Size = new Size(267, 628);
            panelControl_TDE.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(buttonSetFeature_TDE);
            groupBox1.Controls.Add(buttonHelp_TDE);
            groupBox1.Location = new Point(6, 425);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(253, 116);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Руководство";
            // 
            // buttonHelp_TDE
            // 
            buttonHelp_TDE.BackgroundImageLayout = ImageLayout.Center;
            buttonHelp_TDE.Image = (System.Drawing.Image)resources.GetObject("buttonHelp_TDE.Image");
            buttonHelp_TDE.Location = new Point(43, 21);
            buttonHelp_TDE.Margin = new Padding(3, 4, 3, 4);
            buttonHelp_TDE.Name = "buttonHelp_TDE";
            buttonHelp_TDE.Size = new Size(74, 87);
            buttonHelp_TDE.TabIndex = 3;
            toolTip_TDE.SetToolTip(buttonHelp_TDE, "Как создать свой файл маршрутов");
            buttonHelp_TDE.UseVisualStyleBackColor = true;
            buttonHelp_TDE.Click += buttonHelp_TDE_Click;
            buttonHelp_TDE.MouseEnter += buttonHelp_TDE_MouseEnter;
            // 
            // groupBoxFile_TDE
            // 
            groupBoxFile_TDE.Controls.Add(buttonUpdateFile_TDE);
            groupBoxFile_TDE.Controls.Add(buttonSaveFile_TDE);
            groupBoxFile_TDE.Controls.Add(buttonOpenFile_TDE);
            groupBoxFile_TDE.Dock = DockStyle.Top;
            groupBoxFile_TDE.Location = new Point(6, 71);
            groupBoxFile_TDE.Margin = new Padding(3, 4, 3, 4);
            groupBoxFile_TDE.Name = "groupBoxFile_TDE";
            groupBoxFile_TDE.Padding = new Padding(3, 4, 3, 4);
            groupBoxFile_TDE.Size = new Size(255, 116);
            groupBoxFile_TDE.TabIndex = 1;
            groupBoxFile_TDE.TabStop = false;
            groupBoxFile_TDE.Text = "Файл";
            // 
            // buttonUpdateFile_TDE
            // 
            buttonUpdateFile_TDE.BackgroundImageLayout = ImageLayout.Center;
            buttonUpdateFile_TDE.Enabled = false;
            buttonUpdateFile_TDE.Image = (System.Drawing.Image)resources.GetObject("buttonUpdateFile_TDE.Image");
            buttonUpdateFile_TDE.Location = new Point(169, 21);
            buttonUpdateFile_TDE.Margin = new Padding(3, 4, 3, 4);
            buttonUpdateFile_TDE.Name = "buttonUpdateFile_TDE";
            buttonUpdateFile_TDE.Size = new Size(74, 87);
            buttonUpdateFile_TDE.TabIndex = 2;
            toolTip_TDE.SetToolTip(buttonUpdateFile_TDE, "Обновить содержимое файла");
            buttonUpdateFile_TDE.UseVisualStyleBackColor = true;
            buttonUpdateFile_TDE.Click += buttonUpdateFile_TDE_Click;
            buttonUpdateFile_TDE.MouseEnter += buttonUpdateFile_TDE_MouseEnter;
            // 
            // buttonSaveFile_TDE
            // 
            buttonSaveFile_TDE.BackgroundImageLayout = ImageLayout.Center;
            buttonSaveFile_TDE.Enabled = false;
            buttonSaveFile_TDE.Image = (System.Drawing.Image)resources.GetObject("buttonSaveFile_TDE.Image");
            buttonSaveFile_TDE.Location = new Point(88, 21);
            buttonSaveFile_TDE.Margin = new Padding(3, 4, 3, 4);
            buttonSaveFile_TDE.Name = "buttonSaveFile_TDE";
            buttonSaveFile_TDE.Size = new Size(74, 87);
            buttonSaveFile_TDE.TabIndex = 1;
            toolTip_TDE.SetToolTip(buttonSaveFile_TDE, "Сохранить файл");
            buttonSaveFile_TDE.UseVisualStyleBackColor = true;
            buttonSaveFile_TDE.Click += buttonSaveFile_TDE_Click;
            buttonSaveFile_TDE.MouseEnter += buttonSaveFile_TDE_MouseEnter;
            // 
            // buttonOpenFile_TDE
            // 
            buttonOpenFile_TDE.BackgroundImageLayout = ImageLayout.Center;
            buttonOpenFile_TDE.Image = (System.Drawing.Image)resources.GetObject("buttonOpenFile_TDE.Image");
            buttonOpenFile_TDE.Location = new Point(7, 21);
            buttonOpenFile_TDE.Margin = new Padding(3, 4, 3, 4);
            buttonOpenFile_TDE.Name = "buttonOpenFile_TDE";
            buttonOpenFile_TDE.Size = new Size(74, 87);
            buttonOpenFile_TDE.TabIndex = 0;
            toolTip_TDE.SetToolTip(buttonOpenFile_TDE, "Открыть файл маршрутов (.csv)");
            buttonOpenFile_TDE.UseVisualStyleBackColor = true;
            buttonOpenFile_TDE.Click += buttonOpenFile_TDE_Click;
            buttonOpenFile_TDE.MouseEnter += buttonOpenFile_TDE_MouseEnter;
            // 
            // groupBoxSearch_TDE
            // 
            groupBoxSearch_TDE.Controls.Add(buttonSearch_TDE);
            groupBoxSearch_TDE.Controls.Add(textBoxSearch_TDE);
            groupBoxSearch_TDE.Dock = DockStyle.Top;
            groupBoxSearch_TDE.Location = new Point(6, 0);
            groupBoxSearch_TDE.Margin = new Padding(3, 4, 3, 4);
            groupBoxSearch_TDE.Name = "groupBoxSearch_TDE";
            groupBoxSearch_TDE.Padding = new Padding(3, 4, 3, 4);
            groupBoxSearch_TDE.Size = new Size(255, 71);
            groupBoxSearch_TDE.TabIndex = 0;
            groupBoxSearch_TDE.TabStop = false;
            groupBoxSearch_TDE.Text = "Поиск";
            // 
            // buttonSearch_TDE
            // 
            buttonSearch_TDE.Image = (System.Drawing.Image)resources.GetObject("buttonSearch_TDE.Image");
            buttonSearch_TDE.Location = new Point(191, 15);
            buttonSearch_TDE.Margin = new Padding(3, 4, 3, 4);
            buttonSearch_TDE.Name = "buttonSearch_TDE";
            buttonSearch_TDE.Size = new Size(55, 51);
            buttonSearch_TDE.TabIndex = 4;
            toolTip_TDE.SetToolTip(buttonSearch_TDE, "Выполнить поиск");
            buttonSearch_TDE.UseVisualStyleBackColor = true;
            buttonSearch_TDE.Click += buttonSearch_TDE_Click;
            // 
            // textBoxSearch_TDE
            // 
            textBoxSearch_TDE.Location = new Point(7, 32);
            textBoxSearch_TDE.Margin = new Padding(3, 4, 3, 4);
            textBoxSearch_TDE.Name = "textBoxSearch_TDE";
            textBoxSearch_TDE.Size = new Size(178, 27);
            textBoxSearch_TDE.TabIndex = 3;
            toolTip_TDE.SetToolTip(textBoxSearch_TDE, "Введите номер маршрута");
            textBoxSearch_TDE.MouseEnter += textBoxSearch_TDE_MouseEnter;
            // 
            // tabControlRoutes_TDE
            // 
            tabControlRoutes_TDE.Controls.Add(tabPageRoutes);
            tabControlRoutes_TDE.Controls.Add(tabPageFeatures);
            tabControlRoutes_TDE.Dock = DockStyle.Fill;
            tabControlRoutes_TDE.Location = new Point(282, 11);
            tabControlRoutes_TDE.Margin = new Padding(3, 4, 3, 4);
            tabControlRoutes_TDE.Name = "tabControlRoutes_TDE";
            tabControlRoutes_TDE.SelectedIndex = 0;
            tabControlRoutes_TDE.Size = new Size(632, 628);
            tabControlRoutes_TDE.TabIndex = 2;
            tabControlRoutes_TDE.Selected += tabControlRoutes_TDE_Selected;
            // 
            // tabPageRoutes
            // 
            tabPageRoutes.Controls.Add(dataGridViewRoutes_TDE);
            tabPageRoutes.Location = new Point(4, 29);
            tabPageRoutes.Margin = new Padding(3, 4, 3, 4);
            tabPageRoutes.Name = "tabPageRoutes";
            tabPageRoutes.Padding = new Padding(3, 4, 3, 4);
            tabPageRoutes.Size = new Size(624, 595);
            tabPageRoutes.TabIndex = 0;
            tabPageRoutes.Text = "Список маршрутов";
            tabPageRoutes.UseVisualStyleBackColor = true;
            // 
            // dataGridViewRoutes_TDE
            // 
            dataGridViewRoutes_TDE.AllowUserToAddRows = false;
            dataGridViewRoutes_TDE.AllowUserToDeleteRows = false;
            dataGridViewRoutes_TDE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRoutes_TDE.Columns.AddRange(new DataGridViewColumn[] { ColumnNumber, ColumnStart, ColumnEnd, ColumnType });
            dataGridViewRoutes_TDE.Dock = DockStyle.Fill;
            dataGridViewRoutes_TDE.Location = new Point(3, 4);
            dataGridViewRoutes_TDE.Margin = new Padding(3, 4, 3, 4);
            dataGridViewRoutes_TDE.Name = "dataGridViewRoutes_TDE";
            dataGridViewRoutes_TDE.ReadOnly = true;
            dataGridViewRoutes_TDE.RowHeadersVisible = false;
            dataGridViewRoutes_TDE.RowHeadersWidth = 51;
            dataGridViewRoutes_TDE.Size = new Size(618, 587);
            dataGridViewRoutes_TDE.TabIndex = 0;
            dataGridViewRoutes_TDE.CellContentClick += dataGridViewRoutes_TDE_CellClick;
            // 
            // ColumnNumber
            // 
            ColumnNumber.HeaderText = "№";
            ColumnNumber.MinimumWidth = 6;
            ColumnNumber.Name = "ColumnNumber";
            ColumnNumber.ReadOnly = true;
            ColumnNumber.ToolTipText = "Номер маршрута";
            ColumnNumber.Width = 30;
            // 
            // ColumnStart
            // 
            ColumnStart.HeaderText = "Начальная остановка";
            ColumnStart.MinimumWidth = 6;
            ColumnStart.Name = "ColumnStart";
            ColumnStart.ReadOnly = true;
            ColumnStart.ToolTipText = "Первая остановка";
            ColumnStart.Width = 200;
            // 
            // ColumnEnd
            // 
            ColumnEnd.HeaderText = "Конечная остановка";
            ColumnEnd.MinimumWidth = 6;
            ColumnEnd.Name = "ColumnEnd";
            ColumnEnd.ReadOnly = true;
            ColumnEnd.ToolTipText = "Последняя остановка";
            ColumnEnd.Width = 200;
            // 
            // ColumnType
            // 
            ColumnType.HeaderText = "Тип";
            ColumnType.MinimumWidth = 6;
            ColumnType.Name = "ColumnType";
            ColumnType.ReadOnly = true;
            ColumnType.ToolTipText = "Вид транспорта";
            ColumnType.Width = 125;
            // 
            // tabPageFeatures
            // 
            tabPageFeatures.Controls.Add(dataGridViewFeatures_TDE);
            tabPageFeatures.Location = new Point(4, 29);
            tabPageFeatures.Margin = new Padding(3, 4, 3, 4);
            tabPageFeatures.Name = "tabPageFeatures";
            tabPageFeatures.Padding = new Padding(3, 4, 3, 4);
            tabPageFeatures.Size = new Size(624, 595);
            tabPageFeatures.TabIndex = 1;
            tabPageFeatures.Text = "Избранные";
            tabPageFeatures.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFeatures_TDE
            // 
            dataGridViewFeatures_TDE.AllowUserToAddRows = false;
            dataGridViewFeatures_TDE.AllowUserToDeleteRows = false;
            dataGridViewFeatures_TDE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFeatures_TDE.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dataGridViewFeatures_TDE.Dock = DockStyle.Fill;
            dataGridViewFeatures_TDE.Location = new Point(3, 4);
            dataGridViewFeatures_TDE.Margin = new Padding(3, 4, 3, 4);
            dataGridViewFeatures_TDE.MinimumSize = new Size(609, 501);
            dataGridViewFeatures_TDE.Name = "dataGridViewFeatures_TDE";
            dataGridViewFeatures_TDE.ReadOnly = true;
            dataGridViewFeatures_TDE.RowHeadersVisible = false;
            dataGridViewFeatures_TDE.RowHeadersWidth = 51;
            dataGridViewFeatures_TDE.Size = new Size(618, 587);
            dataGridViewFeatures_TDE.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "№";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.ToolTipText = "Номер маршрута";
            dataGridViewTextBoxColumn1.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Начальная остановка";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.ToolTipText = "Первая остановка";
            dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Конечная остановка";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            dataGridViewTextBoxColumn3.ToolTipText = "Последняя остановка";
            dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Тип";
            dataGridViewTextBoxColumn4.MinimumWidth = 6;
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            dataGridViewTextBoxColumn4.ToolTipText = "Вид транспорта";
            dataGridViewTextBoxColumn4.Width = 125;
            // 
            // toolTip_TDE
            // 
            toolTip_TDE.IsBalloon = true;
            toolTip_TDE.ToolTipIcon = ToolTipIcon.Info;
            toolTip_TDE.Popup += toolTip_TDE_Popup;
            // 
            // openFileDialog_TDE
            // 
            openFileDialog_TDE.FileName = "Routes.csv";
            // 
            // saveFileDialog_TDE
            // 
            saveFileDialog_TDE.FileName = "file.csv";
            // 
            // buttonSetFeature_TDE
            // 
            buttonSetFeature_TDE.Image = (System.Drawing.Image)resources.GetObject("buttonSetFeature_TDE.Image");
            buttonSetFeature_TDE.Location = new Point(152, 21);
            buttonSetFeature_TDE.Name = "buttonSetFeature_TDE";
            buttonSetFeature_TDE.Size = new Size(75, 87);
            buttonSetFeature_TDE.TabIndex = 5;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(923, 680);
            Controls.Add(tableLayoutPanel_TDE);
            Controls.Add(menuStrip_TDE);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip_TDE;
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(934, 640);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Транспортные маршруты";
            Load += FormMain_Load;
            menuStrip_TDE.ResumeLayout(false);
            menuStrip_TDE.PerformLayout();
            tableLayoutPanel_TDE.ResumeLayout(false);
            panelControl_TDE.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBoxFile_TDE.ResumeLayout(false);
            groupBoxSearch_TDE.ResumeLayout(false);
            groupBoxSearch_TDE.PerformLayout();
            tabControlRoutes_TDE.ResumeLayout(false);
            tabPageRoutes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRoutes_TDE).EndInit();
            tabPageFeatures.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewFeatures_TDE).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void dataGridViewRoutes_TDE_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private MenuStrip menuStrip_TDE;
    private ToolStripMenuItem ToolStripMenuItemProgramm_TDE;
    private ToolStripMenuItem ToolStripMenuAbout_TDE;
    private ToolStripMenuItem ToolStripMenuItemFile_TDE;
    private TableLayoutPanel tableLayoutPanel_TDE;
    private Panel panelControl_TDE;
    private TabControl tabControlRoutes_TDE;
    private TabPage tabPageRoutes;
    private TabPage tabPageFeatures;
    private DataGridView dataGridViewRoutes_TDE;
    private GroupBox groupBoxSearch_TDE;
    private Button buttonSearch_TDE;
    private TextBox textBoxSearch_TDE;
    private ToolTip toolTip_TDE;
    private DataGridViewTextBoxColumn ColumnNumber;
    private DataGridViewTextBoxColumn ColumnStart;
    private DataGridViewTextBoxColumn ColumnEnd;
    private DataGridViewTextBoxColumn ColumnType;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem ToolStripMenuExit_TDE;
    private GroupBox groupBoxFile_TDE;
    private Button buttonUpdateFile_TDE;
    private Button buttonSaveFile_TDE;
    private Button buttonOpenFile_TDE;
    private GroupBox groupBox1;
    private Button buttonHelp_TDE;
    private ToolStripMenuItem ToolStripMenuOpenNewFileTool_TDE;
    private ToolStripMenuItem ToolStripMenuSaveFile_TDE;
    private ToolStripMenuItem ToolStripMenuRefresh_TDE;
    private ToolStripMenuItem ToolStripMenuOpenFile_TDE;
    private OpenFileDialog openFileDialog_TDE;
    private DataGridView dataGridViewFeatures_TDE;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    private SaveFileDialog saveFileDialog_TDE;
    private ToolStripMenuItem ToolStripMenuOpenNewFile_TDE;
    private ToolStripMenuItem ToolStripMenuImages_TDE;
        private Button buttonSetFeature_TDE;
    }
}
