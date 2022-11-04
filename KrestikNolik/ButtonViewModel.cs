using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Media;


namespace KrestikNolik
{
    public class ButtonViewModel
    {
        public string Content { get; set; }
        public ImageBrush BackFon { get; set; }
        public int Row { get; set; }
        public int Column { get; set; }

        public ICommand Command { get; set; }

        private Button btn = new Button();
        public Button Btn
        {
            get { return btn; }
            set { btn = value; }
        }

        public ButtonViewModel(Button btnNew, ImageBrush Fon, int row = 0, int column = 0, ICommand command = null)
        {
           
            Row = row;
            Column = column;
            Command = command;
            Btn = new Button();
            Btn = btnNew;
            BackFon = Fon;
            Content = btnNew.Name;

            // https://ru.stackoverflow.com/questions/820783/c-wpf-%D0%9A%D0%B0%D0%BA-%D0%B2-%D0%BA%D0%BE%D0%B4%D0%B5-%D1%81%D0%BE%D0%B7%D0%B4%D0%B0%D1%82%D1%8C-%D0%BA%D0%BD%D0%BE%D0%BF%D0%BA%D0%B8-%D0%B2-%D1%83%D0%BA%D0%B0%D0%B7%D0%B0%D0%BD%D0%BD%D1%8B%D1%85-%D1%8F%D1%87%D0%B5%D0%B9%D0%BA%D0%B0%D1%85-%D0%B3%D1%80%D0%B8%D0%B4%D0%B0
        }
    }
}
