using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JH_CST117_InClassAssignment3
{
    public partial class YourWeightOnMars : Form
    {
        public YourWeightOnMars()
        {
            InitializeComponent();
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            //define global vars
            double earthWeight = 0.00;
            double earthMass = 0.00;
            double earthGraviationalConstant = 9.80;
            double marsGraviationalConstant = 3.724;

            try{
                //read in earth weight
                earthWeight = Convert.ToDouble(txtEarthWeight.Text);

                //calculate the mass on earth from the earth weight
                earthMass = earthWeight / earthGraviationalConstant;
                //Console.WriteLine(earthMass); //debug print earthMass to the console

                //find weight on Mars
                double marsWeight = marsGraviationalConstant * earthMass; //do calc to get mars weight from earth mass
                String marsWeightString = marsWeight.ToString(); //convert mars weight double to string
                //Console.WriteLine(marsWeight); //debug print the marsWeight to the console

                txtMarsWeight.Text = String.Format("{0:#,0.000}", marsWeight); //write mars weight to textbox txtMarsWeight
                //String.format used to make output to 3 decimal places

            }
            //check to make sure we get the right format and dont crash the program
            catch (FormatException exp)
            {
                Console.WriteLine("ERROR: User must enter an integer value");
                txtEarthWeight.Text = "ERR";
                txtMarsWeight.Text = "Error: Integer required";
            }
            finally
            {
                Console.WriteLine("Run completed");
            }

            //-----------------------
            //Didn't feel like mkaing an entire new project for the string formatting examples below
            //done in class 09/28/2020
            //Console.WriteLine("This is my mars weight: " + string.Format("{0:#,0.000}", marsWeight)); //# used to automatically put commas
            //Console.WriteLine(marsWeight.ToString("#,0.000"));
            //Console.WriteLine("Your bank balance is: {0:C2} or {1:0.000}", marsWeight, marsWeight); //c2 automatically formats for currency
            //-----------------------
        }
    }
}
