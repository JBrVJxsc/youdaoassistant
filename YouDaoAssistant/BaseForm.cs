using DevExpress.XtraEditors;
using System;
using System.Windows.Forms;

namespace YouDaoAssistant
{
    public partial class BaseForm : XtraForm
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x086)
            {
                if (m.WParam == IntPtr.Zero)
                {
                    m.WParam = new IntPtr(1);
                }
            }
            base.WndProc(ref m);
        }
    }
}
