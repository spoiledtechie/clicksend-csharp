/* 
 * ClickSend v3 API
 *
 *  This is an official SDK for [ClickSend](https://clicksend.com)  Below you will find a current list of the available methods for clicksend.  *NOTE: You will need to create a free account to use the API. You can register [here](https://dashboard.clicksend.com/#/signup/step1/)..* 
 *
 * OpenAPI spec version: 3.1
 * Contact: support@clicksend.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using JsonSubTypes;
using System.ComponentModel.DataAnnotations;
using ClickSendDateConverter = IO.ClickSend.Client.ClickSendDateConverter;

namespace IO.ClickSend.ClickSend.Model
{
    /// <summary>
    /// Your list.
    /// </summary>
    [DataContract]
    [JsonConverter(typeof(JsonSubtypes), "classType")]
    public partial class List :  IEquatable<List>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="List" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected List() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="List" /> class.
        /// </summary>
        /// <param name="listName">Your list name. (required).</param>
        public List(string listName = default(string))
        {
            // to ensure "listName" is required (not null)
            if (listName == null)
            {
                throw new InvalidDataException("listName is a required property for List and cannot be null");
            }
            else
            {
                this.ListName = listName;
            }
        }
        
        /// <summary>
        /// Your list name.
        /// </summary>
        /// <value>Your list name.</value>
        [DataMember(Name="list_name", EmitDefaultValue=false)]
        public string ListName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class List {\n");
            sb.Append("  ListName: ").Append(ListName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as List);
        }

        /// <summary>
        /// Returns true if List instances are equal
        /// </summary>
        /// <param name="input">Instance of List to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(List input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ListName == input.ListName ||
                    (this.ListName != null &&
                    this.ListName.Equals(input.ListName))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.ListName != null)
                    hashCode = hashCode * 59 + this.ListName.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
