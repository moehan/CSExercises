namespace CSExercises
{
    public class Ex41
    {
        public static bool InString(string s1, string s2)
        {
            bool contain = false;
            if (s1.Contains(s2))
            {
                contain = true;
            }
            return contain;
        }
    }
}


