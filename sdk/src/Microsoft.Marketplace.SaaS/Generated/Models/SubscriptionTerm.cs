// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Marketplace.SaaS.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class SubscriptionTerm
    {
        /// <summary>
        /// Initializes a new instance of the SubscriptionTerm class.
        /// </summary>
        public SubscriptionTerm()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SubscriptionTerm class.
        /// </summary>
        public SubscriptionTerm(System.DateTime? startDate = default(System.DateTime?), System.DateTime? endDate = default(System.DateTime?))
        {
            StartDate = startDate;
            EndDate = endDate;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "startDate")]
        public System.DateTime? StartDate { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "endDate")]
        public System.DateTime? EndDate { get; set; }

    }
}
