using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SourceCompare
{
    public partial class Form1 : Form
    {

        Settings settings;
        List<Result> results;

        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            results = new List<Result>();
            settings = Settings.Get();
            txtFolder1.Text = settings.Folder1;
            txtFolder2.Text = settings.Folder2;
            cmbComparison.SelectedIndex = settings.FileComparison;
            cmbShowSame.SelectedIndex = settings.ShowSame;
            cmbShowOnly1.SelectedIndex = settings.ShowOnly1;
            cmbShowOnly2.SelectedIndex = settings.ShowOnly2;
            cmbShowDifferent.SelectedIndex = settings.ShowDifferent;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.Folder1 = txtFolder1.Text;
            settings.Folder2 = txtFolder2.Text;
            settings.FileComparison = cmbComparison.SelectedIndex;
            settings.ShowSame = cmbShowSame.SelectedIndex;
            settings.ShowOnly1 = cmbShowOnly1.SelectedIndex;
            settings.ShowOnly2 = cmbShowOnly2.SelectedIndex;
            settings.ShowDifferent = cmbShowDifferent.SelectedIndex;
            settings.Save();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void setFolder1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.SelectedPath = txtFolder1.Text;
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtFolder1.Text = f.SelectedPath;
            }
        }

        private void setFolder2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog f = new FolderBrowserDialog();
            f.SelectedPath = txtFolder2.Text;
            if (f.ShowDialog() == DialogResult.OK)
            {
                txtFolder2.Text = f.SelectedPath;
            }
        }

        private void cmbShowSame_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            UpdateResultsGrid();
        }

        private void cmbShowOnly1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResultsGrid();
        }

        private void cmbShowOnly2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResultsGrid();
        }

        private void cmbShowDifferent_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateResultsGrid();
        }

        private void compareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            results.Clear();
            progressBar.Value = 0;
            progressBar.Maximum = CountFiles(txtFolder1.Text);
            CompareFolders(txtFolder1.Text, txtFolder2.Text);
            UpdateResultsGrid();
            progressBar.Value = progressBar.Maximum;
            Cursor = Cursors.Arrow;
        }

        private int CountFiles(string folder)
        {
            int ret = 0;

            DirectoryInfo dir = new DirectoryInfo(folder);
            foreach (DirectoryInfo sub in dir.GetDirectories())
            {
                ret += CountFiles(sub.FullName);
            }
            ret += dir.GetFiles().Count();

            return ret;
        }

        private void CompareFolders(string folder1, string folder2, string folder = "")
        {
            string thisFolder1 = folder.Length > 0 ? Path.Combine(folder1, folder) : folder1;
            string thisFolder2 = folder.Length > 0 ? Path.Combine(folder2, folder) : folder2;
            DirectoryInfo dir1 = new DirectoryInfo(thisFolder1);
            DirectoryInfo dir2 = new DirectoryInfo(thisFolder2);

            DirectoryInfo[] subs1 = dir1.GetDirectories().OrderBy(d => d.Name).ToArray();
            DirectoryInfo[] subs2 = dir2.GetDirectories().OrderBy(d => d.Name).ToArray();
            foreach (DirectoryInfo sub1 in subs1)
            {
                string thisFolder = folder.Length > 0 ? Path.Combine(folder, sub1.Name) : sub1.Name;

                DirectoryInfo sub2 = subs2.FirstOrDefault(d => d.Name.Equals(sub1.Name, StringComparison.CurrentCultureIgnoreCase));
                if (sub2 != null)
                {
                    CompareFolders(folder1, folder2, thisFolder);
                }
                else
                {
                    results.Add(new Result
                    {
                        Folder1 = folder1,
                        Folder2 = folder2,
                        Path = thisFolder,
                        Modified1 = sub1.LastWriteTime,
                        Modified2 = null,
                        ComparisonResult = Result.Results.Only1
                    });
                }
                Application.DoEvents();
            }
            foreach (DirectoryInfo sub2 in subs2)
            {
                string thisFolder = folder.Length > 0 ? Path.Combine(folder, sub2.Name) : sub2.Name;

                DirectoryInfo sub1 = subs1.FirstOrDefault(d => d.Name.Equals(sub2.Name, StringComparison.CurrentCultureIgnoreCase));
                if (sub1 == null)
                {
                    results.Add(new Result
                    {
                        Folder1 = folder1,
                        Folder2 = folder2,
                        Path = thisFolder,
                        Modified1 = null,
                        Modified2 = sub2.LastWriteTime,
                        ComparisonResult = Result.Results.Only2
                    });
                }
                Application.DoEvents();
            }

            FileInfo[] files1 = dir1.GetFiles().OrderBy(d => d.Name).ToArray();
            FileInfo[] files2 = dir2.GetFiles().OrderBy(d => d.Name).ToArray();
            foreach (FileInfo file1 in files1)
            {
                string thisFile = folder.Length > 0 ? Path.Combine(folder, file1.Name) : file1.Name;

                FileInfo file2 = files2.FirstOrDefault(d => d.Name.Equals(file1.Name, StringComparison.CurrentCultureIgnoreCase));
                if (file2 != null)
                {
                    results.Add(new Result
                    {
                        Folder1 = folder1,
                        Folder2 = folder2,
                        Path = thisFile,
                        Modified1 = file1.LastWriteTime,
                        Modified2 = file2.LastWriteTime,
                        ComparisonResult = CompareFiles(file1, file2)
                    });
                }
                else
                {
                    results.Add(new Result
                    {
                        Folder1 = folder1,
                        Folder2 = folder2,
                        Path = thisFile,
                        Modified1 = file1.LastWriteTime,
                        Modified2 = null,
                        ComparisonResult = Result.Results.Only1
                    });
                }
                progressBar.Value++;
                Application.DoEvents();
            }
            foreach (FileInfo file2 in files2)
            {
                string thisFile = folder.Length > 0 ? Path.Combine(folder, file2.Name) : file2.Name;

                FileInfo file1 = files1.FirstOrDefault(d => d.Name.Equals(file2.Name, StringComparison.CurrentCultureIgnoreCase));
                if (file1 == null)
                {
                    results.Add(new Result
                    {
                        Folder1 = folder1,
                        Folder2 = folder2,
                        Path = thisFile,
                        Modified1 = null,
                        Modified2 = file2.LastWriteTime,
                        ComparisonResult = Result.Results.Only2
                    });
                }
                Application.DoEvents();
            }
        }

        private Result.Results CompareFiles(FileInfo file1, FileInfo file2)
        {
            if (cmbComparison.SelectedIndex == 0)
            {
                byte[] contents1 = File.ReadAllBytes(file1.FullName);
                byte[] contents2 = File.ReadAllBytes(file2.FullName);
                if (contents1.Length != contents2.Length)
                {
                    return Result.Results.Different;
                }
                for (long c = 0; c < contents1.Length; c++)
                {
                    if (contents1[c] != contents2[c])
                    {
                        return Result.Results.Different;
                    }
                    Application.DoEvents();
                }
                contents1 = null;
                contents2 = null;
            }
            else if (cmbComparison.SelectedIndex == 1)
            {
                if (file1.LastWriteTime != file2.LastWriteTime)
                {
                    return Result.Results.Different;
                }
            }
            return Result.Results.Same;
        }

        private void UpdateResultsGrid()
        {
            gridResults.Rows.Clear();
            foreach (Result result in results)
            {
                if ((result.ComparisonResult == Result.Results.Same && cmbShowSame.SelectedIndex == 0) ||
                    (result.ComparisonResult == Result.Results.Only1 && cmbShowOnly1.SelectedIndex == 0) ||
                    (result.ComparisonResult == Result.Results.Only2 && cmbShowOnly2.SelectedIndex == 0) ||
                    (result.ComparisonResult == Result.Results.Different && cmbShowDifferent.SelectedIndex == 0)                     )
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.Tag = result;

                    DataGridViewTextBoxCell cell0 = new DataGridViewTextBoxCell();
                    cell0.Value = result.Path;
                    row.Cells.Add(cell0);

                    DataGridViewTextBoxCell cell1 = new DataGridViewTextBoxCell();
                    if (result.ComparisonResult == Result.Results.Same)
                    {
                        cell1.Value = "Same";
                    }
                    else if (result.ComparisonResult == Result.Results.Different)
                    {
                        cell1.Value = "Different";
                    }
                    else if (result.ComparisonResult == Result.Results.Only1)
                    {
                        cell1.Value = "Only in 1";
                    }
                    else if (result.ComparisonResult == Result.Results.Only2)
                    {
                        cell1.Value = "Only in 2";
                    }
                    row.Cells.Add(cell1);

                    DataGridViewTextBoxCell cell2 = new DataGridViewTextBoxCell();
                    cell2.Value = result.Modified1.HasValue ? result.Modified1.Value.ToString("dd/MM/yyyy HH:mm:ss") : string.Empty;
                    row.Cells.Add(cell2);

                    DataGridViewTextBoxCell cell3 = new DataGridViewTextBoxCell();
                    cell3.Value = result.Modified2.HasValue ? result.Modified2.Value.ToString("dd/MM/yyyy HH:mm:ss") : string.Empty;
                    row.Cells.Add(cell3);

                    gridResults.Rows.Add(row);
                }
            }
        }

        private void DeleteEmptyDirectories(string folder)
        {
            DirectoryInfo dir = new DirectoryInfo(folder);
            if (!dir.Exists) return;

            foreach (DirectoryInfo sub in dir.GetDirectories())
            {
                DeleteEmptyDirectories(sub.FullName);
            }
            if (dir.GetFiles().Count() == 0 && dir.GetDirectories().Count() == 0)
            {
                dir.Delete();
            }
        }

        private void PerformResultAction(Result.ResultAction action)
        {
            Cursor = Cursors.WaitCursor;
            Application.DoEvents();
            List<string> directoriesToCheckIfEmpty = new List<string>();
            foreach (Result result in results.ToList())
            {
                if (action == Result.ResultAction.DeleteSame1 && result.ComparisonResult == Result.Results.Same)
                {
                    FileInfo file = new FileInfo(Path.Combine(result.Folder1, result.Path));
                    if (file.Exists)
                    {
                        file.Delete();
                    }
                    results.Remove(result);
                }
                else if (action == Result.ResultAction.DeleteSame2 && result.ComparisonResult == Result.Results.Same)
                {
                    FileInfo file = new FileInfo(Path.Combine(result.Folder2, result.Path));
                    if (file.Exists)
                    {
                        file.Delete();
                    }
                    results.Remove(result);
                }
                Application.DoEvents();
            }
            Cursor = Cursors.Arrow;
            Application.DoEvents();
        }

        private void deleteSameFrom1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (results.Count == 0)
            {
                return;
            }

            if (MessageBox.Show(string.Format("Do you really want to delete all files from {0} which are the same as in the other folder?", results[0].Folder1), "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PerformResultAction(Result.ResultAction.DeleteSame1);
                DeleteEmptyDirectories(txtFolder1.Text);
            }
        }

        private void deleteSameFrom2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (results.Count == 0)
            {
                return;
            }

            if (MessageBox.Show(string.Format("Do you really want to delete all files from {0} which are the same as in the other folder?", results[0].Folder2), "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                PerformResultAction(Result.ResultAction.DeleteSame2);
                DeleteEmptyDirectories(txtFolder2.Text);
            }
        }

        private void gridResults_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string winMerge = @"C:\Program Files (x86)\WinMerge\WinMergeU.exe";
            if (!File.Exists(winMerge)) return;

            if (e.RowIndex < 0) return;

            Result result = (Result)gridResults.Rows[e.RowIndex].Tag;

            string file1 = Path.Combine(result.Folder1, result.Path);
            string file2 = Path.Combine(result.Folder2, result.Path);
            if (File.Exists(file1) && File.Exists(file2))
            {
                ProcessStartInfo psi = new ProcessStartInfo();
                psi.FileName = winMerge;
                psi.Arguments = string.Format("\"{0}\" \"{1}\"", file1, file2);
                Process.Start(psi);
            }
        }
    }
}
