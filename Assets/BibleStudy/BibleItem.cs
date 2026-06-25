using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BibleItem : MonoBehaviour
{
    public EOldTestamentType m_OldTestamentType = EOldTestamentType.None;

    public EOldTestamentType OldTestamentType { get { return m_OldTestamentType; } set { m_OldTestamentType = value; } }

    public ENewTestamentType m_NewTestamentType = ENewTestamentType.None;

    public ENewTestamentType NewTestamentType { get { return m_NewTestamentType; } set { m_NewTestamentType = value; } }

    public UILabel m_UILabelBibleName;

    public UILabel UILabelBibleName { get { return m_UILabelBibleName; } set { m_UILabelBibleName = value; } } 

    public UILabel m_UILabelBibleNameEnglish;

    public UILabel UILabelBibleNameEnglish { get { return m_UILabelBibleNameEnglish; } set { m_UILabelBibleNameEnglish = value; } }

    public void OnClicked()
    {
        BibleStudy.Get.SetPanelAlpla(0, 0, 1);

        if (BibleStudy.Get.m_TempBibleType == EBibleType.OldTestament) BibleStudy.Get.m_TempOldTestamentType = OldTestamentType;
        else if (BibleStudy.Get.m_TempBibleType == EBibleType.NewTestament) BibleStudy.Get.m_TempNewTestamentType = NewTestamentType;
        
        OldTestamentInfo bibleOld = new OldTestamentInfo(); // 신약성서 객체 생성.
        NewTestamentInfo bibleNew = new NewTestamentInfo(); // 구약성서 객체 생성.

        if (BibleStudy.Get.m_TempBibleType == EBibleType.OldTestament) // 만일 구약성경을 선택했다면?
        {
            bibleOld = OldTestamentTable.GetByIndex((int)BibleStudy.Get.m_TempOldTestamentType); // 선택된 구약성서의 내용을 가져옴.

            int KeyWord = BibleStudy.Get.GetNationCode(BibleStudy.Get.m_NationType);

            if (KeyWord == 1) // English
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}", bibleOld.m_English);
            else if (KeyWord == 2) // Portuguese
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleOld.m_Portuguese, bibleOld.m_English);
            else if (KeyWord == 3) // Japanese
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleOld.m_Japanese, bibleOld.m_English);
            else if (KeyWord == 4) // German
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleOld.m_German, bibleOld.m_English);
            else if (KeyWord == 5) // Romanian
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleOld.m_Romanian, bibleOld.m_English);
            else if (KeyWord == 6) // French
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleOld.m_French, bibleOld.m_English);
            else if (KeyWord == 7) // Spanish
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleOld.m_Spanish, bibleOld.m_English);
            else if (KeyWord == 8) // Italian
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleOld.m_Italian, bibleOld.m_English);
            else if (KeyWord == 9) // Hungarian
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleOld.m_Hungarian, bibleOld.m_English);
            else if (KeyWord == 10) // Hindi
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleOld.m_Hindi, bibleOld.m_English);
            else if (KeyWord == 11) // Russian
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleOld.m_Russian, bibleOld.m_English);
            else if (KeyWord == 12) // Chinese
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleOld.m_Chinese, bibleOld.m_English);
            else if (KeyWord == 13) // Korean
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}", bibleOld.m_Korean);
        } // 만일 신약성경을 선택했다면?
        else if (BibleStudy.Get.m_TempBibleType == EBibleType.NewTestament)
        {
            bibleNew = NewTestamentTable.GetByIndex((int)BibleStudy.Get.m_TempNewTestamentType); // 선택된 신약성서의 내용을 가져옴.

            int KeyWord = BibleStudy.Get.GetNationCode(BibleStudy.Get.m_NationType);

            if (KeyWord == 1) // English
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}", bibleNew.m_English);
            else if (KeyWord == 2) // Portuguese
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleNew.m_Portuguese, bibleNew.m_English);
            else if (KeyWord == 3) // Japanese
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleNew.m_Japanese, bibleNew.m_English);
            else if (KeyWord == 4) // German
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleNew.m_German, bibleNew.m_English);
            else if (KeyWord == 5) // Romanian
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleNew.m_Romanian, bibleNew.m_English);
            else if (KeyWord == 6) // French
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleNew.m_French, bibleNew.m_English);
            else if (KeyWord == 7) // Spanish
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleNew.m_Spanish, bibleNew.m_English);
            else if (KeyWord == 8) // Italian
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleNew.m_Italian, bibleNew.m_English);
            else if (KeyWord == 9) // Hungarian
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleNew.m_Hungarian, bibleNew.m_English);
            else if (KeyWord == 10) // Hindi
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleNew.m_Hindi, bibleNew.m_English);
            else if (KeyWord == 11) // Russian
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleNew.m_Russian, bibleNew.m_English);
            else if (KeyWord == 12) // Chinese
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}({1})", bibleNew.m_Chinese, bibleNew.m_English);
            else if (KeyWord == 13) // Korean
                BibleStudy.Get.m_LabelSelecChapter.text = string.Format("{0}", bibleNew.m_Korean);
        }

        BibleStudy.Get.SpawnBibleChapter();
    }
}
