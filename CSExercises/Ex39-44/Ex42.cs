namespace CSExercises
{
    public class Ex42
    {
        public static int FindWord(string s1, string s2)
        {
            bool contain = false;
            int count=0;

            if (s1.Contains(s2))
            {
                contain = true;

                for (int i = 0; i < s1.Length; i++)
                {
                    count++;
                    if (s2[0] == s1[i])
                    {
                        break;
                    }
                }
            }

            else
            {
                contain = false;
                count = -1;
            }
            return count ;
        }
    }
}
