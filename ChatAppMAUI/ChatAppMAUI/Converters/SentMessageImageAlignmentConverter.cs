using System.Globalization;

namespace ChatAppMAUI.Converters;

public class SentMessageImageAlignmentConverter : IValueConverter
{
	public SentMessageImageAlignmentConverter()
	{

	}

    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool isSentByFirstUser && isSentByFirstUser)
        {
            return LayoutOptions.Start; // Align image to the left for first user's messages
        }
        return LayoutOptions.End; // Align image to the right for other user's messages
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}