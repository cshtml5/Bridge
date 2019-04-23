using System.Collections.Generic;

namespace System.ComponentModel.DataAnnotations
{
    /// <summary>
    /// Container class for the results of a validation request.
    /// <para>
    ///     Use the static <see cref="ValidationResult.Success" /> to represent successful validation.
    /// </para>
    /// </summary>
    [Bridge.Convention(Member = Bridge.ConventionMember.Field | Bridge.ConventionMember.Method, Notation = Bridge.Notation.CamelCase)]
    public class ValidationResult
    {
        private IEnumerable<string> _memberNames;
        private string _errorMessage;

        /// <summary>
        /// Gets a <see cref="ValidationResult" /> that indicates Success.
        /// </summary>
        public static readonly ValidationResult Success;

        /// <summary>
        /// Constructor that accepts an error message.  This error message would override any error message
        /// provided on the <see cref="ValidationAttribute" />.
        /// </summary>
        /// <param name="errorMessage">
        /// The user-visible error message.  If null, <see cref="ValidationAttribute.GetValidationResult" />
        /// will use <see cref="ValidationAttribute.FormatErrorMessage" /> for its error message.
        /// </param>
        public ValidationResult(string errorMessage)
            : this(errorMessage, null)
        {
        }

        /// <summary>
        /// Constructor that accepts an error message as well as a list of member names involved in the validation.
        /// This error message would override any error message provided on the <see cref="ValidationAttribute" />.
        /// </summary>
        /// <param name="errorMessage">
        /// The user-visible error message.  If null, <see cref="ValidationAttribute.GetValidationResult" />
        /// will use <see cref="ValidationAttribute.FormatErrorMessage" /> for its error message.
        /// </param>
        /// <param name="memberNames">
        /// The list of member names affected by this result.
        /// This list of member names is meant to be used by presentation layers to indicate which fields are in error.
        /// </param>
        public ValidationResult(string errorMessage, IEnumerable<string> memberNames)
        {
            this._errorMessage = errorMessage;
            this._memberNames = memberNames ?? new string[0];
        }

        /// <summary>
        /// Constructor that creates a copy of an existing ValidationResult.
        /// </summary>
        /// <param name="validationResult">The validation result.</param>
        /// <exception cref="System.ArgumentNullException">The <paramref name="validationResult" /> is null.</exception>
        protected ValidationResult(ValidationResult validationResult)
        {
            if (validationResult == null)
            {
                throw new ArgumentNullException("validationResult");
            }

            this._errorMessage = validationResult._errorMessage;
            this._memberNames = validationResult._memberNames;
        }

        /// <summary>
        /// Gets the collection of member names affected by this result.  The collection may be empty but will never be null.
        /// </summary>
        public IEnumerable<string> MemberNames
        {
            get
            {
                return this._memberNames;
            }
        }

        /// <summary>
        /// Gets the error message for this result.  It may be null.
        /// </summary>
        public string ErrorMessage
        {
            get
            {
                return this._errorMessage;
            }
            set
            {
                this._errorMessage = value;
            }
        }

        /// <summary>
        /// Override the string representation of this instance, returning
        /// the <see cref="ErrorMessage"/> if not <c>null</c>, otherwise
        /// the base <see cref="Object.ToString"/> result.
        /// </summary>
        public override string ToString()
        {
            return this.ErrorMessage ?? base.ToString();
        }

    }
}
