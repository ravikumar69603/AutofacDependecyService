using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAutoFacService.Model;

namespace WebAutoFacService.Service
{
    public interface ITestService
    {
        List<TestModel> GetTestList();

    }
}
