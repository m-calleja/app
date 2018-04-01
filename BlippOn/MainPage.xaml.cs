using BlippOn.Menu;
using BlippOn.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace BlippOn
{
    public partial class MainPage : MasterDetailPage
    {

        public List<MasterPageItem> menuList { get; set; }

        public MainPage()
        {

            InitializeComponent();

            menuList = new List<MasterPageItem>();
            //this are for android Icons you can download from android asset studio and include in Your Project Resources Folder
            // Creating our pages for menu navigation
            // Here you can define title for item, 
            // icon on the left side, and page that you want to open after selection
            //var page1 = new MasterPageItem() { Title = "FastDelivery", Icon = "ic_local_shipping_black_24dp.png", TargetType = typeof(View1) };
            //var page2 = new MasterPageItem() { Title = "Menus", Icon = "ic_restaurant_black_24dp", TargetType = typeof(View2) };
            //var page3 = new MasterPageItem() { Title = "Free Pizza", Icon = "ic_local_pizza_black_24dp.png", TargetType = typeof(View3) };
            //var page4 = new MasterPageItem() { Title = "Dining", Icon = "ic_local_dining_black_24dp.png", TargetType = typeof(View4) };
            //var page5 = new MasterPageItem() { Title = "Parking", Icon = "ic_local_parking_black_24dp.png", TargetType = typeof(View3) };
            //var page6 = new MasterPageItem() { Title = "LocateUs", Icon = "ic_my_location_black_24dp.png", TargetType = typeof(View2) };

            //Fot Ios icons
            var page1 = new MasterPageItem() { Title = "Find a Service", Icon = "ic_shortcut_search.png", TargetType = typeof(FindService) };
            var page2 = new MasterPageItem() { Title = "Games", Icon = "ic_shortcut_videogame_assets.png", TargetType = typeof(Games) };
            var page3 = new MasterPageItem() { Title = "Redeem Offers", Icon = "ic_shortcut_redeem.png", TargetType = typeof(Redeem_Offers) };
            var page4 = new MasterPageItem() { Title = "Explore" , Icon = "ic_shortcut_explore.png", TargetType = typeof(Explore) };
            var page5 = new MasterPageItem() { Title = "Messages", Icon = "ic_local_parking.png", TargetType = typeof(Messages) };
            var page6 = new MasterPageItem() { Title = "Settings", Icon = "ic_shortcut_settings.png", TargetType = typeof(Settings) };
            // Adding menu items to menuList
            menuList.Add(page1);
            menuList.Add(page2);
            menuList.Add(page3);
            menuList.Add(page4);
            menuList.Add(page5);
            menuList.Add(page6);


            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;
            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(ViewMain)));
            this.BindingContext = new
            {
                Header = "",
                Image = "http://www3.hilton.com/resources/media/hi/GSPSCHF/en_US/img/shared/full_page_image_gallery/main/HH_food_22_675x359_FitToBoxSmallDimension_Center.jpg",
                //Footer = "         -------- Welcome To HotelPlaza --------           "
                Footer = "Welcome To Blippon"
            };
        }



        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterPageItem)e.SelectedItem;
            Type page = item.TargetType;
            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
    }
}
