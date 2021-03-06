using System.Collections.ObjectModel;

namespace DefaultHelppage.Areas.HelpPage.ModelDescriptions
{
    /// <summary>   Description of the complex type model. </summary>
    public class ComplexTypeModelDescription : ModelDescription
    {
        /// <summary>
        ///     Initializes a new instance of the
        ///     DefaultHelppage.Areas.HelpPage.ModelDescriptions.ComplexTypeModelDescription class.
        /// </summary>
        public ComplexTypeModelDescription()
        {
            Properties = new Collection<ParameterDescription>();
        }

        /// <summary>   Gets the properties. </summary>
        ///
        /// <value> The properties. </value>
        public Collection<ParameterDescription> Properties { get; private set; }
    }
}