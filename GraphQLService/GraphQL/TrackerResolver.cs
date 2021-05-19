using GraphQLService.TestDb;
using HotChocolate;
using HotChocolate.Data;
using HotChocolate.Types;

namespace GraphQLService.GraphQL
{
    [ExtendObjectType(typeof(Tracker))]
    public class TrackerResolver
    {
        [IsProjected(true)]
        public int GetId([Parent] Tracker tracker) => tracker.Id;

        public bool GetCanEdit([Parent] Tracker tracker)
        {
            return tracker.Id > 1;
        }
    }
}