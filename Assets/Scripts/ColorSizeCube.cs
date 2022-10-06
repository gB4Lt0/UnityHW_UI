using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSizeCube : MonoBehaviour
{
    public MeshRenderer cube_color;
    public GameObject cube_size;
    public Slider red; 
    public Slider green; 
    public Slider blue; 
    public Slider height; 
    public Slider width; 
    public Slider lenght; 

    public void OnEdit() 
    {
        Color color = cube_color.material.color;
        color.r = red.value;
        color.g = green.value;
        color.b = blue.value;
        cube_color.material.color = color;
        cube_color.material.SetColor("_EmissionColor", color);

        cube_size.gameObject.transform.localScale = new Vector3(width.value, height.value, lenght.value);
    }
}
