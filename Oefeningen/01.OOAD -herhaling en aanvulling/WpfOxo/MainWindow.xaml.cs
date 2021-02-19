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


namespace WpfOxo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool beurt = true; //true=X false=O
        int beurtenTeller = 0; 
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender; //converteert de sender object
            if (beurt)
                btn.Content = "X";
            else
                btn.Content = "O";

            beurt = !beurt; //om de beurt te bepalen
            btn.IsEnabled = false;
            beurtenTeller++;

            winnerBepalen();
        }

        private void winnerBepalen()
        {
            bool winnaar = false;

            //Horizonatale check
            if ((A1.Content == A2.Content) && (A2.Content == A3.Content) && (!A1.IsEnabled))
                winnaar = true;
            else if ((B1.Content == B2.Content) && (B2.Content == B3.Content) && (!B1.IsEnabled))
                winnaar = true;
            else if ((C1.Content == C2.Content) && (C2.Content == C3.Content) && (!C1.IsEnabled))
                winnaar = true;

            //Verticale check
            if ((A1.Content == B1.Content) && (B1.Content == C1.Content) && (!A1.IsEnabled))
                winnaar = true;
            else if ((A2.Content == B2.Content) && (B2.Content == C2.Content) && (!A2.IsEnabled))
                winnaar = true;
            else if ((A3.Content == B3.Content) && (B3.Content == C3.Content) && (!A3.IsEnabled))
                winnaar = true;

            //Diagonale check
            
            else if ((A1.Content == B2.Content) && (B2.Content == C3.Content) && (!A1.IsEnabled))
                winnaar = true;
            else if ((A3.Content == B2.Content) && (B2.Content == C1.Content) && (!C1.IsEnabled))
                winnaar = true;

            if (winnaar)
            {
                disableButtons();
                String speler = "";
                if (beurt)
                    speler = "O";
                else
                    speler = "X";

                MessageBox.Show(speler + " is gewonnen", "GG!");
                
            }
            else
            {
                if (beurtenTeller == 9)
                    MessageBox.Show("Gelijkspel!", "GG");
            }

        }//end

        //methode buttons uitschakelen na er winnaar is
        private void disableButtons()
        {
            GridMain.IsEnabled = false;
        }
    }
}
