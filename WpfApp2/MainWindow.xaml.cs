using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            inkCanvas1.Strokes.Clear();
        }

        private Random rm = new Random();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Color = System.Windows.Media.Color.FromRgb((byte)rm.Next(0, 255), (byte)rm.Next(0, 255), (byte)rm.Next(0, 255));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            inkCanvas1.DefaultDrawingAttributes.Width += 5;
            inkCanvas1.DefaultDrawingAttributes.Height += 5;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (inkCanvas1.DefaultDrawingAttributes.Width > 5)
                inkCanvas1.DefaultDrawingAttributes.Width -= 5;
            if (inkCanvas1.DefaultDrawingAttributes.Height > 5)
                inkCanvas1.DefaultDrawingAttributes.Height -= 5;
        }

        private void CheckBox_OnClick(object sender, RoutedEventArgs e)
        {
            inkCanvas1.EditingMode = CheckBox.IsChecked == true ? InkCanvasEditingMode.Ink : InkCanvasEditingMode.None;
        }

        private void inkCanvas1_MouseEnter(object sender, MouseEventArgs e)
        {
            string cursorPath = Directory.GetCurrentDirectory();
            cursorPath += "\\jxh1.ani";
            inkCanvas1.UseCustomCursor = true;
            inkCanvas1.Cursor = new Cursor(cursorPath);
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            string cursorPath = Directory.GetCurrentDirectory();
            cursorPath += "\\jxh.ani";
            this.Cursor = new Cursor(cursorPath);
        }
    }
}
