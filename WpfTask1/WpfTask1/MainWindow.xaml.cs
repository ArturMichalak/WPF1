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
using WpfTask1.Logic;
using WpfTask1.Logic.Interfaces;

namespace WpfTask1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private IStack<string> stack;
        public MainWindow()
        {
            InitializeComponent();
            stack = new CStack<string>();
        }

        private void Pop_Click(object sender, RoutedEventArgs e)
        {
            OutputLabel.Content = stack.Empty ? "Stos jest pusty" : stack.Pop + " zdjeto ze stosu";
        }

        private void Push_Click(object sender, RoutedEventArgs e)
        {
            stack.Push(InputArea.Text);
            OutputLabel.Content = "Wprowadzono " + stack.Top;
        }
    }
}
