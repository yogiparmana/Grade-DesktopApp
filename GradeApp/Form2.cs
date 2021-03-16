using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GradeApp
{
    public partial class Form2 : Form
    {
        string nama;
        double checkNum = -1;
        public Form2(string nama)
        {
            InitializeComponent();
            label2.Text += nama;
            this.nama = nama;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkNumber(textTugas.Text.ToString(),checkNum,label1) != 0 && checkNumber(textKuis.Text.ToString(), checkNum,label3) != 0 && checkNumber(textUts.Text.ToString(), checkNum,label4) != 0 && checkNumber(textUas.Text.ToString(), checkNum,label5) != 0)
            {
                string nHuruf;
                double dTugas = double.Parse(textTugas.Text), dKuis = double.Parse(textKuis.Text), dUts = double.Parse(textUts.Text), dUas = double.Parse(textUas.Text), nAkhir;

                nAkhir = (0.2 * dTugas) + (0.2 * dKuis) + (0.3 * dUts) + (0.3 * dUas);
                if (nAkhir >= 85 && nAkhir <= 100)
                    nHuruf = "A";
                else if (nAkhir >= 65 && nAkhir < 85)
                    nHuruf = "B";
                else if (nAkhir >= 55 && nAkhir < 65)
                    nHuruf = "C";
                else if (nAkhir >= 45 && nAkhir < 55)
                    nHuruf = "D";
                else if (nAkhir >= 0 && nAkhir <= 45)
                    nHuruf = "E";
                else
                    nHuruf = "INVALID";
                MessageBox.Show("Nama Mahasiswa \t: "+nama+"\nNilai Akhir\t: " + nAkhir +"\nGrade\t\t: " + nHuruf);
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        static double checkNumber(string str, double checkNum, Label l)
        {

            
            double newNum = 0;
            if (double.TryParse(str, out checkNum))
            {
                newNum = double.Parse(str);
                if (newNum > 100 || newNum < 0)
                {  
                    MessageBox.Show("error di Form " + l.Text + ", 'Input HArus > 0 atau < 100!'");
                    newNum = 0;
                }

            }
            else
            {
                MessageBox.Show("error di Form " +l.Text+", 'Input Harus Angka!'");
            }
            return newNum;
        }
    }
}
