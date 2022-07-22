// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace theogravity.Fusionauth.Inputs
{

    public sealed class FusionAuthApplicationRegistrationConfigurationArgs : Pulumi.ResourceArgs
    {
        [Input("birthDate")]
        public Input<Inputs.FusionAuthApplicationRegistrationConfigurationBirthDateArgs>? BirthDate { get; set; }

        [Input("confirmPassword")]
        public Input<bool>? ConfirmPassword { get; set; }

        /// <summary>
        /// Whether or not SAML Single Logout for this SAML IdP is enabled.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("firstName")]
        public Input<Inputs.FusionAuthApplicationRegistrationConfigurationFirstNameArgs>? FirstName { get; set; }

        /// <summary>
        /// The Id of an associated Form when using advanced registration configuration type. This field is required when application.registrationConfiguration.type is set to advanced.
        /// </summary>
        [Input("formId")]
        public Input<string>? FormId { get; set; }

        [Input("fullName")]
        public Input<Inputs.FusionAuthApplicationRegistrationConfigurationFullNameArgs>? FullName { get; set; }

        [Input("lastName")]
        public Input<Inputs.FusionAuthApplicationRegistrationConfigurationLastNameArgs>? LastName { get; set; }

        /// <summary>
        /// The unique login Id that will be collected during registration, this value can be email or username. Leaving the default value of email is preferred because an email address is globally unique.
        /// </summary>
        [Input("loginIdType")]
        public Input<string>? LoginIdType { get; set; }

        [Input("middleName")]
        public Input<Inputs.FusionAuthApplicationRegistrationConfigurationMiddleNameArgs>? MiddleName { get; set; }

        [Input("mobilePhone")]
        public Input<Inputs.FusionAuthApplicationRegistrationConfigurationMobilePhoneArgs>? MobilePhone { get; set; }

        /// <summary>
        /// The type of registration flow.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public FusionAuthApplicationRegistrationConfigurationArgs()
        {
        }
    }
}