using System;
using System.Collections.Generic;

namespace GraphQLService.TestDb
{
    public partial class Tracker
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
    }
}
