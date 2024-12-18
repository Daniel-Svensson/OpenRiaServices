﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
#if SERVERFX
using OpenRiaServices.Server;
#endif

#nullable disable

#if SERVERFX
namespace OpenRiaServices.Hosting
#else
namespace OpenRiaServices.Client
#endif
{
    /// <summary>
    /// Message type used to communicate exception results between server and client.
    /// </summary>
    [DataContract(Namespace = "DomainServices")]
    public class DomainServiceFault
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public DomainServiceFault()
        {
        }

        /// <summary>
        /// Gets or sets the custom code for the error.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public int ErrorCode
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the message giving details on the error.
        /// </summary>
        [DataMember]
        public string ErrorMessage
        {
            get;
            set;
        }

#if SERVERFX
        /// <summary>
        /// Gets or sets a value indicating whether the error was a <see cref="DomainException"/>. 
        /// If the value is true, it indicates that the error should be reconstructed on the 
        /// client as the equivalent exception type.
        /// </summary>
#else
        /// <summary>
        /// Gets or sets a value indicating whether the fault indicates that the error information 
        /// should be reconstructed on the client as a <see cref="DomainException"/> type.
        /// </summary>
#endif
        [DataMember]
        public bool IsDomainException
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the stack trace for the error.
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string StackTrace
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the validation errors that occurred during this request.
        /// </summary>
        /// <remarks>This is only used when a request invokes a single method, such as an invoke operation.</remarks>
        [DataMember(EmitDefaultValue = false)]
        public IEnumerable<ValidationResultInfo> OperationErrors
        {
            get;
            set;
        }

        /// <summary>
        /// Get the validation errors 
        /// </summary>
        /// <returns>
        /// Collection of validation errors as <see cref="IEnumerable"/>.
        /// </returns>
        public IEnumerable<ValidationResult> GetValidationErrors()
        {
            if (this.OperationErrors == null)
            {
                return new List<ValidationResult>();
            }
            
            return this.OperationErrors.Select(oe => new ValidationResult(oe.Message, oe.SourceMemberNames)).ToList();
        }

#if SERVERFX
        internal void SetFromDomainException(DomainException ex, bool includeStackTrace)
        {
            ErrorCode = ex.ErrorCode;
            ErrorMessage = FormatExceptionMessage(ex);
            IsDomainException = true;
            StackTrace = includeStackTrace ? ex.StackTrace : null;
        }

        internal void SetFromException(Exception ex, bool includeStackTrace)
        {
            ErrorMessage = FormatExceptionMessage(ex);
            IsDomainException = false;
            StackTrace = includeStackTrace ? ex.StackTrace : null;
        }

        /// <summary>
        /// For the specified exception, return the error message concatenating
        /// the message of any inner exception to one level deep.
        /// </summary>
        /// <param name="e">The exception</param>
        /// <returns>The formatted exception message.</returns>
        private static string FormatExceptionMessage(Exception e)
        {
            if (e.InnerException == null)
            {
                return e.Message;
            }
            return string.Format(CultureInfo.InvariantCulture, Wcf.Resource.FaultException_InnerExceptionDetails, e.Message, e.InnerException.Message);
        }
#endif
    }
}
