using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Xamarin.Course.Exercises.XamlExtensions
{
    public partial class MainPage : ContentPage
    {
        // Just a simple user class to display in a list in the UI
        public class User {
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
        }

        // We expose test data via a static field, to make it easily accessible from XAML
        private static readonly ObservableCollection<User> TestUsers = new ObservableCollection<User>
        {
            new User { Name = "Benny Bananhue", PhoneNumber = "10203040" },
            new User { Name = "Johan Navneskifter", PhoneNumber = "30405060" },
            new User { Name = "Tonny Tupé", PhoneNumber = "20202020" },
        };

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
