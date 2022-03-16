using AwesomeShop.Services.Orders.Core.Events;
using System;
using System.Collections.Generic;

namespace AwesomeShop.Services.Orders.Core.Entities.Common
{
    public class AggregateRoot : IEntitieBase
    {
        private List<IDomainEvent> _events = new List<IDomainEvent>();
        public Guid Id { get; set; }

        public IEnumerable<IDomainEvent> Events => _events;

        protected void AddEvent(IDomainEvent @event)
        {
            if(_events == null)
                _events = new List<IDomainEvent>();

            _events.Add(@event);
        }
    }
}
