using System.IO;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;

public enum ESoundType
{
    None = -1,
    Correct,
    Wrong,
    Select,
    Forward,
    Backward,
    Error,
    Contratulation,
    Max,
}

public class QuizUI : MonoBehaviour
{
    private static QuizUI m_instance = null;

    public static QuizUI Get { get { return m_instance; } }

    public List<AudioClip> m_AudioClips = new List<AudioClip>();
    public AudioSource m_AudioSource;

    public List<string> testArray = new List<string>();

    public List<string> listFirst = new List<string>();
    public List<string> listSecond = new List<string>();

    public List<RectTransform> transforms = new List<RectTransform>();

    public RectTransform imageQuestion;

    /// <summary>
    /// 퀴즈판.
    /// </summary>
    public RectTransform m_MainPanel;
    public RectTransform m_PopupResultPanel;
    /// <summary>
    /// 버튼이 계속 눌리는 것을 방지하기 위해서 참조.
    /// </summary>
    public List<Button> m_Buttons = new List<Button>();
    /// <summary>
    /// 게임상에서 일어나는 정보들을 표시.
    /// </summary>
    public Text m_TextInfo;

    public Text m_TextCount;
    
    /// <summary>
    /// 퀴즈 문제를 표시.
    /// </summary>
    public Text m_TextQuestion;
    /// <summary>
    /// 퀴즈의 예상 정답들을 사지선다형으로 표시.
    /// </summary>
    public List<Text> m_TextAnswers = new List<Text>();
    /// <summary>
    /// 퀴즈를 맟추었는지, 틀렸는지를 표시.
    /// </summary>
    public Text m_TextMessage;
    /// <summary>
    /// 스코어를 표시.
    /// </summary>
    public Text m_TextScore;
    /// <summary>
    /// 퀴즈를 다 풀었을 때 초기화되고 결과 스코어를 표시.
    /// </summary>
    public Text m_TextResult;
    /// <summary>
    /// 인벤토리 아이템들의 스크롤뷰의 그리드.
    /// </summary>
    public RectTransform m_GridInventory;

    public int QuizIndex = 0;

    public int QuizKindIndex = 0;

    public RectTransform m_ContentWorldList;

    public WordItem m_WordItem;

    /// <summary>
    /// 데이터 초기화 이벤트 함수.
    /// </summary>
    private void Awake()
    {
        m_instance = this;
        Initialize();
    }

    private void Start()
    {
        isEnglishQuestion = true;

        QuizKindIndex = PlayerPrefs.GetInt("QuizKindIndex");
        Debug.Log("QuizKindIndex : " + QuizKindIndex);

        //List<Sprite> ImageAssets = Resources.LoadAll<Sprite>(@"Images\").ToList();
        //int randomIndex = Random.Range(0, ImageAssets.Count);
        //GetComponent<Image>().sprite = ImageAssets[randomIndex];

        QuizManager.Get.GetQuizUI.Initialize();
        QuizManager.Get.GetQuizUI.InitializeScore();
        QuizManager.Get.GetQuizUI.SetMainPanelActive(true);
        AudioClip clip = QuizManager.Get.GetQuizUI.GetSound(ESoundType.Select);
        QuizManager.Get.GetQuizUI.PlayButtonSound(clip);
        QuizManager.Get.Initialize();

        QuizManager.Get.QuizData = QuizManager.Get.QuizDatas[QuizUI.Get.QuizKindIndex];
        QuizUI.Get.m_TextInfo.text = QuizManager.Get.QuizData.name + " 선택되었습니다. ";
        QuizManager.Get.StartGame(true);

        SpawnWordItem();
    }

    public void SpawnWordItem()
    {
        for (int i = 0; i < QuizManager.Get.QuizDatas.Count; i++)
        {
            WordItem worldItem = Instantiate(m_WordItem);
            worldItem.index = i;
            List<string> quizCount = QuizManager.Get.QuizDatas[i].text.Split("\r\n").ToList();
            worldItem.m_Text.text = QuizManager.Get.QuizDatas[i].name + " (" + (quizCount.Count / 2) + "문제)";
            worldItem.transform.SetParent(m_ContentWorldList);
            worldItem.GetComponent<RectTransform>().localScale = new Vector3(1.0f, 1.0f, 1.0f);
        }
    }

    /// <summary>
    /// 메인패널과 결과창을 비활성화.
    /// </summary>
    public void Initialize()
    {
        SetMainPanelActive(false);
        SetPopupResultPanelActive(false);
    }

    /// <summary>
    /// 스코어를 표시하는 UI를 초기화함.
    /// </summary>
    /// <param name="index"></param>
    public void InitializeScore()
    {
        if (m_TextScore)
            m_TextScore.text = string.Format("Score {0}", 0);
        else
            Debug.Log("There is no TextScore !!");
    }

    /// <summary>
    /// 퀴즈판을 보일지? 숨길지?
    /// </summary>
    /// <param name="isActive"></param>
    public void SetMainPanelActive(bool isActive)
    {
        if (m_MainPanel)
            m_MainPanel.gameObject.SetActive(isActive);
        else
            Debug.Log("There is no MainPanel !!");
    }

    /// <summary>
    /// 결과창을 보일지? 숨길지?
    /// </summary>
    /// <param name="isActive"></param>
    public void SetPopupResultPanelActive(bool isActive)
    {
        m_PopupResultPanel.gameObject.SetActive(isActive);
        m_MainPanel.gameObject.SetActive(!isActive);
    }

    /// <summary>
    /// 질문을 영어로 할지? 한글로 할지?
    /// </summary>
    /// <param name="isEnglishQuestion"></param>
    public void ChangeQuizGameLanguage(bool isEnglishQuestion)
    {
        Initialize();
        InitializeScore();
        SetMainPanelActive(true);
        QuizManager.Get.Initialize();
        QuizManager.Get.StartGame(isEnglishQuestion);
        QuizManager.Get.IsFinished = false;
    }

    /// <summary>
    /// 퀴즈 데이터들을 가져와서 UI에서 선택할 수록 스크롤 뷰 UI구성.
    /// </summary>
    public void SetInventory()
    {
        for (int i = 0; i < QuizManager.Get.QuizDatas.Count; i++)
        {
            QuizData quizData = Instantiate(Resources.Load("QuizData", typeof(QuizData))) as QuizData;
            quizData.transform.SetParent(m_GridInventory);
            quizData.SetInfo(QuizManager.Get.QuizDatas[i]);
        }
    }

    public bool isEnglishQuestion = true;

    /// <summary>
    /// 버튼이 클릭되면 영어 문제로 시작함.
    /// </summary>
    public void ButtonForward()
    {
        QuizUI.Get.CancelAutoPlay();
        ShowQuizUIForward();
        // Invoke("ShowQuizUIForward", 2.0f);
    }

    public void ShowQuizUIForward()
    {
        string message = string.Empty;

        if (!QuizManager.Get.QuizData)
        {
            message = "There is no QuizData. !!";
            PlayButtonSound(GetSound(ESoundType.Error));
            SetInformation(message);
            return;
        }

        InitializeScore();
        QuizManager.Get.Initialize();

        isEnglishQuestion = true;
        ChangeQuizGameLanguage(isEnglishQuestion);
        PlayButtonSound(GetSound(ESoundType.Forward));

        message = "Play it back.";
        SetInformation(message);
    }


    /// <summary>
    /// 버튼이 클릭되면 한글 문제로 시작함.
    /// </summary>
    public void ButtonBackward()
    {
        QuizUI.Get.CancelAutoPlay();
        ShowQuizUIBackward();
        // Invoke("ShowQuizUIBackward", 2.0f);
    }

    public void ShowQuizUIBackward()
    {
        string message = string.Empty;

        if (!QuizManager.Get.QuizData)
        {
            message = "There is no QuizData. !!";
            SetInformation(message);
            PlayButtonSound(GetSound(ESoundType.Error));
            return;
        }

        InitializeScore();
        QuizManager.Get.Initialize();

        isEnglishQuestion = false;
        ChangeQuizGameLanguage(isEnglishQuestion);
        PlayButtonSound(GetSound(ESoundType.Backward));

        message = "Play in reverse. !!";
        SetInformation(message);
    }

    public void ButtonClosePopupResult()
    {
        for (int i = 0; i < transforms.Count; i++)
        {
            transforms[i].gameObject.SetActive(true);
        }

        imageQuestion.transform.localPosition = new Vector3(27, 251, 0);

        SetPopupResultPanelActive(false);

        Initialize();
        InitializeScore();
        SetMainPanelActive(false);
        QuizManager.Get.Initialize();

        Start();
    }

    public void CheckAnswer(int index)
    {
        PlayButtonSound(index);
        SetMessage(index);
        SetScore(index);

        QuizManager.Get.QuizIndex++;

        QuizManager.Get.CheckQuiz();

        StartCoroutine(QuizUI.Get.SetInfo(QuizManager.Get.QuizIndex));

        QuizUI.Get.m_TextCount.text = string.Format("{0} / {1} 문제", QuizManager.Get.QuizIndex + 1, (QuizUI.Get.testArray.Count / 2));
    }

    /// <summary>
    /// 사지선다형의 예비 답안중 1번째 버튼을 클릭했을 때.
    /// </summary>
    public void ButtonAnswer0()
    {
        int index = 0;

        if (!QuizManager.Get.QuizData)
        {
            string message = "There is no QuizData. !!";
            SetInformation(message);
            PlayButtonSound(GetSound(ESoundType.Error));
            return;
        }

        StartCoroutine(SetButtonEnabled(index, false));
        CheckAnswer(index);
    }

    /// <summary>
    /// 사지선다형의 예비 답안중 2번째 버튼을 클릭했을 때.
    /// </summary>
    public void ButtonAnswer1()
    {
        int index = 1;

        if (!QuizManager.Get.QuizData)
        {
            string message = "There is no QuizData. !!";
            SetInformation(message);
            PlayButtonSound(GetSound(ESoundType.Error));
            return;
        }

        StartCoroutine(SetButtonEnabled(index, false));
        CheckAnswer(index);
    }

    /// <summary>
    /// 사지선다형의 예비 답안중 3번째 버튼을 클릭했을 때.
    /// </summary>
    public void ButtonAnswer2()
    {
        int index = 2;

        if (!QuizManager.Get.QuizData)
        {
            string message = "There is no QuizData. !!";
            SetInformation(message);
            PlayButtonSound(GetSound(ESoundType.Error));
            return;
        }

        StartCoroutine(SetButtonEnabled(index, false));
        CheckAnswer(index);
    }

    /// <summary>
    /// 사지선다형의 예비 답안중 4번째 버튼을 클릭했을 때.
    /// </summary>
    public void ButtonAnswer3()
    {
        int index = 3;

        if (!QuizManager.Get.QuizData)
        {
            string message = "There is no QuizData. !!";
            SetInformation(message);
            PlayButtonSound(GetSound(ESoundType.Error));
            return;
        }

        StartCoroutine(SetButtonEnabled(index, false));
        CheckAnswer(index);
    }

    /// <summary>
    /// 사지선다형의 예비답안 버튼이 클릭되면 바로 클릭이 되지 않도록 버튼이.
    /// 일정 시간후 다시 활성화.
    /// </summary>
    /// <param name="index"></param>
    /// <param name="enabled"></param>
    /// <returns></returns>
    public IEnumerator SetButtonEnabled(int index, bool enabled)
    {
        m_Buttons[index].enabled = enabled;
        yield return new WaitForSeconds(1.5f);
        m_Buttons[index].enabled = !enabled;
    }

    /// <summary>
    /// 정답을 맟추었을 때와 틀렸을 때 다른 사운드를 플레이.
    /// </summary>
    /// <param name="index"></param>
    public void PlayButtonSound(int index)
    {
        int answerIndex = QuizManager.Get.QuizInfos[QuizManager.Get.QuizIndex].m_AnswerIndex;
        ESoundType soundType = (answerIndex == index) ? ESoundType.Correct : ESoundType.Wrong;
        PlayButtonSound(GetSound(soundType));
    }

    /// <summary>
    /// 사운드를 플레이.
    /// </summary>
    /// <param name="clip"></param>
    public void PlayButtonSound(AudioClip clip)
    {
        m_AudioSource.clip = clip;
        m_AudioSource.volume = 0.1f;
        m_AudioSource.Play();
    }

    /// <summary>
    /// 사운드 타입에 따라서 AudioClip을 가져옴.
    /// </summary>
    /// <param name="soundType"></param>
    /// <returns></returns>
    public AudioClip GetSound(ESoundType soundType)
    {
        return m_AudioClips[(int)soundType];
    }

    /// <summary>
    /// 정답을 맟추었는지, 틀렸는지를 표시함.
    /// </summary>
    /// <param name="index"></param>
    public void SetMessage(int index)
    {
        int answerIndex = QuizManager.Get.QuizInfos[QuizManager.Get.QuizIndex].m_AnswerIndex;
        string rightMessage = string.Format("{0}", QuizManager.Get.QuizInfos[QuizManager.Get.QuizIndex].m_Answers[answerIndex]);
        string wrongMessage = string.Format("{0}", "정답은 " + QuizManager.Get.QuizInfos[QuizManager.Get.QuizIndex].m_Answers[answerIndex] + "입니다. ");
        // string message = "정답은 " + QuizManager.Get.QuizInfos[QuizManager.Get.QuizIndex].m_Answers[answerIndex] + "입니다. ";
        string message = (answerIndex == index) ? rightMessage : wrongMessage;

        if (m_TextMessage)
        {
            if (answerIndex == index)
            {
                m_TextMessage.color = Color.white;
            }
            else
            {
                m_TextMessage.color = Color.red;
            }

            m_TextMessage.text = message;
            StartCoroutine(InitializeTextMessage(m_TextMessage));
        }
        else
            Debug.Log("There is no TextMessage !!");
    }

    /// <summary>
    /// 게임상에서 일어나는 각종 정보들을 표시.
    /// </summary>
    /// <param name="info"></param>
    public void SetInformation(string info)
    {
        if (m_TextInfo)
        {
            //m_TextInfo.text = string.Format("{0}", info);
            //StartCoroutine(InitializeTextMessage(m_TextInfo));
        }
        else
            Debug.Log("There is no TextInfo !!");
    }

    /// <summary>
    /// 정답을 맟추었는지, 틀렸는지를 표시한 후에 원래대로 돌아감.
    /// </summary>
    /// <returns></returns>
    IEnumerator InitializeTextMessage(Text textUI)
    {
        yield return new WaitForSeconds(1.0f);

        if (textUI)
            textUI.text = string.Empty;
        else
            Debug.Log("There is no TextMessage !!");
    }

    /// <summary>
    /// 질문글과 사지선다형으로 유저가 선택할 수 있는 예시 답들을 표시함.
    /// </summary>
    /// <param name="index"></param>
    public IEnumerator SetInfo(int index)
    {
        // 인덱스가 퀴즈 문제수를 벗어났다면? 
        if (index > QuizManager.Get.QuizIndex)
        {
            yield break;
        }

        //m_TextQuestion.text = string.Empty;

        //for (int i = 0; i < m_TextAnswers.Count; i++)
        //{
        //    m_TextAnswers[i].text = string.Empty;
        //}

        yield return new WaitForSeconds(1.5f);
        // yield return new WaitForSeconds(5.0f);

        if (m_TextQuestion)
        {
            m_TextQuestion.text = QuizManager.Get.QuizInfos[index].m_Question;

            if (isEnglishQuestion)
            {
                StartCoroutine(DownloadTheAudio());
            }
        }
        else
            Debug.Log("There is no TextQuestion !!");

        for (int i = 0; i < m_TextAnswers.Count; i++)
        {
            if (m_TextAnswers[i])
                m_TextAnswers[i].text = QuizManager.Get.QuizInfos[index].m_Answers[i];
            else
                Debug.Log("There is no TextAnswers !!");
        }
    }

    /// <summary>
    /// 영문 사운드를 읽어 줌
    /// </summary>
    /// <param name="index"></param>
    public void SetInfoShort(int index)
    {
        if (m_TextQuestion)
        {
            m_TextQuestion.text = QuizManager.Get.QuizInfos[index].m_Question;

            if (isEnglishQuestion)
            {
                StartCoroutine(DownloadTheAudio());
            }
        }
        else
        {
            Debug.Log("There is no TextQuestion !!");
        }

        for (int i = 0; i < m_TextAnswers.Count; i++)
        {
            if (m_TextAnswers[i])
            {
                m_TextAnswers[i].text = QuizManager.Get.QuizInfos[index].m_Answers[i];
            }
            else
            {
                Debug.Log("There is no TextAnswers !!");
            }
        }
    }

    /// <summary>
    /// 스코어를 표시함.
    /// </summary>
    /// <param name="index"></param>
    public void SetScore(int index)
    {
        bool isCorrect = (QuizManager.Get.QuizInfos[QuizManager.Get.QuizIndex].m_AnswerIndex == index) ? true : false;

        if (isCorrect)
            ++QuizManager.Get.Score;

        if (m_TextScore)
            m_TextScore.text = string.Format("Score {0}", QuizManager.Get.Score);
        else
            Debug.Log("There is no TextScore !!");
    }

    /// <summary>
    /// 모든 문제를 다 풀었을 때 결과를 표시함.
    /// </summary>
    public void SetResult()
    {
        if (m_TextResult)
        {
            Initialize();
            InitializeScore();
            SetPopupResultPanelActive(true);
            m_TextResult.text = string.Format("Your Final Score : {0}", QuizManager.Get.Score);
        }
        else
            Debug.Log("There is no TextResult !!");
    }

    public void ButtonQuit()
    {
        SceneManager.LoadScene("BibleStudy");
    }

    public void ButtonReturn()
    {
        SceneManager.LoadScene("Main");
    }

    public void ButtonPreviousWord()
    {
        QuizUI.Get.CancelAutoPlay();

        QuizKindIndex--;

        if (QuizKindIndex < 0)
        {
            QuizKindIndex = QuizManager.Get.QuizDatas.Count - 1;
        }

        PlayerPrefs.SetInt("QuizKindIndex", QuizKindIndex);

        Start();
    }

    public void ButtonNextWord()
    {
        QuizUI.Get.CancelAutoPlay();

        QuizKindIndex++;

        if (QuizKindIndex >= QuizManager.Get.QuizDatas.Count)
        {
            QuizKindIndex = 0;
        }

        PlayerPrefs.SetInt("QuizKindIndex", QuizKindIndex);

        Start();
    }

    public void ButtonPlay()
    {
        QuizUI.Get.CancelAutoPlay();

        StartCoroutine(DownloadTheAudio());
    }

    IEnumerator DownloadTheAudio()
    {
        yield return null;

        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.volume = 1;

        if (isEnglishQuestion)
        {
            if (!string.IsNullOrEmpty(listFirst[QuizManager.Get.QuizIndex]))
            {
                string url = @"https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + listFirst[QuizManager.Get.QuizIndex] + "&tl=en-US";

                //WWW www = new WWW(url);
                //yield return www;

                //audioSource.clip = www.GetAudioClip(false, true, AudioType.MPEG);
                //audioSource.Play();

                using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.MPEG))
                {
                    yield return www.SendWebRequest();

                    AudioClip myClip = DownloadHandlerAudioClip.GetContent(www);
                    audioSource.PlayOneShot(myClip);
                }
            }
        }
        else
        {
            //if (!string.IsNullOrEmpty(listFirst[QuizManager.Get.QuizIndex]))
            //{
            //    string url = @"https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + listFirst[QuizManager.Get.QuizIndex] + "&tl=ko-KR";

            //    WWW www = new WWW(url);
            //    yield return www;

            //    audioSource.clip = www.GetAudioClip(false, true, AudioType.MPEG);
            //    audioSource.Play();
            //}
        }
    }


    IEnumerator DownloadTheAudioQuestion()
    {
        yield return null;

        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.volume = 1;

        string url = @"https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + m_TextQuestion.text + "&tl=en-US";

        WWW www = new WWW(url);
        yield return www;

        audioSource.clip = www.GetAudioClip(false, true, AudioType.MPEG);
        audioSource.Play();
    }

    IEnumerator DownloadTheAudioAnswer()
    {
        yield return null;

        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.volume = 1;

        string url = @"https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + m_TextMessage.text + "&tl=en-US";

        //WWW www = new WWW(url);
        //yield return www;

        //audioSource.clip = www.GetAudioClip(false, true, AudioType.MPEG);
        //audioSource.Play();

        using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.MPEG))
        {
            yield return www.SendWebRequest();

            AudioClip myClip = DownloadHandlerAudioClip.GetContent(www);
            audioSource.PlayOneShot(myClip);
        }
    }

    public bool isPlayGame = false;

    public void CancelAutoPlay()
    {
        QuizUI.Get.isPlayGame = false;
        QuizUI.Get.m_TextMessage.text = string.Empty;
    }

    public void ButtonAutoForward()
    {
        // m_TextMessage.text = string.Empty;
        StopAllCoroutines();
        isPlayGame = true;
        StartCoroutine(AutoButtonForward());
    }

    public IEnumerator AutoButtonForward()
    {
        string message = string.Empty;



        InitializeScore();
        QuizManager.Get.Initialize();

        isEnglishQuestion = true;
        ChangeQuizGameLanguage(isEnglishQuestion);
        PlayButtonSound(GetSound(ESoundType.Forward));

        message = "Play it back.";
        SetInformation(message);

        Debug.Log("m_QuizInfos.Count : " + QuizManager.Get.m_QuizInfos.Count);

        for (int i = 0; i < QuizManager.Get.m_QuizInfos.Count; i++)
        {
            //if (isPlayGame == false)
            //{
            //    StopAllCoroutines();
            //    yield break;
            //}

            // StartCoroutine(DownloadTheAudioQuestion());

            yield return new WaitForSeconds(5f);
            if (QuizManager.Get.QuizInfos[QuizManager.Get.QuizIndex].m_AnswerIndex == 0)
                ButtonAnswer0();
            else if (QuizManager.Get.QuizInfos[QuizManager.Get.QuizIndex].m_AnswerIndex == 1)
                ButtonAnswer1();
            else if (QuizManager.Get.QuizInfos[QuizManager.Get.QuizIndex].m_AnswerIndex == 2)
                ButtonAnswer2();
            else if (QuizManager.Get.QuizInfos[QuizManager.Get.QuizIndex].m_AnswerIndex == 3)
                ButtonAnswer3();



            if (isPlayGame == false)
            {
                StopAllCoroutines();
                CancelAutoPlay();

                //isEnglishQuestion = true;

                //QuizKindIndex = PlayerPrefs.GetInt("QuizKindIndex");
                //Debug.Log("QuizKindIndex : " + QuizKindIndex);

                //List<Sprite> ImageAssets = Resources.LoadAll<Sprite>(@"Images\").ToList();
                //int randomIndex = Random.Range(0, ImageAssets.Count);
                //GetComponent<Image>().sprite = ImageAssets[randomIndex];

                //QuizManager.Get.GetQuizUI.Initialize();
                //QuizManager.Get.GetQuizUI.InitializeScore();
                //QuizManager.Get.GetQuizUI.SetMainPanelActive(true);
                //AudioClip clip = QuizManager.Get.GetQuizUI.GetSound(ESoundType.Select);
                //QuizManager.Get.GetQuizUI.PlayButtonSound(clip);
                //QuizManager.Get.Initialize();

                //QuizManager.Get.QuizData = QuizManager.Get.QuizDatas[QuizUI.Get.QuizKindIndex];
                //QuizUI.Get.m_TextInfo.text = QuizManager.Get.QuizData.name + " 선택되었습니다. ";
                //QuizManager.Get.StartGame(true);

                yield break;
            }
        }
    }

    public void ButtonAutoBackward()
    {
        // m_TextMessage.text = string.Empty;
        StopAllCoroutines();
        isPlayGame = true;
        StartCoroutine(AutoButtonBackward());
    }

    public IEnumerator AutoButtonBackward()
    {
        // ButtonNextWord();
        // ButtonBackward();

        string message = string.Empty;
        //if (isPlayGame == false)
        //{
        //    StopAllCoroutines();
        //    CancelAutoPlay();
        //    yield break;
        //}

        InitializeScore();
        QuizManager.Get.Initialize();

        isEnglishQuestion = false;
        ChangeQuizGameLanguage(isEnglishQuestion);
        // PlayButtonSound(GetSound(ESoundType.Backward));

        message = "Play in reverse. !!";
        SetInformation(message);

        Debug.Log("m_QuizInfos.Count : " + QuizManager.Get.m_QuizInfos.Count);

        for (int i = 0; i < QuizManager.Get.m_QuizInfos.Count; i++)
        {
            if (isPlayGame == false)
            {
                StopAllCoroutines();
                yield break;
            }
            

            yield return new WaitForSeconds(5f);

            StartCoroutine(DownloadTheAudioAnswer());

            if (QuizManager.Get.QuizInfos[QuizManager.Get.QuizIndex].m_AnswerIndex == 0)
                ButtonAnswer0();
            else if (QuizManager.Get.QuizInfos[QuizManager.Get.QuizIndex].m_AnswerIndex == 1)
                ButtonAnswer1();
            else if (QuizManager.Get.QuizInfos[QuizManager.Get.QuizIndex].m_AnswerIndex == 2)
                ButtonAnswer2();
            else if (QuizManager.Get.QuizInfos[QuizManager.Get.QuizIndex].m_AnswerIndex == 3)
                ButtonAnswer3();

            

            if (isPlayGame == false)
            {
                StopAllCoroutines();
                CancelAutoPlay();

                //isEnglishQuestion = true;

                //QuizKindIndex = PlayerPrefs.GetInt("QuizKindIndex");
                //Debug.Log("QuizKindIndex : " + QuizKindIndex);

                //List<Sprite> ImageAssets = Resources.LoadAll<Sprite>(@"Images\").ToList();
                //int randomIndex = Random.Range(0, ImageAssets.Count);
                //GetComponent<Image>().sprite = ImageAssets[randomIndex];

                //QuizManager.Get.GetQuizUI.Initialize();
                //QuizManager.Get.GetQuizUI.InitializeScore();
                //QuizManager.Get.GetQuizUI.SetMainPanelActive(true);
                //AudioClip clip = QuizManager.Get.GetQuizUI.GetSound(ESoundType.Select);
                //QuizManager.Get.GetQuizUI.PlayButtonSound(clip);
                //QuizManager.Get.Initialize();

                //QuizManager.Get.QuizData = QuizManager.Get.QuizDatas[QuizUI.Get.QuizKindIndex];
                //QuizUI.Get.m_TextInfo.text = QuizManager.Get.QuizData.name + " 선택되었습니다. ";
                //QuizManager.Get.StartGame(true);

                yield break;
            }
        }
    }

    public void ButtoForwarAuto()
    {
        for (int i = 0; i < transforms.Count; i++)
        {
            transforms[i].gameObject.SetActive(false);
        }

        imageQuestion.transform.localPosition = new Vector3(27, 91, 0);

        ButtonAutoForward();
    }

    public void ButtonBackwardAuto()
    {
        for (int i = 0; i < transforms.Count; i++)
        {
            transforms[i].gameObject.SetActive(false);
        }

        imageQuestion.transform.localPosition = new Vector3(27, 91, 0);

        ButtonAutoBackward();
    }

    public void Update()
    {
        if (Input.GetKeyUp(KeyCode.PageDown))
        {
            //QuizKindIndex++;

            //if (QuizKindIndex >= QuizManager.Get.QuizDatas.Count)
            //{
            //    QuizKindIndex = 0;
            //}

            //PlayerPrefs.SetInt("QuizKindIndex", QuizKindIndex);

            //Start();
            
            //for (int i = 0; i < transforms.Count; i++)
            //{
            //    transforms[i].gameObject.SetActive(false);
            //}

            //ButtonAutoBackward();
        }

        if (Input.GetKeyUp(KeyCode.PageUp))
        {
            //QuizKindIndex--;

            //if (QuizKindIndex < 0)
            //{
            //    QuizKindIndex = QuizManager.Get.QuizDatas.Count - 1;
            //}

            //PlayerPrefs.SetInt("QuizKindIndex", QuizKindIndex);

            //Start();

            //for (int i = 0; i < transforms.Count; i++)
            //{
            //    transforms[i].gameObject.SetActive(false);
            //}

            //ButtonAutoForward();
        }

        if (Input.GetKeyUp(KeyCode.RightShift))
        {
            // StartCoroutine(AutoButtonForward());
        }
    }
}
