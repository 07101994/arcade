// <auto-generated>
// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.
//
// </auto-generated>

namespace Microsoft.DotNet.Helix.Client
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Storage.
    /// </summary>
    public static partial class StorageExtensions
    {
            /// <summary>
            /// This API requires authentication.
            /// List of the containers associated with a specified user, optionally freshly
            /// generating read/write tokens for their use.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='getSasTokens'>
            /// Optional: Generate fresh SAS tokens for provided containers
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<ContainerInformation>> ListAsync(this IStorage operations, bool? getSasTokens = default(bool?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(getSasTokens, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This API requires authentication.
            /// Create a new drop container in the Helix-managed storage accounts.
            /// </summary>
            /// <remarks>
            /// POST body should be empty or contain a JSON blob.
            ///
            /// If JSON is specified, it may contain the following:
            /// ExpirationTimeUtc - Requested time for expiration of the container (after
            /// which it will be deleted)
            /// DesiredName - Name of container if this does not already exist.
            ///
            /// Creator field will be set to the authenticated user
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='newContainer'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ContainerInformation> NewOperationAsync(this IStorage operations, ContainerCreationRequest newContainer, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.NewOperationWithHttpMessagesAsync(newContainer, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// This API requires authentication.
            /// Extend the lifespan of a container, in days, up to the maximum allowed
            /// lifespan of a new container relative to UtcNow
            /// </summary>
            /// <remarks>
            /// POST body should contain a JSON blob matching ContainerExtensionRequest
            /// type
            ///
            /// If JSON is specified, it may contain the following:
            ///
            /// ExtensionInDays - Days to increment expiration time
            /// ContainerName - Name of container (must be created by user)
            /// StorageAccountName - Storage account name for container.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='extensionRequest'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ContainerInformation> ExtendExpirationAsync(this IStorage operations, ContainerExtensionRequest extensionRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                using (var _result = await operations.ExtendExpirationWithHttpMessagesAsync(extensionRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}