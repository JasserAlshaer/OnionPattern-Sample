using OnionPattern_Sample_Core.IRepos;
using OnionPattern_Sample_Core.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPattern_Sample_Infra.Services
{
    public class TestService : ITestService
    {
        private readonly ITestRepos _repos;

        public TestService(ITestRepos repos)
        {
            _repos = repos;
        }

        public async Task<List<string>> GetListofWelcomeMessage()
        {
            List<string> messages = new List<string>(); 
            for (int i = 0; i < 10; i++)
            {
                messages.Add(i.ToString());
                //messages.Add(await _repos.GetWelcomeMessageFromDb());
            }
            return messages;
        }
    }
}
