// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * ## # Registration Resource
 *
 * A registration is the association between a User and an Application that they log into.
 *
 * [Registrations API](https://fusionauth.io/docs/v1/tech/apis/registrations)
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as pulumi_fusionauth from "@theogravity/pulumi-fusionauth";
 *
 * const example = new fusionauth.FusionAuthRegistration("example", {
 *     userId: fusionauth_user.example.id,
 *     applicationId: data.fusionauth_application.FusionAuth.id,
 *     roles: ["admin"],
 *     username: "theadmin",
 * });
 * ```
 */
export class FusionAuthRegistration extends pulumi.CustomResource {
    /**
     * Get an existing FusionAuthRegistration resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: FusionAuthRegistrationState, opts?: pulumi.CustomResourceOptions): FusionAuthRegistration {
        return new FusionAuthRegistration(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'fusionauth:index/fusionAuthRegistration:FusionAuthRegistration';

    /**
     * Returns true if the given object is an instance of FusionAuthRegistration.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is FusionAuthRegistration {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === FusionAuthRegistration.__pulumiType;
    }

    /**
     * The Id of the Application that this registration is for.
     */
    public readonly applicationId!: pulumi.Output<string>;
    /**
     * The authentication token that may be used in place of the User’s password when authenticating against this application represented by this registration. This parameter is ignored if generateAuthenticationToken is set to true and instead the value will be generated.
     */
    public readonly authenticationToken!: pulumi.Output<string>;
    /**
     * An object that can hold any information about the User for this registration that should be persisted.
     */
    public readonly data!: pulumi.Output<{[key: string]: any} | undefined>;
    /**
     * Determines if FusionAuth should generate an Authentication Token for this registration.
     */
    public readonly generateAuthenticationToken!: pulumi.Output<boolean | undefined>;
    /**
     * An array of locale strings that give, in order, the User’s preferred languages for this registration. These are important for email templates and other localizable text.
     */
    public readonly preferredLanguages!: pulumi.Output<string[] | undefined>;
    /**
     * The list of roles that the User has for this registration.
     */
    public readonly roles!: pulumi.Output<string[] | undefined>;
    /**
     * Indicates to FusionAuth that it should skip registration verification even if it is enabled for the Application.
     */
    public readonly skipRegistrationValidation!: pulumi.Output<boolean | undefined>;
    /**
     * The User’s preferred timezone for this registration. The string will be in an IANA time zone format.
     */
    public readonly timezone!: pulumi.Output<string | undefined>;
    /**
     * The Id of the User that is registering for the Application.
     */
    public readonly userId!: pulumi.Output<string>;
    /**
     * The username of the User for this registration only.
     */
    public readonly username!: pulumi.Output<string | undefined>;

    /**
     * Create a FusionAuthRegistration resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: FusionAuthRegistrationArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: FusionAuthRegistrationArgs | FusionAuthRegistrationState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as FusionAuthRegistrationState | undefined;
            resourceInputs["applicationId"] = state ? state.applicationId : undefined;
            resourceInputs["authenticationToken"] = state ? state.authenticationToken : undefined;
            resourceInputs["data"] = state ? state.data : undefined;
            resourceInputs["generateAuthenticationToken"] = state ? state.generateAuthenticationToken : undefined;
            resourceInputs["preferredLanguages"] = state ? state.preferredLanguages : undefined;
            resourceInputs["roles"] = state ? state.roles : undefined;
            resourceInputs["skipRegistrationValidation"] = state ? state.skipRegistrationValidation : undefined;
            resourceInputs["timezone"] = state ? state.timezone : undefined;
            resourceInputs["userId"] = state ? state.userId : undefined;
            resourceInputs["username"] = state ? state.username : undefined;
        } else {
            const args = argsOrState as FusionAuthRegistrationArgs | undefined;
            if ((!args || args.applicationId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'applicationId'");
            }
            if ((!args || args.userId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'userId'");
            }
            resourceInputs["applicationId"] = args ? args.applicationId : undefined;
            resourceInputs["authenticationToken"] = args ? args.authenticationToken : undefined;
            resourceInputs["data"] = args ? args.data : undefined;
            resourceInputs["generateAuthenticationToken"] = args ? args.generateAuthenticationToken : undefined;
            resourceInputs["preferredLanguages"] = args ? args.preferredLanguages : undefined;
            resourceInputs["roles"] = args ? args.roles : undefined;
            resourceInputs["skipRegistrationValidation"] = args ? args.skipRegistrationValidation : undefined;
            resourceInputs["timezone"] = args ? args.timezone : undefined;
            resourceInputs["userId"] = args ? args.userId : undefined;
            resourceInputs["username"] = args ? args.username : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(FusionAuthRegistration.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering FusionAuthRegistration resources.
 */
export interface FusionAuthRegistrationState {
    /**
     * The Id of the Application that this registration is for.
     */
    applicationId?: pulumi.Input<string>;
    /**
     * The authentication token that may be used in place of the User’s password when authenticating against this application represented by this registration. This parameter is ignored if generateAuthenticationToken is set to true and instead the value will be generated.
     */
    authenticationToken?: pulumi.Input<string>;
    /**
     * An object that can hold any information about the User for this registration that should be persisted.
     */
    data?: pulumi.Input<{[key: string]: any}>;
    /**
     * Determines if FusionAuth should generate an Authentication Token for this registration.
     */
    generateAuthenticationToken?: pulumi.Input<boolean>;
    /**
     * An array of locale strings that give, in order, the User’s preferred languages for this registration. These are important for email templates and other localizable text.
     */
    preferredLanguages?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The list of roles that the User has for this registration.
     */
    roles?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Indicates to FusionAuth that it should skip registration verification even if it is enabled for the Application.
     */
    skipRegistrationValidation?: pulumi.Input<boolean>;
    /**
     * The User’s preferred timezone for this registration. The string will be in an IANA time zone format.
     */
    timezone?: pulumi.Input<string>;
    /**
     * The Id of the User that is registering for the Application.
     */
    userId?: pulumi.Input<string>;
    /**
     * The username of the User for this registration only.
     */
    username?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a FusionAuthRegistration resource.
 */
export interface FusionAuthRegistrationArgs {
    /**
     * The Id of the Application that this registration is for.
     */
    applicationId: pulumi.Input<string>;
    /**
     * The authentication token that may be used in place of the User’s password when authenticating against this application represented by this registration. This parameter is ignored if generateAuthenticationToken is set to true and instead the value will be generated.
     */
    authenticationToken?: pulumi.Input<string>;
    /**
     * An object that can hold any information about the User for this registration that should be persisted.
     */
    data?: pulumi.Input<{[key: string]: any}>;
    /**
     * Determines if FusionAuth should generate an Authentication Token for this registration.
     */
    generateAuthenticationToken?: pulumi.Input<boolean>;
    /**
     * An array of locale strings that give, in order, the User’s preferred languages for this registration. These are important for email templates and other localizable text.
     */
    preferredLanguages?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The list of roles that the User has for this registration.
     */
    roles?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Indicates to FusionAuth that it should skip registration verification even if it is enabled for the Application.
     */
    skipRegistrationValidation?: pulumi.Input<boolean>;
    /**
     * The User’s preferred timezone for this registration. The string will be in an IANA time zone format.
     */
    timezone?: pulumi.Input<string>;
    /**
     * The Id of the User that is registering for the Application.
     */
    userId: pulumi.Input<string>;
    /**
     * The username of the User for this registration only.
     */
    username?: pulumi.Input<string>;
}