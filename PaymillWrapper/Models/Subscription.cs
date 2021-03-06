﻿using Newtonsoft.Json;
using PaymillWrapper.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PaymillWrapper.Models
{
    /// <summary>
    /// Subscriptions allow you to charge recurring payments on a client’s credit card / to a client’s direct debit. 
    /// A subscription connects a client to the offers-object.
    /// </summary>
    [JsonConverter(typeof(JsonParser<Subscription>))]
    public class Subscription : BaseModel
    {
        /// <summary>
        /// Hash describing the offer which is subscribed to the client
        /// </summary>
        [DataMember(Name = "Offer")]
        public Offer Offer { get; set; }

        /// <summary>
        /// Whether this subscription was issued while being in live mode or not
        /// </summary>
        [DataMember(Name = "Livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// Cancel this subscription immediately or at the end of the current period?
        /// </summary>
        [DataMember(Name = "Cancel_At_Period_End")]
        public bool Cancel_At_Period_End { get; set; }

        /// <summary>
        /// Cancel date
        /// </summary>
        [DataMember(Name = "CanceledAt")]
        public DateTime CanceledAt { get; set; }

        /// <summary>
        /// Client-object
        /// </summary>
        [DataMember(Name = "Client")]
        public Client Client { get; set; }

        /// <summary>
        /// To connects the offer with more than a client.
        /// Under construction
        /// </summary>
        [DataMember(Name = "Clients")]
        public List<Client> Clients { get; set; }

        /// <summary>
        /// Payment-object
        /// </summary>
        [DataMember(Name = "Payment")]
        public Payment Payment { get; set; }
    }
}