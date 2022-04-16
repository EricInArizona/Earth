// Copyright Eric Chauvin 2018 - 2022.



// This is licensed under the GNU General
// Public License (GPL).  It is the
// same license that Linux has.
// https://www.gnu.org/licenses/gpl-3.0.html



using System;
using System.Text;
using System.Drawing;
using System.Drawing.Imaging;
// using System.Windows.Media;
// using System.Windows.Media.Media3D;
// using System.Windows.Media.Imaging;


namespace ClimateModel
{
  class Ellipse
  {
  private MainForm MForm;
  private double[] XArray;
  private double[] YArray;
// There's two Ys for every X.
// Struct?

  private int XYArraySize = 0;


/*
  internal void MakeEllipse()
    {
    // https://en.wikipedia.org/wiki/Ellipse#Ellipse_as_quadric
    // General form of a quadratic:
    // Ax^2 + Bxy + Cy^2 + Dx + Ey + F = 0
    // An ellipse is when B^2 - 4AC < 0.

    double a = 10; // Semimajor axis.
    double b = 5; // Semiminor axis.
    double ASqr = a * a;
    double BSqr = b * b;
    double x = 30; // Center X.
    double y = 30; // Center Y.
    double Theta = Math.PI / 3.0; // Rotation angle.
    double SinTheta = Math.Sin( Theta );
    double CosTheta = Math.Cos( Theta );
    double SinThetaSqr = (SinTheta * SinTheta);
    double CosThetaSqr = (CosTheta * CosTheta);

    double A = (ASqr * SinThetaSqr) +
               (BSqr * CosThetaSqr);

    double B = 2 * (BSqr - ASqr) * SinTheta * CosTheta;

    double C = (ASqr * CosThetaSqr) +
               (BSqr * SinThetaSqr);

    double D = (-2 * A * x) - (B * y);

    double E = (-B * x) - (2 * C * y);

    double F = (A * x * x) +
               (B * x * y) +
               (C * y * y) -
               (ASqr * BSqr);



///////////
So now I have the coefficients for the genral form:
    // Ax^2 + Bxy + Cy^2 + Dx + Ey + F = 0
    Go through a thousand x's to get a thousand y's.
    And draw lines to them.
    XArray = new double[ArraySize];
    YArray = new double[ArraySize];
    for( int XIndex = 0; XIndex < ArraySize; XIndex++ )
      {

      }
//////////




///////
// Earth's orbit:
// Eccentricity: 0.0167086
// SemiMajor axis: 149.60   10^6 km


    X = ModelConstants.EarthRadiusMajor *
                                 CosLatRadians;

    Y = ModelConstants.EarthRadiusMinor *
                                 SinLatRadians;
///////

    }
*/





  /*
  private void TestZValue( double ResultZ,
                           double SinLatRadians,
                           double XNoLongitude )
    {
    if( SinLatRadians <= 0 )
      return; // ResultZ;

    // RadiusMajor = 6.378137; // Equator
    // RadiusMinor = 6.356752; // poles
    // A is the semimajor axis
    // B is the semiminor axis
    double A = RadiusMajor;
    double B = RadiusMinor;

    // The definition of an ellipse:
    // x^2/A^2 + z^2/B^2 = 1

    // Solve for Z:
    // (B^2*x^2 + A^2*z^2)/(B^2*A^2) = 1
    // B^2*x^2 + A^2*z^2 = B^2*A^2
    // A^2*z^2 = B^2*A^2 - B^2*x^2
    // A^2*z^2 = B^2(A^2 - x^2)
    // z^2 = B^2/A^2*(A^2 - x^2)
    // z = Sqrt( B^2/A^2*(A^2 - x^2))
    // z = B/A * Sqrt( (A^2 - x^2))

    double ZTest = (B / A) * Math.Sqrt( (A * A) - (XNoLongitude * XNoLongitude));

    double Difference = Math.Abs( ZTest - ResultZ );
    if( Difference > MaxZDiff )
      MaxZDiff = Difference;

    // MaxZDiffInMilliMeters: 0.00000310862446895044

    // A millimeter is a thousandth of a meter.
    // So that's 3 nanometers or something?
    }
    */


  }
}
