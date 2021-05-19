using GraphQLService.TestDb;
using HotChocolate.Data;
using HotChocolate.Types;

namespace GraphQLService.GraphQL
{
    [ExtendObjectType(typeof(Tracker))]
    public class TrackerResolver
    {
        [IsProjected(true)] public int Id { get; set; } 
    }
}