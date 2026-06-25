using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class QuizInfo
{
    /// <summary>
    /// 질문.
    /// </summary>
    public string m_Question;
    /// <summary>
    /// 4개의 사지선다형.
    /// </summary>
    public List<string> m_Answers = new List<string>();
    /// <summary>
    /// 정답 Index.
    /// </summary>
    public int m_AnswerIndex;
}
