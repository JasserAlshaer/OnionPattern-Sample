using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPattern_Sample_Core.IRepos
{
    public interface ITestRepos
    {
        Task<string> GetWelcomeMessageFromDb();

    }
}
