namespace CoinTosser
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void JogarMoeda_Clicked(object sender, EventArgs e)
        {
            int valAposta = 0;
            int num = new Random().Next(2);

            string aposta = Convert.ToString(PickerLado.SelectedItem);

            if (aposta == "Coroa") { valAposta = 1; } else {  valAposta = 0; }

            if (num == 1) { Moeda.Text = "Coroa"; ImagemMoeda.Source = "coroa.png"; } else { Moeda.Text = "Cara"; ImagemMoeda.Source = "cara.png"; }

            if (valAposta == num)
            {
                Teste.Text = "Você Venceu";
            }
            else { Teste.Text = "Você Perdeu"; }
            


        }
    }

}
