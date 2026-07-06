using NewsApp.Models;
using NewsApp.Services;

namespace NewsApp.Pages;

public partial class NewsListPage : ContentPage
{
    public NewsListPage(string categoryName)
    {
        InitializeComponent();
        Title = categoryName;
        LoadNews(categoryName);
    }

    private async void LoadNews(string categoryName)
    {
        var apiService = new ApiService();
        var result = await apiService.GetNewsByCategoryAsync(categoryName);
        NewsCollectionView.ItemsSource = result?.articles;
    }

    private async void NewsCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is Article selectedArticle)
        {
            await Navigation.PushAsync(new NewsDetailPage(selectedArticle));
            NewsCollectionView.SelectedItem = null;
        }
    }
}