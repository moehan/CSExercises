namespace CSExercises
{
    public class Ex44
    {
        public static string Substitute(string s, char c1, char c2)
        {
            string new_string = "";
            for (int i = 0; i < s.Length; i++)
            {
                string st = "";
                if (c1 == s[i])
                {
                    st = c2.ToString();
                }

                else
                {
                    st = s[i].ToString();
                }

                new_string += st;
            }
                return new_string;
        }
    }
}
