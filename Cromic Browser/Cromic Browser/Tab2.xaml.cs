using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Popups;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace Cromic_Browser
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Tab2 : Page
    {
        int[] activeTabIndicator = { 0, 1, 0, 0, 0, 0, 0 };
        int addTabIndicator = 0; int activeWebViewNumber = 1; int NoOfOpenTabs = 0;
        double TAB_margin_initial_left =  -450 ;
        double[] Tab_margin_initial_top = {0, 450, 370, 290, 210, 138, 65, 0.3 };
        
        public static readonly Uri HomeUri2 = new Uri("http://www.google.com", UriKind.RelativeOrAbsolute);
        public static readonly Uri techzionHome = new Uri("ms-appx-web:///WebViewHomePage.html", UriKind.RelativeOrAbsolute);
        public static readonly Uri Page3 = new Uri("http://www.google.com", UriKind.RelativeOrAbsolute);
        public static readonly Uri Page4 = new Uri("http://www.google.com", UriKind.RelativeOrAbsolute);
        public static readonly Uri Page5 = new Uri("http://www.google.com", UriKind.RelativeOrAbsolute);
        public static readonly Uri Page6 = new Uri("http://www.google.com", UriKind.RelativeOrAbsolute);
        public static Uri AddressBarInput = new Uri("http://localhost/mydata/login/appTesting/Page3.html", UriKind.RelativeOrAbsolute);

        AddressAndHistoryManager classAddressHistory = new AddressAndHistoryManager();


        public Tab2()
        {
            this.InitializeComponent();
            
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        public void AllMargingInitialize()
        {
            // future use for margin management
        }

         //--------------------------------------------- Universal Button Management ---------------------------------

        private void bHome_Click(object sender, RoutedEventArgs e)
        {
            webView1.Navigate(techzionHome);
           // webView1.Navigate(HomeUri2);
            webView2.Navigate(techzionHome);
            webView3.Navigate(Page3);
            webView4.Navigate(Page4);
            webView5.Navigate(Page5);
            webView6.Navigate(Page6);
        }
        public void history()
        {
          //  webView.Opacity = 0 ;
        }

       
       

        private void bBackward_Click(object sender, RoutedEventArgs e)
        {
            
            switch (activeWebViewNumber)
            {
                case 1: { if (webView1.CanGoBack) { webView1.GoBack(); } else { MessageDisplay("Can Not Go Back"); } break; }
                case 2: { if (webView2.CanGoBack) { webView2.GoBack(); } else { MessageDisplay("Can Not Go Back"); } break; }
                case 3: { if (webView3.CanGoBack) { webView3.GoBack(); } else { MessageDisplay("Can Not Go Back"); } break; }
                case 4: { if (webView4.CanGoBack) { webView4.GoBack(); } else { MessageDisplay("Can Not Go Back"); } break; }
                case 5: { if (webView5.CanGoBack) { webView5.GoBack(); } else { MessageDisplay("Can Not Go Back"); } break; }
                case 6: { if (webView6.CanGoBack) { webView6.GoBack(); } else { MessageDisplay("Can Not Go Back"); } break; }
            }
        }

        private void bForward_Click(object sender, RoutedEventArgs e)
        {
            switch (activeWebViewNumber)
            {
                case 1: { if (webView1.CanGoForward) { webView1.GoForward(); } break; }
                case 2: { if (webView2.CanGoForward) { webView2.GoForward(); } break; }
                case 3: { if (webView3.CanGoForward) { webView3.GoForward(); } break; }
                case 4: { if (webView4.CanGoForward) { webView4.GoForward(); } break; }
                case 5: { if (webView5.CanGoForward) { webView5.GoForward(); } break; }
                case 6: { if (webView6.CanGoForward) { webView6.GoForward(); } break; }
            }
        }

        private void addressBar_LostFocus(object sender, RoutedEventArgs e)
        {
            Thickness m = bGo.Margin;
            m.Left = 417;
            bGo.Margin = m;

            Thickness n = bReload.Margin;
            n.Left = 332;
            bReload.Margin = n;
  
            bSearch.IsEnabled = true;
            bSearch.Opacity = 1;
            bReload.IsEnabled = true;
            bReload.Opacity = 1;
            bGo.IsEnabled = false;
            bGo.Opacity = 0;
        }

        private void addressBar_GotFocus(object sender, RoutedEventArgs e)
        {
            Thickness m = bGo.Margin;
            m.Left = 332;
            bGo.Margin = m;

            Thickness n = bReload.Margin;
            n.Left = 417;
            bReload.Margin = n;

            bSearch.IsEnabled = false;                      // search button
            bSearch.Opacity = 0;
            bReload.IsEnabled = false;                      // reload button
            bReload.Opacity = 0;

          //  addressBar.Width = 400;
            Thickness addressBarLeft = addressBar.Margin;
            addressBarLeft.Left = 8;
            addressBar.Margin = addressBarLeft;
           
            bGo.IsEnabled = true;
            bGo.Opacity = 1;

        }

        private void bGo_Click(object sender, RoutedEventArgs e)
        {
                        //     !Important      manage string for apropiate address margin-->417,332
                         // string addressInput = "http://localhost/mydata/login/appTesting/" + addressBar.Text;
            string addressInput = "http://www." + addressBar.Text;
            AddressBarInput = new Uri(addressInput, UriKind.RelativeOrAbsolute);
            // webView1.Navigate(AddressBarInput);
            switch (activeWebViewNumber)
            {
                case 1: { webView1.Navigate(AddressBarInput); break; }
                case 2: { webView2.Navigate(AddressBarInput); break; }
                case 3: { webView3.Navigate(AddressBarInput); break; }
                case 4: { webView4.Navigate(AddressBarInput); break; }
                case 5: { webView5.Navigate(AddressBarInput); break; }
                case 6: { webView6.Navigate(AddressBarInput); break; }
            }
        }

        double temp_bSearch_Margin_left; double temp_bSearch_width; double temp_bGoSearchButton_Margin_left;
        double temp_breloadButton_margin_left;

        private void bSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            addressBar.IsEnabled = false;    // addressBar Field
            addressBar.Opacity = 0;
            bSearch.Text = "";               // clear default value
            temp_bSearch_width = bSearch.Width;  
            bSearch.Width = addressBar.Width;

            Thickness bSearchMarginLeft = bSearch.Margin;
            temp_bSearch_Margin_left = bSearchMarginLeft.Left;
            bSearchMarginLeft.Left = 5;
            bSearch.Margin = bSearchMarginLeft;

            Thickness bGoSearchMarginLeft = bGo_Search.Margin;
            temp_bGoSearchButton_Margin_left = bGoSearchMarginLeft.Left;
            
            Thickness bReloadMarginLeft = bReload.Margin;
            temp_breloadButton_margin_left = bReloadMarginLeft.Left;

            bGoSearchMarginLeft.Left = 332;      // swapping values
            bReloadMarginLeft.Left = 490;      // swapping values

            bGo_Search.Margin = bGoSearchMarginLeft;                        // saving values
            bReload.Margin = bReloadMarginLeft;                             // saving values

        }

        private void bSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            bSearch.Width = temp_bSearch_width;
            Thickness m = bSearch.Margin;
            m.Left = temp_bSearch_Margin_left;
            bSearch.Margin = m;

            addressBar.IsEnabled = true;
            addressBar.Opacity = 1;

            Thickness bGoSearchMarginLeft = bGo_Search.Margin;
            bGoSearchMarginLeft.Left = 490;
            bGo_Search.Margin = bGoSearchMarginLeft;
            Thickness bReloadMarginLeft = bReload.Margin;
            bReloadMarginLeft.Left = 332;
            bReload.Margin = bReloadMarginLeft;     
      
            if(bSearch.Text == "")
            {
                bSearch.Text = "Search";
            }
        }

        private void bGo_Search_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bReload_Click(object sender, RoutedEventArgs e)
        {
            switch(activeWebViewNumber)
            {
                case 1: { webView1.Refresh(); break; }
                case 2: { webView2.Refresh(); break; }
                case 3: { webView3.Refresh(); break; }
                case 4: { webView4.Refresh(); break; }
                case 5: { webView5.Refresh(); break; }
                case 6: { webView6.Refresh(); break; }

            }
        }

//-------------------------------------------------------------  TAB BUTTON Click -------------------------------------------------------------------------------
        int TabListAreShown = 0;
        private void TabsList_Click(object sender, RoutedEventArgs e)
        {
            if(TabListAreShown ==0)
            { 
            int x = 1;                //    set it in future if NO tab is open
            rectangularBlock.Opacity = 0.3;

            Thickness t1 = Tab1.Margin;
            Thickness t2 = Tab02.Margin;
            Thickness t3 = Tab3.Margin;
            Thickness t4 = Tab4.Margin;
            Thickness t5 = Tab5.Margin;
            Thickness t6 = Tab6.Margin;
            Thickness tNewTab = TabNewtab.Margin;
            Thickness tc1 = Tab1close.Margin;
            Thickness tc2 = Tab02close.Margin;
            Thickness tc3 = Tab3close.Margin;
            Thickness tc4 = Tab4close.Margin;
            Thickness tc5 = Tab5close.Margin;
            Thickness tc6 = Tab6close.Margin;

            if (activeTabIndicator[1] == 1)
            {
                t1.Left = 0;
                tc1.Left = 340;
                t1.Top = Tab_margin_initial_top[x];
                tc1.Top = Tab_margin_initial_top[x];
                x++;
                Tab1.Margin = t1;
                Tab1.Opacity = 1;
                Tab1close.Margin = tc1;
                Tab1close.Opacity = 1;
            }

            if (activeTabIndicator[2] == 1)
            {
                t2.Left = 0;
                tc2.Left = 340;
                t2.Top = Tab_margin_initial_top[x];
                tc2.Top = Tab_margin_initial_top[x];
                x++;
                Tab02.Margin = t2;
                Tab02.Opacity = 1;
                Tab02close.Margin = tc2;
                Tab02close.Opacity = 1;
            }

            if (activeTabIndicator[3] == 1)
            {
                t3.Left = 0;
                tc3.Left = 340;
                t3.Top = Tab_margin_initial_top[x];
                tc3.Top = Tab_margin_initial_top[x];
                x++;
                Tab3.Margin = t3;
                Tab3.Opacity = 1;
                Tab3close.Margin = tc3;
                Tab3close.Opacity = 1;
            }

            if (activeTabIndicator[4] == 1)
            {
                t4.Left = 0;
                tc4.Left = 340;
                t4.Top = Tab_margin_initial_top[x];
                tc4.Top = Tab_margin_initial_top[x];
                x++;
                Tab4.Margin = t4;
                Tab4.Opacity = 1;
                Tab4close.Margin = tc4;
                Tab4close.Opacity = 1;
            }

            if (activeTabIndicator[5] == 1)
            {
                tc5.Left = 340;
                t5.Left = 0;
                t5.Top = Tab_margin_initial_top[x];
                tc5.Top = Tab_margin_initial_top[x];
                x++;
                Tab5.Margin = t5;
                Tab5.Opacity = 1;
                Tab5close.Margin = tc5;
                Tab5close.Opacity = 1;
            }

            if (activeTabIndicator[6] == 1)
            {
                tc6.Left = 340;
                t6.Left = 0;
                t6.Top = Tab_margin_initial_top[x];
                tc6.Top = Tab_margin_initial_top[x];
                x++;
                Tab6.Margin = t6;
                Tab6.Opacity = 1;
                Tab6close.Margin = tc6;
                Tab6close.Opacity = 1;
            }

            NoOfOpenTabs_calc();
            if (NoOfOpenTabs < 6)
            {
                tNewTab.Left = 0;
                tNewTab.Top = Tab_margin_initial_top[x];
                //tNewTab.Top = 80;
                x++;
                TabNewtab.Margin = tNewTab;
            }
            x = 1; TabListAreShown = 1;                    // initializing x for next time
            }
            else
            { hideTabDisplay();  }
        }

        private void TabNewtab_Click(object sender, RoutedEventArgs e)
        {
            NoOfOpenTabs_calc();
            if (activeTabIndicator[1] == 0)
            {
                activeTabIndicator[1] = 1;
                displayWebView(1);
                hideTabDisplay();
            }
            else if (activeTabIndicator[2] == 0)
            {
                activeTabIndicator[2] = 1;
                displayWebView(2);
                hideTabDisplay();
            }
            else if (activeTabIndicator[3] == 0)
            {
                activeTabIndicator[3] = 1;
                displayWebView(3);
                hideTabDisplay();
            }
            else if (activeTabIndicator[4] == 0)
            {
                activeTabIndicator[4] = 1;
                displayWebView(4);
                hideTabDisplay();
            }
            else if (activeTabIndicator[5] == 0)
            {
                activeTabIndicator[5] = 1;
                displayWebView(5);
                hideTabDisplay();
            }
            else if (activeTabIndicator[6] == 0)
            {
                activeTabIndicator[6] = 1;
                displayWebView(6);
                hideTabDisplay();
            }
        }

        private void Tab6_Click(object sender, RoutedEventArgs e)
        {
            webView6.ContentLoading += webView6_ContentLoading;     // onload
            webView6.DOMContentLoaded += webView6_DOMContentLoaded;   // onload finished
            webView6.NavigationStarting += webView6_NavigationStarting;
            webView6.NavigationCompleted += webView6_NavigationCompleted;
            hideTabDisplay();
            displayWebView(6);
            activeWebViewNumber = 6;
        }

        private void webView6_ContentLoading(WebView sender, WebViewContentLoadingEventArgs args)
        {
            statusTextBlock.Text = "Loading Content";
            StatusBarProgressBar.Value = 0;
        }

        private void webView6_DOMContentLoaded(WebView sender, WebViewDOMContentLoadedEventArgs args)
        {
            statusTextBlock.Text = "Finished Loading";
            StatusBarProgressBar.Value = 100;
        }

        private void webView6_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            
        }

        private void webView6_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            classAddressHistory.OnForwardNavigation(args.Uri.ToString());
        }

        private void Tab5_Click(object sender, RoutedEventArgs e)
        {
            webView5.ContentLoading += webView5_ContentLoading;     // onload
            webView5.DOMContentLoaded += webView5_DOMContentLoaded;   // onload finished
            webView5.NavigationStarting += webView5_NavigationStarting;
            webView5.NavigationCompleted += webView5_NavigationCompleted;
            hideTabDisplay();
            displayWebView(5);
            activeWebViewNumber = 5;
        }

        private void webView5_ContentLoading(WebView sender, WebViewContentLoadingEventArgs args)
        {
            statusTextBlock.Text = "Loading Content";
            StatusBarProgressBar.Value = 0;
        }

        private void webView5_DOMContentLoaded(WebView sender, WebViewDOMContentLoadedEventArgs args)
        {
            statusTextBlock.Text = "Finished Loading";
            StatusBarProgressBar.Value = 100;
        }

        private void webView5_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
           
        }

        private void webView5_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            classAddressHistory.OnForwardNavigation(args.Uri.ToString());
        }

        private void Tab4_Click(object sender, RoutedEventArgs e)
        {
            webView4.ContentLoading += webView4_ContentLoading;     // onload
            webView4.DOMContentLoaded += webView4_DOMContentLoaded;   // onload finished
            webView4.NavigationStarting += webView4_NavigationStarting;
            webView4.NavigationCompleted += webView4_NavigationCompleted;
            hideTabDisplay();
            displayWebView(4);
            activeWebViewNumber = 4;
        }

        private void webView4_ContentLoading(WebView sender, WebViewContentLoadingEventArgs args)
        {
            statusTextBlock.Text = "Loading Content";
            StatusBarProgressBar.Value = 0;
        }

        private void webView4_DOMContentLoaded(WebView sender, WebViewDOMContentLoadedEventArgs args)
        {
            statusTextBlock.Text = "Finished Loading";
            StatusBarProgressBar.Value = 100;
        }

        private void webView4_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            
        }

        private void webView4_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            classAddressHistory.OnForwardNavigation(args.Uri.ToString());
        }

        private void Tab3_Click(object sender, RoutedEventArgs e)
        {
            webView3.ContentLoading += webView3_ContentLoading;     // onload
            webView3.DOMContentLoaded += webView3_DOMContentLoaded;   // onload finished
            webView3.NavigationStarting += webView3_NavigationStarting;
            webView3.NavigationCompleted += webView3_NavigationCompleted;
            hideTabDisplay();
            displayWebView(3);
            activeWebViewNumber = 3;
        }

        private void webView3_ContentLoading(WebView sender, WebViewContentLoadingEventArgs args)
        {
            statusTextBlock.Text = "Loading Content";
            StatusBarProgressBar.Value = 0;
        }

        private void webView3_DOMContentLoaded(WebView sender, WebViewDOMContentLoadedEventArgs args)
        {
            statusTextBlock.Text = "Finished Loading";
            StatusBarProgressBar.Value = 100;
        }

        private void webView3_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
            
        }

        private void webView3_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            classAddressHistory.OnForwardNavigation(args.Uri.ToString());
        }

        private void Tab2_Click(object sender, RoutedEventArgs e)
        {
            webView2.ContentLoading += webView2_ContentLoading;     // onload
            webView2.DOMContentLoaded += webView2_DOMContentLoaded;   // onload finished
            webView2.NavigationStarting += webView2_NavigationStarting;
            webView2.NavigationCompleted += webView2_NavigationCompleted;
            
            hideTabDisplay();
            displayWebView(2);
            activeWebViewNumber = 2;
        }

        private void webView2_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
            classAddressHistory.OnForwardNavigation(args.Uri.ToString());
        }

        private void webView2_NavigationStarting(WebView sender, WebViewNavigationStartingEventArgs args)
        {
           
        }

        private void webView2_DOMContentLoaded(WebView sender, WebViewDOMContentLoadedEventArgs args)
        {
            statusTextBlock.Text = "Finished Loading";
            StatusBarProgressBar.Value = 100;
        }

        private void webView2_ContentLoading(WebView sender, WebViewContentLoadingEventArgs args)
        {
            statusTextBlock.Text = "Loading Content";
            StatusBarProgressBar.Value = 0;
        }

        private void Tab1_Click(object sender, RoutedEventArgs e)
        {

            webView1.ContentLoading += webView1_ContentLoading;     // onload
            webView1.DOMContentLoaded += webView1_DOMContentLoaded;   // onload finished
            webView1.NavigationStarting += webView1_NavigationStarting;
            webView1.NavigationCompleted += webView1_NavigationCompleted;
            //webView1.ContainsFullScreenElementChanged += webView_ContainsFullScreenElementChanged;
            hideTabDisplay();
            displayWebView(1);
            activeWebViewNumber = 1;

            //  webView1.DefaultBackgroundColor = Window.ui.color.red ;
            // TabListButtonOptionSelected(1);
            // addressBar.Text = webView1.
        }
        private void webView1_NavigationStarting(object sender, WebViewNavigationStartingEventArgs args)
        {
            // Cancel navigation if URL is not allowed. (Implemetation of IsAllowedUri not shown.)
            // if (!IsAllowedUri(args.Uri)
            //   args.Cancel = true;
        }

        private void webView1_NavigationCompleted(WebView sender, WebViewNavigationCompletedEventArgs args)
        {
          /*  if (args.IsSuccess == true)
            {
                statusTextBlock.Text = "Navigation to " + args.Uri.ToString() + " completed successfully.";
            }
            else
            {
                statusTextBlock.Text = "Navigation to: " + args.Uri.ToString() + " failed with error " + args.WebErrorStatus.ToString();
            }
            */
            classAddressHistory.OnForwardNavigation(args.Uri.ToString());
            
        }
        private void webView1_ContentLoading(WebView sender, WebViewContentLoadingEventArgs args)
        {
            // Show status. 
            if (args.Uri != null)
            {
                // statusTextBlock.Text = "Loading content for " + args.Uri.ToString();
                statusTextBlock.Text = "Loading Content";
                StatusBarProgressBar.Value = 0;
            }
        }


        private void webView1_DOMContentLoaded(WebView sender, WebViewDOMContentLoadedEventArgs args)
        {
            if (args.Uri != null)
            {
                statusTextBlock.Text = "Finished Loading";
                StatusBarProgressBar.Value = 100;
                //  statusTextBlock.Text = "Content for " + args.Uri.ToString() + " has finished loading";
            }
        }

        
        // ------------------------------------------------------- tabs close Button ----------------------------------
        HttpDownloadClient hd = new HttpDownloadClient();
        private void Tab1close_Click(object sender, RoutedEventArgs e)
        {


        }

        private void Tab02close_Click(object sender, RoutedEventArgs e)
        {
            MessageDisplay("2");
        }

        private void Tab3close_Click(object sender, RoutedEventArgs e)
        {
            MessageDisplay("3");
        }

        private void Tab4close_Click(object sender, RoutedEventArgs e)
        {
            MessageDisplay("4");
        }

        private void Tab5close_Click(object sender, RoutedEventArgs e)
        {
            MessageDisplay("5");
        }

        private void Tab6close_Click(object sender, RoutedEventArgs e)
        {
            // MessageDisplay("6");
            toastNotifivationGenerate("Adesh Singh", "", "", "ms-appx:///Assets/camera.png");
        }
       
       
       
        public async void MessageDisplay(string message)
        {
           MessageDialog msgbox = new MessageDialog(message);
           msgbox.Title = "Adesh";
            string ss=" ";
            await msgbox.ShowAsync();
          
        }

        public void TabListButtonOptionSelected(int TabClickedPosition)
        {
            int temp = 1;
            for(int x=1; x<=6; x++)
            {
                if (activeTabIndicator[x] == 1)
                {
                    if(temp == TabClickedPosition)
                    {
                        displayWebView(x);
                        break;
                    }
                    temp++;
                }
             }
        }

        public void displayWebView(int currentWebViewPosition)
        {
            switch (currentWebViewPosition)
            {
                case 0: { webView1.Opacity = 0; webView2.Opacity = 0; webView3.Opacity = 0; webView4.Opacity = 0; webView5.Opacity = 0; webView6.Opacity = 0; break; }
                case 1: { webView1.Opacity = 1; webView2.Opacity = 0; webView3.Opacity = 0; webView4.Opacity = 0; webView5.Opacity = 0; webView6.Opacity = 0; break; }
                case 2: { webView1.Opacity = 0; webView2.Opacity = 1; webView3.Opacity = 0; webView4.Opacity = 0; webView5.Opacity = 0; webView6.Opacity = 0; break; }
                case 3: { webView1.Opacity = 0; webView2.Opacity = 0; webView3.Opacity = 1; webView4.Opacity = 0; webView5.Opacity = 0; webView6.Opacity = 0; break; }
                case 4: { webView1.Opacity = 0; webView2.Opacity = 0; webView3.Opacity = 0; webView4.Opacity = 1; webView5.Opacity = 0; webView6.Opacity = 0; break; }
                case 5: { webView1.Opacity = 0; webView2.Opacity = 0; webView3.Opacity = 0; webView4.Opacity = 0; webView5.Opacity = 1; webView6.Opacity = 0; break; }
                case 6: { webView1.Opacity = 0; webView2.Opacity = 0; webView3.Opacity = 0; webView4.Opacity = 0; webView5.Opacity = 0; webView6.Opacity = 1; break; }
            }
        }

        public void hideTabDisplay()
        {
            Tab1.Opacity = 0; Tab1close.Opacity = 0;
            Tab02.Opacity = 0; Tab02close.Opacity = 0;
            Tab3.Opacity = 0; Tab3close.Opacity = 0;
            Tab4.Opacity = 0; Tab4close.Opacity = 0;
            Tab5.Opacity = 0; Tab5close.Opacity = 0;
            Tab6.Opacity = 0; Tab6close.Opacity = 0;
            Thickness t1 = Tab1.Margin;
            Thickness t2 = Tab02.Margin;
            Thickness t3 = Tab3.Margin;
            Thickness t4 = Tab4.Margin;
            Thickness t5 = Tab5.Margin;
            Thickness t6 = Tab6.Margin;
            Thickness tNewTab = TabNewtab.Margin;
            t1.Left = TAB_margin_initial_left;
            t2.Left = TAB_margin_initial_left;
            t3.Left = TAB_margin_initial_left;
            t4.Left = TAB_margin_initial_left;
            t5.Left = TAB_margin_initial_left;
            t6.Left = TAB_margin_initial_left;
            tNewTab.Left = TAB_margin_initial_left;
           // tNewTab.Left += 25;
            Tab1.Margin = t1;
            Tab02.Margin = t2;
            Tab3.Margin = t3;
            Tab4.Margin = t4;
            Tab5.Margin = t5;
            Tab6.Margin = t6;
            TabNewtab.Margin = tNewTab;
            rectangularBlock.Opacity = 0;
            TabListAreShown = 0;
        }
//----------------------------------------------------------- Menu Button & its Sub Buttons ---------------------------------------------------------------------
        int bMenuEnable = 0;
        private void bMenu_Click(object sender, RoutedEventArgs e)
        {    // -1305,0,1304,0
            if (bMenuEnable==0)
            { 
                 Thickness m = ViewBoxSetting.Margin;
                 m.Left  = 0;
                m.Top = 0;
                 ViewBoxSetting.Margin = m;
                 bMenuEnable = 1;
            }
            else
            {
                Thickness m = ViewBoxSetting.Margin;
                m.Left = -2705;
                ViewBoxSetting.Margin = m;
                bMenuEnable = 0;
            }
        }

        

        public void IsEnableTabsButtonCheck(int positionAfterWhichDIsable)
        {
            switch (positionAfterWhichDIsable)
            {
                case 2: { Tab02.IsEnabled = false; Tab02close.IsEnabled = false;
                          Tab3.IsEnabled = false; Tab3close.IsEnabled = false;
                          Tab4.IsEnabled = false; Tab4close.IsEnabled = false;
                          Tab5.IsEnabled = false; Tab5close.IsEnabled = false;
                          Tab6.IsEnabled = false; Tab6close.IsEnabled = false; break;
                        }
                case 3:
                    {
                        Tab3.IsEnabled = false; Tab3close.IsEnabled = false;
                        Tab4.IsEnabled = false; Tab4close.IsEnabled = false;
                        Tab5.IsEnabled = false; Tab5close.IsEnabled = false;
                        Tab6.IsEnabled = false; Tab6close.IsEnabled = false; break;
                    }
                case 4:
                    {
                        Tab4.IsEnabled = false; Tab4close.IsEnabled = false;
                        Tab5.IsEnabled = false; Tab5close.IsEnabled = false;
                        Tab6.IsEnabled = false; Tab6close.IsEnabled = false; break;
                    }
                case 5:
                    {
                        Tab5.IsEnabled = false; Tab5close.IsEnabled = false;
                        Tab6.IsEnabled = false; Tab6close.IsEnabled = false; break;
                    }
                case 6:
                    {
                        Tab6.IsEnabled = false; Tab6close.IsEnabled = false; break;
                    }
            }
        }



        
        //------------------------------------------------ Supporting Functions -------------------------------------------------

        public void NoOfOpenTabs_calc()
        {
            NoOfOpenTabs = 0;
            for(int a = 1; a<=6; a++)
            {
                if(activeTabIndicator[a]==1)
                { NoOfOpenTabs++;  }
            }
        }

        private void statusTextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }


        private void webView_ContainsFullScreenElementChanged(WebView sender, object args)
           {
         /*   var applicationView = ApplicationView.GetForCurrentView();
            if (sender.ContainsFullScreenElement)
               {
                applicationView.TryEnterFullScreenMode();
               
                   
               }
            else if (applicationView.IsFullScreenMode)
              {
                applicationView.ExitFullScreenMode();
              }
           */
           
          }
  // ------------------------------------------ Toast Notification ------------------------------------------------
        public void toastNotifivationGenerate(String line1Bold, string line2Description, string line3subDescription, string ToastImage)
        {
            ToastTemplateType toastType = ToastTemplateType.ToastImageAndText04;
            XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(toastType);
            XmlNodeList toastTextElement = toastXml.GetElementsByTagName("text");
            toastTextElement[0].AppendChild(toastXml.CreateTextNode(line1Bold));
            toastTextElement[1].AppendChild(toastXml.CreateTextNode(line2Description));
            toastTextElement[2].AppendChild(toastXml.CreateTextNode(line3subDescription));
           
            if(ToastImage.Equals(""))
            {
                ToastImage = "ms-appx:///Assets/camera.png";
            }
                                        // setting image of toast <200kb

            XmlNodeList toastImageAttribute = toastXml.GetElementsByTagName("image");
            ((XmlElement)toastImageAttribute[0]).SetAttribute("src", ToastImage);
            IXmlNode toastNode = toastXml.SelectSingleNode("/toast");
            ((XmlElement)toastNode).SetAttribute("duration", "veryshort");
                                      // create toast based on specified content
            ToastNotification toast = new ToastNotification(toastXml);
          //  toast.Tag = "1";
           // toast.Group = "wallpost";
            toast.ExpirationTime = DateTime.Now.AddSeconds(20);
                                      // send toast
            ToastNotificationManager.CreateToastNotifier().Show(toast);
            //-------------for future-----------------
            // var scheduledNotify = new ScheduledToastNotification( , DateTimeOffset.UtcNow + TimeSpan.FromDays(1.0));
            //  ToastTemplateType toastTemplateXml = ToastTemplateType.ToastImageAndText01;
            //XmlDocument toastXml = ToastNotificationManager.GetTemplateContent(toastTemplateXml);

            //ToastNotification toast = new ToastNotification(toastXml);
            //ToastNotificationManager.CreateToastNotifier().Show(toast);
            //var toastNotify = ToastNotificationManager.CreateToastNotifier();
            //toastNotify.GetScheduledToastNotifications();
            //   toastNotify.AddToSchedule(scheduledNotify);
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
           /* Thickness rec1 = HomeRectangleBox.Margin;
            double y = rec1.Top;
            if(y < 0.0)
            {
                string z = "" + y;
                toastNotifivationGenerate("thickness", z, "", "ms-appx:///Assets/camera.png");
            }
            else { toastNotifivationGenerate("thickness", rec1.Top.ToString(), "", "ms-appx:///Assets/camera.png"); }
          */
          //  RecHome.Visibility = Windows.UI.Xaml.Visibility.Collapsed;
            
            //RecHome.ScrollToVerticalOffset(400);
           
        }

        private void RecHome_ViewChanged(object sender, ScrollViewerViewChangedEventArgs e)
        {
           // toastNotifivationGenerate("scroll", "", " ", "");
            
        }

        private void bHistory_Click(object sender, RoutedEventArgs e)
        {
            Thickness m = ViewBoxHistory.Margin;                    //-1314,-612,1314,127.333
            m.Left = 0;
            m.Top = 0;
            m.Right = 0;
            m.Bottom = -525;
            ViewBoxHistory.Margin = m;
            for(int a= classAddressHistory.addressSavePoint; a>=1; a--)
            {
                ListBoxHistory.Items.Add(classAddressHistory.Address[a]);
            }
        }

        private void bNightDayMode_Click(object sender, RoutedEventArgs e)
        {
           


        }

        private void bViewBoxHistoryHide_Click(object sender, RoutedEventArgs e)
        {
            Thickness m = ViewBoxHistory.Margin;                    //-1314,-612,1314,127.333
            m.Left = -1314;
            m.Top = -612;
            m.Right = 1314;
            m.Bottom = 127.333;
            ViewBoxHistory.Margin = m;
        }

        private void bSetting_Click(object sender, RoutedEventArgs e)
        {
            Thickness m = ViewBoxSettingRec.Margin;                     ////-882,-667,882,127.333
            m.Left = 0;
            m.Top = 0;
          //  m.Right = 0;
          //  m.Bottom = 0;
            ViewBoxSettingRec.Margin = m;
        }

        private void bSettingMenuBack_Click(object sender, RoutedEventArgs e)
        {
            Thickness m = ViewBoxSettingRec.Margin;                  //-882,-667,882,127.333
            m.Left = -882;
            m.Top = -667;
            m.Right = 882;
            m.Bottom = 127.333;
            ViewBoxSettingRec.Margin = m;
        }

        private void bSetClearHistory_Click(object sender, RoutedEventArgs e)
        {
            toastNotifivationGenerate("Browser", "History, Password and Other Records Has Been Cleared", "", "");
        }

        private void bSetMoreSetting_Click(object sender, RoutedEventArgs e)
        {
            toastNotifivationGenerate("Buy Full Version of App", "For All the Features", "", "");
        }

        private void bSetAppLockerPassword_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bSettingMyVideos_Click(object sender, RoutedEventArgs e)
        {
            Thickness m = ViewBoxMyVideos.Margin;                     //-450,-667,450,127.333
            m.Left = 0;
            m.Top = 0;
            m.Right = 0;
            m.Bottom = -525;
            ViewBoxMyVideos.Margin = m;
        }

        private void bMyVideosBack_Click(object sender, RoutedEventArgs e)
        {
            Thickness m = ViewBoxMyVideos.Margin;                     //-450,-667,450,127.333
            m.Left = -450;
            m.Top = -667;
            m.Right = 450;
            m.Bottom = 127.33;
            ViewBoxMyVideos.Margin = m;
        }

        private void bDownloadMenu_Click(object sender, RoutedEventArgs e)
        {   //-1350,45,1350,3.667
            Thickness m = ViewBoxDownload.Margin;                     
            m.Left = 0;
            m.Top = 45;
            m.Right = 0;
            m.Bottom = 3.667;
            ViewBoxDownload.Margin = m;
        }
        private void bDownloadsBack_Click(object sender, RoutedEventArgs e)
        {    //-1350,45,1350,3.667
            Thickness m = ViewBoxDownload.Margin;                     
            m.Left = -1350;
            m.Top = 45;
            m.Right = 1350;
            m.Bottom = 3.667;
            ViewBoxDownload.Margin = m;
            
            

        }

        private void bIncoginito_Toggled(object sender, RoutedEventArgs e)
        {
            classAddressHistory.IncoginitoModeStatus = true;
            toastNotifivationGenerate("Incoginito Mode Activated", "", "", "");
        }

        private void exit_click(object sender, RoutedEventArgs e)
        {
            Application.Current.Exit();
        }

        private void TextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
