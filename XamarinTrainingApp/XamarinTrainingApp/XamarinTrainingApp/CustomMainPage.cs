using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace XamarinTrainingApp
{
    public class CustomMainPage : ContentPage
    {
        public CustomMainPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello from my custom page" }
                }
            };
        }
    }
}
