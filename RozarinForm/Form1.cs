using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RozarinForm
{
    public partial class Form1 : Form
    {
        private Dictionary<string, MethodCallingTree> _tree = new Dictionary<string, MethodCallingTree>();

        public Form1()
        {
            InitializeComponent();
            //dataGridView1.AutoGenerateColumns = false;
        }

        private void fileSelectButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog(this) == DialogResult.OK)
                {
                    kaisekiResultFilePathTextbox.Text = dialog.FileName;
                }
            }
        }

        private async void kaisekiButton_Click(object sender, EventArgs e)
        {
            try
            {
                SetEnabled(false);
                _tree = new Dictionary<string, MethodCallingTree>();

                string filePath = kaisekiResultFilePathTextbox.Text;

                if (string.IsNullOrEmpty(filePath))
                {
                    ShowWarningMessage("解析結果ファイルが指定されていません。");
                    return;
                }

                if (!File.Exists(filePath))
                {
                    ShowWarningMessage("指定された解析結果ファイルが見つかりませんでした。");
                    return;
                }

                Dictionary<string, MethodCallingInfo> dic = new Dictionary<string, MethodCallingInfo>();

                string line;
                using (TextReader reader = new StreamReader(filePath))
                {
                    while (!string.IsNullOrEmpty(line = await reader.ReadLineAsync()))
                    {
                        string[] ar = line.Split('\t');
                        if (ar.Length != 4)
                        {
                            ShowWarningMessage("解析結果ファイルの構成に誤りがあります。読み込めません。");
                            return;
                        }

                        string sourceFilePath = ar[0];
                        string sourceMethodName = ar[1];
                        string callingMethodName = ar[2];
                        int lines = int.Parse(ar[3]);

                        if (dic.ContainsKey($"[{sourceMethodName}]"))
                        {
                            if (!string.IsNullOrEmpty(callingMethodName))
                            {
                                MethodCallingInfo info = dic[$"[{sourceMethodName}]"];
                                info.CallingMethodName.Add(callingMethodName);
                            }
                        }
                        else
                        {
                            MethodCallingInfo info = new MethodCallingInfo();
                            info.FilePath = sourceFilePath;
                            info.MethodName = sourceMethodName;
                            info.Lines = lines;

                            if (!string.IsNullOrEmpty(callingMethodName))
                            {
                                info.CallingMethodName.Add(callingMethodName);
                            }

                            dic.Add($"[{sourceMethodName}]", info);

                            MethodCallingTree newTree = new MethodCallingTree
                            {
                                MethodName = sourceMethodName,
                                Lines = lines
                            };

                            _tree.Add($"[{sourceMethodName}]", newTree);
                        }
                    }
                }

                foreach (string key in dic.Keys)
                {
                    MethodCallingTree tree = _tree[key];

                    foreach (string calling in dic[key].CallingMethodName)
                    {
                        if (!string.IsNullOrWhiteSpace(calling))
                        {
                            if (_tree.ContainsKey($"[{calling}]"))
                            {
                                tree.CallingMethodList.Add(_tree[$"[{calling}]"]);
                            }
                        }
                    }
                }

                List<MethodCallingTree> list = _tree.Values.ToList();
                doubleBufferedDataGridView1.DataSource = list;

                ShowInformationMessage("解析結果ファイルの読み込みが完了しました。");
            }
            finally
            {
                SetEnabled(true);
            }
        }

        private void SetEnabled(bool enabled)
        {
            if (!enabled)
            {
                this.SuspendLayout();
            }

            kaisekiResultFilePathTextbox.Enabled = enabled;
            doubleBufferedDataGridView1.Enabled = enabled;
            fileSelectButton.Enabled = enabled;
            kaisekiButton.Enabled = enabled;
            treeOutputButton.Enabled = enabled;

            if (enabled)
            {
                this.ResumeLayout();
            }
        }

        private void ShowInformationMessage(string message, string title = "Information")
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ShowWarningMessage(string message, string title = "Warning")
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ShowExceptionMessage(string message, string title = "Exception")
        {
            MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void doubleBufferedDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //MethodCallingTree selectedTree = doubleBufferedDataGridView1.SelectedRows[0].DataBoundItem as MethodCallingTree;
        }

        private void treeOutputButton_Click(object sender, EventArgs e)
        {
            if (doubleBufferedDataGridView1.SelectedRows[0].DataBoundItem is MethodCallingTree selectedTree)
            {
                List<string> analyzeResult = CreateTreeList(selectedTree, new List<string>(), 1);
                foreach (string s in analyzeResult)
                {
                    System.Diagnostics.Debug.WriteLine(s);
                }

                using (SaveFileDialog dialog = new SaveFileDialog())
                {
                    dialog.Filter = "CSVファイル(*.csv)|*.csv";
                    if (dialog.ShowDialog(this) == DialogResult.OK)
                    {
                        using (TextWriter writer = new StreamWriter(dialog.FileName))
                        {
                            writer.Write(string.Join(Environment.NewLine, analyzeResult));
                        }

                        ShowInformationMessage("出力が完了しました。");
                        return;
                    }
                }
            }
            else
            {
                ShowWarningMessage("出力に失敗しました。");
            }
        }

        private List<string> CreateTreeList(MethodCallingTree tree, List<string> route, int level)
        {
            List<string> result = new List<string>();
            result.Add($"\"{tree.MethodName}\",{tree.Lines},{level}");
            route.Add(tree.MethodName);

            foreach (MethodCallingTree t in tree.CallingMethodList)
            {
                if (route.Contains(t.MethodName))
                {
                    continue;
                }

                List<string> tmp = new List<string>(route.ToArray());
                result.AddRange(CreateTreeList(t, tmp, level + 1));
            }

            return result;
        }
    }
}
