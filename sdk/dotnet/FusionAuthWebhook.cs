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
    /// ## # Webhook Resource
    /// 
    /// A FusionAuth Webhook is intended to consume JSON events emitted by FusionAuth. Creating a Webhook allows you to tell FusionAuth where you would like to receive these JSON events.
    /// 
    /// [Webhooks API](https://fusionauth.io/docs/v1/tech/apis/webhooks)
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
    ///         var example = new Fusionauth.FusionAuthWebhook("example", new Fusionauth.FusionAuthWebhookArgs
    ///         {
    ///             ApplicationIds = 
    ///             {
    ///                 "00000000-0000-0000-0000-000000000003",
    ///                 fusionauth_application.Example.Id,
    ///             },
    ///             ConnectTimeout = 1000,
    ///             Description = "The standard game Webhook",
    ///             EventsEnabled = new Fusionauth.Inputs.FusionAuthWebhookEventsEnabledArgs
    ///             {
    ///                 UserCreate = true,
    ///                 UserDelete = false,
    ///             },
    ///             Global = false,
    ///             Headers = 
    ///             {
    ///                 { "foo", "bar" },
    ///                 { "bar", "baz" },
    ///             },
    ///             HttpAuthenticationPassword = "password",
    ///             HttpAuthenticationUsername = "username",
    ///             ReadTimeout = 2000,
    ///             SslCertificate = @"  -----BEGIN CERTIFICATE-----\nMIIDUjCCArugAwIBAgIJANZCTNN98L9ZMA0GCSqGSIb3DQEBBQUAMHoxCzAJBgNV\nBAYTAlVTMQswCQYDVQQIEwJDTzEPMA0GA1UEBxMGZGVudmVyMQ8wDQYDVQQKEwZz\nZXRoLXMxCjAIBgNVBAsTAXMxDjAMBgNVBAMTBWludmVyMSAwHgYJKoZIhvcNAQkB\nFhFzamZkZkBsc2tkamZjLmNvbTAeFw0xNDA0MDkyMTA2MDdaFw0xNDA1MDkyMTA2\nMDdaMHoxCzAJBgNVBAYTAlVTMQswCQYDVQQIEwJDTzEPMA0GA1UEBxMGZGVudmVy\nMQ8wDQYDVQQKEwZzZXRoLXMxCjAIBgNVBAsTAXMxDjAMBgNVBAMTBWludmVyMSAw\nHgYJKoZIhvcNAQkBFhFzamZkZkBsc2tkamZjLmNvbTCBnzANBgkqhkiG9w0BAQEF\nAAOBjQAwgYkCgYEAxnQBqyuYvjUE4aFQ6vVZU5RqHmy3KiTg2NcxELIlZztUTK3a\nVFbJoBB4ixHXCCYslujthILyBjgT3F+IhSpPAcrlu8O5LVPaPCysh/SNrGNwH4lq\neiW9Z5WAhRO/nG7NZNa0USPHAei6b9Sv9PxuKCY+GJfAIwlO4/bltIH06/kCAwEA\nAaOB3zCB3DAdBgNVHQ4EFgQUU4SqJEFm1zW+CcLxmLlARrqtMN0wgawGA1UdIwSB\npDCBoYAUU4SqJEFm1zW+CcLxmLlARrqtMN2hfqR8MHoxCzAJBgNVBAYTAlVTMQsw\nCQYDVQQIEwJDTzEPMA0GA1UEBxMGZGVudmVyMQ8wDQYDVQQKEwZzZXRoLXMxCjAI\nBgNVBAsTAXMxDjAMBgNVBAMTBWludmVyMSAwHgYJKoZIhvcNAQkBFhFzamZkZkBs\nc2tkamZjLmNvbYIJANZCTNN98L9ZMAwGA1UdEwQFMAMBAf8wDQYJKoZIhvcNAQEF\nBQADgYEAY/cJsi3w6R4hF4PzAXLhGOg1tzTDYvol3w024WoehJur+qM0AY6UqtoJ\nneCq9af32IKbbOKkoaok+t1+/tylQVF/0FXMTKepxaMbG22vr4TmN3idPUYYbPfW\n5GkF7Hh96BjerrtiUPGuBZL50HoLZ5aR5oZUMAu7TXhOFp+vZp8=\n-----END CERTIFICATE-----
    /// ",
    ///             Url = "http://mygameserver.local:7001/fusionauth-webhook",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    [FusionauthResourceType("fusionauth:index/fusionAuthWebhook:FusionAuthWebhook")]
    public partial class FusionAuthWebhook : Pulumi.CustomResource
    {
        /// <summary>
        /// The Ids of the Applications that this Webhook should be associated with. If no Ids are specified and the global field is false, this Webhook will not be used.
        /// </summary>
        [Output("applicationIds")]
        public Output<ImmutableArray<string>> ApplicationIds { get; private set; } = null!;

        /// <summary>
        /// The connection timeout in milliseconds used when FusionAuth sends events to the Webhook.
        /// </summary>
        [Output("connectTimeout")]
        public Output<int> ConnectTimeout { get; private set; } = null!;

        /// <summary>
        /// A description of the Webhook. This is used for display purposes only.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// A mapping for the events that are enabled for this Webhook.
        /// </summary>
        [Output("eventsEnabled")]
        public Output<Outputs.FusionAuthWebhookEventsEnabled?> EventsEnabled { get; private set; } = null!;

        /// <summary>
        /// Whether or not this Webhook is used for all events or just for specific Applications.
        /// </summary>
        [Output("global")]
        public Output<bool?> Global { get; private set; } = null!;

        /// <summary>
        /// An object that contains headers that are sent as part of the HTTP request for the events.
        /// </summary>
        [Output("headers")]
        public Output<ImmutableDictionary<string, object>?> Headers { get; private set; } = null!;

        /// <summary>
        /// The HTTP basic authentication password that is sent as part of the HTTP request for the events.
        /// </summary>
        [Output("httpAuthenticationPassword")]
        public Output<string?> HttpAuthenticationPassword { get; private set; } = null!;

        /// <summary>
        /// -(Optional) The HTTP basic authentication username that is sent as part of the HTTP request for the events.
        /// </summary>
        [Output("httpAuthenticationUsername")]
        public Output<string?> HttpAuthenticationUsername { get; private set; } = null!;

        /// <summary>
        /// The read timeout in milliseconds used when FusionAuth sends events to the Webhook.
        /// </summary>
        [Output("readTimeout")]
        public Output<int> ReadTimeout { get; private set; } = null!;

        /// <summary>
        /// An SSL certificate in PEM format that is used to establish the a SSL (TLS specifically) connection to the Webhook.
        /// </summary>
        [Output("sslCertificate")]
        public Output<string?> SslCertificate { get; private set; } = null!;

        /// <summary>
        /// The fully qualified URL of the Webhook’s endpoint that will accept the event requests from FusionAuth.
        /// </summary>
        [Output("url")]
        public Output<string> Url { get; private set; } = null!;


        /// <summary>
        /// Create a FusionAuthWebhook resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FusionAuthWebhook(string name, FusionAuthWebhookArgs args, CustomResourceOptions? options = null)
            : base("fusionauth:index/fusionAuthWebhook:FusionAuthWebhook", name, args ?? new FusionAuthWebhookArgs(), MakeResourceOptions(options, ""))
        {
        }

        private FusionAuthWebhook(string name, Input<string> id, FusionAuthWebhookState? state = null, CustomResourceOptions? options = null)
            : base("fusionauth:index/fusionAuthWebhook:FusionAuthWebhook", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing FusionAuthWebhook resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FusionAuthWebhook Get(string name, Input<string> id, FusionAuthWebhookState? state = null, CustomResourceOptions? options = null)
        {
            return new FusionAuthWebhook(name, id, state, options);
        }
    }

    public sealed class FusionAuthWebhookArgs : Pulumi.ResourceArgs
    {
        [Input("applicationIds")]
        private InputList<string>? _applicationIds;

        /// <summary>
        /// The Ids of the Applications that this Webhook should be associated with. If no Ids are specified and the global field is false, this Webhook will not be used.
        /// </summary>
        public InputList<string> ApplicationIds
        {
            get => _applicationIds ?? (_applicationIds = new InputList<string>());
            set => _applicationIds = value;
        }

        /// <summary>
        /// The connection timeout in milliseconds used when FusionAuth sends events to the Webhook.
        /// </summary>
        [Input("connectTimeout", required: true)]
        public Input<int> ConnectTimeout { get; set; } = null!;

        /// <summary>
        /// A description of the Webhook. This is used for display purposes only.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// A mapping for the events that are enabled for this Webhook.
        /// </summary>
        [Input("eventsEnabled")]
        public Input<Inputs.FusionAuthWebhookEventsEnabledArgs>? EventsEnabled { get; set; }

        /// <summary>
        /// Whether or not this Webhook is used for all events or just for specific Applications.
        /// </summary>
        [Input("global")]
        public Input<bool>? Global { get; set; }

        [Input("headers")]
        private InputMap<object>? _headers;

        /// <summary>
        /// An object that contains headers that are sent as part of the HTTP request for the events.
        /// </summary>
        public InputMap<object> Headers
        {
            get => _headers ?? (_headers = new InputMap<object>());
            set => _headers = value;
        }

        /// <summary>
        /// The HTTP basic authentication password that is sent as part of the HTTP request for the events.
        /// </summary>
        [Input("httpAuthenticationPassword")]
        public Input<string>? HttpAuthenticationPassword { get; set; }

        /// <summary>
        /// -(Optional) The HTTP basic authentication username that is sent as part of the HTTP request for the events.
        /// </summary>
        [Input("httpAuthenticationUsername")]
        public Input<string>? HttpAuthenticationUsername { get; set; }

        /// <summary>
        /// The read timeout in milliseconds used when FusionAuth sends events to the Webhook.
        /// </summary>
        [Input("readTimeout", required: true)]
        public Input<int> ReadTimeout { get; set; } = null!;

        /// <summary>
        /// An SSL certificate in PEM format that is used to establish the a SSL (TLS specifically) connection to the Webhook.
        /// </summary>
        [Input("sslCertificate")]
        public Input<string>? SslCertificate { get; set; }

        /// <summary>
        /// The fully qualified URL of the Webhook’s endpoint that will accept the event requests from FusionAuth.
        /// </summary>
        [Input("url", required: true)]
        public Input<string> Url { get; set; } = null!;

        public FusionAuthWebhookArgs()
        {
        }
    }

    public sealed class FusionAuthWebhookState : Pulumi.ResourceArgs
    {
        [Input("applicationIds")]
        private InputList<string>? _applicationIds;

        /// <summary>
        /// The Ids of the Applications that this Webhook should be associated with. If no Ids are specified and the global field is false, this Webhook will not be used.
        /// </summary>
        public InputList<string> ApplicationIds
        {
            get => _applicationIds ?? (_applicationIds = new InputList<string>());
            set => _applicationIds = value;
        }

        /// <summary>
        /// The connection timeout in milliseconds used when FusionAuth sends events to the Webhook.
        /// </summary>
        [Input("connectTimeout")]
        public Input<int>? ConnectTimeout { get; set; }

        /// <summary>
        /// A description of the Webhook. This is used for display purposes only.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// A mapping for the events that are enabled for this Webhook.
        /// </summary>
        [Input("eventsEnabled")]
        public Input<Inputs.FusionAuthWebhookEventsEnabledGetArgs>? EventsEnabled { get; set; }

        /// <summary>
        /// Whether or not this Webhook is used for all events or just for specific Applications.
        /// </summary>
        [Input("global")]
        public Input<bool>? Global { get; set; }

        [Input("headers")]
        private InputMap<object>? _headers;

        /// <summary>
        /// An object that contains headers that are sent as part of the HTTP request for the events.
        /// </summary>
        public InputMap<object> Headers
        {
            get => _headers ?? (_headers = new InputMap<object>());
            set => _headers = value;
        }

        /// <summary>
        /// The HTTP basic authentication password that is sent as part of the HTTP request for the events.
        /// </summary>
        [Input("httpAuthenticationPassword")]
        public Input<string>? HttpAuthenticationPassword { get; set; }

        /// <summary>
        /// -(Optional) The HTTP basic authentication username that is sent as part of the HTTP request for the events.
        /// </summary>
        [Input("httpAuthenticationUsername")]
        public Input<string>? HttpAuthenticationUsername { get; set; }

        /// <summary>
        /// The read timeout in milliseconds used when FusionAuth sends events to the Webhook.
        /// </summary>
        [Input("readTimeout")]
        public Input<int>? ReadTimeout { get; set; }

        /// <summary>
        /// An SSL certificate in PEM format that is used to establish the a SSL (TLS specifically) connection to the Webhook.
        /// </summary>
        [Input("sslCertificate")]
        public Input<string>? SslCertificate { get; set; }

        /// <summary>
        /// The fully qualified URL of the Webhook’s endpoint that will accept the event requests from FusionAuth.
        /// </summary>
        [Input("url")]
        public Input<string>? Url { get; set; }

        public FusionAuthWebhookState()
        {
        }
    }
}