using System.Threading;
using System.Threading.Tasks;

namespace AsyncWorthAwaitComplete
{
    internal class Action1
    {
        internal static void Execute()
        {
            Task.Run((() => Thread.Sleep(3000)));
        }
    }
}
