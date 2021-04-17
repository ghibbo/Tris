using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Tris
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Private Members
        /// <summary>
        /// Holds the current results of cells in the active game
        /// </summary>
        private MarkType[] mResults;
        /// <summary>
        /// True if it is player 1's turn (X) or player 2's turn (O)
        /// </summary>
        private bool mPlaye1Turn;
        /// <summary>
        /// True if the game is ended
        /// </summary>
        private bool mGameEnded;
        #endregion
        #region Constructor
        /// <summary>
        /// Default constructor
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }
        #endregion

        private void NewGame()
        {
            // Create a new blank array of free cells
            mResults = new MarkType[9];
            for (var i = 0; i < mResults.Length; i++)
                mResults[i] = MarkType.Free;
            // Make sure Player 1 starts the game
            mPlaye1Turn = true;
            Container.Children.Cast<Button>().ToList().ForEach(button =>
            {

            });
        }
    }
}
 