using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VarjoExample;

public class TeleportToStartPosition : MonoBehaviour
{
    [SerializeField] ExperimentManager experimentManager;
    [SerializeField] Transform startPosition_Route1;
    [SerializeField] Transform startPosition_Route2;
    [SerializeField] GameObject xrRig;
    bool hasStarted;
    bool buttonDown;
    Controller controller;
    

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<Controller>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.triggerButton)
        {
            if (!buttonDown)
            {
                // Button is pressed
                buttonDown = true;
            }
            else
            {
                // Button is held down
            }
        }
        else if (!controller.triggerButton && buttonDown)
        {
            // Button is released
            Debug.Log("tRIGGER");
            if(!hasStarted)
            {
                if(experimentManager.routeType == RouteType.Route1)
                    xrRig.transform.position = startPosition_Route1.position;
                else if (experimentManager.routeType == RouteType.Route2)
                    xrRig.transform.position = startPosition_Route2.position;
                hasStarted = true;
                experimentManager.ActiveBodyFixedCue(hasStarted);
            }
            buttonDown = false;
        }
    }
}
