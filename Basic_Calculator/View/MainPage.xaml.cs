using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Basic_Calculator
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            UpdateDisplay = new Command(btn_Zero);
            BindingContext = this;
        }

        public ICommand UpdateDisplay;
        int Display;

        private string calcDisplay;

        public string CalcDisplay
        {
            get => calcDisplay;

            set
            {
                if (value == calcDisplay)
                    return;

                calcDisplay += value;
                OnPropertyChanged(nameof(CalcDisplay));
            }
        }

        void btn_Zero()
        {
            CalcDisplay = "0";
        }

        void btn_dblZero()
        {
            CalcDisplay = "00";
        }

        void btn_Comma()
        {
            CalcDisplay = ",";
        }

        void btn_One()
        {
            CalcDisplay = "1";
        }

        void btn_Two()
        {
            CalcDisplay = "2";
        }

        void btn_Three()
        {
            CalcDisplay = "3";
        }

        void btn_Four()
        {
            CalcDisplay = "4";
        }

        void btn_Five()
        {
            CalcDisplay = "5";
        }

        void btn_Six()
        {
            CalcDisplay = "6";
        }

        void btn_Seven()
        {
            CalcDisplay = "7";
        }

        void btn_Eight()
        {
            CalcDisplay = "8";
        }

        void btn_Nine()
        {
            CalcDisplay = "9";
        }

        void btn_Equals()
        {
            CalcDisplay = "=";
        }

        void btn_Add()
        {
            CalcDisplay = "+";
        }

        void btn_Subtract()
        {
            CalcDisplay = "-";
        }

        void btn_Multiply()
        {
            CalcDisplay = "×";
        }

        void btn_Divide()
        {
            CalcDisplay = "÷";
        }

        void btn_Clear()
        {
            CalcDisplay = "";
        }

        void btn_Erase()
        {
            CalcDisplay = "";
        }

        void btn_Percentage()
        {
            CalcDisplay = "";
        }
    }
}
