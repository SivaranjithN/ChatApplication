using System.Globalization;

namespace ChatAppMAUI.Converters;

public class SentMessageBackgroundConverter : IValueConverter
{
	public SentMessageBackgroundConverter()
	{
		
	}

    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool isSentByUser && isSentByUser)
        {
            return Colors.LightGreen; // Background color for sent messages
        }
        return Colors.White; // Background color for received messages
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}