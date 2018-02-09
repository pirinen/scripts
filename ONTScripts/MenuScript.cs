//------------------//
//  Jukka Pirinen   //
//  AR modeling app //
//      2018        //
//------------------//

using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class MenuScript : MonoBehaviour {

    public Canvas MenuCanvas;
    public Canvas InfoCanvas;

    void Start()
    {
        VuforiaRuntime.Instance.Deinit();   //need this to close ARCamera when coming back to menu
    }

    void Awake()
    {
        InfoCanvas.enabled = false;
    }

    public void InfoBtn()
    {
        InfoCanvas.enabled = true;
        MenuCanvas.enabled = false;
    }

    public void BackBtn()
    {
        InfoCanvas.enabled = false;
        MenuCanvas.enabled = true;
    }

    public void StartBtn()
    {
        //Application.LoadLevel(1);
        
        VuforiaRuntime.Instance.InitVuforia();  //Vuforia ARCamera starts

        SceneManager.LoadScene(1);
    }

}
