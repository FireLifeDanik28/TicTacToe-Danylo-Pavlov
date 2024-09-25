using TicTacToe_DanyloPavlov;

namespace TicTacToe_Danylo_Pavlov
{
    public partial class Form1 : Form
    {
        //aktywny gracz - zaczynaja kolko
        Player p = new Player();

        public Form1()
        {
            InitializeComponent();
            //zainicjuj labelke pokazujaca aktywnego gracza
            ActivePlayerLabel.Text = "Aktywny gracz: " + p.GetPlayer();
        }

        void SwitchPlayer()
        {
            //zmien aktywnego gracza
            p.SwitchPlayer();
            //zmodyfikuj labelke pokazujaca aktywnego gracza
            ActivePlayerLabel.Text = "Aktywny gracz: " + p.GetPlayer();
        }

        private void GameButtonClick(object sender, EventArgs e)
        {
            //stworz obiekt klasy button i rzutuj do niego zawartosc sender
            Button button = (Button)sender;

            //jesli na guziku jest juz jakis napis to zako�cz funkcji
            if (button.Text != "")
            {
                return;
            }
            //zapisz do guzika aktywnego gracza 
            button.Text = p.GetPlayer();
            //sprawdzamy czy ktos wygral
            CheckResult();
            //zmiana gracza
            SwitchPlayer();
            //zablokuj guzik
            //button.Enabled = false;
        }
        //indykuje wygrana dla nie pojawiania sie remisu po uzyciu wszystkich wierszy
        bool wygrana = false;
        void CheckResult()
        {
            //pobierz wszystkie guziki z layoutu i zapisz do listy
            List<Button> buttonList =
                        tableLayoutPanel1.Controls.OfType<Button>().ToList();
            //licznik pustych guzikow
            int empty = 0;
            foreach (Button button in buttonList)
            {
                if (button.Text == String.Empty)
                {
                    //jesli guzik nie ma znaku to zwieksz licznik pustych guzik�w
                    empty++;
                }
            }
            //sprawdzamy najpierw wiersze
            //sprawdzamy czy zaden z guzikow w gornym wierszu nie jest pusty
            if (TopLeft.Text != String.Empty &&
                TopCenter.Text != String.Empty &&
                TopRight.Text != String.Empty)
            {
                //jesli nie ma pustych sprawdzamy czy lewy i srodkowy oraz
                // srodkowy i prawy sa takie same
                if (TopLeft.Text == TopCenter.Text && TopCenter.Text == TopRight.Text)
                {
                    //indykuje wygrana dla nie pojawiania sie remisu po uzyciu wszystkich wierszy
                    wygrana = true;
                    //jesli sa takie same to wygrywa gracz ktory ma taki sam znak
                    //nie ma znaczenia z ktorego guzika pobieramy tekst
                    MessageBox.Show("Wygral gracz: " + TopLeft.Text);
                    RestartGame();
                    //dodalem return poniewaz remis pojawia sie po wygranej gdy wszystkie poly sa uzyte
                    return;
                }
            }
            //sprawdzamy czy zaden z guzikow w srodkowym wierszu nie jest pusty
            if (CenterLeft.Text != String.Empty &&
                CenterCenter.Text != String.Empty &&
                CenterRight.Text != String.Empty)
            {
                //jesli nie ma pustych sprawdzamy czy lewy i srodkowy oraz
                // srodkowy i prawy sa takie same
                if (CenterLeft.Text == CenterCenter.Text && CenterCenter.Text == CenterRight.Text)
                {
                    //indykuje wygrana dla nie pojawiania sie remisu po uzyciu wszystkich wierszy
                    wygrana = true;
                    //jesli sa takie same to wygrywa gracz ktory ma taki sam znak
                    //nie ma znaczenia z ktorego guzika pobieramy tekst
                    MessageBox.Show("Wygral gracz: " + CenterLeft.Text);
                    RestartGame();
                    //dodalem return poniewaz remis pojawia sie po wygranej gdy wszystkie poly sa uzyte
                    return;
                }
            }
            //sprawdzamy czy zaden z guzikow w dolnym wierszu nie jest pusty
            if (BottomLeft.Text != String.Empty &&
                BottomCenter.Text != String.Empty &&
                BottomRight.Text != String.Empty)
            {
                //jesli nie ma pustych sprawdzamy czy lewy i srodkowy oraz
                // srodkowy i prawy sa takie same
                if (BottomLeft.Text == BottomCenter.Text && BottomCenter.Text == BottomRight.Text)
                {
                    //indykuje wygrana dla nie pojawiania sie remisu po uzyciu wszystkich wierszy
                    wygrana = true;
                    //jesli sa takie same to wygrywa gracz ktory ma taki sam znak
                    //nie ma znaczenia z ktorego guzika pobieramy tekst
                    MessageBox.Show("Wygral gracz: " + BottomLeft.Text);
                    RestartGame();
                    //dodalem return poniewaz remis pojawia sie po wygranej gdy wszystkie poly sa uzyte
                    return;
                }
            }
            //sprawdzamy teraz kolumny
            //sprawdzamy czy zaden z guzikow w lewej kolumny nie jest pusty
            if (TopLeft.Text != String.Empty &&
                CenterLeft.Text != String.Empty &&
                BottomLeft.Text != String.Empty)
            {
                //jesli nie ma pustych sprawdzamy czy lewy i srodkowy oraz
                // srodkowy i prawy sa takie same
                if (TopLeft.Text == CenterLeft.Text && CenterLeft.Text == BottomLeft.Text)
                {
                    //indykuje wygrana dla nie pojawiania sie remisu po uzyciu wszystkich wierszy
                    wygrana = true;
                    //jesli sa takie same to wygrywa gracz ktory ma taki sam znak
                    //nie ma znaczenia z ktorego guzika pobieramy tekst
                    MessageBox.Show("Wygral gracz: " + TopLeft.Text);
                    RestartGame();
                    //dodalem return poniewaz remis pojawia sie po wygranej gdy wszystkie poly sa uzyte
                    return;
                }
            }
            //sprawdzamy czy zaden z guzikow w srodkowej kolumny nie jest pusty
            if (TopCenter.Text != String.Empty &&
                CenterCenter.Text != String.Empty &&
                BottomCenter.Text != String.Empty)
            {
                //jesli nie ma pustych sprawdzamy czy lewy i srodkowy oraz
                // srodkowy i prawy sa takie same
                if (TopCenter.Text == CenterCenter.Text && CenterCenter.Text == BottomCenter.Text)
                {
                    //indykuje wygrana dla nie pojawiania sie remisu po uzyciu wszystkich wierszy
                    wygrana = true;
                    //jesli sa takie same to wygrywa gracz ktory ma taki sam znak
                    //nie ma znaczenia z ktorego guzika pobieramy tekst
                    MessageBox.Show("Wygral gracz: " + TopCenter.Text);
                    RestartGame();
                    //dodalem return poniewaz remis pojawia sie po wygranej gdy wszystkie poly sa uzyte
                    return;
                }
            }
            //sprawdzamy czy zaden z guzikow w prawej kolumny nie jest pusty
            if (TopRight.Text != String.Empty &&
                CenterRight.Text != String.Empty &&
                BottomRight.Text != String.Empty)
            {
                //jesli nie ma pustych sprawdzamy czy lewy i srodkowy oraz
                // srodkowy i prawy sa takie same
                if (TopRight.Text == CenterRight.Text && CenterRight.Text == BottomRight.Text)
                {
                    //indykuje wygrana dla nie pojawiania sie remisu po uzyciu wszystkich wierszy
                    wygrana = true;
                    //jesli sa takie same to wygrywa gracz ktory ma taki sam znak
                    //nie ma znaczenia z ktorego guzika pobieramy tekst
                    MessageBox.Show("Wygral gracz: " + TopRight.Text);
                    RestartGame();
                    //dodalem return poniewaz remis pojawia sie po wygranej gdy wszystkie poly sa uzyte
                    return;
                }
            }
            //sprawdzamy na koniec diagonale (/ i \)
            //sprawdzamy czy zaden z guzikow w / diagonali nie jest pusty
            if (TopRight.Text != String.Empty &&
                CenterCenter.Text != String.Empty &&
                BottomLeft.Text != String.Empty)
            {
                //jesli nie ma pustych sprawdzamy czy lewy i srodkowy oraz
                // srodkowy i prawy sa takie same
                if (TopRight.Text == CenterCenter.Text && CenterCenter.Text == BottomLeft.Text)
                {
                    //indykuje wygrana dla nie pojawiania sie remisu po uzyciu wszystkich wierszy
                    wygrana = true;
                    //jesli sa takie same to wygrywa gracz ktory ma taki sam znak
                    //nie ma znaczenia z ktorego guzika pobieramy tekst
                    MessageBox.Show("Wygral gracz: " + TopRight.Text);
                    RestartGame();
                    //dodalem return poniewaz remis pojawia sie po wygranej gdy wszystkie poly sa uzyte
                    return;
                }
            }
            //sprawdzamy czy zaden z guzikow w \ diagonali nie jest pusty
            if (TopLeft.Text != String.Empty &&
                CenterCenter.Text != String.Empty &&
                BottomRight.Text != String.Empty)
            {
                //jesli nie ma pustych sprawdzamy czy lewy i srodkowy oraz
                // srodkowy i prawy sa takie same
                if (TopLeft.Text == CenterCenter.Text && CenterCenter.Text == BottomRight.Text)
                {
                    //indykuje wygrana dla nie pojawiania sie remisu po uzyciu wszystkich wierszy
                    wygrana = true;
                    //jesli sa takie same to wygrywa gracz ktory ma taki sam znak
                    //nie ma znaczenia z ktorego guzika pobieramy tekst
                    MessageBox.Show("Wygral gracz: " + TopLeft.Text);
                    RestartGame();
                    //dodalem return poniewaz remis pojawia sie po wygranej gdy wszystkie poly sa uzyte
                    return;
                }
            }
            //jezeli nie wystapil zaden z warunkow wygranej i nie ma pustych guzikow
            //to nastapil remis
            if (empty == 0 && wygrana != true)
            {
                MessageBox.Show("Remis");
                RestartGame();
            }
        }
        void RestartGame()
        {
            //pobierz wszystkie guziki z layoutu i zapisz do listy
            List<Button> buttonList =
                        tableLayoutPanel1.Controls.OfType<Button>().ToList();
            //dla ka�dego guzika w liscie
            foreach (Button button in buttonList)
            {
                //wyczysc tekst
                button.Text = String.Empty;
            }
            //resetuj aktywnego gracza
            p.Reset();
            //zmodyfikuj labelke pokazujacy aktywnego gracza
            ActivePlayerLabel.Text = "Aktywny gracz: " + p.GetPlayer();
            wygrana = false;
        }
    }
}