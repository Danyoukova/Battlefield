using Pra.Battlefield.Core.Entities.Players;
using Pra.Battlefield.Core.Interfaces;
using Pra.Battlefield.Core.Services;
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

namespace Pra.Battlefield.Wpf
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

        SimpleBattlefield simpleBattlefield;
        AdvancedBattlefield advancedBattlefield;

        List<IPlayer> players = new List<IPlayer>();

        public void DefaultView()
        {
            btnNewGame.IsEnabled = true;
            grpBattlefield.IsEnabled = false;
            chkSimpleGame.IsChecked = true;
            chkSimpleGame.IsEnabled = true;
            lblPlayers.Content = "";
            lblPlayersAlive.Content = "";
        }
        public void StartGame()
        {
            grpBattlefield.IsEnabled = true;
            btnNewGame.IsEnabled = false;
            chkSimpleGame.IsEnabled = false;
        }
        public int CountAlive()
        {
            foreach (IPlayer player in players)
            {
                if (player.Health > 0)
                {
                    lblPlayersAlive.Content = players.Count;
                }
            }
            return players.Count;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DefaultView();
           
            
        }

        private void BtnNewGame_Click(object sender, RoutedEventArgs e)
        {
            StartGame();
            if (chkSimpleGame.IsChecked == true)
            {
                simpleBattlefield = new SimpleBattlefield();
            }
            else
            {
                advancedBattlefield = new AdvancedBattlefield();
            }


        }
        private void BtnAddPlayer_Click(object sender, RoutedEventArgs e)
        {

            lstPlayers.ItemsSource = null;
            if(chkSimpleGame.IsChecked==true)
            {
                simpleBattlefield.AddGeneratedPlayer();
                lstPlayers.ItemsSource = simpleBattlefield.Players;
                lblPlayers.Content = simpleBattlefield.Players.Count();
                lblPlayersAlive.Content = simpleBattlefield.NumberAlive();
            }
            else
            {
                advancedBattlefield.AddGeneratedPlayer();
                lstPlayers.ItemsSource = advancedBattlefield.Players;
                lblPlayers.Content = advancedBattlefield.Players.Count();
                lblPlayersAlive.Content = advancedBattlefield.NumberAlive();
            }
            
           
        }

        private void BtnAttack_Click(object sender, RoutedEventArgs e)
        {

        if (chkSimpleGame.IsChecked == true)
            {
                if (simpleBattlefield.NumberAlive() >= 2)
                {
                    simpleBattlefield.Attack();
                    lblPlayersAlive.Content = simpleBattlefield.NumberAlive();
                }
                else
                {
                    MessageBox.Show("Voeg nog spelers toe.");
                }
            }
            else
            {
                if(advancedBattlefield.NumberAlive()>=2)
                {
                    advancedBattlefield.Attack();
                    lblPlayersAlive.Content = advancedBattlefield.NumberAlive();
                }
                else
                {
                    MessageBox.Show("Voeg nog spelers toe.");
                }
            }
              
            
           lstPlayers.Items.Refresh();
            
         
        }


        private void BtnQuitGame_Click(object sender, RoutedEventArgs e)
        {
            players.Clear();
            lstPlayers.ItemsSource = null;
            lstPlayers.Items.Refresh();
            DefaultView();
        }

       
        
    }
}
