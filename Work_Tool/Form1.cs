using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using productivity;
using electricityBonus;
using bonusGas;
using gasAndElectrycityEstimation;

namespace Work_Tool
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "480";
            textBox11.Text = "0";
            textBox12.Text = "0";
            label14.Text = "0 %";
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            label23.Text = "0 %";
            label24.Text = "0 %";
            textBox19.Text = "0";
            textBox20.Text = "0";
            textBox21.Text = "0";
            textBox22.Text = "0";
            label34.Text = "0";
            textBox17.Text = "0";
            textBox18.Text = "0";
            label35.Text = "0";
            label38.Text = "0";
            label39.Text = "0";
            textBox24.Text = "0";
            textBox23.Text = "0";
            label45.Text = "0";
            label46.Text = "0";
            label47.Text = "date unavaible";
            textBox27.Text = "0";
            textBox26.Text = "0";
            textBox25.Text = "0";
            textBox33.Text = "0";
            textBox34.Text = "0";
            textBox31.Text = "0";
            textBox29.Text = "0";
            textBox30.Text = "0";
            textBox35.Text = "0";
            textBox28.Text = "480";
            textBox36.Text = "0";
            textBox32.Text = "0";
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int billCorrection = Int32.Parse(textBox1.Text);
                int billCreation = Int32.Parse(textBox2.Text);
                int monthlyPayment = Int32.Parse(textBox3.Text);
                int contract = Int32.Parse(textBox4.Text);
                int meterReading = Int32.Parse(textBox5.Text);
                int bonus = Int32.Parse(textBox6.Text);
                int paymentCirculation = Int32.Parse(textBox7.Text);
                int collection = Int32.Parse(textBox8.Text);
                int billPlausibility = Int32.Parse(textBox9.Text);
                int workedTime = Int32.Parse(textBox10.Text);
                int other = Int32.Parse(textBox11.Text);
                int masterData = Int32.Parse(textBox12.Text);

                Productivity prod = new Productivity(billCorrection, billCreation, contract, meterReading, bonus, paymentCirculation, collection, monthlyPayment, billPlausibility, other, workedTime, masterData);

                label14.Text = (prod.productivity()).ToString() + " %";

            }
            catch (FormatException)
            {
                MessageBox.Show("You must enter a number for each case type! Please try again!");
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            textBox4.Text = "0";
            textBox4.Text = "0";
            textBox5.Text = "0";
            textBox6.Text = "0";
            textBox7.Text = "0";
            textBox8.Text = "0";
            textBox9.Text = "0";
            textBox10.Text = "480";
            textBox11.Text = "0";
            textBox12.Text = "0";
            label14.Text = "0 %";
        }
        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox13.Text = "0";
            textBox14.Text = "0";
            textBox15.Text = "0";
            textBox16.Text = "0";
            label23.Text = "0 %";
            label24.Text = "0 %";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                double workingPrice = Double.Parse(textBox13.Text);
                double basicPrice = Double.Parse(textBox14.Text);
                double reading1 = Double.Parse(textBox15.Text);
                double reading2 = Double.Parse(textBox16.Text);

                ElectricityBonus bonus = new ElectricityBonus(workingPrice, basicPrice, reading1, reading2);

                label23.Text = String.Format("{0:0.00}", (bonus.bonus15Percent())) + " Euro";
                label24.Text = String.Format("{0:0.00}", (bonus.bonus25Percent())) + " Euro";

            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter only numbers!!!");
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        List<double> partialConsumption = new List<double>();
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double reading1 = Double.Parse(textBox19.Text);
                double reading2 = Double.Parse(textBox20.Text);
                double elevationConstant = Double.Parse(textBox21.Text);
                double burningConstamt = Double.Parse(textBox22.Text);

                BonusGas gas = new BonusGas(reading1, reading2, elevationConstant, burningConstamt);

                partialConsumption.Add(gas.periodConsumption());

                label34.Text = String.Format("{0:0.00}", (gas.periodConsumption()));
                label35.Text = String.Format("{0:0.00}", (partialConsumption.Sum()));

                textBox19.Text = "0";
                textBox20.Text = "0";
                textBox21.Text = "0";
                textBox22.Text = "0";

            }
            catch(FormatException)
            {
                MessageBox.Show("You must always enter numbers! Please try again!");
            }
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label35_Click(object sender, EventArgs e)
        {
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double workingPrice = Double.Parse(textBox17.Text);
            double basicPrice = Double.Parse(textBox18.Text);
            
            label38.Text = String.Format("{0:0.00}", (((((partialConsumption.Sum()) * workingPrice) + basicPrice * 12) * 15) / 100)) + " Euro";
            label39.Text = String.Format("{0:0.00}", (((((partialConsumption.Sum()) * workingPrice) + basicPrice * 12) * 25) / 100)) + " Euro";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox19.Text = "0";
            textBox20.Text = "0";
            textBox21.Text = "0";
            textBox22.Text = "0";
            label34.Text = "0";
            textBox17.Text = "0";
            textBox18.Text = "0";
            label35.Text = "0";
            label38.Text = "0";
            label39.Text = "0";
            partialConsumption.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                double reading1 = Double.Parse(textBox24.Text);
                double reading2 = Double.Parse(textBox23.Text);
                double estimatedReading;
                

                DateTime date1 = DateTime.Parse(dateTimePicker1.Text);
                DateTime date2 = DateTime.Parse(dateTimePicker2.Text);
                DateTime dateEstimation = DateTime.Parse(dateTimePicker3.Text);

                Estimation estimare = new Estimation(reading1, reading2, date1, date2, dateEstimation);

                estimare.averageDayConsumption();
                estimare.averageDayConsumptionAtReset();
                estimare.dateReset();

                if (estimare.averageDayConsumption() < 0)  // if a meter reset exists and it resets at value 99999
                {
                    if (((estimare.dateReset() - dateEstimation).TotalDays) < ((dateEstimation - date1).TotalDays))   // estimate date after meter reset date
                    {
                        estimatedReading = 99999 - (estimare.dateReset() - dateEstimation).TotalDays * estimare.averageDayConsumptionAtReset();

                        if (estimatedReading > 99999)
                        {
                            label45.Text = (estimatedReading - 99999).ToString();
                            label46.Text = (estimare.averageDayConsumptionAtReset() * 365).ToString();
                            label47.Text = estimare.dateReset().ToShortDateString();
                        }
                        else
                        {
                            label45.Text = String.Format("{0:0.00}", estimatedReading);
                            label46.Text = String.Format("{0:0.00}", (estimare.averageDayConsumptionAtReset() * 365));
                            label47.Text = estimare.dateReset().ToShortDateString();
                        }

                    }
                    else if (((estimare.dateReset() - dateEstimation).TotalDays) > ((dateEstimation - date1).TotalDays)) // estimate date before meter reset
                    {
                        estimatedReading = 99999 - (estimare.dateReset() - dateEstimation).TotalDays * estimare.averageDayConsumptionAtReset();

                        if (estimatedReading > 99999)
                        {
                            label45.Text = String.Format("{0:0.00}",(estimatedReading - 99999));
                            label46.Text = String.Format("{0:0.00}",(estimare.averageDayConsumptionAtReset() * 365));
                            label47.Text = estimare.dateReset().ToShortDateString();
                        }
                        else
                        {
                            label45.Text = String.Format("{0:0.00}", estimatedReading);
                            label46.Text = String.Format("{0:0.00}", (estimare.averageDayConsumptionAtReset() * 365));
                            label47.Text = estimare.dateReset().ToShortDateString();
                        }
                    }

                }
                else  // when there is no meter reset
                {
                    if (((dateEstimation - date2).TotalDays) < ((dateEstimation - date1).TotalDays))
                    {
                        estimatedReading = reading2 + ((dateEstimation - date2).TotalDays) * estimare.averageDayConsumption();
                        label45.Text = String.Format("{0:0.00}", estimatedReading);
                        label46.Text = String.Format("{0:0.00}", (estimare.averageDayConsumption() * 365));

                    }
                    else if (((dateEstimation - date2).TotalDays) > ((dateEstimation - date1).TotalDays))
                    {
                        estimatedReading = reading1 - ((date1 - dateEstimation).TotalDays) * estimare.averageDayConsumption();
                        label45.Text = String.Format("{0:0.00}", estimatedReading);
                        label46.Text = String.Format("{0:0.00}", (estimare.averageDayConsumption() * 365));

                    }
                    else if (((date2 - dateEstimation).TotalDays) < ((dateEstimation - date1).TotalDays))
                    {
                        estimatedReading = reading2 - ((date2 - dateEstimation).TotalDays) * estimare.averageDayConsumption();
                        label45.Text = String.Format("{0:0.00}", estimatedReading);
                        label46.Text = String.Format("{0:0.00}", (estimare.averageDayConsumption() * 365));

                    }
                    else if (((date2 - dateEstimation).TotalDays) > ((dateEstimation - date1).TotalDays))
                    {
                        estimatedReading = reading1 + ((dateEstimation - date1).TotalDays) * estimare.averageDayConsumption();
                        label45.Text = String.Format("{0:0.00}",estimatedReading);
                        label46.Text = String.Format("{0:0.00}", (estimare.averageDayConsumption() * 365));
                    }
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("You must enter numbers only! Please try again!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox24.Text = "0";
            textBox23.Text = "0";
            label45.Text = "0";
            label46.Text = "0";
            label47.Text = "date unavaible";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            try
            {
                int billCorrection = Int32.Parse(textBox27.Text);
                int billCreation = Int32.Parse(textBox26.Text);
                int monthlyPayment = Int32.Parse(textBox25.Text);
                int contract = Int32.Parse(textBox33.Text);
                int meterReading = Int32.Parse(textBox34.Text);
                int bonus = Int32.Parse(textBox31.Text);
                int paymentCirculation = Int32.Parse(textBox29.Text);
                int collection = Int32.Parse(textBox30.Text);
                int billPlausibility = Int32.Parse(textBox35.Text);
                int workedTime = Int32.Parse(textBox28.Text);
                int other = Int32.Parse(textBox36.Text);
                int masterData = Int32.Parse(textBox32.Text);

                Productivity produc = new Productivity(billCorrection, billCreation, contract, meterReading, bonus, paymentCirculation, collection, monthlyPayment, billPlausibility, other, workedTime, masterData);

                if (produc.productivity()>=80)
                {
                    label62.Text = "Minimum productivity met!";
                }
                else
                {
                    double percentLeft = 80 - produc.productivity();
                    double timeLeft = (percentLeft / 100) * 480;

                    textBox27.Text = String.Format("{0:0.0}", timeLeft/7); 
                    textBox26.Text = String.Format("{0:0.0}", timeLeft/4); 
                    textBox25.Text = String.Format("{0:0.0}", timeLeft/2); 
                    textBox33.Text = String.Format("{0:0.0}", timeLeft);
                    textBox34.Text = String.Format("{0:0.0}", timeLeft); 
                    textBox31.Text = String.Format("{0:0.0}", timeLeft/2); 
                    textBox29.Text = String.Format("{0:0.0}", timeLeft); 
                    textBox30.Text = String.Format("{0:0.0}", timeLeft); 
                    textBox35.Text = String.Format("{0:0.0}", timeLeft/5); 
                    textBox36.Text = String.Format("{0:0.0}", timeLeft);
                    textBox32.Text = String.Format("{0:0.0}", timeLeft);
                    label62.Text = "Minimul productivity not met!";
                }


            }catch(FormatException)
            {
                MessageBox.Show("You must enter numbers only!Please try again!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox27.Text = "0";
            textBox26.Text = "0";
            textBox25.Text = "0";
            textBox33.Text = "0";
            textBox34.Text = "0";
            textBox31.Text = "0";
            textBox29.Text = "0";
            textBox30.Text = "0";
            textBox35.Text = "0";
            textBox28.Text = "480";
            textBox36.Text = "0";
            textBox32.Text = "0";
        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

    
}
