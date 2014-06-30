
using System;
using System.Windows.Forms;
namespace YouDaoAssistant
{
    public partial class WordCategoryForm : BaseForm
    {
        public WordCategoryForm()
        {
            InitializeComponent();
        }

        public string CategoryName
        {
            get
            {
                return txtNameCategory.Text;
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNameCategory_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Close();
            }
        }
    }
}
