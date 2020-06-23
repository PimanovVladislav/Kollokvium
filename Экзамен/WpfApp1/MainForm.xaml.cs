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
using System.Windows.Shapes;
using System.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainForm.xaml
    /// </summary>
    public partial class MainForm : Window
    {
        public MainForm()
        {
            InitializeComponent();
            SQL_Class.SQL_OpenServer();
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.O)
            {
                SaveFile();
            }
        }
        private string sql;
        private bool factor = false;
        private int allID = 0;
        public static bool BOOLER = false;
        private void MainForm_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Exit ex = new Exit();
            ex.Show();
        }
        private void BlueSide(object sender, RoutedEventArgs e)
        {
          factor = true;
        }
        private void SaveFile(object sender, RoutedEventArgs e)
        {
            SaveFile();
        }
        private void SaveFile()
        {
            MessageBox.Show("Ваш заказ принят.", "Успех!");
        }
        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {
            popup1.IsOpen = true;
        }
        private void ProcLoad(object sender, RoutedEventArgs e)
        {
            ProcLabel.Background = Brushes.Red;
            List<string> data = new List<string>();
            data.Add("Выберите бургер");
            var combo = sender as ComboBox;
            sql = "SELECT * FROM `burger`";
            MySqlCommand command = new MySqlCommand(sql, SQL_Class.connection);
            MySqlDataReader reader = command.ExecuteReader();
            combo.SelectedIndex = 0;
            while (reader.Read())
            {
                data.Add(reader[1].ToString());
            }
            combo.ItemsSource = data;
            
            /* Обнуление лишней строки */
            data.Remove("Выберите бургер");
            combo.ItemsSource = data;
            
            reader.Close();
        }
        private void MatLoad(object sender, RoutedEventArgs e)
        {
            MatLabel.Background = Brushes.Red;
            List<string> data2 = new List<string>();
            data2.Add("Выберите картошку");
            var combo = sender as ComboBox;
            sql = "SELECT * FROM `free_potato`";
            MySqlCommand command = new MySqlCommand(sql, SQL_Class.connection);
            MySqlDataReader reader = command.ExecuteReader();
            combo.SelectedIndex = 0;
            while (reader.Read())
            {
                data2.Add(reader[1].ToString());
            }
            combo.ItemsSource = data2;

            /* Обнуление лишней строки */
            data2.Remove("Выберите картошку");
            combo.ItemsSource = data2;

            reader.Close();            
        }
        private void VideoLoad(object sender, RoutedEventArgs e)
        {
            VideoLabel.Background = Brushes.Red;
            List<string> data3 = new List<string>();
            data3.Add("Выберите мясную закуску");
            var combo = sender as ComboBox;
            sql = "SELECT * FROM `myaso`";
            MySqlCommand command = new MySqlCommand(sql, SQL_Class.connection);
            MySqlDataReader reader = command.ExecuteReader();
            combo.SelectedIndex = 0;
            while (reader.Read())
            {
                data3.Add(reader[1].ToString());
            }
            combo.ItemsSource = data3;

            /* Обнуление лишней строки */
            data3.Remove("Выберите мясную закуску");
            combo.ItemsSource = data3;

            reader.Close();

        }
        private void OperLoad(object sender, RoutedEventArgs e)
        {
            OperLabel.Background = Brushes.Red;
            List<string> data4 = new List<string>();
            data4.Add("Выберите соус");
            var combo = sender as ComboBox;
            sql = "SELECT * FROM `soyses`";
            MySqlCommand command = new MySqlCommand(sql, SQL_Class.connection);
            MySqlDataReader reader = command.ExecuteReader();
            combo.SelectedIndex = 0;
            while (reader.Read())
            {
                data4.Add(reader[1].ToString());
            }
            combo.ItemsSource = data4;

            /* Обнуление лишней строки */
            data4.Remove("Выберите соус");
            combo.ItemsSource = data4;

            reader.Close();

        }
        private void HranLoad(object sender, RoutedEventArgs e)
        {
            HranLabel.Background = Brushes.Red;
            List<string> data5 = new List<string>();
            data5.Add("Выберите напиток");
            var combo = sender as ComboBox;
            sql = "SELECT * FROM `napitok`";
            MySqlCommand command = new MySqlCommand(sql, SQL_Class.connection);
            MySqlDataReader reader = command.ExecuteReader();
            combo.SelectedIndex = 0;
            while (reader.Read())
            {
                data5.Add(reader[1].ToString());
            }
            combo.ItemsSource = data5;

            /* Обнуление лишней строки */
            data5.Remove("Выберите напиток");
            combo.ItemsSource = data5;

            reader.Close();

        }
        private void BlockLoad(object sender, RoutedEventArgs e)
        {
            BlockLabel.Background = Brushes.Red;
            List<string> data6 = new List<string>();
            data6.Add("Выберите десерт");
            var combo = sender as ComboBox;
            sql = "SELECT * FROM `desert`";
            MySqlCommand command = new MySqlCommand(sql, SQL_Class.connection);
            MySqlDataReader reader = command.ExecuteReader();
            combo.SelectedIndex = 0;
            while (reader.Read())
            {
                data6.Add(reader[1].ToString());
            }
            combo.ItemsSource = data6;

            /* Обнуление лишней строки */
            data6.Remove("Выберите десерт");
            combo.ItemsSource = data6;

            reader.Close();

        }
        private void Proс_Selection(object sender, SelectionChangedEventArgs e)
        {
            string spname = "Выберите бургер";
            var selected = sender as ComboBox;
            if (!(spname == selected.SelectedItem as string))
            {
                string name = selected.SelectedItem as string;
                if (factor)
                {
                    sql = "SELECT * FROM `burger` WHERE `name` = " + '"' + name + '"';
                    MySqlCommand nextCommand = new MySqlCommand(sql, SQL_Class.connection);
                    MySqlDataReader reader = nextCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        allID = System.Convert.ToInt32(reader[0].ToString());
                    }
                }
                ProcLabel.Background = Brushes.Transparent;
            }
        }
        private void Potato_Selection(object sender, SelectionChangedEventArgs e)
        {
            string spname = "Выберите картошку";
            var selected = sender as ComboBox;
            if (!(spname == selected.SelectedItem as string))
            {
                string name = selected.SelectedItem as string;
                if (factor)
                {
                    sql = "SELECT * FROM `free_potato` WHERE `name` = " + '"' + name + '"';
                    MySqlCommand nextCommand = new MySqlCommand(sql, SQL_Class.connection);
                    MySqlDataReader reader = nextCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        allID = System.Convert.ToInt32(reader[0].ToString());
                    }
                }
                MatLabel.Background = Brushes.Transparent;
            }
        }
        private void Myaso_Selection(object sender, SelectionChangedEventArgs e)
        {
            string spname = "Выберите мясную закуску";
            var selected = sender as ComboBox;
            if (!(spname == selected.SelectedItem as string))
            {
                string name = selected.SelectedItem as string;
                if (factor)
                {
                    sql = "SELECT * FROM `myaso` WHERE `name` = " + '"' + name + '"';
                    MySqlCommand nextCommand = new MySqlCommand(sql, SQL_Class.connection);
                    MySqlDataReader reader = nextCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        allID = System.Convert.ToInt32(reader[0].ToString());
                    }
                }
                VideoLabel.Background = Brushes.Transparent;
            }
        }
        private void Soyses_Selection(object sender, SelectionChangedEventArgs e)
        {
            string spname = "Выберите соус";
            var selected = sender as ComboBox;
            if (!(spname == selected.SelectedItem as string))
            {
                string name = selected.SelectedItem as string;
                if (factor)
                {
                    sql = "SELECT * FROM `soyses` WHERE `name` = " + '"' + name + '"';
                    MySqlCommand nextCommand = new MySqlCommand(sql, SQL_Class.connection);
                    MySqlDataReader reader = nextCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        allID = System.Convert.ToInt32(reader[0].ToString());
                    }
                }
                OperLabel.Background = Brushes.Transparent;
            }
        }
        private void Napitok_Selection(object sender, SelectionChangedEventArgs e)
        {
            string spname = "Выберите напиток";
            var selected = sender as ComboBox;
            if (!(spname == selected.SelectedItem as string))
            {
                string name = selected.SelectedItem as string;
                if (factor)
                {
                    sql = "SELECT * FROM `napitok` WHERE `name` = " + '"' + name + '"';
                    MySqlCommand nextCommand = new MySqlCommand(sql, SQL_Class.connection);
                    MySqlDataReader reader = nextCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        allID = System.Convert.ToInt32(reader[0].ToString());
                    }
                }
                HranLabel.Background = Brushes.Transparent;
            }
        }
        private void Desert_Selection(object sender, SelectionChangedEventArgs e)
        {
            string spname = "Выберите десерт";
            var selected = sender as ComboBox;
            if (!(spname == selected.SelectedItem as string))
            {
                string name = selected.SelectedItem as string;
                if (factor)
                {
                    sql = "SELECT * FROM `desert` WHERE `name` = " + '"' + name + '"';
                    MySqlCommand nextCommand = new MySqlCommand(sql, SQL_Class.connection);
                    MySqlDataReader reader = nextCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        allID = System.Convert.ToInt32(reader[0].ToString());
                    }
                }
                BlockLabel.Background = Brushes.Transparent;
            }
        }

        private void AboutMe(object sender, RoutedEventArgs e)
        {
            TY thx = new TY();
            thx.Show();
        }
        interface IFire
        {
            void Fst();
            void Scnd();
            void Thrt();
        }
        class FireWorks : IFire
        {
            public void Fst()
            {
                MessageBox.Show("Напрасно нажал сюда", "Зря");
            }
            public void Scnd()
            {
                MessageBox.Show("Лучше не надо", "Warning!!!");
            }
            public void Thrt()
            {
                MessageBox.Show("Дальше вообще мрак", "Я бы лучше закрыл поскорее");
            }
        }

        class ImpFireWorks : FireWorks
        {
            public void NeverMore()
            {
                MessageBox.Show("А вот и ваш промокод на скидку: ILOVEPROGRAMMING", "Спасибо!");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            IFire canonfire = new FireWorks();
            canonfire.Fst();
            canonfire.Scnd();
            canonfire.Thrt();
            ImpFireWorks newfire = new ImpFireWorks();
            newfire.NeverMore();
        }
    }
}
