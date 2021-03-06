// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Fixtures.DateTimeOffset
{
    using System.Threading.Tasks;
   using Models;

    /// <summary>
    /// Extension methods for SwaggerDateTimeOffsetClient.
    /// </summary>
    public static partial class SwaggerDateTimeOffsetClientExtensions
    {
            /// <summary>
            /// Product Types
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='responseCode'>
            /// The desired returned status code
            /// </param>
            /// <param name='product'>
            /// The only parameter
            /// </param>
            public static Product GetProduct(this ISwaggerDateTimeOffsetClient operations, string responseCode = default(string), Product product = default(Product))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerDateTimeOffsetClient)s).GetProductAsync(responseCode, product), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Product Types
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='responseCode'>
            /// The desired returned status code
            /// </param>
            /// <param name='product'>
            /// The only parameter
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Product> GetProductAsync(this ISwaggerDateTimeOffsetClient operations, string responseCode = default(string), Product product = default(Product), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.GetProductWithHttpMessagesAsync(responseCode, product, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Product Types
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='responseCode'>
            /// The desired returned status code
            /// </param>
            /// <param name='product'>
            /// The only parameter
            /// </param>
            public static Product PutProduct(this ISwaggerDateTimeOffsetClient operations, string responseCode = default(string), Product product = default(Product))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerDateTimeOffsetClient)s).PutProductAsync(responseCode, product), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Product Types
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='responseCode'>
            /// The desired returned status code
            /// </param>
            /// <param name='product'>
            /// The only parameter
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Product> PutProductAsync(this ISwaggerDateTimeOffsetClient operations, string responseCode = default(string), Product product = default(Product), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PutProductWithHttpMessagesAsync(responseCode, product, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Product Types
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='responseCode'>
            /// The desired returned status code
            /// </param>
            /// <param name='product'>
            /// The only parameter
            /// </param>
            public static Product PostProduct(this ISwaggerDateTimeOffsetClient operations, string responseCode = default(string), Product product = default(Product))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerDateTimeOffsetClient)s).PostProductAsync(responseCode, product), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Product Types
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='responseCode'>
            /// The desired returned status code
            /// </param>
            /// <param name='product'>
            /// The only parameter
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Product> PostProductAsync(this ISwaggerDateTimeOffsetClient operations, string responseCode = default(string), Product product = default(Product), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PostProductWithHttpMessagesAsync(responseCode, product, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Product Types
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='responseCode'>
            /// The desired returned status code
            /// </param>
            /// <param name='product'>
            /// The only parameter
            /// </param>
            public static Product PatchProduct(this ISwaggerDateTimeOffsetClient operations, string responseCode = default(string), Product product = default(Product))
            {
                return System.Threading.Tasks.Task.Factory.StartNew(s => ((ISwaggerDateTimeOffsetClient)s).PatchProductAsync(responseCode, product), operations, System.Threading.CancellationToken.None, System.Threading.Tasks.TaskCreationOptions.None, System.Threading.Tasks.TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Product Types
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='responseCode'>
            /// The desired returned status code
            /// </param>
            /// <param name='product'>
            /// The only parameter
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async System.Threading.Tasks.Task<Product> PatchProductAsync(this ISwaggerDateTimeOffsetClient operations, string responseCode = default(string), Product product = default(Product), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.PatchProductWithHttpMessagesAsync(responseCode, product, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
