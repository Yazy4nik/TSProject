using System;
using System.Windows;
using StockSharp.Quik;

namespace TradeStudio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            QuikTrader q = new QuikTrader(QuikTerminal.GetDefaultPath());
            q.Connect();
        }
    }
}
