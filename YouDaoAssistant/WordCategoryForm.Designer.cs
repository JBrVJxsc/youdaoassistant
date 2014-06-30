namespace YouDaoAssistant
{
    partial class WordCategoryForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WordCategoryForm));
            this.txtNameCategory = new DevExpress.XtraEditors.TextEdit();
            this.btOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameCategory.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Location = new System.Drawing.Point(12, 12);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Properties.Appearance.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCategory.Properties.Appearance.Options.UseFont = true;
            this.txtNameCategory.Size = new System.Drawing.Size(135, 26);
            this.txtNameCategory.TabIndex = 0;
            this.txtNameCategory.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNameCategory_KeyDown);
            // 
            // btOK
            // 
            this.btOK.Appearance.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btOK.Appearance.Options.UseFont = true;
            this.btOK.Location = new System.Drawing.Point(12, 44);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(135, 25);
            this.btOK.TabIndex = 1;
            this.btOK.Text = "确定";
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // WordCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(159, 81);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.txtNameCategory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WordCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "道单词分类";
            ((System.ComponentModel.ISupportInitialize)(this.txtNameCategory.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btOK;
        private DevExpress.XtraEditors.TextEdit txtNameCategory;
    }
}