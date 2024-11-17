using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mastermind
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string colour1;
        string colour2;
        string colour3;
        string colour4;
        public MainWindow()
        {
            InitializeComponent();
            GenerateColours(out colour1, out colour2, out colour3, out colour4);
            Title += $": ({colour1}, {colour2}, {colour3}, {colour4})";
        }

        //METHODS
        public void GenerateColours(out string colourSlot1, out string colourSlot2, out string colourSlot3, out string colourSlot4)
        {
            Random rng = new Random();
            List<string> colourList = new List<string>();
            int rngNumber;
            string rngString = "";
            
            for (int i=0; i<4; i++)
            {
                rngNumber = rng.Next(1, 7);
                switch (rngNumber)
                {
                    case 1:
                        rngString = "Red";
                        break;
                    case 2:
                        rngString = "Yellow";
                        break;
                    case 3:
                        rngString = "Orange";
                        break;
                    case 4:
                        rngString = "White";
                        break;
                    case 5:
                        rngString = "Green";
                        break;
                    case 6:
                        rngString = "Blue";
                        break;
                }
                colourList.Add(rngString);
            }
            colourSlot1 = colourList[0];
            colourSlot2 = colourList[1];
            colourSlot3 = colourList[2];
            colourSlot4 = colourList[3];
        }


        //EVENT METHODS
        private void comboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        colour1Label.Background = Brushes.Red;
                        break;
                    case 1:
                        colour1Label.Background = Brushes.Yellow;
                        break;
                    case 2:
                        colour1Label.Background = Brushes.Orange;
                        break;
                    case 3:
                        colour1Label.Background = Brushes.White;
                        break;
                    case 4:
                        colour1Label.Background = Brushes.Green;
                        break;
                    case 5:
                        colour1Label.Background = Brushes.Blue;
                        break;
                }
            }
        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox2.SelectedIndex != -1)
            {
                switch (comboBox2.SelectedIndex)
                {
                    case 0:
                        colour2Label.Background = Brushes.Red;
                        break;
                    case 1:
                        colour2Label.Background = Brushes.Yellow;
                        break;
                    case 2:
                        colour2Label.Background = Brushes.Orange;
                        break;
                    case 3:
                        colour2Label.Background = Brushes.White;
                        break;
                    case 4:
                        colour2Label.Background = Brushes.Green;
                        break;
                    case 5:
                        colour2Label.Background = Brushes.Blue;
                        break;
                }
            }
        }

        private void comboBox3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox3.SelectedIndex != -1)
            {
                switch (comboBox3.SelectedIndex)
                {
                    case 0:
                        colour3Label.Background = Brushes.Red;
                        break;
                    case 1:
                        colour3Label.Background = Brushes.Yellow;
                        break;
                    case 2:
                        colour3Label.Background = Brushes.Orange;
                        break;
                    case 3:
                        colour3Label.Background = Brushes.White;
                        break;
                    case 4:
                        colour3Label.Background = Brushes.Green;
                        break;
                    case 5:
                        colour3Label.Background = Brushes.Blue;
                        break;
                }
            }
        }

        private void comboBox4_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (comboBox4.SelectedIndex != -1)
            {
                switch (comboBox4.SelectedIndex)
                {
                    case 0:
                        colour4Label.Background = Brushes.Red;
                        break;
                    case 1:
                        colour4Label.Background = Brushes.Yellow;
                        break;
                    case 2:
                        colour4Label.Background = Brushes.Orange;
                        break;
                    case 3:
                        colour4Label.Background = Brushes.White;
                        break;
                    case 4:
                        colour4Label.Background = Brushes.Green;
                        break;
                    case 5:
                        colour4Label.Background = Brushes.Blue;
                        break;
                }
            }
        }
    }
}