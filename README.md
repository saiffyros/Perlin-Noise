# Perlin-Noise
Simple Perlin noise 1D, 2D and 3D in C# derived from Processing/P5JS

## Usage
Can be used to return 1D, 2D or 3D Perlin noise Value.

# 1D
```cs
Noise _noise = new Noise()
float x = _noise.noise(10);
Console.WriteLine(x); // returns a float value between 0 and 1
```
# 2D
```cs
Noise _noise = new Noise()
float y = _noise.noise(0.5f, 0.8f); // returns a float value between 0 and 1
Console.WriteLine(y); 
```
For 3D just add one more parameter.

You can also call noise in sequence to access all of its pre-generated values:

```cs
Noise _noise = new Noise()

for (float i = 0; i < 10; i += 0.01f)
{
  float z = _noise.noise(i); 
  Console.WriteLine(z);
}
```

## API

### noise(x, [y], [z])

Returns a Perlin noise generated value 0 - 1

| Parameter    | Type     | Description                         |
| ------------ | -------- | ----------------------------------- |
| x            | _number_ | x value for one dimensional noise   |
| y (optional) | _number_ | y value for two dimensional noise   |
| z (optional) | _number_ | z value for three dimensional noise |
