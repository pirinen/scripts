//------------------//
//  Jukka Pirinen   //
//  AR modeling app //
//      2018        //
//------------------//

using UnityEngine;

public class TrackingCoords : MonoBehaviour
{

    public GameObject TrackableObject;
    Vector3 position;
    GUIStyle style = new GUIStyle();
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        position = TrackableObject.transform.localPosition;
    }

    void OnGUI()
    {
        style.fontSize = 50;
        style.normal.textColor = Color.white;
        GUI.Button(new Rect(50, 150, 250, 180), "Position: x,y,z\n" + position, style);
    }
}