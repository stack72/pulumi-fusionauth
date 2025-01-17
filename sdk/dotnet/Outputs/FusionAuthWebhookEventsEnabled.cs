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
    public sealed class FusionAuthWebhookEventsEnabled
    {
        /// <summary>
        /// When an audit log is created
        /// </summary>
        public readonly bool? AuditLogCreate;
        /// <summary>
        /// When an event log is created
        /// </summary>
        public readonly bool? EventLogCreate;
        /// <summary>
        /// When a JWT RSA Public / Private keypair may have been changed
        /// </summary>
        public readonly bool? JwtPublicKeyUpdate;
        /// <summary>
        /// When an access token is refreshed using a refresh token
        /// </summary>
        public readonly bool? JwtRefresh;
        /// <summary>
        /// When a JWT Refresh Token is revoked
        /// </summary>
        public readonly bool? JwtRefreshTokenRevoke;
        /// <summary>
        /// When kickstart has successfully completed
        /// </summary>
        public readonly bool? KickstartSuccess;
        /// <summary>
        /// When a user action is triggered
        /// </summary>
        public readonly bool? UserAction;
        /// <summary>
        /// When multiple users are created in bulk (i.e. during an import)
        /// </summary>
        public readonly bool? UserBulkCreate;
        /// <summary>
        /// When a user is created
        /// </summary>
        public readonly bool? UserCreate;
        /// <summary>
        /// When a user create transaction has completed
        /// </summary>
        public readonly bool? UserCreateComplete;
        /// <summary>
        /// When a user is deactivated
        /// </summary>
        public readonly bool? UserDeactivate;
        /// <summary>
        /// When a user is deleted
        /// </summary>
        public readonly bool? UserDelete;
        /// <summary>
        /// When a user delete transaction has completed
        /// </summary>
        public readonly bool? UserDeleteComplete;
        /// <summary>
        /// When a user updates their email address
        /// </summary>
        public readonly bool? UserEmailUpdate;
        /// <summary>
        /// When a user verifies their email address
        /// </summary>
        public readonly bool? UserEmailVerified;
        /// <summary>
        /// When a user fails a login request
        /// </summary>
        public readonly bool? UserLoginFailed;
        /// <summary>
        /// When a request to create a user with a login Id (email or username) which is already in use has been received
        /// </summary>
        public readonly bool? UserLoginIdDuplicateCreate;
        /// <summary>
        /// When a request to update a user and change their login Id (email or username) to one that is already in use has been received
        /// </summary>
        public readonly bool? UserLoginIdDuplicateUpdate;
        /// <summary>
        /// When a user begins a login request with a new device
        /// </summary>
        public readonly bool? UserLoginNewDevice;
        /// <summary>
        /// When a user completes a login request
        /// </summary>
        public readonly bool? UserLoginSuccess;
        /// <summary>
        /// When a user logs in and is considered to be a potential threat
        /// </summary>
        public readonly bool? UserLoginSuspicious;
        /// <summary>
        /// When Reactor detects a user is using a potentially breached password (requires an activated license)
        /// </summary>
        public readonly bool? UserPasswordBreach;
        /// <summary>
        /// When a forgot password email has been sent to a user
        /// </summary>
        public readonly bool? UserPasswordResetSend;
        /// <summary>
        /// When the process to reset a user password has started
        /// </summary>
        public readonly bool? UserPasswordResetStart;
        /// <summary>
        /// When a user has successfully reset their password
        /// </summary>
        public readonly bool? UserPasswordResetSuccess;
        /// <summary>
        /// When a user has updated their password
        /// </summary>
        public readonly bool? UserPasswordUpdate;
        /// <summary>
        /// When a user is reactivated
        /// </summary>
        public readonly bool? UserReactivate;
        /// <summary>
        /// When a user registration is created
        /// </summary>
        public readonly bool? UserRegistrationCreate;
        /// <summary>
        /// When a user registration create transaction has completed
        /// </summary>
        public readonly bool? UserRegistrationCreateComplete;
        /// <summary>
        /// When a user registration is deleted
        /// </summary>
        public readonly bool? UserRegistrationDelete;
        /// <summary>
        /// When a user registration delete transaction has completed
        /// </summary>
        public readonly bool? UserRegistrationDeleteComplete;
        /// <summary>
        /// When a user registration is updated
        /// </summary>
        public readonly bool? UserRegistrationUpdate;
        /// <summary>
        /// When a user registration update transaction has completed
        /// </summary>
        public readonly bool? UserRegistrationUpdateComplete;
        /// <summary>
        /// When a user completes registration verification
        /// </summary>
        public readonly bool? UserRegistrationVerified;
        /// <summary>
        /// When a user has added a two-factor method
        /// </summary>
        public readonly bool? UserTwoFactorMethodAdd;
        /// <summary>
        /// When a user has removed a two-factor method
        /// </summary>
        public readonly bool? UserTwoFactorMethodRemove;
        /// <summary>
        /// When a user is updated
        /// </summary>
        public readonly bool? UserUpdate;
        /// <summary>
        /// When a user update transaction has completed
        /// </summary>
        public readonly bool? UserUpdateComplete;

        [OutputConstructor]
        private FusionAuthWebhookEventsEnabled(
            bool? auditLogCreate,

            bool? eventLogCreate,

            bool? jwtPublicKeyUpdate,

            bool? jwtRefresh,

            bool? jwtRefreshTokenRevoke,

            bool? kickstartSuccess,

            bool? userAction,

            bool? userBulkCreate,

            bool? userCreate,

            bool? userCreateComplete,

            bool? userDeactivate,

            bool? userDelete,

            bool? userDeleteComplete,

            bool? userEmailUpdate,

            bool? userEmailVerified,

            bool? userLoginFailed,

            bool? userLoginIdDuplicateCreate,

            bool? userLoginIdDuplicateUpdate,

            bool? userLoginNewDevice,

            bool? userLoginSuccess,

            bool? userLoginSuspicious,

            bool? userPasswordBreach,

            bool? userPasswordResetSend,

            bool? userPasswordResetStart,

            bool? userPasswordResetSuccess,

            bool? userPasswordUpdate,

            bool? userReactivate,

            bool? userRegistrationCreate,

            bool? userRegistrationCreateComplete,

            bool? userRegistrationDelete,

            bool? userRegistrationDeleteComplete,

            bool? userRegistrationUpdate,

            bool? userRegistrationUpdateComplete,

            bool? userRegistrationVerified,

            bool? userTwoFactorMethodAdd,

            bool? userTwoFactorMethodRemove,

            bool? userUpdate,

            bool? userUpdateComplete)
        {
            AuditLogCreate = auditLogCreate;
            EventLogCreate = eventLogCreate;
            JwtPublicKeyUpdate = jwtPublicKeyUpdate;
            JwtRefresh = jwtRefresh;
            JwtRefreshTokenRevoke = jwtRefreshTokenRevoke;
            KickstartSuccess = kickstartSuccess;
            UserAction = userAction;
            UserBulkCreate = userBulkCreate;
            UserCreate = userCreate;
            UserCreateComplete = userCreateComplete;
            UserDeactivate = userDeactivate;
            UserDelete = userDelete;
            UserDeleteComplete = userDeleteComplete;
            UserEmailUpdate = userEmailUpdate;
            UserEmailVerified = userEmailVerified;
            UserLoginFailed = userLoginFailed;
            UserLoginIdDuplicateCreate = userLoginIdDuplicateCreate;
            UserLoginIdDuplicateUpdate = userLoginIdDuplicateUpdate;
            UserLoginNewDevice = userLoginNewDevice;
            UserLoginSuccess = userLoginSuccess;
            UserLoginSuspicious = userLoginSuspicious;
            UserPasswordBreach = userPasswordBreach;
            UserPasswordResetSend = userPasswordResetSend;
            UserPasswordResetStart = userPasswordResetStart;
            UserPasswordResetSuccess = userPasswordResetSuccess;
            UserPasswordUpdate = userPasswordUpdate;
            UserReactivate = userReactivate;
            UserRegistrationCreate = userRegistrationCreate;
            UserRegistrationCreateComplete = userRegistrationCreateComplete;
            UserRegistrationDelete = userRegistrationDelete;
            UserRegistrationDeleteComplete = userRegistrationDeleteComplete;
            UserRegistrationUpdate = userRegistrationUpdate;
            UserRegistrationUpdateComplete = userRegistrationUpdateComplete;
            UserRegistrationVerified = userRegistrationVerified;
            UserTwoFactorMethodAdd = userTwoFactorMethodAdd;
            UserTwoFactorMethodRemove = userTwoFactorMethodRemove;
            UserUpdate = userUpdate;
            UserUpdateComplete = userUpdateComplete;
        }
    }
}
