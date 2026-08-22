namespace MauiAppMinhasCompras.Resources.Views;

public partial class ListaProduto : ContentPage
{
	public ListaProduto()
	{
		InitializeComponent();
	}

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {

		try
		{

			Navigation.PushAsync(new Views.NovoProduto());

        }
		catch(Exception ex)
		{
			DisplayAlert("ops", ex.Message, "ok");
		}

    }

    private void ToolbarItem_Clicked_1(object sender, EventArgs e)
    {
        try
        {

           

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "ok");
        }

    }
}