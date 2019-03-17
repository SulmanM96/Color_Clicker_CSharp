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
using System.Windows.Forms;
using System.Windows.Threading;
using Microsoft.Win32;
using System.IO;
using Button = System.Windows.Forms.Button;

namespace ColorClicker
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer timer = new DispatcherTimer();
        Random rand = new Random();
        Button x = new Button();
        int teleportTo = 0;
        int score = 0;
        bool isClicked = false;
        


        public MainWindow()
        {

            timer.Tick += new EventHandler(updateScore);
            timer.Interval = TimeSpan.FromSeconds(0.7);
            timer.Start();

            
            InitializeComponent();

        }

        

        private void updateScore(object sender, EventArgs e)
        {
            
            lblscore.Content = "Hit: " + score;
            
            
            if (score > 30)
            {
                System.Windows.MessageBox.Show("You Win");
                this.Close();
            }
            randomCircle();


        }

        private void randomCircle()
        {
            isClicked = false;
            teleportTo = rand.Next(1, 10);

            switch (teleportTo)
            {
                case 1:
                    if (Button1.IsVisible == true)
                    {
                        
                        Button1.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        Button1.Visibility = Visibility.Visible;


                        Button8.Visibility = Visibility.Hidden;
                        Button2.Visibility = Visibility.Hidden;
                        Button3.Visibility = Visibility.Hidden;
                        Button4.Visibility = Visibility.Hidden;
                        Button5.Visibility = Visibility.Hidden;
                        Button6.Visibility = Visibility.Hidden;
                        Button7.Visibility = Visibility.Hidden;
                        Button9.Visibility = Visibility.Hidden;


                    }
                    break;

                case 2:
                    if (Button2.IsVisible == true)
                    {
                        Button2.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        Button2.Visibility = Visibility.Visible;


                        Button1.Visibility = Visibility.Hidden;
                        Button8.Visibility = Visibility.Hidden;
                        Button3.Visibility = Visibility.Hidden;
                        Button4.Visibility = Visibility.Hidden;
                        Button5.Visibility = Visibility.Hidden;
                        Button6.Visibility = Visibility.Hidden;
                        Button7.Visibility = Visibility.Hidden;
                        Button9.Visibility = Visibility.Hidden;


                    }
                    break;

                case 3:
                    if (Button3.IsVisible == true)
                    {
                        Button3.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        Button3.Visibility = Visibility.Visible;
                        


                        Button1.Visibility = Visibility.Hidden;
                        Button2.Visibility = Visibility.Hidden;
                        Button8.Visibility = Visibility.Hidden;
                        Button4.Visibility = Visibility.Hidden;
                        Button5.Visibility = Visibility.Hidden;
                        Button6.Visibility = Visibility.Hidden;
                        Button7.Visibility = Visibility.Hidden;
                        Button9.Visibility = Visibility.Hidden;

                    }
                    break;

                case 4:
                    if (Button9.IsVisible == true)
                    {
                        Button9.Visibility = Visibility.Hidden;
                    }
                    else {
                        Button9.Visibility = Visibility.Visible;
                        

                        Button1.Visibility = Visibility.Hidden;
                        Button2.Visibility = Visibility.Hidden;
                        Button3.Visibility = Visibility.Hidden;
                        Button4.Visibility = Visibility.Hidden;
                        Button5.Visibility = Visibility.Hidden;
                        Button6.Visibility = Visibility.Hidden;
                        Button7.Visibility = Visibility.Hidden;
                        Button8.Visibility = Visibility.Hidden;

                    }
                    break;

                case 5:
                    if (Button4.IsVisible == true)
                    {
                        Button4.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        Button4.Visibility = Visibility.Visible;
                        

                        Button1.Visibility = Visibility.Hidden;
                        Button2.Visibility = Visibility.Hidden;
                        Button3.Visibility = Visibility.Hidden;
                        Button8.Visibility = Visibility.Hidden;
                        Button5.Visibility = Visibility.Hidden;
                        Button6.Visibility = Visibility.Hidden;
                        Button7.Visibility = Visibility.Hidden;
                        Button9.Visibility = Visibility.Hidden;

                    }
                    break;

                case 6:
                    if (Button5.IsVisible == true)
                    {
                        Button5.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        Button5.Visibility = Visibility.Visible;


                        Button1.Visibility = Visibility.Hidden;
                        Button2.Visibility = Visibility.Hidden;
                        Button3.Visibility = Visibility.Hidden;
                        Button4.Visibility = Visibility.Hidden;
                        Button8.Visibility = Visibility.Hidden;
                        Button6.Visibility = Visibility.Hidden;
                        Button7.Visibility = Visibility.Hidden;
                        Button9.Visibility = Visibility.Hidden;

                    }
                    break;

                case 7:
                    if (Button6.IsVisible == true)
                    {
                        Button6.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        Button6.Visibility = Visibility.Visible;
                       


                        Button1.Visibility = Visibility.Hidden;
                        Button2.Visibility = Visibility.Hidden;
                        Button3.Visibility = Visibility.Hidden;
                        Button4.Visibility = Visibility.Hidden;
                        Button5.Visibility = Visibility.Hidden;
                        Button8.Visibility = Visibility.Hidden;
                        Button7.Visibility = Visibility.Hidden;
                        Button9.Visibility = Visibility.Hidden;

                    }
                    break;

                case 8:
                    if (Button7.IsVisible == true)
                    {
                        Button7.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        Button7.Visibility = Visibility.Visible;
                        

                        Button1.Visibility = Visibility.Hidden;
                        Button2.Visibility = Visibility.Hidden;
                        Button3.Visibility = Visibility.Hidden;
                        Button4.Visibility = Visibility.Hidden;
                        Button5.Visibility = Visibility.Hidden;
                        Button6.Visibility = Visibility.Hidden;
                        Button8.Visibility = Visibility.Hidden;
                        Button9.Visibility = Visibility.Hidden;

                    }
                    break;

                case 9:
                    if (Button8.IsVisible == true)
                    {
                        Button8.Visibility = Visibility.Hidden;
                    }
                    else
                    {
                        Button8.Visibility = Visibility.Visible;
                        

                        Button1.Visibility = Visibility.Hidden;
                        Button2.Visibility = Visibility.Hidden;
                        Button3.Visibility = Visibility.Hidden;
                        Button4.Visibility = Visibility.Hidden;
                        Button5.Visibility = Visibility.Hidden;
                        Button6.Visibility = Visibility.Hidden;
                        Button7.Visibility = Visibility.Hidden;
                        Button9.Visibility = Visibility.Hidden;

                    }
                    break;

                default:


                    break;

            }
        }

        private void circleClicked1(object sender, RoutedEventArgs e)
        {
            isClicked = true;
            score++;
            
            timer.Start();
            Button5.Visibility = Visibility.Hidden;
        }

        private void circleClicked2(object sender, RoutedEventArgs e)
        {
            isClicked = true;
            score++;

            Button6.Visibility = Visibility.Hidden;
        }

        private void circleClicked3(object sender, RoutedEventArgs e)
        {
            isClicked = true;
            score++;

            Button1.Visibility = Visibility.Hidden;
        }

        private void circleClicked4(object sender, RoutedEventArgs e)
        {
            isClicked = true;
            score++;

            Button2.Visibility = Visibility.Hidden;
        }

        private void circleClicked5(object sender, RoutedEventArgs e)
        {
            isClicked = true;
            score++;

            Button3.Visibility = Visibility.Hidden;
        }

        private void circleClicked6(object sender, RoutedEventArgs e)
        {
            isClicked = true;
            score++;

            Button4.Visibility = Visibility.Hidden;
        }

        private void circleClicked7(object sender, RoutedEventArgs e)
        {
            isClicked = true;
            score++;

            Button7.Visibility = Visibility.Hidden;
        }

        private void circleClicked8(object sender, RoutedEventArgs e)
        {
            isClicked = true;
            score++;

            Button8.Visibility = Visibility.Hidden;
        }

        private void circleClicked9(object sender, RoutedEventArgs e)
        {
            isClicked = true;
            score++;
            Button9.Visibility = Visibility.Hidden;
        }
    }
}
