public static List<int> gradingStudents(List<int> grades)
    {
        List<int> roundedGrades = new List<int>();
        foreach (var item in grades)
        {
            if(item % 5 >= 3)
            {
                var roundedGrade = item + (5 - item % 5);
                if (roundedGrade >= 40)
                {
                    roundedGrades.Add(roundedGrade);
                }
                else
                {
                    roundedGrades.Add(item);
                }
            }
            else
            {
                roundedGrades.Add(item);
            }
        }
        
        return roundedGrades;
    }
