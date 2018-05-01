﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestObject : MonoBehaviour {

    public int questNumber;

    public QuestManager theQM;

    public string startText;
    public string endText;

    public bool isItemQuest;
    public string targetItem;

    public bool isEnemyQuest;
    public string targetEnemy;
    public int enemysToKill;
    public int enemyKillCounter;


    // Use this for initialization
    void Start () {
        theQM = FindObjectOfType<QuestManager>();

        
	}
	
	// Update is called once per frame
	void Update () {

        if (isItemQuest)
        {
            if(theQM.itemCollected == targetItem)
            {
                theQM.itemCollected = null;

                EndQuest();
            }
        }
        if (isEnemyQuest)
        {
            if(theQM.enemyKilled == targetEnemy)
            {
                enemyKillCounter++;
                theQM.enemyKilled = null;

              
            }

            if(enemyKillCounter >= enemysToKill)
            {
                EndQuest();
            }
        }
	}

    public void StartQuest()
    {
        theQM.ShowQuestText(startText);
    }

    public void EndQuest()
    {
        theQM.ShowQuestText(endText);
        theQM.questsCompleted[questNumber] = true;
        gameObject.SetActive(false);
    }
}
