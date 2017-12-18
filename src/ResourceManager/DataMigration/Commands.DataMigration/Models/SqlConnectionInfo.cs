// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Commands.DataMigration.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;

    /// <summary>
    /// Information for connecting to SQL database server
    /// </summary>
    public partial class SqlConnectionInfo : ConnectionInfo
    {
        /// <summary>
        /// Initializes a new instance of the SqlConnectionInfo class.
        /// </summary>
        public SqlConnectionInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SqlConnectionInfo class.
        /// </summary>
        /// <param name="dataSource">Data source in the format
        /// Protocol:MachineName\SQLServerInstanceName,PortNumber</param>
        /// <param name="userName">User name</param>
        /// <param name="password">Password credential. It must be RSA
        /// encrypted by the public key of the VM, then base64 encoded. It must
        /// never be the plaintext! Cryptography class contains helper methods
        /// to perform the encryption.
        /// </param>
        /// <param name="authentication">Authentication type to use for
        /// connection. Possible values include: 'None',
        /// 'WindowsAuthentication', 'SqlAuthentication',
        /// 'ActiveDirectoryIntegrated', 'ActiveDirectoryPassword'</param>
        /// <param name="encryptConnection">Whether to encrypt the
        /// connection</param>
        /// <param name="additionalSettings">Additional connection
        /// settings</param>
        /// <param name="trustServerCertificate">Whether to trust the server
        /// certificate</param>
        public SqlConnectionInfo(string dataSource, string userName = default(string), string password = default(string), AuthenticationType? authentication = default(AuthenticationType?), bool? encryptConnection = default(bool?), string additionalSettings = default(string), bool? trustServerCertificate = default(bool?))
            : base(userName, password)
        {
            DataSource = dataSource;
            Authentication = authentication;
            EncryptConnection = encryptConnection;
            AdditionalSettings = additionalSettings;
            TrustServerCertificate = trustServerCertificate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets data source in the format
        /// Protocol:MachineName\SQLServerInstanceName,PortNumber
        /// </summary>
        [JsonProperty(PropertyName = "dataSource")]
        public string DataSource { get; set; }

       
        public AuthenticationType? Authentication { get; set; }

        public bool? EncryptConnection { get; set; }

        public string AdditionalSettings { get; set; }

        public bool? TrustServerCertificate { get; set; }
       
    }
}