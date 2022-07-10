/* adapted from https://github.com/processing/processing-android/blob/master/core/src/processing/core/PApplet.java#L3763
by Rodrigo Oliveira
twitter @poa_oliveira */

using System;

class Program
{
    public static void Main()
    {
        Noise Noise = new Noise();

        for (int i = 0; i < 100; i++)
        {
            float x = Noise.noise(i);
            Console.WriteLine(x);
        }
    }
}
