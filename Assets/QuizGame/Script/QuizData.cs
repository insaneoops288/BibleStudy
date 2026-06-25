using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizData : MonoBehaviour
{
    public TextAsset m_TextAsset;
    public Text m_TextName;

    private void Awake()
    {
        
    }

    private void Start ()
    {
		
	}

    public void SetInfo(TextAsset asset)
    {
        m_TextAsset = asset;
        m_TextName.text = asset.name;
    }

    public void Clicked()
    {
        string message = m_TextAsset.name + " is selected. !!";
        QuizManager.Get.GetQuizUI.SetInformation(message);

        QuizManager.Get.GetQuizUI.Initialize();
        QuizManager.Get.GetQuizUI.InitializeScore();
        QuizManager.Get.GetQuizUI.SetMainPanelActive(true);
        AudioClip clip = QuizManager.Get.GetQuizUI.GetSound(ESoundType.Select);
        QuizManager.Get.GetQuizUI.PlayButtonSound(clip);
        QuizManager.Get.Initialize();

        QuizManager.Get.QuizData = m_TextAsset;
        QuizManager.Get.StartGame(true);
    }
}
