using System;
using System.Threading.Tasks;

namespace AsyncWorthAwaitComplete
{
    internal class Action1
    {
        internal static Task Execute()
        {
            return Task.Delay(3000);
        }

        public static async Task<string> ExecuteA()
        {
            await Task.Delay(2000).ConfigureAwait(false);
            return DateTime.Now.ToString("HH:mm:ss");
        }

        public static async Task<string> ExecuteB()
        {
            await Task.Delay(4000).ConfigureAwait(false);
            return DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
