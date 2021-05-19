using System.Linq;
using GraphQLService.TestDb;
using HotChocolate;
using HotChocolate.Data;

namespace GraphQLService.GraphQL
{
    public class Query
    {        
        [UseDbContext(typeof(TestDbContext))]
        [UseProjection]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Tracker> GetTrackers([ScopedService] TestDbContext dc) => dc.Trackers;
    }
}