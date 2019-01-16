using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace Taschenrechner.UserControls
{
    /// <summary>
    /// Interaktionslogik für ResultView.xaml
    /// </summary>
    public partial class ResultView : UserControl, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string result;
        public double Result
        {
            get
            {
                if (double.IsNaN(Convert.ToDouble(result)))
                {
                    MessageBox.Show("Calculation returned in an error");
                    Clear();
                }
                return Convert.ToDouble(result);
            }
            set => result = value.ToString();
        }

        public string addToResult
        {
            set
            {
                if (result == null)
                    result += "0.";
                else
                    result += ".";
            }
        }
        public ResultView()
        {
            InitializeComponent();
        }

        public void AddNumber(double number)
        {
            if (result?.Last() != '.')
                Result = Convert.ToDouble(Result.ToString() + number.ToString());
            else
                Result += number / 10;
        }

        public void Clear()
        {
            Result = 0;
        }
    }
}
