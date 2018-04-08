using Xamarin.Forms;

namespace Tour_Guide
{
    public partial class Tour_GuidePage : MasterDetailPage
    {
       
        public Tour_GuidePage()
        {
            InitializeComponent();
            Detail = new NavigationPage(new Homepage()) { BarTextColor = Color.Black } ;
        }

        void Home_Button(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Homepage()) { BarTextColor = Color.Black } ;
            IsPresented = false;
        }
        void Trail_Button(object sender, System.EventArgs e)
        {
            DisplayAlert("Demo", "Only the river side walk is availible during this demo", "OK");
            Detail = new NavigationPage(new Trails()) { BarTextColor = Color.Black } ;
            IsPresented = false;
        }

        void About_Button(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new About()) { BarTextColor = Color.Black } ;
            IsPresented = false;
        }

        void Register_Button(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Register()) { BarTextColor = Color.Black };
            IsPresented = false;
        }

        void Feedback_Button(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Feedback()) { BarTextColor = Color.Black };
            IsPresented = false;
        }


    }
}
