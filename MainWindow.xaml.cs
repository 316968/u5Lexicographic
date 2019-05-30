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

namespace u5Lexicographic
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string final = "";
        public MainWindow()
        {
            InitializeComponent();

            int count = 1000000;
            int p = 0;
            List<int> digit = new List<int>();
            for(int i = 0; i < 10; i++)
            {
                digit.Add(i);
            }
            int r = factorial(9);
            for(int i = 9; i > -1; i--)
            {

                for(int y = 0; y < digit.Count + 1; y++)
                {
                    int temp = p + r * (y + 1);
                    if(temp >= count)
                    {
                        p += r * y;
                        final += digit[y] + "";
                        digit.RemoveAt(y);
                        try
                        {
                            r /= i;
                        }
                        catch
                        {

                        }
                        y = 9;
                    }
                }
            }
            MessageBox.Show(final);
        }
        public int factorial(int n)
        {
            if(n == 0)
            {
                return 1;
            }
            return n * factorial(n - 1);
        }
    }
}
