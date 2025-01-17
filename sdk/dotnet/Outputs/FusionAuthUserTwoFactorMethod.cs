// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace theogravity.Fusionauth.Outputs
{

    [OutputType]
    public sealed class FusionAuthUserTwoFactorMethod
    {
        /// <summary>
        /// The algorithm used by the TOTP authenticator. With the current implementation, this will always be HmacSHA1.
        /// </summary>
        public readonly string? AuthenticatorAlgorithm;
        /// <summary>
        /// The length of code generated by the TOTP. With the current implementation, this will always be 6.
        /// </summary>
        public readonly int? AuthenticatorCodeLength;
        /// <summary>
        /// The time-step size in seconds. With the current implementation, this will always be 30.
        /// </summary>
        public readonly int? AuthenticatorTimeStep;
        /// <summary>
        /// The value of the email address for this method.
        /// </summary>
        public readonly string? Email;
        /// <summary>
        /// The type of this method. There will also be an object with the same value containing additional information about this method.
        /// </summary>
        public readonly string? Method;
        /// <summary>
        /// The value of the mobile phone for this method.
        /// </summary>
        public readonly string? MobilePhone;
        /// <summary>
        /// A base64 encoded secret
        /// </summary>
        public readonly string? Secret;

        [OutputConstructor]
        private FusionAuthUserTwoFactorMethod(
            string? authenticatorAlgorithm,

            int? authenticatorCodeLength,

            int? authenticatorTimeStep,

            string? email,

            string? method,

            string? mobilePhone,

            string? secret)
        {
            AuthenticatorAlgorithm = authenticatorAlgorithm;
            AuthenticatorCodeLength = authenticatorCodeLength;
            AuthenticatorTimeStep = authenticatorTimeStep;
            Email = email;
            Method = method;
            MobilePhone = mobilePhone;
            Secret = secret;
        }
    }
}
