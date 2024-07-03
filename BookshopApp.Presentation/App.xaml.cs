using Microsoft.Maui.Controls;
using System;
namespace BookshopApp.Presentation;

public partial class App : Microsoft.Maui.Controls.Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new MainPage();
    }
}
