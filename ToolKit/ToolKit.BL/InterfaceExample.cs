using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace ToolKit.BL
{
    /// <summary>
    /// An interface is a way to ensure that two or more otherwise different classes share certain things
    /// in common. Furthermore, it is a way to separate those common properties or methods from everything
    /// else. This way you can create a method, among other things, that can take multiple different
    /// classes in as a parameter using their derived interface. 
    /// 
    /// See the below example.
    /// </summary>
    /// 

    public interface IAchievementService
    {
        string LogAchievement();
    }

    class Goblin : IAchievementService
    {
        public void Death()
        {
            LogAchievement();
        }

        public string LogAchievement() => "You killed a Goblin!";
    }

    class Sword : IAchievementService
    {
        public Sword()
        {
            LogAchievement();
        }

        public string LogAchievement() => "You acquired a Sword!";
    }

    public static class AchievementLoggingService
    {
        //the sword and goblin classes can both be interfaced with using one method because of their shared interface
        public static void WriteToFile(List<IAchievementService> achievementsToLog)
        {
            foreach(var achievement in achievementsToLog)
            {
                Console.WriteLine("Achievement: " + achievement.LogAchievement());
            }
        }
    }
}
