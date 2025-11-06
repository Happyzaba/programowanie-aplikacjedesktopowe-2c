using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminMauiApp
{
    internal class Viewmodel : BindableObject
    {
        private int r = 255;
        private int g = 255;
        private int b = 255;
        private Color boxColor;
        private Color baseColor = Colors.White;
        private string textRGB = "255, 255, 255";
        public int RValue
        {
            get => r;
            set
            {
                r = value;
                OnPropertyChanged();
                ColorUpdate();
            }
        }
        public int GValue
        {
            get => g;
            set
            {
                g = value;
                OnPropertyChanged();
                ColorUpdate();
            }
        }

        public int BValue
        {
            get => b;
            set
            {
                b = value;
                OnPropertyChanged();
                ColorUpdate();
            }
        }

        public Color ColorBox
        {
            get => boxColor;
            set
            {
                boxColor = value;
                OnPropertyChanged();
            }
        }

        public Color BaseColor
        {
            get => baseColor;
            set
            {
                baseColor = value;
                OnPropertyChanged();
            }
        }

        public string TextRGB
        {
            get => textRGB;
            set
            {
                textRGB = value;
                OnPropertyChanged();
            }
        }
        public Command GetColorCommand { get; set; }

        public Viewmodel()
        {
            GetColorCommand = new Command(UpdateColor);
            ColorUpdate();
        }
        private void ColorUpdate()
        {
            ColorBox = Color.FromRgb(RValue, GValue, BValue);
        }
        private void UpdateColor()
        {
            BaseColor = Color.FromRgb(RValue, GValue, BValue);
            TextRGB = $"{RValue}, {GValue}, {BValue}";
        }

    }
}
