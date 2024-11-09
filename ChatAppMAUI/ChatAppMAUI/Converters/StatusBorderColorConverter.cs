using System.Globalization;

namespace ChatAppMAUI.Converters;

public class StatusBorderColorConverter : IValueConverter
{
	public StatusBorderColorConverter()
	{

	}

    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        bool isStatusAdded = (bool)value;
        return isStatusAdded ? Colors.Green : Colors.LightGray;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}