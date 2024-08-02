# .NET-MAUI-NavigationDrawer-with-TabbedPage
This sample demonstrates how to add a navigation drawer to a TabbedPage.

##  Adding a .NET MAUI NavigationDrawer reference
Syncfusion .NET MAUI controls are available in Nuget.org. To add .NET MAUI Tab View to your project, open the NuGet package manager in Visual Studio, search for Syncfusion.Maui.NavigationDrawer and then install it.

## Creating the project
Create a new .NET MAUI application in Visual Studio.

## Create a Tabbed Page with Two Tab Items

Prepare the Tabbed Page with two tab items, named First Page and Second Page. Add the Navigation Drawer to each page.

**XAML**

```
<TabbedPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
            xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
            x:Class="NavigationDrawerTabbed.TabbedPageWithNavigationDrawer"
            xmlns:navigationdrawer="clr-namespace:Syncfusion.Maui.NavigationDrawer;assembly=Syncfusion.Maui.NavigationDrawer"
            Title="TabbedPageWithNavigationDrawer">
  <NavigationPage Title="First Page">
      <x:Arguments>
          <ContentPage>
          <navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer1">
              <navigationdrawer:SfNavigationDrawer.DrawerSettings>
                  <navigationdrawer:DrawerSettings DrawerWidth="200"
                                                   TouchThreshold="100"
                                                   DrawerHeaderHeight="50"
                                                   DrawerFooterHeight="50">
                      <!-- Drawer Header View -->
                      <!-- ... -->
                          <navigationdrawer:DrawerSettings.DrawerContentView>
                              <Grid>
                                  <Label Text="Content View" FontSize="14" TextColor="Black"  VerticalTextAlignment="Center" HorizontalTextAlignment="Center"/>
                              </Grid>
                          </navigationdrawer:DrawerSettings.DrawerContentView>
                      <!-- Drawer Footer View -->
                      <!-- ... -->
                  </navigationdrawer:DrawerSettings>
              </navigationdrawer:SfNavigationDrawer.DrawerSettings>

              <navigationdrawer:SfNavigationDrawer.ContentView>
                  <Grid x:Name="mainContentView1" 
    BackgroundColor="White" RowDefinitions="Auto,*">
                      <HorizontalStackLayout BackgroundColor="#6750A4" Spacing="10" Padding="5,0,0,0">
                          <ImageButton x:Name="hamburgerButton1"
                       HeightRequest="50"
                       WidthRequest="50"
                       HorizontalOptions="Start"
                       Source="hamburgericon.png"
                       BackgroundColor="#6750A4"
                       Clicked="hamburgerButton1_Clicked"/>
                          <Label x:Name="headerLabel"
                                 HeightRequest="50"
                                 HorizontalTextAlignment="Center"
                                 VerticalTextAlignment="Center"
                                 Text="Home" FontSize="16"
                                 TextColor="White"
                                 BackgroundColor="#6750A4"/>
                      </HorizontalStackLayout>

                      <Label Grid.Row="1"
                             Text="First Page"
                             VerticalOptions="Center"
                             HorizontalOptions="Center" />
                  </Grid>
              </navigationdrawer:SfNavigationDrawer.ContentView>
          </navigationdrawer:SfNavigationDrawer>
          </ContentPage>
      </x:Arguments>
  </NavigationPage>
  <NavigationPage Title="Second Page">
      <x:Arguments>
          <ContentPage>
              <navigationdrawer:SfNavigationDrawer x:Name="navigationDrawer2">
                  <navigationdrawer:SfNavigationDrawer.DrawerSettings>
                      <navigationdrawer:DrawerSettings DrawerWidth="150"
                                                       TouchThreshold="100"
                                                       DrawerHeaderHeight="100"
                                                       DrawerFooterHeight="100">
                          <!-- Drawer Header View -->
                          <!-- ... -->
                          <navigationdrawer:DrawerSettings.DrawerContentView>
                              <Grid>
                                  <Label Text="Content View" FontSize="14" TextColor="Black"  VerticalTextAlignment="Center" HorizontalTextAlignment="Center"/>
                              </Grid>
                          </navigationdrawer:DrawerSettings.DrawerContentView>
                         <!-- Drawer Footer View -->
                         <!-- ... -->
                      </navigationdrawer:DrawerSettings>
                  </navigationdrawer:SfNavigationDrawer.DrawerSettings>

                  <navigationdrawer:SfNavigationDrawer.ContentView>
                      <Grid x:Name="mainContentView2" 
BackgroundColor="White" RowDefinitions="Auto,*">
                          <HorizontalStackLayout BackgroundColor="#6750A4" Spacing="10" Padding="5,0,0,0">
                              <ImageButton x:Name="hamburgerButton2"
                                           HeightRequest="50"
                                           WidthRequest="50"
                                           HorizontalOptions="Start"
                                           Source="hamburgericon.png"
                                           BackgroundColor="#6750A4"
                                           Clicked="hamburgerButton2_Clicked"/>
                              <Label x:Name="headerLabel2"
                                     HeightRequest="50"
                                     HorizontalTextAlignment="Center"
                                     VerticalTextAlignment="Center"
                                     Text="Home" FontSize="16"
                                     TextColor="White"
                                     BackgroundColor="#6750A4"/>
                          </HorizontalStackLayout>

                          <Label Grid.Row="1"
                                 Text="Second Page"
                                 VerticalOptions="Center"
                                 HorizontalOptions="Center" />
                      </Grid>
                  </navigationdrawer:SfNavigationDrawer.ContentView>
              </navigationdrawer:SfNavigationDrawer>
          </ContentPage>
      </x:Arguments>
  </NavigationPage>
</TabbedPage>
```

**C#**

```
private void hamburgerButton1_Clicked(object sender, EventArgs e)
{
    navigationDrawer1.ToggleDrawer();
}

private void hamburgerButton2_Clicked(object sender, EventArgs e)
{
    navigationDrawer2.ToggleDrawer();
}
```

## Project pre-requisites

Make sure that you have the compatible versions of Visual Studio with .NET MAUI workloads and .NET SDK version in your machine before starting to work on this project. Refer to [System Requirements for .NET MAUI](https://help.syncfusion.com/maui/system-requirements).

## How to run this application?

To run this application, you need to first clone the .NET-MAUI-NavigationDrawer-with-TabbedPage repository and then open it in Visual Studio 2022. Now, simply build and run your project to view the output.

## <a name="troubleshooting"></a>Troubleshooting ##
### Path too long exception
If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.

## License

Syncfusion has no liability for any damage or consequence that may arise by using or viewing the samples. The samples are for demonstrative purposes, and if you choose to use or access the samples, you agree to not hold Syncfusion liable, in any form, for any damage that is related to use, for accessing, or viewing the samples. By accessing, viewing, or seeing the samples, you acknowledge and agree Syncfusion’s samples will not allow you seek injunctive relief in any form for any claim related to the sample. If you do not agree to this, do not view, access, utilize, or otherwise do anything with Syncfusion’s samples.