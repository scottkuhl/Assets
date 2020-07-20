using Xamarin.Forms;

namespace Farnsworth
{
    /// <summary>
    ///     Strongly typed class interface for the property dictionary.
    /// </summary>
    public static class Settings
    {
        public static int Example
        {
            get { return (int)Application.Current.Properties[nameof(Example)]; }
            set { Application.Current.Properties[nameof(Example)] = value; }
        }
    }
}