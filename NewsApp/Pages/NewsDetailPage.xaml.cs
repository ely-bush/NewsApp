using NewsApp.Models;

namespace NewsApp.Pages;

public partial class NewsDetailPage : ContentPage
{
    public NewsDetailPage(Article article)
    {
        InitializeComponent();
        ArticleImage.Source = article.image;
        ArticleTitle.Text = article.title;
        ArticleContent.Text = article.content;
    }
}