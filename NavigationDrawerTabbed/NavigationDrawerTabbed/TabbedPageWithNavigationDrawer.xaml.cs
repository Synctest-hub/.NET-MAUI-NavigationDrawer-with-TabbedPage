using Syncfusion.Maui.NavigationDrawer;
using System.Collections.ObjectModel;

namespace NavigationDrawerTabbed;

public partial class TabbedPageWithNavigationDrawer : TabbedPage
{
	public TabbedPageWithNavigationDrawer()
	{
        InitializeComponent();
    }

    private void hamburgerButton1_Clicked(object sender, EventArgs e)
    {
        navigationDrawer1.ToggleDrawer();
    }

    private void hamburgerButton2_Clicked(object sender, EventArgs e)
    {
        navigationDrawer2.ToggleDrawer();
    }
}