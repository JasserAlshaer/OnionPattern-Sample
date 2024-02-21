using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionPattern_Sample_Core.IServices
{
    public interface ITestService
    {
        Task<List<string>> GetListofWelcomeMessage();
    }
}
