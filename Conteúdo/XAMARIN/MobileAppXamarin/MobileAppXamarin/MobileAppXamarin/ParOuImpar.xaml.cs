using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileAppXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ParOuImpar : ContentView
    {
        public ParOuImpar()
        {
            InitializeComponent();
        }

        public static implicit operator Page(ParOuImpar v)
        {
            throw new NotImplementedException();
        }
    }
}