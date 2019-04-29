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
using MaterialDesignColors;
using MaterialDesignThemes;

namespace FirstLessonApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            firstNameLabel.Content = "Robert";
            lastNameLabel.Content = "Kiyosaki";
            addressLabel.Content = "Usa st.Gavai";
            groupLabel.Content = "A113";
            birthdayDateLabel.Content = "08.04.1947";
        }
    }
}
