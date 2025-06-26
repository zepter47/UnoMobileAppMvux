using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using EstatesUpdated.Services.Respository;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using EstatesUpdated.Services.Endpoints;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace EstatesUpdated.View;
/// <summary>
/// An empty page that can be used on its own or navigated to within a Frame.
/// </summary>
public sealed partial class ResidentsListPage : Page
{
    public ResidentsListPage()
    {
        this.InitializeComponent();

    }
}
