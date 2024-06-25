using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Controls;

namespace KrestikNolik
{
    public class Pole_Status
        // состояние ячейки игрового поля
    {
        public string PoleTag { get; set; }

        private int poleStatus = 0;
        public int PoleStatus
        {
            get { return poleStatus; }
            set { poleStatus = value; }
        }
        private Button btn = new Button();
        public Button Btn
        {
            get { return btn; }
            set { btn = value; }
        }

        public Pole_Status( string pNum )
        {
            PoleTag=pNum;
            PoleStatus = 0;
            Btn = new Button();
        }
    }
 }
