    public static int countingValleys(int steps, string path)
    {
        var arr = path.ToCharArray();
        var altitude = 0;
        var exAltitude = 0;
        var valleyStarted = false;
        var valleyCount = 0;

        foreach (var item in arr)
        {
            exAltitude = altitude;
            altitude = item == 'U' ? altitude + 1 : altitude - 1;

            if(exAltitude > altitude)
            {
                valleyStarted = true;
            }

            if( altitude > exAltitude && altitude == 0 && valleyStarted)
            {
                valleyCount++;
                valleyStarted = false;
            }
        }
        
        return valleyCount;
    }
