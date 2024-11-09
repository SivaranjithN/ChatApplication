using System.Globalization;

namespace ChatAppMAUI.Converters;

public class SentMessageAlignmentConverter : IValueConverter
{
	public SentMessageAlignmentConverter()
	{

	}

    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool isSentByUser && isSentByUser)
        {
            return LayoutOptions.End; // Align sent messages to the right
        }
        return LayoutOptions.Start; // Align received messages to the left
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}