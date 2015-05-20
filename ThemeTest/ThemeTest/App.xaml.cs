using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ThemeTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            SetDefaultStyle();
            MainPage = new TestPage();
        }

        public void SetDefaultStyle()
        {
            Resources = Default;
        }

        public void SetSecondStyle()
        {
            Resources = Second;
        }
    }
}
