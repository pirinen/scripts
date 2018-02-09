//------------------//
//  Jukka Pirinen   //
//  AR modeling app //
//  Thesis, 2018    //
//------------------//

using UnityEngine;
using UnityEngine.UI;

public class DropDown : MonoBehaviour {

    public Dropdown myDropdown;
    // Use this for initialization
    void Start()
    {
        myDropdown.onValueChanged.AddListener(delegate {
            myDropdownValueChangedHandler(myDropdown);
        });
    }
    void Destroy()
    {
        myDropdown.onValueChanged.RemoveAllListeners();
    }

    private void myDropdownValueChangedHandler(Dropdown target)
    {
        Debug.Log("selected: " + target.value);
    }

    public void SetDropdownIndex(int index)
    {
        myDropdown.value = index;
    }
}
