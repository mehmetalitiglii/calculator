using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesap_makinası
{
    public partial class Form1 : Form
    {
        char _process;
        bool _clean_screen;
         int _first_number;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (_clean_screen) 
            {

                txtbox.Text = "";
                _clean_screen = false;
            }


            if (_clean_screen)
            {

                txtbox.Text = "";
                _clean_screen = false;
            }

            txtbox.Text += "1";

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (_clean_screen)
            {

                txtbox.Text = "";
                _clean_screen = false;
            }
            if (txtbox.Text == "0") txtbox.Text = "";

            txtbox.Text += "2";
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (_clean_screen)
            {

                txtbox.Text = "";
                _clean_screen = false;
            }
            if (txtbox.Text == "0") txtbox.Text = "";

            txtbox.Text += "3";
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (_clean_screen)
            {

                txtbox.Text = "";
                _clean_screen = false;
            }
            if (txtbox.Text == "0") txtbox.Text = "";

            txtbox.Text += "4";
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (_clean_screen)
            {

                txtbox.Text = "";
                _clean_screen = false;
            }
            if (txtbox.Text == "0") txtbox.Text = "";

            txtbox.Text += "5";
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (_clean_screen)
            {

                txtbox.Text = "";
                _clean_screen = false;
            }
            if (txtbox.Text == "0") txtbox.Text = "";

            txtbox.Text += "6";
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (_clean_screen)
            {

                txtbox.Text = "";
                _clean_screen = false;
            }
            if (txtbox.Text == "0") txtbox.Text = "";

            txtbox.Text += "7";
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (_clean_screen)
            {

                txtbox.Text = "";
                _clean_screen = false;
            }
            if (txtbox.Text == "0") txtbox.Text = "";

            txtbox.Text += "8";
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (_clean_screen)
            {

                txtbox.Text = "";
                _clean_screen = false;
            }
            if (txtbox.Text == "0") txtbox.Text = "";

            txtbox.Text += "9";
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (_clean_screen)
            {

                txtbox.Text = "";
                _clean_screen = false;
            }
            if (txtbox.Text == "0") txtbox.Text = "";

            txtbox.Text += "0";
        }

        private void btn_C_Click(object sender, EventArgs e)
        {
            txtbox.Text = txtbox.Text.Substring(0 , txtbox.Text.Length - 1).ToString();
            if (txtbox.Text == "") txtbox.Text = "0";
        }

        
        private void btn_plus_Click(object sender, EventArgs e)
        {
            _process = '+';
            _clean_screen= true;
            _first_number = Convert.ToInt32(txtbox.Text);
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            int _second_number  = Convert.ToInt32(txtbox.Text);
            int result;

            switch (_process)
            {
                case '+':
                    result = _first_number + _second_number;
                    break;

                case '-':
                    result = _first_number - _second_number;
                    break;

                case '*':
                    result = _first_number * _second_number;
                    break;

                case '/':
                    result = _first_number / _second_number;
                    break;

                default:
                    result = 0;
                    break;  

            }
            txtbox.Text = Convert.ToString(result);
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            _process = '-';
            _clean_screen = true;
            _first_number = Convert.ToInt32(txtbox.Text);
        }

        private void btn_times_Click(object sender, EventArgs e)
        {
            _process = '*';
            _clean_screen = true;
            _first_number = Convert.ToInt32(txtbox.Text);
        }

        private void btn_divided_Click(object sender, EventArgs e)
        {
            _process = '/';
            _clean_screen = true;
            _first_number = Convert.ToInt32(txtbox.Text);
        }
    }
}
