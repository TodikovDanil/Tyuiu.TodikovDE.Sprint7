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

            saveFileDialog_TDE.Filter = "��������, ���������� ��������(*.csv)|*.csv|��� �����(*.*)|*.*";
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
            openFileDialog_TDE.Filter = "��������, ���������� ��������(*.csv)|*.csv|��� �����(*.*)|*.*";
            openFileDialog_TDE.ShowDialog();
            if (File.Exists(openFileDialog_TDE.FileName))
            {
                openFilePath = openFileDialog_TDE.FileName;
                items = dataService.ParseRouteItems(openFilePath);

                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].Length < 4 || !int.TryParse(items[i][0], out _))
                    {
                        MessageBox.Show("�������� ������ � �����", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                SetItemsToGrid(items);

                

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
                MessageBox.Show("������� �������� ������", "������", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void ToolStripMenuOpenFile_TDE_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = openFilePath;
            txt.Start();
        }

        private void ButtonOpenRoute_TDE_Click(object sender, EventArgs e)
        {

            FormRoute formRoute = new FormRoute(items[rowFocusIndex]);
            formRoute.Text = "������� " + GetCurrentDataGridView().CurrentRow.Cells[0].Value;
            formRoute.ShowDialog();
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


        private void buttonHelp_TDE_Click(object sender, EventArgs e)
        {
            FormGuide formGuide = new FormGuide();
            formGuide.ShowDialog();
        }

        #region MouseEnterTips
        private void buttonOpenFile_TDE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TDE.ToolTipTitle = "��������";
        }

        private void buttonSaveFile_TDE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TDE.ToolTipTitle = "�������";
        }

        private void buttonUpdateFile_TDE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TDE.ToolTipTitle = "��������";
        }

        private void buttonHelp_TDE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TDE.ToolTipTitle = "�����������";
        }

        private void textBoxSearch_TDE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TDE.ToolTipTitle = "�����";
        }

        private void buttonOpenRoute_TDE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TDE.ToolTipTitle = "�������";
        }

        private void buttonSetFeature_TDE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TDE.ToolTipTitle = "���������";
        }
        private void buttonHelpImages_TDE_MouseEnter(object sender, EventArgs e)
        {
            toolTip_TDE.ToolTipTitle = "�����������";
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

        private void groupBoxEdit_TDE_Enter_1(object sender, EventArgs e)
        {

        }
    }
}

