using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class TopOrientation : MonoBehaviour {
    /*
    void Start()    //from https://library.vuforia.com/articles/Solution/Working-with-the-Camera
    {               //Ei tämä taida tehdä mitään järkevää
        Debug.Log("TopOrientation Void Start");
        var vuforia = VuforiaARController.Instance;
        vuforia.RegisterVuforiaStartedCallback(OnVuforiaStarted);
        vuforia.RegisterOnPauseCallback(OnPaused);
    }

    private void OnVuforiaStarted()
    {
        Debug.Log("TopOrientation OnVuforiaStarted");
        CameraDevice.Instance.SetFocusMode(
            CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
    }

    private void OnPaused(bool paused)
    {
        Debug.Log("TopOrientation OnPaused");
        if (!paused) // resumed
        {
            // Set again autofocus mode when app is resumed
            CameraDevice.Instance.SetFocusMode(
                CameraDevice.FocusMode.FOCUS_MODE_CONTINUOUSAUTO);
        }
    }
    */
    //float zAngle = GlobalManager.Instance.arCamera.transform.rotation.eulerAngles.z;
    //bool topOrientation = false;
    //if ((zAngle >= 0 && zAngle< 90) || (zAngle >= 230 && zAngle< 360)) topOrientation = true;


    // Use this for initialization
    //void Start () {

    //}

    // Update is called once per frame
    //void Update () {
    //Debug.Log("Top orientation");
    //TrackerManager.Instance.GetTracker<ObjectTracker>().Stop(); //Object tracker stop
    //TrackerManager.Instance.GetTracker<ObjectTracker>().Start(); //Object tracker start

    //}
    /*float zAngle = VuforiaBehaviour.Instance.transform.rotation.eulerAngles.z;
    bool topOrientation = false;
        if ((zAngle >= 0 && zAngle< 90) || (zAngle >= 230 && zAngle< 360))
        {
            Debug.Log("topOrientation = true");
            topOrientation = true;
        }
    */
}
