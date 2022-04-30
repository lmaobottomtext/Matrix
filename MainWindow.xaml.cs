using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Matrix
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private TextBox[,] MatrixATextBoxes, MatrixBTextBoxes;
        public MainWindow()
        {
            InitializeComponent();
        }
        private TextBox[,] UpdateGrid(UniformGrid uniformGrid, int size)
        {
            TextBox[,] result = new TextBox[size, size];

            uniformGrid.Rows = size;
            uniformGrid.Columns = size;
            uniformGrid.Children.Clear();

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    result[i, j] = new TextBox();
                    result[i, j].Text = "0";
                    uniformGrid.Children.Add(result[i, j]);
                }
            }
            return result;
        }

        private void buttonCreateMatrix_Click(object sender, RoutedEventArgs e)
        {
            MatrixATextBoxes = UpdateGrid(MatrixA, Convert.ToInt32(dimensionMatrix.Text));
            MatrixBTextBoxes = UpdateGrid(MatrixB, Convert.ToInt32(dimensionMatrix.Text));
        }

        private void buttontFillMatrix_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttontAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void buttontMultiply_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}
