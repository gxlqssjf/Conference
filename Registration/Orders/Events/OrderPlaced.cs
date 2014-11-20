﻿using System;
using System.Collections.Generic;
using ENode.Eventing;

namespace Registration.Orders
{
    [Serializable]
    public class OrderPlaced : DomainEvent<Guid>
    {
        public Guid ConferenceId { get; private set; }
        public OrderTotal Total { get; private set; }
        public string AccessCode { get; private set; }

        public OrderPlaced(Guid orderId, Guid conferenceId, OrderTotal total, string accessCode) : base(orderId)
        {
            ConferenceId = conferenceId;
            Total = total;
            AccessCode = accessCode;
        }
    }
}