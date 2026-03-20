using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ocenki_na_uchenici
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string[] studentNames = new string[30]; // До 30 ученика
        private int[,] studentGrades = new int[30, 10]; // 30 ученика × 10 оценки
        private int studentCount = 0; // Брой ученици
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (studentCount >= 30)
            {
                labelResult.Text = "Достигнат е лимитът от 30 ученици!";
                return;
            }

            string name = comboBoxStudents.Text;
            string[] gradesText = textBoxGrades.Text.Split(',');

            if (name == "" || gradesText.Length != 10)
            {
                labelResult.Text = "Въведете име и точно 10 оценки!";
                return;
            }

            studentNames[studentCount] = name;

            for (int i = 0; i < 10; i++)
            {
                studentGrades[studentCount, i] = int.Parse(gradesText[i]);
            }

            listBoxStudents.Items.Add( name +string.Join(", ", gradesText));
            
            studentCount++;

            textBoxGrades.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (studentCount == 0)
            {
                labelResult.Text = "Няма добавени ученици!";
                return;
            }

            double totalSum = 0;
            int totalGrades = studentCount * 10;

            for (int i = 0; i < studentCount; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    totalSum += studentGrades[i, j];
                }
            }

            labelResult.Text = "Среден успех: " + (totalSum / totalGrades);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labelResult.Text = "Общ брой оценки: " + studentCount * 10;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (studentCount == 0)
            {
                labelResult.Text = "Няма ученици!";
                return;
            }

            int minIndex = 0;
            double minAverage = GetAverage(studentGrades, 0);

            for (int i = 1; i < studentCount; i++)
            {
                double avg = GetAverage(studentGrades, i);
                if (avg < minAverage)
                {
                    minAverage = avg;
                    minIndex = i;
                }
            }
             labelResult.Text = "Най-нисък успех: "+studentNames[minIndex]+ minAverage;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (studentCount == 0)
            {
                labelResult.Text = "Няма ученици!";
                return;
            }

            int maxIndex = 0;
            double maxAverage = GetAverage(studentGrades, 0);

            for (int i = 1; i < studentCount; i++)
            {
                double avg = GetAverage(studentGrades, i);
                if (avg > maxAverage)
                {
                    maxAverage = avg;
                    maxIndex = i;
                }
            }

            labelResult.Text = "Най-висок успех: " + studentNames[maxIndex] + maxAverage;
        }
        private double GetAverage(int[,] grades, int index)
        {
            double sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum += grades[index, i];
            }
            return sum / 10;
        }

        private void comboBoxStudents_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            studentCount = 0;
            listBoxStudents.Items.Clear();
            comboBoxStudents.Items.Clear();
            labelResult.Text = "Резултат: ";
        }
    }
}
