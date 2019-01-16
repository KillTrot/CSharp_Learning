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

namespace Taschenrechner
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _firstNumber { get; set; } = 0;
        private double _secondNumber { get; set; } = 0;
        private enum latestActionEnum { division, multiplication, minus, plus};
        private latestActionEnum latestAction { get; set; } 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            int number;
            if (int.TryParse(button.Content.ToString(), out number))
            {
                resultView.AddNumber(number);
            }
            else
            {
                switch(button.Tag.ToString())
                {
                    case "squareRoot":
                        {
                            resultView.Result = Math.Sqrt(resultView.Result);
                            break;
                        }
                    case "pow":
                        {
                            resultView.Result = Math.Pow(resultView.Result, 2);
                            break;
                        }
                    case "negation":
                        {
                            resultView.Result *= -1;
                            break;
                        }
                    case "clearAll":
                        {
                            _firstNumber = 0;
                            _secondNumber = 0;
                            resultView.Clear();
                            break;
                        }
                    case "division":
                        {
                            if (_firstNumber == 0)
                            {
                                _firstNumber = resultView.Result;
                                resultView.Result = 0;
                            }
                            else
                            {
                                _secondNumber = resultView.Result;
                                runLatestAction();
                                _firstNumber = resultView.Result;
                                resultView.Result = 0;
                                _secondNumber = 0;
                            }
                            latestAction = latestActionEnum.division;
                            break;
                        }
                    case "multiplication":
                        {
                            if (_firstNumber == 0)
                            {
                                _firstNumber = resultView.Result;
                                resultView.Result = 0;
                            }
                            else
                            {
                                _secondNumber = resultView.Result;
                                runLatestAction();
                                _firstNumber = resultView.Result;
                                resultView.Result = 0;
                                _secondNumber = 0;
                            }
                            latestAction = latestActionEnum.multiplication;
                            break;
                        }
                    case "minus":
                        {
                            if (_firstNumber == 0)
                            {
                                _firstNumber = resultView.Result;
                                resultView.Result = 0;
                            }
                            else
                            {
                                _secondNumber = resultView.Result;
                                runLatestAction();
                                _firstNumber = resultView.Result;
                                resultView.Result = 0;
                                _secondNumber = 0;
                            }
                            latestAction = latestActionEnum.minus;
                            break;
                        }
                    case "plus":
                        {
                            if (_firstNumber == 0)
                            {
                                _firstNumber = resultView.Result;
                                resultView.Result = 0;
                            }
                            else
                            {
                                _secondNumber = resultView.Result;
                                runLatestAction();
                                _firstNumber = resultView.Result;
                                resultView.Result = 0;
                                _secondNumber = 0;
                            }
                            latestAction = latestActionEnum.plus;
                            break;
                        }
                    case "equals":
                        {
                            _secondNumber = resultView.Result;
                            runLatestAction(true);
                            break;
                        }
                    case "point":
                        {
                            if (resultView.Result.ToString().Contains(".") == false)
                            {
                                resultView.addToResult = "";
                            }
                                
                            break;
                        }
                }
            }
        }

        void runLatestAction(bool clear = false)
        {
            switch (latestAction)
            {
                case latestActionEnum.minus:
                    {
                        resultView.Result = _firstNumber - _secondNumber;
                        break;
                    }
                case latestActionEnum.plus:
                    {
                        resultView.Result = _firstNumber + _secondNumber;
                        break;
                    }
                case latestActionEnum.division:
                    {
                        resultView.Result = _firstNumber / _secondNumber;
                        break;
                    }
                case latestActionEnum.multiplication:
                    {
                        resultView.Result = _firstNumber * _secondNumber;
                        break;
                    }
            }
            if (clear)
            {
                _firstNumber = 0;
                _secondNumber = 0;
            }
            else
            {
                _firstNumber = resultView.Result;
                _secondNumber = 0;
            }
        }
    }
}
