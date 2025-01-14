// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Core;
using Azure.ResourceManager.ServiceBus;

namespace Azure.ResourceManager.ServiceBus.Models
{
    /// <summary> Creates Migration configuration and starts migration of entities from Standard to Premium namespace. </summary>
    public partial class MigrationConfigPropertiesCreateOrUpdateOperation : Operation<MigrationConfigProperties>, IOperationSource<MigrationConfigProperties>
    {
        private readonly OperationInternals<MigrationConfigProperties> _operation;

        private readonly ArmResource _operationBase;

        /// <summary> Initializes a new instance of MigrationConfigPropertiesCreateOrUpdateOperation for mocking. </summary>
        protected MigrationConfigPropertiesCreateOrUpdateOperation()
        {
        }

        internal MigrationConfigPropertiesCreateOrUpdateOperation(ArmResource operationsBase, ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new OperationInternals<MigrationConfigProperties>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "MigrationConfigPropertiesCreateOrUpdateOperation");
            _operationBase = operationsBase;
        }

        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override MigrationConfigProperties Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<MigrationConfigProperties>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<MigrationConfigProperties>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        MigrationConfigProperties IOperationSource<MigrationConfigProperties>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = MigrationConfigPropertiesData.DeserializeMigrationConfigPropertiesData(document.RootElement);
            return new MigrationConfigProperties(_operationBase, data);
        }

        async ValueTask<MigrationConfigProperties> IOperationSource<MigrationConfigProperties>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = MigrationConfigPropertiesData.DeserializeMigrationConfigPropertiesData(document.RootElement);
            return new MigrationConfigProperties(_operationBase, data);
        }
    }
}
