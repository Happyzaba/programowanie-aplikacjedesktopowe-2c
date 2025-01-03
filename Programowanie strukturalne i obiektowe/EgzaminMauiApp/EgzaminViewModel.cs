using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgzaminMauiApp
{
    internal class EgzaminViewModel : BindableObject
    {
        private Random draw = new Random();

		private int gameResult;
		public int GameResult
		{
			get { return gameResult; }
			set { gameResult = value; OnPropertyChanged(); }
		}

		private int drawResult;
		public int DrawResult
		{
			get { return drawResult; }
			set { drawResult = value; }
		}


	}
}
