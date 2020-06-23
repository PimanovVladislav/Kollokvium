using MySql.Data.MySqlClient;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        delegate void Message();
        public MainWindow()
        {
            InitializeComponent();
            Message mes = GoodMorning;
            if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
            {
                mes = GoodMorning;
            }
            if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 16)
            {
                mes = GoodAfternoon;
            }
            if (DateTime.Now.Hour >= 16 && DateTime.Now.Hour <= 24)
            {
                mes = GoodEvening;
            }
            if (DateTime.Now.Hour >= 0 && DateTime.Now.Hour < 6)
            {
                mes = GoodNight;
            }
            mes();
        }
        private static void GoodMorning()
        {
            MessageBox.Show("Доброе утро");
        }
        private static void GoodAfternoon()
        {
            MessageBox.Show("Добрый день");
        }
        private static void GoodEvening()
        {
            MessageBox.Show("Добрый вечер");
        }
        private static void GoodNight()
        {
            MessageBox.Show("Доброй ночи");
        }

        private void Starter_Click(object sender, RoutedEventArgs e)
        {
            SQL_Class.SQL_Starter();
            if (SQL_Class.OPENED)
            {
                MainForm forma = new MainForm();
                forma.Show();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
    }
}
