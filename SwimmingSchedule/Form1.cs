using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SwimmingSchedule
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelClear();
        }

        // 結果を表示するラベルのクリア
        private void labelClear()
        {
            labelClassDay.Text = "";
            labelStartTime.Text = "";
            labelSchoolFees.Text = "";
        }

        private void buttonIndication_Click(object sender, EventArgs e)
        {
            int year = (int)numericUpDownYear.Value;
            int month = (int)numericUpDownMonth.Value;
            int n = listBoxCourse.SelectedIndex; // ListBoxの選択されている要素のインデックス
            switch (n)
            {
                case 0:
                    Course courseBaby = new Course(year, month, "ベビー", 1, 14, 1000);
                    labelClassDay.Text = courseBaby.Days;
                    labelStartTime.Text = courseBaby.Starttime.ToString()+"時";
                    labelSchoolFees.Text = courseBaby.Schoolfees.ToString() + "円";
                    break;
                case 1:
                    Course courseInfant = new Course(year, month, "幼児", 2, 10, 1000);
                    labelClassDay.Text = courseInfant.Days;
                    labelStartTime.Text = courseInfant.Starttime.ToString() + "時";
                    labelSchoolFees.Text = courseInfant.Schoolfees.ToString() + "円";
                    break;
                case 2:
                    Course courseElementary = new Course(year, month, "小学生", 3, 17, 800);
                    labelClassDay.Text = courseElementary.Days;
                    labelStartTime.Text = courseElementary.Starttime.ToString() + "時";
                    labelSchoolFees.Text = courseElementary.Schoolfees.ToString() + "円";
                    break;
                case 3:
                    Course courseMiddle = new Course(year, month, "中学生", 4, 19, 800);
                    labelClassDay.Text = courseMiddle.Days;
                    labelStartTime.Text = courseMiddle.Starttime.ToString() + "時";
                    labelSchoolFees.Text = courseMiddle.Schoolfees.ToString() + "円";
                    break;
                case 4:
                    Course courseRady = new Course(year, month, "レディース", 5, 20, 1000);
                    labelClassDay.Text = courseRady.Days;
                    labelStartTime.Text = courseRady.Starttime.ToString() + "時";
                    labelSchoolFees.Text = courseRady.Schoolfees.ToString() + "円";
                    break;
                case 5:
                    Course courseGeneral = new Course(year, month, "一般", 6, 20, 1200);
                    labelClassDay.Text = courseGeneral.Days;
                    labelStartTime.Text = courseGeneral.Starttime.ToString() + "時";
                    labelSchoolFees.Text = courseGeneral.Schoolfees.ToString() + "円";
                    break;
                case 6:
                    Course courseFamily = new Course(year, month, "家族", 0, 10, 1500);
                    labelClassDay.Text = courseFamily.Days;
                    labelStartTime.Text = courseFamily.Starttime.ToString() + "時";
                    labelSchoolFees.Text = courseFamily.Schoolfees.ToString() + "円";
                    break;
            }
        }
    }
}
