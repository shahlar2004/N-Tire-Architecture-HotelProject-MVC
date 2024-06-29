namespace HotelProject.Web.ResultMessages
{
    public class Messages
    {
        public static class Country
        {

            public static string Message(string mes)
            {
                return $"{mes}";
            }

            public static string Add(string articleTitle)
            {
                return $"{articleTitle} Ölkə uğurla əlavə edildi.";
            }

            public static string Update(string articleTitle)
            {
                return $"{articleTitle} Ölkə uğurla dəyişdirildi.";
            }
        }

    }
}
