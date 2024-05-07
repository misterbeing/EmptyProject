using PaintIn3D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NozzleSize : MonoBehaviour
{
    public CwPaintSphere CwPaintSphere;

    public void SetNozzleSize(float nozzleSize)
    {
        CwPaintSphere.Radius = nozzleSize;
    }
}
