//------------------//
//  Jukka Pirinen   //
//  AR modeling app //
//      2018        //
//------------------//

using UnityEngine;
using Vuforia;
public class ModelSwapper : MonoBehaviour
{
    public TrackableBehaviour theTrackable;
    private bool mSwapModel1 = false;

    private bool mSwapModel2 = false;
    public GameObject modelObject1;
    public GameObject modelObject2;
    private string nameOfObject = "";

    // Use this for initialization
    void Start()
    {
        if (theTrackable == null)
        {
            Debug.Log("Warning: Trackable not set !!");
        }
    }
    // Update is called once per frame
    void Update()
    {
        if (mSwapModel1 && theTrackable != null)
        {
            SwapModel1();
            mSwapModel1 = false;
            

        }
        if (mSwapModel2 && theTrackable != null)
        {
            SwapModel2();
            mSwapModel2 = false;
            
        }
    }
    void OnGUI()
    {
        GUI.Button(new Rect(50, 150, 120, 40),"Valittuna: \n" + nameOfObject);

        if (GUI.Button(new Rect(50, 200, 120, 40), "xxx"))
        {
            mSwapModel1 = true;
            mSwapModel2 = false;
            nameOfObject = "xxx";
        }
        if (GUI.Button(new Rect(50, 250, 120, 40), "model"))
        {
            mSwapModel2 = true;
            mSwapModel1 = false;
            nameOfObject = "model";
        }
        if (GUI.Button(new Rect(50, 300, 120, 40), "Empty"))
        {
            //mSwapModel2 = false;
            //mSwapModel1 = false;

            modelObject1.SetActive(false);
            modelObject2.SetActive(false);
            nameOfObject = "";
        }
    }
    private void SwapModel1()   //Uuni
    {
        GameObject trackableGameObject = theTrackable.gameObject;
        //disable any pre-existing augmentation
        for (int i = 0; i < trackableGameObject.transform.GetChildCount(); i++)
        {
            Transform child = trackableGameObject.transform.GetChild(i);
            child.gameObject.active = false;
        }

        modelObject1.transform.parent = theTrackable.transform;
        
        modelObject1.transform.localPosition = new Vector3(0, 0/*.2f*/, 0);
        modelObject1.transform.localRotation = Quaternion.identity;
        //modelObject1.transform.localRotation = new Vector3(0,0);  // Y Rotate 180degree
        modelObject1.transform.localScale = new Vector3(3.4f, 3.4f, 3.4f);

        //modelObject.active = true;
        modelObject1.SetActive(true);

    }
    private void SwapModel2()   //Raitamalli
    {
        GameObject trackableGameObject = theTrackable.gameObject;
        //disable any pre-existing augmentation
        for (int i = 0; i < trackableGameObject.transform.GetChildCount(); i++)
        {
            Transform child = trackableGameObject.transform.GetChild(i);
            child.gameObject.active = false;
        }

        modelObject2.transform.parent = theTrackable.transform;
        modelObject2.transform.localPosition = new Vector3(0, 0, 0);
        modelObject2.transform.localRotation = Quaternion.identity;
        modelObject2.transform.localScale = new Vector3(3.4f, 3.4f, 3.4f);
        
        //modelObject.active = true;
        modelObject2.SetActive(true);
    }

}