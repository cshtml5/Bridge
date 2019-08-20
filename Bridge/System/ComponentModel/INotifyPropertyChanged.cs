namespace System.ComponentModel
{
    [Bridge.External]
    public interface INotifyPropertyChanged : Bridge.IBridgeClass
    {
        event PropertyChangedEventHandler PropertyChanged;
    }

    [Bridge.Name("Function")]
    public delegate void PropertyChangedEventHandler(object sender, PropertyChangedEventArgs e);

    [Bridge.Convention(Member = Bridge.ConventionMember.Field | Bridge.ConventionMember.Method, Notation = Bridge.Notation.CamelCase)]
    [Bridge.External]
    public class PropertyChangedEventArgs : Bridge.IBridgeClass
    {
        private readonly string propertyName;

        /// <summary>
        /// Initializes a new instance of the System.ComponentModel.PropertyChangedEventArgs class.
        /// </summary>
        /// <param name="propertyName">The name of the property that changed.</param>
        public PropertyChangedEventArgs(string propertyName)
        {
            this.propertyName = propertyName;
        }

        /// <summary>
        /// Gets the name of the property that changed. Returns the name of the property that changed.
        /// </summary>
        public string PropertyName
        {
            get
            {
                return propertyName;
            }
        }
    }
}