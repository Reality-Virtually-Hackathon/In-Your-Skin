using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinChanges : MonoBehaviour {
    GameObject skin;
    public Texture2D texture1;
    public Texture2D texture2;
    public bool triggerButtonDown = false;
    private Valve.VR.EVRButtonId triggerButton = Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger;

    private SteamVR_Controller.Device controller
    {
        get
        {
            return SteamVR_Controller.Input((int)trackedObj.index);
        }
    }
    private SteamVR_TrackedObject trackedObj;
    private void Awake()
    {
        trackedObj = GetComponent<SteamVR_TrackedObject>();
    }
    // Use this for initialization
    void Start () {
        //texture1 = (Texture2D)Resources.Load("");
	}
	
	// Update is called once per frame
	void Update () {
        if (controller == null)
        {
            Debug.Log("Controller not initialized");
            return;
        }
        triggerButtonDown = controller.GetPressDown(triggerButton);
        if (triggerButtonDown)
        {
            skin.GetComponent<Renderer>().material.mainTexture = texture1;
        }
        if (controller.GetHairTriggerUp())
        {
            Debug.Log(gameObject.name + " Trigger Release ");
        }
    }
}
