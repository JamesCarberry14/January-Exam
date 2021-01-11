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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //adding 4 objects
            CurrentAccount CA1 = new CurrentAccount("Linda", "Gallagher", 20000, new DateTime(11/1/2020));
            CurrentAccount CA2 = new CurrentAccount("Katrina", "Walsh", 25000, new DateTime(18/11/2020));

            SavingsAccount SA1 = new SavingsAccount("Desmond","Jackson", 32000, new DateTime(15/3/2020));
            SavingsAccount SA2 = new SavingsAccount("John", "Smith", 22000, new DateTime(21/4/2020));

            //adding objects to list
            Accounts.Add(CA1);
            Accounts.Add(CA2);

            Accounts.Add(SA1);
            Accounts.Add(SA2);

            //adding list as item source for listbox
            AccountList_lbx.ItemsSource = Accounts;

        }

        private void AccountList_lbx_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //this method determines which item is selected and prints the details to the textboxes

            Account selectedItem = AccountList_lbx.SelectedItem as Account;

            if (selectedItem != null)
            {
                DisplayFName_tblk.Text = selectedItem.firstname;
                DisplayLName_tblk.Text = selectedItem.lastname;
                DisplayBalance_tblk.Text = selectedItem.balance.ToString();


                if (selectedItem is CurrentAccount)
                {
                    DisplayACType_tblk.Text = "Current Account";
                    DisplayInterest_tblk.Text = "3%";
                }

                if (selectedItem is SavingsAccount)
                {
                    DisplayACType_tblk.Text = "Savings Account";
                    DisplayInterest_tblk.Text = "6%";
                }

            }
        }

        private void Deposit_btn_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void Withdraw_btn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
