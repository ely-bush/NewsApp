namespace NewsApp.Pages;

public class NewsCategory
{ 
	public string Name { get; set; }
	public string Image { get; set; }
}
public partial class NewsHomePage : ContentPage
{
	public NewsHomePage()
	{
		InitializeComponent();

		CategoryCollectionView.ItemsSource = new List<NewsCategory>
		{new NewsCategory { Name = "Technology", Image = "technology.png" },
            new NewsCategory { Name = "Sports", Image = "sports.png" },
            new NewsCategory { Name = "Health", Image = "health.png" },
            new NewsCategory { Name = "Science", Image = "science.png" },
            new NewsCategory { Name = "Business", Image = "business.png" },
            new NewsCategory { Name = "Entertainment", Image = "entertainment.png" },
            new NewsCategory { Name = "World", Image = "world.png" },
            new NewsCategory { Name = "Nation", Image = "nation.png" },
        };
    }

    private async void CategoryCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    { 
        if (e.CurrentSelection.FirstOrDefault() is NewsCategory selectedCategory)
        {
            await Navigation.PushAsync(new NewsListPage(selectedCategory.Name.ToLower()));
            CategoryCollectionView.SelectedItem = null;
        }
    }
}