using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FillScreen : MonoBehaviour
{
    public float HorizontalRatio = 1.0f;
    public float VerticalRatio = 1.0f;
    void Start()
    {
        StartCoroutine(SetARLensSimulator());
    }

    IEnumerator SetARLensSimulator()
    { 
        yield return new WaitForSeconds(1);

        float distance = (Camera.main.nearClipPlane + 0.1f);

        transform.position = Camera.main.transform.position + Camera.main.transform.forward * distance;

        //https://docs.unity3d.com/Manual/FrustumSizeAtDistance.html
        float height = 2.0f * distance * Mathf.Tan(Camera.main.fieldOfView * 0.5f * Mathf.Deg2Rad);
        float width = height * Camera.main.aspect;

        transform.localScale = new Vector3(width * 0.1f * HorizontalRatio, 1f, height * 0.1f * VerticalRatio); //use plane object -- scale 1: 10m

        float fieldOfView_Height = 2.0f * Mathf.Atan(height * VerticalRatio * 0.5f / distance) * Mathf.Rad2Deg; //*0.5f - simulate limited FOV
        float fieldOfView_Width = 2.0f * Mathf.Atan(width * HorizontalRatio * 0.5f / distance) * Mathf.Rad2Deg;
        Debug.Log(fieldOfView_Height.ToString() + "  " + fieldOfView_Width.ToString());

    }
        


}
