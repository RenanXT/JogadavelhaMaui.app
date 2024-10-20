namespace JogadavelhaMaui.app
{
    public partial class MainPage : ContentPage
    {
        String vez = "X";
        int count = 0;
      

        public MainPage()
        {
            InitializeComponent();
        }
        
            private void Button_Clicked_1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
           
            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
                btnVez.Text = "Jogador: " + vez;
            }
            else if (vez == "O")
            {
                btn.Text = "O";
                vez = "X";
                btnVez.Text = "Jogador: " + vez;
            }
            //COMDIÇÃO PARA 'X'
            if (btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X")
            {
                DisplayAlert("Parabéns!", " X ganhou!", "OK");
                zerar();
            }
            if (btn13.Text == "X" && btn14.Text == "X" && btn15.Text == "X")
            {
                DisplayAlert("Parabéns!", " X ganhou!", "OK");
                zerar();
            }
            if (btn16.Text == "X" && btn17.Text == "X" && btn18.Text == "X")
            {
                DisplayAlert("Parabéns!", " X ganhou!", "OK");
                zerar();
            }
            if (btn10.Text == "X" && btn14.Text == "X" && btn18.Text == "X")
            {
                DisplayAlert("Parabéns!", " X ganhou!", "OK");
                zerar();
            }
            if (btn12.Text == "X" && btn14.Text == "X" && btn16.Text == "X")
            {
                DisplayAlert("Parabéns!", " X ganhou!", "OK");
                zerar();
            }
            if (btn10.Text == "X" && btn13.Text == "X" && btn16.Text == "X")
            {
                DisplayAlert("Parabéns!", " X ganhou!", "OK");
                zerar();
            }
            if (btn11.Text == "X" && btn14.Text == "X" && btn17.Text == "X")
            {
                DisplayAlert("Parabéns!", " X ganhou!", "OK");
                zerar();
            }
            if (btn12.Text == "X" && btn15.Text == "X" && btn18.Text == "X")
            {
                DisplayAlert("Parabéns!", " X ganhou!", "OK");
                zerar();
            }



            // CONDIÇÃO PARA 'O'
            if (btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O")
            {
                DisplayAlert("Parabéns!", " O ganhou!", "OK");
                zerar();
            }
            if (btn13.Text == "O" && btn14.Text == "O" && btn15.Text == "O")
            {
                DisplayAlert("Parabéns!", " O ganhou!", "OK");
                zerar();
            }
            if (btn16.Text == "O" && btn17.Text == "O" && btn18.Text == "O")
            {
                DisplayAlert("Parabéns!", " O ganhou!", "OK");
                zerar();
            }
            if (btn10.Text == "O" && btn14.Text == "O" && btn18.Text == "O")
            {
                DisplayAlert("Parabéns!", " O ganhou!", "OK");
                zerar();
            }
            if (btn12.Text == "O" && btn14.Text == "O" && btn16.Text == "O")
                {
                    DisplayAlert("Parabéns!", " O ganhou!", "OK");
                    zerar();
                }
            if (btn10.Text == "O" && btn13.Text == "O" && btn16.Text == "O")
            {
                DisplayAlert("Parabéns!", " O ganhou!", "OK");
                zerar();
            }
            if (btn11.Text == "O" && btn14.Text == "O" && btn17.Text == "O")
            {
                DisplayAlert("Parabéns!", " O ganhou!", "OK");
                zerar();
            }
            if (btn12.Text == "O" && btn15.Text == "O" && btn18.Text == "O")
            {
                DisplayAlert("Parabéns!", " O ganhou!", "OK");
                zerar();
            }

        }//metodo
        void zerar()
        {
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn13.Text = "";
            btn14.Text = "";
            btn15.Text = "";
            btn16.Text = "";
            btn17.Text = "";
            btn18.Text = "";

            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn13.IsEnabled = true;
            btn14.IsEnabled = true;
            btn15.IsEnabled = true;
            btn16.IsEnabled = true;
            btn17.IsEnabled = true;
            btn18.IsEnabled = true;
        }

      

        private void btnVez_Clicked(object sender, EventArgs e)
        {
          
        }
    }//classe
}//namespace
        
