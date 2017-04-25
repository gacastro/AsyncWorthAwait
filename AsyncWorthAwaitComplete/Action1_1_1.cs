using System.Threading;
using System.Threading.Tasks;

namespace AsyncWorthAwaitComplete
{
    internal class Action1
    {
        internal static void Execute()
        {
            var work = new Task(() => Thread.Sleep(3000));
            work.Start();
        }
    }
}
