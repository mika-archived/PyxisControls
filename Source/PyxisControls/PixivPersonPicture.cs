using Windows.ApplicationModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace PyxisControls
{
    [TemplatePart(Name = "ImageControl", Type = typeof(PersonPicture))]
    public sealed class PixivPersonPicture : PixivControl<PersonPicture>
    {
        public static readonly DependencyProperty SourceProperty =
            DependencyProperty.Register(nameof(Source), typeof(object), typeof(PixivPersonPicture), new PropertyMetadata(default(object), OnSourceChanged));

        public override object Source
        {
            get => GetValue(SourceProperty);
            set => SetValue(SourceProperty, value);
        }

        public PixivPersonPicture()
        {
            if (DesignMode.DesignModeEnabled)
                return;

            DefaultStyleKey = typeof(PixivPersonPicture);
        }

        protected override void AssignToImageControl(string image)
        {
            ImageControl.ProfilePicture = CreateImageSource(image);
        }
    }
}