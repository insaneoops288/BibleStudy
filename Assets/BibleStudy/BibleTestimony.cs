using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BibleTestimony : MonoBehaviour
{
    public List<Transform> InitItem = new List<Transform>();

    public List<TestimonyInfo> TestimonyInfos = new List<TestimonyInfo>();

    public List<TestimonyInfo> CollectTestimonyInfos = new List<TestimonyInfo>();

    public BibleItemTestimony m_BibleItemTestimony;

    public List<BibleItemTestimony> m_BibleItemTestimonies = new List<BibleItemTestimony>();

    public List<PlayerInfo> TestimonyPrayerInfos = new List<PlayerInfo>();

    public List<PlayerInfo> CollectTestimonyPrayerInfos = new List<PlayerInfo>();

    public UIScrollView m_ScrollViewTestimony;
    public UIGrid m_UIGridTestimony;

    public UILabel m_LabelJustTest;

    public List<UISprite> Buttons = new List<UISprite>();

    private static BibleTestimony m_Instance = null;

    public static BibleTestimony Get { get { return m_Instance; } set { m_Instance = value; } }

    public void Awake()
    {
        m_Instance = this;
    }

    public void InitButton()
    {
        for (int i = 0; i < Buttons.Count; i++)
        {
            Buttons[i].color = new Color(1, 1, 1, 1);
        }
    }


    public void ButtonExitPanelTestimony()
    {
        SceneManager.LoadScene("BibleStudy");
    }



    public void Init()
    {

    }

    public void ButtonTestimonyBible()
    {
        Init();
        InitButton();

        CollectTestimonyInfos.Clear();

        for (int i = 0; i < TestimonyInfos.Count; i++)
        {
            if (TestimonyInfos[i].m_Confirm == "Bible")
            {
                CollectTestimonyInfos.Add(TestimonyInfos[i]);
            }
        }

        SpawnItem();
    }

    public void SpawnItem()
    {
        // m_LabelJustTest.text = "" + CollectTestimonyInfos.Count;

        for (int i = 0; i < m_BibleItemTestimonies.Count; i++)
        {
            m_BibleItemTestimonies[i].gameObject.SetActive(true);
        }

        for (int i = CollectTestimonyInfos.Count; i < m_BibleItemTestimonies.Count; i++)
        {
            m_BibleItemTestimonies[i].gameObject.SetActive(false);
        }

        CollectTestimonyInfos = (from prod in CollectTestimonyInfos
                                 orderby prod.m_Content
                                 select prod).ToList();

        for (int i = 0; i < CollectTestimonyInfos.Count; i++)
        {
            m_BibleItemTestimonies[i].m_intIndex = i + 1;
            m_BibleItemTestimonies[i].m_intMax = CollectTestimonyInfos.Count;
            m_BibleItemTestimonies[i].m_TestimonyInfo = CollectTestimonyInfos[i];
            m_BibleItemTestimonies[i].SetInfo();
        }

        m_UIGridTestimony.repositionNow = true;
        m_UIGridTestimony.Reposition();
        m_ScrollViewTestimony.ResetPosition();
    }

    public void ButtonTestimonyGrace()
    {
        Init();
        InitButton();

        CollectTestimonyInfos.Clear();

        for (int i = 0; i < TestimonyInfos.Count; i++)
        {
            if (TestimonyInfos[i].m_Confirm == "Grace")
            {
                CollectTestimonyInfos.Add(TestimonyInfos[i]);
            }
        }

        SpawnItem();
    }

    public void ButtonTestimonyPrayer()
    {
        Init();
        InitButton();

        CollectTestimonyInfos.Clear();

        for (int i = 0; i < TestimonyInfos.Count; i++)
        {
            if (TestimonyInfos[i].m_Confirm == "Prayer")
            {
                CollectTestimonyInfos.Add(TestimonyInfos[i]);
            }
        }

        SpawnItem();
    }

    public void ButtonTestimonySalvation()
    {
        Init();
        InitButton();

        CollectTestimonyInfos.Clear();

        for (int i = 0; i < TestimonyInfos.Count; i++)
        {
            if (TestimonyInfos[i].m_Confirm == "Salvation")
            {
                CollectTestimonyInfos.Add(TestimonyInfos[i]);
            }
        }

        SpawnItem();
    }

    public void ButtonTestimonyHolySpirit()
    {
        Init();
        InitButton();
        CollectTestimonyInfos.Clear();

        for (int i = 0; i < TestimonyInfos.Count; i++)
        {
            if (TestimonyInfos[i].m_Confirm == "HolySpirit")
            {
                CollectTestimonyInfos.Add(TestimonyInfos[i]);
            }
        }

        SpawnItem();
    }

    public void ButtonTestimonyHeaven()
    {
        Init();
        InitButton();
        CollectTestimonyInfos.Clear();

        for (int i = 0; i < TestimonyInfos.Count; i++)
        {
            if (TestimonyInfos[i].m_Confirm == "Heaven")
            {
                CollectTestimonyInfos.Add(TestimonyInfos[i]);
            }
        }

        SpawnItem();
    }

    public void ButtonTestimonyPenitence()
    {
        Init();
        InitButton();
        CollectTestimonyInfos.Clear();

        for (int i = 0; i < TestimonyInfos.Count; i++)
        {
            if (TestimonyInfos[i].m_Confirm == "Penitence")
            {
                CollectTestimonyInfos.Add(TestimonyInfos[i]);
            }
        }

        SpawnItem();
    }

    public void ButtonTestimonySin()
    {
        Init();
        InitButton();
        CollectTestimonyInfos.Clear();

        for (int i = 0; i < TestimonyInfos.Count; i++)
        {
            if (TestimonyInfos[i].m_Confirm == "Sin")
            {
                CollectTestimonyInfos.Add(TestimonyInfos[i]);
            }
        }

        SpawnItem();
    }

    public void ButtonTestimonySexual()
    {
        Init();
        InitButton();
        CollectTestimonyInfos.Clear();

        for (int i = 0; i < TestimonyInfos.Count; i++)
        {
            if (TestimonyInfos[i].m_Confirm == "Sexual")
            {
                CollectTestimonyInfos.Add(TestimonyInfos[i]);
            }
        }

        SpawnItem();
    }

    public void ButtonTestimonyGodPrayer()
    {
        Init();
        InitButton();
        CollectTestimonyInfos.Clear();

        for (int i = 0; i < TestimonyInfos.Count; i++)
        {
            if (TestimonyInfos[i].m_Confirm == "GodPrayer")
            {
                CollectTestimonyInfos.Add(TestimonyInfos[i]);
            }
        }

        SpawnItem();
    }

    public void ButtonTestimonChurch()
    {
        Init();
        InitButton();
        CollectTestimonyInfos.Clear();

        for (int i = 0; i < TestimonyInfos.Count; i++)
        {
            if (TestimonyInfos[i].m_Confirm == "Church")
            {
                CollectTestimonyInfos.Add(TestimonyInfos[i]);
            }
        }

        SpawnItem();
    }

    public void ButtonTestimonTithe()
    {
        Init();
        InitButton();
        CollectTestimonyInfos.Clear();

        for (int i = 0; i < TestimonyInfos.Count; i++)
        {
            if (TestimonyInfos[i].m_Confirm == "Tithe")
            {
                CollectTestimonyInfos.Add(TestimonyInfos[i]);
            }
        }

        SpawnItem();
    }

    public void ButtonTestimonGlory()
    {
        Init();
        InitButton();
        CollectTestimonyInfos.Clear();

        for (int i = 0; i < TestimonyInfos.Count; i++)
        {
            if (TestimonyInfos[i].m_Confirm == "Glory")
            {
                CollectTestimonyInfos.Add(TestimonyInfos[i]);
            }
        }

        SpawnItem();


        //CollectTestimonyInfos.Clear();

        //for (int i = 0; i < TestimonyInfos.Count; i++)
        //{
        //    //if (TestimonyInfos[i].m_Confirm == "Glory")
        //    //{
        //        CollectTestimonyInfos.Add(TestimonyInfos[i]);
        //    //}
        //}

        //SpawnItem();
    }

    public void ButtonTestimonParable()
    {
        Init();
        InitButton();
        CollectTestimonyInfos.Clear();

        for (int i = 0; i < TestimonyInfos.Count; i++)
        {
            if (TestimonyInfos[i].m_Confirm == "Parable")
            {
                CollectTestimonyInfos.Add(TestimonyInfos[i]);
            }
        }

        SpawnItem();
    }

    public void ButtonTestimonFaith()
    {
        Init();
        InitButton();
        CollectTestimonyInfos.Clear();

        for (int i = 0; i < TestimonyInfos.Count; i++)
        {
            if (TestimonyInfos[i].m_Confirm == "Faith")
            {
                CollectTestimonyInfos.Add(TestimonyInfos[i]);
            }
        }

        SpawnItem();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        TestimonyInfos.Clear();

        TestimonyInfos = TestimonyTable.GetAllList();

        //TestimonyPrayerInfos.Clear();

        //TestimonyPrayerInfos = PlayerTable.GetAllList();

        m_BibleItemTestimonies = m_UIGridTestimony.GetComponentsInChildren<BibleItemTestimony>().ToList();

        for (int i = 0; i < m_BibleItemTestimonies.Count; i++)
        {
            m_BibleItemTestimonies[i].gameObject.SetActive(false);
        }

        for (int i = 0; i < m_BibleItemTestimonies.Count; i++)
        {
            m_BibleItemTestimonies[i].m_UILabelBibleName.text = "";
        }

        for (int i = 0; i < m_BibleItemTestimonies.Count; i++)
        {
            Buttons.Add(m_BibleItemTestimonies[i].GetComponentInChildren<UISprite>());
        }

        InitButton();
    }



}
