using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverterMauiApp.Converters
{
    internal class GradeToTextGradeConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if(value == null
                || value is not string)
            {
                throw new ArgumentNullException("Błędna wartość");
            }

            string grade = value as string;

            string textGrade = grade switch
            {
                "1" => "Niedostateczny",
                "2" => "Dopuszczający",
                "3" => "Dostateczny",
                "4" => "Dobry",
                "5" => "Bardzo Dobry",
                "6" => "Celujący",
                _ => "Błędne dane"
            };
            return textGrade;
        }
        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
