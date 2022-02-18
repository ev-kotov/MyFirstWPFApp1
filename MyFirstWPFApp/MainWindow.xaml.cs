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

namespace MyFirstWPFApp
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

        private void AddMoneyToAccount(object sender, RoutedEventArgs e)
        {
            try
            {
                // принимаем средсва
                double bankAccount = Convert.ToDouble(bankAccountTextBox.Text);

                if (bankAccount <= 0)
                {
                    MessageBox.Show("Вносимая сумма не может быть меньшей или равной нулю");
                }
                else
                {
                    MessageBox.Show(
                        $" Операция проведена успешно." +
                        $"\n На счету: {bankAccount.ToString()}");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введены недопустимые символы, повторите ввод");
            }
        }
    }
    //class Account
    //{
    //    public delegate void AccountHandler(string message);
    //    public event AccountHandler? Notify;

    //    // 1.Определение события
    //    public Account(int sum) => Sum = sum;
    //    public int Sum { get; private set; }

        
    //    public void Put(int sum) // Вызов события
    //    {
    //        Sum += sum;
    //        Notify?.Invoke($"На счет поступило: {sum}");
    //    }

    //    public void Take(int sum) // Вызов события
    //    {
    //        if (Sum >= sum)
    //        {
    //            Sum -= sum;
    //            Notify?.Invoke($"Со счета снято: {sum}");
    //        }
    //        else
    //        {
    //            Notify?.Invoke($"Недостаточно денег на счете. Текущий баланс: {Sum}"); ;
    //        }
    //    }
    //}
}
