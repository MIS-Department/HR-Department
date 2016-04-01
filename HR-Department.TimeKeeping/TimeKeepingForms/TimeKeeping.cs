using System;
using System.Windows.Forms;


namespace HR_Department.TimeKeeping.TimeKeepingForms
{
    public partial class TimeKeepingMain : Form
    {
        public TimeKeepingMain()
        {
            InitializeComponent();
        }

    
        private void tmrDateAndTime_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("yyyy MMMM dd");
            
        }




        public void clearTxtbox()
        {
            txtBarcode.Text = string.Empty;
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.NumPad0)
            {
                clearTxtbox();
                lblTimeIn.Text = "Time In";
            }
            else if (e.KeyCode == Keys.Enter)
            {
                clearTxtbox();
                lblTimeIn.Text = "Lunch In";
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                clearTxtbox();
                lblTimeIn.Text = "Lunch Out";
            }
            else if (e.KeyCode == Keys.Add)
            {
                clearTxtbox();
                lblTimeIn.Text = "Time Out";
            }
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.Multiply || e.KeyCode == Keys.Divide || e.KeyCode == Keys.NumLock || e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.NumPad9)
            {
                clearTxtbox();
            }
        
            clearTxtbox();
        }

        private void TimeKeeping_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.NumPad0)
            //{
            //    clearTxtbox();
            //    lblTimeIn.Text = "Time In";

            //}
            //else if (e.KeyCode == Keys.Enter)
            //{
            //    clearTxtbox();
            //    lblTimeIn.Text = "Lunch In";


            //}
            //else if (e.KeyCode == Keys.Decimal)
            //{
            //    clearTxtbox();
            //    lblTimeIn.Text = "Lunch Out";


            //}
            //else if (e.KeyCode == Keys.Add)
            //{
            //    clearTxtbox();
            //    lblTimeIn.Text = "Time Out";
            //}
            //else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.Multiply || e.KeyCode == Keys.Divide || e.KeyCode == Keys.NumLock || e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.NumPad9)
            //{
            //    clearTxtbox();
            //}
            //clearTxtbox();
        }

        private void tmrBlinkedTimer_Tick(object sender, EventArgs e)
        {
            lblTimeIn.Visible = !lblTimeIn.Visible;

        }

  

           

    }
}
