using System;
using System.Windows;


namespace MyFirstWPFApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window 
    {
        private double _bankAccount = 0; // банковский счёт

        // принимаем средсва
        private void InitialMoney(object sender, RoutedEventArgs e)
        {
            try
            {
                double inputData = Convert.ToDouble(bankAccountTextBox.Text);

                if (inputData <= 0)
                {
                    MessageBox.Show("Вносимая сумма не может быть отрицательной или равной нулю");
                }
                else
                {
                    _bankAccount += inputData;

                    MessageBox.Show(
                        $" Операция проведена успешно." +
                        $"\n Внесено: {inputData}" +
                        $"\n На счету: {_bankAccount.ToString()}");
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введены недопустимые символы, повторите ввод");
            }
        }

        // снимаем средства
        private void WithdrawMoney(object sender, RoutedEventArgs e) 
        {
            try
            {
                double inputData = Convert.ToDouble(bankAccountTextBox.Text);

                if (inputData <= 0)
                {
                    MessageBox.Show("Вносимая сумма не может быть отрицательной или равной нулю");
                }
                else
                {
                    if (_bankAccount >= inputData)
                    {
                        _bankAccount -= inputData;

                        MessageBox.Show(
                        $" Операция проведена успешно." +
                        $"\n Снято: {inputData}" +
                        $"\n На счету: {_bankAccount.ToString()}");
                    }
                    else
                    {
                        MessageBox.Show(
                            $" На счету недостаточно средств" +
                            $"\n На счету: {_bankAccount.ToString()}");
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Введены недопустимые символы, повторите ввод");
            }
        }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
