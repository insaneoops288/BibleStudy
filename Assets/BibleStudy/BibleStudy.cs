using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
// using UnityEditor;

#if UNITY_EDITOR
using UnityEditor.PackageManager;
using UnityEditor.VersionControl;
#endif

using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

/**
https://github.com/insaneoops288/Bible
https://github.com/insaneoops288/BibleAfrikaans
https://github.com/insaneoops288/BibleAlbanian
https://github.com/insaneoops288/BibleChinese
https://github.com/insaneoops288/BibleCzech
https://github.com/insaneoops288/BibleFinnish
https://github.com/insaneoops288/BibleFrench
https://github.com/insaneoops288/BibleGerman
https://github.com/insaneoops288/BibleHindi
https://github.com/insaneoops288/BibleHungarian
https://github.com/insaneoops288/BibleIndonesian
https://github.com/insaneoops288/BibleItalian
https://github.com/insaneoops288/BibleJapanese
https://github.com/insaneoops288/BiblePolish
https://github.com/insaneoops288/BiblePortuguese
https://github.com/insaneoops288/BibleRomanian
https://github.com/insaneoops288/BibleRussian
https://github.com/insaneoops288/BibleSpanish
https://github.com/insaneoops288/BibleTagalog
https://github.com/insaneoops288/BibleThai
https://github.com/insaneoops288/BibleVietnamese
https://github.com/insaneoops288/Bible
*/

/**
public void SetOldTestamentInfo(OldTestamentInfo Old, NewTestamentInfo New)
public void SetNewTestamentInfo(OldTestamentInfo Old, NewTestamentInfo New)
void SetBibleInfoSearchFor()
private void Start()

SetBibleInfoInit()

m_KoreanBible
 */

/**
한글성경 4종, 영어성경 6종에서 성경 종류가 바뀌었을 경우

Start()

SetCheckboxEasyBible()
SetCheckboxStandardNewTranslation()
SetCheckboxKoreanBible()
SetCheckboxRevisedRevision()
SetCheckboxNIV()
SetCheckboxESV()
SetCheckboxNKJV()
SetCheckboxKJV()
SetCheckboxNRSV()

SetOldTestamentInfo()
SetNewTestamentInfo()

SetEasyBibleInfo()
SetNewStandardTranslationInfo()
SetKoreanBibleInfo()
SetRevisedRevisionInfo()
SetNIVInfo()
SetESVInfo()
SetNewKJVInfo()
SetKJVInfo()
SetNewRSVInfo()

ShowBible();

CheckKoreanBible();
CheckEnglishBible();

ChapterItem  OnClicked()
*/

public enum ENationType
{
    None = -1,
    Afrikaans,
    Albanian,
    Chinese,
    Czech,
    Finnish,
    French,
    German,
    Hindi,
    Hungarian,
    Indonesian,
    Italian,
    Japanese,
    Polish,
    Portuguese,
    Romanian,
    Russian,
    Spanish,
    Tagalog,
    Thai,
    Vietnamese,
    Korean,
    English,
    Max,
}

public enum EKeyword
{
    None = -1,
    IsCheckboxReadBibleKorean,
    IsPhone,
    OldKoreanBible,
    OldEnglishBible,
    m_BibleType,
    m_OldTestamentType,
    m_NewTestamentType,
    m_Chapter,
    m_MaxChapter,
    Sentence,
    SetScrollbar,
    BibleTestimony,
    BibleMessage,
    QuizGame,
    m_ScrollBarPanelMan,
    SetScrollbarInit,
    Max,
}

/// <summary>
/// 53종의 성경의 Resource폴더에서의 위치값을 구분하기 위한 열거형
/// </summary>
public enum EBiblePath
{
    None = -1,
    afri,                   // EAfrikaansBibleType
    albanian,               // EAlbanianBibleType
    chinese_union_simp,     // EChineseBibleType
    chinese_union_trad,     // EChineseBibleType
    ckjv_sds,               // EChineseBibleType
    ckjv_sdt,               // EChineseBibleType
    bkr,                    // ECzechBibleType
    // stve,
    NIV,                    // EEnglishBibleType
    ESV,                    // EEnglishBibleType
    NewRSV,                 // EEnglishBibleType   
    KJV,                    // EEnglishBibleType
    NewKJV,                 // EEnglishBibleType
    finn,                   // EFinnishBibleType
    epee,                   // EFrenchBibleType
    // martin,
    oster,                  // EFrenchBibleType
    segond_1910,            // EFrenchBibleType
    // elberfelder_1871,
    elberfelder_1905,       // EGermanBibleType
    // luther,
    luther_1912,            // EGermanBibleType
    schlachter,             // EGermanBibleType
    // wlc,
    irv,                    // EHindiBibleType
    karoli,                 // EHungarianBibleType
    indo_tb,                // EIndonesianBibleType
    indo_tm,                // EIndonesianBibleType
    diodati,                // EItalianBibleType
    bungo,                  // EJapaneseBibleType
    kougo,                  // EJapaneseBibleType
    EasyBible,              // EKoreanBibleType
    KoreanBible,            // EKoreanBibleType
    NewStandardTranslation, // EKoreanBibleType
    RevisedRevision,        // EKoreanBibleType
    // maori,
    // opt,
    pol_nbg,                // EPolishBibleType
    pol_ubg,                // EPolishBibleType
    polbg,                  // EPolishBibleType
    almeida_ra,             // EPortugueseBibleType
    almeida_rc,             // EPortugueseBibleType
    blivre,                 // EPortugueseBibleType
    fidela,                 // ERomanianBibleType
    synodal,                 // ERussianBibleType
    rv_1909,                // ESpanishBibleType
    rvg,                    // ESpanishBibleType
    rvg_2004,               // ESpanishBibleType
    sagradas,               // ESpanishBibleType
    tagab,                  // ETagalogBibleType
    thaikjv,                // EThaiBibleType
    // turkish,
    cadman,                 // EVietnameseBibleType
    Max,
}

/// <summary>
/// 구약성서, 신약성서를 구분하기 위한 열거형.
/// </summary>
public enum EBibleType
{
    None = -1,
    OldTestament,
    NewTestament,
    Max,
}
/// <summary>
/// 한국어 성경 4종을 구분하기 위한 열거형
/// </summary>
public enum EKoreanBibleType
{
    EasyBible,
    NewStandardTranslation,
    KoreanBible,
    RevisedRevision,
}

public enum EChineseBibleType
{
    chinese_union_simp,
    chinese_union_trad,
    ckjv_sds,
    ckjv_sdt,
}

public enum EAfrikaansBibleType
{
    afri,
}

public enum EAlbanianBibleType
{
    albanian,
}

public enum ECzechBibleType
{
    bkr,
}

public enum EVietnameseBibleType
{
    cadman,
}

public enum EFinnishBibleType
{
    finn,
}

public enum EIndonesianBibleType
{
    indo_tb,
    indo_tm,
}

public enum EPolishBibleType
{
    pol_nbg,
    pol_ubg,
    polbg,
}

public enum ETagalogBibleType
{
    tagab,
}

public enum EThaiBibleType
{
    thaikjv,
}

public enum EPortugueseBibleType
{
    almeida_ra,
    almeida_rc,
    blivre,
}

public enum EJapaneseBibleType
{
    bungo,
    kougo,
}

public enum EGermanBibleType
{
    elberfelder_1905,
    luther_1912,
    schlachter,
}

public enum ERomanianBibleType
{
    fidela,
}

public enum EFrenchBibleType
{
    epee,
    oster,
    segond_1910,
}

public enum ESpanishBibleType
{
    rv_1909,
    rvg,
    rvg_2004,
    sagradas,
}

public enum EItalianBibleType
{
    diodati,
}

public enum EHindiBibleType
{
    irv,
}
public enum EHungarianBibleType
{
    karoli,
}

public enum ERussianBibleType
{
    synodal,
}

/// <summary>
/// 영어 성경 6종을 구분하기 위한 열거형
/// </summary>
public enum EEnglishBibleType
{
    NIV,
    ESV,
    NewKJV,
    KJV,
    NewRSV,
}

/// <summary>
/// 구약성서들을 구분하기 위한 열거형.
/// </summary>
public enum EOldTestamentType
{
    None = -1,
    Genesis,
    Exodus,
    Leviticus,
    Numbers,
    Deuteronomy,
    Joshua,
    Judges,
    Ruth,
    Samuel1, 
    Samuel2,
    Kings1,
    Kings2,
    Chronicles1,
    Chronicles2,
    Ezra,
    Nehemiah,
    Esther,
    Job,
    Psalms,
    Proverbs,
    Ecclesiastes,
    SongOfSongs,
    Isaiah,
    Jeremiah,
    Lamentations,
    Ezekiel,
    Daniel,
    Hosea,
    Joel,
    Amos,
    Obadiah,
    Jonah,
    Micah,
    Nahum,
    Habakkuk,
    Zephaniah,
    Haggai,
    Zechariah,
    Malachi,
    Max,
}
/// <summary>
/// 신약성서들을 구분하기 위한 열거형.
/// </summary>
public enum ENewTestamentType
{
    None = -1,
    Matthew,
    Mark,
    Luke,
    John,
    Acts,
    Romans,
    Corinthians1,
    Corinthians2,
    Galatians,
    Ephesians,
    Philippians,
    Colossians,
    Thessalonians1,
    Thessalonians2,
    Timothy1,
    Timothy2,
    Titus,
    Philemon,
    Hebrews,
    James,
    Peter1,
    Peter2,
    John1,
    John2,
    John3,
    Jude,
    Revelation,
    Max,
}

public class BibleStudy : MonoBehaviour
{
    public bool IsDebug = false;

    public UILabel LabelTempTemp;

    /// <summary>
    /// 중국의 경우 2가지로 분기해 주어야 함. 
    /// </summary>
    public bool IsChinessOtherType = false;

    /// <summary>
    /// 영어성경이 메인일지? 한글성경이 메인일지? 
    /// </summary>
    /// <param name="isKorean"></param>
    public void SetLabelKindOfBible(bool isKorean)
    {
        if (isKorean)
        {
            m_LabelKindOfBible.transform.localPosition = new Vector2(-519, 494);
            m_LabelKindOfBibleEnglish.transform.localPosition = new Vector3(-519, 435);
        }
        else
        {
            m_LabelKindOfBible.transform.localPosition = new Vector2(-519, 435);
            m_LabelKindOfBibleEnglish.transform.localPosition = new Vector3(-519, 494);
        }
    }

    /// <summary>
    /// 나라를 구분하기 위한
    /// </summary>
    public ENationType m_NationType = ENationType.None;

    /// <summary>
    /// 현재 있는 모든 성경의 기본 정보
    /// </summary>
    public Dictionary<string, BibleEachInfo> m_BibleEachs = new Dictionary<string, BibleEachInfo>();

    public Dictionary<int, CustomizeInfo> m_Customize = new Dictionary<int, CustomizeInfo>();

    /// <summary>
    /// 현재 있는 모든 성경의 나라를 기준으로 한 기본 정보
    /// </summary>
    public Dictionary<string, BibleNationInfo> m_BibleNations = new Dictionary<string, BibleNationInfo>();
    // public List<BibleEachInfo> BibleTypes = new List<BibleEachInfo>();
    /// <summary>
    /// 각각의 바이블의 종류를 구분하기 위한 
    /// </summary>
    public EBiblePath PathKey = EBiblePath.None;

    /// <summary>
    /// CustomizeLabels[0] = 옵션
    /// CustomizeLabels[1] = 자동읽어주기
    /// CustomizeLabels[2] = 업데이트
    /// CustomizeLabels[3] = 구약찾기
    /// CustomizeLabels[4] = 신약찾기
    /// CustomizeLabels[5] = 폰트사이즈 :
    /// CustomizeLabels[6] = 크게
    /// CustomizeLabels[7] = 중간
    /// CustomizeLabels[8] = 작게
    /// CustomizeLabels[9] = 성경에서 단어 찾기
    /// CustomizeLabels[10] = 구약찾기
    /// CustomizeLabels[11] = 신약찾기
    /// CustomizeLabels[12] = 구약
    /// CustomizeLabels[13] = 신약
    /// CustomizeLabels[14] = 찾을 단어를 입력하세요.
    /// </summary>
    public List<UILabel> CustomizeLabels = new List<UILabel>();



    void SetCustomizeLabels()
    {
        int KeyWord = GetNationCode(m_NationType);

        if (KeyWord == 13)
        {
            if (m_CheckboxReadBibleKorean.value == true) m_LabelChapterInfo.text = "하나님의 말씀 " + VersionInfo; // 버젼을 알려줌. 
            else m_LabelChapterInfo.text = "Word Of God " + VersionInfo;
        }
        else m_LabelChapterInfo.text = "Word Of God " + VersionInfo;

        if (KeyWord == 13)
        {
            if (m_CheckboxReadBibleKorean.value == true) { for (int i = 0; i < CustomizeLabels.Count; i++) CustomizeLabels[i].text = m_Customize[i + 1].m_Korean; }
            else { for (int i = 0; i < CustomizeLabels.Count; i++) CustomizeLabels[i].text = m_Customize[i + 1].m_English; }
        }
        else { for (int i = 0; i < CustomizeLabels.Count; i++) CustomizeLabels[i].text = m_Customize[i + 1].m_English; }
    }

    /// <summary>
    /// 나라별로 로컬라이징을 위한
    /// </summary>
    /// <param name="Type"></param>
    /// <returns></returns>
    public int GetNationCode(ENationType Type)
    {
        return m_BibleNations[Type.ToString()].m_Bible;
    }

    public float GetDelayMiddle(ENationType Type)
    {
        return m_BibleNations[Type.ToString()].m_DelayMiddle;

        if (Type == ENationType.Chinese)
        {
            if (IsChinessOtherType ==false)
                return m_BibleNations[Type.ToString()].m_DelayMiddle;
            else
                return m_BibleNations[Type.ToString()].m_OtherDelayMiddle;
        }
    }

    public float GetDelayEnd(ENationType Type)
    {
         return m_BibleNations[Type.ToString()].m_DelayEnd;

        if (Type == ENationType.Chinese)
        {
            if (IsChinessOtherType == false)
                return m_BibleNations[Type.ToString()].m_DelayEnd;
            else
                return m_BibleNations[Type.ToString()].m_OtherDelayEnd;
        }
    }

    /// <summary>
    /// 폰에서 볼때 글자 크기를 크게 하기 위한.
    /// </summary>
    void SetIsPhone1()
    {
        PlayerPrefs.SetInt(EKeyword.IsPhone.ToString(), 1);
        PlayerPrefs.Save();
    }
    /// <summary>
    /// 탭에서 볼때 글자 크기를 작게 하기 위한.
    /// </summary>
    void SetIsPhone2()
    {
        PlayerPrefs.SetInt(EKeyword.IsPhone.ToString(), 2);
        PlayerPrefs.Save();
    }
    /// <summary>
    /// 탭에서 볼때 글자 크기를 제일 작게 하기 위한.
    /// </summary>
    void SetIsPhone3()
    {
        PlayerPrefs.SetInt(EKeyword.IsPhone.ToString(), 3);
        PlayerPrefs.Save();
    }
    string GetNationVoice(ENationType Type)
    {
        return m_BibleNations[Type.ToString()].m_NationType;
    }

    /// <summary>
    /// 한글성경에서 구약성경에서 찾을지? 신약성경에서 찾을지? 결과값을 저장
    /// </summary>
    string m_KoreanBibleSearchFor;
    /// <summary>
    /// 영문성경에서 구약성경에서 찾을지? 신약성경에서 찾을지? 결과값을 저장
    /// </summary>
    string m_EnglishBibleSearchFor;
    /// <summary>
    /// 현재 선택한 성경중에서 신약성경을 가져올지? 구약성경을 가져올지? 
    /// </summary>
    void SetKoreanBibleInfoSearchFor(EBiblePath Type)
    {
        if (!IsNewTastament) // 만일 선택한 성경이 구약성경이라면? 
            m_KoreanBibleSearchFor = Type.ToString() + "/Old/";
        else if (IsNewTastament) // 만일 선택한 성경이 신약성경이라면? 
            m_KoreanBibleSearchFor = Type.ToString() + "/New/";
    }
    /// <summary>
    /// 현재 선택한 성경중에서 신약성경을 가져올지? 구약성경을 가져올지? 
    /// </summary>
    void SetEnglishBibleInfoSearchFor(EBiblePath Type)
    {
        if (!IsNewTastament) // 만일 선택한 성경이 구약성경이라면? 
            m_EnglishBibleSearchFor = Type.ToString() + "/Old/";
        else if (IsNewTastament) // 만일 선택한 성경이 신약성경이라면? 
            m_EnglishBibleSearchFor = Type.ToString() + "/New/";
    }
    /// <summary>
    /// 현재 선택한 성경중에서 신약성경을 가져올지? 구약성경을 가져올지? 
    /// </summary>
    void SetBibleInfoSearchFor()
    {
        if (m_NationType == ENationType.Korean)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.EasyBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfoSearchFor(EBiblePath.NewStandardTranslation);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) SetKoreanBibleInfoSearchFor(EBiblePath.KoreanBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) SetKoreanBibleInfoSearchFor(EBiblePath.RevisedRevision);
        }
        else if (m_NationType == ENationType.Chinese)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.chinese_union_simp);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfoSearchFor(EBiblePath.chinese_union_trad);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) SetKoreanBibleInfoSearchFor(EBiblePath.ckjv_sds);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) SetKoreanBibleInfoSearchFor(EBiblePath.ckjv_sdt);
        }
        else if (m_NationType == ENationType.Afrikaans)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.afri);
        }
        else if (m_NationType == ENationType.Albanian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.albanian);
        }
        else if (m_NationType == ENationType.Czech)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.bkr);
        }
        else if (m_NationType == ENationType.Vietnamese)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.cadman);
        }
        else if (m_NationType == ENationType.Finnish)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.finn);
        }
        else if (m_NationType == ENationType.Indonesian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.indo_tb);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfoSearchFor(EBiblePath.indo_tm);
        }
        else if (m_NationType == ENationType.Polish)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.pol_nbg);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfoSearchFor(EBiblePath.pol_ubg);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) SetKoreanBibleInfoSearchFor(EBiblePath.polbg);
        }
        else if (m_NationType == ENationType.Tagalog)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.tagab);
        }
        else if (m_NationType == ENationType.Thai)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.thaikjv);
        }
        else if (m_NationType == ENationType.Portuguese)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.almeida_ra);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfoSearchFor(EBiblePath.almeida_rc);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) SetKoreanBibleInfoSearchFor(EBiblePath.blivre);
        }
        else if (m_NationType == ENationType.Japanese)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.bungo);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfoSearchFor(EBiblePath.kougo);
        }
        else if (m_NationType == ENationType.German)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.elberfelder_1905);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfoSearchFor(EBiblePath.luther_1912);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) SetKoreanBibleInfoSearchFor(EBiblePath.schlachter);
        }
        else if (m_NationType == ENationType.Romanian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.fidela);
        }
        else if (m_NationType == ENationType.French)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.epee);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfoSearchFor(EBiblePath.oster);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) SetKoreanBibleInfoSearchFor(EBiblePath.segond_1910);
        }
        else if (m_NationType == ENationType.Spanish)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.rv_1909);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfoSearchFor(EBiblePath.rvg);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) SetKoreanBibleInfoSearchFor(EBiblePath.rvg_2004);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) SetKoreanBibleInfoSearchFor(EBiblePath.sagradas);
        }
        else if (m_NationType == ENationType.Italian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.diodati);
        }
        else if (m_NationType == ENationType.Hindi)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.irv);
        }
        else if (m_NationType == ENationType.Hungarian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.karoli);
        }
        else if (m_NationType == ENationType.Russian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.synodal);
        }
        else 
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfoSearchFor(EBiblePath.EasyBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfoSearchFor(EBiblePath.NewStandardTranslation);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) SetKoreanBibleInfoSearchFor(EBiblePath.KoreanBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) SetKoreanBibleInfoSearchFor(EBiblePath.RevisedRevision);
        }

        if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.NIV) SetEnglishBibleInfoSearchFor(EBiblePath.NIV);
        else if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.ESV) SetEnglishBibleInfoSearchFor(EBiblePath.ESV);
        else if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.NewKJV) SetEnglishBibleInfoSearchFor(EBiblePath.NewKJV);
        else if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.KJV) SetEnglishBibleInfoSearchFor(EBiblePath.KJV);
        else if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.NewRSV) SetEnglishBibleInfoSearchFor(EBiblePath.NewRSV);
    }
    /// <summary>
    /// 현재 선택한 성경중에서 신약성경을 가져올지? 구약성경을 가져올지? 
    /// </summary>
    void SetBibleInfoInit()
    {
        if (m_NationType == ENationType.Korean)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.EasyBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfo(EBiblePath.NewStandardTranslation);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) SetKoreanBibleInfo(EBiblePath.KoreanBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) SetKoreanBibleInfo(EBiblePath.RevisedRevision);
        }
        else if (m_NationType == ENationType.Chinese)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.chinese_union_simp);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfo(EBiblePath.chinese_union_trad);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) SetKoreanBibleInfo(EBiblePath.ckjv_sds);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) SetKoreanBibleInfo(EBiblePath.ckjv_sdt);
        }
        else if (m_NationType == ENationType.Afrikaans)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.afri);
        }
        else if (m_NationType == ENationType.Albanian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.albanian);
        }
        else if (m_NationType == ENationType.Czech)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.bkr);
        }
        else if (m_NationType == ENationType.Vietnamese)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.cadman);
        }
        else if (m_NationType == ENationType.Finnish)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.finn);
        }
        else if (m_NationType == ENationType.Indonesian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.indo_tb);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfo(EBiblePath.indo_tm);
        }
        else if (m_NationType == ENationType.Polish)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.pol_nbg);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfo(EBiblePath.pol_ubg);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) SetKoreanBibleInfo(EBiblePath.polbg);
        }
        else if (m_NationType == ENationType.Tagalog)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.tagab);
        }
        else if (m_NationType == ENationType.Thai)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.thaikjv);
        }
        else if (m_NationType == ENationType.Portuguese)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.almeida_ra);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfo(EBiblePath.almeida_rc);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) SetKoreanBibleInfo(EBiblePath.blivre);
        }
        else if (m_NationType == ENationType.Japanese)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.bungo);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfo(EBiblePath.kougo);
        }
        else if (m_NationType == ENationType.German)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.elberfelder_1905);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfo(EBiblePath.luther_1912);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) SetKoreanBibleInfo(EBiblePath.schlachter);
        }
        else if (m_NationType == ENationType.Romanian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.fidela);
        }
        else if (m_NationType == ENationType.French)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.epee);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfo(EBiblePath.oster);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) SetKoreanBibleInfo(EBiblePath.segond_1910);
        }
        else if (m_NationType == ENationType.Spanish)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.rv_1909);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfo(EBiblePath.rvg);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) SetKoreanBibleInfo(EBiblePath.rvg_2004);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) SetKoreanBibleInfo(EBiblePath.sagradas);
        }
        else if (m_NationType == ENationType.Italian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.diodati);
        }
        else if (m_NationType == ENationType.Hindi)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.irv);
        }
        else if (m_NationType == ENationType.Hungarian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.karoli);
        }
        else if (m_NationType == ENationType.Russian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.synodal);
        }
        else
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) SetKoreanBibleInfo(EBiblePath.EasyBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) SetKoreanBibleInfo(EBiblePath.NewStandardTranslation);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) SetKoreanBibleInfo(EBiblePath.KoreanBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) SetKoreanBibleInfo(EBiblePath.RevisedRevision);
        }

        if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.NIV) SetEnglishBibleInfo(EBiblePath.NIV);
        else if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.ESV) SetEnglishBibleInfo(EBiblePath.ESV);
        else if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.NewKJV) SetEnglishBibleInfo(EBiblePath.NewKJV);
        else if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.KJV) SetEnglishBibleInfo(EBiblePath.KJV);
        else if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.NewRSV) SetEnglishBibleInfo(EBiblePath.NewRSV);
    }

    public void SetCheckBoxInterEach(EBiblePath Path)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
        SetCheckBoxInter(Path);
    }

    public void SetCheckBoxInter(EBiblePath Path)
    {
        if (m_BibleType == EBibleType.OldTestament) // 만일 선택한 성경이 구약성경이라면? 
            m_KoreanBible = Path.ToString() + "/Old/";
        else if (m_BibleType == EBibleType.NewTestament) // 만일 선택한 성경이 신약성경이라면? 
            m_KoreanBible = Path.ToString() + "/New/";

        m_LabelKindOfBible.text = "- " + m_BibleEachs[Path.ToString()].m_Content.TrimEnd() + " (" + m_BibleEachs[Path.ToString()].m_Nation.TrimEnd() + ") -";
        m_KoreanBibleName = Path.ToString();
    }
    /// <summary>
    /// EAfrikaansBibleType
    /// </summary>
    public void SetCheckBox_afri()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.afri;
        SetCheckboxAfrikaansBibleInit(EAfrikaansBibleType.afri);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EAlbanianBibleType
    /// </summary>
    public void SetCheckBox_albanian()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.albanian;
        SetCheckboxAlbanianBibleInit(EAlbanianBibleType.albanian);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EChineseBibleType
    /// </summary>
    public void SetCheckBox_chinese_union_simp()
    {
        IsChinessOtherType = true;
        PathKey = EBiblePath.chinese_union_simp;
        SetCheckboxChineseBibleInit(EChineseBibleType.chinese_union_simp);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EChineseBibleType
    /// </summary>
    public void SetCheckBox_chinese_union_trad()
    {
        IsChinessOtherType = true;
        PathKey = EBiblePath.chinese_union_trad;
        SetCheckboxChineseBibleInit(EChineseBibleType.chinese_union_trad);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EChineseBibleType
    /// </summary>
    public void SetCheckBox_ckjv_sds()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.ckjv_sds;
        SetCheckboxChineseBibleInit(EChineseBibleType.ckjv_sds);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EChineseBibleType
    /// </summary>
    public void SetCheckBox_ckjv_sdt()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.ckjv_sdt;
        SetCheckboxChineseBibleInit(EChineseBibleType.ckjv_sdt);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// ECzechBibleType
    /// </summary>
    public void SetCheckBox_bkr()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.bkr;
        SetCheckboxCzechBibleInit(ECzechBibleType.bkr);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EEnglishBibleType
    /// </summary>
    public void SetCheckBox_NIV()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.NIV;
        SetCheckboxEnglishBibleInit(EEnglishBibleType.NIV);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EEnglishBibleType
    /// </summary>
    public void SetCheckBox_ESV()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.ESV;
        SetCheckboxEnglishBibleInit(EEnglishBibleType.ESV);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EEnglishBibleType
    /// </summary>
    public void SetCheckBox_NewRSV()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.NewRSV;
        SetCheckboxEnglishBibleInit(EEnglishBibleType.NewRSV);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EEnglishBibleType
    /// </summary>
    public void SetCheckBox_KJV()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.KJV;
        SetCheckboxEnglishBibleInit(EEnglishBibleType.KJV);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EEnglishBibleType
    /// </summary>
    public void SetCheckBox_NewKJV()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.NewKJV;
        SetCheckboxEnglishBibleInit(EEnglishBibleType.NewKJV);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EFinnishBibleType
    /// </summary>
    public void SetCheckBox_finn()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.finn;
        SetCheckboxFinnishBibleInit(EFinnishBibleType.finn);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EFrenchBibleType
    /// </summary>
    public void SetCheckBox_epee()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.epee;
        SetCheckboxFrenchBibleInit(EFrenchBibleType.epee);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EFrenchBibleType
    /// </summary>
    public void SetCheckBox_oster()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.oster;
        SetCheckboxFrenchBibleInit(EFrenchBibleType.oster);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EFrenchBibleType
    /// </summary>
    public void SetCheckBox_segond_1910()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.segond_1910;
        SetCheckboxFrenchBibleInit(EFrenchBibleType.segond_1910);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EGermanBibleType
    /// </summary>
    public void SetCheckBox_elberfelder_1905()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.elberfelder_1905;
        SetCheckboxGermanBibleInit(EGermanBibleType.elberfelder_1905);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EGermanBibleType
    /// </summary>
    public void SetCheckBox_luther_1912()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.luther_1912;
        SetCheckboxGermanBibleInit(EGermanBibleType.luther_1912);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EGermanBibleType
    /// </summary>
    public void SetCheckBox_schlachter()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.schlachter;
        SetCheckboxGermanBibleInit(EGermanBibleType.schlachter);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EHindiBibleType
    /// </summary>
    public void SetCheckBox_irv()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.irv;
        SetCheckboxHindiBibleInit(EHindiBibleType.irv);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EHungarianBibleType
    /// </summary>
    public void SetCheckBox_karoli()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.karoli;
        SetCheckboxHungarianBibleInit(EHungarianBibleType.karoli);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EIndonesianBibleType
    /// </summary>
    public void SetCheckBox_indo_tb()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.indo_tb;
        SetCheckboxIndonesianBibleInit(EIndonesianBibleType.indo_tb);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EIndonesianBibleType
    /// </summary>
    public void SetCheckBox_indo_tm()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.indo_tm;
        SetCheckboxIndonesianBibleInit(EIndonesianBibleType.indo_tm);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EItalianBibleType
    /// </summary>
    public void SetCheckBox_diodati()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.diodati;
        SetCheckboxItalianBibleInit(EItalianBibleType.diodati);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EJapaneseBibleType
    /// </summary>
    public void SetCheckBox_bungo()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.bungo;
        SetCheckboxJapaneseBibleInit(EJapaneseBibleType.bungo);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EJapaneseBibleType
    /// </summary>
    public void SetCheckBox_kougo()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.kougo;
        SetCheckboxJapaneseBibleInit(EJapaneseBibleType.kougo);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EKoreanBibleType
    /// </summary>
    public void SetCheckBox_EasyBible()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.EasyBible;
        SetCheckboxKoreanBibleInit(EKoreanBibleType.EasyBible);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EKoreanBibleType
    /// </summary>
    public void SetCheckBox_KoreanBible()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.KoreanBible;
        SetCheckboxKoreanBibleInit(EKoreanBibleType.KoreanBible);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EKoreanBibleType
    /// </summary>
    public void SetCheckBox_NewStandardTranslation()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.NewStandardTranslation;
        SetCheckboxKoreanBibleInit(EKoreanBibleType.NewStandardTranslation);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EKoreanBibleType
    /// </summary>
    public void SetCheckBox_RevisedRevision()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.RevisedRevision;
        SetCheckboxKoreanBibleInit(EKoreanBibleType.RevisedRevision);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EPolishBibleType
    /// </summary>
    public void SetCheckBox_pol_nbg()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.pol_nbg;
        SetCheckboxPolishBibleInit(EPolishBibleType.pol_nbg);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EPolishBibleType
    /// </summary>
    public void SetCheckBox_pol_ubg()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.pol_ubg;
        SetCheckboxPolishBibleInit(EPolishBibleType.pol_ubg);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EPolishBibleType
    /// </summary>
    public void SetCheckBox_polbg()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.polbg;
        SetCheckboxPolishBibleInit(EPolishBibleType.polbg);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EPortugueseBibleType
    /// </summary>
    public void SetCheckBox_almeida_ra()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.almeida_ra;
        SetCheckboxPortugueseBibleInit(EPortugueseBibleType.almeida_ra);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EPortugueseBibleType
    /// </summary>
    public void SetCheckBox_almeida_rc()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.almeida_rc;
        SetCheckboxPortugueseBibleInit(EPortugueseBibleType.almeida_rc);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EPortugueseBibleType
    /// </summary>
    public void SetCheckBox_blivre()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.blivre;
        SetCheckboxPortugueseBibleInit(EPortugueseBibleType.blivre);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// ERomanianBibleType
    /// </summary>
    public void SetCheckBox_fidela()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.fidela;
        SetCheckboxRomanianBibleInit(ERomanianBibleType.fidela);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// ERussianBibleType
    /// </summary>
    public void SetCheckBox_synoda()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.synodal;
        SetCheckboxRussianBibleInit(ERussianBibleType.synodal);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// ESpanishBibleType
    /// </summary>
    public void SetCheckBox_rv_1909()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.rv_1909;
        SetCheckboxSpanishBibleInit(ESpanishBibleType.rv_1909);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// ESpanishBibleType
    /// </summary>
    public void SetCheckBox_rvg()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.rvg;
        SetCheckboxSpanishBibleInit(ESpanishBibleType.rvg);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// ESpanishBibleType
    /// </summary>
    public void SetCheckBox_rvg_2004()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.rvg_2004;
        SetCheckboxSpanishBibleInit(ESpanishBibleType.rvg_2004);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// ESpanishBibleType
    /// </summary>
    public void SetCheckBox_sagradas()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.sagradas;
        SetCheckboxSpanishBibleInit(ESpanishBibleType.sagradas);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// ETagalogBibleType
    /// </summary>
    public void SetCheckBox_tagab()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.tagab;
        SetCheckboxTagalogBibleInit(ETagalogBibleType.tagab);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EThaiBibleType
    /// </summary>
    public void SetCheckBox_thaikjv()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.thaikjv;
        SetCheckboxThaiBibleInit(EThaiBibleType.thaikjv);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// EVietnameseBibleType
    /// </summary>
    public void SetCheckBox_cadman()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.cadman;
        SetCheckboxVietnameseBibleInit(EVietnameseBibleType.cadman);
        SetKoreanBibleInfo(PathKey);
    }

    public List<UIToggle> TogglesChinese = new List<UIToggle>();
    public List<UIToggle> TogglesAfrikaans = new List<UIToggle>();
    public List<UIToggle> TogglesAlbanian = new List<UIToggle>();
    public List<UIToggle> TogglesCzech = new List<UIToggle>();
    public List<UIToggle> TogglesVietnamese = new List<UIToggle>();
    public List<UIToggle> TogglesFinnish = new List<UIToggle>();
    public List<UIToggle> TogglesIndonesian = new List<UIToggle>();
    public List<UIToggle> TogglesPolish = new List<UIToggle>();
    public List<UIToggle> TogglesTagalog = new List<UIToggle>();
    public List<UIToggle> TogglesThai = new List<UIToggle>();
    public List<UIToggle> TogglesPortuguese = new List<UIToggle>();
    public List<UIToggle> TogglesJapanese = new List<UIToggle>();
    public List<UIToggle> TogglesGerman = new List<UIToggle>();
    public List<UIToggle> TogglesRomanian = new List<UIToggle>();
    public List<UIToggle> TogglesFrench = new List<UIToggle>();
    public List<UIToggle> TogglesSpanish = new List<UIToggle>();
    public List<UIToggle> TogglesItalian = new List<UIToggle>();
    public List<UIToggle> TogglesHindi = new List<UIToggle>();
    public List<UIToggle> TogglesHungarian = new List<UIToggle>();
    public List<UIToggle> TogglesRussian = new List<UIToggle>();

    public GameObject TogglesGameObjectKorean;
    public GameObject TogglesGameObjectChinese;
    public GameObject TogglesGameObjectAfrikaans;
    public GameObject TogglesGameObjectAlbanian;
    public GameObject TogglesGameObjectCzech;
    public GameObject TogglesGameObjectVietnamese;
    public GameObject TogglesGameObjectFinnish;
    public GameObject TogglesGameObjectIndonesian;
    public GameObject TogglesGameObjectPolish;
    public GameObject TogglesGameObjectTagalog;
    public GameObject TogglesGameObjectThai;
    public GameObject TogglesGameObjectPortuguese;
    public GameObject TogglesGameObjectJapanese;
    public GameObject TogglesGameObjectGerman;
    public GameObject TogglesGameObjectRomanian;
    public GameObject TogglesGameObjectFrench;
    public GameObject TogglesGameObjectSpanish;
    public GameObject TogglesGameObjectItalian;
    public GameObject TogglesGameObjectHindi;
    public GameObject TogglesGameObjectHungarian;
    public GameObject TogglesGameObjectRussian;

    /// <summary>
    /// 한글 성경들을 구분하기 위한 토글들을 모아놓은 리스트. 
    /// </summary>
    public List<UIToggle> TogglesKorean = new List<UIToggle>();
    /// <summary>
    /// 영어 성경들을 구분하기 위한 토글들을 모아놓은 리스트. 
    /// </summary>
    public List<UIToggle> TogglesEnglish = new List<UIToggle>();

    /// <summary>
    /// 1189개의 문서중에 쉬운 성경에 해당하는 문서가 있는 위치
    /// </summary>
    public string selectedKoreanEasyBible = string.Empty;
    public string selectedKoreanKoreanBible = string.Empty;
    public string selectedKoreanNewStandardTranslation = string.Empty;
    public string selectedKoreanRevisedRevision = string.Empty;
    public string selectedEnglishNIV = string.Empty;
    public string selectedEnglishESV = string.Empty;
    public string selectedEnglishNewRSV = string.Empty;
    public string selectedEnglishNewKJV = string.Empty;
    public string selectedEnglishKJV = string.Empty;
    /// <summary>
    /// 1189개의 문서중에 쉬운 성경에 해당하는 문서의 내용을 배열에 저장
    /// </summary>
    public List<string> collectKoreanEasyBible = new List<string>();
    public List<string> collectKoreanKoreanBible = new List<string>();
    public List<string> collectKoreanNewStandardTranslation = new List<string>();
    public List<string> collectKoreanRevisedRevision = new List<string>();
    public List<string> collectEnglishNIV = new List<string>();
    public List<string> collectEnglishESV = new List<string>();
    public List<string> collectEnglishNewRSV = new List<string>();
    public List<string> collectEnglishNewKJV = new List<string>();
    public List<string> collectEnglishKJV = new List<string>();
    /// <summary>
    /// 1189개의 문서중에 쉬운 성경에 해당하는 문서의 정보를 저장
    /// </summary>
    public string BibleMessageEasyBible;
    public string BibleMessageKoreanBible;
    public string BibleMessageNewStandardTranslation;
    public string BibleMessageRevisedRevision;
    public string BibleMessageNIV;
    public string BibleMessageESV;
    public string BibleMessageNewRSV;
    public string BibleMessageNewKJV;
    public string BibleMessageKJV;


    private static BibleStudy m_Instance = null;
    public static BibleStudy Get { get { return m_Instance; } set { m_Instance = value; } }
    private void Awake()
    {
        m_Instance = this;

        m_ScrollBarPanelManValue = PlayerPrefsGetFloatm_ScrollBarPanelMan(); // 성경문장의 스크롤바를 움직였을 때의 값을 가져옴. 이전에 읽었던 위치를 표시하기 위한.
        SetRandomBackground(); // 배경 이미지를 랜덤으로 변경해 줍니다.
        SetBackgroundImagesHalf();
    }

    string VersionInfo = string.Empty;
    

    private void Start()
    {
        VersionInfo = "v3.7";

        IsDebug = false;

        IsChinessOtherType = false; // 중국의 경우 2가지로 분기해 주어야 함. 

        m_BibleEachs = BibleEachTable.GetAll(); // 45가지의 하나님의 말씀 정보
        m_BibleNations = BibleNationTable.GetAll(); // 45가지의 하나님의 말씀 정보중에서 나라를 기준으로 한 기본 정보
        m_Customize = CustomizeTable.GetAll();

        int KeyWord = GetNationCode(m_NationType); //  나라를 구분하기 위한. 
        SetCustomizeLabels(); // UI 커스터마이징

        CanSoundPlay = true; // 최초에 사운드가 플레이 되도록 함. 

        readBibleIndex = -1;
        readBibleSentencesIndex = -1;
        ReadBibleMessageIndex = -1; // 사용하지 않음. 

        m_CheckboxReadBible.Set(false); // CheckboxReadBible토글이 최초에는 실행되지 않도록 함. 처음부터 바이블을 읽을 수 없음.
        m_CheckboxReadBible.enabled = false;

        if (PlayerPrefs.GetInt(EKeyword.IsCheckboxReadBibleKorean.ToString()) == 0) m_CheckboxReadBibleKorean.value = true; // 영어로 시작할지? 한글로 시작할지?       
        else if (PlayerPrefs.GetInt(EKeyword.IsCheckboxReadBibleKorean.ToString()) == 1) m_CheckboxReadBibleKorean.value = false;

        SetLabelKindOfBible(m_CheckboxReadBibleKorean.value); // 영어성경과 한글성경의 레이블 위치, 누가 메인인지? 

        SetFontSize(labelBible);

        if (PlayerPrefs.GetInt(EKeyword.IsPhone.ToString()) == 1) SetCheckBoxPhoneTab(true, false, false); // 폰트 사이즈 체크박스들 조절
        else if (PlayerPrefs.GetInt(EKeyword.IsPhone.ToString()) == 2) SetCheckBoxPhoneTab(false, true, false);
        else if (PlayerPrefs.GetInt(EKeyword.IsPhone.ToString()) == 3) SetCheckBoxPhoneTab(false, false, true);       

        if (string.IsNullOrEmpty(PlayerPrefs.GetString(EKeyword.m_BibleType.ToString()))) // 최초라서 만일 바이블을 선택하지 않았다면? 구약성서의 창세기를 선택
        {                   
            OldTestamentInfo bibleOld = new OldTestamentInfo(); // 엑셀테이블에서 구약성서의 정보를 가져옴.
            m_BibleType = EBibleType.OldTestament; // 구약성서를 선택.
            PlayerPrefs.SetString(EKeyword.m_BibleType.ToString(), m_BibleType.ToString()); // 구약성서를 선택한 것을 메모리에 저장.
            m_OldTestamentType = EOldTestamentType.Genesis; // 창세기를 선택
            PlayerPrefs.SetString(EKeyword.m_OldTestamentType.ToString(), m_OldTestamentType.ToString()); // 창세기를 선택했다고 메모리에 저장.
            bibleOld = OldTestamentTable.GetByIndex((int)m_OldTestamentType); // 창세기를 가져옴.
            m_MaxChapter = bibleOld.m_Count; // 창세기의 마지막 장을 가져옴.
            PlayerPrefs.SetInt(EKeyword.m_Chapter.ToString(), 1); // 1장이라고 메모리에 저장
            PlayerPrefs.SetInt(EKeyword.m_MaxChapter.ToString(), m_MaxChapter); // 마지막 장을 메모리에 저장
        }   

        SetPanelAlpla(1, 0, 0); // PanelMain을 보여줍니다. 

        if (!string.IsNullOrEmpty(PlayerPrefs.GetString(EKeyword.m_BibleType.ToString()))) // 만일 신약성경이나 구약성경을 이미 선택했다면? 
        {
            m_BibleType = (EBibleType)System.Enum.Parse(typeof(EBibleType), PlayerPrefs.GetString(EKeyword.m_BibleType.ToString())); // 선택한 성경타입을 가져옴

            if (m_BibleType == EBibleType.OldTestament) // 만일 선택한 성경이 구약성경이라면? 
            {
                m_OldTestamentType = (EOldTestamentType)System.Enum.Parse(typeof(EOldTestamentType), PlayerPrefs.GetString(EKeyword.m_OldTestamentType.ToString())); // 구약성경중 선택한 성경을 가져옴
                m_Chapter = PlayerPrefs.GetInt(EKeyword.m_Chapter.ToString()); // 선택한 성경의 챕터를 가져옴
                m_MaxChapter = PlayerPrefs.GetInt(EKeyword.m_MaxChapter.ToString()); // 선택한 성경의 맥스챕터를 가져옴.
            }
            else if (m_BibleType == EBibleType.NewTestament) // 만일 선택한 성경이 신약성경이라면? 
            {
                m_NewTestamentType = (ENewTestamentType)System.Enum.Parse(typeof(ENewTestamentType), PlayerPrefs.GetString(EKeyword.m_NewTestamentType.ToString())); // 신약성경중 선택한 성경을 가져옴.
                m_Chapter = PlayerPrefs.GetInt(EKeyword.m_Chapter.ToString()); // 선택한 성경의 챕터를 가져옴
                m_MaxChapter = PlayerPrefs.GetInt(EKeyword.m_MaxChapter.ToString()); // 선택한 성경의 맥스챕터를 가져옴.
            }

            SetBibleInfoInit();

            CheckTooglesInit(); // 나라별 체크박스 초기화. 

            if (m_NationType == ENationType.Korean)
            {
                IsChinessOtherType = false;
                TogglesGameObjectKorean.SetActive(true);
                // 한글 성경들을 선택해 주는 체크박스들 조절
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckKoreanBible(EKoreanBibleType.EasyBible);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) CheckKoreanBible(EKoreanBibleType.NewStandardTranslation);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) CheckKoreanBible(EKoreanBibleType.KoreanBible);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) CheckKoreanBible(EKoreanBibleType.RevisedRevision);
            }
            else if (m_NationType == ENationType.Chinese)
            {
                IsChinessOtherType = false;
                TogglesGameObjectChinese.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible)
                {
                    IsChinessOtherType = true;
                    CheckChineseBible(EKoreanBibleType.EasyBible);
                }
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation)
                {
                    IsChinessOtherType = true;
                    CheckChineseBible(EKoreanBibleType.NewStandardTranslation);
                }
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) CheckChineseBible(EKoreanBibleType.KoreanBible);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) CheckChineseBible(EKoreanBibleType.RevisedRevision);
            }
            else if (m_NationType == ENationType.Afrikaans)
            {
                IsChinessOtherType = false;
                TogglesGameObjectAfrikaans.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckAfrikaansBible(EKoreanBibleType.EasyBible);
            }
            else if (m_NationType == ENationType.Albanian)
            {
                IsChinessOtherType = false;
                TogglesGameObjectAlbanian.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckAlbanianBible(EKoreanBibleType.EasyBible);
            }
            else if (m_NationType == ENationType.Czech)
            {
                IsChinessOtherType = false;
                TogglesGameObjectCzech.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckCzechBible(EKoreanBibleType.EasyBible);
            }
            else if (m_NationType == ENationType.Vietnamese)
            {
                IsChinessOtherType = false;
                TogglesGameObjectVietnamese.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckVietnameseBible(EKoreanBibleType.EasyBible);
            }
            else if (m_NationType == ENationType.Finnish)
            {
                IsChinessOtherType = false;
                TogglesGameObjectFinnish.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckFinnishBible(EKoreanBibleType.EasyBible);
            }
            else if (m_NationType == ENationType.Indonesian)
            {
                IsChinessOtherType = false;
                TogglesGameObjectIndonesian.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckIndonesianBible(EKoreanBibleType.EasyBible);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) CheckIndonesianBible(EKoreanBibleType.NewStandardTranslation);
            }
            else if (m_NationType == ENationType.Polish)
            {
                IsChinessOtherType = false;
                TogglesGameObjectPolish.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckPolishBible(EKoreanBibleType.EasyBible);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) CheckPolishBible(EKoreanBibleType.NewStandardTranslation);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) CheckPolishBible(EKoreanBibleType.KoreanBible);
            }
            else if (m_NationType == ENationType.Tagalog)
            {
                IsChinessOtherType = false;
                TogglesGameObjectTagalog.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckTagalogBible(EKoreanBibleType.EasyBible);
            }
            else if (m_NationType == ENationType.Thai)
            {
                IsChinessOtherType = false;
                TogglesGameObjectThai.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckThaiBible(EKoreanBibleType.EasyBible);
            }
            else if (m_NationType == ENationType.Portuguese)
            {
                IsChinessOtherType = false;
                TogglesGameObjectPortuguese.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckPortugueseBible(EKoreanBibleType.EasyBible);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) CheckPortugueseBible(EKoreanBibleType.NewStandardTranslation);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) CheckPortugueseBible(EKoreanBibleType.KoreanBible);
            }
            else if (m_NationType == ENationType.Japanese)
            {
                IsChinessOtherType = false;
                TogglesGameObjectJapanese.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckJapaneseBible(EKoreanBibleType.EasyBible);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) CheckJapaneseBible(EKoreanBibleType.NewStandardTranslation);
            }
            else if (m_NationType == ENationType.German)
            {
                IsChinessOtherType = false;
                TogglesGameObjectGerman.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckGermanBible(EKoreanBibleType.EasyBible);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) CheckGermanBible(EKoreanBibleType.NewStandardTranslation);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) CheckGermanBible(EKoreanBibleType.KoreanBible);
            }
            else if (m_NationType == ENationType.Romanian)
            {
                IsChinessOtherType = false;
                TogglesGameObjectRomanian.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckRomanianBible(EKoreanBibleType.EasyBible);
            }
            else if (m_NationType == ENationType.French)
            {
                IsChinessOtherType = false;
                TogglesGameObjectFrench.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckFrenchBible(EKoreanBibleType.EasyBible);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) CheckFrenchBible(EKoreanBibleType.NewStandardTranslation);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) CheckFrenchBible(EKoreanBibleType.KoreanBible);
            }
            else if (m_NationType == ENationType.Spanish)
            {
                IsChinessOtherType = false;
                TogglesGameObjectSpanish.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckSpanishBible(EKoreanBibleType.EasyBible);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) CheckSpanishBible(EKoreanBibleType.NewStandardTranslation);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) CheckSpanishBible(EKoreanBibleType.KoreanBible);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) CheckSpanishBible(EKoreanBibleType.RevisedRevision);
            }
            else if (m_NationType == ENationType.Italian)
            {
                IsChinessOtherType = false;
                TogglesGameObjectItalian.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckItalianBible(EKoreanBibleType.EasyBible);
            }
            else if (m_NationType == ENationType.Hindi)
            {
                IsChinessOtherType = false;
                TogglesGameObjectHindi.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckHindiBible(EKoreanBibleType.EasyBible);
            }
            else if (m_NationType == ENationType.Hungarian)
            {
                IsChinessOtherType = false;
                TogglesGameObjectHungarian.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckHungarianBible(EKoreanBibleType.EasyBible);
            }
            else if (m_NationType == ENationType.Russian)
            {
                IsChinessOtherType = false;
                TogglesGameObjectRussian.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckRussianBible(EKoreanBibleType.EasyBible);
            }
            else
            {
                IsChinessOtherType = false;
                TogglesGameObjectKorean.SetActive(true);
                if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckKoreanBible(EKoreanBibleType.EasyBible);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) CheckKoreanBible(EKoreanBibleType.NewStandardTranslation);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) CheckKoreanBible(EKoreanBibleType.KoreanBible);
                else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) CheckKoreanBible(EKoreanBibleType.RevisedRevision);
            }

            // 영어 성경들을 선택해 주는 체크박스들 조절
            if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.NIV) CheckEnglishBible(EEnglishBibleType.NIV);
            else if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.ESV) CheckEnglishBible(EEnglishBibleType.ESV);
            else if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.NewKJV) CheckEnglishBible(EEnglishBibleType.NewKJV);
            else if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.KJV) CheckEnglishBible(EEnglishBibleType.KJV);
            else if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.NewRSV) CheckEnglishBible(EEnglishBibleType.NewRSV);

            ShowBible(); // 선택한 성경의 내용을 보여줌.
            TestimonyInfos.Clear();
            TestimonyInfos = TestimonyTable.GetAllList(); // Youtube에 성경 관련 동영상 모음
            WiseSayingInfos.Clear();
            WiseSayingInfos = WiseSayingTable.GetAllList(); // 로컬라이징 관련

            if (m_CheckboxReadBibleKorean.value == true)
            {
                if (KeyWord == 13) LabelWiseSaying.text = WiseSayingInfos[0].m_Korean;
                else LabelWiseSaying.text = WiseSayingInfos[0].m_English;
            }
            else LabelWiseSaying.text = WiseSayingInfos[0].m_English;
        }
    }

    void Startinit()
    {
        CheckTooglesInit(); // 나라별 체크박스 초기화. 

        if (m_NationType == ENationType.Korean)
        {
            TogglesGameObjectKorean.SetActive(true);
            // 한글 성경들을 선택해 주는 체크박스들 조절
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckKoreanBible(EKoreanBibleType.EasyBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) CheckKoreanBible(EKoreanBibleType.NewStandardTranslation);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) CheckKoreanBible(EKoreanBibleType.KoreanBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) CheckKoreanBible(EKoreanBibleType.RevisedRevision);
        }
        else if (m_NationType == ENationType.Chinese)
        {
            TogglesGameObjectChinese.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckChineseBible(EKoreanBibleType.EasyBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) CheckChineseBible(EKoreanBibleType.NewStandardTranslation);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) CheckChineseBible(EKoreanBibleType.KoreanBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) CheckChineseBible(EKoreanBibleType.RevisedRevision);
        }
        else if (m_NationType == ENationType.Afrikaans)
        {
            TogglesGameObjectAfrikaans.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckAfrikaansBible(EKoreanBibleType.EasyBible);
        }
        else if (m_NationType == ENationType.Albanian)
        {
            TogglesGameObjectAlbanian.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckAlbanianBible(EKoreanBibleType.EasyBible);
        }
        else if (m_NationType == ENationType.Czech)
        {
            TogglesGameObjectCzech.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckCzechBible(EKoreanBibleType.EasyBible);
        }
        else if (m_NationType == ENationType.Vietnamese)
        {
            TogglesGameObjectVietnamese.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckVietnameseBible(EKoreanBibleType.EasyBible);
        }
        else if (m_NationType == ENationType.Finnish)
        {
            TogglesGameObjectFinnish.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckFinnishBible(EKoreanBibleType.EasyBible);
        }
        else if (m_NationType == ENationType.Indonesian)
        {
            TogglesGameObjectIndonesian.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckIndonesianBible(EKoreanBibleType.EasyBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) CheckIndonesianBible(EKoreanBibleType.NewStandardTranslation);
        }
        else if (m_NationType == ENationType.Polish)
        {
            TogglesGameObjectPolish.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckPolishBible(EKoreanBibleType.EasyBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) CheckPolishBible(EKoreanBibleType.NewStandardTranslation);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) CheckPolishBible(EKoreanBibleType.KoreanBible);
        }
        else if (m_NationType == ENationType.Tagalog)
        {
            TogglesGameObjectTagalog.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckTagalogBible(EKoreanBibleType.EasyBible);
        }
        else if (m_NationType == ENationType.Thai)
        {
            TogglesGameObjectThai.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckThaiBible(EKoreanBibleType.EasyBible);
        }
        else if (m_NationType == ENationType.Portuguese)
        {
            TogglesGameObjectPortuguese.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckPortugueseBible(EKoreanBibleType.EasyBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) CheckPortugueseBible(EKoreanBibleType.NewStandardTranslation);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) CheckPortugueseBible(EKoreanBibleType.KoreanBible);
        }
        else if (m_NationType == ENationType.Japanese)
        {
            TogglesGameObjectJapanese.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckJapaneseBible(EKoreanBibleType.EasyBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) CheckJapaneseBible(EKoreanBibleType.NewStandardTranslation);
        }
        else if (m_NationType == ENationType.German)
        {
            TogglesGameObjectGerman.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckGermanBible(EKoreanBibleType.EasyBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) CheckGermanBible(EKoreanBibleType.NewStandardTranslation);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) CheckGermanBible(EKoreanBibleType.KoreanBible);
        }
        else if (m_NationType == ENationType.Romanian)
        {
            TogglesGameObjectRomanian.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckRomanianBible(EKoreanBibleType.EasyBible);
        }
        else if (m_NationType == ENationType.French)
        {
            TogglesGameObjectFrench.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckFrenchBible(EKoreanBibleType.EasyBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) CheckFrenchBible(EKoreanBibleType.NewStandardTranslation);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) CheckFrenchBible(EKoreanBibleType.KoreanBible);
        }
        else if (m_NationType == ENationType.Spanish)
        {
            TogglesGameObjectSpanish.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckSpanishBible(EKoreanBibleType.EasyBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) CheckSpanishBible(EKoreanBibleType.NewStandardTranslation);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) CheckSpanishBible(EKoreanBibleType.KoreanBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) CheckSpanishBible(EKoreanBibleType.RevisedRevision);
        }
        else if (m_NationType == ENationType.Italian)
        {
            TogglesGameObjectItalian.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckItalianBible(EKoreanBibleType.EasyBible);
        }
        else if (m_NationType == ENationType.Hindi)
        {
            TogglesGameObjectHindi.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckHindiBible(EKoreanBibleType.EasyBible);
        }
        else if (m_NationType == ENationType.Hungarian)
        {
            TogglesGameObjectHungarian.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckHungarianBible(EKoreanBibleType.EasyBible);
        }
        else if (m_NationType == ENationType.Russian)
        {
            TogglesGameObjectRussian.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckRussianBible(EKoreanBibleType.EasyBible);
        }
        else
        {
            TogglesGameObjectKorean.SetActive(true);
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) CheckKoreanBible(EKoreanBibleType.EasyBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) CheckKoreanBible(EKoreanBibleType.NewStandardTranslation);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) CheckKoreanBible(EKoreanBibleType.KoreanBible);
            else if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) CheckKoreanBible(EKoreanBibleType.RevisedRevision);
        }

        SetCustomizeLabels(); // UI 커스터마이징
    }

    void SetCheckboxKoreanBibleInit(EKoreanBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxChineseBibleInit(EChineseBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxAfrikaansBibleInit(EAfrikaansBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxAlbanianBibleInit(EAlbanianBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxCzechBibleInit(ECzechBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxVietnameseBibleInit(EVietnameseBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxFinnishBibleInit(EFinnishBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxIndonesianBibleInit(EIndonesianBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxPolishBibleInit(EPolishBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxTagalogBibleInit(ETagalogBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxThaiBibleInit(EThaiBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxPortugueseBibleInit(EPortugueseBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxJapaneseBibleInit(EJapaneseBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxGermanBibleInit(EGermanBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxRomanianBibleInit(ERomanianBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxFrenchBibleInit(EFrenchBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxSpanishBibleInit(ESpanishBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxItalianBibleInit(EItalianBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxHindiBibleInit(EHindiBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxHungarianBibleInit(EHungarianBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxRussianBibleInit(ERussianBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldKoreanBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    void SetCheckboxEnglishBibleInit(EEnglishBibleType Type)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤, 옵션창을 끄면 바이블을 읽어줌
        PlayerPrefsSetIntOldEnglishBible((int)Type);
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        PlayerPrefs.Save();
    }

    /// <summary>
    /// 현재 선택한 성경중에서 신약성경을 가져올지? 구약성경을 가져올지? 
    /// </summary>
    void SetKoreanBibleInfo(EBiblePath Path)
    {
        if (m_BibleType == EBibleType.OldTestament) // 만일 선택한 성경이 구약성경이라면? 
            m_KoreanBible = Path.ToString() + "/Old/";
        else if (m_BibleType == EBibleType.NewTestament) // 만일 선택한 성경이 신약성경이라면? 
            m_KoreanBible = Path.ToString() + "/New/";
        
        m_LabelKindOfBible.text = m_BibleEachs[Path.ToString()].m_Content.TrimEnd();
        m_KoreanBibleName = m_BibleEachs[Path.ToString()].m_Content.TrimEnd();
        Debug.Log(string.Empty);
    }
    /// <summary>
    /// 현재 선택한 성경중에서 신약성경을 가져올지? 구약성경을 가져올지? 
    /// </summary>
    void SetEnglishBibleInfo(EBiblePath Path)
    {
        if (m_BibleType == EBibleType.OldTestament) // 만일 선택한 성경이 구약성경이라면? 
            m_EnglishBible = Path.ToString() + "/Old/";
        else if (m_BibleType == EBibleType.NewTestament) // 만일 선택한 성경이 신약성경이라면? 
            m_EnglishBible = Path.ToString() + "/New/";

        m_LabelKindOfBibleEnglish.text = m_BibleEachs[Path.ToString()].m_Content.TrimEnd();
        m_EnglishBibleName = m_BibleEachs[Path.ToString()].m_Content.TrimEnd();
    }
    /// <summary>
    /// 
    /// </summary>
    public void SetCheckboxEasyBible()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.EasyBible;
        SetCheckboxKoreanBibleInit(EKoreanBibleType.EasyBible);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// 
    /// </summary>
    public void SetCheckboxStandardNewTranslation()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.NewStandardTranslation;
        SetCheckboxKoreanBibleInit(EKoreanBibleType.NewStandardTranslation);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// 
    /// </summary>
    public void SetCheckboxKoreanBible()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.KoreanBible;
        SetCheckboxKoreanBibleInit(EKoreanBibleType.KoreanBible);
        SetKoreanBibleInfo(PathKey);
    }
    /// <summary>
    /// 
    /// </summary>
    public void SetCheckboxRevisedRevision()
    {
        IsChinessOtherType = false;
        PathKey = EBiblePath.RevisedRevision;
        SetCheckboxKoreanBibleInit(EKoreanBibleType.RevisedRevision);
        SetKoreanBibleInfo(PathKey);
    }
    
    /// <summary>
    /// 영어 성경은 NIV성경으로 설정합니다. 
    /// </summary>
    public void SetCheckboxNIV()
    {
        SetCheckboxEnglishBibleInit(EEnglishBibleType.NIV);
        SetEnglishBibleInfo(EBiblePath.NIV);
    }
    /// <summary>
    /// 영어 성경은 KJV성경으로 설정합니다. 
    /// </summary>
    public void SetCheckboxKJV()
    {
        SetCheckboxEnglishBibleInit(EEnglishBibleType.KJV);
        SetEnglishBibleInfo(EBiblePath.KJV);
    }
    /// <summary>
    /// 영어 성경은 NKJV성경으로 설정합니다. 
    /// </summary>
    public void SetCheckboxNKJV()
    {
        SetCheckboxEnglishBibleInit(EEnglishBibleType.NewKJV);
        SetEnglishBibleInfo(EBiblePath.NewKJV);
    }
    /// <summary>
    /// 영어 성경은 ESV성경으로 설정합니다. 
    /// </summary>
    public void SetCheckboxESV()
    {
        SetCheckboxEnglishBibleInit(EEnglishBibleType.ESV);
        SetEnglishBibleInfo(EBiblePath.ESV);
    }
    /// <summary>
    /// 영어 성경은 NRSV성경으로 설정합니다. 
    /// </summary>
    public void SetCheckboxNRSV()
    {
        SetCheckboxEnglishBibleInit(EEnglishBibleType.NewRSV);
        SetEnglishBibleInfo(EBiblePath.NewRSV);
    }

    void CheckTooglesInit()
    {
        TogglesGameObjectKorean.SetActive(false);
        TogglesGameObjectChinese.SetActive(false);
        TogglesGameObjectAfrikaans.SetActive(false);
        TogglesGameObjectAlbanian.SetActive(false);
        TogglesGameObjectCzech.SetActive(false);
        TogglesGameObjectVietnamese.SetActive(false);
        TogglesGameObjectFinnish.SetActive(false);
        TogglesGameObjectIndonesian.SetActive(false);
        TogglesGameObjectPolish.SetActive(false);
        TogglesGameObjectTagalog.SetActive(false);
        TogglesGameObjectThai.SetActive(false);
        TogglesGameObjectPortuguese.SetActive(false);
        TogglesGameObjectJapanese.SetActive(false);
        TogglesGameObjectGerman.SetActive(false);
        TogglesGameObjectRomanian.SetActive(false);
        TogglesGameObjectFrench.SetActive(false);
        TogglesGameObjectSpanish.SetActive(false);
        TogglesGameObjectItalian.SetActive(false);
        TogglesGameObjectHindi.SetActive(false);
        TogglesGameObjectHungarian.SetActive(false);
        TogglesGameObjectRussian.SetActive(false);
    }

    void CheckChineseBible(EKoreanBibleType Type)
    {
        TogglesGameObjectChinese.SetActive(true);

        for (int i = 0; i < TogglesChinese.Count; i++) TogglesChinese[i].value = false;

        TogglesChinese[(int)Type].value = true;
    }

    void CheckAfrikaansBible(EKoreanBibleType Type)
    {
        TogglesGameObjectAfrikaans.SetActive(true);

        for (int i = 0; i < TogglesAfrikaans.Count; i++) TogglesAfrikaans[i].value = false;

        TogglesAfrikaans[(int)Type].value = true;
    }

    void CheckAlbanianBible(EKoreanBibleType Type)
    {
        TogglesGameObjectAlbanian.SetActive(true);

        for (int i = 0; i < TogglesAlbanian.Count; i++) TogglesAlbanian[i].value = false;

        TogglesAlbanian[(int)Type].value = true;
    }

    void CheckCzechBible(EKoreanBibleType Type)
    {
        TogglesGameObjectCzech.SetActive(true);

        for (int i = 0; i < TogglesCzech.Count; i++) TogglesCzech[i].value = false;

        TogglesCzech[(int)Type].value = true;
    }

    void CheckVietnameseBible(EKoreanBibleType Type)
    {
        TogglesGameObjectVietnamese.SetActive(true);

        for (int i = 0; i < TogglesVietnamese.Count; i++) TogglesVietnamese[i].value = false;

        TogglesVietnamese[(int)Type].value = true;
    }

    void CheckFinnishBible(EKoreanBibleType Type)
    {
        TogglesGameObjectFinnish.SetActive(true);

        for (int i = 0; i < TogglesFinnish.Count; i++) TogglesFinnish[i].value = false;

        TogglesFinnish[(int)Type].value = true;
    }

    void CheckIndonesianBible(EKoreanBibleType Type)
    {
        TogglesGameObjectIndonesian.SetActive(true);

        for (int i = 0; i < TogglesIndonesian.Count; i++) TogglesIndonesian[i].value = false;

        TogglesIndonesian[(int)Type].value = true;
    }

    void CheckPolishBible(EKoreanBibleType Type)
    {
        TogglesGameObjectPolish.SetActive(true);

        for (int i = 0; i < TogglesPolish.Count; i++) TogglesPolish[i].value = false;

        TogglesPolish[(int)Type].value = true;
    }

    void CheckTagalogBible(EKoreanBibleType Type)
    {
        TogglesGameObjectTagalog.SetActive(true);

        for (int i = 0; i < TogglesTagalog.Count; i++) TogglesTagalog[i].value = false;

        TogglesTagalog[(int)Type].value = true;
    }

    void CheckThaiBible(EKoreanBibleType Type)
    {
        TogglesGameObjectThai.SetActive(true);

        for (int i = 0; i < TogglesThai.Count; i++) TogglesThai[i].value = false;

        TogglesThai[(int)Type].value = true;
    }

    void CheckPortugueseBible(EKoreanBibleType Type)
    {
        TogglesGameObjectPortuguese.SetActive(true);

        for (int i = 0; i < TogglesPortuguese.Count; i++) TogglesPortuguese[i].value = false;

        TogglesPortuguese[(int)Type].value = true;
    }

    void CheckJapaneseBible(EKoreanBibleType Type)
    {
        TogglesGameObjectJapanese.SetActive(true);

        for (int i = 0; i < TogglesJapanese.Count; i++) TogglesJapanese[i].value = false;

        TogglesJapanese[(int)Type].value = true;
    }

    void CheckGermanBible(EKoreanBibleType Type)
    {
        TogglesGameObjectGerman.SetActive(true);

        for (int i = 0; i < TogglesGerman.Count; i++) TogglesGerman[i].value = false;

        TogglesGerman[(int)Type].value = true;
    }

    void CheckRomanianBible(EKoreanBibleType Type)
    {
        TogglesGameObjectRomanian.SetActive(true);

        for (int i = 0; i < TogglesRomanian.Count; i++) TogglesRomanian[i].value = false;

        TogglesRomanian[(int)Type].value = true;
    }

    void CheckFrenchBible(EKoreanBibleType Type)
    {
        TogglesGameObjectFrench.SetActive(true);

        for (int i = 0; i < TogglesFrench.Count; i++) TogglesFrench[i].value = false;

        TogglesFrench[(int)Type].value = true;
    }

    void CheckSpanishBible(EKoreanBibleType Type)
    {
        TogglesGameObjectSpanish.SetActive(true);

        for (int i = 0; i < TogglesSpanish.Count; i++) TogglesSpanish[i].value = false;

        TogglesSpanish[(int)Type].value = true;
    }

    void CheckItalianBible(EKoreanBibleType Type)
    {
        TogglesGameObjectItalian.SetActive(true);

        for (int i = 0; i < TogglesItalian.Count; i++) TogglesItalian[i].value = false;

        TogglesItalian[(int)Type].value = true;
    }

    void CheckHindiBible(EKoreanBibleType Type)
    {
        TogglesGameObjectHindi.SetActive(true);

        for (int i = 0; i < TogglesHindi.Count; i++) TogglesHindi[i].value = false;

        TogglesHindi[(int)Type].value = true;
    }

    void CheckHungarianBible(EKoreanBibleType Type)
    {
        TogglesGameObjectHungarian.SetActive(true);

        for (int i = 0; i < TogglesHungarian.Count; i++) TogglesHungarian[i].value = false;

        TogglesHungarian[(int)Type].value = true;
    }

    void CheckRussianBible(EKoreanBibleType Type)
    {
        TogglesGameObjectRussian.SetActive(true);

        for (int i = 0; i < TogglesRussian.Count; i++) TogglesRussian[i].value = false;

        TogglesRussian[(int)Type].value = true;
    }

    void CheckKoreanBible(EKoreanBibleType Type)
    {
        TogglesGameObjectKorean.SetActive(true);

        for (int i = 0; i < TogglesKorean.Count; i++) TogglesKorean[i].value = false;

        TogglesKorean[(int)Type].value = true;
    }

    void CheckEnglishBible(EEnglishBibleType Type)
    {
        for (int i = 0; i < TogglesEnglish.Count; i++) TogglesEnglish[i].value = false;

        TogglesEnglish[(int)Type].value = true;
    }
    /// <summary>
    /// 바이블의 내용을 표시.
    /// </summary>
    void ShowBible()
    {
        // SetRandomBackground();

        foreach (var item in m_ChapterItems) Destroy(item.gameObject); // 초기화를 위해서 생성된 챕터아이템들이 있다면 삭제.

        m_ChapterItems.Clear(); // 생성된 챕터아이템들을 저장해둘 리스트 초기화.
        PlayerPrefs.SetInt(EKeyword.m_Chapter.ToString(), m_Chapter); // 현재 챕터를 메모리에 저장.
        OldTestamentInfo bibleOld = new OldTestamentInfo(); // 신약성서 객체 생성.
        NewTestamentInfo bibleNew = new NewTestamentInfo(); // 구약성서 객체 생성.

        if (m_BibleType == EBibleType.OldTestament) // 만일 구약성서가 선택되었다면?
        {
            bibleOld = OldTestamentTable.GetByIndex((int)m_OldTestamentType); // 선택된 구약성서의 내용을 가져옴.
            m_MaxChapter = bibleOld.m_Count; // 선택된 구약성서의 맥스카운트를 저장.
            PlayerPrefs.SetInt(EKeyword.m_MaxChapter.ToString(), m_MaxChapter); // 선택된 구약성서의 맥스카운트를 메모리에 저장.
            SetOldTestamentInfo(bibleOld, bibleNew);
        }
        else if (m_BibleType == EBibleType.NewTestament) // 만일 신약성서가 선택되었다면?
        {
            bibleNew = NewTestamentTable.GetByIndex((int)m_NewTestamentType); // 선택된 신약성서의 내용을 가져옴.
            m_MaxChapter = bibleNew.m_Count; // 선택된 신약성서의 맥스챕터를 저장.
            PlayerPrefs.SetInt(EKeyword.m_MaxChapter.ToString(), m_MaxChapter); // 선택된 신약성서의 맥스챕터를 메모리에 저장.
            SetNewTestamentInfo(bibleOld, bibleNew);
        }

        m_PanelMain.alpha = 1.0f; // 패널매인을 보여줌.
        m_PanelBible.alpha = 0.0f; // 패널바이블은 안보여줌.
        m_PanelChapter.alpha = 0.0f; // 패널챕터는 안보여줌.
        Invoke("SetScrollbar", 0.01f); // 이전에 읽었던 문장으로 이동.
        PlayerPrefs.Save();
    }

    TextAsset korean;
    TextAsset english;

    /// <summary>
    /// 성서의 내용을 보여줌.
    /// </summary>
    /// <param name="selectedKorean"></param>
    /// <param name="selectedEnglish"></param>
    /// <param name="oldBible"></param>
    /// <param name="newBible"></param>
    void Show(string selectedKorean, string selectedEnglish, OldTestamentInfo oldBible, NewTestamentInfo newBible)
    {
        StopIsPlay(); // 성경 읽어주는 것을 멈춤

        //SetRandomBackground();

        korean = (TextAsset)Resources.Load(m_KoreanBible + selectedKorean, typeof(TextAsset)); // 챕터별로 정리된 성경의 한글판을 가져옴.
        english = (TextAsset)Resources.Load(m_EnglishBible + selectedEnglish, typeof(TextAsset)); // 챕터별로 정리된 성경의 영문판을 가져옴. 

        //TextAsset koreanEasyBible = (TextAsset)Resources.Load((EBiblePath.EasyBible.ToString() + "/") + selectedKoreanEasyBible, typeof(TextAsset));
        //TextAsset koreanKoreanBible = (TextAsset)Resources.Load((EBiblePath.KoreanBible.ToString() + "/") + selectedKoreanKoreanBible, typeof(TextAsset));
        //TextAsset koreanNewStandardTranslation = (TextAsset)Resources.Load((EBiblePath.NewStandardTranslation.ToString() + "/") + selectedKoreanNewStandardTranslation, typeof(TextAsset));
        //TextAsset koreanRevisedRevision = (TextAsset)Resources.Load((EBiblePath.RevisedRevision.ToString() + "/") + selectedKoreanRevisedRevision, typeof(TextAsset));

        //TextAsset englishNiv = (TextAsset)Resources.Load((EBiblePath.NIV.ToString() + "/") + selectedEnglishNIV, typeof(TextAsset));
        //TextAsset englishESV = (TextAsset)Resources.Load((EBiblePath.ESV.ToString() + "/") + selectedEnglishESV,  typeof(TextAsset));
        //TextAsset englishNewRSV = (TextAsset)Resources.Load((EBiblePath.NewRSV.ToString() + "/") + selectedEnglishNewRSV, typeof(TextAsset));
        //TextAsset englishNewKJV = (TextAsset)Resources.Load((EBiblePath.NewKJV.ToString() + "/") + selectedEnglishNewKJV, typeof(TextAsset));
        //TextAsset englishKJV = (TextAsset)Resources.Load((EBiblePath.KJV.ToString() + "/") + selectedEnglishKJV, typeof(TextAsset));

        //collectKoreanEasyBible = new List<string>(koreanEasyBible.text.Split('\n'));
        //collectKoreanKoreanBible = new List<string>(koreanKoreanBible.text.Split('\n'));
        //collectKoreanNewStandardTranslation = new List<string>(koreanNewStandardTranslation.text.Split('\n'));
        //collectKoreanRevisedRevision = new List<string>(koreanRevisedRevision.text.Split('\n'));
        //collectEnglishNIV = new List<string>(englishNiv.text.Split('\n'));
        //collectEnglishESV = new List<string>(englishESV.text.Split('\n'));
        //collectEnglishNewRSV = new List<string>(englishNewRSV.text.Split('\n'));
        //collectEnglishNewKJV = new List<string>(englishNewKJV.text.Split('\n'));
        //collectEnglishKJV = new List<string>(englishKJV.text.Split('\n'));


        collectKorean = new List<string>(korean.text.Split('\n')); // 챕터별로 정리된 성경의 한글판을 \n으로 분리해서 리스트에 저장.
        collectEnglish = new List<string>(english.text.Split('\n')); // 챕터별로 정리된 성경의 영문판을 \n으로 분리해서 리스트에 저장.

        // 성경마다 절 수가 틀린 경우가 있어서 똑같이 절 수를 맟쳐주기 위해서, 방법을 찾아야 함..
        if (collectKorean.Count > collectEnglish.Count) collectKorean.RemoveAt(collectKorean.Count - 1); else if (collectKorean.Count < collectEnglish.Count) collectEnglish.RemoveAt(collectEnglish.Count - 1);
        if (collectKorean.Count > collectEnglish.Count) collectKorean.RemoveAt(collectKorean.Count - 1); else if (collectKorean.Count < collectEnglish.Count) collectEnglish.RemoveAt(collectEnglish.Count - 1);
        if (collectKorean.Count > collectEnglish.Count) collectKorean.RemoveAt(collectKorean.Count - 1); else if (collectKorean.Count < collectEnglish.Count) collectEnglish.RemoveAt(collectEnglish.Count - 1);
        if (collectKorean.Count > collectEnglish.Count) collectKorean.RemoveAt(collectKorean.Count - 1); else if (collectKorean.Count < collectEnglish.Count) collectEnglish.RemoveAt(collectEnglish.Count - 1);
        if (collectKorean.Count > collectEnglish.Count) collectKorean.RemoveAt(collectKorean.Count - 1); else if (collectKorean.Count < collectEnglish.Count) collectEnglish.RemoveAt(collectEnglish.Count - 1);
        if (collectKorean.Count > collectEnglish.Count) collectKorean.RemoveAt(collectKorean.Count - 1); else if (collectKorean.Count < collectEnglish.Count) collectEnglish.RemoveAt(collectEnglish.Count - 1);
        if (collectKorean.Count > collectEnglish.Count) collectKorean.RemoveAt(collectKorean.Count - 1); else if (collectKorean.Count < collectEnglish.Count) collectEnglish.RemoveAt(collectEnglish.Count - 1);
        if (collectKorean.Count > collectEnglish.Count) collectKorean.RemoveAt(collectKorean.Count - 1); else if (collectKorean.Count < collectEnglish.Count) collectEnglish.RemoveAt(collectEnglish.Count - 1);
        if (collectKorean.Count > collectEnglish.Count) collectKorean.RemoveAt(collectKorean.Count - 1); else if (collectKorean.Count < collectEnglish.Count) collectEnglish.RemoveAt(collectEnglish.Count - 1);
        if (collectKorean.Count > collectEnglish.Count) collectKorean.RemoveAt(collectKorean.Count - 1); else if (collectKorean.Count < collectEnglish.Count) collectEnglish.RemoveAt(collectEnglish.Count - 1);
        if (collectKorean.Count > collectEnglish.Count) collectKorean.RemoveAt(collectKorean.Count - 1); else if (collectKorean.Count < collectEnglish.Count) collectEnglish.RemoveAt(collectEnglish.Count - 1);
        if (collectKorean.Count > collectEnglish.Count) collectKorean.RemoveAt(collectKorean.Count - 1); else if (collectKorean.Count < collectEnglish.Count) collectEnglish.RemoveAt(collectEnglish.Count - 1);
        if (collectKorean.Count > collectEnglish.Count) collectKorean.RemoveAt(collectKorean.Count - 1); else if (collectKorean.Count < collectEnglish.Count) collectEnglish.RemoveAt(collectEnglish.Count - 1);
        if (collectKorean.Count > collectEnglish.Count) collectKorean.RemoveAt(collectKorean.Count - 1); else if (collectKorean.Count < collectEnglish.Count) collectEnglish.RemoveAt(collectEnglish.Count - 1);
        if (collectKorean.Count > collectEnglish.Count) collectKorean.RemoveAt(collectKorean.Count - 1); else if (collectKorean.Count < collectEnglish.Count) collectEnglish.RemoveAt(collectEnglish.Count - 1);
        if (collectKorean.Count > collectEnglish.Count) collectKorean.RemoveAt(collectKorean.Count - 1); else if (collectKorean.Count < collectEnglish.Count) collectEnglish.RemoveAt(collectEnglish.Count - 1);

        collectKorean[collectKorean.Count - 1] = string.Empty; // 텍스트 파일의 맨 끝은 문장이 있는 것이 아니고 빈문장이 되게 하기 위해서, 영어와 한글의 절 수를 맟쳐주기 위한 
        collectEnglish[collectEnglish.Count - 1] = string.Empty; // 텍스트 파일의 맨 끝은 문장이 있는 것이 아니고 빈문장이 되게 하기 위해서, 영어와 한글의 절 수를 맟쳐주기 위한 

        if (m_BibleType == EBibleType.OldTestament) // 만일 구약성경을 선택했다면?
        {
            if (m_CheckboxReadBibleKorean.value == true) // 구약성경의 이름, 챕터, 맥스챕터를 표시.
            {
                int KeyWord = GetNationCode(m_NationType);

                if (KeyWord == 1) // English
                {
                    labelBibleChapter.text = string.Format("▼ {0} {1}({2})", oldBible.m_English, m_Chapter, oldBible.m_Count); 
                    bibleName = oldBible.m_English;
                }
                else if (KeyWord == 2) // Portuguese
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", oldBible.m_Portuguese, oldBible.m_English, m_Chapter, oldBible.m_Count); 
                    bibleName = oldBible.m_Portuguese;
                }
                else if (KeyWord == 3) // Japanese
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", oldBible.m_Japanese, oldBible.m_English, m_Chapter, oldBible.m_Count); 
                    bibleName = oldBible.m_Japanese;
                }
                else if (KeyWord == 4) // German
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", oldBible.m_German, oldBible.m_English, m_Chapter, oldBible.m_Count); 
                    bibleName = oldBible.m_German;
                }
                else if (KeyWord == 5) // Romanian
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", oldBible.m_Romanian, oldBible.m_English, m_Chapter, oldBible.m_Count); 
                    bibleName = oldBible.m_Romanian;
                }
                else if (KeyWord == 6) // French
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", oldBible.m_French, oldBible.m_English, m_Chapter, oldBible.m_Count); 
                    bibleName = oldBible.m_French;
                }
                else if (KeyWord == 7) // Spanish
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", oldBible.m_Spanish, oldBible.m_English, m_Chapter, oldBible.m_Count); 
                    bibleName = oldBible.m_Spanish;
                }
                else if (KeyWord == 8) // Italian
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", oldBible.m_Italian, oldBible.m_English, m_Chapter, oldBible.m_Count); 
                    bibleName = oldBible.m_Italian;
                }
                else if (KeyWord == 9) // Hungarian
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", oldBible.m_Hungarian, oldBible.m_English, m_Chapter, oldBible.m_Count); 
                    bibleName = oldBible.m_Hungarian;
                }
                else if (KeyWord == 10) // Hindi
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", oldBible.m_Hindi, oldBible.m_English, m_Chapter, oldBible.m_Count); 
                    bibleName = oldBible.m_Hindi;
                }
                else if (KeyWord == 11) // Russian
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", oldBible.m_Russian, oldBible.m_English, m_Chapter, oldBible.m_Count); 
                    bibleName = oldBible.m_Russian;
                }
                else if (KeyWord == 12) // Chinese
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", oldBible.m_Chinese, oldBible.m_English, m_Chapter, oldBible.m_Count); 
                    bibleName = oldBible.m_Chinese;
                }
                else if (KeyWord == 13) // Korean
                {
                    labelBibleChapter.text = string.Format("▼ {0} {1}장({2}장)", oldBible.m_Korean, m_Chapter, oldBible.m_Count);

                    bibleName = oldBible.m_Korean;
                }
            }
            else
                labelBibleChapter.text = string.Format("▼ {0} {1}({2})", oldBible.m_English, m_Chapter, oldBible.m_Count);

            bibleNameEnglish = oldBible.m_English;
            bibleNameSource = oldBible.m_Source;
            bibleNameSourceEnglish = oldBible.m_SourceEnglish;
            bibleChapter = m_Chapter;
            bibleMaxChapter = oldBible.m_Count;
        }
        else if (m_BibleType == EBibleType.NewTestament) // 만일 신약성경을 선택했다면?
        {
            if (m_CheckboxReadBibleKorean.value == true) // 신약성경의 이름, 챕터, 맥스챕터를 표시.
            {
                int KeyWord = GetNationCode(m_NationType);

                if (KeyWord == 1) // English
                {
                    labelBibleChapter.text = string.Format("▼ {0} {1}({2})", newBible.m_English, m_Chapter, newBible.m_Count); 
                    bibleName = newBible.m_English;
                }
                else if (KeyWord == 2) // Portuguese
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", newBible.m_Portuguese, newBible.m_English, m_Chapter, newBible.m_Count); 
                    bibleName = newBible.m_Portuguese;
                }
                else if (KeyWord == 3) // Japanese
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", newBible.m_Japanese, newBible.m_English, m_Chapter, newBible.m_Count); 
                    bibleName = newBible.m_Japanese;
                }
                else if (KeyWord == 4) // German
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", newBible.m_German, newBible.m_English, m_Chapter, newBible.m_Count); 
                    bibleName = newBible.m_German;
                }
                else if (KeyWord == 5) // Romanian
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", newBible.m_Romanian, newBible.m_English, m_Chapter, newBible.m_Count); 
                    bibleName = newBible.m_Romanian;
                }
                else if (KeyWord == 6) // French
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", newBible.m_French, newBible.m_English, m_Chapter, newBible.m_Count); 
                    bibleName = newBible.m_French;
                }
                else if (KeyWord == 7) // Spanish
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", newBible.m_Spanish, newBible.m_English, m_Chapter, newBible.m_Count); 
                    bibleName = newBible.m_Spanish;
                }
                else if (KeyWord == 8) // Italian
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", newBible.m_Italian, newBible.m_English, m_Chapter, newBible.m_Count); 
                    bibleName = newBible.m_Italian;
                }
                else if (KeyWord == 9) // Hungarian
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", newBible.m_Hungarian, newBible.m_English, m_Chapter, newBible.m_Count); 
                    bibleName = newBible.m_Hungarian;
                }
                else if (KeyWord == 10) // Hindi
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", newBible.m_Hindi, newBible.m_English, m_Chapter, newBible.m_Count); 
                    bibleName = newBible.m_Hindi;
                }
                else if (KeyWord == 11) // Russian
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", newBible.m_Russian, newBible.m_English, m_Chapter, newBible.m_Count); 
                    bibleName = newBible.m_Russian;
                }
                else if (KeyWord == 12) // Chinese
                {
                    labelBibleChapter.text = string.Format("▼ {0}({1}) {2}({3})", newBible.m_Chinese, newBible.m_English, m_Chapter, newBible.m_Count); 
                    bibleName = newBible.m_Chinese;
                }
                else if (KeyWord == 13) // Korean
                {
                    labelBibleChapter.text = string.Format("▼ {0} {1}장({2}장)", newBible.m_Korean, m_Chapter, newBible.m_Count);

                    bibleName = newBible.m_Korean;
                }
            }
            else
                labelBibleChapter.text = string.Format("▼ {0} {1}({2})", newBible.m_English, m_Chapter, newBible.m_Count);

            bibleNameEnglish = newBible.m_English;
            bibleNameSource = newBible.m_Source;
            bibleNameSourceEnglish = newBible.m_SourceEnglish;
            bibleChapter = m_Chapter;
            bibleMaxChapter = newBible.m_Count;
        }

        List<string> collectAll = new List<string>(); // 최종 문장들을 저장할 리스트.

        for (int i = 0; i < collectKorean.Count - 1; i++) // 한글판, 영문판 한줄씩 최종 리스트에 저장.
        {
            if (m_CheckboxReadBibleKorean.value == true)
            {
                collectAll.Add((i + 1) + "." + collectKorean[i]);
                collectAll.Add("[C3C3C3]" + collectEnglish[i] + "[-]");
                collectAll.Add("[C3C3C3][-]");
            }
            else
            {
                collectAll.Add((i + 1) + "." + collectEnglish[i]);
                collectAll.Add("[C3C3C3]" + collectKorean[i] + "[-]");
                collectAll.Add("[C3C3C3][-]");
            }
        }

        collectAll.RemoveAt(collectAll.Count - 1);
        StringBuilder stringBuilder = new StringBuilder(); // 스트링빌더 객체 생성.

        for (int i = 0; i < collectAll.Count; i++) // 최종리스트를 대상으로 반복문 처리.
            stringBuilder.AppendLine(collectAll[i]);

        m_ScrollViewContent.ResetPosition(); // 메인스크롤뷰 초기화.
        SetFontSize(labelBible);
        labelBible.text = stringBuilder.ToString(); // 성격의 내용을 표시.
        PlayerPrefs.Save();

        // 200자 넘는 문장을 저장하기 위한. 빌드할 때는 주석처리 해줌. 
        // SetSavedBibleName();

    }

    /// <summary>
    /// 에디터에서 할 수 있도록 수정해야 함. 
    /// 200자 넘는 문장을 저장하기 위한.
    /// </summary>
    void SetSavedBibleName()
    {
        // 영어성경의 문장과 한글 성경의 문장의 절 수가 틀릴경우 어는 장인지를 표시
        //string FileNameBible = string.Empty;
        //if (m_CheckboxReadBibleKorean.value == true)
        //    FileNameBible = m_KoreanBible.Substring(0, m_KoreanBible.Length - 5);
        //else
        //    FileNameBible = m_EnglishBible.Substring(0, m_EnglishBible.Length - 5);

        //string path = @"c:\Bible\"; // 저장될 경로입니다. 
        //StreamWriter streamWriter = new StreamWriter(path + "(" + m_NationType.ToString() + ") " + FileNameBible + ".txt", true); // 파일을 저장할 준비를 합니다. 

        //if (collectKorean.Count != collectEnglish.Count)
        //{
        //    streamWriter.WriteLine(m_NationType.ToString() + " (" + bibleName + ") " + bibleChapter + "장 " + collectKorean.Count + "절");
        //    streamWriter.WriteLine("English (" + bibleNameEnglish + ") " + bibleChapter + "장 " + collectEnglish.Count + "절");
        //}


        // 만일 성경의 문장이 200자가 넘을 경우 그 문장이 있는 텍스트 화일도 카피하고 어느 문장인지도 표시함. 
        string FileNameBible = string.Empty;
        if (m_CheckboxReadBibleKorean.value == true)
            FileNameBible = m_KoreanBible.Substring(0, m_KoreanBible.Length - 5);
        else
            FileNameBible = m_EnglishBible.Substring(0, m_EnglishBible.Length - 5);

        string path = @"c:\Bible\"; // 저장될 경로입니다. 

        StreamWriter streamWriter;

        if (m_CheckboxReadBibleKorean.value == true)
            streamWriter = new StreamWriter(path + "(" + m_NationType.ToString() + ") " + FileNameBible + ".txt", true);
        else
            streamWriter = new StreamWriter(path + "(" + "English" + ") " + FileNameBible + ".txt", true);

        if (m_CheckboxReadBibleKorean.value == true)
        {
            for (int i = 0; i < collectKorean.Count - 1; i++)
            {
                if (collectKorean[i].Length >= 200 && !collectKorean[i].Contains('#'))
                {
                    if (!File.Exists(path + korean.name + ".txt"))
                    {
                        //string projectPath = AssetDatabase.GetAssetPath(korean);
                        //string fullPath = System.IO.Path.GetFullPath(projectPath);
                        //string NewFilenName = path + korean.name + ".txt";
                        //System.IO.File.Copy(fullPath, NewFilenName);
                    }

                    streamWriter.WriteLine(bibleName + "(" + bibleNameEnglish + ") " + bibleChapter + ":" + (i + 1) + " (" + collectKorean[i].Length + ") " + collectKorean[i]);
                }
            }
        }
        else
        {
            for (int i = 0; i < collectEnglish.Count - 1; i++)
            {
                if (collectEnglish[i].Length >= 200 && !collectEnglish[i].Contains('#'))
                {
                    if (!File.Exists(path + english.name + ".txt"))
                    {
                        //string projectPath = AssetDatabase.GetAssetPath(english);
                        //string fullPath = System.IO.Path.GetFullPath(projectPath);
                        //string NewFilenName = path + english.name + ".txt";
                        //System.IO.File.Copy(fullPath, NewFilenName);
                    }

                    streamWriter.WriteLine(bibleNameEnglish + " " + bibleChapter + ":" + (i + 1) + " (" + collectEnglish[i].Length + ") " + collectEnglish[i]);
                }
            }
        }

        streamWriter.Close();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="Old"></param>
    /// <param name="New"></param>
    public void SetOldTestamentInfo(OldTestamentInfo Old, NewTestamentInfo New)
    {
        SetBibleInfoInit();

        string selectedKorean = string.Empty; // 챕터별로 정리된 구약성서의 한글판의 이름을 가져옴.

        if (m_NationType == ENationType.Korean)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_EasyBible + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = Old.m_NewStandardTranslation + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) selectedKorean = Old.m_KoreanBible + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) selectedKorean = Old.m_RevisedRevision + m_Chapter;
            
        }
        else if (m_NationType == ENationType.Chinese)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_chinese_union_simp + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = Old.m_chinese_union_trad + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) selectedKorean = Old.m_ckjv_sds + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) selectedKorean = Old.m_ckjv_sdt + m_Chapter;
        }
        else if (m_NationType == ENationType.Afrikaans)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_afri + m_Chapter;
        }
        else if (m_NationType == ENationType.Albanian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_albanian + m_Chapter;
        }
        else if (m_NationType == ENationType.Czech)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_bkr + m_Chapter;
        }
        else if (m_NationType == ENationType.Vietnamese)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_cadman + m_Chapter;
        }
        else if (m_NationType == ENationType.Finnish)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_finn + m_Chapter;
        }
        else if (m_NationType == ENationType.Indonesian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_indo_tb + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = Old.m_indo_tm + m_Chapter;
        }
        else if (m_NationType == ENationType.Polish)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_pol_nbg + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = Old.m_pol_ubg + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) selectedKorean = Old.m_polbg + m_Chapter;
        }
        else if (m_NationType == ENationType.Tagalog)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_tagab + m_Chapter;
        }
        else if (m_NationType == ENationType.Thai)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_thaikjv + m_Chapter;
        }
        else if (m_NationType == ENationType.Portuguese)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_almeida_ra + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = Old.m_almeida_rc + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) selectedKorean = Old.m_blivre + m_Chapter;
        }
        else if (m_NationType == ENationType.Japanese)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_bungo + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = Old.m_kougo + m_Chapter;
        }
        else if (m_NationType == ENationType.German)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_elberfelder_1905 + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = Old.m_luther_1912 + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) selectedKorean = Old.m_schlachter + m_Chapter;
        }
        else if (m_NationType == ENationType.Romanian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_fidela + m_Chapter;
        }
        else if (m_NationType == ENationType.French)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_epee + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = Old.m_oster + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) selectedKorean = Old.m_segond_1910 + m_Chapter;
        }
        else if (m_NationType == ENationType.Spanish)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_rv_1909 + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = Old.m_rvg + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) selectedKorean = Old.m_rvg_2004 + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) selectedKorean = Old.m_sagradas + m_Chapter;
        }
        else if (m_NationType == ENationType.Italian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_diodati + m_Chapter;
        }
        else if (m_NationType == ENationType.Hindi)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_irv + m_Chapter;
        }
        else if (m_NationType == ENationType.Hungarian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_karoli + m_Chapter;
        }
        else if (m_NationType == ENationType.Russian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_synodal + m_Chapter;
        }
        else
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = Old.m_EasyBible + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = Old.m_NewStandardTranslation + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) selectedKorean = Old.m_KoreanBible + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) selectedKorean = Old.m_RevisedRevision + m_Chapter;
        }

        string selectedEnglish = string.Empty; // 챕터별로 정리된 구약성서의 영문판의 이름을 가져옴.

        if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.NIV) selectedEnglish = Old.m_NIV + m_Chapter;
        if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.KJV) selectedEnglish = Old.m_KJV + m_Chapter;
        if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.NewKJV) selectedEnglish = Old.m_NewKJV + m_Chapter;
        if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.ESV) selectedEnglish = Old.m_ESV + m_Chapter;
        if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.NewRSV) selectedEnglish = Old.m_NewRSV + m_Chapter;

        Show(selectedKorean, selectedEnglish, Old, New);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="Old"></param>
    /// <param name="New"></param>
    public void SetNewTestamentInfo(OldTestamentInfo Old, NewTestamentInfo New)
    {
        SetBibleInfoInit();

        string selectedKorean = string.Empty; // 챕터별로 정리된 구약성서의 영문판의 이름을 가져옴.

        if (m_NationType == ENationType.Korean)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_EasyBible + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = New.m_NewStandardTranslation + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) selectedKorean = New.m_KoreanBible + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) selectedKorean = New.m_RevisedRevision + m_Chapter;

        }
        else if (m_NationType == ENationType.Chinese)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_chinese_union_simp + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = New.m_chinese_union_trad + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) selectedKorean = New.m_ckjv_sds + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) selectedKorean = New.m_ckjv_sdt + m_Chapter;
        }
        else if (m_NationType == ENationType.Afrikaans)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_afri + m_Chapter;
        }
        else if (m_NationType == ENationType.Albanian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_albanian + m_Chapter;
        }
        else if (m_NationType == ENationType.Czech)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_bkr + m_Chapter;
        }
        else if (m_NationType == ENationType.Vietnamese)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_cadman + m_Chapter;
        }
        else if (m_NationType == ENationType.Finnish)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_finn + m_Chapter;
        }
        else if (m_NationType == ENationType.Indonesian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_indo_tb + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = New.m_indo_tm + m_Chapter;
        }
        else if (m_NationType == ENationType.Polish)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_pol_nbg + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = New.m_pol_ubg + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) selectedKorean = New.m_polbg + m_Chapter;
        }
        else if (m_NationType == ENationType.Tagalog)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_tagab + m_Chapter;
        }
        else if (m_NationType == ENationType.Thai)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_thaikjv + m_Chapter;
        }
        else if (m_NationType == ENationType.Portuguese)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_almeida_ra + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = New.m_almeida_rc + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) selectedKorean = New.m_blivre + m_Chapter;
        }
        else if (m_NationType == ENationType.Japanese)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_bungo + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = New.m_kougo + m_Chapter;
        }
        else if (m_NationType == ENationType.German)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_elberfelder_1905 + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = New.m_luther_1912 + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) selectedKorean = New.m_schlachter + m_Chapter;
        }
        else if (m_NationType == ENationType.Romanian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_fidela + m_Chapter;
        }
        else if (m_NationType == ENationType.French)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_epee + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = New.m_oster + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) selectedKorean = New.m_segond_1910 + m_Chapter;
        }
        else if (m_NationType == ENationType.Spanish)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_rv_1909 + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = New.m_rvg + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) selectedKorean = New.m_rvg_2004 + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) selectedKorean = New.m_sagradas + m_Chapter;
        }
        else if (m_NationType == ENationType.Italian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_diodati + m_Chapter;
        }
        else if (m_NationType == ENationType.Hindi)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_irv + m_Chapter;
        }
        else if (m_NationType == ENationType.Hungarian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_karoli + m_Chapter;
        }
        else if (m_NationType == ENationType.Russian)
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_synodal + m_Chapter;
        }
        else
        {
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.EasyBible) selectedKorean = New.m_EasyBible + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.NewStandardTranslation) selectedKorean = New.m_NewStandardTranslation + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.KoreanBible) selectedKorean = New.m_KoreanBible + m_Chapter;
            if (PlayerPrefs.GetInt(EKeyword.OldKoreanBible.ToString()) == (int)EKoreanBibleType.RevisedRevision) selectedKorean = New.m_RevisedRevision + m_Chapter;
        }

        string selectedEnglish = string.Empty; // 챕터별로 정리된 구약성서의 한글판의 이름을 가져옴.

        if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.NIV) selectedEnglish = New.m_NIV + m_Chapter;
        if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.KJV) selectedEnglish = New.m_KJV + m_Chapter;
        if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.NewKJV) selectedEnglish = New.m_NewKJV + m_Chapter;
        if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.ESV) selectedEnglish = New.m_ESV + m_Chapter;
        if (PlayerPrefs.GetInt(EKeyword.OldEnglishBible.ToString()) == (int)EEnglishBibleType.NewRSV) selectedEnglish = New.m_NewRSV + m_Chapter;

        Show(selectedKorean, selectedEnglish, Old, New);
    }
    /// <summary>
    /// 
    /// </summary>
    void InitPanel()
    {
        m_PanelMain.alpha = 1.0f;
        m_PanelBible.alpha = 0.0f;
        m_PanelChapter.alpha = 0.0f;
        m_PanelOption.alpha = 0.0f;
        m_PanelLordPrayer.alpha = 0.0f;
        m_PanelFront.alpha = 1.0f;
        // m_PanelShowBible.alpha = 1.0f;
        SetLabelShowBibleInit();
    }
    /// <summary>
    /// 현재 보이는 문장을 저장했다고 확인할 수 있는 레이블, Tab키를 눌렀을 때
    /// </summary>
    public UILabel m_LabelConfirm;
    /// <summary>
    /// 
    /// </summary>
    public UILabel m_LabelTestimonyInfo;
    /// <summary>
    /// PanelBibleUpperBody을 안보이기 위치값을 옮기기 위한
    /// </summary>
    public Transform m_PanelBibleUpperBody;
    /// <summary>
    /// 첫번째 레이블 지금은 쓰이지 않음
    /// </summary>
    public UILabel m_LabelBibleFirst;
    /// <summary>
    /// 두번째 레이블 지금은 쓰이지 않음
    /// </summary>
    public UILabel m_LabelBibleSecond;
    /// <summary>
    /// 읽어주는 하나님의 말씀 깃허브로 가는 버튼
    /// </summary>
    public void ButtonUpdateBible()
    {
        if (m_NationType == ENationType.Korean) { Application.OpenURL(@"https://github.com/insaneoops288/Bible"); }
        else if (m_NationType == ENationType.Afrikaans) { Application.OpenURL(@"https://github.com/insaneoops288/BibleAfrikaans"); }
        else if (m_NationType == ENationType.Albanian) { Application.OpenURL(@"https://github.com/insaneoops288/BibleAlbanian"); }
        else if (m_NationType == ENationType.Chinese) { Application.OpenURL(@"https://github.com/insaneoops288/BibleChinese"); }
        else if (m_NationType == ENationType.Czech) { Application.OpenURL(@"https://github.com/insaneoops288/BibleCzech"); }
        else if (m_NationType == ENationType.Finnish) { Application.OpenURL(@"https://github.com/insaneoops288/BibleFinnish"); }
        else if (m_NationType == ENationType.French) { Application.OpenURL(@"https://github.com/insaneoops288/BibleFrench"); }
        else if (m_NationType == ENationType.German) { Application.OpenURL(@"https://github.com/insaneoops288/BibleGerman"); }
        else if (m_NationType == ENationType.Hindi) { Application.OpenURL(@"https://github.com/insaneoops288/BibleHindi"); }
        else if (m_NationType == ENationType.Hungarian) { Application.OpenURL(@"https://github.com/insaneoops288/BibleHungarian"); }
        else if (m_NationType == ENationType.Indonesian) { Application.OpenURL(@"https://github.com/insaneoops288/BibleIndonesian"); }
        else if (m_NationType == ENationType.Italian) { Application.OpenURL(@"https://github.com/insaneoops288/BibleItalian"); }
        else if (m_NationType == ENationType.Japanese) { Application.OpenURL(@"https://github.com/insaneoops288/BibleJapanese"); }
        else if (m_NationType == ENationType.Polish) { Application.OpenURL(@"https://github.com/insaneoops288/BiblePolish"); }
        else if (m_NationType == ENationType.Portuguese) { Application.OpenURL(@"https://github.com/insaneoops288/BiblePortuguese"); }
        else if (m_NationType == ENationType.Romanian) { Application.OpenURL(@"https://github.com/insaneoops288/BibleRomanian"); }
        else if (m_NationType == ENationType.Russian) { Application.OpenURL(@"https://github.com/insaneoops288/BibleRussian"); }
        else if (m_NationType == ENationType.Spanish) { Application.OpenURL(@"https://github.com/insaneoops288/BibleSpanish"); }
        else if (m_NationType == ENationType.Tagalog) { Application.OpenURL(@"https://github.com/insaneoops288/BibleTagalog"); }
        else if (m_NationType == ENationType.Thai) { Application.OpenURL(@"https://github.com/insaneoops288/BibleThai"); }
        else if (m_NationType == ENationType.Vietnamese) { Application.OpenURL(@"https://github.com/insaneoops288/BibleVietnamese"); }
        else if (m_NationType == ENationType.English) { Application.OpenURL(@"https://github.com/insaneoops288/Bible"); }
    }
    /// <summary>
    /// Youtube에서 성경관련, 간증 관련 동영상들을 보기 위한 씬으로
    /// </summary>
    public void ButtonTestimony()
    {
        SceneManager.LoadScene("BibleTestimony");
    }
    /// <summary>
    /// 사용하지 않음
    /// </summary>
    public List<string> BibleMessgeContents = new List<string>();
    /// <summary>
    /// 사용하지 않음
    /// </summary>
    public List<string> BibleMessgeIndex = new List<string>();
    /// <summary>
    /// 사용하지 않음
    /// </summary>
    public int ReadBibleMessageIndex;
    /// <summary>
    /// 사용하지 않음
    /// </summary>
    void GetBibleMessage()
    {
        BibleMessgeContents.Clear();
        BibleMessgeIndex.Clear();

        if (m_TempBibleType == EBibleType.OldTestament)
        {
            TextAsset korean = (TextAsset)Resources.Load("BibleMessage/" + bibleName, typeof(TextAsset));
            List<string> tmep = new List<string>(korean.text.Split('\n'));

            for (int i = 0; i < tmep.Count; i = i + 2)
            {
                BibleMessgeContents.Add(tmep[i]);
                BibleMessgeIndex.Add(tmep[i + 1]);
            }
        }
        else if (m_TempBibleType == EBibleType.NewTestament)
        {
            TextAsset korean = (TextAsset)Resources.Load("BibleMessage/" + bibleName, typeof(TextAsset));
            List<string> tmep = new List<string>(korean.text.Split('\n'));

            for (int i = 0; i < tmep.Count; i = i + 2)
            {
                BibleMessgeContents.Add(tmep[i]);
                BibleMessgeIndex.Add(tmep[i + 1]);
            }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public UIPanel m_PanelFront;
    /// <summary>
    /// 선택한 한글 성경의 이름
    /// </summary>
    public string bibleName;
    /// <summary>
    /// 선택한 한글 성경이름의 약어
    /// </summary>
    public string bibleNameSource;
    /// <summary>
    /// 선택한 영어 성경이름의 약어
    /// </summary>
    public string bibleNameSourceEnglish;
    /// <summary>
    /// 선택한 영어 성경의 이름
    /// </summary>
    public string bibleNameEnglish;
    /// <summary>
    /// 선택한 성경의 챕터
    /// </summary>
    public int bibleChapter;
    /// <summary>
    ///  선택한 성경의 맥스 챕터
    /// </summary>
    public int bibleMaxChapter;
    /// <summary>
    /// 구약성서, 신약성서를 구분하기 위한 열거형.
    /// </summary>
    public EBibleType m_BibleType = EBibleType.None;
    /// <summary>
    /// 구약성서, 신약성서를 구분하기 위한 열거형.
    /// </summary>
    public EBibleType m_TempBibleType = EBibleType.None;
    /// <summary>
    /// 구약성서들을 구분하기 위한 열거형.
    /// </summary>
    public EOldTestamentType m_OldTestamentType = EOldTestamentType.None;
    /// <summary>
    /// 구약성서들을 구분하기 위한 열거형.
    /// </summary>
    public EOldTestamentType m_TempOldTestamentType = EOldTestamentType.None;
    /// <summary>
    /// 신약성서들을 구분하기 위한 열거형.
    /// </summary>
    public ENewTestamentType m_NewTestamentType = ENewTestamentType.None;
    /// <summary>
    /// 신약성서들을 구분하기 위한 열거형.
    /// </summary>
    public ENewTestamentType m_TempNewTestamentType = ENewTestamentType.None;
    /// <summary>
    /// 챕터를 저장하기 위한 변수.
    /// </summary>
    public int m_Chapter;
    /// <summary>
    /// 맥스챕터를 저장하기 위한 변수.
    /// </summary>
    public int m_MaxChapter;
    /// <summary>
    /// 각각의 바이블들의 위치를 저장할
    /// </summary>
    public string m_KoreanBible;
    /// <summary>
    /// 각각의 바이블들의 위치를 저장할
    /// </summary>
    public string m_EnglishBible;
    /// <summary>
    /// 한국어로 읽어줄 지? 영어로 읽어줄 지 판별해주는 불리언 변수
    /// </summary>
    public bool isPlayKorean = true;
    /// <summary>
    /// 성경 읽어주는 것을 멈출지 확인하는 불리언 변수
    /// </summary>
    public bool isPlay = false;
    /// <summary>
    /// 성경을 '\n'로 구분해서 저장할 collectKorean리스트
    /// </summary>
    public List<string> collectKorean = new List<string>();
    /// <summary>
    /// 성경을 '\n'로 구분해서 저장할 collectEnglish
    /// </summary>
    public List<string> collectEnglish = new List<string>();
    /// <summary>
    /// 결과 문자열들을 저장해둘 리스트
    /// </summary>
    public List<string> result = new List<string>();
    /// <summary>
    /// 성경 명언들이 들어있는 리스트에 접근하기 위한 인덱스
    /// </summary>
    public int indexBible = 0;
    /// <summary>
    /// 배경 스프라이트들을 저장해 둘 배열
    /// </summary>
    public List<Sprite> allSprite = new List<Sprite>();
    /// <summary>
    /// 배경 스프라이트들을 저장해 둘 배열
    /// </summary>
    public List<Sprite> AllSprite { get { return allSprite; } set { allSprite = value; } }
    /// <summary>
    /// PanelShowBible패널에서 성경의 각 절들을 보여주는 패널
    /// </summary>
    public UIPanel m_PanelShowBible;
    /// <summary>
    /// PanelShowBible패널에서 성경의 각 절들을 보여주는 레이블
    /// </summary>
    public UILabel m_LabelShowBible;
    /// <summary>
    /// PanelShowBible패널에서 성경의 몇장 몇절인지를 보여주는 레이블
    /// </summary>
    public UILabel m_LabelBibleInfo;
    /// <summary>
    /// 
    /// </summary>
    void SetLabelShowBibleInit()
    {
        m_LabelShowBible.text = string.Empty;
        m_LabelBibleInfo.text = string.Empty;
        m_LabelBibleFirst.enabled = false;
        m_LabelBibleSecond.enabled = false;
    }
    /// <summary>
    /// 
    /// </summary>
    void SetLabelShowBible()
    {
        m_LabelBibleFirst.enabled = true;
        m_LabelBibleSecond.enabled = true;
    }
    /// <summary>
    /// PanelMain패널에서 절을 한글로 읽어줄 것인지? 영어로 읽어줄 것인지를 표시해주는 레이블
    /// </summary>
    public UILabel m_LabelCheckboxReadBibleKorean;
    /// <summary>
    /// PanelShowBible패널에서 성경의 각 절들을 보여주는 패널의 배경이미지를 저장하기 위한 스프라이트, 선택될 때 마다 배경이미지가 변경됨
    /// </summary>
    public UI2DSprite m_SpritePanelShowBible;
    /// <summary>
    /// PanelOption패널에서 찾은 단어가 몇개 있고, 어디에 저장되어 있다고 알려주는 레이블
    /// </summary>
    public UILabel m_LabelBibleSearchInfo;
    /// <summary>
    /// PanelShowBible패널에서 현재 몇절인지를 표시
    /// </summary>
    public UILabel m_LabelChapterInfo;
    /// <summary>
    /// PanelFront패널에서 성경 명언을 표시하는 레이블의 TweenAlpha
    /// </summary>
    public TweenAlpha m_TweenLabelWiseSaying;
    /// <summary>
    /// PanelShowBible패널에서 성경의 내용을 표시하는 레이블의 TweenAlpha
    /// </summary>
    public TweenAlpha m_TweenLabelBible;
    /// <summary>
    /// PanelMain패널에서 성경명언을 표시하는
    /// </summary>
    public UILabel m_LabelKindOfBible;
    /// <summary>
    /// PanelMain패널에서 성경명언을 표시하는
    /// </summary>
    public UILabel m_LabelKindOfBibleEnglish;
    /// <summary>
    /// 
    /// </summary>
    public UIInput inputFieldBibleSearch;
    /// <summary>
    /// 
    /// </summary>
    public List<WiseSayingInfo> ListWiseSaying = new List<WiseSayingInfo>();
    /// <summary>
    ///  사운드를 플레이하기 위한 AudioSource
    /// </summary>
    public AudioSource audioSource;
    /// <summary>
    /// 
    /// </summary>
    public UILabel m_LabelWiseSaying;
    /// <summary>
    /// 한글 성경 이름
    /// </summary>
    public string m_KoreanBibleName;
    /// <summary>
    /// 영어 성경 이름
    /// </summary>
    public string m_EnglishBibleName;
    /// <summary>
    /// 
    /// </summary>
    /// <param name="label"></param>
    void SetFontSize(UILabel label)
    {
        if (PlayerPrefs.GetInt(EKeyword.IsPhone.ToString()) == 0) // 만일 int값이 0이라면 초기화를 위해서 int값을 1로 설정, 폰트 사이즈는 75
        {
            PlayerPrefs.SetInt(EKeyword.IsPhone.ToString(), 1);
            PlayerPrefs.Save();
        }
        
        if (PlayerPrefs.GetInt(EKeyword.IsPhone.ToString()) == 1) label.fontSize = 75; // 성경을 보여주는 UILabel의 폰트 사이즈 조절
        else if (PlayerPrefs.GetInt(EKeyword.IsPhone.ToString()) == 2) label.fontSize = 50;
        else if (PlayerPrefs.GetInt(EKeyword.IsPhone.ToString()) == 3) label.fontSize = 67;
    }
    /// <summary>
    /// 9가지의 성경의 기본정보가 저장
    /// </summary>
    // public Dictionary<string, BibleTypeInfo> BibleTypeInfos = new Dictionary<string, BibleTypeInfo>();
    /// <summary>
    /// 
    /// </summary>
    public List<WiseSayingInfo> WiseSayingInfos = new List<WiseSayingInfo>();
    /// <summary>
    /// 
    /// </summary>
    public List<TestimonyInfo> TestimonyInfos = new List<TestimonyInfo>();
    /// <summary>
    /// PanelMain패널에서 성서의 내용을 표시하는 레이블. 폰은 75, 탭은 60
    /// </summary>
    public UILabel labelBible;
    /// <summary>
    /// PanelFront패널에서 성경에 관한 명언들을 표시할 레이블
    /// </summary>
    public UILabel LabelWiseSaying;
    /// <summary>
    /// PanelMain패널에서 성경의 내용이 표시되는 스크롤뷰.
    /// </summary>
    public UIScrollView m_ScrollViewContent;
    /// <summary>
    /// PanelMain패널에서 성서의 정보들이 표시되는 레이블.
    /// </summary>
    public UILabel labelBibleChapter;
    /// <summary>
    /// 메인패널.
    /// </summary>
    public UIPanel m_PanelMain;
    /// <summary>
    ///  바이블패널.
    /// </summary>
    public UIPanel m_PanelBible;
    /// <summary>
    /// 챕터패널.
    /// </summary>
    public UIPanel m_PanelChapter;
    /// <summary>
    /// PanelBible패널에서 바이블 스크롤뷰.
    /// </summary>
    public UIScrollView m_ScrollViewBible;
    /// <summary>
    /// PanelBible패널에서 바이블 그리드.
    /// </summary>
    public UIGrid m_UIGridBible;
    /// <summary>
    /// 챕터 프리팹.
    /// </summary>
    public ChapterItem m_ChapterItemPrefab;
    /// <summary>
    /// PanelChapter패널에서 챕터 스크롤뷰.
    /// </summary>
    public UIScrollView m_ScrollViewChapter;
    /// <summary>
    /// PanelChapter패널에서 챕터 그리드.
    /// </summary>
    public UIGrid m_UIGridChapter;
    /// <summary>
    /// 생성된 바이블 아이텝들을 저장해둘 리스트.
    /// </summary>
    public List<BibleItem> m_BibleItems = new List<BibleItem>();
    /// <summary>
    /// 생성된 챕터 아이템들을 저장해둘 리스트.
    /// </summary>
    public List<ChapterItem> m_ChapterItems = new List<ChapterItem>();
    /// <summary>
    /// 옵션창 저장.
    /// </summary>
    public UIPanel m_PanelOption;
    /// <summary>
    /// PanelOption패널에서 성경의 내용을 크게 보기위한 토글. 폰에서 보기 위한.
    /// </summary>
    public UIToggle m_CheckboxPhone;
    /// <summary>
    /// PanelOption패널에서 성경의 내용을 작게 보기위한 토글. 탭에서 보기 위한. 
    /// </summary>
    public UIToggle m_CheckboxMiddle;
    /// <summary>
    /// PanelOption패널에서 성경의 내용을 작게 보기위한 토글. 탭에서 보기 위한. 
    /// </summary>
    public UIToggle m_CheckboxPad;    
    /// <summary>
    /// PanelBible에서 성경의 정보를 표시.
    /// </summary>
    public UILabel m_LabelSelectBible;
    /// <summary>
    /// PanelChapter에서 성경의 정보를 표시.
    /// </summary>
    public UILabel m_LabelSelecChapter;
    /// <summary>
    /// 주기도문과 사도신경이 있는 패널.
    /// </summary>
    public UIPanel m_PanelLordPrayer;
    /// <summary>
    /// PanelLordPrayer패널에서 주기도문이 표시.
    /// </summary>
    public UILabel m_LabelLordPrayer;
    /// <summary>
    /// PanelLordPrayer패널에서 사도신경이 표시.
    /// </summary>
    public UILabel m_LabelApostlesCreed;
    /// <summary>
    /// PanelMain패널에서 성경문장의 이전에 읽엇던 위치를 표시.
    /// </summary>
    public UIScrollBar m_ScrollBarPanelMan;
    /// <summary>
    /// PanelMain패널에서 성경문장의 이전에 읽었던 위치의 값을 저장.
    /// </summary>
    public float m_ScrollBarPanelManValue;
    /// <summary>
    /// PanelLordPrayer패널에서 주기도문이 보여지는 스크롤뷰.
    /// </summary>
    public UIScrollView m_ScrollViewLordPrayer;
    /// <summary>
    /// PanelLordPrayer패널에서 사도신경이 보여지는 스크롤뷰.
    /// </summary>
    public UIScrollView m_ScrollViewApostlesCreed;
    /// <summary>
    /// PanelLordPrayer패널에서 주기도문을 보는지? 사도신경을 보는지? 표시.
    /// </summary>
    public UILabel m_LabelLordPrayerTitle;
    /// <summary>
    /// "요한복음 3장 16절" 연출이 끝나면 버튼들을 활성화.
    /// </summary>
    public List<UIButton> m_UIButtons = new List<UIButton>();
    /// <summary>
    /// 배경 이미지들을 저장해둘 리스트
    /// </summary>
    public List<UI2DSprite> m_BackgroundImages = new List<UI2DSprite>();

    public void SetBackgroundImagesOne()
    {
        // m_BackgroundImages[1].color = new Color(200f / 255f, 200f / 255f, 200f / 255f, 1);
        // m_BackgroundImages[1].color = new Color(150f / 255f, 150f / 255f, 150f / 255f, 1);
        m_BackgroundImages[1].color = new Color(100f / 255f, 100f / 255f, 100f / 255f, 1);
    }

    public void SetBackgroundImagesHalf()
    {
        m_BackgroundImages[1].color = new Color(70f/ 255f, 70f / 255f, 70f / 255f, 1);
    }

    /// <summary>
    /// PanelMain패널에서 한글로 읽어줄지? 영어로 읽어줄지?
    /// </summary>
    public UIToggle m_CheckboxReadBibleKorean;
    /// <summary>
    /// PanelMain패널에서 성경을 읽어줄지?
    /// </summary>
    public UIToggle m_CheckboxReadBible;
    /// <summary>
    /// 
    /// </summary>
    public void ButtonQuiz()
    {
        SceneManager.LoadScene("QuizGame");
    }
    /// <summary>
    /// 각각의 패널들의 알파값을 조절해서 보여줄 패널을 선택
    /// </summary>
    /// <param name="panelMainValue"></param>
    /// <param name="panelBibleValue"></param>
    /// <param name="panelChapterValue"></param>
    public void SetPanelAlpla(float panelMainValue, float panelBibleValue, float panelChapterValue)
    {
        m_PanelMain.alpha = panelMainValue;
        m_PanelBible.alpha = panelBibleValue;
        m_PanelChapter.alpha = panelChapterValue;
    }
    /// <summary>
    /// 성경문장의 스크롤바를 움직였을 때의 값을 가져옴. 이전에 읽었던 위치를 표시하기 위한.
    /// </summary>
    /// <returns></returns>
    float PlayerPrefsGetFloatm_ScrollBarPanelMan()
    {
        return PlayerPrefs.GetFloat(EKeyword.m_ScrollBarPanelMan.ToString());
    }   
    /// <summary>
    /// 성경 명언의 TypeWriterEffect 이펙트가 끝나면 성경 명언을 서서히 없애줌
    /// </summary>
    void EndLabelWiseSayingTypeWriterEffect()
    {
        m_TweenLabelWiseSaying.enabled = true;
    }
    /// <summary>
    /// 성경 명언이 서서히 없어지는 이펙트가 끝나면 성경의 내용을 표시하는 레이블이 서서히 보여짐
    /// </summary>
    void EndLabelWiseSayingTweenAlpha()
    {
        m_TweenLabelBible.enabled = true;
    }

    public int BackgroundIndex = 0;

    /// <summary>
    /// 배경 이미지를 랜덤으로 보여줌
    /// </summary>
    void SetRandomBackground()
    {
        //AllSprite = Resources.LoadAll<Sprite>("BibleImage/").ToList(); // 배경 스프라이트들을 가져옴.

        //for (int i = 0; i < m_BackgroundImages.Count; i++)
        //    m_BackgroundImages[i].sprite2D = AllSprite[UnityEngine.Random.Range(0, AllSprite.Count)]; // 각각의 배열이미지들을 랜덤으로 설정.

        // AllSprite = Resources.LoadAll<Sprite>("BibleImage/").ToList(); // 배경 스프라이트들을 가져옴.

        // LabelTempTemp.text = BackgroundIndex + " / " + AllSprite.Count;

        if (BackgroundIndex >= AllSprite.Count - 1)
            BackgroundIndex = 0;

        for (int i = 0; i < m_BackgroundImages.Count; i++)
            m_BackgroundImages[i].sprite2D = AllSprite[BackgroundIndex]; // 각각의 배열이미지들을 랜덤으로 설정.

        BackgroundIndex++;
    }
    /// <summary>
    /// "요한복음 3장 16절" 연출이 끝나면 버튼들을 활성화.
    /// </summary>
    void SetUIButtonsEnabledTrue()
    {
        for (int i = 0; i < m_UIButtons.Count; i++) m_UIButtons[i].enabled = true;

        m_CheckboxReadBible.enabled = true;
    }
    /// <summary>
    /// 
    /// </summary>
    public void CheckboxReadBible()
    {
        if (m_CheckboxReadBible.value == true)
        {
            SetReadBibleEnabled();
            SetLabelShowBible();
            isPlay = true;
            StartCoroutine(DownloadTheAudio());
            List<Sprite> GetAllSprite = Resources.LoadAll<Sprite>("BibleImage/").ToList(); // 배경 스프라이트들을 가져옴.
            m_SpritePanelShowBible.sprite2D = GetAllSprite[UnityEngine.Random.Range(0, GetAllSprite.Count)];
            // SetRandomBackground();
            SetBackgroundImagesOne();
        }
        else
        {
            SetBackgroundImagesHalf();
            SetReadBibleDisabled();
            StopIsPlay();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public void CheckboxReadBibleKorean()
    {
        SetBackgroundImagesHalf();

        if (m_CheckboxReadBibleKorean.value == true)
        {
            SetReadBibleDisabled();
            StopIsPlay();
            isPlayKorean = true;

            int KeyWord = GetNationCode(m_NationType);

            if (KeyWord == 13)
            {
                if (m_CheckboxReadBibleKorean.value == true) m_LabelCheckboxReadBibleKorean.text = string.Format("{0}", "한국어");
                else m_LabelCheckboxReadBibleKorean.text = string.Format("{0}", "English");
            }
            else m_LabelCheckboxReadBibleKorean.text = string.Format("{0}", m_NationType.ToString());

            PlayerPrefs.SetInt(EKeyword.IsCheckboxReadBibleKorean.ToString(), 0);
        }
        else
        {
            SetReadBibleDisabled();
            StopIsPlay();
            isPlayKorean = false;

            int KeyWord = GetNationCode(m_NationType);

            if (KeyWord == 13) m_LabelCheckboxReadBibleKorean.text = string.Format("{0}", "English");
            else m_LabelCheckboxReadBibleKorean.text = string.Format("{0}", "English");

            PlayerPrefs.SetInt(EKeyword.IsCheckboxReadBibleKorean.ToString(), 1);
        }

        SetLabelKindOfBible(m_CheckboxReadBibleKorean.value);
        ShowBible();
        SetCustomizeLabels();
    }
    /// <summary>
    /// 성경문장의 스크롤바를 움직였을 때의 값을 저장함. 
    /// </summary>
    /// <returns></returns>
    void PlayerPrefsSetFloatm_ScrollBarPanelMan(float value)
    {
        PlayerPrefs.SetFloat(EKeyword.m_ScrollBarPanelMan.ToString(), value);
    }
    /// <summary>
    /// 스크롤바 위치를 0으로 초기화 해서 스크롤뷰 초기화.
    /// </summary>
    public void InitScrollBarPanelMan()
    {
        PlayerPrefsSetFloatm_ScrollBarPanelMan(0.0f);
        m_ScrollBarPanelManValue = PlayerPrefsGetFloatm_ScrollBarPanelMan();
    }
    /// <summary>
    /// 주기도문을 보여줄지? 사도신경을 보여줄지?
    /// </summary>
    /// <param name="isLordPrayer"></param>
    void SetLordPrayer(bool isLordPrayer)
    {
        m_PanelLordPrayer.alpha = 1.0f;
        m_ScrollViewLordPrayer.enabled = isLordPrayer ? true : false;
        m_ScrollViewApostlesCreed.enabled = isLordPrayer ? false : true;

        m_ScrollViewLordPrayer.GetComponent<UIPanel>().alpha = isLordPrayer ? 1.0f : 0.0f;
        m_ScrollViewApostlesCreed.GetComponent<UIPanel>().alpha = isLordPrayer ? 0.0f : 1.0f;
        m_ScrollViewLordPrayer.ResetPosition();
        m_ScrollViewApostlesCreed.ResetPosition();

        m_LabelLordPrayerTitle.text = isLordPrayer ? string.Format("{0}", "주기도문") : string.Format("{0}", "십계명");
    }
    /// <summary>
    /// 주기도문을 보여줌.
    /// </summary>
    public void ButtonLordPrayer()
    {
        SetLordPrayer(true);
    }
    /// <summary>
    /// 사도신경을 보여줌.
    /// </summary>
    public void ButtonApostlesCreed()
    {
        SetLordPrayer(false);
    }
    /// <summary>
    /// 주기도문과 사도신경이 보여지는 패널을 안보이게.
    /// </summary>
    public void ButtonExitPanelLordPrayer()
    {
        // SetRandomBackground();
        m_PanelLordPrayer.alpha = 0.0f;
    }
    /// <summary>
    /// 주기도문과 사도신경이 보이는 패널을 보이게.
    /// </summary>
    public void ButtonPanelLordPrayer()
    {
        m_PanelLordPrayer.alpha = 1.0f;
        m_ScrollViewLordPrayer.ResetPosition();
        m_ScrollViewApostlesCreed.ResetPosition();
    }
    /// <summary>
    /// 옵션패널을 안보이게.
    /// </summary>
    public void ButtonExitPanelOption()
    {
        // SetRandomBackground();
        m_PanelOption.alpha = 0.0f;
    }
    /// <summary>
    /// 옵션패널을 보이게.
    /// </summary>
    public void ButtonOption()
    {
        SetReadBibleDisabled();
        StopIsPlay();
        m_PanelOption.alpha = 1.0f;
        SetBackgroundImagesHalf();
    }
    /// <summary>
    /// 옵션패널이 안보이게 하면서. 성경문장을 보여줌.
    /// </summary>
    public void ButtonQuitOption()
    {
        // SetRandomBackground();
        m_PanelOption.alpha = 0.0f;
        ShowBible(); // 옵션패널이 안보이면 성경을 보여줌
        m_LabelBibleSearchInfo.text = string.Empty;
        inputFieldBibleSearch.value = string.Empty;
    }
    /// <summary>
    /// 구약성서 목록을 보여줌.
    /// </summary>
    public void ButtonBibleChapter()
    {
        SetBackgroundImagesHalf();
        SetReadBibleDisabled();
        StopIsPlay();
        // SetRandomBackground();
        SetPanelAlpla(0, 1, 0);

        if (m_BibleType == EBibleType.OldTestament) ButtonOldTestament();
        else if (m_BibleType == EBibleType.NewTestament) ButtonNewTestament();
    }
    /// <summary>
    /// 성경 문장을 보여줌.
    /// </summary>
    public void ButtonExitPanelBible()
    {
        // SetRandomBackground();
        SetPanelAlpla(1, 0, 0);
    }
    /// <summary>
    /// 스크롤뷰의 성경목록의 챕터들을 삭제해주어서 초기화 해 주고 성경목록 패널로.
    /// </summary>
    public void ButtonExitPanelChapter()
    {
        for (int i = 0; i < m_ChapterItems.Count; i++) Destroy(m_ChapterItems[i].gameObject);

        m_ChapterItems.Clear();
        SetPanelAlpla(0, 1, 0);
    }
    /// <summary>
    /// 앱 종료.
    /// </summary>
    public void ButtonQuit()
    {
        PlayerPrefsSetFloatm_ScrollBarPanelMan(m_ScrollBarPanelMan.value); // 현재 스크롤바의 값을 저장.
        m_ScrollBarPanelManValue = PlayerPrefsGetFloatm_ScrollBarPanelMan();

        Application.Quit();
    }
    /// <summary>
    /// 이전 챕터로 이동.
    /// </summary>
    public void ButtonPrevious()
    {
        SetBackgroundImagesHalf();
        SetLabelShowBibleInit(); // m_PanelShowBible.alpha = 0.0f;
        labelBible.enabled = true;

        readBibleIndex = -1; readBibleSentencesIndex = -1;
        StopIsPlay();

        if (m_BibleType == EBibleType.OldTestament)
        {
            if (m_OldTestamentType == EOldTestamentType.Genesis && m_Chapter == 1) return;

            if (m_Chapter == 1) // 챕터가 1이라면 처음이므로 더이상 함수의 내용을 실행하지 않음.
            {
                int bibleIndex = (int)m_OldTestamentType; // 현재 바이블의 인덱스를 가져옴.
                m_OldTestamentType = (EOldTestamentType)(bibleIndex - 1); // 인덱스를 통해서 이전 바이블을 저장.
                OldTestamentInfo bibleOld = new OldTestamentInfo(); // 구약성서 객체 생성.
                bibleOld = OldTestamentTable.GetByIndex((int)m_OldTestamentType); // 선택된 구약성서의 내용을 가져옴.
                m_MaxChapter = bibleOld.m_Count; // 선택된 구약성서의 맥스카운트를 저장.
                PlayerPrefs.SetInt(EKeyword.m_MaxChapter.ToString(), m_MaxChapter); // 선택된 구약성서의 맥스카운트를 메모리에 저장.
                m_Chapter = m_MaxChapter;
                PlayerPrefs.SetInt(EKeyword.m_Chapter.ToString(), m_Chapter);
                PlayerPrefs.SetString(EKeyword.m_BibleType.ToString(), m_BibleType.ToString());
                PlayerPrefs.SetString(EKeyword.m_OldTestamentType.ToString(), m_OldTestamentType.ToString());
                ShowBible(); // 바이블의 내용을 표시
                return;
            }
            
            m_Chapter--; // 이전 챕터로 감.
            PlayerPrefs.SetInt(EKeyword.m_Chapter.ToString(), m_Chapter);
            PlayerPrefs.SetString(EKeyword.m_BibleType.ToString(), m_BibleType.ToString());
            PlayerPrefs.SetString(EKeyword.m_OldTestamentType.ToString(), m_OldTestamentType.ToString());
            m_Chapter = Mathf.Clamp(m_Chapter, 1, m_MaxChapter); // 챕터는 1과 맥스챕터 사이로 제한.
            ShowBible(); // 바이블의 내용을 표시
        }
        else if (m_BibleType == EBibleType.NewTestament)
        {
            if (m_NewTestamentType == ENewTestamentType.Matthew && m_Chapter == 1) return;

            if (m_Chapter == 1) // 챕터가 1이라면 처음이므로 더이상 함수의 내용을 실행하지 않음.
            {
                int bibleIndex = (int)m_NewTestamentType; // 현재 바이블의 인덱스를 가져옴.
                m_NewTestamentType = (ENewTestamentType)(bibleIndex - 1); // 인덱스를 통해서 이전 바이블을 저장.
                NewTestamentInfo bibleNew = new NewTestamentInfo(); // 구약성서 객체 생성.
                bibleNew = NewTestamentTable.GetByIndex((int)m_NewTestamentType); // 선택된 구약성서의 내용을 가져옴.
                m_MaxChapter = bibleNew.m_Count; // 선택된 구약성서의 맥스카운트를 저장.
                PlayerPrefs.SetInt(EKeyword.m_MaxChapter.ToString(), m_MaxChapter); // 선택된 구약성서의 맥스카운트를 메모리에 저장.
                m_Chapter = m_MaxChapter;
                PlayerPrefs.SetInt(EKeyword.m_Chapter.ToString(), m_Chapter);
                PlayerPrefs.SetString(EKeyword.m_BibleType.ToString(), m_BibleType.ToString());
                PlayerPrefs.SetString(EKeyword.m_NewTestamentType.ToString(), m_NewTestamentType.ToString());
                
                ShowBible(); // 바이블의 내용을 표시
                return;
            }
            
            m_Chapter--; // 이전 챕터로 감.
            PlayerPrefs.SetInt(EKeyword.m_Chapter.ToString(), m_Chapter);
            PlayerPrefs.SetString(EKeyword.m_BibleType.ToString(), m_BibleType.ToString());
            PlayerPrefs.SetString(EKeyword.m_NewTestamentType.ToString(), m_NewTestamentType.ToString());
            m_Chapter = Mathf.Clamp(m_Chapter, 1, m_MaxChapter); // 챕터는 1과 맥스챕터 사이로 제한.
            
            ShowBible(); // 바이블의 내용을 표시
        }

        Invoke("SetScrollbarInit", 0.01f);
    }
    /// <summary>
    /// 성경문장에서 스크롤바 위치를 설정.
    /// </summary>
    void SetScrollbar()
    {
        m_ScrollBarPanelMan.Set(PlayerPrefsGetFloatm_ScrollBarPanelMan());
    }
    /// <summary>
    /// 성경 문장에서 스크롤바 위치 초기화.
    /// </summary>
    void SetScrollbarInit()
    {
        PlayerPrefsSetFloatm_ScrollBarPanelMan(0.0f);

        m_ScrollBarPanelMan.Set(0.0f);
    }

    /// <summary>
    /// 이후 챕터로 이동.
    /// </summary>
    public void ButtonNext()
    {
        SetBackgroundImagesHalf();
        SetLabelShowBibleInit();
        labelBible.enabled = true;

        readBibleIndex = -1; readBibleSentencesIndex = -1;
        StopIsPlay();

        if (m_BibleType == EBibleType.OldTestament)
        {
            if (m_OldTestamentType == EOldTestamentType.Malachi && m_Chapter == m_MaxChapter) return;

            if (m_Chapter == m_MaxChapter) // 챕터가 1이라면 처음이므로 더이상 함수의 내용을 실행하지 않음.
            {
                int bibleIndex = (int)m_OldTestamentType; // 현재 바이블의 인덱스를 가져옴.
                m_OldTestamentType = (EOldTestamentType)(bibleIndex + 1); // 인덱스를 통해서 이전 바이블을 저장.
                OldTestamentInfo bibleOld = new OldTestamentInfo(); // 구약성서 객체 생성.
                bibleOld = OldTestamentTable.GetByIndex((int)m_OldTestamentType); // 선택된 구약성서의 내용을 가져옴.
                m_MaxChapter = bibleOld.m_Count; // 선택된 구약성서의 맥스카운트를 저장.
                PlayerPrefs.SetInt(EKeyword.m_MaxChapter.ToString(), m_MaxChapter); // 선택된 구약성서의 맥스카운트를 메모리에 저장.
                m_Chapter = 1;
                PlayerPrefs.SetInt(EKeyword.m_Chapter.ToString(), m_Chapter);
                PlayerPrefs.SetString(EKeyword.m_BibleType.ToString(), m_BibleType.ToString());
                PlayerPrefs.SetString(EKeyword.m_OldTestamentType.ToString(), m_OldTestamentType.ToString());
                
                ShowBible(); // 바이블의 내용을 표시
                return;
            }
            
            m_Chapter++; // 이후 챕터로 감.
            PlayerPrefs.SetInt(EKeyword.m_Chapter.ToString(), m_Chapter);
            PlayerPrefs.SetString(EKeyword.m_BibleType.ToString(), m_BibleType.ToString());
            PlayerPrefs.SetString(EKeyword.m_OldTestamentType.ToString(), m_OldTestamentType.ToString());
            m_Chapter = Mathf.Clamp(m_Chapter, 1, m_MaxChapter); // 챕터는 1과 맥스챕터 사이로 제한.
            
            ShowBible(); // 바이블의 내용을 표시
        }
        else if (m_BibleType == EBibleType.NewTestament)
        {
            if (m_NewTestamentType == ENewTestamentType.Revelation && m_Chapter == m_MaxChapter) return;

            if (m_Chapter == m_MaxChapter) // 챕터가 1이라면 처음이므로 더이상 함수의 내용을 실행하지 않음.
            {
                int bibleIndex = (int)m_NewTestamentType; // 현재 바이블의 인덱스를 가져옴.
                m_NewTestamentType = (ENewTestamentType)(bibleIndex + 1); // 인덱스를 통해서 이전 바이블을 저장.
                NewTestamentInfo bibleNew = new NewTestamentInfo(); // 구약성서 객체 생성.
                bibleNew = NewTestamentTable.GetByIndex((int)m_NewTestamentType); // 선택된 구약성서의 내용을 가져옴.
                m_MaxChapter = bibleNew.m_Count; // 선택된 구약성서의 맥스카운트를 저장.
                PlayerPrefs.SetInt(EKeyword.m_MaxChapter.ToString(), m_MaxChapter); // 선택된 구약성서의 맥스카운트를 메모리에 저장.
                m_Chapter = 1;
                PlayerPrefs.SetInt(EKeyword.m_Chapter.ToString(), m_Chapter);
                PlayerPrefs.SetString(EKeyword.m_BibleType.ToString(), m_BibleType.ToString());
                PlayerPrefs.SetString(EKeyword.m_NewTestamentType.ToString(), m_NewTestamentType.ToString());
                
                ShowBible(); // 바이블의 내용을 표시
                return;
            }
            
            m_Chapter++; // 이후 챕터로 감.
            PlayerPrefs.SetInt(EKeyword.m_Chapter.ToString(), m_Chapter);
            PlayerPrefs.SetString(EKeyword.m_BibleType.ToString(), m_BibleType.ToString());
            PlayerPrefs.SetString(EKeyword.m_NewTestamentType.ToString(), m_NewTestamentType.ToString());
            m_Chapter = Mathf.Clamp(m_Chapter, 1, m_MaxChapter); // 챕터는 1과 맥스챕터 사이로 제한.
            
            ShowBible(); // 바이블의 내용을 표시
        }

        Invoke("SetScrollbarInit", 0.01f);
    }
    
    /// <summary>
    /// 구약성서를 선택하는 버튼.
    /// </summary>
    public void ButtonOldTestament()
    {
        int KeyWord = GetNationCode(m_NationType);

        if (KeyWord == 13)
        {
            if (m_CheckboxReadBibleKorean.value == true) m_LabelSelectBible.text = string.Format("{0}", "구약성경(The Old Testament)");
            else m_LabelSelectBible.text = string.Format("{0}", "The Old Testament");
        }
        else m_LabelSelectBible.text = string.Format("{0}", "The Old Testament");

        m_TempBibleType = EBibleType.OldTestament; // 구약성서를 선택.
        SetPanelAlpla(0, 1, 0);
        SpawnBibleItems(); // 바이블 아이템들을 생성.
    }
    /// <summary>
    /// 신약성서를 선택하는 버튼.
    /// </summary>
    public void ButtonNewTestament()
    {
        int KeyWord = GetNationCode(m_NationType);

        if (KeyWord == 13)
        {
            if (m_CheckboxReadBibleKorean.value == true) m_LabelSelectBible.text = string.Format("{0}", "신약성경(The New Testament)");
            else m_LabelSelectBible.text = string.Format("{0}", "The New Testament");
        }
        else m_LabelSelectBible.text = string.Format("{0}", "The New Testament");

        m_TempBibleType = EBibleType.NewTestament; // 신약성서를 선택.
        SetPanelAlpla(0, 1, 0);
        SpawnBibleItems(); // 바이블 아이템들을 생성.
    }
    /// <summary>
    /// 성서아이템들을 생성.
    /// </summary>
    void SpawnBibleItems()
    {
        var bibleOld = OldTestamentTable.GetAllList(); // 구약성서의 내용을 가져옴.
        var bibleNew = NewTestamentTable.GetAllList(); // 신약성서의 내용을 가져움.
        
        if (m_TempBibleType == EBibleType.OldTestament) // 만일 구약성서를 선택했다면?
        {
            for (int i = 27; i < 39; i++) m_BibleItems[i].gameObject.SetActive(true);

            for (int i = 0; i < bibleOld.Count; i++)
            {
                if (m_CheckboxReadBibleKorean.value == true)
                {
                    int KeyWord = GetNationCode(m_NationType);

                    if (KeyWord == 1) // English
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1} - {2} Chapters", (i + 1), bibleOld[i].m_English, bibleOld[i].m_Count);
                    else if (KeyWord == 2) // Portuguese
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleOld[i].m_Portuguese, bibleOld[i].m_English, bibleOld[i].m_Count);
                    else if (KeyWord == 3) // Japanese
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleOld[i].m_Japanese, bibleOld[i].m_English, bibleOld[i].m_Count);
                    else if (KeyWord == 4) // German
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleOld[i].m_German, bibleOld[i].m_English, bibleOld[i].m_Count);
                    else if (KeyWord == 5) // Romanian
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleOld[i].m_Romanian, bibleOld[i].m_English, bibleOld[i].m_Count);
                    else if (KeyWord == 6) // French
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleOld[i].m_French, bibleOld[i].m_English, bibleOld[i].m_Count);
                    else if (KeyWord == 7) // Spanish
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleOld[i].m_Spanish, bibleOld[i].m_English, bibleOld[i].m_Count);
                    else if (KeyWord == 8) // Italian
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleOld[i].m_Italian, bibleOld[i].m_English, bibleOld[i].m_Count);
                    else if (KeyWord == 9) // Hungarian
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleOld[i].m_Hungarian, bibleOld[i].m_English, bibleOld[i].m_Count);
                    else if (KeyWord == 10) // Hindi
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleOld[i].m_Hindi, bibleOld[i].m_English, bibleOld[i].m_Count);
                    else if (KeyWord == 11) // Russian
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleOld[i].m_Russian, bibleOld[i].m_English, bibleOld[i].m_Count);
                    else if (KeyWord == 12) // Chinese
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleOld[i].m_Chinese, bibleOld[i].m_English, bibleOld[i].m_Count);
                    else if (KeyWord == 13) // Korean
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} 장", (i + 1), bibleOld[i].m_Korean, bibleOld[i].m_English, bibleOld[i].m_Count);
                }
                else
                    m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1} - {2} Chapters", (i + 1), bibleOld[i].m_English, bibleOld[i].m_Count);

                m_BibleItems[i].OldTestamentType = (EOldTestamentType)i;
                m_BibleItems[i].UILabelBibleNameEnglish.text = string.Format("{0}", bibleOld[i].m_English);
            }
        }
        else if (m_TempBibleType == EBibleType.NewTestament) // 만일 신약성서를 선택했다면?
        {
            // 구약성경은 39권이고 신약성경은 27권이므로 신약성경을 선택하면 바이블아이템의 일부를 안보이게 해줌
            for (int i = 27; i < 39; i++) m_BibleItems[i].gameObject.SetActive(false);

            for (int i = 0; i < bibleNew.Count; i++)
            {
                if (m_CheckboxReadBibleKorean.value == true)
                {
                    int KeyWord = GetNationCode(m_NationType);

                    if (KeyWord == 1) // English
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1} - {2} Chapters", (i + 1), bibleNew[i].m_English, bibleNew[i].m_Count);
                    else if (KeyWord == 2) // Portuguese
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleNew[i].m_Portuguese, bibleNew[i].m_English, bibleNew[i].m_Count);
                    else if (KeyWord == 3) // Japanese
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleNew[i].m_Japanese, bibleNew[i].m_English, bibleNew[i].m_Count);
                    else if (KeyWord == 4) // German
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleNew[i].m_German, bibleNew[i].m_English, bibleNew[i].m_Count);
                    else if (KeyWord == 5) // Romanian
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleNew[i].m_Romanian, bibleNew[i].m_English, bibleNew[i].m_Count);
                    else if (KeyWord == 6) // French
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleNew[i].m_French, bibleNew[i].m_English, bibleNew[i].m_Count);
                    else if (KeyWord == 7) // Spanish
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleNew[i].m_Spanish, bibleNew[i].m_English, bibleNew[i].m_Count);
                    else if (KeyWord == 8) // Italian
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleNew[i].m_Italian, bibleNew[i].m_English, bibleNew[i].m_Count);
                    else if (KeyWord == 9) // Hungarian
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleNew[i].m_Hungarian, bibleNew[i].m_English, bibleNew[i].m_Count);
                    else if (KeyWord == 10) // Hindi
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleNew[i].m_Hindi, bibleNew[i].m_English, bibleNew[i].m_Count);
                    else if (KeyWord == 11) // Russian
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleNew[i].m_Russian, bibleNew[i].m_English, bibleNew[i].m_Count);
                    else if (KeyWord == 12) // Chinese
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} Chapters", (i + 1), bibleNew[i].m_Chinese, bibleNew[i].m_English, bibleNew[i].m_Count);
                    else if (KeyWord == 13) // Korean
                        m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1}({2}) - {3} 장", (i + 1), bibleNew[i].m_Korean, bibleNew[i].m_English, bibleNew[i].m_Count);
                }
                else
                    m_BibleItems[i].UILabelBibleName.text = string.Format("{0}. {1} - {2} Chapters", (i + 1), bibleNew[i].m_English, bibleNew[i].m_Count);

                m_BibleItems[i].NewTestamentType = (ENewTestamentType)i;
                m_BibleItems[i].UILabelBibleNameEnglish.text = string.Format("{0}", bibleNew[i].m_English);
            }
        }

        m_ScrollViewBible.ResetPosition(); // m_ScrollViewBible설정이 TopLeft로 되어 있어야 함. 스크롤바의 위치로도 할 수 있음. 
        m_UIGridBible.enabled = true;
        m_UIGridBible.Reposition();
        m_UIGridBible.repositionNow = true;
    }
    /// <summary>
    /// 챕터아이템들을 생성.
    /// </summary>
    public void SpawnBibleChapter()
    {
        var bibleOld = OldTestamentTable.GetAllList(); // 엑셀 테이블의 내용을 가져옴. 
        var bibleNew = NewTestamentTable.GetAllList(); // 엑셀 테이블의 내용을 가져옴. 

        if (m_TempBibleType == EBibleType.OldTestament) // 만일 현재 임시로 선택된 성경이 구약성경이라면?
        {   
            int count = bibleOld[(int)m_TempOldTestamentType].m_Count;  // 구약성경중에 어느 성경이 선택되었는지 알기 위해서 몇장으로 이루어졌는지? 
            SpawnChapterItemes(count); // 장수만큼 아이템 생성.  
        }
        else if (m_TempBibleType == EBibleType.NewTestament) // 만일 현재 임시로 선택된 성경이 신약성경이라면?
        {   
            int count = bibleNew[(int)m_TempNewTestamentType].m_Count; // 신약성경중에 어느 성경이 선택되었는지 알기 위해서 몇장으로 이루어졌는지? 
            SpawnChapterItemes(count);  // 장수만큼 아이템 생성.  
        }

        m_ScrollViewChapter.ResetPosition();    // 스크롤뷰 초기화. 
        m_UIGridChapter.enabled = true;         // 스크롤뷰 초기화. 
        m_UIGridChapter.repositionNow = true;   // 스크롤뷰 초기화. 
        m_UIGridChapter.Reposition();           // 스크롤뷰 초기화. 
    }
    /// <summary>
    /// count에 해당하는 만큼 아이템들 생성
    /// </summary>
    /// <param name="count"></param>
    void SpawnChapterItemes(int count)
    {
        for (int i = 0; i < count; i++)
        {
            ChapterItem chapterItem = Instantiate(m_ChapterItemPrefab);
            chapterItem.name = m_ChapterItemPrefab.name;
            chapterItem.transform.SetParent(m_UIGridChapter.transform);
            chapterItem.transform.localPosition = m_ChapterItemPrefab.transform.localPosition;
            chapterItem.transform.localRotation = m_ChapterItemPrefab.transform.localRotation;
            chapterItem.transform.localScale = m_ChapterItemPrefab.transform.localScale;
            chapterItem.Init(i + 1);

            m_ChapterItems.Add(chapterItem); // 생성된 아이템들을 관리를 위해서 배열에 추가. 
        }
    }

    /// 
    /// </summary>
    /// <param name="value"></param>
    void PlayerPrefsSetIntOldKoreanBible(int value)
    {
        PlayerPrefs.SetInt(EKeyword.OldKoreanBible.ToString(), value);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="value"></param>
    void PlayerPrefsSetIntOldEnglishBible(int value)
    {
        PlayerPrefs.SetInt(EKeyword.OldEnglishBible.ToString(), value);
    }
    /// <summary>
    /// 성경 읽어주는 것을 멈춤
    /// </summary>
    public void StopIsPlay()
    {
        SetLabelShowBibleInit();
        m_CheckboxReadBible.value = false;
        isPlay = false;
        StopAllCoroutines();
        audioSource.Stop();
    }
    /// <summary>
    /// 
    /// </summary>
    void SetReadBibleEnabled()
    {
        labelBible.enabled = false;
    }
    /// <summary>
    /// 
    /// </summary>
    void SetReadBibleDisabled()
    {
        readBibleIndex = -1; readBibleSentencesIndex = -1;
        SetLabelShowBibleInit();
        labelBible.enabled = true;
        StopIsPlay();
    }
    /// <summary>
    ///  문장이 몇 문자로 이루어졌는지 표시. 
    /// </summary>
    public UILabel m_TempTemp;
    /// <summary>
    /// 화살표 키로 한글 성경의 절을 수동으로 플레이했을 때 
    /// </summary>
    /// <param name="CollectStrings"></param>
    /// <param name="DelayTimes"></param>
    /// <returns></returns>
    IEnumerator DownloadTheAudioForKorean(List<string> CollectStrings, float[] DelayTimes)
    {
        // SetRandomBackground();

        for (int i = 0; i < DelayTimes.Length; i++)
        {
            string url = @"https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + CollectStrings[i] + GetNationVoice(m_NationType);

            using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.MPEG))
            {
                yield return www.SendWebRequest();

                if (www.result == UnityWebRequest.Result.Success)
                {
                    AudioClip clip = DownloadHandlerAudioClip.GetContent(www);
                    
                    if (clip != null)
                    {
                        audioSource.clip = clip;
                        audioSource.pitch = 1.0f;
                        audioSource.Play();
                    }
                    else Debug.LogError("DownloadHandlerAudioClip.GetContent returned null");
                }
                else Debug.LogError("Error: " + www.error);
            }
            yield return new WaitForSeconds(CollectStrings[i].Length * DelayTimes[i]);
        }
    }
    /// <summary>
    /// 화살표 키로 영문 성경의 절을 수동으로 플레이했을 때 
    /// </summary>
    /// <param name="CollectStrings"></param>
    /// <param name="DelayTimes"></param>
    /// <returns></returns>
    IEnumerator DownloadTheAudioForEnglish(List<string> CollectStrings, float[] DelayTimes)
    {
        // SetRandomBackground();

        for (int i = 0; i < DelayTimes.Length; i++)
        {
            string url = @"https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + CollectStrings[i] + GetNationVoice(ENationType.English);
            
            using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.MPEG))
            {
                yield return www.SendWebRequest();

                if (www.result == UnityWebRequest.Result.Success)
                {
                    AudioClip clip = DownloadHandlerAudioClip.GetContent(www);
                   
                    if (clip != null)
                    {
                        audioSource.clip = clip;
                        audioSource.pitch = 1.0f;
                        audioSource.Play();
                    }
                    else Debug.LogError("DownloadHandlerAudioClip.GetContent returned null");
                }
                else Debug.LogError("Error: " + www.error);
            }
            yield return new WaitForSeconds(CollectStrings[i].Length * DelayTimes[i]);
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    IEnumerator DownloadTheAudio()
    {
        // SetRandomBackground();

        for (int i = 0; i < collectKorean.Count; i++)
        {
            if (i >= collectKorean.Count)
            {
                isPlay = false;
                m_CheckboxReadBible.value = false;
                StopAllCoroutines();
                yield break;
            }

            if (isPlay == false)
            {
                m_CheckboxReadBible.value = false;
                StopAllCoroutines();
                yield break;
            }

            int KeyWord = GetNationCode(m_NationType);

            // 인덱스는 0부터 시작하므로 최종절은 collectKorean.Count - 1 입니다. 
            // 인덱스는 0부터 시작하지만 절은 1부터 시작하므로 최초의 절은 i + 1입니다. 
            if (m_CheckboxReadBibleKorean.value == true)
                m_LabelBibleInfo.text = string.Format("{0}({1}) {2}:{3}({4})", bibleName, bibleNameEnglish, bibleChapter, i + 1, collectKorean.Count - 1);
            else
            {
                // if (string.IsNullOrEmpty(bibleName))
                m_LabelBibleInfo.text = string.Format("{0} {1}:{2}({3})", bibleNameEnglish, bibleChapter, i + 1, collectKorean.Count - 1);
                // else
                // m_LabelBibleInfo.text = string.Format("{0}({1}) {2}:{3}({4})", bibleNameEnglish, bibleName, bibleChapter, i + 1, collectKorean.Count - 1);
            }

            List<string> CollectKoreanEnglish = new List<string>();

            if (m_CheckboxReadBibleKorean.value == true)
            {
                CollectKoreanEnglish.Add(collectKorean[i]);
                CollectKoreanEnglish.Add(string.Empty);
                CollectKoreanEnglish.Add(collectEnglish[i]);
            }
            else
            {
                CollectKoreanEnglish.Add(collectEnglish[i]);
                CollectKoreanEnglish.Add(string.Empty);
                CollectKoreanEnglish.Add(collectKorean[i]);
            }

            StringBuilder stringBuilder = new StringBuilder(); // 스트링빌더 객체 생성.

            for (int j = 0; j < CollectKoreanEnglish.Count; j++) // 최종리스트를 대상으로 반복문 처리.
                stringBuilder.AppendLine(CollectKoreanEnglish[j]);

            m_LabelShowBible.text = stringBuilder.ToString(); // 성격의 내용을 표시.

            if (m_CheckboxReadBible.value)
            {
                if (isPlayKorean)
                {
                    // LabelTempTemp.text = collectKorean[i]; // 확인해야 함. 

                    SetRandomBackground();
                    if (!string.IsNullOrEmpty(collectKorean[i]))
                    {
                        if (collectKorean[i].Length < 200)
                        {
                            if (IsDebug)
                                m_TempTemp.text = "" + collectKorean[i].Length;
                            else
                                m_TempTemp.text = string.Empty;

                            string url = @"https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + collectKorean[i] + GetNationVoice(m_NationType);

                            using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.MPEG))
                            {
                                yield return www.SendWebRequest();

                                if (www.result == UnityWebRequest.Result.Success)
                                {
                                    AudioClip clip = DownloadHandlerAudioClip.GetContent(www);

                                    if (clip != null)
                                    {
                                        audioSource.clip = clip;
                                        audioSource.pitch = 1.0f;
                                        audioSource.Play();
                                    }
                                    else Debug.LogError("DownloadHandlerAudioClip.GetContent returned null");
                                }
                                else Debug.LogError("Error: " + www.error);
                            }
                            yield return new WaitForSeconds(collectKorean[i].Length * GetDelayEnd(m_NationType));
                        }

                        if (collectKorean[i].Length >= 200)
                        {
                            List<string> tempCollect = ReturnOver200CharactersResult(collectKorean[i]);
                            string temmpCount = string.Empty;

                            for (int k = 0; k < tempCollect.Count; k++) temmpCount += tempCollect[k].Length + ",";

                            if (IsDebug)
                                m_TempTemp.text = temmpCount;
                            else
                                m_TempTemp.text = string.Empty;

                            if (tempCollect.Count == 2)
                            {
                                float[] TempDelay = { GetDelayMiddle(m_NationType), GetDelayEnd(m_NationType) };
                                StartCoroutine(DownloadTheAudioForKorean(tempCollect, TempDelay));
                            }
                            else if (tempCollect.Count == 3)
                            {
                                float[] TempDelay = { GetDelayMiddle(m_NationType), GetDelayMiddle(m_NationType), GetDelayEnd(m_NationType) };
                                StartCoroutine(DownloadTheAudioForKorean(tempCollect, TempDelay));
                            }
                            else if (tempCollect.Count == 4)
                            {
                                float[] TempDelay = { GetDelayMiddle(m_NationType), GetDelayMiddle(m_NationType), GetDelayMiddle(m_NationType), GetDelayEnd(m_NationType) };
                                StartCoroutine(DownloadTheAudioForKorean(tempCollect, TempDelay));
                            }
                            yield return new WaitForSeconds(collectKorean[i].Length * GetDelayEnd(m_NationType));
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        isPlay = false;
                        m_CheckboxReadBible.value = false;
                        StopAllCoroutines();
                        yield break;
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(collectEnglish[i]))
                    {
                        // LabelTempTemp.text = collectEnglish[i]; // 확인해야 함. 

                        SetRandomBackground();
                        if (collectEnglish[i].Length < 200)
                        {
                            if (IsDebug)
                                m_TempTemp.text = "" + collectEnglish[i].Length;
                            else
                                m_TempTemp.text = string.Empty;

                            string url = @"https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + collectEnglish[i] + GetNationVoice(ENationType.English); ;

                            using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.MPEG))
                            {
                                yield return www.SendWebRequest();

                                if (www.result == UnityWebRequest.Result.Success)
                                {
                                    AudioClip clip = DownloadHandlerAudioClip.GetContent(www);

                                    if (clip != null)
                                    {
                                        audioSource.clip = clip;
                                        audioSource.pitch = 1.0f;
                                        audioSource.Play();
                                    }
                                    else Debug.LogError("DownloadHandlerAudioClip.GetContent returned null");
                                }
                                else Debug.LogError("Error: " + www.error);
                            }
                            yield return new WaitForSeconds(collectEnglish[i].Length * GetDelayEnd(ENationType.English));
                        }

                        if (collectEnglish[i].Length >= 200)
                        {
                            List<string> tempCollect = ReturnOver200CharactersResult(collectEnglish[i]);
                            string temmpCount = string.Empty;

                            for (int k = 0; k < tempCollect.Count; k++) temmpCount += tempCollect[k].Length + ",";

                            if (IsDebug)
                                m_TempTemp.text = temmpCount;
                            else
                                m_TempTemp.text = string.Empty;

                            if (tempCollect.Count == 2)
                            {
                                float[] TempDelay = { GetDelayMiddle(m_NationType), 0.2f };
                                StartCoroutine(DownloadTheAudioForEnglish(tempCollect, TempDelay));
                            }
                            else if (tempCollect.Count == 3)
                            {
                                float[] TempDelay = { GetDelayMiddle(m_NationType), GetDelayMiddle(m_NationType), 0.2f };
                                StartCoroutine(DownloadTheAudioForEnglish(tempCollect, TempDelay));
                            }
                            else if (tempCollect.Count == 4)
                            {
                                float[] TempDelay = { GetDelayMiddle(m_NationType), GetDelayMiddle(m_NationType), GetDelayMiddle(m_NationType), 0.2f };
                                StartCoroutine(DownloadTheAudioForEnglish(tempCollect, TempDelay));
                            }
                            yield return new WaitForSeconds(collectEnglish[i].Length * 0.2f);
                        }
                        else
                        {

                        }
                    }
                    else
                    {
                        isPlay = false;
                        m_CheckboxReadBible.value = false;
                        StopAllCoroutines();
                        yield break;
                    }
                }
            }
        }
    }

    /// <summary>
    /// ButtonBibleSearch에서 신약성서인지? 구약성서인지?
    /// </summary>
    public bool IsNewTastament = false;
    /// <summary>
    /// 전체 구약성경에서 단어로 검색
    /// </summary>
    public void ButtonBibleSearchOldTastament()
    {
        IsNewTastament = false;
        ButtonBibleSearch();
    }
    /// <summary>
    /// 전체 신약성경에서 단어로 검색
    /// </summary>
    public void ButtonBibleSearchNewTastament()
    {
        IsNewTastament = true;
        ButtonBibleSearch();
    }
    /// <summary>
    /// 전체 구약성경이나 전체 신약성경에서 단어로 검색하기 위한
    /// </summary>
    void ButtonBibleSearch()
    {
        SetBibleInfoSearchFor();
        TextAsset[] CollectAllFiles = Resources.LoadAll<TextAsset>(m_KoreanBibleSearchFor); // 바이블 텍스트에셋을 모두 불러옵니다. 
        List<string> collectKoreanEnglish = new List<string>(); // 텍스트에셋을 문자열 배열로 변경해서 저장할 배열입니다. 
        List<string> CollectSearchForWordInBible = new List<string>(); // 성경 문자열에 찾을 문자열이 포함되어 있다면 성경 문자열을 저장할 배열입니다. 
        string outputFilePath = string.Empty;
        string searchForWord = inputFieldBibleSearch.value;  // 찾을 문자열을 저장합니다. 
        m_LabelBibleSearchInfo.text = "\"" + searchForWord + "\"" + " is no Existed. !!"; // 초기화 해 줌.

        if (!string.IsNullOrEmpty(inputFieldBibleSearch.value))
        {
            CollectSearchForWordInBible.Clear();
            
            for (int i = 0; i < CollectAllFiles.Length; i++) // 모든 성경 텍스트에셋을 대상으로 반복문 처리합니다. 
            {
                string textValue = CollectAllFiles[i].text; // 성경 텍스트에셋을 문자열로 변경해서 저장합니다. 
                collectKoreanEnglish.Clear();
                collectKoreanEnglish = new List<string>(textValue.Split('\n'));  // 문자열을 \n로 구분한 뒤 배열에 저장합니다. 

                for (int j = 0; j < collectKoreanEnglish.Count; j++) // 배열을 대상으로 반복문 처리합니다. 
                {
                    if (collectKoreanEnglish[j].Contains(searchForWord)) // 만일 성경 문자열에 찾을 문자열이 포함 되어 있다면? 
                    {
                        string FileName = Path.GetFileNameWithoutExtension(CollectAllFiles[i].name);
                        CollectSearchForWordInBible.Add(collectKoreanEnglish[j]);
                        CollectSearchForWordInBible.Add(FileName + ":" + (j + 1)); // 인덱스는 0부터 시작하지만 절은 1절부터 시작하므로
                        CollectSearchForWordInBible.Add(string.Empty);
                    }
                }
            }
        }

        if (CollectSearchForWordInBible.Count > 0)
        {
            string folderPath = @"c:\Bible\BibleSearch\" + m_KoreanBible; // 결과를 저장할 폴더입니다. 
            DirectoryInfo di = new DirectoryInfo(folderPath);

            if (di.Exists == false) di.Create(); // 만약 폴더가 존재하지 않으면 

            if (IsNewTastament) outputFilePath = folderPath + searchForWord + "(" + "The New Testament" + ")" + ".txt"; // 저장될 파일 이름입니다. 
            else outputFilePath = folderPath + searchForWord + "(" + "The Old Testament" + ")" + ".txt";

            StreamWriter writer = new StreamWriter(outputFilePath);

            for (int j = 0; j < CollectSearchForWordInBible.Count; j++) writer.WriteLine(CollectSearchForWordInBible[j].Trim());

            writer.Close();
            Application.OpenURL(@"File://" + outputFilePath);
            m_LabelBibleSearchInfo.text = "\"" + searchForWord + "\"" + "is " + CollectSearchForWordInBible.Count / 2 + " Existed. \n" + outputFilePath + " is Saved. ";
        }
        CollectAllFiles = Resources.LoadAll<TextAsset>(m_EnglishBibleSearchFor); // 바이블 텍스트에셋을 모두 불러옵니다. 
        collectKoreanEnglish = new List<string>(); // 텍스트에셋을 문자열 배열로 변경해서 저장할 배열입니다. 
        CollectSearchForWordInBible.Clear(); // 성경 문자열에 찾을 문자열이 포함되어 있다면 성경 문자열을 저장할 배열입니다. 
        searchForWord = inputFieldBibleSearch.value; // 찾을 문자열을 저장합니다. 
        
        if (!string.IsNullOrEmpty(inputFieldBibleSearch.value))
        {
            for (int i = 0; i < CollectAllFiles.Length; i++) // 모든 성경 텍스트에셋을 대상으로 반복문 처리합니다.
            {
                string textValue = CollectAllFiles[i].text; // 성경 텍스트에셋을 문자열로 변경해서 저장합니다. 
                collectKoreanEnglish = new List<string>(textValue.Split('\n')); // 문자열을 \n로 구분한 뒤 배열에 저장합니다. 
                
                for (int j = 0; j < collectKoreanEnglish.Count; j++) // 배열을 대상으로 반복문 처리합니다. 
                {
                    if (collectKoreanEnglish[j].Contains(searchForWord)) // 만일 성경 문자열에 찾을 문자열이 포함 되어 있다면? 
                    {
                        CollectSearchForWordInBible.Add(collectKoreanEnglish[j]);
                        string FileName = Path.GetFileNameWithoutExtension(CollectAllFiles[i].name);
                        CollectSearchForWordInBible.Add(FileName + ":" + (j + 1)); // 인덱스는 0부터 시작하지만 절은 1절부터 시작하므로
                        CollectSearchForWordInBible.Add(string.Empty);
                    }
                }
            }
        }

        if (CollectSearchForWordInBible.Count > 0)
        {
            string folderPath = @"c:\Bible\BibleSearch\" + m_EnglishBible; // 결과를 저장할 폴더입니다. 
            DirectoryInfo di = new DirectoryInfo(folderPath);

            if (di.Exists == false) di.Create(); // 만약 폴더가 존재하지 않으면

            if (IsNewTastament) outputFilePath = folderPath + searchForWord + "(" + "The NewTastament" + ")" + ".txt";
            else outputFilePath = folderPath + searchForWord + "(" + "The OldTastament" + ")" + ".txt";

            StreamWriter writer = new StreamWriter(outputFilePath);

            for (int j = 0; j < CollectSearchForWordInBible.Count; j++) writer.WriteLine(CollectSearchForWordInBible[j].Trim());

            writer.Close();
            Application.OpenURL(@"File://" + outputFilePath);
            m_LabelBibleSearchInfo.text = "\"" + searchForWord + "\"" + " is " + CollectSearchForWordInBible.Count / 2 + " Existed. \n" + outputFilePath + " is Saved. ";
        }
    }
    /// <summary>
    /// 정리해 놓은 성경 문장에서 단어로 검색
    /// </summary>
    void ButtonBibleSearchBible()
    {
        string searchWorld = inputFieldBibleSearch.value; // 찾을 문자열을 저장합니다. 
        string[] CollectAllFilesTemp = Directory.GetFiles(@"d:\Bible\Info\GraceResult", "*.txt", SearchOption.AllDirectories);
        List<string> CollectAllFiles = new List<string>();

        for (int i = 0; i < CollectAllFilesTemp.Length; i++)
        {
            string fileName = Path.GetFileNameWithoutExtension(CollectAllFilesTemp[i]); // 경로를 빼고 파일의 이름을 가져옵니다. 
            CollectAllFiles.Add(fileName);
        }

        CollectAllFiles.Sort();
        List<string> collectKoreanEnglish = new List<string>(); // 텍스트에셋을 문자열 배열로 변경해서 저장할 배열입니다. 
        List<string> CollectSearchForWordInBible = new List<string>(); // 성경 문자열에 찾을 문자열이 포함되어 있다면 성경 문자열을 저장할 배열입니다. 
        string outputFilePath = string.Empty;
        CollectSearchForWordInBible.Clear();

        for (int i = 0; i < CollectAllFiles.Count; i++) // 모든 성경 텍스트에셋을 대상으로 반복문 처리합니다. 
        {
            string textValue = CollectAllFiles[i]; // 성경 텍스트에셋을 문자열로 변경해서 저장합니다. 
            collectKoreanEnglish.Clear();
            collectKoreanEnglish = new List<string>(textValue.Split('\n')); // 문자열을 \n로 구분한 뒤 배열에 저장합니다. 

            for (int j = 0; j < collectKoreanEnglish.Count; j++) // 배열을 대상으로 반복문 처리합니다. 
            {
                if (collectKoreanEnglish[j].Contains(searchWorld)) // 만일 성경 문자열에 찾을 문자열이 포함 되어 있다면? 
                {
                    CollectSearchForWordInBible.Add(CollectAllFiles[i]);
                    CollectSearchForWordInBible.Add(string.Empty);
                }
            }
        }

        if (CollectSearchForWordInBible.Count > 0)
        {
            string folderPath = @"d:\Bible\Info\BibleSearch\"; // 결과를 저장할 폴더입니다. 
            DirectoryInfo di = new DirectoryInfo(folderPath);

            if (di.Exists == false) di.Create(); // 만약 폴더가 존재하지 않으면

            outputFilePath = folderPath + "(" + searchWorld + ")" + ".txt"; // 저장될 파일 이름입니다. 
            StreamWriter writer = new StreamWriter(outputFilePath);

            for (int j = 0; j < CollectSearchForWordInBible.Count; j++) writer.WriteLine(CollectSearchForWordInBible[j].Trim());

            writer.Close();
            Application.OpenURL(@"File://" + outputFilePath);
        }
    }
    
    /// <summary>
    /// 화살표 좌, 우 키를 눌렀을 때 문장이 나오는데, 문장이 들어있는 배열의 인덱스
    /// </summary>
    public int readBibleIndex = 1;

    public int intCount = 0;

    IEnumerator ReadSelectBible(string message)
    {
        // SetRandomBackground();

        if (message.Length < 200)
        {
            if (IsDebug)
                m_TempTemp.text = "" + message.Length;
            else
                m_TempTemp.text = string.Empty;
        }

        if (message.Length >= 200)
        {
            List<string> tempCollect = ReturnOver200CharactersResult(message);
            string temmpCount = string.Empty;

            for (int i = 0; i < tempCollect.Count; i++) temmpCount += tempCollect[i].Length + ",";

            if (IsDebug)
                m_TempTemp.text = temmpCount;
            else
                m_TempTemp.text = string.Empty;

            if (CanSoundPlay)
            {
                if (tempCollect.Count == 2)
                {
                    float[] TempDelay = { GetDelayMiddle(ENationType.English), 0 };
                    StartCoroutine(DownloadTheAudioForEnglish(tempCollect, TempDelay));
                }
                else if (tempCollect.Count == 3)
                {
                    float[] TempDelay = { GetDelayMiddle(ENationType.English), GetDelayMiddle(ENationType.English), 0 };
                    StartCoroutine(DownloadTheAudioForEnglish(tempCollect, TempDelay));
                }
                else if (tempCollect.Count == 4)
                {
                    float[] TempDelay = { GetDelayMiddle(ENationType.English), GetDelayMiddle(ENationType.English), GetDelayMiddle(ENationType.English), 0 };
                    StartCoroutine(DownloadTheAudioForEnglish(tempCollect, TempDelay));
                }
            }
        }
        else
        {
            if (CanSoundPlay)
            {
                string url = @"https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + message + GetNationVoice(ENationType.English);

                using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.MPEG))
                {
                    yield return www.SendWebRequest();

                    if (www.result == UnityWebRequest.Result.Success)
                    {
                        
                        AudioClip clip = DownloadHandlerAudioClip.GetContent(www);
                        if (clip != null)
                        {
                            audioSource.clip = clip;
                            audioSource.pitch = 1.0f;
                            audioSource.Play();
                        }
                        else Debug.LogError("DownloadHandlerAudioClip.GetContent returned null");
                    }
                    else Debug.LogError("Error: " + www.error);  
                }
            }
        }
    }

    IEnumerator ReadSelectBibleKorean(string message)
    {
        // SetRandomBackground();

        if (message.Length < 200)
        {
            if (IsDebug)
                m_TempTemp.text = "" + message.Length;
            else
                m_TempTemp.text = string.Empty;
        }

        if (message.Length >= 200)
        {
            List<string> tempCollect = ReturnOver200CharactersResult(message);
            string temmpCount = string.Empty;

            for (int i = 0; i < tempCollect.Count; i++) temmpCount += tempCollect[i].Length + ",";

            if (IsDebug)
                m_TempTemp.text = temmpCount;
            else
                m_TempTemp.text = string.Empty;

            if (CanSoundPlay)
            {
                if (tempCollect.Count == 2)
                {
                    float[] TempDelay = { GetDelayMiddle(m_NationType), 0 };
                    StartCoroutine(DownloadTheAudioForKorean(tempCollect, TempDelay));

                }
                else if (tempCollect.Count == 3)
                {
                    float[] TempDelay = { GetDelayMiddle(m_NationType), GetDelayMiddle(m_NationType), 0 };
                    StartCoroutine(DownloadTheAudioForKorean(tempCollect, TempDelay));
                }
                else if (tempCollect.Count == 4)
                {
                    float[] TempDelay = { GetDelayMiddle(m_NationType), GetDelayMiddle(m_NationType), GetDelayMiddle(m_NationType), 0 };
                    StartCoroutine(DownloadTheAudioForKorean(tempCollect, TempDelay));
                }
            }
        }
        else
        {
            if (CanSoundPlay)
            {
                string url = @"https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + message + GetNationVoice(m_NationType);

                using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.MPEG))
                {
                    yield return www.SendWebRequest();

                    if (www.result == UnityWebRequest.Result.Success)
                    {
                        AudioClip clip = DownloadHandlerAudioClip.GetContent(www);
                        
                        if (clip != null)
                        {
                            audioSource.clip = clip;
                            audioSource.pitch = 1.0f;
                            audioSource.Play();
                        }
                        else Debug.LogError("DownloadHandlerAudioClip.GetContent returned null");
                    }
                    else Debug.LogError("Error: " + www.error);
                }
            }
        }
    }

    public List<string> bibleSentenceEnglish = new List<string>();
    public List<string> bibleSentenceKorean = new List<string>();

    public List<TextAsset> bibleSentences = new List<TextAsset>();
    public int bibleSentencesIndex = 0;
    public int readBibleSentencesIndex = -1; // 사용하지 않음.

    public string m_BibleMessage;

    public int TestimonyIndex = 0;

    public string BibleMessageFirst;
    public string BibleMessageSecond;
    public string BibleMessageThird;

    void ShowPrevious()
    {
        SetRandomBackground();

        if (m_CheckboxReadBible.value == true) return; // 성경을 자동으로 읽어주지 않을 때만 수동으로 보여줌

        InitPanel();
        SetReadBibleEnabled();
        SetLabelShowBible();
        --readBibleIndex;

        if (readBibleIndex < 0) readBibleIndex = 0;

        // 인덱스는 0부터 시작하므로 최종절은 collectKorean.Count - 1 입니다. 
        // 인덱스는 0부터 시작하지만 절은 1부터 시작하므로 최초의 절은 i + 1입니다. 
        // m_LabelBibleInfo.text = string.Format("{0}({1}) {2}:{3}({4})", bibleName, bibleNameEnglish, bibleChapter, readBibleIndex + 1, collectKorean.Count - 1);
        if (m_CheckboxReadBibleKorean.value == true)
            m_LabelBibleInfo.text = string.Format("{0}({1}) {2}:{3}({4})", bibleName, bibleNameEnglish, bibleChapter, readBibleIndex + 1, collectKorean.Count - 1);
        else
        {
            //if (!string.IsNullOrEmpty(bibleName))
            //    m_LabelBibleInfo.text = string.Format("{0}({1}) {2}:{3}({4})", bibleNameEnglish, bibleName, bibleChapter, readBibleIndex + 1, collectKorean.Count - 1);
            //else
                m_LabelBibleInfo.text = string.Format("{0} {1}:{2}({3})", bibleNameEnglish, bibleChapter, readBibleIndex + 1, collectKorean.Count - 1);

        }

        BibleMessageFirst = collectKorean[readBibleIndex].TrimEnd() + " -" + bibleName + "(" + bibleNameSource + ")" + " " + bibleChapter + "장 " + (readBibleIndex + 1) + "절-";
        BibleMessageSecond = collectEnglish[readBibleIndex].TrimEnd() + " -" + bibleNameEnglish + "(" + bibleNameSourceEnglish + ")" + " " + bibleChapter + ":" + (readBibleIndex + 1) + "-"; ;
        BibleMessageThird = bibleName + "(" + bibleNameEnglish + ") " + bibleChapter + ":" + (readBibleIndex + 1);
        OnlyBibleEnglish = collectEnglish[readBibleIndex];
        OnlyBibleKorean = collectKorean[readBibleIndex];

        List<string> CollectKoreanEnglish = new List<string>();

        if (m_CheckboxReadBibleKorean.value == true)
        {
            CollectKoreanEnglish.Add(collectKorean[readBibleIndex]); // + "\n - " + bibleNameEnglish + " " + bibleChapter + ":" + (readBibleIndex + 1) + " - ");
            CollectKoreanEnglish.Add(string.Empty);
            CollectKoreanEnglish.Add(collectEnglish[readBibleIndex]); //+ "\n - " + bibleName + " " + bibleChapter + "장 " + (readBibleIndex + 1) + "절  - ");
            StartCoroutine(ReadSelectBibleKorean(collectKorean[readBibleIndex]));
        }
        else
        {
            CollectKoreanEnglish.Add(collectEnglish[readBibleIndex]); // + "\n - " + bibleNameEnglish + " " + bibleChapter + ":" + (readBibleIndex + 1) + " - ");
            CollectKoreanEnglish.Add(string.Empty);
            CollectKoreanEnglish.Add(collectKorean[readBibleIndex]); //+ "\n - " + bibleName + " " + bibleChapter + "장 " + (readBibleIndex + 1) + "절  - ");
            StartCoroutine(ReadSelectBible(collectEnglish[readBibleIndex]));
        }
        
        StringBuilder stringBuilder = new StringBuilder(); // 스트링빌더 객체 생성.
        
        for (int j = 0; j < CollectKoreanEnglish.Count; j++) stringBuilder.AppendLine(CollectKoreanEnglish[j]); // 최종리스트를 대상으로 반복문 처리.

        m_LabelShowBible.text = stringBuilder.ToString(); // 성격의 내용을 표시.
    }

    public string OnlyBibleEnglish = string.Empty;
    public string OnlyBibleKorean = string.Empty;

    void ShowNext()
    {
        SetRandomBackground();

        if (m_CheckboxReadBible.value == true) return; // 성경을 자동으로 읽어주지 않을 때만 수동으로 보여줌

        InitPanel();
        SetReadBibleEnabled();
        SetLabelShowBible();
        ++readBibleIndex;

        if (readBibleIndex >= collectKorean.Count - 1)
        {
            ButtonNext();
            ShowNext();
            return;
        }

        // 인덱스는 0부터 시작하므로 최종절은 collectKorean.Count - 1 입니다. 
        // 인덱스는 0부터 시작하지만 절은 1부터 시작하므로 최초의 절은 i + 1입니다. 
        if (m_CheckboxReadBibleKorean.value == true)
            m_LabelBibleInfo.text = string.Format("{0}({1}) {2}:{3}({4})", bibleName, bibleNameEnglish, bibleChapter, readBibleIndex + 1, collectKorean.Count - 1);
        else
        {
            //if (!string.IsNullOrEmpty(bibleName))
            //    m_LabelBibleInfo.text = string.Format("{0}({1}) {2}:{3}({4})", bibleNameEnglish, bibleName, bibleChapter, readBibleIndex + 1, collectKorean.Count - 1);
            //else
                m_LabelBibleInfo.text = string.Format("{0} {1}:{2}({3})", bibleNameEnglish, bibleChapter, readBibleIndex + 1, collectKorean.Count - 1);

        }

        BibleMessageFirst = collectKorean[readBibleIndex].TrimEnd() + " -" + bibleName + "(" + bibleNameSource + ")" + " " + bibleChapter + "장 " + (readBibleIndex + 1) + "절-";
        BibleMessageSecond = collectEnglish[readBibleIndex].TrimEnd() + " -" + bibleNameEnglish + "(" + bibleNameSourceEnglish + ")" + " " + bibleChapter + ":" + (readBibleIndex + 1) + "-";
        BibleMessageThird = bibleName + "(" + bibleNameEnglish + ") " + bibleChapter + ":" + (readBibleIndex + 1);
        OnlyBibleEnglish = collectEnglish[readBibleIndex];
        OnlyBibleKorean = collectKorean[readBibleIndex];

        List<string> CollectKoreanEnglish = new List<string>();

        if (m_CheckboxReadBibleKorean.value == true)
        {
            CollectKoreanEnglish.Add(collectKorean[readBibleIndex]); // + "\n - " + bibleNameEnglish + " " + bibleChapter + ":" + (readBibleIndex + 1) + " - ");
            CollectKoreanEnglish.Add(string.Empty);
            CollectKoreanEnglish.Add(collectEnglish[readBibleIndex]); //+ "\n - " + bibleName + " " + bibleChapter + "장 " + (readBibleIndex + 1) + "절  - ");
            StartCoroutine(ReadSelectBibleKorean(collectKorean[readBibleIndex]));
        }
        else
        {
            CollectKoreanEnglish.Add(collectEnglish[readBibleIndex]); // + "\n - " + bibleNameEnglish + " " + bibleChapter + ":" + (readBibleIndex + 1) + " - ");
            CollectKoreanEnglish.Add(string.Empty);
            CollectKoreanEnglish.Add(collectKorean[readBibleIndex]); // + "\n - " + bibleName + " " + bibleChapter + "장 " + (readBibleIndex + 1) + "절  - ");
            StartCoroutine(ReadSelectBible(collectEnglish[readBibleIndex]));
        }
        
        StringBuilder stringBuilder = new StringBuilder(); // 스트링빌더 객체 생성.
        
        for (int j = 0; j < CollectKoreanEnglish.Count; j++) stringBuilder.AppendLine(CollectKoreanEnglish[j]); // 최종리스트를 대상으로 반복문 처리.

        m_LabelShowBible.text = stringBuilder.ToString(); // 성격의 내용을 표시.
    }

    void ShowOriginal()
    {
        SetRandomBackground();

        if (m_CheckboxReadBible.value == true) return; // 성경을 자동으로 읽어주지 않을 때만 수동으로 보여줌

        InitPanel();
        SetReadBibleEnabled();
        SetLabelShowBible();

        if (readBibleIndex == -1) readBibleIndex = 0;

        if (readBibleIndex >= collectKorean.Count - 1) readBibleIndex = collectKorean.Count - 2;

        // 인덱스는 0부터 시작하므로 최종절은 collectKorean.Count - 1 입니다. 
        // 인덱스는 0부터 시작하지만 절은 1부터 시작하므로 최초의 절은 i + 1입니다. 
        // m_LabelBibleInfo.text = string.Format("{0}({1}) {2}:{3}({4})", bibleName, bibleNameEnglish, bibleChapter, readBibleIndex + 1, collectKorean.Count - 1);
        if (m_CheckboxReadBibleKorean.value == true)
            m_LabelBibleInfo.text = string.Format("{0}({1}) {2}:{3}({4})", bibleName, bibleNameEnglish, bibleChapter, readBibleIndex + 1, collectKorean.Count - 1);
        else
        {
            //if (!string.IsNullOrEmpty(bibleName))
            //    m_LabelBibleInfo.text = string.Format("{0}({1}) {2}:{3}({4})", bibleNameEnglish, bibleName, bibleChapter, readBibleIndex + 1, collectKorean.Count - 1);
            //else
                m_LabelBibleInfo.text = string.Format("{0} {1}:{2}({3})", bibleNameEnglish, bibleChapter, readBibleIndex + 1, collectKorean.Count - 1);

        }

        BibleMessageFirst = collectKorean[readBibleIndex].TrimEnd() + " -" + bibleName + "(" + bibleNameSource + ")" + " " + bibleChapter + "장 " + (readBibleIndex + 1) + "절-";
        BibleMessageSecond = collectEnglish[readBibleIndex].TrimEnd() + " -" + bibleNameEnglish + "(" + bibleNameSourceEnglish + ")" + " " + bibleChapter + ":" + (readBibleIndex + 1) + "-"; ;
        BibleMessageThird = bibleName + "(" + bibleNameEnglish + ") " + bibleChapter + ":" + (readBibleIndex + 1);
        OnlyBibleEnglish = collectEnglish[readBibleIndex];
        OnlyBibleKorean = collectKorean[readBibleIndex];

        List<string> CollectKoreanEnglish = new List<string>();

        if (m_CheckboxReadBibleKorean.value == true)
        {
            CollectKoreanEnglish.Add(collectKorean[readBibleIndex]); // + "\n - " + bibleNameEnglish + " " + bibleChapter + ":" + (readBibleIndex + 1) + " - ");
            CollectKoreanEnglish.Add(string.Empty);
            CollectKoreanEnglish.Add(collectEnglish[readBibleIndex]); //+ "\n - " + bibleName + " " + bibleChapter + "장 " + (readBibleIndex + 1) + "절  - ");
            StartCoroutine(ReadSelectBibleKorean(collectKorean[readBibleIndex]));
        }
        else
        {
            CollectKoreanEnglish.Add(collectEnglish[readBibleIndex]); // + "\n - " + bibleNameEnglish + " " + bibleChapter + ":" + (readBibleIndex + 1) + " - ");
            CollectKoreanEnglish.Add(string.Empty);
            CollectKoreanEnglish.Add(collectKorean[readBibleIndex]); // + "\n - " + bibleName + " " + bibleChapter + "장 " + (readBibleIndex + 1) + "절  - ");
            StartCoroutine(ReadSelectBible(collectEnglish[readBibleIndex]));
        }

        StringBuilder stringBuilder = new StringBuilder(); // 스트링빌더 객체 생성.
        
        for (int j = 0; j < CollectKoreanEnglish.Count; j++) stringBuilder.AppendLine(CollectKoreanEnglish[j]); // 최종리스트를 대상으로 반복문 처리.

        m_LabelShowBible.text = stringBuilder.ToString(); // 성격의 내용을 표시.
    }

    void SetLabelConfirmConfirmInit()
    {
        m_LabelConfirm.text = "";
    }

    public static int BibleTestIndex = 0;
    public int BibleTempCount;

    List<string> ReturnOver200CharactersResult(string source)
    {
      
        List<string> ResultAll = new List<string>();
        ResultAll = source.Split('#').ToList();

        return ResultAll;
    }

    void OOPSButtonNext()
    {
        InvokeRepeating("ButtonNext", 0.05f, 0.05f);

        // 200자 넘는 문장을 저장하기 위한. 빌드할 때는 주석처리 해줌. 
        // Show함수에서 SetSavedBibleName() 호출
    }

    /// <summary>
    /// 사운드를 켤지? 끌지 판별
    /// </summary>
    public bool CanSoundPlay = true;

    List<string> Collects = new List<string>();

    IEnumerator ShowMessage()
    {
        for (int i = 0; i < Collects.Count; i++)
        {
            if (!string.IsNullOrEmpty(Collects[i]))
            {
                m_LabelShowBible.text = Collects[i]; // 성격의 내용을 표시.
                string url = @"https://translate.google.com/translate_tts?ie=UTF-8&total=1&idx=0&textlen=32&client=tw-ob&q=" + Collects[i] + GetNationVoice(m_NationType);

                using (UnityWebRequest www = UnityWebRequestMultimedia.GetAudioClip(url, AudioType.MPEG))
                {
                    yield return www.SendWebRequest();

                    if (www.result == UnityWebRequest.Result.Success)
                    {
                        
                        AudioClip clip = DownloadHandlerAudioClip.GetContent(www);
                        if (clip != null)
                        {
                            audioSource.clip = clip;
                            audioSource.pitch = 1.0f;
                            audioSource.Play();
                        }
                        else Debug.LogError("DownloadHandlerAudioClip.GetContent returned null");
                    }
                    else Debug.LogError("Error: " + www.error);
                }
                yield return new WaitForSeconds(Collects[i].Length * 0.2f);
            }
            else
            {
                StopAllCoroutines();
                yield break;
            }
        }

        yield return new WaitForSeconds(1.0f);
    }

    void TestTest(ENationType Type)
    {
        PlayerPrefs.DeleteAll();
        m_TempTemp.text = Type.ToString();
        Startinit();
        
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.F8))
        {
            TextAsset[] CollectAllFiles = Resources.LoadAll<TextAsset>(@"BibleMessage"); // 바이블 텍스트에셋을 모두 불러옵니다. 
            string textValue = CollectAllFiles[0].text;
            Collects.Clear();
            Collects = new List<string>(textValue.Split('\n'));
            StartCoroutine(ShowMessage());
        }

        if (Input.GetKeyUp(KeyCode.F4))
        {
            //CanSoundPlay = !CanSoundPlay;

            //m_TempTemp.text = CanSoundPlay ? "사운드가 켜졌습니다. " : "사운드가 꺼졌습니다. ";

            IsDebug = !IsDebug;
        }


        if (Input.GetKeyUp(KeyCode.F7))
        {
            OOPSButtonNext(); // ButtonNext 함수를 1초마다 계속 눌러줌. 
            // Show함수에서 SetSavedBibleName() 호출 // 200자 넘는 문장을 저장하기 위한. 빌드할 때는 주석처리 해줌. 

            string[] Koreankeywords = { "창", "출", "레", "민", "신", "수", "삿", "룻", "삼상", "삼하", "왕상", "왕하", "대상", "대하", "스", "느", "에", "욥", "시", "잠", "전", "아", "사", "렘", "애", "겔", "단", "호", "욜", "암", "옵", "욘", "미", "나", "합", "습", "학", "슥", "말", "마", "막", "눅", "요", "행", "롬", "고전", "고후", "갈", "엡", "빌", "골", "살전", "살후", "딤전", "딤후", "딛", "몬", "히", "약", "벧전", "벧후", "요일", "요이", "요삼", "유", "계" };
            string[] keywords = { "Genesis", "Exodus", "Leviticus", "Numbers", "Deuteronomy", "Joshua", "Judges", "Ruth", "1Samuel", "2Samuel", "1Kings", "2Kings",
                "1Chronicles", "2Chronicles", "Ezra", "Nehemiah", "Esther", "Job", "Psalms", "Proverbs", "Ecclesiastes", "SongOfSongs", "Isaiah", "Jeremiah",
                "Lamentations", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos", "Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi",
                "Matthew", "Mark", "Luke", "John", "Acts", "Romans", "1Corinthians", "2Corinthians", "Galatians", "Ephesians", "Philippians", "Colossians",
                "1Thessalonians", "2Thessalonians", "1Timothy", "2Timothy", "Titus", "Philemon", "Hebrews", "James", "1Peter", "2Peter", "1John", "2John", "3John", "Jude", "Revelation" };
            int[] chapterCount = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4, 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };
        }

        if (Input.GetKeyUp(KeyCode.F12))
        {
            PlayerPrefs.DeleteAll();
        }

        if (Input.GetKeyUp(KeyCode.Tab))
        {
            if (m_CheckboxReadBible.value == true) return; // 성경을 자동으로 읽어주지 않을 때만 수동으로 보여줌
            
            if (labelBible.enabled == true) return; // 기본화면에서 성경이 보여지고 있을때는 동작안하게

            string folderPath = @"c:\Bible\"; // 결과를 저장할 폴더입니다. 
            DirectoryInfo di = new DirectoryInfo(folderPath);

            if (di.Exists == false) di.Create(); // 만약 폴더가 존재하지 않으면

            m_LabelConfirm.text = BibleMessageThird + " is Saved. !!";
            m_LabelConfirm.GetComponent<TweenAlpha>().ResetToBeginning();
            m_LabelConfirm.GetComponent<TweenAlpha>().enabled = true;
            string path = @"c:\Bible\" + m_KoreanBibleName + "(" + m_EnglishBibleName + ") " + bibleName + "(" + bibleNameEnglish + ")"; // 저장될 경로입니다. 
            StreamWriter streamWriter = new StreamWriter(path + ".txt", true); // 파일을 저장할 준비를 합니다. 
            streamWriter.WriteLine("");
            streamWriter.WriteLine(BibleMessageFirst + "\n" + BibleMessageSecond);
            streamWriter.Close();
        }

        if (Input.GetKeyUp(KeyCode.F11))
        {
            Application.OpenURL(@"https://translate.google.co.kr/?hl=ko");
        }

        if (Input.GetKeyUp(KeyCode.PageDown))
        {
            if (m_CheckboxReadBible.value == true) return; // 성경을 자동으로 읽어주지 않을 때만 수동으로 보여줌
            
            if (labelBible.enabled == true) return; // 기본화면에서 성경이 보여지고 있을때는 동작안하게

            string folderPath = @"c:\Bible\"; // 결과를 저장할 폴더입니다. 
            DirectoryInfo di = new DirectoryInfo(folderPath);

            if (di.Exists == false) di.Create(); // 만약 폴더가 존재하지 않으면

            m_LabelConfirm.text = BibleMessageThird + " is Saved. !!";
            m_LabelConfirm.GetComponent<TweenAlpha>().ResetToBeginning();
            m_LabelConfirm.GetComponent<TweenAlpha>().enabled = true;
            string path = @"c:\Bible\" + "WordOfGod " + bibleName + "(" + bibleNameEnglish + ")"; // 저장될 경로입니다. 
            StreamWriter streamWriter = new StreamWriter(path + ".txt", true); // 파일을 저장할 준비를 합니다. 
            streamWriter.WriteLine("");
            streamWriter.WriteLine
                (
                BibleMessageEasyBible + "\n" + 
                BibleMessageKoreanBible + "\n" +
                BibleMessageNewStandardTranslation + "\n" +
                BibleMessageRevisedRevision + "\n" +
                BibleMessageNIV + "\n" +
                BibleMessageESV + "\n" +
                BibleMessageNewRSV + "\n" +
                BibleMessageNewKJV + "\n" +
                BibleMessageKJV
                );
            streamWriter.Close();
        }

        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            ShowNext();
            SetBackgroundImagesOne();
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            ShowPrevious();
            SetBackgroundImagesOne();
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            ShowOriginal();
            SetBackgroundImagesOne();
        }

        // 시간을 표시.
        // LabelTime.text = System.DateTime.Now.ToString("tt hh:mm:ss");
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name=EKeyword.IsPhone.ToString()></param>
    /// <param name="isTab"></param>
    /// <param name="isMiddle"></param>
    void SetCheckBoxPhoneTab(bool isPhone, bool isTab, bool isMiddle)
    {
        m_CheckboxPhone.startsActive = isPhone;
        m_CheckboxPad.startsActive = isTab;
        m_CheckboxMiddle.startsActive = isMiddle;
    }

    /**
NGUI UILabel에서 Word Wrapping이 안됨..
(해결법)
NGUIText.cs 파일내 아래와 같이 수정

	// Run through all characters
		for (; offset < textLength; ++offset)
		{
			char ch = text[offset];
			//if (ch > 12287) eastern = true;  //주석치리
            if (ch > 12287 && !(ch >= 44032 && ch <=55215 ) ) eastern = true;      // 수정 (한국어제외)

			// New line character -- start a new line
			if (ch == '\n')
			{
				if (lineCount == maxLineCount) break;
				remainingWidth = regionWidth;

				// Add the previous word to the final string
				if (start < offset) sb.Append(text.Substring(start, offset - start + 1));
				else sb.Append(ch);

				lineIsEmpty = true;
				++lineCount;
				start = offset + 1;
				prev = 0;
				continue;
			}
출처: https://friday13th.tistory.com/entry/NGUI-한국어-word-wrapping [13일의 금요일:티스토리]


유니티 에디터 상에서 NGUI의 UIInput에 한글을 입력하면 한자리에서 계속 입력되고, 글자를 쓰려면 '한글자 치고 방향키 누르고 다시 한글자 치고' 이런 번거로운 일을 해야했다.
물론 모바일에서는 잘나온다. 해결방법은 간단하다.
UIInput.cs에서
if (string.IsNullOrEmpty(ime) && !string.IsNullOrEmpty(Input.inputString))
이 코드를
if (!string.IsNullOrEmpty(Input.inputString))
이렇게 바꾸면 된다.

Unity에서 NGUI UIInput에 한글을 입력하고 마우스로 다른곳을 클릭하면 한글의 마지막글자가 사라집니다.
스페이스나 엔터를 쓰고 하면되는데요 어떻게 해결해야되나요?

자답입니다.
UIInput안에서 OnSelect란 함수가 있습니다.
그 안에 보면 IsSelected로 나눠놨는데 else부분에서 

if (string.IsNullOrEmpty(mText))
                {
                    label.text = mDefaultText;
                    label.color = mDefaultColor;
                    if (isPassword) label.password = false;
                }
                else
                {
                    if (mText.Contains(mLastIME) && mText.LastIndexOf(mLastIME) == mText.Length - 1)
                    {
                        mText = mText + "";
                    }
                    else
                    {
                        mText = mText + mLastIME;
                    }
                    label.text = mText;
                } 
이런식으로 코드를 바꿔주면 됩니다.

혹시나 해서 그런데... 아래와 같은 비교만 해 줘도 되지 않을까요...?
if (mText.LastIndexOf(mLastIME) == mText.Length - 1) {
}

입력된 글자가 없고, 입력한 글자만 있을때 문제가 또 있어서 바꿔봤어요
if (string.IsNullOrEmpty(mText) && Input.inputString.Length == 0)
{
    label.text = mDefaultText;
    label.color = mDefaultColor;
    if (isPassword) label.password = false;
}
else 
{
    int ninputStringIndex = mText.LastIndexOf(Input.inputString);
    if (ninputStringIndex != -1 && ninputStringIndex == mText.Length - 1)
    {
        mText = mText + "";
    }
    else
    {
        mText = mText + Input.inputString;
    }
    label.text = mText;
}	2013-05-14
16:36:08 
 

저도 같은 문제를 겪었습니다. UIInput을 가지고 있는 오브젝트는 UILabel도 가지게 되는데, UILabel에서는 제대로 입력 되다가 마우스를 클릭하면 사라지는 것을 볼 수 있습니다. 그래서 UIInput의 OnDeselectEvent()에서 value와 mValue를 label.text로 바꾸도록 해서 해결하였습니다.

protected void OnDeselectEvent ()
{
     if (mDoInit) Init();

     if (label != null) label.overflowEllipsis = mEllipsis;

     if (label != null && NGUITools.GetActive(this))
     {
          value = label.text;
          mValue = value;
 
 
 */



    // string string1 = "-성도들을 섬기는 목회자, 하나님의 은혜와 평안, 하나님을 섬기는 성도들의 믿음, 하나님의 복음, 하나님의 교회, 예배하는 삶, 하나님의 말씀, 하나님의 진리, 하나님을 섬기는 바른 길, 진실한 믿음, 그리스도를 향한 신앙을 고백, 참된 믿음, 생명책, 하나님의 말씀에 대한 갈망, 하나님의 사랑, 믿음의 말씀, 선한 가르침, 하나님을 섬기는 경건의 훈련, 건강한 교회, 하나님의 마음, 그리스도의 영광, 하나님의 자녀, 예수님의 제자, 살아계신 하나님의 교회, 그리스도의 선한 일꾼-";
    // string string2 = "-교회는 하나님께 부르심을 입은 성도들의 모임이며, 말씀과 복음의 진리를 중심으로 살아가는 공동체입니다. 하나님께서 세상에서 우리를 불러내셨고, 그 부르심에 응답한 자들이 모여 교회가 된 것입니다. 그러므로 교회는 결코 건물이 아니라 하나님의 부르심에 응답한 사람들의 공동체입니다. 교회는 그리스도의 몸입니다. 머리는 그리스도이시며, 각 지체는 서로 다른 역활을 감당하면서도 유기적으로 연결되어 있습니다. 몸의 한 부분이 아프면 온몸이 함께 아프고, 한 부분이 기뻐하면 온몸이 기뻐하는 것처럼, 교회도 각 지체가 서로 돌보고 기뻐하며 하나의 생명으로 움직입니다.-";
    // string string3 = "-교회는 하나님의 집입니다. 하나님은 아버지이시며, 우리는 자녀로써 서로 형제자매의 관계에 서 있습니다. 가정은 피로 묶이는 것처럼, 교회는 예수 그리스도의 피로 묶인 공동체입니다. 참된 교회는 늘 말씀 앞에서 순종하며, 그 말씀을 통해 구원과 거룩함을 경험하는 공동체입니다. 주님의 말씀이시다. \"나의 손이 이 모든 것을 지었으며, 이 모든 것이 나의 것이다. 겸손한 사람, 회개하는 사람, 나를 경외하고 복종하는 사람, 바로 이런 사람을 내가 좋아한다.\" 교회는 바로 이런 사람들이 모여 있는 곳이어야 합니다.-";
    // string string4 = "-당신은 십일조를 드려야 하나님이 당신을 사랑하시고 복을 주실 거라 생각했습니다. 하지만 진실은 그 반대입니다. 하나님이 이미 당신을 사랑하셨고, 이미 예수님께서 십자가에서 모든 것을 이루셨습니다. 고린도후서 9장7절의 말씀입니다. 각자 그 마음에 정한 대로 해야 하고, 아까워하면서 내거나, 마지 못해서 하는 일은 없어야 합니다. 하나님께서는 기쁜 마음으로 내는 사람을 사랑하십니다.-";
    // string string5 = "-우리들은 하늘에 계시는 하나님 아버지의 자녀들입니다. 우리들은 살아계신 하나님 아버지의 아들이시며 구세주이신 예수님의 제자들입니다. 구세주 예수님을 진실되게 믿는 우리들은 형제입니다. 형제끼리는 서로 사랑해야 합니다. 우리들 모두는 하나님의 성전이며 우리에게는 하나님이 보내주신 성령이 있습니다. 따라서 우리들은 제사장입니다.-";

    // 너희가 내 이름으로 구하는 것은, 내가 무엇이든지 다 이루어 주겠다. 이것은 아들로 말미암아 아버지께서 영광을 받으시게 하려는 것이다. 요한복음 14:13
    // 너희가 무엇이든지 내 이름으로 구하면, 내가 다 이루어 주겠다." 요한복음 14:14
    // "너희가 나를 사랑하면, 내 계명을 지킬 것이다. 요한복음 14:15
    // 내가 아버지께 구하겠다. 그러면 아버지께서 다른 보혜사를 너희에게 보내셔서, 영원히 너희와 함께 있게 하실 것이다. 요한복음 14:16
    // 내 계명을 받아서 지키는 사람은 나를 사랑하는 사람이요, 나를 사랑하는 사람은 내 아버지의 사랑을 받을 것이다. 그리고 나도 그 사람을 사랑하여, 그에게 나를 드러낼 것이다." 요한복음 14:21
    // 예수께서 그에게 대답하셨다. "누구든지 나를 사랑하는 사람은 내 말을 지킬 것이다. 그러면 내 아버지께서 그 사람을 사랑하실 것이요, 우리는 그 사람에게로 가서 그 사람과 함께 살 것이다. 요한복음 14:23
    // "너희는 마음에 근심하지 말아라. 하나님을 믿고 또 나를 믿어라. 요한복음 14:1
    // 너희가 나의 계명을 지키면, 나의 사랑 안에 머물러 있을 것이다. 그것은 마치 내가 나의 아버지의 계명을 지켜서 그 사랑 안에 머물러 있는 것과 같다. 요한복음 15:10
    // 나의 계명은 이것이다. 내가 너희를 사랑한 것과 같이, 너희도 서로 사랑하여라. 요한복음 15:12
    // 지금까지는 너희가 아무것도 내 이름으로 구하지 않았다. 구하여라. 그러면 받을 것이다. 이것은 너희에게 기쁨이 넘치게 하려는 것이다." 요한복음 16:24
    // 아버지께서는 아들에게 주신 모든 사람에게 영생을 주게 하시려고, 모든 사람을 다스리는 권세를 아들에게 주셨습니다. 요한복음 17:2
    // 영생은 오직 한 분이신 참 하나님을 알고 또 아버지께서 보내신 예수 그리스도를 아는 것입니다. 요한복음 17:3

    // "너희는 어찌하여 나더러 '주님, 주님!' 하면서도, 내가 말하는 것은 실행하지 않느냐?  누가복음 6:46
    // 내게 와서 내 말을 듣고 그대로 하는 사람이 어떤 사람과 같은지를, 너희에게 보여 주겠다. 누가복음 6:47
    // 그는 땅을 깊이 파고, 반석 위에다가 기초를 놓고 집을 짓는 사람과 같다. 홍수가 나서 물살이 그 집에 들이쳐도, 그 집은 흔들리지 않는다. 잘 지은 집이기 때문이다. 누가복음 6:48
    // 그러나 내 말을 듣고서도 그대로 행하지 않는 사람은, 기초 없이 맨 흙 위에다가 집을 짓는 사람과 같다. 물살이 그 집에 들이치면, 그 집은 곧 무너져 버리고, 무너진 피해가 크다." 누가복음 6:49

    // 아버지께서는 아들에게 주신 모든 사람에게 영생을 주게 하시려고, 모든 사람을 다스리는 권세를 아들에게 주셨습니다. 
    // 영생은 오직 한 분이신 참 하나님을 알고 또 아버지께서 보내신 예수 그리스도를 아는 것입니다. 요한복음 17장 2-3
    // 그런데 여기에 이것이나마 기록한 목적은, 여러분으로 하여금, 예수가 그리스도요 하나님의 아들이심을 믿게 하고, 또 그렇게 믿어서 그의 이름으로 생명을 얻게 하려는 것이다. 요한복음 20장 31

    // 그래서 제자들은 각각 자기 형편을 따라 몫을 정하여, 유대에 사는 신도들에게 구제 헌금을 보내기로 하였다.  사도행저 12:29

    // 형제자매 여러분, 그러므로 나는 하나님의 자비하심을 힘입어 여러분에게 권합니다. 여러분은 여러분의 몸을 하나님께서 기뻐하실 거룩한 산 제물로 드리십시오. 이것이 여러분이 드릴 합당한 예배입니다.  로마서 12:1
    // 그러므로 나는 너희에게 말한다. 너희가 기도하면서 구하는 것은 무엇이든지, 이미 그것을 받은 줄로 믿어라. 그리하면, 너희에게 그대로 이루어질 것이다.  마가복음 11:24

    // 여러분은, 여러분이 하나님의 성전이요 하나님의 성령이 여러분 가운데 계시다는 것을 모르십니까? 누구든지 하나님의 성전을 파괴하면, 하나님께서도 그 사람을 멸하실 것입니다. 하나님의 성전은 거룩합니다. 여러분은 하나님의 성전입니다. 고린도전서 3:16-17

    // 마침 보블리오의 아버지가 열병과 이질에 걸려서 병석에 누워 있었다. 그래서 바울은 들어가서 기도하고, 그에게 손을 얹어서 낫게 해주었다. 사도행전 28:8
    // 이 사람이 바울이 말하는 것을 들었다. 바울이 그를 똑바로 보고서, 고침을 받을 만한 믿음이 그에게 있는 것을 알고는, 큰소리로 "두 발로 똑바로 일어서시오" 하고 말하였다. 그러자 그는 벌떡 일어나서 걷기 시작하였다. 사도행전 14:9-10
    // 그 여자가 여러 날을 두고 이렇게 하므로, 바울이 귀찮게 생각하고, 돌아서서 그 귀신에게 "내가 예수 그리스도의 이름으로 네게 명하니, 이 여자에게서 나오라" 하고 말하니, 바로 그 순간에 귀신이 나왔다. 사도행전 16:18

}
