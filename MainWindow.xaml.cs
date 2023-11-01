using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Caffeine_Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.ResizeMode = ResizeMode.NoResize;
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (double.TryParse(caffeine100ml.Text, out double number1) && double.TryParse(cupml.Text, out double number2))
            {
                double caffeinePer100 = number1/100;
                double caffeineInWholeCup = caffeinePer100 * number2;
                total.Text = $"{Math.Round(caffeineInWholeCup, 2)} mg";
            }
            else
            {
                total.Text = "0 mg";
            }
        }

    }
}
