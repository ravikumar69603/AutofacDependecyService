using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAutoFacService.Model;

namespace WebAutoFacService.Service
{
    public class TestService : ITestService
    {
        public List<TestModel> GetTestList()
        {
            List<TestModel> list = new List<TestModel>() 
            {
                new TestModel { Id = 1, Name = "test1"},
                new TestModel { Id = 2, Name = "test2"},
                new TestModel { Id = 3, Name = "test3"},
                new TestModel { Id = 4, Name = "test4"},
                new TestModel { Id = 5, Name = "test5"},
                new TestModel { Id = 6, Name = "test6"},
                new TestModel { Id = 7, Name = "test7"},
                new TestModel { Id = 8, Name = "test8"}
            };

            return list;
        }
    }
}
