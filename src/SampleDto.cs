using System;
using System.ComponentModel.DataAnnotations;

namespace RestDocumentation.Models
{
    /// <summary>   A sample dto. </summary>
    public class SampleDto
    {
        /// <summary>   Gets or sets the identifier. </summary>
        ///
        /// <value> The identifier. </value>
        [Key]
        public long Id {get;set;}

        /// <summary>   Gets or sets the name. </summary>
        ///
        /// <value> The name. </value>
        [Required]
        public string Name {get;set;}

        /// <summary>   Gets or sets a value indicating whether this object is valid. </summary>
        ///
        /// <value> True if this object is valid, false if not. </value>
        public bool IsValid {get;set;}

        /// <summary>   Gets or sets the nested dto. </summary>
        ///
        /// <value> The nested dto. </value>
        public NestedDto NestedDto {get;set;}
    }

    /// <summary>   A nested dto. </summary>
    public class NestedDto
    {
        /// <summary>   Gets or sets the identifier. </summary>
        ///
        /// <value> The identifier. </value>
        [Range(23, 42)]
        [Editable(false)]
        public long Id {get;set;}

        /// <summary>   Gets or sets the description. </summary>
        ///
        /// <value> The description. </value>
        [Obsolete]
        public string Description {get;set;}
    }
}