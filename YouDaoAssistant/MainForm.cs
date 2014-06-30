using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace YouDaoAssistant
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private HookManager hookManager = new HookManager();
        private bool manualSendKeys = false;
        private bool sendDone = true;
        private StringBuilder activeWindowTitle = new StringBuilder();
        private Timer doneTimer = new Timer();
        private Timer sendRightTimer = new Timer();
        private Timer sendLeftTimer = new Timer();
        private Timer sendSpaceTimer = new Timer();
        private XmlManagerT<Setting> xmlManager = new XmlManagerT<Setting>();
        private Setting setting = new Setting();
        private string settingFileName = "Setting.xml";
        private string mainXmlString = @"<wordbook>
{0}
</wordbook>
";
        private string itemXmlString = @"
<item><word>{0}</word>
    <trans><![CDATA[{1}]]></trans>
    <phonetic><![CDATA[]]></phonetic>
    <tags>{2}</tags>
    <progress>0</progress>
</item>";

        private void btAdd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ProcessText();
        }

        private void barExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            Close();
        }

        private void btQuestion_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowMessage();
        }

        private void barHookMouse_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            if (barHookMouse.Checked)
            {
                hookManager.Start(true, true);
            }
            else
            {
                hookManager.Stop();
            }
        }

        private void ShowMessage()
        {
            string message = "由背单词累趴下的老衲无礼抽空制作：laonawuli@126.com。";
            message += "\n注意：";
            message += "\n当你点击“No”的时候，会弹出一个捐款网页，请一定不要多捐，原因如下：";
            message += "\n1.作为一个能用得起小米手机的土豪，压根不会在乎你到底捐了多少；";
            message += "\n2.这个程序前后不超过一小时写完（含段子），真不值得你几千几万地捐；";
            message += "\n3.这是好玩的一种统计方式，能让我知道你的存在；";
            message += "\n3.5（接上条）当然，如果你连帖子都懒得回，我也不指望你能参与这种方式了...；";
            message += "\n4.我真的只是觉得好玩，我真的不是一个功利心特别特别重的人；";
            message += "\n5.不扯淡了，我要背单词去了。";
            message += "\n6.捐个一毛两毛也行啊啊啊！";
            DialogResult dialogResult = XtraMessageBox.Show(message, "提示", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if (dialogResult == DialogResult.No)
            {
                try
                {
                    string target = @"https://me.alipay.com/laonawuli";
                    Process.Start(target);
                }
                catch (Exception e)
                {
                    XtraMessageBox.Show("程序出了点问题。你可以尝试从以下错误提示中得到一些信息：\n" + e.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ProcessText()
        {
            DialogResult dialogResult = openFileDialog.ShowDialog();
            if (dialogResult != DialogResult.OK)
            {
                return;
            }
            StreamReader streamReader = null;
            StreamWriter streamWriter = null;
            string category = string.Empty;
            try
            {
                btAdd.Enabled = false;
                string fileName = openFileDialog.FileName;
                streamReader = new StreamReader(fileName, Encoding.Default);
                bool isOk = false;
                List<Word> wordList = new List<Word>();
                while (!streamReader.EndOfStream)
                {
                    string str = streamReader.ReadLine();
                    if (str.Trim() == string.Empty)
                    {
                        continue;
                    }
                    str = str.Replace("\t", " ").Trim();
                    if (str.Split(' ').Length == 1)
                    {
                        continue;
                    }
                    Word word = new Word();
                    int lastSpace = str.LastIndexOf(' ');
                    word.WordName = str.Substring(0, lastSpace);
                    word.Meaning = str.Substring(word.WordName.Length, str.Length - word.WordName.Length).Trim();
                    if (isOk)
                    {
                        wordList.Add(word);
                        continue;
                    }
                    dialogResult = XtraMessageBox.Show("单词：" + word.WordName + "\n释义：" + word.Meaning, "第一条记录分析地对吗？", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        wordList.Add(word);
                        isOk = true;
                    }
                    else
                    {
                        XtraMessageBox.Show("请调整源文件格式。单词与释义间应有空格或Tab键。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        goto End;
                    }
                }

                if (wordList.Count == 0)
                {
                    XtraMessageBox.Show("未查找到有效记录。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    goto End;
                }

                WordCategoryForm categoryForm = new WordCategoryForm();
                categoryForm.ShowDialog();
                category = categoryForm.CategoryName;

                string xml = string.Empty;
                progressBar.Maximum = wordList.Count;
                barProgressBar.Visibility = BarItemVisibility.Always;
                int count = 0;
                foreach (Word word in wordList)
                {
                    count++;
                    xml += GetXmlItem(word, category);
                    barProgressBar.EditValue = count;
                    Application.DoEvents();
                }
                xml = string.Format(mainXmlString, xml);
                dialogResult = saveFileDialog.ShowDialog();
                if (dialogResult != DialogResult.OK)
                {
                    goto End;
                }
                fileName = saveFileDialog.FileName;
                streamWriter = File.CreateText(fileName);
                streamWriter.Write(xml);

            End:
                int i = 0;
            }
            catch (Exception e)
            {
                XtraMessageBox.Show("程序出了点问题。你可以尝试从以下错误提示中得到一些信息：\n" + e.Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                if (streamReader != null)
                {
                    streamReader.Close();
                }
                if (streamWriter != null)
                {
                    streamWriter.Close();
                }
                btAdd.Enabled = true;
                barProgressBar.EditValue = 0;
                barProgressBar.Visibility = BarItemVisibility.Never;
            }
        }

        private string GetXmlItem(Word word, string category)
        {
            return string.Format(itemXmlString, word.WordName, word.Meaning, category);
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitHook();
            CheckSetting();
            InitTimer();
        }

        private void InitHook()
        {
            hookManager.HookOnKeyUpEvent += hookManager_HookOnKeyUpEvent;
            hookManager.HookOnMouseActivityEvent += hookManager_HookOnMouseActivityEvent;
        }

        void hookManager_HookOnMouseActivityEvent(object sender, MouseEventArgs e)
        {
            if (!sendDone)
            {
                return;
            }
            if (manualSendKeys)
            {
                return;
            }
            IntPtr activeWindowHandle = GetForegroundWindow();
            GetWindowText(activeWindowHandle.ToInt32(), activeWindowTitle, 11);
            if (activeWindowTitle.ToString() != "有道单词本")
            {
                return;
            }
            Rect rect = new Rect();
            GetWindowRect(activeWindowHandle, ref rect);
            rect.Left = rect.Left + 20;
            rect.Right = rect.Right - 20;
            rect.Top = rect.Top + 80;
            rect.Bottom = rect.Bottom - 60;
            int x = rect.Left;
            int y = rect.Top;
            int width = rect.Right - rect.Left;
            int height = rect.Bottom - rect.Top;
            Rectangle rectangle = new Rectangle(x, y, width, height);
            if (!rectangle.Contains(HookManager.GlobalMouseEventArgs.Location))
            {
                return;
            }
            if (e.Button == MouseButtons.Right)
            {
                SendRightKeys();
            }
            if (e.Button == MouseButtons.Left)
            {
                SendLeftKeys();
            }
            manualSendKeys = false;
        }

        void hookManager_HookOnKeyUpEvent(object sender, KeyEventArgs e)
        {
            if (!sendDone)
            {
                return;
            }
            if (manualSendKeys)
            {
                return;
            }
            GetWindowText(GetForegroundWindow().ToInt32(), activeWindowTitle, 11);
            if (activeWindowTitle.ToString() != "有道单词本")
            {
                return;
            }
            if (e.KeyCode == Keys.Right)
            {
                SendRightKeys();
            }
            else if (e.KeyCode == Keys.Left)
            {
                SendLeftKeys();
            }
            manualSendKeys = false;
        }

        private void SendRightKeys()
        {
            manualSendKeys = true;
            sendSpaceTimer.Start();
            sendRightTimer.Interval = setting.TimeDoNotKnow;
            sendRightTimer.Start();
            doneTimer.Interval = sendRightTimer.Interval + 200;
            sendDone = false;
            doneTimer.Start();
        }

        private void SendLeftKeys()
        {
            manualSendKeys = true;
            sendSpaceTimer.Start();
            sendLeftTimer.Interval = setting.TimeKnow;
            sendLeftTimer.Start();
            doneTimer.Interval = sendLeftTimer.Interval + 200;
            sendDone = false;
            doneTimer.Start();
        }

        private void CheckSetting()
        {
            if (!File.Exists(settingFileName))
            {
                Setting setting = new Setting();
                xmlManager.SerializeToFile(setting, settingFileName);
            }
            else
            {
                setting = xmlManager.DeserializeToObjectFromFile(settingFileName);
            }
            barEditKnow.EditValue = setting.TimeKnow;
            barEditNotKnow.EditValue = setting.TimeDoNotKnow;
            repositoryItemSpinEditKnow.EditValueChanged += repositoryItemSpinEditKnow_EditValueChanged;
            repositoryItemSpinEditNotKnow.EditValueChanged += repositoryItemSpinEditNotKnow_EditValueChanged;
        }

        void repositoryItemSpinEditNotKnow_EditValueChanged(object sender, EventArgs e)
        {
            SpinEdit spinEdit = sender as SpinEdit;
            setting.TimeDoNotKnow = Convert.ToInt32(spinEdit.EditValue);
            xmlManager.SerializeToFile(setting, settingFileName);
        }

        void repositoryItemSpinEditKnow_EditValueChanged(object sender, EventArgs e)
        {
            SpinEdit spinEdit = sender as SpinEdit;
            setting.TimeKnow = Convert.ToInt32(spinEdit.EditValue);
            xmlManager.SerializeToFile(setting, settingFileName);
        }

        private void InitTimer()
        {
            doneTimer.Tick += doneTimer_Tick;
            sendRightTimer.Tick += sendRightTimer_Tick;
            sendLeftTimer.Tick += sendLeftTimer_Tick;
            sendSpaceTimer.Interval = 50;
            sendSpaceTimer.Tick += sendSpaceTimer_Tick;
        }

        void sendSpaceTimer_Tick(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
            sendSpaceTimer.Stop();
        }

        void sendLeftTimer_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("{Left}");
            sendLeftTimer.Stop();
        }

        void sendRightTimer_Tick(object sender, EventArgs e)
        {
            SendKeys.Send("{Right}");
            sendRightTimer.Stop();
        }

        void doneTimer_Tick(object sender, EventArgs e)
        {
            sendDone = true;
            doneTimer.Stop();
        }

        [DllImport("user32.dll", EntryPoint = "GetForegroundWindow")]
        public static extern IntPtr GetForegroundWindow();

        [DllImport("user32.dll")]
        private static extern bool GetWindowText(int hWnd, StringBuilder title, int maxBufSize);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool GetWindowRect(IntPtr hWnd, ref Rect lpRect);

        [StructLayout(LayoutKind.Sequential)]
        public struct Rect
        {
            public int Left;
            public int Top;
            public int Right;
            public int Bottom;
        }
    }
}
