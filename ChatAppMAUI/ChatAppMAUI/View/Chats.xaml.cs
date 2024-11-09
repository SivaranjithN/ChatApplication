using System.Collections.ObjectModel;
using ChatAppMAUI.ViewModel;

namespace ChatAppMAUI.View;

public partial class Chats : ContentView
{
	public Chats()
	{
		InitializeComponent();
        var viewModel = new ChatsViewModel();
        BindingContext = viewModel;
    }

    private async void OnChatSelected(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is ChatItem selectedChat)
        {   
            if (e.CurrentSelection.Count > 0)
            {
                var person = e.CurrentSelection[0] as ChatItem;
                string name = person!.Name;// Assuming person name or ID is used
                var chatViewModel = new ChatViewModel
                {                    
                    CurrentPerson = name, // This triggers loading of the chat history
                };

                await Navigation.PushAsync(new ChatUI
                {
                    BindingContext = chatViewModel
                });
            }

            collectionView.SelectedItem = null;

            // Force the CollectionView to refresh its state
            collectionView.SelectionMode = SelectionMode.None;
            collectionView.SelectionMode = SelectionMode.Single;
        }

    }
}