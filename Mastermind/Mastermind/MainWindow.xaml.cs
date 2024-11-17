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

        
    }
}