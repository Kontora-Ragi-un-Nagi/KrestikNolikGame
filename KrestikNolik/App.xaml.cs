using KrestikNolik.Resources;

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace KrestikNolik
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application

    {
        App()
        {
            MyStrings.Culture = new CultureInfo("lv-LV");
        }
    }
}
