using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.Utilities.Tweenables.Primitives;
public class createFunc : MonoBehaviour
{
    public GameObject stud;
    public int width = 10;
    public int height = 10;
    public double ybound = 10;
    public double scale = 0;

    void Start()
    {
        for (double z = -height; z < height; z += 0.1)
        {
            for (double x = -width; x < width; x += 0.1)
            {
                double y = x * x + z * z;
                if (y < ybound | y > -ybound)
                {
                    float xf = (float)x;
                    float yf = (float)y;
                    float zf = (float)z;
                    Instantiate(stud, new Vector3(xf, yf, zf), Quaternion.identity);
                }
            }
        }
    }
}