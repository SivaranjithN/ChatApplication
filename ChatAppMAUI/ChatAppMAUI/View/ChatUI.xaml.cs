using ChatAppMAUI.ViewModel;

namespace ChatAppMAUI.View;

public partial class ChatUI : ContentPage
{
    private ChatViewModel _viewModel;

    public ChatUI()
	{
		InitializeComponent();
        _viewModel = new ChatViewModel();
        this.BindingContext = _viewModel;
    }
}