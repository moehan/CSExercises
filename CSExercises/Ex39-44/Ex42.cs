namespace CSExercises
{
    public class Ex42
    {
        public static int FindWord(string s1, string s2)
        {
            
            int occurance = -1;
            for (int i = 0; i < s1.Length; i++)
            {
                if (s1.Substring(i,s2.Length) == s2)
                {
                    occurance = i;
                    break;
                }
            }

            return occurance;

        }
    }
}
