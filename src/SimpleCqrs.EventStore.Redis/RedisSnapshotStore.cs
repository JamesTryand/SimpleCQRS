using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SimpleCqrs.Eventing;

namespace SimpleCqrs.EventStore.Redis
{
    public class RedisSnapshotStore : ISnapshotStore
    {
        public Domain.Snapshot GetSnapshot(Guid aggregateRootId)
        {
            throw new NotImplementedException();
        }

        public void SaveSnapshot<TSnapshot>(TSnapshot snapshot) where TSnapshot : Domain.Snapshot
        {
            throw new NotImplementedException();
        }
    }
}
