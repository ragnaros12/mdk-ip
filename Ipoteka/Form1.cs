using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ipoteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Cena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) 
                return;
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (e.KeyChar==',')
            {
                if (Cena.Text.Contains(","))
                    e.Handled = true;
                if (Cena.Text == "")
                    e.Handled = true;
                return;
            }
            if (e.KeyChar == '-' && Cena.Text == "")
                return;
            if (e.KeyChar == 8)
                return;
            if (e.KeyChar==27)
            {
                Cena.Text = "0";
                return;
            }
            e.Handled = true;
        }

        private void GodProc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                return;
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (GodProc.Text.Contains(","))
                    e.Handled = true;
                if (GodProc.Text == "")
                    e.Handled = true;
                return;
            }
            if (e.KeyChar == '-' && GodProc.Text == "")
                return;
            if (e.KeyChar == 8)
                return;
            if (e.KeyChar == 27)
            {
                GodProc.Text = "0";
                return;
            }
            e.Handled = true;
        }

        private void Srok_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                return;
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (Srok.Text.Contains(","))
                    e.Handled = true;
                if (Srok.Text == "")
                    e.Handled = true;
                return;
            }
            if (e.KeyChar == '-' && Srok.Text == "")
                return;
            if (e.KeyChar == 8)
                return;
            if (e.KeyChar == 27)
            {
                Srok.Text = "0";
                return;
            }
            e.Handled = true;
        }

        private void Vznos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                return;
            if (e.KeyChar == '.')
                e.KeyChar = ',';
            if (e.KeyChar == ',')
            {
                if (Vznos.Text.Contains(","))
                    e.Handled = true;
                if (Vznos.Text == "")
                    e.Handled = true;
                return;
            }
            if (e.KeyChar == '-' && Vznos   .Text == "")
                return;
            if (e.KeyChar == 8)
                return;
            if (e.KeyChar == 27)
            {
                Vznos.Text = "0";
                return;
            }
            e.Handled = true;
        }

        private void Raschet_Click(object sender, EventArgs e)
        {
            StreamWriter ghg = new StreamWriter("./text.txt");
            double Cen = Convert.ToDouble(Cena.Text);
            string text_1, Text_2, Text_3, Text_4, Text_5, Text_6, Text_7, Text_8;
            text_1 = "Сумма ипотеки с первоначальным взносом: " + Convert.ToString(Cen);
            double St = Convert.ToDouble(GodProc.Text);
            Text_2 = "Процентная ставка: " + Convert.ToString(St);
            int Sroc = Convert.ToInt32(Srok.Text);
            Text_3 = "Срок платежа: " + Convert.ToString(Sroc);
            double Pv = Convert.ToDouble(Vznos.Text);
            Text_4 = "Первый взнос: " + Convert.ToString(Pv);
            double SummPv = Cen * Pv / 100;
            RaschetVznosa.Text = Convert.ToString(SummPv);
            double SummIpot = Cen - SummPv;
            Text_5 = "Сумма ипотеки без первоночального взноса" + Convert.ToString(SummIpot);
            SummaIpoteki.Text = Convert.ToString(SummIpot);
            DateTime today = DateTime.Today;
            //int year = today.Year;
            //int month = today.Month;
            //int days = System.DateTime.DaysInMonth(year, month);
            label13.Text += today.ToString("dd/MM/yyyy");
            label14.Text += today.AddMonths(Sroc).ToString("dd/MM/yyyy");
            Text_7 = "Дата начала платежа: " + Convert.ToString(today);
            Text_8 = "Дата окончания платежа: " + Convert.ToString(today.AddMonths(Sroc));

            // Аннуитетная схема

            double MesProc = ((St / 12) / 100);
            double KofAn = (MesProc * Math.Pow((MesProc + 1), Sroc)) / (Math.Pow((MesProc + 1), Sroc) - 1);
            double MesPlat = KofAn * SummIpot;
            Text_6 = "Сумма аннуитетного платежа: " + Convert.ToString(MesPlat);
            double OpOsnDolg;
            double GodSt = (St / 100);
            //bool ves = DateTime.IsLeapYear(year);
            double DG;
            double Proc;
            double OstOsDolg = SummIpot;
            double SummProc = 0, SummOpOsDolg = 0;
            ghg.WriteLine(text_1 + "\n" + Text_2 + "\n" + Text_3 + "\n" + Text_4 + "\n" + Text_5 + "\n" + Text_6 + "\n" + Text_7 + "\n" + Text_8 + "\n");
            ghg.WriteLine("Период     |" + "  Месячная плата     |" + "  Оплата основного долга     |" + "  Оплата % банку     |" + "  Остаток основного долга     |");
            int D;

            for (int i = 1; i <= Sroc; i++)
            {
                int year = today.Year;
                int month = today.Month;
                int days = System.DateTime.DaysInMonth(year, month);
                bool ves = DateTime.IsLeapYear(year);

                //D = DateTime.Compare(today.AddMonths(1), today);
                //year = today.Year;
                ves = DateTime.IsLeapYear(year);
                if (ves == true)
                {
                    DG = 366;
                }
                else
                {
                    DG = 365;
                }
                //Proc = (SummIpot * GodSt * days) / DG;
                Proc = (OstOsDolg * GodSt * days) / DG;
                SummProc += Proc;
                OpOsnDolg = MesPlat - Proc;
                SummOpOsDolg += OpOsnDolg;
                OstOsDolg = OstOsDolg - OpOsnDolg;
                today = today.AddMonths(1);
                ghg.WriteLine(Convert.ToString(i) + " - " + Convert.ToString(days) + "     |" + Convert.ToString(MesPlat) + "     |" + Convert.ToString(OpOsnDolg) + "     |" + Convert.ToString(Proc) + "     |" + Convert.ToString(OstOsDolg));
            }

            double SummMesPlat = MesPlat * Sroc;
            SummaBanku_1.Text = Convert.ToString(SummMesPlat);
            Itog_1.Text = Convert.ToString(SummOpOsDolg);
            Pereplata_1.Text = Convert.ToString(SummProc);
            int L;

            //Диффернцированная схема

            double B, p, Sn, V, SummP = 0, SummB = 0, SummV = 0;
            for (int n = 1; n <= Sroc; n++)
            {
                L = DateTime.Compare(today.AddMonths(1), today);
                B = SummIpot / Sroc;
                SummB += B;
                Sn = SummIpot - (B * n);
                p = Sn * (MesProc);
                SummP += p;
                V = B + p;
                SummV += V;
                ghg.WriteLine(Convert.ToString(n) + " - " + Convert.ToString(L) + "     |" + Convert.ToString(V) + "     |" + Convert.ToString(B) + "     |" + Convert.ToString(p) + "     |" + Convert.ToString(Sn));
            }
            SummaBanku_2.Text = Convert.ToString(SummV);
            Itog_2.Text = Convert.ToString(SummB);
            Pereplata_2.Text = Convert.ToString(SummP);

            //Итоги 
            if (SummV > SummMesPlat)
            {
                Raznica.Text = "Аннуитетная схема выгоднее на: " + Convert.ToString(SummV - SummMesPlat);
            }
            if (SummV < SummMesPlat)
            {
                Raznica.Text = "Дифференцированная схема выгоднее на: " + Convert.ToString(SummMesPlat - SummV);
            }
            if (SummV == SummMesPlat)
            {
                Raznica.Text = "Схемы одиннаковые";
            }

            ghg.Close();
        }
    }
}
