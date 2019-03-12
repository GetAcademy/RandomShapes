using System;

namespace RandomBoxes
{
    class Text : Shape
    {
        private string _text;
        private int _x;
        private int _y;

        public Text(int x, int y, string text, Random random) : base(random)
        {
            _y = y;
            _x = x;
            _text = text;
        }

        public override string GetCharacter(int row, int col)
        {
            if (row != _y || col < _x || col >= _x + _text.Length) return null;
            var index = col - _x;
            return _text[index].ToString();
        }
    }
}
