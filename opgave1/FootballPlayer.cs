using System;

namespace opgave1
{
    public class FootballPlayer
    {
        private int _id;
        private string _name;
        private int _price;
        private int _shirtNumber;

        public FootballPlayer(int id, string name, int price, int shirtNumber)
        {
            _id = id;
            _name = name;
            _price = price;
            _shirtNumber = shirtNumber;
        }
        public int ID { get; set; }

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 4) throw new ArgumentOutOfRangeException();
                _name = value;
            }
        }
        public int Price {
            get => _price;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException();
                _price = value;
            }
        }

        public int ShirtNumber
        {
            get => _shirtNumber;
            set
            {
                if ((value < 0) || (value > 100)) throw new ArgumentOutOfRangeException();
                _shirtNumber = value;
            }
        }

    }
}
