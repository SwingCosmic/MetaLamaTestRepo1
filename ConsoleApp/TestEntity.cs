using MetalamaTest1;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    [TestAspect]
    public class TestEntity : IDetectInterface
    {
        [AllowNull]
        public string Id { get; set; }
        public DateTime? CreateTime { get; set; }
    }
}
