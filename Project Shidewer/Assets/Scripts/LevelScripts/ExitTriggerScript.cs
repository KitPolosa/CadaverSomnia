using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTriggerScript : MonoBehaviour
{
    public int enemiesRemaining;
    public int enemiesRemainingSK;
    public int enemiesRemainingGK;
    public int enemiesRemainingSU;
    public GameObject exitTrigger;
    public GameObject firstEnemy;
    public GameObject LevelComplete;
    public GameObject LevelExit;
    public ScreenLevelComplete SLC;
    public ScreenExit SE;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FirstEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        enemiesRemainingSK = GameObject.FindGameObjectsWithTag("Enemy").Length;
        enemiesRemainingGK = GameObject.FindGameObjectsWithTag("EnemySU").Length;
        enemiesRemainingSU = GameObject.FindGameObjectsWithTag("EnemyGD").Length;
        enemiesRemaining = enemiesRemainingSK + enemiesRemainingGK + enemiesRemainingSU;
        SLC = GetComponent<ScreenLevelComplete>();
        SE = GetComponent<ScreenExit>();
    }

    public void EnemyDefeated()
    {
        //enemiesRemaining = enemiesRemainingSK + enemiesRemainingGK;
        enemiesRemaining--;

        if (enemiesRemaining <= 0)
        {
            exitTrigger.SetActive(true);
            ScreenLevelComplete otherScript = LevelComplete.GetComponent<ScreenLevelComplete>();
            ScreenExit otherScript2 = LevelExit.GetComponent<ScreenExit>();
            otherScript.ScrrenFade();
            otherScript2.ScrrenFade();
        }
        else
        {
            exitTrigger.SetActive(false);
        }
    }

    IEnumerator FirstEnemy()
    {
        yield return new WaitForSeconds(9f);
        firstEnemy.SetActive(false);
    }
}