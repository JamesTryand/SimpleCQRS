using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleCqrs.Eventing;

namespace SimpleCqrs.EventStore.Redis
{
    public class RedisEventStore : IEventStore
    {
        public IEnumerable<DomainEvent> GetEvents(Guid aggregateRootId, int startSequence)
        {
            throw new NotImplementedException();
        }

        public void Insert(IEnumerable<DomainEvent> domainEvents)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DomainEvent> GetEventsByEventTypes(IEnumerable<Type> domainEventTypes)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DomainEvent> GetEventsByEventTypes(IEnumerable<Type> domainEventTypes, Guid aggregateRootId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DomainEvent> GetEventsByEventTypes(IEnumerable<Type> domainEventTypes, DateTime startDate, DateTime endDate)
        {
            throw new NotImplementedException();
        }
    }
}
