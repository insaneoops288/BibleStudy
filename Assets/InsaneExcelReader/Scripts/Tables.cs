using UnityEngine;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class BibleEachInfo
{
    public string m_ID { get; private set; }
    public string m_Content { get; private set; }
    public string m_Nation { get; private set; }
    public int m_Bible { get; private set; }
    public string m_NationType { get; private set; }
    public float m_DelayMiddle { get; private set; }
    public float m_DelayEnd { get; private set; }

    public void SetID(string ID) { m_ID = ID; }
    public void SetContent(string Content) { m_Content = Content; }
    public void SetNation(string Nation) { m_Nation = Nation; }
    public void SetBible(int Bible) { m_Bible = Bible; }
    public void SetNationType(string NationType) { m_NationType = NationType; }
    public void SetDelayMiddle(float DelayMiddle) { m_DelayMiddle = DelayMiddle; }
    public void SetDelayEnd(float DelayEnd) { m_DelayEnd = DelayEnd; }
}

public class BibleNationInfo
{
    public string m_Nation { get; private set; }
    public int m_Bible { get; private set; }
    public string m_NationType { get; private set; }
    public float m_DelayMiddle { get; private set; }
    public float m_DelayEnd { get; private set; }
    public float m_OtherDelayMiddle { get; private set; }
    public float m_OtherDelayEnd { get; private set; }

    public void SetNation(string Nation) { m_Nation = Nation; }
    public void SetBible(int Bible) { m_Bible = Bible; }
    public void SetNationType(string NationType) { m_NationType = NationType; }
    public void SetDelayMiddle(float DelayMiddle) { m_DelayMiddle = DelayMiddle; }
    public void SetDelayEnd(float DelayEnd) { m_DelayEnd = DelayEnd; }
    public void SetOtherDelayMiddle(float OtherDelayMiddle) { m_OtherDelayMiddle = OtherDelayMiddle; }
    public void SetOtherDelayEnd(float OtherDelayEnd) { m_OtherDelayEnd = OtherDelayEnd; }
}

public class BibleTypeInfo
{
    public string m_ID { get; private set; }
    public string m_Path { get; private set; }
    public string m_BibleName { get; private set; }
    public string m_BibleContent { get; private set; }

    public void SetID(string ID) { m_ID = ID; }
    public void SetPath(string Path) { m_Path = Path; }
    public void SetBibleName(string BibleName) { m_BibleName = BibleName; }
    public void SetBibleContent(string BibleContent) { m_BibleContent = BibleContent; }
}

public class BibleWiseInfo
{
    public int m_ID { get; private set; }
    public string m_BibleMessage { get; private set; }

    public void SetID(int ID) { m_ID = ID; }
    public void SetBibleMessage(string BibleMessage) { m_BibleMessage = BibleMessage; }
}

public class CustomizeInfo
{
    public int m_ID { get; private set; }
    public string m_Korean { get; private set; }
    public string m_English { get; private set; }

    public void SetID(int ID) { m_ID = ID; }
    public void SetKorean(string Korean) { m_Korean = Korean; }
    public void SetEnglish(string English) { m_English = English; }
}

public class NewTestamentInfo
{
    public int m_ID { get; private set; }
    public string m_English { get; private set; }
    public string m_Korean { get; private set; }
    public int m_Count { get; private set; }
    public string m_EnglishTarget { get; private set; }
    public string m_NIV { get; private set; }
    public string m_KoreanTarget { get; private set; }
    public string m_Source { get; private set; }
    public string m_EasyBible { get; private set; }
    public string m_RevisedHangul { get; private set; }
    public string m_RevisedRevision { get; private set; }
    public string m_JointTranslation { get; private set; }
    public string m_NewStandardTranslation { get; private set; }
    public string m_KoreanBible { get; private set; }
    public string m_SourceEnglish { get; private set; }
    public string m_KJV { get; private set; }
    public string m_NewKJV { get; private set; }
    public string m_ESV { get; private set; }
    public string m_NewRSV { get; private set; }
    public string m_NASB { get; private set; }
    public string m_afri { get; private set; }
    public string m_albanian { get; private set; }
    public string m_chinese_union_simp { get; private set; }
    public string m_chinese_union_trad { get; private set; }
    public string m_ckjv_sds { get; private set; }
    public string m_ckjv_sdt { get; private set; }
    public string m_bkr { get; private set; }
    public string m_stve { get; private set; }
    public string m_finn { get; private set; }
    public string m_epee { get; private set; }
    public string m_martin { get; private set; }
    public string m_oster { get; private set; }
    public string m_segond_1910 { get; private set; }
    public string m_elberfelder_1871 { get; private set; }
    public string m_elberfelder_1905 { get; private set; }
    public string m_luther { get; private set; }
    public string m_luther_1912 { get; private set; }
    public string m_schlachter { get; private set; }
    public string m_wlc { get; private set; }
    public string m_irv { get; private set; }
    public string m_karoli { get; private set; }
    public string m_indo_tb { get; private set; }
    public string m_indo_tm { get; private set; }
    public string m_diodati { get; private set; }
    public string m_bungo { get; private set; }
    public string m_kougo { get; private set; }
    public string m_maori { get; private set; }
    public string m_opt { get; private set; }
    public string m_pol_nbg { get; private set; }
    public string m_pol_ubg { get; private set; }
    public string m_polbg { get; private set; }
    public string m_almeida_ra { get; private set; }
    public string m_almeida_rc { get; private set; }
    public string m_blivre { get; private set; }
    public string m_fidela { get; private set; }
    public string m_synodal { get; private set; }
    public string m_rv_1909 { get; private set; }
    public string m_rvg { get; private set; }
    public string m_rvg_2004 { get; private set; }
    public string m_sagradas { get; private set; }
    public string m_tagab { get; private set; }
    public string m_thaikjv { get; private set; }
    public string m_turkish { get; private set; }
    public string m_cadman { get; private set; }
    public string m_Portuguese { get; private set; }
    public string m_German { get; private set; }
    public string m_Japanese { get; private set; }
    public string m_Chinese { get; private set; }
    public string m_Romanian { get; private set; }
    public string m_French { get; private set; }
    public string m_Spanish { get; private set; }
    public string m_Italian { get; private set; }
    public string m_Hungarian { get; private set; }
    public string m_Russian { get; private set; }
    public string m_Hindi { get; private set; }
    public string m_AcehBible { get; private set; }
    public string m_AdilabadGondiBible { get; private set; }
    public string m_Afrikaans1983Bible { get; private set; }
    public string m_Afrikaans2020Bible { get; private set; }
    public string m_Afrikaans2023Bible { get; private set; }
    public string m_AfrikaansABABible { get; private set; }
    public string m_AfrikaansBible { get; private set; }
    public string m_AfrikaansDBBible { get; private set; }
    public string m_AfrikaansNLVBible { get; private set; }
    public string m_AhiraniBible { get; private set; }
    public string m_Albanian1872Bible { get; private set; }
    public string m_Albanian1879Bible { get; private set; }
    public string m_Albanian2018Bible { get; private set; }
    public string m_AlbanianBible { get; private set; }
    public string m_Amharic2000Bible { get; private set; }
    public string m_AmharicBible { get; private set; }
    public string m_AmharicCatholicBible { get; private set; }
    public string m_AmharicDawroBible { get; private set; }
    public string m_AmharicDawroDFBEBible { get; private set; }
    public string m_AmharicDawroDFBLVLBible { get; private set; }
    public string m_AmharicDawroDWRNTBible { get; private set; }
    public string m_AmharicDawroWWIBible { get; private set; }
    public string m_AmharicGamo2017Bible { get; private set; }
    public string m_AmharicGamoBible { get; private set; }
    public string m_AmharicGamoGMBible { get; private set; }
    public string m_AmharicGamoWordBible { get; private set; }
    public string m_AmharicGofaBible { get; private set; }
    public string m_AmharicGofaGFBEVFBible { get; private set; }
    public string m_AmharicGofaGFBLVFBible { get; private set; }
    public string m_AmharicGofaRNTBible { get; private set; }
    public string m_AmharicGofaWWIBible { get; private set; }
    public string m_AmharicNASVBible { get; private set; }
    public string m_AmharicNSTBible { get; private set; }
    public string m_AmharicTigrinya15Bible { get; private set; }
    public string m_AmharicTigrinya2024Bible { get; private set; }
    public string m_AmharicTigrinyaBible { get; private set; }
    public string m_Arabic1978Bible { get; private set; }
    public string m_Arabic2016Bible { get; private set; }
    public string m_Arabic2018Bible { get; private set; }
    public string m_Arabic2023Bible { get; private set; }
    public string m_ArabicAlgeriaBible { get; private set; }
    public string m_ArabicAPDBible { get; private set; }
    public string m_ArabicAVDBible { get; private set; }
    public string m_ArabicAVDDVBible { get; private set; }
    public string m_ArabicBible { get; private set; }
    public string m_ArabicERVBible { get; private set; }
    public string m_ArabicGNABible { get; private set; }
    public string m_ArabicGOVBible { get; private set; }
    public string m_ArabicLABible { get; private set; }
    public string m_ArabicLebaneseBible { get; private set; }
    public string m_ArabicMorocco2023Bible { get; private set; }
    public string m_ArabicMoroccoBible { get; private set; }
    public string m_ArabicSABBible { get; private set; }
    public string m_ArabicSABible { get; private set; }
    public string m_ArabicSVDBible { get; private set; }
    public string m_ArabicTMABible { get; private set; }
    public string m_ArabicTU2022Bible { get; private set; }
    public string m_ArabicTunisianBible { get; private set; }
    public string m_AramaicBible { get; private set; }
    public string m_Armenian1853Bible { get; private set; }
    public string m_Armenian2017Bible { get; private set; }
    public string m_Armenian2018Bible { get; private set; }
    public string m_Armenian2019Bible { get; private set; }
    public string m_ArmenianAraratBible { get; private set; }
    public string m_ArmenianBible { get; private set; }
    public string m_ArmenianEasternBible { get; private set; }
    public string m_ArmenianNEABible { get; private set; }
    public string m_AssameseBible { get; private set; }
    public string m_AvarBible { get; private set; }
    public string m_AwadhiBible { get; private set; }
    public string m_Aymara1986Bible { get; private set; }
    public string m_Aymara1997Bible { get; private set; }
    public string m_AymaraBible { get; private set; }
    public string m_Azerbaijan2013Bible { get; private set; }
    public string m_AzerbaijanBible { get; private set; }
    public string m_AzerbaijanSouthBible { get; private set; }
    public string m_BagriBible { get; private set; }
    public string m_BalineseBible { get; private set; }
    public string m_BalochiArabicBible { get; private set; }
    public string m_BalochiBible { get; private set; }
    public string m_BalochiSoutherenBible { get; private set; }
    public string m_BalochiSoutherenLatinBible { get; private set; }
    public string m_Baoule1974Bible { get; private set; }
    public string m_Baoule1998Bible { get; private set; }
    public string m_BaouleBible { get; private set; }
    public string m_Bashkir2023Bible { get; private set; }
    public string m_BashkirBible { get; private set; }
    public string m_BasqueBible { get; private set; }
    public string m_Basque2008Bible { get; private set; }
    public string m_BavarianBible { get; private set; }
    public string m_Belarusian2017Bible { get; private set; }
    public string m_BelarusianBible { get; private set; }
    public string m_BelarusianBokunBible { get; private set; }
    public string m_BelarusianCHNTBible { get; private set; }
    public string m_BelarusianNTJSBible { get; private set; }
    public string m_BembaBible { get; private set; }
    public string m_Bengali2017Bible { get; private set; }
    public string m_Bengali2023Bible { get; private set; }
    public string m_BengaliBACIBBible { get; private set; }
    public string m_BengaliBCVBible { get; private set; }
    public string m_BengaliBible { get; private set; }
    public string m_BengaliBSIBible { get; private set; }
    public string m_BengaliCLBSIBible { get; private set; }
    public string m_BengaliERVBible { get; private set; }
    public string m_BengaliIRVBENBible { get; private set; }
    public string m_BengaliMBCLBible { get; private set; }
    public string m_BengaliSBCLBible { get; private set; }
    public string m_BerberBible { get; private set; }
    public string m_BhilaliBible { get; private set; }
    public string m_BodoBible { get; private set; }
    public string m_BodoNTBPL20Bible { get; private set; }
    public string m_BosnianBible { get; private set; }
    public string m_BrajBible { get; private set; }
    public string m_BugisBible { get; private set; }
    public string m_Bulgarian2015Bible { get; private set; }
    public string m_BulgarianBible { get; private set; }
    public string m_BulgarianBOBBible { get; private set; }
    public string m_BulgarianBPBBible { get; private set; }
    public string m_BulgarianCBTBible { get; private set; }
    public string m_BulgarianSPBBible { get; private set; }
    public string m_BulgarianTZABible { get; private set; }
    public string m_BulgarianVerensBible { get; private set; }
    public string m_BundeliBible { get; private set; }
    public string m_Burmese1928Bible { get; private set; }
    public string m_Burmese2021Bible { get; private set; }
    public string m_BurmeseBCLBible { get; private set; }
    public string m_BurmeseBible { get; private set; }
    public string m_BurmeseJBZVBible { get; private set; }
    public string m_BurmeseMCLZVBible { get; private set; }
    public string m_BurmeseMSBUBible { get; private set; }
    public string m_BurmeseMSBZBible { get; private set; }
    public string m_CatalanBCIBible { get; private set; }
    public string m_CatalanBECBible { get; private set; }
    public string m_Cebuano1999Bible { get; private set; }
    public string m_Cebuano2011Bible { get; private set; }
    public string m_CebuanoAPSDBible { get; private set; }
    public string m_CebuanoBible { get; private set; }
    public string m_CebuanoRCPVBible { get; private set; }
    public string m_ChechenBible { get; private set; }
    public string m_Chewa1992Bible { get; private set; }
    public string m_Chewa2014Bible { get; private set; }
    public string m_Chewa2016Bible { get; private set; }
    public string m_ChewaBLYDCBible { get; private set; }
    public string m_ChhattisgarhiBible { get; private set; }
    public string m_ChibembaBible { get; private set; }
    public string m_Chin2010Bible { get; private set; }
    public string m_ChinBSIBible { get; private set; }
    public string m_ChinCSHBible { get; private set; }
    public string m_ChinDNTBible { get; private set; }
    public string m_Chinese1886Bible { get; private set; }
    public string m_Chinese1919Bible { get; private set; }
    public string m_Chinese1927Bible { get; private set; }
    public string m_Chinese1933Bible { get; private set; }
    public string m_Chinese1941Bible { get; private set; }
    public string m_Chinese1967Bible { get; private set; }
    public string m_ChineseCCBSBible { get; private set; }
    public string m_ChineseCCBTBible { get; private set; }
    public string m_ChineseCSBSBible { get; private set; }
    public string m_ChineseCSBTBible { get; private set; }
    public string m_ChineseCUNPSSBible { get; private set; }
    public string m_ChineseCUNPSTBible { get; private set; }
    public string m_ChineseNankingBible { get; private set; }
    public string m_ChinesePekingBible { get; private set; }
    public string m_ChineseRCUVSSBible { get; private set; }
    public string m_ChineseRCUVTBible { get; private set; }
    public string m_ChineseSimplifiedBible { get; private set; }
    public string m_ChineseSimplifiedNewBible { get; private set; }
    public string m_ChineseTCV2019TBible { get; private set; }
    public string m_ChineseTHV2012Bible { get; private set; }
    public string m_ChineseTraditionalBible { get; private set; }
    public string m_ChineseTraditionalERVBible { get; private set; }
    public string m_ChineseTraditionalNewBible { get; private set; }
    public string m_ChineseTTVHBible { get; private set; }
    public string m_ChineseTTVRBible { get; private set; }
    public string m_ChineseUnion2010Bible { get; private set; }
    public string m_ChineseWenli1823Bible { get; private set; }
    public string m_ChineseWenli1885Bible { get; private set; }
    public string m_ChineseWenli1897Bible { get; private set; }
    public string m_ChineseWenliBible { get; private set; }
    public string m_ChineseWenliEasyBible { get; private set; }
    public string m_ChinKNTPBible { get; private set; }
    public string m_ChinMatupi2006Bible { get; private set; }
    public string m_ChinMatupiBible { get; private set; }
    public string m_ChinSCB2Bible { get; private set; }
    public string m_ChinTB77Bible { get; private set; }
    public string m_ChinTBR17Bible { get; private set; }
    public string m_ChinTDBBible { get; private set; }
    public string m_ChinTedim2011Bible { get; private set; }
    public string m_ChinTedimBible { get; private set; }
    public string m_ChuvashBible { get; private set; }
    public string m_ChuvashRSOBible { get; private set; }
    public string m_CopticBible { get; private set; }
    public string m_CopticCNTVBible { get; private set; }
    public string m_CopticSahidicBible { get; private set; }
    public string m_CroatianBible { get; private set; }
    public string m_CroatianBKJBible { get; private set; }
    public string m_CroatianCNTBible { get; private set; }
    public string m_CroatianGKSBible { get; private set; }
    public string m_CroatianSHPBible { get; private set; }
    public string m_Czech1922Bible { get; private set; }
    public string m_Czech1947Bible { get; private set; }
    public string m_Czech1951Bible { get; private set; }
    public string m_CzechBible { get; private set; }
    public string m_CzechEkumenickyBible { get; private set; }
    public string m_CzechKralichka1613Bible { get; private set; }
    public string m_CzechKralichka1998Bible { get; private set; }
    public string m_CzechPMPZBible { get; private set; }
    public string m_CzechPrekladBible { get; private set; }
    public string m_CzechSNCBible { get; private set; }
    public string m_DagbaniBible { get; private set; }
    public string m_Danish1819Bible { get; private set; }
    public string m_Danish2015Bible { get; private set; }
    public string m_DanishBible { get; private set; }
    public string m_DanishLBBible { get; private set; }
    public string m_DanishWIEBible { get; private set; }
    public string m_Dinka2006Bible { get; private set; }
    public string m_DinkaBible { get; private set; }
    public string m_DinkaLEKJOTBible { get; private set; }
    public string m_DogriBible { get; private set; }
    public string m_Dutch1939Bible { get; private set; }
    public string m_Dutch2007Bible { get; private set; }
    public string m_DutchBBBible { get; private set; }
    public string m_DutchBible { get; private set; }
    public string m_DutchEBV24Bible { get; private set; }
    public string m_DutchFrisianBible { get; private set; }
    public string m_DutchGBVNTBible { get; private set; }
    public string m_DutchHSVBible { get; private set; }
    public string m_DutchHTBBible { get; private set; }
    public string m_DutchNBGBible { get; private set; }
    public string m_DutchReimerBible { get; private set; }
    public string m_DutchSVVBible { get; private set; }
    public string m_DutchVBBible { get; private set; }
    public string m_DyulaJulaBible { get; private set; }
    public string m_DyulaKumaBible { get; private set; }
    public string m_DyulaLayidukuraBible { get; private set; }
    public string m_EdoBible { get; private set; }
    public string m_EnglishAmplifiedBible { get; private set; }
    public string m_EnglishAmplifiedClassicBible { get; private set; }
    public string m_EnglishASVBible { get; private set; }
    public string m_EnglishBereanBible { get; private set; }
    public string m_EnglishCSBBible { get; private set; }
    public string m_EnglishDarbyBible { get; private set; }
    public string m_EnglishEASYBible { get; private set; }
    public string m_EnglishERVBible { get; private set; }
    public string m_EnglishESVBible { get; private set; }
    public string m_EnglishGNTBible { get; private set; }
    public string m_EnglishGWBible { get; private set; }
    public string m_EnglishHCSBBible { get; private set; }
    public string m_EnglishKJBible { get; private set; }
    public string m_EnglishLSBBible { get; private set; }
    public string m_EnglishMEVBible { get; private set; }
    public string m_EnglishNASBBible { get; private set; }
    public string m_EnglishNASUBible { get; private set; }
    public string m_EnglishNETBible { get; private set; }
    public string m_EnglishNIRVBible { get; private set; }
    public string m_EnglishNIVBible { get; private set; }
    public string m_EnglishNKJBible { get; private set; }
    public string m_EnglishNLTBible { get; private set; }
    public string m_EnglishNRSVBible { get; private set; }
    public string m_EnglishPassionBible { get; private set; }
    public string m_EnglishRSVBible { get; private set; }
    public string m_EnglishTLBible { get; private set; }
    public string m_EnglishTyndale1537Bible { get; private set; }
    public string m_EnglishYLTBible { get; private set; }
    public string m_EsperantoBible { get; private set; }
    public string m_Estonian2022Bible { get; private set; }
    public string m_EstonianBible { get; private set; }
    public string m_EstonianEEPBible { get; private set; }
    public string m_Ewe1913Bible { get; private set; }
    public string m_Ewe2014Bible { get; private set; }
    public string m_Ewe2020Bible { get; private set; }
    public string m_EweBible { get; private set; }
    public string m_Finnish1776Bible { get; private set; }
    public string m_Finnish1992Bible { get; private set; }
    public string m_FinnishBible { get; private set; }
    public string m_FinnishFINRKBible { get; private set; }
    public string m_FinnishSTLKBible { get; private set; }
    public string m_FonBible { get; private set; }
    public string m_French2004Bible { get; private set; }
    public string m_FrenchBBBBible { get; private set; }
    public string m_FrenchBDSBible { get; private set; }
    public string m_FrenchBFCBible { get; private set; }
    public string m_FrenchBible { get; private set; }
    public string m_FrenchCramponBible { get; private set; }
    public string m_FrenchDarbyBible { get; private set; }
    public string m_FrenchJerusalemBible { get; private set; }
    public string m_FrenchLeonBible { get; private set; }
    public string m_FrenchMachairaBible { get; private set; }
    public string m_FrenchMartinBible { get; private set; }
    public string m_FrenchNBSBible { get; private set; }
    public string m_FrenchNEG79Bible { get; private set; }
    public string m_FrenchNFCBible { get; private set; }
    public string m_FrenchNVS78Bible { get; private set; }
    public string m_FrenchOSTBible { get; private set; }
    public string m_FrenchOstervaldBible { get; private set; }
    public string m_FrenchPDV2017Bible { get; private set; }
    public string m_FrenchPerretBible { get; private set; }
    public string m_FrenchS21Bible { get; private set; }
    public string m_FrenchVigourouxBible { get; private set; }
    public string m_Fulfulde2010Bible { get; private set; }
    public string m_FulfuldeAadiBible { get; private set; }
    public string m_FulfuldeAdamawaBible { get; private set; }
    public string m_FulfuldeAlkawalBible { get; private set; }
    public string m_FulfuldeArabicBible { get; private set; }
    public string m_FulfuldeBeninBible { get; private set; }
    public string m_FulfuldeBurkinaFasoBible { get; private set; }
    public string m_FulfuldeDewtereBible { get; private set; }
    public string m_FulfuldeWestNigerBible { get; private set; }
    public string m_Gaelic1875Bible { get; private set; }
    public string m_GaelicABGBible { get; private set; }
    public string m_GaelicABIGBible { get; private set; }
    public string m_GaelicATNBible { get; private set; }
    public string m_GalacianSEPTBible { get; private set; }
    public string m_GarhwaliBible { get; private set; }
    public string m_GarhwaliGBMBible { get; private set; }
    public string m_Georgian2002Bible { get; private set; }
    public string m_Georgian2012Bible { get; private set; }
    public string m_GeorgianBible { get; private set; }
    public string m_German1545Bible { get; private set; }
    public string m_German2011Bible { get; private set; }
    public string m_GermanAlbrecht1926Bible { get; private set; }
    public string m_GermanBible { get; private set; }
    public string m_GermanElber1905Bible { get; private set; }
    public string m_GermanGruenewaldBible { get; private set; }
    public string m_GermanHeuteBible { get; private set; }
    public string m_GermanHFABible { get; private set; }
    public string m_GermanInterlinearBible { get; private set; }
    public string m_GermanLUT17Bible { get; private set; }
    public string m_GermanLuther1912Bible { get; private set; }
    public string m_GermanLutherHeuteBible { get; private set; }
    public string m_GermanSchlachter2000Bible { get; private set; }
    public string m_GermanTafelBible { get; private set; }
    public string m_GermanTKWBible { get; private set; }
    public string m_GermanUbersetzung2014Bible { get; private set; }
    public string m_GhomalaBible { get; private set; }
    public string m_Greek1550Bible { get; private set; }
    public string m_GreekBible { get; private set; }
    public string m_GreekBYZ04Bible { get; private set; }
    public string m_GreekBYZ18Bible { get; private set; }
    public string m_GreekElzevirBible { get; private set; }
    public string m_GreekF35Bible { get; private set; }
    public string m_GreekFPBBible { get; private set; }
    public string m_GreekGNTBible { get; private set; }
    public string m_GreekLMGNTBible { get; private set; }
    public string m_GreekModern1904Bible { get; private set; }
    public string m_GreekModernFPBBible { get; private set; }
    public string m_GreekNTVBible { get; private set; }
    public string m_GreekSBLGNTBible { get; private set; }
    public string m_GreekTCGNTBible { get; private set; }
    public string m_GreekTGVBible { get; private set; }
    public string m_GreekTHGNTBible { get; private set; }
    public string m_GreekTR1894Bible { get; private set; }
    public string m_Guarani1913Bible { get; private set; }
    public string m_Guarani1970Bible { get; private set; }
    public string m_Guarani1996Bible { get; private set; }
    public string m_Guarani2001Bible { get; private set; }
    public string m_Guarani2015Bible { get; private set; }
    public string m_Guarani2017Bible { get; private set; }
    public string m_GuaraniBible { get; private set; }
    public string m_GuaraniMBYABible { get; private set; }
    public string m_GuaraniSIMBABible { get; private set; }
    public string m_Gujarati2016Bible { get; private set; }
    public string m_Gujarati2017Bible { get; private set; }
    public string m_GujaratiBible { get; private set; }
    public string m_GujaratiGUOVBible { get; private set; }
    public string m_GussiBible { get; private set; }
    public string m_HadiyyaBible { get; private set; }
    public string m_HaitianBible { get; private set; }
    public string m_HaitianBSABible { get; private set; }
    public string m_HaitianHWPBible { get; private set; }
    public string m_HaitianVFKBible { get; private set; }
    public string m_HaryanviBible { get; private set; }
    public string m_Hausa2010Bible { get; private set; }
    public string m_Hausa2013Bible { get; private set; }
    public string m_HausaARBible { get; private set; }
    public string m_Hebrew1885Bible { get; private set; }
    public string m_HebrewAleppoCodexBible { get; private set; }
    public string m_HebrewBible { get; private set; }
    public string m_HebrewBSIBible { get; private set; }
    public string m_HebrewHHHBible { get; private set; }
    public string m_HebrewLeningradCodexBible { get; private set; }
    public string m_HebrewMHBBible { get; private set; }
    public string m_HebrewMHNT2020Bible { get; private set; }
    public string m_HebrewTDBible { get; private set; }
    public string m_Hindi2017Bible { get; private set; }
    public string m_HindiBible { get; private set; }
    public string m_HindiCLBSIBible { get; private set; }
    public string m_HindiERVBible { get; private set; }
    public string m_HindiFijiBible { get; private set; }
    public string m_HindiHSBBible { get; private set; }
    public string m_HindiHSSBible { get; private set; }
    public string m_HindiIRVBible { get; private set; }
    public string m_HindiOVBSIBible { get; private set; }
    public string m_HindiRomanBible { get; private set; }
    public string m_Hmong2000Bible { get; private set; }
    public string m_Hmong2004Bible { get; private set; }
    public string m_HungarianBDUZBible { get; private set; }
    public string m_HungarianBible { get; private set; }
    public string m_HungarianBUZBible { get; private set; }
    public string m_HungarianCSIABible { get; private set; }
    public string m_HungarianCSUZBible { get; private set; }
    public string m_HungarianEFOBible { get; private set; }
    public string m_HungarianEIVBible { get; private set; }
    public string m_HungarianERVBible { get; private set; }
    public string m_HungarianKaroliBible { get; private set; }
    public string m_HungarianKIBBible { get; private set; }
    public string m_HungarianKNBBible { get; private set; }
    public string m_HungarianKSZEBible { get; private set; }
    public string m_HungarianMRUZBible { get; private set; }
    public string m_HungarianRLUZBible { get; private set; }
    public string m_HungarianRUFBible { get; private set; }
    public string m_HungarianSIUZBible { get; private set; }
    public string m_HungarianVSUZBible { get; private set; }
    public string m_IbanBible { get; private set; }
    public string m_IbibioBible { get; private set; }
    public string m_Icelandic1981Bible { get; private set; }
    public string m_IcelandicBible { get; private set; }
    public string m_Igbo1988Bible { get; private set; }
    public string m_Igbo2006Bible { get; private set; }
    public string m_Igbo2020Bible { get; private set; }
    public string m_IkaBible { get; private set; }
    public string m_Ilokano1973Bible { get; private set; }
    public string m_IlokanoBible { get; private set; }
    public string m_Ilonggo2012Bible { get; private set; }
    public string m_IlonggoAPDBible { get; private set; }
    public string m_IlonggoBible { get; private set; }
    public string m_IndonesianAGSBible { get; private set; }
    public string m_IndonesianAMD2021Bible { get; private set; }
    public string m_IndonesianBible { get; private set; }
    public string m_IndonesianBISBible { get; private set; }
    public string m_IndonesianBPJBible { get; private set; }
    public string m_IndonesianFAYHBible { get; private set; }
    public string m_IndonesianINOTAZIBible { get; private set; }
    public string m_IndonesianPBTB2Bible { get; private set; }
    public string m_IndonesianTLBible { get; private set; }
    public string m_IndonesianTSIBible { get; private set; }
    public string m_IndonesianVMDBible { get; private set; }
    public string m_Irish1817Bible { get; private set; }
    public string m_Irish1951Bible { get; private set; }
    public string m_Irish1970Bible { get; private set; }
    public string m_Irish2012Bible { get; private set; }
    public string m_IrishBible { get; private set; }
    public string m_Italian1649Bible { get; private set; }
    public string m_Italian2014Bible { get; private set; }
    public string m_Italian2020Bible { get; private set; }
    public string m_ItalianBible { get; private set; }
    public string m_ItalianCEI2008Bible { get; private set; }
    public string m_ItalianIPNBible { get; private set; }
    public string m_ItalianLaNuovaDiodatiBible { get; private set; }
    public string m_ItalianNR1994Bible { get; private set; }
    public string m_ItalianRivedutaBible { get; private set; }
    public string m_IuMienBible { get; private set; }
    public string m_IuMienThaiBible { get; private set; }
    public string m_JamaicanBible { get; private set; }
    public string m_Japanese1965Bible { get; private set; }
    public string m_Japanese1987Bible { get; private set; }
    public string m_Japanese2017Bible { get; private set; }
    public string m_JapaneseBible { get; private set; }
    public string m_JapaneseCO1955Bible { get; private set; }
    public string m_JapaneseERVBible { get; private set; }
    public string m_JapaneseJCBBible { get; private set; }
    public string m_JavaneseBible { get; private set; }
    public string m_JavaneseJVNBible { get; private set; }
    public string m_JavaneseKJS17Bible { get; private set; }
    public string m_KabardianBible { get; private set; }
    public string m_KabyleBible { get; private set; }
    public string m_KachinJCLBBible { get; private set; }
    public string m_KachinJHVT3Bible { get; private set; }
    public string m_Kalenjin2019Bible { get; private set; }
    public string m_KalenjinBible { get; private set; }
    public string m_KalenjinRevisedBible { get; private set; }
    public string m_KambaBible { get; private set; }
    public string m_KambaMBIVLIABible { get; private set; }
    public string m_KangriBible { get; private set; }
    public string m_Kannada2022Bible { get; private set; }
    public string m_KannadaBible { get; private set; }
    public string m_KannadaBSIBible { get; private set; }
    public string m_KannadaBSIJVBible { get; private set; }
    public string m_KannadaIRVBible { get; private set; }
    public string m_KannadaKNCLBible { get; private set; }
    public string m_Karakalpak2004Bible { get; private set; }
    public string m_Karakalpak2022Bible { get; private set; }
    public string m_KarakalpakK2022Bible { get; private set; }
    public string m_Kazakhstan2023Bible { get; private set; }
    public string m_KazakhstanBible { get; private set; }
    public string m_KenyaGIKCLBible { get; private set; }
    public string m_Khmer2005Bible { get; private set; }
    public string m_Khmer2012Bible { get; private set; }
    public string m_Khmer2014Bible { get; private set; }
    public string m_Khmer2016Bible { get; private set; }
    public string m_Khmer2019Bible { get; private set; }
    public string m_KhmerBFBSBible { get; private set; }
    public string m_KhmerBible { get; private set; }
    public string m_Kiche1995Bible { get; private set; }
    public string m_Kiche2022Bible { get; private set; }
    public string m_KicheBible { get; private set; }
    public string m_KicheQUCNBible { get; private set; }
    public string m_Kikuyu2013Bible { get; private set; }
    public string m_Kikuyu2014Bible { get; private set; }
    public string m_Kikuyu2019Bible { get; private set; }
    public string m_KikwangoBible { get; private set; }
    public string m_KimbunduBible { get; private set; }
    public string m_KimiiruBible { get; private set; }
    public string m_Kinyarwanda2001Bible { get; private set; }
    public string m_Kinyarwanda2012Bible { get; private set; }
    public string m_KinyarwandaBIRBible { get; private set; }
    public string m_KirundiCorosheBible { get; private set; }
    public string m_KirundiRishaBible { get; private set; }
    public string m_KitubaBible { get; private set; }
    public string m_KonkaniBible { get; private set; }
    public string m_Korean2021Bible { get; private set; }
    public string m_KoreanAEBBible { get; private set; }
    public string m_KoreanKLBBible { get; private set; }
    public string m_KoreanNKRVBible { get; private set; }
    public string m_KoreanRentierBible { get; private set; }
    public string m_KoreanRNKSVBible { get; private set; }
    public string m_KoreanTKVBible { get; private set; }
    public string m_KoreanWoorimalBible { get; private set; }
    public string m_KoyaBible { get; private set; }
    public string m_KrioBible { get; private set; }
    public string m_KumaoniBible { get; private set; }
    public string m_Kurdish2005Bible { get; private set; }
    public string m_Kurdish2017Bible { get; private set; }
    public string m_KurdishBHDBible { get; private set; }
    public string m_KurdishBible { get; private set; }
    public string m_KurdishKMRNTCBible { get; private set; }
    public string m_KurdishKMRNTLBible { get; private set; }
    public string m_KurdishPNTZSBible { get; private set; }
    public string m_KurdishSKBBible { get; private set; }
    public string m_KurdishSKVBible { get; private set; }
    public string m_Kurukh2025Bible { get; private set; }
    public string m_KurukhBible { get; private set; }
    public string m_Kyrgyz2004Bible { get; private set; }
    public string m_Kyrgyz2005Bible { get; private set; }
    public string m_LahuBible { get; private set; }
    public string m_LahuLHINTBible { get; private set; }
    public string m_LambadiBible { get; private set; }
    public string m_Lango1979Bible { get; private set; }
    public string m_LangoBible { get; private set; }
    public string m_Lao2012Bible { get; private set; }
    public string m_LaoBible { get; private set; }
    public string m_LaoLCVBible { get; private set; }
    public string m_LatinBible { get; private set; }
    public string m_LatinClementina1914Bible { get; private set; }
    public string m_LatinClementineBible { get; private set; }
    public string m_LatinNovaVulgataBible { get; private set; }
    public string m_LatinSistinaBible { get; private set; }
    public string m_Latvian1965Bible { get; private set; }
    public string m_Latvian2012Bible { get; private set; }
    public string m_Latvian2024Bible { get; private set; }
    public string m_LatvianBible { get; private set; }
    public string m_LatvianGluckBible { get; private set; }
    public string m_LatvianLG8Bible { get; private set; }
    public string m_LatvianLTV1965Bible { get; private set; }
    public string m_LatvianNLBDCBible { get; private set; }
    public string m_LiberianKreyolBible { get; private set; }
    public string m_Lingala2002Bible { get; private set; }
    public string m_Lingala2020Bible { get; private set; }
    public string m_Lithuanian2012Bible { get; private set; }
    public string m_Lithuanian2012EKUBible { get; private set; }
    public string m_Lithuanian2012KANBible { get; private set; }
    public string m_LithuanianBible { get; private set; }
    public string m_LithuanianKJBible { get; private set; }
    public string m_LithuanianLBDBible { get; private set; }
    public string m_LomweBible { get; private set; }
    public string m_Luganda2003Bible { get; private set; }
    public string m_LugandaBible { get; private set; }
    public string m_LugandaBIBU1Bible { get; private set; }
    public string m_LugandaEEEEBible { get; private set; }
    public string m_LugandaLBRBible { get; private set; }
    public string m_LugbaraBible { get; private set; }
    public string m_LuguruBible { get; private set; }
    public string m_Luo1985Bible { get; private set; }
    public string m_Luo2015Bible { get; private set; }
    public string m_Luo2020Bible { get; private set; }
    public string m_Maasai1970Bible { get; private set; }
    public string m_Maasai2020Bible { get; private set; }
    public string m_MaasaiBible { get; private set; }
    public string m_MaasaiMBSBible { get; private set; }
    public string m_Macedonian1990Bible { get; private set; }
    public string m_Macedonian2006Bible { get; private set; }
    public string m_Macedonian2006DBible { get; private set; }
    public string m_Macedonian2023Bible { get; private set; }
    public string m_MacedonianMKB1999Bible { get; private set; }
    public string m_MacedonianMNT1999Bible { get; private set; }
    public string m_MadureseBible { get; private set; }
    public string m_MaithiliBible { get; private set; }
    public string m_Makhuwa2021Bible { get; private set; }
    public string m_MakhuwaBible { get; private set; }
    public string m_MakhuwaVMKBible { get; private set; }
    public string m_MakondeBible { get; private set; }
    public string m_MakondeShiBible { get; private set; }
    public string m_Malagasy1865Bible { get; private set; }
    public string m_Malagasy2003Bible { get; private set; }
    public string m_Malagasy2004Bible { get; private set; }
    public string m_Malagasy2011Bible { get; private set; }
    public string m_MalagasyBible { get; private set; }
    public string m_MalagasyMRVBible { get; private set; }
    public string m_Malayalam1910Bible { get; private set; }
    public string m_Malayalam2013Bible { get; private set; }
    public string m_MalayalamBCSBible { get; private set; }
    public string m_MalayalamBible { get; private set; }
    public string m_MalayalamBSIBible { get; private set; }
    public string m_MalayalamCVBible { get; private set; }
    public string m_MalayalamMalovBible { get; private set; }
    public string m_MalayalamWBTCBible { get; private set; }
    public string m_Malaysian1996Bible { get; private set; }
    public string m_Malaysian2017Bible { get; private set; }
    public string m_Malaysian2020Bible { get; private set; }
    public string m_MalaysianBible { get; private set; }
    public string m_Maori2012Bible { get; private set; }
    public string m_MaoriBible { get; private set; }
    public string m_Marathi2015Bible { get; private set; }
    public string m_MarathiBible { get; private set; }
    public string m_MarathiBSIBible { get; private set; }
    public string m_MarathiIRVMARBible { get; private set; }
    public string m_MarathiMRCVBible { get; private set; }
    public string m_MarwariBible { get; private set; }
    public string m_MazanderaniGMBBible { get; private set; }
    public string m_MazanderaniBible { get; private set; }
    public string m_MazanderaniWMBBible { get; private set; }
    public string m_MeiteiBible { get; private set; }
    public string m_MendeBible { get; private set; }
    public string m_MewariBible { get; private set; }
    public string m_MizoBible { get; private set; }
    public string m_MizoCLBSIBible { get; private set; }
    public string m_MizoOVBSIBible { get; private set; }
    public string m_MobaBible { get; private set; }
    public string m_MoldovianCyrillicBible { get; private set; }
    public string m_MoldovianLatinBible { get; private set; }
    public string m_Mongolian2004Bible { get; private set; }
    public string m_Mongolian2013Bible { get; private set; }
    public string m_Morisyen2021Bible { get; private set; }
    public string m_MorisyenBible { get; private set; }
    public string m_Mossi2014Bible { get; private set; }
    public string m_MossiSBBible { get; private set; }
    public string m_MossiSSDCBible { get; private set; }
    public string m_Munda2020Bible { get; private set; }
    public string m_MundaBible { get; private set; }
    public string m_Nahuatl2012Bible { get; private set; }
    public string m_Nahuatl2017Bible { get; private set; }
    public string m_NahuatlBible { get; private set; }
    public string m_NahuatlGUBible { get; private set; }
    public string m_NahuatlNHEBible { get; private set; }
    public string m_Ndau2023Bible { get; private set; }
    public string m_NdauBible { get; private set; }
    public string m_Ndebele2002Bible { get; private set; }
    public string m_Ndebele2003Bible { get; private set; }
    public string m_Ndebele2012Bible { get; private set; }
    public string m_NdebeleBible { get; private set; }
    public string m_Nepali2008Bible { get; private set; }
    public string m_Nepali2012Bible { get; private set; }
    public string m_Nepali2021Bible { get; private set; }
    public string m_NepaliBible { get; private set; }
    public string m_NepaliTamangBible { get; private set; }
    public string m_NigerianPidginBible { get; private set; }
    public string m_Norwegian1921Bible { get; private set; }
    public string m_Norwegian1938Bible { get; private set; }
    public string m_Norwegian1978Bible { get; private set; }
    public string m_Norwegian2007Bible { get; private set; }
    public string m_Norwegian2011Bible { get; private set; }
    public string m_Norwegian2018Bible { get; private set; }
    public string m_NorwegianBGOBible { get; private set; }
    public string m_NorwegianBIBEL1978Bible { get; private set; }
    public string m_NorwegianBible { get; private set; }
    public string m_NorwegianELBBible { get; private set; }
    public string m_NorwegianN78BMBible { get; private set; }
    public string m_NorwegianN78NNBible { get; private set; }
    public string m_NorwegianNY2011Bible { get; private set; }
    public string m_NuerBible { get; private set; }
    public string m_Nyankole1964Bible { get; private set; }
    public string m_NyankoleBible { get; private set; }
    public string m_Odia2024Bible { get; private set; }
    public string m_OdiaBible { get; private set; }
    public string m_OdiaBSIBible { get; private set; }
    public string m_OdiaERVBible { get; private set; }
    public string m_OdiaIRV2017Bible { get; private set; }
    public string m_OdiaIRVBible { get; private set; }
    public string m_OdiaOROVBible { get; private set; }
    public string m_OriginalGreekBible { get; private set; }
    public string m_OriginalHebrewBible { get; private set; }
    public string m_OromoGUJBible { get; private set; }
    public string m_OromoGujiBible { get; private set; }
    public string m_OromoKakuuHaaraakaBible { get; private set; }
    public string m_OromoKitaabaWaaqaBible { get; private set; }
    public string m_OromoKitaabaWoyyuuBible { get; private set; }
    public string m_OromoWaadaaHaarawaBible { get; private set; }
    public string m_OromoWaadaaLammataaBible { get; private set; }
    public string m_PampangaBible { get; private set; }
    public string m_PapuaNewGuineaBible { get; private set; }
    public string m_PapuaNewGuineaTokPisinBible { get; private set; }
    public string m_Pashto2019Bible { get; private set; }
    public string m_Pashto2023Bible { get; private set; }
    public string m_PashtoBible { get; private set; }
    public string m_Persian2005Bible { get; private set; }
    public string m_Persian2014Bible { get; private set; }
    public string m_PersianBible { get; private set; }
    public string m_PersianDariBible { get; private set; }
    public string m_PersianTPVBible { get; private set; }
    public string m_Polish2016Bible { get; private set; }
    public string m_Polish2018Bible { get; private set; }
    public string m_PolishBible { get; private set; }
    public string m_PolishGdansk2017Bible { get; private set; }
    public string m_PolishGdanskBible { get; private set; }
    public string m_PolishNBGBible { get; private set; }
    public string m_PolishNPDBible { get; private set; }
    public string m_PolishSNPD4Bible { get; private set; }
    public string m_Portuguese1969Bible { get; private set; }
    public string m_PortugueseA21Bible { get; private set; }
    public string m_PortugueseAlmeida1628Bible { get; private set; }
    public string m_PortugueseAlmeida1753Bible { get; private set; }
    public string m_PortugueseARCBible { get; private set; }
    public string m_PortugueseBible { get; private set; }
    public string m_PortugueseBLTBible { get; private set; }
    public string m_PortugueseBPT09Bible { get; private set; }
    public string m_PortugueseCAPBible { get; private set; }
    public string m_PortugueseMZNVIBible { get; private set; }
    public string m_PortugueseNAABible { get; private set; }
    public string m_PortugueseNBV2007Bible { get; private set; }
    public string m_PortugueseNTLHBible { get; private set; }
    public string m_PortugueseNVI2023Bible { get; private set; }
    public string m_PortugueseNVIBible { get; private set; }
    public string m_PortugueseNVTBible { get; private set; }
    public string m_PortugueseOLBible { get; private set; }
    public string m_PortugueseTBBible { get; private set; }
    public string m_PortugueseVFLBible { get; private set; }
    public string m_PularBible { get; private set; }
    public string m_Punjabi2016Bible { get; private set; }
    public string m_Punjabi2020Bible { get; private set; }
    public string m_Punjabi2021Bible { get; private set; }
    public string m_Punjabi2022Bible { get; private set; }
    public string m_Punjabi2023Bible { get; private set; }
    public string m_PunjabiBible { get; private set; }
    public string m_PunjabiERVBible { get; private set; }
    public string m_PunjabiIRVBible { get; private set; }
    public string m_QeqchiBible { get; private set; }
    public string m_Quechuan2010Bible { get; private set; }
    public string m_QuechuanBible { get; private set; }
    public string m_QuechuanQVBMBible { get; private set; }
    public string m_QuechuanQVSBible { get; private set; }
    public string m_QuechuanQVWBible { get; private set; }
    public string m_QuechuanQXOBible { get; private set; }
    public string m_Romani2004Bible { get; private set; }
    public string m_Romani2007Bible { get; private set; }
    public string m_Romanian1928Bible { get; private set; }
    public string m_Romanian1931Bible { get; private set; }
    public string m_Romanian2009Bible { get; private set; }
    public string m_Romanian2014Bible { get; private set; }
    public string m_Romanian2015Bible { get; private set; }
    public string m_Romanian2018Bible { get; private set; }
    public string m_Romanian2020Bible { get; private set; }
    public string m_Romanian2021Bible { get; private set; }
    public string m_Romanian2022Bible { get; private set; }
    public string m_Romanian2023Bible { get; private set; }
    public string m_RomanianBDKBible { get; private set; }
    public string m_RomanianBible { get; private set; }
    public string m_RomanianSBIRBible { get; private set; }
    public string m_RomaniBACHROBible { get; private set; }
    public string m_RomaniBaltic2019Bible { get; private set; }
    public string m_RomaniBalticLT2019Bible { get; private set; }
    public string m_RomaniBible { get; private set; }
    public string m_RomaniCHERGASHBible { get; private set; }
    public string m_RomaniGSPBible { get; private set; }
    public string m_RomaniKALD2004Bible { get; private set; }
    public string m_RomaniKALD2020Bible { get; private set; }
    public string m_RomaniRMCBible { get; private set; }
    public string m_RomaniROM07Bible { get; private set; }
    public string m_RomaniROM6Bible { get; private set; }
    public string m_RomaniSERBible { get; private set; }
    public string m_RomaniSINT2024Bible { get; private set; }
    public string m_Russian2012Bible { get; private set; }
    public string m_RussianAGPBible { get; private set; }
    public string m_RussianBTI2015Bible { get; private set; }
    public string m_RussianCARSABible { get; private set; }
    public string m_RussianCARSBible { get; private set; }
    public string m_RussianCASBible { get; private set; }
    public string m_RussianCSLAVBible { get; private set; }
    public string m_RussianJewishBible { get; private set; }
    public string m_RussianJubileeBible { get; private set; }
    public string m_RussianMengeBible { get; private set; }
    public string m_RussianNRTBible { get; private set; }
    public string m_RussianReceptusBible { get; private set; }
    public string m_RussianRSPBible { get; private set; }
    public string m_RussianRSTBible { get; private set; }
    public string m_RussianSlovoBible { get; private set; }
    public string m_RussianSynodalBible { get; private set; }
    public string m_RussianWBTCBible { get; private set; }
    public string m_SadriBible { get; private set; }
    public string m_SanskritDevanagariBible { get; private set; }
    public string m_SantaliBangladeshBible { get; private set; }
    public string m_SantaliCommonBible { get; private set; }
    public string m_SasakBible { get; private set; }
    public string m_Sena2014Bible { get; private set; }
    public string m_SenaBible { get; private set; }
    public string m_SenaMalawiBible { get; private set; }
    public string m_SeraikiBible { get; private set; }
    public string m_SerbianBible { get; private set; }
    public string m_SerbianCNZBible { get; private set; }
    public string m_SerbianERVBible { get; private set; }
    public string m_SerbianLatinBible { get; private set; }
    public string m_SerbianNSTBible { get; private set; }
    public string m_SerbianNSTLBible { get; private set; }
    public string m_SerbianSDSBible { get; private set; }
    public string m_ShanBible { get; private set; }
    public string m_ShanNCLBible { get; private set; }
    public string m_ShekhawatiBible { get; private set; }
    public string m_ShillukBible { get; private set; }
    public string m_Shona1949Bible { get; private set; }
    public string m_Shona2002Bible { get; private set; }
    public string m_ShonaBDSCBible { get; private set; }
    public string m_ShonaBible { get; private set; }
    public string m_ShonaSCLBBible { get; private set; }
    public string m_ShonaSUBBible { get; private set; }
    public string m_SidamoBible { get; private set; }
    public string m_SindhiBible { get; private set; }
    public string m_SindhiCommonBible { get; private set; }
    public string m_SindhiHinduBible { get; private set; }
    public string m_SindhiMuslimBible { get; private set; }
    public string m_SinhalaNRSVBible { get; private set; }
    public string m_SinhalaSCVBible { get; private set; }
    public string m_SinhalaSNRVBible { get; private set; }
    public string m_SinhalaSROVBible { get; private set; }
    public string m_SiswatiBible { get; private set; }
    public string m_Slovakian2015Bible { get; private set; }
    public string m_Slovakian2017Bible { get; private set; }
    public string m_SlovakianBible { get; private set; }
    public string m_SlovakianNPK2023Bible { get; private set; }
    public string m_SlovakianNPKBible { get; private set; }
    public string m_SlovakianRomaniBible { get; private set; }
    public string m_SlovakianSEBBible { get; private set; }
    public string m_SlovakianSLBBible { get; private set; }
    public string m_SlovakianSSVBible { get; private set; }
    public string m_Slovenian1584Bible { get; private set; }
    public string m_Slovenian1882Bible { get; private set; }
    public string m_Slovenian1928Bible { get; private set; }
    public string m_Slovenian1990Bible { get; private set; }
    public string m_Slovenian2014Bible { get; private set; }
    public string m_SlovenianBible { get; private set; }
    public string m_SlovenianEKUBible { get; private set; }
    public string m_SlovenianSSPBible { get; private set; }
    public string m_SogaBible { get; private set; }
    public string m_Somalian2018Bible { get; private set; }
    public string m_Somalian2024Bible { get; private set; }
    public string m_SomalianBible { get; private set; }
    public string m_SongeBible { get; private set; }
    public string m_Sotho1951Bible { get; private set; }
    public string m_Sotho1989Bible { get; private set; }
    public string m_Sotho2000Bible { get; private set; }
    public string m_SothoBible { get; private set; }
    public string m_Spanish1569Bible { get; private set; }
    public string m_Spanish1858Bible { get; private set; }
    public string m_Spanish1989Bible { get; private set; }
    public string m_SpanishBDOBible { get; private set; }
    public string m_SpanishBHTIBible { get; private set; }
    public string m_SpanishBible { get; private set; }
    public string m_SpanishBLPBible { get; private set; }
    public string m_SpanishBLPHBible { get; private set; }
    public string m_SpanishBTIBible { get; private set; }
    public string m_SpanishBTXBible { get; private set; }
    public string m_SpanishDHHBible { get; private set; }
    public string m_SpanishJBSBible { get; private set; }
    public string m_SpanishLBLABible { get; private set; }
    public string m_SpanishNBLABible { get; private set; }
    public string m_SpanishNBVBible { get; private set; }
    public string m_SpanishNTBIZBible { get; private set; }
    public string m_SpanishNTVBible { get; private set; }
    public string m_SpanishNVIBible { get; private set; }
    public string m_SpanishNVISBible { get; private set; }
    public string m_SpanishPDTBible { get; private set; }
    public string m_SpanishRevisedRVR1960Bible { get; private set; }
    public string m_SpanishRV2020Bible { get; private set; }
    public string m_SpanishRVA2015Bible { get; private set; }
    public string m_SpanishRVCBible { get; private set; }
    public string m_SpanishRVESBible { get; private set; }
    public string m_SpanishRVGBible { get; private set; }
    public string m_SpanishRVR1960Bible { get; private set; }
    public string m_SpanishRVR1995Bible { get; private set; }
    public string m_SpanishTLABible { get; private set; }
    public string m_SpanishVBL2022Bible { get; private set; }
    public string m_SpanishVBLBible { get; private set; }
    public string m_Sukuma1960Bible { get; private set; }
    public string m_SukumaBible { get; private set; }
    public string m_SundaneseBible { get; private set; }
    public string m_Swahili1850Bible { get; private set; }
    public string m_Swahili2001Bible { get; private set; }
    public string m_Swahili2017Bible { get; private set; }
    public string m_Swahili2024Bible { get; private set; }
    public string m_SwahiliBHNTLKBible { get; private set; }
    public string m_SwahiliBible { get; private set; }
    public string m_SwahiliContemporaryBible { get; private set; }
    public string m_SwahiliNMMBible { get; private set; }
    public string m_SwahiliRSUVDCBible { get; private set; }
    public string m_SwahiliSCLDC10Bible { get; private set; }
    public string m_SwahiliSRB37Bible { get; private set; }
    public string m_SwahiliSUVBible { get; private set; }
    public string m_SwahiliSWC02Bible { get; private set; }
    public string m_SwahiliSWZZB1921Bible { get; private set; }
    public string m_Swedish1873Bible { get; private set; }
    public string m_Swedish2000Bible { get; private set; }
    public string m_Swedish2015Bible { get; private set; }
    public string m_Swedish2019Bible { get; private set; }
    public string m_SwedishBible { get; private set; }
    public string m_SwedishFolkBible { get; private set; }
    public string m_SwedishNLBBible { get; private set; }
    public string m_SwedishSB2016Bible { get; private set; }
    public string m_SwedishSFBBible { get; private set; }
    public string m_SylhetiBible { get; private set; }
    public string m_SylhetiSYLLBible { get; private set; }
    public string m_Tagalog2001Bible { get; private set; }
    public string m_Tagalog2005Bible { get; private set; }
    public string m_Tagalog2012Bible { get; private set; }
    public string m_Tagalog2015Bible { get; private set; }
    public string m_TagalogBible { get; private set; }
    public string m_TagalogRevised2005Bible { get; private set; }
    public string m_TagalogTLBABible { get; private set; }
    public string m_Tajik1992Bible { get; private set; }
    public string m_TajikKMOBible { get; private set; }
    public string m_TajikNTBible { get; private set; }
    public string m_TamasheqBible { get; private set; }
    public string m_Tamil2017Bible { get; private set; }
    public string m_TamilBible { get; private set; }
    public string m_TamilIRVBible { get; private set; }
    public string m_TamilRomanisedBible { get; private set; }
    public string m_TamilTCVBible { get; private set; }
    public string m_TamilTRVBible { get; private set; }
    public string m_TamilWBTCBible { get; private set; }
    public string m_TarifitBible { get; private set; }
    public string m_TashelhaytMoroccoBible { get; private set; }
    public string m_Tatar2001Bible { get; private set; }
    public string m_Tatar2015Bible { get; private set; }
    public string m_Tatar2025Bible { get; private set; }
    public string m_TatarRBBLBible { get; private set; }
    public string m_Telugu2016Bible { get; private set; }
    public string m_Telugu2019Bible { get; private set; }
    public string m_TeluguBible { get; private set; }
    public string m_TeluguTCVBible { get; private set; }
    public string m_TeluguWBTCBible { get; private set; }
    public string m_Teso2020Bible { get; private set; }
    public string m_TesoBible { get; private set; }
    public string m_ThadoBible { get; private set; }
    public string m_Thai1940Bible { get; private set; }
    public string m_Thai1971Bible { get; private set; }
    public string m_ThaiBible { get; private set; }
    public string m_ThaiERVBible { get; private set; }
    public string m_ThaiKJVBible { get; private set; }
    public string m_ThaiNTVBible { get; private set; }
    public string m_ThaiTCVBible { get; private set; }
    public string m_ThaiTHSBible { get; private set; }
    public string m_ThaiTNCVBible { get; private set; }
    public string m_TibetianBible { get; private set; }
    public string m_TibetianCBTBible { get; private set; }
    public string m_TivBible { get; private set; }
    public string m_Tshiluba1996Bible { get; private set; }
    public string m_Tshiluba2003Bible { get; private set; }
    public string m_TshivendaBible { get; private set; }
    public string m_Tsonga1989Bible { get; private set; }
    public string m_Tsonga2014Bible { get; private set; }
    public string m_Tsonga2024Bible { get; private set; }
    public string m_TsongaBible { get; private set; }
    public string m_Tswana1890Bible { get; private set; }
    public string m_Tswana1970Bible { get; private set; }
    public string m_Tswana1993Bible { get; private set; }
    public string m_Tswana2024Bible { get; private set; }
    public string m_TswanaBible { get; private set; }
    public string m_TuluBible { get; private set; }
    public string m_TurkanaBible { get; private set; }
    public string m_TurkishBible { get; private set; }
    public string m_TurkishHADIBible { get; private set; }
    public string m_TurkishKKDEUBible { get; private set; }
    public string m_TurkishKMEYABible { get; private set; }
    public string m_TurkishNTBBible { get; private set; }
    public string m_TurkishTKKBible { get; private set; }
    public string m_TurkishTTTBible { get; private set; }
    public string m_TurkishYTCBible { get; private set; }
    public string m_Turkmen2016Bible { get; private set; }
    public string m_TurkmenCyrillic2002Bible { get; private set; }
    public string m_TurkmenLatin2002Bible { get; private set; }
    public string m_TurkmenLatin2017Bible { get; private set; }
    public string m_TwiAkuapemBible { get; private set; }
    public string m_TwiAsanteBible { get; private set; }
    public string m_TwiDCBible { get; private set; }
    public string m_TwiKronkronBible { get; private set; }
    public string m_TwiRevisedBible { get; private set; }
    public string m_Ukrainian1903Bible { get; private set; }
    public string m_Ukrainian1905Bible { get; private set; }
    public string m_Ukrainian2004Bible { get; private set; }
    public string m_Ukrainian2006Bible { get; private set; }
    public string m_Ukrainian2011Bible { get; private set; }
    public string m_Ukrainian2021Bible { get; private set; }
    public string m_Ukrainian2022Bible { get; private set; }
    public string m_UkrainianBible { get; private set; }
    public string m_UkrainianHOMBible { get; private set; }
    public string m_UkrainianTUBBible { get; private set; }
    public string m_UkrainianUKDERBible { get; private set; }
    public string m_UkrainianUMTBible { get; private set; }
    public string m_UmbunduBible { get; private set; }
    public string m_Urdu2017Bible { get; private set; }
    public string m_UrduBible { get; private set; }
    public string m_UrduDGVBible { get; private set; }
    public string m_UrduGVRBible { get; private set; }
    public string m_UrduIRVURDBible { get; private set; }
    public string m_UrduUCVBible { get; private set; }
    public string m_UrduUCVDBible { get; private set; }
    public string m_UrduUGVBible { get; private set; }
    public string m_UrduURDBible { get; private set; }
    public string m_UrduURDGVHBible { get; private set; }
    public string m_UrduURDR55Bible { get; private set; }
    public string m_UyghurArabicBible { get; private set; }
    public string m_UyghurCyrillicBible { get; private set; }
    public string m_UyghurLatinBible { get; private set; }
    public string m_UzbekUZBBible { get; private set; }
    public string m_UzbekUZCBible { get; private set; }
    public string m_UzbekUZLBCBible { get; private set; }
    public string m_Vietnamese1994Bible { get; private set; }
    public string m_Vietnamese2011Bible { get; private set; }
    public string m_Vietnamese2015Bible { get; private set; }
    public string m_VietnameseBible { get; private set; }
    public string m_VietnameseERVBible { get; private set; }
    public string m_VietnameseNVBBible { get; private set; }
    public string m_VietnameseVIEBible { get; private set; }
    public string m_WarayBible { get; private set; }
    public string m_Welsh1894Bible { get; private set; }
    public string m_Welsh1945Bible { get; private set; }
    public string m_Welsh2015Bible { get; private set; }
    public string m_WelshBible { get; private set; }
    public string m_WelshBMWBible { get; private set; }
    public string m_WelshCTEBible { get; private set; }
    public string m_WelshSBYBible { get; private set; }
    public string m_WolayttaBible { get; private set; }
    public string m_WolofBible { get; private set; }
    public string m_WolofKYGBible { get; private set; }
    public string m_Xhosa1920Bible { get; private set; }
    public string m_Xhosa1996Bible { get; private set; }
    public string m_Xhosa2022Bible { get; private set; }
    public string m_XhosaBible { get; private set; }
    public string m_Yoruba2010Bible { get; private set; }
    public string m_Yoruba2014Bible { get; private set; }
    public string m_YorubaBible { get; private set; }
    public string m_ZandeBible { get; private set; }
    public string m_ZarmaBible { get; private set; }
    public string m_Zulu2020Bible { get; private set; }
    public string m_Zulu2023Bible { get; private set; }
    public string m_ZuluBible { get; private set; }

    public void SetID(int ID) { m_ID = ID; }
    public void SetEnglish(string English) { m_English = English; }
    public void SetKorean(string Korean) { m_Korean = Korean; }
    public void SetCount(int Count) { m_Count = Count; }
    public void SetEnglishTarget(string EnglishTarget) { m_EnglishTarget = EnglishTarget; }
    public void SetNIV(string NIV) { m_NIV = NIV; }
    public void SetKoreanTarget(string KoreanTarget) { m_KoreanTarget = KoreanTarget; }
    public void SetSource(string Source) { m_Source = Source; }
    public void SetEasyBible(string EasyBible) { m_EasyBible = EasyBible; }
    public void SetRevisedHangul(string RevisedHangul) { m_RevisedHangul = RevisedHangul; }
    public void SetRevisedRevision(string RevisedRevision) { m_RevisedRevision = RevisedRevision; }
    public void SetJointTranslation(string JointTranslation) { m_JointTranslation = JointTranslation; }
    public void SetNewStandardTranslation(string NewStandardTranslation) { m_NewStandardTranslation = NewStandardTranslation; }
    public void SetKoreanBible(string KoreanBible) { m_KoreanBible = KoreanBible; }
    public void SetSourceEnglish(string SourceEnglish) { m_SourceEnglish = SourceEnglish; }
    public void SetKJV(string KJV) { m_KJV = KJV; }
    public void SetNewKJV(string NewKJV) { m_NewKJV = NewKJV; }
    public void SetESV(string ESV) { m_ESV = ESV; }
    public void SetNewRSV(string NewRSV) { m_NewRSV = NewRSV; }
    public void SetNASB(string NASB) { m_NASB = NASB; }
    public void Setafri(string afri) { m_afri = afri; }
    public void Setalbanian(string albanian) { m_albanian = albanian; }
    public void Setchinese_union_simp(string chinese_union_simp) { m_chinese_union_simp = chinese_union_simp; }
    public void Setchinese_union_trad(string chinese_union_trad) { m_chinese_union_trad = chinese_union_trad; }
    public void Setckjv_sds(string ckjv_sds) { m_ckjv_sds = ckjv_sds; }
    public void Setckjv_sdt(string ckjv_sdt) { m_ckjv_sdt = ckjv_sdt; }
    public void Setbkr(string bkr) { m_bkr = bkr; }
    public void Setstve(string stve) { m_stve = stve; }
    public void Setfinn(string finn) { m_finn = finn; }
    public void Setepee(string epee) { m_epee = epee; }
    public void Setmartin(string martin) { m_martin = martin; }
    public void Setoster(string oster) { m_oster = oster; }
    public void Setsegond_1910(string segond_1910) { m_segond_1910 = segond_1910; }
    public void Setelberfelder_1871(string elberfelder_1871) { m_elberfelder_1871 = elberfelder_1871; }
    public void Setelberfelder_1905(string elberfelder_1905) { m_elberfelder_1905 = elberfelder_1905; }
    public void Setluther(string luther) { m_luther = luther; }
    public void Setluther_1912(string luther_1912) { m_luther_1912 = luther_1912; }
    public void Setschlachter(string schlachter) { m_schlachter = schlachter; }
    public void Setwlc(string wlc) { m_wlc = wlc; }
    public void Setirv(string irv) { m_irv = irv; }
    public void Setkaroli(string karoli) { m_karoli = karoli; }
    public void Setindo_tb(string indo_tb) { m_indo_tb = indo_tb; }
    public void Setindo_tm(string indo_tm) { m_indo_tm = indo_tm; }
    public void Setdiodati(string diodati) { m_diodati = diodati; }
    public void Setbungo(string bungo) { m_bungo = bungo; }
    public void Setkougo(string kougo) { m_kougo = kougo; }
    public void Setmaori(string maori) { m_maori = maori; }
    public void Setopt(string opt) { m_opt = opt; }
    public void Setpol_nbg(string pol_nbg) { m_pol_nbg = pol_nbg; }
    public void Setpol_ubg(string pol_ubg) { m_pol_ubg = pol_ubg; }
    public void Setpolbg(string polbg) { m_polbg = polbg; }
    public void Setalmeida_ra(string almeida_ra) { m_almeida_ra = almeida_ra; }
    public void Setalmeida_rc(string almeida_rc) { m_almeida_rc = almeida_rc; }
    public void Setblivre(string blivre) { m_blivre = blivre; }
    public void Setfidela(string fidela) { m_fidela = fidela; }
    public void Setsynodal(string synodal) { m_synodal = synodal; }
    public void Setrv_1909(string rv_1909) { m_rv_1909 = rv_1909; }
    public void Setrvg(string rvg) { m_rvg = rvg; }
    public void Setrvg_2004(string rvg_2004) { m_rvg_2004 = rvg_2004; }
    public void Setsagradas(string sagradas) { m_sagradas = sagradas; }
    public void Settagab(string tagab) { m_tagab = tagab; }
    public void Setthaikjv(string thaikjv) { m_thaikjv = thaikjv; }
    public void Setturkish(string turkish) { m_turkish = turkish; }
    public void Setcadman(string cadman) { m_cadman = cadman; }
    public void SetPortuguese(string Portuguese) { m_Portuguese = Portuguese; }
    public void SetGerman(string German) { m_German = German; }
    public void SetJapanese(string Japanese) { m_Japanese = Japanese; }
    public void SetChinese(string Chinese) { m_Chinese = Chinese; }
    public void SetRomanian(string Romanian) { m_Romanian = Romanian; }
    public void SetFrench(string French) { m_French = French; }
    public void SetSpanish(string Spanish) { m_Spanish = Spanish; }
    public void SetItalian(string Italian) { m_Italian = Italian; }
    public void SetHungarian(string Hungarian) { m_Hungarian = Hungarian; }
    public void SetRussian(string Russian) { m_Russian = Russian; }
    public void SetHindi(string Hindi) { m_Hindi = Hindi; }
    public void SetAcehBible(string AcehBible) { m_AcehBible = AcehBible; }
    public void SetAdilabadGondiBible(string AdilabadGondiBible) { m_AdilabadGondiBible = AdilabadGondiBible; }
    public void SetAfrikaans1983Bible(string Afrikaans1983Bible) { m_Afrikaans1983Bible = Afrikaans1983Bible; }
    public void SetAfrikaans2020Bible(string Afrikaans2020Bible) { m_Afrikaans2020Bible = Afrikaans2020Bible; }
    public void SetAfrikaans2023Bible(string Afrikaans2023Bible) { m_Afrikaans2023Bible = Afrikaans2023Bible; }
    public void SetAfrikaansABABible(string AfrikaansABABible) { m_AfrikaansABABible = AfrikaansABABible; }
    public void SetAfrikaansBible(string AfrikaansBible) { m_AfrikaansBible = AfrikaansBible; }
    public void SetAfrikaansDBBible(string AfrikaansDBBible) { m_AfrikaansDBBible = AfrikaansDBBible; }
    public void SetAfrikaansNLVBible(string AfrikaansNLVBible) { m_AfrikaansNLVBible = AfrikaansNLVBible; }
    public void SetAhiraniBible(string AhiraniBible) { m_AhiraniBible = AhiraniBible; }
    public void SetAlbanian1872Bible(string Albanian1872Bible) { m_Albanian1872Bible = Albanian1872Bible; }
    public void SetAlbanian1879Bible(string Albanian1879Bible) { m_Albanian1879Bible = Albanian1879Bible; }
    public void SetAlbanian2018Bible(string Albanian2018Bible) { m_Albanian2018Bible = Albanian2018Bible; }
    public void SetAlbanianBible(string AlbanianBible) { m_AlbanianBible = AlbanianBible; }
    public void SetAmharic2000Bible(string Amharic2000Bible) { m_Amharic2000Bible = Amharic2000Bible; }
    public void SetAmharicBible(string AmharicBible) { m_AmharicBible = AmharicBible; }
    public void SetAmharicCatholicBible(string AmharicCatholicBible) { m_AmharicCatholicBible = AmharicCatholicBible; }
    public void SetAmharicDawroBible(string AmharicDawroBible) { m_AmharicDawroBible = AmharicDawroBible; }
    public void SetAmharicDawroDFBEBible(string AmharicDawroDFBEBible) { m_AmharicDawroDFBEBible = AmharicDawroDFBEBible; }
    public void SetAmharicDawroDFBLVLBible(string AmharicDawroDFBLVLBible) { m_AmharicDawroDFBLVLBible = AmharicDawroDFBLVLBible; }
    public void SetAmharicDawroDWRNTBible(string AmharicDawroDWRNTBible) { m_AmharicDawroDWRNTBible = AmharicDawroDWRNTBible; }
    public void SetAmharicDawroWWIBible(string AmharicDawroWWIBible) { m_AmharicDawroWWIBible = AmharicDawroWWIBible; }
    public void SetAmharicGamo2017Bible(string AmharicGamo2017Bible) { m_AmharicGamo2017Bible = AmharicGamo2017Bible; }
    public void SetAmharicGamoBible(string AmharicGamoBible) { m_AmharicGamoBible = AmharicGamoBible; }
    public void SetAmharicGamoGMBible(string AmharicGamoGMBible) { m_AmharicGamoGMBible = AmharicGamoGMBible; }
    public void SetAmharicGamoWordBible(string AmharicGamoWordBible) { m_AmharicGamoWordBible = AmharicGamoWordBible; }
    public void SetAmharicGofaBible(string AmharicGofaBible) { m_AmharicGofaBible = AmharicGofaBible; }
    public void SetAmharicGofaGFBEVFBible(string AmharicGofaGFBEVFBible) { m_AmharicGofaGFBEVFBible = AmharicGofaGFBEVFBible; }
    public void SetAmharicGofaGFBLVFBible(string AmharicGofaGFBLVFBible) { m_AmharicGofaGFBLVFBible = AmharicGofaGFBLVFBible; }
    public void SetAmharicGofaRNTBible(string AmharicGofaRNTBible) { m_AmharicGofaRNTBible = AmharicGofaRNTBible; }
    public void SetAmharicGofaWWIBible(string AmharicGofaWWIBible) { m_AmharicGofaWWIBible = AmharicGofaWWIBible; }
    public void SetAmharicNASVBible(string AmharicNASVBible) { m_AmharicNASVBible = AmharicNASVBible; }
    public void SetAmharicNSTBible(string AmharicNSTBible) { m_AmharicNSTBible = AmharicNSTBible; }
    public void SetAmharicTigrinya15Bible(string AmharicTigrinya15Bible) { m_AmharicTigrinya15Bible = AmharicTigrinya15Bible; }
    public void SetAmharicTigrinya2024Bible(string AmharicTigrinya2024Bible) { m_AmharicTigrinya2024Bible = AmharicTigrinya2024Bible; }
    public void SetAmharicTigrinyaBible(string AmharicTigrinyaBible) { m_AmharicTigrinyaBible = AmharicTigrinyaBible; }
    public void SetArabic1978Bible(string Arabic1978Bible) { m_Arabic1978Bible = Arabic1978Bible; }
    public void SetArabic2016Bible(string Arabic2016Bible) { m_Arabic2016Bible = Arabic2016Bible; }
    public void SetArabic2018Bible(string Arabic2018Bible) { m_Arabic2018Bible = Arabic2018Bible; }
    public void SetArabic2023Bible(string Arabic2023Bible) { m_Arabic2023Bible = Arabic2023Bible; }
    public void SetArabicAlgeriaBible(string ArabicAlgeriaBible) { m_ArabicAlgeriaBible = ArabicAlgeriaBible; }
    public void SetArabicAPDBible(string ArabicAPDBible) { m_ArabicAPDBible = ArabicAPDBible; }
    public void SetArabicAVDBible(string ArabicAVDBible) { m_ArabicAVDBible = ArabicAVDBible; }
    public void SetArabicAVDDVBible(string ArabicAVDDVBible) { m_ArabicAVDDVBible = ArabicAVDDVBible; }
    public void SetArabicBible(string ArabicBible) { m_ArabicBible = ArabicBible; }
    public void SetArabicERVBible(string ArabicERVBible) { m_ArabicERVBible = ArabicERVBible; }
    public void SetArabicGNABible(string ArabicGNABible) { m_ArabicGNABible = ArabicGNABible; }
    public void SetArabicGOVBible(string ArabicGOVBible) { m_ArabicGOVBible = ArabicGOVBible; }
    public void SetArabicLABible(string ArabicLABible) { m_ArabicLABible = ArabicLABible; }
    public void SetArabicLebaneseBible(string ArabicLebaneseBible) { m_ArabicLebaneseBible = ArabicLebaneseBible; }
    public void SetArabicMorocco2023Bible(string ArabicMorocco2023Bible) { m_ArabicMorocco2023Bible = ArabicMorocco2023Bible; }
    public void SetArabicMoroccoBible(string ArabicMoroccoBible) { m_ArabicMoroccoBible = ArabicMoroccoBible; }
    public void SetArabicSABBible(string ArabicSABBible) { m_ArabicSABBible = ArabicSABBible; }
    public void SetArabicSABible(string ArabicSABible) { m_ArabicSABible = ArabicSABible; }
    public void SetArabicSVDBible(string ArabicSVDBible) { m_ArabicSVDBible = ArabicSVDBible; }
    public void SetArabicTMABible(string ArabicTMABible) { m_ArabicTMABible = ArabicTMABible; }
    public void SetArabicTU2022Bible(string ArabicTU2022Bible) { m_ArabicTU2022Bible = ArabicTU2022Bible; }
    public void SetArabicTunisianBible(string ArabicTunisianBible) { m_ArabicTunisianBible = ArabicTunisianBible; }
    public void SetAramaicBible(string AramaicBible) { m_AramaicBible = AramaicBible; }
    public void SetArmenian1853Bible(string Armenian1853Bible) { m_Armenian1853Bible = Armenian1853Bible; }
    public void SetArmenian2017Bible(string Armenian2017Bible) { m_Armenian2017Bible = Armenian2017Bible; }
    public void SetArmenian2018Bible(string Armenian2018Bible) { m_Armenian2018Bible = Armenian2018Bible; }
    public void SetArmenian2019Bible(string Armenian2019Bible) { m_Armenian2019Bible = Armenian2019Bible; }
    public void SetArmenianAraratBible(string ArmenianAraratBible) { m_ArmenianAraratBible = ArmenianAraratBible; }
    public void SetArmenianBible(string ArmenianBible) { m_ArmenianBible = ArmenianBible; }
    public void SetArmenianEasternBible(string ArmenianEasternBible) { m_ArmenianEasternBible = ArmenianEasternBible; }
    public void SetArmenianNEABible(string ArmenianNEABible) { m_ArmenianNEABible = ArmenianNEABible; }
    public void SetAssameseBible(string AssameseBible) { m_AssameseBible = AssameseBible; }
    public void SetAvarBible(string AvarBible) { m_AvarBible = AvarBible; }
    public void SetAwadhiBible(string AwadhiBible) { m_AwadhiBible = AwadhiBible; }
    public void SetAymara1986Bible(string Aymara1986Bible) { m_Aymara1986Bible = Aymara1986Bible; }
    public void SetAymara1997Bible(string Aymara1997Bible) { m_Aymara1997Bible = Aymara1997Bible; }
    public void SetAymaraBible(string AymaraBible) { m_AymaraBible = AymaraBible; }
    public void SetAzerbaijan2013Bible(string Azerbaijan2013Bible) { m_Azerbaijan2013Bible = Azerbaijan2013Bible; }
    public void SetAzerbaijanBible(string AzerbaijanBible) { m_AzerbaijanBible = AzerbaijanBible; }
    public void SetAzerbaijanSouthBible(string AzerbaijanSouthBible) { m_AzerbaijanSouthBible = AzerbaijanSouthBible; }
    public void SetBagriBible(string BagriBible) { m_BagriBible = BagriBible; }
    public void SetBalineseBible(string BalineseBible) { m_BalineseBible = BalineseBible; }
    public void SetBalochiArabicBible(string BalochiArabicBible) { m_BalochiArabicBible = BalochiArabicBible; }
    public void SetBalochiBible(string BalochiBible) { m_BalochiBible = BalochiBible; }
    public void SetBalochiSoutherenBible(string BalochiSoutherenBible) { m_BalochiSoutherenBible = BalochiSoutherenBible; }
    public void SetBalochiSoutherenLatinBible(string BalochiSoutherenLatinBible) { m_BalochiSoutherenLatinBible = BalochiSoutherenLatinBible; }
    public void SetBaoule1974Bible(string Baoule1974Bible) { m_Baoule1974Bible = Baoule1974Bible; }
    public void SetBaoule1998Bible(string Baoule1998Bible) { m_Baoule1998Bible = Baoule1998Bible; }
    public void SetBaouleBible(string BaouleBible) { m_BaouleBible = BaouleBible; }
    public void SetBashkir2023Bible(string Bashkir2023Bible) { m_Bashkir2023Bible = Bashkir2023Bible; }
    public void SetBashkirBible(string BashkirBible) { m_BashkirBible = BashkirBible; }
    public void SetBasqueBible(string BasqueBible) { m_BasqueBible = BasqueBible; }
    public void SetBasque2008Bible(string Basque2008Bible) { m_Basque2008Bible = Basque2008Bible; }
    public void SetBavarianBible(string BavarianBible) { m_BavarianBible = BavarianBible; }
    public void SetBelarusian2017Bible(string Belarusian2017Bible) { m_Belarusian2017Bible = Belarusian2017Bible; }
    public void SetBelarusianBible(string BelarusianBible) { m_BelarusianBible = BelarusianBible; }
    public void SetBelarusianBokunBible(string BelarusianBokunBible) { m_BelarusianBokunBible = BelarusianBokunBible; }
    public void SetBelarusianCHNTBible(string BelarusianCHNTBible) { m_BelarusianCHNTBible = BelarusianCHNTBible; }
    public void SetBelarusianNTJSBible(string BelarusianNTJSBible) { m_BelarusianNTJSBible = BelarusianNTJSBible; }
    public void SetBembaBible(string BembaBible) { m_BembaBible = BembaBible; }
    public void SetBengali2017Bible(string Bengali2017Bible) { m_Bengali2017Bible = Bengali2017Bible; }
    public void SetBengali2023Bible(string Bengali2023Bible) { m_Bengali2023Bible = Bengali2023Bible; }
    public void SetBengaliBACIBBible(string BengaliBACIBBible) { m_BengaliBACIBBible = BengaliBACIBBible; }
    public void SetBengaliBCVBible(string BengaliBCVBible) { m_BengaliBCVBible = BengaliBCVBible; }
    public void SetBengaliBible(string BengaliBible) { m_BengaliBible = BengaliBible; }
    public void SetBengaliBSIBible(string BengaliBSIBible) { m_BengaliBSIBible = BengaliBSIBible; }
    public void SetBengaliCLBSIBible(string BengaliCLBSIBible) { m_BengaliCLBSIBible = BengaliCLBSIBible; }
    public void SetBengaliERVBible(string BengaliERVBible) { m_BengaliERVBible = BengaliERVBible; }
    public void SetBengaliIRVBENBible(string BengaliIRVBENBible) { m_BengaliIRVBENBible = BengaliIRVBENBible; }
    public void SetBengaliMBCLBible(string BengaliMBCLBible) { m_BengaliMBCLBible = BengaliMBCLBible; }
    public void SetBengaliSBCLBible(string BengaliSBCLBible) { m_BengaliSBCLBible = BengaliSBCLBible; }
    public void SetBerberBible(string BerberBible) { m_BerberBible = BerberBible; }
    public void SetBhilaliBible(string BhilaliBible) { m_BhilaliBible = BhilaliBible; }
    public void SetBodoBible(string BodoBible) { m_BodoBible = BodoBible; }
    public void SetBodoNTBPL20Bible(string BodoNTBPL20Bible) { m_BodoNTBPL20Bible = BodoNTBPL20Bible; }
    public void SetBosnianBible(string BosnianBible) { m_BosnianBible = BosnianBible; }
    public void SetBrajBible(string BrajBible) { m_BrajBible = BrajBible; }
    public void SetBugisBible(string BugisBible) { m_BugisBible = BugisBible; }
    public void SetBulgarian2015Bible(string Bulgarian2015Bible) { m_Bulgarian2015Bible = Bulgarian2015Bible; }
    public void SetBulgarianBible(string BulgarianBible) { m_BulgarianBible = BulgarianBible; }
    public void SetBulgarianBOBBible(string BulgarianBOBBible) { m_BulgarianBOBBible = BulgarianBOBBible; }
    public void SetBulgarianBPBBible(string BulgarianBPBBible) { m_BulgarianBPBBible = BulgarianBPBBible; }
    public void SetBulgarianCBTBible(string BulgarianCBTBible) { m_BulgarianCBTBible = BulgarianCBTBible; }
    public void SetBulgarianSPBBible(string BulgarianSPBBible) { m_BulgarianSPBBible = BulgarianSPBBible; }
    public void SetBulgarianTZABible(string BulgarianTZABible) { m_BulgarianTZABible = BulgarianTZABible; }
    public void SetBulgarianVerensBible(string BulgarianVerensBible) { m_BulgarianVerensBible = BulgarianVerensBible; }
    public void SetBundeliBible(string BundeliBible) { m_BundeliBible = BundeliBible; }
    public void SetBurmese1928Bible(string Burmese1928Bible) { m_Burmese1928Bible = Burmese1928Bible; }
    public void SetBurmese2021Bible(string Burmese2021Bible) { m_Burmese2021Bible = Burmese2021Bible; }
    public void SetBurmeseBCLBible(string BurmeseBCLBible) { m_BurmeseBCLBible = BurmeseBCLBible; }
    public void SetBurmeseBible(string BurmeseBible) { m_BurmeseBible = BurmeseBible; }
    public void SetBurmeseJBZVBible(string BurmeseJBZVBible) { m_BurmeseJBZVBible = BurmeseJBZVBible; }
    public void SetBurmeseMCLZVBible(string BurmeseMCLZVBible) { m_BurmeseMCLZVBible = BurmeseMCLZVBible; }
    public void SetBurmeseMSBUBible(string BurmeseMSBUBible) { m_BurmeseMSBUBible = BurmeseMSBUBible; }
    public void SetBurmeseMSBZBible(string BurmeseMSBZBible) { m_BurmeseMSBZBible = BurmeseMSBZBible; }
    public void SetCatalanBCIBible(string CatalanBCIBible) { m_CatalanBCIBible = CatalanBCIBible; }
    public void SetCatalanBECBible(string CatalanBECBible) { m_CatalanBECBible = CatalanBECBible; }
    public void SetCebuano1999Bible(string Cebuano1999Bible) { m_Cebuano1999Bible = Cebuano1999Bible; }
    public void SetCebuano2011Bible(string Cebuano2011Bible) { m_Cebuano2011Bible = Cebuano2011Bible; }
    public void SetCebuanoAPSDBible(string CebuanoAPSDBible) { m_CebuanoAPSDBible = CebuanoAPSDBible; }
    public void SetCebuanoBible(string CebuanoBible) { m_CebuanoBible = CebuanoBible; }
    public void SetCebuanoRCPVBible(string CebuanoRCPVBible) { m_CebuanoRCPVBible = CebuanoRCPVBible; }
    public void SetChechenBible(string ChechenBible) { m_ChechenBible = ChechenBible; }
    public void SetChewa1992Bible(string Chewa1992Bible) { m_Chewa1992Bible = Chewa1992Bible; }
    public void SetChewa2014Bible(string Chewa2014Bible) { m_Chewa2014Bible = Chewa2014Bible; }
    public void SetChewa2016Bible(string Chewa2016Bible) { m_Chewa2016Bible = Chewa2016Bible; }
    public void SetChewaBLYDCBible(string ChewaBLYDCBible) { m_ChewaBLYDCBible = ChewaBLYDCBible; }
    public void SetChhattisgarhiBible(string ChhattisgarhiBible) { m_ChhattisgarhiBible = ChhattisgarhiBible; }
    public void SetChibembaBible(string ChibembaBible) { m_ChibembaBible = ChibembaBible; }
    public void SetChin2010Bible(string Chin2010Bible) { m_Chin2010Bible = Chin2010Bible; }
    public void SetChinBSIBible(string ChinBSIBible) { m_ChinBSIBible = ChinBSIBible; }
    public void SetChinCSHBible(string ChinCSHBible) { m_ChinCSHBible = ChinCSHBible; }
    public void SetChinDNTBible(string ChinDNTBible) { m_ChinDNTBible = ChinDNTBible; }
    public void SetChinese1886Bible(string Chinese1886Bible) { m_Chinese1886Bible = Chinese1886Bible; }
    public void SetChinese1919Bible(string Chinese1919Bible) { m_Chinese1919Bible = Chinese1919Bible; }
    public void SetChinese1927Bible(string Chinese1927Bible) { m_Chinese1927Bible = Chinese1927Bible; }
    public void SetChinese1933Bible(string Chinese1933Bible) { m_Chinese1933Bible = Chinese1933Bible; }
    public void SetChinese1941Bible(string Chinese1941Bible) { m_Chinese1941Bible = Chinese1941Bible; }
    public void SetChinese1967Bible(string Chinese1967Bible) { m_Chinese1967Bible = Chinese1967Bible; }
    public void SetChineseCCBSBible(string ChineseCCBSBible) { m_ChineseCCBSBible = ChineseCCBSBible; }
    public void SetChineseCCBTBible(string ChineseCCBTBible) { m_ChineseCCBTBible = ChineseCCBTBible; }
    public void SetChineseCSBSBible(string ChineseCSBSBible) { m_ChineseCSBSBible = ChineseCSBSBible; }
    public void SetChineseCSBTBible(string ChineseCSBTBible) { m_ChineseCSBTBible = ChineseCSBTBible; }
    public void SetChineseCUNPSSBible(string ChineseCUNPSSBible) { m_ChineseCUNPSSBible = ChineseCUNPSSBible; }
    public void SetChineseCUNPSTBible(string ChineseCUNPSTBible) { m_ChineseCUNPSTBible = ChineseCUNPSTBible; }
    public void SetChineseNankingBible(string ChineseNankingBible) { m_ChineseNankingBible = ChineseNankingBible; }
    public void SetChinesePekingBible(string ChinesePekingBible) { m_ChinesePekingBible = ChinesePekingBible; }
    public void SetChineseRCUVSSBible(string ChineseRCUVSSBible) { m_ChineseRCUVSSBible = ChineseRCUVSSBible; }
    public void SetChineseRCUVTBible(string ChineseRCUVTBible) { m_ChineseRCUVTBible = ChineseRCUVTBible; }
    public void SetChineseSimplifiedBible(string ChineseSimplifiedBible) { m_ChineseSimplifiedBible = ChineseSimplifiedBible; }
    public void SetChineseSimplifiedNewBible(string ChineseSimplifiedNewBible) { m_ChineseSimplifiedNewBible = ChineseSimplifiedNewBible; }
    public void SetChineseTCV2019TBible(string ChineseTCV2019TBible) { m_ChineseTCV2019TBible = ChineseTCV2019TBible; }
    public void SetChineseTHV2012Bible(string ChineseTHV2012Bible) { m_ChineseTHV2012Bible = ChineseTHV2012Bible; }
    public void SetChineseTraditionalBible(string ChineseTraditionalBible) { m_ChineseTraditionalBible = ChineseTraditionalBible; }
    public void SetChineseTraditionalERVBible(string ChineseTraditionalERVBible) { m_ChineseTraditionalERVBible = ChineseTraditionalERVBible; }
    public void SetChineseTraditionalNewBible(string ChineseTraditionalNewBible) { m_ChineseTraditionalNewBible = ChineseTraditionalNewBible; }
    public void SetChineseTTVHBible(string ChineseTTVHBible) { m_ChineseTTVHBible = ChineseTTVHBible; }
    public void SetChineseTTVRBible(string ChineseTTVRBible) { m_ChineseTTVRBible = ChineseTTVRBible; }
    public void SetChineseUnion2010Bible(string ChineseUnion2010Bible) { m_ChineseUnion2010Bible = ChineseUnion2010Bible; }
    public void SetChineseWenli1823Bible(string ChineseWenli1823Bible) { m_ChineseWenli1823Bible = ChineseWenli1823Bible; }
    public void SetChineseWenli1885Bible(string ChineseWenli1885Bible) { m_ChineseWenli1885Bible = ChineseWenli1885Bible; }
    public void SetChineseWenli1897Bible(string ChineseWenli1897Bible) { m_ChineseWenli1897Bible = ChineseWenli1897Bible; }
    public void SetChineseWenliBible(string ChineseWenliBible) { m_ChineseWenliBible = ChineseWenliBible; }
    public void SetChineseWenliEasyBible(string ChineseWenliEasyBible) { m_ChineseWenliEasyBible = ChineseWenliEasyBible; }
    public void SetChinKNTPBible(string ChinKNTPBible) { m_ChinKNTPBible = ChinKNTPBible; }
    public void SetChinMatupi2006Bible(string ChinMatupi2006Bible) { m_ChinMatupi2006Bible = ChinMatupi2006Bible; }
    public void SetChinMatupiBible(string ChinMatupiBible) { m_ChinMatupiBible = ChinMatupiBible; }
    public void SetChinSCB2Bible(string ChinSCB2Bible) { m_ChinSCB2Bible = ChinSCB2Bible; }
    public void SetChinTB77Bible(string ChinTB77Bible) { m_ChinTB77Bible = ChinTB77Bible; }
    public void SetChinTBR17Bible(string ChinTBR17Bible) { m_ChinTBR17Bible = ChinTBR17Bible; }
    public void SetChinTDBBible(string ChinTDBBible) { m_ChinTDBBible = ChinTDBBible; }
    public void SetChinTedim2011Bible(string ChinTedim2011Bible) { m_ChinTedim2011Bible = ChinTedim2011Bible; }
    public void SetChinTedimBible(string ChinTedimBible) { m_ChinTedimBible = ChinTedimBible; }
    public void SetChuvashBible(string ChuvashBible) { m_ChuvashBible = ChuvashBible; }
    public void SetChuvashRSOBible(string ChuvashRSOBible) { m_ChuvashRSOBible = ChuvashRSOBible; }
    public void SetCopticBible(string CopticBible) { m_CopticBible = CopticBible; }
    public void SetCopticCNTVBible(string CopticCNTVBible) { m_CopticCNTVBible = CopticCNTVBible; }
    public void SetCopticSahidicBible(string CopticSahidicBible) { m_CopticSahidicBible = CopticSahidicBible; }
    public void SetCroatianBible(string CroatianBible) { m_CroatianBible = CroatianBible; }
    public void SetCroatianBKJBible(string CroatianBKJBible) { m_CroatianBKJBible = CroatianBKJBible; }
    public void SetCroatianCNTBible(string CroatianCNTBible) { m_CroatianCNTBible = CroatianCNTBible; }
    public void SetCroatianGKSBible(string CroatianGKSBible) { m_CroatianGKSBible = CroatianGKSBible; }
    public void SetCroatianSHPBible(string CroatianSHPBible) { m_CroatianSHPBible = CroatianSHPBible; }
    public void SetCzech1922Bible(string Czech1922Bible) { m_Czech1922Bible = Czech1922Bible; }
    public void SetCzech1947Bible(string Czech1947Bible) { m_Czech1947Bible = Czech1947Bible; }
    public void SetCzech1951Bible(string Czech1951Bible) { m_Czech1951Bible = Czech1951Bible; }
    public void SetCzechBible(string CzechBible) { m_CzechBible = CzechBible; }
    public void SetCzechEkumenickyBible(string CzechEkumenickyBible) { m_CzechEkumenickyBible = CzechEkumenickyBible; }
    public void SetCzechKralichka1613Bible(string CzechKralichka1613Bible) { m_CzechKralichka1613Bible = CzechKralichka1613Bible; }
    public void SetCzechKralichka1998Bible(string CzechKralichka1998Bible) { m_CzechKralichka1998Bible = CzechKralichka1998Bible; }
    public void SetCzechPMPZBible(string CzechPMPZBible) { m_CzechPMPZBible = CzechPMPZBible; }
    public void SetCzechPrekladBible(string CzechPrekladBible) { m_CzechPrekladBible = CzechPrekladBible; }
    public void SetCzechSNCBible(string CzechSNCBible) { m_CzechSNCBible = CzechSNCBible; }
    public void SetDagbaniBible(string DagbaniBible) { m_DagbaniBible = DagbaniBible; }
    public void SetDanish1819Bible(string Danish1819Bible) { m_Danish1819Bible = Danish1819Bible; }
    public void SetDanish2015Bible(string Danish2015Bible) { m_Danish2015Bible = Danish2015Bible; }
    public void SetDanishBible(string DanishBible) { m_DanishBible = DanishBible; }
    public void SetDanishLBBible(string DanishLBBible) { m_DanishLBBible = DanishLBBible; }
    public void SetDanishWIEBible(string DanishWIEBible) { m_DanishWIEBible = DanishWIEBible; }
    public void SetDinka2006Bible(string Dinka2006Bible) { m_Dinka2006Bible = Dinka2006Bible; }
    public void SetDinkaBible(string DinkaBible) { m_DinkaBible = DinkaBible; }
    public void SetDinkaLEKJOTBible(string DinkaLEKJOTBible) { m_DinkaLEKJOTBible = DinkaLEKJOTBible; }
    public void SetDogriBible(string DogriBible) { m_DogriBible = DogriBible; }
    public void SetDutch1939Bible(string Dutch1939Bible) { m_Dutch1939Bible = Dutch1939Bible; }
    public void SetDutch2007Bible(string Dutch2007Bible) { m_Dutch2007Bible = Dutch2007Bible; }
    public void SetDutchBBBible(string DutchBBBible) { m_DutchBBBible = DutchBBBible; }
    public void SetDutchBible(string DutchBible) { m_DutchBible = DutchBible; }
    public void SetDutchEBV24Bible(string DutchEBV24Bible) { m_DutchEBV24Bible = DutchEBV24Bible; }
    public void SetDutchFrisianBible(string DutchFrisianBible) { m_DutchFrisianBible = DutchFrisianBible; }
    public void SetDutchGBVNTBible(string DutchGBVNTBible) { m_DutchGBVNTBible = DutchGBVNTBible; }
    public void SetDutchHSVBible(string DutchHSVBible) { m_DutchHSVBible = DutchHSVBible; }
    public void SetDutchHTBBible(string DutchHTBBible) { m_DutchHTBBible = DutchHTBBible; }
    public void SetDutchNBGBible(string DutchNBGBible) { m_DutchNBGBible = DutchNBGBible; }
    public void SetDutchReimerBible(string DutchReimerBible) { m_DutchReimerBible = DutchReimerBible; }
    public void SetDutchSVVBible(string DutchSVVBible) { m_DutchSVVBible = DutchSVVBible; }
    public void SetDutchVBBible(string DutchVBBible) { m_DutchVBBible = DutchVBBible; }
    public void SetDyulaJulaBible(string DyulaJulaBible) { m_DyulaJulaBible = DyulaJulaBible; }
    public void SetDyulaKumaBible(string DyulaKumaBible) { m_DyulaKumaBible = DyulaKumaBible; }
    public void SetDyulaLayidukuraBible(string DyulaLayidukuraBible) { m_DyulaLayidukuraBible = DyulaLayidukuraBible; }
    public void SetEdoBible(string EdoBible) { m_EdoBible = EdoBible; }
    public void SetEnglishAmplifiedBible(string EnglishAmplifiedBible) { m_EnglishAmplifiedBible = EnglishAmplifiedBible; }
    public void SetEnglishAmplifiedClassicBible(string EnglishAmplifiedClassicBible) { m_EnglishAmplifiedClassicBible = EnglishAmplifiedClassicBible; }
    public void SetEnglishASVBible(string EnglishASVBible) { m_EnglishASVBible = EnglishASVBible; }
    public void SetEnglishBereanBible(string EnglishBereanBible) { m_EnglishBereanBible = EnglishBereanBible; }
    public void SetEnglishCSBBible(string EnglishCSBBible) { m_EnglishCSBBible = EnglishCSBBible; }
    public void SetEnglishDarbyBible(string EnglishDarbyBible) { m_EnglishDarbyBible = EnglishDarbyBible; }
    public void SetEnglishEASYBible(string EnglishEASYBible) { m_EnglishEASYBible = EnglishEASYBible; }
    public void SetEnglishERVBible(string EnglishERVBible) { m_EnglishERVBible = EnglishERVBible; }
    public void SetEnglishESVBible(string EnglishESVBible) { m_EnglishESVBible = EnglishESVBible; }
    public void SetEnglishGNTBible(string EnglishGNTBible) { m_EnglishGNTBible = EnglishGNTBible; }
    public void SetEnglishGWBible(string EnglishGWBible) { m_EnglishGWBible = EnglishGWBible; }
    public void SetEnglishHCSBBible(string EnglishHCSBBible) { m_EnglishHCSBBible = EnglishHCSBBible; }
    public void SetEnglishKJBible(string EnglishKJBible) { m_EnglishKJBible = EnglishKJBible; }
    public void SetEnglishLSBBible(string EnglishLSBBible) { m_EnglishLSBBible = EnglishLSBBible; }
    public void SetEnglishMEVBible(string EnglishMEVBible) { m_EnglishMEVBible = EnglishMEVBible; }
    public void SetEnglishNASBBible(string EnglishNASBBible) { m_EnglishNASBBible = EnglishNASBBible; }
    public void SetEnglishNASUBible(string EnglishNASUBible) { m_EnglishNASUBible = EnglishNASUBible; }
    public void SetEnglishNETBible(string EnglishNETBible) { m_EnglishNETBible = EnglishNETBible; }
    public void SetEnglishNIRVBible(string EnglishNIRVBible) { m_EnglishNIRVBible = EnglishNIRVBible; }
    public void SetEnglishNIVBible(string EnglishNIVBible) { m_EnglishNIVBible = EnglishNIVBible; }
    public void SetEnglishNKJBible(string EnglishNKJBible) { m_EnglishNKJBible = EnglishNKJBible; }
    public void SetEnglishNLTBible(string EnglishNLTBible) { m_EnglishNLTBible = EnglishNLTBible; }
    public void SetEnglishNRSVBible(string EnglishNRSVBible) { m_EnglishNRSVBible = EnglishNRSVBible; }
    public void SetEnglishPassionBible(string EnglishPassionBible) { m_EnglishPassionBible = EnglishPassionBible; }
    public void SetEnglishRSVBible(string EnglishRSVBible) { m_EnglishRSVBible = EnglishRSVBible; }
    public void SetEnglishTLBible(string EnglishTLBible) { m_EnglishTLBible = EnglishTLBible; }
    public void SetEnglishTyndale1537Bible(string EnglishTyndale1537Bible) { m_EnglishTyndale1537Bible = EnglishTyndale1537Bible; }
    public void SetEnglishYLTBible(string EnglishYLTBible) { m_EnglishYLTBible = EnglishYLTBible; }
    public void SetEsperantoBible(string EsperantoBible) { m_EsperantoBible = EsperantoBible; }
    public void SetEstonian2022Bible(string Estonian2022Bible) { m_Estonian2022Bible = Estonian2022Bible; }
    public void SetEstonianBible(string EstonianBible) { m_EstonianBible = EstonianBible; }
    public void SetEstonianEEPBible(string EstonianEEPBible) { m_EstonianEEPBible = EstonianEEPBible; }
    public void SetEwe1913Bible(string Ewe1913Bible) { m_Ewe1913Bible = Ewe1913Bible; }
    public void SetEwe2014Bible(string Ewe2014Bible) { m_Ewe2014Bible = Ewe2014Bible; }
    public void SetEwe2020Bible(string Ewe2020Bible) { m_Ewe2020Bible = Ewe2020Bible; }
    public void SetEweBible(string EweBible) { m_EweBible = EweBible; }
    public void SetFinnish1776Bible(string Finnish1776Bible) { m_Finnish1776Bible = Finnish1776Bible; }
    public void SetFinnish1992Bible(string Finnish1992Bible) { m_Finnish1992Bible = Finnish1992Bible; }
    public void SetFinnishBible(string FinnishBible) { m_FinnishBible = FinnishBible; }
    public void SetFinnishFINRKBible(string FinnishFINRKBible) { m_FinnishFINRKBible = FinnishFINRKBible; }
    public void SetFinnishSTLKBible(string FinnishSTLKBible) { m_FinnishSTLKBible = FinnishSTLKBible; }
    public void SetFonBible(string FonBible) { m_FonBible = FonBible; }
    public void SetFrench2004Bible(string French2004Bible) { m_French2004Bible = French2004Bible; }
    public void SetFrenchBBBBible(string FrenchBBBBible) { m_FrenchBBBBible = FrenchBBBBible; }
    public void SetFrenchBDSBible(string FrenchBDSBible) { m_FrenchBDSBible = FrenchBDSBible; }
    public void SetFrenchBFCBible(string FrenchBFCBible) { m_FrenchBFCBible = FrenchBFCBible; }
    public void SetFrenchBible(string FrenchBible) { m_FrenchBible = FrenchBible; }
    public void SetFrenchCramponBible(string FrenchCramponBible) { m_FrenchCramponBible = FrenchCramponBible; }
    public void SetFrenchDarbyBible(string FrenchDarbyBible) { m_FrenchDarbyBible = FrenchDarbyBible; }
    public void SetFrenchJerusalemBible(string FrenchJerusalemBible) { m_FrenchJerusalemBible = FrenchJerusalemBible; }
    public void SetFrenchLeonBible(string FrenchLeonBible) { m_FrenchLeonBible = FrenchLeonBible; }
    public void SetFrenchMachairaBible(string FrenchMachairaBible) { m_FrenchMachairaBible = FrenchMachairaBible; }
    public void SetFrenchMartinBible(string FrenchMartinBible) { m_FrenchMartinBible = FrenchMartinBible; }
    public void SetFrenchNBSBible(string FrenchNBSBible) { m_FrenchNBSBible = FrenchNBSBible; }
    public void SetFrenchNEG79Bible(string FrenchNEG79Bible) { m_FrenchNEG79Bible = FrenchNEG79Bible; }
    public void SetFrenchNFCBible(string FrenchNFCBible) { m_FrenchNFCBible = FrenchNFCBible; }
    public void SetFrenchNVS78Bible(string FrenchNVS78Bible) { m_FrenchNVS78Bible = FrenchNVS78Bible; }
    public void SetFrenchOSTBible(string FrenchOSTBible) { m_FrenchOSTBible = FrenchOSTBible; }
    public void SetFrenchOstervaldBible(string FrenchOstervaldBible) { m_FrenchOstervaldBible = FrenchOstervaldBible; }
    public void SetFrenchPDV2017Bible(string FrenchPDV2017Bible) { m_FrenchPDV2017Bible = FrenchPDV2017Bible; }
    public void SetFrenchPerretBible(string FrenchPerretBible) { m_FrenchPerretBible = FrenchPerretBible; }
    public void SetFrenchS21Bible(string FrenchS21Bible) { m_FrenchS21Bible = FrenchS21Bible; }
    public void SetFrenchVigourouxBible(string FrenchVigourouxBible) { m_FrenchVigourouxBible = FrenchVigourouxBible; }
    public void SetFulfulde2010Bible(string Fulfulde2010Bible) { m_Fulfulde2010Bible = Fulfulde2010Bible; }
    public void SetFulfuldeAadiBible(string FulfuldeAadiBible) { m_FulfuldeAadiBible = FulfuldeAadiBible; }
    public void SetFulfuldeAdamawaBible(string FulfuldeAdamawaBible) { m_FulfuldeAdamawaBible = FulfuldeAdamawaBible; }
    public void SetFulfuldeAlkawalBible(string FulfuldeAlkawalBible) { m_FulfuldeAlkawalBible = FulfuldeAlkawalBible; }
    public void SetFulfuldeArabicBible(string FulfuldeArabicBible) { m_FulfuldeArabicBible = FulfuldeArabicBible; }
    public void SetFulfuldeBeninBible(string FulfuldeBeninBible) { m_FulfuldeBeninBible = FulfuldeBeninBible; }
    public void SetFulfuldeBurkinaFasoBible(string FulfuldeBurkinaFasoBible) { m_FulfuldeBurkinaFasoBible = FulfuldeBurkinaFasoBible; }
    public void SetFulfuldeDewtereBible(string FulfuldeDewtereBible) { m_FulfuldeDewtereBible = FulfuldeDewtereBible; }
    public void SetFulfuldeWestNigerBible(string FulfuldeWestNigerBible) { m_FulfuldeWestNigerBible = FulfuldeWestNigerBible; }
    public void SetGaelic1875Bible(string Gaelic1875Bible) { m_Gaelic1875Bible = Gaelic1875Bible; }
    public void SetGaelicABGBible(string GaelicABGBible) { m_GaelicABGBible = GaelicABGBible; }
    public void SetGaelicABIGBible(string GaelicABIGBible) { m_GaelicABIGBible = GaelicABIGBible; }
    public void SetGaelicATNBible(string GaelicATNBible) { m_GaelicATNBible = GaelicATNBible; }
    public void SetGalacianSEPTBible(string GalacianSEPTBible) { m_GalacianSEPTBible = GalacianSEPTBible; }
    public void SetGarhwaliBible(string GarhwaliBible) { m_GarhwaliBible = GarhwaliBible; }
    public void SetGarhwaliGBMBible(string GarhwaliGBMBible) { m_GarhwaliGBMBible = GarhwaliGBMBible; }
    public void SetGeorgian2002Bible(string Georgian2002Bible) { m_Georgian2002Bible = Georgian2002Bible; }
    public void SetGeorgian2012Bible(string Georgian2012Bible) { m_Georgian2012Bible = Georgian2012Bible; }
    public void SetGeorgianBible(string GeorgianBible) { m_GeorgianBible = GeorgianBible; }
    public void SetGerman1545Bible(string German1545Bible) { m_German1545Bible = German1545Bible; }
    public void SetGerman2011Bible(string German2011Bible) { m_German2011Bible = German2011Bible; }
    public void SetGermanAlbrecht1926Bible(string GermanAlbrecht1926Bible) { m_GermanAlbrecht1926Bible = GermanAlbrecht1926Bible; }
    public void SetGermanBible(string GermanBible) { m_GermanBible = GermanBible; }
    public void SetGermanElber1905Bible(string GermanElber1905Bible) { m_GermanElber1905Bible = GermanElber1905Bible; }
    public void SetGermanGruenewaldBible(string GermanGruenewaldBible) { m_GermanGruenewaldBible = GermanGruenewaldBible; }
    public void SetGermanHeuteBible(string GermanHeuteBible) { m_GermanHeuteBible = GermanHeuteBible; }
    public void SetGermanHFABible(string GermanHFABible) { m_GermanHFABible = GermanHFABible; }
    public void SetGermanInterlinearBible(string GermanInterlinearBible) { m_GermanInterlinearBible = GermanInterlinearBible; }
    public void SetGermanLUT17Bible(string GermanLUT17Bible) { m_GermanLUT17Bible = GermanLUT17Bible; }
    public void SetGermanLuther1912Bible(string GermanLuther1912Bible) { m_GermanLuther1912Bible = GermanLuther1912Bible; }
    public void SetGermanLutherHeuteBible(string GermanLutherHeuteBible) { m_GermanLutherHeuteBible = GermanLutherHeuteBible; }
    public void SetGermanSchlachter2000Bible(string GermanSchlachter2000Bible) { m_GermanSchlachter2000Bible = GermanSchlachter2000Bible; }
    public void SetGermanTafelBible(string GermanTafelBible) { m_GermanTafelBible = GermanTafelBible; }
    public void SetGermanTKWBible(string GermanTKWBible) { m_GermanTKWBible = GermanTKWBible; }
    public void SetGermanUbersetzung2014Bible(string GermanUbersetzung2014Bible) { m_GermanUbersetzung2014Bible = GermanUbersetzung2014Bible; }
    public void SetGhomalaBible(string GhomalaBible) { m_GhomalaBible = GhomalaBible; }
    public void SetGreek1550Bible(string Greek1550Bible) { m_Greek1550Bible = Greek1550Bible; }
    public void SetGreekBible(string GreekBible) { m_GreekBible = GreekBible; }
    public void SetGreekBYZ04Bible(string GreekBYZ04Bible) { m_GreekBYZ04Bible = GreekBYZ04Bible; }
    public void SetGreekBYZ18Bible(string GreekBYZ18Bible) { m_GreekBYZ18Bible = GreekBYZ18Bible; }
    public void SetGreekElzevirBible(string GreekElzevirBible) { m_GreekElzevirBible = GreekElzevirBible; }
    public void SetGreekF35Bible(string GreekF35Bible) { m_GreekF35Bible = GreekF35Bible; }
    public void SetGreekFPBBible(string GreekFPBBible) { m_GreekFPBBible = GreekFPBBible; }
    public void SetGreekGNTBible(string GreekGNTBible) { m_GreekGNTBible = GreekGNTBible; }
    public void SetGreekLMGNTBible(string GreekLMGNTBible) { m_GreekLMGNTBible = GreekLMGNTBible; }
    public void SetGreekModern1904Bible(string GreekModern1904Bible) { m_GreekModern1904Bible = GreekModern1904Bible; }
    public void SetGreekModernFPBBible(string GreekModernFPBBible) { m_GreekModernFPBBible = GreekModernFPBBible; }
    public void SetGreekNTVBible(string GreekNTVBible) { m_GreekNTVBible = GreekNTVBible; }
    public void SetGreekSBLGNTBible(string GreekSBLGNTBible) { m_GreekSBLGNTBible = GreekSBLGNTBible; }
    public void SetGreekTCGNTBible(string GreekTCGNTBible) { m_GreekTCGNTBible = GreekTCGNTBible; }
    public void SetGreekTGVBible(string GreekTGVBible) { m_GreekTGVBible = GreekTGVBible; }
    public void SetGreekTHGNTBible(string GreekTHGNTBible) { m_GreekTHGNTBible = GreekTHGNTBible; }
    public void SetGreekTR1894Bible(string GreekTR1894Bible) { m_GreekTR1894Bible = GreekTR1894Bible; }
    public void SetGuarani1913Bible(string Guarani1913Bible) { m_Guarani1913Bible = Guarani1913Bible; }
    public void SetGuarani1970Bible(string Guarani1970Bible) { m_Guarani1970Bible = Guarani1970Bible; }
    public void SetGuarani1996Bible(string Guarani1996Bible) { m_Guarani1996Bible = Guarani1996Bible; }
    public void SetGuarani2001Bible(string Guarani2001Bible) { m_Guarani2001Bible = Guarani2001Bible; }
    public void SetGuarani2015Bible(string Guarani2015Bible) { m_Guarani2015Bible = Guarani2015Bible; }
    public void SetGuarani2017Bible(string Guarani2017Bible) { m_Guarani2017Bible = Guarani2017Bible; }
    public void SetGuaraniBible(string GuaraniBible) { m_GuaraniBible = GuaraniBible; }
    public void SetGuaraniMBYABible(string GuaraniMBYABible) { m_GuaraniMBYABible = GuaraniMBYABible; }
    public void SetGuaraniSIMBABible(string GuaraniSIMBABible) { m_GuaraniSIMBABible = GuaraniSIMBABible; }
    public void SetGujarati2016Bible(string Gujarati2016Bible) { m_Gujarati2016Bible = Gujarati2016Bible; }
    public void SetGujarati2017Bible(string Gujarati2017Bible) { m_Gujarati2017Bible = Gujarati2017Bible; }
    public void SetGujaratiBible(string GujaratiBible) { m_GujaratiBible = GujaratiBible; }
    public void SetGujaratiGUOVBible(string GujaratiGUOVBible) { m_GujaratiGUOVBible = GujaratiGUOVBible; }
    public void SetGussiBible(string GussiBible) { m_GussiBible = GussiBible; }
    public void SetHadiyyaBible(string HadiyyaBible) { m_HadiyyaBible = HadiyyaBible; }
    public void SetHaitianBible(string HaitianBible) { m_HaitianBible = HaitianBible; }
    public void SetHaitianBSABible(string HaitianBSABible) { m_HaitianBSABible = HaitianBSABible; }
    public void SetHaitianHWPBible(string HaitianHWPBible) { m_HaitianHWPBible = HaitianHWPBible; }
    public void SetHaitianVFKBible(string HaitianVFKBible) { m_HaitianVFKBible = HaitianVFKBible; }
    public void SetHaryanviBible(string HaryanviBible) { m_HaryanviBible = HaryanviBible; }
    public void SetHausa2010Bible(string Hausa2010Bible) { m_Hausa2010Bible = Hausa2010Bible; }
    public void SetHausa2013Bible(string Hausa2013Bible) { m_Hausa2013Bible = Hausa2013Bible; }
    public void SetHausaARBible(string HausaARBible) { m_HausaARBible = HausaARBible; }
    public void SetHebrew1885Bible(string Hebrew1885Bible) { m_Hebrew1885Bible = Hebrew1885Bible; }
    public void SetHebrewAleppoCodexBible(string HebrewAleppoCodexBible) { m_HebrewAleppoCodexBible = HebrewAleppoCodexBible; }
    public void SetHebrewBible(string HebrewBible) { m_HebrewBible = HebrewBible; }
    public void SetHebrewBSIBible(string HebrewBSIBible) { m_HebrewBSIBible = HebrewBSIBible; }
    public void SetHebrewHHHBible(string HebrewHHHBible) { m_HebrewHHHBible = HebrewHHHBible; }
    public void SetHebrewLeningradCodexBible(string HebrewLeningradCodexBible) { m_HebrewLeningradCodexBible = HebrewLeningradCodexBible; }
    public void SetHebrewMHBBible(string HebrewMHBBible) { m_HebrewMHBBible = HebrewMHBBible; }
    public void SetHebrewMHNT2020Bible(string HebrewMHNT2020Bible) { m_HebrewMHNT2020Bible = HebrewMHNT2020Bible; }
    public void SetHebrewTDBible(string HebrewTDBible) { m_HebrewTDBible = HebrewTDBible; }
    public void SetHindi2017Bible(string Hindi2017Bible) { m_Hindi2017Bible = Hindi2017Bible; }
    public void SetHindiBible(string HindiBible) { m_HindiBible = HindiBible; }
    public void SetHindiCLBSIBible(string HindiCLBSIBible) { m_HindiCLBSIBible = HindiCLBSIBible; }
    public void SetHindiERVBible(string HindiERVBible) { m_HindiERVBible = HindiERVBible; }
    public void SetHindiFijiBible(string HindiFijiBible) { m_HindiFijiBible = HindiFijiBible; }
    public void SetHindiHSBBible(string HindiHSBBible) { m_HindiHSBBible = HindiHSBBible; }
    public void SetHindiHSSBible(string HindiHSSBible) { m_HindiHSSBible = HindiHSSBible; }
    public void SetHindiIRVBible(string HindiIRVBible) { m_HindiIRVBible = HindiIRVBible; }
    public void SetHindiOVBSIBible(string HindiOVBSIBible) { m_HindiOVBSIBible = HindiOVBSIBible; }
    public void SetHindiRomanBible(string HindiRomanBible) { m_HindiRomanBible = HindiRomanBible; }
    public void SetHmong2000Bible(string Hmong2000Bible) { m_Hmong2000Bible = Hmong2000Bible; }
    public void SetHmong2004Bible(string Hmong2004Bible) { m_Hmong2004Bible = Hmong2004Bible; }
    public void SetHungarianBDUZBible(string HungarianBDUZBible) { m_HungarianBDUZBible = HungarianBDUZBible; }
    public void SetHungarianBible(string HungarianBible) { m_HungarianBible = HungarianBible; }
    public void SetHungarianBUZBible(string HungarianBUZBible) { m_HungarianBUZBible = HungarianBUZBible; }
    public void SetHungarianCSIABible(string HungarianCSIABible) { m_HungarianCSIABible = HungarianCSIABible; }
    public void SetHungarianCSUZBible(string HungarianCSUZBible) { m_HungarianCSUZBible = HungarianCSUZBible; }
    public void SetHungarianEFOBible(string HungarianEFOBible) { m_HungarianEFOBible = HungarianEFOBible; }
    public void SetHungarianEIVBible(string HungarianEIVBible) { m_HungarianEIVBible = HungarianEIVBible; }
    public void SetHungarianERVBible(string HungarianERVBible) { m_HungarianERVBible = HungarianERVBible; }
    public void SetHungarianKaroliBible(string HungarianKaroliBible) { m_HungarianKaroliBible = HungarianKaroliBible; }
    public void SetHungarianKIBBible(string HungarianKIBBible) { m_HungarianKIBBible = HungarianKIBBible; }
    public void SetHungarianKNBBible(string HungarianKNBBible) { m_HungarianKNBBible = HungarianKNBBible; }
    public void SetHungarianKSZEBible(string HungarianKSZEBible) { m_HungarianKSZEBible = HungarianKSZEBible; }
    public void SetHungarianMRUZBible(string HungarianMRUZBible) { m_HungarianMRUZBible = HungarianMRUZBible; }
    public void SetHungarianRLUZBible(string HungarianRLUZBible) { m_HungarianRLUZBible = HungarianRLUZBible; }
    public void SetHungarianRUFBible(string HungarianRUFBible) { m_HungarianRUFBible = HungarianRUFBible; }
    public void SetHungarianSIUZBible(string HungarianSIUZBible) { m_HungarianSIUZBible = HungarianSIUZBible; }
    public void SetHungarianVSUZBible(string HungarianVSUZBible) { m_HungarianVSUZBible = HungarianVSUZBible; }
    public void SetIbanBible(string IbanBible) { m_IbanBible = IbanBible; }
    public void SetIbibioBible(string IbibioBible) { m_IbibioBible = IbibioBible; }
    public void SetIcelandic1981Bible(string Icelandic1981Bible) { m_Icelandic1981Bible = Icelandic1981Bible; }
    public void SetIcelandicBible(string IcelandicBible) { m_IcelandicBible = IcelandicBible; }
    public void SetIgbo1988Bible(string Igbo1988Bible) { m_Igbo1988Bible = Igbo1988Bible; }
    public void SetIgbo2006Bible(string Igbo2006Bible) { m_Igbo2006Bible = Igbo2006Bible; }
    public void SetIgbo2020Bible(string Igbo2020Bible) { m_Igbo2020Bible = Igbo2020Bible; }
    public void SetIkaBible(string IkaBible) { m_IkaBible = IkaBible; }
    public void SetIlokano1973Bible(string Ilokano1973Bible) { m_Ilokano1973Bible = Ilokano1973Bible; }
    public void SetIlokanoBible(string IlokanoBible) { m_IlokanoBible = IlokanoBible; }
    public void SetIlonggo2012Bible(string Ilonggo2012Bible) { m_Ilonggo2012Bible = Ilonggo2012Bible; }
    public void SetIlonggoAPDBible(string IlonggoAPDBible) { m_IlonggoAPDBible = IlonggoAPDBible; }
    public void SetIlonggoBible(string IlonggoBible) { m_IlonggoBible = IlonggoBible; }
    public void SetIndonesianAGSBible(string IndonesianAGSBible) { m_IndonesianAGSBible = IndonesianAGSBible; }
    public void SetIndonesianAMD2021Bible(string IndonesianAMD2021Bible) { m_IndonesianAMD2021Bible = IndonesianAMD2021Bible; }
    public void SetIndonesianBible(string IndonesianBible) { m_IndonesianBible = IndonesianBible; }
    public void SetIndonesianBISBible(string IndonesianBISBible) { m_IndonesianBISBible = IndonesianBISBible; }
    public void SetIndonesianBPJBible(string IndonesianBPJBible) { m_IndonesianBPJBible = IndonesianBPJBible; }
    public void SetIndonesianFAYHBible(string IndonesianFAYHBible) { m_IndonesianFAYHBible = IndonesianFAYHBible; }
    public void SetIndonesianINOTAZIBible(string IndonesianINOTAZIBible) { m_IndonesianINOTAZIBible = IndonesianINOTAZIBible; }
    public void SetIndonesianPBTB2Bible(string IndonesianPBTB2Bible) { m_IndonesianPBTB2Bible = IndonesianPBTB2Bible; }
    public void SetIndonesianTLBible(string IndonesianTLBible) { m_IndonesianTLBible = IndonesianTLBible; }
    public void SetIndonesianTSIBible(string IndonesianTSIBible) { m_IndonesianTSIBible = IndonesianTSIBible; }
    public void SetIndonesianVMDBible(string IndonesianVMDBible) { m_IndonesianVMDBible = IndonesianVMDBible; }
    public void SetIrish1817Bible(string Irish1817Bible) { m_Irish1817Bible = Irish1817Bible; }
    public void SetIrish1951Bible(string Irish1951Bible) { m_Irish1951Bible = Irish1951Bible; }
    public void SetIrish1970Bible(string Irish1970Bible) { m_Irish1970Bible = Irish1970Bible; }
    public void SetIrish2012Bible(string Irish2012Bible) { m_Irish2012Bible = Irish2012Bible; }
    public void SetIrishBible(string IrishBible) { m_IrishBible = IrishBible; }
    public void SetItalian1649Bible(string Italian1649Bible) { m_Italian1649Bible = Italian1649Bible; }
    public void SetItalian2014Bible(string Italian2014Bible) { m_Italian2014Bible = Italian2014Bible; }
    public void SetItalian2020Bible(string Italian2020Bible) { m_Italian2020Bible = Italian2020Bible; }
    public void SetItalianBible(string ItalianBible) { m_ItalianBible = ItalianBible; }
    public void SetItalianCEI2008Bible(string ItalianCEI2008Bible) { m_ItalianCEI2008Bible = ItalianCEI2008Bible; }
    public void SetItalianIPNBible(string ItalianIPNBible) { m_ItalianIPNBible = ItalianIPNBible; }
    public void SetItalianLaNuovaDiodatiBible(string ItalianLaNuovaDiodatiBible) { m_ItalianLaNuovaDiodatiBible = ItalianLaNuovaDiodatiBible; }
    public void SetItalianNR1994Bible(string ItalianNR1994Bible) { m_ItalianNR1994Bible = ItalianNR1994Bible; }
    public void SetItalianRivedutaBible(string ItalianRivedutaBible) { m_ItalianRivedutaBible = ItalianRivedutaBible; }
    public void SetIuMienBible(string IuMienBible) { m_IuMienBible = IuMienBible; }
    public void SetIuMienThaiBible(string IuMienThaiBible) { m_IuMienThaiBible = IuMienThaiBible; }
    public void SetJamaicanBible(string JamaicanBible) { m_JamaicanBible = JamaicanBible; }
    public void SetJapanese1965Bible(string Japanese1965Bible) { m_Japanese1965Bible = Japanese1965Bible; }
    public void SetJapanese1987Bible(string Japanese1987Bible) { m_Japanese1987Bible = Japanese1987Bible; }
    public void SetJapanese2017Bible(string Japanese2017Bible) { m_Japanese2017Bible = Japanese2017Bible; }
    public void SetJapaneseBible(string JapaneseBible) { m_JapaneseBible = JapaneseBible; }
    public void SetJapaneseCO1955Bible(string JapaneseCO1955Bible) { m_JapaneseCO1955Bible = JapaneseCO1955Bible; }
    public void SetJapaneseERVBible(string JapaneseERVBible) { m_JapaneseERVBible = JapaneseERVBible; }
    public void SetJapaneseJCBBible(string JapaneseJCBBible) { m_JapaneseJCBBible = JapaneseJCBBible; }
    public void SetJavaneseBible(string JavaneseBible) { m_JavaneseBible = JavaneseBible; }
    public void SetJavaneseJVNBible(string JavaneseJVNBible) { m_JavaneseJVNBible = JavaneseJVNBible; }
    public void SetJavaneseKJS17Bible(string JavaneseKJS17Bible) { m_JavaneseKJS17Bible = JavaneseKJS17Bible; }
    public void SetKabardianBible(string KabardianBible) { m_KabardianBible = KabardianBible; }
    public void SetKabyleBible(string KabyleBible) { m_KabyleBible = KabyleBible; }
    public void SetKachinJCLBBible(string KachinJCLBBible) { m_KachinJCLBBible = KachinJCLBBible; }
    public void SetKachinJHVT3Bible(string KachinJHVT3Bible) { m_KachinJHVT3Bible = KachinJHVT3Bible; }
    public void SetKalenjin2019Bible(string Kalenjin2019Bible) { m_Kalenjin2019Bible = Kalenjin2019Bible; }
    public void SetKalenjinBible(string KalenjinBible) { m_KalenjinBible = KalenjinBible; }
    public void SetKalenjinRevisedBible(string KalenjinRevisedBible) { m_KalenjinRevisedBible = KalenjinRevisedBible; }
    public void SetKambaBible(string KambaBible) { m_KambaBible = KambaBible; }
    public void SetKambaMBIVLIABible(string KambaMBIVLIABible) { m_KambaMBIVLIABible = KambaMBIVLIABible; }
    public void SetKangriBible(string KangriBible) { m_KangriBible = KangriBible; }
    public void SetKannada2022Bible(string Kannada2022Bible) { m_Kannada2022Bible = Kannada2022Bible; }
    public void SetKannadaBible(string KannadaBible) { m_KannadaBible = KannadaBible; }
    public void SetKannadaBSIBible(string KannadaBSIBible) { m_KannadaBSIBible = KannadaBSIBible; }
    public void SetKannadaBSIJVBible(string KannadaBSIJVBible) { m_KannadaBSIJVBible = KannadaBSIJVBible; }
    public void SetKannadaIRVBible(string KannadaIRVBible) { m_KannadaIRVBible = KannadaIRVBible; }
    public void SetKannadaKNCLBible(string KannadaKNCLBible) { m_KannadaKNCLBible = KannadaKNCLBible; }
    public void SetKarakalpak2004Bible(string Karakalpak2004Bible) { m_Karakalpak2004Bible = Karakalpak2004Bible; }
    public void SetKarakalpak2022Bible(string Karakalpak2022Bible) { m_Karakalpak2022Bible = Karakalpak2022Bible; }
    public void SetKarakalpakK2022Bible(string KarakalpakK2022Bible) { m_KarakalpakK2022Bible = KarakalpakK2022Bible; }
    public void SetKazakhstan2023Bible(string Kazakhstan2023Bible) { m_Kazakhstan2023Bible = Kazakhstan2023Bible; }
    public void SetKazakhstanBible(string KazakhstanBible) { m_KazakhstanBible = KazakhstanBible; }
    public void SetKenyaGIKCLBible(string KenyaGIKCLBible) { m_KenyaGIKCLBible = KenyaGIKCLBible; }
    public void SetKhmer2005Bible(string Khmer2005Bible) { m_Khmer2005Bible = Khmer2005Bible; }
    public void SetKhmer2012Bible(string Khmer2012Bible) { m_Khmer2012Bible = Khmer2012Bible; }
    public void SetKhmer2014Bible(string Khmer2014Bible) { m_Khmer2014Bible = Khmer2014Bible; }
    public void SetKhmer2016Bible(string Khmer2016Bible) { m_Khmer2016Bible = Khmer2016Bible; }
    public void SetKhmer2019Bible(string Khmer2019Bible) { m_Khmer2019Bible = Khmer2019Bible; }
    public void SetKhmerBFBSBible(string KhmerBFBSBible) { m_KhmerBFBSBible = KhmerBFBSBible; }
    public void SetKhmerBible(string KhmerBible) { m_KhmerBible = KhmerBible; }
    public void SetKiche1995Bible(string Kiche1995Bible) { m_Kiche1995Bible = Kiche1995Bible; }
    public void SetKiche2022Bible(string Kiche2022Bible) { m_Kiche2022Bible = Kiche2022Bible; }
    public void SetKicheBible(string KicheBible) { m_KicheBible = KicheBible; }
    public void SetKicheQUCNBible(string KicheQUCNBible) { m_KicheQUCNBible = KicheQUCNBible; }
    public void SetKikuyu2013Bible(string Kikuyu2013Bible) { m_Kikuyu2013Bible = Kikuyu2013Bible; }
    public void SetKikuyu2014Bible(string Kikuyu2014Bible) { m_Kikuyu2014Bible = Kikuyu2014Bible; }
    public void SetKikuyu2019Bible(string Kikuyu2019Bible) { m_Kikuyu2019Bible = Kikuyu2019Bible; }
    public void SetKikwangoBible(string KikwangoBible) { m_KikwangoBible = KikwangoBible; }
    public void SetKimbunduBible(string KimbunduBible) { m_KimbunduBible = KimbunduBible; }
    public void SetKimiiruBible(string KimiiruBible) { m_KimiiruBible = KimiiruBible; }
    public void SetKinyarwanda2001Bible(string Kinyarwanda2001Bible) { m_Kinyarwanda2001Bible = Kinyarwanda2001Bible; }
    public void SetKinyarwanda2012Bible(string Kinyarwanda2012Bible) { m_Kinyarwanda2012Bible = Kinyarwanda2012Bible; }
    public void SetKinyarwandaBIRBible(string KinyarwandaBIRBible) { m_KinyarwandaBIRBible = KinyarwandaBIRBible; }
    public void SetKirundiCorosheBible(string KirundiCorosheBible) { m_KirundiCorosheBible = KirundiCorosheBible; }
    public void SetKirundiRishaBible(string KirundiRishaBible) { m_KirundiRishaBible = KirundiRishaBible; }
    public void SetKitubaBible(string KitubaBible) { m_KitubaBible = KitubaBible; }
    public void SetKonkaniBible(string KonkaniBible) { m_KonkaniBible = KonkaniBible; }
    public void SetKorean2021Bible(string Korean2021Bible) { m_Korean2021Bible = Korean2021Bible; }
    public void SetKoreanAEBBible(string KoreanAEBBible) { m_KoreanAEBBible = KoreanAEBBible; }
    public void SetKoreanKLBBible(string KoreanKLBBible) { m_KoreanKLBBible = KoreanKLBBible; }
    public void SetKoreanNKRVBible(string KoreanNKRVBible) { m_KoreanNKRVBible = KoreanNKRVBible; }
    public void SetKoreanRentierBible(string KoreanRentierBible) { m_KoreanRentierBible = KoreanRentierBible; }
    public void SetKoreanRNKSVBible(string KoreanRNKSVBible) { m_KoreanRNKSVBible = KoreanRNKSVBible; }
    public void SetKoreanTKVBible(string KoreanTKVBible) { m_KoreanTKVBible = KoreanTKVBible; }
    public void SetKoreanWoorimalBible(string KoreanWoorimalBible) { m_KoreanWoorimalBible = KoreanWoorimalBible; }
    public void SetKoyaBible(string KoyaBible) { m_KoyaBible = KoyaBible; }
    public void SetKrioBible(string KrioBible) { m_KrioBible = KrioBible; }
    public void SetKumaoniBible(string KumaoniBible) { m_KumaoniBible = KumaoniBible; }
    public void SetKurdish2005Bible(string Kurdish2005Bible) { m_Kurdish2005Bible = Kurdish2005Bible; }
    public void SetKurdish2017Bible(string Kurdish2017Bible) { m_Kurdish2017Bible = Kurdish2017Bible; }
    public void SetKurdishBHDBible(string KurdishBHDBible) { m_KurdishBHDBible = KurdishBHDBible; }
    public void SetKurdishBible(string KurdishBible) { m_KurdishBible = KurdishBible; }
    public void SetKurdishKMRNTCBible(string KurdishKMRNTCBible) { m_KurdishKMRNTCBible = KurdishKMRNTCBible; }
    public void SetKurdishKMRNTLBible(string KurdishKMRNTLBible) { m_KurdishKMRNTLBible = KurdishKMRNTLBible; }
    public void SetKurdishPNTZSBible(string KurdishPNTZSBible) { m_KurdishPNTZSBible = KurdishPNTZSBible; }
    public void SetKurdishSKBBible(string KurdishSKBBible) { m_KurdishSKBBible = KurdishSKBBible; }
    public void SetKurdishSKVBible(string KurdishSKVBible) { m_KurdishSKVBible = KurdishSKVBible; }
    public void SetKurukh2025Bible(string Kurukh2025Bible) { m_Kurukh2025Bible = Kurukh2025Bible; }
    public void SetKurukhBible(string KurukhBible) { m_KurukhBible = KurukhBible; }
    public void SetKyrgyz2004Bible(string Kyrgyz2004Bible) { m_Kyrgyz2004Bible = Kyrgyz2004Bible; }
    public void SetKyrgyz2005Bible(string Kyrgyz2005Bible) { m_Kyrgyz2005Bible = Kyrgyz2005Bible; }
    public void SetLahuBible(string LahuBible) { m_LahuBible = LahuBible; }
    public void SetLahuLHINTBible(string LahuLHINTBible) { m_LahuLHINTBible = LahuLHINTBible; }
    public void SetLambadiBible(string LambadiBible) { m_LambadiBible = LambadiBible; }
    public void SetLango1979Bible(string Lango1979Bible) { m_Lango1979Bible = Lango1979Bible; }
    public void SetLangoBible(string LangoBible) { m_LangoBible = LangoBible; }
    public void SetLao2012Bible(string Lao2012Bible) { m_Lao2012Bible = Lao2012Bible; }
    public void SetLaoBible(string LaoBible) { m_LaoBible = LaoBible; }
    public void SetLaoLCVBible(string LaoLCVBible) { m_LaoLCVBible = LaoLCVBible; }
    public void SetLatinBible(string LatinBible) { m_LatinBible = LatinBible; }
    public void SetLatinClementina1914Bible(string LatinClementina1914Bible) { m_LatinClementina1914Bible = LatinClementina1914Bible; }
    public void SetLatinClementineBible(string LatinClementineBible) { m_LatinClementineBible = LatinClementineBible; }
    public void SetLatinNovaVulgataBible(string LatinNovaVulgataBible) { m_LatinNovaVulgataBible = LatinNovaVulgataBible; }
    public void SetLatinSistinaBible(string LatinSistinaBible) { m_LatinSistinaBible = LatinSistinaBible; }
    public void SetLatvian1965Bible(string Latvian1965Bible) { m_Latvian1965Bible = Latvian1965Bible; }
    public void SetLatvian2012Bible(string Latvian2012Bible) { m_Latvian2012Bible = Latvian2012Bible; }
    public void SetLatvian2024Bible(string Latvian2024Bible) { m_Latvian2024Bible = Latvian2024Bible; }
    public void SetLatvianBible(string LatvianBible) { m_LatvianBible = LatvianBible; }
    public void SetLatvianGluckBible(string LatvianGluckBible) { m_LatvianGluckBible = LatvianGluckBible; }
    public void SetLatvianLG8Bible(string LatvianLG8Bible) { m_LatvianLG8Bible = LatvianLG8Bible; }
    public void SetLatvianLTV1965Bible(string LatvianLTV1965Bible) { m_LatvianLTV1965Bible = LatvianLTV1965Bible; }
    public void SetLatvianNLBDCBible(string LatvianNLBDCBible) { m_LatvianNLBDCBible = LatvianNLBDCBible; }
    public void SetLiberianKreyolBible(string LiberianKreyolBible) { m_LiberianKreyolBible = LiberianKreyolBible; }
    public void SetLingala2002Bible(string Lingala2002Bible) { m_Lingala2002Bible = Lingala2002Bible; }
    public void SetLingala2020Bible(string Lingala2020Bible) { m_Lingala2020Bible = Lingala2020Bible; }
    public void SetLithuanian2012Bible(string Lithuanian2012Bible) { m_Lithuanian2012Bible = Lithuanian2012Bible; }
    public void SetLithuanian2012EKUBible(string Lithuanian2012EKUBible) { m_Lithuanian2012EKUBible = Lithuanian2012EKUBible; }
    public void SetLithuanian2012KANBible(string Lithuanian2012KANBible) { m_Lithuanian2012KANBible = Lithuanian2012KANBible; }
    public void SetLithuanianBible(string LithuanianBible) { m_LithuanianBible = LithuanianBible; }
    public void SetLithuanianKJBible(string LithuanianKJBible) { m_LithuanianKJBible = LithuanianKJBible; }
    public void SetLithuanianLBDBible(string LithuanianLBDBible) { m_LithuanianLBDBible = LithuanianLBDBible; }
    public void SetLomweBible(string LomweBible) { m_LomweBible = LomweBible; }
    public void SetLuganda2003Bible(string Luganda2003Bible) { m_Luganda2003Bible = Luganda2003Bible; }
    public void SetLugandaBible(string LugandaBible) { m_LugandaBible = LugandaBible; }
    public void SetLugandaBIBU1Bible(string LugandaBIBU1Bible) { m_LugandaBIBU1Bible = LugandaBIBU1Bible; }
    public void SetLugandaEEEEBible(string LugandaEEEEBible) { m_LugandaEEEEBible = LugandaEEEEBible; }
    public void SetLugandaLBRBible(string LugandaLBRBible) { m_LugandaLBRBible = LugandaLBRBible; }
    public void SetLugbaraBible(string LugbaraBible) { m_LugbaraBible = LugbaraBible; }
    public void SetLuguruBible(string LuguruBible) { m_LuguruBible = LuguruBible; }
    public void SetLuo1985Bible(string Luo1985Bible) { m_Luo1985Bible = Luo1985Bible; }
    public void SetLuo2015Bible(string Luo2015Bible) { m_Luo2015Bible = Luo2015Bible; }
    public void SetLuo2020Bible(string Luo2020Bible) { m_Luo2020Bible = Luo2020Bible; }
    public void SetMaasai1970Bible(string Maasai1970Bible) { m_Maasai1970Bible = Maasai1970Bible; }
    public void SetMaasai2020Bible(string Maasai2020Bible) { m_Maasai2020Bible = Maasai2020Bible; }
    public void SetMaasaiBible(string MaasaiBible) { m_MaasaiBible = MaasaiBible; }
    public void SetMaasaiMBSBible(string MaasaiMBSBible) { m_MaasaiMBSBible = MaasaiMBSBible; }
    public void SetMacedonian1990Bible(string Macedonian1990Bible) { m_Macedonian1990Bible = Macedonian1990Bible; }
    public void SetMacedonian2006Bible(string Macedonian2006Bible) { m_Macedonian2006Bible = Macedonian2006Bible; }
    public void SetMacedonian2006DBible(string Macedonian2006DBible) { m_Macedonian2006DBible = Macedonian2006DBible; }
    public void SetMacedonian2023Bible(string Macedonian2023Bible) { m_Macedonian2023Bible = Macedonian2023Bible; }
    public void SetMacedonianMKB1999Bible(string MacedonianMKB1999Bible) { m_MacedonianMKB1999Bible = MacedonianMKB1999Bible; }
    public void SetMacedonianMNT1999Bible(string MacedonianMNT1999Bible) { m_MacedonianMNT1999Bible = MacedonianMNT1999Bible; }
    public void SetMadureseBible(string MadureseBible) { m_MadureseBible = MadureseBible; }
    public void SetMaithiliBible(string MaithiliBible) { m_MaithiliBible = MaithiliBible; }
    public void SetMakhuwa2021Bible(string Makhuwa2021Bible) { m_Makhuwa2021Bible = Makhuwa2021Bible; }
    public void SetMakhuwaBible(string MakhuwaBible) { m_MakhuwaBible = MakhuwaBible; }
    public void SetMakhuwaVMKBible(string MakhuwaVMKBible) { m_MakhuwaVMKBible = MakhuwaVMKBible; }
    public void SetMakondeBible(string MakondeBible) { m_MakondeBible = MakondeBible; }
    public void SetMakondeShiBible(string MakondeShiBible) { m_MakondeShiBible = MakondeShiBible; }
    public void SetMalagasy1865Bible(string Malagasy1865Bible) { m_Malagasy1865Bible = Malagasy1865Bible; }
    public void SetMalagasy2003Bible(string Malagasy2003Bible) { m_Malagasy2003Bible = Malagasy2003Bible; }
    public void SetMalagasy2004Bible(string Malagasy2004Bible) { m_Malagasy2004Bible = Malagasy2004Bible; }
    public void SetMalagasy2011Bible(string Malagasy2011Bible) { m_Malagasy2011Bible = Malagasy2011Bible; }
    public void SetMalagasyBible(string MalagasyBible) { m_MalagasyBible = MalagasyBible; }
    public void SetMalagasyMRVBible(string MalagasyMRVBible) { m_MalagasyMRVBible = MalagasyMRVBible; }
    public void SetMalayalam1910Bible(string Malayalam1910Bible) { m_Malayalam1910Bible = Malayalam1910Bible; }
    public void SetMalayalam2013Bible(string Malayalam2013Bible) { m_Malayalam2013Bible = Malayalam2013Bible; }
    public void SetMalayalamBCSBible(string MalayalamBCSBible) { m_MalayalamBCSBible = MalayalamBCSBible; }
    public void SetMalayalamBible(string MalayalamBible) { m_MalayalamBible = MalayalamBible; }
    public void SetMalayalamBSIBible(string MalayalamBSIBible) { m_MalayalamBSIBible = MalayalamBSIBible; }
    public void SetMalayalamCVBible(string MalayalamCVBible) { m_MalayalamCVBible = MalayalamCVBible; }
    public void SetMalayalamMalovBible(string MalayalamMalovBible) { m_MalayalamMalovBible = MalayalamMalovBible; }
    public void SetMalayalamWBTCBible(string MalayalamWBTCBible) { m_MalayalamWBTCBible = MalayalamWBTCBible; }
    public void SetMalaysian1996Bible(string Malaysian1996Bible) { m_Malaysian1996Bible = Malaysian1996Bible; }
    public void SetMalaysian2017Bible(string Malaysian2017Bible) { m_Malaysian2017Bible = Malaysian2017Bible; }
    public void SetMalaysian2020Bible(string Malaysian2020Bible) { m_Malaysian2020Bible = Malaysian2020Bible; }
    public void SetMalaysianBible(string MalaysianBible) { m_MalaysianBible = MalaysianBible; }
    public void SetMaori2012Bible(string Maori2012Bible) { m_Maori2012Bible = Maori2012Bible; }
    public void SetMaoriBible(string MaoriBible) { m_MaoriBible = MaoriBible; }
    public void SetMarathi2015Bible(string Marathi2015Bible) { m_Marathi2015Bible = Marathi2015Bible; }
    public void SetMarathiBible(string MarathiBible) { m_MarathiBible = MarathiBible; }
    public void SetMarathiBSIBible(string MarathiBSIBible) { m_MarathiBSIBible = MarathiBSIBible; }
    public void SetMarathiIRVMARBible(string MarathiIRVMARBible) { m_MarathiIRVMARBible = MarathiIRVMARBible; }
    public void SetMarathiMRCVBible(string MarathiMRCVBible) { m_MarathiMRCVBible = MarathiMRCVBible; }
    public void SetMarwariBible(string MarwariBible) { m_MarwariBible = MarwariBible; }
    public void SetMazanderaniGMBBible(string MazanderaniGMBBible) { m_MazanderaniGMBBible = MazanderaniGMBBible; }
    public void SetMazanderaniBible(string MazanderaniBible) { m_MazanderaniBible = MazanderaniBible; }
    public void SetMazanderaniWMBBible(string MazanderaniWMBBible) { m_MazanderaniWMBBible = MazanderaniWMBBible; }
    public void SetMeiteiBible(string MeiteiBible) { m_MeiteiBible = MeiteiBible; }
    public void SetMendeBible(string MendeBible) { m_MendeBible = MendeBible; }
    public void SetMewariBible(string MewariBible) { m_MewariBible = MewariBible; }
    public void SetMizoBible(string MizoBible) { m_MizoBible = MizoBible; }
    public void SetMizoCLBSIBible(string MizoCLBSIBible) { m_MizoCLBSIBible = MizoCLBSIBible; }
    public void SetMizoOVBSIBible(string MizoOVBSIBible) { m_MizoOVBSIBible = MizoOVBSIBible; }
    public void SetMobaBible(string MobaBible) { m_MobaBible = MobaBible; }
    public void SetMoldovianCyrillicBible(string MoldovianCyrillicBible) { m_MoldovianCyrillicBible = MoldovianCyrillicBible; }
    public void SetMoldovianLatinBible(string MoldovianLatinBible) { m_MoldovianLatinBible = MoldovianLatinBible; }
    public void SetMongolian2004Bible(string Mongolian2004Bible) { m_Mongolian2004Bible = Mongolian2004Bible; }
    public void SetMongolian2013Bible(string Mongolian2013Bible) { m_Mongolian2013Bible = Mongolian2013Bible; }
    public void SetMorisyen2021Bible(string Morisyen2021Bible) { m_Morisyen2021Bible = Morisyen2021Bible; }
    public void SetMorisyenBible(string MorisyenBible) { m_MorisyenBible = MorisyenBible; }
    public void SetMossi2014Bible(string Mossi2014Bible) { m_Mossi2014Bible = Mossi2014Bible; }
    public void SetMossiSBBible(string MossiSBBible) { m_MossiSBBible = MossiSBBible; }
    public void SetMossiSSDCBible(string MossiSSDCBible) { m_MossiSSDCBible = MossiSSDCBible; }
    public void SetMunda2020Bible(string Munda2020Bible) { m_Munda2020Bible = Munda2020Bible; }
    public void SetMundaBible(string MundaBible) { m_MundaBible = MundaBible; }
    public void SetNahuatl2012Bible(string Nahuatl2012Bible) { m_Nahuatl2012Bible = Nahuatl2012Bible; }
    public void SetNahuatl2017Bible(string Nahuatl2017Bible) { m_Nahuatl2017Bible = Nahuatl2017Bible; }
    public void SetNahuatlBible(string NahuatlBible) { m_NahuatlBible = NahuatlBible; }
    public void SetNahuatlGUBible(string NahuatlGUBible) { m_NahuatlGUBible = NahuatlGUBible; }
    public void SetNahuatlNHEBible(string NahuatlNHEBible) { m_NahuatlNHEBible = NahuatlNHEBible; }
    public void SetNdau2023Bible(string Ndau2023Bible) { m_Ndau2023Bible = Ndau2023Bible; }
    public void SetNdauBible(string NdauBible) { m_NdauBible = NdauBible; }
    public void SetNdebele2002Bible(string Ndebele2002Bible) { m_Ndebele2002Bible = Ndebele2002Bible; }
    public void SetNdebele2003Bible(string Ndebele2003Bible) { m_Ndebele2003Bible = Ndebele2003Bible; }
    public void SetNdebele2012Bible(string Ndebele2012Bible) { m_Ndebele2012Bible = Ndebele2012Bible; }
    public void SetNdebeleBible(string NdebeleBible) { m_NdebeleBible = NdebeleBible; }
    public void SetNepali2008Bible(string Nepali2008Bible) { m_Nepali2008Bible = Nepali2008Bible; }
    public void SetNepali2012Bible(string Nepali2012Bible) { m_Nepali2012Bible = Nepali2012Bible; }
    public void SetNepali2021Bible(string Nepali2021Bible) { m_Nepali2021Bible = Nepali2021Bible; }
    public void SetNepaliBible(string NepaliBible) { m_NepaliBible = NepaliBible; }
    public void SetNepaliTamangBible(string NepaliTamangBible) { m_NepaliTamangBible = NepaliTamangBible; }
    public void SetNigerianPidginBible(string NigerianPidginBible) { m_NigerianPidginBible = NigerianPidginBible; }
    public void SetNorwegian1921Bible(string Norwegian1921Bible) { m_Norwegian1921Bible = Norwegian1921Bible; }
    public void SetNorwegian1938Bible(string Norwegian1938Bible) { m_Norwegian1938Bible = Norwegian1938Bible; }
    public void SetNorwegian1978Bible(string Norwegian1978Bible) { m_Norwegian1978Bible = Norwegian1978Bible; }
    public void SetNorwegian2007Bible(string Norwegian2007Bible) { m_Norwegian2007Bible = Norwegian2007Bible; }
    public void SetNorwegian2011Bible(string Norwegian2011Bible) { m_Norwegian2011Bible = Norwegian2011Bible; }
    public void SetNorwegian2018Bible(string Norwegian2018Bible) { m_Norwegian2018Bible = Norwegian2018Bible; }
    public void SetNorwegianBGOBible(string NorwegianBGOBible) { m_NorwegianBGOBible = NorwegianBGOBible; }
    public void SetNorwegianBIBEL1978Bible(string NorwegianBIBEL1978Bible) { m_NorwegianBIBEL1978Bible = NorwegianBIBEL1978Bible; }
    public void SetNorwegianBible(string NorwegianBible) { m_NorwegianBible = NorwegianBible; }
    public void SetNorwegianELBBible(string NorwegianELBBible) { m_NorwegianELBBible = NorwegianELBBible; }
    public void SetNorwegianN78BMBible(string NorwegianN78BMBible) { m_NorwegianN78BMBible = NorwegianN78BMBible; }
    public void SetNorwegianN78NNBible(string NorwegianN78NNBible) { m_NorwegianN78NNBible = NorwegianN78NNBible; }
    public void SetNorwegianNY2011Bible(string NorwegianNY2011Bible) { m_NorwegianNY2011Bible = NorwegianNY2011Bible; }
    public void SetNuerBible(string NuerBible) { m_NuerBible = NuerBible; }
    public void SetNyankole1964Bible(string Nyankole1964Bible) { m_Nyankole1964Bible = Nyankole1964Bible; }
    public void SetNyankoleBible(string NyankoleBible) { m_NyankoleBible = NyankoleBible; }
    public void SetOdia2024Bible(string Odia2024Bible) { m_Odia2024Bible = Odia2024Bible; }
    public void SetOdiaBible(string OdiaBible) { m_OdiaBible = OdiaBible; }
    public void SetOdiaBSIBible(string OdiaBSIBible) { m_OdiaBSIBible = OdiaBSIBible; }
    public void SetOdiaERVBible(string OdiaERVBible) { m_OdiaERVBible = OdiaERVBible; }
    public void SetOdiaIRV2017Bible(string OdiaIRV2017Bible) { m_OdiaIRV2017Bible = OdiaIRV2017Bible; }
    public void SetOdiaIRVBible(string OdiaIRVBible) { m_OdiaIRVBible = OdiaIRVBible; }
    public void SetOdiaOROVBible(string OdiaOROVBible) { m_OdiaOROVBible = OdiaOROVBible; }
    public void SetOriginalGreekBible(string OriginalGreekBible) { m_OriginalGreekBible = OriginalGreekBible; }
    public void SetOriginalHebrewBible(string OriginalHebrewBible) { m_OriginalHebrewBible = OriginalHebrewBible; }
    public void SetOromoGUJBible(string OromoGUJBible) { m_OromoGUJBible = OromoGUJBible; }
    public void SetOromoGujiBible(string OromoGujiBible) { m_OromoGujiBible = OromoGujiBible; }
    public void SetOromoKakuuHaaraakaBible(string OromoKakuuHaaraakaBible) { m_OromoKakuuHaaraakaBible = OromoKakuuHaaraakaBible; }
    public void SetOromoKitaabaWaaqaBible(string OromoKitaabaWaaqaBible) { m_OromoKitaabaWaaqaBible = OromoKitaabaWaaqaBible; }
    public void SetOromoKitaabaWoyyuuBible(string OromoKitaabaWoyyuuBible) { m_OromoKitaabaWoyyuuBible = OromoKitaabaWoyyuuBible; }
    public void SetOromoWaadaaHaarawaBible(string OromoWaadaaHaarawaBible) { m_OromoWaadaaHaarawaBible = OromoWaadaaHaarawaBible; }
    public void SetOromoWaadaaLammataaBible(string OromoWaadaaLammataaBible) { m_OromoWaadaaLammataaBible = OromoWaadaaLammataaBible; }
    public void SetPampangaBible(string PampangaBible) { m_PampangaBible = PampangaBible; }
    public void SetPapuaNewGuineaBible(string PapuaNewGuineaBible) { m_PapuaNewGuineaBible = PapuaNewGuineaBible; }
    public void SetPapuaNewGuineaTokPisinBible(string PapuaNewGuineaTokPisinBible) { m_PapuaNewGuineaTokPisinBible = PapuaNewGuineaTokPisinBible; }
    public void SetPashto2019Bible(string Pashto2019Bible) { m_Pashto2019Bible = Pashto2019Bible; }
    public void SetPashto2023Bible(string Pashto2023Bible) { m_Pashto2023Bible = Pashto2023Bible; }
    public void SetPashtoBible(string PashtoBible) { m_PashtoBible = PashtoBible; }
    public void SetPersian2005Bible(string Persian2005Bible) { m_Persian2005Bible = Persian2005Bible; }
    public void SetPersian2014Bible(string Persian2014Bible) { m_Persian2014Bible = Persian2014Bible; }
    public void SetPersianBible(string PersianBible) { m_PersianBible = PersianBible; }
    public void SetPersianDariBible(string PersianDariBible) { m_PersianDariBible = PersianDariBible; }
    public void SetPersianTPVBible(string PersianTPVBible) { m_PersianTPVBible = PersianTPVBible; }
    public void SetPolish2016Bible(string Polish2016Bible) { m_Polish2016Bible = Polish2016Bible; }
    public void SetPolish2018Bible(string Polish2018Bible) { m_Polish2018Bible = Polish2018Bible; }
    public void SetPolishBible(string PolishBible) { m_PolishBible = PolishBible; }
    public void SetPolishGdansk2017Bible(string PolishGdansk2017Bible) { m_PolishGdansk2017Bible = PolishGdansk2017Bible; }
    public void SetPolishGdanskBible(string PolishGdanskBible) { m_PolishGdanskBible = PolishGdanskBible; }
    public void SetPolishNBGBible(string PolishNBGBible) { m_PolishNBGBible = PolishNBGBible; }
    public void SetPolishNPDBible(string PolishNPDBible) { m_PolishNPDBible = PolishNPDBible; }
    public void SetPolishSNPD4Bible(string PolishSNPD4Bible) { m_PolishSNPD4Bible = PolishSNPD4Bible; }
    public void SetPortuguese1969Bible(string Portuguese1969Bible) { m_Portuguese1969Bible = Portuguese1969Bible; }
    public void SetPortugueseA21Bible(string PortugueseA21Bible) { m_PortugueseA21Bible = PortugueseA21Bible; }
    public void SetPortugueseAlmeida1628Bible(string PortugueseAlmeida1628Bible) { m_PortugueseAlmeida1628Bible = PortugueseAlmeida1628Bible; }
    public void SetPortugueseAlmeida1753Bible(string PortugueseAlmeida1753Bible) { m_PortugueseAlmeida1753Bible = PortugueseAlmeida1753Bible; }
    public void SetPortugueseARCBible(string PortugueseARCBible) { m_PortugueseARCBible = PortugueseARCBible; }
    public void SetPortugueseBible(string PortugueseBible) { m_PortugueseBible = PortugueseBible; }
    public void SetPortugueseBLTBible(string PortugueseBLTBible) { m_PortugueseBLTBible = PortugueseBLTBible; }
    public void SetPortugueseBPT09Bible(string PortugueseBPT09Bible) { m_PortugueseBPT09Bible = PortugueseBPT09Bible; }
    public void SetPortugueseCAPBible(string PortugueseCAPBible) { m_PortugueseCAPBible = PortugueseCAPBible; }
    public void SetPortugueseMZNVIBible(string PortugueseMZNVIBible) { m_PortugueseMZNVIBible = PortugueseMZNVIBible; }
    public void SetPortugueseNAABible(string PortugueseNAABible) { m_PortugueseNAABible = PortugueseNAABible; }
    public void SetPortugueseNBV2007Bible(string PortugueseNBV2007Bible) { m_PortugueseNBV2007Bible = PortugueseNBV2007Bible; }
    public void SetPortugueseNTLHBible(string PortugueseNTLHBible) { m_PortugueseNTLHBible = PortugueseNTLHBible; }
    public void SetPortugueseNVI2023Bible(string PortugueseNVI2023Bible) { m_PortugueseNVI2023Bible = PortugueseNVI2023Bible; }
    public void SetPortugueseNVIBible(string PortugueseNVIBible) { m_PortugueseNVIBible = PortugueseNVIBible; }
    public void SetPortugueseNVTBible(string PortugueseNVTBible) { m_PortugueseNVTBible = PortugueseNVTBible; }
    public void SetPortugueseOLBible(string PortugueseOLBible) { m_PortugueseOLBible = PortugueseOLBible; }
    public void SetPortugueseTBBible(string PortugueseTBBible) { m_PortugueseTBBible = PortugueseTBBible; }
    public void SetPortugueseVFLBible(string PortugueseVFLBible) { m_PortugueseVFLBible = PortugueseVFLBible; }
    public void SetPularBible(string PularBible) { m_PularBible = PularBible; }
    public void SetPunjabi2016Bible(string Punjabi2016Bible) { m_Punjabi2016Bible = Punjabi2016Bible; }
    public void SetPunjabi2020Bible(string Punjabi2020Bible) { m_Punjabi2020Bible = Punjabi2020Bible; }
    public void SetPunjabi2021Bible(string Punjabi2021Bible) { m_Punjabi2021Bible = Punjabi2021Bible; }
    public void SetPunjabi2022Bible(string Punjabi2022Bible) { m_Punjabi2022Bible = Punjabi2022Bible; }
    public void SetPunjabi2023Bible(string Punjabi2023Bible) { m_Punjabi2023Bible = Punjabi2023Bible; }
    public void SetPunjabiBible(string PunjabiBible) { m_PunjabiBible = PunjabiBible; }
    public void SetPunjabiERVBible(string PunjabiERVBible) { m_PunjabiERVBible = PunjabiERVBible; }
    public void SetPunjabiIRVBible(string PunjabiIRVBible) { m_PunjabiIRVBible = PunjabiIRVBible; }
    public void SetQeqchiBible(string QeqchiBible) { m_QeqchiBible = QeqchiBible; }
    public void SetQuechuan2010Bible(string Quechuan2010Bible) { m_Quechuan2010Bible = Quechuan2010Bible; }
    public void SetQuechuanBible(string QuechuanBible) { m_QuechuanBible = QuechuanBible; }
    public void SetQuechuanQVBMBible(string QuechuanQVBMBible) { m_QuechuanQVBMBible = QuechuanQVBMBible; }
    public void SetQuechuanQVSBible(string QuechuanQVSBible) { m_QuechuanQVSBible = QuechuanQVSBible; }
    public void SetQuechuanQVWBible(string QuechuanQVWBible) { m_QuechuanQVWBible = QuechuanQVWBible; }
    public void SetQuechuanQXOBible(string QuechuanQXOBible) { m_QuechuanQXOBible = QuechuanQXOBible; }
    public void SetRomani2004Bible(string Romani2004Bible) { m_Romani2004Bible = Romani2004Bible; }
    public void SetRomani2007Bible(string Romani2007Bible) { m_Romani2007Bible = Romani2007Bible; }
    public void SetRomanian1928Bible(string Romanian1928Bible) { m_Romanian1928Bible = Romanian1928Bible; }
    public void SetRomanian1931Bible(string Romanian1931Bible) { m_Romanian1931Bible = Romanian1931Bible; }
    public void SetRomanian2009Bible(string Romanian2009Bible) { m_Romanian2009Bible = Romanian2009Bible; }
    public void SetRomanian2014Bible(string Romanian2014Bible) { m_Romanian2014Bible = Romanian2014Bible; }
    public void SetRomanian2015Bible(string Romanian2015Bible) { m_Romanian2015Bible = Romanian2015Bible; }
    public void SetRomanian2018Bible(string Romanian2018Bible) { m_Romanian2018Bible = Romanian2018Bible; }
    public void SetRomanian2020Bible(string Romanian2020Bible) { m_Romanian2020Bible = Romanian2020Bible; }
    public void SetRomanian2021Bible(string Romanian2021Bible) { m_Romanian2021Bible = Romanian2021Bible; }
    public void SetRomanian2022Bible(string Romanian2022Bible) { m_Romanian2022Bible = Romanian2022Bible; }
    public void SetRomanian2023Bible(string Romanian2023Bible) { m_Romanian2023Bible = Romanian2023Bible; }
    public void SetRomanianBDKBible(string RomanianBDKBible) { m_RomanianBDKBible = RomanianBDKBible; }
    public void SetRomanianBible(string RomanianBible) { m_RomanianBible = RomanianBible; }
    public void SetRomanianSBIRBible(string RomanianSBIRBible) { m_RomanianSBIRBible = RomanianSBIRBible; }
    public void SetRomaniBACHROBible(string RomaniBACHROBible) { m_RomaniBACHROBible = RomaniBACHROBible; }
    public void SetRomaniBaltic2019Bible(string RomaniBaltic2019Bible) { m_RomaniBaltic2019Bible = RomaniBaltic2019Bible; }
    public void SetRomaniBalticLT2019Bible(string RomaniBalticLT2019Bible) { m_RomaniBalticLT2019Bible = RomaniBalticLT2019Bible; }
    public void SetRomaniBible(string RomaniBible) { m_RomaniBible = RomaniBible; }
    public void SetRomaniCHERGASHBible(string RomaniCHERGASHBible) { m_RomaniCHERGASHBible = RomaniCHERGASHBible; }
    public void SetRomaniGSPBible(string RomaniGSPBible) { m_RomaniGSPBible = RomaniGSPBible; }
    public void SetRomaniKALD2004Bible(string RomaniKALD2004Bible) { m_RomaniKALD2004Bible = RomaniKALD2004Bible; }
    public void SetRomaniKALD2020Bible(string RomaniKALD2020Bible) { m_RomaniKALD2020Bible = RomaniKALD2020Bible; }
    public void SetRomaniRMCBible(string RomaniRMCBible) { m_RomaniRMCBible = RomaniRMCBible; }
    public void SetRomaniROM07Bible(string RomaniROM07Bible) { m_RomaniROM07Bible = RomaniROM07Bible; }
    public void SetRomaniROM6Bible(string RomaniROM6Bible) { m_RomaniROM6Bible = RomaniROM6Bible; }
    public void SetRomaniSERBible(string RomaniSERBible) { m_RomaniSERBible = RomaniSERBible; }
    public void SetRomaniSINT2024Bible(string RomaniSINT2024Bible) { m_RomaniSINT2024Bible = RomaniSINT2024Bible; }
    public void SetRussian2012Bible(string Russian2012Bible) { m_Russian2012Bible = Russian2012Bible; }
    public void SetRussianAGPBible(string RussianAGPBible) { m_RussianAGPBible = RussianAGPBible; }
    public void SetRussianBTI2015Bible(string RussianBTI2015Bible) { m_RussianBTI2015Bible = RussianBTI2015Bible; }
    public void SetRussianCARSABible(string RussianCARSABible) { m_RussianCARSABible = RussianCARSABible; }
    public void SetRussianCARSBible(string RussianCARSBible) { m_RussianCARSBible = RussianCARSBible; }
    public void SetRussianCASBible(string RussianCASBible) { m_RussianCASBible = RussianCASBible; }
    public void SetRussianCSLAVBible(string RussianCSLAVBible) { m_RussianCSLAVBible = RussianCSLAVBible; }
    public void SetRussianJewishBible(string RussianJewishBible) { m_RussianJewishBible = RussianJewishBible; }
    public void SetRussianJubileeBible(string RussianJubileeBible) { m_RussianJubileeBible = RussianJubileeBible; }
    public void SetRussianMengeBible(string RussianMengeBible) { m_RussianMengeBible = RussianMengeBible; }
    public void SetRussianNRTBible(string RussianNRTBible) { m_RussianNRTBible = RussianNRTBible; }
    public void SetRussianReceptusBible(string RussianReceptusBible) { m_RussianReceptusBible = RussianReceptusBible; }
    public void SetRussianRSPBible(string RussianRSPBible) { m_RussianRSPBible = RussianRSPBible; }
    public void SetRussianRSTBible(string RussianRSTBible) { m_RussianRSTBible = RussianRSTBible; }
    public void SetRussianSlovoBible(string RussianSlovoBible) { m_RussianSlovoBible = RussianSlovoBible; }
    public void SetRussianSynodalBible(string RussianSynodalBible) { m_RussianSynodalBible = RussianSynodalBible; }
    public void SetRussianWBTCBible(string RussianWBTCBible) { m_RussianWBTCBible = RussianWBTCBible; }
    public void SetSadriBible(string SadriBible) { m_SadriBible = SadriBible; }
    public void SetSanskritDevanagariBible(string SanskritDevanagariBible) { m_SanskritDevanagariBible = SanskritDevanagariBible; }
    public void SetSantaliBangladeshBible(string SantaliBangladeshBible) { m_SantaliBangladeshBible = SantaliBangladeshBible; }
    public void SetSantaliCommonBible(string SantaliCommonBible) { m_SantaliCommonBible = SantaliCommonBible; }
    public void SetSasakBible(string SasakBible) { m_SasakBible = SasakBible; }
    public void SetSena2014Bible(string Sena2014Bible) { m_Sena2014Bible = Sena2014Bible; }
    public void SetSenaBible(string SenaBible) { m_SenaBible = SenaBible; }
    public void SetSenaMalawiBible(string SenaMalawiBible) { m_SenaMalawiBible = SenaMalawiBible; }
    public void SetSeraikiBible(string SeraikiBible) { m_SeraikiBible = SeraikiBible; }
    public void SetSerbianBible(string SerbianBible) { m_SerbianBible = SerbianBible; }
    public void SetSerbianCNZBible(string SerbianCNZBible) { m_SerbianCNZBible = SerbianCNZBible; }
    public void SetSerbianERVBible(string SerbianERVBible) { m_SerbianERVBible = SerbianERVBible; }
    public void SetSerbianLatinBible(string SerbianLatinBible) { m_SerbianLatinBible = SerbianLatinBible; }
    public void SetSerbianNSTBible(string SerbianNSTBible) { m_SerbianNSTBible = SerbianNSTBible; }
    public void SetSerbianNSTLBible(string SerbianNSTLBible) { m_SerbianNSTLBible = SerbianNSTLBible; }
    public void SetSerbianSDSBible(string SerbianSDSBible) { m_SerbianSDSBible = SerbianSDSBible; }
    public void SetShanBible(string ShanBible) { m_ShanBible = ShanBible; }
    public void SetShanNCLBible(string ShanNCLBible) { m_ShanNCLBible = ShanNCLBible; }
    public void SetShekhawatiBible(string ShekhawatiBible) { m_ShekhawatiBible = ShekhawatiBible; }
    public void SetShillukBible(string ShillukBible) { m_ShillukBible = ShillukBible; }
    public void SetShona1949Bible(string Shona1949Bible) { m_Shona1949Bible = Shona1949Bible; }
    public void SetShona2002Bible(string Shona2002Bible) { m_Shona2002Bible = Shona2002Bible; }
    public void SetShonaBDSCBible(string ShonaBDSCBible) { m_ShonaBDSCBible = ShonaBDSCBible; }
    public void SetShonaBible(string ShonaBible) { m_ShonaBible = ShonaBible; }
    public void SetShonaSCLBBible(string ShonaSCLBBible) { m_ShonaSCLBBible = ShonaSCLBBible; }
    public void SetShonaSUBBible(string ShonaSUBBible) { m_ShonaSUBBible = ShonaSUBBible; }
    public void SetSidamoBible(string SidamoBible) { m_SidamoBible = SidamoBible; }
    public void SetSindhiBible(string SindhiBible) { m_SindhiBible = SindhiBible; }
    public void SetSindhiCommonBible(string SindhiCommonBible) { m_SindhiCommonBible = SindhiCommonBible; }
    public void SetSindhiHinduBible(string SindhiHinduBible) { m_SindhiHinduBible = SindhiHinduBible; }
    public void SetSindhiMuslimBible(string SindhiMuslimBible) { m_SindhiMuslimBible = SindhiMuslimBible; }
    public void SetSinhalaNRSVBible(string SinhalaNRSVBible) { m_SinhalaNRSVBible = SinhalaNRSVBible; }
    public void SetSinhalaSCVBible(string SinhalaSCVBible) { m_SinhalaSCVBible = SinhalaSCVBible; }
    public void SetSinhalaSNRVBible(string SinhalaSNRVBible) { m_SinhalaSNRVBible = SinhalaSNRVBible; }
    public void SetSinhalaSROVBible(string SinhalaSROVBible) { m_SinhalaSROVBible = SinhalaSROVBible; }
    public void SetSiswatiBible(string SiswatiBible) { m_SiswatiBible = SiswatiBible; }
    public void SetSlovakian2015Bible(string Slovakian2015Bible) { m_Slovakian2015Bible = Slovakian2015Bible; }
    public void SetSlovakian2017Bible(string Slovakian2017Bible) { m_Slovakian2017Bible = Slovakian2017Bible; }
    public void SetSlovakianBible(string SlovakianBible) { m_SlovakianBible = SlovakianBible; }
    public void SetSlovakianNPK2023Bible(string SlovakianNPK2023Bible) { m_SlovakianNPK2023Bible = SlovakianNPK2023Bible; }
    public void SetSlovakianNPKBible(string SlovakianNPKBible) { m_SlovakianNPKBible = SlovakianNPKBible; }
    public void SetSlovakianRomaniBible(string SlovakianRomaniBible) { m_SlovakianRomaniBible = SlovakianRomaniBible; }
    public void SetSlovakianSEBBible(string SlovakianSEBBible) { m_SlovakianSEBBible = SlovakianSEBBible; }
    public void SetSlovakianSLBBible(string SlovakianSLBBible) { m_SlovakianSLBBible = SlovakianSLBBible; }
    public void SetSlovakianSSVBible(string SlovakianSSVBible) { m_SlovakianSSVBible = SlovakianSSVBible; }
    public void SetSlovenian1584Bible(string Slovenian1584Bible) { m_Slovenian1584Bible = Slovenian1584Bible; }
    public void SetSlovenian1882Bible(string Slovenian1882Bible) { m_Slovenian1882Bible = Slovenian1882Bible; }
    public void SetSlovenian1928Bible(string Slovenian1928Bible) { m_Slovenian1928Bible = Slovenian1928Bible; }
    public void SetSlovenian1990Bible(string Slovenian1990Bible) { m_Slovenian1990Bible = Slovenian1990Bible; }
    public void SetSlovenian2014Bible(string Slovenian2014Bible) { m_Slovenian2014Bible = Slovenian2014Bible; }
    public void SetSlovenianBible(string SlovenianBible) { m_SlovenianBible = SlovenianBible; }
    public void SetSlovenianEKUBible(string SlovenianEKUBible) { m_SlovenianEKUBible = SlovenianEKUBible; }
    public void SetSlovenianSSPBible(string SlovenianSSPBible) { m_SlovenianSSPBible = SlovenianSSPBible; }
    public void SetSogaBible(string SogaBible) { m_SogaBible = SogaBible; }
    public void SetSomalian2018Bible(string Somalian2018Bible) { m_Somalian2018Bible = Somalian2018Bible; }
    public void SetSomalian2024Bible(string Somalian2024Bible) { m_Somalian2024Bible = Somalian2024Bible; }
    public void SetSomalianBible(string SomalianBible) { m_SomalianBible = SomalianBible; }
    public void SetSongeBible(string SongeBible) { m_SongeBible = SongeBible; }
    public void SetSotho1951Bible(string Sotho1951Bible) { m_Sotho1951Bible = Sotho1951Bible; }
    public void SetSotho1989Bible(string Sotho1989Bible) { m_Sotho1989Bible = Sotho1989Bible; }
    public void SetSotho2000Bible(string Sotho2000Bible) { m_Sotho2000Bible = Sotho2000Bible; }
    public void SetSothoBible(string SothoBible) { m_SothoBible = SothoBible; }
    public void SetSpanish1569Bible(string Spanish1569Bible) { m_Spanish1569Bible = Spanish1569Bible; }
    public void SetSpanish1858Bible(string Spanish1858Bible) { m_Spanish1858Bible = Spanish1858Bible; }
    public void SetSpanish1989Bible(string Spanish1989Bible) { m_Spanish1989Bible = Spanish1989Bible; }
    public void SetSpanishBDOBible(string SpanishBDOBible) { m_SpanishBDOBible = SpanishBDOBible; }
    public void SetSpanishBHTIBible(string SpanishBHTIBible) { m_SpanishBHTIBible = SpanishBHTIBible; }
    public void SetSpanishBible(string SpanishBible) { m_SpanishBible = SpanishBible; }
    public void SetSpanishBLPBible(string SpanishBLPBible) { m_SpanishBLPBible = SpanishBLPBible; }
    public void SetSpanishBLPHBible(string SpanishBLPHBible) { m_SpanishBLPHBible = SpanishBLPHBible; }
    public void SetSpanishBTIBible(string SpanishBTIBible) { m_SpanishBTIBible = SpanishBTIBible; }
    public void SetSpanishBTXBible(string SpanishBTXBible) { m_SpanishBTXBible = SpanishBTXBible; }
    public void SetSpanishDHHBible(string SpanishDHHBible) { m_SpanishDHHBible = SpanishDHHBible; }
    public void SetSpanishJBSBible(string SpanishJBSBible) { m_SpanishJBSBible = SpanishJBSBible; }
    public void SetSpanishLBLABible(string SpanishLBLABible) { m_SpanishLBLABible = SpanishLBLABible; }
    public void SetSpanishNBLABible(string SpanishNBLABible) { m_SpanishNBLABible = SpanishNBLABible; }
    public void SetSpanishNBVBible(string SpanishNBVBible) { m_SpanishNBVBible = SpanishNBVBible; }
    public void SetSpanishNTBIZBible(string SpanishNTBIZBible) { m_SpanishNTBIZBible = SpanishNTBIZBible; }
    public void SetSpanishNTVBible(string SpanishNTVBible) { m_SpanishNTVBible = SpanishNTVBible; }
    public void SetSpanishNVIBible(string SpanishNVIBible) { m_SpanishNVIBible = SpanishNVIBible; }
    public void SetSpanishNVISBible(string SpanishNVISBible) { m_SpanishNVISBible = SpanishNVISBible; }
    public void SetSpanishPDTBible(string SpanishPDTBible) { m_SpanishPDTBible = SpanishPDTBible; }
    public void SetSpanishRevisedRVR1960Bible(string SpanishRevisedRVR1960Bible) { m_SpanishRevisedRVR1960Bible = SpanishRevisedRVR1960Bible; }
    public void SetSpanishRV2020Bible(string SpanishRV2020Bible) { m_SpanishRV2020Bible = SpanishRV2020Bible; }
    public void SetSpanishRVA2015Bible(string SpanishRVA2015Bible) { m_SpanishRVA2015Bible = SpanishRVA2015Bible; }
    public void SetSpanishRVCBible(string SpanishRVCBible) { m_SpanishRVCBible = SpanishRVCBible; }
    public void SetSpanishRVESBible(string SpanishRVESBible) { m_SpanishRVESBible = SpanishRVESBible; }
    public void SetSpanishRVGBible(string SpanishRVGBible) { m_SpanishRVGBible = SpanishRVGBible; }
    public void SetSpanishRVR1960Bible(string SpanishRVR1960Bible) { m_SpanishRVR1960Bible = SpanishRVR1960Bible; }
    public void SetSpanishRVR1995Bible(string SpanishRVR1995Bible) { m_SpanishRVR1995Bible = SpanishRVR1995Bible; }
    public void SetSpanishTLABible(string SpanishTLABible) { m_SpanishTLABible = SpanishTLABible; }
    public void SetSpanishVBL2022Bible(string SpanishVBL2022Bible) { m_SpanishVBL2022Bible = SpanishVBL2022Bible; }
    public void SetSpanishVBLBible(string SpanishVBLBible) { m_SpanishVBLBible = SpanishVBLBible; }
    public void SetSukuma1960Bible(string Sukuma1960Bible) { m_Sukuma1960Bible = Sukuma1960Bible; }
    public void SetSukumaBible(string SukumaBible) { m_SukumaBible = SukumaBible; }
    public void SetSundaneseBible(string SundaneseBible) { m_SundaneseBible = SundaneseBible; }
    public void SetSwahili1850Bible(string Swahili1850Bible) { m_Swahili1850Bible = Swahili1850Bible; }
    public void SetSwahili2001Bible(string Swahili2001Bible) { m_Swahili2001Bible = Swahili2001Bible; }
    public void SetSwahili2017Bible(string Swahili2017Bible) { m_Swahili2017Bible = Swahili2017Bible; }
    public void SetSwahili2024Bible(string Swahili2024Bible) { m_Swahili2024Bible = Swahili2024Bible; }
    public void SetSwahiliBHNTLKBible(string SwahiliBHNTLKBible) { m_SwahiliBHNTLKBible = SwahiliBHNTLKBible; }
    public void SetSwahiliBible(string SwahiliBible) { m_SwahiliBible = SwahiliBible; }
    public void SetSwahiliContemporaryBible(string SwahiliContemporaryBible) { m_SwahiliContemporaryBible = SwahiliContemporaryBible; }
    public void SetSwahiliNMMBible(string SwahiliNMMBible) { m_SwahiliNMMBible = SwahiliNMMBible; }
    public void SetSwahiliRSUVDCBible(string SwahiliRSUVDCBible) { m_SwahiliRSUVDCBible = SwahiliRSUVDCBible; }
    public void SetSwahiliSCLDC10Bible(string SwahiliSCLDC10Bible) { m_SwahiliSCLDC10Bible = SwahiliSCLDC10Bible; }
    public void SetSwahiliSRB37Bible(string SwahiliSRB37Bible) { m_SwahiliSRB37Bible = SwahiliSRB37Bible; }
    public void SetSwahiliSUVBible(string SwahiliSUVBible) { m_SwahiliSUVBible = SwahiliSUVBible; }
    public void SetSwahiliSWC02Bible(string SwahiliSWC02Bible) { m_SwahiliSWC02Bible = SwahiliSWC02Bible; }
    public void SetSwahiliSWZZB1921Bible(string SwahiliSWZZB1921Bible) { m_SwahiliSWZZB1921Bible = SwahiliSWZZB1921Bible; }
    public void SetSwedish1873Bible(string Swedish1873Bible) { m_Swedish1873Bible = Swedish1873Bible; }
    public void SetSwedish2000Bible(string Swedish2000Bible) { m_Swedish2000Bible = Swedish2000Bible; }
    public void SetSwedish2015Bible(string Swedish2015Bible) { m_Swedish2015Bible = Swedish2015Bible; }
    public void SetSwedish2019Bible(string Swedish2019Bible) { m_Swedish2019Bible = Swedish2019Bible; }
    public void SetSwedishBible(string SwedishBible) { m_SwedishBible = SwedishBible; }
    public void SetSwedishFolkBible(string SwedishFolkBible) { m_SwedishFolkBible = SwedishFolkBible; }
    public void SetSwedishNLBBible(string SwedishNLBBible) { m_SwedishNLBBible = SwedishNLBBible; }
    public void SetSwedishSB2016Bible(string SwedishSB2016Bible) { m_SwedishSB2016Bible = SwedishSB2016Bible; }
    public void SetSwedishSFBBible(string SwedishSFBBible) { m_SwedishSFBBible = SwedishSFBBible; }
    public void SetSylhetiBible(string SylhetiBible) { m_SylhetiBible = SylhetiBible; }
    public void SetSylhetiSYLLBible(string SylhetiSYLLBible) { m_SylhetiSYLLBible = SylhetiSYLLBible; }
    public void SetTagalog2001Bible(string Tagalog2001Bible) { m_Tagalog2001Bible = Tagalog2001Bible; }
    public void SetTagalog2005Bible(string Tagalog2005Bible) { m_Tagalog2005Bible = Tagalog2005Bible; }
    public void SetTagalog2012Bible(string Tagalog2012Bible) { m_Tagalog2012Bible = Tagalog2012Bible; }
    public void SetTagalog2015Bible(string Tagalog2015Bible) { m_Tagalog2015Bible = Tagalog2015Bible; }
    public void SetTagalogBible(string TagalogBible) { m_TagalogBible = TagalogBible; }
    public void SetTagalogRevised2005Bible(string TagalogRevised2005Bible) { m_TagalogRevised2005Bible = TagalogRevised2005Bible; }
    public void SetTagalogTLBABible(string TagalogTLBABible) { m_TagalogTLBABible = TagalogTLBABible; }
    public void SetTajik1992Bible(string Tajik1992Bible) { m_Tajik1992Bible = Tajik1992Bible; }
    public void SetTajikKMOBible(string TajikKMOBible) { m_TajikKMOBible = TajikKMOBible; }
    public void SetTajikNTBible(string TajikNTBible) { m_TajikNTBible = TajikNTBible; }
    public void SetTamasheqBible(string TamasheqBible) { m_TamasheqBible = TamasheqBible; }
    public void SetTamil2017Bible(string Tamil2017Bible) { m_Tamil2017Bible = Tamil2017Bible; }
    public void SetTamilBible(string TamilBible) { m_TamilBible = TamilBible; }
    public void SetTamilIRVBible(string TamilIRVBible) { m_TamilIRVBible = TamilIRVBible; }
    public void SetTamilRomanisedBible(string TamilRomanisedBible) { m_TamilRomanisedBible = TamilRomanisedBible; }
    public void SetTamilTCVBible(string TamilTCVBible) { m_TamilTCVBible = TamilTCVBible; }
    public void SetTamilTRVBible(string TamilTRVBible) { m_TamilTRVBible = TamilTRVBible; }
    public void SetTamilWBTCBible(string TamilWBTCBible) { m_TamilWBTCBible = TamilWBTCBible; }
    public void SetTarifitBible(string TarifitBible) { m_TarifitBible = TarifitBible; }
    public void SetTashelhaytMoroccoBible(string TashelhaytMoroccoBible) { m_TashelhaytMoroccoBible = TashelhaytMoroccoBible; }
    public void SetTatar2001Bible(string Tatar2001Bible) { m_Tatar2001Bible = Tatar2001Bible; }
    public void SetTatar2015Bible(string Tatar2015Bible) { m_Tatar2015Bible = Tatar2015Bible; }
    public void SetTatar2025Bible(string Tatar2025Bible) { m_Tatar2025Bible = Tatar2025Bible; }
    public void SetTatarRBBLBible(string TatarRBBLBible) { m_TatarRBBLBible = TatarRBBLBible; }
    public void SetTelugu2016Bible(string Telugu2016Bible) { m_Telugu2016Bible = Telugu2016Bible; }
    public void SetTelugu2019Bible(string Telugu2019Bible) { m_Telugu2019Bible = Telugu2019Bible; }
    public void SetTeluguBible(string TeluguBible) { m_TeluguBible = TeluguBible; }
    public void SetTeluguTCVBible(string TeluguTCVBible) { m_TeluguTCVBible = TeluguTCVBible; }
    public void SetTeluguWBTCBible(string TeluguWBTCBible) { m_TeluguWBTCBible = TeluguWBTCBible; }
    public void SetTeso2020Bible(string Teso2020Bible) { m_Teso2020Bible = Teso2020Bible; }
    public void SetTesoBible(string TesoBible) { m_TesoBible = TesoBible; }
    public void SetThadoBible(string ThadoBible) { m_ThadoBible = ThadoBible; }
    public void SetThai1940Bible(string Thai1940Bible) { m_Thai1940Bible = Thai1940Bible; }
    public void SetThai1971Bible(string Thai1971Bible) { m_Thai1971Bible = Thai1971Bible; }
    public void SetThaiBible(string ThaiBible) { m_ThaiBible = ThaiBible; }
    public void SetThaiERVBible(string ThaiERVBible) { m_ThaiERVBible = ThaiERVBible; }
    public void SetThaiKJVBible(string ThaiKJVBible) { m_ThaiKJVBible = ThaiKJVBible; }
    public void SetThaiNTVBible(string ThaiNTVBible) { m_ThaiNTVBible = ThaiNTVBible; }
    public void SetThaiTCVBible(string ThaiTCVBible) { m_ThaiTCVBible = ThaiTCVBible; }
    public void SetThaiTHSBible(string ThaiTHSBible) { m_ThaiTHSBible = ThaiTHSBible; }
    public void SetThaiTNCVBible(string ThaiTNCVBible) { m_ThaiTNCVBible = ThaiTNCVBible; }
    public void SetTibetianBible(string TibetianBible) { m_TibetianBible = TibetianBible; }
    public void SetTibetianCBTBible(string TibetianCBTBible) { m_TibetianCBTBible = TibetianCBTBible; }
    public void SetTivBible(string TivBible) { m_TivBible = TivBible; }
    public void SetTshiluba1996Bible(string Tshiluba1996Bible) { m_Tshiluba1996Bible = Tshiluba1996Bible; }
    public void SetTshiluba2003Bible(string Tshiluba2003Bible) { m_Tshiluba2003Bible = Tshiluba2003Bible; }
    public void SetTshivendaBible(string TshivendaBible) { m_TshivendaBible = TshivendaBible; }
    public void SetTsonga1989Bible(string Tsonga1989Bible) { m_Tsonga1989Bible = Tsonga1989Bible; }
    public void SetTsonga2014Bible(string Tsonga2014Bible) { m_Tsonga2014Bible = Tsonga2014Bible; }
    public void SetTsonga2024Bible(string Tsonga2024Bible) { m_Tsonga2024Bible = Tsonga2024Bible; }
    public void SetTsongaBible(string TsongaBible) { m_TsongaBible = TsongaBible; }
    public void SetTswana1890Bible(string Tswana1890Bible) { m_Tswana1890Bible = Tswana1890Bible; }
    public void SetTswana1970Bible(string Tswana1970Bible) { m_Tswana1970Bible = Tswana1970Bible; }
    public void SetTswana1993Bible(string Tswana1993Bible) { m_Tswana1993Bible = Tswana1993Bible; }
    public void SetTswana2024Bible(string Tswana2024Bible) { m_Tswana2024Bible = Tswana2024Bible; }
    public void SetTswanaBible(string TswanaBible) { m_TswanaBible = TswanaBible; }
    public void SetTuluBible(string TuluBible) { m_TuluBible = TuluBible; }
    public void SetTurkanaBible(string TurkanaBible) { m_TurkanaBible = TurkanaBible; }
    public void SetTurkishBible(string TurkishBible) { m_TurkishBible = TurkishBible; }
    public void SetTurkishHADIBible(string TurkishHADIBible) { m_TurkishHADIBible = TurkishHADIBible; }
    public void SetTurkishKKDEUBible(string TurkishKKDEUBible) { m_TurkishKKDEUBible = TurkishKKDEUBible; }
    public void SetTurkishKMEYABible(string TurkishKMEYABible) { m_TurkishKMEYABible = TurkishKMEYABible; }
    public void SetTurkishNTBBible(string TurkishNTBBible) { m_TurkishNTBBible = TurkishNTBBible; }
    public void SetTurkishTKKBible(string TurkishTKKBible) { m_TurkishTKKBible = TurkishTKKBible; }
    public void SetTurkishTTTBible(string TurkishTTTBible) { m_TurkishTTTBible = TurkishTTTBible; }
    public void SetTurkishYTCBible(string TurkishYTCBible) { m_TurkishYTCBible = TurkishYTCBible; }
    public void SetTurkmen2016Bible(string Turkmen2016Bible) { m_Turkmen2016Bible = Turkmen2016Bible; }
    public void SetTurkmenCyrillic2002Bible(string TurkmenCyrillic2002Bible) { m_TurkmenCyrillic2002Bible = TurkmenCyrillic2002Bible; }
    public void SetTurkmenLatin2002Bible(string TurkmenLatin2002Bible) { m_TurkmenLatin2002Bible = TurkmenLatin2002Bible; }
    public void SetTurkmenLatin2017Bible(string TurkmenLatin2017Bible) { m_TurkmenLatin2017Bible = TurkmenLatin2017Bible; }
    public void SetTwiAkuapemBible(string TwiAkuapemBible) { m_TwiAkuapemBible = TwiAkuapemBible; }
    public void SetTwiAsanteBible(string TwiAsanteBible) { m_TwiAsanteBible = TwiAsanteBible; }
    public void SetTwiDCBible(string TwiDCBible) { m_TwiDCBible = TwiDCBible; }
    public void SetTwiKronkronBible(string TwiKronkronBible) { m_TwiKronkronBible = TwiKronkronBible; }
    public void SetTwiRevisedBible(string TwiRevisedBible) { m_TwiRevisedBible = TwiRevisedBible; }
    public void SetUkrainian1903Bible(string Ukrainian1903Bible) { m_Ukrainian1903Bible = Ukrainian1903Bible; }
    public void SetUkrainian1905Bible(string Ukrainian1905Bible) { m_Ukrainian1905Bible = Ukrainian1905Bible; }
    public void SetUkrainian2004Bible(string Ukrainian2004Bible) { m_Ukrainian2004Bible = Ukrainian2004Bible; }
    public void SetUkrainian2006Bible(string Ukrainian2006Bible) { m_Ukrainian2006Bible = Ukrainian2006Bible; }
    public void SetUkrainian2011Bible(string Ukrainian2011Bible) { m_Ukrainian2011Bible = Ukrainian2011Bible; }
    public void SetUkrainian2021Bible(string Ukrainian2021Bible) { m_Ukrainian2021Bible = Ukrainian2021Bible; }
    public void SetUkrainian2022Bible(string Ukrainian2022Bible) { m_Ukrainian2022Bible = Ukrainian2022Bible; }
    public void SetUkrainianBible(string UkrainianBible) { m_UkrainianBible = UkrainianBible; }
    public void SetUkrainianHOMBible(string UkrainianHOMBible) { m_UkrainianHOMBible = UkrainianHOMBible; }
    public void SetUkrainianTUBBible(string UkrainianTUBBible) { m_UkrainianTUBBible = UkrainianTUBBible; }
    public void SetUkrainianUKDERBible(string UkrainianUKDERBible) { m_UkrainianUKDERBible = UkrainianUKDERBible; }
    public void SetUkrainianUMTBible(string UkrainianUMTBible) { m_UkrainianUMTBible = UkrainianUMTBible; }
    public void SetUmbunduBible(string UmbunduBible) { m_UmbunduBible = UmbunduBible; }
    public void SetUrdu2017Bible(string Urdu2017Bible) { m_Urdu2017Bible = Urdu2017Bible; }
    public void SetUrduBible(string UrduBible) { m_UrduBible = UrduBible; }
    public void SetUrduDGVBible(string UrduDGVBible) { m_UrduDGVBible = UrduDGVBible; }
    public void SetUrduGVRBible(string UrduGVRBible) { m_UrduGVRBible = UrduGVRBible; }
    public void SetUrduIRVURDBible(string UrduIRVURDBible) { m_UrduIRVURDBible = UrduIRVURDBible; }
    public void SetUrduUCVBible(string UrduUCVBible) { m_UrduUCVBible = UrduUCVBible; }
    public void SetUrduUCVDBible(string UrduUCVDBible) { m_UrduUCVDBible = UrduUCVDBible; }
    public void SetUrduUGVBible(string UrduUGVBible) { m_UrduUGVBible = UrduUGVBible; }
    public void SetUrduURDBible(string UrduURDBible) { m_UrduURDBible = UrduURDBible; }
    public void SetUrduURDGVHBible(string UrduURDGVHBible) { m_UrduURDGVHBible = UrduURDGVHBible; }
    public void SetUrduURDR55Bible(string UrduURDR55Bible) { m_UrduURDR55Bible = UrduURDR55Bible; }
    public void SetUyghurArabicBible(string UyghurArabicBible) { m_UyghurArabicBible = UyghurArabicBible; }
    public void SetUyghurCyrillicBible(string UyghurCyrillicBible) { m_UyghurCyrillicBible = UyghurCyrillicBible; }
    public void SetUyghurLatinBible(string UyghurLatinBible) { m_UyghurLatinBible = UyghurLatinBible; }
    public void SetUzbekUZBBible(string UzbekUZBBible) { m_UzbekUZBBible = UzbekUZBBible; }
    public void SetUzbekUZCBible(string UzbekUZCBible) { m_UzbekUZCBible = UzbekUZCBible; }
    public void SetUzbekUZLBCBible(string UzbekUZLBCBible) { m_UzbekUZLBCBible = UzbekUZLBCBible; }
    public void SetVietnamese1994Bible(string Vietnamese1994Bible) { m_Vietnamese1994Bible = Vietnamese1994Bible; }
    public void SetVietnamese2011Bible(string Vietnamese2011Bible) { m_Vietnamese2011Bible = Vietnamese2011Bible; }
    public void SetVietnamese2015Bible(string Vietnamese2015Bible) { m_Vietnamese2015Bible = Vietnamese2015Bible; }
    public void SetVietnameseBible(string VietnameseBible) { m_VietnameseBible = VietnameseBible; }
    public void SetVietnameseERVBible(string VietnameseERVBible) { m_VietnameseERVBible = VietnameseERVBible; }
    public void SetVietnameseNVBBible(string VietnameseNVBBible) { m_VietnameseNVBBible = VietnameseNVBBible; }
    public void SetVietnameseVIEBible(string VietnameseVIEBible) { m_VietnameseVIEBible = VietnameseVIEBible; }
    public void SetWarayBible(string WarayBible) { m_WarayBible = WarayBible; }
    public void SetWelsh1894Bible(string Welsh1894Bible) { m_Welsh1894Bible = Welsh1894Bible; }
    public void SetWelsh1945Bible(string Welsh1945Bible) { m_Welsh1945Bible = Welsh1945Bible; }
    public void SetWelsh2015Bible(string Welsh2015Bible) { m_Welsh2015Bible = Welsh2015Bible; }
    public void SetWelshBible(string WelshBible) { m_WelshBible = WelshBible; }
    public void SetWelshBMWBible(string WelshBMWBible) { m_WelshBMWBible = WelshBMWBible; }
    public void SetWelshCTEBible(string WelshCTEBible) { m_WelshCTEBible = WelshCTEBible; }
    public void SetWelshSBYBible(string WelshSBYBible) { m_WelshSBYBible = WelshSBYBible; }
    public void SetWolayttaBible(string WolayttaBible) { m_WolayttaBible = WolayttaBible; }
    public void SetWolofBible(string WolofBible) { m_WolofBible = WolofBible; }
    public void SetWolofKYGBible(string WolofKYGBible) { m_WolofKYGBible = WolofKYGBible; }
    public void SetXhosa1920Bible(string Xhosa1920Bible) { m_Xhosa1920Bible = Xhosa1920Bible; }
    public void SetXhosa1996Bible(string Xhosa1996Bible) { m_Xhosa1996Bible = Xhosa1996Bible; }
    public void SetXhosa2022Bible(string Xhosa2022Bible) { m_Xhosa2022Bible = Xhosa2022Bible; }
    public void SetXhosaBible(string XhosaBible) { m_XhosaBible = XhosaBible; }
    public void SetYoruba2010Bible(string Yoruba2010Bible) { m_Yoruba2010Bible = Yoruba2010Bible; }
    public void SetYoruba2014Bible(string Yoruba2014Bible) { m_Yoruba2014Bible = Yoruba2014Bible; }
    public void SetYorubaBible(string YorubaBible) { m_YorubaBible = YorubaBible; }
    public void SetZandeBible(string ZandeBible) { m_ZandeBible = ZandeBible; }
    public void SetZarmaBible(string ZarmaBible) { m_ZarmaBible = ZarmaBible; }
    public void SetZulu2020Bible(string Zulu2020Bible) { m_Zulu2020Bible = Zulu2020Bible; }
    public void SetZulu2023Bible(string Zulu2023Bible) { m_Zulu2023Bible = Zulu2023Bible; }
    public void SetZuluBible(string ZuluBible) { m_ZuluBible = ZuluBible; }
}

public class OldTestamentInfo
{
    public int m_ID { get; private set; }
    public string m_English { get; private set; }
    public string m_Korean { get; private set; }
    public int m_Count { get; private set; }
    public string m_EnglishTarget { get; private set; }
    public string m_NIV { get; private set; }
    public string m_KoreanTarget { get; private set; }
    public string m_Source { get; private set; }
    public string m_EasyBible { get; private set; }
    public string m_RevisedHangul { get; private set; }
    public string m_RevisedRevision { get; private set; }
    public string m_JointTranslation { get; private set; }
    public string m_NewStandardTranslation { get; private set; }
    public string m_KoreanBible { get; private set; }
    public string m_SourceEnglish { get; private set; }
    public string m_KJV { get; private set; }
    public string m_NewKJV { get; private set; }
    public string m_ESV { get; private set; }
    public string m_NewRSV { get; private set; }
    public string m_NASB { get; private set; }
    public string m_afri { get; private set; }
    public string m_albanian { get; private set; }
    public string m_chinese_union_simp { get; private set; }
    public string m_chinese_union_trad { get; private set; }
    public string m_ckjv_sds { get; private set; }
    public string m_ckjv_sdt { get; private set; }
    public string m_bkr { get; private set; }
    public string m_stve { get; private set; }
    public string m_finn { get; private set; }
    public string m_epee { get; private set; }
    public string m_martin { get; private set; }
    public string m_oster { get; private set; }
    public string m_segond_1910 { get; private set; }
    public string m_elberfelder_1871 { get; private set; }
    public string m_elberfelder_1905 { get; private set; }
    public string m_luther { get; private set; }
    public string m_luther_1912 { get; private set; }
    public string m_schlachter { get; private set; }
    public string m_wlc { get; private set; }
    public string m_irv { get; private set; }
    public string m_karoli { get; private set; }
    public string m_indo_tb { get; private set; }
    public string m_indo_tm { get; private set; }
    public string m_diodati { get; private set; }
    public string m_bungo { get; private set; }
    public string m_kougo { get; private set; }
    public string m_maori { get; private set; }
    public string m_opt { get; private set; }
    public string m_pol_nbg { get; private set; }
    public string m_pol_ubg { get; private set; }
    public string m_polbg { get; private set; }
    public string m_almeida_ra { get; private set; }
    public string m_almeida_rc { get; private set; }
    public string m_blivre { get; private set; }
    public string m_fidela { get; private set; }
    public string m_synodal { get; private set; }
    public string m_rv_1909 { get; private set; }
    public string m_rvg { get; private set; }
    public string m_rvg_2004 { get; private set; }
    public string m_sagradas { get; private set; }
    public string m_tagab { get; private set; }
    public string m_thaikjv { get; private set; }
    public string m_turkish { get; private set; }
    public string m_cadman { get; private set; }
    public string m_Portuguese { get; private set; }
    public string m_German { get; private set; }
    public string m_Japanese { get; private set; }
    public string m_Chinese { get; private set; }
    public string m_Romanian { get; private set; }
    public string m_French { get; private set; }
    public string m_Spanish { get; private set; }
    public string m_Italian { get; private set; }
    public string m_Hungarian { get; private set; }
    public string m_Russian { get; private set; }
    public string m_Hindi { get; private set; }
    public string m_AcehBible { get; private set; }
    public string m_AdilabadGondiBible { get; private set; }
    public string m_Afrikaans1983Bible { get; private set; }
    public string m_Afrikaans2020Bible { get; private set; }
    public string m_Afrikaans2023Bible { get; private set; }
    public string m_AfrikaansABABible { get; private set; }
    public string m_AfrikaansBible { get; private set; }
    public string m_AfrikaansDBBible { get; private set; }
    public string m_AfrikaansNLVBible { get; private set; }
    public string m_AhiraniBible { get; private set; }
    public string m_Albanian1872Bible { get; private set; }
    public string m_Albanian1879Bible { get; private set; }
    public string m_Albanian2018Bible { get; private set; }
    public string m_AlbanianBible { get; private set; }
    public string m_Amharic2000Bible { get; private set; }
    public string m_AmharicBible { get; private set; }
    public string m_AmharicCatholicBible { get; private set; }
    public string m_AmharicDawroBible { get; private set; }
    public string m_AmharicDawroDFBEBible { get; private set; }
    public string m_AmharicDawroDFBLVLBible { get; private set; }
    public string m_AmharicDawroDWRNTBible { get; private set; }
    public string m_AmharicDawroWWIBible { get; private set; }
    public string m_AmharicGamo2017Bible { get; private set; }
    public string m_AmharicGamoBible { get; private set; }
    public string m_AmharicGamoGMBible { get; private set; }
    public string m_AmharicGamoWordBible { get; private set; }
    public string m_AmharicGofaBible { get; private set; }
    public string m_AmharicGofaGFBEVFBible { get; private set; }
    public string m_AmharicGofaGFBLVFBible { get; private set; }
    public string m_AmharicGofaRNTBible { get; private set; }
    public string m_AmharicGofaWWIBible { get; private set; }
    public string m_AmharicNASVBible { get; private set; }
    public string m_AmharicNSTBible { get; private set; }
    public string m_AmharicTigrinya15Bible { get; private set; }
    public string m_AmharicTigrinya2024Bible { get; private set; }
    public string m_AmharicTigrinyaBible { get; private set; }
    public string m_Arabic1978Bible { get; private set; }
    public string m_Arabic2016Bible { get; private set; }
    public string m_Arabic2018Bible { get; private set; }
    public string m_Arabic2023Bible { get; private set; }
    public string m_ArabicAlgeriaBible { get; private set; }
    public string m_ArabicAPDBible { get; private set; }
    public string m_ArabicAVDBible { get; private set; }
    public string m_ArabicAVDDVBible { get; private set; }
    public string m_ArabicBible { get; private set; }
    public string m_ArabicERVBible { get; private set; }
    public string m_ArabicGNABible { get; private set; }
    public string m_ArabicGOVBible { get; private set; }
    public string m_ArabicLABible { get; private set; }
    public string m_ArabicLebaneseBible { get; private set; }
    public string m_ArabicMorocco2023Bible { get; private set; }
    public string m_ArabicMoroccoBible { get; private set; }
    public string m_ArabicSABBible { get; private set; }
    public string m_ArabicSABible { get; private set; }
    public string m_ArabicSVDBible { get; private set; }
    public string m_ArabicTMABible { get; private set; }
    public string m_ArabicTU2022Bible { get; private set; }
    public string m_ArabicTunisianBible { get; private set; }
    public string m_AramaicBible { get; private set; }
    public string m_Armenian1853Bible { get; private set; }
    public string m_Armenian2017Bible { get; private set; }
    public string m_Armenian2018Bible { get; private set; }
    public string m_Armenian2019Bible { get; private set; }
    public string m_ArmenianAraratBible { get; private set; }
    public string m_ArmenianBible { get; private set; }
    public string m_ArmenianEasternBible { get; private set; }
    public string m_ArmenianNEABible { get; private set; }
    public string m_AssameseBible { get; private set; }
    public string m_AvarBible { get; private set; }
    public string m_AwadhiBible { get; private set; }
    public string m_Aymara1986Bible { get; private set; }
    public string m_Aymara1997Bible { get; private set; }
    public string m_AymaraBible { get; private set; }
    public string m_Azerbaijan2013Bible { get; private set; }
    public string m_AzerbaijanBible { get; private set; }
    public string m_AzerbaijanSouthBible { get; private set; }
    public string m_BagriBible { get; private set; }
    public string m_BalineseBible { get; private set; }
    public string m_BalochiArabicBible { get; private set; }
    public string m_BalochiBible { get; private set; }
    public string m_BalochiSoutherenBible { get; private set; }
    public string m_BalochiSoutherenLatinBible { get; private set; }
    public string m_Baoule1974Bible { get; private set; }
    public string m_Baoule1998Bible { get; private set; }
    public string m_BaouleBible { get; private set; }
    public string m_Bashkir2023Bible { get; private set; }
    public string m_BashkirBible { get; private set; }
    public string m_BasqueBible { get; private set; }
    public string m_Basque2008Bible { get; private set; }
    public string m_BavarianBible { get; private set; }
    public string m_Belarusian2017Bible { get; private set; }
    public string m_BelarusianBible { get; private set; }
    public string m_BelarusianBokunBible { get; private set; }
    public string m_BelarusianCHNTBible { get; private set; }
    public string m_BelarusianNTJSBible { get; private set; }
    public string m_BembaBible { get; private set; }
    public string m_Bengali2017Bible { get; private set; }
    public string m_Bengali2023Bible { get; private set; }
    public string m_BengaliBACIBBible { get; private set; }
    public string m_BengaliBCVBible { get; private set; }
    public string m_BengaliBible { get; private set; }
    public string m_BengaliBSIBible { get; private set; }
    public string m_BengaliCLBSIBible { get; private set; }
    public string m_BengaliERVBible { get; private set; }
    public string m_BengaliIRVBENBible { get; private set; }
    public string m_BengaliMBCLBible { get; private set; }
    public string m_BengaliSBCLBible { get; private set; }
    public string m_BerberBible { get; private set; }
    public string m_BhilaliBible { get; private set; }
    public string m_BodoBible { get; private set; }
    public string m_BodoNTBPL20Bible { get; private set; }
    public string m_BosnianBible { get; private set; }
    public string m_BrajBible { get; private set; }
    public string m_BugisBible { get; private set; }
    public string m_Bulgarian2015Bible { get; private set; }
    public string m_BulgarianBible { get; private set; }
    public string m_BulgarianBOBBible { get; private set; }
    public string m_BulgarianBPBBible { get; private set; }
    public string m_BulgarianCBTBible { get; private set; }
    public string m_BulgarianSPBBible { get; private set; }
    public string m_BulgarianTZABible { get; private set; }
    public string m_BulgarianVerensBible { get; private set; }
    public string m_BundeliBible { get; private set; }
    public string m_Burmese1928Bible { get; private set; }
    public string m_Burmese2021Bible { get; private set; }
    public string m_BurmeseBCLBible { get; private set; }
    public string m_BurmeseBible { get; private set; }
    public string m_BurmeseJBZVBible { get; private set; }
    public string m_BurmeseMCLZVBible { get; private set; }
    public string m_BurmeseMSBUBible { get; private set; }
    public string m_BurmeseMSBZBible { get; private set; }
    public string m_CatalanBCIBible { get; private set; }
    public string m_CatalanBECBible { get; private set; }
    public string m_Cebuano1999Bible { get; private set; }
    public string m_Cebuano2011Bible { get; private set; }
    public string m_CebuanoAPSDBible { get; private set; }
    public string m_CebuanoBible { get; private set; }
    public string m_CebuanoRCPVBible { get; private set; }
    public string m_ChechenBible { get; private set; }
    public string m_Chewa1992Bible { get; private set; }
    public string m_Chewa2014Bible { get; private set; }
    public string m_Chewa2016Bible { get; private set; }
    public string m_ChewaBLYDCBible { get; private set; }
    public string m_ChhattisgarhiBible { get; private set; }
    public string m_ChibembaBible { get; private set; }
    public string m_Chin2010Bible { get; private set; }
    public string m_ChinBSIBible { get; private set; }
    public string m_ChinCSHBible { get; private set; }
    public string m_ChinDNTBible { get; private set; }
    public string m_Chinese1886Bible { get; private set; }
    public string m_Chinese1919Bible { get; private set; }
    public string m_Chinese1927Bible { get; private set; }
    public string m_Chinese1933Bible { get; private set; }
    public string m_Chinese1941Bible { get; private set; }
    public string m_Chinese1967Bible { get; private set; }
    public string m_ChineseCCBSBible { get; private set; }
    public string m_ChineseCCBTBible { get; private set; }
    public string m_ChineseCSBSBible { get; private set; }
    public string m_ChineseCSBTBible { get; private set; }
    public string m_ChineseCUNPSSBible { get; private set; }
    public string m_ChineseCUNPSTBible { get; private set; }
    public string m_ChineseNankingBible { get; private set; }
    public string m_ChinesePekingBible { get; private set; }
    public string m_ChineseRCUVSSBible { get; private set; }
    public string m_ChineseRCUVTBible { get; private set; }
    public string m_ChineseSimplifiedBible { get; private set; }
    public string m_ChineseSimplifiedNewBible { get; private set; }
    public string m_ChineseTCV2019TBible { get; private set; }
    public string m_ChineseTHV2012Bible { get; private set; }
    public string m_ChineseTraditionalBible { get; private set; }
    public string m_ChineseTraditionalERVBible { get; private set; }
    public string m_ChineseTraditionalNewBible { get; private set; }
    public string m_ChineseTTVHBible { get; private set; }
    public string m_ChineseTTVRBible { get; private set; }
    public string m_ChineseUnion2010Bible { get; private set; }
    public string m_ChineseWenli1823Bible { get; private set; }
    public string m_ChineseWenli1885Bible { get; private set; }
    public string m_ChineseWenli1897Bible { get; private set; }
    public string m_ChineseWenliBible { get; private set; }
    public string m_ChineseWenliEasyBible { get; private set; }
    public string m_ChinKNTPBible { get; private set; }
    public string m_ChinMatupi2006Bible { get; private set; }
    public string m_ChinMatupiBible { get; private set; }
    public string m_ChinSCB2Bible { get; private set; }
    public string m_ChinTB77Bible { get; private set; }
    public string m_ChinTBR17Bible { get; private set; }
    public string m_ChinTDBBible { get; private set; }
    public string m_ChinTedim2011Bible { get; private set; }
    public string m_ChinTedimBible { get; private set; }
    public string m_ChuvashBible { get; private set; }
    public string m_ChuvashRSOBible { get; private set; }
    public string m_CopticBible { get; private set; }
    public string m_CopticCNTVBible { get; private set; }
    public string m_CopticSahidicBible { get; private set; }
    public string m_CroatianBible { get; private set; }
    public string m_CroatianBKJBible { get; private set; }
    public string m_CroatianCNTBible { get; private set; }
    public string m_CroatianGKSBible { get; private set; }
    public string m_CroatianSHPBible { get; private set; }
    public string m_Czech1922Bible { get; private set; }
    public string m_Czech1947Bible { get; private set; }
    public string m_Czech1951Bible { get; private set; }
    public string m_CzechBible { get; private set; }
    public string m_CzechEkumenickyBible { get; private set; }
    public string m_CzechKralichka1613Bible { get; private set; }
    public string m_CzechKralichka1998Bible { get; private set; }
    public string m_CzechPMPZBible { get; private set; }
    public string m_CzechPrekladBible { get; private set; }
    public string m_CzechSNCBible { get; private set; }
    public string m_DagbaniBible { get; private set; }
    public string m_Danish1819Bible { get; private set; }
    public string m_Danish2015Bible { get; private set; }
    public string m_DanishBible { get; private set; }
    public string m_DanishLBBible { get; private set; }
    public string m_DanishWIEBible { get; private set; }
    public string m_Dinka2006Bible { get; private set; }
    public string m_DinkaBible { get; private set; }
    public string m_DinkaLEKJOTBible { get; private set; }
    public string m_DogriBible { get; private set; }
    public string m_Dutch1939Bible { get; private set; }
    public string m_Dutch2007Bible { get; private set; }
    public string m_DutchBBBible { get; private set; }
    public string m_DutchBible { get; private set; }
    public string m_DutchEBV24Bible { get; private set; }
    public string m_DutchFrisianBible { get; private set; }
    public string m_DutchGBVNTBible { get; private set; }
    public string m_DutchHSVBible { get; private set; }
    public string m_DutchHTBBible { get; private set; }
    public string m_DutchNBGBible { get; private set; }
    public string m_DutchReimerBible { get; private set; }
    public string m_DutchSVVBible { get; private set; }
    public string m_DutchVBBible { get; private set; }
    public string m_DyulaJulaBible { get; private set; }
    public string m_DyulaKumaBible { get; private set; }
    public string m_DyulaLayidukuraBible { get; private set; }
    public string m_EdoBible { get; private set; }
    public string m_EnglishAmplifiedBible { get; private set; }
    public string m_EnglishAmplifiedClassicBible { get; private set; }
    public string m_EnglishASVBible { get; private set; }
    public string m_EnglishBereanBible { get; private set; }
    public string m_EnglishCSBBible { get; private set; }
    public string m_EnglishDarbyBible { get; private set; }
    public string m_EnglishEASYBible { get; private set; }
    public string m_EnglishERVBible { get; private set; }
    public string m_EnglishESVBible { get; private set; }
    public string m_EnglishGNTBible { get; private set; }
    public string m_EnglishGWBible { get; private set; }
    public string m_EnglishHCSBBible { get; private set; }
    public string m_EnglishKJBible { get; private set; }
    public string m_EnglishLSBBible { get; private set; }
    public string m_EnglishMEVBible { get; private set; }
    public string m_EnglishNASBBible { get; private set; }
    public string m_EnglishNASUBible { get; private set; }
    public string m_EnglishNETBible { get; private set; }
    public string m_EnglishNIRVBible { get; private set; }
    public string m_EnglishNIVBible { get; private set; }
    public string m_EnglishNKJBible { get; private set; }
    public string m_EnglishNLTBible { get; private set; }
    public string m_EnglishNRSVBible { get; private set; }
    public string m_EnglishPassionBible { get; private set; }
    public string m_EnglishRSVBible { get; private set; }
    public string m_EnglishTLBible { get; private set; }
    public string m_EnglishTyndale1537Bible { get; private set; }
    public string m_EnglishYLTBible { get; private set; }
    public string m_EsperantoBible { get; private set; }
    public string m_Estonian2022Bible { get; private set; }
    public string m_EstonianBible { get; private set; }
    public string m_EstonianEEPBible { get; private set; }
    public string m_Ewe1913Bible { get; private set; }
    public string m_Ewe2014Bible { get; private set; }
    public string m_Ewe2020Bible { get; private set; }
    public string m_EweBible { get; private set; }
    public string m_Finnish1776Bible { get; private set; }
    public string m_Finnish1992Bible { get; private set; }
    public string m_FinnishBible { get; private set; }
    public string m_FinnishFINRKBible { get; private set; }
    public string m_FinnishSTLKBible { get; private set; }
    public string m_FonBible { get; private set; }
    public string m_French2004Bible { get; private set; }
    public string m_FrenchBBBBible { get; private set; }
    public string m_FrenchBDSBible { get; private set; }
    public string m_FrenchBFCBible { get; private set; }
    public string m_FrenchBible { get; private set; }
    public string m_FrenchCramponBible { get; private set; }
    public string m_FrenchDarbyBible { get; private set; }
    public string m_FrenchJerusalemBible { get; private set; }
    public string m_FrenchLeonBible { get; private set; }
    public string m_FrenchMachairaBible { get; private set; }
    public string m_FrenchMartinBible { get; private set; }
    public string m_FrenchNBSBible { get; private set; }
    public string m_FrenchNEG79Bible { get; private set; }
    public string m_FrenchNFCBible { get; private set; }
    public string m_FrenchNVS78Bible { get; private set; }
    public string m_FrenchOSTBible { get; private set; }
    public string m_FrenchOstervaldBible { get; private set; }
    public string m_FrenchPDV2017Bible { get; private set; }
    public string m_FrenchPerretBible { get; private set; }
    public string m_FrenchS21Bible { get; private set; }
    public string m_FrenchVigourouxBible { get; private set; }
    public string m_Fulfulde2010Bible { get; private set; }
    public string m_FulfuldeAadiBible { get; private set; }
    public string m_FulfuldeAdamawaBible { get; private set; }
    public string m_FulfuldeAlkawalBible { get; private set; }
    public string m_FulfuldeArabicBible { get; private set; }
    public string m_FulfuldeBeninBible { get; private set; }
    public string m_FulfuldeBurkinaFasoBible { get; private set; }
    public string m_FulfuldeDewtereBible { get; private set; }
    public string m_FulfuldeWestNigerBible { get; private set; }
    public string m_Gaelic1875Bible { get; private set; }
    public string m_GaelicABGBible { get; private set; }
    public string m_GaelicABIGBible { get; private set; }
    public string m_GaelicATNBible { get; private set; }
    public string m_GalacianSEPTBible { get; private set; }
    public string m_GarhwaliBible { get; private set; }
    public string m_GarhwaliGBMBible { get; private set; }
    public string m_Georgian2002Bible { get; private set; }
    public string m_Georgian2012Bible { get; private set; }
    public string m_GeorgianBible { get; private set; }
    public string m_German1545Bible { get; private set; }
    public string m_German2011Bible { get; private set; }
    public string m_GermanAlbrecht1926Bible { get; private set; }
    public string m_GermanBible { get; private set; }
    public string m_GermanElber1905Bible { get; private set; }
    public string m_GermanGruenewaldBible { get; private set; }
    public string m_GermanHeuteBible { get; private set; }
    public string m_GermanHFABible { get; private set; }
    public string m_GermanInterlinearBible { get; private set; }
    public string m_GermanLUT17Bible { get; private set; }
    public string m_GermanLuther1912Bible { get; private set; }
    public string m_GermanLutherHeuteBible { get; private set; }
    public string m_GermanSchlachter2000Bible { get; private set; }
    public string m_GermanTafelBible { get; private set; }
    public string m_GermanTKWBible { get; private set; }
    public string m_GermanUbersetzung2014Bible { get; private set; }
    public string m_GhomalaBible { get; private set; }
    public string m_Greek1550Bible { get; private set; }
    public string m_GreekBible { get; private set; }
    public string m_GreekBYZ04Bible { get; private set; }
    public string m_GreekBYZ18Bible { get; private set; }
    public string m_GreekElzevirBible { get; private set; }
    public string m_GreekF35Bible { get; private set; }
    public string m_GreekFPBBible { get; private set; }
    public string m_GreekGNTBible { get; private set; }
    public string m_GreekLMGNTBible { get; private set; }
    public string m_GreekModern1904Bible { get; private set; }
    public string m_GreekModernFPBBible { get; private set; }
    public string m_GreekNTVBible { get; private set; }
    public string m_GreekSBLGNTBible { get; private set; }
    public string m_GreekTCGNTBible { get; private set; }
    public string m_GreekTGVBible { get; private set; }
    public string m_GreekTHGNTBible { get; private set; }
    public string m_GreekTR1894Bible { get; private set; }
    public string m_Guarani1913Bible { get; private set; }
    public string m_Guarani1970Bible { get; private set; }
    public string m_Guarani1996Bible { get; private set; }
    public string m_Guarani2001Bible { get; private set; }
    public string m_Guarani2015Bible { get; private set; }
    public string m_Guarani2017Bible { get; private set; }
    public string m_GuaraniBible { get; private set; }
    public string m_GuaraniMBYABible { get; private set; }
    public string m_GuaraniSIMBABible { get; private set; }
    public string m_Gujarati2016Bible { get; private set; }
    public string m_Gujarati2017Bible { get; private set; }
    public string m_GujaratiBible { get; private set; }
    public string m_GujaratiGUOVBible { get; private set; }
    public string m_GussiBible { get; private set; }
    public string m_HadiyyaBible { get; private set; }
    public string m_HaitianBible { get; private set; }
    public string m_HaitianBSABible { get; private set; }
    public string m_HaitianHWPBible { get; private set; }
    public string m_HaitianVFKBible { get; private set; }
    public string m_HaryanviBible { get; private set; }
    public string m_Hausa2010Bible { get; private set; }
    public string m_Hausa2013Bible { get; private set; }
    public string m_HausaARBible { get; private set; }
    public string m_Hebrew1885Bible { get; private set; }
    public string m_HebrewAleppoCodexBible { get; private set; }
    public string m_HebrewBible { get; private set; }
    public string m_HebrewBSIBible { get; private set; }
    public string m_HebrewHHHBible { get; private set; }
    public string m_HebrewLeningradCodexBible { get; private set; }
    public string m_HebrewMHBBible { get; private set; }
    public string m_HebrewMHNT2020Bible { get; private set; }
    public string m_HebrewTDBible { get; private set; }
    public string m_Hindi2017Bible { get; private set; }
    public string m_HindiBible { get; private set; }
    public string m_HindiCLBSIBible { get; private set; }
    public string m_HindiERVBible { get; private set; }
    public string m_HindiFijiBible { get; private set; }
    public string m_HindiHSBBible { get; private set; }
    public string m_HindiHSSBible { get; private set; }
    public string m_HindiIRVBible { get; private set; }
    public string m_HindiOVBSIBible { get; private set; }
    public string m_HindiRomanBible { get; private set; }
    public string m_Hmong2000Bible { get; private set; }
    public string m_Hmong2004Bible { get; private set; }
    public string m_HungarianBDUZBible { get; private set; }
    public string m_HungarianBible { get; private set; }
    public string m_HungarianBUZBible { get; private set; }
    public string m_HungarianCSIABible { get; private set; }
    public string m_HungarianCSUZBible { get; private set; }
    public string m_HungarianEFOBible { get; private set; }
    public string m_HungarianEIVBible { get; private set; }
    public string m_HungarianERVBible { get; private set; }
    public string m_HungarianKaroliBible { get; private set; }
    public string m_HungarianKIBBible { get; private set; }
    public string m_HungarianKNBBible { get; private set; }
    public string m_HungarianKSZEBible { get; private set; }
    public string m_HungarianMRUZBible { get; private set; }
    public string m_HungarianRLUZBible { get; private set; }
    public string m_HungarianRUFBible { get; private set; }
    public string m_HungarianSIUZBible { get; private set; }
    public string m_HungarianVSUZBible { get; private set; }
    public string m_IbanBible { get; private set; }
    public string m_IbibioBible { get; private set; }
    public string m_Icelandic1981Bible { get; private set; }
    public string m_IcelandicBible { get; private set; }
    public string m_Igbo1988Bible { get; private set; }
    public string m_Igbo2006Bible { get; private set; }
    public string m_Igbo2020Bible { get; private set; }
    public string m_IkaBible { get; private set; }
    public string m_Ilokano1973Bible { get; private set; }
    public string m_IlokanoBible { get; private set; }
    public string m_Ilonggo2012Bible { get; private set; }
    public string m_IlonggoAPDBible { get; private set; }
    public string m_IlonggoBible { get; private set; }
    public string m_IndonesianAGSBible { get; private set; }
    public string m_IndonesianAMD2021Bible { get; private set; }
    public string m_IndonesianBible { get; private set; }
    public string m_IndonesianBISBible { get; private set; }
    public string m_IndonesianBPJBible { get; private set; }
    public string m_IndonesianFAYHBible { get; private set; }
    public string m_IndonesianINOTAZIBible { get; private set; }
    public string m_IndonesianPBTB2Bible { get; private set; }
    public string m_IndonesianTLBible { get; private set; }
    public string m_IndonesianTSIBible { get; private set; }
    public string m_IndonesianVMDBible { get; private set; }
    public string m_Irish1817Bible { get; private set; }
    public string m_Irish1951Bible { get; private set; }
    public string m_Irish1970Bible { get; private set; }
    public string m_Irish2012Bible { get; private set; }
    public string m_IrishBible { get; private set; }
    public string m_Italian1649Bible { get; private set; }
    public string m_Italian2014Bible { get; private set; }
    public string m_Italian2020Bible { get; private set; }
    public string m_ItalianBible { get; private set; }
    public string m_ItalianCEI2008Bible { get; private set; }
    public string m_ItalianIPNBible { get; private set; }
    public string m_ItalianLaNuovaDiodatiBible { get; private set; }
    public string m_ItalianNR1994Bible { get; private set; }
    public string m_ItalianRivedutaBible { get; private set; }
    public string m_IuMienBible { get; private set; }
    public string m_IuMienThaiBible { get; private set; }
    public string m_JamaicanBible { get; private set; }
    public string m_Japanese1965Bible { get; private set; }
    public string m_Japanese1987Bible { get; private set; }
    public string m_Japanese2017Bible { get; private set; }
    public string m_JapaneseBible { get; private set; }
    public string m_JapaneseCO1955Bible { get; private set; }
    public string m_JapaneseERVBible { get; private set; }
    public string m_JapaneseJCBBible { get; private set; }
    public string m_JavaneseBible { get; private set; }
    public string m_JavaneseJVNBible { get; private set; }
    public string m_JavaneseKJS17Bible { get; private set; }
    public string m_KabardianBible { get; private set; }
    public string m_KabyleBible { get; private set; }
    public string m_KachinJCLBBible { get; private set; }
    public string m_KachinJHVT3Bible { get; private set; }
    public string m_Kalenjin2019Bible { get; private set; }
    public string m_KalenjinBible { get; private set; }
    public string m_KalenjinRevisedBible { get; private set; }
    public string m_KambaBible { get; private set; }
    public string m_KambaMBIVLIABible { get; private set; }
    public string m_KangriBible { get; private set; }
    public string m_Kannada2022Bible { get; private set; }
    public string m_KannadaBible { get; private set; }
    public string m_KannadaBSIBible { get; private set; }
    public string m_KannadaBSIJVBible { get; private set; }
    public string m_KannadaIRVBible { get; private set; }
    public string m_KannadaKNCLBible { get; private set; }
    public string m_Karakalpak2004Bible { get; private set; }
    public string m_Karakalpak2022Bible { get; private set; }
    public string m_KarakalpakK2022Bible { get; private set; }
    public string m_Kazakhstan2023Bible { get; private set; }
    public string m_KazakhstanBible { get; private set; }
    public string m_KenyaGIKCLBible { get; private set; }
    public string m_Khmer2005Bible { get; private set; }
    public string m_Khmer2012Bible { get; private set; }
    public string m_Khmer2014Bible { get; private set; }
    public string m_Khmer2016Bible { get; private set; }
    public string m_Khmer2019Bible { get; private set; }
    public string m_KhmerBFBSBible { get; private set; }
    public string m_KhmerBible { get; private set; }
    public string m_Kiche1995Bible { get; private set; }
    public string m_Kiche2022Bible { get; private set; }
    public string m_KicheBible { get; private set; }
    public string m_KicheQUCNBible { get; private set; }
    public string m_Kikuyu2013Bible { get; private set; }
    public string m_Kikuyu2014Bible { get; private set; }
    public string m_Kikuyu2019Bible { get; private set; }
    public string m_KikwangoBible { get; private set; }
    public string m_KimbunduBible { get; private set; }
    public string m_KimiiruBible { get; private set; }
    public string m_Kinyarwanda2001Bible { get; private set; }
    public string m_Kinyarwanda2012Bible { get; private set; }
    public string m_KinyarwandaBIRBible { get; private set; }
    public string m_KirundiCorosheBible { get; private set; }
    public string m_KirundiRishaBible { get; private set; }
    public string m_KitubaBible { get; private set; }
    public string m_KonkaniBible { get; private set; }
    public string m_Korean2021Bible { get; private set; }
    public string m_KoreanAEBBible { get; private set; }
    public string m_KoreanKLBBible { get; private set; }
    public string m_KoreanNKRVBible { get; private set; }
    public string m_KoreanRentierBible { get; private set; }
    public string m_KoreanRNKSVBible { get; private set; }
    public string m_KoreanTKVBible { get; private set; }
    public string m_KoreanWoorimalBible { get; private set; }
    public string m_KoyaBible { get; private set; }
    public string m_KrioBible { get; private set; }
    public string m_KumaoniBible { get; private set; }
    public string m_Kurdish2005Bible { get; private set; }
    public string m_Kurdish2017Bible { get; private set; }
    public string m_KurdishBHDBible { get; private set; }
    public string m_KurdishBible { get; private set; }
    public string m_KurdishKMRNTCBible { get; private set; }
    public string m_KurdishKMRNTLBible { get; private set; }
    public string m_KurdishPNTZSBible { get; private set; }
    public string m_KurdishSKBBible { get; private set; }
    public string m_KurdishSKVBible { get; private set; }
    public string m_Kurukh2025Bible { get; private set; }
    public string m_KurukhBible { get; private set; }
    public string m_Kyrgyz2004Bible { get; private set; }
    public string m_Kyrgyz2005Bible { get; private set; }
    public string m_LahuBible { get; private set; }
    public string m_LahuLHINTBible { get; private set; }
    public string m_LambadiBible { get; private set; }
    public string m_Lango1979Bible { get; private set; }
    public string m_LangoBible { get; private set; }
    public string m_Lao2012Bible { get; private set; }
    public string m_LaoBible { get; private set; }
    public string m_LaoLCVBible { get; private set; }
    public string m_LatinBible { get; private set; }
    public string m_LatinClementina1914Bible { get; private set; }
    public string m_LatinClementineBible { get; private set; }
    public string m_LatinNovaVulgataBible { get; private set; }
    public string m_LatinSistinaBible { get; private set; }
    public string m_Latvian1965Bible { get; private set; }
    public string m_Latvian2012Bible { get; private set; }
    public string m_Latvian2024Bible { get; private set; }
    public string m_LatvianBible { get; private set; }
    public string m_LatvianGluckBible { get; private set; }
    public string m_LatvianLG8Bible { get; private set; }
    public string m_LatvianLTV1965Bible { get; private set; }
    public string m_LatvianNLBDCBible { get; private set; }
    public string m_LiberianKreyolBible { get; private set; }
    public string m_Lingala2002Bible { get; private set; }
    public string m_Lingala2020Bible { get; private set; }
    public string m_Lithuanian2012Bible { get; private set; }
    public string m_Lithuanian2012EKUBible { get; private set; }
    public string m_Lithuanian2012KANBible { get; private set; }
    public string m_LithuanianBible { get; private set; }
    public string m_LithuanianKJBible { get; private set; }
    public string m_LithuanianLBDBible { get; private set; }
    public string m_LomweBible { get; private set; }
    public string m_Luganda2003Bible { get; private set; }
    public string m_LugandaBible { get; private set; }
    public string m_LugandaBIBU1Bible { get; private set; }
    public string m_LugandaEEEEBible { get; private set; }
    public string m_LugandaLBRBible { get; private set; }
    public string m_LugbaraBible { get; private set; }
    public string m_LuguruBible { get; private set; }
    public string m_Luo1985Bible { get; private set; }
    public string m_Luo2015Bible { get; private set; }
    public string m_Luo2020Bible { get; private set; }
    public string m_Maasai1970Bible { get; private set; }
    public string m_Maasai2020Bible { get; private set; }
    public string m_MaasaiBible { get; private set; }
    public string m_MaasaiMBSBible { get; private set; }
    public string m_Macedonian1990Bible { get; private set; }
    public string m_Macedonian2006Bible { get; private set; }
    public string m_Macedonian2006DBible { get; private set; }
    public string m_Macedonian2023Bible { get; private set; }
    public string m_MacedonianMKB1999Bible { get; private set; }
    public string m_MacedonianMNT1999Bible { get; private set; }
    public string m_MadureseBible { get; private set; }
    public string m_MaithiliBible { get; private set; }
    public string m_Makhuwa2021Bible { get; private set; }
    public string m_MakhuwaBible { get; private set; }
    public string m_MakhuwaVMKBible { get; private set; }
    public string m_MakondeBible { get; private set; }
    public string m_MakondeShiBible { get; private set; }
    public string m_Malagasy1865Bible { get; private set; }
    public string m_Malagasy2003Bible { get; private set; }
    public string m_Malagasy2004Bible { get; private set; }
    public string m_Malagasy2011Bible { get; private set; }
    public string m_MalagasyBible { get; private set; }
    public string m_MalagasyMRVBible { get; private set; }
    public string m_Malayalam1910Bible { get; private set; }
    public string m_Malayalam2013Bible { get; private set; }
    public string m_MalayalamBCSBible { get; private set; }
    public string m_MalayalamBible { get; private set; }
    public string m_MalayalamBSIBible { get; private set; }
    public string m_MalayalamCVBible { get; private set; }
    public string m_MalayalamMalovBible { get; private set; }
    public string m_MalayalamWBTCBible { get; private set; }
    public string m_Malaysian1996Bible { get; private set; }
    public string m_Malaysian2017Bible { get; private set; }
    public string m_Malaysian2020Bible { get; private set; }
    public string m_MalaysianBible { get; private set; }
    public string m_Maori2012Bible { get; private set; }
    public string m_MaoriBible { get; private set; }
    public string m_Marathi2015Bible { get; private set; }
    public string m_MarathiBible { get; private set; }
    public string m_MarathiBSIBible { get; private set; }
    public string m_MarathiIRVMARBible { get; private set; }
    public string m_MarathiMRCVBible { get; private set; }
    public string m_MarwariBible { get; private set; }
    public string m_MazanderaniGMBBible { get; private set; }
    public string m_MazanderaniBible { get; private set; }
    public string m_MazanderaniWMBBible { get; private set; }
    public string m_MeiteiBible { get; private set; }
    public string m_MendeBible { get; private set; }
    public string m_MewariBible { get; private set; }
    public string m_MizoBible { get; private set; }
    public string m_MizoCLBSIBible { get; private set; }
    public string m_MizoOVBSIBible { get; private set; }
    public string m_MobaBible { get; private set; }
    public string m_MoldovianCyrillicBible { get; private set; }
    public string m_MoldovianLatinBible { get; private set; }
    public string m_Mongolian2004Bible { get; private set; }
    public string m_Mongolian2013Bible { get; private set; }
    public string m_Morisyen2021Bible { get; private set; }
    public string m_MorisyenBible { get; private set; }
    public string m_Mossi2014Bible { get; private set; }
    public string m_MossiSBBible { get; private set; }
    public string m_MossiSSDCBible { get; private set; }
    public string m_Munda2020Bible { get; private set; }
    public string m_MundaBible { get; private set; }
    public string m_Nahuatl2012Bible { get; private set; }
    public string m_Nahuatl2017Bible { get; private set; }
    public string m_NahuatlBible { get; private set; }
    public string m_NahuatlGUBible { get; private set; }
    public string m_NahuatlNHEBible { get; private set; }
    public string m_Ndau2023Bible { get; private set; }
    public string m_NdauBible { get; private set; }
    public string m_Ndebele2002Bible { get; private set; }
    public string m_Ndebele2003Bible { get; private set; }
    public string m_Ndebele2012Bible { get; private set; }
    public string m_NdebeleBible { get; private set; }
    public string m_Nepali2008Bible { get; private set; }
    public string m_Nepali2012Bible { get; private set; }
    public string m_Nepali2021Bible { get; private set; }
    public string m_NepaliBible { get; private set; }
    public string m_NepaliTamangBible { get; private set; }
    public string m_NigerianPidginBible { get; private set; }
    public string m_Norwegian1921Bible { get; private set; }
    public string m_Norwegian1938Bible { get; private set; }
    public string m_Norwegian1978Bible { get; private set; }
    public string m_Norwegian2007Bible { get; private set; }
    public string m_Norwegian2011Bible { get; private set; }
    public string m_Norwegian2018Bible { get; private set; }
    public string m_NorwegianBGOBible { get; private set; }
    public string m_NorwegianBIBEL1978Bible { get; private set; }
    public string m_NorwegianBible { get; private set; }
    public string m_NorwegianELBBible { get; private set; }
    public string m_NorwegianN78BMBible { get; private set; }
    public string m_NorwegianN78NNBible { get; private set; }
    public string m_NorwegianNY2011Bible { get; private set; }
    public string m_NuerBible { get; private set; }
    public string m_Nyankole1964Bible { get; private set; }
    public string m_NyankoleBible { get; private set; }
    public string m_Odia2024Bible { get; private set; }
    public string m_OdiaBible { get; private set; }
    public string m_OdiaBSIBible { get; private set; }
    public string m_OdiaERVBible { get; private set; }
    public string m_OdiaIRV2017Bible { get; private set; }
    public string m_OdiaIRVBible { get; private set; }
    public string m_OdiaOROVBible { get; private set; }
    public string m_OriginalGreekBible { get; private set; }
    public string m_OriginalHebrewBible { get; private set; }
    public string m_OromoGUJBible { get; private set; }
    public string m_OromoGujiBible { get; private set; }
    public string m_OromoKakuuHaaraakaBible { get; private set; }
    public string m_OromoKitaabaWaaqaBible { get; private set; }
    public string m_OromoKitaabaWoyyuuBible { get; private set; }
    public string m_OromoWaadaaHaarawaBible { get; private set; }
    public string m_OromoWaadaaLammataaBible { get; private set; }
    public string m_PampangaBible { get; private set; }
    public string m_PapuaNewGuineaBible { get; private set; }
    public string m_PapuaNewGuineaTokPisinBible { get; private set; }
    public string m_Pashto2019Bible { get; private set; }
    public string m_Pashto2023Bible { get; private set; }
    public string m_PashtoBible { get; private set; }
    public string m_Persian2005Bible { get; private set; }
    public string m_Persian2014Bible { get; private set; }
    public string m_PersianBible { get; private set; }
    public string m_PersianDariBible { get; private set; }
    public string m_PersianTPVBible { get; private set; }
    public string m_Polish2016Bible { get; private set; }
    public string m_Polish2018Bible { get; private set; }
    public string m_PolishBible { get; private set; }
    public string m_PolishGdansk2017Bible { get; private set; }
    public string m_PolishGdanskBible { get; private set; }
    public string m_PolishNBGBible { get; private set; }
    public string m_PolishNPDBible { get; private set; }
    public string m_PolishSNPD4Bible { get; private set; }
    public string m_Portuguese1969Bible { get; private set; }
    public string m_PortugueseA21Bible { get; private set; }
    public string m_PortugueseAlmeida1628Bible { get; private set; }
    public string m_PortugueseAlmeida1753Bible { get; private set; }
    public string m_PortugueseARCBible { get; private set; }
    public string m_PortugueseBible { get; private set; }
    public string m_PortugueseBLTBible { get; private set; }
    public string m_PortugueseBPT09Bible { get; private set; }
    public string m_PortugueseCAPBible { get; private set; }
    public string m_PortugueseMZNVIBible { get; private set; }
    public string m_PortugueseNAABible { get; private set; }
    public string m_PortugueseNBV2007Bible { get; private set; }
    public string m_PortugueseNTLHBible { get; private set; }
    public string m_PortugueseNVI2023Bible { get; private set; }
    public string m_PortugueseNVIBible { get; private set; }
    public string m_PortugueseNVTBible { get; private set; }
    public string m_PortugueseOLBible { get; private set; }
    public string m_PortugueseTBBible { get; private set; }
    public string m_PortugueseVFLBible { get; private set; }
    public string m_PularBible { get; private set; }
    public string m_Punjabi2016Bible { get; private set; }
    public string m_Punjabi2020Bible { get; private set; }
    public string m_Punjabi2021Bible { get; private set; }
    public string m_Punjabi2022Bible { get; private set; }
    public string m_Punjabi2023Bible { get; private set; }
    public string m_PunjabiBible { get; private set; }
    public string m_PunjabiERVBible { get; private set; }
    public string m_PunjabiIRVBible { get; private set; }
    public string m_QeqchiBible { get; private set; }
    public string m_Quechuan2010Bible { get; private set; }
    public string m_QuechuanBible { get; private set; }
    public string m_QuechuanQVBMBible { get; private set; }
    public string m_QuechuanQVSBible { get; private set; }
    public string m_QuechuanQVWBible { get; private set; }
    public string m_QuechuanQXOBible { get; private set; }
    public string m_Romani2004Bible { get; private set; }
    public string m_Romani2007Bible { get; private set; }
    public string m_Romanian1928Bible { get; private set; }
    public string m_Romanian1931Bible { get; private set; }
    public string m_Romanian2009Bible { get; private set; }
    public string m_Romanian2014Bible { get; private set; }
    public string m_Romanian2015Bible { get; private set; }
    public string m_Romanian2018Bible { get; private set; }
    public string m_Romanian2020Bible { get; private set; }
    public string m_Romanian2021Bible { get; private set; }
    public string m_Romanian2022Bible { get; private set; }
    public string m_Romanian2023Bible { get; private set; }
    public string m_RomanianBDKBible { get; private set; }
    public string m_RomanianBible { get; private set; }
    public string m_RomanianSBIRBible { get; private set; }
    public string m_RomaniBACHROBible { get; private set; }
    public string m_RomaniBaltic2019Bible { get; private set; }
    public string m_RomaniBalticLT2019Bible { get; private set; }
    public string m_RomaniBible { get; private set; }
    public string m_RomaniCHERGASHBible { get; private set; }
    public string m_RomaniGSPBible { get; private set; }
    public string m_RomaniKALD2004Bible { get; private set; }
    public string m_RomaniKALD2020Bible { get; private set; }
    public string m_RomaniRMCBible { get; private set; }
    public string m_RomaniROM07Bible { get; private set; }
    public string m_RomaniROM6Bible { get; private set; }
    public string m_RomaniSERBible { get; private set; }
    public string m_RomaniSINT2024Bible { get; private set; }
    public string m_Russian2012Bible { get; private set; }
    public string m_RussianAGPBible { get; private set; }
    public string m_RussianBTI2015Bible { get; private set; }
    public string m_RussianCARSABible { get; private set; }
    public string m_RussianCARSBible { get; private set; }
    public string m_RussianCASBible { get; private set; }
    public string m_RussianCSLAVBible { get; private set; }
    public string m_RussianJewishBible { get; private set; }
    public string m_RussianJubileeBible { get; private set; }
    public string m_RussianMengeBible { get; private set; }
    public string m_RussianNRTBible { get; private set; }
    public string m_RussianReceptusBible { get; private set; }
    public string m_RussianRSPBible { get; private set; }
    public string m_RussianRSTBible { get; private set; }
    public string m_RussianSlovoBible { get; private set; }
    public string m_RussianSynodalBible { get; private set; }
    public string m_RussianWBTCBible { get; private set; }
    public string m_SadriBible { get; private set; }
    public string m_SanskritDevanagariBible { get; private set; }
    public string m_SantaliBangladeshBible { get; private set; }
    public string m_SantaliCommonBible { get; private set; }
    public string m_SasakBible { get; private set; }
    public string m_Sena2014Bible { get; private set; }
    public string m_SenaBible { get; private set; }
    public string m_SenaMalawiBible { get; private set; }
    public string m_SeraikiBible { get; private set; }
    public string m_SerbianBible { get; private set; }
    public string m_SerbianCNZBible { get; private set; }
    public string m_SerbianERVBible { get; private set; }
    public string m_SerbianLatinBible { get; private set; }
    public string m_SerbianNSTBible { get; private set; }
    public string m_SerbianNSTLBible { get; private set; }
    public string m_SerbianSDSBible { get; private set; }
    public string m_ShanBible { get; private set; }
    public string m_ShanNCLBible { get; private set; }
    public string m_ShekhawatiBible { get; private set; }
    public string m_ShillukBible { get; private set; }
    public string m_Shona1949Bible { get; private set; }
    public string m_Shona2002Bible { get; private set; }
    public string m_ShonaBDSCBible { get; private set; }
    public string m_ShonaBible { get; private set; }
    public string m_ShonaSCLBBible { get; private set; }
    public string m_ShonaSUBBible { get; private set; }
    public string m_SidamoBible { get; private set; }
    public string m_SindhiBible { get; private set; }
    public string m_SindhiCommonBible { get; private set; }
    public string m_SindhiHinduBible { get; private set; }
    public string m_SindhiMuslimBible { get; private set; }
    public string m_SinhalaNRSVBible { get; private set; }
    public string m_SinhalaSCVBible { get; private set; }
    public string m_SinhalaSNRVBible { get; private set; }
    public string m_SinhalaSROVBible { get; private set; }
    public string m_SiswatiBible { get; private set; }
    public string m_Slovakian2015Bible { get; private set; }
    public string m_Slovakian2017Bible { get; private set; }
    public string m_SlovakianBible { get; private set; }
    public string m_SlovakianNPK2023Bible { get; private set; }
    public string m_SlovakianNPKBible { get; private set; }
    public string m_SlovakianRomaniBible { get; private set; }
    public string m_SlovakianSEBBible { get; private set; }
    public string m_SlovakianSLBBible { get; private set; }
    public string m_SlovakianSSVBible { get; private set; }
    public string m_Slovenian1584Bible { get; private set; }
    public string m_Slovenian1882Bible { get; private set; }
    public string m_Slovenian1928Bible { get; private set; }
    public string m_Slovenian1990Bible { get; private set; }
    public string m_Slovenian2014Bible { get; private set; }
    public string m_SlovenianBible { get; private set; }
    public string m_SlovenianEKUBible { get; private set; }
    public string m_SlovenianSSPBible { get; private set; }
    public string m_SogaBible { get; private set; }
    public string m_Somalian2018Bible { get; private set; }
    public string m_Somalian2024Bible { get; private set; }
    public string m_SomalianBible { get; private set; }
    public string m_SongeBible { get; private set; }
    public string m_Sotho1951Bible { get; private set; }
    public string m_Sotho1989Bible { get; private set; }
    public string m_Sotho2000Bible { get; private set; }
    public string m_SothoBible { get; private set; }
    public string m_Spanish1569Bible { get; private set; }
    public string m_Spanish1858Bible { get; private set; }
    public string m_Spanish1989Bible { get; private set; }
    public string m_SpanishBDOBible { get; private set; }
    public string m_SpanishBHTIBible { get; private set; }
    public string m_SpanishBible { get; private set; }
    public string m_SpanishBLPBible { get; private set; }
    public string m_SpanishBLPHBible { get; private set; }
    public string m_SpanishBTIBible { get; private set; }
    public string m_SpanishBTXBible { get; private set; }
    public string m_SpanishDHHBible { get; private set; }
    public string m_SpanishJBSBible { get; private set; }
    public string m_SpanishLBLABible { get; private set; }
    public string m_SpanishNBLABible { get; private set; }
    public string m_SpanishNBVBible { get; private set; }
    public string m_SpanishNTBIZBible { get; private set; }
    public string m_SpanishNTVBible { get; private set; }
    public string m_SpanishNVIBible { get; private set; }
    public string m_SpanishNVISBible { get; private set; }
    public string m_SpanishPDTBible { get; private set; }
    public string m_SpanishRevisedRVR1960Bible { get; private set; }
    public string m_SpanishRV2020Bible { get; private set; }
    public string m_SpanishRVA2015Bible { get; private set; }
    public string m_SpanishRVCBible { get; private set; }
    public string m_SpanishRVESBible { get; private set; }
    public string m_SpanishRVGBible { get; private set; }
    public string m_SpanishRVR1960Bible { get; private set; }
    public string m_SpanishRVR1995Bible { get; private set; }
    public string m_SpanishTLABible { get; private set; }
    public string m_SpanishVBL2022Bible { get; private set; }
    public string m_SpanishVBLBible { get; private set; }
    public string m_Sukuma1960Bible { get; private set; }
    public string m_SukumaBible { get; private set; }
    public string m_SundaneseBible { get; private set; }
    public string m_Swahili1850Bible { get; private set; }
    public string m_Swahili2001Bible { get; private set; }
    public string m_Swahili2017Bible { get; private set; }
    public string m_Swahili2024Bible { get; private set; }
    public string m_SwahiliBHNTLKBible { get; private set; }
    public string m_SwahiliBible { get; private set; }
    public string m_SwahiliContemporaryBible { get; private set; }
    public string m_SwahiliNMMBible { get; private set; }
    public string m_SwahiliRSUVDCBible { get; private set; }
    public string m_SwahiliSCLDC10Bible { get; private set; }
    public string m_SwahiliSRB37Bible { get; private set; }
    public string m_SwahiliSUVBible { get; private set; }
    public string m_SwahiliSWC02Bible { get; private set; }
    public string m_SwahiliSWZZB1921Bible { get; private set; }
    public string m_Swedish1873Bible { get; private set; }
    public string m_Swedish2000Bible { get; private set; }
    public string m_Swedish2015Bible { get; private set; }
    public string m_Swedish2019Bible { get; private set; }
    public string m_SwedishBible { get; private set; }
    public string m_SwedishFolkBible { get; private set; }
    public string m_SwedishNLBBible { get; private set; }
    public string m_SwedishSB2016Bible { get; private set; }
    public string m_SwedishSFBBible { get; private set; }
    public string m_SylhetiBible { get; private set; }
    public string m_SylhetiSYLLBible { get; private set; }
    public string m_Tagalog2001Bible { get; private set; }
    public string m_Tagalog2005Bible { get; private set; }
    public string m_Tagalog2012Bible { get; private set; }
    public string m_Tagalog2015Bible { get; private set; }
    public string m_TagalogBible { get; private set; }
    public string m_TagalogRevised2005Bible { get; private set; }
    public string m_TagalogTLBABible { get; private set; }
    public string m_Tajik1992Bible { get; private set; }
    public string m_TajikKMOBible { get; private set; }
    public string m_TajikNTBible { get; private set; }
    public string m_TamasheqBible { get; private set; }
    public string m_Tamil2017Bible { get; private set; }
    public string m_TamilBible { get; private set; }
    public string m_TamilIRVBible { get; private set; }
    public string m_TamilRomanisedBible { get; private set; }
    public string m_TamilTCVBible { get; private set; }
    public string m_TamilTRVBible { get; private set; }
    public string m_TamilWBTCBible { get; private set; }
    public string m_TarifitBible { get; private set; }
    public string m_TashelhaytMoroccoBible { get; private set; }
    public string m_Tatar2001Bible { get; private set; }
    public string m_Tatar2015Bible { get; private set; }
    public string m_Tatar2025Bible { get; private set; }
    public string m_TatarRBBLBible { get; private set; }
    public string m_Telugu2016Bible { get; private set; }
    public string m_Telugu2019Bible { get; private set; }
    public string m_TeluguBible { get; private set; }
    public string m_TeluguTCVBible { get; private set; }
    public string m_TeluguWBTCBible { get; private set; }
    public string m_Teso2020Bible { get; private set; }
    public string m_TesoBible { get; private set; }
    public string m_ThadoBible { get; private set; }
    public string m_Thai1940Bible { get; private set; }
    public string m_Thai1971Bible { get; private set; }
    public string m_ThaiBible { get; private set; }
    public string m_ThaiERVBible { get; private set; }
    public string m_ThaiKJVBible { get; private set; }
    public string m_ThaiNTVBible { get; private set; }
    public string m_ThaiTCVBible { get; private set; }
    public string m_ThaiTHSBible { get; private set; }
    public string m_ThaiTNCVBible { get; private set; }
    public string m_TibetianBible { get; private set; }
    public string m_TibetianCBTBible { get; private set; }
    public string m_TivBible { get; private set; }
    public string m_Tshiluba1996Bible { get; private set; }
    public string m_Tshiluba2003Bible { get; private set; }
    public string m_TshivendaBible { get; private set; }
    public string m_Tsonga1989Bible { get; private set; }
    public string m_Tsonga2014Bible { get; private set; }
    public string m_Tsonga2024Bible { get; private set; }
    public string m_TsongaBible { get; private set; }
    public string m_Tswana1890Bible { get; private set; }
    public string m_Tswana1970Bible { get; private set; }
    public string m_Tswana1993Bible { get; private set; }
    public string m_Tswana2024Bible { get; private set; }
    public string m_TswanaBible { get; private set; }
    public string m_TuluBible { get; private set; }
    public string m_TurkanaBible { get; private set; }
    public string m_TurkishBible { get; private set; }
    public string m_TurkishHADIBible { get; private set; }
    public string m_TurkishKKDEUBible { get; private set; }
    public string m_TurkishKMEYABible { get; private set; }
    public string m_TurkishNTBBible { get; private set; }
    public string m_TurkishTKKBible { get; private set; }
    public string m_TurkishTTTBible { get; private set; }
    public string m_TurkishYTCBible { get; private set; }
    public string m_Turkmen2016Bible { get; private set; }
    public string m_TurkmenCyrillic2002Bible { get; private set; }
    public string m_TurkmenLatin2002Bible { get; private set; }
    public string m_TurkmenLatin2017Bible { get; private set; }
    public string m_TwiAkuapemBible { get; private set; }
    public string m_TwiAsanteBible { get; private set; }
    public string m_TwiDCBible { get; private set; }
    public string m_TwiKronkronBible { get; private set; }
    public string m_TwiRevisedBible { get; private set; }
    public string m_Ukrainian1903Bible { get; private set; }
    public string m_Ukrainian1905Bible { get; private set; }
    public string m_Ukrainian2004Bible { get; private set; }
    public string m_Ukrainian2006Bible { get; private set; }
    public string m_Ukrainian2011Bible { get; private set; }
    public string m_Ukrainian2021Bible { get; private set; }
    public string m_Ukrainian2022Bible { get; private set; }
    public string m_UkrainianBible { get; private set; }
    public string m_UkrainianHOMBible { get; private set; }
    public string m_UkrainianTUBBible { get; private set; }
    public string m_UkrainianUKDERBible { get; private set; }
    public string m_UkrainianUMTBible { get; private set; }
    public string m_UmbunduBible { get; private set; }
    public string m_Urdu2017Bible { get; private set; }
    public string m_UrduBible { get; private set; }
    public string m_UrduDGVBible { get; private set; }
    public string m_UrduGVRBible { get; private set; }
    public string m_UrduIRVURDBible { get; private set; }
    public string m_UrduUCVBible { get; private set; }
    public string m_UrduUCVDBible { get; private set; }
    public string m_UrduUGVBible { get; private set; }
    public string m_UrduURDBible { get; private set; }
    public string m_UrduURDGVHBible { get; private set; }
    public string m_UrduURDR55Bible { get; private set; }
    public string m_UyghurArabicBible { get; private set; }
    public string m_UyghurCyrillicBible { get; private set; }
    public string m_UyghurLatinBible { get; private set; }
    public string m_UzbekUZBBible { get; private set; }
    public string m_UzbekUZCBible { get; private set; }
    public string m_UzbekUZLBCBible { get; private set; }
    public string m_Vietnamese1994Bible { get; private set; }
    public string m_Vietnamese2011Bible { get; private set; }
    public string m_Vietnamese2015Bible { get; private set; }
    public string m_VietnameseBible { get; private set; }
    public string m_VietnameseERVBible { get; private set; }
    public string m_VietnameseNVBBible { get; private set; }
    public string m_VietnameseVIEBible { get; private set; }
    public string m_WarayBible { get; private set; }
    public string m_Welsh1894Bible { get; private set; }
    public string m_Welsh1945Bible { get; private set; }
    public string m_Welsh2015Bible { get; private set; }
    public string m_WelshBible { get; private set; }
    public string m_WelshBMWBible { get; private set; }
    public string m_WelshCTEBible { get; private set; }
    public string m_WelshSBYBible { get; private set; }
    public string m_WolayttaBible { get; private set; }
    public string m_WolofBible { get; private set; }
    public string m_WolofKYGBible { get; private set; }
    public string m_Xhosa1920Bible { get; private set; }
    public string m_Xhosa1996Bible { get; private set; }
    public string m_Xhosa2022Bible { get; private set; }
    public string m_XhosaBible { get; private set; }
    public string m_Yoruba2010Bible { get; private set; }
    public string m_Yoruba2014Bible { get; private set; }
    public string m_YorubaBible { get; private set; }
    public string m_ZandeBible { get; private set; }
    public string m_ZarmaBible { get; private set; }
    public string m_Zulu2020Bible { get; private set; }
    public string m_Zulu2023Bible { get; private set; }
    public string m_ZuluBible { get; private set; }

    public void SetID(int ID) { m_ID = ID; }
    public void SetEnglish(string English) { m_English = English; }
    public void SetKorean(string Korean) { m_Korean = Korean; }
    public void SetCount(int Count) { m_Count = Count; }
    public void SetEnglishTarget(string EnglishTarget) { m_EnglishTarget = EnglishTarget; }
    public void SetNIV(string NIV) { m_NIV = NIV; }
    public void SetKoreanTarget(string KoreanTarget) { m_KoreanTarget = KoreanTarget; }
    public void SetSource(string Source) { m_Source = Source; }
    public void SetEasyBible(string EasyBible) { m_EasyBible = EasyBible; }
    public void SetRevisedHangul(string RevisedHangul) { m_RevisedHangul = RevisedHangul; }
    public void SetRevisedRevision(string RevisedRevision) { m_RevisedRevision = RevisedRevision; }
    public void SetJointTranslation(string JointTranslation) { m_JointTranslation = JointTranslation; }
    public void SetNewStandardTranslation(string NewStandardTranslation) { m_NewStandardTranslation = NewStandardTranslation; }
    public void SetKoreanBible(string KoreanBible) { m_KoreanBible = KoreanBible; }
    public void SetSourceEnglish(string SourceEnglish) { m_SourceEnglish = SourceEnglish; }
    public void SetKJV(string KJV) { m_KJV = KJV; }
    public void SetNewKJV(string NewKJV) { m_NewKJV = NewKJV; }
    public void SetESV(string ESV) { m_ESV = ESV; }
    public void SetNewRSV(string NewRSV) { m_NewRSV = NewRSV; }
    public void SetNASB(string NASB) { m_NASB = NASB; }
    public void Setafri(string afri) { m_afri = afri; }
    public void Setalbanian(string albanian) { m_albanian = albanian; }
    public void Setchinese_union_simp(string chinese_union_simp) { m_chinese_union_simp = chinese_union_simp; }
    public void Setchinese_union_trad(string chinese_union_trad) { m_chinese_union_trad = chinese_union_trad; }
    public void Setckjv_sds(string ckjv_sds) { m_ckjv_sds = ckjv_sds; }
    public void Setckjv_sdt(string ckjv_sdt) { m_ckjv_sdt = ckjv_sdt; }
    public void Setbkr(string bkr) { m_bkr = bkr; }
    public void Setstve(string stve) { m_stve = stve; }
    public void Setfinn(string finn) { m_finn = finn; }
    public void Setepee(string epee) { m_epee = epee; }
    public void Setmartin(string martin) { m_martin = martin; }
    public void Setoster(string oster) { m_oster = oster; }
    public void Setsegond_1910(string segond_1910) { m_segond_1910 = segond_1910; }
    public void Setelberfelder_1871(string elberfelder_1871) { m_elberfelder_1871 = elberfelder_1871; }
    public void Setelberfelder_1905(string elberfelder_1905) { m_elberfelder_1905 = elberfelder_1905; }
    public void Setluther(string luther) { m_luther = luther; }
    public void Setluther_1912(string luther_1912) { m_luther_1912 = luther_1912; }
    public void Setschlachter(string schlachter) { m_schlachter = schlachter; }
    public void Setwlc(string wlc) { m_wlc = wlc; }
    public void Setirv(string irv) { m_irv = irv; }
    public void Setkaroli(string karoli) { m_karoli = karoli; }
    public void Setindo_tb(string indo_tb) { m_indo_tb = indo_tb; }
    public void Setindo_tm(string indo_tm) { m_indo_tm = indo_tm; }
    public void Setdiodati(string diodati) { m_diodati = diodati; }
    public void Setbungo(string bungo) { m_bungo = bungo; }
    public void Setkougo(string kougo) { m_kougo = kougo; }
    public void Setmaori(string maori) { m_maori = maori; }
    public void Setopt(string opt) { m_opt = opt; }
    public void Setpol_nbg(string pol_nbg) { m_pol_nbg = pol_nbg; }
    public void Setpol_ubg(string pol_ubg) { m_pol_ubg = pol_ubg; }
    public void Setpolbg(string polbg) { m_polbg = polbg; }
    public void Setalmeida_ra(string almeida_ra) { m_almeida_ra = almeida_ra; }
    public void Setalmeida_rc(string almeida_rc) { m_almeida_rc = almeida_rc; }
    public void Setblivre(string blivre) { m_blivre = blivre; }
    public void Setfidela(string fidela) { m_fidela = fidela; }
    public void Setsynodal(string synodal) { m_synodal = synodal; }
    public void Setrv_1909(string rv_1909) { m_rv_1909 = rv_1909; }
    public void Setrvg(string rvg) { m_rvg = rvg; }
    public void Setrvg_2004(string rvg_2004) { m_rvg_2004 = rvg_2004; }
    public void Setsagradas(string sagradas) { m_sagradas = sagradas; }
    public void Settagab(string tagab) { m_tagab = tagab; }
    public void Setthaikjv(string thaikjv) { m_thaikjv = thaikjv; }
    public void Setturkish(string turkish) { m_turkish = turkish; }
    public void Setcadman(string cadman) { m_cadman = cadman; }
    public void SetPortuguese(string Portuguese) { m_Portuguese = Portuguese; }
    public void SetGerman(string German) { m_German = German; }
    public void SetJapanese(string Japanese) { m_Japanese = Japanese; }
    public void SetChinese(string Chinese) { m_Chinese = Chinese; }
    public void SetRomanian(string Romanian) { m_Romanian = Romanian; }
    public void SetFrench(string French) { m_French = French; }
    public void SetSpanish(string Spanish) { m_Spanish = Spanish; }
    public void SetItalian(string Italian) { m_Italian = Italian; }
    public void SetHungarian(string Hungarian) { m_Hungarian = Hungarian; }
    public void SetRussian(string Russian) { m_Russian = Russian; }
    public void SetHindi(string Hindi) { m_Hindi = Hindi; }
    public void SetAcehBible(string AcehBible) { m_AcehBible = AcehBible; }
    public void SetAdilabadGondiBible(string AdilabadGondiBible) { m_AdilabadGondiBible = AdilabadGondiBible; }
    public void SetAfrikaans1983Bible(string Afrikaans1983Bible) { m_Afrikaans1983Bible = Afrikaans1983Bible; }
    public void SetAfrikaans2020Bible(string Afrikaans2020Bible) { m_Afrikaans2020Bible = Afrikaans2020Bible; }
    public void SetAfrikaans2023Bible(string Afrikaans2023Bible) { m_Afrikaans2023Bible = Afrikaans2023Bible; }
    public void SetAfrikaansABABible(string AfrikaansABABible) { m_AfrikaansABABible = AfrikaansABABible; }
    public void SetAfrikaansBible(string AfrikaansBible) { m_AfrikaansBible = AfrikaansBible; }
    public void SetAfrikaansDBBible(string AfrikaansDBBible) { m_AfrikaansDBBible = AfrikaansDBBible; }
    public void SetAfrikaansNLVBible(string AfrikaansNLVBible) { m_AfrikaansNLVBible = AfrikaansNLVBible; }
    public void SetAhiraniBible(string AhiraniBible) { m_AhiraniBible = AhiraniBible; }
    public void SetAlbanian1872Bible(string Albanian1872Bible) { m_Albanian1872Bible = Albanian1872Bible; }
    public void SetAlbanian1879Bible(string Albanian1879Bible) { m_Albanian1879Bible = Albanian1879Bible; }
    public void SetAlbanian2018Bible(string Albanian2018Bible) { m_Albanian2018Bible = Albanian2018Bible; }
    public void SetAlbanianBible(string AlbanianBible) { m_AlbanianBible = AlbanianBible; }
    public void SetAmharic2000Bible(string Amharic2000Bible) { m_Amharic2000Bible = Amharic2000Bible; }
    public void SetAmharicBible(string AmharicBible) { m_AmharicBible = AmharicBible; }
    public void SetAmharicCatholicBible(string AmharicCatholicBible) { m_AmharicCatholicBible = AmharicCatholicBible; }
    public void SetAmharicDawroBible(string AmharicDawroBible) { m_AmharicDawroBible = AmharicDawroBible; }
    public void SetAmharicDawroDFBEBible(string AmharicDawroDFBEBible) { m_AmharicDawroDFBEBible = AmharicDawroDFBEBible; }
    public void SetAmharicDawroDFBLVLBible(string AmharicDawroDFBLVLBible) { m_AmharicDawroDFBLVLBible = AmharicDawroDFBLVLBible; }
    public void SetAmharicDawroDWRNTBible(string AmharicDawroDWRNTBible) { m_AmharicDawroDWRNTBible = AmharicDawroDWRNTBible; }
    public void SetAmharicDawroWWIBible(string AmharicDawroWWIBible) { m_AmharicDawroWWIBible = AmharicDawroWWIBible; }
    public void SetAmharicGamo2017Bible(string AmharicGamo2017Bible) { m_AmharicGamo2017Bible = AmharicGamo2017Bible; }
    public void SetAmharicGamoBible(string AmharicGamoBible) { m_AmharicGamoBible = AmharicGamoBible; }
    public void SetAmharicGamoGMBible(string AmharicGamoGMBible) { m_AmharicGamoGMBible = AmharicGamoGMBible; }
    public void SetAmharicGamoWordBible(string AmharicGamoWordBible) { m_AmharicGamoWordBible = AmharicGamoWordBible; }
    public void SetAmharicGofaBible(string AmharicGofaBible) { m_AmharicGofaBible = AmharicGofaBible; }
    public void SetAmharicGofaGFBEVFBible(string AmharicGofaGFBEVFBible) { m_AmharicGofaGFBEVFBible = AmharicGofaGFBEVFBible; }
    public void SetAmharicGofaGFBLVFBible(string AmharicGofaGFBLVFBible) { m_AmharicGofaGFBLVFBible = AmharicGofaGFBLVFBible; }
    public void SetAmharicGofaRNTBible(string AmharicGofaRNTBible) { m_AmharicGofaRNTBible = AmharicGofaRNTBible; }
    public void SetAmharicGofaWWIBible(string AmharicGofaWWIBible) { m_AmharicGofaWWIBible = AmharicGofaWWIBible; }
    public void SetAmharicNASVBible(string AmharicNASVBible) { m_AmharicNASVBible = AmharicNASVBible; }
    public void SetAmharicNSTBible(string AmharicNSTBible) { m_AmharicNSTBible = AmharicNSTBible; }
    public void SetAmharicTigrinya15Bible(string AmharicTigrinya15Bible) { m_AmharicTigrinya15Bible = AmharicTigrinya15Bible; }
    public void SetAmharicTigrinya2024Bible(string AmharicTigrinya2024Bible) { m_AmharicTigrinya2024Bible = AmharicTigrinya2024Bible; }
    public void SetAmharicTigrinyaBible(string AmharicTigrinyaBible) { m_AmharicTigrinyaBible = AmharicTigrinyaBible; }
    public void SetArabic1978Bible(string Arabic1978Bible) { m_Arabic1978Bible = Arabic1978Bible; }
    public void SetArabic2016Bible(string Arabic2016Bible) { m_Arabic2016Bible = Arabic2016Bible; }
    public void SetArabic2018Bible(string Arabic2018Bible) { m_Arabic2018Bible = Arabic2018Bible; }
    public void SetArabic2023Bible(string Arabic2023Bible) { m_Arabic2023Bible = Arabic2023Bible; }
    public void SetArabicAlgeriaBible(string ArabicAlgeriaBible) { m_ArabicAlgeriaBible = ArabicAlgeriaBible; }
    public void SetArabicAPDBible(string ArabicAPDBible) { m_ArabicAPDBible = ArabicAPDBible; }
    public void SetArabicAVDBible(string ArabicAVDBible) { m_ArabicAVDBible = ArabicAVDBible; }
    public void SetArabicAVDDVBible(string ArabicAVDDVBible) { m_ArabicAVDDVBible = ArabicAVDDVBible; }
    public void SetArabicBible(string ArabicBible) { m_ArabicBible = ArabicBible; }
    public void SetArabicERVBible(string ArabicERVBible) { m_ArabicERVBible = ArabicERVBible; }
    public void SetArabicGNABible(string ArabicGNABible) { m_ArabicGNABible = ArabicGNABible; }
    public void SetArabicGOVBible(string ArabicGOVBible) { m_ArabicGOVBible = ArabicGOVBible; }
    public void SetArabicLABible(string ArabicLABible) { m_ArabicLABible = ArabicLABible; }
    public void SetArabicLebaneseBible(string ArabicLebaneseBible) { m_ArabicLebaneseBible = ArabicLebaneseBible; }
    public void SetArabicMorocco2023Bible(string ArabicMorocco2023Bible) { m_ArabicMorocco2023Bible = ArabicMorocco2023Bible; }
    public void SetArabicMoroccoBible(string ArabicMoroccoBible) { m_ArabicMoroccoBible = ArabicMoroccoBible; }
    public void SetArabicSABBible(string ArabicSABBible) { m_ArabicSABBible = ArabicSABBible; }
    public void SetArabicSABible(string ArabicSABible) { m_ArabicSABible = ArabicSABible; }
    public void SetArabicSVDBible(string ArabicSVDBible) { m_ArabicSVDBible = ArabicSVDBible; }
    public void SetArabicTMABible(string ArabicTMABible) { m_ArabicTMABible = ArabicTMABible; }
    public void SetArabicTU2022Bible(string ArabicTU2022Bible) { m_ArabicTU2022Bible = ArabicTU2022Bible; }
    public void SetArabicTunisianBible(string ArabicTunisianBible) { m_ArabicTunisianBible = ArabicTunisianBible; }
    public void SetAramaicBible(string AramaicBible) { m_AramaicBible = AramaicBible; }
    public void SetArmenian1853Bible(string Armenian1853Bible) { m_Armenian1853Bible = Armenian1853Bible; }
    public void SetArmenian2017Bible(string Armenian2017Bible) { m_Armenian2017Bible = Armenian2017Bible; }
    public void SetArmenian2018Bible(string Armenian2018Bible) { m_Armenian2018Bible = Armenian2018Bible; }
    public void SetArmenian2019Bible(string Armenian2019Bible) { m_Armenian2019Bible = Armenian2019Bible; }
    public void SetArmenianAraratBible(string ArmenianAraratBible) { m_ArmenianAraratBible = ArmenianAraratBible; }
    public void SetArmenianBible(string ArmenianBible) { m_ArmenianBible = ArmenianBible; }
    public void SetArmenianEasternBible(string ArmenianEasternBible) { m_ArmenianEasternBible = ArmenianEasternBible; }
    public void SetArmenianNEABible(string ArmenianNEABible) { m_ArmenianNEABible = ArmenianNEABible; }
    public void SetAssameseBible(string AssameseBible) { m_AssameseBible = AssameseBible; }
    public void SetAvarBible(string AvarBible) { m_AvarBible = AvarBible; }
    public void SetAwadhiBible(string AwadhiBible) { m_AwadhiBible = AwadhiBible; }
    public void SetAymara1986Bible(string Aymara1986Bible) { m_Aymara1986Bible = Aymara1986Bible; }
    public void SetAymara1997Bible(string Aymara1997Bible) { m_Aymara1997Bible = Aymara1997Bible; }
    public void SetAymaraBible(string AymaraBible) { m_AymaraBible = AymaraBible; }
    public void SetAzerbaijan2013Bible(string Azerbaijan2013Bible) { m_Azerbaijan2013Bible = Azerbaijan2013Bible; }
    public void SetAzerbaijanBible(string AzerbaijanBible) { m_AzerbaijanBible = AzerbaijanBible; }
    public void SetAzerbaijanSouthBible(string AzerbaijanSouthBible) { m_AzerbaijanSouthBible = AzerbaijanSouthBible; }
    public void SetBagriBible(string BagriBible) { m_BagriBible = BagriBible; }
    public void SetBalineseBible(string BalineseBible) { m_BalineseBible = BalineseBible; }
    public void SetBalochiArabicBible(string BalochiArabicBible) { m_BalochiArabicBible = BalochiArabicBible; }
    public void SetBalochiBible(string BalochiBible) { m_BalochiBible = BalochiBible; }
    public void SetBalochiSoutherenBible(string BalochiSoutherenBible) { m_BalochiSoutherenBible = BalochiSoutherenBible; }
    public void SetBalochiSoutherenLatinBible(string BalochiSoutherenLatinBible) { m_BalochiSoutherenLatinBible = BalochiSoutherenLatinBible; }
    public void SetBaoule1974Bible(string Baoule1974Bible) { m_Baoule1974Bible = Baoule1974Bible; }
    public void SetBaoule1998Bible(string Baoule1998Bible) { m_Baoule1998Bible = Baoule1998Bible; }
    public void SetBaouleBible(string BaouleBible) { m_BaouleBible = BaouleBible; }
    public void SetBashkir2023Bible(string Bashkir2023Bible) { m_Bashkir2023Bible = Bashkir2023Bible; }
    public void SetBashkirBible(string BashkirBible) { m_BashkirBible = BashkirBible; }
    public void SetBasqueBible(string BasqueBible) { m_BasqueBible = BasqueBible; }
    public void SetBasque2008Bible(string Basque2008Bible) { m_Basque2008Bible = Basque2008Bible; }
    public void SetBavarianBible(string BavarianBible) { m_BavarianBible = BavarianBible; }
    public void SetBelarusian2017Bible(string Belarusian2017Bible) { m_Belarusian2017Bible = Belarusian2017Bible; }
    public void SetBelarusianBible(string BelarusianBible) { m_BelarusianBible = BelarusianBible; }
    public void SetBelarusianBokunBible(string BelarusianBokunBible) { m_BelarusianBokunBible = BelarusianBokunBible; }
    public void SetBelarusianCHNTBible(string BelarusianCHNTBible) { m_BelarusianCHNTBible = BelarusianCHNTBible; }
    public void SetBelarusianNTJSBible(string BelarusianNTJSBible) { m_BelarusianNTJSBible = BelarusianNTJSBible; }
    public void SetBembaBible(string BembaBible) { m_BembaBible = BembaBible; }
    public void SetBengali2017Bible(string Bengali2017Bible) { m_Bengali2017Bible = Bengali2017Bible; }
    public void SetBengali2023Bible(string Bengali2023Bible) { m_Bengali2023Bible = Bengali2023Bible; }
    public void SetBengaliBACIBBible(string BengaliBACIBBible) { m_BengaliBACIBBible = BengaliBACIBBible; }
    public void SetBengaliBCVBible(string BengaliBCVBible) { m_BengaliBCVBible = BengaliBCVBible; }
    public void SetBengaliBible(string BengaliBible) { m_BengaliBible = BengaliBible; }
    public void SetBengaliBSIBible(string BengaliBSIBible) { m_BengaliBSIBible = BengaliBSIBible; }
    public void SetBengaliCLBSIBible(string BengaliCLBSIBible) { m_BengaliCLBSIBible = BengaliCLBSIBible; }
    public void SetBengaliERVBible(string BengaliERVBible) { m_BengaliERVBible = BengaliERVBible; }
    public void SetBengaliIRVBENBible(string BengaliIRVBENBible) { m_BengaliIRVBENBible = BengaliIRVBENBible; }
    public void SetBengaliMBCLBible(string BengaliMBCLBible) { m_BengaliMBCLBible = BengaliMBCLBible; }
    public void SetBengaliSBCLBible(string BengaliSBCLBible) { m_BengaliSBCLBible = BengaliSBCLBible; }
    public void SetBerberBible(string BerberBible) { m_BerberBible = BerberBible; }
    public void SetBhilaliBible(string BhilaliBible) { m_BhilaliBible = BhilaliBible; }
    public void SetBodoBible(string BodoBible) { m_BodoBible = BodoBible; }
    public void SetBodoNTBPL20Bible(string BodoNTBPL20Bible) { m_BodoNTBPL20Bible = BodoNTBPL20Bible; }
    public void SetBosnianBible(string BosnianBible) { m_BosnianBible = BosnianBible; }
    public void SetBrajBible(string BrajBible) { m_BrajBible = BrajBible; }
    public void SetBugisBible(string BugisBible) { m_BugisBible = BugisBible; }
    public void SetBulgarian2015Bible(string Bulgarian2015Bible) { m_Bulgarian2015Bible = Bulgarian2015Bible; }
    public void SetBulgarianBible(string BulgarianBible) { m_BulgarianBible = BulgarianBible; }
    public void SetBulgarianBOBBible(string BulgarianBOBBible) { m_BulgarianBOBBible = BulgarianBOBBible; }
    public void SetBulgarianBPBBible(string BulgarianBPBBible) { m_BulgarianBPBBible = BulgarianBPBBible; }
    public void SetBulgarianCBTBible(string BulgarianCBTBible) { m_BulgarianCBTBible = BulgarianCBTBible; }
    public void SetBulgarianSPBBible(string BulgarianSPBBible) { m_BulgarianSPBBible = BulgarianSPBBible; }
    public void SetBulgarianTZABible(string BulgarianTZABible) { m_BulgarianTZABible = BulgarianTZABible; }
    public void SetBulgarianVerensBible(string BulgarianVerensBible) { m_BulgarianVerensBible = BulgarianVerensBible; }
    public void SetBundeliBible(string BundeliBible) { m_BundeliBible = BundeliBible; }
    public void SetBurmese1928Bible(string Burmese1928Bible) { m_Burmese1928Bible = Burmese1928Bible; }
    public void SetBurmese2021Bible(string Burmese2021Bible) { m_Burmese2021Bible = Burmese2021Bible; }
    public void SetBurmeseBCLBible(string BurmeseBCLBible) { m_BurmeseBCLBible = BurmeseBCLBible; }
    public void SetBurmeseBible(string BurmeseBible) { m_BurmeseBible = BurmeseBible; }
    public void SetBurmeseJBZVBible(string BurmeseJBZVBible) { m_BurmeseJBZVBible = BurmeseJBZVBible; }
    public void SetBurmeseMCLZVBible(string BurmeseMCLZVBible) { m_BurmeseMCLZVBible = BurmeseMCLZVBible; }
    public void SetBurmeseMSBUBible(string BurmeseMSBUBible) { m_BurmeseMSBUBible = BurmeseMSBUBible; }
    public void SetBurmeseMSBZBible(string BurmeseMSBZBible) { m_BurmeseMSBZBible = BurmeseMSBZBible; }
    public void SetCatalanBCIBible(string CatalanBCIBible) { m_CatalanBCIBible = CatalanBCIBible; }
    public void SetCatalanBECBible(string CatalanBECBible) { m_CatalanBECBible = CatalanBECBible; }
    public void SetCebuano1999Bible(string Cebuano1999Bible) { m_Cebuano1999Bible = Cebuano1999Bible; }
    public void SetCebuano2011Bible(string Cebuano2011Bible) { m_Cebuano2011Bible = Cebuano2011Bible; }
    public void SetCebuanoAPSDBible(string CebuanoAPSDBible) { m_CebuanoAPSDBible = CebuanoAPSDBible; }
    public void SetCebuanoBible(string CebuanoBible) { m_CebuanoBible = CebuanoBible; }
    public void SetCebuanoRCPVBible(string CebuanoRCPVBible) { m_CebuanoRCPVBible = CebuanoRCPVBible; }
    public void SetChechenBible(string ChechenBible) { m_ChechenBible = ChechenBible; }
    public void SetChewa1992Bible(string Chewa1992Bible) { m_Chewa1992Bible = Chewa1992Bible; }
    public void SetChewa2014Bible(string Chewa2014Bible) { m_Chewa2014Bible = Chewa2014Bible; }
    public void SetChewa2016Bible(string Chewa2016Bible) { m_Chewa2016Bible = Chewa2016Bible; }
    public void SetChewaBLYDCBible(string ChewaBLYDCBible) { m_ChewaBLYDCBible = ChewaBLYDCBible; }
    public void SetChhattisgarhiBible(string ChhattisgarhiBible) { m_ChhattisgarhiBible = ChhattisgarhiBible; }
    public void SetChibembaBible(string ChibembaBible) { m_ChibembaBible = ChibembaBible; }
    public void SetChin2010Bible(string Chin2010Bible) { m_Chin2010Bible = Chin2010Bible; }
    public void SetChinBSIBible(string ChinBSIBible) { m_ChinBSIBible = ChinBSIBible; }
    public void SetChinCSHBible(string ChinCSHBible) { m_ChinCSHBible = ChinCSHBible; }
    public void SetChinDNTBible(string ChinDNTBible) { m_ChinDNTBible = ChinDNTBible; }
    public void SetChinese1886Bible(string Chinese1886Bible) { m_Chinese1886Bible = Chinese1886Bible; }
    public void SetChinese1919Bible(string Chinese1919Bible) { m_Chinese1919Bible = Chinese1919Bible; }
    public void SetChinese1927Bible(string Chinese1927Bible) { m_Chinese1927Bible = Chinese1927Bible; }
    public void SetChinese1933Bible(string Chinese1933Bible) { m_Chinese1933Bible = Chinese1933Bible; }
    public void SetChinese1941Bible(string Chinese1941Bible) { m_Chinese1941Bible = Chinese1941Bible; }
    public void SetChinese1967Bible(string Chinese1967Bible) { m_Chinese1967Bible = Chinese1967Bible; }
    public void SetChineseCCBSBible(string ChineseCCBSBible) { m_ChineseCCBSBible = ChineseCCBSBible; }
    public void SetChineseCCBTBible(string ChineseCCBTBible) { m_ChineseCCBTBible = ChineseCCBTBible; }
    public void SetChineseCSBSBible(string ChineseCSBSBible) { m_ChineseCSBSBible = ChineseCSBSBible; }
    public void SetChineseCSBTBible(string ChineseCSBTBible) { m_ChineseCSBTBible = ChineseCSBTBible; }
    public void SetChineseCUNPSSBible(string ChineseCUNPSSBible) { m_ChineseCUNPSSBible = ChineseCUNPSSBible; }
    public void SetChineseCUNPSTBible(string ChineseCUNPSTBible) { m_ChineseCUNPSTBible = ChineseCUNPSTBible; }
    public void SetChineseNankingBible(string ChineseNankingBible) { m_ChineseNankingBible = ChineseNankingBible; }
    public void SetChinesePekingBible(string ChinesePekingBible) { m_ChinesePekingBible = ChinesePekingBible; }
    public void SetChineseRCUVSSBible(string ChineseRCUVSSBible) { m_ChineseRCUVSSBible = ChineseRCUVSSBible; }
    public void SetChineseRCUVTBible(string ChineseRCUVTBible) { m_ChineseRCUVTBible = ChineseRCUVTBible; }
    public void SetChineseSimplifiedBible(string ChineseSimplifiedBible) { m_ChineseSimplifiedBible = ChineseSimplifiedBible; }
    public void SetChineseSimplifiedNewBible(string ChineseSimplifiedNewBible) { m_ChineseSimplifiedNewBible = ChineseSimplifiedNewBible; }
    public void SetChineseTCV2019TBible(string ChineseTCV2019TBible) { m_ChineseTCV2019TBible = ChineseTCV2019TBible; }
    public void SetChineseTHV2012Bible(string ChineseTHV2012Bible) { m_ChineseTHV2012Bible = ChineseTHV2012Bible; }
    public void SetChineseTraditionalBible(string ChineseTraditionalBible) { m_ChineseTraditionalBible = ChineseTraditionalBible; }
    public void SetChineseTraditionalERVBible(string ChineseTraditionalERVBible) { m_ChineseTraditionalERVBible = ChineseTraditionalERVBible; }
    public void SetChineseTraditionalNewBible(string ChineseTraditionalNewBible) { m_ChineseTraditionalNewBible = ChineseTraditionalNewBible; }
    public void SetChineseTTVHBible(string ChineseTTVHBible) { m_ChineseTTVHBible = ChineseTTVHBible; }
    public void SetChineseTTVRBible(string ChineseTTVRBible) { m_ChineseTTVRBible = ChineseTTVRBible; }
    public void SetChineseUnion2010Bible(string ChineseUnion2010Bible) { m_ChineseUnion2010Bible = ChineseUnion2010Bible; }
    public void SetChineseWenli1823Bible(string ChineseWenli1823Bible) { m_ChineseWenli1823Bible = ChineseWenli1823Bible; }
    public void SetChineseWenli1885Bible(string ChineseWenli1885Bible) { m_ChineseWenli1885Bible = ChineseWenli1885Bible; }
    public void SetChineseWenli1897Bible(string ChineseWenli1897Bible) { m_ChineseWenli1897Bible = ChineseWenli1897Bible; }
    public void SetChineseWenliBible(string ChineseWenliBible) { m_ChineseWenliBible = ChineseWenliBible; }
    public void SetChineseWenliEasyBible(string ChineseWenliEasyBible) { m_ChineseWenliEasyBible = ChineseWenliEasyBible; }
    public void SetChinKNTPBible(string ChinKNTPBible) { m_ChinKNTPBible = ChinKNTPBible; }
    public void SetChinMatupi2006Bible(string ChinMatupi2006Bible) { m_ChinMatupi2006Bible = ChinMatupi2006Bible; }
    public void SetChinMatupiBible(string ChinMatupiBible) { m_ChinMatupiBible = ChinMatupiBible; }
    public void SetChinSCB2Bible(string ChinSCB2Bible) { m_ChinSCB2Bible = ChinSCB2Bible; }
    public void SetChinTB77Bible(string ChinTB77Bible) { m_ChinTB77Bible = ChinTB77Bible; }
    public void SetChinTBR17Bible(string ChinTBR17Bible) { m_ChinTBR17Bible = ChinTBR17Bible; }
    public void SetChinTDBBible(string ChinTDBBible) { m_ChinTDBBible = ChinTDBBible; }
    public void SetChinTedim2011Bible(string ChinTedim2011Bible) { m_ChinTedim2011Bible = ChinTedim2011Bible; }
    public void SetChinTedimBible(string ChinTedimBible) { m_ChinTedimBible = ChinTedimBible; }
    public void SetChuvashBible(string ChuvashBible) { m_ChuvashBible = ChuvashBible; }
    public void SetChuvashRSOBible(string ChuvashRSOBible) { m_ChuvashRSOBible = ChuvashRSOBible; }
    public void SetCopticBible(string CopticBible) { m_CopticBible = CopticBible; }
    public void SetCopticCNTVBible(string CopticCNTVBible) { m_CopticCNTVBible = CopticCNTVBible; }
    public void SetCopticSahidicBible(string CopticSahidicBible) { m_CopticSahidicBible = CopticSahidicBible; }
    public void SetCroatianBible(string CroatianBible) { m_CroatianBible = CroatianBible; }
    public void SetCroatianBKJBible(string CroatianBKJBible) { m_CroatianBKJBible = CroatianBKJBible; }
    public void SetCroatianCNTBible(string CroatianCNTBible) { m_CroatianCNTBible = CroatianCNTBible; }
    public void SetCroatianGKSBible(string CroatianGKSBible) { m_CroatianGKSBible = CroatianGKSBible; }
    public void SetCroatianSHPBible(string CroatianSHPBible) { m_CroatianSHPBible = CroatianSHPBible; }
    public void SetCzech1922Bible(string Czech1922Bible) { m_Czech1922Bible = Czech1922Bible; }
    public void SetCzech1947Bible(string Czech1947Bible) { m_Czech1947Bible = Czech1947Bible; }
    public void SetCzech1951Bible(string Czech1951Bible) { m_Czech1951Bible = Czech1951Bible; }
    public void SetCzechBible(string CzechBible) { m_CzechBible = CzechBible; }
    public void SetCzechEkumenickyBible(string CzechEkumenickyBible) { m_CzechEkumenickyBible = CzechEkumenickyBible; }
    public void SetCzechKralichka1613Bible(string CzechKralichka1613Bible) { m_CzechKralichka1613Bible = CzechKralichka1613Bible; }
    public void SetCzechKralichka1998Bible(string CzechKralichka1998Bible) { m_CzechKralichka1998Bible = CzechKralichka1998Bible; }
    public void SetCzechPMPZBible(string CzechPMPZBible) { m_CzechPMPZBible = CzechPMPZBible; }
    public void SetCzechPrekladBible(string CzechPrekladBible) { m_CzechPrekladBible = CzechPrekladBible; }
    public void SetCzechSNCBible(string CzechSNCBible) { m_CzechSNCBible = CzechSNCBible; }
    public void SetDagbaniBible(string DagbaniBible) { m_DagbaniBible = DagbaniBible; }
    public void SetDanish1819Bible(string Danish1819Bible) { m_Danish1819Bible = Danish1819Bible; }
    public void SetDanish2015Bible(string Danish2015Bible) { m_Danish2015Bible = Danish2015Bible; }
    public void SetDanishBible(string DanishBible) { m_DanishBible = DanishBible; }
    public void SetDanishLBBible(string DanishLBBible) { m_DanishLBBible = DanishLBBible; }
    public void SetDanishWIEBible(string DanishWIEBible) { m_DanishWIEBible = DanishWIEBible; }
    public void SetDinka2006Bible(string Dinka2006Bible) { m_Dinka2006Bible = Dinka2006Bible; }
    public void SetDinkaBible(string DinkaBible) { m_DinkaBible = DinkaBible; }
    public void SetDinkaLEKJOTBible(string DinkaLEKJOTBible) { m_DinkaLEKJOTBible = DinkaLEKJOTBible; }
    public void SetDogriBible(string DogriBible) { m_DogriBible = DogriBible; }
    public void SetDutch1939Bible(string Dutch1939Bible) { m_Dutch1939Bible = Dutch1939Bible; }
    public void SetDutch2007Bible(string Dutch2007Bible) { m_Dutch2007Bible = Dutch2007Bible; }
    public void SetDutchBBBible(string DutchBBBible) { m_DutchBBBible = DutchBBBible; }
    public void SetDutchBible(string DutchBible) { m_DutchBible = DutchBible; }
    public void SetDutchEBV24Bible(string DutchEBV24Bible) { m_DutchEBV24Bible = DutchEBV24Bible; }
    public void SetDutchFrisianBible(string DutchFrisianBible) { m_DutchFrisianBible = DutchFrisianBible; }
    public void SetDutchGBVNTBible(string DutchGBVNTBible) { m_DutchGBVNTBible = DutchGBVNTBible; }
    public void SetDutchHSVBible(string DutchHSVBible) { m_DutchHSVBible = DutchHSVBible; }
    public void SetDutchHTBBible(string DutchHTBBible) { m_DutchHTBBible = DutchHTBBible; }
    public void SetDutchNBGBible(string DutchNBGBible) { m_DutchNBGBible = DutchNBGBible; }
    public void SetDutchReimerBible(string DutchReimerBible) { m_DutchReimerBible = DutchReimerBible; }
    public void SetDutchSVVBible(string DutchSVVBible) { m_DutchSVVBible = DutchSVVBible; }
    public void SetDutchVBBible(string DutchVBBible) { m_DutchVBBible = DutchVBBible; }
    public void SetDyulaJulaBible(string DyulaJulaBible) { m_DyulaJulaBible = DyulaJulaBible; }
    public void SetDyulaKumaBible(string DyulaKumaBible) { m_DyulaKumaBible = DyulaKumaBible; }
    public void SetDyulaLayidukuraBible(string DyulaLayidukuraBible) { m_DyulaLayidukuraBible = DyulaLayidukuraBible; }
    public void SetEdoBible(string EdoBible) { m_EdoBible = EdoBible; }
    public void SetEnglishAmplifiedBible(string EnglishAmplifiedBible) { m_EnglishAmplifiedBible = EnglishAmplifiedBible; }
    public void SetEnglishAmplifiedClassicBible(string EnglishAmplifiedClassicBible) { m_EnglishAmplifiedClassicBible = EnglishAmplifiedClassicBible; }
    public void SetEnglishASVBible(string EnglishASVBible) { m_EnglishASVBible = EnglishASVBible; }
    public void SetEnglishBereanBible(string EnglishBereanBible) { m_EnglishBereanBible = EnglishBereanBible; }
    public void SetEnglishCSBBible(string EnglishCSBBible) { m_EnglishCSBBible = EnglishCSBBible; }
    public void SetEnglishDarbyBible(string EnglishDarbyBible) { m_EnglishDarbyBible = EnglishDarbyBible; }
    public void SetEnglishEASYBible(string EnglishEASYBible) { m_EnglishEASYBible = EnglishEASYBible; }
    public void SetEnglishERVBible(string EnglishERVBible) { m_EnglishERVBible = EnglishERVBible; }
    public void SetEnglishESVBible(string EnglishESVBible) { m_EnglishESVBible = EnglishESVBible; }
    public void SetEnglishGNTBible(string EnglishGNTBible) { m_EnglishGNTBible = EnglishGNTBible; }
    public void SetEnglishGWBible(string EnglishGWBible) { m_EnglishGWBible = EnglishGWBible; }
    public void SetEnglishHCSBBible(string EnglishHCSBBible) { m_EnglishHCSBBible = EnglishHCSBBible; }
    public void SetEnglishKJBible(string EnglishKJBible) { m_EnglishKJBible = EnglishKJBible; }
    public void SetEnglishLSBBible(string EnglishLSBBible) { m_EnglishLSBBible = EnglishLSBBible; }
    public void SetEnglishMEVBible(string EnglishMEVBible) { m_EnglishMEVBible = EnglishMEVBible; }
    public void SetEnglishNASBBible(string EnglishNASBBible) { m_EnglishNASBBible = EnglishNASBBible; }
    public void SetEnglishNASUBible(string EnglishNASUBible) { m_EnglishNASUBible = EnglishNASUBible; }
    public void SetEnglishNETBible(string EnglishNETBible) { m_EnglishNETBible = EnglishNETBible; }
    public void SetEnglishNIRVBible(string EnglishNIRVBible) { m_EnglishNIRVBible = EnglishNIRVBible; }
    public void SetEnglishNIVBible(string EnglishNIVBible) { m_EnglishNIVBible = EnglishNIVBible; }
    public void SetEnglishNKJBible(string EnglishNKJBible) { m_EnglishNKJBible = EnglishNKJBible; }
    public void SetEnglishNLTBible(string EnglishNLTBible) { m_EnglishNLTBible = EnglishNLTBible; }
    public void SetEnglishNRSVBible(string EnglishNRSVBible) { m_EnglishNRSVBible = EnglishNRSVBible; }
    public void SetEnglishPassionBible(string EnglishPassionBible) { m_EnglishPassionBible = EnglishPassionBible; }
    public void SetEnglishRSVBible(string EnglishRSVBible) { m_EnglishRSVBible = EnglishRSVBible; }
    public void SetEnglishTLBible(string EnglishTLBible) { m_EnglishTLBible = EnglishTLBible; }
    public void SetEnglishTyndale1537Bible(string EnglishTyndale1537Bible) { m_EnglishTyndale1537Bible = EnglishTyndale1537Bible; }
    public void SetEnglishYLTBible(string EnglishYLTBible) { m_EnglishYLTBible = EnglishYLTBible; }
    public void SetEsperantoBible(string EsperantoBible) { m_EsperantoBible = EsperantoBible; }
    public void SetEstonian2022Bible(string Estonian2022Bible) { m_Estonian2022Bible = Estonian2022Bible; }
    public void SetEstonianBible(string EstonianBible) { m_EstonianBible = EstonianBible; }
    public void SetEstonianEEPBible(string EstonianEEPBible) { m_EstonianEEPBible = EstonianEEPBible; }
    public void SetEwe1913Bible(string Ewe1913Bible) { m_Ewe1913Bible = Ewe1913Bible; }
    public void SetEwe2014Bible(string Ewe2014Bible) { m_Ewe2014Bible = Ewe2014Bible; }
    public void SetEwe2020Bible(string Ewe2020Bible) { m_Ewe2020Bible = Ewe2020Bible; }
    public void SetEweBible(string EweBible) { m_EweBible = EweBible; }
    public void SetFinnish1776Bible(string Finnish1776Bible) { m_Finnish1776Bible = Finnish1776Bible; }
    public void SetFinnish1992Bible(string Finnish1992Bible) { m_Finnish1992Bible = Finnish1992Bible; }
    public void SetFinnishBible(string FinnishBible) { m_FinnishBible = FinnishBible; }
    public void SetFinnishFINRKBible(string FinnishFINRKBible) { m_FinnishFINRKBible = FinnishFINRKBible; }
    public void SetFinnishSTLKBible(string FinnishSTLKBible) { m_FinnishSTLKBible = FinnishSTLKBible; }
    public void SetFonBible(string FonBible) { m_FonBible = FonBible; }
    public void SetFrench2004Bible(string French2004Bible) { m_French2004Bible = French2004Bible; }
    public void SetFrenchBBBBible(string FrenchBBBBible) { m_FrenchBBBBible = FrenchBBBBible; }
    public void SetFrenchBDSBible(string FrenchBDSBible) { m_FrenchBDSBible = FrenchBDSBible; }
    public void SetFrenchBFCBible(string FrenchBFCBible) { m_FrenchBFCBible = FrenchBFCBible; }
    public void SetFrenchBible(string FrenchBible) { m_FrenchBible = FrenchBible; }
    public void SetFrenchCramponBible(string FrenchCramponBible) { m_FrenchCramponBible = FrenchCramponBible; }
    public void SetFrenchDarbyBible(string FrenchDarbyBible) { m_FrenchDarbyBible = FrenchDarbyBible; }
    public void SetFrenchJerusalemBible(string FrenchJerusalemBible) { m_FrenchJerusalemBible = FrenchJerusalemBible; }
    public void SetFrenchLeonBible(string FrenchLeonBible) { m_FrenchLeonBible = FrenchLeonBible; }
    public void SetFrenchMachairaBible(string FrenchMachairaBible) { m_FrenchMachairaBible = FrenchMachairaBible; }
    public void SetFrenchMartinBible(string FrenchMartinBible) { m_FrenchMartinBible = FrenchMartinBible; }
    public void SetFrenchNBSBible(string FrenchNBSBible) { m_FrenchNBSBible = FrenchNBSBible; }
    public void SetFrenchNEG79Bible(string FrenchNEG79Bible) { m_FrenchNEG79Bible = FrenchNEG79Bible; }
    public void SetFrenchNFCBible(string FrenchNFCBible) { m_FrenchNFCBible = FrenchNFCBible; }
    public void SetFrenchNVS78Bible(string FrenchNVS78Bible) { m_FrenchNVS78Bible = FrenchNVS78Bible; }
    public void SetFrenchOSTBible(string FrenchOSTBible) { m_FrenchOSTBible = FrenchOSTBible; }
    public void SetFrenchOstervaldBible(string FrenchOstervaldBible) { m_FrenchOstervaldBible = FrenchOstervaldBible; }
    public void SetFrenchPDV2017Bible(string FrenchPDV2017Bible) { m_FrenchPDV2017Bible = FrenchPDV2017Bible; }
    public void SetFrenchPerretBible(string FrenchPerretBible) { m_FrenchPerretBible = FrenchPerretBible; }
    public void SetFrenchS21Bible(string FrenchS21Bible) { m_FrenchS21Bible = FrenchS21Bible; }
    public void SetFrenchVigourouxBible(string FrenchVigourouxBible) { m_FrenchVigourouxBible = FrenchVigourouxBible; }
    public void SetFulfulde2010Bible(string Fulfulde2010Bible) { m_Fulfulde2010Bible = Fulfulde2010Bible; }
    public void SetFulfuldeAadiBible(string FulfuldeAadiBible) { m_FulfuldeAadiBible = FulfuldeAadiBible; }
    public void SetFulfuldeAdamawaBible(string FulfuldeAdamawaBible) { m_FulfuldeAdamawaBible = FulfuldeAdamawaBible; }
    public void SetFulfuldeAlkawalBible(string FulfuldeAlkawalBible) { m_FulfuldeAlkawalBible = FulfuldeAlkawalBible; }
    public void SetFulfuldeArabicBible(string FulfuldeArabicBible) { m_FulfuldeArabicBible = FulfuldeArabicBible; }
    public void SetFulfuldeBeninBible(string FulfuldeBeninBible) { m_FulfuldeBeninBible = FulfuldeBeninBible; }
    public void SetFulfuldeBurkinaFasoBible(string FulfuldeBurkinaFasoBible) { m_FulfuldeBurkinaFasoBible = FulfuldeBurkinaFasoBible; }
    public void SetFulfuldeDewtereBible(string FulfuldeDewtereBible) { m_FulfuldeDewtereBible = FulfuldeDewtereBible; }
    public void SetFulfuldeWestNigerBible(string FulfuldeWestNigerBible) { m_FulfuldeWestNigerBible = FulfuldeWestNigerBible; }
    public void SetGaelic1875Bible(string Gaelic1875Bible) { m_Gaelic1875Bible = Gaelic1875Bible; }
    public void SetGaelicABGBible(string GaelicABGBible) { m_GaelicABGBible = GaelicABGBible; }
    public void SetGaelicABIGBible(string GaelicABIGBible) { m_GaelicABIGBible = GaelicABIGBible; }
    public void SetGaelicATNBible(string GaelicATNBible) { m_GaelicATNBible = GaelicATNBible; }
    public void SetGalacianSEPTBible(string GalacianSEPTBible) { m_GalacianSEPTBible = GalacianSEPTBible; }
    public void SetGarhwaliBible(string GarhwaliBible) { m_GarhwaliBible = GarhwaliBible; }
    public void SetGarhwaliGBMBible(string GarhwaliGBMBible) { m_GarhwaliGBMBible = GarhwaliGBMBible; }
    public void SetGeorgian2002Bible(string Georgian2002Bible) { m_Georgian2002Bible = Georgian2002Bible; }
    public void SetGeorgian2012Bible(string Georgian2012Bible) { m_Georgian2012Bible = Georgian2012Bible; }
    public void SetGeorgianBible(string GeorgianBible) { m_GeorgianBible = GeorgianBible; }
    public void SetGerman1545Bible(string German1545Bible) { m_German1545Bible = German1545Bible; }
    public void SetGerman2011Bible(string German2011Bible) { m_German2011Bible = German2011Bible; }
    public void SetGermanAlbrecht1926Bible(string GermanAlbrecht1926Bible) { m_GermanAlbrecht1926Bible = GermanAlbrecht1926Bible; }
    public void SetGermanBible(string GermanBible) { m_GermanBible = GermanBible; }
    public void SetGermanElber1905Bible(string GermanElber1905Bible) { m_GermanElber1905Bible = GermanElber1905Bible; }
    public void SetGermanGruenewaldBible(string GermanGruenewaldBible) { m_GermanGruenewaldBible = GermanGruenewaldBible; }
    public void SetGermanHeuteBible(string GermanHeuteBible) { m_GermanHeuteBible = GermanHeuteBible; }
    public void SetGermanHFABible(string GermanHFABible) { m_GermanHFABible = GermanHFABible; }
    public void SetGermanInterlinearBible(string GermanInterlinearBible) { m_GermanInterlinearBible = GermanInterlinearBible; }
    public void SetGermanLUT17Bible(string GermanLUT17Bible) { m_GermanLUT17Bible = GermanLUT17Bible; }
    public void SetGermanLuther1912Bible(string GermanLuther1912Bible) { m_GermanLuther1912Bible = GermanLuther1912Bible; }
    public void SetGermanLutherHeuteBible(string GermanLutherHeuteBible) { m_GermanLutherHeuteBible = GermanLutherHeuteBible; }
    public void SetGermanSchlachter2000Bible(string GermanSchlachter2000Bible) { m_GermanSchlachter2000Bible = GermanSchlachter2000Bible; }
    public void SetGermanTafelBible(string GermanTafelBible) { m_GermanTafelBible = GermanTafelBible; }
    public void SetGermanTKWBible(string GermanTKWBible) { m_GermanTKWBible = GermanTKWBible; }
    public void SetGermanUbersetzung2014Bible(string GermanUbersetzung2014Bible) { m_GermanUbersetzung2014Bible = GermanUbersetzung2014Bible; }
    public void SetGhomalaBible(string GhomalaBible) { m_GhomalaBible = GhomalaBible; }
    public void SetGreek1550Bible(string Greek1550Bible) { m_Greek1550Bible = Greek1550Bible; }
    public void SetGreekBible(string GreekBible) { m_GreekBible = GreekBible; }
    public void SetGreekBYZ04Bible(string GreekBYZ04Bible) { m_GreekBYZ04Bible = GreekBYZ04Bible; }
    public void SetGreekBYZ18Bible(string GreekBYZ18Bible) { m_GreekBYZ18Bible = GreekBYZ18Bible; }
    public void SetGreekElzevirBible(string GreekElzevirBible) { m_GreekElzevirBible = GreekElzevirBible; }
    public void SetGreekF35Bible(string GreekF35Bible) { m_GreekF35Bible = GreekF35Bible; }
    public void SetGreekFPBBible(string GreekFPBBible) { m_GreekFPBBible = GreekFPBBible; }
    public void SetGreekGNTBible(string GreekGNTBible) { m_GreekGNTBible = GreekGNTBible; }
    public void SetGreekLMGNTBible(string GreekLMGNTBible) { m_GreekLMGNTBible = GreekLMGNTBible; }
    public void SetGreekModern1904Bible(string GreekModern1904Bible) { m_GreekModern1904Bible = GreekModern1904Bible; }
    public void SetGreekModernFPBBible(string GreekModernFPBBible) { m_GreekModernFPBBible = GreekModernFPBBible; }
    public void SetGreekNTVBible(string GreekNTVBible) { m_GreekNTVBible = GreekNTVBible; }
    public void SetGreekSBLGNTBible(string GreekSBLGNTBible) { m_GreekSBLGNTBible = GreekSBLGNTBible; }
    public void SetGreekTCGNTBible(string GreekTCGNTBible) { m_GreekTCGNTBible = GreekTCGNTBible; }
    public void SetGreekTGVBible(string GreekTGVBible) { m_GreekTGVBible = GreekTGVBible; }
    public void SetGreekTHGNTBible(string GreekTHGNTBible) { m_GreekTHGNTBible = GreekTHGNTBible; }
    public void SetGreekTR1894Bible(string GreekTR1894Bible) { m_GreekTR1894Bible = GreekTR1894Bible; }
    public void SetGuarani1913Bible(string Guarani1913Bible) { m_Guarani1913Bible = Guarani1913Bible; }
    public void SetGuarani1970Bible(string Guarani1970Bible) { m_Guarani1970Bible = Guarani1970Bible; }
    public void SetGuarani1996Bible(string Guarani1996Bible) { m_Guarani1996Bible = Guarani1996Bible; }
    public void SetGuarani2001Bible(string Guarani2001Bible) { m_Guarani2001Bible = Guarani2001Bible; }
    public void SetGuarani2015Bible(string Guarani2015Bible) { m_Guarani2015Bible = Guarani2015Bible; }
    public void SetGuarani2017Bible(string Guarani2017Bible) { m_Guarani2017Bible = Guarani2017Bible; }
    public void SetGuaraniBible(string GuaraniBible) { m_GuaraniBible = GuaraniBible; }
    public void SetGuaraniMBYABible(string GuaraniMBYABible) { m_GuaraniMBYABible = GuaraniMBYABible; }
    public void SetGuaraniSIMBABible(string GuaraniSIMBABible) { m_GuaraniSIMBABible = GuaraniSIMBABible; }
    public void SetGujarati2016Bible(string Gujarati2016Bible) { m_Gujarati2016Bible = Gujarati2016Bible; }
    public void SetGujarati2017Bible(string Gujarati2017Bible) { m_Gujarati2017Bible = Gujarati2017Bible; }
    public void SetGujaratiBible(string GujaratiBible) { m_GujaratiBible = GujaratiBible; }
    public void SetGujaratiGUOVBible(string GujaratiGUOVBible) { m_GujaratiGUOVBible = GujaratiGUOVBible; }
    public void SetGussiBible(string GussiBible) { m_GussiBible = GussiBible; }
    public void SetHadiyyaBible(string HadiyyaBible) { m_HadiyyaBible = HadiyyaBible; }
    public void SetHaitianBible(string HaitianBible) { m_HaitianBible = HaitianBible; }
    public void SetHaitianBSABible(string HaitianBSABible) { m_HaitianBSABible = HaitianBSABible; }
    public void SetHaitianHWPBible(string HaitianHWPBible) { m_HaitianHWPBible = HaitianHWPBible; }
    public void SetHaitianVFKBible(string HaitianVFKBible) { m_HaitianVFKBible = HaitianVFKBible; }
    public void SetHaryanviBible(string HaryanviBible) { m_HaryanviBible = HaryanviBible; }
    public void SetHausa2010Bible(string Hausa2010Bible) { m_Hausa2010Bible = Hausa2010Bible; }
    public void SetHausa2013Bible(string Hausa2013Bible) { m_Hausa2013Bible = Hausa2013Bible; }
    public void SetHausaARBible(string HausaARBible) { m_HausaARBible = HausaARBible; }
    public void SetHebrew1885Bible(string Hebrew1885Bible) { m_Hebrew1885Bible = Hebrew1885Bible; }
    public void SetHebrewAleppoCodexBible(string HebrewAleppoCodexBible) { m_HebrewAleppoCodexBible = HebrewAleppoCodexBible; }
    public void SetHebrewBible(string HebrewBible) { m_HebrewBible = HebrewBible; }
    public void SetHebrewBSIBible(string HebrewBSIBible) { m_HebrewBSIBible = HebrewBSIBible; }
    public void SetHebrewHHHBible(string HebrewHHHBible) { m_HebrewHHHBible = HebrewHHHBible; }
    public void SetHebrewLeningradCodexBible(string HebrewLeningradCodexBible) { m_HebrewLeningradCodexBible = HebrewLeningradCodexBible; }
    public void SetHebrewMHBBible(string HebrewMHBBible) { m_HebrewMHBBible = HebrewMHBBible; }
    public void SetHebrewMHNT2020Bible(string HebrewMHNT2020Bible) { m_HebrewMHNT2020Bible = HebrewMHNT2020Bible; }
    public void SetHebrewTDBible(string HebrewTDBible) { m_HebrewTDBible = HebrewTDBible; }
    public void SetHindi2017Bible(string Hindi2017Bible) { m_Hindi2017Bible = Hindi2017Bible; }
    public void SetHindiBible(string HindiBible) { m_HindiBible = HindiBible; }
    public void SetHindiCLBSIBible(string HindiCLBSIBible) { m_HindiCLBSIBible = HindiCLBSIBible; }
    public void SetHindiERVBible(string HindiERVBible) { m_HindiERVBible = HindiERVBible; }
    public void SetHindiFijiBible(string HindiFijiBible) { m_HindiFijiBible = HindiFijiBible; }
    public void SetHindiHSBBible(string HindiHSBBible) { m_HindiHSBBible = HindiHSBBible; }
    public void SetHindiHSSBible(string HindiHSSBible) { m_HindiHSSBible = HindiHSSBible; }
    public void SetHindiIRVBible(string HindiIRVBible) { m_HindiIRVBible = HindiIRVBible; }
    public void SetHindiOVBSIBible(string HindiOVBSIBible) { m_HindiOVBSIBible = HindiOVBSIBible; }
    public void SetHindiRomanBible(string HindiRomanBible) { m_HindiRomanBible = HindiRomanBible; }
    public void SetHmong2000Bible(string Hmong2000Bible) { m_Hmong2000Bible = Hmong2000Bible; }
    public void SetHmong2004Bible(string Hmong2004Bible) { m_Hmong2004Bible = Hmong2004Bible; }
    public void SetHungarianBDUZBible(string HungarianBDUZBible) { m_HungarianBDUZBible = HungarianBDUZBible; }
    public void SetHungarianBible(string HungarianBible) { m_HungarianBible = HungarianBible; }
    public void SetHungarianBUZBible(string HungarianBUZBible) { m_HungarianBUZBible = HungarianBUZBible; }
    public void SetHungarianCSIABible(string HungarianCSIABible) { m_HungarianCSIABible = HungarianCSIABible; }
    public void SetHungarianCSUZBible(string HungarianCSUZBible) { m_HungarianCSUZBible = HungarianCSUZBible; }
    public void SetHungarianEFOBible(string HungarianEFOBible) { m_HungarianEFOBible = HungarianEFOBible; }
    public void SetHungarianEIVBible(string HungarianEIVBible) { m_HungarianEIVBible = HungarianEIVBible; }
    public void SetHungarianERVBible(string HungarianERVBible) { m_HungarianERVBible = HungarianERVBible; }
    public void SetHungarianKaroliBible(string HungarianKaroliBible) { m_HungarianKaroliBible = HungarianKaroliBible; }
    public void SetHungarianKIBBible(string HungarianKIBBible) { m_HungarianKIBBible = HungarianKIBBible; }
    public void SetHungarianKNBBible(string HungarianKNBBible) { m_HungarianKNBBible = HungarianKNBBible; }
    public void SetHungarianKSZEBible(string HungarianKSZEBible) { m_HungarianKSZEBible = HungarianKSZEBible; }
    public void SetHungarianMRUZBible(string HungarianMRUZBible) { m_HungarianMRUZBible = HungarianMRUZBible; }
    public void SetHungarianRLUZBible(string HungarianRLUZBible) { m_HungarianRLUZBible = HungarianRLUZBible; }
    public void SetHungarianRUFBible(string HungarianRUFBible) { m_HungarianRUFBible = HungarianRUFBible; }
    public void SetHungarianSIUZBible(string HungarianSIUZBible) { m_HungarianSIUZBible = HungarianSIUZBible; }
    public void SetHungarianVSUZBible(string HungarianVSUZBible) { m_HungarianVSUZBible = HungarianVSUZBible; }
    public void SetIbanBible(string IbanBible) { m_IbanBible = IbanBible; }
    public void SetIbibioBible(string IbibioBible) { m_IbibioBible = IbibioBible; }
    public void SetIcelandic1981Bible(string Icelandic1981Bible) { m_Icelandic1981Bible = Icelandic1981Bible; }
    public void SetIcelandicBible(string IcelandicBible) { m_IcelandicBible = IcelandicBible; }
    public void SetIgbo1988Bible(string Igbo1988Bible) { m_Igbo1988Bible = Igbo1988Bible; }
    public void SetIgbo2006Bible(string Igbo2006Bible) { m_Igbo2006Bible = Igbo2006Bible; }
    public void SetIgbo2020Bible(string Igbo2020Bible) { m_Igbo2020Bible = Igbo2020Bible; }
    public void SetIkaBible(string IkaBible) { m_IkaBible = IkaBible; }
    public void SetIlokano1973Bible(string Ilokano1973Bible) { m_Ilokano1973Bible = Ilokano1973Bible; }
    public void SetIlokanoBible(string IlokanoBible) { m_IlokanoBible = IlokanoBible; }
    public void SetIlonggo2012Bible(string Ilonggo2012Bible) { m_Ilonggo2012Bible = Ilonggo2012Bible; }
    public void SetIlonggoAPDBible(string IlonggoAPDBible) { m_IlonggoAPDBible = IlonggoAPDBible; }
    public void SetIlonggoBible(string IlonggoBible) { m_IlonggoBible = IlonggoBible; }
    public void SetIndonesianAGSBible(string IndonesianAGSBible) { m_IndonesianAGSBible = IndonesianAGSBible; }
    public void SetIndonesianAMD2021Bible(string IndonesianAMD2021Bible) { m_IndonesianAMD2021Bible = IndonesianAMD2021Bible; }
    public void SetIndonesianBible(string IndonesianBible) { m_IndonesianBible = IndonesianBible; }
    public void SetIndonesianBISBible(string IndonesianBISBible) { m_IndonesianBISBible = IndonesianBISBible; }
    public void SetIndonesianBPJBible(string IndonesianBPJBible) { m_IndonesianBPJBible = IndonesianBPJBible; }
    public void SetIndonesianFAYHBible(string IndonesianFAYHBible) { m_IndonesianFAYHBible = IndonesianFAYHBible; }
    public void SetIndonesianINOTAZIBible(string IndonesianINOTAZIBible) { m_IndonesianINOTAZIBible = IndonesianINOTAZIBible; }
    public void SetIndonesianPBTB2Bible(string IndonesianPBTB2Bible) { m_IndonesianPBTB2Bible = IndonesianPBTB2Bible; }
    public void SetIndonesianTLBible(string IndonesianTLBible) { m_IndonesianTLBible = IndonesianTLBible; }
    public void SetIndonesianTSIBible(string IndonesianTSIBible) { m_IndonesianTSIBible = IndonesianTSIBible; }
    public void SetIndonesianVMDBible(string IndonesianVMDBible) { m_IndonesianVMDBible = IndonesianVMDBible; }
    public void SetIrish1817Bible(string Irish1817Bible) { m_Irish1817Bible = Irish1817Bible; }
    public void SetIrish1951Bible(string Irish1951Bible) { m_Irish1951Bible = Irish1951Bible; }
    public void SetIrish1970Bible(string Irish1970Bible) { m_Irish1970Bible = Irish1970Bible; }
    public void SetIrish2012Bible(string Irish2012Bible) { m_Irish2012Bible = Irish2012Bible; }
    public void SetIrishBible(string IrishBible) { m_IrishBible = IrishBible; }
    public void SetItalian1649Bible(string Italian1649Bible) { m_Italian1649Bible = Italian1649Bible; }
    public void SetItalian2014Bible(string Italian2014Bible) { m_Italian2014Bible = Italian2014Bible; }
    public void SetItalian2020Bible(string Italian2020Bible) { m_Italian2020Bible = Italian2020Bible; }
    public void SetItalianBible(string ItalianBible) { m_ItalianBible = ItalianBible; }
    public void SetItalianCEI2008Bible(string ItalianCEI2008Bible) { m_ItalianCEI2008Bible = ItalianCEI2008Bible; }
    public void SetItalianIPNBible(string ItalianIPNBible) { m_ItalianIPNBible = ItalianIPNBible; }
    public void SetItalianLaNuovaDiodatiBible(string ItalianLaNuovaDiodatiBible) { m_ItalianLaNuovaDiodatiBible = ItalianLaNuovaDiodatiBible; }
    public void SetItalianNR1994Bible(string ItalianNR1994Bible) { m_ItalianNR1994Bible = ItalianNR1994Bible; }
    public void SetItalianRivedutaBible(string ItalianRivedutaBible) { m_ItalianRivedutaBible = ItalianRivedutaBible; }
    public void SetIuMienBible(string IuMienBible) { m_IuMienBible = IuMienBible; }
    public void SetIuMienThaiBible(string IuMienThaiBible) { m_IuMienThaiBible = IuMienThaiBible; }
    public void SetJamaicanBible(string JamaicanBible) { m_JamaicanBible = JamaicanBible; }
    public void SetJapanese1965Bible(string Japanese1965Bible) { m_Japanese1965Bible = Japanese1965Bible; }
    public void SetJapanese1987Bible(string Japanese1987Bible) { m_Japanese1987Bible = Japanese1987Bible; }
    public void SetJapanese2017Bible(string Japanese2017Bible) { m_Japanese2017Bible = Japanese2017Bible; }
    public void SetJapaneseBible(string JapaneseBible) { m_JapaneseBible = JapaneseBible; }
    public void SetJapaneseCO1955Bible(string JapaneseCO1955Bible) { m_JapaneseCO1955Bible = JapaneseCO1955Bible; }
    public void SetJapaneseERVBible(string JapaneseERVBible) { m_JapaneseERVBible = JapaneseERVBible; }
    public void SetJapaneseJCBBible(string JapaneseJCBBible) { m_JapaneseJCBBible = JapaneseJCBBible; }
    public void SetJavaneseBible(string JavaneseBible) { m_JavaneseBible = JavaneseBible; }
    public void SetJavaneseJVNBible(string JavaneseJVNBible) { m_JavaneseJVNBible = JavaneseJVNBible; }
    public void SetJavaneseKJS17Bible(string JavaneseKJS17Bible) { m_JavaneseKJS17Bible = JavaneseKJS17Bible; }
    public void SetKabardianBible(string KabardianBible) { m_KabardianBible = KabardianBible; }
    public void SetKabyleBible(string KabyleBible) { m_KabyleBible = KabyleBible; }
    public void SetKachinJCLBBible(string KachinJCLBBible) { m_KachinJCLBBible = KachinJCLBBible; }
    public void SetKachinJHVT3Bible(string KachinJHVT3Bible) { m_KachinJHVT3Bible = KachinJHVT3Bible; }
    public void SetKalenjin2019Bible(string Kalenjin2019Bible) { m_Kalenjin2019Bible = Kalenjin2019Bible; }
    public void SetKalenjinBible(string KalenjinBible) { m_KalenjinBible = KalenjinBible; }
    public void SetKalenjinRevisedBible(string KalenjinRevisedBible) { m_KalenjinRevisedBible = KalenjinRevisedBible; }
    public void SetKambaBible(string KambaBible) { m_KambaBible = KambaBible; }
    public void SetKambaMBIVLIABible(string KambaMBIVLIABible) { m_KambaMBIVLIABible = KambaMBIVLIABible; }
    public void SetKangriBible(string KangriBible) { m_KangriBible = KangriBible; }
    public void SetKannada2022Bible(string Kannada2022Bible) { m_Kannada2022Bible = Kannada2022Bible; }
    public void SetKannadaBible(string KannadaBible) { m_KannadaBible = KannadaBible; }
    public void SetKannadaBSIBible(string KannadaBSIBible) { m_KannadaBSIBible = KannadaBSIBible; }
    public void SetKannadaBSIJVBible(string KannadaBSIJVBible) { m_KannadaBSIJVBible = KannadaBSIJVBible; }
    public void SetKannadaIRVBible(string KannadaIRVBible) { m_KannadaIRVBible = KannadaIRVBible; }
    public void SetKannadaKNCLBible(string KannadaKNCLBible) { m_KannadaKNCLBible = KannadaKNCLBible; }
    public void SetKarakalpak2004Bible(string Karakalpak2004Bible) { m_Karakalpak2004Bible = Karakalpak2004Bible; }
    public void SetKarakalpak2022Bible(string Karakalpak2022Bible) { m_Karakalpak2022Bible = Karakalpak2022Bible; }
    public void SetKarakalpakK2022Bible(string KarakalpakK2022Bible) { m_KarakalpakK2022Bible = KarakalpakK2022Bible; }
    public void SetKazakhstan2023Bible(string Kazakhstan2023Bible) { m_Kazakhstan2023Bible = Kazakhstan2023Bible; }
    public void SetKazakhstanBible(string KazakhstanBible) { m_KazakhstanBible = KazakhstanBible; }
    public void SetKenyaGIKCLBible(string KenyaGIKCLBible) { m_KenyaGIKCLBible = KenyaGIKCLBible; }
    public void SetKhmer2005Bible(string Khmer2005Bible) { m_Khmer2005Bible = Khmer2005Bible; }
    public void SetKhmer2012Bible(string Khmer2012Bible) { m_Khmer2012Bible = Khmer2012Bible; }
    public void SetKhmer2014Bible(string Khmer2014Bible) { m_Khmer2014Bible = Khmer2014Bible; }
    public void SetKhmer2016Bible(string Khmer2016Bible) { m_Khmer2016Bible = Khmer2016Bible; }
    public void SetKhmer2019Bible(string Khmer2019Bible) { m_Khmer2019Bible = Khmer2019Bible; }
    public void SetKhmerBFBSBible(string KhmerBFBSBible) { m_KhmerBFBSBible = KhmerBFBSBible; }
    public void SetKhmerBible(string KhmerBible) { m_KhmerBible = KhmerBible; }
    public void SetKiche1995Bible(string Kiche1995Bible) { m_Kiche1995Bible = Kiche1995Bible; }
    public void SetKiche2022Bible(string Kiche2022Bible) { m_Kiche2022Bible = Kiche2022Bible; }
    public void SetKicheBible(string KicheBible) { m_KicheBible = KicheBible; }
    public void SetKicheQUCNBible(string KicheQUCNBible) { m_KicheQUCNBible = KicheQUCNBible; }
    public void SetKikuyu2013Bible(string Kikuyu2013Bible) { m_Kikuyu2013Bible = Kikuyu2013Bible; }
    public void SetKikuyu2014Bible(string Kikuyu2014Bible) { m_Kikuyu2014Bible = Kikuyu2014Bible; }
    public void SetKikuyu2019Bible(string Kikuyu2019Bible) { m_Kikuyu2019Bible = Kikuyu2019Bible; }
    public void SetKikwangoBible(string KikwangoBible) { m_KikwangoBible = KikwangoBible; }
    public void SetKimbunduBible(string KimbunduBible) { m_KimbunduBible = KimbunduBible; }
    public void SetKimiiruBible(string KimiiruBible) { m_KimiiruBible = KimiiruBible; }
    public void SetKinyarwanda2001Bible(string Kinyarwanda2001Bible) { m_Kinyarwanda2001Bible = Kinyarwanda2001Bible; }
    public void SetKinyarwanda2012Bible(string Kinyarwanda2012Bible) { m_Kinyarwanda2012Bible = Kinyarwanda2012Bible; }
    public void SetKinyarwandaBIRBible(string KinyarwandaBIRBible) { m_KinyarwandaBIRBible = KinyarwandaBIRBible; }
    public void SetKirundiCorosheBible(string KirundiCorosheBible) { m_KirundiCorosheBible = KirundiCorosheBible; }
    public void SetKirundiRishaBible(string KirundiRishaBible) { m_KirundiRishaBible = KirundiRishaBible; }
    public void SetKitubaBible(string KitubaBible) { m_KitubaBible = KitubaBible; }
    public void SetKonkaniBible(string KonkaniBible) { m_KonkaniBible = KonkaniBible; }
    public void SetKorean2021Bible(string Korean2021Bible) { m_Korean2021Bible = Korean2021Bible; }
    public void SetKoreanAEBBible(string KoreanAEBBible) { m_KoreanAEBBible = KoreanAEBBible; }
    public void SetKoreanKLBBible(string KoreanKLBBible) { m_KoreanKLBBible = KoreanKLBBible; }
    public void SetKoreanNKRVBible(string KoreanNKRVBible) { m_KoreanNKRVBible = KoreanNKRVBible; }
    public void SetKoreanRentierBible(string KoreanRentierBible) { m_KoreanRentierBible = KoreanRentierBible; }
    public void SetKoreanRNKSVBible(string KoreanRNKSVBible) { m_KoreanRNKSVBible = KoreanRNKSVBible; }
    public void SetKoreanTKVBible(string KoreanTKVBible) { m_KoreanTKVBible = KoreanTKVBible; }
    public void SetKoreanWoorimalBible(string KoreanWoorimalBible) { m_KoreanWoorimalBible = KoreanWoorimalBible; }
    public void SetKoyaBible(string KoyaBible) { m_KoyaBible = KoyaBible; }
    public void SetKrioBible(string KrioBible) { m_KrioBible = KrioBible; }
    public void SetKumaoniBible(string KumaoniBible) { m_KumaoniBible = KumaoniBible; }
    public void SetKurdish2005Bible(string Kurdish2005Bible) { m_Kurdish2005Bible = Kurdish2005Bible; }
    public void SetKurdish2017Bible(string Kurdish2017Bible) { m_Kurdish2017Bible = Kurdish2017Bible; }
    public void SetKurdishBHDBible(string KurdishBHDBible) { m_KurdishBHDBible = KurdishBHDBible; }
    public void SetKurdishBible(string KurdishBible) { m_KurdishBible = KurdishBible; }
    public void SetKurdishKMRNTCBible(string KurdishKMRNTCBible) { m_KurdishKMRNTCBible = KurdishKMRNTCBible; }
    public void SetKurdishKMRNTLBible(string KurdishKMRNTLBible) { m_KurdishKMRNTLBible = KurdishKMRNTLBible; }
    public void SetKurdishPNTZSBible(string KurdishPNTZSBible) { m_KurdishPNTZSBible = KurdishPNTZSBible; }
    public void SetKurdishSKBBible(string KurdishSKBBible) { m_KurdishSKBBible = KurdishSKBBible; }
    public void SetKurdishSKVBible(string KurdishSKVBible) { m_KurdishSKVBible = KurdishSKVBible; }
    public void SetKurukh2025Bible(string Kurukh2025Bible) { m_Kurukh2025Bible = Kurukh2025Bible; }
    public void SetKurukhBible(string KurukhBible) { m_KurukhBible = KurukhBible; }
    public void SetKyrgyz2004Bible(string Kyrgyz2004Bible) { m_Kyrgyz2004Bible = Kyrgyz2004Bible; }
    public void SetKyrgyz2005Bible(string Kyrgyz2005Bible) { m_Kyrgyz2005Bible = Kyrgyz2005Bible; }
    public void SetLahuBible(string LahuBible) { m_LahuBible = LahuBible; }
    public void SetLahuLHINTBible(string LahuLHINTBible) { m_LahuLHINTBible = LahuLHINTBible; }
    public void SetLambadiBible(string LambadiBible) { m_LambadiBible = LambadiBible; }
    public void SetLango1979Bible(string Lango1979Bible) { m_Lango1979Bible = Lango1979Bible; }
    public void SetLangoBible(string LangoBible) { m_LangoBible = LangoBible; }
    public void SetLao2012Bible(string Lao2012Bible) { m_Lao2012Bible = Lao2012Bible; }
    public void SetLaoBible(string LaoBible) { m_LaoBible = LaoBible; }
    public void SetLaoLCVBible(string LaoLCVBible) { m_LaoLCVBible = LaoLCVBible; }
    public void SetLatinBible(string LatinBible) { m_LatinBible = LatinBible; }
    public void SetLatinClementina1914Bible(string LatinClementina1914Bible) { m_LatinClementina1914Bible = LatinClementina1914Bible; }
    public void SetLatinClementineBible(string LatinClementineBible) { m_LatinClementineBible = LatinClementineBible; }
    public void SetLatinNovaVulgataBible(string LatinNovaVulgataBible) { m_LatinNovaVulgataBible = LatinNovaVulgataBible; }
    public void SetLatinSistinaBible(string LatinSistinaBible) { m_LatinSistinaBible = LatinSistinaBible; }
    public void SetLatvian1965Bible(string Latvian1965Bible) { m_Latvian1965Bible = Latvian1965Bible; }
    public void SetLatvian2012Bible(string Latvian2012Bible) { m_Latvian2012Bible = Latvian2012Bible; }
    public void SetLatvian2024Bible(string Latvian2024Bible) { m_Latvian2024Bible = Latvian2024Bible; }
    public void SetLatvianBible(string LatvianBible) { m_LatvianBible = LatvianBible; }
    public void SetLatvianGluckBible(string LatvianGluckBible) { m_LatvianGluckBible = LatvianGluckBible; }
    public void SetLatvianLG8Bible(string LatvianLG8Bible) { m_LatvianLG8Bible = LatvianLG8Bible; }
    public void SetLatvianLTV1965Bible(string LatvianLTV1965Bible) { m_LatvianLTV1965Bible = LatvianLTV1965Bible; }
    public void SetLatvianNLBDCBible(string LatvianNLBDCBible) { m_LatvianNLBDCBible = LatvianNLBDCBible; }
    public void SetLiberianKreyolBible(string LiberianKreyolBible) { m_LiberianKreyolBible = LiberianKreyolBible; }
    public void SetLingala2002Bible(string Lingala2002Bible) { m_Lingala2002Bible = Lingala2002Bible; }
    public void SetLingala2020Bible(string Lingala2020Bible) { m_Lingala2020Bible = Lingala2020Bible; }
    public void SetLithuanian2012Bible(string Lithuanian2012Bible) { m_Lithuanian2012Bible = Lithuanian2012Bible; }
    public void SetLithuanian2012EKUBible(string Lithuanian2012EKUBible) { m_Lithuanian2012EKUBible = Lithuanian2012EKUBible; }
    public void SetLithuanian2012KANBible(string Lithuanian2012KANBible) { m_Lithuanian2012KANBible = Lithuanian2012KANBible; }
    public void SetLithuanianBible(string LithuanianBible) { m_LithuanianBible = LithuanianBible; }
    public void SetLithuanianKJBible(string LithuanianKJBible) { m_LithuanianKJBible = LithuanianKJBible; }
    public void SetLithuanianLBDBible(string LithuanianLBDBible) { m_LithuanianLBDBible = LithuanianLBDBible; }
    public void SetLomweBible(string LomweBible) { m_LomweBible = LomweBible; }
    public void SetLuganda2003Bible(string Luganda2003Bible) { m_Luganda2003Bible = Luganda2003Bible; }
    public void SetLugandaBible(string LugandaBible) { m_LugandaBible = LugandaBible; }
    public void SetLugandaBIBU1Bible(string LugandaBIBU1Bible) { m_LugandaBIBU1Bible = LugandaBIBU1Bible; }
    public void SetLugandaEEEEBible(string LugandaEEEEBible) { m_LugandaEEEEBible = LugandaEEEEBible; }
    public void SetLugandaLBRBible(string LugandaLBRBible) { m_LugandaLBRBible = LugandaLBRBible; }
    public void SetLugbaraBible(string LugbaraBible) { m_LugbaraBible = LugbaraBible; }
    public void SetLuguruBible(string LuguruBible) { m_LuguruBible = LuguruBible; }
    public void SetLuo1985Bible(string Luo1985Bible) { m_Luo1985Bible = Luo1985Bible; }
    public void SetLuo2015Bible(string Luo2015Bible) { m_Luo2015Bible = Luo2015Bible; }
    public void SetLuo2020Bible(string Luo2020Bible) { m_Luo2020Bible = Luo2020Bible; }
    public void SetMaasai1970Bible(string Maasai1970Bible) { m_Maasai1970Bible = Maasai1970Bible; }
    public void SetMaasai2020Bible(string Maasai2020Bible) { m_Maasai2020Bible = Maasai2020Bible; }
    public void SetMaasaiBible(string MaasaiBible) { m_MaasaiBible = MaasaiBible; }
    public void SetMaasaiMBSBible(string MaasaiMBSBible) { m_MaasaiMBSBible = MaasaiMBSBible; }
    public void SetMacedonian1990Bible(string Macedonian1990Bible) { m_Macedonian1990Bible = Macedonian1990Bible; }
    public void SetMacedonian2006Bible(string Macedonian2006Bible) { m_Macedonian2006Bible = Macedonian2006Bible; }
    public void SetMacedonian2006DBible(string Macedonian2006DBible) { m_Macedonian2006DBible = Macedonian2006DBible; }
    public void SetMacedonian2023Bible(string Macedonian2023Bible) { m_Macedonian2023Bible = Macedonian2023Bible; }
    public void SetMacedonianMKB1999Bible(string MacedonianMKB1999Bible) { m_MacedonianMKB1999Bible = MacedonianMKB1999Bible; }
    public void SetMacedonianMNT1999Bible(string MacedonianMNT1999Bible) { m_MacedonianMNT1999Bible = MacedonianMNT1999Bible; }
    public void SetMadureseBible(string MadureseBible) { m_MadureseBible = MadureseBible; }
    public void SetMaithiliBible(string MaithiliBible) { m_MaithiliBible = MaithiliBible; }
    public void SetMakhuwa2021Bible(string Makhuwa2021Bible) { m_Makhuwa2021Bible = Makhuwa2021Bible; }
    public void SetMakhuwaBible(string MakhuwaBible) { m_MakhuwaBible = MakhuwaBible; }
    public void SetMakhuwaVMKBible(string MakhuwaVMKBible) { m_MakhuwaVMKBible = MakhuwaVMKBible; }
    public void SetMakondeBible(string MakondeBible) { m_MakondeBible = MakondeBible; }
    public void SetMakondeShiBible(string MakondeShiBible) { m_MakondeShiBible = MakondeShiBible; }
    public void SetMalagasy1865Bible(string Malagasy1865Bible) { m_Malagasy1865Bible = Malagasy1865Bible; }
    public void SetMalagasy2003Bible(string Malagasy2003Bible) { m_Malagasy2003Bible = Malagasy2003Bible; }
    public void SetMalagasy2004Bible(string Malagasy2004Bible) { m_Malagasy2004Bible = Malagasy2004Bible; }
    public void SetMalagasy2011Bible(string Malagasy2011Bible) { m_Malagasy2011Bible = Malagasy2011Bible; }
    public void SetMalagasyBible(string MalagasyBible) { m_MalagasyBible = MalagasyBible; }
    public void SetMalagasyMRVBible(string MalagasyMRVBible) { m_MalagasyMRVBible = MalagasyMRVBible; }
    public void SetMalayalam1910Bible(string Malayalam1910Bible) { m_Malayalam1910Bible = Malayalam1910Bible; }
    public void SetMalayalam2013Bible(string Malayalam2013Bible) { m_Malayalam2013Bible = Malayalam2013Bible; }
    public void SetMalayalamBCSBible(string MalayalamBCSBible) { m_MalayalamBCSBible = MalayalamBCSBible; }
    public void SetMalayalamBible(string MalayalamBible) { m_MalayalamBible = MalayalamBible; }
    public void SetMalayalamBSIBible(string MalayalamBSIBible) { m_MalayalamBSIBible = MalayalamBSIBible; }
    public void SetMalayalamCVBible(string MalayalamCVBible) { m_MalayalamCVBible = MalayalamCVBible; }
    public void SetMalayalamMalovBible(string MalayalamMalovBible) { m_MalayalamMalovBible = MalayalamMalovBible; }
    public void SetMalayalamWBTCBible(string MalayalamWBTCBible) { m_MalayalamWBTCBible = MalayalamWBTCBible; }
    public void SetMalaysian1996Bible(string Malaysian1996Bible) { m_Malaysian1996Bible = Malaysian1996Bible; }
    public void SetMalaysian2017Bible(string Malaysian2017Bible) { m_Malaysian2017Bible = Malaysian2017Bible; }
    public void SetMalaysian2020Bible(string Malaysian2020Bible) { m_Malaysian2020Bible = Malaysian2020Bible; }
    public void SetMalaysianBible(string MalaysianBible) { m_MalaysianBible = MalaysianBible; }
    public void SetMaori2012Bible(string Maori2012Bible) { m_Maori2012Bible = Maori2012Bible; }
    public void SetMaoriBible(string MaoriBible) { m_MaoriBible = MaoriBible; }
    public void SetMarathi2015Bible(string Marathi2015Bible) { m_Marathi2015Bible = Marathi2015Bible; }
    public void SetMarathiBible(string MarathiBible) { m_MarathiBible = MarathiBible; }
    public void SetMarathiBSIBible(string MarathiBSIBible) { m_MarathiBSIBible = MarathiBSIBible; }
    public void SetMarathiIRVMARBible(string MarathiIRVMARBible) { m_MarathiIRVMARBible = MarathiIRVMARBible; }
    public void SetMarathiMRCVBible(string MarathiMRCVBible) { m_MarathiMRCVBible = MarathiMRCVBible; }
    public void SetMarwariBible(string MarwariBible) { m_MarwariBible = MarwariBible; }
    public void SetMazanderaniGMBBible(string MazanderaniGMBBible) { m_MazanderaniGMBBible = MazanderaniGMBBible; }
    public void SetMazanderaniBible(string MazanderaniBible) { m_MazanderaniBible = MazanderaniBible; }
    public void SetMazanderaniWMBBible(string MazanderaniWMBBible) { m_MazanderaniWMBBible = MazanderaniWMBBible; }
    public void SetMeiteiBible(string MeiteiBible) { m_MeiteiBible = MeiteiBible; }
    public void SetMendeBible(string MendeBible) { m_MendeBible = MendeBible; }
    public void SetMewariBible(string MewariBible) { m_MewariBible = MewariBible; }
    public void SetMizoBible(string MizoBible) { m_MizoBible = MizoBible; }
    public void SetMizoCLBSIBible(string MizoCLBSIBible) { m_MizoCLBSIBible = MizoCLBSIBible; }
    public void SetMizoOVBSIBible(string MizoOVBSIBible) { m_MizoOVBSIBible = MizoOVBSIBible; }
    public void SetMobaBible(string MobaBible) { m_MobaBible = MobaBible; }
    public void SetMoldovianCyrillicBible(string MoldovianCyrillicBible) { m_MoldovianCyrillicBible = MoldovianCyrillicBible; }
    public void SetMoldovianLatinBible(string MoldovianLatinBible) { m_MoldovianLatinBible = MoldovianLatinBible; }
    public void SetMongolian2004Bible(string Mongolian2004Bible) { m_Mongolian2004Bible = Mongolian2004Bible; }
    public void SetMongolian2013Bible(string Mongolian2013Bible) { m_Mongolian2013Bible = Mongolian2013Bible; }
    public void SetMorisyen2021Bible(string Morisyen2021Bible) { m_Morisyen2021Bible = Morisyen2021Bible; }
    public void SetMorisyenBible(string MorisyenBible) { m_MorisyenBible = MorisyenBible; }
    public void SetMossi2014Bible(string Mossi2014Bible) { m_Mossi2014Bible = Mossi2014Bible; }
    public void SetMossiSBBible(string MossiSBBible) { m_MossiSBBible = MossiSBBible; }
    public void SetMossiSSDCBible(string MossiSSDCBible) { m_MossiSSDCBible = MossiSSDCBible; }
    public void SetMunda2020Bible(string Munda2020Bible) { m_Munda2020Bible = Munda2020Bible; }
    public void SetMundaBible(string MundaBible) { m_MundaBible = MundaBible; }
    public void SetNahuatl2012Bible(string Nahuatl2012Bible) { m_Nahuatl2012Bible = Nahuatl2012Bible; }
    public void SetNahuatl2017Bible(string Nahuatl2017Bible) { m_Nahuatl2017Bible = Nahuatl2017Bible; }
    public void SetNahuatlBible(string NahuatlBible) { m_NahuatlBible = NahuatlBible; }
    public void SetNahuatlGUBible(string NahuatlGUBible) { m_NahuatlGUBible = NahuatlGUBible; }
    public void SetNahuatlNHEBible(string NahuatlNHEBible) { m_NahuatlNHEBible = NahuatlNHEBible; }
    public void SetNdau2023Bible(string Ndau2023Bible) { m_Ndau2023Bible = Ndau2023Bible; }
    public void SetNdauBible(string NdauBible) { m_NdauBible = NdauBible; }
    public void SetNdebele2002Bible(string Ndebele2002Bible) { m_Ndebele2002Bible = Ndebele2002Bible; }
    public void SetNdebele2003Bible(string Ndebele2003Bible) { m_Ndebele2003Bible = Ndebele2003Bible; }
    public void SetNdebele2012Bible(string Ndebele2012Bible) { m_Ndebele2012Bible = Ndebele2012Bible; }
    public void SetNdebeleBible(string NdebeleBible) { m_NdebeleBible = NdebeleBible; }
    public void SetNepali2008Bible(string Nepali2008Bible) { m_Nepali2008Bible = Nepali2008Bible; }
    public void SetNepali2012Bible(string Nepali2012Bible) { m_Nepali2012Bible = Nepali2012Bible; }
    public void SetNepali2021Bible(string Nepali2021Bible) { m_Nepali2021Bible = Nepali2021Bible; }
    public void SetNepaliBible(string NepaliBible) { m_NepaliBible = NepaliBible; }
    public void SetNepaliTamangBible(string NepaliTamangBible) { m_NepaliTamangBible = NepaliTamangBible; }
    public void SetNigerianPidginBible(string NigerianPidginBible) { m_NigerianPidginBible = NigerianPidginBible; }
    public void SetNorwegian1921Bible(string Norwegian1921Bible) { m_Norwegian1921Bible = Norwegian1921Bible; }
    public void SetNorwegian1938Bible(string Norwegian1938Bible) { m_Norwegian1938Bible = Norwegian1938Bible; }
    public void SetNorwegian1978Bible(string Norwegian1978Bible) { m_Norwegian1978Bible = Norwegian1978Bible; }
    public void SetNorwegian2007Bible(string Norwegian2007Bible) { m_Norwegian2007Bible = Norwegian2007Bible; }
    public void SetNorwegian2011Bible(string Norwegian2011Bible) { m_Norwegian2011Bible = Norwegian2011Bible; }
    public void SetNorwegian2018Bible(string Norwegian2018Bible) { m_Norwegian2018Bible = Norwegian2018Bible; }
    public void SetNorwegianBGOBible(string NorwegianBGOBible) { m_NorwegianBGOBible = NorwegianBGOBible; }
    public void SetNorwegianBIBEL1978Bible(string NorwegianBIBEL1978Bible) { m_NorwegianBIBEL1978Bible = NorwegianBIBEL1978Bible; }
    public void SetNorwegianBible(string NorwegianBible) { m_NorwegianBible = NorwegianBible; }
    public void SetNorwegianELBBible(string NorwegianELBBible) { m_NorwegianELBBible = NorwegianELBBible; }
    public void SetNorwegianN78BMBible(string NorwegianN78BMBible) { m_NorwegianN78BMBible = NorwegianN78BMBible; }
    public void SetNorwegianN78NNBible(string NorwegianN78NNBible) { m_NorwegianN78NNBible = NorwegianN78NNBible; }
    public void SetNorwegianNY2011Bible(string NorwegianNY2011Bible) { m_NorwegianNY2011Bible = NorwegianNY2011Bible; }
    public void SetNuerBible(string NuerBible) { m_NuerBible = NuerBible; }
    public void SetNyankole1964Bible(string Nyankole1964Bible) { m_Nyankole1964Bible = Nyankole1964Bible; }
    public void SetNyankoleBible(string NyankoleBible) { m_NyankoleBible = NyankoleBible; }
    public void SetOdia2024Bible(string Odia2024Bible) { m_Odia2024Bible = Odia2024Bible; }
    public void SetOdiaBible(string OdiaBible) { m_OdiaBible = OdiaBible; }
    public void SetOdiaBSIBible(string OdiaBSIBible) { m_OdiaBSIBible = OdiaBSIBible; }
    public void SetOdiaERVBible(string OdiaERVBible) { m_OdiaERVBible = OdiaERVBible; }
    public void SetOdiaIRV2017Bible(string OdiaIRV2017Bible) { m_OdiaIRV2017Bible = OdiaIRV2017Bible; }
    public void SetOdiaIRVBible(string OdiaIRVBible) { m_OdiaIRVBible = OdiaIRVBible; }
    public void SetOdiaOROVBible(string OdiaOROVBible) { m_OdiaOROVBible = OdiaOROVBible; }
    public void SetOriginalGreekBible(string OriginalGreekBible) { m_OriginalGreekBible = OriginalGreekBible; }
    public void SetOriginalHebrewBible(string OriginalHebrewBible) { m_OriginalHebrewBible = OriginalHebrewBible; }
    public void SetOromoGUJBible(string OromoGUJBible) { m_OromoGUJBible = OromoGUJBible; }
    public void SetOromoGujiBible(string OromoGujiBible) { m_OromoGujiBible = OromoGujiBible; }
    public void SetOromoKakuuHaaraakaBible(string OromoKakuuHaaraakaBible) { m_OromoKakuuHaaraakaBible = OromoKakuuHaaraakaBible; }
    public void SetOromoKitaabaWaaqaBible(string OromoKitaabaWaaqaBible) { m_OromoKitaabaWaaqaBible = OromoKitaabaWaaqaBible; }
    public void SetOromoKitaabaWoyyuuBible(string OromoKitaabaWoyyuuBible) { m_OromoKitaabaWoyyuuBible = OromoKitaabaWoyyuuBible; }
    public void SetOromoWaadaaHaarawaBible(string OromoWaadaaHaarawaBible) { m_OromoWaadaaHaarawaBible = OromoWaadaaHaarawaBible; }
    public void SetOromoWaadaaLammataaBible(string OromoWaadaaLammataaBible) { m_OromoWaadaaLammataaBible = OromoWaadaaLammataaBible; }
    public void SetPampangaBible(string PampangaBible) { m_PampangaBible = PampangaBible; }
    public void SetPapuaNewGuineaBible(string PapuaNewGuineaBible) { m_PapuaNewGuineaBible = PapuaNewGuineaBible; }
    public void SetPapuaNewGuineaTokPisinBible(string PapuaNewGuineaTokPisinBible) { m_PapuaNewGuineaTokPisinBible = PapuaNewGuineaTokPisinBible; }
    public void SetPashto2019Bible(string Pashto2019Bible) { m_Pashto2019Bible = Pashto2019Bible; }
    public void SetPashto2023Bible(string Pashto2023Bible) { m_Pashto2023Bible = Pashto2023Bible; }
    public void SetPashtoBible(string PashtoBible) { m_PashtoBible = PashtoBible; }
    public void SetPersian2005Bible(string Persian2005Bible) { m_Persian2005Bible = Persian2005Bible; }
    public void SetPersian2014Bible(string Persian2014Bible) { m_Persian2014Bible = Persian2014Bible; }
    public void SetPersianBible(string PersianBible) { m_PersianBible = PersianBible; }
    public void SetPersianDariBible(string PersianDariBible) { m_PersianDariBible = PersianDariBible; }
    public void SetPersianTPVBible(string PersianTPVBible) { m_PersianTPVBible = PersianTPVBible; }
    public void SetPolish2016Bible(string Polish2016Bible) { m_Polish2016Bible = Polish2016Bible; }
    public void SetPolish2018Bible(string Polish2018Bible) { m_Polish2018Bible = Polish2018Bible; }
    public void SetPolishBible(string PolishBible) { m_PolishBible = PolishBible; }
    public void SetPolishGdansk2017Bible(string PolishGdansk2017Bible) { m_PolishGdansk2017Bible = PolishGdansk2017Bible; }
    public void SetPolishGdanskBible(string PolishGdanskBible) { m_PolishGdanskBible = PolishGdanskBible; }
    public void SetPolishNBGBible(string PolishNBGBible) { m_PolishNBGBible = PolishNBGBible; }
    public void SetPolishNPDBible(string PolishNPDBible) { m_PolishNPDBible = PolishNPDBible; }
    public void SetPolishSNPD4Bible(string PolishSNPD4Bible) { m_PolishSNPD4Bible = PolishSNPD4Bible; }
    public void SetPortuguese1969Bible(string Portuguese1969Bible) { m_Portuguese1969Bible = Portuguese1969Bible; }
    public void SetPortugueseA21Bible(string PortugueseA21Bible) { m_PortugueseA21Bible = PortugueseA21Bible; }
    public void SetPortugueseAlmeida1628Bible(string PortugueseAlmeida1628Bible) { m_PortugueseAlmeida1628Bible = PortugueseAlmeida1628Bible; }
    public void SetPortugueseAlmeida1753Bible(string PortugueseAlmeida1753Bible) { m_PortugueseAlmeida1753Bible = PortugueseAlmeida1753Bible; }
    public void SetPortugueseARCBible(string PortugueseARCBible) { m_PortugueseARCBible = PortugueseARCBible; }
    public void SetPortugueseBible(string PortugueseBible) { m_PortugueseBible = PortugueseBible; }
    public void SetPortugueseBLTBible(string PortugueseBLTBible) { m_PortugueseBLTBible = PortugueseBLTBible; }
    public void SetPortugueseBPT09Bible(string PortugueseBPT09Bible) { m_PortugueseBPT09Bible = PortugueseBPT09Bible; }
    public void SetPortugueseCAPBible(string PortugueseCAPBible) { m_PortugueseCAPBible = PortugueseCAPBible; }
    public void SetPortugueseMZNVIBible(string PortugueseMZNVIBible) { m_PortugueseMZNVIBible = PortugueseMZNVIBible; }
    public void SetPortugueseNAABible(string PortugueseNAABible) { m_PortugueseNAABible = PortugueseNAABible; }
    public void SetPortugueseNBV2007Bible(string PortugueseNBV2007Bible) { m_PortugueseNBV2007Bible = PortugueseNBV2007Bible; }
    public void SetPortugueseNTLHBible(string PortugueseNTLHBible) { m_PortugueseNTLHBible = PortugueseNTLHBible; }
    public void SetPortugueseNVI2023Bible(string PortugueseNVI2023Bible) { m_PortugueseNVI2023Bible = PortugueseNVI2023Bible; }
    public void SetPortugueseNVIBible(string PortugueseNVIBible) { m_PortugueseNVIBible = PortugueseNVIBible; }
    public void SetPortugueseNVTBible(string PortugueseNVTBible) { m_PortugueseNVTBible = PortugueseNVTBible; }
    public void SetPortugueseOLBible(string PortugueseOLBible) { m_PortugueseOLBible = PortugueseOLBible; }
    public void SetPortugueseTBBible(string PortugueseTBBible) { m_PortugueseTBBible = PortugueseTBBible; }
    public void SetPortugueseVFLBible(string PortugueseVFLBible) { m_PortugueseVFLBible = PortugueseVFLBible; }
    public void SetPularBible(string PularBible) { m_PularBible = PularBible; }
    public void SetPunjabi2016Bible(string Punjabi2016Bible) { m_Punjabi2016Bible = Punjabi2016Bible; }
    public void SetPunjabi2020Bible(string Punjabi2020Bible) { m_Punjabi2020Bible = Punjabi2020Bible; }
    public void SetPunjabi2021Bible(string Punjabi2021Bible) { m_Punjabi2021Bible = Punjabi2021Bible; }
    public void SetPunjabi2022Bible(string Punjabi2022Bible) { m_Punjabi2022Bible = Punjabi2022Bible; }
    public void SetPunjabi2023Bible(string Punjabi2023Bible) { m_Punjabi2023Bible = Punjabi2023Bible; }
    public void SetPunjabiBible(string PunjabiBible) { m_PunjabiBible = PunjabiBible; }
    public void SetPunjabiERVBible(string PunjabiERVBible) { m_PunjabiERVBible = PunjabiERVBible; }
    public void SetPunjabiIRVBible(string PunjabiIRVBible) { m_PunjabiIRVBible = PunjabiIRVBible; }
    public void SetQeqchiBible(string QeqchiBible) { m_QeqchiBible = QeqchiBible; }
    public void SetQuechuan2010Bible(string Quechuan2010Bible) { m_Quechuan2010Bible = Quechuan2010Bible; }
    public void SetQuechuanBible(string QuechuanBible) { m_QuechuanBible = QuechuanBible; }
    public void SetQuechuanQVBMBible(string QuechuanQVBMBible) { m_QuechuanQVBMBible = QuechuanQVBMBible; }
    public void SetQuechuanQVSBible(string QuechuanQVSBible) { m_QuechuanQVSBible = QuechuanQVSBible; }
    public void SetQuechuanQVWBible(string QuechuanQVWBible) { m_QuechuanQVWBible = QuechuanQVWBible; }
    public void SetQuechuanQXOBible(string QuechuanQXOBible) { m_QuechuanQXOBible = QuechuanQXOBible; }
    public void SetRomani2004Bible(string Romani2004Bible) { m_Romani2004Bible = Romani2004Bible; }
    public void SetRomani2007Bible(string Romani2007Bible) { m_Romani2007Bible = Romani2007Bible; }
    public void SetRomanian1928Bible(string Romanian1928Bible) { m_Romanian1928Bible = Romanian1928Bible; }
    public void SetRomanian1931Bible(string Romanian1931Bible) { m_Romanian1931Bible = Romanian1931Bible; }
    public void SetRomanian2009Bible(string Romanian2009Bible) { m_Romanian2009Bible = Romanian2009Bible; }
    public void SetRomanian2014Bible(string Romanian2014Bible) { m_Romanian2014Bible = Romanian2014Bible; }
    public void SetRomanian2015Bible(string Romanian2015Bible) { m_Romanian2015Bible = Romanian2015Bible; }
    public void SetRomanian2018Bible(string Romanian2018Bible) { m_Romanian2018Bible = Romanian2018Bible; }
    public void SetRomanian2020Bible(string Romanian2020Bible) { m_Romanian2020Bible = Romanian2020Bible; }
    public void SetRomanian2021Bible(string Romanian2021Bible) { m_Romanian2021Bible = Romanian2021Bible; }
    public void SetRomanian2022Bible(string Romanian2022Bible) { m_Romanian2022Bible = Romanian2022Bible; }
    public void SetRomanian2023Bible(string Romanian2023Bible) { m_Romanian2023Bible = Romanian2023Bible; }
    public void SetRomanianBDKBible(string RomanianBDKBible) { m_RomanianBDKBible = RomanianBDKBible; }
    public void SetRomanianBible(string RomanianBible) { m_RomanianBible = RomanianBible; }
    public void SetRomanianSBIRBible(string RomanianSBIRBible) { m_RomanianSBIRBible = RomanianSBIRBible; }
    public void SetRomaniBACHROBible(string RomaniBACHROBible) { m_RomaniBACHROBible = RomaniBACHROBible; }
    public void SetRomaniBaltic2019Bible(string RomaniBaltic2019Bible) { m_RomaniBaltic2019Bible = RomaniBaltic2019Bible; }
    public void SetRomaniBalticLT2019Bible(string RomaniBalticLT2019Bible) { m_RomaniBalticLT2019Bible = RomaniBalticLT2019Bible; }
    public void SetRomaniBible(string RomaniBible) { m_RomaniBible = RomaniBible; }
    public void SetRomaniCHERGASHBible(string RomaniCHERGASHBible) { m_RomaniCHERGASHBible = RomaniCHERGASHBible; }
    public void SetRomaniGSPBible(string RomaniGSPBible) { m_RomaniGSPBible = RomaniGSPBible; }
    public void SetRomaniKALD2004Bible(string RomaniKALD2004Bible) { m_RomaniKALD2004Bible = RomaniKALD2004Bible; }
    public void SetRomaniKALD2020Bible(string RomaniKALD2020Bible) { m_RomaniKALD2020Bible = RomaniKALD2020Bible; }
    public void SetRomaniRMCBible(string RomaniRMCBible) { m_RomaniRMCBible = RomaniRMCBible; }
    public void SetRomaniROM07Bible(string RomaniROM07Bible) { m_RomaniROM07Bible = RomaniROM07Bible; }
    public void SetRomaniROM6Bible(string RomaniROM6Bible) { m_RomaniROM6Bible = RomaniROM6Bible; }
    public void SetRomaniSERBible(string RomaniSERBible) { m_RomaniSERBible = RomaniSERBible; }
    public void SetRomaniSINT2024Bible(string RomaniSINT2024Bible) { m_RomaniSINT2024Bible = RomaniSINT2024Bible; }
    public void SetRussian2012Bible(string Russian2012Bible) { m_Russian2012Bible = Russian2012Bible; }
    public void SetRussianAGPBible(string RussianAGPBible) { m_RussianAGPBible = RussianAGPBible; }
    public void SetRussianBTI2015Bible(string RussianBTI2015Bible) { m_RussianBTI2015Bible = RussianBTI2015Bible; }
    public void SetRussianCARSABible(string RussianCARSABible) { m_RussianCARSABible = RussianCARSABible; }
    public void SetRussianCARSBible(string RussianCARSBible) { m_RussianCARSBible = RussianCARSBible; }
    public void SetRussianCASBible(string RussianCASBible) { m_RussianCASBible = RussianCASBible; }
    public void SetRussianCSLAVBible(string RussianCSLAVBible) { m_RussianCSLAVBible = RussianCSLAVBible; }
    public void SetRussianJewishBible(string RussianJewishBible) { m_RussianJewishBible = RussianJewishBible; }
    public void SetRussianJubileeBible(string RussianJubileeBible) { m_RussianJubileeBible = RussianJubileeBible; }
    public void SetRussianMengeBible(string RussianMengeBible) { m_RussianMengeBible = RussianMengeBible; }
    public void SetRussianNRTBible(string RussianNRTBible) { m_RussianNRTBible = RussianNRTBible; }
    public void SetRussianReceptusBible(string RussianReceptusBible) { m_RussianReceptusBible = RussianReceptusBible; }
    public void SetRussianRSPBible(string RussianRSPBible) { m_RussianRSPBible = RussianRSPBible; }
    public void SetRussianRSTBible(string RussianRSTBible) { m_RussianRSTBible = RussianRSTBible; }
    public void SetRussianSlovoBible(string RussianSlovoBible) { m_RussianSlovoBible = RussianSlovoBible; }
    public void SetRussianSynodalBible(string RussianSynodalBible) { m_RussianSynodalBible = RussianSynodalBible; }
    public void SetRussianWBTCBible(string RussianWBTCBible) { m_RussianWBTCBible = RussianWBTCBible; }
    public void SetSadriBible(string SadriBible) { m_SadriBible = SadriBible; }
    public void SetSanskritDevanagariBible(string SanskritDevanagariBible) { m_SanskritDevanagariBible = SanskritDevanagariBible; }
    public void SetSantaliBangladeshBible(string SantaliBangladeshBible) { m_SantaliBangladeshBible = SantaliBangladeshBible; }
    public void SetSantaliCommonBible(string SantaliCommonBible) { m_SantaliCommonBible = SantaliCommonBible; }
    public void SetSasakBible(string SasakBible) { m_SasakBible = SasakBible; }
    public void SetSena2014Bible(string Sena2014Bible) { m_Sena2014Bible = Sena2014Bible; }
    public void SetSenaBible(string SenaBible) { m_SenaBible = SenaBible; }
    public void SetSenaMalawiBible(string SenaMalawiBible) { m_SenaMalawiBible = SenaMalawiBible; }
    public void SetSeraikiBible(string SeraikiBible) { m_SeraikiBible = SeraikiBible; }
    public void SetSerbianBible(string SerbianBible) { m_SerbianBible = SerbianBible; }
    public void SetSerbianCNZBible(string SerbianCNZBible) { m_SerbianCNZBible = SerbianCNZBible; }
    public void SetSerbianERVBible(string SerbianERVBible) { m_SerbianERVBible = SerbianERVBible; }
    public void SetSerbianLatinBible(string SerbianLatinBible) { m_SerbianLatinBible = SerbianLatinBible; }
    public void SetSerbianNSTBible(string SerbianNSTBible) { m_SerbianNSTBible = SerbianNSTBible; }
    public void SetSerbianNSTLBible(string SerbianNSTLBible) { m_SerbianNSTLBible = SerbianNSTLBible; }
    public void SetSerbianSDSBible(string SerbianSDSBible) { m_SerbianSDSBible = SerbianSDSBible; }
    public void SetShanBible(string ShanBible) { m_ShanBible = ShanBible; }
    public void SetShanNCLBible(string ShanNCLBible) { m_ShanNCLBible = ShanNCLBible; }
    public void SetShekhawatiBible(string ShekhawatiBible) { m_ShekhawatiBible = ShekhawatiBible; }
    public void SetShillukBible(string ShillukBible) { m_ShillukBible = ShillukBible; }
    public void SetShona1949Bible(string Shona1949Bible) { m_Shona1949Bible = Shona1949Bible; }
    public void SetShona2002Bible(string Shona2002Bible) { m_Shona2002Bible = Shona2002Bible; }
    public void SetShonaBDSCBible(string ShonaBDSCBible) { m_ShonaBDSCBible = ShonaBDSCBible; }
    public void SetShonaBible(string ShonaBible) { m_ShonaBible = ShonaBible; }
    public void SetShonaSCLBBible(string ShonaSCLBBible) { m_ShonaSCLBBible = ShonaSCLBBible; }
    public void SetShonaSUBBible(string ShonaSUBBible) { m_ShonaSUBBible = ShonaSUBBible; }
    public void SetSidamoBible(string SidamoBible) { m_SidamoBible = SidamoBible; }
    public void SetSindhiBible(string SindhiBible) { m_SindhiBible = SindhiBible; }
    public void SetSindhiCommonBible(string SindhiCommonBible) { m_SindhiCommonBible = SindhiCommonBible; }
    public void SetSindhiHinduBible(string SindhiHinduBible) { m_SindhiHinduBible = SindhiHinduBible; }
    public void SetSindhiMuslimBible(string SindhiMuslimBible) { m_SindhiMuslimBible = SindhiMuslimBible; }
    public void SetSinhalaNRSVBible(string SinhalaNRSVBible) { m_SinhalaNRSVBible = SinhalaNRSVBible; }
    public void SetSinhalaSCVBible(string SinhalaSCVBible) { m_SinhalaSCVBible = SinhalaSCVBible; }
    public void SetSinhalaSNRVBible(string SinhalaSNRVBible) { m_SinhalaSNRVBible = SinhalaSNRVBible; }
    public void SetSinhalaSROVBible(string SinhalaSROVBible) { m_SinhalaSROVBible = SinhalaSROVBible; }
    public void SetSiswatiBible(string SiswatiBible) { m_SiswatiBible = SiswatiBible; }
    public void SetSlovakian2015Bible(string Slovakian2015Bible) { m_Slovakian2015Bible = Slovakian2015Bible; }
    public void SetSlovakian2017Bible(string Slovakian2017Bible) { m_Slovakian2017Bible = Slovakian2017Bible; }
    public void SetSlovakianBible(string SlovakianBible) { m_SlovakianBible = SlovakianBible; }
    public void SetSlovakianNPK2023Bible(string SlovakianNPK2023Bible) { m_SlovakianNPK2023Bible = SlovakianNPK2023Bible; }
    public void SetSlovakianNPKBible(string SlovakianNPKBible) { m_SlovakianNPKBible = SlovakianNPKBible; }
    public void SetSlovakianRomaniBible(string SlovakianRomaniBible) { m_SlovakianRomaniBible = SlovakianRomaniBible; }
    public void SetSlovakianSEBBible(string SlovakianSEBBible) { m_SlovakianSEBBible = SlovakianSEBBible; }
    public void SetSlovakianSLBBible(string SlovakianSLBBible) { m_SlovakianSLBBible = SlovakianSLBBible; }
    public void SetSlovakianSSVBible(string SlovakianSSVBible) { m_SlovakianSSVBible = SlovakianSSVBible; }
    public void SetSlovenian1584Bible(string Slovenian1584Bible) { m_Slovenian1584Bible = Slovenian1584Bible; }
    public void SetSlovenian1882Bible(string Slovenian1882Bible) { m_Slovenian1882Bible = Slovenian1882Bible; }
    public void SetSlovenian1928Bible(string Slovenian1928Bible) { m_Slovenian1928Bible = Slovenian1928Bible; }
    public void SetSlovenian1990Bible(string Slovenian1990Bible) { m_Slovenian1990Bible = Slovenian1990Bible; }
    public void SetSlovenian2014Bible(string Slovenian2014Bible) { m_Slovenian2014Bible = Slovenian2014Bible; }
    public void SetSlovenianBible(string SlovenianBible) { m_SlovenianBible = SlovenianBible; }
    public void SetSlovenianEKUBible(string SlovenianEKUBible) { m_SlovenianEKUBible = SlovenianEKUBible; }
    public void SetSlovenianSSPBible(string SlovenianSSPBible) { m_SlovenianSSPBible = SlovenianSSPBible; }
    public void SetSogaBible(string SogaBible) { m_SogaBible = SogaBible; }
    public void SetSomalian2018Bible(string Somalian2018Bible) { m_Somalian2018Bible = Somalian2018Bible; }
    public void SetSomalian2024Bible(string Somalian2024Bible) { m_Somalian2024Bible = Somalian2024Bible; }
    public void SetSomalianBible(string SomalianBible) { m_SomalianBible = SomalianBible; }
    public void SetSongeBible(string SongeBible) { m_SongeBible = SongeBible; }
    public void SetSotho1951Bible(string Sotho1951Bible) { m_Sotho1951Bible = Sotho1951Bible; }
    public void SetSotho1989Bible(string Sotho1989Bible) { m_Sotho1989Bible = Sotho1989Bible; }
    public void SetSotho2000Bible(string Sotho2000Bible) { m_Sotho2000Bible = Sotho2000Bible; }
    public void SetSothoBible(string SothoBible) { m_SothoBible = SothoBible; }
    public void SetSpanish1569Bible(string Spanish1569Bible) { m_Spanish1569Bible = Spanish1569Bible; }
    public void SetSpanish1858Bible(string Spanish1858Bible) { m_Spanish1858Bible = Spanish1858Bible; }
    public void SetSpanish1989Bible(string Spanish1989Bible) { m_Spanish1989Bible = Spanish1989Bible; }
    public void SetSpanishBDOBible(string SpanishBDOBible) { m_SpanishBDOBible = SpanishBDOBible; }
    public void SetSpanishBHTIBible(string SpanishBHTIBible) { m_SpanishBHTIBible = SpanishBHTIBible; }
    public void SetSpanishBible(string SpanishBible) { m_SpanishBible = SpanishBible; }
    public void SetSpanishBLPBible(string SpanishBLPBible) { m_SpanishBLPBible = SpanishBLPBible; }
    public void SetSpanishBLPHBible(string SpanishBLPHBible) { m_SpanishBLPHBible = SpanishBLPHBible; }
    public void SetSpanishBTIBible(string SpanishBTIBible) { m_SpanishBTIBible = SpanishBTIBible; }
    public void SetSpanishBTXBible(string SpanishBTXBible) { m_SpanishBTXBible = SpanishBTXBible; }
    public void SetSpanishDHHBible(string SpanishDHHBible) { m_SpanishDHHBible = SpanishDHHBible; }
    public void SetSpanishJBSBible(string SpanishJBSBible) { m_SpanishJBSBible = SpanishJBSBible; }
    public void SetSpanishLBLABible(string SpanishLBLABible) { m_SpanishLBLABible = SpanishLBLABible; }
    public void SetSpanishNBLABible(string SpanishNBLABible) { m_SpanishNBLABible = SpanishNBLABible; }
    public void SetSpanishNBVBible(string SpanishNBVBible) { m_SpanishNBVBible = SpanishNBVBible; }
    public void SetSpanishNTBIZBible(string SpanishNTBIZBible) { m_SpanishNTBIZBible = SpanishNTBIZBible; }
    public void SetSpanishNTVBible(string SpanishNTVBible) { m_SpanishNTVBible = SpanishNTVBible; }
    public void SetSpanishNVIBible(string SpanishNVIBible) { m_SpanishNVIBible = SpanishNVIBible; }
    public void SetSpanishNVISBible(string SpanishNVISBible) { m_SpanishNVISBible = SpanishNVISBible; }
    public void SetSpanishPDTBible(string SpanishPDTBible) { m_SpanishPDTBible = SpanishPDTBible; }
    public void SetSpanishRevisedRVR1960Bible(string SpanishRevisedRVR1960Bible) { m_SpanishRevisedRVR1960Bible = SpanishRevisedRVR1960Bible; }
    public void SetSpanishRV2020Bible(string SpanishRV2020Bible) { m_SpanishRV2020Bible = SpanishRV2020Bible; }
    public void SetSpanishRVA2015Bible(string SpanishRVA2015Bible) { m_SpanishRVA2015Bible = SpanishRVA2015Bible; }
    public void SetSpanishRVCBible(string SpanishRVCBible) { m_SpanishRVCBible = SpanishRVCBible; }
    public void SetSpanishRVESBible(string SpanishRVESBible) { m_SpanishRVESBible = SpanishRVESBible; }
    public void SetSpanishRVGBible(string SpanishRVGBible) { m_SpanishRVGBible = SpanishRVGBible; }
    public void SetSpanishRVR1960Bible(string SpanishRVR1960Bible) { m_SpanishRVR1960Bible = SpanishRVR1960Bible; }
    public void SetSpanishRVR1995Bible(string SpanishRVR1995Bible) { m_SpanishRVR1995Bible = SpanishRVR1995Bible; }
    public void SetSpanishTLABible(string SpanishTLABible) { m_SpanishTLABible = SpanishTLABible; }
    public void SetSpanishVBL2022Bible(string SpanishVBL2022Bible) { m_SpanishVBL2022Bible = SpanishVBL2022Bible; }
    public void SetSpanishVBLBible(string SpanishVBLBible) { m_SpanishVBLBible = SpanishVBLBible; }
    public void SetSukuma1960Bible(string Sukuma1960Bible) { m_Sukuma1960Bible = Sukuma1960Bible; }
    public void SetSukumaBible(string SukumaBible) { m_SukumaBible = SukumaBible; }
    public void SetSundaneseBible(string SundaneseBible) { m_SundaneseBible = SundaneseBible; }
    public void SetSwahili1850Bible(string Swahili1850Bible) { m_Swahili1850Bible = Swahili1850Bible; }
    public void SetSwahili2001Bible(string Swahili2001Bible) { m_Swahili2001Bible = Swahili2001Bible; }
    public void SetSwahili2017Bible(string Swahili2017Bible) { m_Swahili2017Bible = Swahili2017Bible; }
    public void SetSwahili2024Bible(string Swahili2024Bible) { m_Swahili2024Bible = Swahili2024Bible; }
    public void SetSwahiliBHNTLKBible(string SwahiliBHNTLKBible) { m_SwahiliBHNTLKBible = SwahiliBHNTLKBible; }
    public void SetSwahiliBible(string SwahiliBible) { m_SwahiliBible = SwahiliBible; }
    public void SetSwahiliContemporaryBible(string SwahiliContemporaryBible) { m_SwahiliContemporaryBible = SwahiliContemporaryBible; }
    public void SetSwahiliNMMBible(string SwahiliNMMBible) { m_SwahiliNMMBible = SwahiliNMMBible; }
    public void SetSwahiliRSUVDCBible(string SwahiliRSUVDCBible) { m_SwahiliRSUVDCBible = SwahiliRSUVDCBible; }
    public void SetSwahiliSCLDC10Bible(string SwahiliSCLDC10Bible) { m_SwahiliSCLDC10Bible = SwahiliSCLDC10Bible; }
    public void SetSwahiliSRB37Bible(string SwahiliSRB37Bible) { m_SwahiliSRB37Bible = SwahiliSRB37Bible; }
    public void SetSwahiliSUVBible(string SwahiliSUVBible) { m_SwahiliSUVBible = SwahiliSUVBible; }
    public void SetSwahiliSWC02Bible(string SwahiliSWC02Bible) { m_SwahiliSWC02Bible = SwahiliSWC02Bible; }
    public void SetSwahiliSWZZB1921Bible(string SwahiliSWZZB1921Bible) { m_SwahiliSWZZB1921Bible = SwahiliSWZZB1921Bible; }
    public void SetSwedish1873Bible(string Swedish1873Bible) { m_Swedish1873Bible = Swedish1873Bible; }
    public void SetSwedish2000Bible(string Swedish2000Bible) { m_Swedish2000Bible = Swedish2000Bible; }
    public void SetSwedish2015Bible(string Swedish2015Bible) { m_Swedish2015Bible = Swedish2015Bible; }
    public void SetSwedish2019Bible(string Swedish2019Bible) { m_Swedish2019Bible = Swedish2019Bible; }
    public void SetSwedishBible(string SwedishBible) { m_SwedishBible = SwedishBible; }
    public void SetSwedishFolkBible(string SwedishFolkBible) { m_SwedishFolkBible = SwedishFolkBible; }
    public void SetSwedishNLBBible(string SwedishNLBBible) { m_SwedishNLBBible = SwedishNLBBible; }
    public void SetSwedishSB2016Bible(string SwedishSB2016Bible) { m_SwedishSB2016Bible = SwedishSB2016Bible; }
    public void SetSwedishSFBBible(string SwedishSFBBible) { m_SwedishSFBBible = SwedishSFBBible; }
    public void SetSylhetiBible(string SylhetiBible) { m_SylhetiBible = SylhetiBible; }
    public void SetSylhetiSYLLBible(string SylhetiSYLLBible) { m_SylhetiSYLLBible = SylhetiSYLLBible; }
    public void SetTagalog2001Bible(string Tagalog2001Bible) { m_Tagalog2001Bible = Tagalog2001Bible; }
    public void SetTagalog2005Bible(string Tagalog2005Bible) { m_Tagalog2005Bible = Tagalog2005Bible; }
    public void SetTagalog2012Bible(string Tagalog2012Bible) { m_Tagalog2012Bible = Tagalog2012Bible; }
    public void SetTagalog2015Bible(string Tagalog2015Bible) { m_Tagalog2015Bible = Tagalog2015Bible; }
    public void SetTagalogBible(string TagalogBible) { m_TagalogBible = TagalogBible; }
    public void SetTagalogRevised2005Bible(string TagalogRevised2005Bible) { m_TagalogRevised2005Bible = TagalogRevised2005Bible; }
    public void SetTagalogTLBABible(string TagalogTLBABible) { m_TagalogTLBABible = TagalogTLBABible; }
    public void SetTajik1992Bible(string Tajik1992Bible) { m_Tajik1992Bible = Tajik1992Bible; }
    public void SetTajikKMOBible(string TajikKMOBible) { m_TajikKMOBible = TajikKMOBible; }
    public void SetTajikNTBible(string TajikNTBible) { m_TajikNTBible = TajikNTBible; }
    public void SetTamasheqBible(string TamasheqBible) { m_TamasheqBible = TamasheqBible; }
    public void SetTamil2017Bible(string Tamil2017Bible) { m_Tamil2017Bible = Tamil2017Bible; }
    public void SetTamilBible(string TamilBible) { m_TamilBible = TamilBible; }
    public void SetTamilIRVBible(string TamilIRVBible) { m_TamilIRVBible = TamilIRVBible; }
    public void SetTamilRomanisedBible(string TamilRomanisedBible) { m_TamilRomanisedBible = TamilRomanisedBible; }
    public void SetTamilTCVBible(string TamilTCVBible) { m_TamilTCVBible = TamilTCVBible; }
    public void SetTamilTRVBible(string TamilTRVBible) { m_TamilTRVBible = TamilTRVBible; }
    public void SetTamilWBTCBible(string TamilWBTCBible) { m_TamilWBTCBible = TamilWBTCBible; }
    public void SetTarifitBible(string TarifitBible) { m_TarifitBible = TarifitBible; }
    public void SetTashelhaytMoroccoBible(string TashelhaytMoroccoBible) { m_TashelhaytMoroccoBible = TashelhaytMoroccoBible; }
    public void SetTatar2001Bible(string Tatar2001Bible) { m_Tatar2001Bible = Tatar2001Bible; }
    public void SetTatar2015Bible(string Tatar2015Bible) { m_Tatar2015Bible = Tatar2015Bible; }
    public void SetTatar2025Bible(string Tatar2025Bible) { m_Tatar2025Bible = Tatar2025Bible; }
    public void SetTatarRBBLBible(string TatarRBBLBible) { m_TatarRBBLBible = TatarRBBLBible; }
    public void SetTelugu2016Bible(string Telugu2016Bible) { m_Telugu2016Bible = Telugu2016Bible; }
    public void SetTelugu2019Bible(string Telugu2019Bible) { m_Telugu2019Bible = Telugu2019Bible; }
    public void SetTeluguBible(string TeluguBible) { m_TeluguBible = TeluguBible; }
    public void SetTeluguTCVBible(string TeluguTCVBible) { m_TeluguTCVBible = TeluguTCVBible; }
    public void SetTeluguWBTCBible(string TeluguWBTCBible) { m_TeluguWBTCBible = TeluguWBTCBible; }
    public void SetTeso2020Bible(string Teso2020Bible) { m_Teso2020Bible = Teso2020Bible; }
    public void SetTesoBible(string TesoBible) { m_TesoBible = TesoBible; }
    public void SetThadoBible(string ThadoBible) { m_ThadoBible = ThadoBible; }
    public void SetThai1940Bible(string Thai1940Bible) { m_Thai1940Bible = Thai1940Bible; }
    public void SetThai1971Bible(string Thai1971Bible) { m_Thai1971Bible = Thai1971Bible; }
    public void SetThaiBible(string ThaiBible) { m_ThaiBible = ThaiBible; }
    public void SetThaiERVBible(string ThaiERVBible) { m_ThaiERVBible = ThaiERVBible; }
    public void SetThaiKJVBible(string ThaiKJVBible) { m_ThaiKJVBible = ThaiKJVBible; }
    public void SetThaiNTVBible(string ThaiNTVBible) { m_ThaiNTVBible = ThaiNTVBible; }
    public void SetThaiTCVBible(string ThaiTCVBible) { m_ThaiTCVBible = ThaiTCVBible; }
    public void SetThaiTHSBible(string ThaiTHSBible) { m_ThaiTHSBible = ThaiTHSBible; }
    public void SetThaiTNCVBible(string ThaiTNCVBible) { m_ThaiTNCVBible = ThaiTNCVBible; }
    public void SetTibetianBible(string TibetianBible) { m_TibetianBible = TibetianBible; }
    public void SetTibetianCBTBible(string TibetianCBTBible) { m_TibetianCBTBible = TibetianCBTBible; }
    public void SetTivBible(string TivBible) { m_TivBible = TivBible; }
    public void SetTshiluba1996Bible(string Tshiluba1996Bible) { m_Tshiluba1996Bible = Tshiluba1996Bible; }
    public void SetTshiluba2003Bible(string Tshiluba2003Bible) { m_Tshiluba2003Bible = Tshiluba2003Bible; }
    public void SetTshivendaBible(string TshivendaBible) { m_TshivendaBible = TshivendaBible; }
    public void SetTsonga1989Bible(string Tsonga1989Bible) { m_Tsonga1989Bible = Tsonga1989Bible; }
    public void SetTsonga2014Bible(string Tsonga2014Bible) { m_Tsonga2014Bible = Tsonga2014Bible; }
    public void SetTsonga2024Bible(string Tsonga2024Bible) { m_Tsonga2024Bible = Tsonga2024Bible; }
    public void SetTsongaBible(string TsongaBible) { m_TsongaBible = TsongaBible; }
    public void SetTswana1890Bible(string Tswana1890Bible) { m_Tswana1890Bible = Tswana1890Bible; }
    public void SetTswana1970Bible(string Tswana1970Bible) { m_Tswana1970Bible = Tswana1970Bible; }
    public void SetTswana1993Bible(string Tswana1993Bible) { m_Tswana1993Bible = Tswana1993Bible; }
    public void SetTswana2024Bible(string Tswana2024Bible) { m_Tswana2024Bible = Tswana2024Bible; }
    public void SetTswanaBible(string TswanaBible) { m_TswanaBible = TswanaBible; }
    public void SetTuluBible(string TuluBible) { m_TuluBible = TuluBible; }
    public void SetTurkanaBible(string TurkanaBible) { m_TurkanaBible = TurkanaBible; }
    public void SetTurkishBible(string TurkishBible) { m_TurkishBible = TurkishBible; }
    public void SetTurkishHADIBible(string TurkishHADIBible) { m_TurkishHADIBible = TurkishHADIBible; }
    public void SetTurkishKKDEUBible(string TurkishKKDEUBible) { m_TurkishKKDEUBible = TurkishKKDEUBible; }
    public void SetTurkishKMEYABible(string TurkishKMEYABible) { m_TurkishKMEYABible = TurkishKMEYABible; }
    public void SetTurkishNTBBible(string TurkishNTBBible) { m_TurkishNTBBible = TurkishNTBBible; }
    public void SetTurkishTKKBible(string TurkishTKKBible) { m_TurkishTKKBible = TurkishTKKBible; }
    public void SetTurkishTTTBible(string TurkishTTTBible) { m_TurkishTTTBible = TurkishTTTBible; }
    public void SetTurkishYTCBible(string TurkishYTCBible) { m_TurkishYTCBible = TurkishYTCBible; }
    public void SetTurkmen2016Bible(string Turkmen2016Bible) { m_Turkmen2016Bible = Turkmen2016Bible; }
    public void SetTurkmenCyrillic2002Bible(string TurkmenCyrillic2002Bible) { m_TurkmenCyrillic2002Bible = TurkmenCyrillic2002Bible; }
    public void SetTurkmenLatin2002Bible(string TurkmenLatin2002Bible) { m_TurkmenLatin2002Bible = TurkmenLatin2002Bible; }
    public void SetTurkmenLatin2017Bible(string TurkmenLatin2017Bible) { m_TurkmenLatin2017Bible = TurkmenLatin2017Bible; }
    public void SetTwiAkuapemBible(string TwiAkuapemBible) { m_TwiAkuapemBible = TwiAkuapemBible; }
    public void SetTwiAsanteBible(string TwiAsanteBible) { m_TwiAsanteBible = TwiAsanteBible; }
    public void SetTwiDCBible(string TwiDCBible) { m_TwiDCBible = TwiDCBible; }
    public void SetTwiKronkronBible(string TwiKronkronBible) { m_TwiKronkronBible = TwiKronkronBible; }
    public void SetTwiRevisedBible(string TwiRevisedBible) { m_TwiRevisedBible = TwiRevisedBible; }
    public void SetUkrainian1903Bible(string Ukrainian1903Bible) { m_Ukrainian1903Bible = Ukrainian1903Bible; }
    public void SetUkrainian1905Bible(string Ukrainian1905Bible) { m_Ukrainian1905Bible = Ukrainian1905Bible; }
    public void SetUkrainian2004Bible(string Ukrainian2004Bible) { m_Ukrainian2004Bible = Ukrainian2004Bible; }
    public void SetUkrainian2006Bible(string Ukrainian2006Bible) { m_Ukrainian2006Bible = Ukrainian2006Bible; }
    public void SetUkrainian2011Bible(string Ukrainian2011Bible) { m_Ukrainian2011Bible = Ukrainian2011Bible; }
    public void SetUkrainian2021Bible(string Ukrainian2021Bible) { m_Ukrainian2021Bible = Ukrainian2021Bible; }
    public void SetUkrainian2022Bible(string Ukrainian2022Bible) { m_Ukrainian2022Bible = Ukrainian2022Bible; }
    public void SetUkrainianBible(string UkrainianBible) { m_UkrainianBible = UkrainianBible; }
    public void SetUkrainianHOMBible(string UkrainianHOMBible) { m_UkrainianHOMBible = UkrainianHOMBible; }
    public void SetUkrainianTUBBible(string UkrainianTUBBible) { m_UkrainianTUBBible = UkrainianTUBBible; }
    public void SetUkrainianUKDERBible(string UkrainianUKDERBible) { m_UkrainianUKDERBible = UkrainianUKDERBible; }
    public void SetUkrainianUMTBible(string UkrainianUMTBible) { m_UkrainianUMTBible = UkrainianUMTBible; }
    public void SetUmbunduBible(string UmbunduBible) { m_UmbunduBible = UmbunduBible; }
    public void SetUrdu2017Bible(string Urdu2017Bible) { m_Urdu2017Bible = Urdu2017Bible; }
    public void SetUrduBible(string UrduBible) { m_UrduBible = UrduBible; }
    public void SetUrduDGVBible(string UrduDGVBible) { m_UrduDGVBible = UrduDGVBible; }
    public void SetUrduGVRBible(string UrduGVRBible) { m_UrduGVRBible = UrduGVRBible; }
    public void SetUrduIRVURDBible(string UrduIRVURDBible) { m_UrduIRVURDBible = UrduIRVURDBible; }
    public void SetUrduUCVBible(string UrduUCVBible) { m_UrduUCVBible = UrduUCVBible; }
    public void SetUrduUCVDBible(string UrduUCVDBible) { m_UrduUCVDBible = UrduUCVDBible; }
    public void SetUrduUGVBible(string UrduUGVBible) { m_UrduUGVBible = UrduUGVBible; }
    public void SetUrduURDBible(string UrduURDBible) { m_UrduURDBible = UrduURDBible; }
    public void SetUrduURDGVHBible(string UrduURDGVHBible) { m_UrduURDGVHBible = UrduURDGVHBible; }
    public void SetUrduURDR55Bible(string UrduURDR55Bible) { m_UrduURDR55Bible = UrduURDR55Bible; }
    public void SetUyghurArabicBible(string UyghurArabicBible) { m_UyghurArabicBible = UyghurArabicBible; }
    public void SetUyghurCyrillicBible(string UyghurCyrillicBible) { m_UyghurCyrillicBible = UyghurCyrillicBible; }
    public void SetUyghurLatinBible(string UyghurLatinBible) { m_UyghurLatinBible = UyghurLatinBible; }
    public void SetUzbekUZBBible(string UzbekUZBBible) { m_UzbekUZBBible = UzbekUZBBible; }
    public void SetUzbekUZCBible(string UzbekUZCBible) { m_UzbekUZCBible = UzbekUZCBible; }
    public void SetUzbekUZLBCBible(string UzbekUZLBCBible) { m_UzbekUZLBCBible = UzbekUZLBCBible; }
    public void SetVietnamese1994Bible(string Vietnamese1994Bible) { m_Vietnamese1994Bible = Vietnamese1994Bible; }
    public void SetVietnamese2011Bible(string Vietnamese2011Bible) { m_Vietnamese2011Bible = Vietnamese2011Bible; }
    public void SetVietnamese2015Bible(string Vietnamese2015Bible) { m_Vietnamese2015Bible = Vietnamese2015Bible; }
    public void SetVietnameseBible(string VietnameseBible) { m_VietnameseBible = VietnameseBible; }
    public void SetVietnameseERVBible(string VietnameseERVBible) { m_VietnameseERVBible = VietnameseERVBible; }
    public void SetVietnameseNVBBible(string VietnameseNVBBible) { m_VietnameseNVBBible = VietnameseNVBBible; }
    public void SetVietnameseVIEBible(string VietnameseVIEBible) { m_VietnameseVIEBible = VietnameseVIEBible; }
    public void SetWarayBible(string WarayBible) { m_WarayBible = WarayBible; }
    public void SetWelsh1894Bible(string Welsh1894Bible) { m_Welsh1894Bible = Welsh1894Bible; }
    public void SetWelsh1945Bible(string Welsh1945Bible) { m_Welsh1945Bible = Welsh1945Bible; }
    public void SetWelsh2015Bible(string Welsh2015Bible) { m_Welsh2015Bible = Welsh2015Bible; }
    public void SetWelshBible(string WelshBible) { m_WelshBible = WelshBible; }
    public void SetWelshBMWBible(string WelshBMWBible) { m_WelshBMWBible = WelshBMWBible; }
    public void SetWelshCTEBible(string WelshCTEBible) { m_WelshCTEBible = WelshCTEBible; }
    public void SetWelshSBYBible(string WelshSBYBible) { m_WelshSBYBible = WelshSBYBible; }
    public void SetWolayttaBible(string WolayttaBible) { m_WolayttaBible = WolayttaBible; }
    public void SetWolofBible(string WolofBible) { m_WolofBible = WolofBible; }
    public void SetWolofKYGBible(string WolofKYGBible) { m_WolofKYGBible = WolofKYGBible; }
    public void SetXhosa1920Bible(string Xhosa1920Bible) { m_Xhosa1920Bible = Xhosa1920Bible; }
    public void SetXhosa1996Bible(string Xhosa1996Bible) { m_Xhosa1996Bible = Xhosa1996Bible; }
    public void SetXhosa2022Bible(string Xhosa2022Bible) { m_Xhosa2022Bible = Xhosa2022Bible; }
    public void SetXhosaBible(string XhosaBible) { m_XhosaBible = XhosaBible; }
    public void SetYoruba2010Bible(string Yoruba2010Bible) { m_Yoruba2010Bible = Yoruba2010Bible; }
    public void SetYoruba2014Bible(string Yoruba2014Bible) { m_Yoruba2014Bible = Yoruba2014Bible; }
    public void SetYorubaBible(string YorubaBible) { m_YorubaBible = YorubaBible; }
    public void SetZandeBible(string ZandeBible) { m_ZandeBible = ZandeBible; }
    public void SetZarmaBible(string ZarmaBible) { m_ZarmaBible = ZarmaBible; }
    public void SetZulu2020Bible(string Zulu2020Bible) { m_Zulu2020Bible = Zulu2020Bible; }
    public void SetZulu2023Bible(string Zulu2023Bible) { m_Zulu2023Bible = Zulu2023Bible; }
    public void SetZuluBible(string ZuluBible) { m_ZuluBible = ZuluBible; }
}

public class PlayerInfo
{
    public string m_ID { get; private set; }
    public string m_Content { get; private set; }
    public string m_Address { get; private set; }
    public string m_ETC { get; private set; }

    public void SetID(string ID) { m_ID = ID; }
    public void SetContent(string Content) { m_Content = Content; }
    public void SetAddress(string Address) { m_Address = Address; }
    public void SetETC(string ETC) { m_ETC = ETC; }
}

public class TestimonyInfo
{
    public string m_ID { get; private set; }
    public string m_Content { get; private set; }
    public string m_Address { get; private set; }
    public string m_Confirm { get; private set; }
    public string m_ETC { get; private set; }

    public void SetID(string ID) { m_ID = ID; }
    public void SetContent(string Content) { m_Content = Content; }
    public void SetAddress(string Address) { m_Address = Address; }
    public void SetConfirm(string Confirm) { m_Confirm = Confirm; }
    public void SetETC(string ETC) { m_ETC = ETC; }
}

public class WiseSayingInfo
{
    public int m_ID { get; private set; }
    public string m_Korean { get; private set; }
    public string m_English { get; private set; }

    public void SetID(int ID) { m_ID = ID; }
    public void SetKorean(string Korean) { m_Korean = Korean; }
    public void SetEnglish(string English) { m_English = English; }
}

public class BibleEachTable
{
    private static Dictionary<string, BibleEachInfo> Table = new Dictionary<string, BibleEachInfo>();

    public static Dictionary<string, BibleEachInfo> GetAll()
    {
        return Table;
    }

    public static BibleEachInfo GetByKey(string key)
    {
        BibleEachInfo value;

        if (Table.TryGetValue(key, out value))
            return value;

        return null;
    }

    public static BibleEachInfo GetByIndex(int index)
    {
        return Table.Values.ElementAt(index);
    }

    public static List<BibleEachInfo> GetAllList()
    {
        return Table.Values.ToList();
    }

    public BibleEachTable()
    {
        InitTable();
    }

    private void InitTable()
    {
        TextAsset textAsset = Resources.Load("Tables/BibleEach") as TextAsset;
        MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
        BinaryReader binaryReader = new BinaryReader(memoryStream);

        int tableCount = binaryReader.ReadInt32();

        for( int i = 0; i < tableCount; ++i)
        {
            string key = binaryReader.ReadString();

            BibleEachInfo info = new BibleEachInfo();
            info.SetID(binaryReader.ReadString());
            info.SetContent(binaryReader.ReadString());
            info.SetNation(binaryReader.ReadString());
            info.SetBible(binaryReader.ReadInt32());
            info.SetNationType(binaryReader.ReadString());
            info.SetDelayMiddle(binaryReader.ReadSingle());
            info.SetDelayEnd(binaryReader.ReadSingle());

            Table.Add(key, info);
        }
    }
}

public class BibleNationTable
{
    private static Dictionary<string, BibleNationInfo> Table = new Dictionary<string, BibleNationInfo>();

    public static Dictionary<string, BibleNationInfo> GetAll()
    {
        return Table;
    }

    public static BibleNationInfo GetByKey(string key)
    {
        BibleNationInfo value;

        if (Table.TryGetValue(key, out value))
            return value;

        return null;
    }

    public static BibleNationInfo GetByIndex(int index)
    {
        return Table.Values.ElementAt(index);
    }

    public static List<BibleNationInfo> GetAllList()
    {
        return Table.Values.ToList();
    }

    public BibleNationTable()
    {
        InitTable();
    }

    private void InitTable()
    {
        TextAsset textAsset = Resources.Load("Tables/BibleNation") as TextAsset;
        MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
        BinaryReader binaryReader = new BinaryReader(memoryStream);

        int tableCount = binaryReader.ReadInt32();

        for( int i = 0; i < tableCount; ++i)
        {
            string key = binaryReader.ReadString();

            BibleNationInfo info = new BibleNationInfo();
            info.SetNation(binaryReader.ReadString());
            info.SetBible(binaryReader.ReadInt32());
            info.SetNationType(binaryReader.ReadString());
            info.SetDelayMiddle(binaryReader.ReadSingle());
            info.SetDelayEnd(binaryReader.ReadSingle());
            info.SetOtherDelayMiddle(binaryReader.ReadSingle());
            info.SetOtherDelayEnd(binaryReader.ReadSingle());

            Table.Add(key, info);
        }
    }
}

public class BibleTypeTable
{
    private static Dictionary<string, BibleTypeInfo> Table = new Dictionary<string, BibleTypeInfo>();

    public static Dictionary<string, BibleTypeInfo> GetAll()
    {
        return Table;
    }

    public static BibleTypeInfo GetByKey(string key)
    {
        BibleTypeInfo value;

        if (Table.TryGetValue(key, out value))
            return value;

        return null;
    }

    public static BibleTypeInfo GetByIndex(int index)
    {
        return Table.Values.ElementAt(index);
    }

    public static List<BibleTypeInfo> GetAllList()
    {
        return Table.Values.ToList();
    }

    public BibleTypeTable()
    {
        InitTable();
    }

    private void InitTable()
    {
        TextAsset textAsset = Resources.Load("Tables/BibleType") as TextAsset;
        MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
        BinaryReader binaryReader = new BinaryReader(memoryStream);

        int tableCount = binaryReader.ReadInt32();

        for( int i = 0; i < tableCount; ++i)
        {
            string key = binaryReader.ReadString();

            BibleTypeInfo info = new BibleTypeInfo();
            info.SetID(binaryReader.ReadString());
            info.SetPath(binaryReader.ReadString());
            info.SetBibleName(binaryReader.ReadString());
            info.SetBibleContent(binaryReader.ReadString());

            Table.Add(key, info);
        }
    }
}

public class BibleWiseTable
{
    private static Dictionary<int, BibleWiseInfo> Table = new Dictionary<int, BibleWiseInfo>();

    public static Dictionary<int, BibleWiseInfo> GetAll()
    {
        return Table;
    }

    public static BibleWiseInfo GetByKey(int key)
    {
        BibleWiseInfo value;

        if (Table.TryGetValue(key, out value))
            return value;

        return null;
    }

    public static BibleWiseInfo GetByIndex(int index)
    {
        return Table.Values.ElementAt(index);
    }

    public static List<BibleWiseInfo> GetAllList()
    {
        return Table.Values.ToList();
    }

    public BibleWiseTable()
    {
        InitTable();
    }

    private void InitTable()
    {
        TextAsset textAsset = Resources.Load("Tables/BibleWise") as TextAsset;
        MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
        BinaryReader binaryReader = new BinaryReader(memoryStream);

        int tableCount = binaryReader.ReadInt32();

        for( int i = 0; i < tableCount; ++i)
        {
            int key = binaryReader.ReadInt32();

            BibleWiseInfo info = new BibleWiseInfo();
            info.SetID(binaryReader.ReadInt32());
            info.SetBibleMessage(binaryReader.ReadString());

            Table.Add(key, info);
        }
    }
}

public class CustomizeTable
{
    private static Dictionary<int, CustomizeInfo> Table = new Dictionary<int, CustomizeInfo>();

    public static Dictionary<int, CustomizeInfo> GetAll()
    {
        return Table;
    }

    public static CustomizeInfo GetByKey(int key)
    {
        CustomizeInfo value;

        if (Table.TryGetValue(key, out value))
            return value;

        return null;
    }

    public static CustomizeInfo GetByIndex(int index)
    {
        return Table.Values.ElementAt(index);
    }

    public static List<CustomizeInfo> GetAllList()
    {
        return Table.Values.ToList();
    }

    public CustomizeTable()
    {
        InitTable();
    }

    private void InitTable()
    {
        TextAsset textAsset = Resources.Load("Tables/Customize") as TextAsset;
        MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
        BinaryReader binaryReader = new BinaryReader(memoryStream);

        int tableCount = binaryReader.ReadInt32();

        for( int i = 0; i < tableCount; ++i)
        {
            int key = binaryReader.ReadInt32();

            CustomizeInfo info = new CustomizeInfo();
            info.SetID(binaryReader.ReadInt32());
            info.SetKorean(binaryReader.ReadString());
            info.SetEnglish(binaryReader.ReadString());

            Table.Add(key, info);
        }
    }
}

public class NewTestamentTable
{
    private static Dictionary<int, NewTestamentInfo> Table = new Dictionary<int, NewTestamentInfo>();

    public static Dictionary<int, NewTestamentInfo> GetAll()
    {
        return Table;
    }

    public static NewTestamentInfo GetByKey(int key)
    {
        NewTestamentInfo value;

        if (Table.TryGetValue(key, out value))
            return value;

        return null;
    }

    public static NewTestamentInfo GetByIndex(int index)
    {
        return Table.Values.ElementAt(index);
    }

    public static List<NewTestamentInfo> GetAllList()
    {
        return Table.Values.ToList();
    }

    public NewTestamentTable()
    {
        InitTable();
    }

    private void InitTable()
    {
        TextAsset textAsset = Resources.Load("Tables/NewTestament") as TextAsset;
        MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
        BinaryReader binaryReader = new BinaryReader(memoryStream);

        int tableCount = binaryReader.ReadInt32();

        for( int i = 0; i < tableCount; ++i)
        {
            int key = binaryReader.ReadInt32();

            NewTestamentInfo info = new NewTestamentInfo();
            info.SetID(binaryReader.ReadInt32());
            info.SetEnglish(binaryReader.ReadString());
            info.SetKorean(binaryReader.ReadString());
            info.SetCount(binaryReader.ReadInt32());
            info.SetEnglishTarget(binaryReader.ReadString());
            info.SetNIV(binaryReader.ReadString());
            info.SetKoreanTarget(binaryReader.ReadString());
            info.SetSource(binaryReader.ReadString());
            info.SetEasyBible(binaryReader.ReadString());
            info.SetRevisedHangul(binaryReader.ReadString());
            info.SetRevisedRevision(binaryReader.ReadString());
            info.SetJointTranslation(binaryReader.ReadString());
            info.SetNewStandardTranslation(binaryReader.ReadString());
            info.SetKoreanBible(binaryReader.ReadString());
            info.SetSourceEnglish(binaryReader.ReadString());
            info.SetKJV(binaryReader.ReadString());
            info.SetNewKJV(binaryReader.ReadString());
            info.SetESV(binaryReader.ReadString());
            info.SetNewRSV(binaryReader.ReadString());
            info.SetNASB(binaryReader.ReadString());
            info.Setafri(binaryReader.ReadString());
            info.Setalbanian(binaryReader.ReadString());
            info.Setchinese_union_simp(binaryReader.ReadString());
            info.Setchinese_union_trad(binaryReader.ReadString());
            info.Setckjv_sds(binaryReader.ReadString());
            info.Setckjv_sdt(binaryReader.ReadString());
            info.Setbkr(binaryReader.ReadString());
            info.Setstve(binaryReader.ReadString());
            info.Setfinn(binaryReader.ReadString());
            info.Setepee(binaryReader.ReadString());
            info.Setmartin(binaryReader.ReadString());
            info.Setoster(binaryReader.ReadString());
            info.Setsegond_1910(binaryReader.ReadString());
            info.Setelberfelder_1871(binaryReader.ReadString());
            info.Setelberfelder_1905(binaryReader.ReadString());
            info.Setluther(binaryReader.ReadString());
            info.Setluther_1912(binaryReader.ReadString());
            info.Setschlachter(binaryReader.ReadString());
            info.Setwlc(binaryReader.ReadString());
            info.Setirv(binaryReader.ReadString());
            info.Setkaroli(binaryReader.ReadString());
            info.Setindo_tb(binaryReader.ReadString());
            info.Setindo_tm(binaryReader.ReadString());
            info.Setdiodati(binaryReader.ReadString());
            info.Setbungo(binaryReader.ReadString());
            info.Setkougo(binaryReader.ReadString());
            info.Setmaori(binaryReader.ReadString());
            info.Setopt(binaryReader.ReadString());
            info.Setpol_nbg(binaryReader.ReadString());
            info.Setpol_ubg(binaryReader.ReadString());
            info.Setpolbg(binaryReader.ReadString());
            info.Setalmeida_ra(binaryReader.ReadString());
            info.Setalmeida_rc(binaryReader.ReadString());
            info.Setblivre(binaryReader.ReadString());
            info.Setfidela(binaryReader.ReadString());
            info.Setsynodal(binaryReader.ReadString());
            info.Setrv_1909(binaryReader.ReadString());
            info.Setrvg(binaryReader.ReadString());
            info.Setrvg_2004(binaryReader.ReadString());
            info.Setsagradas(binaryReader.ReadString());
            info.Settagab(binaryReader.ReadString());
            info.Setthaikjv(binaryReader.ReadString());
            info.Setturkish(binaryReader.ReadString());
            info.Setcadman(binaryReader.ReadString());
            info.SetPortuguese(binaryReader.ReadString());
            info.SetGerman(binaryReader.ReadString());
            info.SetJapanese(binaryReader.ReadString());
            info.SetChinese(binaryReader.ReadString());
            info.SetRomanian(binaryReader.ReadString());
            info.SetFrench(binaryReader.ReadString());
            info.SetSpanish(binaryReader.ReadString());
            info.SetItalian(binaryReader.ReadString());
            info.SetHungarian(binaryReader.ReadString());
            info.SetRussian(binaryReader.ReadString());
            info.SetHindi(binaryReader.ReadString());
            info.SetAcehBible(binaryReader.ReadString());
            info.SetAdilabadGondiBible(binaryReader.ReadString());
            info.SetAfrikaans1983Bible(binaryReader.ReadString());
            info.SetAfrikaans2020Bible(binaryReader.ReadString());
            info.SetAfrikaans2023Bible(binaryReader.ReadString());
            info.SetAfrikaansABABible(binaryReader.ReadString());
            info.SetAfrikaansBible(binaryReader.ReadString());
            info.SetAfrikaansDBBible(binaryReader.ReadString());
            info.SetAfrikaansNLVBible(binaryReader.ReadString());
            info.SetAhiraniBible(binaryReader.ReadString());
            info.SetAlbanian1872Bible(binaryReader.ReadString());
            info.SetAlbanian1879Bible(binaryReader.ReadString());
            info.SetAlbanian2018Bible(binaryReader.ReadString());
            info.SetAlbanianBible(binaryReader.ReadString());
            info.SetAmharic2000Bible(binaryReader.ReadString());
            info.SetAmharicBible(binaryReader.ReadString());
            info.SetAmharicCatholicBible(binaryReader.ReadString());
            info.SetAmharicDawroBible(binaryReader.ReadString());
            info.SetAmharicDawroDFBEBible(binaryReader.ReadString());
            info.SetAmharicDawroDFBLVLBible(binaryReader.ReadString());
            info.SetAmharicDawroDWRNTBible(binaryReader.ReadString());
            info.SetAmharicDawroWWIBible(binaryReader.ReadString());
            info.SetAmharicGamo2017Bible(binaryReader.ReadString());
            info.SetAmharicGamoBible(binaryReader.ReadString());
            info.SetAmharicGamoGMBible(binaryReader.ReadString());
            info.SetAmharicGamoWordBible(binaryReader.ReadString());
            info.SetAmharicGofaBible(binaryReader.ReadString());
            info.SetAmharicGofaGFBEVFBible(binaryReader.ReadString());
            info.SetAmharicGofaGFBLVFBible(binaryReader.ReadString());
            info.SetAmharicGofaRNTBible(binaryReader.ReadString());
            info.SetAmharicGofaWWIBible(binaryReader.ReadString());
            info.SetAmharicNASVBible(binaryReader.ReadString());
            info.SetAmharicNSTBible(binaryReader.ReadString());
            info.SetAmharicTigrinya15Bible(binaryReader.ReadString());
            info.SetAmharicTigrinya2024Bible(binaryReader.ReadString());
            info.SetAmharicTigrinyaBible(binaryReader.ReadString());
            info.SetArabic1978Bible(binaryReader.ReadString());
            info.SetArabic2016Bible(binaryReader.ReadString());
            info.SetArabic2018Bible(binaryReader.ReadString());
            info.SetArabic2023Bible(binaryReader.ReadString());
            info.SetArabicAlgeriaBible(binaryReader.ReadString());
            info.SetArabicAPDBible(binaryReader.ReadString());
            info.SetArabicAVDBible(binaryReader.ReadString());
            info.SetArabicAVDDVBible(binaryReader.ReadString());
            info.SetArabicBible(binaryReader.ReadString());
            info.SetArabicERVBible(binaryReader.ReadString());
            info.SetArabicGNABible(binaryReader.ReadString());
            info.SetArabicGOVBible(binaryReader.ReadString());
            info.SetArabicLABible(binaryReader.ReadString());
            info.SetArabicLebaneseBible(binaryReader.ReadString());
            info.SetArabicMorocco2023Bible(binaryReader.ReadString());
            info.SetArabicMoroccoBible(binaryReader.ReadString());
            info.SetArabicSABBible(binaryReader.ReadString());
            info.SetArabicSABible(binaryReader.ReadString());
            info.SetArabicSVDBible(binaryReader.ReadString());
            info.SetArabicTMABible(binaryReader.ReadString());
            info.SetArabicTU2022Bible(binaryReader.ReadString());
            info.SetArabicTunisianBible(binaryReader.ReadString());
            info.SetAramaicBible(binaryReader.ReadString());
            info.SetArmenian1853Bible(binaryReader.ReadString());
            info.SetArmenian2017Bible(binaryReader.ReadString());
            info.SetArmenian2018Bible(binaryReader.ReadString());
            info.SetArmenian2019Bible(binaryReader.ReadString());
            info.SetArmenianAraratBible(binaryReader.ReadString());
            info.SetArmenianBible(binaryReader.ReadString());
            info.SetArmenianEasternBible(binaryReader.ReadString());
            info.SetArmenianNEABible(binaryReader.ReadString());
            info.SetAssameseBible(binaryReader.ReadString());
            info.SetAvarBible(binaryReader.ReadString());
            info.SetAwadhiBible(binaryReader.ReadString());
            info.SetAymara1986Bible(binaryReader.ReadString());
            info.SetAymara1997Bible(binaryReader.ReadString());
            info.SetAymaraBible(binaryReader.ReadString());
            info.SetAzerbaijan2013Bible(binaryReader.ReadString());
            info.SetAzerbaijanBible(binaryReader.ReadString());
            info.SetAzerbaijanSouthBible(binaryReader.ReadString());
            info.SetBagriBible(binaryReader.ReadString());
            info.SetBalineseBible(binaryReader.ReadString());
            info.SetBalochiArabicBible(binaryReader.ReadString());
            info.SetBalochiBible(binaryReader.ReadString());
            info.SetBalochiSoutherenBible(binaryReader.ReadString());
            info.SetBalochiSoutherenLatinBible(binaryReader.ReadString());
            info.SetBaoule1974Bible(binaryReader.ReadString());
            info.SetBaoule1998Bible(binaryReader.ReadString());
            info.SetBaouleBible(binaryReader.ReadString());
            info.SetBashkir2023Bible(binaryReader.ReadString());
            info.SetBashkirBible(binaryReader.ReadString());
            info.SetBasqueBible(binaryReader.ReadString());
            info.SetBasque2008Bible(binaryReader.ReadString());
            info.SetBavarianBible(binaryReader.ReadString());
            info.SetBelarusian2017Bible(binaryReader.ReadString());
            info.SetBelarusianBible(binaryReader.ReadString());
            info.SetBelarusianBokunBible(binaryReader.ReadString());
            info.SetBelarusianCHNTBible(binaryReader.ReadString());
            info.SetBelarusianNTJSBible(binaryReader.ReadString());
            info.SetBembaBible(binaryReader.ReadString());
            info.SetBengali2017Bible(binaryReader.ReadString());
            info.SetBengali2023Bible(binaryReader.ReadString());
            info.SetBengaliBACIBBible(binaryReader.ReadString());
            info.SetBengaliBCVBible(binaryReader.ReadString());
            info.SetBengaliBible(binaryReader.ReadString());
            info.SetBengaliBSIBible(binaryReader.ReadString());
            info.SetBengaliCLBSIBible(binaryReader.ReadString());
            info.SetBengaliERVBible(binaryReader.ReadString());
            info.SetBengaliIRVBENBible(binaryReader.ReadString());
            info.SetBengaliMBCLBible(binaryReader.ReadString());
            info.SetBengaliSBCLBible(binaryReader.ReadString());
            info.SetBerberBible(binaryReader.ReadString());
            info.SetBhilaliBible(binaryReader.ReadString());
            info.SetBodoBible(binaryReader.ReadString());
            info.SetBodoNTBPL20Bible(binaryReader.ReadString());
            info.SetBosnianBible(binaryReader.ReadString());
            info.SetBrajBible(binaryReader.ReadString());
            info.SetBugisBible(binaryReader.ReadString());
            info.SetBulgarian2015Bible(binaryReader.ReadString());
            info.SetBulgarianBible(binaryReader.ReadString());
            info.SetBulgarianBOBBible(binaryReader.ReadString());
            info.SetBulgarianBPBBible(binaryReader.ReadString());
            info.SetBulgarianCBTBible(binaryReader.ReadString());
            info.SetBulgarianSPBBible(binaryReader.ReadString());
            info.SetBulgarianTZABible(binaryReader.ReadString());
            info.SetBulgarianVerensBible(binaryReader.ReadString());
            info.SetBundeliBible(binaryReader.ReadString());
            info.SetBurmese1928Bible(binaryReader.ReadString());
            info.SetBurmese2021Bible(binaryReader.ReadString());
            info.SetBurmeseBCLBible(binaryReader.ReadString());
            info.SetBurmeseBible(binaryReader.ReadString());
            info.SetBurmeseJBZVBible(binaryReader.ReadString());
            info.SetBurmeseMCLZVBible(binaryReader.ReadString());
            info.SetBurmeseMSBUBible(binaryReader.ReadString());
            info.SetBurmeseMSBZBible(binaryReader.ReadString());
            info.SetCatalanBCIBible(binaryReader.ReadString());
            info.SetCatalanBECBible(binaryReader.ReadString());
            info.SetCebuano1999Bible(binaryReader.ReadString());
            info.SetCebuano2011Bible(binaryReader.ReadString());
            info.SetCebuanoAPSDBible(binaryReader.ReadString());
            info.SetCebuanoBible(binaryReader.ReadString());
            info.SetCebuanoRCPVBible(binaryReader.ReadString());
            info.SetChechenBible(binaryReader.ReadString());
            info.SetChewa1992Bible(binaryReader.ReadString());
            info.SetChewa2014Bible(binaryReader.ReadString());
            info.SetChewa2016Bible(binaryReader.ReadString());
            info.SetChewaBLYDCBible(binaryReader.ReadString());
            info.SetChhattisgarhiBible(binaryReader.ReadString());
            info.SetChibembaBible(binaryReader.ReadString());
            info.SetChin2010Bible(binaryReader.ReadString());
            info.SetChinBSIBible(binaryReader.ReadString());
            info.SetChinCSHBible(binaryReader.ReadString());
            info.SetChinDNTBible(binaryReader.ReadString());
            info.SetChinese1886Bible(binaryReader.ReadString());
            info.SetChinese1919Bible(binaryReader.ReadString());
            info.SetChinese1927Bible(binaryReader.ReadString());
            info.SetChinese1933Bible(binaryReader.ReadString());
            info.SetChinese1941Bible(binaryReader.ReadString());
            info.SetChinese1967Bible(binaryReader.ReadString());
            info.SetChineseCCBSBible(binaryReader.ReadString());
            info.SetChineseCCBTBible(binaryReader.ReadString());
            info.SetChineseCSBSBible(binaryReader.ReadString());
            info.SetChineseCSBTBible(binaryReader.ReadString());
            info.SetChineseCUNPSSBible(binaryReader.ReadString());
            info.SetChineseCUNPSTBible(binaryReader.ReadString());
            info.SetChineseNankingBible(binaryReader.ReadString());
            info.SetChinesePekingBible(binaryReader.ReadString());
            info.SetChineseRCUVSSBible(binaryReader.ReadString());
            info.SetChineseRCUVTBible(binaryReader.ReadString());
            info.SetChineseSimplifiedBible(binaryReader.ReadString());
            info.SetChineseSimplifiedNewBible(binaryReader.ReadString());
            info.SetChineseTCV2019TBible(binaryReader.ReadString());
            info.SetChineseTHV2012Bible(binaryReader.ReadString());
            info.SetChineseTraditionalBible(binaryReader.ReadString());
            info.SetChineseTraditionalERVBible(binaryReader.ReadString());
            info.SetChineseTraditionalNewBible(binaryReader.ReadString());
            info.SetChineseTTVHBible(binaryReader.ReadString());
            info.SetChineseTTVRBible(binaryReader.ReadString());
            info.SetChineseUnion2010Bible(binaryReader.ReadString());
            info.SetChineseWenli1823Bible(binaryReader.ReadString());
            info.SetChineseWenli1885Bible(binaryReader.ReadString());
            info.SetChineseWenli1897Bible(binaryReader.ReadString());
            info.SetChineseWenliBible(binaryReader.ReadString());
            info.SetChineseWenliEasyBible(binaryReader.ReadString());
            info.SetChinKNTPBible(binaryReader.ReadString());
            info.SetChinMatupi2006Bible(binaryReader.ReadString());
            info.SetChinMatupiBible(binaryReader.ReadString());
            info.SetChinSCB2Bible(binaryReader.ReadString());
            info.SetChinTB77Bible(binaryReader.ReadString());
            info.SetChinTBR17Bible(binaryReader.ReadString());
            info.SetChinTDBBible(binaryReader.ReadString());
            info.SetChinTedim2011Bible(binaryReader.ReadString());
            info.SetChinTedimBible(binaryReader.ReadString());
            info.SetChuvashBible(binaryReader.ReadString());
            info.SetChuvashRSOBible(binaryReader.ReadString());
            info.SetCopticBible(binaryReader.ReadString());
            info.SetCopticCNTVBible(binaryReader.ReadString());
            info.SetCopticSahidicBible(binaryReader.ReadString());
            info.SetCroatianBible(binaryReader.ReadString());
            info.SetCroatianBKJBible(binaryReader.ReadString());
            info.SetCroatianCNTBible(binaryReader.ReadString());
            info.SetCroatianGKSBible(binaryReader.ReadString());
            info.SetCroatianSHPBible(binaryReader.ReadString());
            info.SetCzech1922Bible(binaryReader.ReadString());
            info.SetCzech1947Bible(binaryReader.ReadString());
            info.SetCzech1951Bible(binaryReader.ReadString());
            info.SetCzechBible(binaryReader.ReadString());
            info.SetCzechEkumenickyBible(binaryReader.ReadString());
            info.SetCzechKralichka1613Bible(binaryReader.ReadString());
            info.SetCzechKralichka1998Bible(binaryReader.ReadString());
            info.SetCzechPMPZBible(binaryReader.ReadString());
            info.SetCzechPrekladBible(binaryReader.ReadString());
            info.SetCzechSNCBible(binaryReader.ReadString());
            info.SetDagbaniBible(binaryReader.ReadString());
            info.SetDanish1819Bible(binaryReader.ReadString());
            info.SetDanish2015Bible(binaryReader.ReadString());
            info.SetDanishBible(binaryReader.ReadString());
            info.SetDanishLBBible(binaryReader.ReadString());
            info.SetDanishWIEBible(binaryReader.ReadString());
            info.SetDinka2006Bible(binaryReader.ReadString());
            info.SetDinkaBible(binaryReader.ReadString());
            info.SetDinkaLEKJOTBible(binaryReader.ReadString());
            info.SetDogriBible(binaryReader.ReadString());
            info.SetDutch1939Bible(binaryReader.ReadString());
            info.SetDutch2007Bible(binaryReader.ReadString());
            info.SetDutchBBBible(binaryReader.ReadString());
            info.SetDutchBible(binaryReader.ReadString());
            info.SetDutchEBV24Bible(binaryReader.ReadString());
            info.SetDutchFrisianBible(binaryReader.ReadString());
            info.SetDutchGBVNTBible(binaryReader.ReadString());
            info.SetDutchHSVBible(binaryReader.ReadString());
            info.SetDutchHTBBible(binaryReader.ReadString());
            info.SetDutchNBGBible(binaryReader.ReadString());
            info.SetDutchReimerBible(binaryReader.ReadString());
            info.SetDutchSVVBible(binaryReader.ReadString());
            info.SetDutchVBBible(binaryReader.ReadString());
            info.SetDyulaJulaBible(binaryReader.ReadString());
            info.SetDyulaKumaBible(binaryReader.ReadString());
            info.SetDyulaLayidukuraBible(binaryReader.ReadString());
            info.SetEdoBible(binaryReader.ReadString());
            info.SetEnglishAmplifiedBible(binaryReader.ReadString());
            info.SetEnglishAmplifiedClassicBible(binaryReader.ReadString());
            info.SetEnglishASVBible(binaryReader.ReadString());
            info.SetEnglishBereanBible(binaryReader.ReadString());
            info.SetEnglishCSBBible(binaryReader.ReadString());
            info.SetEnglishDarbyBible(binaryReader.ReadString());
            info.SetEnglishEASYBible(binaryReader.ReadString());
            info.SetEnglishERVBible(binaryReader.ReadString());
            info.SetEnglishESVBible(binaryReader.ReadString());
            info.SetEnglishGNTBible(binaryReader.ReadString());
            info.SetEnglishGWBible(binaryReader.ReadString());
            info.SetEnglishHCSBBible(binaryReader.ReadString());
            info.SetEnglishKJBible(binaryReader.ReadString());
            info.SetEnglishLSBBible(binaryReader.ReadString());
            info.SetEnglishMEVBible(binaryReader.ReadString());
            info.SetEnglishNASBBible(binaryReader.ReadString());
            info.SetEnglishNASUBible(binaryReader.ReadString());
            info.SetEnglishNETBible(binaryReader.ReadString());
            info.SetEnglishNIRVBible(binaryReader.ReadString());
            info.SetEnglishNIVBible(binaryReader.ReadString());
            info.SetEnglishNKJBible(binaryReader.ReadString());
            info.SetEnglishNLTBible(binaryReader.ReadString());
            info.SetEnglishNRSVBible(binaryReader.ReadString());
            info.SetEnglishPassionBible(binaryReader.ReadString());
            info.SetEnglishRSVBible(binaryReader.ReadString());
            info.SetEnglishTLBible(binaryReader.ReadString());
            info.SetEnglishTyndale1537Bible(binaryReader.ReadString());
            info.SetEnglishYLTBible(binaryReader.ReadString());
            info.SetEsperantoBible(binaryReader.ReadString());
            info.SetEstonian2022Bible(binaryReader.ReadString());
            info.SetEstonianBible(binaryReader.ReadString());
            info.SetEstonianEEPBible(binaryReader.ReadString());
            info.SetEwe1913Bible(binaryReader.ReadString());
            info.SetEwe2014Bible(binaryReader.ReadString());
            info.SetEwe2020Bible(binaryReader.ReadString());
            info.SetEweBible(binaryReader.ReadString());
            info.SetFinnish1776Bible(binaryReader.ReadString());
            info.SetFinnish1992Bible(binaryReader.ReadString());
            info.SetFinnishBible(binaryReader.ReadString());
            info.SetFinnishFINRKBible(binaryReader.ReadString());
            info.SetFinnishSTLKBible(binaryReader.ReadString());
            info.SetFonBible(binaryReader.ReadString());
            info.SetFrench2004Bible(binaryReader.ReadString());
            info.SetFrenchBBBBible(binaryReader.ReadString());
            info.SetFrenchBDSBible(binaryReader.ReadString());
            info.SetFrenchBFCBible(binaryReader.ReadString());
            info.SetFrenchBible(binaryReader.ReadString());
            info.SetFrenchCramponBible(binaryReader.ReadString());
            info.SetFrenchDarbyBible(binaryReader.ReadString());
            info.SetFrenchJerusalemBible(binaryReader.ReadString());
            info.SetFrenchLeonBible(binaryReader.ReadString());
            info.SetFrenchMachairaBible(binaryReader.ReadString());
            info.SetFrenchMartinBible(binaryReader.ReadString());
            info.SetFrenchNBSBible(binaryReader.ReadString());
            info.SetFrenchNEG79Bible(binaryReader.ReadString());
            info.SetFrenchNFCBible(binaryReader.ReadString());
            info.SetFrenchNVS78Bible(binaryReader.ReadString());
            info.SetFrenchOSTBible(binaryReader.ReadString());
            info.SetFrenchOstervaldBible(binaryReader.ReadString());
            info.SetFrenchPDV2017Bible(binaryReader.ReadString());
            info.SetFrenchPerretBible(binaryReader.ReadString());
            info.SetFrenchS21Bible(binaryReader.ReadString());
            info.SetFrenchVigourouxBible(binaryReader.ReadString());
            info.SetFulfulde2010Bible(binaryReader.ReadString());
            info.SetFulfuldeAadiBible(binaryReader.ReadString());
            info.SetFulfuldeAdamawaBible(binaryReader.ReadString());
            info.SetFulfuldeAlkawalBible(binaryReader.ReadString());
            info.SetFulfuldeArabicBible(binaryReader.ReadString());
            info.SetFulfuldeBeninBible(binaryReader.ReadString());
            info.SetFulfuldeBurkinaFasoBible(binaryReader.ReadString());
            info.SetFulfuldeDewtereBible(binaryReader.ReadString());
            info.SetFulfuldeWestNigerBible(binaryReader.ReadString());
            info.SetGaelic1875Bible(binaryReader.ReadString());
            info.SetGaelicABGBible(binaryReader.ReadString());
            info.SetGaelicABIGBible(binaryReader.ReadString());
            info.SetGaelicATNBible(binaryReader.ReadString());
            info.SetGalacianSEPTBible(binaryReader.ReadString());
            info.SetGarhwaliBible(binaryReader.ReadString());
            info.SetGarhwaliGBMBible(binaryReader.ReadString());
            info.SetGeorgian2002Bible(binaryReader.ReadString());
            info.SetGeorgian2012Bible(binaryReader.ReadString());
            info.SetGeorgianBible(binaryReader.ReadString());
            info.SetGerman1545Bible(binaryReader.ReadString());
            info.SetGerman2011Bible(binaryReader.ReadString());
            info.SetGermanAlbrecht1926Bible(binaryReader.ReadString());
            info.SetGermanBible(binaryReader.ReadString());
            info.SetGermanElber1905Bible(binaryReader.ReadString());
            info.SetGermanGruenewaldBible(binaryReader.ReadString());
            info.SetGermanHeuteBible(binaryReader.ReadString());
            info.SetGermanHFABible(binaryReader.ReadString());
            info.SetGermanInterlinearBible(binaryReader.ReadString());
            info.SetGermanLUT17Bible(binaryReader.ReadString());
            info.SetGermanLuther1912Bible(binaryReader.ReadString());
            info.SetGermanLutherHeuteBible(binaryReader.ReadString());
            info.SetGermanSchlachter2000Bible(binaryReader.ReadString());
            info.SetGermanTafelBible(binaryReader.ReadString());
            info.SetGermanTKWBible(binaryReader.ReadString());
            info.SetGermanUbersetzung2014Bible(binaryReader.ReadString());
            info.SetGhomalaBible(binaryReader.ReadString());
            info.SetGreek1550Bible(binaryReader.ReadString());
            info.SetGreekBible(binaryReader.ReadString());
            info.SetGreekBYZ04Bible(binaryReader.ReadString());
            info.SetGreekBYZ18Bible(binaryReader.ReadString());
            info.SetGreekElzevirBible(binaryReader.ReadString());
            info.SetGreekF35Bible(binaryReader.ReadString());
            info.SetGreekFPBBible(binaryReader.ReadString());
            info.SetGreekGNTBible(binaryReader.ReadString());
            info.SetGreekLMGNTBible(binaryReader.ReadString());
            info.SetGreekModern1904Bible(binaryReader.ReadString());
            info.SetGreekModernFPBBible(binaryReader.ReadString());
            info.SetGreekNTVBible(binaryReader.ReadString());
            info.SetGreekSBLGNTBible(binaryReader.ReadString());
            info.SetGreekTCGNTBible(binaryReader.ReadString());
            info.SetGreekTGVBible(binaryReader.ReadString());
            info.SetGreekTHGNTBible(binaryReader.ReadString());
            info.SetGreekTR1894Bible(binaryReader.ReadString());
            info.SetGuarani1913Bible(binaryReader.ReadString());
            info.SetGuarani1970Bible(binaryReader.ReadString());
            info.SetGuarani1996Bible(binaryReader.ReadString());
            info.SetGuarani2001Bible(binaryReader.ReadString());
            info.SetGuarani2015Bible(binaryReader.ReadString());
            info.SetGuarani2017Bible(binaryReader.ReadString());
            info.SetGuaraniBible(binaryReader.ReadString());
            info.SetGuaraniMBYABible(binaryReader.ReadString());
            info.SetGuaraniSIMBABible(binaryReader.ReadString());
            info.SetGujarati2016Bible(binaryReader.ReadString());
            info.SetGujarati2017Bible(binaryReader.ReadString());
            info.SetGujaratiBible(binaryReader.ReadString());
            info.SetGujaratiGUOVBible(binaryReader.ReadString());
            info.SetGussiBible(binaryReader.ReadString());
            info.SetHadiyyaBible(binaryReader.ReadString());
            info.SetHaitianBible(binaryReader.ReadString());
            info.SetHaitianBSABible(binaryReader.ReadString());
            info.SetHaitianHWPBible(binaryReader.ReadString());
            info.SetHaitianVFKBible(binaryReader.ReadString());
            info.SetHaryanviBible(binaryReader.ReadString());
            info.SetHausa2010Bible(binaryReader.ReadString());
            info.SetHausa2013Bible(binaryReader.ReadString());
            info.SetHausaARBible(binaryReader.ReadString());
            info.SetHebrew1885Bible(binaryReader.ReadString());
            info.SetHebrewAleppoCodexBible(binaryReader.ReadString());
            info.SetHebrewBible(binaryReader.ReadString());
            info.SetHebrewBSIBible(binaryReader.ReadString());
            info.SetHebrewHHHBible(binaryReader.ReadString());
            info.SetHebrewLeningradCodexBible(binaryReader.ReadString());
            info.SetHebrewMHBBible(binaryReader.ReadString());
            info.SetHebrewMHNT2020Bible(binaryReader.ReadString());
            info.SetHebrewTDBible(binaryReader.ReadString());
            info.SetHindi2017Bible(binaryReader.ReadString());
            info.SetHindiBible(binaryReader.ReadString());
            info.SetHindiCLBSIBible(binaryReader.ReadString());
            info.SetHindiERVBible(binaryReader.ReadString());
            info.SetHindiFijiBible(binaryReader.ReadString());
            info.SetHindiHSBBible(binaryReader.ReadString());
            info.SetHindiHSSBible(binaryReader.ReadString());
            info.SetHindiIRVBible(binaryReader.ReadString());
            info.SetHindiOVBSIBible(binaryReader.ReadString());
            info.SetHindiRomanBible(binaryReader.ReadString());
            info.SetHmong2000Bible(binaryReader.ReadString());
            info.SetHmong2004Bible(binaryReader.ReadString());
            info.SetHungarianBDUZBible(binaryReader.ReadString());
            info.SetHungarianBible(binaryReader.ReadString());
            info.SetHungarianBUZBible(binaryReader.ReadString());
            info.SetHungarianCSIABible(binaryReader.ReadString());
            info.SetHungarianCSUZBible(binaryReader.ReadString());
            info.SetHungarianEFOBible(binaryReader.ReadString());
            info.SetHungarianEIVBible(binaryReader.ReadString());
            info.SetHungarianERVBible(binaryReader.ReadString());
            info.SetHungarianKaroliBible(binaryReader.ReadString());
            info.SetHungarianKIBBible(binaryReader.ReadString());
            info.SetHungarianKNBBible(binaryReader.ReadString());
            info.SetHungarianKSZEBible(binaryReader.ReadString());
            info.SetHungarianMRUZBible(binaryReader.ReadString());
            info.SetHungarianRLUZBible(binaryReader.ReadString());
            info.SetHungarianRUFBible(binaryReader.ReadString());
            info.SetHungarianSIUZBible(binaryReader.ReadString());
            info.SetHungarianVSUZBible(binaryReader.ReadString());
            info.SetIbanBible(binaryReader.ReadString());
            info.SetIbibioBible(binaryReader.ReadString());
            info.SetIcelandic1981Bible(binaryReader.ReadString());
            info.SetIcelandicBible(binaryReader.ReadString());
            info.SetIgbo1988Bible(binaryReader.ReadString());
            info.SetIgbo2006Bible(binaryReader.ReadString());
            info.SetIgbo2020Bible(binaryReader.ReadString());
            info.SetIkaBible(binaryReader.ReadString());
            info.SetIlokano1973Bible(binaryReader.ReadString());
            info.SetIlokanoBible(binaryReader.ReadString());
            info.SetIlonggo2012Bible(binaryReader.ReadString());
            info.SetIlonggoAPDBible(binaryReader.ReadString());
            info.SetIlonggoBible(binaryReader.ReadString());
            info.SetIndonesianAGSBible(binaryReader.ReadString());
            info.SetIndonesianAMD2021Bible(binaryReader.ReadString());
            info.SetIndonesianBible(binaryReader.ReadString());
            info.SetIndonesianBISBible(binaryReader.ReadString());
            info.SetIndonesianBPJBible(binaryReader.ReadString());
            info.SetIndonesianFAYHBible(binaryReader.ReadString());
            info.SetIndonesianINOTAZIBible(binaryReader.ReadString());
            info.SetIndonesianPBTB2Bible(binaryReader.ReadString());
            info.SetIndonesianTLBible(binaryReader.ReadString());
            info.SetIndonesianTSIBible(binaryReader.ReadString());
            info.SetIndonesianVMDBible(binaryReader.ReadString());
            info.SetIrish1817Bible(binaryReader.ReadString());
            info.SetIrish1951Bible(binaryReader.ReadString());
            info.SetIrish1970Bible(binaryReader.ReadString());
            info.SetIrish2012Bible(binaryReader.ReadString());
            info.SetIrishBible(binaryReader.ReadString());
            info.SetItalian1649Bible(binaryReader.ReadString());
            info.SetItalian2014Bible(binaryReader.ReadString());
            info.SetItalian2020Bible(binaryReader.ReadString());
            info.SetItalianBible(binaryReader.ReadString());
            info.SetItalianCEI2008Bible(binaryReader.ReadString());
            info.SetItalianIPNBible(binaryReader.ReadString());
            info.SetItalianLaNuovaDiodatiBible(binaryReader.ReadString());
            info.SetItalianNR1994Bible(binaryReader.ReadString());
            info.SetItalianRivedutaBible(binaryReader.ReadString());
            info.SetIuMienBible(binaryReader.ReadString());
            info.SetIuMienThaiBible(binaryReader.ReadString());
            info.SetJamaicanBible(binaryReader.ReadString());
            info.SetJapanese1965Bible(binaryReader.ReadString());
            info.SetJapanese1987Bible(binaryReader.ReadString());
            info.SetJapanese2017Bible(binaryReader.ReadString());
            info.SetJapaneseBible(binaryReader.ReadString());
            info.SetJapaneseCO1955Bible(binaryReader.ReadString());
            info.SetJapaneseERVBible(binaryReader.ReadString());
            info.SetJapaneseJCBBible(binaryReader.ReadString());
            info.SetJavaneseBible(binaryReader.ReadString());
            info.SetJavaneseJVNBible(binaryReader.ReadString());
            info.SetJavaneseKJS17Bible(binaryReader.ReadString());
            info.SetKabardianBible(binaryReader.ReadString());
            info.SetKabyleBible(binaryReader.ReadString());
            info.SetKachinJCLBBible(binaryReader.ReadString());
            info.SetKachinJHVT3Bible(binaryReader.ReadString());
            info.SetKalenjin2019Bible(binaryReader.ReadString());
            info.SetKalenjinBible(binaryReader.ReadString());
            info.SetKalenjinRevisedBible(binaryReader.ReadString());
            info.SetKambaBible(binaryReader.ReadString());
            info.SetKambaMBIVLIABible(binaryReader.ReadString());
            info.SetKangriBible(binaryReader.ReadString());
            info.SetKannada2022Bible(binaryReader.ReadString());
            info.SetKannadaBible(binaryReader.ReadString());
            info.SetKannadaBSIBible(binaryReader.ReadString());
            info.SetKannadaBSIJVBible(binaryReader.ReadString());
            info.SetKannadaIRVBible(binaryReader.ReadString());
            info.SetKannadaKNCLBible(binaryReader.ReadString());
            info.SetKarakalpak2004Bible(binaryReader.ReadString());
            info.SetKarakalpak2022Bible(binaryReader.ReadString());
            info.SetKarakalpakK2022Bible(binaryReader.ReadString());
            info.SetKazakhstan2023Bible(binaryReader.ReadString());
            info.SetKazakhstanBible(binaryReader.ReadString());
            info.SetKenyaGIKCLBible(binaryReader.ReadString());
            info.SetKhmer2005Bible(binaryReader.ReadString());
            info.SetKhmer2012Bible(binaryReader.ReadString());
            info.SetKhmer2014Bible(binaryReader.ReadString());
            info.SetKhmer2016Bible(binaryReader.ReadString());
            info.SetKhmer2019Bible(binaryReader.ReadString());
            info.SetKhmerBFBSBible(binaryReader.ReadString());
            info.SetKhmerBible(binaryReader.ReadString());
            info.SetKiche1995Bible(binaryReader.ReadString());
            info.SetKiche2022Bible(binaryReader.ReadString());
            info.SetKicheBible(binaryReader.ReadString());
            info.SetKicheQUCNBible(binaryReader.ReadString());
            info.SetKikuyu2013Bible(binaryReader.ReadString());
            info.SetKikuyu2014Bible(binaryReader.ReadString());
            info.SetKikuyu2019Bible(binaryReader.ReadString());
            info.SetKikwangoBible(binaryReader.ReadString());
            info.SetKimbunduBible(binaryReader.ReadString());
            info.SetKimiiruBible(binaryReader.ReadString());
            info.SetKinyarwanda2001Bible(binaryReader.ReadString());
            info.SetKinyarwanda2012Bible(binaryReader.ReadString());
            info.SetKinyarwandaBIRBible(binaryReader.ReadString());
            info.SetKirundiCorosheBible(binaryReader.ReadString());
            info.SetKirundiRishaBible(binaryReader.ReadString());
            info.SetKitubaBible(binaryReader.ReadString());
            info.SetKonkaniBible(binaryReader.ReadString());
            info.SetKorean2021Bible(binaryReader.ReadString());
            info.SetKoreanAEBBible(binaryReader.ReadString());
            info.SetKoreanKLBBible(binaryReader.ReadString());
            info.SetKoreanNKRVBible(binaryReader.ReadString());
            info.SetKoreanRentierBible(binaryReader.ReadString());
            info.SetKoreanRNKSVBible(binaryReader.ReadString());
            info.SetKoreanTKVBible(binaryReader.ReadString());
            info.SetKoreanWoorimalBible(binaryReader.ReadString());
            info.SetKoyaBible(binaryReader.ReadString());
            info.SetKrioBible(binaryReader.ReadString());
            info.SetKumaoniBible(binaryReader.ReadString());
            info.SetKurdish2005Bible(binaryReader.ReadString());
            info.SetKurdish2017Bible(binaryReader.ReadString());
            info.SetKurdishBHDBible(binaryReader.ReadString());
            info.SetKurdishBible(binaryReader.ReadString());
            info.SetKurdishKMRNTCBible(binaryReader.ReadString());
            info.SetKurdishKMRNTLBible(binaryReader.ReadString());
            info.SetKurdishPNTZSBible(binaryReader.ReadString());
            info.SetKurdishSKBBible(binaryReader.ReadString());
            info.SetKurdishSKVBible(binaryReader.ReadString());
            info.SetKurukh2025Bible(binaryReader.ReadString());
            info.SetKurukhBible(binaryReader.ReadString());
            info.SetKyrgyz2004Bible(binaryReader.ReadString());
            info.SetKyrgyz2005Bible(binaryReader.ReadString());
            info.SetLahuBible(binaryReader.ReadString());
            info.SetLahuLHINTBible(binaryReader.ReadString());
            info.SetLambadiBible(binaryReader.ReadString());
            info.SetLango1979Bible(binaryReader.ReadString());
            info.SetLangoBible(binaryReader.ReadString());
            info.SetLao2012Bible(binaryReader.ReadString());
            info.SetLaoBible(binaryReader.ReadString());
            info.SetLaoLCVBible(binaryReader.ReadString());
            info.SetLatinBible(binaryReader.ReadString());
            info.SetLatinClementina1914Bible(binaryReader.ReadString());
            info.SetLatinClementineBible(binaryReader.ReadString());
            info.SetLatinNovaVulgataBible(binaryReader.ReadString());
            info.SetLatinSistinaBible(binaryReader.ReadString());
            info.SetLatvian1965Bible(binaryReader.ReadString());
            info.SetLatvian2012Bible(binaryReader.ReadString());
            info.SetLatvian2024Bible(binaryReader.ReadString());
            info.SetLatvianBible(binaryReader.ReadString());
            info.SetLatvianGluckBible(binaryReader.ReadString());
            info.SetLatvianLG8Bible(binaryReader.ReadString());
            info.SetLatvianLTV1965Bible(binaryReader.ReadString());
            info.SetLatvianNLBDCBible(binaryReader.ReadString());
            info.SetLiberianKreyolBible(binaryReader.ReadString());
            info.SetLingala2002Bible(binaryReader.ReadString());
            info.SetLingala2020Bible(binaryReader.ReadString());
            info.SetLithuanian2012Bible(binaryReader.ReadString());
            info.SetLithuanian2012EKUBible(binaryReader.ReadString());
            info.SetLithuanian2012KANBible(binaryReader.ReadString());
            info.SetLithuanianBible(binaryReader.ReadString());
            info.SetLithuanianKJBible(binaryReader.ReadString());
            info.SetLithuanianLBDBible(binaryReader.ReadString());
            info.SetLomweBible(binaryReader.ReadString());
            info.SetLuganda2003Bible(binaryReader.ReadString());
            info.SetLugandaBible(binaryReader.ReadString());
            info.SetLugandaBIBU1Bible(binaryReader.ReadString());
            info.SetLugandaEEEEBible(binaryReader.ReadString());
            info.SetLugandaLBRBible(binaryReader.ReadString());
            info.SetLugbaraBible(binaryReader.ReadString());
            info.SetLuguruBible(binaryReader.ReadString());
            info.SetLuo1985Bible(binaryReader.ReadString());
            info.SetLuo2015Bible(binaryReader.ReadString());
            info.SetLuo2020Bible(binaryReader.ReadString());
            info.SetMaasai1970Bible(binaryReader.ReadString());
            info.SetMaasai2020Bible(binaryReader.ReadString());
            info.SetMaasaiBible(binaryReader.ReadString());
            info.SetMaasaiMBSBible(binaryReader.ReadString());
            info.SetMacedonian1990Bible(binaryReader.ReadString());
            info.SetMacedonian2006Bible(binaryReader.ReadString());
            info.SetMacedonian2006DBible(binaryReader.ReadString());
            info.SetMacedonian2023Bible(binaryReader.ReadString());
            info.SetMacedonianMKB1999Bible(binaryReader.ReadString());
            info.SetMacedonianMNT1999Bible(binaryReader.ReadString());
            info.SetMadureseBible(binaryReader.ReadString());
            info.SetMaithiliBible(binaryReader.ReadString());
            info.SetMakhuwa2021Bible(binaryReader.ReadString());
            info.SetMakhuwaBible(binaryReader.ReadString());
            info.SetMakhuwaVMKBible(binaryReader.ReadString());
            info.SetMakondeBible(binaryReader.ReadString());
            info.SetMakondeShiBible(binaryReader.ReadString());
            info.SetMalagasy1865Bible(binaryReader.ReadString());
            info.SetMalagasy2003Bible(binaryReader.ReadString());
            info.SetMalagasy2004Bible(binaryReader.ReadString());
            info.SetMalagasy2011Bible(binaryReader.ReadString());
            info.SetMalagasyBible(binaryReader.ReadString());
            info.SetMalagasyMRVBible(binaryReader.ReadString());
            info.SetMalayalam1910Bible(binaryReader.ReadString());
            info.SetMalayalam2013Bible(binaryReader.ReadString());
            info.SetMalayalamBCSBible(binaryReader.ReadString());
            info.SetMalayalamBible(binaryReader.ReadString());
            info.SetMalayalamBSIBible(binaryReader.ReadString());
            info.SetMalayalamCVBible(binaryReader.ReadString());
            info.SetMalayalamMalovBible(binaryReader.ReadString());
            info.SetMalayalamWBTCBible(binaryReader.ReadString());
            info.SetMalaysian1996Bible(binaryReader.ReadString());
            info.SetMalaysian2017Bible(binaryReader.ReadString());
            info.SetMalaysian2020Bible(binaryReader.ReadString());
            info.SetMalaysianBible(binaryReader.ReadString());
            info.SetMaori2012Bible(binaryReader.ReadString());
            info.SetMaoriBible(binaryReader.ReadString());
            info.SetMarathi2015Bible(binaryReader.ReadString());
            info.SetMarathiBible(binaryReader.ReadString());
            info.SetMarathiBSIBible(binaryReader.ReadString());
            info.SetMarathiIRVMARBible(binaryReader.ReadString());
            info.SetMarathiMRCVBible(binaryReader.ReadString());
            info.SetMarwariBible(binaryReader.ReadString());
            info.SetMazanderaniGMBBible(binaryReader.ReadString());
            info.SetMazanderaniBible(binaryReader.ReadString());
            info.SetMazanderaniWMBBible(binaryReader.ReadString());
            info.SetMeiteiBible(binaryReader.ReadString());
            info.SetMendeBible(binaryReader.ReadString());
            info.SetMewariBible(binaryReader.ReadString());
            info.SetMizoBible(binaryReader.ReadString());
            info.SetMizoCLBSIBible(binaryReader.ReadString());
            info.SetMizoOVBSIBible(binaryReader.ReadString());
            info.SetMobaBible(binaryReader.ReadString());
            info.SetMoldovianCyrillicBible(binaryReader.ReadString());
            info.SetMoldovianLatinBible(binaryReader.ReadString());
            info.SetMongolian2004Bible(binaryReader.ReadString());
            info.SetMongolian2013Bible(binaryReader.ReadString());
            info.SetMorisyen2021Bible(binaryReader.ReadString());
            info.SetMorisyenBible(binaryReader.ReadString());
            info.SetMossi2014Bible(binaryReader.ReadString());
            info.SetMossiSBBible(binaryReader.ReadString());
            info.SetMossiSSDCBible(binaryReader.ReadString());
            info.SetMunda2020Bible(binaryReader.ReadString());
            info.SetMundaBible(binaryReader.ReadString());
            info.SetNahuatl2012Bible(binaryReader.ReadString());
            info.SetNahuatl2017Bible(binaryReader.ReadString());
            info.SetNahuatlBible(binaryReader.ReadString());
            info.SetNahuatlGUBible(binaryReader.ReadString());
            info.SetNahuatlNHEBible(binaryReader.ReadString());
            info.SetNdau2023Bible(binaryReader.ReadString());
            info.SetNdauBible(binaryReader.ReadString());
            info.SetNdebele2002Bible(binaryReader.ReadString());
            info.SetNdebele2003Bible(binaryReader.ReadString());
            info.SetNdebele2012Bible(binaryReader.ReadString());
            info.SetNdebeleBible(binaryReader.ReadString());
            info.SetNepali2008Bible(binaryReader.ReadString());
            info.SetNepali2012Bible(binaryReader.ReadString());
            info.SetNepali2021Bible(binaryReader.ReadString());
            info.SetNepaliBible(binaryReader.ReadString());
            info.SetNepaliTamangBible(binaryReader.ReadString());
            info.SetNigerianPidginBible(binaryReader.ReadString());
            info.SetNorwegian1921Bible(binaryReader.ReadString());
            info.SetNorwegian1938Bible(binaryReader.ReadString());
            info.SetNorwegian1978Bible(binaryReader.ReadString());
            info.SetNorwegian2007Bible(binaryReader.ReadString());
            info.SetNorwegian2011Bible(binaryReader.ReadString());
            info.SetNorwegian2018Bible(binaryReader.ReadString());
            info.SetNorwegianBGOBible(binaryReader.ReadString());
            info.SetNorwegianBIBEL1978Bible(binaryReader.ReadString());
            info.SetNorwegianBible(binaryReader.ReadString());
            info.SetNorwegianELBBible(binaryReader.ReadString());
            info.SetNorwegianN78BMBible(binaryReader.ReadString());
            info.SetNorwegianN78NNBible(binaryReader.ReadString());
            info.SetNorwegianNY2011Bible(binaryReader.ReadString());
            info.SetNuerBible(binaryReader.ReadString());
            info.SetNyankole1964Bible(binaryReader.ReadString());
            info.SetNyankoleBible(binaryReader.ReadString());
            info.SetOdia2024Bible(binaryReader.ReadString());
            info.SetOdiaBible(binaryReader.ReadString());
            info.SetOdiaBSIBible(binaryReader.ReadString());
            info.SetOdiaERVBible(binaryReader.ReadString());
            info.SetOdiaIRV2017Bible(binaryReader.ReadString());
            info.SetOdiaIRVBible(binaryReader.ReadString());
            info.SetOdiaOROVBible(binaryReader.ReadString());
            info.SetOriginalGreekBible(binaryReader.ReadString());
            info.SetOriginalHebrewBible(binaryReader.ReadString());
            info.SetOromoGUJBible(binaryReader.ReadString());
            info.SetOromoGujiBible(binaryReader.ReadString());
            info.SetOromoKakuuHaaraakaBible(binaryReader.ReadString());
            info.SetOromoKitaabaWaaqaBible(binaryReader.ReadString());
            info.SetOromoKitaabaWoyyuuBible(binaryReader.ReadString());
            info.SetOromoWaadaaHaarawaBible(binaryReader.ReadString());
            info.SetOromoWaadaaLammataaBible(binaryReader.ReadString());
            info.SetPampangaBible(binaryReader.ReadString());
            info.SetPapuaNewGuineaBible(binaryReader.ReadString());
            info.SetPapuaNewGuineaTokPisinBible(binaryReader.ReadString());
            info.SetPashto2019Bible(binaryReader.ReadString());
            info.SetPashto2023Bible(binaryReader.ReadString());
            info.SetPashtoBible(binaryReader.ReadString());
            info.SetPersian2005Bible(binaryReader.ReadString());
            info.SetPersian2014Bible(binaryReader.ReadString());
            info.SetPersianBible(binaryReader.ReadString());
            info.SetPersianDariBible(binaryReader.ReadString());
            info.SetPersianTPVBible(binaryReader.ReadString());
            info.SetPolish2016Bible(binaryReader.ReadString());
            info.SetPolish2018Bible(binaryReader.ReadString());
            info.SetPolishBible(binaryReader.ReadString());
            info.SetPolishGdansk2017Bible(binaryReader.ReadString());
            info.SetPolishGdanskBible(binaryReader.ReadString());
            info.SetPolishNBGBible(binaryReader.ReadString());
            info.SetPolishNPDBible(binaryReader.ReadString());
            info.SetPolishSNPD4Bible(binaryReader.ReadString());
            info.SetPortuguese1969Bible(binaryReader.ReadString());
            info.SetPortugueseA21Bible(binaryReader.ReadString());
            info.SetPortugueseAlmeida1628Bible(binaryReader.ReadString());
            info.SetPortugueseAlmeida1753Bible(binaryReader.ReadString());
            info.SetPortugueseARCBible(binaryReader.ReadString());
            info.SetPortugueseBible(binaryReader.ReadString());
            info.SetPortugueseBLTBible(binaryReader.ReadString());
            info.SetPortugueseBPT09Bible(binaryReader.ReadString());
            info.SetPortugueseCAPBible(binaryReader.ReadString());
            info.SetPortugueseMZNVIBible(binaryReader.ReadString());
            info.SetPortugueseNAABible(binaryReader.ReadString());
            info.SetPortugueseNBV2007Bible(binaryReader.ReadString());
            info.SetPortugueseNTLHBible(binaryReader.ReadString());
            info.SetPortugueseNVI2023Bible(binaryReader.ReadString());
            info.SetPortugueseNVIBible(binaryReader.ReadString());
            info.SetPortugueseNVTBible(binaryReader.ReadString());
            info.SetPortugueseOLBible(binaryReader.ReadString());
            info.SetPortugueseTBBible(binaryReader.ReadString());
            info.SetPortugueseVFLBible(binaryReader.ReadString());
            info.SetPularBible(binaryReader.ReadString());
            info.SetPunjabi2016Bible(binaryReader.ReadString());
            info.SetPunjabi2020Bible(binaryReader.ReadString());
            info.SetPunjabi2021Bible(binaryReader.ReadString());
            info.SetPunjabi2022Bible(binaryReader.ReadString());
            info.SetPunjabi2023Bible(binaryReader.ReadString());
            info.SetPunjabiBible(binaryReader.ReadString());
            info.SetPunjabiERVBible(binaryReader.ReadString());
            info.SetPunjabiIRVBible(binaryReader.ReadString());
            info.SetQeqchiBible(binaryReader.ReadString());
            info.SetQuechuan2010Bible(binaryReader.ReadString());
            info.SetQuechuanBible(binaryReader.ReadString());
            info.SetQuechuanQVBMBible(binaryReader.ReadString());
            info.SetQuechuanQVSBible(binaryReader.ReadString());
            info.SetQuechuanQVWBible(binaryReader.ReadString());
            info.SetQuechuanQXOBible(binaryReader.ReadString());
            info.SetRomani2004Bible(binaryReader.ReadString());
            info.SetRomani2007Bible(binaryReader.ReadString());
            info.SetRomanian1928Bible(binaryReader.ReadString());
            info.SetRomanian1931Bible(binaryReader.ReadString());
            info.SetRomanian2009Bible(binaryReader.ReadString());
            info.SetRomanian2014Bible(binaryReader.ReadString());
            info.SetRomanian2015Bible(binaryReader.ReadString());
            info.SetRomanian2018Bible(binaryReader.ReadString());
            info.SetRomanian2020Bible(binaryReader.ReadString());
            info.SetRomanian2021Bible(binaryReader.ReadString());
            info.SetRomanian2022Bible(binaryReader.ReadString());
            info.SetRomanian2023Bible(binaryReader.ReadString());
            info.SetRomanianBDKBible(binaryReader.ReadString());
            info.SetRomanianBible(binaryReader.ReadString());
            info.SetRomanianSBIRBible(binaryReader.ReadString());
            info.SetRomaniBACHROBible(binaryReader.ReadString());
            info.SetRomaniBaltic2019Bible(binaryReader.ReadString());
            info.SetRomaniBalticLT2019Bible(binaryReader.ReadString());
            info.SetRomaniBible(binaryReader.ReadString());
            info.SetRomaniCHERGASHBible(binaryReader.ReadString());
            info.SetRomaniGSPBible(binaryReader.ReadString());
            info.SetRomaniKALD2004Bible(binaryReader.ReadString());
            info.SetRomaniKALD2020Bible(binaryReader.ReadString());
            info.SetRomaniRMCBible(binaryReader.ReadString());
            info.SetRomaniROM07Bible(binaryReader.ReadString());
            info.SetRomaniROM6Bible(binaryReader.ReadString());
            info.SetRomaniSERBible(binaryReader.ReadString());
            info.SetRomaniSINT2024Bible(binaryReader.ReadString());
            info.SetRussian2012Bible(binaryReader.ReadString());
            info.SetRussianAGPBible(binaryReader.ReadString());
            info.SetRussianBTI2015Bible(binaryReader.ReadString());
            info.SetRussianCARSABible(binaryReader.ReadString());
            info.SetRussianCARSBible(binaryReader.ReadString());
            info.SetRussianCASBible(binaryReader.ReadString());
            info.SetRussianCSLAVBible(binaryReader.ReadString());
            info.SetRussianJewishBible(binaryReader.ReadString());
            info.SetRussianJubileeBible(binaryReader.ReadString());
            info.SetRussianMengeBible(binaryReader.ReadString());
            info.SetRussianNRTBible(binaryReader.ReadString());
            info.SetRussianReceptusBible(binaryReader.ReadString());
            info.SetRussianRSPBible(binaryReader.ReadString());
            info.SetRussianRSTBible(binaryReader.ReadString());
            info.SetRussianSlovoBible(binaryReader.ReadString());
            info.SetRussianSynodalBible(binaryReader.ReadString());
            info.SetRussianWBTCBible(binaryReader.ReadString());
            info.SetSadriBible(binaryReader.ReadString());
            info.SetSanskritDevanagariBible(binaryReader.ReadString());
            info.SetSantaliBangladeshBible(binaryReader.ReadString());
            info.SetSantaliCommonBible(binaryReader.ReadString());
            info.SetSasakBible(binaryReader.ReadString());
            info.SetSena2014Bible(binaryReader.ReadString());
            info.SetSenaBible(binaryReader.ReadString());
            info.SetSenaMalawiBible(binaryReader.ReadString());
            info.SetSeraikiBible(binaryReader.ReadString());
            info.SetSerbianBible(binaryReader.ReadString());
            info.SetSerbianCNZBible(binaryReader.ReadString());
            info.SetSerbianERVBible(binaryReader.ReadString());
            info.SetSerbianLatinBible(binaryReader.ReadString());
            info.SetSerbianNSTBible(binaryReader.ReadString());
            info.SetSerbianNSTLBible(binaryReader.ReadString());
            info.SetSerbianSDSBible(binaryReader.ReadString());
            info.SetShanBible(binaryReader.ReadString());
            info.SetShanNCLBible(binaryReader.ReadString());
            info.SetShekhawatiBible(binaryReader.ReadString());
            info.SetShillukBible(binaryReader.ReadString());
            info.SetShona1949Bible(binaryReader.ReadString());
            info.SetShona2002Bible(binaryReader.ReadString());
            info.SetShonaBDSCBible(binaryReader.ReadString());
            info.SetShonaBible(binaryReader.ReadString());
            info.SetShonaSCLBBible(binaryReader.ReadString());
            info.SetShonaSUBBible(binaryReader.ReadString());
            info.SetSidamoBible(binaryReader.ReadString());
            info.SetSindhiBible(binaryReader.ReadString());
            info.SetSindhiCommonBible(binaryReader.ReadString());
            info.SetSindhiHinduBible(binaryReader.ReadString());
            info.SetSindhiMuslimBible(binaryReader.ReadString());
            info.SetSinhalaNRSVBible(binaryReader.ReadString());
            info.SetSinhalaSCVBible(binaryReader.ReadString());
            info.SetSinhalaSNRVBible(binaryReader.ReadString());
            info.SetSinhalaSROVBible(binaryReader.ReadString());
            info.SetSiswatiBible(binaryReader.ReadString());
            info.SetSlovakian2015Bible(binaryReader.ReadString());
            info.SetSlovakian2017Bible(binaryReader.ReadString());
            info.SetSlovakianBible(binaryReader.ReadString());
            info.SetSlovakianNPK2023Bible(binaryReader.ReadString());
            info.SetSlovakianNPKBible(binaryReader.ReadString());
            info.SetSlovakianRomaniBible(binaryReader.ReadString());
            info.SetSlovakianSEBBible(binaryReader.ReadString());
            info.SetSlovakianSLBBible(binaryReader.ReadString());
            info.SetSlovakianSSVBible(binaryReader.ReadString());
            info.SetSlovenian1584Bible(binaryReader.ReadString());
            info.SetSlovenian1882Bible(binaryReader.ReadString());
            info.SetSlovenian1928Bible(binaryReader.ReadString());
            info.SetSlovenian1990Bible(binaryReader.ReadString());
            info.SetSlovenian2014Bible(binaryReader.ReadString());
            info.SetSlovenianBible(binaryReader.ReadString());
            info.SetSlovenianEKUBible(binaryReader.ReadString());
            info.SetSlovenianSSPBible(binaryReader.ReadString());
            info.SetSogaBible(binaryReader.ReadString());
            info.SetSomalian2018Bible(binaryReader.ReadString());
            info.SetSomalian2024Bible(binaryReader.ReadString());
            info.SetSomalianBible(binaryReader.ReadString());
            info.SetSongeBible(binaryReader.ReadString());
            info.SetSotho1951Bible(binaryReader.ReadString());
            info.SetSotho1989Bible(binaryReader.ReadString());
            info.SetSotho2000Bible(binaryReader.ReadString());
            info.SetSothoBible(binaryReader.ReadString());
            info.SetSpanish1569Bible(binaryReader.ReadString());
            info.SetSpanish1858Bible(binaryReader.ReadString());
            info.SetSpanish1989Bible(binaryReader.ReadString());
            info.SetSpanishBDOBible(binaryReader.ReadString());
            info.SetSpanishBHTIBible(binaryReader.ReadString());
            info.SetSpanishBible(binaryReader.ReadString());
            info.SetSpanishBLPBible(binaryReader.ReadString());
            info.SetSpanishBLPHBible(binaryReader.ReadString());
            info.SetSpanishBTIBible(binaryReader.ReadString());
            info.SetSpanishBTXBible(binaryReader.ReadString());
            info.SetSpanishDHHBible(binaryReader.ReadString());
            info.SetSpanishJBSBible(binaryReader.ReadString());
            info.SetSpanishLBLABible(binaryReader.ReadString());
            info.SetSpanishNBLABible(binaryReader.ReadString());
            info.SetSpanishNBVBible(binaryReader.ReadString());
            info.SetSpanishNTBIZBible(binaryReader.ReadString());
            info.SetSpanishNTVBible(binaryReader.ReadString());
            info.SetSpanishNVIBible(binaryReader.ReadString());
            info.SetSpanishNVISBible(binaryReader.ReadString());
            info.SetSpanishPDTBible(binaryReader.ReadString());
            info.SetSpanishRevisedRVR1960Bible(binaryReader.ReadString());
            info.SetSpanishRV2020Bible(binaryReader.ReadString());
            info.SetSpanishRVA2015Bible(binaryReader.ReadString());
            info.SetSpanishRVCBible(binaryReader.ReadString());
            info.SetSpanishRVESBible(binaryReader.ReadString());
            info.SetSpanishRVGBible(binaryReader.ReadString());
            info.SetSpanishRVR1960Bible(binaryReader.ReadString());
            info.SetSpanishRVR1995Bible(binaryReader.ReadString());
            info.SetSpanishTLABible(binaryReader.ReadString());
            info.SetSpanishVBL2022Bible(binaryReader.ReadString());
            info.SetSpanishVBLBible(binaryReader.ReadString());
            info.SetSukuma1960Bible(binaryReader.ReadString());
            info.SetSukumaBible(binaryReader.ReadString());
            info.SetSundaneseBible(binaryReader.ReadString());
            info.SetSwahili1850Bible(binaryReader.ReadString());
            info.SetSwahili2001Bible(binaryReader.ReadString());
            info.SetSwahili2017Bible(binaryReader.ReadString());
            info.SetSwahili2024Bible(binaryReader.ReadString());
            info.SetSwahiliBHNTLKBible(binaryReader.ReadString());
            info.SetSwahiliBible(binaryReader.ReadString());
            info.SetSwahiliContemporaryBible(binaryReader.ReadString());
            info.SetSwahiliNMMBible(binaryReader.ReadString());
            info.SetSwahiliRSUVDCBible(binaryReader.ReadString());
            info.SetSwahiliSCLDC10Bible(binaryReader.ReadString());
            info.SetSwahiliSRB37Bible(binaryReader.ReadString());
            info.SetSwahiliSUVBible(binaryReader.ReadString());
            info.SetSwahiliSWC02Bible(binaryReader.ReadString());
            info.SetSwahiliSWZZB1921Bible(binaryReader.ReadString());
            info.SetSwedish1873Bible(binaryReader.ReadString());
            info.SetSwedish2000Bible(binaryReader.ReadString());
            info.SetSwedish2015Bible(binaryReader.ReadString());
            info.SetSwedish2019Bible(binaryReader.ReadString());
            info.SetSwedishBible(binaryReader.ReadString());
            info.SetSwedishFolkBible(binaryReader.ReadString());
            info.SetSwedishNLBBible(binaryReader.ReadString());
            info.SetSwedishSB2016Bible(binaryReader.ReadString());
            info.SetSwedishSFBBible(binaryReader.ReadString());
            info.SetSylhetiBible(binaryReader.ReadString());
            info.SetSylhetiSYLLBible(binaryReader.ReadString());
            info.SetTagalog2001Bible(binaryReader.ReadString());
            info.SetTagalog2005Bible(binaryReader.ReadString());
            info.SetTagalog2012Bible(binaryReader.ReadString());
            info.SetTagalog2015Bible(binaryReader.ReadString());
            info.SetTagalogBible(binaryReader.ReadString());
            info.SetTagalogRevised2005Bible(binaryReader.ReadString());
            info.SetTagalogTLBABible(binaryReader.ReadString());
            info.SetTajik1992Bible(binaryReader.ReadString());
            info.SetTajikKMOBible(binaryReader.ReadString());
            info.SetTajikNTBible(binaryReader.ReadString());
            info.SetTamasheqBible(binaryReader.ReadString());
            info.SetTamil2017Bible(binaryReader.ReadString());
            info.SetTamilBible(binaryReader.ReadString());
            info.SetTamilIRVBible(binaryReader.ReadString());
            info.SetTamilRomanisedBible(binaryReader.ReadString());
            info.SetTamilTCVBible(binaryReader.ReadString());
            info.SetTamilTRVBible(binaryReader.ReadString());
            info.SetTamilWBTCBible(binaryReader.ReadString());
            info.SetTarifitBible(binaryReader.ReadString());
            info.SetTashelhaytMoroccoBible(binaryReader.ReadString());
            info.SetTatar2001Bible(binaryReader.ReadString());
            info.SetTatar2015Bible(binaryReader.ReadString());
            info.SetTatar2025Bible(binaryReader.ReadString());
            info.SetTatarRBBLBible(binaryReader.ReadString());
            info.SetTelugu2016Bible(binaryReader.ReadString());
            info.SetTelugu2019Bible(binaryReader.ReadString());
            info.SetTeluguBible(binaryReader.ReadString());
            info.SetTeluguTCVBible(binaryReader.ReadString());
            info.SetTeluguWBTCBible(binaryReader.ReadString());
            info.SetTeso2020Bible(binaryReader.ReadString());
            info.SetTesoBible(binaryReader.ReadString());
            info.SetThadoBible(binaryReader.ReadString());
            info.SetThai1940Bible(binaryReader.ReadString());
            info.SetThai1971Bible(binaryReader.ReadString());
            info.SetThaiBible(binaryReader.ReadString());
            info.SetThaiERVBible(binaryReader.ReadString());
            info.SetThaiKJVBible(binaryReader.ReadString());
            info.SetThaiNTVBible(binaryReader.ReadString());
            info.SetThaiTCVBible(binaryReader.ReadString());
            info.SetThaiTHSBible(binaryReader.ReadString());
            info.SetThaiTNCVBible(binaryReader.ReadString());
            info.SetTibetianBible(binaryReader.ReadString());
            info.SetTibetianCBTBible(binaryReader.ReadString());
            info.SetTivBible(binaryReader.ReadString());
            info.SetTshiluba1996Bible(binaryReader.ReadString());
            info.SetTshiluba2003Bible(binaryReader.ReadString());
            info.SetTshivendaBible(binaryReader.ReadString());
            info.SetTsonga1989Bible(binaryReader.ReadString());
            info.SetTsonga2014Bible(binaryReader.ReadString());
            info.SetTsonga2024Bible(binaryReader.ReadString());
            info.SetTsongaBible(binaryReader.ReadString());
            info.SetTswana1890Bible(binaryReader.ReadString());
            info.SetTswana1970Bible(binaryReader.ReadString());
            info.SetTswana1993Bible(binaryReader.ReadString());
            info.SetTswana2024Bible(binaryReader.ReadString());
            info.SetTswanaBible(binaryReader.ReadString());
            info.SetTuluBible(binaryReader.ReadString());
            info.SetTurkanaBible(binaryReader.ReadString());
            info.SetTurkishBible(binaryReader.ReadString());
            info.SetTurkishHADIBible(binaryReader.ReadString());
            info.SetTurkishKKDEUBible(binaryReader.ReadString());
            info.SetTurkishKMEYABible(binaryReader.ReadString());
            info.SetTurkishNTBBible(binaryReader.ReadString());
            info.SetTurkishTKKBible(binaryReader.ReadString());
            info.SetTurkishTTTBible(binaryReader.ReadString());
            info.SetTurkishYTCBible(binaryReader.ReadString());
            info.SetTurkmen2016Bible(binaryReader.ReadString());
            info.SetTurkmenCyrillic2002Bible(binaryReader.ReadString());
            info.SetTurkmenLatin2002Bible(binaryReader.ReadString());
            info.SetTurkmenLatin2017Bible(binaryReader.ReadString());
            info.SetTwiAkuapemBible(binaryReader.ReadString());
            info.SetTwiAsanteBible(binaryReader.ReadString());
            info.SetTwiDCBible(binaryReader.ReadString());
            info.SetTwiKronkronBible(binaryReader.ReadString());
            info.SetTwiRevisedBible(binaryReader.ReadString());
            info.SetUkrainian1903Bible(binaryReader.ReadString());
            info.SetUkrainian1905Bible(binaryReader.ReadString());
            info.SetUkrainian2004Bible(binaryReader.ReadString());
            info.SetUkrainian2006Bible(binaryReader.ReadString());
            info.SetUkrainian2011Bible(binaryReader.ReadString());
            info.SetUkrainian2021Bible(binaryReader.ReadString());
            info.SetUkrainian2022Bible(binaryReader.ReadString());
            info.SetUkrainianBible(binaryReader.ReadString());
            info.SetUkrainianHOMBible(binaryReader.ReadString());
            info.SetUkrainianTUBBible(binaryReader.ReadString());
            info.SetUkrainianUKDERBible(binaryReader.ReadString());
            info.SetUkrainianUMTBible(binaryReader.ReadString());
            info.SetUmbunduBible(binaryReader.ReadString());
            info.SetUrdu2017Bible(binaryReader.ReadString());
            info.SetUrduBible(binaryReader.ReadString());
            info.SetUrduDGVBible(binaryReader.ReadString());
            info.SetUrduGVRBible(binaryReader.ReadString());
            info.SetUrduIRVURDBible(binaryReader.ReadString());
            info.SetUrduUCVBible(binaryReader.ReadString());
            info.SetUrduUCVDBible(binaryReader.ReadString());
            info.SetUrduUGVBible(binaryReader.ReadString());
            info.SetUrduURDBible(binaryReader.ReadString());
            info.SetUrduURDGVHBible(binaryReader.ReadString());
            info.SetUrduURDR55Bible(binaryReader.ReadString());
            info.SetUyghurArabicBible(binaryReader.ReadString());
            info.SetUyghurCyrillicBible(binaryReader.ReadString());
            info.SetUyghurLatinBible(binaryReader.ReadString());
            info.SetUzbekUZBBible(binaryReader.ReadString());
            info.SetUzbekUZCBible(binaryReader.ReadString());
            info.SetUzbekUZLBCBible(binaryReader.ReadString());
            info.SetVietnamese1994Bible(binaryReader.ReadString());
            info.SetVietnamese2011Bible(binaryReader.ReadString());
            info.SetVietnamese2015Bible(binaryReader.ReadString());
            info.SetVietnameseBible(binaryReader.ReadString());
            info.SetVietnameseERVBible(binaryReader.ReadString());
            info.SetVietnameseNVBBible(binaryReader.ReadString());
            info.SetVietnameseVIEBible(binaryReader.ReadString());
            info.SetWarayBible(binaryReader.ReadString());
            info.SetWelsh1894Bible(binaryReader.ReadString());
            info.SetWelsh1945Bible(binaryReader.ReadString());
            info.SetWelsh2015Bible(binaryReader.ReadString());
            info.SetWelshBible(binaryReader.ReadString());
            info.SetWelshBMWBible(binaryReader.ReadString());
            info.SetWelshCTEBible(binaryReader.ReadString());
            info.SetWelshSBYBible(binaryReader.ReadString());
            info.SetWolayttaBible(binaryReader.ReadString());
            info.SetWolofBible(binaryReader.ReadString());
            info.SetWolofKYGBible(binaryReader.ReadString());
            info.SetXhosa1920Bible(binaryReader.ReadString());
            info.SetXhosa1996Bible(binaryReader.ReadString());
            info.SetXhosa2022Bible(binaryReader.ReadString());
            info.SetXhosaBible(binaryReader.ReadString());
            info.SetYoruba2010Bible(binaryReader.ReadString());
            info.SetYoruba2014Bible(binaryReader.ReadString());
            info.SetYorubaBible(binaryReader.ReadString());
            info.SetZandeBible(binaryReader.ReadString());
            info.SetZarmaBible(binaryReader.ReadString());
            info.SetZulu2020Bible(binaryReader.ReadString());
            info.SetZulu2023Bible(binaryReader.ReadString());
            info.SetZuluBible(binaryReader.ReadString());

            Table.Add(key, info);
        }
    }
}

public class OldTestamentTable
{
    private static Dictionary<int, OldTestamentInfo> Table = new Dictionary<int, OldTestamentInfo>();

    public static Dictionary<int, OldTestamentInfo> GetAll()
    {
        return Table;
    }

    public static OldTestamentInfo GetByKey(int key)
    {
        OldTestamentInfo value;

        if (Table.TryGetValue(key, out value))
            return value;

        return null;
    }

    public static OldTestamentInfo GetByIndex(int index)
    {
        return Table.Values.ElementAt(index);
    }

    public static List<OldTestamentInfo> GetAllList()
    {
        return Table.Values.ToList();
    }

    public OldTestamentTable()
    {
        InitTable();
    }

    private void InitTable()
    {
        TextAsset textAsset = Resources.Load("Tables/OldTestament") as TextAsset;
        MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
        BinaryReader binaryReader = new BinaryReader(memoryStream);

        int tableCount = binaryReader.ReadInt32();

        for( int i = 0; i < tableCount; ++i)
        {
            int key = binaryReader.ReadInt32();

            OldTestamentInfo info = new OldTestamentInfo();
            info.SetID(binaryReader.ReadInt32());
            info.SetEnglish(binaryReader.ReadString());
            info.SetKorean(binaryReader.ReadString());
            info.SetCount(binaryReader.ReadInt32());
            info.SetEnglishTarget(binaryReader.ReadString());
            info.SetNIV(binaryReader.ReadString());
            info.SetKoreanTarget(binaryReader.ReadString());
            info.SetSource(binaryReader.ReadString());
            info.SetEasyBible(binaryReader.ReadString());
            info.SetRevisedHangul(binaryReader.ReadString());
            info.SetRevisedRevision(binaryReader.ReadString());
            info.SetJointTranslation(binaryReader.ReadString());
            info.SetNewStandardTranslation(binaryReader.ReadString());
            info.SetKoreanBible(binaryReader.ReadString());
            info.SetSourceEnglish(binaryReader.ReadString());
            info.SetKJV(binaryReader.ReadString());
            info.SetNewKJV(binaryReader.ReadString());
            info.SetESV(binaryReader.ReadString());
            info.SetNewRSV(binaryReader.ReadString());
            info.SetNASB(binaryReader.ReadString());
            info.Setafri(binaryReader.ReadString());
            info.Setalbanian(binaryReader.ReadString());
            info.Setchinese_union_simp(binaryReader.ReadString());
            info.Setchinese_union_trad(binaryReader.ReadString());
            info.Setckjv_sds(binaryReader.ReadString());
            info.Setckjv_sdt(binaryReader.ReadString());
            info.Setbkr(binaryReader.ReadString());
            info.Setstve(binaryReader.ReadString());
            info.Setfinn(binaryReader.ReadString());
            info.Setepee(binaryReader.ReadString());
            info.Setmartin(binaryReader.ReadString());
            info.Setoster(binaryReader.ReadString());
            info.Setsegond_1910(binaryReader.ReadString());
            info.Setelberfelder_1871(binaryReader.ReadString());
            info.Setelberfelder_1905(binaryReader.ReadString());
            info.Setluther(binaryReader.ReadString());
            info.Setluther_1912(binaryReader.ReadString());
            info.Setschlachter(binaryReader.ReadString());
            info.Setwlc(binaryReader.ReadString());
            info.Setirv(binaryReader.ReadString());
            info.Setkaroli(binaryReader.ReadString());
            info.Setindo_tb(binaryReader.ReadString());
            info.Setindo_tm(binaryReader.ReadString());
            info.Setdiodati(binaryReader.ReadString());
            info.Setbungo(binaryReader.ReadString());
            info.Setkougo(binaryReader.ReadString());
            info.Setmaori(binaryReader.ReadString());
            info.Setopt(binaryReader.ReadString());
            info.Setpol_nbg(binaryReader.ReadString());
            info.Setpol_ubg(binaryReader.ReadString());
            info.Setpolbg(binaryReader.ReadString());
            info.Setalmeida_ra(binaryReader.ReadString());
            info.Setalmeida_rc(binaryReader.ReadString());
            info.Setblivre(binaryReader.ReadString());
            info.Setfidela(binaryReader.ReadString());
            info.Setsynodal(binaryReader.ReadString());
            info.Setrv_1909(binaryReader.ReadString());
            info.Setrvg(binaryReader.ReadString());
            info.Setrvg_2004(binaryReader.ReadString());
            info.Setsagradas(binaryReader.ReadString());
            info.Settagab(binaryReader.ReadString());
            info.Setthaikjv(binaryReader.ReadString());
            info.Setturkish(binaryReader.ReadString());
            info.Setcadman(binaryReader.ReadString());
            info.SetPortuguese(binaryReader.ReadString());
            info.SetGerman(binaryReader.ReadString());
            info.SetJapanese(binaryReader.ReadString());
            info.SetChinese(binaryReader.ReadString());
            info.SetRomanian(binaryReader.ReadString());
            info.SetFrench(binaryReader.ReadString());
            info.SetSpanish(binaryReader.ReadString());
            info.SetItalian(binaryReader.ReadString());
            info.SetHungarian(binaryReader.ReadString());
            info.SetRussian(binaryReader.ReadString());
            info.SetHindi(binaryReader.ReadString());
            info.SetAcehBible(binaryReader.ReadString());
            info.SetAdilabadGondiBible(binaryReader.ReadString());
            info.SetAfrikaans1983Bible(binaryReader.ReadString());
            info.SetAfrikaans2020Bible(binaryReader.ReadString());
            info.SetAfrikaans2023Bible(binaryReader.ReadString());
            info.SetAfrikaansABABible(binaryReader.ReadString());
            info.SetAfrikaansBible(binaryReader.ReadString());
            info.SetAfrikaansDBBible(binaryReader.ReadString());
            info.SetAfrikaansNLVBible(binaryReader.ReadString());
            info.SetAhiraniBible(binaryReader.ReadString());
            info.SetAlbanian1872Bible(binaryReader.ReadString());
            info.SetAlbanian1879Bible(binaryReader.ReadString());
            info.SetAlbanian2018Bible(binaryReader.ReadString());
            info.SetAlbanianBible(binaryReader.ReadString());
            info.SetAmharic2000Bible(binaryReader.ReadString());
            info.SetAmharicBible(binaryReader.ReadString());
            info.SetAmharicCatholicBible(binaryReader.ReadString());
            info.SetAmharicDawroBible(binaryReader.ReadString());
            info.SetAmharicDawroDFBEBible(binaryReader.ReadString());
            info.SetAmharicDawroDFBLVLBible(binaryReader.ReadString());
            info.SetAmharicDawroDWRNTBible(binaryReader.ReadString());
            info.SetAmharicDawroWWIBible(binaryReader.ReadString());
            info.SetAmharicGamo2017Bible(binaryReader.ReadString());
            info.SetAmharicGamoBible(binaryReader.ReadString());
            info.SetAmharicGamoGMBible(binaryReader.ReadString());
            info.SetAmharicGamoWordBible(binaryReader.ReadString());
            info.SetAmharicGofaBible(binaryReader.ReadString());
            info.SetAmharicGofaGFBEVFBible(binaryReader.ReadString());
            info.SetAmharicGofaGFBLVFBible(binaryReader.ReadString());
            info.SetAmharicGofaRNTBible(binaryReader.ReadString());
            info.SetAmharicGofaWWIBible(binaryReader.ReadString());
            info.SetAmharicNASVBible(binaryReader.ReadString());
            info.SetAmharicNSTBible(binaryReader.ReadString());
            info.SetAmharicTigrinya15Bible(binaryReader.ReadString());
            info.SetAmharicTigrinya2024Bible(binaryReader.ReadString());
            info.SetAmharicTigrinyaBible(binaryReader.ReadString());
            info.SetArabic1978Bible(binaryReader.ReadString());
            info.SetArabic2016Bible(binaryReader.ReadString());
            info.SetArabic2018Bible(binaryReader.ReadString());
            info.SetArabic2023Bible(binaryReader.ReadString());
            info.SetArabicAlgeriaBible(binaryReader.ReadString());
            info.SetArabicAPDBible(binaryReader.ReadString());
            info.SetArabicAVDBible(binaryReader.ReadString());
            info.SetArabicAVDDVBible(binaryReader.ReadString());
            info.SetArabicBible(binaryReader.ReadString());
            info.SetArabicERVBible(binaryReader.ReadString());
            info.SetArabicGNABible(binaryReader.ReadString());
            info.SetArabicGOVBible(binaryReader.ReadString());
            info.SetArabicLABible(binaryReader.ReadString());
            info.SetArabicLebaneseBible(binaryReader.ReadString());
            info.SetArabicMorocco2023Bible(binaryReader.ReadString());
            info.SetArabicMoroccoBible(binaryReader.ReadString());
            info.SetArabicSABBible(binaryReader.ReadString());
            info.SetArabicSABible(binaryReader.ReadString());
            info.SetArabicSVDBible(binaryReader.ReadString());
            info.SetArabicTMABible(binaryReader.ReadString());
            info.SetArabicTU2022Bible(binaryReader.ReadString());
            info.SetArabicTunisianBible(binaryReader.ReadString());
            info.SetAramaicBible(binaryReader.ReadString());
            info.SetArmenian1853Bible(binaryReader.ReadString());
            info.SetArmenian2017Bible(binaryReader.ReadString());
            info.SetArmenian2018Bible(binaryReader.ReadString());
            info.SetArmenian2019Bible(binaryReader.ReadString());
            info.SetArmenianAraratBible(binaryReader.ReadString());
            info.SetArmenianBible(binaryReader.ReadString());
            info.SetArmenianEasternBible(binaryReader.ReadString());
            info.SetArmenianNEABible(binaryReader.ReadString());
            info.SetAssameseBible(binaryReader.ReadString());
            info.SetAvarBible(binaryReader.ReadString());
            info.SetAwadhiBible(binaryReader.ReadString());
            info.SetAymara1986Bible(binaryReader.ReadString());
            info.SetAymara1997Bible(binaryReader.ReadString());
            info.SetAymaraBible(binaryReader.ReadString());
            info.SetAzerbaijan2013Bible(binaryReader.ReadString());
            info.SetAzerbaijanBible(binaryReader.ReadString());
            info.SetAzerbaijanSouthBible(binaryReader.ReadString());
            info.SetBagriBible(binaryReader.ReadString());
            info.SetBalineseBible(binaryReader.ReadString());
            info.SetBalochiArabicBible(binaryReader.ReadString());
            info.SetBalochiBible(binaryReader.ReadString());
            info.SetBalochiSoutherenBible(binaryReader.ReadString());
            info.SetBalochiSoutherenLatinBible(binaryReader.ReadString());
            info.SetBaoule1974Bible(binaryReader.ReadString());
            info.SetBaoule1998Bible(binaryReader.ReadString());
            info.SetBaouleBible(binaryReader.ReadString());
            info.SetBashkir2023Bible(binaryReader.ReadString());
            info.SetBashkirBible(binaryReader.ReadString());
            info.SetBasqueBible(binaryReader.ReadString());
            info.SetBasque2008Bible(binaryReader.ReadString());
            info.SetBavarianBible(binaryReader.ReadString());
            info.SetBelarusian2017Bible(binaryReader.ReadString());
            info.SetBelarusianBible(binaryReader.ReadString());
            info.SetBelarusianBokunBible(binaryReader.ReadString());
            info.SetBelarusianCHNTBible(binaryReader.ReadString());
            info.SetBelarusianNTJSBible(binaryReader.ReadString());
            info.SetBembaBible(binaryReader.ReadString());
            info.SetBengali2017Bible(binaryReader.ReadString());
            info.SetBengali2023Bible(binaryReader.ReadString());
            info.SetBengaliBACIBBible(binaryReader.ReadString());
            info.SetBengaliBCVBible(binaryReader.ReadString());
            info.SetBengaliBible(binaryReader.ReadString());
            info.SetBengaliBSIBible(binaryReader.ReadString());
            info.SetBengaliCLBSIBible(binaryReader.ReadString());
            info.SetBengaliERVBible(binaryReader.ReadString());
            info.SetBengaliIRVBENBible(binaryReader.ReadString());
            info.SetBengaliMBCLBible(binaryReader.ReadString());
            info.SetBengaliSBCLBible(binaryReader.ReadString());
            info.SetBerberBible(binaryReader.ReadString());
            info.SetBhilaliBible(binaryReader.ReadString());
            info.SetBodoBible(binaryReader.ReadString());
            info.SetBodoNTBPL20Bible(binaryReader.ReadString());
            info.SetBosnianBible(binaryReader.ReadString());
            info.SetBrajBible(binaryReader.ReadString());
            info.SetBugisBible(binaryReader.ReadString());
            info.SetBulgarian2015Bible(binaryReader.ReadString());
            info.SetBulgarianBible(binaryReader.ReadString());
            info.SetBulgarianBOBBible(binaryReader.ReadString());
            info.SetBulgarianBPBBible(binaryReader.ReadString());
            info.SetBulgarianCBTBible(binaryReader.ReadString());
            info.SetBulgarianSPBBible(binaryReader.ReadString());
            info.SetBulgarianTZABible(binaryReader.ReadString());
            info.SetBulgarianVerensBible(binaryReader.ReadString());
            info.SetBundeliBible(binaryReader.ReadString());
            info.SetBurmese1928Bible(binaryReader.ReadString());
            info.SetBurmese2021Bible(binaryReader.ReadString());
            info.SetBurmeseBCLBible(binaryReader.ReadString());
            info.SetBurmeseBible(binaryReader.ReadString());
            info.SetBurmeseJBZVBible(binaryReader.ReadString());
            info.SetBurmeseMCLZVBible(binaryReader.ReadString());
            info.SetBurmeseMSBUBible(binaryReader.ReadString());
            info.SetBurmeseMSBZBible(binaryReader.ReadString());
            info.SetCatalanBCIBible(binaryReader.ReadString());
            info.SetCatalanBECBible(binaryReader.ReadString());
            info.SetCebuano1999Bible(binaryReader.ReadString());
            info.SetCebuano2011Bible(binaryReader.ReadString());
            info.SetCebuanoAPSDBible(binaryReader.ReadString());
            info.SetCebuanoBible(binaryReader.ReadString());
            info.SetCebuanoRCPVBible(binaryReader.ReadString());
            info.SetChechenBible(binaryReader.ReadString());
            info.SetChewa1992Bible(binaryReader.ReadString());
            info.SetChewa2014Bible(binaryReader.ReadString());
            info.SetChewa2016Bible(binaryReader.ReadString());
            info.SetChewaBLYDCBible(binaryReader.ReadString());
            info.SetChhattisgarhiBible(binaryReader.ReadString());
            info.SetChibembaBible(binaryReader.ReadString());
            info.SetChin2010Bible(binaryReader.ReadString());
            info.SetChinBSIBible(binaryReader.ReadString());
            info.SetChinCSHBible(binaryReader.ReadString());
            info.SetChinDNTBible(binaryReader.ReadString());
            info.SetChinese1886Bible(binaryReader.ReadString());
            info.SetChinese1919Bible(binaryReader.ReadString());
            info.SetChinese1927Bible(binaryReader.ReadString());
            info.SetChinese1933Bible(binaryReader.ReadString());
            info.SetChinese1941Bible(binaryReader.ReadString());
            info.SetChinese1967Bible(binaryReader.ReadString());
            info.SetChineseCCBSBible(binaryReader.ReadString());
            info.SetChineseCCBTBible(binaryReader.ReadString());
            info.SetChineseCSBSBible(binaryReader.ReadString());
            info.SetChineseCSBTBible(binaryReader.ReadString());
            info.SetChineseCUNPSSBible(binaryReader.ReadString());
            info.SetChineseCUNPSTBible(binaryReader.ReadString());
            info.SetChineseNankingBible(binaryReader.ReadString());
            info.SetChinesePekingBible(binaryReader.ReadString());
            info.SetChineseRCUVSSBible(binaryReader.ReadString());
            info.SetChineseRCUVTBible(binaryReader.ReadString());
            info.SetChineseSimplifiedBible(binaryReader.ReadString());
            info.SetChineseSimplifiedNewBible(binaryReader.ReadString());
            info.SetChineseTCV2019TBible(binaryReader.ReadString());
            info.SetChineseTHV2012Bible(binaryReader.ReadString());
            info.SetChineseTraditionalBible(binaryReader.ReadString());
            info.SetChineseTraditionalERVBible(binaryReader.ReadString());
            info.SetChineseTraditionalNewBible(binaryReader.ReadString());
            info.SetChineseTTVHBible(binaryReader.ReadString());
            info.SetChineseTTVRBible(binaryReader.ReadString());
            info.SetChineseUnion2010Bible(binaryReader.ReadString());
            info.SetChineseWenli1823Bible(binaryReader.ReadString());
            info.SetChineseWenli1885Bible(binaryReader.ReadString());
            info.SetChineseWenli1897Bible(binaryReader.ReadString());
            info.SetChineseWenliBible(binaryReader.ReadString());
            info.SetChineseWenliEasyBible(binaryReader.ReadString());
            info.SetChinKNTPBible(binaryReader.ReadString());
            info.SetChinMatupi2006Bible(binaryReader.ReadString());
            info.SetChinMatupiBible(binaryReader.ReadString());
            info.SetChinSCB2Bible(binaryReader.ReadString());
            info.SetChinTB77Bible(binaryReader.ReadString());
            info.SetChinTBR17Bible(binaryReader.ReadString());
            info.SetChinTDBBible(binaryReader.ReadString());
            info.SetChinTedim2011Bible(binaryReader.ReadString());
            info.SetChinTedimBible(binaryReader.ReadString());
            info.SetChuvashBible(binaryReader.ReadString());
            info.SetChuvashRSOBible(binaryReader.ReadString());
            info.SetCopticBible(binaryReader.ReadString());
            info.SetCopticCNTVBible(binaryReader.ReadString());
            info.SetCopticSahidicBible(binaryReader.ReadString());
            info.SetCroatianBible(binaryReader.ReadString());
            info.SetCroatianBKJBible(binaryReader.ReadString());
            info.SetCroatianCNTBible(binaryReader.ReadString());
            info.SetCroatianGKSBible(binaryReader.ReadString());
            info.SetCroatianSHPBible(binaryReader.ReadString());
            info.SetCzech1922Bible(binaryReader.ReadString());
            info.SetCzech1947Bible(binaryReader.ReadString());
            info.SetCzech1951Bible(binaryReader.ReadString());
            info.SetCzechBible(binaryReader.ReadString());
            info.SetCzechEkumenickyBible(binaryReader.ReadString());
            info.SetCzechKralichka1613Bible(binaryReader.ReadString());
            info.SetCzechKralichka1998Bible(binaryReader.ReadString());
            info.SetCzechPMPZBible(binaryReader.ReadString());
            info.SetCzechPrekladBible(binaryReader.ReadString());
            info.SetCzechSNCBible(binaryReader.ReadString());
            info.SetDagbaniBible(binaryReader.ReadString());
            info.SetDanish1819Bible(binaryReader.ReadString());
            info.SetDanish2015Bible(binaryReader.ReadString());
            info.SetDanishBible(binaryReader.ReadString());
            info.SetDanishLBBible(binaryReader.ReadString());
            info.SetDanishWIEBible(binaryReader.ReadString());
            info.SetDinka2006Bible(binaryReader.ReadString());
            info.SetDinkaBible(binaryReader.ReadString());
            info.SetDinkaLEKJOTBible(binaryReader.ReadString());
            info.SetDogriBible(binaryReader.ReadString());
            info.SetDutch1939Bible(binaryReader.ReadString());
            info.SetDutch2007Bible(binaryReader.ReadString());
            info.SetDutchBBBible(binaryReader.ReadString());
            info.SetDutchBible(binaryReader.ReadString());
            info.SetDutchEBV24Bible(binaryReader.ReadString());
            info.SetDutchFrisianBible(binaryReader.ReadString());
            info.SetDutchGBVNTBible(binaryReader.ReadString());
            info.SetDutchHSVBible(binaryReader.ReadString());
            info.SetDutchHTBBible(binaryReader.ReadString());
            info.SetDutchNBGBible(binaryReader.ReadString());
            info.SetDutchReimerBible(binaryReader.ReadString());
            info.SetDutchSVVBible(binaryReader.ReadString());
            info.SetDutchVBBible(binaryReader.ReadString());
            info.SetDyulaJulaBible(binaryReader.ReadString());
            info.SetDyulaKumaBible(binaryReader.ReadString());
            info.SetDyulaLayidukuraBible(binaryReader.ReadString());
            info.SetEdoBible(binaryReader.ReadString());
            info.SetEnglishAmplifiedBible(binaryReader.ReadString());
            info.SetEnglishAmplifiedClassicBible(binaryReader.ReadString());
            info.SetEnglishASVBible(binaryReader.ReadString());
            info.SetEnglishBereanBible(binaryReader.ReadString());
            info.SetEnglishCSBBible(binaryReader.ReadString());
            info.SetEnglishDarbyBible(binaryReader.ReadString());
            info.SetEnglishEASYBible(binaryReader.ReadString());
            info.SetEnglishERVBible(binaryReader.ReadString());
            info.SetEnglishESVBible(binaryReader.ReadString());
            info.SetEnglishGNTBible(binaryReader.ReadString());
            info.SetEnglishGWBible(binaryReader.ReadString());
            info.SetEnglishHCSBBible(binaryReader.ReadString());
            info.SetEnglishKJBible(binaryReader.ReadString());
            info.SetEnglishLSBBible(binaryReader.ReadString());
            info.SetEnglishMEVBible(binaryReader.ReadString());
            info.SetEnglishNASBBible(binaryReader.ReadString());
            info.SetEnglishNASUBible(binaryReader.ReadString());
            info.SetEnglishNETBible(binaryReader.ReadString());
            info.SetEnglishNIRVBible(binaryReader.ReadString());
            info.SetEnglishNIVBible(binaryReader.ReadString());
            info.SetEnglishNKJBible(binaryReader.ReadString());
            info.SetEnglishNLTBible(binaryReader.ReadString());
            info.SetEnglishNRSVBible(binaryReader.ReadString());
            info.SetEnglishPassionBible(binaryReader.ReadString());
            info.SetEnglishRSVBible(binaryReader.ReadString());
            info.SetEnglishTLBible(binaryReader.ReadString());
            info.SetEnglishTyndale1537Bible(binaryReader.ReadString());
            info.SetEnglishYLTBible(binaryReader.ReadString());
            info.SetEsperantoBible(binaryReader.ReadString());
            info.SetEstonian2022Bible(binaryReader.ReadString());
            info.SetEstonianBible(binaryReader.ReadString());
            info.SetEstonianEEPBible(binaryReader.ReadString());
            info.SetEwe1913Bible(binaryReader.ReadString());
            info.SetEwe2014Bible(binaryReader.ReadString());
            info.SetEwe2020Bible(binaryReader.ReadString());
            info.SetEweBible(binaryReader.ReadString());
            info.SetFinnish1776Bible(binaryReader.ReadString());
            info.SetFinnish1992Bible(binaryReader.ReadString());
            info.SetFinnishBible(binaryReader.ReadString());
            info.SetFinnishFINRKBible(binaryReader.ReadString());
            info.SetFinnishSTLKBible(binaryReader.ReadString());
            info.SetFonBible(binaryReader.ReadString());
            info.SetFrench2004Bible(binaryReader.ReadString());
            info.SetFrenchBBBBible(binaryReader.ReadString());
            info.SetFrenchBDSBible(binaryReader.ReadString());
            info.SetFrenchBFCBible(binaryReader.ReadString());
            info.SetFrenchBible(binaryReader.ReadString());
            info.SetFrenchCramponBible(binaryReader.ReadString());
            info.SetFrenchDarbyBible(binaryReader.ReadString());
            info.SetFrenchJerusalemBible(binaryReader.ReadString());
            info.SetFrenchLeonBible(binaryReader.ReadString());
            info.SetFrenchMachairaBible(binaryReader.ReadString());
            info.SetFrenchMartinBible(binaryReader.ReadString());
            info.SetFrenchNBSBible(binaryReader.ReadString());
            info.SetFrenchNEG79Bible(binaryReader.ReadString());
            info.SetFrenchNFCBible(binaryReader.ReadString());
            info.SetFrenchNVS78Bible(binaryReader.ReadString());
            info.SetFrenchOSTBible(binaryReader.ReadString());
            info.SetFrenchOstervaldBible(binaryReader.ReadString());
            info.SetFrenchPDV2017Bible(binaryReader.ReadString());
            info.SetFrenchPerretBible(binaryReader.ReadString());
            info.SetFrenchS21Bible(binaryReader.ReadString());
            info.SetFrenchVigourouxBible(binaryReader.ReadString());
            info.SetFulfulde2010Bible(binaryReader.ReadString());
            info.SetFulfuldeAadiBible(binaryReader.ReadString());
            info.SetFulfuldeAdamawaBible(binaryReader.ReadString());
            info.SetFulfuldeAlkawalBible(binaryReader.ReadString());
            info.SetFulfuldeArabicBible(binaryReader.ReadString());
            info.SetFulfuldeBeninBible(binaryReader.ReadString());
            info.SetFulfuldeBurkinaFasoBible(binaryReader.ReadString());
            info.SetFulfuldeDewtereBible(binaryReader.ReadString());
            info.SetFulfuldeWestNigerBible(binaryReader.ReadString());
            info.SetGaelic1875Bible(binaryReader.ReadString());
            info.SetGaelicABGBible(binaryReader.ReadString());
            info.SetGaelicABIGBible(binaryReader.ReadString());
            info.SetGaelicATNBible(binaryReader.ReadString());
            info.SetGalacianSEPTBible(binaryReader.ReadString());
            info.SetGarhwaliBible(binaryReader.ReadString());
            info.SetGarhwaliGBMBible(binaryReader.ReadString());
            info.SetGeorgian2002Bible(binaryReader.ReadString());
            info.SetGeorgian2012Bible(binaryReader.ReadString());
            info.SetGeorgianBible(binaryReader.ReadString());
            info.SetGerman1545Bible(binaryReader.ReadString());
            info.SetGerman2011Bible(binaryReader.ReadString());
            info.SetGermanAlbrecht1926Bible(binaryReader.ReadString());
            info.SetGermanBible(binaryReader.ReadString());
            info.SetGermanElber1905Bible(binaryReader.ReadString());
            info.SetGermanGruenewaldBible(binaryReader.ReadString());
            info.SetGermanHeuteBible(binaryReader.ReadString());
            info.SetGermanHFABible(binaryReader.ReadString());
            info.SetGermanInterlinearBible(binaryReader.ReadString());
            info.SetGermanLUT17Bible(binaryReader.ReadString());
            info.SetGermanLuther1912Bible(binaryReader.ReadString());
            info.SetGermanLutherHeuteBible(binaryReader.ReadString());
            info.SetGermanSchlachter2000Bible(binaryReader.ReadString());
            info.SetGermanTafelBible(binaryReader.ReadString());
            info.SetGermanTKWBible(binaryReader.ReadString());
            info.SetGermanUbersetzung2014Bible(binaryReader.ReadString());
            info.SetGhomalaBible(binaryReader.ReadString());
            info.SetGreek1550Bible(binaryReader.ReadString());
            info.SetGreekBible(binaryReader.ReadString());
            info.SetGreekBYZ04Bible(binaryReader.ReadString());
            info.SetGreekBYZ18Bible(binaryReader.ReadString());
            info.SetGreekElzevirBible(binaryReader.ReadString());
            info.SetGreekF35Bible(binaryReader.ReadString());
            info.SetGreekFPBBible(binaryReader.ReadString());
            info.SetGreekGNTBible(binaryReader.ReadString());
            info.SetGreekLMGNTBible(binaryReader.ReadString());
            info.SetGreekModern1904Bible(binaryReader.ReadString());
            info.SetGreekModernFPBBible(binaryReader.ReadString());
            info.SetGreekNTVBible(binaryReader.ReadString());
            info.SetGreekSBLGNTBible(binaryReader.ReadString());
            info.SetGreekTCGNTBible(binaryReader.ReadString());
            info.SetGreekTGVBible(binaryReader.ReadString());
            info.SetGreekTHGNTBible(binaryReader.ReadString());
            info.SetGreekTR1894Bible(binaryReader.ReadString());
            info.SetGuarani1913Bible(binaryReader.ReadString());
            info.SetGuarani1970Bible(binaryReader.ReadString());
            info.SetGuarani1996Bible(binaryReader.ReadString());
            info.SetGuarani2001Bible(binaryReader.ReadString());
            info.SetGuarani2015Bible(binaryReader.ReadString());
            info.SetGuarani2017Bible(binaryReader.ReadString());
            info.SetGuaraniBible(binaryReader.ReadString());
            info.SetGuaraniMBYABible(binaryReader.ReadString());
            info.SetGuaraniSIMBABible(binaryReader.ReadString());
            info.SetGujarati2016Bible(binaryReader.ReadString());
            info.SetGujarati2017Bible(binaryReader.ReadString());
            info.SetGujaratiBible(binaryReader.ReadString());
            info.SetGujaratiGUOVBible(binaryReader.ReadString());
            info.SetGussiBible(binaryReader.ReadString());
            info.SetHadiyyaBible(binaryReader.ReadString());
            info.SetHaitianBible(binaryReader.ReadString());
            info.SetHaitianBSABible(binaryReader.ReadString());
            info.SetHaitianHWPBible(binaryReader.ReadString());
            info.SetHaitianVFKBible(binaryReader.ReadString());
            info.SetHaryanviBible(binaryReader.ReadString());
            info.SetHausa2010Bible(binaryReader.ReadString());
            info.SetHausa2013Bible(binaryReader.ReadString());
            info.SetHausaARBible(binaryReader.ReadString());
            info.SetHebrew1885Bible(binaryReader.ReadString());
            info.SetHebrewAleppoCodexBible(binaryReader.ReadString());
            info.SetHebrewBible(binaryReader.ReadString());
            info.SetHebrewBSIBible(binaryReader.ReadString());
            info.SetHebrewHHHBible(binaryReader.ReadString());
            info.SetHebrewLeningradCodexBible(binaryReader.ReadString());
            info.SetHebrewMHBBible(binaryReader.ReadString());
            info.SetHebrewMHNT2020Bible(binaryReader.ReadString());
            info.SetHebrewTDBible(binaryReader.ReadString());
            info.SetHindi2017Bible(binaryReader.ReadString());
            info.SetHindiBible(binaryReader.ReadString());
            info.SetHindiCLBSIBible(binaryReader.ReadString());
            info.SetHindiERVBible(binaryReader.ReadString());
            info.SetHindiFijiBible(binaryReader.ReadString());
            info.SetHindiHSBBible(binaryReader.ReadString());
            info.SetHindiHSSBible(binaryReader.ReadString());
            info.SetHindiIRVBible(binaryReader.ReadString());
            info.SetHindiOVBSIBible(binaryReader.ReadString());
            info.SetHindiRomanBible(binaryReader.ReadString());
            info.SetHmong2000Bible(binaryReader.ReadString());
            info.SetHmong2004Bible(binaryReader.ReadString());
            info.SetHungarianBDUZBible(binaryReader.ReadString());
            info.SetHungarianBible(binaryReader.ReadString());
            info.SetHungarianBUZBible(binaryReader.ReadString());
            info.SetHungarianCSIABible(binaryReader.ReadString());
            info.SetHungarianCSUZBible(binaryReader.ReadString());
            info.SetHungarianEFOBible(binaryReader.ReadString());
            info.SetHungarianEIVBible(binaryReader.ReadString());
            info.SetHungarianERVBible(binaryReader.ReadString());
            info.SetHungarianKaroliBible(binaryReader.ReadString());
            info.SetHungarianKIBBible(binaryReader.ReadString());
            info.SetHungarianKNBBible(binaryReader.ReadString());
            info.SetHungarianKSZEBible(binaryReader.ReadString());
            info.SetHungarianMRUZBible(binaryReader.ReadString());
            info.SetHungarianRLUZBible(binaryReader.ReadString());
            info.SetHungarianRUFBible(binaryReader.ReadString());
            info.SetHungarianSIUZBible(binaryReader.ReadString());
            info.SetHungarianVSUZBible(binaryReader.ReadString());
            info.SetIbanBible(binaryReader.ReadString());
            info.SetIbibioBible(binaryReader.ReadString());
            info.SetIcelandic1981Bible(binaryReader.ReadString());
            info.SetIcelandicBible(binaryReader.ReadString());
            info.SetIgbo1988Bible(binaryReader.ReadString());
            info.SetIgbo2006Bible(binaryReader.ReadString());
            info.SetIgbo2020Bible(binaryReader.ReadString());
            info.SetIkaBible(binaryReader.ReadString());
            info.SetIlokano1973Bible(binaryReader.ReadString());
            info.SetIlokanoBible(binaryReader.ReadString());
            info.SetIlonggo2012Bible(binaryReader.ReadString());
            info.SetIlonggoAPDBible(binaryReader.ReadString());
            info.SetIlonggoBible(binaryReader.ReadString());
            info.SetIndonesianAGSBible(binaryReader.ReadString());
            info.SetIndonesianAMD2021Bible(binaryReader.ReadString());
            info.SetIndonesianBible(binaryReader.ReadString());
            info.SetIndonesianBISBible(binaryReader.ReadString());
            info.SetIndonesianBPJBible(binaryReader.ReadString());
            info.SetIndonesianFAYHBible(binaryReader.ReadString());
            info.SetIndonesianINOTAZIBible(binaryReader.ReadString());
            info.SetIndonesianPBTB2Bible(binaryReader.ReadString());
            info.SetIndonesianTLBible(binaryReader.ReadString());
            info.SetIndonesianTSIBible(binaryReader.ReadString());
            info.SetIndonesianVMDBible(binaryReader.ReadString());
            info.SetIrish1817Bible(binaryReader.ReadString());
            info.SetIrish1951Bible(binaryReader.ReadString());
            info.SetIrish1970Bible(binaryReader.ReadString());
            info.SetIrish2012Bible(binaryReader.ReadString());
            info.SetIrishBible(binaryReader.ReadString());
            info.SetItalian1649Bible(binaryReader.ReadString());
            info.SetItalian2014Bible(binaryReader.ReadString());
            info.SetItalian2020Bible(binaryReader.ReadString());
            info.SetItalianBible(binaryReader.ReadString());
            info.SetItalianCEI2008Bible(binaryReader.ReadString());
            info.SetItalianIPNBible(binaryReader.ReadString());
            info.SetItalianLaNuovaDiodatiBible(binaryReader.ReadString());
            info.SetItalianNR1994Bible(binaryReader.ReadString());
            info.SetItalianRivedutaBible(binaryReader.ReadString());
            info.SetIuMienBible(binaryReader.ReadString());
            info.SetIuMienThaiBible(binaryReader.ReadString());
            info.SetJamaicanBible(binaryReader.ReadString());
            info.SetJapanese1965Bible(binaryReader.ReadString());
            info.SetJapanese1987Bible(binaryReader.ReadString());
            info.SetJapanese2017Bible(binaryReader.ReadString());
            info.SetJapaneseBible(binaryReader.ReadString());
            info.SetJapaneseCO1955Bible(binaryReader.ReadString());
            info.SetJapaneseERVBible(binaryReader.ReadString());
            info.SetJapaneseJCBBible(binaryReader.ReadString());
            info.SetJavaneseBible(binaryReader.ReadString());
            info.SetJavaneseJVNBible(binaryReader.ReadString());
            info.SetJavaneseKJS17Bible(binaryReader.ReadString());
            info.SetKabardianBible(binaryReader.ReadString());
            info.SetKabyleBible(binaryReader.ReadString());
            info.SetKachinJCLBBible(binaryReader.ReadString());
            info.SetKachinJHVT3Bible(binaryReader.ReadString());
            info.SetKalenjin2019Bible(binaryReader.ReadString());
            info.SetKalenjinBible(binaryReader.ReadString());
            info.SetKalenjinRevisedBible(binaryReader.ReadString());
            info.SetKambaBible(binaryReader.ReadString());
            info.SetKambaMBIVLIABible(binaryReader.ReadString());
            info.SetKangriBible(binaryReader.ReadString());
            info.SetKannada2022Bible(binaryReader.ReadString());
            info.SetKannadaBible(binaryReader.ReadString());
            info.SetKannadaBSIBible(binaryReader.ReadString());
            info.SetKannadaBSIJVBible(binaryReader.ReadString());
            info.SetKannadaIRVBible(binaryReader.ReadString());
            info.SetKannadaKNCLBible(binaryReader.ReadString());
            info.SetKarakalpak2004Bible(binaryReader.ReadString());
            info.SetKarakalpak2022Bible(binaryReader.ReadString());
            info.SetKarakalpakK2022Bible(binaryReader.ReadString());
            info.SetKazakhstan2023Bible(binaryReader.ReadString());
            info.SetKazakhstanBible(binaryReader.ReadString());
            info.SetKenyaGIKCLBible(binaryReader.ReadString());
            info.SetKhmer2005Bible(binaryReader.ReadString());
            info.SetKhmer2012Bible(binaryReader.ReadString());
            info.SetKhmer2014Bible(binaryReader.ReadString());
            info.SetKhmer2016Bible(binaryReader.ReadString());
            info.SetKhmer2019Bible(binaryReader.ReadString());
            info.SetKhmerBFBSBible(binaryReader.ReadString());
            info.SetKhmerBible(binaryReader.ReadString());
            info.SetKiche1995Bible(binaryReader.ReadString());
            info.SetKiche2022Bible(binaryReader.ReadString());
            info.SetKicheBible(binaryReader.ReadString());
            info.SetKicheQUCNBible(binaryReader.ReadString());
            info.SetKikuyu2013Bible(binaryReader.ReadString());
            info.SetKikuyu2014Bible(binaryReader.ReadString());
            info.SetKikuyu2019Bible(binaryReader.ReadString());
            info.SetKikwangoBible(binaryReader.ReadString());
            info.SetKimbunduBible(binaryReader.ReadString());
            info.SetKimiiruBible(binaryReader.ReadString());
            info.SetKinyarwanda2001Bible(binaryReader.ReadString());
            info.SetKinyarwanda2012Bible(binaryReader.ReadString());
            info.SetKinyarwandaBIRBible(binaryReader.ReadString());
            info.SetKirundiCorosheBible(binaryReader.ReadString());
            info.SetKirundiRishaBible(binaryReader.ReadString());
            info.SetKitubaBible(binaryReader.ReadString());
            info.SetKonkaniBible(binaryReader.ReadString());
            info.SetKorean2021Bible(binaryReader.ReadString());
            info.SetKoreanAEBBible(binaryReader.ReadString());
            info.SetKoreanKLBBible(binaryReader.ReadString());
            info.SetKoreanNKRVBible(binaryReader.ReadString());
            info.SetKoreanRentierBible(binaryReader.ReadString());
            info.SetKoreanRNKSVBible(binaryReader.ReadString());
            info.SetKoreanTKVBible(binaryReader.ReadString());
            info.SetKoreanWoorimalBible(binaryReader.ReadString());
            info.SetKoyaBible(binaryReader.ReadString());
            info.SetKrioBible(binaryReader.ReadString());
            info.SetKumaoniBible(binaryReader.ReadString());
            info.SetKurdish2005Bible(binaryReader.ReadString());
            info.SetKurdish2017Bible(binaryReader.ReadString());
            info.SetKurdishBHDBible(binaryReader.ReadString());
            info.SetKurdishBible(binaryReader.ReadString());
            info.SetKurdishKMRNTCBible(binaryReader.ReadString());
            info.SetKurdishKMRNTLBible(binaryReader.ReadString());
            info.SetKurdishPNTZSBible(binaryReader.ReadString());
            info.SetKurdishSKBBible(binaryReader.ReadString());
            info.SetKurdishSKVBible(binaryReader.ReadString());
            info.SetKurukh2025Bible(binaryReader.ReadString());
            info.SetKurukhBible(binaryReader.ReadString());
            info.SetKyrgyz2004Bible(binaryReader.ReadString());
            info.SetKyrgyz2005Bible(binaryReader.ReadString());
            info.SetLahuBible(binaryReader.ReadString());
            info.SetLahuLHINTBible(binaryReader.ReadString());
            info.SetLambadiBible(binaryReader.ReadString());
            info.SetLango1979Bible(binaryReader.ReadString());
            info.SetLangoBible(binaryReader.ReadString());
            info.SetLao2012Bible(binaryReader.ReadString());
            info.SetLaoBible(binaryReader.ReadString());
            info.SetLaoLCVBible(binaryReader.ReadString());
            info.SetLatinBible(binaryReader.ReadString());
            info.SetLatinClementina1914Bible(binaryReader.ReadString());
            info.SetLatinClementineBible(binaryReader.ReadString());
            info.SetLatinNovaVulgataBible(binaryReader.ReadString());
            info.SetLatinSistinaBible(binaryReader.ReadString());
            info.SetLatvian1965Bible(binaryReader.ReadString());
            info.SetLatvian2012Bible(binaryReader.ReadString());
            info.SetLatvian2024Bible(binaryReader.ReadString());
            info.SetLatvianBible(binaryReader.ReadString());
            info.SetLatvianGluckBible(binaryReader.ReadString());
            info.SetLatvianLG8Bible(binaryReader.ReadString());
            info.SetLatvianLTV1965Bible(binaryReader.ReadString());
            info.SetLatvianNLBDCBible(binaryReader.ReadString());
            info.SetLiberianKreyolBible(binaryReader.ReadString());
            info.SetLingala2002Bible(binaryReader.ReadString());
            info.SetLingala2020Bible(binaryReader.ReadString());
            info.SetLithuanian2012Bible(binaryReader.ReadString());
            info.SetLithuanian2012EKUBible(binaryReader.ReadString());
            info.SetLithuanian2012KANBible(binaryReader.ReadString());
            info.SetLithuanianBible(binaryReader.ReadString());
            info.SetLithuanianKJBible(binaryReader.ReadString());
            info.SetLithuanianLBDBible(binaryReader.ReadString());
            info.SetLomweBible(binaryReader.ReadString());
            info.SetLuganda2003Bible(binaryReader.ReadString());
            info.SetLugandaBible(binaryReader.ReadString());
            info.SetLugandaBIBU1Bible(binaryReader.ReadString());
            info.SetLugandaEEEEBible(binaryReader.ReadString());
            info.SetLugandaLBRBible(binaryReader.ReadString());
            info.SetLugbaraBible(binaryReader.ReadString());
            info.SetLuguruBible(binaryReader.ReadString());
            info.SetLuo1985Bible(binaryReader.ReadString());
            info.SetLuo2015Bible(binaryReader.ReadString());
            info.SetLuo2020Bible(binaryReader.ReadString());
            info.SetMaasai1970Bible(binaryReader.ReadString());
            info.SetMaasai2020Bible(binaryReader.ReadString());
            info.SetMaasaiBible(binaryReader.ReadString());
            info.SetMaasaiMBSBible(binaryReader.ReadString());
            info.SetMacedonian1990Bible(binaryReader.ReadString());
            info.SetMacedonian2006Bible(binaryReader.ReadString());
            info.SetMacedonian2006DBible(binaryReader.ReadString());
            info.SetMacedonian2023Bible(binaryReader.ReadString());
            info.SetMacedonianMKB1999Bible(binaryReader.ReadString());
            info.SetMacedonianMNT1999Bible(binaryReader.ReadString());
            info.SetMadureseBible(binaryReader.ReadString());
            info.SetMaithiliBible(binaryReader.ReadString());
            info.SetMakhuwa2021Bible(binaryReader.ReadString());
            info.SetMakhuwaBible(binaryReader.ReadString());
            info.SetMakhuwaVMKBible(binaryReader.ReadString());
            info.SetMakondeBible(binaryReader.ReadString());
            info.SetMakondeShiBible(binaryReader.ReadString());
            info.SetMalagasy1865Bible(binaryReader.ReadString());
            info.SetMalagasy2003Bible(binaryReader.ReadString());
            info.SetMalagasy2004Bible(binaryReader.ReadString());
            info.SetMalagasy2011Bible(binaryReader.ReadString());
            info.SetMalagasyBible(binaryReader.ReadString());
            info.SetMalagasyMRVBible(binaryReader.ReadString());
            info.SetMalayalam1910Bible(binaryReader.ReadString());
            info.SetMalayalam2013Bible(binaryReader.ReadString());
            info.SetMalayalamBCSBible(binaryReader.ReadString());
            info.SetMalayalamBible(binaryReader.ReadString());
            info.SetMalayalamBSIBible(binaryReader.ReadString());
            info.SetMalayalamCVBible(binaryReader.ReadString());
            info.SetMalayalamMalovBible(binaryReader.ReadString());
            info.SetMalayalamWBTCBible(binaryReader.ReadString());
            info.SetMalaysian1996Bible(binaryReader.ReadString());
            info.SetMalaysian2017Bible(binaryReader.ReadString());
            info.SetMalaysian2020Bible(binaryReader.ReadString());
            info.SetMalaysianBible(binaryReader.ReadString());
            info.SetMaori2012Bible(binaryReader.ReadString());
            info.SetMaoriBible(binaryReader.ReadString());
            info.SetMarathi2015Bible(binaryReader.ReadString());
            info.SetMarathiBible(binaryReader.ReadString());
            info.SetMarathiBSIBible(binaryReader.ReadString());
            info.SetMarathiIRVMARBible(binaryReader.ReadString());
            info.SetMarathiMRCVBible(binaryReader.ReadString());
            info.SetMarwariBible(binaryReader.ReadString());
            info.SetMazanderaniGMBBible(binaryReader.ReadString());
            info.SetMazanderaniBible(binaryReader.ReadString());
            info.SetMazanderaniWMBBible(binaryReader.ReadString());
            info.SetMeiteiBible(binaryReader.ReadString());
            info.SetMendeBible(binaryReader.ReadString());
            info.SetMewariBible(binaryReader.ReadString());
            info.SetMizoBible(binaryReader.ReadString());
            info.SetMizoCLBSIBible(binaryReader.ReadString());
            info.SetMizoOVBSIBible(binaryReader.ReadString());
            info.SetMobaBible(binaryReader.ReadString());
            info.SetMoldovianCyrillicBible(binaryReader.ReadString());
            info.SetMoldovianLatinBible(binaryReader.ReadString());
            info.SetMongolian2004Bible(binaryReader.ReadString());
            info.SetMongolian2013Bible(binaryReader.ReadString());
            info.SetMorisyen2021Bible(binaryReader.ReadString());
            info.SetMorisyenBible(binaryReader.ReadString());
            info.SetMossi2014Bible(binaryReader.ReadString());
            info.SetMossiSBBible(binaryReader.ReadString());
            info.SetMossiSSDCBible(binaryReader.ReadString());
            info.SetMunda2020Bible(binaryReader.ReadString());
            info.SetMundaBible(binaryReader.ReadString());
            info.SetNahuatl2012Bible(binaryReader.ReadString());
            info.SetNahuatl2017Bible(binaryReader.ReadString());
            info.SetNahuatlBible(binaryReader.ReadString());
            info.SetNahuatlGUBible(binaryReader.ReadString());
            info.SetNahuatlNHEBible(binaryReader.ReadString());
            info.SetNdau2023Bible(binaryReader.ReadString());
            info.SetNdauBible(binaryReader.ReadString());
            info.SetNdebele2002Bible(binaryReader.ReadString());
            info.SetNdebele2003Bible(binaryReader.ReadString());
            info.SetNdebele2012Bible(binaryReader.ReadString());
            info.SetNdebeleBible(binaryReader.ReadString());
            info.SetNepali2008Bible(binaryReader.ReadString());
            info.SetNepali2012Bible(binaryReader.ReadString());
            info.SetNepali2021Bible(binaryReader.ReadString());
            info.SetNepaliBible(binaryReader.ReadString());
            info.SetNepaliTamangBible(binaryReader.ReadString());
            info.SetNigerianPidginBible(binaryReader.ReadString());
            info.SetNorwegian1921Bible(binaryReader.ReadString());
            info.SetNorwegian1938Bible(binaryReader.ReadString());
            info.SetNorwegian1978Bible(binaryReader.ReadString());
            info.SetNorwegian2007Bible(binaryReader.ReadString());
            info.SetNorwegian2011Bible(binaryReader.ReadString());
            info.SetNorwegian2018Bible(binaryReader.ReadString());
            info.SetNorwegianBGOBible(binaryReader.ReadString());
            info.SetNorwegianBIBEL1978Bible(binaryReader.ReadString());
            info.SetNorwegianBible(binaryReader.ReadString());
            info.SetNorwegianELBBible(binaryReader.ReadString());
            info.SetNorwegianN78BMBible(binaryReader.ReadString());
            info.SetNorwegianN78NNBible(binaryReader.ReadString());
            info.SetNorwegianNY2011Bible(binaryReader.ReadString());
            info.SetNuerBible(binaryReader.ReadString());
            info.SetNyankole1964Bible(binaryReader.ReadString());
            info.SetNyankoleBible(binaryReader.ReadString());
            info.SetOdia2024Bible(binaryReader.ReadString());
            info.SetOdiaBible(binaryReader.ReadString());
            info.SetOdiaBSIBible(binaryReader.ReadString());
            info.SetOdiaERVBible(binaryReader.ReadString());
            info.SetOdiaIRV2017Bible(binaryReader.ReadString());
            info.SetOdiaIRVBible(binaryReader.ReadString());
            info.SetOdiaOROVBible(binaryReader.ReadString());
            info.SetOriginalGreekBible(binaryReader.ReadString());
            info.SetOriginalHebrewBible(binaryReader.ReadString());
            info.SetOromoGUJBible(binaryReader.ReadString());
            info.SetOromoGujiBible(binaryReader.ReadString());
            info.SetOromoKakuuHaaraakaBible(binaryReader.ReadString());
            info.SetOromoKitaabaWaaqaBible(binaryReader.ReadString());
            info.SetOromoKitaabaWoyyuuBible(binaryReader.ReadString());
            info.SetOromoWaadaaHaarawaBible(binaryReader.ReadString());
            info.SetOromoWaadaaLammataaBible(binaryReader.ReadString());
            info.SetPampangaBible(binaryReader.ReadString());
            info.SetPapuaNewGuineaBible(binaryReader.ReadString());
            info.SetPapuaNewGuineaTokPisinBible(binaryReader.ReadString());
            info.SetPashto2019Bible(binaryReader.ReadString());
            info.SetPashto2023Bible(binaryReader.ReadString());
            info.SetPashtoBible(binaryReader.ReadString());
            info.SetPersian2005Bible(binaryReader.ReadString());
            info.SetPersian2014Bible(binaryReader.ReadString());
            info.SetPersianBible(binaryReader.ReadString());
            info.SetPersianDariBible(binaryReader.ReadString());
            info.SetPersianTPVBible(binaryReader.ReadString());
            info.SetPolish2016Bible(binaryReader.ReadString());
            info.SetPolish2018Bible(binaryReader.ReadString());
            info.SetPolishBible(binaryReader.ReadString());
            info.SetPolishGdansk2017Bible(binaryReader.ReadString());
            info.SetPolishGdanskBible(binaryReader.ReadString());
            info.SetPolishNBGBible(binaryReader.ReadString());
            info.SetPolishNPDBible(binaryReader.ReadString());
            info.SetPolishSNPD4Bible(binaryReader.ReadString());
            info.SetPortuguese1969Bible(binaryReader.ReadString());
            info.SetPortugueseA21Bible(binaryReader.ReadString());
            info.SetPortugueseAlmeida1628Bible(binaryReader.ReadString());
            info.SetPortugueseAlmeida1753Bible(binaryReader.ReadString());
            info.SetPortugueseARCBible(binaryReader.ReadString());
            info.SetPortugueseBible(binaryReader.ReadString());
            info.SetPortugueseBLTBible(binaryReader.ReadString());
            info.SetPortugueseBPT09Bible(binaryReader.ReadString());
            info.SetPortugueseCAPBible(binaryReader.ReadString());
            info.SetPortugueseMZNVIBible(binaryReader.ReadString());
            info.SetPortugueseNAABible(binaryReader.ReadString());
            info.SetPortugueseNBV2007Bible(binaryReader.ReadString());
            info.SetPortugueseNTLHBible(binaryReader.ReadString());
            info.SetPortugueseNVI2023Bible(binaryReader.ReadString());
            info.SetPortugueseNVIBible(binaryReader.ReadString());
            info.SetPortugueseNVTBible(binaryReader.ReadString());
            info.SetPortugueseOLBible(binaryReader.ReadString());
            info.SetPortugueseTBBible(binaryReader.ReadString());
            info.SetPortugueseVFLBible(binaryReader.ReadString());
            info.SetPularBible(binaryReader.ReadString());
            info.SetPunjabi2016Bible(binaryReader.ReadString());
            info.SetPunjabi2020Bible(binaryReader.ReadString());
            info.SetPunjabi2021Bible(binaryReader.ReadString());
            info.SetPunjabi2022Bible(binaryReader.ReadString());
            info.SetPunjabi2023Bible(binaryReader.ReadString());
            info.SetPunjabiBible(binaryReader.ReadString());
            info.SetPunjabiERVBible(binaryReader.ReadString());
            info.SetPunjabiIRVBible(binaryReader.ReadString());
            info.SetQeqchiBible(binaryReader.ReadString());
            info.SetQuechuan2010Bible(binaryReader.ReadString());
            info.SetQuechuanBible(binaryReader.ReadString());
            info.SetQuechuanQVBMBible(binaryReader.ReadString());
            info.SetQuechuanQVSBible(binaryReader.ReadString());
            info.SetQuechuanQVWBible(binaryReader.ReadString());
            info.SetQuechuanQXOBible(binaryReader.ReadString());
            info.SetRomani2004Bible(binaryReader.ReadString());
            info.SetRomani2007Bible(binaryReader.ReadString());
            info.SetRomanian1928Bible(binaryReader.ReadString());
            info.SetRomanian1931Bible(binaryReader.ReadString());
            info.SetRomanian2009Bible(binaryReader.ReadString());
            info.SetRomanian2014Bible(binaryReader.ReadString());
            info.SetRomanian2015Bible(binaryReader.ReadString());
            info.SetRomanian2018Bible(binaryReader.ReadString());
            info.SetRomanian2020Bible(binaryReader.ReadString());
            info.SetRomanian2021Bible(binaryReader.ReadString());
            info.SetRomanian2022Bible(binaryReader.ReadString());
            info.SetRomanian2023Bible(binaryReader.ReadString());
            info.SetRomanianBDKBible(binaryReader.ReadString());
            info.SetRomanianBible(binaryReader.ReadString());
            info.SetRomanianSBIRBible(binaryReader.ReadString());
            info.SetRomaniBACHROBible(binaryReader.ReadString());
            info.SetRomaniBaltic2019Bible(binaryReader.ReadString());
            info.SetRomaniBalticLT2019Bible(binaryReader.ReadString());
            info.SetRomaniBible(binaryReader.ReadString());
            info.SetRomaniCHERGASHBible(binaryReader.ReadString());
            info.SetRomaniGSPBible(binaryReader.ReadString());
            info.SetRomaniKALD2004Bible(binaryReader.ReadString());
            info.SetRomaniKALD2020Bible(binaryReader.ReadString());
            info.SetRomaniRMCBible(binaryReader.ReadString());
            info.SetRomaniROM07Bible(binaryReader.ReadString());
            info.SetRomaniROM6Bible(binaryReader.ReadString());
            info.SetRomaniSERBible(binaryReader.ReadString());
            info.SetRomaniSINT2024Bible(binaryReader.ReadString());
            info.SetRussian2012Bible(binaryReader.ReadString());
            info.SetRussianAGPBible(binaryReader.ReadString());
            info.SetRussianBTI2015Bible(binaryReader.ReadString());
            info.SetRussianCARSABible(binaryReader.ReadString());
            info.SetRussianCARSBible(binaryReader.ReadString());
            info.SetRussianCASBible(binaryReader.ReadString());
            info.SetRussianCSLAVBible(binaryReader.ReadString());
            info.SetRussianJewishBible(binaryReader.ReadString());
            info.SetRussianJubileeBible(binaryReader.ReadString());
            info.SetRussianMengeBible(binaryReader.ReadString());
            info.SetRussianNRTBible(binaryReader.ReadString());
            info.SetRussianReceptusBible(binaryReader.ReadString());
            info.SetRussianRSPBible(binaryReader.ReadString());
            info.SetRussianRSTBible(binaryReader.ReadString());
            info.SetRussianSlovoBible(binaryReader.ReadString());
            info.SetRussianSynodalBible(binaryReader.ReadString());
            info.SetRussianWBTCBible(binaryReader.ReadString());
            info.SetSadriBible(binaryReader.ReadString());
            info.SetSanskritDevanagariBible(binaryReader.ReadString());
            info.SetSantaliBangladeshBible(binaryReader.ReadString());
            info.SetSantaliCommonBible(binaryReader.ReadString());
            info.SetSasakBible(binaryReader.ReadString());
            info.SetSena2014Bible(binaryReader.ReadString());
            info.SetSenaBible(binaryReader.ReadString());
            info.SetSenaMalawiBible(binaryReader.ReadString());
            info.SetSeraikiBible(binaryReader.ReadString());
            info.SetSerbianBible(binaryReader.ReadString());
            info.SetSerbianCNZBible(binaryReader.ReadString());
            info.SetSerbianERVBible(binaryReader.ReadString());
            info.SetSerbianLatinBible(binaryReader.ReadString());
            info.SetSerbianNSTBible(binaryReader.ReadString());
            info.SetSerbianNSTLBible(binaryReader.ReadString());
            info.SetSerbianSDSBible(binaryReader.ReadString());
            info.SetShanBible(binaryReader.ReadString());
            info.SetShanNCLBible(binaryReader.ReadString());
            info.SetShekhawatiBible(binaryReader.ReadString());
            info.SetShillukBible(binaryReader.ReadString());
            info.SetShona1949Bible(binaryReader.ReadString());
            info.SetShona2002Bible(binaryReader.ReadString());
            info.SetShonaBDSCBible(binaryReader.ReadString());
            info.SetShonaBible(binaryReader.ReadString());
            info.SetShonaSCLBBible(binaryReader.ReadString());
            info.SetShonaSUBBible(binaryReader.ReadString());
            info.SetSidamoBible(binaryReader.ReadString());
            info.SetSindhiBible(binaryReader.ReadString());
            info.SetSindhiCommonBible(binaryReader.ReadString());
            info.SetSindhiHinduBible(binaryReader.ReadString());
            info.SetSindhiMuslimBible(binaryReader.ReadString());
            info.SetSinhalaNRSVBible(binaryReader.ReadString());
            info.SetSinhalaSCVBible(binaryReader.ReadString());
            info.SetSinhalaSNRVBible(binaryReader.ReadString());
            info.SetSinhalaSROVBible(binaryReader.ReadString());
            info.SetSiswatiBible(binaryReader.ReadString());
            info.SetSlovakian2015Bible(binaryReader.ReadString());
            info.SetSlovakian2017Bible(binaryReader.ReadString());
            info.SetSlovakianBible(binaryReader.ReadString());
            info.SetSlovakianNPK2023Bible(binaryReader.ReadString());
            info.SetSlovakianNPKBible(binaryReader.ReadString());
            info.SetSlovakianRomaniBible(binaryReader.ReadString());
            info.SetSlovakianSEBBible(binaryReader.ReadString());
            info.SetSlovakianSLBBible(binaryReader.ReadString());
            info.SetSlovakianSSVBible(binaryReader.ReadString());
            info.SetSlovenian1584Bible(binaryReader.ReadString());
            info.SetSlovenian1882Bible(binaryReader.ReadString());
            info.SetSlovenian1928Bible(binaryReader.ReadString());
            info.SetSlovenian1990Bible(binaryReader.ReadString());
            info.SetSlovenian2014Bible(binaryReader.ReadString());
            info.SetSlovenianBible(binaryReader.ReadString());
            info.SetSlovenianEKUBible(binaryReader.ReadString());
            info.SetSlovenianSSPBible(binaryReader.ReadString());
            info.SetSogaBible(binaryReader.ReadString());
            info.SetSomalian2018Bible(binaryReader.ReadString());
            info.SetSomalian2024Bible(binaryReader.ReadString());
            info.SetSomalianBible(binaryReader.ReadString());
            info.SetSongeBible(binaryReader.ReadString());
            info.SetSotho1951Bible(binaryReader.ReadString());
            info.SetSotho1989Bible(binaryReader.ReadString());
            info.SetSotho2000Bible(binaryReader.ReadString());
            info.SetSothoBible(binaryReader.ReadString());
            info.SetSpanish1569Bible(binaryReader.ReadString());
            info.SetSpanish1858Bible(binaryReader.ReadString());
            info.SetSpanish1989Bible(binaryReader.ReadString());
            info.SetSpanishBDOBible(binaryReader.ReadString());
            info.SetSpanishBHTIBible(binaryReader.ReadString());
            info.SetSpanishBible(binaryReader.ReadString());
            info.SetSpanishBLPBible(binaryReader.ReadString());
            info.SetSpanishBLPHBible(binaryReader.ReadString());
            info.SetSpanishBTIBible(binaryReader.ReadString());
            info.SetSpanishBTXBible(binaryReader.ReadString());
            info.SetSpanishDHHBible(binaryReader.ReadString());
            info.SetSpanishJBSBible(binaryReader.ReadString());
            info.SetSpanishLBLABible(binaryReader.ReadString());
            info.SetSpanishNBLABible(binaryReader.ReadString());
            info.SetSpanishNBVBible(binaryReader.ReadString());
            info.SetSpanishNTBIZBible(binaryReader.ReadString());
            info.SetSpanishNTVBible(binaryReader.ReadString());
            info.SetSpanishNVIBible(binaryReader.ReadString());
            info.SetSpanishNVISBible(binaryReader.ReadString());
            info.SetSpanishPDTBible(binaryReader.ReadString());
            info.SetSpanishRevisedRVR1960Bible(binaryReader.ReadString());
            info.SetSpanishRV2020Bible(binaryReader.ReadString());
            info.SetSpanishRVA2015Bible(binaryReader.ReadString());
            info.SetSpanishRVCBible(binaryReader.ReadString());
            info.SetSpanishRVESBible(binaryReader.ReadString());
            info.SetSpanishRVGBible(binaryReader.ReadString());
            info.SetSpanishRVR1960Bible(binaryReader.ReadString());
            info.SetSpanishRVR1995Bible(binaryReader.ReadString());
            info.SetSpanishTLABible(binaryReader.ReadString());
            info.SetSpanishVBL2022Bible(binaryReader.ReadString());
            info.SetSpanishVBLBible(binaryReader.ReadString());
            info.SetSukuma1960Bible(binaryReader.ReadString());
            info.SetSukumaBible(binaryReader.ReadString());
            info.SetSundaneseBible(binaryReader.ReadString());
            info.SetSwahili1850Bible(binaryReader.ReadString());
            info.SetSwahili2001Bible(binaryReader.ReadString());
            info.SetSwahili2017Bible(binaryReader.ReadString());
            info.SetSwahili2024Bible(binaryReader.ReadString());
            info.SetSwahiliBHNTLKBible(binaryReader.ReadString());
            info.SetSwahiliBible(binaryReader.ReadString());
            info.SetSwahiliContemporaryBible(binaryReader.ReadString());
            info.SetSwahiliNMMBible(binaryReader.ReadString());
            info.SetSwahiliRSUVDCBible(binaryReader.ReadString());
            info.SetSwahiliSCLDC10Bible(binaryReader.ReadString());
            info.SetSwahiliSRB37Bible(binaryReader.ReadString());
            info.SetSwahiliSUVBible(binaryReader.ReadString());
            info.SetSwahiliSWC02Bible(binaryReader.ReadString());
            info.SetSwahiliSWZZB1921Bible(binaryReader.ReadString());
            info.SetSwedish1873Bible(binaryReader.ReadString());
            info.SetSwedish2000Bible(binaryReader.ReadString());
            info.SetSwedish2015Bible(binaryReader.ReadString());
            info.SetSwedish2019Bible(binaryReader.ReadString());
            info.SetSwedishBible(binaryReader.ReadString());
            info.SetSwedishFolkBible(binaryReader.ReadString());
            info.SetSwedishNLBBible(binaryReader.ReadString());
            info.SetSwedishSB2016Bible(binaryReader.ReadString());
            info.SetSwedishSFBBible(binaryReader.ReadString());
            info.SetSylhetiBible(binaryReader.ReadString());
            info.SetSylhetiSYLLBible(binaryReader.ReadString());
            info.SetTagalog2001Bible(binaryReader.ReadString());
            info.SetTagalog2005Bible(binaryReader.ReadString());
            info.SetTagalog2012Bible(binaryReader.ReadString());
            info.SetTagalog2015Bible(binaryReader.ReadString());
            info.SetTagalogBible(binaryReader.ReadString());
            info.SetTagalogRevised2005Bible(binaryReader.ReadString());
            info.SetTagalogTLBABible(binaryReader.ReadString());
            info.SetTajik1992Bible(binaryReader.ReadString());
            info.SetTajikKMOBible(binaryReader.ReadString());
            info.SetTajikNTBible(binaryReader.ReadString());
            info.SetTamasheqBible(binaryReader.ReadString());
            info.SetTamil2017Bible(binaryReader.ReadString());
            info.SetTamilBible(binaryReader.ReadString());
            info.SetTamilIRVBible(binaryReader.ReadString());
            info.SetTamilRomanisedBible(binaryReader.ReadString());
            info.SetTamilTCVBible(binaryReader.ReadString());
            info.SetTamilTRVBible(binaryReader.ReadString());
            info.SetTamilWBTCBible(binaryReader.ReadString());
            info.SetTarifitBible(binaryReader.ReadString());
            info.SetTashelhaytMoroccoBible(binaryReader.ReadString());
            info.SetTatar2001Bible(binaryReader.ReadString());
            info.SetTatar2015Bible(binaryReader.ReadString());
            info.SetTatar2025Bible(binaryReader.ReadString());
            info.SetTatarRBBLBible(binaryReader.ReadString());
            info.SetTelugu2016Bible(binaryReader.ReadString());
            info.SetTelugu2019Bible(binaryReader.ReadString());
            info.SetTeluguBible(binaryReader.ReadString());
            info.SetTeluguTCVBible(binaryReader.ReadString());
            info.SetTeluguWBTCBible(binaryReader.ReadString());
            info.SetTeso2020Bible(binaryReader.ReadString());
            info.SetTesoBible(binaryReader.ReadString());
            info.SetThadoBible(binaryReader.ReadString());
            info.SetThai1940Bible(binaryReader.ReadString());
            info.SetThai1971Bible(binaryReader.ReadString());
            info.SetThaiBible(binaryReader.ReadString());
            info.SetThaiERVBible(binaryReader.ReadString());
            info.SetThaiKJVBible(binaryReader.ReadString());
            info.SetThaiNTVBible(binaryReader.ReadString());
            info.SetThaiTCVBible(binaryReader.ReadString());
            info.SetThaiTHSBible(binaryReader.ReadString());
            info.SetThaiTNCVBible(binaryReader.ReadString());
            info.SetTibetianBible(binaryReader.ReadString());
            info.SetTibetianCBTBible(binaryReader.ReadString());
            info.SetTivBible(binaryReader.ReadString());
            info.SetTshiluba1996Bible(binaryReader.ReadString());
            info.SetTshiluba2003Bible(binaryReader.ReadString());
            info.SetTshivendaBible(binaryReader.ReadString());
            info.SetTsonga1989Bible(binaryReader.ReadString());
            info.SetTsonga2014Bible(binaryReader.ReadString());
            info.SetTsonga2024Bible(binaryReader.ReadString());
            info.SetTsongaBible(binaryReader.ReadString());
            info.SetTswana1890Bible(binaryReader.ReadString());
            info.SetTswana1970Bible(binaryReader.ReadString());
            info.SetTswana1993Bible(binaryReader.ReadString());
            info.SetTswana2024Bible(binaryReader.ReadString());
            info.SetTswanaBible(binaryReader.ReadString());
            info.SetTuluBible(binaryReader.ReadString());
            info.SetTurkanaBible(binaryReader.ReadString());
            info.SetTurkishBible(binaryReader.ReadString());
            info.SetTurkishHADIBible(binaryReader.ReadString());
            info.SetTurkishKKDEUBible(binaryReader.ReadString());
            info.SetTurkishKMEYABible(binaryReader.ReadString());
            info.SetTurkishNTBBible(binaryReader.ReadString());
            info.SetTurkishTKKBible(binaryReader.ReadString());
            info.SetTurkishTTTBible(binaryReader.ReadString());
            info.SetTurkishYTCBible(binaryReader.ReadString());
            info.SetTurkmen2016Bible(binaryReader.ReadString());
            info.SetTurkmenCyrillic2002Bible(binaryReader.ReadString());
            info.SetTurkmenLatin2002Bible(binaryReader.ReadString());
            info.SetTurkmenLatin2017Bible(binaryReader.ReadString());
            info.SetTwiAkuapemBible(binaryReader.ReadString());
            info.SetTwiAsanteBible(binaryReader.ReadString());
            info.SetTwiDCBible(binaryReader.ReadString());
            info.SetTwiKronkronBible(binaryReader.ReadString());
            info.SetTwiRevisedBible(binaryReader.ReadString());
            info.SetUkrainian1903Bible(binaryReader.ReadString());
            info.SetUkrainian1905Bible(binaryReader.ReadString());
            info.SetUkrainian2004Bible(binaryReader.ReadString());
            info.SetUkrainian2006Bible(binaryReader.ReadString());
            info.SetUkrainian2011Bible(binaryReader.ReadString());
            info.SetUkrainian2021Bible(binaryReader.ReadString());
            info.SetUkrainian2022Bible(binaryReader.ReadString());
            info.SetUkrainianBible(binaryReader.ReadString());
            info.SetUkrainianHOMBible(binaryReader.ReadString());
            info.SetUkrainianTUBBible(binaryReader.ReadString());
            info.SetUkrainianUKDERBible(binaryReader.ReadString());
            info.SetUkrainianUMTBible(binaryReader.ReadString());
            info.SetUmbunduBible(binaryReader.ReadString());
            info.SetUrdu2017Bible(binaryReader.ReadString());
            info.SetUrduBible(binaryReader.ReadString());
            info.SetUrduDGVBible(binaryReader.ReadString());
            info.SetUrduGVRBible(binaryReader.ReadString());
            info.SetUrduIRVURDBible(binaryReader.ReadString());
            info.SetUrduUCVBible(binaryReader.ReadString());
            info.SetUrduUCVDBible(binaryReader.ReadString());
            info.SetUrduUGVBible(binaryReader.ReadString());
            info.SetUrduURDBible(binaryReader.ReadString());
            info.SetUrduURDGVHBible(binaryReader.ReadString());
            info.SetUrduURDR55Bible(binaryReader.ReadString());
            info.SetUyghurArabicBible(binaryReader.ReadString());
            info.SetUyghurCyrillicBible(binaryReader.ReadString());
            info.SetUyghurLatinBible(binaryReader.ReadString());
            info.SetUzbekUZBBible(binaryReader.ReadString());
            info.SetUzbekUZCBible(binaryReader.ReadString());
            info.SetUzbekUZLBCBible(binaryReader.ReadString());
            info.SetVietnamese1994Bible(binaryReader.ReadString());
            info.SetVietnamese2011Bible(binaryReader.ReadString());
            info.SetVietnamese2015Bible(binaryReader.ReadString());
            info.SetVietnameseBible(binaryReader.ReadString());
            info.SetVietnameseERVBible(binaryReader.ReadString());
            info.SetVietnameseNVBBible(binaryReader.ReadString());
            info.SetVietnameseVIEBible(binaryReader.ReadString());
            info.SetWarayBible(binaryReader.ReadString());
            info.SetWelsh1894Bible(binaryReader.ReadString());
            info.SetWelsh1945Bible(binaryReader.ReadString());
            info.SetWelsh2015Bible(binaryReader.ReadString());
            info.SetWelshBible(binaryReader.ReadString());
            info.SetWelshBMWBible(binaryReader.ReadString());
            info.SetWelshCTEBible(binaryReader.ReadString());
            info.SetWelshSBYBible(binaryReader.ReadString());
            info.SetWolayttaBible(binaryReader.ReadString());
            info.SetWolofBible(binaryReader.ReadString());
            info.SetWolofKYGBible(binaryReader.ReadString());
            info.SetXhosa1920Bible(binaryReader.ReadString());
            info.SetXhosa1996Bible(binaryReader.ReadString());
            info.SetXhosa2022Bible(binaryReader.ReadString());
            info.SetXhosaBible(binaryReader.ReadString());
            info.SetYoruba2010Bible(binaryReader.ReadString());
            info.SetYoruba2014Bible(binaryReader.ReadString());
            info.SetYorubaBible(binaryReader.ReadString());
            info.SetZandeBible(binaryReader.ReadString());
            info.SetZarmaBible(binaryReader.ReadString());
            info.SetZulu2020Bible(binaryReader.ReadString());
            info.SetZulu2023Bible(binaryReader.ReadString());
            info.SetZuluBible(binaryReader.ReadString());

            Table.Add(key, info);
        }
    }
}

public class PlayerTable
{
    private static Dictionary<string, PlayerInfo> Table = new Dictionary<string, PlayerInfo>();

    public static Dictionary<string, PlayerInfo> GetAll()
    {
        return Table;
    }

    public static PlayerInfo GetByKey(string key)
    {
        PlayerInfo value;

        if (Table.TryGetValue(key, out value))
            return value;

        return null;
    }

    public static PlayerInfo GetByIndex(int index)
    {
        return Table.Values.ElementAt(index);
    }

    public static List<PlayerInfo> GetAllList()
    {
        return Table.Values.ToList();
    }

    public PlayerTable()
    {
        InitTable();
    }

    private void InitTable()
    {
        TextAsset textAsset = Resources.Load("Tables/Player") as TextAsset;
        MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
        BinaryReader binaryReader = new BinaryReader(memoryStream);

        int tableCount = binaryReader.ReadInt32();

        for( int i = 0; i < tableCount; ++i)
        {
            string key = binaryReader.ReadString();

            PlayerInfo info = new PlayerInfo();
            info.SetID(binaryReader.ReadString());
            info.SetContent(binaryReader.ReadString());
            info.SetAddress(binaryReader.ReadString());
            info.SetETC(binaryReader.ReadString());

            Table.Add(key, info);
        }
    }
}

public class TestimonyTable
{
    private static Dictionary<string, TestimonyInfo> Table = new Dictionary<string, TestimonyInfo>();

    public static Dictionary<string, TestimonyInfo> GetAll()
    {
        return Table;
    }

    public static TestimonyInfo GetByKey(string key)
    {
        TestimonyInfo value;

        if (Table.TryGetValue(key, out value))
            return value;

        return null;
    }

    public static TestimonyInfo GetByIndex(int index)
    {
        return Table.Values.ElementAt(index);
    }

    public static List<TestimonyInfo> GetAllList()
    {
        return Table.Values.ToList();
    }

    public TestimonyTable()
    {
        InitTable();
    }

    private void InitTable()
    {
        TextAsset textAsset = Resources.Load("Tables/Testimony") as TextAsset;
        MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
        BinaryReader binaryReader = new BinaryReader(memoryStream);

        int tableCount = binaryReader.ReadInt32();

        for( int i = 0; i < tableCount; ++i)
        {
            string key = binaryReader.ReadString();

            TestimonyInfo info = new TestimonyInfo();
            info.SetID(binaryReader.ReadString());
            info.SetContent(binaryReader.ReadString());
            info.SetAddress(binaryReader.ReadString());
            info.SetConfirm(binaryReader.ReadString());
            info.SetETC(binaryReader.ReadString());

            Table.Add(key, info);
        }
    }
}

public class WiseSayingTable
{
    private static Dictionary<int, WiseSayingInfo> Table = new Dictionary<int, WiseSayingInfo>();

    public static Dictionary<int, WiseSayingInfo> GetAll()
    {
        return Table;
    }

    public static WiseSayingInfo GetByKey(int key)
    {
        WiseSayingInfo value;

        if (Table.TryGetValue(key, out value))
            return value;

        return null;
    }

    public static WiseSayingInfo GetByIndex(int index)
    {
        return Table.Values.ElementAt(index);
    }

    public static List<WiseSayingInfo> GetAllList()
    {
        return Table.Values.ToList();
    }

    public WiseSayingTable()
    {
        InitTable();
    }

    private void InitTable()
    {
        TextAsset textAsset = Resources.Load("Tables/WiseSaying") as TextAsset;
        MemoryStream memoryStream = new MemoryStream(textAsset.bytes);
        BinaryReader binaryReader = new BinaryReader(memoryStream);

        int tableCount = binaryReader.ReadInt32();

        for( int i = 0; i < tableCount; ++i)
        {
            int key = binaryReader.ReadInt32();

            WiseSayingInfo info = new WiseSayingInfo();
            info.SetID(binaryReader.ReadInt32());
            info.SetKorean(binaryReader.ReadString());
            info.SetEnglish(binaryReader.ReadString());

            Table.Add(key, info);
        }
    }
}


public class Tables : MonoBehaviour
{
    public BibleEachTable BibleEach = null;
    public BibleNationTable BibleNation = null;
    public BibleTypeTable BibleType = null;
    public BibleWiseTable BibleWise = null;
    public CustomizeTable Customize = null;
    public NewTestamentTable NewTestament = null;
    public OldTestamentTable OldTestament = null;
    public PlayerTable Player = null;
    public TestimonyTable Testimony = null;
    public WiseSayingTable WiseSaying = null;

    private static Tables instance = null;

    public static Tables Instance
    {
        get { return instance; }
    }

    void Awake() 
    {
        if (instance == null)
        {
            instance = this;

            BibleEach = new BibleEachTable();
            BibleNation = new BibleNationTable();
            BibleType = new BibleTypeTable();
            BibleWise = new BibleWiseTable();
            Customize = new CustomizeTable();
            NewTestament = new NewTestamentTable();
            OldTestament = new OldTestamentTable();
            Player = new PlayerTable();
            Testimony = new TestimonyTable();
            WiseSaying = new WiseSayingTable();
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
    }
}

