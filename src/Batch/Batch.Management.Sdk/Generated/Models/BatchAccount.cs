// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{
    using System.Linq;

    /// <summary>
    /// Contains information about an Azure Batch account.
    /// </summary>
    [Microsoft.Rest.Serialization.JsonTransformation]
    public partial class BatchAccount : Resource
    {
        /// <summary>
        /// Initializes a new instance of the BatchAccount class.
        /// </summary>
        public BatchAccount()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BatchAccount class.
        /// </summary>

        /// <param name="id">The ID of the resource.
        /// </param>

        /// <param name="name">The name of the resource.
        /// </param>

        /// <param name="type">The type of the resource.
        /// </param>

        /// <param name="location">The location of the resource.
        /// </param>

        /// <param name="tags">The tags of the resource.
        /// </param>

        /// <param name="identity">The identity of the Batch account.
        /// </param>

        /// <param name="provisioningState">The provisioned state of the resource
        /// Possible values include: &#39;Invalid&#39;, &#39;Creating&#39;, &#39;Deleting&#39;, &#39;Succeeded&#39;,
        /// &#39;Failed&#39;, &#39;Cancelled&#39;</param>

        /// <param name="networkProfile">The network profile only takes effect when publicNetworkAccess is enabled.
        /// </param>

        /// <param name="accountEndpoint">The account endpoint used to interact with the Batch service.
        /// </param>

        /// <param name="nodeManagementEndpoint">The endpoint used by compute node to connect to the Batch node management
        /// service.
        /// </param>

        /// <param name="poolAllocationMode">The allocation mode for creating pools in the Batch account.
        /// Possible values include: &#39;BatchService&#39;, &#39;UserSubscription&#39;</param>

        /// <param name="keyVaultReference">Identifies the Azure key vault associated with a Batch account.
        /// </param>

        /// <param name="publicNetworkAccess">If not specified, the default value is &#39;enabled&#39;.
        /// Possible values include: &#39;Enabled&#39;, &#39;Disabled&#39;</param>

        /// <param name="privateEndpointConnections">List of private endpoint connections associated with the Batch account
        /// </param>

        /// <param name="autoStorage">Contains information about the auto-storage account associated with a Batch
        /// account.
        /// </param>

        /// <param name="encryption">Configures how customer data is encrypted inside the Batch account. By
        /// default, accounts are encrypted using a Microsoft managed key. For
        /// additional control, a customer-managed key can be used instead.
        /// </param>

        /// <param name="dedicatedCoreQuota">For accounts with PoolAllocationMode set to UserSubscription, quota is
        /// managed on the subscription so this value is not returned.
        /// </param>

        /// <param name="lowPriorityCoreQuota">For accounts with PoolAllocationMode set to UserSubscription, quota is
        /// managed on the subscription so this value is not returned.
        /// </param>

        /// <param name="dedicatedCoreQuotaPerVMFamily">A list of the dedicated core quota per Virtual Machine family for the Batch
        /// account. For accounts with PoolAllocationMode set to UserSubscription,
        /// quota is managed on the subscription so this value is not returned.
        /// </param>

        /// <param name="dedicatedCoreQuotaPerVMFamilyEnforced">If this flag is true, dedicated core quota is enforced via both the
        /// dedicatedCoreQuotaPerVMFamily and dedicatedCoreQuota properties on the
        /// account. If this flag is false, dedicated core quota is enforced only via
        /// the dedicatedCoreQuota property on the account and does not consider
        /// Virtual Machine family.
        /// </param>

        /// <param name="poolQuota">The pool quota for the Batch account.
        /// </param>

        /// <param name="activeJobAndJobScheduleQuota">The active job and job schedule quota for the Batch account.
        /// </param>

        /// <param name="allowedAuthenticationModes">List of allowed authentication modes for the Batch account that can be used
        /// to authenticate with the data plane. This does not affect authentication
        /// with the control plane.
        /// </param>
        public BatchAccount(string id = default(string), string name = default(string), string type = default(string), string location = default(string), System.Collections.Generic.IDictionary<string, string> tags = default(System.Collections.Generic.IDictionary<string, string>), BatchAccountIdentity identity = default(BatchAccountIdentity), ProvisioningState provisioningState = default(ProvisioningState), NetworkProfile networkProfile = default(NetworkProfile), string accountEndpoint = default(string), string nodeManagementEndpoint = default(string), PoolAllocationMode? poolAllocationMode = default(PoolAllocationMode?), KeyVaultReference keyVaultReference = default(KeyVaultReference), PublicNetworkAccessType? publicNetworkAccess = default(PublicNetworkAccessType?), System.Collections.Generic.IList<PrivateEndpointConnection> privateEndpointConnections = default(System.Collections.Generic.IList<PrivateEndpointConnection>), AutoStorageProperties autoStorage = default(AutoStorageProperties), EncryptionProperties encryption = default(EncryptionProperties), int? dedicatedCoreQuota = default(int?), int? lowPriorityCoreQuota = default(int?), System.Collections.Generic.IList<VirtualMachineFamilyCoreQuota> dedicatedCoreQuotaPerVMFamily = default(System.Collections.Generic.IList<VirtualMachineFamilyCoreQuota>), bool dedicatedCoreQuotaPerVMFamilyEnforced = default(bool), int poolQuota = default(int), int activeJobAndJobScheduleQuota = default(int), System.Collections.Generic.IList<AuthenticationMode?> allowedAuthenticationModes = default(System.Collections.Generic.IList<AuthenticationMode?>))

        : base(id, name, type, location, tags)
        {
            this.Identity = identity;
            this.ProvisioningState = provisioningState;
            this.NetworkProfile = networkProfile;
            this.AccountEndpoint = accountEndpoint;
            this.NodeManagementEndpoint = nodeManagementEndpoint;
            this.PoolAllocationMode = poolAllocationMode;
            this.KeyVaultReference = keyVaultReference;
            this.PublicNetworkAccess = publicNetworkAccess;
            this.PrivateEndpointConnections = privateEndpointConnections;
            this.AutoStorage = autoStorage;
            this.Encryption = encryption;
            this.DedicatedCoreQuota = dedicatedCoreQuota;
            this.LowPriorityCoreQuota = lowPriorityCoreQuota;
            this.DedicatedCoreQuotaPerVMFamily = dedicatedCoreQuotaPerVMFamily;
            this.DedicatedCoreQuotaPerVMFamilyEnforced = dedicatedCoreQuotaPerVMFamilyEnforced;
            this.PoolQuota = poolQuota;
            this.ActiveJobAndJobScheduleQuota = activeJobAndJobScheduleQuota;
            this.AllowedAuthenticationModes = allowedAuthenticationModes;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the identity of the Batch account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "identity")]
        public BatchAccountIdentity Identity {get; set; }

        /// <summary>
        /// Gets the provisioned state of the resource Possible values include: &#39;Invalid&#39;, &#39;Creating&#39;, &#39;Deleting&#39;, &#39;Succeeded&#39;, &#39;Failed&#39;, &#39;Cancelled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.provisioningState")]
        public ProvisioningState ProvisioningState {get; private set; }

        /// <summary>
        /// Gets or sets the network profile only takes effect when publicNetworkAccess
        /// is enabled.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.networkProfile")]
        public NetworkProfile NetworkProfile {get; set; }

        /// <summary>
        /// Gets the account endpoint used to interact with the Batch service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.accountEndpoint")]
        public string AccountEndpoint {get; private set; }

        /// <summary>
        /// Gets the endpoint used by compute node to connect to the Batch node
        /// management service.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.nodeManagementEndpoint")]
        public string NodeManagementEndpoint {get; private set; }

        /// <summary>
        /// Gets the allocation mode for creating pools in the Batch account. Possible values include: &#39;BatchService&#39;, &#39;UserSubscription&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.poolAllocationMode")]
        public PoolAllocationMode? PoolAllocationMode {get; private set; }

        /// <summary>
        /// Gets identifies the Azure key vault associated with a Batch account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.keyVaultReference")]
        public KeyVaultReference KeyVaultReference {get; private set; }

        /// <summary>
        /// Gets or sets if not specified, the default value is &#39;enabled&#39;. Possible values include: &#39;Enabled&#39;, &#39;Disabled&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.publicNetworkAccess")]
        public PublicNetworkAccessType? PublicNetworkAccess {get; set; }

        /// <summary>
        /// Gets list of private endpoint connections associated with the Batch account
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.privateEndpointConnections")]
        public System.Collections.Generic.IList<PrivateEndpointConnection> PrivateEndpointConnections {get; private set; }

        /// <summary>
        /// Gets contains information about the auto-storage account associated with a
        /// Batch account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.autoStorage")]
        public AutoStorageProperties AutoStorage {get; private set; }

        /// <summary>
        /// Gets configures how customer data is encrypted inside the Batch account. By
        /// default, accounts are encrypted using a Microsoft managed key. For
        /// additional control, a customer-managed key can be used instead.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.encryption")]
        public EncryptionProperties Encryption {get; private set; }

        /// <summary>
        /// Gets for accounts with PoolAllocationMode set to UserSubscription, quota is
        /// managed on the subscription so this value is not returned.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.dedicatedCoreQuota")]
        public int? DedicatedCoreQuota {get; private set; }

        /// <summary>
        /// Gets for accounts with PoolAllocationMode set to UserSubscription, quota is
        /// managed on the subscription so this value is not returned.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.lowPriorityCoreQuota")]
        public int? LowPriorityCoreQuota {get; private set; }

        /// <summary>
        /// Gets a list of the dedicated core quota per Virtual Machine family for the
        /// Batch account. For accounts with PoolAllocationMode set to
        /// UserSubscription, quota is managed on the subscription so this value is not
        /// returned.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.dedicatedCoreQuotaPerVMFamily")]
        public System.Collections.Generic.IList<VirtualMachineFamilyCoreQuota> DedicatedCoreQuotaPerVMFamily {get; private set; }

        /// <summary>
        /// Gets if this flag is true, dedicated core quota is enforced via both the
        /// dedicatedCoreQuotaPerVMFamily and dedicatedCoreQuota properties on the
        /// account. If this flag is false, dedicated core quota is enforced only via
        /// the dedicatedCoreQuota property on the account and does not consider
        /// Virtual Machine family.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.dedicatedCoreQuotaPerVMFamilyEnforced")]
        public bool DedicatedCoreQuotaPerVMFamilyEnforced {get; private set; }

        /// <summary>
        /// Gets the pool quota for the Batch account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.poolQuota")]
        public int PoolQuota {get; private set; }

        /// <summary>
        /// Gets the active job and job schedule quota for the Batch account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.activeJobAndJobScheduleQuota")]
        public int ActiveJobAndJobScheduleQuota {get; private set; }

        /// <summary>
        /// Gets list of allowed authentication modes for the Batch account that can be
        /// used to authenticate with the data plane. This does not affect
        /// authentication with the control plane.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "properties.allowedAuthenticationModes")]
        public System.Collections.Generic.IList<AuthenticationMode?> AllowedAuthenticationModes {get; private set; }
        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.Identity != null)
            {
                this.Identity.Validate();
            }

            if (this.NetworkProfile != null)
            {
                this.NetworkProfile.Validate();
            }



            if (this.KeyVaultReference != null)
            {
                this.KeyVaultReference.Validate();
            }

            if (this.PrivateEndpointConnections != null)
            {
                foreach (var element in this.PrivateEndpointConnections)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.AutoStorage != null)
            {
                this.AutoStorage.Validate();
            }



        }
    }
}