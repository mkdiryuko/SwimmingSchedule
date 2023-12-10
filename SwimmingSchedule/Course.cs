using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingSchedule
{
    // コースクラス
    class Course
    {
        // フィールド
        private int schoolfees;   　// 一回分の授業料
        private string days;        // 授業がある日付

        // コンストラクタ
        public Course(int year, int month, string coursename, 
            int dayofweek, int starttime, int schoolfees)
        {
            Year = year;
            Month = month;
            CourseName = coursename;
            DayOfWeek  = dayofweek;
            Starttime  = starttime;
            Schoolfees = schoolfees;
            Days = CalDays(year, month, dayofweek);
        }

        // プロパティ
        public int Year { get; set; }
        public int Month { get; set; }
        public string CourseName { get; set; }
        public int DayOfWeek { get; set; }
        public int Starttime { get; set; }
        
        public int Schoolfees
        {
            get { return schoolfees; }
            set { schoolfees = CalSchoolFees(Year, Month, DayOfWeek, value); }
        }

        public string Days
        {
            get { return days; }
            set { days = value; }
        }

        // 授業日を計算
        public string CalDays(int year, int month, int targetdayofweek)
        {
            int finalday = FinalDay(year, month, targetdayofweek);

            int day4 = finalday;
            int day3 = day4 - 7;
            int day2 = day3 - 7;
            int day1 = day2 - 7;

            if (day1 == 0)
                return day2.ToString() + "日 " + day3.ToString() + "日 " + day4.ToString() + "日 ";
            else
                return day1.ToString() + "日 " + day2.ToString() + "日 " + day3.ToString() + "日 " + day4.ToString() + "日 ";
        }

        // （仮引数）年、月、曜日
        // （戻り値）月の最後にその曜日となる日
        public int FinalDay(int year, int month, int targetdayofweek)
        {
            int daysInMonth = DateTime.DaysInMonth(year, month);  // 月の最終日
            int finalday = daysInMonth - 3;                       // 月の最後の3日は休講だから、実質ここが最終日
            int w;

            do
            {
                DateTime dt = new DateTime(year, month, finalday);
                w = (int)dt.DayOfWeek;  // 月の最終日の曜日をintで取得(0:日, 1:月... 6:土)
                finalday -= 1;
            }while (w != targetdayofweek);

            return finalday + 1;
        }

        // １ヶ月の授業料を計算
        public int CalSchoolFees(int year, int month, int targetdayofweek, int schoolfees)
        {
            int count = 0;
            int finalday = FinalDay(year, month, targetdayofweek);

            int day4 = finalday;
            count++;
            int day3 = day4 - 7;
            count++;
            int day2 = day3 - 7;
            count++;
            int day1 = day2 - 7;
            count++;

            if (day1 == 0)
            {
                count--;
            }
            return schoolfees * count;
        }
    }
}
