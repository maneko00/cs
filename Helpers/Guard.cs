using DDD.Domain.Exceptions;

namespace DDD.Domain.Helpers
{
    public static class Guard
    {
        public static void IsStringEmpty(string o, string message)
        {
            if(o == "")
            {
                throw new InputException(message);
            }
        }
    }
}
