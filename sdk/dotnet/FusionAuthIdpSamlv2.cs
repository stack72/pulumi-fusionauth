// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;
using Pulumi;

namespace theogravity.Fusionauth
{
    /// <summary>
    /// ## # SAML v2 Identity Provider Resource
    /// 
    /// SAML v2 identity providers connect to external SAML v2 login systems. This type of login will optionally provide a Login with …​ button on FusionAuth’s login page. This button is customizable by using different properties of the identity provider.
    /// 
    /// Optionally, this identity provider can define one or more domains it is associated with. This is useful for allowing employees to log in with their corporate credentials. As long as the company has an identity solution that provides SAML v2, you can leverage this feature. This is referred to as a Domain Based Identity Provider. If you enable domains for an identity provider, the Login with …​ button will not be displayed. Instead, only the email form field will be displayed initially on the FusionAuth login page. Once the user types in their email address, FusionAuth will determine if the user is logging in locally or if they should be redirected to this identity provider. This is determined by extracting the domain from their email address and comparing it to the domains associated with the identity provider.
    /// 
    /// FusionAuth will locate the user’s email address in the SAML assertion which will be used to create or lookup the existing user. Additional claims from the SAML response can be used to reconcile the User to FusionAuth by using a SAML v2 Reconcile Lambda. Unless you assign a reconcile lambda to this provider, on the email address will be used from the available assertions returned by the SAML v2 identity provider.
    /// 
    /// [SAML v2 Connect Identity Providers API](https://fusionauth.io/docs/v1/tech/apis/identity-providers/samlv2/)
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Fusionauth = theogravity.Fusionauth;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var saml = new Fusionauth.FusionAuthIdpSamlv2("saml", new Fusionauth.FusionAuthIdpSamlv2Args
    ///         {
    ///             ApplicationConfigurations = 
    ///             {
    ///                 new Fusionauth.Inputs.FusionAuthIdpSamlv2ApplicationConfigurationArgs
    ///                 {
    ///                     ApplicationId = fusionauth_application.Myapp.Id,
    ///                     ButtonText = "Login with SAML (app text)",
    ///                     CreateRegistration = true,
    ///                     Enabled = true,
    ///                 },
    ///             },
    ///             ButtonText = "Login with SAML",
    ///             Debug = false,
    ///             EmailClaim = "email",
    ///             IdpEndpoint = "https://www.example.com/login",
    ///             PostRequest = true,
    ///             RequestSigningKey = "3168129b-91fa-46f4-9676-947f5509fdce",
    ///             SignRequest = true,
    ///             UseNameForEmail = true,
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    [FusionauthResourceType("fusionauth:index/fusionAuthIdpSamlv2:FusionAuthIdpSamlv2")]
    public partial class FusionAuthIdpSamlv2 : Pulumi.CustomResource
    {
        /// <summary>
        /// The configuration for each Application that the identity provider is enabled for.
        /// </summary>
        [Output("applicationConfigurations")]
        public Output<ImmutableArray<Outputs.FusionAuthIdpSamlv2ApplicationConfiguration>> ApplicationConfigurations { get; private set; } = null!;

        /// <summary>
        /// The top-level button image (URL) to use on the FusionAuth login page for this Identity Provider.
        /// </summary>
        [Output("buttonImageUrl")]
        public Output<string?> ButtonImageUrl { get; private set; } = null!;

        /// <summary>
        /// The top-level button text to use on the FusionAuth login page for this Identity Provider.
        /// </summary>
        [Output("buttonText")]
        public Output<string> ButtonText { get; private set; } = null!;

        /// <summary>
        /// Determines if debug is enabled for this provider. When enabled, each time this provider is invoked to reconcile a login an Event Log will be created.
        /// </summary>
        [Output("debug")]
        public Output<bool?> Debug { get; private set; } = null!;

        /// <summary>
        /// This is an optional list of domains that this OpenID Connect provider should be used for. This converts the FusionAuth login form to a domain-based login form. This type of form first asks the user for their email. FusionAuth then uses their email to determine if an OpenID Connect identity provider should be used. If an OpenID Connect provider should be used, the browser is redirected to the authorization endpoint of that identity provider. Otherwise, the password field is revealed on the form so that the user can login using FusionAuth.
        /// </summary>
        [Output("domains")]
        public Output<ImmutableArray<string>> Domains { get; private set; } = null!;

        /// <summary>
        /// The name of the email claim (Attribute in the Assertion element) in the SAML response that FusionAuth uses to uniquely identity the user. If this is not set, the `use_name_for_email` flag must be true.
        /// </summary>
        [Output("emailClaim")]
        public Output<string?> EmailClaim { get; private set; } = null!;

        /// <summary>
        /// Determines if this provider is enabled. If it is false then it will be disabled globally.
        /// </summary>
        [Output("enabled")]
        public Output<bool?> Enabled { get; private set; } = null!;

        /// <summary>
        /// The SAML v2 login page of the identity provider.
        /// </summary>
        [Output("idpEndpoint")]
        public Output<string?> IdpEndpoint { get; private set; } = null!;

        /// <summary>
        /// The ID to use for the new identity provider. If not specified a secure random UUID will be generated.
        /// </summary>
        [Output("idpId")]
        public Output<string?> IdpId { get; private set; } = null!;

        /// <summary>
        /// The id of the key stored in Key Master that is used to verify the SAML response sent back to FusionAuth from the identity provider. This key must be a verification only key or certificate (meaning that it only has a public key component).
        /// </summary>
        [Output("keyId")]
        public Output<string> KeyId { get; private set; } = null!;

        /// <summary>
        /// The unique Id of the lambda to used during the user reconcile process to map custom claims from the external identity provider to the FusionAuth user.
        /// </summary>
        [Output("lambdaReconcileId")]
        public Output<string?> LambdaReconcileId { get; private set; } = null!;

        /// <summary>
        /// The linking strategy to use when creating the link between the {idp_display_name} Identity Provider and the user.
        /// </summary>
        [Output("linkingStrategy")]
        public Output<string> LinkingStrategy { get; private set; } = null!;

        /// <summary>
        /// The name of this OpenID Connect identity provider. This is only used for display purposes.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Either urn:oasis:names:tc:SAML:2.0:nameid-format:persistent or urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress depending on which NameId format you wish to use.
        /// </summary>
        [Output("nameIdFormat")]
        public Output<string> NameIdFormat { get; private set; } = null!;

        /// <summary>
        /// Set this value equal to true if you wish to use POST bindings with this OpenID Connect identity provider. The default value of false means that a redirect binding which uses a GET request will be used.
        /// </summary>
        [Output("postRequest")]
        public Output<bool?> PostRequest { get; private set; } = null!;

        /// <summary>
        /// TThe key pair Id to use to sign the SAML request. Required when `sign_request` is true.
        /// </summary>
        [Output("requestSigningKey")]
        public Output<string?> RequestSigningKey { get; private set; } = null!;

        /// <summary>
        /// When true authentication requests sent to the identity provider will be signed.
        /// </summary>
        [Output("signRequest")]
        public Output<bool?> SignRequest { get; private set; } = null!;

        /// <summary>
        /// The configuration for each Tenant that limits the number of links a user may have for a particular identity provider.
        /// </summary>
        [Output("tenantConfigurations")]
        public Output<ImmutableArray<Outputs.FusionAuthIdpSamlv2TenantConfiguration>> TenantConfigurations { get; private set; } = null!;

        /// <summary>
        /// Whether or not FusionAuth will use the NameID element value as the email address of the user for reconciliation processing. If this is false, then the `email_claim` property must be set.
        /// </summary>
        [Output("useNameForEmail")]
        public Output<bool?> UseNameForEmail { get; private set; } = null!;

        /// <summary>
        /// The XML signature canonicalization method used when digesting and signing the SAML request.
        /// </summary>
        [Output("xmlSignatureCanonicalizationMethod")]
        public Output<string?> XmlSignatureCanonicalizationMethod { get; private set; } = null!;


        /// <summary>
        /// Create a FusionAuthIdpSamlv2 resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FusionAuthIdpSamlv2(string name, FusionAuthIdpSamlv2Args args, CustomResourceOptions? options = null)
            : base("fusionauth:index/fusionAuthIdpSamlv2:FusionAuthIdpSamlv2", name, args ?? new FusionAuthIdpSamlv2Args(), MakeResourceOptions(options, ""))
        {
        }

        private FusionAuthIdpSamlv2(string name, Input<string> id, FusionAuthIdpSamlv2State? state = null, CustomResourceOptions? options = null)
            : base("fusionauth:index/fusionAuthIdpSamlv2:FusionAuthIdpSamlv2", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                PluginDownloadURL = "https://github.com/theogravity/pulumi-fusionauth/releases/download/v${VERSION}",
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing FusionAuthIdpSamlv2 resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FusionAuthIdpSamlv2 Get(string name, Input<string> id, FusionAuthIdpSamlv2State? state = null, CustomResourceOptions? options = null)
        {
            return new FusionAuthIdpSamlv2(name, id, state, options);
        }
    }

    public sealed class FusionAuthIdpSamlv2Args : Pulumi.ResourceArgs
    {
        [Input("applicationConfigurations")]
        private InputList<Inputs.FusionAuthIdpSamlv2ApplicationConfigurationArgs>? _applicationConfigurations;

        /// <summary>
        /// The configuration for each Application that the identity provider is enabled for.
        /// </summary>
        public InputList<Inputs.FusionAuthIdpSamlv2ApplicationConfigurationArgs> ApplicationConfigurations
        {
            get => _applicationConfigurations ?? (_applicationConfigurations = new InputList<Inputs.FusionAuthIdpSamlv2ApplicationConfigurationArgs>());
            set => _applicationConfigurations = value;
        }

        /// <summary>
        /// The top-level button image (URL) to use on the FusionAuth login page for this Identity Provider.
        /// </summary>
        [Input("buttonImageUrl")]
        public Input<string>? ButtonImageUrl { get; set; }

        /// <summary>
        /// The top-level button text to use on the FusionAuth login page for this Identity Provider.
        /// </summary>
        [Input("buttonText", required: true)]
        public Input<string> ButtonText { get; set; } = null!;

        /// <summary>
        /// Determines if debug is enabled for this provider. When enabled, each time this provider is invoked to reconcile a login an Event Log will be created.
        /// </summary>
        [Input("debug")]
        public Input<bool>? Debug { get; set; }

        [Input("domains")]
        private InputList<string>? _domains;

        /// <summary>
        /// This is an optional list of domains that this OpenID Connect provider should be used for. This converts the FusionAuth login form to a domain-based login form. This type of form first asks the user for their email. FusionAuth then uses their email to determine if an OpenID Connect identity provider should be used. If an OpenID Connect provider should be used, the browser is redirected to the authorization endpoint of that identity provider. Otherwise, the password field is revealed on the form so that the user can login using FusionAuth.
        /// </summary>
        public InputList<string> Domains
        {
            get => _domains ?? (_domains = new InputList<string>());
            set => _domains = value;
        }

        /// <summary>
        /// The name of the email claim (Attribute in the Assertion element) in the SAML response that FusionAuth uses to uniquely identity the user. If this is not set, the `use_name_for_email` flag must be true.
        /// </summary>
        [Input("emailClaim")]
        public Input<string>? EmailClaim { get; set; }

        /// <summary>
        /// Determines if this provider is enabled. If it is false then it will be disabled globally.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The SAML v2 login page of the identity provider.
        /// </summary>
        [Input("idpEndpoint")]
        public Input<string>? IdpEndpoint { get; set; }

        /// <summary>
        /// The ID to use for the new identity provider. If not specified a secure random UUID will be generated.
        /// </summary>
        [Input("idpId")]
        public Input<string>? IdpId { get; set; }

        /// <summary>
        /// The id of the key stored in Key Master that is used to verify the SAML response sent back to FusionAuth from the identity provider. This key must be a verification only key or certificate (meaning that it only has a public key component).
        /// </summary>
        [Input("keyId", required: true)]
        public Input<string> KeyId { get; set; } = null!;

        /// <summary>
        /// The unique Id of the lambda to used during the user reconcile process to map custom claims from the external identity provider to the FusionAuth user.
        /// </summary>
        [Input("lambdaReconcileId")]
        public Input<string>? LambdaReconcileId { get; set; }

        /// <summary>
        /// The linking strategy to use when creating the link between the {idp_display_name} Identity Provider and the user.
        /// </summary>
        [Input("linkingStrategy")]
        public Input<string>? LinkingStrategy { get; set; }

        /// <summary>
        /// The name of this OpenID Connect identity provider. This is only used for display purposes.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Either urn:oasis:names:tc:SAML:2.0:nameid-format:persistent or urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress depending on which NameId format you wish to use.
        /// </summary>
        [Input("nameIdFormat")]
        public Input<string>? NameIdFormat { get; set; }

        /// <summary>
        /// Set this value equal to true if you wish to use POST bindings with this OpenID Connect identity provider. The default value of false means that a redirect binding which uses a GET request will be used.
        /// </summary>
        [Input("postRequest")]
        public Input<bool>? PostRequest { get; set; }

        /// <summary>
        /// TThe key pair Id to use to sign the SAML request. Required when `sign_request` is true.
        /// </summary>
        [Input("requestSigningKey")]
        public Input<string>? RequestSigningKey { get; set; }

        /// <summary>
        /// When true authentication requests sent to the identity provider will be signed.
        /// </summary>
        [Input("signRequest")]
        public Input<bool>? SignRequest { get; set; }

        [Input("tenantConfigurations")]
        private InputList<Inputs.FusionAuthIdpSamlv2TenantConfigurationArgs>? _tenantConfigurations;

        /// <summary>
        /// The configuration for each Tenant that limits the number of links a user may have for a particular identity provider.
        /// </summary>
        public InputList<Inputs.FusionAuthIdpSamlv2TenantConfigurationArgs> TenantConfigurations
        {
            get => _tenantConfigurations ?? (_tenantConfigurations = new InputList<Inputs.FusionAuthIdpSamlv2TenantConfigurationArgs>());
            set => _tenantConfigurations = value;
        }

        /// <summary>
        /// Whether or not FusionAuth will use the NameID element value as the email address of the user for reconciliation processing. If this is false, then the `email_claim` property must be set.
        /// </summary>
        [Input("useNameForEmail")]
        public Input<bool>? UseNameForEmail { get; set; }

        /// <summary>
        /// The XML signature canonicalization method used when digesting and signing the SAML request.
        /// </summary>
        [Input("xmlSignatureCanonicalizationMethod")]
        public Input<string>? XmlSignatureCanonicalizationMethod { get; set; }

        public FusionAuthIdpSamlv2Args()
        {
        }
    }

    public sealed class FusionAuthIdpSamlv2State : Pulumi.ResourceArgs
    {
        [Input("applicationConfigurations")]
        private InputList<Inputs.FusionAuthIdpSamlv2ApplicationConfigurationGetArgs>? _applicationConfigurations;

        /// <summary>
        /// The configuration for each Application that the identity provider is enabled for.
        /// </summary>
        public InputList<Inputs.FusionAuthIdpSamlv2ApplicationConfigurationGetArgs> ApplicationConfigurations
        {
            get => _applicationConfigurations ?? (_applicationConfigurations = new InputList<Inputs.FusionAuthIdpSamlv2ApplicationConfigurationGetArgs>());
            set => _applicationConfigurations = value;
        }

        /// <summary>
        /// The top-level button image (URL) to use on the FusionAuth login page for this Identity Provider.
        /// </summary>
        [Input("buttonImageUrl")]
        public Input<string>? ButtonImageUrl { get; set; }

        /// <summary>
        /// The top-level button text to use on the FusionAuth login page for this Identity Provider.
        /// </summary>
        [Input("buttonText")]
        public Input<string>? ButtonText { get; set; }

        /// <summary>
        /// Determines if debug is enabled for this provider. When enabled, each time this provider is invoked to reconcile a login an Event Log will be created.
        /// </summary>
        [Input("debug")]
        public Input<bool>? Debug { get; set; }

        [Input("domains")]
        private InputList<string>? _domains;

        /// <summary>
        /// This is an optional list of domains that this OpenID Connect provider should be used for. This converts the FusionAuth login form to a domain-based login form. This type of form first asks the user for their email. FusionAuth then uses their email to determine if an OpenID Connect identity provider should be used. If an OpenID Connect provider should be used, the browser is redirected to the authorization endpoint of that identity provider. Otherwise, the password field is revealed on the form so that the user can login using FusionAuth.
        /// </summary>
        public InputList<string> Domains
        {
            get => _domains ?? (_domains = new InputList<string>());
            set => _domains = value;
        }

        /// <summary>
        /// The name of the email claim (Attribute in the Assertion element) in the SAML response that FusionAuth uses to uniquely identity the user. If this is not set, the `use_name_for_email` flag must be true.
        /// </summary>
        [Input("emailClaim")]
        public Input<string>? EmailClaim { get; set; }

        /// <summary>
        /// Determines if this provider is enabled. If it is false then it will be disabled globally.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// The SAML v2 login page of the identity provider.
        /// </summary>
        [Input("idpEndpoint")]
        public Input<string>? IdpEndpoint { get; set; }

        /// <summary>
        /// The ID to use for the new identity provider. If not specified a secure random UUID will be generated.
        /// </summary>
        [Input("idpId")]
        public Input<string>? IdpId { get; set; }

        /// <summary>
        /// The id of the key stored in Key Master that is used to verify the SAML response sent back to FusionAuth from the identity provider. This key must be a verification only key or certificate (meaning that it only has a public key component).
        /// </summary>
        [Input("keyId")]
        public Input<string>? KeyId { get; set; }

        /// <summary>
        /// The unique Id of the lambda to used during the user reconcile process to map custom claims from the external identity provider to the FusionAuth user.
        /// </summary>
        [Input("lambdaReconcileId")]
        public Input<string>? LambdaReconcileId { get; set; }

        /// <summary>
        /// The linking strategy to use when creating the link between the {idp_display_name} Identity Provider and the user.
        /// </summary>
        [Input("linkingStrategy")]
        public Input<string>? LinkingStrategy { get; set; }

        /// <summary>
        /// The name of this OpenID Connect identity provider. This is only used for display purposes.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Either urn:oasis:names:tc:SAML:2.0:nameid-format:persistent or urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress depending on which NameId format you wish to use.
        /// </summary>
        [Input("nameIdFormat")]
        public Input<string>? NameIdFormat { get; set; }

        /// <summary>
        /// Set this value equal to true if you wish to use POST bindings with this OpenID Connect identity provider. The default value of false means that a redirect binding which uses a GET request will be used.
        /// </summary>
        [Input("postRequest")]
        public Input<bool>? PostRequest { get; set; }

        /// <summary>
        /// TThe key pair Id to use to sign the SAML request. Required when `sign_request` is true.
        /// </summary>
        [Input("requestSigningKey")]
        public Input<string>? RequestSigningKey { get; set; }

        /// <summary>
        /// When true authentication requests sent to the identity provider will be signed.
        /// </summary>
        [Input("signRequest")]
        public Input<bool>? SignRequest { get; set; }

        [Input("tenantConfigurations")]
        private InputList<Inputs.FusionAuthIdpSamlv2TenantConfigurationGetArgs>? _tenantConfigurations;

        /// <summary>
        /// The configuration for each Tenant that limits the number of links a user may have for a particular identity provider.
        /// </summary>
        public InputList<Inputs.FusionAuthIdpSamlv2TenantConfigurationGetArgs> TenantConfigurations
        {
            get => _tenantConfigurations ?? (_tenantConfigurations = new InputList<Inputs.FusionAuthIdpSamlv2TenantConfigurationGetArgs>());
            set => _tenantConfigurations = value;
        }

        /// <summary>
        /// Whether or not FusionAuth will use the NameID element value as the email address of the user for reconciliation processing. If this is false, then the `email_claim` property must be set.
        /// </summary>
        [Input("useNameForEmail")]
        public Input<bool>? UseNameForEmail { get; set; }

        /// <summary>
        /// The XML signature canonicalization method used when digesting and signing the SAML request.
        /// </summary>
        [Input("xmlSignatureCanonicalizationMethod")]
        public Input<string>? XmlSignatureCanonicalizationMethod { get; set; }

        public FusionAuthIdpSamlv2State()
        {
        }
    }
}