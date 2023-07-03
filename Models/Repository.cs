namespace ch3_selbst.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new();
        public static IEnumerable<GuestResponse> Responses => responses;
        public static void AddResponse(GuestResponse response)
        {
            System.Console.WriteLine(response);
            responses.Add(response);
        }
    }
}