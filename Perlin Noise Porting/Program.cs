/* adapted from https://github.com/processing/processing-android/blob/master/core/src/processing/core/PApplet.java#L3763
by Rodrigo Oliveira
twitter @poa_oliveira */

using System;

class Program
{
    public static void Main()
    {
        Noise _noise = new Noise();

        float x = _noise.noise(-2146233080);
        Console.WriteLine("Check: " + x);

        float y = _noise.noise(0.000005f, 0.000008f);
        Console.WriteLine(y);

        // returns a float value between 0 and 1, but different and related to the previous return value on each loop cycle
        for (float i = 0; i < 10; i += 0.01f)
        {
            float z = _noise.noise(i); 
            Console.WriteLine(z);
        }
    }
}
