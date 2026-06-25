using UnityEngine;
using UnityEditor;
using System.Xml.Linq;
using System.Text;
using System.IO;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;

public class XmlToCsvEditor : EditorWindow
{
    // DefaultAsset 대신 TextAsset을 사용해야 XML이 정상적으로 할당됩니다.
    private TextAsset xmlFile;

    // 

    public static List<TextAsset> InternationalBibles = new List<TextAsset>();

    public static int BibleIndex = 0;

    [MenuItem("Tools/성경 XML을 CSV로 변환")]
    public static void ShowWindow()
    {
        GetWindow<XmlToCsvEditor>("XML to CSV");

        TextAsset[] Bibles = Resources.LoadAll<TextAsset>("XML/");

        InternationalBibles = Bibles.ToList();
    }

    private void OnGUI()
    {
        GUILayout.Label("성경 XML 변환 도구 (TextAsset 기반)", EditorStyles.boldLabel);
        EditorGUILayout.Space();

        // ObjectField의 타입을 TextAsset으로 변경
        // xmlFile = (TextAsset)EditorGUILayout.ObjectField("XML 파일 (TextAsset)", xmlFile, typeof(TextAsset), false);
        

        if (GUILayout.Button("CSV로 변환 시작"))
        {
            //if (xmlFile == null)
            //{
            //    EditorUtility.DisplayDialog("오류", "프로젝트 창에서 XML 파일을 드래그해서 넣어주세요.", "확인");
            //    return;
            //}

            

            xmlFile = InternationalBibles[BibleIndex];

            ConvertXmlToCsv();

            BibleIndex++;
        }
    }

    private void ConvertXmlToCsv()
    {
        // TextAsset으로부터 실제 파일 경로를 가져옵니다.
        string inputPath = AssetDatabase.GetAssetPath(xmlFile);
        string outputPath = inputPath.Replace(".xml", ".csv");

        // 만약 확장자가 .xml로 끝나지 않는 파일(예: .txt)을 넣었을 경우를 대비
        if (!inputPath.ToLower().EndsWith(".xml"))
        {
            outputPath = inputPath + ".csv";
        }

        try
        {
            XDocument doc = XDocument.Load(inputPath);
            StringBuilder csvBuilder = new StringBuilder();

            csvBuilder.AppendLine("Testament,Book,Chapter,Verse,Content");

            var verses = from testament in doc.Descendants("testament")
                         let tName = testament.Attribute("name")?.Value ?? ""
                         from book in testament.Elements("book")
                         let bNum = book.Attribute("number")?.Value ?? ""
                         from chapter in book.Elements("chapter")
                         let cNum = chapter.Attribute("number")?.Value ?? ""
                         from verse in chapter.Elements("verse")
                         select new
                         {
                             T = tName,
                             B = bNum,
                             C = cNum,
                             V = verse.Attribute("number")?.Value ?? "",
                             Txt = verse.Value.Replace("\"", "\"\"")
                         };

            foreach (var v in verses)
            {
                csvBuilder.AppendLine($"\"{v.T}\",\"{v.B}\",\"{v.C}\",\"{v.V}\",\"{v.Txt}\"");
            }

            File.WriteAllText(outputPath, csvBuilder.ToString(), Encoding.UTF8);
            AssetDatabase.Refresh();

            // EditorUtility.DisplayDialog("성공", $"변환 완료!\n파일 위치: {outputPath}", "확인");
        }
        catch (System.Exception e)
        {
            // EditorUtility.DisplayDialog("오류 발생", "XML 형식이 올바르지 않거나 읽을 수 없습니다.\n" + e.Message, "확인");
        }
    }
}