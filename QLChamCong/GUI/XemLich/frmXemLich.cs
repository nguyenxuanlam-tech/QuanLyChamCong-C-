using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.XemLich
{
    public partial class frmXemLich : Form
    {
        int month, year;
        public frmXemLich()
        {
            InitializeComponent();
        }

        private void frmXemLich_Load(object sender, EventArgs e)
        {
            displayDays();
        }
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDate.Text = monthname+" " +year;

            //lấy giá trị ngày đầu tiên của tháng
            DateTime strartoftheMonth = new DateTime(year, month, 1);
            //gán giá trị ngày đầu tiên của tháng vào tuần
            int days = DateTime.DaysInMonth(year, month);
            //chuyển giá trị ngày đâu tiên tháng về kiển interger
            int dayofweek = Convert.ToInt32(strartoftheMonth.DayOfWeek.ToString("d")) +1;

            //tạo UserControl cho từ ngày
            for(int i = 1; i<dayofweek; i++)
            {
                uctBlank uctblank = new uctBlank();

                dayContainer.Controls.Add(uctblank);
            }

            //Tạo một UserControl for day
            for(int i = 1; i <= days; i++)
            {
                uctDays uctday = new uctDays();
                uctday.Days(i);
                dayContainer.Controls.Add(uctday);
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            //clear  container
            dayContainer.Controls.Clear();
            //giảm giá trị của tháng lên 1 đơn vị sau mỗi lần click
            month--;
            //lấy giá trị ngày đầu tiên của tháng
            DateTime strartoftheMonth = new DateTime(year, month, 1);
            //gán giá trị ngày đầu tiên của tháng vào tuần
            int days = DateTime.DaysInMonth(year, month);
            //chuyển giá trị ngày đâu tiên tháng về kiển interger
            int dayofweek = Convert.ToInt32(strartoftheMonth.DayOfWeek.ToString("d")) + 1;

            //tạo UserControl cho từ ngày
            for (int i = 1; i < dayofweek; i++)
            {
                uctBlank uctblank = new uctBlank();

                dayContainer.Controls.Add(uctblank);
            }

            //Tạo một UserControl for day
            for (int i = 1; i <= days; i++)
            {
                uctDays uctday = new uctDays();
                uctday.Days(i);
                dayContainer.Controls.Add(uctday);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //clear  container
            dayContainer.Controls.Clear();
            //tăng giá trị của tháng lên 1 đơn vị sau mỗi lần click
            month++;
            //lấy giá trị ngày đầu tiên của tháng
            DateTime strartoftheMonth = new DateTime(year, month, 1);
            //gán giá trị ngày đầu tiên của tháng vào tuần
            int days = DateTime.DaysInMonth(year, month);
            //chuyển giá trị ngày đâu tiên tháng về kiển interger
            int dayofweek = Convert.ToInt32(strartoftheMonth.DayOfWeek.ToString("d")) + 1;

            //tạo UserControl cho từ ngày
            for (int i = 1; i < dayofweek; i++)
            {
                uctBlank uctblank = new uctBlank();

                dayContainer.Controls.Add(uctblank);
            }

            //Tạo một UserControl for day
            for (int i = 1; i <= days; i++)
            {
                uctDays uctday = new uctDays();
                uctday.Days(i);
                dayContainer.Controls.Add(uctday);
            }
        }
    }
}
