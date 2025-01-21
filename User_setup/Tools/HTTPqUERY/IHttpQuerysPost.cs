using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OTSC_ui.Tools.HTTPqUERY
{
    public interface IHttpQuerysPost
    {
        public  Task<int> SendTgCodeToTgAsync();
        public Task<int> SendTgCodeToTgAsync(long id);

    }
}
