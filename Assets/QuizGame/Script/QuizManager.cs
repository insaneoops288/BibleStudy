using System.IO;
using System.Text;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    private static QuizManager m_instance = null;

    public static QuizManager Get { get { return m_instance; } }

    /// <summary>
    /// QuizUI가 있을 수도, 없을 수도 있고, 클래스가 바뀔 수도 있으니 항상 GetQuizUI 속성을 통해서 접근.
    /// </summary>
    public QuizUI GetQuizUI { get { return QuizUI.Get; } }

    private TextAsset m_QuizData;
    public TextAsset QuizData { get { return m_QuizData; } set { m_QuizData = value; } }
    private List<TextAsset> m_QuizDatas = new List<TextAsset>();
    public List<TextAsset> QuizDatas { get { return m_QuizDatas; } set { m_QuizDatas = value; } }
    /// <summary>
    /// 퀴즈의 문제와 정답 예시들, 정답 Index를 저장.
    /// </summary>
    public List<QuizInfo> m_QuizInfos = new List<QuizInfo>();
    public List<QuizInfo> QuizInfos { get { return m_QuizInfos; } set { m_QuizInfos = value; } }
    /// <summary>
    /// 다음 Quiz로 넘어가기 위한 Index.
    /// </summary>
    public int m_QuizIndex = 0;
    public int QuizIndex { get { return m_QuizIndex; } set { m_QuizIndex = value; } }
    /// <summary>
    /// 점수.
    /// </summary>
    public int m_Score = 0;
    public int Score { get { return m_Score; } set { m_Score = value; } }
    /// <summary>
    /// 만일 m_IsFinished의 값이 true라면 게임이 끝나게 됨.
    /// </summary>
    private bool m_IsFinished = false;
    public bool IsFinished { get { return m_IsFinished; } set { m_IsFinished = value; } }

    private void Awake()
    {
        m_instance = this;

        Initialize();
        m_QuizDatas = GetQuizDatas();
    }

    

    /// <summary>
    /// 게임이 시작되면 제일 먼저 호출되는 이벤트 함수.
    /// </summary>
    void Start()
    {
        // GetQuizUI.SetInventory();

        
    }

    /// <summary>
    /// 스코어와 문제 인덱스를 초기화.
    /// </summary>
    public void Initialize()
    {
        m_Score = 0;
        m_QuizIndex = 0;
    }

    /// <summary>
    /// 질문을 영어로 할지? 한글로 할지?
    /// </summary>
    /// <param name="isEnglishQuestion"></param>
    public void StartGame(bool isEnglishQuestion)
    {
        if (!m_QuizData)
        {
            Debug.Log("There is no QuizData !!");
            return;
        }

        m_QuizInfos = Common.GetQuizInfos(m_QuizData.text, isEnglishQuestion);

        if (GetQuizUI)
        {
            // GetQuizUI.SetInfoShort(m_QuizIndex);
            StartCoroutine(GetQuizUI.SetInfo(m_QuizIndex));
        }
        else
            Debug.Log("There is no QuizUI !!");
    }

    /// <summary>
    /// 퀴즈 데이터들을 불러옴.
    /// </summary>
    /// <returns></returns>
    public List<TextAsset> GetQuizDatas()
    {
        List<TextAsset> textAssets = Resources.LoadAll<TextAsset>(@"Data\").ToList();

        return textAssets;
    }

    public void SetResult()
    {

    }


    /// <summary>
    /// 모든 문제를 다 풀었는지 확인함.
    /// </summary>
    public void CheckQuiz()
    {
        if (m_QuizIndex == m_QuizInfos.Count)
        {
            

            Invoke("FinkshQuiz", 3.0f);
        }
    }

    public void FinkshQuiz()
    {
        StopAllCoroutines();

        //게임이 끝났으니 끝났다고 통지해주고.
        m_IsFinished = true;
        //퀴즈 데이터도 없애준다.
        m_QuizData = null;

        // 게임을 끝냄
        GetQuizUI.isPlayGame = false;
        //UI 초기화해주고.
        GetQuizUI.Initialize();

        //결과창을 띄우고.
        GetQuizUI.SetPopupResultPanelActive(true);
        //게임결과를 표시한다.
        GetQuizUI.SetResult();
        //매니져도 초기화.
        Initialize();
        GetQuizUI.PlayButtonSound(GetQuizUI.GetSound(ESoundType.Contratulation));
    }
}
