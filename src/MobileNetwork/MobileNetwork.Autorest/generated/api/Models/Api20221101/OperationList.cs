// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Extensions;

    /// <summary>List of the operations.</summary>
    public partial class OperationList :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IOperationList,
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IOperationListInternal
    {

        /// <summary>Internal Acessors for NextLink</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IOperationListInternal.NextLink { get => this._nextLink; set { {_nextLink = value;} } }

        /// <summary>Internal Acessors for Value</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IOperation[] Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IOperationListInternal.Value { get => this._value; set { {_value = value;} } }

        /// <summary>Backing field for <see cref="NextLink" /> property.</summary>
        private string _nextLink;

        /// <summary>The URL to get the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public string NextLink { get => this._nextLink; }

        /// <summary>Backing field for <see cref="Value" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IOperation[] _value;

        /// <summary>List of Microsoft.MobileNetwork operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Origin(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IOperation[] Value { get => this._value; }

        /// <summary>Creates an new <see cref="OperationList" /> instance.</summary>
        public OperationList()
        {

        }
    }
    /// List of the operations.
    public partial interface IOperationList :
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.IJsonSerializable
    {
        /// <summary>The URL to get the next set of results.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"The URL to get the next set of results.",
        SerializedName = @"nextLink",
        PossibleTypes = new [] { typeof(string) })]
        string NextLink { get;  }
        /// <summary>List of Microsoft.MobileNetwork operations.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Description = @"List of Microsoft.MobileNetwork operations.",
        SerializedName = @"value",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IOperation) })]
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IOperation[] Value { get;  }

    }
    /// List of the operations.
    internal partial interface IOperationListInternal

    {
        /// <summary>The URL to get the next set of results.</summary>
        string NextLink { get; set; }
        /// <summary>List of Microsoft.MobileNetwork operations.</summary>
        Microsoft.Azure.PowerShell.Cmdlets.MobileNetwork.Models.Api20221101.IOperation[] Value { get; set; }

    }
}