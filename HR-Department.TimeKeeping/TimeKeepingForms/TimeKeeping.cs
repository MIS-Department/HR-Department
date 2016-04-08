using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HR_Department.Models.Tables;
using Newtonsoft.Json;


namespace HR_Department.TimeKeeping.TimeKeepingForms
{

    public partial class TimeKeepingMain : Form
    {
        int flag = 1;
        string URI = "http://localhost:9080/hrdapi/employee";
        string searchstring = "employeenumber";
        string URIDailyTimeRecord = "http://localhost:9080/hrdapi/dailytimerecord";
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
      

            if (e.KeyCode == Keys.Enter)
            {
                GetEmployeeNumber();

                clearTxtbox();          
            }
            else if (e.KeyCode == Keys.NumLock)
            {
                clearTxtbox();
                flag = 1;
            }
            else if (e.KeyCode == Keys.Divide)
            {
                clearTxtbox();
                flag = 2;
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                clearTxtbox();
                flag = 3;

            }
            else if (e.KeyCode == Keys.Subtract)
            {
                clearTxtbox();
                flag = 4;

            }
            else if (e.KeyCode == Keys.Subtract || e.KeyCode == Keys.Multiply || e.KeyCode == Keys.Divide || e.KeyCode == Keys.NumLock || e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.NumPad9)
            {
                clearTxtbox();
            }

        }


        private void tmrBlinkedTimer_Tick(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                lblTimeIn.Visible = !lblTimeIn.Visible;
                lblBreakIn.Visible = true;
                lblBreakOut.Visible = true;
                lblTimeOut.Visible = true;
            }
            else if (flag == 2)
            {
                lblBreakOut.Visible = !lblBreakOut.Visible;
                lblBreakIn.Visible = true;
                lblTimeOut.Visible = true;
                lblTimeIn.Visible = true;
            }
            else if (flag == 3)
            {
                lblBreakIn.Visible = !lblBreakIn.Visible;
                lblTimeOut.Visible = true;
                lblBreakOut.Visible = true;
                lblTimeIn.Visible = true;
            }
            else if (flag == 4)
            {
                lblTimeOut.Visible = !lblTimeOut.Visible;
                lblBreakIn.Visible = true;
                lblBreakOut.Visible = true;
                lblTimeIn.Visible = true;
            }


        }


        private async void GetEmployeeNumber()
        {
            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(string.Format("{0}/{1}/{2}", URI, txtBarcode.Text, searchstring)))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var employeeJsonString = await response.Content.ReadAsStringAsync();

                        JsonConvert.DeserializeObjectAsync<Employee>(employeeJsonString);
                        lblEmployeeName.Text = JsonConvert.DeserializeObject<Employee>(employeeJsonString).FirstName + " " + JsonConvert.DeserializeObject<Employee>(employeeJsonString).MiddleName + " " + JsonConvert.DeserializeObject<Employee>(employeeJsonString).LastName;
                        lblEmployeeNumber.Text =
                            JsonConvert.DeserializeObject<Employee>(employeeJsonString).EmployeeNumber;

                        InsertDailyTimeRecord(JsonConvert.DeserializeObject<Employee>(employeeJsonString).EmployeeId);

                        try
                        {
                            byte[] imagSource = JsonConvert.DeserializeObject<Employee>(employeeJsonString).ImageEmployee;
                            Bitmap image;
                            using (MemoryStream stream = new MemoryStream(imagSource))
                            {
                                image = new Bitmap(stream);
                            }
                            pictureBox1.Image = image;
                        }
                        catch (Exception ex)
                        {
                            lblErrorMessage.Text = ex.Message;
                          
                        }
                    }
                }
            }
        }

        private async Task<int> InsertDailyTimeRecord(int tempId)
        {
            DailyTimeRecord dtr = new DailyTimeRecord();
            dtr.EmployeeId = tempId;
            dtr.TimeCategoryId = flag;
            dtr.DateCreated = System.DateTime.Now;
            dtr.Time = System.DateTime.Now;
            using (var client = new HttpClient())
            {
                try
                {
                    var serializeDailyTimeRecord = JsonConvert.SerializeObject(dtr);
                    var content = new StringContent(serializeDailyTimeRecord, Encoding.UTF8, "application/json");
                    await client.PostAsync(URIDailyTimeRecord, content);
                }
                catch (Exception ex)
                {

                    lblErrorMessage.Text = ex.Message;
                    throw;
                }

            }
            GetAllDailtyTimeRecordSample();
            return tempId;
        }

        private async void GetAllDailtyTimeRecordSample()
        {
            dgvDetails.Columns.Clear();

            using (var client = new HttpClient())
            {
                using (var response = await client.GetAsync(URIDailyTimeRecord))
                {
                    if (response.IsSuccessStatusCode)
                    {
                        var DailyTimeRecordJsonString = await response.Content.ReadAsStringAsync();
                        dgvDetails.DataSource =
                            JsonConvert.DeserializeObject<DailyTimeRecord[]>(DailyTimeRecordJsonString).ToList();
                    }
                }
            }
        }

        private void txtBarcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            GetEmployeeNumber();
        }

        private void txtBarcode_Enter(object sender, EventArgs e)
        {
            GetEmployeeNumber();
        }


        public int TempId(int tempId)
        {
            return tempId;
        }


    }



}

