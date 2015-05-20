using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ThemeTest
{
    public partial class TestPage : ContentPage
    {
        public TestPage()
        {
            InitializeComponent();
        }

        private void BtnDefaultStyle_OnClicked(object sender, EventArgs e)
        {
            ((App)App.Current).SetDefaultStyle();
        }

        private void BtnSecondStyle_OnClicked(object sender, EventArgs e)
        {
            ((App)App.Current).SetSecondStyle();
        }
    }
}
