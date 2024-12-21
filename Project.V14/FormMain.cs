using System.IO;
using System.Windows.Forms;
using Tyuiu.TodikovDE.Sprint7.Tsak0.V14.Lib;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
namespace Project.V14
{
    public partial class FormMain : Form
    {
        public string? openFilePath;

        public List<string[]>? items;

        int rows;
        const int COLUMNS = 6;

        int rowFocusIndex;

        DataService dataService = new DataService();
        public FormMain()
        {
            InitializeComponent();

            saveFileDialog_TDE.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.BeginInvoke(new Action(() =>
            {
                buttonOpenFile_TDE.Focus();
            }));

            dataGridViewRoutes_TDE.RowCount = 14;
            dataGridViewFeatures_TDE.RowCount = 14;
        }

        private void ToolStripMenuAbout_TDE_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void ToolStripMenuExit_TDE_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void buttonOpenFile_TDE_Click(object sender, EventArgs e)
        {
            openFileDialog_TDE.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            openFileDialog_TDE.ShowDialog();
            if (File.Exists(openFileDialog_TDE.FileName))
            {
                openFilePath = openFileDialog_TDE.FileName;
                items = dataService.ParseRouteItems(openFilePath);

                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].Length < 4 || !int.TryParse(items[i][0], out _))
                    {
                        MessageBox.Show("Неверные данные в файле", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                SetItemsToGrid(items);

                for (int i = 0; i < rows; i++)
                {
                    if (items[i].Count() == 5)
                    {
                        try
                        {
                            if (Convert.ToBoolean(items[i][4])) AddRowToFeature(i);
                        }
                        catch
                        {
                            MessageBox.Show("Неверные данные в файле (опция \"Избранное\n не является bool значением)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

                buttonSaveFile_TDE.Enabled = true;
                buttonUpdateFile_TDE.Enabled = true;

                ToolStripMenuOpenNewFileTool_TDE.Enabled = true;
                ToolStripMenuOpenFile_TDE.Enabled = true;
                ToolStripMenuRefresh_TDE.Enabled = true;
                ToolStripMenuSaveFile_TDE.Enabled = true;
            }

        }

        private void SetItemsToGrid(List<string[]> items)
        {
            rows = items.Count;

            dataGridViewRoutes_TDE.RowCount = rows;
            dataGridViewRoutes_TDE.ColumnCount = COLUMNS - 2;

            dataGridViewFeatures_TDE.RowCount = 0;

            for (int i = 0; i < rows; i++)
            {
                string[] routes = items[i][1].Split('|');
                dataGridViewRoutes_TDE.Rows[i].Cells[0].Value = items[i][0];
                dataGridViewRoutes_TDE.Rows[i].Cells[1].Value = routes[0];
                dataGridViewRoutes_TDE.Rows[i].Cells[2].Value = routes[^1];
                dataGridViewRoutes_TDE.Rows[i].Cells[3].Value = items[i][2];
            }
        }

        private void buttonSaveFile_TDE_Click(object sender, EventArgs e)
        {
            saveFileDialog_TDE.FileName = "file.csv";
            saveFileDialog_TDE.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog_TDE.ShowDialog();

            string path = saveFileDialog_TDE.FileName;

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < COLUMNS; j++)
                {
                    if (j != COLUMNS - 1)
                    {
                        str += dataGridViewRoutes_TDE.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewRoutes_TDE.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }

        private void buttonUpdateFile_TDE_Click(object sender, EventArgs e)
        {
            items = dataService.ParseRouteItems(openFilePath);
            SetItemsToGrid(items);
        }

      
        private void AddRowToFeature(int index)
        {
            int indexRow = dataGridViewFeatures_TDE.RowCount;
            dataGridViewFeatures_TDE.RowCount += 1;
            dataGridViewFeatures_TDE.Rows[indexRow].Cells[0].Value = dataGridViewRoutes_TDE.Rows[index].Cells[0].Value;
            dataGridViewFeatures_TDE.Rows[indexRow].Cells[1].Value = dataGridViewRoutes_TDE.Rows[index].Cells[1].Value;
            dataGridViewFeatures_TDE.Rows[indexRow].Cells[2].Value = dataGridViewRoutes_TDE.Rows[index].Cells[2].Value;
            dataGridViewFeatures_TDE.Rows[indexRow].Cells[3].Value = dataGridViewRoutes_TDE.Rows[index].Cells[3].Value;
        }

     

        private void tabControlRoutes_TDE_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControlRoutes_TDE.SelectedIndex == 0)
            {
                dataGridViewRoutes_TDE.Sort(dataGridViewRoutes_TDE.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            }
            else dataGridViewFeatures_TDE.Sort(dataGridViewFeatures_TDE.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
        }
        private void buttonSearch_TDE_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxSearch_TDE.Text, out int number))
            {
                DataGridView dataGrid = tabControlRoutes_TDE.SelectedIndex == 0 ? dataGridViewRoutes_TDE : dataGridViewFeatures_TDE;
                foreach (DataGridViewRow row in dataGrid.Rows)
                {
                    if (Convert.ToInt32(row.Cells[0].Value) != number)
                    {
                        dataGrid.Rows.Remove(row);
                    }
                }
            }
            else
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ToolStripMenuOpenFile_TDE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = openFilePath;
            txt.Start();
        }

       

        private DataGridView GetCurrentDataGridView()
        {
            if (tabControlRoutes_TDE.SelectedIndex == 0) return dataGridViewRoutes_TDE;
            else return dataGridViewFeatures_TDE;
        }
        private void ToolStripMenuImages_TDE_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (Directory.Exists(dialog.SelectedPath))
                {
                    DataService.imagesFolder = dialog.SelectedPath;
                }
            }
        }
        

        #region MouseEnterTips
        private void buttonOpenFile_TDE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TDE.ToolTipTitle = "Открытие";
        }

        private void buttonSaveFile_TDE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TDE.ToolTipTitle = "Экспорт";
        }

        private void buttonUpdateFile_TDE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TDE.ToolTipTitle = "Обновить";
        }

        private void buttonHelp_TDE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TDE.ToolTipTitle = "Руководство";
        }

        private void textBoxSearch_TDE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TDE.ToolTipTitle = "Поиск";
        }

        private void buttonOpenRoute_TDE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TDE.ToolTipTitle = "Открыть";
        }

        private void buttonSetFeature_TDE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TDE.ToolTipTitle = "Избранное";
        }
        private void buttonHelpImages_TDE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TDE.ToolTipTitle = "Руководство";
        }
        #endregion

        private void toolTip_TDE_Popup(object sender, PopupEventArgs e)
        {

        }

        private void groupBoxSearch_TDE_Enter(object sender, EventArgs e)
        {

        }

        private void groupBoxEdit_TDE_Enter(object sender, EventArgs e)
        {

        }

        private void tabPageRoutes_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel_TDE_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

