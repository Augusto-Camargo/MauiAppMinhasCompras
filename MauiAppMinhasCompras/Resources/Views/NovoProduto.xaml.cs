using MauiAppMinhasCompras.Properties.Models;

namespace MauiAppMinhasCompras.Resources.Views;

public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}

    private async Task ToolbarItem_Clicked(object sender, EventArgs e)
    {
		try
		{
			Produto p = new Produto
			{
				Descricao = txt_descricao.Text,
				Quantidade = Convert.ToDouble(txt_quantidade.Text),
				Preco = Convert.ToDouble(txt_preco.Text)
			};

			await App.Db.Insert(p);
			await DisplayAlert("Sucesso", "Produto cadastrado com sucesso!", "OK");
        }
		catch (Exception ex)
		{
			await DisplayAlert("ops", ex.Message, "ok");

        }
    }
}