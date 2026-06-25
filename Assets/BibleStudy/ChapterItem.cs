using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChapterItem : MonoBehaviour
{
    public UILabel m_LabelNumber;

    public UILabel LabelNumber { get { return m_LabelNumber; } set { m_LabelNumber = value; } }

    public int m_Chapter;

    public int Chapter { get { return m_Chapter; } set { m_Chapter = value; } }

    public void Init(int chapter)
    {
        Chapter = chapter;

        int KeyWord = BibleStudy.Get.GetNationCode(BibleStudy.Get.m_NationType);

        if (KeyWord == 13) // Korean
        {
            if (BibleStudy.Get.m_CheckboxReadBibleKorean.value == true) LabelNumber.text = string.Format("{0}장", chapter);
            else LabelNumber.text = string.Format("{0}", chapter);
        }
        else LabelNumber.text = string.Format("{0}", chapter);
    }

    public void OnClicked()
    {
        BibleStudy.Get.StopIsPlay();

        foreach (var item in BibleStudy.Get.m_ChapterItems) Destroy(item.gameObject);

        BibleStudy.Get.m_ChapterItems.Clear();
        BibleStudy.Get.m_Chapter = Chapter;
        PlayerPrefs.SetInt("m_Chapter", Chapter);
        OldTestamentInfo bibleOld = new OldTestamentInfo();
        NewTestamentInfo bibleNew = new NewTestamentInfo();

        if (BibleStudy.Get.m_TempBibleType == EBibleType.OldTestament)
        {
            BibleStudy.Get.m_BibleType = EBibleType.OldTestament; // 구약성서를 선택.
            PlayerPrefs.SetString("m_BibleType", BibleStudy.Get.m_BibleType.ToString()); // 구약성서를 선택한 것을 메모리에 저장.
            BibleStudy.Get.m_OldTestamentType = BibleStudy.Get.m_TempOldTestamentType;
            PlayerPrefs.SetString("m_OldTestamentType", BibleStudy.Get.m_OldTestamentType.ToString());
            bibleOld = OldTestamentTable.GetByIndex((int)BibleStudy.Get.m_OldTestamentType);
            BibleStudy.Get.m_MaxChapter = bibleOld.m_Count;
            PlayerPrefs.SetInt("m_MaxChapter", BibleStudy.Get.m_MaxChapter);
            BibleStudy.Get.SetOldTestamentInfo(bibleOld, bibleNew);
        }
        else if (BibleStudy.Get.m_TempBibleType == EBibleType.NewTestament)
        {
            BibleStudy.Get.m_BibleType = EBibleType.NewTestament;  // 신약성서를 선택.
            PlayerPrefs.SetString("m_BibleType", BibleStudy.Get.m_BibleType.ToString()); // 신약성서를 선택했다는 것을 메모리에 저장.
            BibleStudy.Get.m_NewTestamentType = BibleStudy.Get.m_TempNewTestamentType;
            PlayerPrefs.SetString("m_NewTestamentType", BibleStudy.Get.m_NewTestamentType.ToString());
            bibleNew = NewTestamentTable.GetByIndex((int)BibleStudy.Get.m_NewTestamentType);
            BibleStudy.Get.m_MaxChapter = bibleNew.m_Count;
            PlayerPrefs.SetInt("m_MaxChapter", BibleStudy.Get.m_MaxChapter);
            BibleStudy.Get.SetNewTestamentInfo(bibleOld, bibleNew);
        }

        BibleStudy.Get.SetPanelAlpla(1, 0, 0);
        BibleStudy.Get.InitScrollBarPanelMan();
    }
}
