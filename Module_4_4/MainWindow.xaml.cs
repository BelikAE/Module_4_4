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

namespace Module_4_4
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double _rateDollar = Convert.ToDouble(rateDollar.Text);
            double _sumDollar = Convert.ToDouble(sumDollar.Text);
            double _result = _rateDollar * _sumDollar;
            resSumDollar.Text = _result.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double _rateEuro = Convert.ToDouble(rateEuro.Text);
            double _sumEuro = Convert.ToDouble(sumEuro.Text);
            double _result = _rateEuro * _sumEuro;
            resSumEuro.Text = _result.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            
            double _rateHryvnia = Convert.ToDouble(rateHryvnia.Text);
            double _sumHryvnia = Convert.ToDouble(sumHryvnia.Text);
            double _result = _rateHryvnia * _sumHryvnia;
            resSumHryvnia.Text = _result.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double _rateDram = Convert.ToDouble(rateDram.Text);
            double _sumDram = Convert.ToDouble(sumDram.Text);
            double _result = _rateDram * _sumDram;
            resSumDram.Text = _result.ToString();
        }
        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double _inches = Convert.ToDouble(inches.Text);
            resInches.Text = (_inches* 0.0254).ToString();
        }
        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double _feet = Convert.ToDouble(feet.Text);
            resFeet.Text = (_feet * 0.3048).ToString();
        }
        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double _miles = Convert.ToDouble(miles.Text);
            resMiles.Text = (_miles * 1609.34).ToString();
        }
        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double _verst = Convert.ToDouble(verst.Text);
            resVerst.Text = (_verst * 1066.8).ToString();
        }
    }
}
