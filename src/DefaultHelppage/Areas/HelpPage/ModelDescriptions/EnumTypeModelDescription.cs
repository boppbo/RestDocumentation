using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace DefaultHelppage.Areas.HelpPage.ModelDescriptions
{
    /// <summary>   Description of the enum type model. </summary>
    public class EnumTypeModelDescription : ModelDescription
    {
        /// <summary>
        ///     Initializes a new instance of the
        ///     DefaultHelppage.Areas.HelpPage.ModelDescriptions.EnumTypeModelDescription class.
        /// </summary>
        public EnumTypeModelDescription()
        {
            Values = new Collection<EnumValueDescription>();
        }

        /// <summary>   Gets the values. </summary>
        ///
        /// <value> The values. </value>
        public Collection<EnumValueDescription> Values { get; private set; }
    }
}