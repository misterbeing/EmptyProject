using PaintIn3D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColourPicker : MonoBehaviour
{
    public ParticleSystem ParticleSystem;
    public CwPaintSphere CwPaintSphere;
    public Color Color;

    public bool executeFunction;


    private void Update()
    {
        if (executeFunction) 
        {
            ChangeColour();
            executeFunction = false;
        }
    }

    public void ChangeColour()
    {
        CwPaintSphere.Color = Color;
        ParticleSystem.startColor = Color;
    }
}
