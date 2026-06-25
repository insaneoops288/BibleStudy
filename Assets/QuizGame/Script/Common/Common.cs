using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Common : MonoBehaviour
{
    /// <summary>
    /// 텍스트 파일을 읽어서 문제들과 사지선다형 답글들과 정답 번호들을 저장.
    /// </summary>
    /// <param name="textAsset"></param>
    /// <returns></returns>
    public static List<QuizInfo> GetQuizInfos(string quizText, bool IsEnglishQuestion)
    {
        List<QuizInfo> infos = new List<QuizInfo>();
        QuizUI.Get.listFirst.Clear();
        QuizUI.Get.listSecond.Clear();

        QuizUI.Get.testArray.Clear();
        QuizUI.Get.testArray = quizText.Split("\r\n").ToList();
        Debug.Log("testArray.Count : " + QuizUI.Get.testArray.Count);
        // 퀴즈는 1부터 시작하는데 QuizUI.Get.QuizIndex는 0으로 초기화 되었으므로
        QuizUI.Get.m_TextCount.text = string.Format("{0} / {1} 문제", QuizManager.Get.QuizIndex + 1, (QuizUI.Get.testArray.Count / 2));

        for (int i = 0; i < QuizUI.Get.testArray.Count; i += 2)
        {
            if (IsEnglishQuestion)
            {
                QuizUI.Get.listFirst.Add(QuizUI.Get.testArray[i]);
                QuizUI.Get.listSecond.Add(QuizUI.Get.testArray[i + 1]);
            }
            else
            {
                QuizUI.Get.listSecond.Add(QuizUI.Get.testArray[i]);
                QuizUI.Get.listFirst.Add(QuizUI.Get.testArray[i + 1]);
            }
        }


        //quizText = quizText.Replace("\r\n", "");

        //if (IsEnglishQuestion)
        //    GetData(quizText, ref listFirst, ref listSecond);
        //else
        //    GetData(quizText, ref listSecond, ref listFirst);

        for (int i = 0; i < QuizUI.Get.listFirst.Count; i++)
        {
            //예시 답안은 사지선다형입니다.
            List<string> answers = new List<string> {"", "", "", ""};

            /*
             사지선다형의 예시 답안중 정답이 아닌 것들중에 나머지 3개를 고르기 위해서 우선 정답을 지워줌.
            답안에 해당하는 원본 컬렉션을 그대로 쓰게 되면 RemoveAt함수로 삭제 했을 때.
            원본까지 지워지므로 사본을 만들어서 사용.
             */
            List<string> tempList = new List<string>(QuizUI.Get.listSecond);
            tempList.RemoveAt(i);

            for (int j = 0; j < answers.Count; j++)
            {
                //정답이 들어 있는 않은 리스트에서 랜덤으로 하나를 선택.
                int tempIndex = Random.Range(0, tempList.Count);
                //예시 답안에 넣어줌.
                answers[j] = tempList[tempIndex];
                //예시 답안이 중복되는 것을 방지하기 위해서 랜덤으로 선택한 예시 답안을 지워줌.
                tempList.RemoveAt(tempIndex);
            }

            //정답은 사지선다형의 어느곳에도 들어갈 수 있기 때문에 랜덤으로 선택.
            int radomAnswerIndex = Random.Range(0, answers.Count);
            //실제 정답을 넣어줌.
            answers[radomAnswerIndex] = QuizUI.Get.listSecond[i];

            QuizInfo info = new QuizInfo();
            //질문 넣어주고.
            info.m_Question = QuizUI.Get.listFirst[i];
            //사지선다형의 4개의 예시 답안중 몇 번째 예시 답안이 정답인지를 정해주고.
            info.m_AnswerIndex = radomAnswerIndex;
            //정답이 포함된 예시 답안들을 넣어줌.
            info.m_Answers = answers;

            infos.Add(info);
        }

        return infos;
    }

    /// <summary>
    /// 받은 텍스트 파일의 내용을 "." 로 분리해서 첫 문자열은 first리스트에 두 번째 문자열은 second에 추가.
    /// </summary>
    /// <param name="text"></param>
    /// <param name="first"></param>
    /// <param name="second"></param>
    public static void GetData(string text, ref List<string> first, ref List<string> second)
    {
        string[] data = text.Split('.');

        for (int i = 0; i < data.Length; i += 2)
        {
            first.Add(data[i]);
            second.Add(data[i + 1]);
        }

        Debug.Log("first.Count : " + first.Count);
        Debug.Log("second.Count : " + second.Count);
    }
}
