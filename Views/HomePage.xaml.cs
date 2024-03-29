using clipboardLibrary.ViewModel;

namespace clipboardLibrary.Views;

public partial class HomePage : ContentPage
{
	private BooksViewModel _vm;
	public HomePage(BooksViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		_vm = vm;
	}

	protected async override void OnAppearing()
	{
		base.OnAppearing();
		await _vm.LoadBooks();
	}

    private async void Entry_TextChanged(object sender, TextChangedEventArgs e)
    {
		await _vm.LoadBooks();
    }
}