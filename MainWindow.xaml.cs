﻿using System;
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

namespace UsersApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Reg_Click(object sender, RoutedEventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string pass = passBox.Password.Trim();
            string pass_2 = passBox2.Password.Trim();
            string email = textBoxEmail.Text.Trim().ToLower();

            if(login.Length < 5)
            {
                textBoxLogin.ToolTip = "Це поле введено не вірно!";
                textBoxLogin.Background = Brushes.DarkRed;
            }
            else if (pass.Length < 5) 
            {
                passBox.ToolTip = "Це поле введено не вірно!";
                passBox.Background = Brushes.DarkRed;
            }
            else if(pass != pass_2)
            {
                passBox2.ToolTip = "Це поле введено не вірно!";
                passBox2.Background = Brushes.DarkRed;
            }
            else if (email.Length < 5 || !email.Contains("@") || !email.Contains(".")) 
            {
                textBoxEmail.ToolTip = "Це поле введено не вірно!";
                textBoxEmail.Background = Brushes.DarkRed;  
            }
            else
            {
                textBoxLogin.ToolTip = "";
                textBoxLogin.Background = Brushes.Transparent;
                passBox.ToolTip = "";
                passBox.Background = Brushes.Transparent;
                passBox2.ToolTip = "";
                passBox2.Background = Brushes.Transparent;
                textBoxEmail.ToolTip = "";
                textBoxEmail.Background = Brushes.Transparent;

                MessageBox.Show("Oll Good!");
            }
        }
    }
}
