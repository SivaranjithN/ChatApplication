using ChatAppMAUI.View;
using CommunityToolkit.Maui.Views;

namespace ChatAppMAUI
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var popup = new MenuPopUp();
            this.ShowPopup(popup);
        }

        private async void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            if (SearchBarControl.IsVisible)
            {
                // Fade out and hide the SearchBar
                await SearchBarControl.FadeTo(0, 250);
                SearchBarControl.IsVisible = false;
            }
            else
            {
                // Show and fade in the SearchBar
                SearchBarControl.IsVisible = true;
                await SearchBarControl.FadeTo(1, 250);
                SearchBarControl.Focus();  // Optional: focus the SearchBar for user input
            }
        }
    }
}
