using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownScript : MonoBehaviour {
    public Dropdown myDropdown;
    // Use this for initialization
    void Start () {
        myDropdown = GetComponent<Dropdown>();
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
        GameMasterScript.Instance.mapSize = int.Parse(target.captionText.text);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
