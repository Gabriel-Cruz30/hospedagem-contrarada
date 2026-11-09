

namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
    public ContratacaoHospedagem()
    {
        InitializeComponent();

        pck_quarto.Items.Add("Suíte Standard");
        pck_quarto.Items.Add("Suíte Luxo");
        pck_quarto.Items.Add("Suíte Presidencial");

        dtpck_checkin.MinimumDate = DateTime.Today;
        dtpck_checkin.Date = DateTime.Today;

        dtpck_checkout.MinimumDate = DateTime.Today.AddDays(1);
        dtpck_checkout.Date = DateTime.Today.AddDays(1);
    }

    private async void Avancar_Clicked(object sender, EventArgs e)
    {
        if (pck_quarto.SelectedIndex == -1)
        {
            await DisplayAlertAsync("Atenção", "Selecione uma acomodação.", "OK");
            return;
        }

        if (dtpck_checkout.Date <= dtpck_checkin.Date)
        {
            await DisplayAlertAsync("Atenção", "O check-out deve ser posterior ao check-in.", "OK");
            return;
        }

        await Navigation.PushAsync(new HospedagemContratada());
    }

    private async void Sobre_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Sobre());
    }
}
