# Perlin-Noise
Simple Perlin noise in C# derived from Processing/P5JS

## Usage
Can be used to return 1D, 2D or 3D Perlin noise Value.

# 1D
```cs
Noise _noise = new Noise()
float x = _noise.noise(10) // returns a float value between 0 and 1
```
# 2D
```cs
Noise _noise = new Noise()
float x = _noise.noise(0.5f, 0.8f) // returns a float value between 0 and 1
```
For 3D just add one more parameter.

You can also call noise in sequence to access all of its pre-generated values:

```cs
Noise _noise = new Noise()

for (int i = 0; i < 100; i += 0.01f;) {
  float x = _noise.noise(i) // returns a float value between 0 and 1, but different and related to the previous return value on each loop cycle
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
