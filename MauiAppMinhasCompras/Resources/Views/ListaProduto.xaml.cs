
using MauiAppMinhasCompras.Properties.Models;
using System.Collections.ObjectModel;

namespace MauiAppMinhasCompras.Resources.Views;

public partial class ListaProduto : ContentPage
{

    ObservableCollection<Produto> Lista = new ObservableCollection<Produto>();
    public ListaProduto()
    {
        InitializeComponent();

        lst.ItemsSource = Lista;
    }

    protected async override void OnAppearing() {

        List<Produto> tmp = await App.Db.GetAll();

        tmp.ForEach(i => Lista.Add(i));

    }

    private void ToolbarItem_Clicked(object sender, EventArgs e)
    {

        try
        {

            Navigation.PushAsync(new Views.NovoProduto());

        }
        catch (Exception ex)
        {
            DisplayAlert("ops", ex.Message, "ok");
        }

    }

    private async void txt_search_TextChagend(BindableObject sender, TextChangedEventArgs e)
    {
        string q = e.NewTextValue;

        Lista.Clear();

        List<Produto> tmp = await App.Db.Search(q);

        tmp.ForEach(i => Lista.Add(i));
    }

    private void ToolbarItem_Clicked_1(object sender, EventArgs e)
    {
        double soma = Lista.Sum(i => i.Total);

        string msg = $"o Total é {soma:C}";
         
        DisplayAlert("Total dos Produtos", msg, "OK");
    }

    private void MenuItem_Clicked(object sender, EventArgs e)
    {



    }
}