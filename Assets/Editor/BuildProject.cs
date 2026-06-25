using System.IO;
using UnityEditor;
using UnityEngine;

public class BuildProject : EditorWindow
{
    [MenuItem("Tools/BuildProject")]
    public static void Init()
    {
        EditorWindow window = (BuildProject)EditorWindow.GetWindow(typeof(BuildProject));
    }

    public static void GetActiveObject(ENationType Type)
    {
        GameObject instance = GameObject.Find("BibleStudy");
        Selection.activeGameObject = instance;
        BibleStudy bibleStudy = instance.GetComponent<BibleStudy>();
        bibleStudy.m_NationType = Type;
        if (PrefabUtility.IsPartOfPrefabInstance(instance)) PrefabUtility.ApplyPrefabInstance(instance, InteractionMode.UserAction);
    }

    public static void SetBuildUnity(string name)
    {
        PlayerSettings.productName = name;
        string path = EditorUtility.SaveFolderPanel("Choose Location of Built Game", "c:/Git/", PlayerSettings.productName);

        if (string.IsNullOrEmpty(path)) return;

        string[] scenes = { "Assets/BibleStudy/BibleStudy.unity" }; // Modify as needed
        string buildPath = Path.Combine(path, PlayerSettings.productName + ".exe");
        BuildTarget target = BuildTarget.StandaloneWindows64;
        BuildOptions options = BuildOptions.CompressWithLz4HC;
        BuildPipeline.BuildPlayer(scenes, buildPath, target, options);
    }

    void OnGUI()
    {
        Repaint();

        // EditorGUILayout.BeginVertical();
            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Korean", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Korean);
                }

                if (GUILayout.Button("Afrikaans", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Afrikaans);
                }

                if (GUILayout.Button("Albanian", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Albanian);
                }

                if (GUILayout.Button("Chinese", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Chinese);
                }

                if (GUILayout.Button("Czech", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Czech);
                }

                if (GUILayout.Button("Finnish", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Finnish);
                }

                if (GUILayout.Button("French", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.French);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("German", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.German);
                }

                if (GUILayout.Button("Hindi", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Hindi);
                }

                if (GUILayout.Button("Hungarian", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Hungarian);
                }

                if (GUILayout.Button("Indonesian", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Indonesian);
                }

                if (GUILayout.Button("Italian", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Italian);
                }

                if (GUILayout.Button("Japanese", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Japanese);
                }

                if (GUILayout.Button("Polish", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Polish);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Portuguese", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Portuguese);
                }

                if (GUILayout.Button("Romanian", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Romanian);
                }

                if (GUILayout.Button("Russian", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Russian);
                }

                if (GUILayout.Button("Spanish", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Spanish);
                }

                if (GUILayout.Button("Tagalog", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Tagalog);
                }

                if (GUILayout.Button("Thai", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Thai);
                }

                if (GUILayout.Button("Vietnamese", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Vietnamese);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Delete Folder", GUILayout.Height(30)))
                {
                    string path = "Assets/Nations/Resources";

                    // AssetDatabase.DeleteAsset returns true if successful
                    if (AssetDatabase.DeleteAsset(path))
                    {
                        Debug.Log($"Successfully deleted: {path}");
                    }
                    else
                    {
                        Debug.LogError("Failed to delete folder. Path may be incorrect.");
                    }
                    // Syntax: CreateFolder(parentPath, newFolderName)
                    string guid = AssetDatabase.CreateFolder("Assets", "MyNewFolder");

                    // You can convert the GUID to a path if needed
                    string newFolderPath = AssetDatabase.GUIDToAssetPath(guid);

                    Debug.Log($"Folder created at: {newFolderPath}");


                }

                if (GUILayout.Button("Create Folder", GUILayout.Height(30)))
                {
                    string path = "Resources";

                    // Syntax: CreateFolder(parentPath, newFolderName)
                    string guid = AssetDatabase.CreateFolder("Assets/Nations", path);

                    // You can convert the GUID to a path if needed
                    string newFolderPath = AssetDatabase.GUIDToAssetPath(guid);

                    Debug.Log($"Folder created at: {newFolderPath}");


                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move BibleKorean", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Korean);

                    string sourceA = "Assets/Nations/Korean/EasyBible";
                    string sourceB = "Assets/Nations/Korean/KoreanBible";
                    string sourceC = "Assets/Nations/Korean/NewStandardTranslation";
                    string sourceD = "Assets/Nations/Korean/RevisedRevision";
                    string destinationA = "Assets/Nations/Resources/EasyBible";
                    string destinationB = "Assets/Nations/Resources/KoreanBible";
                    string destinationC = "Assets/Nations/Resources/NewStandardTranslation";
                    string destinationD = "Assets/Nations/Resources/RevisedRevision";

                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                    error = AssetDatabase.MoveAsset(sourceB, destinationB);
                    error = AssetDatabase.MoveAsset(sourceC, destinationC);
                    error = AssetDatabase.MoveAsset(sourceD, destinationD);
                }

                if (GUILayout.Button("Build BibleKorean", GUILayout.Height(30)))
                {
                    string ProductKey = "Bible";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore BibleKorean", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/Korean/EasyBible";
                    string sourceB = "Assets/Nations/Korean/KoreanBible";
                    string sourceC = "Assets/Nations/Korean/NewStandardTranslation";
                    string sourceD = "Assets/Nations/Korean/RevisedRevision";
                    string destinationA = "Assets/Nations/Resources/EasyBible";
                    string destinationB = "Assets/Nations/Resources/KoreanBible";
                    string destinationC = "Assets/Nations/Resources/NewStandardTranslation";
                    string destinationD = "Assets/Nations/Resources/RevisedRevision";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                    error = AssetDatabase.MoveAsset(destinationB, sourceB);
                    error = AssetDatabase.MoveAsset(destinationC, sourceC);
                    error = AssetDatabase.MoveAsset(destinationD, sourceD);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move Afrikaans", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Afrikaans);

                    string sourceA = "Assets/Nations/BibleAfrikaans/afri";
                    string destinationA = "Assets/Nations/Resources/afri";
 
                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);       
                }

                if (GUILayout.Button("Build Afrikaans", GUILayout.Height(30)))
                {
                    string ProductKey = "BibleAfrikaans";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore Afrikaans", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BibleAfrikaans/afri";
                    string destinationA = "Assets/Nations/Resources/afri";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move Albanian", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Albanian);

                    string sourceA = "Assets/Nations/BibleAlbanian/albanian";
                    string destinationA = "Assets/Nations/Resources/albanian";

                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                }

                if (GUILayout.Button("Build Albanian", GUILayout.Height(30)))
                {
                    string ProductKey = "BibleAlbanian";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore Albanian", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BibleAlbanian/albanian";
                    string destinationA = "Assets/Nations/Resources/albanian";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move Czech", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Czech);

                    string sourceA = "Assets/Nations/BibleCzech/bkr";
                    string destinationA = "Assets/Nations/Resources/bkr";

                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                }

                if (GUILayout.Button("Build Czech", GUILayout.Height(30)))
                {
                    string ProductKey = "BibleCzech";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore Czech", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BibleCzech/bkr";
                    string destinationA = "Assets/Nations/Resources/bkr";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move Chinese", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Chinese);

                    string sourceA = "Assets/Nations/BibleChinese/chinese_union_simp";
                    string sourceB = "Assets/Nations/BibleChinese/chinese_union_trad";
                    string sourceC = "Assets/Nations/BibleChinese/ckjv_sds";
                    string sourceD = "Assets/Nations/BibleChinese/ckjv_sdt";
                    string destinationA = "Assets/Nations/Resources/chinese_union_simp";
                    string destinationB = "Assets/Nations/Resources/chinese_union_trad";
                    string destinationC = "Assets/Nations/Resources/ckjv_sds";
                    string destinationD = "Assets/Nations/Resources/ckjv_sdt";

                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                    error = AssetDatabase.MoveAsset(sourceB, destinationB);
                    error = AssetDatabase.MoveAsset(sourceC, destinationC);
                    error = AssetDatabase.MoveAsset(sourceD, destinationD);
                }

                if (GUILayout.Button("Build Chinese", GUILayout.Height(30)))
                {
                    string ProductKey = "BibleChinese";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore Chinese", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BibleChinese/chinese_union_simp";
                    string sourceB = "Assets/Nations/BibleChinese/chinese_union_trad";
                    string sourceC = "Assets/Nations/BibleChinese/ckjv_sds";
                    string sourceD = "Assets/Nations/BibleChinese/ckjv_sdt";
                    string destinationA = "Assets/Nations/Resources/chinese_union_simp";
                    string destinationB = "Assets/Nations/Resources/chinese_union_trad";
                    string destinationC = "Assets/Nations/Resources/ckjv_sds";
                    string destinationD = "Assets/Nations/Resources/ckjv_sdt";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                    error = AssetDatabase.MoveAsset(destinationB, sourceB);
                    error = AssetDatabase.MoveAsset(destinationC, sourceC);
                    error = AssetDatabase.MoveAsset(destinationD, sourceD);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move Finnish", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Finnish);

                    string sourceA = "Assets/Nations/BibleFinnish/finn";
                    string destinationA = "Assets/Nations/Resources/finn";

                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                }

                if (GUILayout.Button("Build Finnish", GUILayout.Height(30)))
                {
                    string ProductKey = "BibleFinnish";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore Finnish", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BibleFinnish/finn";
                    string destinationA = "Assets/Nations/Resources/finn";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move French", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.French);

                    string sourceA = "Assets/Nations/BibleFrench/epee";
                    string sourceB = "Assets/Nations/BibleFrench/oster";
                    string sourceC = "Assets/Nations/BibleFrench/segond_1910";
                    string destinationA = "Assets/Nations/Resources/epee";
                    string destinationB = "Assets/Nations/Resources/oster";
                    string destinationC = "Assets/Nations/Resources/segond_1910";

                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                    error = AssetDatabase.MoveAsset(sourceB, destinationB);
                    error = AssetDatabase.MoveAsset(sourceC, destinationC);
                }

                if (GUILayout.Button("Build French", GUILayout.Height(30)))
                {
                    string ProductKey = "BibleFrench";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore French", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BibleFrench/epee";
                    string sourceB = "Assets/Nations/BibleFrench/oster";
                    string sourceC = "Assets/Nations/BibleFrench/segond_1910";
                    string destinationA = "Assets/Nations/Resources/epee";
                    string destinationB = "Assets/Nations/Resources/oster";
                    string destinationC = "Assets/Nations/Resources/segond_1910";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                    error = AssetDatabase.MoveAsset(destinationB, sourceB);
                    error = AssetDatabase.MoveAsset(destinationC, sourceC);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move German", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.German);

                    string sourceA = "Assets/Nations/BibleGerman/elberfelder_1905";
                    string sourceB = "Assets/Nations/BibleGerman/luther_1912";
                    string sourceC = "Assets/Nations/BibleGerman/schlachter";
                    string destinationA = "Assets/Nations/Resources/elberfelder_1905";
                    string destinationB = "Assets/Nations/Resources/luther_1912";
                    string destinationC = "Assets/Nations/Resources/schlachter";

                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                    error = AssetDatabase.MoveAsset(sourceB, destinationB);
                    error = AssetDatabase.MoveAsset(sourceC, destinationC);
                }

                if (GUILayout.Button("Build German", GUILayout.Height(30)))
                {
                    string ProductKey = "BibleGerman";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore German", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BibleGerman/elberfelder_1905";
                    string sourceB = "Assets/Nations/BibleGerman/luther_1912";
                    string sourceC = "Assets/Nations/BibleGerman/schlachter";
                    string destinationA = "Assets/Nations/Resources/elberfelder_1905";
                    string destinationB = "Assets/Nations/Resources/luther_1912";
                    string destinationC = "Assets/Nations/Resources/schlachter";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                    error = AssetDatabase.MoveAsset(destinationB, sourceB);
                    error = AssetDatabase.MoveAsset(destinationC, sourceC);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move Hindi", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Hindi);

                    string sourceA = "Assets/Nations/BibleHindi/irv";
                    string destinationA = "Assets/Nations/Resources/irv";

                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                }

                if (GUILayout.Button("Build Hindi", GUILayout.Height(30)))
                {
                    string ProductKey = "BibleHindi";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore Hindi", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BibleHindi/irv";
                    string destinationA = "Assets/Nations/Resources/irv";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move Hungarian", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Hungarian);

                    string sourceA = "Assets/Nations/BibleHungarian/karoli";
                    string destinationA = "Assets/Nations/Resources/karoli";

                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                }

                if (GUILayout.Button("Build Hungarian", GUILayout.Height(30)))
                {
                    string ProductKey = "BibleHungarian";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore Hungarian", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BibleHungarian/karoli";
                    string destinationA = "Assets/Nations/Resources/karoli";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move Indonesian", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Indonesian);

                    string sourceA = "Assets/Nations/BibleIndonesian/indo_tb";
                    string sourceB = "Assets/Nations/BibleIndonesian/indo_tm";
                    string destinationA = "Assets/Nations/Resources/indo_tb";
                    string destinationB = "Assets/Nations/Resources/indo_tm";

                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                    error = AssetDatabase.MoveAsset(sourceB, destinationB);
                }

                if (GUILayout.Button("Build Indonesian", GUILayout.Height(30)))
                {
                    string ProductKey = "BibleIndonesian";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore Indonesian", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BibleIndonesian/indo_tb";
                    string sourceB = "Assets/Nations/BibleIndonesian/indo_tm";
                    string destinationA = "Assets/Nations/Resources/indo_tb";
                    string destinationB = "Assets/Nations/Resources/indo_tm";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                    error = AssetDatabase.MoveAsset(destinationB, sourceB);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move Italian", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Italian);

                    string sourceA = "Assets/Nations/BibleItalian/diodati";
                    string destinationA = "Assets/Nations/Resources/diodati";

                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                }

                if (GUILayout.Button("Build Italian", GUILayout.Height(30)))
                {
                    string ProductKey = "BibleItalian";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore Italian", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BibleItalian/diodati";
                    string destinationA = "Assets/Nations/Resources/diodati";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move Japanese", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Japanese);

                    string sourceA = "Assets/Nations/BibleJapanese/bungo";
                    string sourceB = "Assets/Nations/BibleJapanese/kougo";
                    string destinationA = "Assets/Nations/Resources/bungo";
                    string destinationB = "Assets/Nations/Resources/kougo";

                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                    error = AssetDatabase.MoveAsset(sourceB, destinationB);
                }

                if (GUILayout.Button("Build Japanese", GUILayout.Height(30)))
                {
                    string ProductKey = "BibleJapanese";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore Japanese", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BibleJapanese/bungo";
                    string sourceB = "Assets/Nations/BibleJapanese/kougo";
                    string destinationA = "Assets/Nations/Resources/bungo";
                    string destinationB = "Assets/Nations/Resources/kougo";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                    error = AssetDatabase.MoveAsset(destinationB, sourceB);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move Polish", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Polish);

                    string sourceA = "Assets/Nations/BiblePolish/pol_nbg";
                    string sourceB = "Assets/Nations/BiblePolish/pol_ubg";
                    string sourceC = "Assets/Nations/BiblePolish/polbg";
                    string destinationA = "Assets/Nations/Resources/pol_nbg";
                    string destinationB = "Assets/Nations/Resources/pol_ubg";
                    string destinationC = "Assets/Nations/Resources/polbg";

                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                    error = AssetDatabase.MoveAsset(sourceB, destinationB);
                    error = AssetDatabase.MoveAsset(sourceC, destinationC);
                }

                if (GUILayout.Button("Build Polish", GUILayout.Height(30)))
                {
                    string ProductKey = "BiblePolish";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore Polish", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BiblePolish/pol_nbg";
                    string sourceB = "Assets/Nations/BiblePolish/pol_ubg";
                    string sourceC = "Assets/Nations/BiblePolish/polbg";
                    string destinationA = "Assets/Nations/Resources/pol_nbg";
                    string destinationB = "Assets/Nations/Resources/pol_ubg";
                    string destinationC = "Assets/Nations/Resources/polbg";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                    error = AssetDatabase.MoveAsset(destinationB, sourceB);
                    error = AssetDatabase.MoveAsset(destinationC, sourceC);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move Portuguese", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Portuguese);

                    string sourceA = "Assets/Nations/BiblePortuguese/almeida_ra";
                    string sourceB = "Assets/Nations/BiblePortuguese/almeida_rc";
                    string sourceC = "Assets/Nations/BiblePortuguese/blivre";
                    string destinationA = "Assets/Nations/Resources/almeida_ra";
                    string destinationB = "Assets/Nations/Resources/almeida_rc";
                    string destinationC = "Assets/Nations/Resources/blivre";

                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                    error = AssetDatabase.MoveAsset(sourceB, destinationB);
                    error = AssetDatabase.MoveAsset(sourceC, destinationC);
                }

                if (GUILayout.Button("Build Portuguese", GUILayout.Height(30)))
                {
                    string ProductKey = "BiblePortuguese";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore Portuguese", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BiblePortuguese/almeida_ra";
                    string sourceB = "Assets/Nations/BiblePortuguese/almeida_rc";
                    string sourceC = "Assets/Nations/BiblePortuguese/blivre";
                    string destinationA = "Assets/Nations/Resources/almeida_ra";
                    string destinationB = "Assets/Nations/Resources/almeida_rc";
                    string destinationC = "Assets/Nations/Resources/blivre";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                    error = AssetDatabase.MoveAsset(destinationB, sourceB);
                    error = AssetDatabase.MoveAsset(destinationC, sourceC);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move Romanian", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Romanian);

                    string sourceA = "Assets/Nations/BibleRomanian/fidela";
                    string destinationA = "Assets/Nations/Resources/fidela";

                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                }

                if (GUILayout.Button("Build Romanian", GUILayout.Height(30)))
                {
                    string ProductKey = "BibleRomanian";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore Romanian", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BibleRomanian/fidela";
                    string destinationA = "Assets/Nations/Resources/fidela";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move Russian", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Russian);

                    string sourceA = "Assets/Nations/BibleRussian/synodal";
                    string destinationA = "Assets/Nations/Resources/synodal";
    
                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                }

                if (GUILayout.Button("Build Russian", GUILayout.Height(30)))
                {
                    string ProductKey = "BibleRussian";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore Russian", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BibleRussian/synodal";
                    string destinationA = "Assets/Nations/Resources/synodal";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move Spanish", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Spanish);

                    string sourceA = "Assets/Nations/BibleSpanish/rv_1909";
                    string sourceB = "Assets/Nations/BibleSpanish/rvg";
                    string sourceC = "Assets/Nations/BibleSpanish/rvg_2004";
                    string sourceD = "Assets/Nations/BibleSpanish/sagradas";
                    string destinationA = "Assets/Nations/Resources/rv_1909";
                    string destinationB = "Assets/Nations/Resources/rvg";
                    string destinationC = "Assets/Nations/Resources/rvg_2004";
                    string destinationD = "Assets/Nations/Resources/sagradas";

                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                    error = AssetDatabase.MoveAsset(sourceB, destinationB);
                    error = AssetDatabase.MoveAsset(sourceC, destinationC);
                    error = AssetDatabase.MoveAsset(sourceD, destinationD);
                }

                if (GUILayout.Button("Build Spanish", GUILayout.Height(30)))
                {
                    string ProductKey = "BibleSpanish";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore Spanish", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BibleSpanish/rv_1909";
                    string sourceB = "Assets/Nations/BibleSpanish/rvg";
                    string sourceC = "Assets/Nations/BibleSpanish/rvg_2004";
                    string sourceD = "Assets/Nations/BibleSpanish/sagradas";
                    string destinationA = "Assets/Nations/Resources/rv_1909";
                    string destinationB = "Assets/Nations/Resources/rvg";
                    string destinationC = "Assets/Nations/Resources/rvg_2004";
                    string destinationD = "Assets/Nations/Resources/sagradas";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                    error = AssetDatabase.MoveAsset(destinationB, sourceB);
                    error = AssetDatabase.MoveAsset(destinationC, sourceC);
                    error = AssetDatabase.MoveAsset(destinationD, sourceD);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move Tagalog", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Tagalog);

                    string sourceA = "Assets/Nations/BibleTagalog/tagab";
                    string destinationA = "Assets/Nations/Resources/tagab";

                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                }

                if (GUILayout.Button("Build Tagalog", GUILayout.Height(30)))
                {
                    string ProductKey = "BibleTagalog";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore Tagalog", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BibleTagalog/tagab";
                    string destinationA = "Assets/Nations/Resources/tagab";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move Thai", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Thai);

                    string sourceA = "Assets/Nations/BibleThai/thaikjv";
                    string destinationA = "Assets/Nations/Resources/thaikjv";

                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                }

                if (GUILayout.Button("Build Thai", GUILayout.Height(30)))
                {
                    string ProductKey = "BibleThai";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore Thai", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BibleThai/thaikjv";
                    string destinationA = "Assets/Nations/Resources/thaikjv";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("Move Vietnamese", GUILayout.Height(30)))
                {
                    GetActiveObject(ENationType.Vietnamese);

                    string sourceA = "Assets/Nations/BibleVietnamese/cadman";
                    string destinationA = "Assets/Nations/Resources/cadman";

                    string error = AssetDatabase.MoveAsset(sourceA, destinationA);
                }

                if (GUILayout.Button("Build Vietnamese", GUILayout.Height(30)))
                {
                    string ProductKey = "BibleVietnamese";
                    SetBuildUnity(ProductKey);
                }

                if (GUILayout.Button("Restore Vietnamese", GUILayout.Height(30)))
                {
                    GameObject GO = GameObject.Find("BibleStudy");
                    Selection.activeGameObject = GO;

                    string sourceA = "Assets/Nations/BibleVietnamese/cadman";
                    string destinationA = "Assets/Nations/Resources/cadman";

                    string error = AssetDatabase.MoveAsset(destinationA, sourceA);
                }
            }
            GUILayout.EndHorizontal();
        // EditorGUILayout.EndVertical();
    }
}
