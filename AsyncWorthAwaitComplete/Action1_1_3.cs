using System.Threading.Tasks;

namespace AsyncWorthAwaitComplete
{
    internal class Action1
    {
        internal static void Execute()
        {
            //Task that takes 3s to complete
            Task.Delay(3000);

            //Task that is completed and has a result of "Done"
            Task.FromResult("Done");
        }
    }
}
