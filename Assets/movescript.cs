using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movescript : MonoBehaviour
{
    // Start is called before the first frame update
    Material mat;
    Vector4[] positions;
    Color[] colors;
    const int div = 10;
    public int length = 10;
    public float sinOffset = 0;
    void Start()
    {
        mat = GetComponent<Renderer>().material;
        positions = new Vector4[div];
        colors = new Color[div];
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < div; i++)
        {
            positions[i] = new Vector4(Mathf.Sin(i+Time.realtimeSinceStartup+sinOffset), 0, 0, 0);
            colors[i] = new Color(1f, (float)i/ div, 0f,1f);
        }
        mat.SetFloat("_Length", length);
        mat.SetVectorArray("_Positions", positions);
        mat.SetColorArray("_Colors", colors);
        //mat.SetFloat("_Timen",Time.realtimeSinceStartup);
    }
}
