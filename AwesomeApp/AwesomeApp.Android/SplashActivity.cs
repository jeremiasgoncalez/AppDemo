﻿using Android.App;
using Android.Content;
using Android.OS;
using System;
using System.Threading.Tasks;


namespace AwesomeApp.Droid
{
    [Activity(Label = "SplashActivity", MainLauncher = true, Theme = "@style/MyTheme.Splash", NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            
            base.OnCreate(savedInstanceState);

            // Create your application here
        }

        protected override async void OnResume()
        {
            base.OnResume();
            await SimulateStartup();

        }

        async Task SimulateStartup()
        {
            await Task.Delay(TimeSpan.FromSeconds(4));
                      
            StartActivity(new Intent(Application.Context, typeof(MainActivity)));

        }
    }
}