using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] NumArray = {" ","one","two","three","four","five","six","seven","eight","nine", //0-9
                                "ten","eleven","twelve","thirteen","fourteen","fifteen","sixteen","seventeen","eighteen","nineteen", //11-19
                                "twenty","thirty","forty","fifty","sixty","seventy","eighty","ninty","hundred"}; //20-30-40...-90

        public static string NumberToWords(int number)
        {
            if (number == 0)
                return "zero";

            if (number < 0)
                return "minus " + NumberToWords(Math.Abs(number));

            string words = "";

            if ((number / 1000000) > 0)
            {
                words += NumberToWords(number / 1000000) + " million ";
                number %= 1000000;
            }

            if ((number / 1000) > 0)
            {
                words += NumberToWords(number / 1000) + " thousand ";
                number %= 1000;
            }

            if ((number / 100) > 0)
            {
                words += NumberToWords(number / 100) + " hundred ";
                number %= 100;
            }

            if (number > 0)
            {
                if (words != "")
                    words += "and ";

                var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
                var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

                if (number < 20)
                    words += unitsMap[number];
                else
                {
                    words += tensMap[number / 10];
                    if ((number % 10) > 0)
                        words += "-" + unitsMap[number % 10];
                }
            }

            return words;
        }
        
        
        private void numBox_TextChanged(object sender, EventArgs e)
        {

#region previous code
            string strNumber = numBox.Text.ToString(); //Number as a string
            int intNumber = 0;                         //Number as an integer

            if (strNumber.Length > 0) //Convert strNumber to int if there is a number
                intNumber = Convert.ToInt32(numBox.Text.ToString());


            else if (strNumber.Length == 0) //No number entered or number deleted.
                numLabel.Text = "Enter a number.";


            numLabel.Text = NumberToWords(intNumber);

            //if (strNumber.Length <= 6 && strNumber.Length > 0) // Number length between 1-6
            //{
            //    int sixthPlace = intNumber / 100000;            //_xx xxx
            //    int fifthPlace = (intNumber % 100000) / 10000;  //x_x xxx
            //    int fourthPlace = (intNumber % 10000) / 1000;   //xx_ xxx
            //    int thirdPlace = (intNumber % 1000) / 100;      //xxx _xx
            //    int secondPlace = (intNumber % 100) / 10;       //xxx x_x
            //    int firstPlace = intNumber % 10;                //xxx xx_


            //    if (intNumber >= 0 && intNumber <= 20)                  // 0-20
            //        numLabel.Text = NumArray[intNumber];

            //    else if (intNumber >= 21 && intNumber <= 99)            // 21-99
            //        numLabel.Text = NumArray[secondPlace + 18] + " " + NumArray[firstPlace];

            //    else if (intNumber >= 100 && intNumber <= 999)          // 100 - 999
            //    {
            //        if (secondPlace == 0 ) //100-109/200-209/300-309.../900-909
            //            numLabel.Text = NumArray[thirdPlace] + " hundred " + NumArray[firstPlace];

            //        else if (secondPlace == 1)//110-119/210-219.../910-919
            //            numLabel.Text = NumArray[thirdPlace] + " hundred " + NumArray[firstPlace + 10];

            //        else if (secondPlace >= 2)   //120-199/220-299/320-399.../920-999
            //            numLabel.Text = NumArray[thirdPlace] + " hundred " + NumArray[secondPlace + 18] + " " + NumArray[firstPlace % 10];

            //    }

            //    else if (intNumber >= 1000 && intNumber <=9999)          //1000-9999
            //    {
            //        numLabel.Text = NumArray[fourthPlace] + " thousand"+ NumArray[thirdPlace] + " hundred " + NumArray[secondPlace + 18] + " " + NumArray[firstPlace % 10];
            //    }
            //}


#endregion
        }


    }
}
