using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartButtonScript : MonoBehaviour
{

    public LevelControllerScript levelController;

    public GameObject Level1;
    public GameObject Level2;
    public GameObject Level3;
    public GameObject Level4;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        OnClick();
    }

    public void OnClick()
    {
        if (levelController.playerLevel == 1)
        {

        }

        if (levelController.playerLevel == 2)
        {

        }

        if (levelController.playerLevel == 3)
        {

        }

        if (levelController.playerLevel == 4)
        {

        }
    }
}
