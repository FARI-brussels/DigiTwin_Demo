using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSetup : MonoBehaviour
{
    public GameObject gameGUIObj;
    public GameObject dayGUI;
    public GameObject clockGUI;

    // Start is called before the first frame update
    void Start()
    {
        gameGUIObj.SetActive(true);
        dayGUI.SetActive(false);
        clockGUI.SetActive(false);
    }
}
