namespace YouDaoAssistant
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.barMain = new DevExpress.XtraBars.Bar();
            this.btAdd = new DevExpress.XtraBars.BarButtonItem();
            this.barHookMouse = new DevExpress.XtraBars.BarCheckItem();
            this.barSetting = new DevExpress.XtraBars.BarSubItem();
            this.barHook = new DevExpress.XtraBars.BarSubItem();
            this.barEditKnow = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEditKnow = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barEditNotKnow = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemSpinEditNotKnow = new DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit();
            this.barExit = new DevExpress.XtraBars.BarButtonItem();
            this.btQuestion = new DevExpress.XtraBars.BarButtonItem();
            this.barStausBar = new DevExpress.XtraBars.Bar();
            this.barProgressBar = new DevExpress.XtraBars.BarEditItem();
            this.progressBar = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.images = new DevExpress.Utils.ImageCollection(this.components);
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemMarqueeProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar();
            this.btProcess = new DevExpress.XtraBars.BarButtonItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditKnow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditNotKnow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.images)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager
            // 
            this.barManager.AllowCustomization = false;
            this.barManager.AllowMoveBarOnToolbar = false;
            this.barManager.AllowQuickCustomization = false;
            this.barManager.AllowShowToolbarsPopup = false;
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.barMain,
            this.barStausBar});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Images = this.images;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barEditItem1,
            this.barProgressBar,
            this.btAdd,
            this.btProcess,
            this.barExit,
            this.btQuestion,
            this.barHookMouse,
            this.barSetting,
            this.barHook,
            this.barEditKnow,
            this.barEditNotKnow});
            this.barManager.MainMenu = this.barMain;
            this.barManager.MaxItemId = 11;
            this.barManager.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMarqueeProgressBar1,
            this.progressBar,
            this.repositoryItemSpinEditKnow,
            this.repositoryItemSpinEditNotKnow});
            this.barManager.StatusBar = this.barStausBar;
            // 
            // barMain
            // 
            this.barMain.BarName = "Main menu";
            this.barMain.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Top;
            this.barMain.DockCol = 0;
            this.barMain.DockRow = 0;
            this.barMain.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.barMain.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.barHookMouse),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barSetting, DevExpress.XtraBars.BarItemPaintStyle.CaptionInMenu),
            new DevExpress.XtraBars.LinkPersistInfo(this.barExit, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btQuestion)});
            this.barMain.OptionsBar.AllowQuickCustomization = false;
            this.barMain.OptionsBar.DisableCustomization = true;
            this.barMain.OptionsBar.DrawDragBorder = false;
            this.barMain.OptionsBar.MultiLine = true;
            this.barMain.OptionsBar.UseWholeRow = true;
            this.barMain.Text = "Main menu";
            // 
            // btAdd
            // 
            this.btAdd.Caption = "选择文件";
            this.btAdd.Id = 2;
            this.btAdd.ImageIndex = 0;
            this.btAdd.Name = "btAdd";
            this.btAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btAdd_ItemClick);
            // 
            // barHookMouse
            // 
            this.barHookMouse.Caption = "快捷";
            this.barHookMouse.Id = 6;
            this.barHookMouse.ImageIndex = 3;
            this.barHookMouse.Name = "barHookMouse";
            this.barHookMouse.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barHookMouse_CheckedChanged);
            // 
            // barSetting
            // 
            this.barSetting.Caption = "设置";
            this.barSetting.Id = 7;
            this.barSetting.ImageIndex = 4;
            this.barSetting.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barHook)});
            this.barSetting.Name = "barSetting";
            // 
            // barHook
            // 
            this.barHook.Caption = "快捷";
            this.barHook.Id = 8;
            this.barHook.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditKnow),
            new DevExpress.XtraBars.LinkPersistInfo(this.barEditNotKnow)});
            this.barHook.Name = "barHook";
            // 
            // barEditKnow
            // 
            this.barEditKnow.Caption = "记得";
            this.barEditKnow.Edit = this.repositoryItemSpinEditKnow;
            this.barEditKnow.Id = 9;
            this.barEditKnow.Name = "barEditKnow";
            this.barEditKnow.Width = 60;
            // 
            // repositoryItemSpinEditKnow
            // 
            this.repositoryItemSpinEditKnow.AutoHeight = false;
            this.repositoryItemSpinEditKnow.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEditKnow.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.repositoryItemSpinEditKnow.Name = "repositoryItemSpinEditKnow";
            // 
            // barEditNotKnow
            // 
            this.barEditNotKnow.Caption = "忘记";
            this.barEditNotKnow.Edit = this.repositoryItemSpinEditNotKnow;
            this.barEditNotKnow.Id = 10;
            this.barEditNotKnow.Name = "barEditNotKnow";
            this.barEditNotKnow.Width = 60;
            // 
            // repositoryItemSpinEditNotKnow
            // 
            this.repositoryItemSpinEditNotKnow.AutoHeight = false;
            this.repositoryItemSpinEditNotKnow.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemSpinEditNotKnow.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.repositoryItemSpinEditNotKnow.Name = "repositoryItemSpinEditNotKnow";
            // 
            // barExit
            // 
            this.barExit.Caption = "退出";
            this.barExit.Id = 4;
            this.barExit.ImageIndex = 1;
            this.barExit.Name = "barExit";
            this.barExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barExit_ItemClick);
            // 
            // btQuestion
            // 
            this.btQuestion.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btQuestion.Caption = "疑问";
            this.btQuestion.Id = 5;
            this.btQuestion.ImageIndex = 2;
            this.btQuestion.Name = "btQuestion";
            this.btQuestion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btQuestion_ItemClick);
            // 
            // barStausBar
            // 
            this.barStausBar.BarName = "Status bar";
            this.barStausBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.barStausBar.DockCol = 0;
            this.barStausBar.DockRow = 0;
            this.barStausBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.barStausBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barProgressBar)});
            this.barStausBar.OptionsBar.AllowQuickCustomization = false;
            this.barStausBar.OptionsBar.DrawDragBorder = false;
            this.barStausBar.OptionsBar.UseWholeRow = true;
            this.barStausBar.Text = "Status bar";
            // 
            // barProgressBar
            // 
            this.barProgressBar.AutoFillWidth = true;
            this.barProgressBar.AutoHideEdit = false;
            this.barProgressBar.Caption = "进度";
            this.barProgressBar.Edit = this.progressBar;
            this.barProgressBar.EditHeight = 20;
            this.barProgressBar.Id = 1;
            this.barProgressBar.Name = "barProgressBar";
            this.barProgressBar.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // progressBar
            // 
            this.progressBar.EndColor = System.Drawing.Color.DimGray;
            this.progressBar.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.progressBar.LookAndFeel.UseDefaultLookAndFeel = false;
            this.progressBar.Name = "progressBar";
            this.progressBar.ProgressViewStyle = DevExpress.XtraEditors.Controls.ProgressViewStyle.Solid;
            this.progressBar.StartColor = System.Drawing.Color.Silver;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(279, 40);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 30);
            this.barDockControlBottom.Size = new System.Drawing.Size(279, 25);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 40);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 0);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(279, 40);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 0);
            // 
            // images
            // 
            this.images.ImageSize = new System.Drawing.Size(32, 32);
            this.images.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("images.ImageStream")));
            this.images.Images.SetKeyName(0, "Add.png");
            this.images.Images.SetKeyName(1, "Exit.png");
            this.images.Images.SetKeyName(2, "Question.png");
            this.images.Images.SetKeyName(3, "Hook.png");
            this.images.Images.SetKeyName(4, "Configuration.png");
            // 
            // barEditItem1
            // 
            this.barEditItem1.Caption = "barEditItem1";
            this.barEditItem1.Edit = this.repositoryItemMarqueeProgressBar1;
            this.barEditItem1.Id = 0;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemMarqueeProgressBar1
            // 
            this.repositoryItemMarqueeProgressBar1.Name = "repositoryItemMarqueeProgressBar1";
            // 
            // btProcess
            // 
            this.btProcess.Caption = "生成";
            this.btProcess.Id = 3;
            this.btProcess.ImageIndex = 2;
            this.btProcess.Name = "btProcess";
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "文本文件(*.txt)|*.txt";
            this.openFileDialog.RestoreDirectory = true;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "WordsBook";
            this.saveFileDialog.Filter = "有道单词本文件(*.xml)|*.xml";
            this.saveFileDialog.RestoreDirectory = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 55);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "道助手";
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditKnow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSpinEditNotKnow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.progressBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.images)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMarqueeProgressBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar barMain;
        private DevExpress.XtraBars.Bar barStausBar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemMarqueeProgressBar repositoryItemMarqueeProgressBar1;
        private DevExpress.XtraBars.BarEditItem barProgressBar;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar progressBar;
        private DevExpress.Utils.ImageCollection images;
        private DevExpress.XtraBars.BarButtonItem btAdd;
        private DevExpress.XtraBars.BarButtonItem btProcess;
        private DevExpress.XtraBars.BarButtonItem barExit;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private DevExpress.XtraBars.BarButtonItem btQuestion;
        private DevExpress.XtraBars.BarCheckItem barHookMouse;
        private DevExpress.XtraBars.BarSubItem barSetting;
        private DevExpress.XtraBars.BarSubItem barHook;
        private DevExpress.XtraBars.BarEditItem barEditKnow;
        private DevExpress.XtraBars.BarEditItem barEditNotKnow;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEditKnow;
        private DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit repositoryItemSpinEditNotKnow;

    }
}

