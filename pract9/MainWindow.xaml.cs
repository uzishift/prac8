using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pract9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Поле для хранения пары чисел.
        /// </summary>
        private PairOfNumbers pair;

        /// <summary>
        /// Конструктор класса MainWindow.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Кнопка вывода информации.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Демьяхин Роман ИСП-31\nЗадание: Реализация класса для операций с парами чисел.", "О программе");
        }
        /// <summary>
        /// Кнопка выхода.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Метод для создания пары из введеных чисел.
        /// </summary>
        /// <returns>True, если числа успешно преобразованы в double, иначе False.</returns>
        private bool TryCreatePair()
        {
            if (double.TryParse(Number1TextBox.Text, out double number1) &&
                double.TryParse(Number2TextBox.Text, out double number2))
            {
                pair = new PairOfNumbers(number1, number2);
                return true;
            }

            MessageBox.Show("Пожалуйста, введите корректные числа.", "Ошибка");
            return false;
        }
        /// <summary>
        /// Кнопка умножения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (TryCreatePair())
                ResultTextBlock.Text = $"Сумма: {pair.Add()}";
        }
        /// <summary>
        /// Кнопка вычитания.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSubstract_Click(object sender, RoutedEventArgs e)
        {
            if (TryCreatePair())
                ResultTextBlock.Text = $"Разность: {pair.Subtract()}";
        }
        /// <summary>
        /// Кнопка умножения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMultiply_Click(object sender, RoutedEventArgs e)
        {
            if (TryCreatePair())
                ResultTextBlock.Text = $"Произведение: {pair.Multiply()}";
        }
        /// <summary>
        /// Кнопка деления.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDivide_Click(object sender, RoutedEventArgs e)
        {
            if (TryCreatePair())
            {
                try
                {
                    ResultTextBlock.Text = $"Частное: {pair.Divide()}";
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка");
                }
            }
        }
        /// <summary>
        /// Кнопка сравнения.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCompare_Click(object sender, RoutedEventArgs e)
        {
            if (TryCreatePair() && double.TryParse(DopNumber1TextBox.Text, out double dopNumber1) &&
       double.TryParse(DopNumber2TextBox.Text, out double dopNumber2))
            {
                var dopPair = new PairOfNumbers(dopNumber1, dopNumber2);
                int comparisonResult = pair.CompareTo(dopPair);

                string resultMessage;
                if (comparisonResult > 0)
                {
                    resultMessage = "Первая пара чисел больше второй пары. 😊";
                }
                else if (comparisonResult < 0)
                {
                    resultMessage = "Первая пара чисел меньше второй пары. 😕";
                }
                else
                {
                    resultMessage = "Пары чисел равны. 😃";
                }

                ResultTextBlock.Text = resultMessage;
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числа для дополнительной пары.", "Ошибка");
            }
        }
    }
}