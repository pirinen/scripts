//------------------//
//  Jukka Pirinen   //
//  AR modeling app //
//      2018        //
//------------------//

using UnityEngine;
using UnityEngine.SceneManagement;
using Vuforia;

public class BackToMenu : MonoBehaviour {

    public void BackBtn()
    {

        VuforiaBehaviour.Instance.enabled = false;  //need this to close ARCamera when coming back to menu

        Debug.Log("Back to menu");
        SceneManager.LoadScene(0);
    }
}
