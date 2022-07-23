// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package fusionauth

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// ## # Application Resource
//
// [Applications API](https://fusionauth.io/docs/v1/tech/apis/applications)
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-fusionauth/sdk/go/fusionauth"
// 	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
// 	"github.com/theogravity/pulumi-fusionauth/sdk/go/fusionauth"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := fusionauth.GetApplication(ctx, &GetApplicationArgs{
// 			Name: "FusionAuth",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
func GetApplication(ctx *pulumi.Context, args *GetApplicationArgs, opts ...pulumi.InvokeOption) (*GetApplicationResult, error) {
	opts = pkgInvokeDefaultOpts(opts)
	var rv GetApplicationResult
	err := ctx.Invoke("fusionauth:index/getApplication:getApplication", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getApplication.
type GetApplicationArgs struct {
	// The name of the Application.
	Name string `pulumi:"name"`
}

// A collection of values returned by getApplication.
type GetApplicationResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id   string `pulumi:"id"`
	Name string `pulumi:"name"`
}

func GetApplicationOutput(ctx *pulumi.Context, args GetApplicationOutputArgs, opts ...pulumi.InvokeOption) GetApplicationResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (GetApplicationResult, error) {
			args := v.(GetApplicationArgs)
			r, err := GetApplication(ctx, &args, opts...)
			var s GetApplicationResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(GetApplicationResultOutput)
}

// A collection of arguments for invoking getApplication.
type GetApplicationOutputArgs struct {
	// The name of the Application.
	Name pulumi.StringInput `pulumi:"name"`
}

func (GetApplicationOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*GetApplicationArgs)(nil)).Elem()
}

// A collection of values returned by getApplication.
type GetApplicationResultOutput struct{ *pulumi.OutputState }

func (GetApplicationResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*GetApplicationResult)(nil)).Elem()
}

func (o GetApplicationResultOutput) ToGetApplicationResultOutput() GetApplicationResultOutput {
	return o
}

func (o GetApplicationResultOutput) ToGetApplicationResultOutputWithContext(ctx context.Context) GetApplicationResultOutput {
	return o
}

// The provider-assigned unique ID for this managed resource.
func (o GetApplicationResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v GetApplicationResult) string { return v.Id }).(pulumi.StringOutput)
}

func (o GetApplicationResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v GetApplicationResult) string { return v.Name }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(GetApplicationResultOutput{})
}
