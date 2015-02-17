using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hex2float
{
    public partial class Form1 : Form
    {
        private bool singlePrecision;

        public unsafe float uInt32ToSingle(UInt32 value)
        {
            return *(float*)(&value);
        }

        public unsafe double uInt64ToDouble(UInt64 value)
        {
            return *(double*)(&value);
        }

        public unsafe UInt32 singleToUInt32(float value)
        {
            return *(UInt32*)(&value);
        }

        public unsafe UInt64 doubleToUInt64(double value)
        {
            return *(UInt64*)(&value);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void hex2FloatButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(singlePrecision)
                    floatTextBox.Text = uInt32ToSingle(Convert.ToUInt32(hexTextBox.Text, 16)).ToString();
                else
                    floatTextBox.Text = uInt64ToDouble(Convert.ToUInt64(hexTextBox.Text, 16)).ToString();
            }
            catch { floatTextBox.Text = "error"; };
        }

        private void float2HexButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (singlePrecision)
                    hexTextBox.Text = singleToUInt32(Convert.ToSingle(floatTextBox.Text)).ToString("X8");
                else
                    hexTextBox.Text = doubleToUInt64(Convert.ToDouble(floatTextBox.Text)).ToString("X16");
            }
            catch { floatTextBox.Text = "error"; };
        }

        private void epsilonButton_Click(object sender, EventArgs e)
        {
            floatTextBox.Text = (singlePrecision) ? Single.Epsilon.ToString() : Double.Epsilon.ToString();
        }

        private void nanButton_Click(object sender, EventArgs e)
        {
            floatTextBox.Text = (singlePrecision) ? Single.NaN.ToString() : Double.NaN.ToString();
        }

        private void poitiveInfinityButton_Click(object sender, EventArgs e)
        {
            floatTextBox.Text = (singlePrecision) ? Single.PositiveInfinity.ToString() : Double.PositiveInfinity.ToString();
        }

        private void negativeInfinityButton_Click(object sender, EventArgs e)
        {
            floatTextBox.Text = (singlePrecision) ? Single.NegativeInfinity.ToString() : Double.NegativeInfinity.ToString();
        }

        private void minValueButton_Click(object sender, EventArgs e)
        {
            floatTextBox.Text = (singlePrecision) ? Single.MinValue.ToString(): Double.MinValue.ToString();
        }

        private void maxValueButton_Click(object sender, EventArgs e)
        {
            floatTextBox.Text = (singlePrecision) ? Single.MaxValue.ToString() : Double.MaxValue.ToString();
        }

        private void hexToAButton_Click(object sender, EventArgs e)
        {
            hexATextBox.Text = hexTextBox.Text;
            updateAllFromHex();
        }
        private void hexToBButtonClick(object sender, EventArgs e)
        {
            hexBTextBox.Text = hexTextBox.Text;
            updateAllFromHex();
        }

        private void floatToAButton_Click(object sender, EventArgs e)
        {
            floatATextBox.Text = floatTextBox.Text;
            updateAll();
        }

        private void floatToBButton_Click(object sender, EventArgs e)
        {
            floatBTextBox.Text = floatTextBox.Text;
            updateAll();
        }

        private void singlePrecisionButton_CheckedChanged(object sender, EventArgs e)
        {
            singlePrecision = true;
        }

        private void doublePrecisionButton_CheckedChanged(object sender, EventArgs e)
        {
            singlePrecision = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            singlePrecision = true;
        }

        private void updateAll()
        { 
            float singleA, singleB;
            double doubleA, doubleB;
            try
            {
                if (singlePrecision)
                {
                    singleA = Convert.ToSingle(floatATextBox.Text);
                    singleB = Convert.ToSingle(floatBTextBox.Text);

                    hexATextBox.Text = singleToUInt32(singleA).ToString("X8");
                    floatATextBox.Text = singleA.ToString();
                    hexBTextBox.Text = singleToUInt32(singleB).ToString("X8");
                    floatBTextBox.Text = singleB.ToString();
                    eqTextBox.Text = (singleA == singleB).ToString();
                    notEqTextBox.Text = (singleA != singleB).ToString();
                    greatTextBox.Text = (singleA > singleB).ToString();
                    lessTextBox.Text = (singleA < singleB).ToString();
                    hexPlusTextBox.Text = singleToUInt32(singleA + singleB).ToString("X8");
                    floatPlusTextBox.Text = (singleA + singleB).ToString();
                    hexMinusTextBox.Text = singleToUInt32(singleA - singleB).ToString("X8");
                    floatMinusTextBox.Text = (singleA - singleB).ToString();
                    hexMulTextBox.Text = singleToUInt32(singleA * singleB).ToString("X8");
                    floatMulTextBox.Text = (singleA * singleB).ToString();
                    hexDivTextBox.Text = singleToUInt32(singleA / singleB).ToString("X8");
                    floatDivTextBox.Text = (singleA / singleB).ToString();
                }
                else
                {
                    doubleA = Convert.ToDouble(floatATextBox.Text);
                    doubleB = Convert.ToDouble(floatBTextBox.Text);

                    hexATextBox.Text = doubleToUInt64(doubleA).ToString("X16");
                    floatATextBox.Text = doubleA.ToString();
                    hexBTextBox.Text = doubleToUInt64(doubleB).ToString("X16");
                    floatBTextBox.Text = doubleB.ToString();
                    eqTextBox.Text = (doubleA == doubleB).ToString();
                    notEqTextBox.Text = (doubleA != doubleB).ToString();
                    greatTextBox.Text = (doubleA > doubleB).ToString();
                    lessTextBox.Text = (doubleA < doubleB).ToString();
                    hexPlusTextBox.Text = doubleToUInt64(doubleA + doubleB).ToString("X16");
                    floatPlusTextBox.Text = (doubleA + doubleB).ToString();
                    hexMinusTextBox.Text = doubleToUInt64(doubleA - doubleB).ToString("X16");
                    floatMinusTextBox.Text = (doubleA - doubleB).ToString();
                    hexMulTextBox.Text = doubleToUInt64(doubleA * doubleB).ToString("X16");
                    floatMulTextBox.Text = (doubleA * doubleB).ToString();
                    hexDivTextBox.Text = doubleToUInt64(doubleA / doubleB).ToString("X16");
                    floatDivTextBox.Text = (doubleA / doubleB).ToString();
                }
            }
            catch
            {
                hexATextBox.Text = "-";
                floatATextBox.Text = "-";
                floatBTextBox.Text = "-";
                eqTextBox.Text = "-";
                notEqTextBox.Text = "-";
                greatTextBox.Text = "-";
                lessTextBox.Text = "-";
                hexPlusTextBox.Text = "-";
                floatPlusTextBox.Text = "-";
                hexMinusTextBox.Text = "-";
                floatMinusTextBox.Text = "-";
                hexMulTextBox.Text = "-";
                floatMulTextBox.Text = "-";
                hexDivTextBox.Text = "-";
                floatDivTextBox.Text = "-";
            }
        }
    
    private void updateAllFromHex()
        {
            UInt32 singleHexA, singleHexB;
            UInt64 doubleHexA, doubleHexB;
            float singleA, singleB;
            double doubleA, doubleB;
            try
            {
                if (singlePrecision)
                {
                    singleHexA = Convert.ToUInt32(hexATextBox.Text, 16);
                    singleHexB = Convert.ToUInt32(hexBTextBox.Text, 16);
                    singleA = uInt32ToSingle(singleHexA);
                    singleB = uInt32ToSingle(singleHexB);
                    hexATextBox.Text = singleHexA.ToString("X8");
                    floatATextBox.Text = singleA.ToString();
                    hexBTextBox.Text = singleHexB.ToString("X8");
                    floatBTextBox.Text = singleB.ToString();
                    eqTextBox.Text = (singleA == singleB).ToString();
                    notEqTextBox.Text = (singleA != singleB).ToString();
                    greatTextBox.Text = (singleA > singleB).ToString();
                    lessTextBox.Text = (singleA < singleB).ToString();
                    hexPlusTextBox.Text = singleToUInt32(singleA + singleB).ToString("X8");
                    floatPlusTextBox.Text = (singleA + singleB).ToString();
                    hexMinusTextBox.Text = singleToUInt32(singleA - singleB).ToString("X8");
                    floatMinusTextBox.Text = (singleA - singleB).ToString();
                    hexMulTextBox.Text = singleToUInt32(singleA * singleB).ToString("X8");
                    floatMulTextBox.Text = (singleA * singleB).ToString();
                    hexDivTextBox.Text = singleToUInt32(singleA / singleB).ToString("X8");
                    floatDivTextBox.Text = (singleA / singleB).ToString();
                }
                else
                {
                    doubleHexA = Convert.ToUInt64(hexATextBox.Text, 16);
                    doubleHexB = Convert.ToUInt64(hexBTextBox.Text, 16);
                    doubleA = uInt64ToDouble(doubleHexA);
                    doubleB = uInt64ToDouble(doubleHexB);
                    hexATextBox.Text = doubleHexA.ToString("X16");
                    floatATextBox.Text = doubleA.ToString();
                    hexBTextBox.Text = doubleHexB.ToString("X16");
                    floatBTextBox.Text = doubleB.ToString();
                    eqTextBox.Text = (doubleA == doubleB).ToString();
                    notEqTextBox.Text = (doubleA != doubleB).ToString();
                    greatTextBox.Text = (doubleA > doubleB).ToString();
                    lessTextBox.Text = (doubleA < doubleB).ToString();
                    hexPlusTextBox.Text = doubleToUInt64(doubleA + doubleB).ToString("X16");
                    floatPlusTextBox.Text = (doubleA + doubleB).ToString();
                    hexMinusTextBox.Text = doubleToUInt64(doubleA - doubleB).ToString("X16");
                    floatMinusTextBox.Text = (doubleA - doubleB).ToString();
                    hexMulTextBox.Text = doubleToUInt64(doubleA * doubleB).ToString("X16");
                    floatMulTextBox.Text = (doubleA * doubleB).ToString();
                    hexDivTextBox.Text = doubleToUInt64(doubleA / doubleB).ToString("X16");
                    floatDivTextBox.Text = (doubleA / doubleB).ToString();
                }
            }
            catch
            {
                hexATextBox.Text = "-";
                floatATextBox.Text = "-";
                floatBTextBox.Text = "-";
                eqTextBox.Text = "-";
                notEqTextBox.Text = "-";
                greatTextBox.Text = "-";
                lessTextBox.Text = "-";
                hexPlusTextBox.Text = "-";
                floatPlusTextBox.Text = "-";
                hexMinusTextBox.Text = "-";
                floatMinusTextBox.Text = "-";
                hexMulTextBox.Text = "-";
                floatMulTextBox.Text = "-";
                hexDivTextBox.Text = "-";
                floatDivTextBox.Text = "-";
            }
        }
    }
}
