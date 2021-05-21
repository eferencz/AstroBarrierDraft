using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelControllerScript : MonoBehaviour
{
    public GameObject SmallEnemy;
    public GameObject MediumEnemy;
    public GameObject LargeEnemy;

    public GameObject CurrentLevel;
    public GameObject NextLevel;

    private bool allTargetsHit = false;
    private float livesLeft;
    private float bulletsLeft;
    public float playerLevel;
    private bool levelLost = false;

    public MobileEnemyScript mobileEnemy;

    // Start is called before the first frame update
    void Start()
    {
        bulletsLeft = 5;
    }

    // Update is called once per frame
    void Update()
    {
        CheckPlayerLevel();

        CheckForShoot();

        CheckForLivesLost();

        CheckForTargetsHit();

        CheckForLevelLost();

        CheckForLevelWon();
    }

    void CheckPlayerLevel()
    {
        if (playerLevel == 0)
        {
            allTargetsHit = false;

        }
    }

    void CheckForShoot()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (bulletsLeft == 0)
            {
                bulletsLeft += -1;
            }
        }

        if (bulletsLeft == 0)
        {
            levelLost = true;
        }
    }

    void CheckForLivesLost()
    {

    }

    void CheckForTargetsHit()
    {

    }

    void CheckForLevelLost()
    {
        if (levelLost == true)
        {
            Debug.Log("You Lost Level" + playerLevel + "!");

            livesLeft += -1;

            ResetLevel();
        }
    }

    void CheckForLevelWon()
    {
        if (allTargetsHit == true)
        {
            Debug.Log("You Passed Level" + playerLevel + "!");

            MoveToNextLevel();
        }
    }

    void ResetLevel()
    {
        mobileEnemy.ResetEnemy();
    }

    void MoveToNextLevel()
    {
        CurrentLevel.SetActive(false);
        NextLevel.SetActive(true);

        bulletsLeft = 5;
    }


}
