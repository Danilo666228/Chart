using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.LinkLabel;

namespace ПР20
{
    public partial class StudentAnalysis : Form
    {
        public StudentAnalysis()
        {
            InitializeComponent();
        }
        public List<string> ReadSubjectForFile()
        {
            List<string> Subject = new List<string>();
            using (StreamReader reader = new StreamReader("Student.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    bool isNumber = false;
                    foreach(char i in line )
                    {
                        if(char.IsDigit(i))
                        {
                            isNumber = true;
                            break;
                        }
                    }
                    if(!isNumber)
                    {
                        Subject.Add(line);
                    }
                }
            }
            return Subject;
        }
        public List<int> ReadGradeFirstStudent()
        {
            List<int> Grade = new List<int>();
            using (var reader = new StreamReader("Student.txt"))
            {               
                reader.ReadLine();
                string line = reader.ReadLine();
                string[] lines = line.Split(',');
                foreach (string lin in lines)
                {
                    if (int.TryParse(lin, out int grade))
                    {
                        Grade.Add(grade);
                    }
                }
            }
            return Grade;
        }
        public List<int> ReadGradeTwoStudent()
        {
            List<int> Grade = new List<int>();
            using (var reader = new StreamReader("Student.txt"))
            {
                for (int i = 0; i < 3; i++)
                    reader.ReadLine();
                string line = reader.ReadLine();
                string[] lines = line.Split(',');
                foreach (string lin in lines)
                {
                    if (int.TryParse(lin, out int grade))
                    {
                        Grade.Add(grade);
                    }
                }
            }
            return Grade;
        }
        public List<int> ReadGradeThreeStudent()
        {
            List<int> Grade = new List<int>();
            using (var reader = new StreamReader("Student.txt"))
            {
                for (int i = 0; i < 5; i++)
                    reader.ReadLine();
                string line = reader.ReadLine();
                string[] lines = line.Split(',');
                foreach (string lin in lines)
                {
                    if (int.TryParse(lin, out int grade))
                    {
                        Grade.Add(grade);
                    }
                }
            }
            return Grade;
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            List<int> Grade1 = ReadGradeFirstStudent();
            List<int> Grade2 = ReadGradeTwoStudent();
            List<int> Grade3 = ReadGradeThreeStudent();
            double AverageGrade1 = Grade1.Average();
            double AverageGrade2 = Grade2.Average();
            double AverageGrade3 = Grade3.Average();
            List<double> ResultGrade = new List<double>();
            ResultGrade.Add(AverageGrade1);
            ResultGrade.Add(AverageGrade2);
            ResultGrade.Add(AverageGrade3);
            List<string> Predmet = ReadSubjectForFile();

            for (int i = 0; i < ResultGrade.Count; i++)
            {
                chart1.Series[0].Points.AddXY(Predmet[i], ResultGrade[i]);
            }
            btnResult.Enabled = false;
        }


    }
}
