using System;
namespace solid.Models.Saleable
{
    public class Mario:Item
    {
        public Mario()
        {
        }

        public override string GetItemSize()
        {
            throw new NotImplementedException();
        }

        public override string GetOnlineRegistrationCode()
        {
            return "ABDE-8-1-4";
        }
    }
}
