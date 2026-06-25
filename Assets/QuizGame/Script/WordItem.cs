using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class WordItem : MonoBehaviour
{
    public int index;
    public Text m_Text;

    public void OnClicked()
    {
        //QuizUI.Get.isPlayGame = false;
        //QuizUI.Get.m_TextMessage.text = string.Empty;
        QuizUI.Get.CancelAutoPlay();

        ShowQuiz();
    }

    public void ShowQuiz()
    {
        PlayerPrefs.SetInt("QuizKindIndex", index);

        QuizUI.Get.isEnglishQuestion = true;

        QuizUI.Get.QuizKindIndex = index;
        Debug.Log("QuizKindIndex : " + QuizUI.Get.QuizKindIndex);

        List<Sprite> ImageAssets = Resources.LoadAll<Sprite>(@"Images\").ToList();
        int randomIndex = Random.Range(0, ImageAssets.Count);
        GetComponent<Image>().sprite = ImageAssets[randomIndex];

        QuizManager.Get.GetQuizUI.Initialize();
        QuizManager.Get.GetQuizUI.InitializeScore();
        QuizManager.Get.GetQuizUI.SetMainPanelActive(true);
        AudioClip clip = QuizManager.Get.GetQuizUI.GetSound(ESoundType.Select);
        QuizManager.Get.GetQuizUI.PlayButtonSound(clip);
        QuizManager.Get.Initialize();

        QuizManager.Get.QuizData = QuizManager.Get.QuizDatas[QuizUI.Get.QuizKindIndex];
        QuizUI.Get.m_TextInfo.text = QuizManager.Get.QuizData.name + " 선택되었습니다. ";
        QuizManager.Get.StartGame(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }
}
