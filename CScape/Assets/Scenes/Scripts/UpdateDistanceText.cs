using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateDistanceText : MonoBehaviour
{
    [SerializeField] TextMesh DisText;
    [SerializeField] GameObject DecisionPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dist = Vector3.Distance(Camera.main.transform.position, DecisionPoint.transform.position);
        //consider the Trigger are not at the same position as the Decision Point to calculate the dist, - 5m
        dist = dist - 5f;
        UpdateDisText(dist, DisText);
    }

    public void UpdateDisText(float dist, TextMesh DisText)
    {
        if (dist > 50f)
            DisText.text = "100m";
        else if (dist > 20f)
            DisText.text = "50m";
        else if (dist > 10f)
            DisText.text = "20m";
        else
            DisText.text = "10m";
    }
}
