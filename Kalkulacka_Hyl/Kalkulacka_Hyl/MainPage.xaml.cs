using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Data;

namespace Kalkulacka_Hyl
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Button_Click(object sender, EventArgs args)
        {
            Button btn = (Button)sender;
            Console.WriteLine(btn.Text);

            if(btn.Text == "C")
            {
                Label_Equation.Text = "";
            }
            else if (btn.Text == "=")
            {
                Label_Result.Text = new DataTable().Compute(Label_Equation.Text, null).ToString();
            }
            else if (btn.Text == "B" && Label_Equation.Text.Length > 0)
            {
                Label_Equation.Text = Label_Equation.Text.Remove(Label_Equation.Text.Length - 1);
            }
            else
            {
                if ("/*-+".Contains(btn.Text) && !Label_Equation.Text.EndsWith(btn.Text))
                {
                    Label_Equation.Text += btn.Text;
                }
                else if ("0123456789".Contains(btn.Text))
                {
                    Label_Equation.Text += btn.Text;
                }
                
            }
        }
    }
}
