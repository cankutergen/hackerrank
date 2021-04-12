static int jumpingOnClouds(int[] c) 
{
          int steps = 0;
          for (int i = 0; i < c.Length; i++)
          {
              if (i == c.Length - 1)
              {
                  break;
              }

              if (i + 2 < c.Length && c[i + 2] == 0)
              {
                  steps++;
                  i = i + 1;
              }
              else
              {
                  steps++;
              }
          }

          return steps;
    }
