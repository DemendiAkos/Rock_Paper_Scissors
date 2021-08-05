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

namespace harmadik
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        Random rnd = new Random();

        int user;
        int computer;
        int pp;
        int qq;

        public MainWindow()
        {
            InitializeComponent();
            Restart.Margin = new Thickness(1000);
            
        }

        private void endgame()
        {
            if (pp == 10 || qq == 10)
            {
                Rock.Margin = new Thickness(10000);
                Scissors.Margin = new Thickness(1000);
                paper.Margin = new Thickness(10000);
                Score.Margin = new Thickness(10000);
                ricardo.Margin = new Thickness(10000);
                goal.Margin = new Thickness(1000);
                Result_img.Margin = new Thickness(1000);
                Yuuuuuu.Margin = new Thickness(1000);
                Attack.Margin = new Thickness(1000);
                background.Margin = new Thickness(10000);
                sk.Margin = new Thickness(10000);
                Restart.Margin = new Thickness(0);
            }
        }

        private void cal()
        {
            if (computer == 0)
            {
                Result_img.Source = new BitmapImage(new Uri(@"0.png", UriKind.RelativeOrAbsolute));
                
                if (user == 0)
                {
                    Score.Content = "It's a tie";
                }
                else if (user == 1)
                {
                    qq++;
                    Score.Content = "You lost";
                }
                else if (user == 2)
                {
                    pp++;
                    Score.Content = "You won";
                }
                
            }
            else if (computer == 1)
            {
                Result_img.Source = new BitmapImage(new Uri(@"1.jpg", UriKind.RelativeOrAbsolute));
                if (user == 0)
                {
                    pp++;
                    Score.Content = "You won";
                }
                else if (user == 1)
                {
                    Score.Content = "It's a tie";
                }
                else if (user == 2)
                {
                    qq++;
                    Score.Content = "You lost";
                }
                
            }
            else if (computer == 2)
            {
                Result_img.Source = new BitmapImage(new Uri(@"2.png", UriKind.RelativeOrAbsolute));
                if (user == 0)
                {
                    qq++;
                    Score.Content = "You lost";
                }
                else if (user == 1)
                {
                    pp++;
                    Score.Content = "You won";
                }
                else if (user == 2)
                {
                    Score.Content = "It's a tie";
                }
                
            }
        }

        private void Button_Rock(object sender, RoutedEventArgs e)
        {
            computer = rnd.Next(0, 3);
            user = 0;
            Attack.Content = computer;
            cal();
            endgame();
            ricardo.Content = pp + ":" + qq;
        }

        private void Button_Scissors(object sender, RoutedEventArgs e)
        {
            computer= rnd.Next(0, 3);
            Attack.Content = computer;
            user = 1;
            cal();
            endgame();
            ricardo.Content = pp + ":" + qq;
        }

        private void Button_paper(object sender, RoutedEventArgs e)
        {
            computer = rnd.Next(0, 3);
            Attack.Content = computer;
            user = 2;
            cal();
            endgame();
            ricardo.Content = pp + ":" + qq;
        }

        private void Btn_restart(object sender, RoutedEventArgs e)
        {
            pp = 0;
            qq = 0;
            ricardo.Content = "0:0";
            Restart.Margin = new Thickness(1000);
            Rock.Margin = new Thickness(83, 220, 0, 0);
            Scissors.Margin = new Thickness(83, 404, 0, 0);
            paper.Margin = new Thickness(83, 582, 0, 0);
            Score.Margin = new Thickness(783, 117, 0, 0);
            ricardo.Margin = new Thickness(838, 205, 0, 0);
            goal.Margin = new Thickness(899, 85, 0, 0);
            Result_img.Margin = new Thickness(1110, 268, 251, 138);
            Yuuuuuu.Margin = new Thickness(384, 127, 0, 0);
            Attack.Margin = new Thickness(1432, 164, 0, 0);
            background.Margin = new Thickness(57, 0, 0, 10);
            sk.Margin = new Thickness(0, 10, 0, 0);
        }
    }
}
