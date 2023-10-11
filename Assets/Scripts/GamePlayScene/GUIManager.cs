using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class GUIManager : MonoBehaviour
{
    public Text levelNoText;

    public static GUIManager instance;

    public GameObject restartButton;
    public GameObject undoButton;
    public Transform levelPassedMessage;
    public Transform levelFailedMessage;
    public Transform nextLevelButton;

    private void MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Awake()
    {
        MakeInstance();
    }

    void Start()
    {
       
    }

    public void SetLevelText(int levelNo)
    {
        levelNoText.text = "LEVEL " + levelNo;
    }

    
    public void ShowLevelPassedMessage()
    {
        levelPassedMessage.gameObject.SetActive(true);
    }
    private void ShowLevelFailedMessage()
    {
        levelFailedMessage.gameObject.SetActive(true);
    }

    private void SetResetAndUndoButtonDisable()
    {
        restartButton.GetComponent<Button>().enabled = false;
        undoButton.GetComponent<Button>().enabled = false;
    }

    public void OnTapToContinueButton()
    {
        LevelManager.instance.LoadNextLevel();
    }

    public void OnTapToReplayButton()
    {
        LevelManager.instance.LoadCurrentLevel();
    }
}
