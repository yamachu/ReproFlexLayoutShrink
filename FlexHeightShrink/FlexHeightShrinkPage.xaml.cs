using Xamarin.Forms;

namespace FlexHeightShrink
{
    public partial class FlexHeightShrinkPage : ContentPage
    {
        public FlexHeightShrinkPage()
        {
            InitializeComponent();

            var flexRoot = new FlexLayout
            {
                Direction = FlexDirection.Column
            };

            var upperFlex = new FlexLayout
            {
                BackgroundColor = Color.Red
            };
            upperFlex.Children.Add(new Label
            {
                Text = "Upper"
            });
            FlexLayout.SetGrow(upperFlex, 1);

            flexRoot.Children.Add(upperFlex);

            var bottomFlex = new FlexLayout
            {
                BackgroundColor = Color.Yellow
            };
            bottomFlex.Children.Add(new Label
            {
                Text = "Bottom"
            });
            FlexLayout.SetBasis(bottomFlex, 100);

            flexRoot.Children.Add(bottomFlex);

            Content = flexRoot;
        }
    }
}
