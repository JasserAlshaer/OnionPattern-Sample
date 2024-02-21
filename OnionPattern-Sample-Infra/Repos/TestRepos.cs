using OnionPattern_Sample_Core.IRepos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPattern_Sample_Infra.Repos
{
    public class TestRepos : ITestRepos
    {
        public async Task<string> GetWelcomeMessageFromDb()
        {
           return new Guid().ToString();
        }
    }
}
