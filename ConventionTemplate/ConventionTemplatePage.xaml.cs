using ConventionTemplate.Models;
using Xamarin.Forms;
using System.Collections.Generic;
using System;

namespace ConventionTemplate
{
    public partial class ConventionTemplatePage : ContentPage
    {
        public ConventionTemplatePage()
        {
            InitializeComponent();

            PanelList.ItemsSource = new List<PanelGuest> {
                new PanelGuest{name="Henry Cavil", description="ahgsfdhjkagsGVDJKHasgvdjhgaSJKHDG", imageUrl="ConventionTemplate.Images.background.jpg", notes="ajhsgdjhasdbfjabfd"},
                new PanelGuest{name="Henry Cavil", description="ahgsfdhjkagsGVDJKHasgvdjhgaSJKHDG", imageUrl="https://unsplash.com/photos/b8rkmfxZjdU", notes="ajhsgdjhasdbfjabfd"},
                new PanelGuest{name="Henry Cavil", description="ahgsfdhjkagsGVDJKHasgvdjhgaSJKHDG", imageUrl="https://unsplash.com/photos/b8rkmfxZjdU", notes="ajhsgdjhasdbfjabfd"}
            };
        }
    }
}
