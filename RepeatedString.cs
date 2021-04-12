static long repeatedString(string s, long n) 
{
            var charArr = s.ToCharArray();
            
            var rest = n % s.Length;
            var recurrence = (n - rest) / s.Length;
            long counter = 0;

            for (int i = 0; i < charArr.Length; i++)
            {
                if (charArr[i] == 'a') counter++;
            }

            counter = counter * recurrence;
            for (int i = 0; i < rest; i++)
            {
                if (charArr[i] == 'a') counter++;
            }
            
            return counter;
    }
