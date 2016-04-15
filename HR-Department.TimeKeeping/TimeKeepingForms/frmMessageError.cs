using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_Department.TimeKeeping.TimeKeepingForms
{
    public partial class frmMessageError : Form
    {
        public frmMessageError()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
