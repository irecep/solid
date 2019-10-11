using System;
namespace solid.Models.Saleable
{
    public class GameConsole : Item
    {
        public GameConsole()
        {
        }

        public override string GetItemSize()
        {
            return "20 x 20";
        }

        public override string GetOnlineRegistrationCode()
        {
            throw new NotImplementedException();
        }
    }
}
