using ScottPlot;
using System.Diagnostics;
using System.Numerics;
using VectorTest;

Plot myPlot = new();

double[] xs = Generate.Consecutive(10);
double[] ys = Generate.Consecutive(10);

const double length = 0.7;
bool normalize = false;
List<RootedCoordinateVector> vectors = new();

for (int i = 0; i < xs.Length; i++)
{
    Coordinates pt = new(xs[i], ys[i]);

    var v = VectorMaking.CreateVector(length, 335.6 + i);
    if (normalize)
    {
        v = Vector2.Normalize(v) * 0.7f;
    }

    Console.WriteLine($"magnitude: {v.Length()}, direction: {335.6 + i}");

    RootedCoordinateVector vector = new(pt, v);
    vectors.Add(vector);

}

myPlot.Add.VectorField(vectors);

myPlot.SavePng("test.png", 400, 300);

Process.Start(new ProcessStartInfo
{
    FileName = "test.png",
    UseShellExecute = true
});