﻿using Xamarin.Forms;

namespace AnylineXamarinForms
{
    public class EnergyPage : ContentPage
    {
        public EnergyPage()
		{
            Title = "Energy Scan Page";
            // rendering of this page is done natively on each platform (via EnergyPageRenderer / MrzPageRenderer etc.)

            NavigationPage.SetHasBackButton(this, false);
        }
    }
}

