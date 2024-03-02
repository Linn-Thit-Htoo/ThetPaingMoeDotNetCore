namespace LibraryManagementSystem
{
    public class Validation
    {
        public static bool IsNullOrEmpty(params string[] strings)
        {
            foreach (string str in strings)
            {
                if (string.IsNullOrEmpty(str))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
