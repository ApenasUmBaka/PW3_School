 x:Class="A13PAM2_appSoma.MainPage">

    <StackLayout Orientation="Vertical">
        <Frame BackgroundColor="White" Padding="24" BorderColor="Black" CornerRadius="0">
            <Label Text="Welcome to App Calculadora" HorizontalTextAlignment="Center" TextColor="Aquarine" FontSize="36"/>
        </Frame>
        <Label Text="Digite o Primeiro valor" FontSize="Title" Padding="30,10,30,10" FontAttributes="Bold"/>
        <Entry x:Name="txtnNum1" Keyboard="Numeric" HorizontalTextAlignment="Center" TextColor="Aqua" FontAttributes="None"/>
        
        <Label Text="Digite o Segundo valor" FontSize="Subtitle" Padding="30,10,30,10" FontAttributes="Bold"/>
        <Entry x:Name="txtnNum2" Keyboard="Numeric" HorizontalTextAlignment="Center" TextColor="Aqua" FontAttributes="None"/>

        <Button x:Name="btnSomar" Text="Soma"  Clicked="BtnSomar_Clicked" FontAttributes="Bold" BorderColor="DarkGreen" />
        <Button x:Name="btnMenos" Text="Subtração" Clicked="BtnMenos_Cliked" FontAtributes="Bold" BorderColor="DarkGreen" />
        <Button x:Name="btnDivisao" Text="Divisão" Clicked="BtnDivisao_Cliked" FontAtributes="Bold" BorderColor="DarkGreen" />
        <Button x:Name="btnVezes" Text="Multiplicação" Clicked="BtnVezes_Cliked" FontAtributes="Bold" BorderColor="DarkGreen" />
        <Button x:Name="btnLimpar" Text="Nova Soma"  Clicked="BtnLimpar_Clicked" FontAttributes="Bold" BorderColor="AliceBlue" />

        <Label x:Name="lblResultado" Text="Resolução" HorizontalOptions="Center" FontSize="Large"/>
    </StackLayout>





    namespace A13PAM2_appSoma
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnSomar_Clicked(object sender, EventArgs e)
        {
            try { 
            double n1 = Convert.Todouble(txtNum1.Text);
            double n2 = Convert.Todouble(txtNum2.Text);
                            
            double res = n1 + n2;


            lblResultado.Text = res.ToString();
            lblResultado.TextColor = Color.Red;
            lblResultado.HorizontalTextAlignment = TextAlignment.Center; 
        }
        catch (Exception ex)
            {
                lblResultado.Text = "Erro ! \n" + ex.Message;
            }
       }    

        private void BtnMenos_Clicked(object sender, EventArgs e) 
        { 
            try {         
            
            
                double n1 = Convert.Todouble32("txtNum1");
                double n2 = Convert.Todouble32("txtNum2");

                double res = n1 - n2;

             
                lblResultado.Text = res.ToString();
                lblResultado.TextColor = Color.Red;
                lblResultado.HorizontalTextAlignment = TextAlignment.Center;
            }
            catch (Exception ex)
            {
                lblResultado.Text = "Erro ! \n" + ex.Message;
            }
        }

        private void BtnDivisao_Clicked(object sender, EventArgs e)
        {
            try { 
            
            
                double n1 = Convert.Todouble32("txtNum1");
                double n2 = Convert.Todouble32("txtNum2");

                double res = n1 / n2;

             
                lblResultado.Text = res.ToString();
                lblResultado.TextColor = Color.Red;
                lblResultado.HorizontalTextAlignment = TextAlignment.Center;
            } 
            catch (Exception ex)
            {
                lblResultado.Text = "Erro ! \n" + ex.Message;
            }
        }

         private void BtnVezes_Clicked(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.Todouble32("txtNum1");
                double n2 = Convert.Todouble32("txtNum2");

                double res = n1 * n2;

             
                lblResultado.Text = res.ToString();
                lblResultado.TextColor = Color.Red;
                lblResultado.HorizontalTextAlignment = TextAlignment.Center;
            } 

            catch (Exception ex)
            {
                lblResultado.Text = "Erro ! \n" + ex.Message;
            }
        }

        private void BtnLimpar_Clicked(object sender, EventArgs e)
        {
            txtnNum1.Text = "";
            txtnNum2.Text = "";
            lblResultado.Text = "Resultado";


        }
    }
}
