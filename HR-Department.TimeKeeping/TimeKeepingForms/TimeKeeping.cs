using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Windows.Forms;
using HR_Department.TimeKeeping.Properties;
using Newtonsoft.Json;
using OG_MFTG.Models.DTO;

namespace HR_Department.TimeKeeping.TimeKeepingForms
{

    public partial class TimeKeepingMain : Form
    {
        frmMessageError messageError = new frmMessageError();
        private int _flag = 1;
        string _uri = "http://localhost:9081/hrdapi/employee";
        string _searchstring = "employeenumber";
        string _timecategoryid = "timecategoryid";
        string _uriDailyTimeRecord = "http://192.168.2.8:9081/hrdapi/dailytimerecord";
        public TimeKeepingMain()
        {
            InitializeComponent();
        }


        private void tmrDateAndTime_Tick(object sender, EventArgs e)
        {

            lblTime.Text = DateTime.Now.ToString("hh:mm:ss tt");
            lblDate.Text = DateTime.Now.ToString("yyyy MMMM dd");
        }
        public void ClearTxtbox()
        {
            txtBarcode.Clear();
        }

        private void txtBarcode_KeyDown(object sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Enter)
            {

                GetEmployeeNumber();
                txtBarcode.Clear();

            }
            else if (e.KeyCode == Keys.NumLock)
            {

                _flag = 1;
                ClearTxtbox();
            }
            else if (e.KeyCode == Keys.Divide)
            {

                _flag = 2;
                ClearTxtbox();
            }
            else if (e.KeyCode == Keys.Multiply)
            {

                _flag = 3;
                ClearTxtbox();
            }
            else if (e.KeyCode == Keys.Subtract)
            {

                _flag = 4;
                ClearTxtbox();

            }
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.Multiply || e.KeyCode == Keys.Divide || e.KeyCode == Keys.NumLock || e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.NumPad9)
            {
                ClearTxtbox();
            }

        }
        private void tmrBlinkedTimer_Tick(object sender, EventArgs e)
        {
            if (_flag == 1)
            {
                lblTimeIn.Visible = !lblTimeIn.Visible;
                lblBreakIn.Visible = true;
                lblBreakOut.Visible = true;
                lblTimeOut.Visible = true;
            }
            else if (_flag == 4)
            {
                lblBreakOut.Visible = !lblBreakOut.Visible;
                lblBreakIn.Visible = true;
                lblTimeOut.Visible = true;
                lblTimeIn.Visible = true;


            }
            else if (_flag == 3)
            {
                lblBreakIn.Visible = !lblBreakIn.Visible;
                lblTimeOut.Visible = true;
                lblBreakOut.Visible = true;
                lblTimeIn.Visible = true;


            }
            else if (_flag == 2)
            {
                lblTimeOut.Visible = !lblTimeOut.Visible;
                lblBreakIn.Visible = true;
                lblBreakOut.Visible = true;
                lblTimeIn.Visible = true;

            }

            if (pctErrorMessage.Visible)
            {
                pctErrorMessage.Visible = !pctErrorMessage.Visible;
            }

        }
        private async void GetEmployeeNumber()
        {

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(string.Format("{0}?employeenumber={1}&timecategoryid={2}", _uriDailyTimeRecord, txtBarcode.Text.Trim('/', '*', '-'), _flag)))

                {

                    if (response.IsSuccessStatusCode)
                    {
                        lblErrorMessage.Text = null;
                        pctErrorMessage.Visible = false;
                        dgvDetails.DataSource = null;
                        var employeeJsonString = await response.Content.ReadAsStringAsync();
                        try
                        {

                            lblEmployeeNumber.Text =
                                JsonConvert.DeserializeObject<EmployeeNotify>(employeeJsonString)
                                    .Employee.EmployeeNumber;
                            lblEmployeeName.Text = JsonConvert.DeserializeObject<EmployeeNotify>(employeeJsonString).Employee.FirstName +
                                                   " " +
                                                   JsonConvert.DeserializeObject<EmployeeNotify>(employeeJsonString).Employee.MiddleName +
                                                   " " +
                                                   JsonConvert.DeserializeObject<EmployeeNotify>(employeeJsonString).Employee.LastName;
                            dgvDetails.DataSource =
                                JsonConvert.DeserializeObject<EmployeeNotify>(employeeJsonString)
                                    .DailyTimeRecord.ToList();
                            //byte[] imagSource =
                            //    JsonConvert.DeserializeObject<EmployeeNotify>(employeeJsonString).Employee.ImageEmployee;
                            //Bitmap image;
                            //using (MemoryStream stream = new MemoryStream(imagSource))
                            //{
                            //    image = new Bitmap(stream);
                            //}
                            //pictureBox1.Image = image;
                        }
                        catch (Exception ex)
                        {
                            pctErrorMessage.Visible = true;
                            pctErrorMessage.Image = Resources.Information;
                            lblErrorMessage.Text = ex.Message;

                        }

                        if (JsonConvert.DeserializeObject<EmployeeNotify>(employeeJsonString).IsSuspended)
                        {
                            //MessageBox.Show("You are suspended today", "System Denied", MessageBoxButtons.OKCancel);
                            messageError.Show();
                        }

                        if (JsonConvert.DeserializeObject<EmployeeNotify>(employeeJsonString).IsTimeCheck)
                        {
                            if (_flag == 1)
                            {
                                pctErrorMessage.Visible = true;
                                lblErrorMessage.ImageAlign = ContentAlignment.MiddleLeft;
                                lblErrorMessage.Text = "You already time in";
                            }
                            else if (_flag == 2)
                            {
                                pctErrorMessage.Visible = true;
                                pctErrorMessage.Image = Resources._32px_Red_information_icon_with_gradient_background_svg;
                                lblErrorMessage.Text = "You already break out";
                            }
                            else if (_flag == 3)
                            {
                                pctErrorMessage.Visible = true;
                                pctErrorMessage.Image = Resources.Information;
                                lblErrorMessage.Text = "You already break in";
                            }
                            else if (_flag == 4)
                            {
                                pctErrorMessage.Visible = true;
                                pctErrorMessage.Image = Resources.Information;
                                lblErrorMessage.Text = "You already time out";
                            }


                        }
                        if (JsonConvert.DeserializeObject<EmployeeNotify>(employeeJsonString).Error != null)
                        {
                            pctErrorMessage.Visible = true;
                            pctErrorMessage.Image = Resources.Information;
                            lblErrorMessage.Text = JsonConvert.DeserializeObject<EmployeeNotify>(employeeJsonString).Error.Message;
                        }
                    }
                    else
                    {
                        pctErrorMessage.Visible = true;
                        pctErrorMessage.Image = Resources.Information;
                        lblErrorMessage.Text = "Access Denied";
                    }
                }
            }
        }
    }
}

