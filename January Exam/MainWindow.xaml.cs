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

namespace January_Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //global variables

        List<Account> Accounts = new List<Account>();



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded()
        {

            CurrentAccount CA1 = new CurrentAccount("Linda", "Gallagher", 20000, 11/1/2021);
            CurrentAccount CA2 = new CurrentAccount("Katrina", "Walsh", 25000, 11/1/2021);

            SavingsAccount SA1 = new SavingsAccount("Desmond","Jackson", 32000, 11/1/2021);
            SavingsAccount SA2 = new SavingsAccount("John", "Smith", 22000, 11/1/2021);


            Accounts.Add(CA1);
            Accounts.Add(CA2);

            Accounts.Add(SA1);
            Accounts.Add(SA2);

            AccountList_lbx.ItemsSource = Accounts;

        }
    }
}
