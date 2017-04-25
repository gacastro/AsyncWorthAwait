using System.Threading.Tasks;

namespace AsyncWorthAwaitComplete
{
    internal class Action1
    {
        internal static Task Execute()
        {
            return Task.Delay(3000);
        }
    }
}
