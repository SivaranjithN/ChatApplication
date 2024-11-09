using System.Globalization;

namespace ChatAppMAUI.Converters;

public class SentMessageAlignmentColumnConverter : IValueConverter
{
	public SentMessageAlignmentColumnConverter()
	{

	}

    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value is bool isSentByUser && isSentByUser)
        {
            return 1; // Column 1 for sent messages
        }
        return 0; // Column 0 for received messages
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}