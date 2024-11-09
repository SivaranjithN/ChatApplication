using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ChatAppMAUI.Model;
using ChatAppMAUI.View;
namespace ChatAppMAUI.ViewModel;

public class ChatViewModel : INotifyPropertyChanged
{
    private string? _currentMessage;
    private string? _senderName;

    public ObservableCollection<ChatMessage> Messages { get; set; }

    public Dictionary<string, ObservableCollection<ChatMessage>> ChatHistories { get; set; }

    public ObservableCollection<ChatMessage> ChatMessages { get; set; }

    public string? CurrentMessage
    {
        get => _currentMessage;
        set
        {
            _currentMessage = value;
            OnPropertyChanged();
        }
    }

    public string? SenderName
    {
        get => _senderName;
        set
        {
            _senderName = value;
            OnPropertyChanged();
        }
    }

    private string currentPerson = "";
    public string CurrentPerson
    {
        get => currentPerson;
        set
        {
            currentPerson = value;
            OnPropertyChanged(nameof(CurrentPerson));
        }
    }


    public ICommand SendMessageCommand { get; }

    public ChatViewModel()
    {
        Messages = new ObservableCollection<ChatMessage>();
        ChatMessages = new ObservableCollection<ChatMessage>();
        ChatHistories = new Dictionary<string, ObservableCollection<ChatMessage>>();
        SendMessageCommand = new Command<string>(SendMessage);

        Messages = new ObservableCollection<ChatMessage>();
;   }

    private bool _isIncoming = false;

    public bool IsIncoming1
    {
        get => _isIncoming;
        set
        {
            if (_isIncoming != value)
            {
                _isIncoming = value;
                OnPropertyChanged();
            }
        }
    }

    public List<string> ImageCollection = new List<string>() 
    {   "people_circle4.png",
        "people_circle6.png",
        "people_circle7.png",
        "people_circle8.png",
        "people_circle9.png",
        "people_circle10.png",
        "people_circle11.png",
        "people_circle12.png",
        "people_circle13.png",
        "people_circle14.png",
        "people_circle15.png",
        "people_circle16.png",
        "people_circle17.png",
        "people_circle18.png",
        "people_circle4.png"
    };
    

    private void SendMessage(string messageText)
    {
        if (string.IsNullOrWhiteSpace(messageText))
            return;
       
        Messages.Add(new ChatMessage { Text = messageText, User = "User1", IsIncoming = IsIncoming1, Time = DateTime.Now.ToString(), UserImage = "people_circle5.png" });       
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}


public class StatusViewModel
{
    public ObservableCollection<StatusItem> StatusCollection { get; set; }
    public StatusViewModel()
    {
        StatusCollection = new ObservableCollection<StatusItem>
            {
                new StatusItem { ProfileImage = "people_circle4.png", Name = "+62 878-3063-3111", Timestamp = "16:14" , IsStatusAdded = true},
                new StatusItem { ProfileImage = "people_circle5.png", Name = "+62 831-2227-1318",  Timestamp = "Yesterday", IsStatusAdded = false },
                new StatusItem { ProfileImage = "people_circle6.png", Name = "+62 896-7551-1748",  Timestamp = "17/11/17" , IsStatusAdded = true},
                new StatusItem { ProfileImage = "people_circle7.png", Name = "+62 858-0223-7963", Timestamp = "10/9/17" , IsStatusAdded = true },
                new StatusItem { ProfileImage = "people_circle8.png", Name = "U", Timestamp = "9/7/17" , IsStatusAdded = false },
                new StatusItem { ProfileImage = "people_circle9.png", Name = "Mandha",  Timestamp = "5/2/17" , IsStatusAdded = false},
                new StatusItem { ProfileImage = "people_circle10.png", Name = "+62 878-3063-3111", Timestamp = "16:14" , IsStatusAdded = true},
                new StatusItem { ProfileImage = "people_circle11.png", Name = "+62 831-2227-1318",  Timestamp = "Yesterday", IsStatusAdded = false },
                new StatusItem { ProfileImage = "people_circle12.png", Name = "+62 896-7551-1748",  Timestamp = "17/11/17", IsStatusAdded = true },
                new StatusItem { ProfileImage = "people_circle13.png", Name = "+62 858-0223-7963",  Timestamp = "10/9/17" , IsStatusAdded = true},
                new StatusItem { ProfileImage = "people_circle14.png", Name = "U",  Timestamp = "9/7/17", IsStatusAdded = false },
                new StatusItem { ProfileImage = "people_circle15.png", Name = "Mandha",  Timestamp = "5/2/17" , IsStatusAdded = false}
            };
    }
}

public class StatusItem
{
    public required string ProfileImage { get; set; }
    public required string Name { get; set; }
    public required string Timestamp { get; set; }

    public bool IsStatusAdded { get; set; }
}

public class ChatsViewModel
{
    public ObservableCollection<ChatItem> Chats { get; set; }

    public ChatsViewModel()
    {
        Chats = new ObservableCollection<ChatItem>
            {
                new ChatItem { ProfileImage = "people_circle4.png", Name = "+62 878-3063-3111", Message = "Pagi me", Timestamp = "16:14" },
                new ChatItem { ProfileImage = "people_circle14.png", Name = "+62 831-2227-1318", Message = "Waiting for this message...", Timestamp = "Yesterday" },
                new ChatItem { ProfileImage = "people_circle18.png", Name = "+62 896-7551-1748", Message = "Waiting for this message...", Timestamp = "17/11/17" },
                new ChatItem { ProfileImage = "people_circle8.png", Name = "+62 858-0223-7963", Message = "You were added", Timestamp = "10/9/17" },
                new ChatItem { ProfileImage = "people_circle14.png", Name = "U", Message = "You were added", Timestamp = "9/7/17" },
                new ChatItem { ProfileImage = "people_circle9.png", Name = "Mandha", Message = "You were added", Timestamp = "5/2/17" },
                new ChatItem { ProfileImage = "people_circle10.png", Name = "+62 878-3063-3111", Message = "Pagi me", Timestamp = "16:14" },
                new ChatItem { ProfileImage = "people_circle11.png", Name = "+62 831-2227-1318", Message = "Waiting for this message...", Timestamp = "Yesterday" },
                new ChatItem { ProfileImage = "people_circle12.png", Name = "+62 896-7551-1748", Message = "Waiting for this message...", Timestamp = "17/11/17" },
                new ChatItem { ProfileImage = "people_circle13.png", Name = "+62 858-0223-7963", Message = "You were added", Timestamp = "10/9/17" },
                new ChatItem { ProfileImage = "people_circle14.png", Name = "U", Message = "You were added", Timestamp = "9/7/17" },
                new ChatItem { ProfileImage = "people_circle15.png", Name = "Mandha", Message = "You were added", Timestamp = "5/2/17" },
                new ChatItem { ProfileImage = "people_circle4.png", Name = "+62 878-3063-3111", Message = "Pagi me", Timestamp = "16:14" },
                new ChatItem { ProfileImage = "people_circle5.png", Name = "+62 831-2227-1318", Message = "Waiting for this message...", Timestamp = "Yesterday" },
                new ChatItem { ProfileImage = "people_circle6.png", Name = "+62 896-7551-1748", Message = "Waiting for this message...", Timestamp = "17/11/17" },
                new ChatItem { ProfileImage = "people_circle7.png", Name = "+62 858-0223-7963", Message = "You were added", Timestamp = "10/9/17" },
                new ChatItem { ProfileImage = "people_circle8.png", Name = "U", Message = "You were added", Timestamp = "9/7/17" },
                new ChatItem { ProfileImage = "people_circle9.png", Name = "Mandha", Message = "You were added", Timestamp = "5/2/17" },
                new ChatItem { ProfileImage = "people_circle10.png", Name = "+62 878-3063-3111", Message = "Pagi me", Timestamp = "16:14" },
                new ChatItem { ProfileImage = "people_circle11.png", Name = "+62 831-2227-1318", Message = "Waiting for this message...", Timestamp = "Yesterday" },
                new ChatItem { ProfileImage = "people_circle12.png", Name = "+62 896-7551-1748", Message = "Waiting for this message...", Timestamp = "17/11/17" },
                new ChatItem { ProfileImage = "people_circle13.png", Name = "+62 858-0223-7963", Message = "You were added", Timestamp = "10/9/17" },
                new ChatItem { ProfileImage = "people_circle14.png", Name = "U", Message = "You were added", Timestamp = "9/7/17" },
                new ChatItem { ProfileImage = "people_circle15.png", Name = "Mandha", Message = "You were added", Timestamp = "5/2/17" }
            };
    }
}

public class ChatItem
{
    public required string ProfileImage { get; set; }
    public required string Name { get; set; }
    public required string Message { get; set; }
    public required string Timestamp { get; set; }
}


public class CallsViewModel
{
    public ObservableCollection<CallItem> CallsCollection { get; set; }
    public CallsViewModel()
    {
        CallsCollection = new ObservableCollection<CallItem>
        {
            new CallItem { ProfileImage = "people_circle4.png", Name = "+62 878-3063-3111", CallImage = "call.png", Timestamp = "16:14"  },
            new CallItem { ProfileImage = "people_circle4.png", Name = "+62 878-3063-3111", CallImage = "videocall.png", Timestamp = "Yesterday" },
            new CallItem { ProfileImage = "people_circle4.png", Name = "+62 878-3063-3111", CallImage = "videocall.png" , Timestamp = "17/11/17" },
            new CallItem { ProfileImage = "people_circle4.png", Name = "+62 878-3063-3111", CallImage = "missedcall.png" , Timestamp = "10/9/17"},
            new CallItem { ProfileImage = "people_circle4.png", Name = "+62 878-3063-3111", CallImage = "call.png" , Timestamp = "9/7/17" },
            new CallItem { ProfileImage = "people_circle4.png", Name = "+62 878-3063-3111", CallImage = "call.png" , Timestamp = "Yesterday" },
            new CallItem { ProfileImage = "people_circle4.png", Name = "+62 878-3063-3111", CallImage = "missedcall.png" , Timestamp = "17/11/17" },
            new CallItem { ProfileImage = "people_circle4.png", Name = "+62 878-3063-3111", CallImage = "videocall.png", Timestamp = "16:14" },
            new CallItem { ProfileImage = "people_circle4.png", Name = "+62 878-3063-3111", CallImage = "missedcall.png" , Timestamp = "17/11/17" },
            new CallItem { ProfileImage = "people_circle4.png", Name = "+62 878-3063-3111", CallImage = "call.png" , Timestamp = "16:14"  },
            new CallItem { ProfileImage = "people_circle4.png", Name = "+62 878-3063-3111", CallImage = "videocall.png" , Timestamp = "17/11/17"},
            new CallItem { ProfileImage = "people_circle4.png", Name = "+62 878-3063-3111", CallImage = "videocall.png" , Timestamp = "16:14"  },
            new CallItem { ProfileImage = "people_circle4.png", Name = "+62 878-3063-3111", CallImage = "missedcall.png" , Timestamp = "10/9/17" },
            new CallItem { ProfileImage = "people_circle4.png", Name = "+62 878-3063-3111", CallImage = "call.png", Timestamp = "17/11/17"  }
        };
    }
}


public class CallItem
{
    public required string ProfileImage { get; set; }
    public required string Name { get; set; }

    public required string CallImage { get; set; }

    public required string Timestamp { get; set; }
}

public class ChatService
{
    private List<ChatMessage> _conversationHistory;

    public ChatService()
    {
        _conversationHistory = new List<ChatMessage>();
    }

    // Save conversation
    public void SaveConversation(List<ChatMessage> messages)
    {
        _conversationHistory = messages;
    }

    // Load conversation
    public List<ChatMessage> LoadConversation()
    {
        return _conversationHistory;
    }
}

