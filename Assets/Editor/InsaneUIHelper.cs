using Codice.CM.Client.Differences;
using NUnit.Framework;
using OfficeOpenXml.FormulaParsing.Excel.Functions.Numeric;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using static Unity.VisualScripting.Member;
using static UnityEngine.UI.Image;

/**



 
*/


/**
string

Matthew_
Mark_
Luke_
John_
Acts_
Romans_
1Corinthians_
2Corinthians_
Galatians_
Ephesians_
Philippians_
Colossians_
1Thessalonians_
2Thessalonians_
1Timothy_
2Timothy_
Titus_
Philemon_
Hebrews_
James_
1Peter_
2Peter_
1John_
2John_
3John_
Jude_
Revelation_
 
*/

/**
string

Genesis_
Exodus_
Leviticus_
Numbers_
Deuteronomy_
Joshua_
Judges_
Ruth_
1Samuel_
2Samuel_
1Kings_
2Kings_
1Chronicles_
2Chronicles_
Ezra_
Nehemiah_
Esther_
Job_
Psalms_
Proverbs_
Ecclesiastes_
SongOfSongs_
Isaiah_
Jeremiah_
Lamentations_
Ezekiel_
Daniel_
Hosea_
Joel_
Amos_
Obadiah_
Jonah_
Micah_
Nahum_
Habakkuk_
Zephaniah_
Haggai_
Zechariah_
Malachi_
 
 */

/**
아체(Aceh)는 인도네시아 수마트라섬의 가장 북서쪽 끝에 위치한 특별자치주
AcehBible (Aceh Language (Alkitab HABA GET))    

아딜라바드(Adilabad)는 인도 텔랑가나(Telangana) 주 북부에 위치한 도시
AdilabadGondiBible (Adilabad Gondi (ఆదిలాబాద్ గోండి పూన నియమ్))   

아프리칸스어(Afrikaans)는 주로 남아프리카 공화국과 나미비아에서 사용되는 서게르만어군 언어
Afrikaans1983Bible (Afrikaans 1983)     
Afrikaans2020Bible (Afrikaans 2020 (Die Bybel 2020-vertaling))
Afrikaans2023Bible (Afrikaans (Contemporary Afrikaans Bible 2023))
AfrikaansABABible (Afrikaans Bible (ABA) 2007 (Bybel vir almal))
AfrikaansBible (Afrikaans 1933, 1953)
AfrikaansDBBible (Afrikaans DB 2006 (Die Boodskap))
AfrikaansNLVBible (Afrikaans (NLV) 2011)

아히라니(Ahirani)어는 주로 인도 마하라슈트라(Maharashtra)주 북부 칸데시(Khandesh) 지역에서 사용되는 언어/방언
AhiraniBible (Ahirani (आहिराणी नवा करार))        

알바니아(Albania)는 유럽 동남부 발칸반도 서북부, 아드리아해와 이오니아해에 접한 국가
Albanian1872Bible (Albanian 1872 (Dhiata e Re Gegnisht Konstandin Kristoforidhi 1872))      
Albanian1879Bible (Albanian DERKK79 (Dhiata e Re Konstantin Kristoferidhi 1879))
Albanian2018Bible (Albania (Shqip Së Bashku 2020))
AlbanianALTMK27Bible (Albanian (Dhjata e Re 1827))
AlbanianBible (Albanian (Bibla Shqip 1994))

암하라어(Amharic)는 주로 에티오피아에서 사용되는 공용어
Amharic2000Bible (Amharic 2000 (የአማርኛ መጽሐፍ ቅዱስ (ሰማንያ አሃዱ)))     
AmharicBible (Amharic Bible (መጽሐፍ ቅዱስ (የብሉይና የሐዲስ ኪዳን መጻሕፍት)))
AmharicCatholicBible (Amharic Catholic Version (መጽሐፍ ቅዱስ - (ካቶሊካዊ እትም - ኤማሁስ)))
AmharicDawroBible (Amharic Dawro (Ooratha Caaquwaa))
AmharicDawroDFBEBible (Amharic Dawro DFBE (ጌሻ ማጻፋ))
AmharicDawroDFBLVLBible (Amharic Dawro DFBLVL (Geeshsha Mas'aafaa))
AmharicDawroDWRNTBible (Amharic Dawro DWRNT (Ooratha Caaquwaa))
AmharicDawroWWIBible (Amharic Dawro New Testament (The Word for the World International))
AmharicGamo2017Bible (Amharic Gamo 2017 (Gamo Geesha Maxxafa New Testamen))
AmharicGamoBible Amharic Gamo 2011 New Testament)
AmharicGamoGMBible (Amharic Gamo (Geeshsha Maxaafa))
AmharicGamoWordBible (Amharic Gamo (ጋሞ ማጻፋ))
AmharicGofaBible (Amharic Gofa 2011 (ኦራ ጫቁዋ ጎፋ))
AmharicGofaGFBEVFBible (Amharic Gofa GFBEVF (ጌሻ ማፃፋ))
AmharicGofaGFBLVFBible (Amharic Gofa GFBLVF (Geeshsha Maxaafa))
AmharicGofaRNTBible (Amharic Gofa RNT 2011 (Ooratha Caaquwa Goofatho))
AmharicGofaWWIBible (Amharic Gofa 2011 (The Word For The World International) (Gofa New Testament))
AmharicNASVBible (Amharic NASV (አዲሱ መደበኛ ትርጒም))
AmharicNSTBible (Amharic New Standard Translation (አማርኛ አዲሱ መደበኛ ትርጉም) 2005)
AmharicTigrinya15Bible (Amharic Tigrinya (መፅሓፍ ቅዱስ))
AmharicTigrinya2024Bible (Amharic (Tigrigna Contemporary Tigrinya Bible 2024))
AmharicTigrinyaBible (Amharic Tigrinya 2011)

아랍(Arabic) 지역은 주로 서아시아(아라비아 반도)와 북아프리카에 위치한 22개 아랍연맹 회원국들을 가리키며, 아랍어를 공용어로 사용하는 중동 중심의 국가들
Arabic1978Bible (Arabic 1978 (APD) (Kitaab al Vahd aj Jadid 1978))      
Arabic2016Bible (Arabic 2016 (الكِتاب المُقَدَّس التَّرْجَمَةُ العَرَبِيَّةُ المُبَسَّطَةُ))
Arabic2018Bible (Arabic 2018 (الترجمة الكاثوليكيّة (اليسوعيّة)))
Arabic2023Bible (Arabic 2023 (SAB) (الكتاب الشريف))
ArabicAlgeriaBible (Arabic Algerian (العهد الجديد باللهجة الجزائرية))
ArabicAPDBible (Arabic APD 2024 (كِتاب العَهد الجَّديد مِن الكِتاب المُقَدَّس))
ArabicAVDBible (Arabic Bible AVD 1999)
ArabicAVDDVBible (Arabic Bible AVDDV 1999)
ArabicBible (Arabic KEH Ketab El Hayat (كتاب الحياة))
ArabicERVBible (Arabic Bible ERV 2009)
ArabicGNABible (Arabic Bible (GNA) Good News Arabic - 1993 (الترجمة العربية المشتركة))
ArabicGOVBible (Arabic GOV (الكتاب المقدس العهد الجديد، النسخة الارثوذكسية القدس))
ArabicLABible (Arabic Bible Live (Targamet El Hayah) (LA))
ArabicLebaneseBible (Arabic Lebanese (bil 3arabe App))
ArabicMorocco2023Bible (Arabic Moroccan (Northern Mor NT))
ArabicMoroccoBible (Arabic Bible Morocco Version - 2012)
ArabicSABBible (Arabic SAB (الكتاب الشريف))
ArabicSABible (Arabic Simplified (الكِتاب المُقَدَّس التَّرْجَمَةُ العَرَبِيَّةُ المُبَسَّطَةُ))
ArabicSVDBible (Arabic SVD 1865 Version)
ArabicTMABible (Arabic TMA 2021 (المعنى الصحيح لإنجيل المسيح))
ArabicTU2022Bible (Arabic TU2022 (العهد الجديد بالدارجة التونسية))
ArabicTunisianBible (Arabic Bible (Tunisian) (Tunisian Arabic Version) 2018)

아람어(Aramaic)는 기원전 10세기경부터 고대 근동(현재의 시리아, 이라크, 튀르키예, 레바논 지역)에서 주로 사용된 셈어파 언어
AramaicBible(Aramaic Peshitta)      

아르메니아(Armenia)는 서아시아의 남캅카스 지역에 위치한 내륙국
Armenian1853Bible (Armenian 1853 (Western Armenian Bible 1853))     
Armenian2017Bible (Armenian 2017 (Արեւմտահայերէն Նոր Կտակարան, հարմարցուած․ 2017))
Armenian2018Bible (Armenian 2018 (Նոր վերանայված Արարատ Աստվածաշունչ))
Armenian2019Bible (Armenian 2019 (Western Armenian New Translation - Armenian Catholicosate of Cilicia - New Testament))
ArmenianAraratBible (Armenian Ararat 1896 (Արարատ Թարգմանություն))
ArmenianBible (Armenian Western NT 1994)
ArmenianEasternBible (Armenian Eastern Bible 1994)
ArmenianNEABible (Armenian NEA (Նոր Էջմիածին Աստվածաշունչ))

아삼어(Assamese)는 주로 인도 북동부의 아삼(Assam) 주에서 사용되는 언어
AssameseBible (Assamese - 2019 (ইণ্ডিয়ান ৰিভাইচ ভাৰচন (IRV) আচামিচ - 2019))     

'아바르(Avar)'족은 6~9세기경 유럽 동중부(판노니아 평원)를 지배했던 유목 민족을 뜻하며, 현재의 캅카스 지역에 사는 민족과는 다른 집단
AvarBible (Avar Инжил Магӏарул [Avaric])        

Awadhi(아와디어/아와드 지역)는 주로 인도 북부 우타르프라데시(Uttar Pradesh)주 중심부에 위치한 역사적인 지역
AwadhiBible (Awadhi ERV (पवित्तर बाइबिल))       

아이마라(Aymara)족은 남아메리카 안데스 산맥의 볼리비아, 페루, 칠레, 아르헨티나 북서부에 걸쳐 거주하는 토착민입니다
Aymara1986Bible (Aymara Bible 1986 (Aymar Bibliia 1986))        
Aymara1997Bible (Aymara 1997 (Qullan Arunaka DC))
AymaraBible (Ayamar Bible (Qullan Arunaca))

아제르바이잔(Azerbaijan)은 서아시아와 동유럽의 경계인 코카서스 지역(카스피해 연안)에 위치한 내륙국입니다.
Azerbaijan2013Bible (Azerbaijan 2013 (موقدس کتاب))      
AzerbaijanBible (Azerbajani (Azərbaycan Bibliyası 2008))
AzerbaijanSouthBible (Azerbajani Bible (South) Used in Both Iran and Azerbaijan 2008)

'Bagri(바그리)'는 주로 인도 북서부의 바가르(Bagar) 지역에서 사용되는 인도-아리안 언어(라자스탄어의 일종)를 말하며, 해당 지역에 거주하는 공동체를 지칭하기도 합니다
BagriBible (Bagri Bible)        

발리(Balinese)는 인도네시아(Indonesia)의 섬이자 주(Province)로, 동남아시아에 위치해 있습니다.
BalineseBible (Balinese (Cakepan Suci))     

발루치어(Balochi)는 주로 파키스탄의 발루치스탄 주를 중심으로, 인접한 이란의 시스탄-발루체스탄주 및 아프가니스탄 남부 지역에 거주하는 발루치족이 사용하는 언어입니다.
BalochiArabicBible (Balochi Arabic (هُدائے پاکێن کتاب، بلۆچی زبانا))     
BalochiBible (Balochi (Hodáay Pákén Ketáb, Balochi zobáná))
BalochiSoutherenBible (Balochi Southern (هُدائے پاکێن کتاب، بلۆچی زبانا))
BalochiSoutherenLatinBible (Balochi, Southern Latin (Hodáay Pákén Ketáb, Balochi zobáná))

바울레(Baoulé)족은 서아프리카 코트디부아르의 중부 지역에 주로 거주하는 가장 큰 민족 그룹입니다. 
Baoule1974Bible (Baoule (Nyanmien nde Ufle) 1974)       
Baoule1998Bible (Baoule (NYANMIƐN NDƐ'N 1998))
BaouleBible (Baoule Bible 1996 (Kuo Dele'))

바시키르(Bashkir)는 주로 러시아 연방 내 바시코르토스탄 공화국(Republic of Bashkortostan)에 거주하는 튀르크계 토착 민족입니다.
Bashkir2023Bible (Bashkir 2023 (Изге Яҙма))     
BashkirBible (Bashkir 2014 - Инжил Башҡортча)

바스크(Basque) 지방은 스페인 북부와 프랑스 남서부 국경, 비스케이 만 연안의 피레네 산맥 일대에 위치한 지역입니다. 
BasqueBible (Basque (Navarro-Labourdin Basque))
Basque2008Bible (Basque (EAB) 2008 (Elizen Arteko Biblia (Biblia en Euskara, Traducción Interconfesional)))     

바이에른(Bavaria, 독일어: Bayern)은 독일 남동부에 위치한 주입니다
BavarianBible (Bavarian Bible 1998 (De Bibl auf Bairisch))      

벨라루스(Belarus)는 동유럽에 위치한 내륙국입니다.
Belarusian2017Bible (Belarusian 2017 (Біблія — пераклад Чарняўскага (Выданне 2017 Года)))       
BelarusianBible (Belarusian (Пераклад В. Сёмухі))
BelarusianBokunBible (Belarusian Bokun (Пераклад А.Бокуна))
BelarusianCHNTBible (Belarusian Bible (CHNT) 1999)
BelarusianNTJSBible (Belarusian Bible Maley (© 1931, 1948; у 1985, 1991 унесены праўкі))

\벰바족(Bemba)은 주로 잠비아(Zambia) 북동부 고원 지대에 거주하는 반투계 민족입니다
BembaBible (Bemba (Ishiwi Lyakwa Lesa 2015))    

벵골어(Bengali, বাংলা)는 주로 방글라데시와 인도 서벵골주에서 사용되는 언어입니다.
Bengali2017Bible (Bengali 2017 (বাঙালি বাইবেল))      
Bengali2023Bible (Bengali 2023 (পবিত্র বাইবেল (কেরী ভার্সন)))
BengaliBACIBBible (Bengali (BACIB) 2013 (কিতাবুল মোকাদ্দস))
BengaliBCVBible (Bengali (BCV) (বাংলা সমকালীন সংস্করণ))
BengaliBible (Bengali (World Bible Translation Center) (WBTC))
BengaliBSIBible (Bengali (BSI) 2016 O.V. Bible, পবিএ বাইবেল O.V)
BengaliCLBSIBible (Bengali CL BSI 2016 (পবিএ বাইবেল CL Bible (BSI)))
BengaliERVBible (Bengali ERV 2001 (পবিত্র বাইবেল))
BengaliIRVBENBible (Bengali IRV (ইন্ডিয়ান রিভাইজড ভার্সন (IRV) - বেঙ্গলী))
BengaliMBCLBible (Bengali Bangladesh MBCL (Kitabul Mukkadas))
BengaliSBCLBible (Bengali Bangladesh 2000 SBCL (Pobitro Baibel))

베르베르족(Berber)은 주로 모로코, 알제리, 튀니지, 리비아 등 북아프리카 마그레브 지역과 사하라 사막 근처에 거주하는 원주민입니다. 
BerberBible (Berber = Morocco and Algeria - Tachelheit Bible (RBD) (aåaras n-tudrt - injil l-lmasiæ - løhd l-ljdid lli-iskr rbbi å-gras d-bnadm))   

Bhilali(빌랄리)는 주로 인도 서부 및 중부 지역에 위치한 마하라슈트라(Maharashtra)주 잘가온(Jalgaon) 지구에 위치한 마을입니다
BhilaliBible (Bhilali (भगवानेन छाचला बुल))   

보되(Bodø)는 노르웨이 북부에 위치한 도시로, 로포텐 제도(Lofoten Islands)로 향하는 항구와 공항을 갖춘 북극권 관문입니다. 
BodoBible (Bodo BDVNT (ବ୍‌ଡ଼୍ ହ୍‌ର୍‌ଜା ବାଇବଲ))     
BodoNTBPL20Bible (Bodo NTBPL20 (ସଃର୍ଗାର୍‌ ବାଟ୍‌ ନଃଉଁଆ ନିଅମ୍‌))

보스니아 헤르체고비나(Bosnia and Herzegovina)는 유럽 동남부 발칸반도에 위치한 국가입니다. 
BosnianBible (Bosnian (Biblija, Stari i Novi Zavjet))       

브라즈(Braj, 또는 Vraj, Brij)는 인도 북부 우타르프라데시(Uttar Pradesh) 주에 위치한 지역으로, 
BrajBible (Braj (बृज भासा))    

싱가포르의 부기스(Bugis)는 싱가포르 중심부, 다운타운 코어(Downtown Core) 내의 아랍 및 무슬림 지역에 위치해 있습니다
BugisBible (Bugis (KITTA KAREBA MADECENG))      

불가리아(Bulgaria)는 유럽 동남부, 발칸반도 동쪽에 위치한 나라입니다.
Bulgarian2015Bible (Bulgarian 2015 (Библия, Ревизирано Издание))    
BulgarianBible (Bulgarian 1940 (Ревизиран))
BulgarianBOBBible (Bulgarian (Библия, Синодално Издание (1982 г.)))
BulgarianBPBBible (Bulgarian (Библейска лига - Ревизия 2001))
BulgarianCBTBible (Bulgarian CBT (Съвременен български превод (с DC books) 2013))
BulgarianSPBBible (Bulgarian (SPB) 2000 (Новият Завет Съвременен Превод))
BulgarianTZABible (Bulgarian (TZA) (Цариградски))
BulgarianVerensBible (Bulgarian Veren's (Верен) Contemporary 1871)

Bundeli ( Devaanagari : Bundelkhandi) 또는 Bundelkhandi 는 인도 중부 Bundelkhand 지역에서 사용되는 인도-아리아어 입니다
BundeliBible (Bundeli 2018 (Bundeli Holy Bible))        

버마어(Burmese)는 미얀마(Myanmar)의 공식 언어로, 해당 국가의 주류 민족인 버마족의 언어입니다
Burmese1928Bible (Burmese Myanmar 1928 (Garrad Bible))      
Burmese2021Bible (Burmese Myanmar (Judson Bible))
BurmeseBCLBible (Burmese (BCL) (Common Language Bible))
BurmeseBible (Burmese 1835 Version Judson)
BurmeseJBZVBible (Burmese Myanmar (Judson Bible in Zawgyi Version))
BurmeseMCLZVBible (Burmese Myanmar MCLZV (Myanmar Common Language Zawgyi Version))
BurmeseMSBUBible (Burmese MSBU Myanmar (မြန်​​​မာ့​​​စံ​​​မီ​​​သမ္မာ​​​ကျမ်း​​))
BurmeseMSBZBible (Burmese Myanmar MSBZ (ျမန္​မာ့​စံ​မီ​သမၼာ​က်မ္))

카탈루냐(Catalan/Catalonia)는 스페인(Spain) 북동부에 위치한 자치 지방입니다. 
CatalanBCIBible (Catalan (BCI) 2008 - (Bíblia Catalana, Traducción Interconfesional))   
CatalanBECBible (Catalan (BEC) 2000 (Bíblia Evangèlica Catalana))

세부아노어(Cebuano)는 필리핀 중남부 비사야(Visayas) 지방과 민다나오(Mindanao) 섬에서 주로 사용되는 언어입니다.
Cebuano1999Bible (Cebuano 1999 (Maayong Balita Biblia))     
Cebuano2011Bible (Cebuano 2011 (Ang Biblia, 2011))
CebuanoAPSDBible (Cebuano APSD (Ang Pulong sa Dios))
CebuanoBible (Cebuano CBV)
CebuanoRCPVBible (Cebuano RCPV 1999 (Ang Bag-ong Maayong Balita Biblia))

체첸(Chechnya, 공식 명칭: 체첸 공화국)은 러시아 연방의 구성 공화국 중 하나입니다
ChechenBible (Chechen 2012 (Делан Йозанаш))     

체와족(Chewa)은 주로 남동부 아프리카 지역에 거주하는 반투계 민족입니다
Chewa1992Bible (Chewa Bible (BL) 1992 - Buku Lopatulika)    
Chewa2014Bible (Chewa 1922 (Buku Lopatulika))
Chewa2016Bible (Chewa 2002 (Mawu a Mulungu mu Chichewa Chalero))
ChewaBLYDCBible (Chewa (Buku Loyera Catholic Edition - Chichewa))

차티스가르어(Chhattisgarhi)는 주로 인도 중부에 위치한 차티스가르(Chhattisgarh)주에서 사용되는 언어입니다
ChhattisgarhiBible (Chhattisgarhi (नवां नियम छत्तीसगढ़ी) 2012)     

Chibemba(벰바어)는 주로 잠비아(Zambia) 북동부 지역에서 사용되는 반투어군 언어입니다.
ChibembaBible (Chibemba (Ishiwi Lyakwa Lesa 2015))      

'Dai Cangcim Kthai'는 미얀마 친주(Chin State)의 다아이(Daai) 친족(Daai Chin)이 사용하는 언어
Chin2010Bible (Chin 2010)
ChinBSIBible (Chin (Mara Bible RV (BSI)))
ChinCSHBible (Chin (Khyang NT))
ChinDNTBible (Chin (Dai Cangcim Kthai))     

중국어
Chinese1886Bible (Chinese Bible 1886 (Traditional) (楊格非官話《新約全書》))       
Chinese1919Bible (Chinese Bible 1919 (Traditional) (文理和合譯本《新舊約全書》))
Chinese1927Bible (Chinese Bible 1927 (Traditional) (文理《委辦譯本》))
Chinese1933Bible (Chinese Bible 1933 (Traditional) (王元德《新式標點新約全書》)
Chinese1941Bible (Chinese Bible 1941 (Traditional) (亨理－鄭壽麟《國語新舊庫譯本－新約全書》))
Chinese1967Bible (Chinese Bible 1967 (Traditional) (蕭鐵笛《新譯新約全書》))
ChineseCCBSBible (Chinese (Simplified) Contemporary Bible (CCB Bible) (圣经当代译本修订版))
ChineseCCBTBible (Chinese Bible CCB (Traditional))
ChineseCSBSBible (Chinese Bible CSBS (Simplified) - (中文标准译本))
ChineseCSBTBible (Chinese Bible CSBT (Traditional) - (中文標準譯本))
ChineseCUNPSSBible (Chinese Bible CUNPSS (Simplified) (新标点和合本, 上帝版))
ChineseCUNPSTBible (Chinese Bible (Traditional) (CUNPST))
ChineseNankingBible (Chinese Bible Nanking (Traditional) (南京官話《新約全書》))
ChinesePekingBible (Chinese Bible (Peking) (Traditional) (北京官話譯本))
ChineseRCUVSSBible (Chinese Bible RCUVSS (Simplified) (和合本修订版))
ChineseRCUVTBible (Chinese Bible RCUV (Traditional) (和合本修訂版))
ChineseSimplifiedBible (Chinese Simplified CUNPSS Script Union (新标点和合本, 神版))
ChineseSimplifiedNewBible (Chinese Bible - (Simplified) (新译本) CNVS)
ChineseTCV2019TBible (Chinese Bible TCV2019T (Traditional) (《現代中文譯本2019－－繁體版》))
ChineseTHV2012Bible (Chinese Bible TNV 2012 (Traditional) (客語聖經 – 現代臺灣客語譯本，新舊約全書客語聖經 – 漢字版))
ChineseTraditionalBible (Chinese Union Traditional 1919)
ChineseTraditionalERVBible (Chinese Traditional ERV 2006)
ChineseTraditionalNewBible (Chinese Bible CNVT (Traditional) - (新譯本))
ChineseTTVHBible (Chinese TTVH 2021 (現代台語譯本漢字版))
ChineseTTVRBible (Chinese TTVR (現代台語譯本羅馬字版))
ChineseUnion2010Bible (Chinese Bible Union Version 2010 (Traditional) (（和合本修訂版） （繁體字） 神版))
ChineseWenli1823Bible (Chinese Bible Wenli 1823 (Traditional) (米憐文理《神天聖書》))
ChineseWenli1885Bible (Chinese Bible Wenli 1885 (Traditional))
ChineseWenli1897Bible (Chinese Bible Wenli 1897 (Traditional) (湛約翰－韶瑪亭文理《新約全書》))
ChineseWenliBible (Chinese Bible (Wenli) (Traditional) (包爾騰－柏漢理淺文理《新約聖經》))
ChineseWenliEasyBible (Chinese Bible (Easy Wenli) (Traditional))

"Chin KNTP (Khongso New Testament Printed)"은 미얀마의 Bible Society of Myanmar (미얀마 성서공회)에서 발행한 콩소(Khongso/Anu-Hkongso) 부족 언어의 신약 성경입니다.
ChinKNTPBible (Chin KNTP (Khongso New Testament Printed))       
ChinMatupi2006Bible (Chin Matupi (Matu Chin New Testament 2006))
ChinMatupiBible (Chin (Matu Bible))
ChinSCB2Bible (Chin SCB2 (Syin Chin Bible))
ChinTB77Bible (Chin TB77 (Tedim Bible))
ChinTBR17Bible (Chin TBR17 (Tedim Bible Revision 2017))
ChinTDBBible (Chin TBD (Tedim Bible Revision 2017))
ChinTedim2011Bible (Chin 2011 (Tedim Bible))
ChinTedimBible (Chin 1977 (Tedim Bible))

추바시 공화국(Chuvashia)은 동유럽에 위치한 러시아 연방의 구성 공화국입니다
ChuvashBible (Chuvash (CHB) (БИБЛИ) 2009)       
ChuvashRSOBible (Chuvash RSO (Синодальный НЗ))

'콥트(Coptic)'는 주로 이집트에 거주하는 토착 기독교인(콥트 정교회)을 뜻합니다.
CopticBible (Coptic Bohairic NT 2006)       
CopticCNTVBible (Coptic 2018 (العهد الجديد))
CopticSahidicBible (Coptic Sahidic 2006)

크로아티아(Croatia)는 유럽 남동부, 발칸반도에 위치한 국가입니다. 
CroatianBible (Croatian Bible 1988)     
CroatianBKJBible (Croatian BKJ 2011 (Biblija Kralja Jakova))
CroatianCNTBible (Croatian (Knjiga O Kristu))
CroatianGKSBible (Croatian Bible GKS 2010 - (Šarić) Version)
CroatianSHPBible (Croatian (SHP) 2019 (Biblija Suvremeni Hrvatski Prijevod))

체코(체코 공화국)는 중부 유럽에 위치한 내륙국으로, 북쪽으로 폴란드, 서쪽으로 독일, 남쪽으로 오스트리아, 동쪽으로 슬로바키아와 국경을 접하고 있습니다
Czech1922Bible (Czech Bible (SYK) 1922 Dr. Jan Ladislav Sýkora)     
Czech1947Bible (Czech Bible (COL) Dr. Rudolf Col (1947))
Czech1951Bible (Czech Bible (SKRABAL) 1951 - Dr Pavel Škrabal)
CzechBible (Czech (Bible 21))
CzechEkumenickyBible (Czech Bible Ekumenicky 2001)
CzechKralichka1613Bible (Czech (Kralická 1613))
CzechKralichka1998Bible (Czech Kralichka 1998 (Czech Nova karlica Bible (NBK) Nova Bible Kralicka))
CzechPMPZBible (Czech Bible (PMPZ) 2014 (Český studijní překlad Miloše Pavlíka - Miloš Pavlík))
CzechPrekladBible (Czech 2009 (Český studijní překlad))
CzechSNCBible (Czech 2012 (Slovo na cestu))

다그바니어(Dagbani 또는 Dagbanli)는 주로 가나 북부 지역(Northern Region of Ghana)에서 사용되는 언어입니다
DagbaniBible (Dagbani Bible (Naawuni Kundi Kasi))       

덴마크(Denmark, Danish)는 북유럽 스칸디나비아 반도 남서쪽, 독일 바로 북쪽에 위치한 나라입니다. 
Danish1819Bible (Danish 1819-1871)      
Danish2015Bible (Danish 2015 (Bibelen på Hverdagsdansk))
DanishBible (Danish 1871 (Danske Bibel 1871, 1907))
DanishLBBible (Danish Bible (LB) 1866)
DanishWIEBible (Danish Bible (WIE) 1997 - Det Nye Testamente)

딩카(Dinka)족은 주로 아프리카 남수단의 나일강 주변에 거주하는 나일로틱 민족입니다. 
Dinka2006Bible (Dinka Southwestern (Lëk yam))       
DinkaBible (Dinka DIPBSS 2009)
DinkaLEKJOTBible (Dinka Southeastern LEKJOT (Lek Jot de Jecu Kritho 1940))

도그리어(Dogri)는 주로 인도 북부의 잠무 카슈미르(Jammu and Kashmir) 연방 직할지, 특히 잠무(Jammu) 지역에서 사용되는 언어입니다.
DogriBible (Dogri (डोगरी नवां नियम))     

'Dutch(더치)'는 네덜란드(The Netherlands) 사람, 네덜란드어, 또는 네덜란드의 것을 뜻합니다
Dutch1939Bible (Dutch 1939 (De Heilige Schrift, Petrus Canisiusvertaling, 1939))        
Dutch2007Bible (Dutch 2007 (HTB))
DutchBBBible (Dutch (BB) 2016 BasisBijbel)
DutchBible (Dutch (Statenvertaling Jongbloed-editie))
DutchEBV24Bible (Dutch 2024 (EBV24 een Eigentijdse Bijbelvertaling))
DutchFrisianBible (Dutch Frisian)
DutchGBVNTBible (Dutch GBVNT (Gods Boek - het Nieuwe Testament))
DutchHSVBible (Dutch (HSV) 2017 (Herziene Statenvertaling))
DutchHTBBible (Dutch HTB 2007 (Het Boek))
DutchNBGBible (Dutch (NBG) Nederlands Bijbel Genootschap 1951)
DutchReimerBible (Dutch Reimer 2001)
DutchSVVBible (Dutch SVV 2018 (Statenvertaling Jongbloed-editie))
DutchVBBible (Dutch 2023 (Venster Bijbel))

듈라족(Dyula/Dioula)은 서아프리카 지역에 거주하는 만데(Mande) 계열의 상인 민족입니다.
DyulaJulaBible (Dyula Bible (Jula NT of Côte d’Ivoire))     
DyulaKumaBible (Dyula Bible (ALA KA KUMA))
DyulaLayidukuraBible (Dyula Bible (LAYIDUKURA))

'E Baibol Ẹdo'는 나이지리아 에도주(Edo State)에서 사용하는 에도어(Edo/Bini language)로 번역된 성경을 뜻합니다
EdoBible (Edo ((E Baibol Ẹdo) Version 1996))      

영어
EnglishAmplifiedBible (English Amplified)
EnglishAmplifiedClassicBible (English Amplified Classic Bible 1987)
EnglishASVBible (English ASV)
EnglishBereanBible (English Berean Standard Bible (BSB))
EnglishCSBBible (English CSB 2017 - Christian Standard Bible)
EnglishDarbyBible (English Darby 1890)
EnglishEASYBible (English EASY 2024)
EnglishERVBible (English ERV 2006)
EnglishESVBible (English ESV 2016)
EnglishGNTBible (English GNT (Good News Translation))
EnglishGWBible (English God's Word - GW 1995)
EnglishHCSBBible (English HCSB 2004)
EnglishKJBible (English KJV)
EnglishLSBBible (Legacy Standard Bible (LSB))
EnglishMEVBible (English MEV 2014 (Modern English Version))
EnglishNASBBible (English NASB (New American Standard Bible - NASB 1995))
EnglishNASUBible (English NASU 1989 - New American Standard Update)
EnglishNETBible (English NET Bible - 2005 (New English Translation))
EnglishNIRVBible (English NIRV 1996)
EnglishNIVBible (English NIV)
EnglishNKJBible (English NKJ 1982)
EnglishNLTBible (English NLT)
EnglishNRSVBible (English NRSV 1989)
EnglishPassionBible (English Passion Translation Bible 2020)
EnglishRSVBible (English RSV (Revised Standard Version))
EnglishTLBible (English TL (The Living Bible) (1971))
EnglishTyndale1537Bible (English Tyndale 1537)
EnglishYLTBible (English (YLT) 1898 Young's Literal Translation by Robert Young)

에스페란토(Esperanto)는 1887년 폴란드 의사 자멘호프가 창안한 세계 최대의 인공 국제어로, 특정 국가가 아닌 전 세계에 약 200만 명의 사용자가 산발적으로 퍼져 있는 언어입니다. 
EsperantoBible (Esperanto ESP (La Sankta Biblio 1926 (Esperanto Londona Biblio)))   

에스토니아(Estonia)는 북유럽에 위치한 국가입니다 
Estonian2022Bible (Estonian 2022 (Pühakiri Kaasaegses Eesti Keeles))    
EstonianBible (Estonian Bible (Eestikeelne Piibel 1997))
EstonianEEPBible (Estonian EEP (Eesti Piibel))

Ewe(에웨족)는 주로 아프리카 가나, 토고, 베냉 남부 지역에 거주하는 민족이며, 이들이 사용하는 언어도 Ewe어라고 합니다.
Ewe1913Bible (Ewe 1913 (Biblia alo Ŋɔŋlɔ Kɔkɔe La Le Eʋegbe Me 1913))    
Ewe2014Bible (Ewe 2014 (EƲEGBE BIBLIA))
Ewe2020Bible (Ewe (Agbenya La) 2020)
EweBible (Ewe BEV (Agbenya La) 2006)

핀란드(Finland, 핀란드어: Suomi)는 북유럽에 위치한 나라로, 스웨덴, 러시아, 노르웨이와 접해 있으며, 발트해와 핀란드만을 끼고 있는 노르딕 국가입니다.
Finnish1776Bible (Finnish 1776)     
Finnish1992Bible (Finnish 1992 (Kirkkoraamattu 1992))
FinnishBible (Finnish (Kirkkoraamattu 1933, 1938))
FinnishFINRKBible (Finnish FINRK 2012 (Raamattu Kansalle))
FinnishSTLKBible (Finnish STLK 2017 = Pyhä Raamattu (STLK 2017))

MAWUXÓWÉMA는 베냉(Benin)과 토고(Togo) 일부 지역에서 사용되는 퐁어(Fon language)로 번역된 성경을 의미합니다.
FonBible (Fon (MAWUXÓWÉMA))     

프랑스(France)는 서유럽에 위치한 공화제 국가로, 유라시아 대륙 북서쪽 가장자리에 자리 잡고 있습니다.
French2004Bible (French (La Bible expliquée))       
FrenchBBBBible (French Bible (BBB) Bible Bovet Bonnet (1900))
FrenchBDSBible (French (BDS) 2015 (La Bible du Semeur 2015))
FrenchBFCBible (French (BFC) 1997 (Bible en Français Courant))
FrenchBible (French (La Sainte Bible par Louis Segond 1910))
FrenchCramponBible (French (Catholique Crampon 1923))
FrenchDarbyBible (French (J.N. Darby) 1885)
FrenchJerusalemBible (French Jerusalem 1998)
FrenchLeonBible (French (Zoque, Francisco León))
FrenchMachairaBible (French Machaira 2012)
FrenchMartinBible (French Martin 1744)
FrenchNBSBible (French (NBS) 2002 (Nouvelle Bible Segond))
FrenchNEG79Bible (French NEG79 1979 (Segond Nouvelle Edition de Genève 1979))
FrenchNFCBible (French NFC 2019 (Nouvelle Français courant))
FrenchNVS78Bible (French NVS78P 1978 (Nouvelle Segond Révisée))
FrenchOSTBible (French OST (Ostervald))
FrenchOstervaldBible (French OST - Osterwald)
FrenchPDV2017Bible (French PDV2017 (Parole de Vie 2017))
FrenchPerretBible (French Perret-Gentil et Rilliet 1847)
FrenchS21Bible (French S21 2007 (Bible Segond 21))
FrenchVigourouxBible (French Vigouroux 1902 Bible)

풀라어(Fulfulde)는 주로 서아프리카와 중앙아프리카의 약 18개국에 걸쳐 분포하며, 약 3,600만 명 이상이 사용하는 세네감비아 어족 언어입니다.
Fulfulde2010Bible (Fulfulde Bible (Caka Nigeria) 2010)       
FulfuldeAadiBible (Fulfulde Bible (Aadi keyri linjiila iisaa almasiihu))
FulfuldeAdamawaBible (Fulfulde Adamawa Bible)
FulfuldeAlkawalBible (Fulfulde Bible (Alkawal Kesal) Central Eastern Niger)
FulfuldeArabicBible (Fulfulde Bible (Caka Nigeria Arabic Script) (اَلْکَوَلْ کٜسَلْ ندٜرْ فُلْفُلْدٜ شَکَ نَاجٜىٰرِيَ))
FulfuldeBeninBible (Fulfulde Bible (Borgu Benin))
FulfuldeBurkinaFasoBible (Fulfulde Bible (Dewtere Laamɗo Amaana Keso) (Burkina Faso))
FulfuldeDewtereBible (Fulfulde Bible (Dewtere Laamɗo Fulfulde Burkina Faso))
FulfuldeWestNigerBible (Fulfulde Bible (Western Niger))

게일어(Gaelic)는 주로 아일랜드와 영국 스코틀랜드, 그리고 맨 섬을 중심으로 사용되는 켈트계 언어군입니다.
Gaelic1875Bible (Gaelic Scottish (Tiomnadh Nuadh (MacEachen) 1875))     
GaelicABGBible (Gaelic Scottish (Am Bìoball Gàidhlig 1992))
GaelicABIGBible (Gaelic ABIG (Scottish) (Am Bìoball Iomraidh Gàidhlig 1880, 1992))
GaelicATNBible (Gaelic (Scottish) (An Tiomnadh Nuadh anns an Eadar-Theangachadh Ùr Gàidhlig 2017)

갈리시아(Galicia)는 스페인의 최북서단에 위치한 자치 지방입니다
GalacianSEPTBible (Galacian 1989 (Biblia SEPT))     

가르왈리어(Garhwali)는 주로 인도 북부 우타라칸드(Uttarakhand) 주의 가르왈(Garhwal) 지역에서 사용되는 언어입니다.
GarhwaliBible (Garhwali (GHMNT) (गढवली नयो नियम) 2020)     
GarhwaliGBMBible (Garhwali GBM (Garhwali))

조지아(Georgia)는 동유럽과 서아시아의 교차점인 캅카스(Caucasus) 지역에 위치한 국가입니다. 
Georgian2002Bible (Georgian GEO02 (ბიბლია))     
Georgian2012Bible (Georgian 2013 (ბიბლია))
GeorgianBible (Georgian (OGB) Old Georgian)

독일(Germany)은 서유럽 및 중앙유럽에 위치한 국가로, 북쪽으로는 발트해와 북해, 남쪽으로는 알프스 산맥 사이에 자리 잡고 있습니다. 
German1545Bible (German Luther 1545)        
German2011Bible (German 2011 (Neue Genfer Übersetzung))
GermanAlbrecht1926Bible (German (Albrecht NT und Psalmen))
GermanBible (German (Die Heilige Schrift (Schlachter 1951)))
GermanElber1905Bible (German Elber 1905 (Darby Unrevidierte Elberfelder))
GermanGruenewaldBible (German Gruenewald (Grünewald) 1924)
GermanHeuteBible (German HEUTE (Bibel Heute))
GermanHFABible (German HFA (Hoffnung für Alle))
GermanInterlinearBible (German Interlinear 1979 (Interlinearübersetzung))
GermanLUT17Bible (German LUT17 Lutherbibel 2017)
GermanLuther1912Bible (German Luther (Lutherbibel 1912))
GermanLutherHeuteBible (German Luther Heute 2021)
GermanSchlachter2000Bible (German SCH2000 Schlachter 2000 (Die Bibel (Schlachter 2000)))
GermanTafelBible (German Bible Tafel (Tafelbibel) 1911)
GermanTKWBible (German TKW (Textbibel von Kautzsch und Weizsäcker))
GermanUbersetzung2014Bible (German Ubersetzung 2014)

Ghomala'(고말라어)는 카메룬(Cameroon)에서 사용되는 언어입니다
GhomalaBible (Ghomala New Testament (GNT02))        

그리스(Greece)는 동남유럽 발칸반도 남쪽 끝에 위치하며, 지중해와 접해 있는 국가입니다
Greek1550Bible (Greek Stephanus NT 1550)        
GreekBible (Greek Bible - Neophytos Vamvas Translation 1770)
GreekBYZ04Bible (Greek BYZ04 (Πατριαρχικό Κείμενο (Έκδοση Αντωνιάδη, 1904)))
GreekBYZ18Bible (Greek BYZ18 (Byzantine Textform 2018))
GreekElzevirBible (Greek TR1624 (Elzevir Textus Receptus 1624))
GreekF35Bible (Greek F35 (Η Ελληνική Καινή Διαθήκη Σύμφωνα με την Οικογένεια 35))
GreekFPBBible (Greek FPB (H Αγία Γραφή στη Δημοτική (Filos Pergamos)))
GreekGNTBible (Greek GNT 1904)
GreekLMGNTBible (Greek LMGNT (Νεοελληνική Μετάφραση Λόγου))
GreekModern1904Bible (Greek Modern Bible 1904)
GreekModernFPBBible (Greek Modern Bible  FPB 1994)
GreekNTVBible (Greek NTV (Η Καινή Διαθήκη του Κυρίου και Σωτήρος ημών Ιησού Χριστού κατά νεοελληνικήν απόδοσιν))
GreekSBLGNTBible (Greek SBLG (SBL Greek New Testament))
GreekTCGNTBible (Greek TCGNT (Text-Critical Greek New Testament))
GreekTGVBible (Greek TGV (Η Αγία Γραφή (Παλαιά και Καινή Διαθήκη)))
GreekTHGNTBible (Greek THGNT (The Greek New Testament))
GreekTR1894Bible (Greek TR1894 (Scrivener’s Textus Receptus 1894))

과라니족(Guarani)은 주로 남아메리카 중남부 지역에 거주하는 원주민입니다.
Guarani1913Bible (Guarani (Tûpâ Ñandeyára 1913))        
Guarani1970Bible (Guarani 1970 (Ñandeyara Ñe'ẽ))
Guarani1996Bible (Guarani 1996 (Ñandejara Ñe’ẽ ✟))
Guarani2001Bible (Guarani 2001 (Biblia Guarani, Tumpa Iñee))
Guarani2015Bible (Guarani 2015 (Ñanderuete Ñe’ẽ Porã 2015))
Guarani2017Bible (Guarani (Biblia) 2017)
GuaraniBible (Guarani (Nuevo Testamento Guaraní Pe))
GuaraniMBYABible (Guarani MBYA (Nhanderuete ayvu iky'a e'ỹ va'e))
GuaraniSIMBABible (Guarani (Guaraní Pe (Western) Simba))

구자라트 는 인도 구자라트 주에서 주로 사용되는 인도아리아어족 언어로 , 주로 구자라트 사람들이 사용합니다.
Gujarati2016Bible (Gujarati 2016 BSI (GUCL) (પવિત્ર બાઇબલ C.L.))       
Gujarati2017Bible (Gujarati (IRVGUJ) (ઇન્ડિયન રીવાઇઝ્ડ વર્ઝન ગુજરાતી - 2019))
GujaratiBible (Gujarati ERV 2003 (પવિત્ર બાઈબલ))
GujaratiGUOVBible (Gujarati BSI (GUOV) (પવિત્ર બાઇબલ OV Reference Bible (BSI)))

EBIBILIA ENCHENU는 케냐 서부 지역의 구시어(Ekegusii)로 번역된 성경입니다
GussiBible (Gussi (EBIBILIA ENCHENU) 2020)  

Hadiyya(하디야)는 에티오피아 남중부 지역에 위치한 행정 구역(Zone)이자 그 지역에 거주하는 민족 집단입니다
HadiyyaBible (Hadiyya (KEESAMMI KITAABA))   

아이티(Haiti)는 북아메리카 카리브해에 위치한 섬나라입니다.
HaitianBible (Hatian (1998 Haïtienne))      
HaitianBSABible (Haitian BSA (Bib Sen An Kreyòl Ayisyen) 2023)
HaitianHWPBible (Hatian Creole (HWP) 2000)
HaitianVFKBible (Hatian VFK (Nouvo Testaman Vèsyon Kreyòl Fasil))

하리얀비어(Haryanvi)는 주로 인도 북부의 하리아나(Haryana) 주에서 사용되는 인도-아리안 언어입니다
HaryanviBible (Haryanvi Bible (हरियाणवी))      

하우사(Hausa)족은 주로 아프리카 서부의 사헬 지역, 특히 나이지리아 북부와 니제르 남부에 집중 거주하는 민족입니다.
Hausa2010Bible (Hausa Bible 1979 (Littafi Mai Tsarki))       
Hausa2013Bible (Hausa (Sabon Rai Don Kowa 2020))
HausaARBible (Hausa Arabic 2020 (أَتَّوْرَتْ دَ أَنَّبَاوَا))

히브리어는 주로 이스라엘에서 사용하는 공식 언어입니다
Hebrew1885Bible (Hebrew Bible (DHNT) 1885 - Delitzsch's Hebrew New Testament)   
HebrewAleppoCodexBible (Hebrew Aleppo Codex Bible)
HebrewBible (Hebrew Bible Modern 1977)
HebrewBSIBible (Hebrew BSI 2017 (שעתוק אלקטרוני נאמן לכתב יד לנינגרד))
HebrewHHHBible (Hebrew (HHH) 2009 (Habrit HakhadashaHaderekh))
HebrewLeningradCodexBible (Hebrew Leningrad Codex)
HebrewMHBBible (Hebrew Bible (MHB) 2010)
HebrewMHNT2020Bible (Hebrew MHNT 2020 (הברית החדשה בעברית מודרנית))
HebrewTDBible (Hebrew TD 2018 (תנ'ך וברית חדשה בתרגום דליטש))

힌디어(Hindi)는 주로 인도 북부 및 중부 지역(힌디 벨트)에서 사용하는 언어로, 인도 연방의 공식 공용어입니다
Hindi2017Bible (Hindi 2017 (नया नियम))    
HindiBible (Hindi Bible HHBD = (BSI))
HindiCLBSIBible (Hindi Bible CLBSI 2015 (पवित्र बाइबिल CL Bible (BSI)))
HindiERVBible (Hindi Bible (ERV) (पवित्र बाइबल))
HindiFijiBible (Hindi Fiji (Nawa Haup))
HindiHSBBible (Hindi HSB 2023 (नवीन हिंदी बाइबल))
HindiHSSBible (Hindi HSS 2019 (सरल हिन्दी बाइबल))
HindiIRVBible (Hindi IRVHIN (इंडियन रिवाइज्ड वर्जन (IRV) हिंदी - 2019))
HindiOVBSIBible (Hindi HINOVBSI (पवित्र बाइबिल OV (Re-edited) Bible (BSI)))
HindiRomanBible (Hindi (Roman Script))

몽족(Hmong)은 중국 남부, 베트남, 라오스, 태국 등 동남아시아 산악 지대에 주로 거주하는 소수 민족입니다. 
Hmong2000Bible (Hmong Bible (Vajtswv Txojlus 2000))     
Hmong2004Bible (Hmong Bible 2004)

헝가리(Hungary)는 중부 유럽(또는 동남유럽)에 위치한 내륙 국가로, 수도는 부다페스트입니다.
HungarianBDUZBible (Hungarian Bible (BDUZ) 1951 - Hungarian Bekes — Dalos NT)   
HungarianBible (Hungarian HUNB (Magyar Bibliatársulat új fordítású Bibliája))
HungarianBUZBible (Hungarian Bible (BUZ) 1967 - Dr. Budai Gergely Ujszovetseg forditasa)
HungarianCSIABible (Hungarian Bible by Lajos Csia)
HungarianCSUZBible (Hungarian (CSUZ) 1924 - Czeglédy Sándor Újszövetség fordítása)
HungarianEFOBible (Hungarian EFO (BIBLIA Egyszerű Fordítás))
HungarianEIVBible (Hungarian (EIV) (Újszövetség élet, igazság és világosság))
HungarianERVBible (Hungarian Bible (ERV) 2012)
HungarianKaroliBible (Hungarian (Karoli Bible 1908))
HungarianKIBBible (Hungarian Bible - KIB 1935 - Kecskeméthy István)
HungarianKNBBible (Hungarian Bible (KNB) 1997 - Káldi Neovulgata Bible)
HungarianKSZEBible (Hungarian Bible - (KSZE) 2011 - Revideált Károli Biblia)
HungarianMRUZBible (Hungarian Bible (MRUZ) 1925 - Dr. Masznyik Endre Újszövetség fordítása)
HungarianRLUZBible (Hungarian Bible (RLUZ) 1971 - Ravasz László Újszövetség fordítása)
HungarianRUFBible (Hungarian RUF (Revised Hungarian Bible))
HungarianSIUZBible (Hungarian Bible (SIUZ))
HungarianVSUZBible (Hungarian Bible 1971 (VSUZ) - Vida Sándor Újszövetség fordítása)

Bup Kudus는 말레이시아 사라왁주, 인도네시아 칼리만탄 바랏, 브루나이 등지에서 사용하는 이반어(Iban language) 성경을 뜻합니다
IbanBible (Iban (Bup Kudus))        

이비비오(Ibibio)족은 나이지리아 남동부 지역에 주로 거주하는 민족입니다
IbibioBible (Ibibio (Ñwed Abasi Ke Ikọ Ibibio Ayo Mfịn))    

아이슬란드(Iceland)는 북대서양 북서쪽 끝, 그린란드와 영국 사이에 위치한 유럽의 섬나라입니다.
Icelandic1981Bible (Icelandic 1981 (Biblían (1981)))    
IcelandicBible (Icelandic 2007 (Biblían (2007)))

이그보족(Igbo)은 나이지리아 남부 및 동남부 지역에 주로 거주하는 민족입니다. 
Igbo1988Bible (Igbo Bible 1988)     
Igbo2006Bible (Igbo (Bible Nso))
Igbo2020Bible (Igbo 2020 (Baịbụlụ Nsọ nʼIgbo Ndị Ugbu a))

2018년 판 이카(Ika) 성경은 주로 나이지리아 이카 지역에서 사용되는 언어로 번역된 성경
IkaBible (Ika 2018 Bible)       

일로카노어(Ilokano/Iloko)는 주로 필리핀 북부 지역에서 사용되는 언어입니다
Ilokano1973Bible (Ilokano (Ti Biblia (1973)))   
IlokanoBible (Ilokano (Ti Baro a Naimbag a Damag Biblia) 1996)

일롱고(Ilonggo)어 또는 힐리가이논(Hiligaynon)어는 주로 필리핀 중부 비사야(Visayas) 제도 지역에서 사용되는 언어입니다
Ilonggo2012Bible (Ilonggo (Maayong Balita nga Biblia (2012)))       
IlonggoAPDBible (Ilonggo APD 2022 (Ang Pulong Sang Dios))
IlonggoBible (Ilonggo (Ang Biblia (1982)))

인도네시아(Indonesia)는 동남아시아에 위치한 국가로, 말레이 제도에 있는 세계 최대의 도서 국가입니다
IndonesianAGSBible (Indonesian AGS (Alkitab Gratis untuk Semua))        
IndonesianAMD2021Bible (Indonesian AMD 2021 (Perjanjian Baru Alkitab Mudah Dibaca))
IndonesianBible (Indonesian (Alkitab Terjemahan Baru))
IndonesianBISBible (Indonesian BIS 1985 (Alkitab dalam Bahasa Indonesia Masa Kini))
IndonesianBPJBible (Indonesian Bible (BPJ) - Kitab Perjanjian Baru - Year No Data)
IndonesianFAYHBible (Indonesian FAYH (Firman Allah Yang Hidup))
IndonesianINOTAZIBible (Indonesian INOTAZI (Indonesian Tazi NT))
IndonesianPBTB2Bible (Indonesian PBTB2 (Perjanjian Baru Terjemahan Baru Edisi 2))
IndonesianTLBible (Indonesian TL 1954 (Alkitab Terjemahan Lama))
IndonesianTSIBible (Indonesian Bible (TSI) 2013 - (Terjemahan Sederhana Indonesia))
IndonesianVMDBible (Indonesian VMD 2005)

'Irish'는 아일랜드(Ireland)의 사람, 언어, 문화를 뜻하며, 아일랜드는 유럽 북서쪽에 위치한 섬나라입니다.
Irish1817Bible (Irish 1817 (An Bíobla Naomhtha 1817 (Bedell)))  
Irish1951Bible (Irish 1951 (Tiomna Nua 1951 (de Siúnta)))
Irish1970Bible (Irish 1970 (An Tiomna Nua 1970 (Ó Cuinn)))
Irish2012Bible (Irish 2012 (An Tiomna Nua Agus Leabhar na Salm 2012))
IrishBible (Irish 1981 - (An Bíobla Naofa 1981))


Italian1649Bible (Italian 1885 (Diodati Bibbia 1885))  이탈리아
Italian2014Bible (Italian Bible (ICL00D) (Traduzione Interconfessionale in Lingua Corrente))
Italian2020Bible (Italian 2020 (La Sacra Bibbia Versione Riveduta 2020 (R2)))
ItalianBible (Italian CEI 1974)
ItalianCEI2008Bible (Italian Bible (CEI) 2008)
ItalianIPNBible (Italian Bible (IPN) 1996 San Paolo)
ItalianLaNuovaDiodatiBible (Italian Bible (LND) 1991)
ItalianNR1994Bible (Italian (Nuova Riveduta 1994))
ItalianRivedutaBible (Italian (Versione Diodati Riveduta))

Iu Mien(이우몐/유멘)족은 중국 남부와 동남아시아 산악 지대에 주로 거주하는 소수 민족입니다
IuMienBible (Iu Mien (Iu-Mien New))     
IuMienThaiBible (Mien Bible (Thai Script) © Thailand Bible Society, 2007)

자메이카(Jamaica)는 북아메리카 카리브해에 위치한 섬나라입니다. 
JamaicanBible (Jamaican 2012 (Di Jamiekan Nyuu Testiment))      

일본
Japanese1965Bible (Japanese 1965)
Japanese1987Bible (Japanese 1988 (Seisho Shinkyoudoyaku 聖書 新共同訳))
Japanese2017Bible (Japanese 2017 (バイブル 新約聖書))
JapaneseBible (Japanese (Colloquial version (1955)))
JapaneseCO1955Bible (Japanese (CO1955) (聖書　口語訳))
JapaneseERVBible (Japanese ERV (訳 ー 読みやすい聖書 ー（新約聖書）))
JapaneseJCBBible (Japanese Contemporary (リビングバイブル))

자바인(Javanese)은 주로 인도네시아 자바섬(Java Island)의 중부 및 동부 지역에 거주하는 민족입니다
JavaneseBible (Javanese Bible 1981)     
JavaneseJVNBible (Javanese JVN (Javanese, Caribbean))
JavaneseKJS17Bible (Javanese KJS17 (Kitab Jawa Suriname))

카바르디아어(Kabardian, East Circassian)는 주로 러시아 북캅카스 지역에서 사용되는 언어입니다
KabardianBible (Kabardian 1993 (ХъыбарыфӀыр. ЩӀэдзапӀэр. Уэрэд ЛъапӀэхэр))      

카빌(Kabyle)족은 주로 알제리 북부에 거주하는 베르베르(Berber)계 원주민입니다.
KabyleBible (Kabyle Maybe is 2001)      

카친(Kachin)은 미얀마 최북단에 위치한 카친주(Kachin State)를 의미합니다. 
KachinJCLBBible (Kachin JCLB (Jinghpaw))    
KachinJHVT3Bible (Kachin JHVT3 (Jinghpaw Hanson Version Bible))

칼렌진(Kalenjin)족은 주로 케냐의 서부 고지대(특히 리프트 밸리 지역)에 거주하는 나일족 계열의 민족입니다 
Kalenjin2019Bible (Kalenjin 2019 (Bukuit Ne Tilil))     
KalenjinBible (Kalenjin Bible (BUKUIT NE TILIL))
KalenjinRevisedBible (Kalenjin Bible Revised (BUKUIT NE TILIIL Sireet ne Dutero Kanon))

'Kamba(캄바)'는 주로 케냐 중남부 지역에 거주하는 반투계 원주민 부족을 의미하며, 동부 아프리카에 위치합니다
KambaBible (Kamba (MBIVILIA ŨVOO MŨSEO))    
KambaMBIVLIABible (Kamba (Mbivilia) 1956)

'Kangri(캉그리)'는 주로 인도 북부 라다크(Ladakh) 지역에 있는 히말라야 산맥의 고봉들을 지칭하는 말로 쓰입니다
KangriBible (Kangri (काँगड़ी))      

칸나다어(Kannada)는 인도 남서부 카르나타카(Karnataka) 주의 공식 언어입니다.
Kannada2022Bible (Kannada KSB 2022 (ಕನ್ನಡ ಸಮಕಾಲಿಕ ಅನುವಾದ))       
KannadaBible (Kannada (ERV) 1997 (ಪರಿಶುದ್ದ ಬೈಬಲ್‌))
KannadaBSIBible (Kannada BSI Bible 2016)
KannadaBSIJVBible (Kannada BSI JV (ಕನ್ನಡ ಸತ್ಯವೇದವು J.V. (BSI)))
KannadaIRVBible (Kannada 2019 (ಇಂಡಿಯನ್ ರಿವೈಜ್ಡ್ ವರ್ಸನ್ (IRV) - ಕನ್ನಡ - 2019))
KannadaKNCLBible (Kannada Bible (KNCL) BSI 2016)

카라칼파크스탄(Karakalpakstan)은 우즈베키스탄 북서부에 위치한 자치공화국입니다.
Karakalpak2004Bible (Karakalpak (Жаңа Келисим))     
Karakalpak2022Bible (Karakalpak 2022 (Мухаддес Китап))
KarakalpakK2022Bible (Karakalpak (Muxaddes Kitap) 2022)

카자흐스탄(Kazakhstan)은 중앙아시아와 동유럽에 걸쳐 있는 나라입니다
Kazakhstan2023Bible (Kazakhstan 2023 (Zhana Osiet))     
KazakhstanBible (Kazakhstan 1993 (Киелі Кітап))

케냐(Kenya)는 동아프리카에 위치한 나라입니다
KenyaGIKCLBible (Kikuyu Bible 2008 (Kenya) - IBUKU RĨA ŨHORO ŨRĨA MWEGA (GIKCL))    

'크메르(Khmer)'는 주로 캄보디아(Cambodia)를 의미하며, 동남아시아에 위치하고 있습니다
Khmer2005Bible (Khmer 2005 (ព្រះគម្ពីរភាសាខ្មែរបច្ចុប្បន្ន ២០០៥))   
Khmer2012Bible (Khmer 2012 (Khmer Christian Bible))
Khmer2014Bible (Khmer 2014 (អាល់គីតាប))
Khmer2016Bible (Khmer (ព្រះគម្ពីរបរិសុទ្ធកែសម្រួល ២០១៦))
Khmer2019Bible (Khmer 2023 (ព្រះគម្ពីរខ្មែរសាកល))
KhmerBFBSBible (Khmer BFBS (ព្រះគម្ពីរបរិសុទ្ធ ១៩៥៤))
KhmerBible (Khmer Standard Version 1954 = Hammond Version)

과테말라의 마야 언어인 키체어(Kʼicheʼ) 성경
Kiche1995Bible (Kiche 1995 (Quiché Bible))      
Kiche2022Bible (Kiche (RI KꞌAKꞌ TESTAMENTO PA TZIJOBꞌAL KꞌICHEꞌ))
KicheBible (Kiche QUCT)
KicheQUCNBible (Kiche QUCN (New Orthography))

키쿠유(Kikuyu)는 동아프리카 케냐(Kenya)의 수도 나이로비 근교에 위치한 도시이자, 해당 지역을 중심으로 거주하는 케냐 최대의 민족 그룹입니다
Kikuyu2013Bible (Kikuyu 2013 (Kiugo Gĩtheru Kĩa Ngai, Kĩrĩkanĩro Kĩrĩa Gĩkũrũ Na Kĩrĩa Kĩerũ))      
Kikuyu2014Bible (Kikuyu (Kĩrĩkanĩro Gĩa Gĩkũyũ))
Kikuyu2019Bible (Kikuyu Bible (IBUKU RĨRĨA ITHERU RĨA NGAI))

1950년판 키크완고(Kikwango/Kituba) 신약 성경
KikwangoBible (Kikwango Bible (Le Nouveau Testament en Kikwango 1950))      

킴분두어(Kimbundu)는 앙골라(Angola) 북서부 지역에서 주로 사용되는 반투어군 언어입니다
KimbunduBible (Kimbundu (O Mikanda Ikola))      

키메루어 (Kimeru), Catholic Edition
KimiiruBible (Kimiiru (NTETO INJEGA CIA MURUNGU KIRI ANTU BONTHE CATHOLIC EDITION))     




키냐르완다어(Kinyarwanda)는 아프리카 중동부에 위치한 르완다 공화국의 공식 언어입니다
Kinyarwanda2001Bible (Rwandan Kinyarwanda (BYSB) 2001 (Bibiliya Yera))
Kinyarwanda2012Bible (Kinyarwanda 2012 (Bibiliya Ntagatifu))        .
KinyarwandaBIRBible (Kinyarwanda 2001 (BIR) (Bibiliya Ijambo ry'imana))

키룬디어(Kirundi/Rundi)는 주로 동아프리카의 부룬디(Burundi)에서 사용되는 반투어군 언어입니다. 
KirundiCorosheBible (Kirundi (Bibiliya mu Kirundi Coroshe) Uburenganzira © 2021 bwa Biblica, Inc)   
KirundiRishaBible (Kirundi (Bibliya Yera 1951, 1967 (Burundi)))

키투바(Kituba, Kikongo ya leta)는 중앙아프리카의 콩고 공화국(Republic of the Congo)과 콩고 민주 공화국(DR Congo)에서 주로 사용되는 반투어 기반의 크리올어이자 공용어입니다
KitubaBible (Kituba (BIBILIYA NA KITUBA))   

콘카니어(Konkani)는 주로 인도 서부 해안(콘칸 지역)에서 사용되는 언어입니다
KonkaniBible (Konkani Bible (Novo Korar NT (BSI)))      

한국어
Korean2021Bible (Korean 2021 (읽기 쉬운 성경))
KoreanAEBBible (Korean AEB)
KoreanBible (Korean 1961 (개역한글))
KoreanCatholicBible (Korean Catholic 2005)
KoreanKLBBible (Korean KLB (현대인의 성경))
KoreanNKRVBible (Korean NKRV Bible 1998)
KoreanNLTNKBible (Korean NLTNK (God’s Promises New Testament in North Korean))
KoreanRentierBible (Korean Rentier Bible)
KoreanRNKSVBible (Korean RNKSV (새번역))
KoreanTKVBible (Today's Korean Version TKV 1991)
KoreanWoorimalBible (Korean Woorimal 2004)
KoyaBible (Koya (ପୁନାଦ୍ ଆର୍ର୍, ପୁନାଦ୍‍ ନିୟମ୍‍))

크리오어(Krio)는 주로 서아프리카의 시에라리온(Sierra Leone)에서 사용되는 영어 기반의 크리올어입니다
KrioBible (Krio (Krio Fɔs Oli Baybul))  

쿠마오니(Kumaoni)족은 주로 인도 우타라칸드(Uttarakhand) 주의 쿠마온(Kumaon) 지역에 거주하는 인도아리아 어족 언어 집단입니다
KumaoniBible (Kumaoni (सोरियाली नय्या नियम) 2020)  

쿠르드족(Kurdish)은 특정 국가 없이 서아시아의 튀르키예 동남부, 이라크 북부, 이란 북서부, 시리아 북동부에 걸친 '쿠르디스탄' 지역에 분산되어 거주하는 민족입니다.
Kurdish2005Bible (Kurdish (Kurmanji Încîl))     
Kurdish2017Bible (Kurdish Bible (PNU) 2016 - Peymana Nû (Încîl))
KurdishBHDBible (Kurdish - Behdini Kurdish (ئنجیلا پیرۆز))
KurdishBible (Kurdish Sorani KSS 2020 (كوردی سۆرانی ستانده‌رد))
KurdishKMRNTCBible (Kurdish Kurmanji Cyrillic (KMRNTC) (Пәймана Ну (Инщил)) 2000)
KurdishKMRNTLBible (Kurdish Kurmanji Latin (Peymana Nû (Încîl)))
KurdishPNTZSBible (Kuridsh Sorani (پەیمانی نوێ و زەبوورەکان بە سۆرانی))
KurdishSKBBible (Kurdish Kurmanji 2024 SKB (کتاب مقدس به زبان کردی شیکاکی))
KurdishSKVBible (Kurdish Southern SKV (Kalhori) (کتاب مقدس به زبان کردی جنوبی - گویش کلهوری))

쿠루크어(Kurukh)는 주로 인도 동부 및 중부 지역에서 사용되는 북드라비다어족 언어입니다
Kurukh2025Bible (Kurukh NT 2025)    
KurukhBible (Kurukh (पुना गच्छरना NT (BSI)))

키르기스스탄(Kyrgyzstan)은 중앙아시아에 위치한 내륙국입니다.
Kyrgyz2004Bible (Kyrgyz 2004 - Кыргыз тилиндеги Библия - Kyrgyz Tilindegi Bible)     
Kyrgyz2005Bible (Kyrgyz 2005 - (Инжил ЛС (2005)))

라후족(Lahu)은 주로 동남아시아의 산악 지대와 중국 남서부 윈난성 일대에 거주하는 소수 민족입니다
LahuBible (Lahu (Lahu Bible Edited))    
LahuLHINTBible (Lahu LHINT (Lahu Shi))

람바디(Lambadi 또는 Banjara)는 주로 인도 전역에 퍼져 살고 있는 유목민 출신의 부족(또는 커뮤니티)입니다.
LambadiBible (Lambadi 2025 (పవిత్తర్ బైబిల్ (బంజారాలంబాడిగోర్బోలి)))    

Lango(랑고)는 주로 우간다 북중부 지역(Lango sub-region)에 거주하는 랑고족이 사용하는 언어이자 그 지역을 지칭합니다
Lango1979Bible (Lango New Testament)    
LangoBible (Lango (BUK OBAŊA ACIL AME OLWOŊO NI BAIBUL AME OGEO LOKO I LEB LAŊO))

라오스(Laos)는 동남아시아 인도차이나 반도 중심부에 위치한 내륙국입니다
Lao2012Bible (Lao Bible 2012 (ພຣະຄຳພີສັກສິ))   
LaoBible (Lao Bible (ฉบับอักษรลาว))
LaoLCVBible (Lao 2023 (ພຣະຄຳພີລາວສະບັບສະໄໝໃໝ່))

라틴어(Latin)는 고대 이탈리아반도 중부, 지금의 로마 주변인 라치오(Latium) 지방에서 유래했습니다. 
LatinBible (Latin - Vulgate Version)    
LatinClementina1914Bible (Latin - Vulgata Clementina Hetzenauer Editore 1914)
LatinClementineBible (Latin - Clementine Vulgata 1598)
LatinNovaVulgataBible (Latin - Nova Vulgata 1979)
LatinSistinaBible (Latin - Vulgata Sistina)

라트비아(Latvia)는 북유럽 발트해 연안에 위치한 국가입니다
Latvian1965Bible (Latvian (RT65) 1965 (1965. Gada Bībeles Izdevuma Revidētais Teksts))  
Latvian2012Bible (Latvian NLB (New Latvian Inter-Confessional Bible))
Latvian2024Bible (Latvian 2024 (Jauna Pārstrādāta latviešu Bībele 2024))
LatvianBible (Latvian LJD (Latviešu Jaunā Derība))
LatvianGluckBible (Latvian Gluck 1685 (LvGluck8)  Glika Bībele 8. Izdevums)
LatvianLG8Bible (Latvian LG8 (Glika Bībele 8. Izdevums))
LatvianLTV1965Bible (Latvian LTV 1965 (LATVIJAS BĪBELES BIEDRĪBA))
LatvianNLBDCBible (Latvian NLBDC (New Latvian Inter-Confessional Bible with Deuterocanonicals))

라이베리아(Liberia)는 서아프리카 해안에 위치한 국가입니다
LiberianKreyolBible (Liberian Kreyol (ꕢꕌꔳ ꕺꖃ ꕯꕮꕊ))  

링갈라어(Lingala)는 주로 중앙아프리카 지역에서 사용되는 언어입니다
Lingala2002Bible (Lingala Bible 2002 (Mokanda na Bomoi))    
Lingala2020Bible (Lingala 2020 (Mokanda na Bomoi))

리투아니아(Lithuania)는 북유럽 발트해 연안에 위치한 나라로, 라트비아, 벨라루스, 폴란드, 러시아(칼리닌그라드)와 국경을 맞대고 있는 발트 3국 중 가장 남쪽에 있는 국가입니다
Lithuanian2012Bible (Lithuanian 2012 LBDC (Biblija arba Šventasis Raštas))  
Lithuanian2012EKUBible (Lithuanian 2012 EKU (A. Rubšio ir Č. Kavaliausko Vertimas su Antrojo Kanono Knygomis))
Lithuanian2012KANBible (Lithuanian LBD-KAN (A. Rubšio ir Č. Kavaliausko Vertimas be Antrojo Kanono Knygų))
LithuanianBible (Lithuanian (KBV) (Biblija. Senasis Testamentas. Naujasis Testamentas))
LithuanianKJBible (Lithuanian Bible (Karaliaus Jokūbo Versija Lietuviškai 2012 Edition) 2012 - KJV)
LithuanianLBDBible (Lithuanian (LBD) 2012 (Biblija arba Šventasis Raštas))

롬웨(Lomwe 또는 Elhomwe)족은 주로 모잠비크 북부(잠베지아주, 남풀라주)와 말라위 남동부 지역에 거주하는 반투계 부족입니다
LomweBible (Nlakano Nahihano ni Masalmo 1930))  

루간다어(Luganda, 또는 Oluganda)는 아프리카 동부 우간다(Uganda)에서 주로 사용되는 언어입니다
Luganda2003Bible (Luganda (Luganda Bible 2003) (LB03))  
LugandaBible (Luganda 1968 (Ekitabo Ekitukuvu ekiyitibwa Baibuli Endagaano Enkadde n'Empya))
LugandaBIBU1Bible (Luganda (BIBU1) (BIBULIYA ENTUKUVU))
LugandaEEEEBible (Luganda (EEEE) (Endagaano Enkadde n’Endagaano Empya))
LugandaLBRBible (Luganda (LBR) (EKITABO EKITUKUVU, BAIBULI))

루그바라(Lugbara)족은 주로 우간다 북서부의 서나일(West Nile) 지역과 인접한 콩고민주공화국(DRC)의 오리엔탈주에 거주하는 나일계 민족입니다.
LugbaraBible (Lugbara (E’yo Siza Alatararu Munguniri BIBLIA))   

루구루(Luguru)족 또는 울루구루(Uluguru) 산맥은 탄자니아 동부 모로고로(Morogoro) 지역에 위치해 있습니다
LuguruBible (Luguru - Laghano - Ikiruguru - Chilughuru - (Laghano Lya Sambi Kwe Iwanu Wose))    

돌 루오 방언 ( [d̪ólúô] 로 발음되는 ) 또는 나일어족 카비론 도(Nilotic Kavirondo )는 나일어족 의 루오어 그룹 에 속하는 방언
Luo1985Bible (Luo (Acoli Baibul) 1985)  
Luo2015Bible (Luo (MUMA MALER 1976))
Luo2020Bible (Luo 1980 (Motingʼo Loko Manyien))

마사이족(Maasai)은 동아프리카에 거주하는 유목 민족으로, 주로 케냐 남부와 탄자니아 북부의 경계 지역에 걸쳐 살고 있습니다.
Maasai1970Bible (Maasai 1964 (Osotua Ng'ejuk))      
Maasai2020Bible (Maasai 2020 (BIBLIA SINYATI))
MaasaiBible (Maasai 2018 (BIBLIA SINYATI TE NKUTUK OO LMAASAI NATISIRAKI ENG'EJUK NAATA MBUKUI E DITROKANONI))
MaasaiMBSBible (Maasai (Biblia Sinyati))

'마케도니아'는 지리적, 역사적으로 발칸반도 지역을 의미하며, 현재는 크게 두 곳으로 나뉩니다. 
Macedonian1990Bible (Macedonian (Свето Писмо (Гаврилова) 1990))     
Macedonian2006Bible (Macedonian (Свето Писмо Стандардна Библија 2006 (66 книги)))
Macedonian2006DBible (Macedonian 2006 D - (Свето Писмо Стандардна Библија 2006 (со Девтероканонски Книги)))
Macedonian2023Bible (Macedonian 2023 (Нов Превод на Новиот Завет 2023))
MacedonianMKB1999Bible (Macedonian 1999 (MKB) - (Библија Стариот и Новиот Завет, Константинов))
MacedonianMNT1999Bible (Macedonian 1999 (MNT) (Динамичен Превод на Новиот завет на Македонски Јазик))

마두라어(Madurese)는 주로 인도네시아 동자바주의 마두라섬(Madura Island)과 그 주변 섬, 그리고 자바섬 동부 지역에서 사용되는 언어입니다
MadureseBible (Madurese Bible 1994 (ALKETAB E DHALEM BASA MADURA))  

마이틸리어(Maithili)는 주로 인도 북부와 네팔 남동부 지역에서 사용되는 인도아리아어군 언어입니다
MaithiliBible (Maithili - 2010 (Jivən Səndesh))     

마쿠아(Makhuwa, Makua)족과 마쿠아어는 주로 모잠비크 북부 지역에 집중되어 거주하는 반투계 민족 및 언어입니다.
Makhuwa2021Bible (Makhuwa 2021 (Nleehano Nonaanano Imeetto; Moçambique))    
MakhuwaBible (Makhuwa (Makua New Testament))
MakhuwaVMKBible (Makhuwa VMK (Emakhuwa Bible))

마콘데(Makonde)족은 주로 동아프리카의 탄자니아 남부와 모잠비크 북부 접경 지역에 거주하는 부족입니다.
MakondeBible (Makonde (Bibiliya ya Chimakonde))     
MakondeShiBible (Makonde Shimakonde (Ibibiliya mu Shimakonde Imbodi Yaambi na dimbande dya Imbodi Yakala))

마다가스카르(Malagasy)는 아프리카 대륙 동남쪽, 인도양에 위치한 섬나라입니다.
Malagasy1865Bible (Malagasy Bible 1865)     
Malagasy2003Bible (Malagasy 2003 (Baiboly Katolika))
Malagasy2004Bible (Malagasy 2004 (DIEM PROTESTANTA))
Malagasy2011Bible (Malagasy (Baiboly Protestanta Malagasy 2011))
MalagasyBible (Malagasy 2019 (Baiboly Protestanta Malagasy))
MalagasyMRVBible (Malagasy MRV 2011 (La Bible en Malgache))

말라얄람어는 인도에서 상당수의 사람들이 사용하는 언어이며 케랄라 주의 주요 언어입니다.
Malayalam1910Bible (Malayalam (മലയാളം സത്യവേദപുസ്തകം 1910 പതിപ്പ് (പരിഷ്കരിച്ച ലിപിയിൽ)))        
Malayalam2013Bible (Malayalam Bible POC-ML 2013)
MalayalamBCSBible (Malayalam Bible (IRV) 2019 (ഇന്ത്യൻ റിവൈസ്ഡ് വേർഷൻ - മലയാളം))
MalayalamBible (Malayalam 1992 MBSI)
MalayalamBSIBible (Malayalam (BSI) 2016 (സത്യവേദപുസ്തകം C.L. (BSI)))
MalayalamCVBible (Malayalam Contemporary Version (സമകാലിക മലയാളവിവർത്തനം))
MalayalamMalovBible (Malayalam Bible (OV-BSI) 2016 (സത്യവേദപുസ്തകം OV Bible (BSI)))
MalayalamWBTCBible (Malayalam (ERV) WBTC Bible)

말레이시아는 동남아시아의 태국 아래 위치한 국가로, 남중국해를 사이에 두고 말레이반도의 서말레이시아와 보르네오섬 북부의 동말레이시아 두 지역으로 나뉘어 있습니다.
Malaysian1996Bible (Malaysian (BM) 1996 (Alkitab Berita Baik Protestant Bible))     
Malaysian2017Bible (Malaysian 2017 (Perjanjian Baru Bahasa Manado))
Malaysian2020Bible (Malaysian 2020 (Perjanjian Baru Bahasa Melayu Maluku Utara))
MalaysianBible (Malaysian Version 2008)

마오리족(Māori)은 뉴질랜드(New Zealand)의 원주민입니다.
Maori2012Bible (Maori (Paipera Tapu 2012))      
MaoriBible (Maori MRI1952 (Te Paipera Tapu 1952))

마라티어는 인도의 22개 공용어 중 하나
Marathi2015Bible (Marathi MARVBSI (पवित्र शास्त्र RV (Re-edited) Bible (BSI)))       
MarathiBible (Marathi 2006 ERV WBTC)
MarathiBSIBible (Marathi MACLBSI (पवित्र शास्त्र CL New Testament (BSI)))
MarathiIRVMARBible (Marathı IRV (इंडियन रीवाइज्ड वर्जन (IRV) - मराठी))
MarathiMRCVBible (Marathi MRCV (पवित्रशास्त्र, मराठी समकालीन आवृत्ती))

마르와리(Marwari)는 인도 서부 라자스탄(Rajasthan)주의 마르와르(Marwar, 현 조드푸르 일대) 지역을 기반으로 하는 상인 공동체입니다
MarwariBible (Marwari Bible)    

마잔다라니(Mazanderani)는 주로 이란 북부, 카스피해 남쪽 연안 지역에 거주하는 마잔다라니족이 사용하는 언어이자 그 지역을 뜻합니다
MazanderaniGMBBible (Mazanderani GMB (گیله ماز))
MazanderaniBible (Mazanderani EMB (کتاب مقدس به زبان مازندرانی - گویش شرقی))    
MazanderaniWMBBible (Mazanderani WMB (کتاب مقدس به زبان مازندرانی - گویش غربی))

메이테이족(Meitei)은 주로 인도 동북부 마니푸르(Manipur)주에 거주하는 토착 민족입니다
MeiteiBible (Meitei Bible (Anouba Warepnaba (Roman Script)) 2022)   

망드(Mende)는 프랑스 남부 옥시타니(Occitanie) 레지옹의 로제르(Lozère)주에 위치한 도시이며, 로제르주의 주도(Prefecture)입니다
MendeBible (Mende (Nupela Testamen long tokples Mende long Niugini))    

'메와리(Mewari)'는 인도 라자스탄주(Rajasthan) 남동부의 역사적 지역인 '메와르(Mewar)' 지역을 가리키거나, 그 지역에서 사용하는 언어를 뜻합니다
MewariBible (Mewari (नुवो नेम (मेवड़ी नया नियम)))   

미조어 (Duhlián ṭawng 이라고도 함)는 주로 인도 미조람 주에서 사용되는 티베트-버마어족 언어로, 미조람 주의 공식 언어 이자 공용어 입니다
MizoBible (Mizo Bible)  
MizoCLBSIBible (Mizo CL BSI (Common Language))
MizoOVBSIBible (Mizo OV BSI (THUTHLUNG HLUI (Re-edited) Bible (BSI)))

MobaBible (Moba (Yiesu Lɑbɑmɑnn Muɑl Ni))

몰도바(Moldova)는 동유럽에 위치한 내륙국입니다
MoldovianCyrillicBible (Moldovian Bible Cyrillic - (Ени Бааланты) (GAGNTC) 2006)     
MoldovianLatinBible (Moldovian Bible Latin - 2006 (Enі Baalantı))

몽골(Mongolia)은 동아시아 중앙부, 러시아(북쪽)와 중국(남쪽) 사이에 위치한 내륙국입니다
Mongolian2004Bible (Mongolian (Ариун Библи, 2004))      
Mongolian2013Bible (Mongolian (Ариун Библи 2013))

모리셔스 크레올어는 1968년 영국으로부터 독립한 모리셔스 공화국의 공용어 입니다
Morisyen2021Bible (Morisyen (Nouvo Testaman Kreol Morisien Harmonisation NTPS KM))      
MorisyenBible (Morisyen (Nouvo Testaman dan Kreol Morisien))

Mossi2014Bible (Mossi MPBU (WẼNNAAM SEBRE 2014))
MossiSBBible (Mossi Moore (KÃAB-PAALGÃ KOE-NOOGO))
MossiSSDCBible (Mossi (SEBR SÕNGO) 1998)

문다(Munda)는 솔로몬 제도, 웨스턴 주(Western Province) 뉴조지아 섬에 위치한 도시이자 마을입니다.
Munda2020Bible (Munda 2020 (ପାର୍‌ମେଶ୍ୱାର୍‌ଆଃ ଜୀନିଦ୍‌ ବାଚାନ୍‌, ନାୱା ନିୟାମ୍‌))  
MundaBible (Munda (ମୁଣ୍ଡା ନାୱା ନିୟାମ୍))

나와틀어(Nahuatl)는 주로 멕시코(Mexico) 중부 및 남부 지역에서 사용되는 토착 원주민 언어입니다
Nahuatl2012Bible (Nahuatl (Zacatlán, Ahuacatlán, Tepetzintla))  
Nahuatl2017Bible (Nahuatl 2017 (El Nuevo Testamento))
NahuatlBible (Nahuatl 1987 (In yencuic iyectlajtoltzin Dios itech ica toTeco Jesucristo))
NahuatlGUBible (Nahuatl GU (El Nuevo Testamento))
NahuatlNHEBible (Nahuatl NHE (Ya ni nopa yancuic tlajtoli tlen toteco toca mocajtoc))

모잠비크 성서 공회(Bible Society of Mozambique)에서 발행한 버전
Ndau2023Bible (Ndau 2023 (NOVO TESTAMENTO EM NDAU))     
NdauBible (Ndau (Bhaibheri Rakachena muChindau))

은데벨레족(Ndebele)은 주로 남아프리카 공화국과 짐바브웨에 거주하는 응구니 계통의 토착 종족입니다
Ndebele2002Bible (Ndebele Bible 1978 (iBhayibhili Elingcwele 1978))     
Ndebele2003Bible (Ndebele 2003 BEN (IBhayibhili Elingcwele LesiNdebele))
Ndebele2012Bible (Ndebele Bible (SND) 2012 (IsiNdebele 2012 Translation))
NdebeleBible (Ndebele Bible - 2010)

네팔어(Nepali)는 주로 네팔(Nepal)의 공용어이자 모국어입니다.
Nepali2008Bible (Nepali 2008 - (सरल नेपाली पवित्र बाइबल))      
Nepali2012Bible (Nepali 2012 (NNRV) New Revised Version (नेपाली नयाँ संशोधित संस्करण))
Nepali2021Bible (Nepali Contemporary Version 2021 (पवित्र बाइबल, नेपाली समकालीन संस्करण))
NepaliBible (Nepali ERV (पवित्र बाइबल))
NepaliTamangBible (Nepali Tamang 2011)

나이지리아(Nigeria)는 서아프리카에 위치한 국가입니다
NigerianPidginBible (Nigerian Pidgin Bible)     
    
노르웨이지안 에어 셔틀(Norwegian Air Shuttle)의 본사는 노르웨이 포르네부(Fornebu)에 위치해 있습니다
Norwegian1921Bible (Norwegian 1921 (Studentmållagsbibelen) (SMB))   
Norwegian1938Bible (Norwegian 1938 (Norsk Oversettelse 1938 Nynorsk))
Norwegian1978Bible (Norwegian (Bibelen 2011 Bokmål))
Norwegian2007Bible (Norwegian NB (Norsk Bibel 1988, 2007))
Norwegian2011Bible (Norwegian Brød Nye Testamente 2011)
Norwegian2018Bible (Norwegian 2018 (Bibelen - Guds Ord Hverdagsbibelen (Hermon Forlag)))
NorwegianBGOBible (Norwegian (Bibelen – Guds Ord 2017))
NorwegianBIBEL1978Bible (Norwegian 1978 (Bibel1978, 1985 - Bibelselskapet))
NorwegianBible (Norwegian 1930 (Det Norsk Bibelselskap 1930))
NorwegianELBBible (Norwegian ELB (En Levende Bok))
NorwegianN78BMBible (Norwegian (N78BM) (The Bible in Norwegian 1978, 1985 bokmål))
NorwegianN78NNBible (Norwegian (N78NN) (Bibelen 1978, 1985 Nynorsk))
NorwegianNY2011Bible (Norwegian 2011 (Bibelen 2011 Nynorsk))

누에르인(Nuer people)은 주로 남수단(South Sudan)과 에티오피아(Ethiopia) 접경 지역에 거주하는 나일계 민족입니다
NuerBible (Nuer (RUAC KUƆTH IN RƐL RƆ))     

루간다어(Luganda)로 된 성경을 의미합니다
Nyankole1964Bible (Nyankole 1964 (Baibuli Erikwera))        
NyankoleBible (Nyankole (EKITABO EKIRIKWERA BAIBULI N'EBITABO EBY'OMUBONANO APOKURUFADYUTROKANONIKO))

Odia(오디아어/오리야어)는 주로 인도 동부의 오디샤(Odisha) 주에서 사용되는 언어입니다
Odia2024Bible (Odia NTS2024 2024 (ದೆವಾಚಿ ಖರಿ ಖಬರ್))      
OdiaBible (Odia - 1840)
OdiaBSIBible (Odia BSI (ପବିତ୍ର ବାଇବଲ (CL) NT (BSI)))
OdiaERVBible (Odia Bible ERV 2004 (ପବିତ୍ର ବାଇବଲ))
OdiaIRV2017Bible (Odia IRV 2017 (ଓଡିଆ ବାଇବେଲ))
OdiaIRVBible (Odia IRV (ଇଣ୍ଡିୟାନ ରିୱାଇସ୍ଡ୍ ୱରସନ୍ ଓଡିଆ -NT))
OdiaOROVBible (Odia 2014 (Re-edited) (ପବିତ୍ର ବାଇବଲ (Re-edited) - (BSI)))

그리스(Greece)는 동남유럽 발칸반도 남쪽 끝에 위치하며, 지중해에 접해 있는 나라입니다
OriginalGreekBible (Greek New Testament)    

히브리어(Hebrew)는 주로 이스라엘에서 사용되는 공용어이며, 아프리카아시아어족에 속하는 셈어파 언어입니다.
OriginalHebrewBible (Hebrew)    

오로모(Oromo)족은 주로 동아프리카에 거주하는 민족 집단입니다. 
OromoGUJBible (Oromo Gujiii (KITAABA WOYYICHA))     
OromoGujiBible (Oromo Bible (Guji) 2007)
OromoKakuuHaaraakaBible (Oromo Bible (Kakuu Haaraaka))
OromoKitaabaWaaqaBible (Oromo Bible (KITAABA WAAQA) 2019)
OromoKitaabaWoyyuuBible (Oromo Bible (Kitaaba Woyyuu))
OromoWaadaaHaarawaBible (Oromo Bible (Waadaa Haarawa))
OromoWaadaaLammataaBible (Oromo Bible (WAADAA LAMMATAA) 2013)

팜팡가(Pampanga)는 필리핀의 루손섬 센트럴 루손 지방에 위치한 주입니다
PampangaBible (Pampanga (Ing Mayap a Balita Biblia))        

파푸아(Papua)는 뉴기니섬(New Guinea)의 서쪽 절반을 차지하고 있는 인도네시아의 영토입니다
PapuaNewGuineaBible (Papua New Guinea 1997)     
PapuaNewGuineaTokPisinBible (Papua New Guinea Tok Pisin (Buk Baibel Long Tok Pisin 2008 + DC))

파슈토어는 주로 파슈툰 족이 모국어로 사용하는 언어이며, 아프가니스탄의 두 공식 언어 중 하나로 다리어 와 함께 사용됩니다
Pashto2019Bible (Pashto 2019 (Pakistani Yousafzai Pashto))      
Pashto2023Bible (Pashto 2023 (Afghan Pashto Bible))
PashtoBible (Pashto Bible 1996 (Nangahari) - (د پښتو مقدس کتاب))

페르시아(Persia)는 현재의 이란(Iran) 이슬람 공화국입니다. 서남아시아에 위치한 이란의 옛 명칭으로, 1935년 페르시아에서 이란으로 국명을 변경하였습니다
Persian2005Bible (Persian Bible (FACB) 2005 - Persian Contemporary Bible)       
Persian2014Bible (Persian Bible (NMV) 2014 - New Millennium Version)
PersianBible (Persian Bible, POV (Persian Old Version) 1895)
PersianDariBible (Persian Dari Bible - Afgan Dialect - Version Good News for a New Age (GNN) == 2007)
PersianTPVBible (Persian TPV (مژده برای عصر جدید))

폴란드(Poland/Polska)는 중부 유럽에 위치한 국가입니다
Polish2016Bible (Polish 2016 (Słowo Życia))     
Polish2018Bible (Polish 2018 (Biblia, to jest Pismo Święte Starego i Nowego Przymierza Wydanie pierwsze 2018))
PolishBible (Polish (Biblia Warszawska 1975))
PolishGdansk2017Bible (Polish Gdansk 2018 (UWSPÓŁCZEŚNIONA BIBLIA GDAŃSKA))
PolishGdanskBible (Polish Gdansk 1881 - 1910 (Biblia Gdańska))
PolishNBGBible (Polish NBG (Nowa Biblia Gdańska))
PolishNPDBible (Polish NPD (Dobra Wiadomość o ratunku w Chrystusie. Nowy Przekład Dynamiczny Nowego Testamentu))
PolishSNPD4Bible (Polish SNPD4 (Biblia, to jest Pismo Święte Starego i Nowego Przymierza))

포르투갈어(Portuguese)
Portuguese1969Bible (Portuguese Bible Old Orthography)      
PortugueseA21Bible (Portuguese A21 (Biblia Almeida Século 21))
PortugueseAlmeida1628Bible (Portuguese Almeida 1628)
PortugueseAlmeida1753Bible (Portuguese Almeida 1753)
PortugueseARCBible (Portuguese ARC 2009 (Almeida Revista e Corrigida))
PortugueseBible (Portuguese Almeida Revista e Atualizada)
PortugueseBLTBible (Portuguese BLT Biblia Livre Para Todos)
PortugueseBPT09Bible (Portuguese BPT09 (Aprenda Mais Sobre a BÍBLIA para todos Edição Comum))
PortugueseCAPBible (Portuguese (CAP) Capuchinhos)
PortugueseMZNVIBible (Portuguese (Nova Versão Internacional, Português de Moçambique))
PortugueseNAABible (Portuguese NAA 2017 (Nova Almeida Atualizada))
PortugueseNBV2007Bible (Portuguese NBV-P (Nova Bíblia Viva Português))
PortugueseNTLHBible (Portuguese NTLH (Nova Tradução na Linguagem de Hoje))
PortugueseNVI2023Bible (Portuguese NVI 2023)
PortugueseNVIBible (Portuguese NVI 2000)
PortugueseNVTBible (Portuguese NVT (Bíblia Sagrada, Nova Versão Transformadora))
PortugueseOLBible (Portuguese OL 2017 (O Livro))
PortugueseTBBible (Portuguese TB (Tradução Brasileira))
PortugueseVFLBible (Portuguese (Bíblia Sagrada Versão Fácil de Ler) VFL)
PularBible (Pular (Version Pular Fuuta-Jallon))

'펀자브(Punjab)'는 남아시아 지역으로, 현재 인도 북서부와 파키스탄 동부에 걸쳐 있는 지역입니다
Punjabi2016Bible (Punjabi Bible 2016 - ਪਵਿੱਤਰ ਬਾਈਬਲ O.V.)      
Punjabi2020Bible (Punjabi Revised 2020 (Arabic Script) (پنجابی نواں عہد نامہ نظرثانی شدہ چھپائی))
Punjabi2021Bible (Punjabi 2021 CL-NA (ਪਵਿੱਤਰ ਬਾਈਬਲ (Revised Common Language North American Edition)))
Punjabi2022Bible (Punjabi 2022 (ਪੰਜਾਬੀ ਮੌਜੂਦਾ ਤਰਜਮਾ))
Punjabi2023Bible (Punjabi Standard Bible (Punjabi Standard Bible) 2023)
PunjabiBible (Punjabi ERV)
PunjabiERVBible (Punjabi 2002 ERV (ਪਵਿੱਤਰ ਬਾਈਬਲ))
PunjabiIRVBible (Punjabi RV (ਇੰਡਿਅਨ ਰਿਵਾਇਜ਼ਡ ਵਰਜ਼ਨ (IRV) - ਪੰਜਾਬੀ))

Q'eqchi'(케크치) 마야족은 주로 과테말라(Guatemala)와 벨리즈(Belize) 지역에 거주하는 원주민입니다
QeqchiBible (Qeqchi)    

케추아어(Quechua)와 케추아족은 주로 남아메리카 안데스 산맥 고원 지대에 위치하고 있습니다.
Quechuan2010Bible (Quechuan Bible 2011 (QUB))       
QuechuanBible (Quechuan - 1972)
QuechuanQVBMBible (Quechuan (Tayta Diospa Wilakuynin) 2003)
QuechuanQVSBible (Quechuan QVS 1992 (San Martín))
QuechuanQVWBible (Quechua (Huaylla Wanca))
QuechuanQXOBible (Quechuan QXO (Biblia en Quechua del sur de Conchucos))

로마니(Romani, 일명 집시)족은 인도 아대륙, 특히 북서부의 라자스탄 및 펀자브 지역에서 기원한 민족입니다
Romani2004Bible (Romani (E Nevi Viasta o Psalmo 2004 (Maximoff - Kalderaš)))    
Romani2007Bible (Romani Chile (Vlax Chileana) (Nuevo Testamento Romané 2007))
Romanian1928Bible (Romanian Cornilescu 1928)
Romanian1931Bible (Romanian 1931 (Traducere Literală Cornilescu 1931))
Romanian2009Bible (Romanian 2009 (Română Noul Testament Interconfesional 2009))
Romanian2014Bible (Romanian 2014 (Biblia în Versuri 2014))
Romanian2015Bible (Romanian 2015 (Biblia Traducerea Fidela 2015))
Romanian2018Bible (Romanian 2018 (Biblia în Versiune Actualizată 2018))
Romanian2020Bible (Romanian 2020 (Versiunea Biblia Romano Catolică 2020))
Romanian2021Bible (Romanian 2021 (Noua Traducere Românească))
Romanian2022Bible (Romanian (Ediția Dumitru Cornilescu revizuită 2022))
Romanian2023Bible (Romanian 2023 (Noul Testament SBR 2023))
RomanianBDKBible (Romanian BDK 1924 (Библия Думитру Корнилеску 1924))
RomanianBible (Romanian VDC 1924 (Biblia sau Sfânta Scriptură cu Trimiteri 1924, Dumitru Cornilescu))
RomanianSBIRBible (Romanian SBIR (Biblia Dumitru Cornilescu 2024))
RomaniBACHROBible (Romani Ursari 2018 (Biblia ande Chib Romani))
RomaniBaltic2019Bible (Romani Baltic (Библия - Пэ Балтитко Романи чиб (Романэс) 2019))
RomaniBalticLT2019Bible (Romani Baltic Latin (Biblija - Pe Baltitko Romani čib (Romanes) 2019))
RomaniBible (Romani 1984)
RomaniCHERGASHBible (Romani Chergash Ursari (Biblija pe Romani Čhib))
RomaniGSPBible (Romani Ursari (E Devleso Lafi ko Gurbetsko Dijalekt))
RomaniKALD2004Bible (Romani 2004 Kalderaš (E Nevi Viasta o Psalmo 2004 (Maximoff - Kalderaš)))
RomaniKALD2020Bible (Romani from Romanian (E Romaii Biblia 2020 (Kăldărărihko)))
RomaniRMCBible (Romani Slovakian RMC (Le Devleskero Lav Andre Romaňi Čhib Slovensko 2021))
RomaniROM07Bible (Romani Chilean (Nuevo Testamento Romané 2007))
RomaniROM6Bible (Romani German (ROM6) (O Debleskro Drom 2021))
RomaniSERBible (Romani Serbian (Romski prevod Novog zaveta - Srbija))
RomaniSINT2024Bible (Romani Sinte 2024 (O Debleskro Lab 2024 (Sinte-Manouche)))

러시아(Russian Federation)는 유라시아 대륙 북부에 위치한 세계에서 가장 영토가 넓은 나라로, 동유럽에서 북아시아에 걸쳐 있습니다.
Russian2012Bible (Russian 2012 - Радостная Весть - Современный Русский Перевод)     
RussianAGPBible (Russian Bible 2004 - Agape Bible - Nicholas Olizarevich)
RussianBTI2015Bible (Russian BTI 2015 - Библия под ред. М.П. Кулакова и М.М. Кулакова (BTI))
RussianCARSABible (Russian (CARSA) (Восточный перевод))
RussianCARSBible (Russian Восточный Перевод (CARS))
RussianCASBible (Russian CAS Bible 1970 - Новый Завет, перевод под ред. еп. Кассиана Безобразова)
RussianCSLAVBible (Russian CSLAV (Библия на Церковнославянском Языке))
RussianJewishBible (Russian Jewish Bible 1989 - Еврейский Новый Завет - Перевод с англ. A. Долбин, В. Долбина)
RussianJubileeBible (Russian Jubilee Bible 2010 - Библия. Юбилейное издание)
RussianMengeBible (Russian Bible Menge - Библия Менге info - Переведено с немецкого перевода Германа Менге - Hermann August Menge)
RussianNRTBible (Russian NRT (Новый Русский Перевод))
RussianReceptusBible (Russian 2014 - Новый Завет по тексту большинства - Textus Receptus)
RussianRSPBible (Russian (RSP) (Святая Библия Современный перевод))
RussianRSTBible (Russian RST Bible - 1900-1907 - Книги Священнаго Писанія Ветхаго и Новаго Завѣта въ русскомъ переводѣ съ параллельными мѣстами.)
RussianSlovoBible (Russian New Russian Translation (NRT) (IBS) (Slovo Zhizny) Новый Русский Перевод)
RussianSynodalBible (Russian Synodal 1876)
RussianWBTCBible (Russian Современный Перевод Библии WBTC 1993)

사드리(Sadri)는 인도 라자스탄(Rajasthan) 주 팔리(Pali) 지구에 위치한 자치시(Municipality)입니다
SadriBible (Sadri (सादरी नवाँ नियम))     

산스크리트어(Sanskrit)를 표기하는 가장 대표적인 문자 체계인 데바나가리(Devanagari)는 주로 인도와 네팔 전역에서 사용됩니다
SanskritDevanagariBible (Sanskrit Bible (NT) in Devanagari Script (सत्यवेद))      

산탈어(Santali)는 주로 인도 동부 지역에서 사용되는 오스트로아시아어족 문다어파에 속하는 언어입니다
SantaliBangladeshBible (Santali Bible (সান্তালী বাইবেল))      
SantaliCommonBible (Santali Bible (Common Language New Testament))

사삭(Sasak)족은 인도네시아 서누사텐가라주 롬복섬(Lombok Island)의 토착 원주민으로, 섬 인구의 90% 이상을 차지합니다.
SasakBible (Sasak (KITAB SUCI ZABUR INJIL))     

세나족은 모잠비크 북서부 지역, 소팔라 주 , 잠베지아 주 에 기원을 둔 반투족 언어 집단입니다
Sena2014Bible (Sena 2014 (Cibverano Cipsa))     
SenaBible (Sena (Cibverano Cipsa Cisena 2013))
SenaMalawiBible (Sena Malawi)

시라이키어는 파키스탄 에서 사용되는 인도아리아어족 언어입니다
SeraikiBible (Seraiki (کِتاب مُقدّس سرائیکی ترجمہ))    

세르비아(Serbia)는 동남유럽 중앙의 발칸반도에 위치한 내륙국입니다
SerbianBible (Serbian Cyrillic Version)     
SerbianCNZBible (Serbian CNZ (Нови српски превод Стари завет Проф. др Драган Милин и Нови завет Проф. др Емилијан Чарнић))
SerbianERVBible (Serbian (ERV) (Библија Савремени Српски Превод))
SerbianLatinBible (Serbian Latin Version  1865)
SerbianNSTBible (Serbian (NST) (Нови Српски Превод))
SerbianNSTLBible (Serbian (NSTL) 2017 (Novi Srpski Prevod))
SerbianSDSBible (Serbian Bible (SDS) 1934)

'Shan(샨)'은 주로 미얀마 동부에 위치한 샨 주(Shan State)를 의미합니다.
ShanBible (Shan (သမ်ႇမႃႇၵျၢမ်းလိၵ်ႈ ထႃႇဝရႃႉၽြႂး))     
ShanNCLBible (Shan NCL (သမ်ႇမႃႇၵျၢမ်းလိၵ်ႈ ထႃႇဝရႃႉၽြႃး))

셰카와티(Shekhawati)는 인도 라자스탄주 북동부에 위치한 지역으로, 시카르(Sikar), 주준주누(Jhunjhunu), 추루(Churu) 구를 포함하는 역사적인 명소입니다
ShekhawatiBible (Shekhawati (जीवन को च्यानणो (सेकावाटी नया नियम की पोथ्या)))   

\실룩족(Shilluk)은 남수단(South Sudan)의 북동부, 상나일주(Upper Nile State)에 위치한 백나일강(White Nile) 서쪽 은행을 따라 거주하는 나일로틱(Nilotic) 민족입니다
ShillukBible (Shilluk (WÄNYI KWËRØ 2011))   

쇼나(Shona)족과 그 언어는 주로 아프리카 남부 짐바브웨(Zimbabwe)를 중심으로 거주하고 있습니다
Shona1949Bible (Baiberi Magwaro Matȿene aMŋari 1949 (Doke))     
Shona2002Bible (Shona (Shona Bible 1949, revised 2002))
ShonaBDSCBible (Shona (Bhaibheri Dzvene MuChiShona Chanhasi))
ShonaBible (Shona 2009)
ShonaSCLBBible (Shona (Bhaibhiri Idzva rechiShona))
ShonaSUBBible (Shona SUB 2002 Bible)

시다모(Sidamo)는 에티오피아 남부에 위치한 세계적인 커피 생산 지역입니다
SidamoBible (Sidamo (Qullaawa Maxaafa))     

신드어(Sindhi)는 주로 파키스탄의 신드(Sindh) 주에서 사용되는 인도아리아어군의 언어입니다. 
SindhiBible (Sindhi Bible status=Sindhi Bible © Pakistan Bible Society, 1954,1962.)     
SindhiCommonBible (Sindhi Bible (Common Language New Testament))
SindhiHinduBible (Sindhi Bible (Hindu) (Hindu Sindhi New Testament © The Pakistan Bible Society, 2022) - پوِتر شاستر يسوع مسيح جي خوشخبري)
SindhiMuslimBible (Sindhi Bible (Muslim) (مقدس ڪلام توريت، زبور ۽ نبين جون ٻيو لکتون ۽ انجيل شريف))

싱할라어(Sinhala)는 스리랑카(Sri Lanka)의 공용어이자 국가 언어입니다
SinhalaNRSVBible (Sinhala Bile - New Revised Version (NRSV))    
SinhalaSCVBible (Sinhala (SCV) 2020 (සිංහල කාලීන පරිවර්තනය))
SinhalaSNRVBible (Sinhala SNRV (New Revised Version 2018))
SinhalaSROVBible (Sinhala Bile - Revised Old Version (SROV))

스와티어(SiSwati)는 주로 아프리카 남부에서 사용되는 언어입니다
SiswatiBible (Siswati 1996 Bible)       

슬로바키아(Slovakia)는 중앙유럽(중유럽)에 위치한 내륙국입니다
Slovakian2015Bible (Slovakian Bible - Botekov 2015)     
Slovakian2017Bible (Slovakian 2017 (Slovenský Ekumenický Preklad s DT Knihami))
SlovakianBible (Slovakian 1936 (ROH - Roháčkov Preklad))
SlovakianNPK2023Bible (Slovakian (NPK) (Nádej Pre Kazdého) 2023)
SlovakianNPKBible (Slovakian Bible (NPK) 1993 - (Nádej Pre Kazdého))
SlovakianRomaniBible (Slovakian Bible - Rómska Nová Zmluva 2014)
SlovakianSEBBible (Slovakian 2017 (Slovenský Ekumenický Preklad))
SlovakianSLBBible (Slovakian (Evanjelický preklad))
SlovakianSSVBible (Slovakian (Sväté Písmo - Katolícky Preklad))

슬로베니아(Slovenia)는 중앙유럽 남부에 위치한 나라입니다    
Slovenian1584Bible (Slovenian (Dalmatinova Biblija 1584))   
Slovenian1882Bible (Slovenian Josipa Stritarja (1882) SloStritar)
Slovenian1928Bible (Slovenian (Prekmurska NZ and Psalmi (1928)))
Slovenian1990Bible (Slovenian (JUB) 1990 (Jubilejni Prevod Nove Zaveze))
Slovenian2014Bible (Slovenian (ZNZ) 2014 (Živa Nova Zaveza))
SlovenianBible (Slovenian 2014 (Chráskov Prevod))
SlovenianEKUBible (Slovenian EKU (Ekumenska izdaja))
SlovenianSSPBible (Slovenian SSP (Slovenski Standardni Prevod))

Baibuli'는 아프리카 우간다의 주요 언어인 루간다어(Luganda)로 된 성경을 뜻합니다
SogaBible (Soga (Baibuli Ekibono kya Katonda 2014)) 

소말리아(Somalia)는 아프리카 동부, 일명 '아프리카의 뿔(Horn of Africa)'이라 불리는 지역의 최동단에 위치해 있습니다
Somalian2018Bible (Somalian 2018 (KITAABKA QUDUUSKA AH))        
Somalian2024Bible (Somalian 2024 (Ereyga Illaahey Axdiga Cusub))
SomalianBible (Somalian (Kitaabka Quduuska Ah))

SongeBible (Songe (NTETO INJEGA CIA MURUNGU KIRI ANTU BONTHE CATHOLIC EDITION))

소토(Sotho, 바소토족/Basotho)는 남부 아프리카의 내륙에 위치한 국가 레소토(Lesotho)와 남아프리카 공화국(남아공) 일대에 주로 거주하는 민족 및 그들의 언어(세소토어)를 의미합니다.
Sotho1951Bible (Sotho 1951 (BIBELE))        
Sotho1989Bible (Sotho Bible 1989 (BIBELE))
Sotho2000Bible (Sotho 2000 (BIBELE Taba yea Botse))
SothoBible (Sotho 2024 (Contemporary Sepedi Nothern Sotho Bible 2024))

스페인어
Spanish1569Bible (Spanish 1569)     
Spanish1858Bible (Spanish Reina Valera NT 1858)
Spanish1989Bible (Spanish 1989)
SpanishBDOBible (Spanish BDO 1973 (Biblia del Oso 1573))
SpanishBHTIBible (Spanish BHTI (Traducción Interconfesional, versión hispanoamericana))
SpanishBible (Spanish RVR 1909 (Más información sobre Biblia Reina Valera 1909))
SpanishBLPBible (Spanish BLP (La Palabra (versión española)))
SpanishBLPHBible (Spanish BLPH (La Palabra (versión hispanoamericana)))
SpanishBTIBible (Spanish BTI (La Biblia, Traducción Interconfesional (versión española)))
SpanishBTXBible (Spanish La Biblia Textual (BTX) Biblia Hebraica Stuttgartensia 1999)
SpanishDHHBible (Spanish DHH 1996)
SpanishJBSBible (Spanish JBS (Biblia del Jubileo))
SpanishLBLABible (Spanish Bible LBLB (La Biblia De Las Américas) 1997)
SpanishNBLABible (Spanish NBLA (Nueva Biblia de las Américas))
SpanishNBVBible (Spanish NBV (Nueva Biblia Viva))
SpanishNTBIZBible (Spanish NTBIZ (Segun el Texto Bizantino 2005))
SpanishNTVBible (Spanish NTV (Nueva Traducción Viviente))
SpanishNVIBible (Spanish NVI Bible - Nueva Versión Internacional)
SpanishNVISBible (Spanish NVIS (La Santa Biblia, Nueva Versión Internacional Simplificada))
SpanishPDTBible (Spanish PDT (La Biblia La Palabra de Dios para todos))
SpanishRevisedRVR1960Bible (Spanish Reina-Valera RVR 1960 (Revised Reina Valera 1960))
SpanishRV2020Bible (Spanish RV2020 (Reina Valera 2020))
SpanishRVA2015Bible (Spanish RVA2015 (Reina Valera Actualizada))
SpanishRVCBible (Spanish RVC (Reina Valera Contemporánea))
SpanishRVESBible (Spanish RVES (Reina-Valera Antigua))
SpanishRVGBible (Spanish Bible RVG - Reina Valera Gómez 2004)
SpanishRVR1960Bible (Spanish RVR 1960 (Más información sobre Biblia Reina Valera 1960))
SpanishRVR1995Bible (Spanish RVR 1995 (Biblia Reina Valera 1995))
SpanishTLABible (Spanish TLA (Traducción en Lenguaje Actual))
SpanishVBL2022Bible (Spanish VBL 2022 (Versión Biblia Libre))
SpanishVBLBible (Spanish Version Is Called = Free Bible Version)

Sukuma1960Bible (Sukuma (Ilagano Ipya Lya))
SukumaBible (Sukuma New Testament 2000)

순다족(Sundanese)과 순다어는 인도네시아 자바섬 서부 지역에 기반을 두고 있습니다.
SundaneseBible (Sundanese Bible (Sunda) - KITAB SUCI (LAISUN) 1991) 

스와힐리어(Swahili)는 주로 동아프리카 지역에서 널리 쓰이는 반투어군 언어입니다. 케냐, 탄자니아, 우간다, 르완다의 공식 언어
Swahili1850Bible (Swahili 1850 - Biblia Takatifu)   
Swahili2001Bible (Swahili (BHN) (Habari Njema) 2001)
Swahili2017Bible (Swahili (TKU) 2017 (Jipya Tafsiri ya Kusoma-Kwa-Urahisi))
Swahili2024Bible (Swahili (Neno Maandiko Matakatifu 2024))
SwahiliBHNTLKBible (Swahili BHNTLK (Biblia Habari Njema Toleo la Kujifunza))
SwahiliBible (Swahili (SRUV) (Swahili Revised Union Version))
SwahiliContemporaryBible (Swahili NEN (Neno Bibilia Takatifu 2025))
SwahiliNMMBible (Swahili NMM (Neno Maandiko Matakatifu) 2018)
SwahiliRSUVDCBible (Swahili RSUVDC (BIBLIA KISWAHILI))
SwahiliSCLDC10Bible (Swahili SCLDC10 (BIBLIA Yenye Vitabu vya Deuterokanoni HABARI NJEMA))
SwahiliSRB37Bible (Swahili SRB37 (Swahili Roehl Bible 1937))
SwahiliSUVBible (Swahili SUV (Maandiko Matakatifu ya Mungu Yaitwayo Biblia))
SwahiliSWC02Bible (Swahili SWC02 (BIBLIA ﻿Maandiko Matakatifu Kwa Watu Wote 2002))
SwahiliSWZZB1921Bible (Swahili SWZZB1921 (New Testament in Swahili (Zanzibar) Revised Edition 1921))

스웨덴(Sweden)은 북유럽 스칸디나비아 반도에 위치한 나라입니다
Swedish1873Bible (Swedish Karl XII 1873 (Karl XII 1873))    
Swedish2000Bible (Swedish (B2000) (Bibel 2000))
Swedish2015Bible (Swedish (NUB) (nuBibeln) 2015)
Swedish2019Bible (Swedish Bible (RFBNT) (Svenska Reformationsbibeln))
SwedishBible (Swedish (Svenska 1917))
SwedishFolkBible (Swedish Folk 1998 (Svenska Folkbibeln))
SwedishNLBBible (Swedish (New Living Bible) (NLB) 2004 (Nya Levande Bibeln))
SwedishSB2016Bible (Swedish (SB) 2016 (Svenskbibel))
SwedishSFBBible (Swedish (SFB) (Svenska Folkbibeln 2015))

실헤티(Sylheti)는 주로 방글라데시 동북부와 인도 동북부 지역에서 사용되는 인도-아리안 언어입니다
SylhetiBible (Sylheti (ছিলটি আছমানি কিতাব (বাংলা লিপি)))   
SylhetiSYLLBible (Sylheti SYLL (Siloṭi Asmani Kitab (Latin lipi)))

타갈로그어(Tagalog)는 필리핀의 공식 언어인 필리피노어의 기반이 되는 언어로, 주로 필리핀 루손 섬 중남부 지역(마닐라 포함)에서 사용됩니다
Tagalog2001Bible (Tagalog (Ang Biblia 2001))    
Tagalog2005Bible (Tagalog 2005 (Magandang Balita Biblia (2005)))
Tagalog2012Bible (Tagalog 2012 (Magandang Balita Biblia))
Tagalog2015Bible (Tagalog (Ang Salita ng Dios))
TagalogBible (Tagalog (TLAB) 1905 (Ang Biblia (1905, 1982)))
TagalogRevised2005Bible (Tagalog 2005 Revised (Magandang Balita Bible (Revised)))
TagalogTLBABible (Tagalog TLBA (Ang Biblia))

타지키스탄(Tajikistan)은 중앙아시아에 위치한 내륙국입니다
Tajik1992Bible (Tajik (Китоби Муқаддас 1992, 1999)) 
TajikKMOBible (Tajik (KMO) (Китоби Муқаддас Оммафаҳм))
TajikNTBible (Tajik NT 1999)

타마셰크어(Tamasheq)는 주로 사하라 사막 중심부와 그 주변 지역인 북아프리카와 서아프리카 일대에서 투아레그(Tuareg)족이 사용하는 언어입니다
TamasheqBible (Tamasheq 2003)   

타밀(Tamil)은 주로 인도 남부의 타밀나두(Tamil Nadu) 주와 스리랑카 북동부 지역에 위치합니다
Tamil2017Bible (Tamil Bible - பரிசுத்த வேதாகமம் O.V.) 
TamilBible (Tamil (BSI) (பரிசுத்த வேதாகமம் O.V. (BSI)))
TamilIRVBible (Tamil (IRV) (இண்டியன் ரிவைஸ்டு வெர்ஸன் (IRV) - தமிழ்))
TamilRomanisedBible (Tamil Bible Romanised 2017)
TamilTCVBible (Tamil (TCV) (இந்திய சமகால தமிழ் மொழிப்பெயர்ப்பு 2022))
TamilTRVBible (Tamil (TRV) (இலங்கை இலகு தமிழ் மொழிபெயர்ப்பு))
TamilWBTCBible (Tamil WBTC (ERV) (பரிசுத்த பைபிள்))

TarifitBible (Tarifit (Ṯarifiṯ 2020))

TashelhaytMoroccoBible (Tashelhayt Morocco 1998 (Tashelhayt Arabic Script Morocco) (اغاراس ن-تودرت - ءينجيل لّماسيح - لعهد لّجديد لّي-يسكر ربّي غ-گراس د-بنادم))

타타르족(Tatars)은 주로 러시아 내의 타타르스탄 공화국(Tatarstan Republic)과 그 주변의 볼가-우랄 지역에 거주하는 튀르크 계통의 민족입니다
Tatar2001Bible (Tatar 2001 Bible - Инҗил status=Институт перевода Библии 2001)  
Tatar2015Bible (Tatar Crimean 2016 Bible - Къырымтатарджа [Crimean Tatar] (Мукъаддес Китап))
Tatar2025Bible (Tatar 2025 (Инҗил))
TatarRBBLBible (Tatar (Изге Язма))

텔루구어(Telugu)는 주로 인도 남동부의 안드라프라데시(Andhra Pradesh) 주와 텔랑가나(Telangana) 주에서 사용하는 주요 언어이자 공용어입니다.
Telugu2016Bible (Telugu Bible (TELOV) (పరిశుద్ధ గ్రంథము O.V. Bible (BSI)))    
Telugu2019Bible (Telugu Bible 2019 (ఇండియన్ రివైజ్డ్ వెర్షన్ (IRV) - తెలుగు -2019))
TeluguBible (Telugu (BSI) 1880)
TeluguTCVBible (Telugu TCV (తెలుగు సమకాలీన అనువాదం, పవిత్ర గ్రంథం))
TeluguWBTCBible (Telugu 1997 TERV (పవిత్ర బైబిల్))

Teso2020Bible (Teso 2020 (AKITUTUKET NAKITETET (NEPEPEKA ISABULIN KA AWARAGASIA)))
TesoBible (Teso (Ebaibuli))

ThadoBible (Thado (Pathen Thutheng BU (BSI)) 2015)

태국어에서 '어디'는 '티나이' (ที่ไหน, tee nai)라고 하며, 구어체에서는 줄여서 '나이' (ไหน, nai)라고 주로 표현합니다. 
Thai1940Bible (Thai 1940 (พระคริสตธรรมคัมภีร์ ฉบับ 1940))    
Thai1971Bible (Thai Bible 1971 (พระคัมภีร์ไทย ฉบับ 1971))
ThaiBible (Thia KJV (พระคัมภีร์ภาษาไทยฉบับ KJV))
ThaiERVBible (Thai Bible (ERV) 2001 (พระคริสตธรรมคัมภีร์ ฉบับอ่านเข้าใจง่าย))
ThaiKJVBible (Thai KJV 2003)
ThaiNTVBible (Thai NTV (พระคัมภีร์ ฉบับแปลใหม่ (NTV)))
ThaiTCVBible (Thai TCV 2025 (คัมภีร์ ฉบับไทยสามัญ))
ThaiTHSBible (Thai Bible (THS) 2011 (ฉบับมาตรฐาน))
ThaiTNCVBible (Thai Bible (TNCV) 2007 - New Contemporary Version (พระคริสตธรรมคัมภีร์ไทย ฉบับอมตธรรมร่วมสมัย))

티베트(Tibet)는 중앙아시아, 중국 서남부에 위치한 티베트고원 지역입니다
TibetianBible (Tibetian NTB (བོད་འགྱུར་གསར་མ།))    
TibetianCBTBible (Tibetian CTB (གསུང་རབ།))

TivBible (Tiv (ICIGHAN BIBILO))

Tshiluba(칠루바어)는 주로 콩고 민주 공화국(DR 콩고, Democratic Republic of the Congo)에서 사용되는 언어입니다. 
Tshiluba1996Bible (Tshiluba Bible 1996 (MUKANDA WA MYIDI MUKULU))   
Tshiluba2003Bible (Tshiluba Bible (Mukanda wa Nzambi Dihungila Dikulukulu ne Dihungila Dihia-dihia 2003))

치벤다어(Tshivenda)는 주로 남아프리카 공화국 북부에서 사용되는 언어입니다
TshivendaBible (Tshivenda (BIVHILI KHETHWA Mafhungo Madifha))   

쏭가족(Tsonga people)은 주로 남아프리카 지역에 거주하는 반투족 계열의 민족입니다.
Tsonga1989Bible (Tsonga (BIBELE Mahungu Lamanene) 1989) 
Tsonga2014Bible (Tsonga (Testamente Leyimpsha Xichangana))
Tsonga2024Bible (Tsonga (Contemporary Tsonga Bible 2024))
TsongaBible (Tsonga Xitsonga (Bibele) 1929)

츠와나족(Tswana people)은 남아프리카 지역에 주로 거주하는 반투어계 민족
Tswana1890Bible (Tswana 1890 (Bibela ea Boitsépho 1890 (Sechuana Tlhaping - Moffatt Bible)))    
Tswana1970Bible (Tswana Setswana 1970)
Tswana1993Bible (Tswana 1993 (Lefoko La Botshelo Kgolagano e Ntsha))
Tswana2024Bible (Tswana 2024 (Contemporary Tswana Bible 2024))
TswanaBible (Tswana (BAEBELE e e Boitshepo) 1992)

툴루(Tulu)어는 주로 인도 남서부 해안 지역에서 사용되는 드라비다어족 언어입니다
TuluBible (Tulu (ಪೊಸ ಒಡಂಬಡಿಕೆ)) 

투르카나(Turkana)는 케냐 북서부에 위치한 지역(카운티)입니다
TurkanaBible (Turkana (ABIBILIA NGAKIRO NAAJOKAK))  

튀르키예(Turkey, 옛 터키)는 지리적으로 아시아와 유럽의 교차로에 위치해 있습니다
TurkishBible (Turkish (Yaşam Yayınları))    
TurkishHADIBible (Turkish (Halk Dilinde İncil) 2013)
TurkishKKDEUBible (Turkish KKDEU (Kutsal Kitap ve Deuterokanonik Kitaplar))
TurkishKMEYABible (Turkish KMEYA (Old Translation 1941))
TurkishNTBBible (Turkish (TCL02) NTB (New Turkish Bible) 2009 Version)
TurkishTKKBible (Turkish TKK (Кирил харфлерийле Тюркче Кутсал Китап))
TurkishTTTBible (Turkish (TTT) (Türkçe Tercüme))
TurkishYTCBible (Turkish Yorumsuz Türkçe Çeviri (YTC))

투르크메니스탄(Turkmenistan)은 중앙아시아 남서부에 위치한 나라입니다
Turkmen2016Bible (Turkmen 2016 (Мукаддес Китап))    
TurkmenCyrillic2002Bible (Turkmen 2002 Инжил)
TurkmenLatin2002Bible (Turkmen Latin 2002)
TurkmenLatin2017Bible (Turkmen 2016 Latin (Mukaddes Kitap))

TwiAkuapemBible (Twi Bible 2020 (Akuapem Twi Nkwa Asɛm))
TwiAsanteBible (Twi Bible (Asante Twi Nkwa Asɛm))
TwiDCBible (Twi Bible 2017 (DC KYERƐW KRONKRON))
TwiKronkronBible (Twi Bible (Twerɛ Kronkron))
TwiRevisedBible (Twi Bible 2012 (New Revised Asante Twi Bible))
    
우크라이나(Ukraine)는 동유럽에 위치한 국가
Ukrainian1903Bible (Ukrainian 1871 (Куліша та Пулюя))   
Ukrainian1905Bible (Ukrainian 1905 (Біблія в пер. П.Куліша та І.Пулюя, 1905))
Ukrainian2004Bible (Ukrainian Bible 2004 (Патріарха Філарета))
Ukrainian2006Bible (Ukrainian Bible 2006 (Oleksandr Gizha))
Ukrainian2011Bible (UKrainian 2011 (Переклад Р. Турконяка))
Ukrainian2021Bible (Ukrainian 2021 (Переклад. Ю. Попченка.))
Ukrainian2022Bible (Ukrainian 2022 (Новий Переклад Українською))
UkrainianBible Ukrainian 1962 (Біблія в пер. Івана Огієнка 1962)
UkrainianHOMBible (Ukrainian (Івана Хоменка) 1963)
UkrainianTUBBible (Ukrainian 1997 (TUB) - (Турконяка))
UkrainianUKDERBible (Ukrainian Bible (UKDER) 1992 - Велике Відкриття. Новий Завіт з додатком Псалмів і Притч)
UkrainianUMTBible (Ukrainian UMT (Свята Біблія Сучасною Мовою) 2007)

움분두어(Umbundu)는 주로 앙골라(Angola) 서부와 중부 지역에서 사용되는 반투어군 언어입니다. 
UmbunduBible (Umbundu Bible (Embimbiliya - Bíblia Sagrada em Umbundu))  

우르두어(Urdu)는 주로 파키스탄의 공용어
Urdu2017Bible (Urdu 2017 BCS)   
UrduBible (Urdu ERV 2007)
UrduDGVBible (Urdu DGV (किताब-ए मुक़द्दस))
UrduGVRBible (Urdu GVR (Kitab-i Muqaddas))
UrduIRVURDBible (Urdu IRV (इंडियन रिवाइज्ड वर्जन (IRV) उर्दू - 2019))
UrduUCVBible (Urdu UCV - (اُردو ہم عصر ترجُمہ))
UrduUCVDBible (Urdu UCVD (उर्दू हमअस्र तरजुमा))
UrduUGVBible (Urdu Bible (UGV) 2019 (ہولی بائبل کا اردو جیو ورژن))
UrduURDBible (Urdu URD (کِتابِ مُقادّس))
UrduURDGVHBible (Urdu URDGVH (किताबे-मुक़द्दस))
UrduURDR55Bible (Urdu URDR55 (Kitáb i Muqaddas 1955 (Tauret, Zabúr, Ambiyá ke Sahífa, aur Injíl)))

위구르는 주로 중국 서북부의 신장 위구르 자치구 (Xinjiang Uyghur Autonomous Region)에 거주하고 있습니다.
UyghurArabicBible (Uyghur Arabic 2005 (ھازىرقى زامان ئۇيغۇرچە تەرجىمىسى))   
UyghurCyrillicBible (Uyghur Cyrillic 2005 (Һазирқи Заман Уйғурчә Тәрҗимиси))
UyghurLatinBible (Uyghur Latin Bible - (Muqeddes Kalam) 2010)

우즈베키스탄(Uzbekistan)은 중앙아시아에 위치한 내륙국
UzbekUZBBible (Uzbek 2016 (UZB) (Муқаддас Китоб))   
UzbekUZCBible (Uzbek Bible (UZC) 2008 Tavrot in Uzbek)
UzbekUZLBCBible (Uzbek Latin 2016 (UZLBC) (Muqaddas Kitob))

베트남어
Vietnamese1994Bible (Vietnamese 1994 (Lời Chúa Cho Mọi Người))  
Vietnamese2011Bible (Vietnamese (Kinh Thánh Tiếng Việt, Bản Dịch 2011))
Vietnamese2015Bible (Vietnamese Contemporary 2015 (Kinh Thánh Hiện Đại))
VietnameseBible (Vietnamese (Kinh Thánh Tiếng Việt 1925))
VietnameseERVBible (Vietnamese ERV (Thánh Kinh Bản Phổ thông))
VietnameseNVBBible (Vietnamese 2002 (NVB) (Kinh Thánh Bản Dịch Mới))
VietnameseVIEBible (Vietnamese 2010 (VIE) (Kinh Thánh Tiếng Việt Bản Hiệu Đính 2010))

WarayBible (Waray (Samarenyo Meaning-Based Bible (1984)))

웨일스(Wales)는 영국(UK)을 구성하는 4개국 중 하나
Welsh1894Bible (Welsh 1894 (Cyfieithiad Briscoe 1853-94 (Test. Newydd a rhannau o'r Hen Dest.)))    
Welsh1945Bible (Welsh 1945 (Cyfieithiad Urdd y Graddedigion 1921-45 (T.N., Hosea ac Amos)))
Welsh2015Bible (Welsh 2023 (BNET) (beibl.net 2015, 2024))
WelshBible (Welsh BCND (Beibl Cymraeg Newydd Diwygiedig 2004))
WelshBMWBible (Welsh 1955 (Beibl William Morgan - Argraffiad 1955))
WelshCTEBible (Welsh CTE 1894 (Testament Newydd gyda Nodiadau 1894-1915 (William Edwards)))
WelshSBYBible (Welsh 1567 (Testament Newydd a'r Salmau 1567 (William Salesbury)))

월라이타(Wolaytta, Welayta)는 에티오피아 남부에 위치한 지역이자 그곳에 사는 민족(월라이타족)을 뜻합니다.
WolayttaBible (Wolaytta 2002 (WOB))  

월로프어(Wolof)는 주로 서아프리카의 세네감비아(Senegambia) 지역에서 사용되는 언어입니다.
WolofBible (Wolof 1987) 
WolofKYGBible (Wolof KYG (Kàddug Yàlla gi))

코사족(Xhosa)은 남아프리카공화국(South Africa)에 주로 거주하는 원주민입니다. 
Xhosa1920Bible (Xhosa 1902 (Incwadi Yeziba̔lo Ezingcwele 1864, 1902 (Xhosa Appleyard)))  
Xhosa1996Bible (Xhosa XHO96 (IBHAYIBHILE))
Xhosa2022Bible (Xhosa 2024 (ITestamente Entsha))
XhosaBible (Xhosa 1975 (IZIBHALO EZINGCWELE))

요루바족(Yoruba)은 주로 서아프리카 지역에 거주하는 민족입니다
Yoruba2010Bible (Yoruba 2010)   
Yoruba2014Bible (Yoruba YCB (Bíbélì Mímọ́ ní Èdè Yorùbá Òde-Òní))
YorubaBible (Yoruba YBCV (Bibeli Mimọ))

잔데족(Azande)은 주로 아프리카 중북부 지역에 거주하는 민족입니다
ZandeBible (Zande (Ziazia kekeapai))    
ZarmaBible (Zarma)

줄루족(Zulu)은 주로 남아프리카 공화국(South Africa)에 위치하고 있습니다. 
Zulu2020Bible (Zulu 2020 (IsiZulu 2020))    
Zulu2023Bible (Zulu 2023 (Baasraak Zulu New Testament Bible))
ZuluBible (Zulu 1959 (IBHAYIBHELI ELINGCWELE))


 */

/**
아체(Aceh)는 인도네시아 수마트라섬의 가장 북서쪽 끝에 위치한 특별자치주
AcehBible (Aceh Language (Alkitab HABA GET))    

아딜라바드(Adilabad)는 인도 텔랑가나(Telangana) 주 북부에 위치한 도시
AdilabadGondiBible (Adilabad Gondi (ఆదిలాబాద్ గోండి పూన నియమ్))   

아프리칸스어(Afrikaans)는 주로 남아프리카 공화국과 나미비아에서 사용되는 서게르만어군 언어
Afrikaans1983Bible (Afrikaans 1983)     
Afrikaans2020Bible (Afrikaans 2020 (Die Bybel 2020-vertaling))
Afrikaans2023Bible (Afrikaans (Contemporary Afrikaans Bible 2023))
AfrikaansABABible (Afrikaans Bible (ABA) 2007 (Bybel vir almal))
AfrikaansBible (Afrikaans 1933, 1953)
AfrikaansDBBible (Afrikaans DB 2006 (Die Boodskap))
AfrikaansNLVBible (Afrikaans (NLV) 2011)

아히라니(Ahirani)어는 주로 인도 마하라슈트라(Maharashtra)주 북부 칸데시(Khandesh) 지역에서 사용되는 언어/방언
AhiraniBible (Ahirani (आहिराणी नवा करार))        

알바니아(Albania)는 유럽 동남부 발칸반도 서북부, 아드리아해와 이오니아해에 접한 국가
Albanian1872Bible (Albanian 1872 (Dhiata e Re Gegnisht Konstandin Kristoforidhi 1872))      
Albanian1879Bible (Albanian DERKK79 (Dhiata e Re Konstantin Kristoferidhi 1879))
Albanian2018Bible (Albania (Shqip Së Bashku 2020))
AlbanianALTMK27Bible (Albanian (Dhjata e Re 1827))
AlbanianBible (Albanian (Bibla Shqip 1994))

암하라어(Amharic)는 주로 에티오피아에서 사용되는 공용어
Amharic2000Bible (Amharic 2000 (የአማርኛ መጽሐፍ ቅዱስ (ሰማንያ አሃዱ)))     
AmharicBible (Amharic Bible (መጽሐፍ ቅዱስ (የብሉይና የሐዲስ ኪዳን መጻሕፍት)))
AmharicCatholicBible (Amharic Catholic Version (መጽሐፍ ቅዱስ - (ካቶሊካዊ እትም - ኤማሁስ)))
AmharicDawroBible (Amharic Dawro (Ooratha Caaquwaa))
AmharicDawroDFBEBible (Amharic Dawro DFBE (ጌሻ ማጻፋ))
AmharicDawroDFBLVLBible (Amharic Dawro DFBLVL (Geeshsha Mas'aafaa))
AmharicDawroDWRNTBible (Amharic Dawro DWRNT (Ooratha Caaquwaa))
AmharicDawroWWIBible (Amharic Dawro New Testament (The Word for the World International))
AmharicGamo2017Bible (Amharic Gamo 2017 (Gamo Geesha Maxxafa New Testamen))
AmharicGamoBible Amharic Gamo 2011 New Testament)
AmharicGamoGMBible (Amharic Gamo (Geeshsha Maxaafa))
AmharicGamoWordBible (Amharic Gamo (ጋሞ ማጻፋ))
AmharicGofaBible (Amharic Gofa 2011 (ኦራ ጫቁዋ ጎፋ))
AmharicGofaGFBEVFBible (Amharic Gofa GFBEVF (ጌሻ ማፃፋ))
AmharicGofaGFBLVFBible (Amharic Gofa GFBLVF (Geeshsha Maxaafa))
AmharicGofaRNTBible (Amharic Gofa RNT 2011 (Ooratha Caaquwa Goofatho))
AmharicGofaWWIBible (Amharic Gofa 2011 (The Word For The World International) (Gofa New Testament))
AmharicNASVBible (Amharic NASV (አዲሱ መደበኛ ትርጒም))
AmharicNSTBible (Amharic New Standard Translation (አማርኛ አዲሱ መደበኛ ትርጉም) 2005)
AmharicTigrinya15Bible (Amharic Tigrinya (መፅሓፍ ቅዱስ))
AmharicTigrinya2024Bible (Amharic (Tigrigna Contemporary Tigrinya Bible 2024))
AmharicTigrinyaBible (Amharic Tigrinya 2011)

아랍(Arabic) 지역은 주로 서아시아(아라비아 반도)와 북아프리카에 위치한 22개 아랍연맹 회원국들을 가리키며, 아랍어를 공용어로 사용하는 중동 중심의 국가들
Arabic1978Bible (Arabic 1978 (APD) (Kitaab al Vahd aj Jadid 1978))      
Arabic2016Bible (Arabic 2016 (الكِتاب المُقَدَّس التَّرْجَمَةُ العَرَبِيَّةُ المُبَسَّطَةُ))
Arabic2018Bible (Arabic 2018 (الترجمة الكاثوليكيّة (اليسوعيّة)))
Arabic2023Bible (Arabic 2023 (SAB) (الكتاب الشريف))
ArabicAlgeriaBible (Arabic Algerian (العهد الجديد باللهجة الجزائرية))
ArabicAPDBible (Arabic APD 2024 (كِتاب العَهد الجَّديد مِن الكِتاب المُقَدَّس))
ArabicAVDBible (Arabic Bible AVD 1999)
ArabicAVDDVBible (Arabic Bible AVDDV 1999)
ArabicBible (Arabic KEH Ketab El Hayat (كتاب الحياة))
ArabicERVBible (Arabic Bible ERV 2009)
ArabicGNABible (Arabic Bible (GNA) Good News Arabic - 1993 (الترجمة العربية المشتركة))
ArabicGOVBible (Arabic GOV (الكتاب المقدس العهد الجديد، النسخة الارثوذكسية القدس))
ArabicLABible (Arabic Bible Live (Targamet El Hayah) (LA))
ArabicLebaneseBible (Arabic Lebanese (bil 3arabe App))
ArabicMorocco2023Bible (Arabic Moroccan (Northern Mor NT))
ArabicMoroccoBible (Arabic Bible Morocco Version - 2012)
ArabicSABBible (Arabic SAB (الكتاب الشريف))
ArabicSABible (Arabic Simplified (الكِتاب المُقَدَّس التَّرْجَمَةُ العَرَبِيَّةُ المُبَسَّطَةُ))
ArabicSVDBible (Arabic SVD 1865 Version)
ArabicTMABible (Arabic TMA 2021 (المعنى الصحيح لإنجيل المسيح))
ArabicTU2022Bible (Arabic TU2022 (العهد الجديد بالدارجة التونسية))
ArabicTunisianBible (Arabic Bible (Tunisian) (Tunisian Arabic Version) 2018)

아람어(Aramaic)는 기원전 10세기경부터 고대 근동(현재의 시리아, 이라크, 튀르키예, 레바논 지역)에서 주로 사용된 셈어파 언어
AramaicBible(Aramaic Peshitta)      

아르메니아(Armenia)는 서아시아의 남캅카스 지역에 위치한 내륙국
Armenian1853Bible (Armenian 1853 (Western Armenian Bible 1853))     
Armenian2017Bible (Armenian 2017 (Արեւմտահայերէն Նոր Կտակարան, հարմարցուած․ 2017))
Armenian2018Bible (Armenian 2018 (Նոր վերանայված Արարատ Աստվածաշունչ))
Armenian2019Bible (Armenian 2019 (Western Armenian New Translation - Armenian Catholicosate of Cilicia - New Testament))
ArmenianAraratBible (Armenian Ararat 1896 (Արարատ Թարգմանություն))
ArmenianBible (Armenian Western NT 1994)
ArmenianEasternBible (Armenian Eastern Bible 1994)
ArmenianNEABible (Armenian NEA (Նոր Էջմիածին Աստվածաշունչ))

아삼어(Assamese)는 주로 인도 북동부의 아삼(Assam) 주에서 사용되는 언어
AssameseBible (Assamese - 2019 (ইণ্ডিয়ান ৰিভাইচ ভাৰচন (IRV) আচামিচ - 2019))     

'아바르(Avar)'족은 6~9세기경 유럽 동중부(판노니아 평원)를 지배했던 유목 민족을 뜻하며, 현재의 캅카스 지역에 사는 민족과는 다른 집단
AvarBible (Avar Инжил Магӏарул [Avaric])        

Awadhi(아와디어/아와드 지역)는 주로 인도 북부 우타르프라데시(Uttar Pradesh)주 중심부에 위치한 역사적인 지역
AwadhiBible (Awadhi ERV (पवित्तर बाइबिल))       

아이마라(Aymara)족은 남아메리카 안데스 산맥의 볼리비아, 페루, 칠레, 아르헨티나 북서부에 걸쳐 거주하는 토착민입니다
Aymara1986Bible (Aymara Bible 1986 (Aymar Bibliia 1986))        
Aymara1997Bible (Aymara 1997 (Qullan Arunaka DC))
AymaraBible (Ayamar Bible (Qullan Arunaca))

아제르바이잔(Azerbaijan)은 서아시아와 동유럽의 경계인 코카서스 지역(카스피해 연안)에 위치한 내륙국입니다.
Azerbaijan2013Bible (Azerbaijan 2013 (موقدس کتاب))      
AzerbaijanBible (Azerbajani (Azərbaycan Bibliyası 2008))
AzerbaijanSouthBible (Azerbajani Bible (South) Used in Both Iran and Azerbaijan 2008)

'Bagri(바그리)'는 주로 인도 북서부의 바가르(Bagar) 지역에서 사용되는 인도-아리안 언어(라자스탄어의 일종)를 말하며, 해당 지역에 거주하는 공동체를 지칭하기도 합니다
BagriBible (Bagri Bible)        

발리(Balinese)는 인도네시아(Indonesia)의 섬이자 주(Province)로, 동남아시아에 위치해 있습니다.
BalineseBible (Balinese (Cakepan Suci))     

발루치어(Balochi)는 주로 파키스탄의 발루치스탄 주를 중심으로, 인접한 이란의 시스탄-발루체스탄주 및 아프가니스탄 남부 지역에 거주하는 발루치족이 사용하는 언어입니다.
BalochiArabicBible (Balochi Arabic (هُدائے پاکێن کتاب، بلۆچی زبانا))     
BalochiBible (Balochi (Hodáay Pákén Ketáb, Balochi zobáná))
BalochiSoutherenBible (Balochi Southern (هُدائے پاکێن کتاب، بلۆچی زبانا))
BalochiSoutherenLatinBible (Balochi, Southern Latin (Hodáay Pákén Ketáb, Balochi zobáná))

바울레(Baoulé)족은 서아프리카 코트디부아르의 중부 지역에 주로 거주하는 가장 큰 민족 그룹입니다. 
Baoule1974Bible (Baoule (Nyanmien nde Ufle) 1974)       
Baoule1998Bible (Baoule (NYANMIƐN NDƐ'N 1998))
BaouleBible (Baoule Bible 1996 (Kuo Dele'))

바시키르(Bashkir)는 주로 러시아 연방 내 바시코르토스탄 공화국(Republic of Bashkortostan)에 거주하는 튀르크계 토착 민족입니다.
Bashkir2023Bible (Bashkir 2023 (Изге Яҙма))     
BashkirBible (Bashkir 2014 - Инжил Башҡортча)

바스크(Basque) 지방은 스페인 북부와 프랑스 남서부 국경, 비스케이 만 연안의 피레네 산맥 일대에 위치한 지역입니다. 
BasqueBible (Basque (Navarro-Labourdin Basque))
Basque2008Bible (Basque (EAB) 2008 (Elizen Arteko Biblia (Biblia en Euskara, Traducción Interconfesional)))     

바이에른(Bavaria, 독일어: Bayern)은 독일 남동부에 위치한 주입니다
BavarianBible (Bavarian Bible 1998 (De Bibl auf Bairisch))      

벨라루스(Belarus)는 동유럽에 위치한 내륙국입니다.
Belarusian2017Bible (Belarusian 2017 (Біблія — пераклад Чарняўскага (Выданне 2017 Года)))       
BelarusianBible (Belarusian (Пераклад В. Сёмухі))
BelarusianBokunBible (Belarusian Bokun (Пераклад А.Бокуна))
BelarusianCHNTBible (Belarusian Bible (CHNT) 1999)
BelarusianNTJSBible (Belarusian Bible Maley (© 1931, 1948; у 1985, 1991 унесены праўкі))

\벰바족(Bemba)은 주로 잠비아(Zambia) 북동부 고원 지대에 거주하는 반투계 민족입니다
BembaBible (Bemba (Ishiwi Lyakwa Lesa 2015))    

벵골어(Bengali, বাংলা)는 주로 방글라데시와 인도 서벵골주에서 사용되는 언어입니다.
Bengali2017Bible (Bengali 2017 (বাঙালি বাইবেল))      
Bengali2023Bible (Bengali 2023 (পবিত্র বাইবেল (কেরী ভার্সন)))
BengaliBACIBBible (Bengali (BACIB) 2013 (কিতাবুল মোকাদ্দস))
BengaliBCVBible (Bengali (BCV) (বাংলা সমকালীন সংস্করণ))
BengaliBible (Bengali (World Bible Translation Center) (WBTC))
BengaliBSIBible (Bengali (BSI) 2016 O.V. Bible, পবিএ বাইবেল O.V)
BengaliCLBSIBible (Bengali CL BSI 2016 (পবিএ বাইবেল CL Bible (BSI)))
BengaliERVBible (Bengali ERV 2001 (পবিত্র বাইবেল))
BengaliIRVBENBible (Bengali IRV (ইন্ডিয়ান রিভাইজড ভার্সন (IRV) - বেঙ্গলী))
BengaliMBCLBible (Bengali Bangladesh MBCL (Kitabul Mukkadas))
BengaliSBCLBible (Bengali Bangladesh 2000 SBCL (Pobitro Baibel))

베르베르족(Berber)은 주로 모로코, 알제리, 튀니지, 리비아 등 북아프리카 마그레브 지역과 사하라 사막 근처에 거주하는 원주민입니다. 
BerberBible (Berber = Morocco and Algeria - Tachelheit Bible (RBD) (aåaras n-tudrt - injil l-lmasiæ - løhd l-ljdid lli-iskr rbbi å-gras d-bnadm))   

Bhilali(빌랄리)는 주로 인도 서부 및 중부 지역에 위치한 마하라슈트라(Maharashtra)주 잘가온(Jalgaon) 지구에 위치한 마을입니다
BhilaliBible (Bhilali (भगवानेन छाचला बुल))   

보되(Bodø)는 노르웨이 북부에 위치한 도시로, 로포텐 제도(Lofoten Islands)로 향하는 항구와 공항을 갖춘 북극권 관문입니다. 
BodoBible (Bodo BDVNT (ବ୍‌ଡ଼୍ ହ୍‌ର୍‌ଜା ବାଇବଲ))     
BodoNTBPL20Bible (Bodo NTBPL20 (ସଃର୍ଗାର୍‌ ବାଟ୍‌ ନଃଉଁଆ ନିଅମ୍‌))

보스니아 헤르체고비나(Bosnia and Herzegovina)는 유럽 동남부 발칸반도에 위치한 국가입니다. 
BosnianBible (Bosnian (Biblija, Stari i Novi Zavjet))       

브라즈(Braj, 또는 Vraj, Brij)는 인도 북부 우타르프라데시(Uttar Pradesh) 주에 위치한 지역으로, 
BrajBible (Braj (बृज भासा))    

싱가포르의 부기스(Bugis)는 싱가포르 중심부, 다운타운 코어(Downtown Core) 내의 아랍 및 무슬림 지역에 위치해 있습니다
BugisBible (Bugis (KITTA KAREBA MADECENG))      

불가리아(Bulgaria)는 유럽 동남부, 발칸반도 동쪽에 위치한 나라입니다.
Bulgarian2015Bible (Bulgarian 2015 (Библия, Ревизирано Издание))    
BulgarianBible (Bulgarian 1940 (Ревизиран))
BulgarianBOBBible (Bulgarian (Библия, Синодално Издание (1982 г.)))
BulgarianBPBBible (Bulgarian (Библейска лига - Ревизия 2001))
BulgarianCBTBible (Bulgarian CBT (Съвременен български превод (с DC books) 2013))
BulgarianSPBBible (Bulgarian (SPB) 2000 (Новият Завет Съвременен Превод))
BulgarianTZABible (Bulgarian (TZA) (Цариградски))
BulgarianVerensBible (Bulgarian Veren's (Верен) Contemporary 1871)

Bundeli ( Devaanagari : Bundelkhandi) 또는 Bundelkhandi 는 인도 중부 Bundelkhand 지역에서 사용되는 인도-아리아어 입니다
BundeliBible (Bundeli 2018 (Bundeli Holy Bible))        

버마어(Burmese)는 미얀마(Myanmar)의 공식 언어로, 해당 국가의 주류 민족인 버마족의 언어입니다
Burmese1928Bible (Burmese Myanmar 1928 (Garrad Bible))      
Burmese2021Bible (Burmese Myanmar (Judson Bible))
BurmeseBCLBible (Burmese (BCL) (Common Language Bible))
BurmeseBible (Burmese 1835 Version Judson)
BurmeseJBZVBible (Burmese Myanmar (Judson Bible in Zawgyi Version))
BurmeseMCLZVBible (Burmese Myanmar MCLZV (Myanmar Common Language Zawgyi Version))
BurmeseMSBUBible (Burmese MSBU Myanmar (မြန်​​​မာ့​​​စံ​​​မီ​​​သမ္မာ​​​ကျမ်း​​))
BurmeseMSBZBible (Burmese Myanmar MSBZ (ျမန္​မာ့​စံ​မီ​သမၼာ​က်မ္))

카탈루냐(Catalan/Catalonia)는 스페인(Spain) 북동부에 위치한 자치 지방입니다. 
CatalanBCIBible (Catalan (BCI) 2008 - (Bíblia Catalana, Traducción Interconfesional))   
CatalanBECBible (Catalan (BEC) 2000 (Bíblia Evangèlica Catalana))

세부아노어(Cebuano)는 필리핀 중남부 비사야(Visayas) 지방과 민다나오(Mindanao) 섬에서 주로 사용되는 언어입니다.
Cebuano1999Bible (Cebuano 1999 (Maayong Balita Biblia))     
Cebuano2011Bible (Cebuano 2011 (Ang Biblia, 2011))
CebuanoAPSDBible (Cebuano APSD (Ang Pulong sa Dios))
CebuanoBible (Cebuano CBV)
CebuanoRCPVBible (Cebuano RCPV 1999 (Ang Bag-ong Maayong Balita Biblia))

체첸(Chechnya, 공식 명칭: 체첸 공화국)은 러시아 연방의 구성 공화국 중 하나입니다
ChechenBible (Chechen 2012 (Делан Йозанаш))     

체와족(Chewa)은 주로 남동부 아프리카 지역에 거주하는 반투계 민족입니다
Chewa1992Bible (Chewa Bible (BL) 1992 - Buku Lopatulika)    
Chewa2014Bible (Chewa 1922 (Buku Lopatulika))
Chewa2016Bible (Chewa 2002 (Mawu a Mulungu mu Chichewa Chalero))
ChewaBLYDCBible (Chewa (Buku Loyera Catholic Edition - Chichewa))

차티스가르어(Chhattisgarhi)는 주로 인도 중부에 위치한 차티스가르(Chhattisgarh)주에서 사용되는 언어입니다
ChhattisgarhiBible (Chhattisgarhi (नवां नियम छत्तीसगढ़ी) 2012)     

Chibemba(벰바어)는 주로 잠비아(Zambia) 북동부 지역에서 사용되는 반투어군 언어입니다.
ChibembaBible (Chibemba (Ishiwi Lyakwa Lesa 2015))      


Chin2010Bible (Chin 2010)
ChinBSIBible (Chin (Mara Bible RV (BSI)))
ChinCSHBible (Chin (Khyang NT))

'Dai Cangcim Kthai'는 미얀마 친주(Chin State)의 다아이(Daai) 친족(Daai Chin)이 사용하는 언어
ChinDNTBible (Chin (Dai Cangcim Kthai))     

중국어
Chinese1886Bible (Chinese Bible 1886 (Traditional) (楊格非官話《新約全書》))       
Chinese1919Bible (Chinese Bible 1919 (Traditional) (文理和合譯本《新舊約全書》))
Chinese1927Bible (Chinese Bible 1927 (Traditional) (文理《委辦譯本》))
Chinese1933Bible (Chinese Bible 1933 (Traditional) (王元德《新式標點新約全書》)
Chinese1941Bible (Chinese Bible 1941 (Traditional) (亨理－鄭壽麟《國語新舊庫譯本－新約全書》))
Chinese1967Bible (Chinese Bible 1967 (Traditional) (蕭鐵笛《新譯新約全書》))
ChineseCCBSBible (Chinese (Simplified) Contemporary Bible (CCB Bible) (圣经当代译本修订版))
ChineseCCBTBible (Chinese Bible CCB (Traditional))
ChineseCSBSBible (Chinese Bible CSBS (Simplified) - (中文标准译本))
ChineseCSBTBible (Chinese Bible CSBT (Traditional) - (中文標準譯本))
ChineseCUNPSSBible (Chinese Bible CUNPSS (Simplified) (新标点和合本, 上帝版))
ChineseCUNPSTBible (Chinese Bible (Traditional) (CUNPST))
ChineseNankingBible (Chinese Bible Nanking (Traditional) (南京官話《新約全書》))
ChinesePekingBible (Chinese Bible (Peking) (Traditional) (北京官話譯本))
ChineseRCUVSSBible (Chinese Bible RCUVSS (Simplified) (和合本修订版))
ChineseRCUVTBible (Chinese Bible RCUV (Traditional) (和合本修訂版))
ChineseSimplifiedBible (Chinese Simplified CUNPSS Script Union (新标点和合本, 神版))
ChineseSimplifiedNewBible (Chinese Bible - (Simplified) (新译本) CNVS)
ChineseTCV2019TBible (Chinese Bible TCV2019T (Traditional) (《現代中文譯本2019－－繁體版》))
ChineseTHV2012Bible (Chinese Bible TNV 2012 (Traditional) (客語聖經 – 現代臺灣客語譯本，新舊約全書客語聖經 – 漢字版))
ChineseTraditionalBible (Chinese Union Traditional 1919)
ChineseTraditionalERVBible (Chinese Traditional ERV 2006)
ChineseTraditionalNewBible (Chinese Bible CNVT (Traditional) - (新譯本))
ChineseTTVHBible (Chinese TTVH 2021 (現代台語譯本漢字版))
ChineseTTVRBible (Chinese TTVR (現代台語譯本羅馬字版))
ChineseUnion2010Bible (Chinese Bible Union Version 2010 (Traditional) (（和合本修訂版） （繁體字） 神版))
ChineseWenli1823Bible (Chinese Bible Wenli 1823 (Traditional) (米憐文理《神天聖書》))
ChineseWenli1885Bible (Chinese Bible Wenli 1885 (Traditional))
ChineseWenli1897Bible (Chinese Bible Wenli 1897 (Traditional) (湛約翰－韶瑪亭文理《新約全書》))
ChineseWenliBible (Chinese Bible (Wenli) (Traditional) (包爾騰－柏漢理淺文理《新約聖經》))
ChineseWenliEasyBible (Chinese Bible (Easy Wenli) (Traditional))

"Chin KNTP (Khongso New Testament Printed)"은 미얀마의 Bible Society of Myanmar (미얀마 성서공회)에서 발행한 콩소(Khongso/Anu-Hkongso) 부족 언어의 신약 성경입니다.
ChinKNTPBible (Chin KNTP (Khongso New Testament Printed))       
ChinMatupi2006Bible (Chin Matupi (Matu Chin New Testament 2006))
ChinMatupiBible (Chin (Matu Bible))
ChinSCB2Bible (Chin SCB2 (Syin Chin Bible))
ChinTB77Bible (Chin TB77 (Tedim Bible))
ChinTBR17Bible (Chin TBR17 (Tedim Bible Revision 2017))
ChinTDBBible (Chin TBD (Tedim Bible Revision 2017))
ChinTedim2011Bible (Chin 2011 (Tedim Bible))
ChinTedimBible (Chin 1977 (Tedim Bible))

추바시 공화국(Chuvashia)은 동유럽에 위치한 러시아 연방의 구성 공화국입니다
ChuvashBible (Chuvash (CHB) (БИБЛИ) 2009)       
ChuvashRSOBible (Chuvash RSO (Синодальный НЗ))

'콥트(Coptic)'는 주로 이집트에 거주하는 토착 기독교인(콥트 정교회)을 뜻합니다.
CopticBible (Coptic Bohairic NT 2006)       
CopticCNTVBible (Coptic 2018 (العهد الجديد))
CopticSahidicBible (Coptic Sahidic 2006)

크로아티아(Croatia)는 유럽 남동부, 발칸반도에 위치한 국가입니다. 
CroatianBible (Croatian Bible 1988)     
CroatianBKJBible (Croatian BKJ 2011 (Biblija Kralja Jakova))
CroatianCNTBible (Croatian (Knjiga O Kristu))
CroatianGKSBible (Croatian Bible GKS 2010 - (Šarić) Version)
CroatianSHPBible (Croatian (SHP) 2019 (Biblija Suvremeni Hrvatski Prijevod))

체코(체코 공화국)는 중부 유럽에 위치한 내륙국으로, 북쪽으로 폴란드, 서쪽으로 독일, 남쪽으로 오스트리아, 동쪽으로 슬로바키아와 국경을 접하고 있습니다
Czech1922Bible (Czech Bible (SYK) 1922 Dr. Jan Ladislav Sýkora)     
Czech1947Bible (Czech Bible (COL) Dr. Rudolf Col (1947))
Czech1951Bible (Czech Bible (SKRABAL) 1951 - Dr Pavel Škrabal)
CzechBible (Czech (Bible 21))
CzechEkumenickyBible (Czech Bible Ekumenicky 2001)
CzechKralichka1613Bible (Czech (Kralická 1613))
CzechKralichka1998Bible (Czech Kralichka 1998 (Czech Nova karlica Bible (NBK) Nova Bible Kralicka))
CzechPMPZBible (Czech Bible (PMPZ) 2014 (Český studijní překlad Miloše Pavlíka - Miloš Pavlík))
CzechPrekladBible (Czech 2009 (Český studijní překlad))
CzechSNCBible (Czech 2012 (Slovo na cestu))

다그바니어(Dagbani 또는 Dagbanli)는 주로 가나 북부 지역(Northern Region of Ghana)에서 사용되는 언어입니다
DagbaniBible (Dagbani Bible (Naawuni Kundi Kasi))       

덴마크(Denmark, Danish)는 북유럽 스칸디나비아 반도 남서쪽, 독일 바로 북쪽에 위치한 나라입니다. 
Danish1819Bible (Danish 1819-1871)      
Danish2015Bible (Danish 2015 (Bibelen på Hverdagsdansk))
DanishBible (Danish 1871 (Danske Bibel 1871, 1907))
DanishLBBible (Danish Bible (LB) 1866)
DanishWIEBible (Danish Bible (WIE) 1997 - Det Nye Testamente)

딩카(Dinka)족은 주로 아프리카 남수단의 나일강 주변에 거주하는 나일로틱 민족입니다. 
Dinka2006Bible (Dinka Southwestern (Lëk yam))       
DinkaBible (Dinka DIPBSS 2009)
DinkaLEKJOTBible (Dinka Southeastern LEKJOT (Lek Jot de Jecu Kritho 1940))

도그리어(Dogri)는 주로 인도 북부의 잠무 카슈미르(Jammu and Kashmir) 연방 직할지, 특히 잠무(Jammu) 지역에서 사용되는 언어입니다.
DogriBible (Dogri (डोगरी नवां नियम))     

'Dutch(더치)'는 네덜란드(The Netherlands) 사람, 네덜란드어, 또는 네덜란드의 것을 뜻합니다
Dutch1939Bible (Dutch 1939 (De Heilige Schrift, Petrus Canisiusvertaling, 1939))        
Dutch2007Bible (Dutch 2007 (HTB))
DutchBBBible (Dutch (BB) 2016 BasisBijbel)
DutchBible (Dutch (Statenvertaling Jongbloed-editie))
DutchEBV24Bible (Dutch 2024 (EBV24 een Eigentijdse Bijbelvertaling))
DutchFrisianBible (Dutch Frisian)
DutchGBVNTBible (Dutch GBVNT (Gods Boek - het Nieuwe Testament))
DutchHSVBible (Dutch (HSV) 2017 (Herziene Statenvertaling))
DutchHTBBible (Dutch HTB 2007 (Het Boek))
DutchNBGBible (Dutch (NBG) Nederlands Bijbel Genootschap 1951)
DutchReimerBible (Dutch Reimer 2001)
DutchSVVBible (Dutch SVV 2018 (Statenvertaling Jongbloed-editie))
DutchVBBible (Dutch 2023 (Venster Bijbel))

듈라족(Dyula/Dioula)은 서아프리카 지역에 거주하는 만데(Mande) 계열의 상인 민족입니다.
DyulaJulaBible (Dyula Bible (Jula NT of Côte d’Ivoire))     
DyulaKumaBible (Dyula Bible (ALA KA KUMA))
DyulaLayidukuraBible (Dyula Bible (LAYIDUKURA))

'E Baibol Ẹdo'는 나이지리아 에도주(Edo State)에서 사용하는 에도어(Edo/Bini language)로 번역된 성경을 뜻합니다
EdoBible (Edo ((E Baibol Ẹdo) Version 1996))      

영어
EnglishAmplifiedBible (English Amplified)
EnglishAmplifiedClassicBible (English Amplified Classic Bible 1987)
EnglishASVBible (English ASV)
EnglishBereanBible (English Berean Standard Bible (BSB))
EnglishCSBBible (English CSB 2017 - Christian Standard Bible)
EnglishDarbyBible (English Darby 1890)
EnglishEASYBible (English EASY 2024)
EnglishERVBible (English ERV 2006)
EnglishESVBible (English ESV 2016)
EnglishGNTBible (English GNT (Good News Translation))
EnglishGWBible (English God's Word - GW 1995)
EnglishHCSBBible (English HCSB 2004)
EnglishKJBible (English KJV)
EnglishLSBBible (Legacy Standard Bible (LSB))
EnglishMEVBible (English MEV 2014 (Modern English Version))
EnglishNASBBible (English NASB (New American Standard Bible - NASB 1995))
EnglishNASUBible (English NASU 1989 - New American Standard Update)
EnglishNETBible (English NET Bible - 2005 (New English Translation))
EnglishNIRVBible (English NIRV 1996)
EnglishNIVBible (English NIV)
EnglishNKJBible (English NKJ 1982)
EnglishNLTBible (English NLT)
EnglishNRSVBible (English NRSV 1989)
EnglishPassionBible (English Passion Translation Bible 2020)
EnglishRSVBible (English RSV (Revised Standard Version))
EnglishTLBible (English TL (The Living Bible) (1971))
EnglishTyndale1537Bible (English Tyndale 1537)
EnglishYLTBible (English (YLT) 1898 Young's Literal Translation by Robert Young)

에스페란토(Esperanto)는 1887년 폴란드 의사 자멘호프가 창안한 세계 최대의 인공 국제어로, 특정 국가가 아닌 전 세계에 약 200만 명의 사용자가 산발적으로 퍼져 있는 언어입니다. 
EsperantoBible (Esperanto ESP (La Sankta Biblio 1926 (Esperanto Londona Biblio)))   

에스토니아(Estonia)는 북유럽에 위치한 국가입니다 
Estonian2022Bible (Estonian 2022 (Pühakiri Kaasaegses Eesti Keeles))    
EstonianBible (Estonian Bible (Eestikeelne Piibel 1997))
EstonianEEPBible (Estonian EEP (Eesti Piibel))

Ewe(에웨족)는 주로 아프리카 가나, 토고, 베냉 남부 지역에 거주하는 민족이며, 이들이 사용하는 언어도 Ewe어라고 합니다.
Ewe1913Bible (Ewe 1913 (Biblia alo Ŋɔŋlɔ Kɔkɔe La Le Eʋegbe Me 1913))    
Ewe2014Bible (Ewe 2014 (EƲEGBE BIBLIA))
Ewe2020Bible (Ewe (Agbenya La) 2020)
EweBible (Ewe BEV (Agbenya La) 2006)

핀란드(Finland, 핀란드어: Suomi)는 북유럽에 위치한 나라로, 스웨덴, 러시아, 노르웨이와 접해 있으며, 발트해와 핀란드만을 끼고 있는 노르딕 국가입니다.
Finnish1776Bible (Finnish 1776)     
Finnish1992Bible (Finnish 1992 (Kirkkoraamattu 1992))
FinnishBible (Finnish (Kirkkoraamattu 1933, 1938))
FinnishFINRKBible (Finnish FINRK 2012 (Raamattu Kansalle))
FinnishSTLKBible (Finnish STLK 2017 = Pyhä Raamattu (STLK 2017))

MAWUXÓWÉMA는 베냉(Benin)과 토고(Togo) 일부 지역에서 사용되는 퐁어(Fon language)로 번역된 성경을 의미합니다.
FonBible (Fon (MAWUXÓWÉMA))     

프랑스(France)는 서유럽에 위치한 공화제 국가로, 유라시아 대륙 북서쪽 가장자리에 자리 잡고 있습니다.
French2004Bible (French (La Bible expliquée))       
FrenchBBBBible (French Bible (BBB) Bible Bovet Bonnet (1900))
FrenchBDSBible (French (BDS) 2015 (La Bible du Semeur 2015))
FrenchBFCBible (French (BFC) 1997 (Bible en Français Courant))
FrenchBible (French (La Sainte Bible par Louis Segond 1910))
FrenchCramponBible (French (Catholique Crampon 1923))
FrenchDarbyBible (French (J.N. Darby) 1885)
FrenchJerusalemBible (French Jerusalem 1998)
FrenchLeonBible (French (Zoque, Francisco León))
FrenchMachairaBible (French Machaira 2012)
FrenchMartinBible (French Martin 1744)
FrenchNBSBible (French (NBS) 2002 (Nouvelle Bible Segond))
FrenchNEG79Bible (French NEG79 1979 (Segond Nouvelle Edition de Genève 1979))
FrenchNFCBible (French NFC 2019 (Nouvelle Français courant))
FrenchNVS78Bible (French NVS78P 1978 (Nouvelle Segond Révisée))
FrenchOSTBible (French OST (Ostervald))
FrenchOstervaldBible (French OST - Osterwald)
FrenchPDV2017Bible (French PDV2017 (Parole de Vie 2017))
FrenchPerretBible (French Perret-Gentil et Rilliet 1847)
FrenchS21Bible (French S21 2007 (Bible Segond 21))
FrenchVigourouxBible (French Vigouroux 1902 Bible)

풀라어(Fulfulde)는 주로 서아프리카와 중앙아프리카의 약 18개국에 걸쳐 분포하며, 약 3,600만 명 이상이 사용하는 세네감비아 어족 언어입니다.
Fulfulde2010Bible (Fulfulde Bible (Caka Nigeria) 2010)       
FulfuldeAadiBible (Fulfulde Bible (Aadi keyri linjiila iisaa almasiihu))
FulfuldeAdamawaBible (Fulfulde Adamawa Bible)
FulfuldeAlkawalBible (Fulfulde Bible (Alkawal Kesal) Central Eastern Niger)
FulfuldeArabicBible (Fulfulde Bible (Caka Nigeria Arabic Script) (اَلْکَوَلْ کٜسَلْ ندٜرْ فُلْفُلْدٜ شَکَ نَاجٜىٰرِيَ))
FulfuldeBeninBible (Fulfulde Bible (Borgu Benin))
FulfuldeBurkinaFasoBible (Fulfulde Bible (Dewtere Laamɗo Amaana Keso) (Burkina Faso))
FulfuldeDewtereBible (Fulfulde Bible (Dewtere Laamɗo Fulfulde Burkina Faso))
FulfuldeWestNigerBible (Fulfulde Bible (Western Niger))

게일어(Gaelic)는 주로 아일랜드와 영국 스코틀랜드, 그리고 맨 섬을 중심으로 사용되는 켈트계 언어군입니다.
Gaelic1875Bible (Gaelic Scottish (Tiomnadh Nuadh (MacEachen) 1875))     
GaelicABGBible (Gaelic Scottish (Am Bìoball Gàidhlig 1992))
GaelicABIGBible (Gaelic ABIG (Scottish) (Am Bìoball Iomraidh Gàidhlig 1880, 1992))
GaelicATNBible (Gaelic (Scottish) (An Tiomnadh Nuadh anns an Eadar-Theangachadh Ùr Gàidhlig 2017)

갈리시아(Galicia)는 스페인의 최북서단에 위치한 자치 지방입니다
GalacianSEPTBible (Galacian 1989 (Biblia SEPT))     

가르왈리어(Garhwali)는 주로 인도 북부 우타라칸드(Uttarakhand) 주의 가르왈(Garhwal) 지역에서 사용되는 언어입니다.
GarhwaliBible (Garhwali (GHMNT) (गढवली नयो नियम) 2020)     
GarhwaliGBMBible (Garhwali GBM (Garhwali))

조지아(Georgia)는 동유럽과 서아시아의 교차점인 캅카스(Caucasus) 지역에 위치한 국가입니다. 
Georgian2002Bible (Georgian GEO02 (ბიბლია))     
Georgian2012Bible (Georgian 2013 (ბიბლია))
GeorgianBible (Georgian (OGB) Old Georgian)

독일(Germany)은 서유럽 및 중앙유럽에 위치한 국가로, 북쪽으로는 발트해와 북해, 남쪽으로는 알프스 산맥 사이에 자리 잡고 있습니다. 
German1545Bible (German Luther 1545)        
German2011Bible (German 2011 (Neue Genfer Übersetzung))
GermanAlbrecht1926Bible (German (Albrecht NT und Psalmen))
GermanBible (German (Die Heilige Schrift (Schlachter 1951)))
GermanElber1905Bible (German Elber 1905 (Darby Unrevidierte Elberfelder))
GermanGruenewaldBible (German Gruenewald (Grünewald) 1924)
GermanHeuteBible (German HEUTE (Bibel Heute))
GermanHFABible (German HFA (Hoffnung für Alle))
GermanInterlinearBible (German Interlinear 1979 (Interlinearübersetzung))
GermanLUT17Bible (German LUT17 Lutherbibel 2017)
GermanLuther1912Bible (German Luther (Lutherbibel 1912))
GermanLutherHeuteBible (German Luther Heute 2021)
GermanSchlachter2000Bible (German SCH2000 Schlachter 2000 (Die Bibel (Schlachter 2000)))
GermanTafelBible (German Bible Tafel (Tafelbibel) 1911)
GermanTKWBible (German TKW (Textbibel von Kautzsch und Weizsäcker))
GermanUbersetzung2014Bible (German Ubersetzung 2014)

Ghomala'(고말라어)는 카메룬(Cameroon)에서 사용되는 언어입니다
GhomalaBible (Ghomala New Testament (GNT02))        

그리스(Greece)는 동남유럽 발칸반도 남쪽 끝에 위치하며, 지중해와 접해 있는 국가입니다
Greek1550Bible (Greek Stephanus NT 1550)        
GreekBible (Greek Bible - Neophytos Vamvas Translation 1770)
GreekBYZ04Bible (Greek BYZ04 (Πατριαρχικό Κείμενο (Έκδοση Αντωνιάδη, 1904)))
GreekBYZ18Bible (Greek BYZ18 (Byzantine Textform 2018))
GreekElzevirBible (Greek TR1624 (Elzevir Textus Receptus 1624))
GreekF35Bible (Greek F35 (Η Ελληνική Καινή Διαθήκη Σύμφωνα με την Οικογένεια 35))
GreekFPBBible (Greek FPB (H Αγία Γραφή στη Δημοτική (Filos Pergamos)))
GreekGNTBible (Greek GNT 1904)
GreekLMGNTBible (Greek LMGNT (Νεοελληνική Μετάφραση Λόγου))
GreekModern1904Bible (Greek Modern Bible 1904)
GreekModernFPBBible (Greek Modern Bible  FPB 1994)
GreekNTVBible (Greek NTV (Η Καινή Διαθήκη του Κυρίου και Σωτήρος ημών Ιησού Χριστού κατά νεοελληνικήν απόδοσιν))
GreekSBLGNTBible (Greek SBLG (SBL Greek New Testament))
GreekTCGNTBible (Greek TCGNT (Text-Critical Greek New Testament))
GreekTGVBible (Greek TGV (Η Αγία Γραφή (Παλαιά και Καινή Διαθήκη)))
GreekTHGNTBible (Greek THGNT (The Greek New Testament))
GreekTR1894Bible (Greek TR1894 (Scrivener’s Textus Receptus 1894))

과라니족(Guarani)은 주로 남아메리카 중남부 지역에 거주하는 원주민입니다.
Guarani1913Bible (Guarani (Tûpâ Ñandeyára 1913))        
Guarani1970Bible (Guarani 1970 (Ñandeyara Ñe'ẽ))
Guarani1996Bible (Guarani 1996 (Ñandejara Ñe’ẽ ✟))
Guarani2001Bible (Guarani 2001 (Biblia Guarani, Tumpa Iñee))
Guarani2015Bible (Guarani 2015 (Ñanderuete Ñe’ẽ Porã 2015))
Guarani2017Bible (Guarani (Biblia) 2017)
GuaraniBible (Guarani (Nuevo Testamento Guaraní Pe))
GuaraniMBYABible (Guarani MBYA (Nhanderuete ayvu iky'a e'ỹ va'e))
GuaraniSIMBABible (Guarani (Guaraní Pe (Western) Simba))

구자라트 는 인도 구자라트 주에서 주로 사용되는 인도아리아어족 언어로 , 주로 구자라트 사람들이 사용합니다.
Gujarati2016Bible (Gujarati 2016 BSI (GUCL) (પવિત્ર બાઇબલ C.L.))       
Gujarati2017Bible (Gujarati (IRVGUJ) (ઇન્ડિયન રીવાઇઝ્ડ વર્ઝન ગુજરાતી - 2019))
GujaratiBible (Gujarati ERV 2003 (પવિત્ર બાઈબલ))
GujaratiGUOVBible (Gujarati BSI (GUOV) (પવિત્ર બાઇબલ OV Reference Bible (BSI)))

EBIBILIA ENCHENU는 케냐 서부 지역의 구시어(Ekegusii)로 번역된 성경입니다
GussiBible (Gussi (EBIBILIA ENCHENU) 2020)  

Hadiyya(하디야)는 에티오피아 남중부 지역에 위치한 행정 구역(Zone)이자 그 지역에 거주하는 민족 집단입니다
HadiyyaBible (Hadiyya (KEESAMMI KITAABA))   

아이티(Haiti)는 북아메리카 카리브해에 위치한 섬나라입니다.
HaitianBible (Hatian (1998 Haïtienne))      
HaitianBSABible (Haitian BSA (Bib Sen An Kreyòl Ayisyen) 2023)
HaitianHWPBible (Hatian Creole (HWP) 2000)
HaitianVFKBible (Hatian VFK (Nouvo Testaman Vèsyon Kreyòl Fasil))

하리얀비어(Haryanvi)는 주로 인도 북부의 하리아나(Haryana) 주에서 사용되는 인도-아리안 언어입니다
HaryanviBible (Haryanvi Bible (हरियाणवी))      

하우사(Hausa)족은 주로 아프리카 서부의 사헬 지역, 특히 나이지리아 북부와 니제르 남부에 집중 거주하는 민족입니다.
Hausa2010Bible (Hausa Bible 1979 (Littafi Mai Tsarki))       
Hausa2013Bible (Hausa (Sabon Rai Don Kowa 2020))
HausaARBible (Hausa Arabic 2020 (أَتَّوْرَتْ دَ أَنَّبَاوَا))

히브리어는 주로 이스라엘에서 사용하는 공식 언어입니다
Hebrew1885Bible (Hebrew Bible (DHNT) 1885 - Delitzsch's Hebrew New Testament)   
HebrewAleppoCodexBible (Hebrew Aleppo Codex Bible)
HebrewBible (Hebrew Bible Modern 1977)
HebrewBSIBible (Hebrew BSI 2017 (שעתוק אלקטרוני נאמן לכתב יד לנינגרד))
HebrewHHHBible (Hebrew (HHH) 2009 (Habrit HakhadashaHaderekh))
HebrewLeningradCodexBible (Hebrew Leningrad Codex)
HebrewMHBBible (Hebrew Bible (MHB) 2010)
HebrewMHNT2020Bible (Hebrew MHNT 2020 (הברית החדשה בעברית מודרנית))
HebrewTDBible (Hebrew TD 2018 (תנ'ך וברית חדשה בתרגום דליטש))

힌디어(Hindi)는 주로 인도 북부 및 중부 지역(힌디 벨트)에서 사용하는 언어로, 인도 연방의 공식 공용어입니다
Hindi2017Bible (Hindi 2017 (नया नियम))    
HindiBible (Hindi Bible HHBD = (BSI))
HindiCLBSIBible (Hindi Bible CLBSI 2015 (पवित्र बाइबिल CL Bible (BSI)))
HindiERVBible (Hindi Bible (ERV) (पवित्र बाइबल))
HindiFijiBible (Hindi Fiji (Nawa Haup))
HindiHSBBible (Hindi HSB 2023 (नवीन हिंदी बाइबल))
HindiHSSBible (Hindi HSS 2019 (सरल हिन्दी बाइबल))
HindiIRVBible (Hindi IRVHIN (इंडियन रिवाइज्ड वर्जन (IRV) हिंदी - 2019))
HindiOVBSIBible (Hindi HINOVBSI (पवित्र बाइबिल OV (Re-edited) Bible (BSI)))
HindiRomanBible (Hindi (Roman Script))

몽족(Hmong)은 중국 남부, 베트남, 라오스, 태국 등 동남아시아 산악 지대에 주로 거주하는 소수 민족입니다. 
Hmong2000Bible (Hmong Bible (Vajtswv Txojlus 2000))     
Hmong2004Bible (Hmong Bible 2004)

헝가리(Hungary)는 중부 유럽(또는 동남유럽)에 위치한 내륙 국가로, 수도는 부다페스트입니다.
HungarianBDUZBible (Hungarian Bible (BDUZ) 1951 - Hungarian Bekes — Dalos NT)   
HungarianBible (Hungarian HUNB (Magyar Bibliatársulat új fordítású Bibliája))
HungarianBUZBible (Hungarian Bible (BUZ) 1967 - Dr. Budai Gergely Ujszovetseg forditasa)
HungarianCSIABible (Hungarian Bible by Lajos Csia)
HungarianCSUZBible (Hungarian (CSUZ) 1924 - Czeglédy Sándor Újszövetség fordítása)
HungarianEFOBible (Hungarian EFO (BIBLIA Egyszerű Fordítás))
HungarianEIVBible (Hungarian (EIV) (Újszövetség élet, igazság és világosság))
HungarianERVBible (Hungarian Bible (ERV) 2012)
HungarianKaroliBible (Hungarian (Karoli Bible 1908))
HungarianKIBBible (Hungarian Bible - KIB 1935 - Kecskeméthy István)
HungarianKNBBible (Hungarian Bible (KNB) 1997 - Káldi Neovulgata Bible)
HungarianKSZEBible (Hungarian Bible - (KSZE) 2011 - Revideált Károli Biblia)
HungarianMRUZBible (Hungarian Bible (MRUZ) 1925 - Dr. Masznyik Endre Újszövetség fordítása)
HungarianRLUZBible (Hungarian Bible (RLUZ) 1971 - Ravasz László Újszövetség fordítása)
HungarianRUFBible (Hungarian RUF (Revised Hungarian Bible))
HungarianSIUZBible (Hungarian Bible (SIUZ))
HungarianVSUZBible (Hungarian Bible 1971 (VSUZ) - Vida Sándor Újszövetség fordítása)

Bup Kudus는 말레이시아 사라왁주, 인도네시아 칼리만탄 바랏, 브루나이 등지에서 사용하는 이반어(Iban language) 성경을 뜻합니다
IbanBible (Iban (Bup Kudus))        

이비비오(Ibibio)족은 나이지리아 남동부 지역에 주로 거주하는 민족입니다
IbibioBible (Ibibio (Ñwed Abasi Ke Ikọ Ibibio Ayo Mfịn))    

아이슬란드(Iceland)는 북대서양 북서쪽 끝, 그린란드와 영국 사이에 위치한 유럽의 섬나라입니다.
Icelandic1981Bible (Icelandic 1981 (Biblían (1981)))    
IcelandicBible (Icelandic 2007 (Biblían (2007)))

이그보족(Igbo)은 나이지리아 남부 및 동남부 지역에 주로 거주하는 민족입니다. 
Igbo1988Bible (Igbo Bible 1988)     
Igbo2006Bible (Igbo (Bible Nso))
Igbo2020Bible (Igbo 2020 (Baịbụlụ Nsọ nʼIgbo Ndị Ugbu a))

2018년 판 이카(Ika) 성경은 주로 나이지리아 이카 지역에서 사용되는 언어로 번역된 성경
IkaBible (Ika 2018 Bible)       

일로카노어(Ilokano/Iloko)는 주로 필리핀 북부 지역에서 사용되는 언어입니다
Ilokano1973Bible (Ilokano (Ti Biblia (1973)))   
IlokanoBible (Ilokano (Ti Baro a Naimbag a Damag Biblia) 1996)

일롱고(Ilonggo)어 또는 힐리가이논(Hiligaynon)어는 주로 필리핀 중부 비사야(Visayas) 제도 지역에서 사용되는 언어입니다
Ilonggo2012Bible (Ilonggo (Maayong Balita nga Biblia (2012)))       
IlonggoAPDBible (Ilonggo APD 2022 (Ang Pulong Sang Dios))
IlonggoBible (Ilonggo (Ang Biblia (1982)))

인도네시아(Indonesia)는 동남아시아에 위치한 국가로, 말레이 제도에 있는 세계 최대의 도서 국가입니다
IndonesianAGSBible (Indonesian AGS (Alkitab Gratis untuk Semua))        
IndonesianAMD2021Bible (Indonesian AMD 2021 (Perjanjian Baru Alkitab Mudah Dibaca))
IndonesianBible (Indonesian (Alkitab Terjemahan Baru))
IndonesianBISBible (Indonesian BIS 1985 (Alkitab dalam Bahasa Indonesia Masa Kini))
IndonesianBPJBible (Indonesian Bible (BPJ) - Kitab Perjanjian Baru - Year No Data)
IndonesianFAYHBible (Indonesian FAYH (Firman Allah Yang Hidup))
IndonesianINOTAZIBible (Indonesian INOTAZI (Indonesian Tazi NT))
IndonesianPBTB2Bible (Indonesian PBTB2 (Perjanjian Baru Terjemahan Baru Edisi 2))
IndonesianTLBible (Indonesian TL 1954 (Alkitab Terjemahan Lama))
IndonesianTSIBible (Indonesian Bible (TSI) 2013 - (Terjemahan Sederhana Indonesia))
IndonesianVMDBible (Indonesian VMD 2005)

'Irish'는 아일랜드(Ireland)의 사람, 언어, 문화를 뜻하며, 아일랜드는 유럽 북서쪽에 위치한 섬나라입니다.
Irish1817Bible (Irish 1817 (An Bíobla Naomhtha 1817 (Bedell)))  
Irish1951Bible (Irish 1951 (Tiomna Nua 1951 (de Siúnta)))
Irish1970Bible (Irish 1970 (An Tiomna Nua 1970 (Ó Cuinn)))
Irish2012Bible (Irish 2012 (An Tiomna Nua Agus Leabhar na Salm 2012))
IrishBible (Irish 1981 - (An Bíobla Naofa 1981))


Italian1649Bible (Italian 1885 (Diodati Bibbia 1885))  이탈리아
Italian2014Bible (Italian Bible (ICL00D) (Traduzione Interconfessionale in Lingua Corrente))
Italian2020Bible (Italian 2020 (La Sacra Bibbia Versione Riveduta 2020 (R2)))
ItalianBible (Italian CEI 1974)
ItalianCEI2008Bible (Italian Bible (CEI) 2008)
ItalianIPNBible (Italian Bible (IPN) 1996 San Paolo)
ItalianLaNuovaDiodatiBible (Italian Bible (LND) 1991)
ItalianNR1994Bible (Italian (Nuova Riveduta 1994))
ItalianRivedutaBible (Italian (Versione Diodati Riveduta))

Iu Mien(이우몐/유멘)족은 중국 남부와 동남아시아 산악 지대에 주로 거주하는 소수 민족입니다
IuMienBible (Iu Mien (Iu-Mien New))     
IuMienThaiBible (Mien Bible (Thai Script) © Thailand Bible Society, 2007)

자메이카(Jamaica)는 북아메리카 카리브해에 위치한 섬나라입니다. 
JamaicanBible (Jamaican 2012 (Di Jamiekan Nyuu Testiment))      

일본
Japanese1965Bible (Japanese 1965)
Japanese1987Bible (Japanese 1988 (Seisho Shinkyoudoyaku 聖書 新共同訳))
Japanese2017Bible (Japanese 2017 (バイブル 新約聖書))
JapaneseBible (Japanese (Colloquial version (1955)))
JapaneseCO1955Bible (Japanese (CO1955) (聖書　口語訳))
JapaneseERVBible (Japanese ERV (訳 ー 読みやすい聖書 ー（新約聖書）))
JapaneseJCBBible (Japanese Contemporary (リビングバイブル))

자바인(Javanese)은 주로 인도네시아 자바섬(Java Island)의 중부 및 동부 지역에 거주하는 민족입니다
JavaneseBible (Javanese Bible 1981)     
JavaneseJVNBible (Javanese JVN (Javanese, Caribbean))
JavaneseKJS17Bible (Javanese KJS17 (Kitab Jawa Suriname))

카바르디아어(Kabardian, East Circassian)는 주로 러시아 북캅카스 지역에서 사용되는 언어입니다
KabardianBible (Kabardian 1993 (ХъыбарыфӀыр. ЩӀэдзапӀэр. Уэрэд ЛъапӀэхэр))      

카빌(Kabyle)족은 주로 알제리 북부에 거주하는 베르베르(Berber)계 원주민입니다.
KabyleBible (Kabyle Maybe is 2001)      

카친(Kachin)은 미얀마 최북단에 위치한 카친주(Kachin State)를 의미합니다. 
KachinJCLBBible (Kachin JCLB (Jinghpaw))    
KachinJHVT3Bible (Kachin JHVT3 (Jinghpaw Hanson Version Bible))

칼렌진(Kalenjin)족은 주로 케냐의 서부 고지대(특히 리프트 밸리 지역)에 거주하는 나일족 계열의 민족입니다 
Kalenjin2019Bible (Kalenjin 2019 (Bukuit Ne Tilil))     
KalenjinBible (Kalenjin Bible (BUKUIT NE TILIL))
KalenjinRevisedBible (Kalenjin Bible Revised (BUKUIT NE TILIIL Sireet ne Dutero Kanon))

'Kamba(캄바)'는 주로 케냐 중남부 지역에 거주하는 반투계 원주민 부족을 의미하며, 동부 아프리카에 위치합니다
KambaBible (Kamba (MBIVILIA ŨVOO MŨSEO))    
KambaMBIVLIABible (Kamba (Mbivilia) 1956)

'Kangri(캉그리)'는 주로 인도 북부 라다크(Ladakh) 지역에 있는 히말라야 산맥의 고봉들을 지칭하는 말로 쓰입니다
KangriBible (Kangri (काँगड़ी))      

칸나다어(Kannada)는 인도 남서부 카르나타카(Karnataka) 주의 공식 언어입니다.
Kannada2022Bible (Kannada KSB 2022 (ಕನ್ನಡ ಸಮಕಾಲಿಕ ಅನುವಾದ))       
KannadaBible (Kannada (ERV) 1997 (ಪರಿಶುದ್ದ ಬೈಬಲ್‌))
KannadaBSIBible (Kannada BSI Bible 2016)
KannadaBSIJVBible (Kannada BSI JV (ಕನ್ನಡ ಸತ್ಯವೇದವು J.V. (BSI)))
KannadaIRVBible (Kannada 2019 (ಇಂಡಿಯನ್ ರಿವೈಜ್ಡ್ ವರ್ಸನ್ (IRV) - ಕನ್ನಡ - 2019))
KannadaKNCLBible (Kannada Bible (KNCL) BSI 2016)

카라칼파크스탄(Karakalpakstan)은 우즈베키스탄 북서부에 위치한 자치공화국입니다.
Karakalpak2004Bible (Karakalpak (Жаңа Келисим))     
Karakalpak2022Bible (Karakalpak 2022 (Мухаддес Китап))
KarakalpakK2022Bible (Karakalpak (Muxaddes Kitap) 2022)

카자흐스탄(Kazakhstan)은 중앙아시아와 동유럽에 걸쳐 있는 나라입니다
Kazakhstan2023Bible (Kazakhstan 2023 (Zhana Osiet))     
KazakhstanBible (Kazakhstan 1993 (Киелі Кітап))

케냐(Kenya)는 동아프리카에 위치한 나라입니다
KenyaGIKCLBible (Kikuyu Bible 2008 (Kenya) - IBUKU RĨA ŨHORO ŨRĨA MWEGA (GIKCL))    

'크메르(Khmer)'는 주로 캄보디아(Cambodia)를 의미하며, 동남아시아에 위치하고 있습니다
Khmer2005Bible (Khmer 2005 (ព្រះគម្ពីរភាសាខ្មែរបច្ចុប្បន្ន ២០០៥))   
Khmer2012Bible (Khmer 2012 (Khmer Christian Bible))
Khmer2014Bible (Khmer 2014 (អាល់គីតាប))
Khmer2016Bible (Khmer (ព្រះគម្ពីរបរិសុទ្ធកែសម្រួល ២០១៦))
Khmer2019Bible (Khmer 2023 (ព្រះគម្ពីរខ្មែរសាកល))
KhmerBFBSBible (Khmer BFBS (ព្រះគម្ពីរបរិសុទ្ធ ១៩៥៤))
KhmerBible (Khmer Standard Version 1954 = Hammond Version)

과테말라의 마야 언어인 키체어(Kʼicheʼ) 성경
Kiche1995Bible (Kiche 1995 (Quiché Bible))      
Kiche2022Bible (Kiche (RI KꞌAKꞌ TESTAMENTO PA TZIJOBꞌAL KꞌICHEꞌ))
KicheBible (Kiche QUCT)
KicheQUCNBible (Kiche QUCN (New Orthography))

키쿠유(Kikuyu)는 동아프리카 케냐(Kenya)의 수도 나이로비 근교에 위치한 도시이자, 해당 지역을 중심으로 거주하는 케냐 최대의 민족 그룹입니다
Kikuyu2013Bible (Kikuyu 2013 (Kiugo Gĩtheru Kĩa Ngai, Kĩrĩkanĩro Kĩrĩa Gĩkũrũ Na Kĩrĩa Kĩerũ))      
Kikuyu2014Bible (Kikuyu (Kĩrĩkanĩro Gĩa Gĩkũyũ))
Kikuyu2019Bible (Kikuyu Bible (IBUKU RĨRĨA ITHERU RĨA NGAI))

1950년판 키크완고(Kikwango/Kituba) 신약 성경
KikwangoBible (Kikwango Bible (Le Nouveau Testament en Kikwango 1950))      

킴분두어(Kimbundu)는 앙골라(Angola) 북서부 지역에서 주로 사용되는 반투어군 언어입니다
KimbunduBible (Kimbundu (O Mikanda Ikola))      

키메루어 (Kimeru), Catholic Edition
KimiiruBible (Kimiiru (NTETO INJEGA CIA MURUNGU KIRI ANTU BONTHE CATHOLIC EDITION))     




키냐르완다어(Kinyarwanda)는 아프리카 중동부에 위치한 르완다 공화국의 공식 언어입니다
Kinyarwanda2001Bible (Rwandan Kinyarwanda (BYSB) 2001 (Bibiliya Yera))
Kinyarwanda2012Bible (Kinyarwanda 2012 (Bibiliya Ntagatifu))        .
KinyarwandaBIRBible (Kinyarwanda 2001 (BIR) (Bibiliya Ijambo ry'imana))

키룬디어(Kirundi/Rundi)는 주로 동아프리카의 부룬디(Burundi)에서 사용되는 반투어군 언어입니다. 
KirundiCorosheBible (Kirundi (Bibiliya mu Kirundi Coroshe) Uburenganzira © 2021 bwa Biblica, Inc)   
KirundiRishaBible (Kirundi (Bibliya Yera 1951, 1967 (Burundi)))

키투바(Kituba, Kikongo ya leta)는 중앙아프리카의 콩고 공화국(Republic of the Congo)과 콩고 민주 공화국(DR Congo)에서 주로 사용되는 반투어 기반의 크리올어이자 공용어입니다
KitubaBible (Kituba (BIBILIYA NA KITUBA))   

콘카니어(Konkani)는 주로 인도 서부 해안(콘칸 지역)에서 사용되는 언어입니다
KonkaniBible (Konkani Bible (Novo Korar NT (BSI)))      

한국어
Korean2021Bible (Korean 2021 (읽기 쉬운 성경))
KoreanAEBBible (Korean AEB)
KoreanBible (Korean 1961 (개역한글))
KoreanCatholicBible (Korean Catholic 2005)
KoreanKLBBible (Korean KLB (현대인의 성경))
KoreanNKRVBible (Korean NKRV Bible 1998)
KoreanNLTNKBible (Korean NLTNK (God’s Promises New Testament in North Korean))
KoreanRentierBible (Korean Rentier Bible)
KoreanRNKSVBible (Korean RNKSV (새번역))
KoreanTKVBible (Today's Korean Version TKV 1991)
KoreanWoorimalBible (Korean Woorimal 2004)
KoyaBible (Koya (ପୁନାଦ୍ ଆର୍ର୍, ପୁନାଦ୍‍ ନିୟମ୍‍))

크리오어(Krio)는 주로 서아프리카의 시에라리온(Sierra Leone)에서 사용되는 영어 기반의 크리올어입니다
KrioBible (Krio (Krio Fɔs Oli Baybul))  

쿠마오니(Kumaoni)족은 주로 인도 우타라칸드(Uttarakhand) 주의 쿠마온(Kumaon) 지역에 거주하는 인도아리아 어족 언어 집단입니다
KumaoniBible (Kumaoni (सोरियाली नय्या नियम) 2020)  

쿠르드족(Kurdish)은 특정 국가 없이 서아시아의 튀르키예 동남부, 이라크 북부, 이란 북서부, 시리아 북동부에 걸친 '쿠르디스탄' 지역에 분산되어 거주하는 민족입니다.
Kurdish2005Bible (Kurdish (Kurmanji Încîl))     
Kurdish2017Bible (Kurdish Bible (PNU) 2016 - Peymana Nû (Încîl))
KurdishBHDBible (Kurdish - Behdini Kurdish (ئنجیلا پیرۆز))
KurdishBible (Kurdish Sorani KSS 2020 (كوردی سۆرانی ستانده‌رد))
KurdishKMRNTCBible (Kurdish Kurmanji Cyrillic (KMRNTC) (Пәймана Ну (Инщил)) 2000)
KurdishKMRNTLBible (Kurdish Kurmanji Latin (Peymana Nû (Încîl)))
KurdishPNTZSBible (Kuridsh Sorani (پەیمانی نوێ و زەبوورەکان بە سۆرانی))
KurdishSKBBible (Kurdish Kurmanji 2024 SKB (کتاب مقدس به زبان کردی شیکاکی))
KurdishSKVBible (Kurdish Southern SKV (Kalhori) (کتاب مقدس به زبان کردی جنوبی - گویش کلهوری))

쿠루크어(Kurukh)는 주로 인도 동부 및 중부 지역에서 사용되는 북드라비다어족 언어입니다
Kurukh2025Bible (Kurukh NT 2025)    
KurukhBible (Kurukh (पुना गच्छरना NT (BSI)))

키르기스스탄(Kyrgyzstan)은 중앙아시아에 위치한 내륙국입니다.
Kyrgyz2004Bible (Kyrgyz 2004 - Кыргыз тилиндеги Библия - Kyrgyz Tilindegi Bible)     
Kyrgyz2005Bible (Kyrgyz 2005 - (Инжил ЛС (2005)))

라후족(Lahu)은 주로 동남아시아의 산악 지대와 중국 남서부 윈난성 일대에 거주하는 소수 민족입니다
LahuBible (Lahu (Lahu Bible Edited))    
LahuLHINTBible (Lahu LHINT (Lahu Shi))

람바디(Lambadi 또는 Banjara)는 주로 인도 전역에 퍼져 살고 있는 유목민 출신의 부족(또는 커뮤니티)입니다.
LambadiBible (Lambadi 2025 (పవిత్తర్ బైబిల్ (బంజారాలంబాడిగోర్బోలి)))    

Lango(랑고)는 주로 우간다 북중부 지역(Lango sub-region)에 거주하는 랑고족이 사용하는 언어이자 그 지역을 지칭합니다
Lango1979Bible (Lango New Testament)    
LangoBible (Lango (BUK OBAŊA ACIL AME OLWOŊO NI BAIBUL AME OGEO LOKO I LEB LAŊO))

라오스(Laos)는 동남아시아 인도차이나 반도 중심부에 위치한 내륙국입니다
Lao2012Bible (Lao Bible 2012 (ພຣະຄຳພີສັກສິ))   
LaoBible (Lao Bible (ฉบับอักษรลาว))
LaoLCVBible (Lao 2023 (ພຣະຄຳພີລາວສະບັບສະໄໝໃໝ່))

라틴어(Latin)는 고대 이탈리아반도 중부, 지금의 로마 주변인 라치오(Latium) 지방에서 유래했습니다. 
LatinBible (Latin - Vulgate Version)    
LatinClementina1914Bible (Latin - Vulgata Clementina Hetzenauer Editore 1914)
LatinClementineBible (Latin - Clementine Vulgata 1598)
LatinNovaVulgataBible (Latin - Nova Vulgata 1979)
LatinSistinaBible (Latin - Vulgata Sistina)

라트비아(Latvia)는 북유럽 발트해 연안에 위치한 국가입니다
Latvian1965Bible (Latvian (RT65) 1965 (1965. Gada Bībeles Izdevuma Revidētais Teksts))  
Latvian2012Bible (Latvian NLB (New Latvian Inter-Confessional Bible))
Latvian2024Bible (Latvian 2024 (Jauna Pārstrādāta latviešu Bībele 2024))
LatvianBible (Latvian LJD (Latviešu Jaunā Derība))
LatvianGluckBible (Latvian Gluck 1685 (LvGluck8)  Glika Bībele 8. Izdevums)
LatvianLG8Bible (Latvian LG8 (Glika Bībele 8. Izdevums))
LatvianLTV1965Bible (Latvian LTV 1965 (LATVIJAS BĪBELES BIEDRĪBA))
LatvianNLBDCBible (Latvian NLBDC (New Latvian Inter-Confessional Bible with Deuterocanonicals))

라이베리아(Liberia)는 서아프리카 해안에 위치한 국가입니다
LiberianKreyolBible (Liberian Kreyol (ꕢꕌꔳ ꕺꖃ ꕯꕮꕊ))  

링갈라어(Lingala)는 주로 중앙아프리카 지역에서 사용되는 언어입니다
Lingala2002Bible (Lingala Bible 2002 (Mokanda na Bomoi))    
Lingala2020Bible (Lingala 2020 (Mokanda na Bomoi))

리투아니아(Lithuania)는 북유럽 발트해 연안에 위치한 나라로, 라트비아, 벨라루스, 폴란드, 러시아(칼리닌그라드)와 국경을 맞대고 있는 발트 3국 중 가장 남쪽에 있는 국가입니다
Lithuanian2012Bible (Lithuanian 2012 LBDC (Biblija arba Šventasis Raštas))  
Lithuanian2012EKUBible (Lithuanian 2012 EKU (A. Rubšio ir Č. Kavaliausko Vertimas su Antrojo Kanono Knygomis))
Lithuanian2012KANBible (Lithuanian LBD-KAN (A. Rubšio ir Č. Kavaliausko Vertimas be Antrojo Kanono Knygų))
LithuanianBible (Lithuanian (KBV) (Biblija. Senasis Testamentas. Naujasis Testamentas))
LithuanianKJBible (Lithuanian Bible (Karaliaus Jokūbo Versija Lietuviškai 2012 Edition) 2012 - KJV)
LithuanianLBDBible (Lithuanian (LBD) 2012 (Biblija arba Šventasis Raštas))

롬웨(Lomwe 또는 Elhomwe)족은 주로 모잠비크 북부(잠베지아주, 남풀라주)와 말라위 남동부 지역에 거주하는 반투계 부족입니다
LomweBible (Nlakano Nahihano ni Masalmo 1930))  

루간다어(Luganda, 또는 Oluganda)는 아프리카 동부 우간다(Uganda)에서 주로 사용되는 언어입니다
Luganda2003Bible (Luganda (Luganda Bible 2003) (LB03))  
LugandaBible (Luganda 1968 (Ekitabo Ekitukuvu ekiyitibwa Baibuli Endagaano Enkadde n'Empya))
LugandaBIBU1Bible (Luganda (BIBU1) (BIBULIYA ENTUKUVU))
LugandaEEEEBible (Luganda (EEEE) (Endagaano Enkadde n’Endagaano Empya))
LugandaLBRBible (Luganda (LBR) (EKITABO EKITUKUVU, BAIBULI))

루그바라(Lugbara)족은 주로 우간다 북서부의 서나일(West Nile) 지역과 인접한 콩고민주공화국(DRC)의 오리엔탈주에 거주하는 나일계 민족입니다.
LugbaraBible (Lugbara (E’yo Siza Alatararu Munguniri BIBLIA))   

루구루(Luguru)족 또는 울루구루(Uluguru) 산맥은 탄자니아 동부 모로고로(Morogoro) 지역에 위치해 있습니다
LuguruBible (Luguru - Laghano - Ikiruguru - Chilughuru - (Laghano Lya Sambi Kwe Iwanu Wose))    

돌 루오 방언 ( [d̪ólúô] 로 발음되는 ) 또는 나일어족 카비론 도(Nilotic Kavirondo )는 나일어족 의 루오어 그룹 에 속하는 방언
Luo1985Bible (Luo (Acoli Baibul) 1985)  
Luo2015Bible (Luo (MUMA MALER 1976))
Luo2020Bible (Luo 1980 (Motingʼo Loko Manyien))

마사이족(Maasai)은 동아프리카에 거주하는 유목 민족으로, 주로 케냐 남부와 탄자니아 북부의 경계 지역에 걸쳐 살고 있습니다.
Maasai1970Bible (Maasai 1964 (Osotua Ng'ejuk))      
Maasai2020Bible (Maasai 2020 (BIBLIA SINYATI))
MaasaiBible (Maasai 2018 (BIBLIA SINYATI TE NKUTUK OO LMAASAI NATISIRAKI ENG'EJUK NAATA MBUKUI E DITROKANONI))
MaasaiMBSBible (Maasai (Biblia Sinyati))

'마케도니아'는 지리적, 역사적으로 발칸반도 지역을 의미하며, 현재는 크게 두 곳으로 나뉩니다. 
Macedonian1990Bible (Macedonian (Свето Писмо (Гаврилова) 1990))     
Macedonian2006Bible (Macedonian (Свето Писмо Стандардна Библија 2006 (66 книги)))
Macedonian2006DBible (Macedonian 2006 D - (Свето Писмо Стандардна Библија 2006 (со Девтероканонски Книги)))
Macedonian2023Bible (Macedonian 2023 (Нов Превод на Новиот Завет 2023))
MacedonianMKB1999Bible (Macedonian 1999 (MKB) - (Библија Стариот и Новиот Завет, Константинов))
MacedonianMNT1999Bible (Macedonian 1999 (MNT) (Динамичен Превод на Новиот завет на Македонски Јазик))

마두라어(Madurese)는 주로 인도네시아 동자바주의 마두라섬(Madura Island)과 그 주변 섬, 그리고 자바섬 동부 지역에서 사용되는 언어입니다
MadureseBible (Madurese Bible 1994 (ALKETAB E DHALEM BASA MADURA))  

마이틸리어(Maithili)는 주로 인도 북부와 네팔 남동부 지역에서 사용되는 인도아리아어군 언어입니다
MaithiliBible (Maithili - 2010 (Jivən Səndesh))     

마쿠아(Makhuwa, Makua)족과 마쿠아어는 주로 모잠비크 북부 지역에 집중되어 거주하는 반투계 민족 및 언어입니다.
Makhuwa2021Bible (Makhuwa 2021 (Nleehano Nonaanano Imeetto; Moçambique))    
MakhuwaBible (Makhuwa (Makua New Testament))
MakhuwaVMKBible (Makhuwa VMK (Emakhuwa Bible))

마콘데(Makonde)족은 주로 동아프리카의 탄자니아 남부와 모잠비크 북부 접경 지역에 거주하는 부족입니다.
MakondeBible (Makonde (Bibiliya ya Chimakonde))     
MakondeShiBible (Makonde Shimakonde (Ibibiliya mu Shimakonde Imbodi Yaambi na dimbande dya Imbodi Yakala))

마다가스카르(Malagasy)는 아프리카 대륙 동남쪽, 인도양에 위치한 섬나라입니다.
Malagasy1865Bible (Malagasy Bible 1865)     
Malagasy2003Bible (Malagasy 2003 (Baiboly Katolika))
Malagasy2004Bible (Malagasy 2004 (DIEM PROTESTANTA))
Malagasy2011Bible (Malagasy (Baiboly Protestanta Malagasy 2011))
MalagasyBible (Malagasy 2019 (Baiboly Protestanta Malagasy))
MalagasyMRVBible (Malagasy MRV 2011 (La Bible en Malgache))

말라얄람어는 인도에서 상당수의 사람들이 사용하는 언어이며 케랄라 주의 주요 언어입니다.
Malayalam1910Bible (Malayalam (മലയാളം സത്യവേദപുസ്തകം 1910 പതിപ്പ് (പരിഷ്കരിച്ച ലിപിയിൽ)))        
Malayalam2013Bible (Malayalam Bible POC-ML 2013)
MalayalamBCSBible (Malayalam Bible (IRV) 2019 (ഇന്ത്യൻ റിവൈസ്ഡ് വേർഷൻ - മലയാളം))
MalayalamBible (Malayalam 1992 MBSI)
MalayalamBSIBible (Malayalam (BSI) 2016 (സത്യവേദപുസ്തകം C.L. (BSI)))
MalayalamCVBible (Malayalam Contemporary Version (സമകാലിക മലയാളവിവർത്തനം))
MalayalamMalovBible (Malayalam Bible (OV-BSI) 2016 (സത്യവേദപുസ്തകം OV Bible (BSI)))
MalayalamWBTCBible (Malayalam (ERV) WBTC Bible)

말레이시아는 동남아시아의 태국 아래 위치한 국가로, 남중국해를 사이에 두고 말레이반도의 서말레이시아와 보르네오섬 북부의 동말레이시아 두 지역으로 나뉘어 있습니다.
Malaysian1996Bible (Malaysian (BM) 1996 (Alkitab Berita Baik Protestant Bible))     
Malaysian2017Bible (Malaysian 2017 (Perjanjian Baru Bahasa Manado))
Malaysian2020Bible (Malaysian 2020 (Perjanjian Baru Bahasa Melayu Maluku Utara))
MalaysianBible (Malaysian Version 2008)

마오리족(Māori)은 뉴질랜드(New Zealand)의 원주민입니다.
Maori2012Bible (Maori (Paipera Tapu 2012))      
MaoriBible (Maori MRI1952 (Te Paipera Tapu 1952))

마라티어는 인도의 22개 공용어 중 하나
Marathi2015Bible (Marathi MARVBSI (पवित्र शास्त्र RV (Re-edited) Bible (BSI)))       
MarathiBible (Marathi 2006 ERV WBTC)
MarathiBSIBible (Marathi MACLBSI (पवित्र शास्त्र CL New Testament (BSI)))
MarathiIRVMARBible (Marathı IRV (इंडियन रीवाइज्ड वर्जन (IRV) - मराठी))
MarathiMRCVBible (Marathi MRCV (पवित्रशास्त्र, मराठी समकालीन आवृत्ती))

마르와리(Marwari)는 인도 서부 라자스탄(Rajasthan)주의 마르와르(Marwar, 현 조드푸르 일대) 지역을 기반으로 하는 상인 공동체입니다
MarwariBible (Marwari Bible)    

마잔다라니(Mazanderani)는 주로 이란 북부, 카스피해 남쪽 연안 지역에 거주하는 마잔다라니족이 사용하는 언어이자 그 지역을 뜻합니다
MazanderaniGMBBible (Mazanderani GMB (گیله ماز))
MazanderaniBible (Mazanderani EMB (کتاب مقدس به زبان مازندرانی - گویش شرقی))    
MazanderaniWMBBible (Mazanderani WMB (کتاب مقدس به زبان مازندرانی - گویش غربی))

메이테이족(Meitei)은 주로 인도 동북부 마니푸르(Manipur)주에 거주하는 토착 민족입니다
MeiteiBible (Meitei Bible (Anouba Warepnaba (Roman Script)) 2022)   

망드(Mende)는 프랑스 남부 옥시타니(Occitanie) 레지옹의 로제르(Lozère)주에 위치한 도시이며, 로제르주의 주도(Prefecture)입니다
MendeBible (Mende (Nupela Testamen long tokples Mende long Niugini))    

'메와리(Mewari)'는 인도 라자스탄주(Rajasthan) 남동부의 역사적 지역인 '메와르(Mewar)' 지역을 가리키거나, 그 지역에서 사용하는 언어를 뜻합니다
MewariBible (Mewari (नुवो नेम (मेवड़ी नया नियम)))   

미조어 (Duhlián ṭawng 이라고도 함)는 주로 인도 미조람 주에서 사용되는 티베트-버마어족 언어로, 미조람 주의 공식 언어 이자 공용어 입니다
MizoBible (Mizo Bible)  
MizoCLBSIBible (Mizo CL BSI (Common Language))
MizoOVBSIBible (Mizo OV BSI (THUTHLUNG HLUI (Re-edited) Bible (BSI)))

MobaBible (Moba (Yiesu Lɑbɑmɑnn Muɑl Ni))

몰도바(Moldova)는 동유럽에 위치한 내륙국입니다
MoldovianCyrillicBible (Moldovian Bible Cyrillic - (Ени Бааланты) (GAGNTC) 2006)     
MoldovianLatinBible (Moldovian Bible Latin - 2006 (Enі Baalantı))

몽골(Mongolia)은 동아시아 중앙부, 러시아(북쪽)와 중국(남쪽) 사이에 위치한 내륙국입니다
Mongolian2004Bible (Mongolian (Ариун Библи, 2004))      
Mongolian2013Bible (Mongolian (Ариун Библи 2013))

모리셔스 크레올어는 1968년 영국으로부터 독립한 모리셔스 공화국의 공용어 입니다
Morisyen2021Bible (Morisyen (Nouvo Testaman Kreol Morisien Harmonisation NTPS KM))      
MorisyenBible (Morisyen (Nouvo Testaman dan Kreol Morisien))

Mossi2014Bible (Mossi MPBU (WẼNNAAM SEBRE 2014))
MossiSBBible (Mossi Moore (KÃAB-PAALGÃ KOE-NOOGO))
MossiSSDCBible (Mossi (SEBR SÕNGO) 1998)

문다(Munda)는 솔로몬 제도, 웨스턴 주(Western Province) 뉴조지아 섬에 위치한 도시이자 마을입니다.
Munda2020Bible (Munda 2020 (ପାର୍‌ମେଶ୍ୱାର୍‌ଆଃ ଜୀନିଦ୍‌ ବାଚାନ୍‌, ନାୱା ନିୟାମ୍‌))  
MundaBible (Munda (ମୁଣ୍ଡା ନାୱା ନିୟାମ୍))

나와틀어(Nahuatl)는 주로 멕시코(Mexico) 중부 및 남부 지역에서 사용되는 토착 원주민 언어입니다
Nahuatl2012Bible (Nahuatl (Zacatlán, Ahuacatlán, Tepetzintla))  
Nahuatl2017Bible (Nahuatl 2017 (El Nuevo Testamento))
NahuatlBible (Nahuatl 1987 (In yencuic iyectlajtoltzin Dios itech ica toTeco Jesucristo))
NahuatlGUBible (Nahuatl GU (El Nuevo Testamento))
NahuatlNHEBible (Nahuatl NHE (Ya ni nopa yancuic tlajtoli tlen toteco toca mocajtoc))

모잠비크 성서 공회(Bible Society of Mozambique)에서 발행한 버전
Ndau2023Bible (Ndau 2023 (NOVO TESTAMENTO EM NDAU))     
NdauBible (Ndau (Bhaibheri Rakachena muChindau))

은데벨레족(Ndebele)은 주로 남아프리카 공화국과 짐바브웨에 거주하는 응구니 계통의 토착 종족입니다
Ndebele2002Bible (Ndebele Bible 1978 (iBhayibhili Elingcwele 1978))     
Ndebele2003Bible (Ndebele 2003 BEN (IBhayibhili Elingcwele LesiNdebele))
Ndebele2012Bible (Ndebele Bible (SND) 2012 (IsiNdebele 2012 Translation))
NdebeleBible (Ndebele Bible - 2010)

네팔어(Nepali)는 주로 네팔(Nepal)의 공용어이자 모국어입니다.
Nepali2008Bible (Nepali 2008 - (सरल नेपाली पवित्र बाइबल))      
Nepali2012Bible (Nepali 2012 (NNRV) New Revised Version (नेपाली नयाँ संशोधित संस्करण))
Nepali2021Bible (Nepali Contemporary Version 2021 (पवित्र बाइबल, नेपाली समकालीन संस्करण))
NepaliBible (Nepali ERV (पवित्र बाइबल))
NepaliTamangBible (Nepali Tamang 2011)

나이지리아(Nigeria)는 서아프리카에 위치한 국가입니다
NigerianPidginBible (Nigerian Pidgin Bible)     
    
노르웨이지안 에어 셔틀(Norwegian Air Shuttle)의 본사는 노르웨이 포르네부(Fornebu)에 위치해 있습니다
Norwegian1921Bible (Norwegian 1921 (Studentmållagsbibelen) (SMB))   
Norwegian1938Bible (Norwegian 1938 (Norsk Oversettelse 1938 Nynorsk))
Norwegian1978Bible (Norwegian (Bibelen 2011 Bokmål))
Norwegian2007Bible (Norwegian NB (Norsk Bibel 1988, 2007))
Norwegian2011Bible (Norwegian Brød Nye Testamente 2011)
Norwegian2018Bible (Norwegian 2018 (Bibelen - Guds Ord Hverdagsbibelen (Hermon Forlag)))
NorwegianBGOBible (Norwegian (Bibelen – Guds Ord 2017))
NorwegianBIBEL1978Bible (Norwegian 1978 (Bibel1978, 1985 - Bibelselskapet))
NorwegianBible (Norwegian 1930 (Det Norsk Bibelselskap 1930))
NorwegianELBBible (Norwegian ELB (En Levende Bok))
NorwegianN78BMBible (Norwegian (N78BM) (The Bible in Norwegian 1978, 1985 bokmål))
NorwegianN78NNBible (Norwegian (N78NN) (Bibelen 1978, 1985 Nynorsk))
NorwegianNY2011Bible (Norwegian 2011 (Bibelen 2011 Nynorsk))

누에르인(Nuer people)은 주로 남수단(South Sudan)과 에티오피아(Ethiopia) 접경 지역에 거주하는 나일계 민족입니다
NuerBible (Nuer (RUAC KUƆTH IN RƐL RƆ))     

루간다어(Luganda)로 된 성경을 의미합니다
Nyankole1964Bible (Nyankole 1964 (Baibuli Erikwera))        
NyankoleBible (Nyankole (EKITABO EKIRIKWERA BAIBULI N'EBITABO EBY'OMUBONANO APOKURUFADYUTROKANONIKO))

Odia(오디아어/오리야어)는 주로 인도 동부의 오디샤(Odisha) 주에서 사용되는 언어입니다
Odia2024Bible (Odia NTS2024 2024 (ದೆವಾಚಿ ಖರಿ ಖಬರ್))      
OdiaBible (Odia - 1840)
OdiaBSIBible (Odia BSI (ପବିତ୍ର ବାଇବଲ (CL) NT (BSI)))
OdiaERVBible (Odia Bible ERV 2004 (ପବିତ୍ର ବାଇବଲ))
OdiaIRV2017Bible (Odia IRV 2017 (ଓଡିଆ ବାଇବେଲ))
OdiaIRVBible (Odia IRV (ଇଣ୍ଡିୟାନ ରିୱାଇସ୍ଡ୍ ୱରସନ୍ ଓଡିଆ -NT))
OdiaOROVBible (Odia 2014 (Re-edited) (ପବିତ୍ର ବାଇବଲ (Re-edited) - (BSI)))

그리스(Greece)는 동남유럽 발칸반도 남쪽 끝에 위치하며, 지중해에 접해 있는 나라입니다
OriginalGreekBible (Greek New Testament)    

히브리어(Hebrew)는 주로 이스라엘에서 사용되는 공용어이며, 아프리카아시아어족에 속하는 셈어파 언어입니다.
OriginalHebrewBible (Hebrew)    

오로모(Oromo)족은 주로 동아프리카에 거주하는 민족 집단입니다. 
OromoGUJBible (Oromo Gujiii (KITAABA WOYYICHA))     
OromoGujiBible (Oromo Bible (Guji) 2007)
OromoKakuuHaaraakaBible (Oromo Bible (Kakuu Haaraaka))
OromoKitaabaWaaqaBible (Oromo Bible (KITAABA WAAQA) 2019)
OromoKitaabaWoyyuuBible (Oromo Bible (Kitaaba Woyyuu))
OromoWaadaaHaarawaBible (Oromo Bible (Waadaa Haarawa))
OromoWaadaaLammataaBible (Oromo Bible (WAADAA LAMMATAA) 2013)

팜팡가(Pampanga)는 필리핀의 루손섬 센트럴 루손 지방에 위치한 주입니다
PampangaBible (Pampanga (Ing Mayap a Balita Biblia))        

파푸아(Papua)는 뉴기니섬(New Guinea)의 서쪽 절반을 차지하고 있는 인도네시아의 영토입니다
PapuaNewGuineaBible (Papua New Guinea 1997)     
PapuaNewGuineaTokPisinBible (Papua New Guinea Tok Pisin (Buk Baibel Long Tok Pisin 2008 + DC))

파슈토어는 주로 파슈툰 족이 모국어로 사용하는 언어이며, 아프가니스탄의 두 공식 언어 중 하나로 다리어 와 함께 사용됩니다
Pashto2019Bible (Pashto 2019 (Pakistani Yousafzai Pashto))      
Pashto2023Bible (Pashto 2023 (Afghan Pashto Bible))
PashtoBible (Pashto Bible 1996 (Nangahari) - (د پښتو مقدس کتاب))

페르시아(Persia)는 현재의 이란(Iran) 이슬람 공화국입니다. 서남아시아에 위치한 이란의 옛 명칭으로, 1935년 페르시아에서 이란으로 국명을 변경하였습니다
Persian2005Bible (Persian Bible (FACB) 2005 - Persian Contemporary Bible)       
Persian2014Bible (Persian Bible (NMV) 2014 - New Millennium Version)
PersianBible (Persian Bible, POV (Persian Old Version) 1895)
PersianDariBible (Persian Dari Bible - Afgan Dialect - Version Good News for a New Age (GNN) == 2007)
PersianTPVBible (Persian TPV (مژده برای عصر جدید))

폴란드(Poland/Polska)는 중부 유럽에 위치한 국가입니다
Polish2016Bible (Polish 2016 (Słowo Życia))     
Polish2018Bible (Polish 2018 (Biblia, to jest Pismo Święte Starego i Nowego Przymierza Wydanie pierwsze 2018))
PolishBible (Polish (Biblia Warszawska 1975))
PolishGdansk2017Bible (Polish Gdansk 2018 (UWSPÓŁCZEŚNIONA BIBLIA GDAŃSKA))
PolishGdanskBible (Polish Gdansk 1881 - 1910 (Biblia Gdańska))
PolishNBGBible (Polish NBG (Nowa Biblia Gdańska))
PolishNPDBible (Polish NPD (Dobra Wiadomość o ratunku w Chrystusie. Nowy Przekład Dynamiczny Nowego Testamentu))
PolishSNPD4Bible (Polish SNPD4 (Biblia, to jest Pismo Święte Starego i Nowego Przymierza))

포르투갈어(Portuguese)
Portuguese1969Bible (Portuguese Bible Old Orthography)      
PortugueseA21Bible (Portuguese A21 (Biblia Almeida Século 21))
PortugueseAlmeida1628Bible (Portuguese Almeida 1628)
PortugueseAlmeida1753Bible (Portuguese Almeida 1753)
PortugueseARCBible (Portuguese ARC 2009 (Almeida Revista e Corrigida))
PortugueseBible (Portuguese Almeida Revista e Atualizada)
PortugueseBLTBible (Portuguese BLT Biblia Livre Para Todos)
PortugueseBPT09Bible (Portuguese BPT09 (Aprenda Mais Sobre a BÍBLIA para todos Edição Comum))
PortugueseCAPBible (Portuguese (CAP) Capuchinhos)
PortugueseMZNVIBible (Portuguese (Nova Versão Internacional, Português de Moçambique))
PortugueseNAABible (Portuguese NAA 2017 (Nova Almeida Atualizada))
PortugueseNBV2007Bible (Portuguese NBV-P (Nova Bíblia Viva Português))
PortugueseNTLHBible (Portuguese NTLH (Nova Tradução na Linguagem de Hoje))
PortugueseNVI2023Bible (Portuguese NVI 2023)
PortugueseNVIBible (Portuguese NVI 2000)
PortugueseNVTBible (Portuguese NVT (Bíblia Sagrada, Nova Versão Transformadora))
PortugueseOLBible (Portuguese OL 2017 (O Livro))
PortugueseTBBible (Portuguese TB (Tradução Brasileira))
PortugueseVFLBible (Portuguese (Bíblia Sagrada Versão Fácil de Ler) VFL)
PularBible (Pular (Version Pular Fuuta-Jallon))

'펀자브(Punjab)'는 남아시아 지역으로, 현재 인도 북서부와 파키스탄 동부에 걸쳐 있는 지역입니다
Punjabi2016Bible (Punjabi Bible 2016 - ਪਵਿੱਤਰ ਬਾਈਬਲ O.V.)      
Punjabi2020Bible (Punjabi Revised 2020 (Arabic Script) (پنجابی نواں عہد نامہ نظرثانی شدہ چھپائی))
Punjabi2021Bible (Punjabi 2021 CL-NA (ਪਵਿੱਤਰ ਬਾਈਬਲ (Revised Common Language North American Edition)))
Punjabi2022Bible (Punjabi 2022 (ਪੰਜਾਬੀ ਮੌਜੂਦਾ ਤਰਜਮਾ))
Punjabi2023Bible (Punjabi Standard Bible (Punjabi Standard Bible) 2023)
PunjabiBible (Punjabi ERV)
PunjabiERVBible (Punjabi 2002 ERV (ਪਵਿੱਤਰ ਬਾਈਬਲ))
PunjabiIRVBible (Punjabi RV (ਇੰਡਿਅਨ ਰਿਵਾਇਜ਼ਡ ਵਰਜ਼ਨ (IRV) - ਪੰਜਾਬੀ))

Q'eqchi'(케크치) 마야족은 주로 과테말라(Guatemala)와 벨리즈(Belize) 지역에 거주하는 원주민입니다
QeqchiBible (Qeqchi)    

케추아어(Quechua)와 케추아족은 주로 남아메리카 안데스 산맥 고원 지대에 위치하고 있습니다.
Quechuan2010Bible (Quechuan Bible 2011 (QUB))       
QuechuanBible (Quechuan - 1972)
QuechuanQVBMBible (Quechuan (Tayta Diospa Wilakuynin) 2003)
QuechuanQVSBible (Quechuan QVS 1992 (San Martín))
QuechuanQVWBible (Quechua (Huaylla Wanca))
QuechuanQXOBible (Quechuan QXO (Biblia en Quechua del sur de Conchucos))

로마니(Romani, 일명 집시)족은 인도 아대륙, 특히 북서부의 라자스탄 및 펀자브 지역에서 기원한 민족입니다
Romani2004Bible (Romani (E Nevi Viasta o Psalmo 2004 (Maximoff - Kalderaš)))    
Romani2007Bible (Romani Chile (Vlax Chileana) (Nuevo Testamento Romané 2007))
Romanian1928Bible (Romanian Cornilescu 1928)
Romanian1931Bible (Romanian 1931 (Traducere Literală Cornilescu 1931))
Romanian2009Bible (Romanian 2009 (Română Noul Testament Interconfesional 2009))
Romanian2014Bible (Romanian 2014 (Biblia în Versuri 2014))
Romanian2015Bible (Romanian 2015 (Biblia Traducerea Fidela 2015))
Romanian2018Bible (Romanian 2018 (Biblia în Versiune Actualizată 2018))
Romanian2020Bible (Romanian 2020 (Versiunea Biblia Romano Catolică 2020))
Romanian2021Bible (Romanian 2021 (Noua Traducere Românească))
Romanian2022Bible (Romanian (Ediția Dumitru Cornilescu revizuită 2022))
Romanian2023Bible (Romanian 2023 (Noul Testament SBR 2023))
RomanianBDKBible (Romanian BDK 1924 (Библия Думитру Корнилеску 1924))
RomanianBible (Romanian VDC 1924 (Biblia sau Sfânta Scriptură cu Trimiteri 1924, Dumitru Cornilescu))
RomanianSBIRBible (Romanian SBIR (Biblia Dumitru Cornilescu 2024))
RomaniBACHROBible (Romani Ursari 2018 (Biblia ande Chib Romani))
RomaniBaltic2019Bible (Romani Baltic (Библия - Пэ Балтитко Романи чиб (Романэс) 2019))
RomaniBalticLT2019Bible (Romani Baltic Latin (Biblija - Pe Baltitko Romani čib (Romanes) 2019))
RomaniBible (Romani 1984)
RomaniCHERGASHBible (Romani Chergash Ursari (Biblija pe Romani Čhib))
RomaniGSPBible (Romani Ursari (E Devleso Lafi ko Gurbetsko Dijalekt))
RomaniKALD2004Bible (Romani 2004 Kalderaš (E Nevi Viasta o Psalmo 2004 (Maximoff - Kalderaš)))
RomaniKALD2020Bible (Romani from Romanian (E Romaii Biblia 2020 (Kăldărărihko)))
RomaniRMCBible (Romani Slovakian RMC (Le Devleskero Lav Andre Romaňi Čhib Slovensko 2021))
RomaniROM07Bible (Romani Chilean (Nuevo Testamento Romané 2007))
RomaniROM6Bible (Romani German (ROM6) (O Debleskro Drom 2021))
RomaniSERBible (Romani Serbian (Romski prevod Novog zaveta - Srbija))
RomaniSINT2024Bible (Romani Sinte 2024 (O Debleskro Lab 2024 (Sinte-Manouche)))

러시아(Russian Federation)는 유라시아 대륙 북부에 위치한 세계에서 가장 영토가 넓은 나라로, 동유럽에서 북아시아에 걸쳐 있습니다.
Russian2012Bible (Russian 2012 - Радостная Весть - Современный Русский Перевод)     
RussianAGPBible (Russian Bible 2004 - Agape Bible - Nicholas Olizarevich)
RussianBTI2015Bible (Russian BTI 2015 - Библия под ред. М.П. Кулакова и М.М. Кулакова (BTI))
RussianCARSABible (Russian (CARSA) (Восточный перевод))
RussianCARSBible (Russian Восточный Перевод (CARS))
RussianCASBible (Russian CAS Bible 1970 - Новый Завет, перевод под ред. еп. Кассиана Безобразова)
RussianCSLAVBible (Russian CSLAV (Библия на Церковнославянском Языке))
RussianJewishBible (Russian Jewish Bible 1989 - Еврейский Новый Завет - Перевод с англ. A. Долбин, В. Долбина)
RussianJubileeBible (Russian Jubilee Bible 2010 - Библия. Юбилейное издание)
RussianMengeBible (Russian Bible Menge - Библия Менге info - Переведено с немецкого перевода Германа Менге - Hermann August Menge)
RussianNRTBible (Russian NRT (Новый Русский Перевод))
RussianReceptusBible (Russian 2014 - Новый Завет по тексту большинства - Textus Receptus)
RussianRSPBible (Russian (RSP) (Святая Библия Современный перевод))
RussianRSTBible (Russian RST Bible - 1900-1907 - Книги Священнаго Писанія Ветхаго и Новаго Завѣта въ русскомъ переводѣ съ параллельными мѣстами.)
RussianSlovoBible (Russian New Russian Translation (NRT) (IBS) (Slovo Zhizny) Новый Русский Перевод)
RussianSynodalBible (Russian Synodal 1876)
RussianWBTCBible (Russian Современный Перевод Библии WBTC 1993)

사드리(Sadri)는 인도 라자스탄(Rajasthan) 주 팔리(Pali) 지구에 위치한 자치시(Municipality)입니다
SadriBible (Sadri (सादरी नवाँ नियम))     

산스크리트어(Sanskrit)를 표기하는 가장 대표적인 문자 체계인 데바나가리(Devanagari)는 주로 인도와 네팔 전역에서 사용됩니다
SanskritDevanagariBible (Sanskrit Bible (NT) in Devanagari Script (सत्यवेद))      

산탈어(Santali)는 주로 인도 동부 지역에서 사용되는 오스트로아시아어족 문다어파에 속하는 언어입니다
SantaliBangladeshBible (Santali Bible (সান্তালী বাইবেল))      
SantaliCommonBible (Santali Bible (Common Language New Testament))

사삭(Sasak)족은 인도네시아 서누사텐가라주 롬복섬(Lombok Island)의 토착 원주민으로, 섬 인구의 90% 이상을 차지합니다.
SasakBible (Sasak (KITAB SUCI ZABUR INJIL))     

세나족은 모잠비크 북서부 지역, 소팔라 주 , 잠베지아 주 에 기원을 둔 반투족 언어 집단입니다
Sena2014Bible (Sena 2014 (Cibverano Cipsa))     
SenaBible (Sena (Cibverano Cipsa Cisena 2013))
SenaMalawiBible (Sena Malawi)

시라이키어는 파키스탄 에서 사용되는 인도아리아어족 언어입니다
SeraikiBible (Seraiki (کِتاب مُقدّس سرائیکی ترجمہ))    

세르비아(Serbia)는 동남유럽 중앙의 발칸반도에 위치한 내륙국입니다
SerbianBible (Serbian Cyrillic Version)     
SerbianCNZBible (Serbian CNZ (Нови српски превод Стари завет Проф. др Драган Милин и Нови завет Проф. др Емилијан Чарнић))
SerbianERVBible (Serbian (ERV) (Библија Савремени Српски Превод))
SerbianLatinBible (Serbian Latin Version  1865)
SerbianNSTBible (Serbian (NST) (Нови Српски Превод))
SerbianNSTLBible (Serbian (NSTL) 2017 (Novi Srpski Prevod))
SerbianSDSBible (Serbian Bible (SDS) 1934)

'Shan(샨)'은 주로 미얀마 동부에 위치한 샨 주(Shan State)를 의미합니다.
ShanBible (Shan (သမ်ႇမႃႇၵျၢမ်းလိၵ်ႈ ထႃႇဝရႃႉၽြႂး))     
ShanNCLBible (Shan NCL (သမ်ႇမႃႇၵျၢမ်းလိၵ်ႈ ထႃႇဝရႃႉၽြႃး))

셰카와티(Shekhawati)는 인도 라자스탄주 북동부에 위치한 지역으로, 시카르(Sikar), 주준주누(Jhunjhunu), 추루(Churu) 구를 포함하는 역사적인 명소입니다
ShekhawatiBible (Shekhawati (जीवन को च्यानणो (सेकावाटी नया नियम की पोथ्या)))   

\실룩족(Shilluk)은 남수단(South Sudan)의 북동부, 상나일주(Upper Nile State)에 위치한 백나일강(White Nile) 서쪽 은행을 따라 거주하는 나일로틱(Nilotic) 민족입니다
ShillukBible (Shilluk (WÄNYI KWËRØ 2011))   

쇼나(Shona)족과 그 언어는 주로 아프리카 남부 짐바브웨(Zimbabwe)를 중심으로 거주하고 있습니다
Shona1949Bible (Baiberi Magwaro Matȿene aMŋari 1949 (Doke))     
Shona2002Bible (Shona (Shona Bible 1949, revised 2002))
ShonaBDSCBible (Shona (Bhaibheri Dzvene MuChiShona Chanhasi))
ShonaBible (Shona 2009)
ShonaSCLBBible (Shona (Bhaibhiri Idzva rechiShona))
ShonaSUBBible (Shona SUB 2002 Bible)

시다모(Sidamo)는 에티오피아 남부에 위치한 세계적인 커피 생산 지역입니다
SidamoBible (Sidamo (Qullaawa Maxaafa))     

신드어(Sindhi)는 주로 파키스탄의 신드(Sindh) 주에서 사용되는 인도아리아어군의 언어입니다. 
SindhiBible (Sindhi Bible status=Sindhi Bible © Pakistan Bible Society, 1954,1962.)     
SindhiCommonBible (Sindhi Bible (Common Language New Testament))
SindhiHinduBible (Sindhi Bible (Hindu) (Hindu Sindhi New Testament © The Pakistan Bible Society, 2022) - پوِتر شاستر يسوع مسيح جي خوشخبري)
SindhiMuslimBible (Sindhi Bible (Muslim) (مقدس ڪلام توريت، زبور ۽ نبين جون ٻيو لکتون ۽ انجيل شريف))

싱할라어(Sinhala)는 스리랑카(Sri Lanka)의 공용어이자 국가 언어입니다
SinhalaNRSVBible (Sinhala Bile - New Revised Version (NRSV))    
SinhalaSCVBible (Sinhala (SCV) 2020 (සිංහල කාලීන පරිවර්තනය))
SinhalaSNRVBible (Sinhala SNRV (New Revised Version 2018))
SinhalaSROVBible (Sinhala Bile - Revised Old Version (SROV))

스와티어(SiSwati)는 주로 아프리카 남부에서 사용되는 언어입니다
SiswatiBible (Siswati 1996 Bible)       

슬로바키아(Slovakia)는 중앙유럽(중유럽)에 위치한 내륙국입니다
Slovakian2015Bible (Slovakian Bible - Botekov 2015)     
Slovakian2017Bible (Slovakian 2017 (Slovenský Ekumenický Preklad s DT Knihami))
SlovakianBible (Slovakian 1936 (ROH - Roháčkov Preklad))
SlovakianNPK2023Bible (Slovakian (NPK) (Nádej Pre Kazdého) 2023)
SlovakianNPKBible (Slovakian Bible (NPK) 1993 - (Nádej Pre Kazdého))
SlovakianRomaniBible (Slovakian Bible - Rómska Nová Zmluva 2014)
SlovakianSEBBible (Slovakian 2017 (Slovenský Ekumenický Preklad))
SlovakianSLBBible (Slovakian (Evanjelický preklad))
SlovakianSSVBible (Slovakian (Sväté Písmo - Katolícky Preklad))

슬로베니아(Slovenia)는 중앙유럽 남부에 위치한 나라입니다    
Slovenian1584Bible (Slovenian (Dalmatinova Biblija 1584))   
Slovenian1882Bible (Slovenian Josipa Stritarja (1882) SloStritar)
Slovenian1928Bible (Slovenian (Prekmurska NZ and Psalmi (1928)))
Slovenian1990Bible (Slovenian (JUB) 1990 (Jubilejni Prevod Nove Zaveze))
Slovenian2014Bible (Slovenian (ZNZ) 2014 (Živa Nova Zaveza))
SlovenianBible (Slovenian 2014 (Chráskov Prevod))
SlovenianEKUBible (Slovenian EKU (Ekumenska izdaja))
SlovenianSSPBible (Slovenian SSP (Slovenski Standardni Prevod))

Baibuli'는 아프리카 우간다의 주요 언어인 루간다어(Luganda)로 된 성경을 뜻합니다
SogaBible (Soga (Baibuli Ekibono kya Katonda 2014)) 

소말리아(Somalia)는 아프리카 동부, 일명 '아프리카의 뿔(Horn of Africa)'이라 불리는 지역의 최동단에 위치해 있습니다
Somalian2018Bible (Somalian 2018 (KITAABKA QUDUUSKA AH))        
Somalian2024Bible (Somalian 2024 (Ereyga Illaahey Axdiga Cusub))
SomalianBible (Somalian (Kitaabka Quduuska Ah))

SongeBible (Songe (NTETO INJEGA CIA MURUNGU KIRI ANTU BONTHE CATHOLIC EDITION))

소토(Sotho, 바소토족/Basotho)는 남부 아프리카의 내륙에 위치한 국가 레소토(Lesotho)와 남아프리카 공화국(남아공) 일대에 주로 거주하는 민족 및 그들의 언어(세소토어)를 의미합니다.
Sotho1951Bible (Sotho 1951 (BIBELE))        
Sotho1989Bible (Sotho Bible 1989 (BIBELE))
Sotho2000Bible (Sotho 2000 (BIBELE Taba yea Botse))
SothoBible (Sotho 2024 (Contemporary Sepedi Nothern Sotho Bible 2024))

스페인어
Spanish1569Bible (Spanish 1569)     
Spanish1858Bible (Spanish Reina Valera NT 1858)
Spanish1989Bible (Spanish 1989)
SpanishBDOBible (Spanish BDO 1973 (Biblia del Oso 1573))
SpanishBHTIBible (Spanish BHTI (Traducción Interconfesional, versión hispanoamericana))
SpanishBible (Spanish RVR 1909 (Más información sobre Biblia Reina Valera 1909))
SpanishBLPBible (Spanish BLP (La Palabra (versión española)))
SpanishBLPHBible (Spanish BLPH (La Palabra (versión hispanoamericana)))
SpanishBTIBible (Spanish BTI (La Biblia, Traducción Interconfesional (versión española)))
SpanishBTXBible (Spanish La Biblia Textual (BTX) Biblia Hebraica Stuttgartensia 1999)
SpanishDHHBible (Spanish DHH 1996)
SpanishJBSBible (Spanish JBS (Biblia del Jubileo))
SpanishLBLABible (Spanish Bible LBLB (La Biblia De Las Américas) 1997)
SpanishNBLABible (Spanish NBLA (Nueva Biblia de las Américas))
SpanishNBVBible (Spanish NBV (Nueva Biblia Viva))
SpanishNTBIZBible (Spanish NTBIZ (Segun el Texto Bizantino 2005))
SpanishNTVBible (Spanish NTV (Nueva Traducción Viviente))
SpanishNVIBible (Spanish NVI Bible - Nueva Versión Internacional)
SpanishNVISBible (Spanish NVIS (La Santa Biblia, Nueva Versión Internacional Simplificada))
SpanishPDTBible (Spanish PDT (La Biblia La Palabra de Dios para todos))
SpanishRevisedRVR1960Bible (Spanish Reina-Valera RVR 1960 (Revised Reina Valera 1960))
SpanishRV2020Bible (Spanish RV2020 (Reina Valera 2020))
SpanishRVA2015Bible (Spanish RVA2015 (Reina Valera Actualizada))
SpanishRVCBible (Spanish RVC (Reina Valera Contemporánea))
SpanishRVESBible (Spanish RVES (Reina-Valera Antigua))
SpanishRVGBible (Spanish Bible RVG - Reina Valera Gómez 2004)
SpanishRVR1960Bible (Spanish RVR 1960 (Más información sobre Biblia Reina Valera 1960))
SpanishRVR1995Bible (Spanish RVR 1995 (Biblia Reina Valera 1995))
SpanishTLABible (Spanish TLA (Traducción en Lenguaje Actual))
SpanishVBL2022Bible (Spanish VBL 2022 (Versión Biblia Libre))
SpanishVBLBible (Spanish Version Is Called = Free Bible Version)

Sukuma1960Bible (Sukuma (Ilagano Ipya Lya))
SukumaBible (Sukuma New Testament 2000)

순다족(Sundanese)과 순다어는 인도네시아 자바섬 서부 지역에 기반을 두고 있습니다.
SundaneseBible (Sundanese Bible (Sunda) - KITAB SUCI (LAISUN) 1991) 

스와힐리어(Swahili)는 주로 동아프리카 지역에서 널리 쓰이는 반투어군 언어입니다. 케냐, 탄자니아, 우간다, 르완다의 공식 언어
Swahili1850Bible (Swahili 1850 - Biblia Takatifu)   
Swahili2001Bible (Swahili (BHN) (Habari Njema) 2001)
Swahili2017Bible (Swahili (TKU) 2017 (Jipya Tafsiri ya Kusoma-Kwa-Urahisi))
Swahili2024Bible (Swahili (Neno Maandiko Matakatifu 2024))
SwahiliBHNTLKBible (Swahili BHNTLK (Biblia Habari Njema Toleo la Kujifunza))
SwahiliBible (Swahili (SRUV) (Swahili Revised Union Version))
SwahiliContemporaryBible (Swahili NEN (Neno Bibilia Takatifu 2025))
SwahiliNMMBible (Swahili NMM (Neno Maandiko Matakatifu) 2018)
SwahiliRSUVDCBible (Swahili RSUVDC (BIBLIA KISWAHILI))
SwahiliSCLDC10Bible (Swahili SCLDC10 (BIBLIA Yenye Vitabu vya Deuterokanoni HABARI NJEMA))
SwahiliSRB37Bible (Swahili SRB37 (Swahili Roehl Bible 1937))
SwahiliSUVBible (Swahili SUV (Maandiko Matakatifu ya Mungu Yaitwayo Biblia))
SwahiliSWC02Bible (Swahili SWC02 (BIBLIA ﻿Maandiko Matakatifu Kwa Watu Wote 2002))
SwahiliSWZZB1921Bible (Swahili SWZZB1921 (New Testament in Swahili (Zanzibar) Revised Edition 1921))

스웨덴(Sweden)은 북유럽 스칸디나비아 반도에 위치한 나라입니다
Swedish1873Bible (Swedish Karl XII 1873 (Karl XII 1873))    
Swedish2000Bible (Swedish (B2000) (Bibel 2000))
Swedish2015Bible (Swedish (NUB) (nuBibeln) 2015)
Swedish2019Bible (Swedish Bible (RFBNT) (Svenska Reformationsbibeln))
SwedishBible (Swedish (Svenska 1917))
SwedishFolkBible (Swedish Folk 1998 (Svenska Folkbibeln))
SwedishNLBBible (Swedish (New Living Bible) (NLB) 2004 (Nya Levande Bibeln))
SwedishSB2016Bible (Swedish (SB) 2016 (Svenskbibel))
SwedishSFBBible (Swedish (SFB) (Svenska Folkbibeln 2015))

실헤티(Sylheti)는 주로 방글라데시 동북부와 인도 동북부 지역에서 사용되는 인도-아리안 언어입니다
SylhetiBible (Sylheti (ছিলটি আছমানি কিতাব (বাংলা লিপি)))   
SylhetiSYLLBible (Sylheti SYLL (Siloṭi Asmani Kitab (Latin lipi)))

타갈로그어(Tagalog)는 필리핀의 공식 언어인 필리피노어의 기반이 되는 언어로, 주로 필리핀 루손 섬 중남부 지역(마닐라 포함)에서 사용됩니다
Tagalog2001Bible (Tagalog (Ang Biblia 2001))    
Tagalog2005Bible (Tagalog 2005 (Magandang Balita Biblia (2005)))
Tagalog2012Bible (Tagalog 2012 (Magandang Balita Biblia))
Tagalog2015Bible (Tagalog (Ang Salita ng Dios))
TagalogBible (Tagalog (TLAB) 1905 (Ang Biblia (1905, 1982)))
TagalogRevised2005Bible (Tagalog 2005 Revised (Magandang Balita Bible (Revised)))
TagalogTLBABible (Tagalog TLBA (Ang Biblia))

타지키스탄(Tajikistan)은 중앙아시아에 위치한 내륙국입니다
Tajik1992Bible (Tajik (Китоби Муқаддас 1992, 1999)) 
TajikKMOBible (Tajik (KMO) (Китоби Муқаддас Оммафаҳм))
TajikNTBible (Tajik NT 1999)

타마셰크어(Tamasheq)는 주로 사하라 사막 중심부와 그 주변 지역인 북아프리카와 서아프리카 일대에서 투아레그(Tuareg)족이 사용하는 언어입니다
TamasheqBible (Tamasheq 2003)   

타밀(Tamil)은 주로 인도 남부의 타밀나두(Tamil Nadu) 주와 스리랑카 북동부 지역에 위치합니다
Tamil2017Bible (Tamil Bible - பரிசுத்த வேதாகமம் O.V.) 
TamilBible (Tamil (BSI) (பரிசுத்த வேதாகமம் O.V. (BSI)))
TamilIRVBible (Tamil (IRV) (இண்டியன் ரிவைஸ்டு வெர்ஸன் (IRV) - தமிழ்))
TamilRomanisedBible (Tamil Bible Romanised 2017)
TamilTCVBible (Tamil (TCV) (இந்திய சமகால தமிழ் மொழிப்பெயர்ப்பு 2022))
TamilTRVBible (Tamil (TRV) (இலங்கை இலகு தமிழ் மொழிபெயர்ப்பு))
TamilWBTCBible (Tamil WBTC (ERV) (பரிசுத்த பைபிள்))

TarifitBible (Tarifit (Ṯarifiṯ 2020))

TashelhaytMoroccoBible (Tashelhayt Morocco 1998 (Tashelhayt Arabic Script Morocco) (اغاراس ن-تودرت - ءينجيل لّماسيح - لعهد لّجديد لّي-يسكر ربّي غ-گراس د-بنادم))

타타르족(Tatars)은 주로 러시아 내의 타타르스탄 공화국(Tatarstan Republic)과 그 주변의 볼가-우랄 지역에 거주하는 튀르크 계통의 민족입니다
Tatar2001Bible (Tatar 2001 Bible - Инҗил status=Институт перевода Библии 2001)  
Tatar2015Bible (Tatar Crimean 2016 Bible - Къырымтатарджа [Crimean Tatar] (Мукъаддес Китап))
Tatar2025Bible (Tatar 2025 (Инҗил))
TatarRBBLBible (Tatar (Изге Язма))

텔루구어(Telugu)는 주로 인도 남동부의 안드라프라데시(Andhra Pradesh) 주와 텔랑가나(Telangana) 주에서 사용하는 주요 언어이자 공용어입니다.
Telugu2016Bible (Telugu Bible (TELOV) (పరిశుద్ధ గ్రంథము O.V. Bible (BSI)))    
Telugu2019Bible (Telugu Bible 2019 (ఇండియన్ రివైజ్డ్ వెర్షన్ (IRV) - తెలుగు -2019))
TeluguBible (Telugu (BSI) 1880)
TeluguTCVBible (Telugu TCV (తెలుగు సమకాలీన అనువాదం, పవిత్ర గ్రంథం))
TeluguWBTCBible (Telugu 1997 TERV (పవిత్ర బైబిల్))

Teso2020Bible (Teso 2020 (AKITUTUKET NAKITETET (NEPEPEKA ISABULIN KA AWARAGASIA)))
TesoBible (Teso (Ebaibuli))

ThadoBible (Thado (Pathen Thutheng BU (BSI)) 2015)

태국어에서 '어디'는 '티나이' (ที่ไหน, tee nai)라고 하며, 구어체에서는 줄여서 '나이' (ไหน, nai)라고 주로 표현합니다. 
Thai1940Bible (Thai 1940 (พระคริสตธรรมคัมภีร์ ฉบับ 1940))    
Thai1971Bible (Thai Bible 1971 (พระคัมภีร์ไทย ฉบับ 1971))
ThaiBible (Thia KJV (พระคัมภีร์ภาษาไทยฉบับ KJV))
ThaiERVBible (Thai Bible (ERV) 2001 (พระคริสตธรรมคัมภีร์ ฉบับอ่านเข้าใจง่าย))
ThaiKJVBible (Thai KJV 2003)
ThaiNTVBible (Thai NTV (พระคัมภีร์ ฉบับแปลใหม่ (NTV)))
ThaiTCVBible (Thai TCV 2025 (คัมภีร์ ฉบับไทยสามัญ))
ThaiTHSBible (Thai Bible (THS) 2011 (ฉบับมาตรฐาน))
ThaiTNCVBible (Thai Bible (TNCV) 2007 - New Contemporary Version (พระคริสตธรรมคัมภีร์ไทย ฉบับอมตธรรมร่วมสมัย))

티베트(Tibet)는 중앙아시아, 중국 서남부에 위치한 티베트고원 지역입니다
TibetianBible (Tibetian NTB (བོད་འགྱུར་གསར་མ།))    
TibetianCBTBible (Tibetian CTB (གསུང་རབ།))

TivBible (Tiv (ICIGHAN BIBILO))

Tshiluba(칠루바어)는 주로 콩고 민주 공화국(DR 콩고, Democratic Republic of the Congo)에서 사용되는 언어입니다. 
Tshiluba1996Bible (Tshiluba Bible 1996 (MUKANDA WA MYIDI MUKULU))   
Tshiluba2003Bible (Tshiluba Bible (Mukanda wa Nzambi Dihungila Dikulukulu ne Dihungila Dihia-dihia 2003))

치벤다어(Tshivenda)는 주로 남아프리카 공화국 북부에서 사용되는 언어입니다
TshivendaBible (Tshivenda (BIVHILI KHETHWA Mafhungo Madifha))   

쏭가족(Tsonga people)은 주로 남아프리카 지역에 거주하는 반투족 계열의 민족입니다.
Tsonga1989Bible (Tsonga (BIBELE Mahungu Lamanene) 1989) 
Tsonga2014Bible (Tsonga (Testamente Leyimpsha Xichangana))
Tsonga2024Bible (Tsonga (Contemporary Tsonga Bible 2024))
TsongaBible (Tsonga Xitsonga (Bibele) 1929)

츠와나족(Tswana people)은 남아프리카 지역에 주로 거주하는 반투어계 민족
Tswana1890Bible (Tswana 1890 (Bibela ea Boitsépho 1890 (Sechuana Tlhaping - Moffatt Bible)))    
Tswana1970Bible (Tswana Setswana 1970)
Tswana1993Bible (Tswana 1993 (Lefoko La Botshelo Kgolagano e Ntsha))
Tswana2024Bible (Tswana 2024 (Contemporary Tswana Bible 2024))
TswanaBible (Tswana (BAEBELE e e Boitshepo) 1992)

툴루(Tulu)어는 주로 인도 남서부 해안 지역에서 사용되는 드라비다어족 언어입니다
TuluBible (Tulu (ಪೊಸ ಒಡಂಬಡಿಕೆ)) 

투르카나(Turkana)는 케냐 북서부에 위치한 지역(카운티)입니다
TurkanaBible (Turkana (ABIBILIA NGAKIRO NAAJOKAK))  

튀르키예(Turkey, 옛 터키)는 지리적으로 아시아와 유럽의 교차로에 위치해 있습니다
TurkishBible (Turkish (Yaşam Yayınları))    
TurkishHADIBible (Turkish (Halk Dilinde İncil) 2013)
TurkishKKDEUBible (Turkish KKDEU (Kutsal Kitap ve Deuterokanonik Kitaplar))
TurkishKMEYABible (Turkish KMEYA (Old Translation 1941))
TurkishNTBBible (Turkish (TCL02) NTB (New Turkish Bible) 2009 Version)
TurkishTKKBible (Turkish TKK (Кирил харфлерийле Тюркче Кутсал Китап))
TurkishTTTBible (Turkish (TTT) (Türkçe Tercüme))
TurkishYTCBible (Turkish Yorumsuz Türkçe Çeviri (YTC))

투르크메니스탄(Turkmenistan)은 중앙아시아 남서부에 위치한 나라입니다
Turkmen2016Bible (Turkmen 2016 (Мукаддес Китап))    
TurkmenCyrillic2002Bible (Turkmen 2002 Инжил)
TurkmenLatin2002Bible (Turkmen Latin 2002)
TurkmenLatin2017Bible (Turkmen 2016 Latin (Mukaddes Kitap))

TwiAkuapemBible (Twi Bible 2020 (Akuapem Twi Nkwa Asɛm))
TwiAsanteBible (Twi Bible (Asante Twi Nkwa Asɛm))
TwiDCBible (Twi Bible 2017 (DC KYERƐW KRONKRON))
TwiKronkronBible (Twi Bible (Twerɛ Kronkron))
TwiRevisedBible (Twi Bible 2012 (New Revised Asante Twi Bible))
    
우크라이나(Ukraine)는 동유럽에 위치한 국가
Ukrainian1903Bible (Ukrainian 1871 (Куліша та Пулюя))   
Ukrainian1905Bible (Ukrainian 1905 (Біблія в пер. П.Куліша та І.Пулюя, 1905))
Ukrainian2004Bible (Ukrainian Bible 2004 (Патріарха Філарета))
Ukrainian2006Bible (Ukrainian Bible 2006 (Oleksandr Gizha))
Ukrainian2011Bible (UKrainian 2011 (Переклад Р. Турконяка))
Ukrainian2021Bible (Ukrainian 2021 (Переклад. Ю. Попченка.))
Ukrainian2022Bible (Ukrainian 2022 (Новий Переклад Українською))
UkrainianBible Ukrainian 1962 (Біблія в пер. Івана Огієнка 1962)
UkrainianHOMBible (Ukrainian (Івана Хоменка) 1963)
UkrainianTUBBible (Ukrainian 1997 (TUB) - (Турконяка))
UkrainianUKDERBible (Ukrainian Bible (UKDER) 1992 - Велике Відкриття. Новий Завіт з додатком Псалмів і Притч)
UkrainianUMTBible (Ukrainian UMT (Свята Біблія Сучасною Мовою) 2007)

움분두어(Umbundu)는 주로 앙골라(Angola) 서부와 중부 지역에서 사용되는 반투어군 언어입니다. 
UmbunduBible (Umbundu Bible (Embimbiliya - Bíblia Sagrada em Umbundu))  

우르두어(Urdu)는 주로 파키스탄의 공용어
Urdu2017Bible (Urdu 2017 BCS)   
UrduBible (Urdu ERV 2007)
UrduDGVBible (Urdu DGV (किताब-ए मुक़द्दस))
UrduGVRBible (Urdu GVR (Kitab-i Muqaddas))
UrduIRVURDBible (Urdu IRV (इंडियन रिवाइज्ड वर्जन (IRV) उर्दू - 2019))
UrduUCVBible (Urdu UCV - (اُردو ہم عصر ترجُمہ))
UrduUCVDBible (Urdu UCVD (उर्दू हमअस्र तरजुमा))
UrduUGVBible (Urdu Bible (UGV) 2019 (ہولی بائبل کا اردو جیو ورژن))
UrduURDBible (Urdu URD (کِتابِ مُقادّس))
UrduURDGVHBible (Urdu URDGVH (किताबे-मुक़द्दस))
UrduURDR55Bible (Urdu URDR55 (Kitáb i Muqaddas 1955 (Tauret, Zabúr, Ambiyá ke Sahífa, aur Injíl)))

위구르는 주로 중국 서북부의 신장 위구르 자치구 (Xinjiang Uyghur Autonomous Region)에 거주하고 있습니다.
UyghurArabicBible (Uyghur Arabic 2005 (ھازىرقى زامان ئۇيغۇرچە تەرجىمىسى))   
UyghurCyrillicBible (Uyghur Cyrillic 2005 (Һазирқи Заман Уйғурчә Тәрҗимиси))
UyghurLatinBible (Uyghur Latin Bible - (Muqeddes Kalam) 2010)

우즈베키스탄(Uzbekistan)은 중앙아시아에 위치한 내륙국
UzbekUZBBible (Uzbek 2016 (UZB) (Муқаддас Китоб))   
UzbekUZCBible (Uzbek Bible (UZC) 2008 Tavrot in Uzbek)
UzbekUZLBCBible (Uzbek Latin 2016 (UZLBC) (Muqaddas Kitob))

베트남어
Vietnamese1994Bible (Vietnamese 1994 (Lời Chúa Cho Mọi Người))  
Vietnamese2011Bible (Vietnamese (Kinh Thánh Tiếng Việt, Bản Dịch 2011))
Vietnamese2015Bible (Vietnamese Contemporary 2015 (Kinh Thánh Hiện Đại))
VietnameseBible (Vietnamese (Kinh Thánh Tiếng Việt 1925))
VietnameseERVBible (Vietnamese ERV (Thánh Kinh Bản Phổ thông))
VietnameseNVBBible (Vietnamese 2002 (NVB) (Kinh Thánh Bản Dịch Mới))
VietnameseVIEBible (Vietnamese 2010 (VIE) (Kinh Thánh Tiếng Việt Bản Hiệu Đính 2010))

WarayBible (Waray (Samarenyo Meaning-Based Bible (1984)))

웨일스(Wales)는 영국(UK)을 구성하는 4개국 중 하나
Welsh1894Bible (Welsh 1894 (Cyfieithiad Briscoe 1853-94 (Test. Newydd a rhannau o'r Hen Dest.)))    
Welsh1945Bible (Welsh 1945 (Cyfieithiad Urdd y Graddedigion 1921-45 (T.N., Hosea ac Amos)))
Welsh2015Bible (Welsh 2023 (BNET) (beibl.net 2015, 2024))
WelshBible (Welsh BCND (Beibl Cymraeg Newydd Diwygiedig 2004))
WelshBMWBible (Welsh 1955 (Beibl William Morgan - Argraffiad 1955))
WelshCTEBible (Welsh CTE 1894 (Testament Newydd gyda Nodiadau 1894-1915 (William Edwards)))
WelshSBYBible (Welsh 1567 (Testament Newydd a'r Salmau 1567 (William Salesbury)))

월라이타(Wolaytta, Welayta)는 에티오피아 남부에 위치한 지역이자 그곳에 사는 민족(월라이타족)을 뜻합니다.
WolayttaBible (Wolaytta 2002 (WOB))  

월로프어(Wolof)는 주로 서아프리카의 세네감비아(Senegambia) 지역에서 사용되는 언어입니다.
WolofBible (Wolof 1987) 
WolofKYGBible (Wolof KYG (Kàddug Yàlla gi))

코사족(Xhosa)은 남아프리카공화국(South Africa)에 주로 거주하는 원주민입니다. 
Xhosa1920Bible (Xhosa 1902 (Incwadi Yeziba̔lo Ezingcwele 1864, 1902 (Xhosa Appleyard)))  
Xhosa1996Bible (Xhosa XHO96 (IBHAYIBHILE))
Xhosa2022Bible (Xhosa 2024 (ITestamente Entsha))
XhosaBible (Xhosa 1975 (IZIBHALO EZINGCWELE))

요루바족(Yoruba)은 주로 서아프리카 지역에 거주하는 민족입니다
Yoruba2010Bible (Yoruba 2010)   
Yoruba2014Bible (Yoruba YCB (Bíbélì Mímọ́ ní Èdè Yorùbá Òde-Òní))
YorubaBible (Yoruba YBCV (Bibeli Mimọ))

잔데족(Azande)은 주로 아프리카 중북부 지역에 거주하는 민족입니다
ZandeBible (Zande (Ziazia kekeapai))    
ZarmaBible (Zarma)

줄루족(Zulu)은 주로 남아프리카 공화국(South Africa)에 위치하고 있습니다. 
Zulu2020Bible (Zulu 2020 (IsiZulu 2020))    
Zulu2023Bible (Zulu 2023 (Baasraak Zulu New Testament Bible))
ZuluBible (Zulu 1959 (IBHAYIBHELI ELINGCWELE))


 */

/**
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
 */


/**
Chinese	    12
Afrikaans	1
Albanian	1
Czech	    1
Vietnamese	1
Finnish	    1
Indonesian	1
Polish	    1
Tagalog	    1
Thai	    1
Portuguese	2
Japanese	3
German	    4
Romanian	5
French	    6
Spanish	    7
Italian	    8
Hindi	    10
Hungarian	9
Russian	    11
Korean	    13
English	    1

 */

/**
Word Of God(Afrikaans 1953) - Afrikaans
Word Of God(Albanian) - Albanian
Word Of God(Bible Kralicka) - Czech
Word Of God(Chinese Union (Simplified)) - Chinese
Word Of God(Chinese Union (Traditional)) - Chinese
Word Of God(Chinese KJV (Simplified)) - Chinese
Word Of God(Chinese KJV (Traditional)) - Chinese
Word Of God(Finnish 1776 (Finnish)) - Finnish
Word Of God(La Bible de l'Épée (2005)) - French
Word Of God(Ostervald (1996)) - French
Word Of God(Louis Segond 1910) - French
Word Of God(Elberfelder (1905)) - German
Word Of God(Luther Bible (1912)) - German
Word Of God(Schlachter Bibel (1951)) - German
Word Of God(Indian Revised Version (2017 / 2018)) - Hindi
Word Of God(Karoli) - Hungarian
Word Of God(Terjemahan Baru (1994)) - Indonesian
Word Of God(Terjemahan Lama) - Indonesian
Word Of God(Diodati (1649)) - Italian
Word Of God(Bungo-yaku: Taisho-kaiyaku (NT) (1950)) - Japanese
Word Of God(Kougo-yaku (1954/1955)) - Japanese
Word Of God(NOWEJ BIBLII GDANSKIEJ (2012)) - Polish
Word Of God(Uwspółcześniona Biblia Gdańska (2017)) - Polish
Word Of God(Polska Biblia Gdanska (1881)) - Polish
Word Of God(Tradução de João Ferreira de Almeida) - Portuguese
Word Of God(Tradução de João Ferreira de Almeida Revista e Corrigid) - Portuguese
Word Of God(Biblia Livre) - Portuguese
Word Of God(Fidela Biblia în limba română (2011-2016)) - Romanian
Word Of God(Synodal (1876)) - Russian
Word Of God(Reina Valera 1909) - Spanish
Word Of God(Valera Gómez (2010)) - Spanish
Word Of God(Reina Valera Gómez (2004)) - Spanish
Word Of God(Sagradas Escrituras (1569)) - Spanish
Word Of God(Tagalog Ang Biblia (1905)) - Tagalog
Word Of God(Thai KJV) - Thai
Word Of God(Vietnamese Cadman (1934)) - Vietnamese
 */

/**
TogglesGameObjectKorean;
TogglesGameObjectChinese;
TogglesGameObjectAfrikaans;
TogglesGameObjectAlbanian;
TogglesGameObjectCzech;
TogglesGameObjectVietnamese;
TogglesGameObjectFinnish;
TogglesGameObjectIndonesian;
TogglesGameObjectPolish;
TogglesGameObjectTagalog;
TogglesGameObjectThai;
TogglesGameObjectPortuguese;
TogglesGameObjectJapanese;
TogglesGameObjectGerman;
TogglesGameObjectRomanian;
TogglesGameObjectFrench;
TogglesGameObjectSpanish;
TogglesGameObjectItalian;
TogglesGameObjectHindi;
TogglesGameObjectHungarian;
TogglesGameObjectRussian;
 */

/**
 void CheckChineseBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesChinese.Count; i++) TogglesChinese[i].value = false;
        TogglesChinese[(int)Type].value = true;
    }

    void CheckAfrikaansBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesAfrikaans.Count; i++) TogglesAfrikaans[i].value = false;
        TogglesAfrikaans[(int)Type].value = true;
    }

    void CheckAlbanianBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesAlbanian.Count; i++) TogglesAlbanian[i].value = false;
        TogglesAlbanian[(int)Type].value = true;
    }

    void CheckCzechBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesCzech.Count; i++) TogglesCzech[i].value = false;
        TogglesCzech[(int)Type].value = true;
    }

    void CheckVietnameseBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesVietnamese.Count; i++) TogglesVietnamese[i].value = false;

        TogglesVietnamese[(int)Type].value = true;
    }

    void CheckFinnishBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesFinnish.Count; i++) TogglesFinnish[i].value = false;

        TogglesFinnish[(int)Type].value = true;
    }

    void CheckIndonesianBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesIndonesian.Count; i++) TogglesIndonesian[i].value = false;

        TogglesIndonesian[(int)Type].value = true;
    }

    void CheckPolishBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesPolish.Count; i++) TogglesPolish[i].value = false;

        TogglesPolish[(int)Type].value = true;
    }

    void CheckTagalogBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesTagalog.Count; i++) TogglesTagalog[i].value = false;

        TogglesTagalog[(int)Type].value = true;
    }

    void CheckThaiBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesThai.Count; i++) TogglesThai[i].value = false;

        TogglesThai[(int)Type].value = true;
    }

    void CheckPortugueseBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesPortuguese.Count; i++) TogglesPortuguese[i].value = false;

        TogglesPortuguese[(int)Type].value = true;
    }

    void CheckJapaneseBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesJapanese.Count; i++) TogglesJapanese[i].value = false;

        TogglesJapanese[(int)Type].value = true;
    }

    void CheckGermanBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesGerman.Count; i++) TogglesGerman[i].value = false;

        TogglesGerman[(int)Type].value = true;
    }

    void CheckRomanianBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesRomanian.Count; i++) TogglesRomanian[i].value = false;

        TogglesRomanian[(int)Type].value = true;
    }

    void CheckFrenchBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesFrench.Count; i++) TogglesFrench[i].value = false;

        TogglesFrench[(int)Type].value = true;
    }

    void CheckSpanishBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesSpanish.Count; i++) TogglesSpanish[i].value = false;

        TogglesSpanish[(int)Type].value = true;
    }

    void CheckItalianBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesItalian.Count; i++) TogglesItalian[i].value = false;

        TogglesItalian[(int)Type].value = true;
    }

    void CheckHindiBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesHindi.Count; i++) TogglesHindi[i].value = false;

        TogglesHindi[(int)Type].value = true;
    }

    void CheckHungarianBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesHungarian.Count; i++) TogglesHungarian[i].value = false;

        TogglesHungarian[(int)Type].value = true;
    }

    void CheckRussianBible(EKoreanBibleType Type)
    {
        for (int i = 0; i < TogglesRussian.Count; i++) TogglesRussian[i].value = false;

        TogglesRussian[(int)Type].value = true;
    }
 */

/**
 public enum ENationType
{
    None = -1,
    Chinese,
    Afrikaans,
    Albanian,
    Czech,
    Vietnamese,
    Finnish,
    Indonesian,
    Polish,
    Tagalog,
    Thai,
    Portuguese,
    Japanese,
    German,
    Romanian,
    French,
    Spanish,
    Italian,
    Hindi,
    Hungarian,
    Russian,
    Korean,
    English,
    Max,
}
 */

/**
 
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
    synoda,
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
 */


/**
 chinese_union_simp	Chinese Union (Simplified)
chinese_union_trad	Chinese Union (Traditional)
ckjv_sds	中文英皇钦定本上帝版 Chinese KJV (Simplified)
ckjv_sdt	中文英皇欽定本上帝版 Chinese KJV (Traditional)
afri	Afrikaans 1953                                   
albanian	Albanian                                                    
bkr	Bible Kralicka                                              
cadman	Vietnamese Cadman (1934)                                    
finn	Finnish 1776 (Finnish) (1776)                               
indo_tb	Terjemahan Baru (1994)                                      
indo_tm	Terjemahan Lama                                             
pol_nbg	NOWEJ BIBLII GDANSKIEJ (2012)                               
pol_ubg	Uwspółcześniona Biblia Gdańska (2017)                      
polbg	Polska Biblia Gdanska (1881)                                
tagab	Tagalog Ang Biblia (1905)                                   
thaikjv	Thai KJV                                                    
almeida_ra	Tradução de João Ferreira de Almeida                        
almeida_rc	Tradução de João Ferreira de Almeida Revista e Corrigida    
blivre	Biblia Livre                                                
bungo	Bungo-yaku: Taisho-kaiyaku (NT) (1950)                      
kougo	Kougo-yaku (1954/1955)                                      
elberfelder_1905	Elberfelder (1905)                                          
luther_1912	Luther Bible (1912)                                
schlachter	Schlachter Bibel (1951)                                     
fidela	Fidela Biblia în limba română (2011-2016)                   
epee	La Bible de l'Épée (2005)                                   
oster	Ostervald (1996)                                            
segond_1910	Louis Segond 1910                                
rv_1909	Reina Valera 1909                            
rvg	Reina Valera Gómez (2010)                                   
rvg_2004	Reina Valera Gómez (2004)
sagradas	Sagradas Escrituras (1569)                                  
diodati	Diodati (1649)                                              
irv	Indian Revised Version (2017 / 2018)                        
karoli	Karoli                                                      
synodal	Synodal (1876)                                              
EasyBible	쉬운성경
KoreanBible	우리말성경                                               
NewStandardTranslation	표준새번역                                              
RevisedRevision	개역개정                                                    
NIV	New International Version
ESV	English Standard Version
NewRSV	New Revised Standard Version
KJV	King James Version
NewKJV	New King James Version

 */

/**



 */

/**
string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\AAA", "*.txt", SearchOption.AllDirectories); // c:\Bible\AAA 폴더에 있는 모든 텍스트 파일들을 읽어 옵니다. 
 string textValue = System.IO.File.ReadAllText(CollectAllFiles[k]); // 텍스트 문서를 읽어서 모든 문장을 배열에 저장
 List<string> collectKorean = new List<string>(textValue.Split('\n'));  // 읽어온 문자열을 '\n' 기준으로 분리해서 리스트 컬렉션에 저장합니다. 

TextAsset[] RevisedRevision = Resources.LoadAll<TextAsset>("Append/");
for (int k = 0; k < RevisedRevision.Length; k++)
{
    TextAsset textFile; // 한글 성경 TextAsset을 저장할 변수입니다. 
    List<string> result = new List<string>();
    textFile = RevisedRevision[k]; // Resources폴더에서 성경이름을 가져와서 한글 성경 TextAsset에 저장합니다. 
    result.Clear();
    StringReader stringReader = new StringReader(textFile.text); // textFile의 내용을 stringReader에 저장합니다. 
    while (stringReader.Peek() >= 0) // stringReader에 저장되어 있는 문자열이 끝이 아닐 때까지 반복합니다. 
    {
        string temp = stringReader.ReadLine(); // stringReader에서 라인을 읽어 옵니다. 
        result.Add(temp + " ");
    }
    stringReader.Close();
} 
 */

/// </summary>

public class InsaneUIHelper : EditorWindow
{
    [MenuItem("Tools/InsaneUIHelper")]

    

    public static void Init()
    {
        EditorWindow window = (InsaneUIHelper)EditorWindow.GetWindow(typeof(InsaneUIHelper));
    }
    /// <summary>
    /// Youtube 자막에서 특정 단어 찾기
    /// </summary>
    /// <param name="searchWorld"></param>
    public static void YoutubeSearch(string searchWorld)
    {
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
                    // string tempWord = CollectAllFiles[i].Replace("txt", "");
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
    /// Youtube 자막 정리
    /// </summary>
    public static void YoutubeSubtitlesSummary()
    {
        string[] RevisedRevision = Directory.GetFiles(@"c:\Bible\Info\AppendA\", "*.txt", SearchOption.AllDirectories); // c:\Bible\AAA 폴더에 있는 모든 텍스트 파일들을 읽어 옵니다. 

        for (int k = 0; k < RevisedRevision.Length; k++)
        {
            List<string> resultFirst = new List<string>();
            List<string> resultSecond = new List<string>();
            List<string> resultThird = new List<string>();

            List<string> tempCollection = new List<string>();

            string textValue = System.IO.File.ReadAllText(RevisedRevision[k]);
            resultFirst = new List<string>(textValue.Split('\n'));

            for (int x = 0; x < resultFirst.Count; x = x + 2) resultSecond.Add(resultFirst[x]);

            //for (int x = 0; x < resultFirst.Count - 1; x++)
            //{
            //    resultSecond.Add(resultFirst[x].TrimEnd());
            //}

            for (int x = 0; x < resultSecond.Count; x = x + 4)
            {
                string temptempLast = string.Empty;
                try { temptempLast = string.Format("{0} {1} {2} {3} ", resultSecond[x].TrimEnd(), (resultSecond[x + 1]).TrimEnd(), (resultSecond[x + 2]).TrimEnd(), (resultSecond[x + 3]).TrimEnd()); } catch (Exception e) { }
                // try { temptempLast += resultSecond[x]; } catch (Exception e) { }
                // try { temptempLast += resultSecond[x + 1]; } catch (Exception e) { }
                // try { temptempLast += resultSecond[x + 2]; } catch (Exception e) { }
                // try { temptempLast += resultSecond[x + 3]; } catch (Exception e) { }
                resultThird.Add(temptempLast);
            }

            string path = @"c:\Bible\Info\AppendResult\"; // 저장될 경로입니다. 
            DirectoryInfo di = new DirectoryInfo(path);

            if (di.Exists == false) di.Create(); // 만약 폴더가 존재하지 않으면

            StreamWriter streamWriter = new StreamWriter(path + Path.GetFileNameWithoutExtension(RevisedRevision[k]) + ".txt", true); // 파일을 저장할 준비를 합니다. 

            for (int i = 0; i < resultThird.Count; i++) streamWriter.WriteLine(resultThird[i]); // 결과 리스트를 파일에 저장합니다. 

            streamWriter.Close();
        }





        //TextAsset[] RevisedRevision = Resources.LoadAll<TextAsset>("AppendA/");

        //for (int k = 0; k < RevisedRevision.Length; k++)
        //{
        //    TextAsset textFile; // 한글 성경 TextAsset을 저장할 변수입니다. 
        //    List<string> result = new List<string>();
        //    textFile = RevisedRevision[k]; // Resources폴더에서 성경이름을 가져와서 한글 성경 TextAsset에 저장합니다. 
        //    result.Clear();

        //    StringReader stringReader = new StringReader(textFile.text); // textFile의 내용을 stringReader에 저장합니다. 

        //    while (stringReader.Peek() >= 0) // stringReader에 저장되어 있는 문자열이 끝이 아닐 때까지 반복합니다. 
        //    {
        //        string temp = stringReader.ReadLine(); // stringReader에서 라인을 읽어 옵니다. 
        //        result.Add(temp + " ");
        //    }
        //    stringReader.Close();

        //    List<string> resultK = new List<string>();
        //    List<string> resultA = new List<string>();

        //    for (int x = 0; x < result.Count; x = x + 2) resultA.Add(result[x]);

        //    for (int x = 0; x < resultA.Count; x = x + 4)
        //    {
        //        string temptemp = string.Empty;
        //        try { temptemp += resultA[x]; } catch (Exception e) { }
        //        try { temptemp += resultA[x + 1]; } catch (Exception e) { }
        //        try { temptemp += resultA[x + 2]; } catch (Exception e) { }
        //        try { temptemp += resultA[x + 3]; } catch (Exception e) { }
        //        resultK.Add(temptemp);
        //    }

        //    string path = @"d:\Bible\Info\AppendResult\"; // 저장될 경로입니다. 
        //    DirectoryInfo di = new DirectoryInfo(path);

        //    if (di.Exists == false) di.Create(); // 만약 폴더가 존재하지 않으면

        //    StreamWriter streamWriter = new StreamWriter(path + RevisedRevision[k].name + ".txt", true); // 파일을 저장할 준비를 합니다. 

        //    for (int i = 0; i < resultK.Count; i++) streamWriter.WriteLine(resultK[i]); // 결과 리스트를 파일에 저장합니다. 

        //    streamWriter.Close();
        //}

    }
    /// <summary>
    /// 성경별로 각각의 챕터들의 절들이 몇 절들인가를 확인
    /// </summary>
    public static void CheckChapters()
    {
        string OutputPath = @"c:\Bible\Info\";
        DirectoryInfo di = new DirectoryInfo(OutputPath);

        if (di.Exists == false) di.Create(); // 만약 폴더가 존재하지 않으면

        string[] Koreankeywords = { "창", "출", "레", "민", "신", "수", "삿", "룻", "삼상", "삼하", "왕상", "왕하", "대상", "대하", "스", "느", "에", "욥", "시", "잠", "전", "아", "사", "렘", "애", "겔", "단", "호", "욜", "암", "옵", "욘", "미", "나", "합", "습", "학", "슥", "말", "마", "막", "눅", "요", "행", "롬", "고전", "고후", "갈", "엡", "빌", "골", "살전", "살후", "딤전", "딤후", "딛", "몬", "히", "약", "벧전", "벧후", "요일", "요이", "요삼", "유", "계" };
        string[] keywords = { "Gen", "Ex", "Lev", "Num", "Deut", "Josh", "Judg", "Ruth", "1Sam", "2Sam", "1Kin", "2Kin", "1Chr", "2Chr", "Ezra", "Neh", "Esther", "Job", "Ps", "Prov", "Eccles", "Song", "Is", "Jer", "Lam", "Ezek", "Dan", "Hos", "Joel", "Amos", "Obad", "Jonah", "Mic", "Nah", "Hab", "Zeph", "Hag", "Zech", "Mal", "Matt", "Mark", "Luke", "John", "Acts", "Rom", "1Cor", "2Cor", "Gal", "Eph", "Phil", "Col", "1Thess", "2Thess", "1Tim", "2Tim", "Titus", "Philem", "Heb", "James", "1Pet", "2Pet", "1John", "2John", "3John", "Jude", "Rev" };
        int[] chapterCount = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4, 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };

        Debug.Log("Koreankeywords.Length : " + Koreankeywords.Length);
        Debug.Log("keywords.Length : " + keywords.Length);
        Debug.Log("chapterCount.Length : " + chapterCount.Length);
        
        TextAsset[] RevisedRevision = Resources.LoadAll<TextAsset>("RevisedRevision/"); // RevisedRevision 폴더에 있는 모든 파일들을 읽어 옵니다. 
        TextAsset[] EasyBible = Resources.LoadAll<TextAsset>("EasyBible/"); // EasyBible 폴더에 있는 모든 파일들을 읽어 옵니다. 
        TextAsset[] KoreanBible = Resources.LoadAll<TextAsset>("KoreanBible/");
        TextAsset[] NewStandardTranslation = Resources.LoadAll<TextAsset>("NewStandardTranslation/"); // NewStandardTranslation 폴더에 있는 모든 파일들을 읽어 옵니다. 
        TextAsset[] NIV = Resources.LoadAll<TextAsset>("NIV/"); // NIV 폴더에 있는 모든 파일들을 읽어 옵니다. 
        TextAsset[] KJV = Resources.LoadAll<TextAsset>("KJV/"); // KJV 폴더에 있는 모든 파일들을 읽어 옵니다. 
        TextAsset[] NewKJV = Resources.LoadAll<TextAsset>("NewKJV/"); // NewKJV 폴더에 있는 모든 파일들을 읽어 옵니다. 
        TextAsset[] ESV = Resources.LoadAll<TextAsset>("ESV/"); // ESV 폴더에 있는 모든 파일들을 읽어 옵니다. 
        TextAsset[] NewRSV = Resources.LoadAll<TextAsset>("NewRSV/"); // NewRSV 폴더에 있는 모든 파일들을 읽어 옵니다. 
        TextAsset[] NASB = Resources.LoadAll<TextAsset>("NASB/"); // NASB 폴더에 있는 모든 파일들을 읽어 옵니다. 

        StreamWriter streamWriter = new StreamWriter(OutputPath + "하나님의 말씀(챕터).txt", true);

        streamWriter.WriteLine("01 : RevisedRevision");
        streamWriter.WriteLine("02 : EasyBible");
        streamWriter.WriteLine("03 : KoreanBible");
        streamWriter.WriteLine("04 : NewStandardTranslation");
        streamWriter.WriteLine("05 : NIV");
        streamWriter.WriteLine("06 : KJV");
        streamWriter.WriteLine("07 : NewKJV");
        streamWriter.WriteLine("08 : ESV");
        streamWriter.WriteLine("09 : NewRSV");
        streamWriter.WriteLine("10 : NASB");

        streamWriter.WriteLine("");

        string tempA = string.Format("{0} :           {1},   {2},         {3},       {4},            {5},                   {6},                 {7},               {8},              {9},             {10}",
                "Bible", "RevisedRevision", "EasyBible", "KoreanBible", "NewStandard", "NIV", "KJV", "NewKJV", "ESV",
                "NewRSV", "NASB");

        streamWriter.WriteLine(tempA);


        for (int i = 0; i < RevisedRevision.Length; i++)
        {
            List<string> RevisedRevisions = new List<string>(RevisedRevision[i].text.Split('\n'));
            List<string> EasyBibles = new List<string>(EasyBible[i].text.Split('\n'));
            List<string> KoreanBibles = new List<string>(KoreanBible[i].text.Split('\n'));
            List<string> NewStandardTranslations = new List<string>(NewStandardTranslation[i].text.Split('\n'));
            List<string> NIVs = new List<string>(NIV[i].text.Split('\n'));
            List<string> KJVs = new List<string>(KJV[i].text.Split('\n'));
            List<string> NewKJVs = new List<string>(NewKJV[i].text.Split('\n'));
            List<string> ESVs = new List<string>(ESV[i].text.Split('\n'));
            List<string> NewRSVs = new List<string>(NewRSV[i].text.Split('\n'));
            List<string> NASBs = new List<string>(NASB[i].text.Split('\n'));

            string temp = string.Format("{0} \t: {1}, \t\t\t{2}, \t\t\t{3}, \t\t\t{4}, \t\t\t{5}, \t\t\t{6}, \t\t\t{7}, \t\t\t{8}, \t\t\t{9}, \t\t\t{10}",
                RevisedRevision[i].name, RevisedRevisions.Count, EasyBibles.Count, KoreanBibles.Count,
                NewStandardTranslations.Count, NIVs.Count, KJVs.Count, NewKJVs.Count, ESVs.Count, NewRSVs.Count, NASBs.Count);

            streamWriter.WriteLine(temp);
        }

        streamWriter.Close();



        //Debug.Log(string.Empty);

        //List<string> tempTemp = new List<string>();

        //for (int i = 0; i < RevisedRevision.Length; i++)
        //{
        //    tempTemp.Add(RevisedRevision[i].name);
        //}

        //Debug.Log(string.Empty);

        //List<TextAsset> temptemptemp = new List<TextAsset>();
        //temptemptemp = RevisedRevision.ToList();

        //temptemptemp = temptemptemp.OrderBy(item => item.name).ToList();

        //Debug.Log(string.Empty);

        //// RevisedRevision = tempTemp.ToArray();
        //// 읽어 온 파일들을 배열에 저장합니다. 
        //List<TextAsset[]> CollectTextAssets = new List<TextAsset[]>() { RevisedRevision, EasyBible, KoreanBible, NewStandardTranslation, NIV, KJV, NewKJV, ESV, NewRSV, NASB };
        //// 저장될 파일 이름입니다. 
        //StreamWriter streamWriter = new StreamWriter(OutputPath + "하나님의 말씀(챕터).txt", true);

        //string Count = string.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9}", RevisedRevision.Length, EasyBible.Length, KoreanBible.Length, NewStandardTranslation.Length, NIV.Length, KJV.Length, NewKJV.Length, ESV.Length, NewRSV.Length, NASB.Length);
        //// 구분을 위해서 폴더 이름을 파일에 저장합니다. 
        //streamWriter.WriteLine("01 : RevisedRevision");
        //streamWriter.WriteLine("02 : EasyBible");
        //streamWriter.WriteLine("03 : KoreanBible");
        //streamWriter.WriteLine("04 : NewStandardTranslation");
        //streamWriter.WriteLine("05 : NIV");
        //streamWriter.WriteLine("06 : KJV");
        //streamWriter.WriteLine("07 : NewKJV");
        //streamWriter.WriteLine("08 : ESV");
        //streamWriter.WriteLine("09 : NewRSV");
        //streamWriter.WriteLine("10 : NASB");

        //{
        //    // 한글 키워드를 대상으로 반복문 처리합니다. 
        //    for (int m = 0; m < Koreankeywords.Length; m++)
        //    {
        //        /////////////////////////////////////////////////////
        //        streamWriter.WriteLine("\n");
        //        // 문자열들을 하나의 문자열로 저장하기 위해서 StringBuilder객체를 생성합니다. 
        //        StringBuilder stringBuilder = new StringBuilder();
        //        List<string> collect = new List<string>();
        //        // stringBuilder에 "01 : "을 추가해 줍니다. 
        //        stringBuilder.Append(Koreankeywords[m] + "01 : ");
        //        // RevisedRevision 폴더에 있는 파일들을 대상으로 반복문 처리합니다. 
        //        for (int i = 0; i < RevisedRevision.Length; i++)
        //        {
        //            // 파일 이름에 "_창" 문자열이 포함되어 있다면? 
        //            if (RevisedRevision[i].name.Contains("_" + Koreankeywords[m]))
        //            {
        //                // 파일에 있는 문자열을 '\n'로 구분해서 collect 리스트에 저장합니다. 
        //                collect = new List<string>(RevisedRevision[i].text.Split('\n'));
        //                // stringBuilder에 collect리스트의 사이즈를 저장합니다. 
        //                stringBuilder.Append(collect.Count + ", ");
        //            }
        //        }
        //        // stringBuilder에 있는 내용을 파일에 저장합니다. 
        //        streamWriter.WriteLine(stringBuilder.ToString());
        //        /////////////////////////////////////////////////////

        //        /////////////////////////////////////////////////////
        //        stringBuilder = new StringBuilder();
        //        collect = new List<string>();
        //        stringBuilder.Append(Koreankeywords[m] + "02 : ");

        //        for (int i = 0; i < EasyBible.Length; i++)
        //        {
        //            if (EasyBible[i].name.Contains("_" + Koreankeywords[m]))
        //            {
        //                collect = new List<string>(EasyBible[i].text.Split('\n'));
        //                stringBuilder.Append(collect.Count + ", ");
        //            }
        //        }

        //        streamWriter.WriteLine(stringBuilder.ToString());
        //        /////////////////////////////////////////////////////

        //        /////////////////////////////////////////////////////
        //        stringBuilder = new StringBuilder();
        //        collect = new List<string>();
        //        stringBuilder.Append(Koreankeywords[m] + "03 : ");

        //        for (int i = 0; i < KoreanBible.Length; i++)
        //        {
        //            if (KoreanBible[i].name.Contains("_" + Koreankeywords[m]))
        //            {
        //                collect = new List<string>(KoreanBible[i].text.Split('\n'));
        //                stringBuilder.Append(collect.Count + ", ");
        //            }
        //        }

        //        streamWriter.WriteLine(stringBuilder.ToString());
        //        /////////////////////////////////////////////////////

        //        /////////////////////////////////////////////////////
        //        stringBuilder = new StringBuilder();
        //        collect = new List<string>();
        //        stringBuilder.Append(Koreankeywords[m] + "04 : ");

        //        for (int i = 0; i < NewStandardTranslation.Length; i++)
        //        {
        //            if (NewStandardTranslation[i].name.Contains("_" + Koreankeywords[m]))
        //            {
        //                collect = new List<string>(NewStandardTranslation[i].text.Split('\n'));
        //                stringBuilder.Append(collect.Count + ", ");
        //            }
        //        }

        //        streamWriter.WriteLine(stringBuilder.ToString());
        //        /////////////////////////////////////////////////////

        //        /////////////////////////////////////////////////////
        //        stringBuilder = new StringBuilder();
        //        collect = new List<string>();
        //        stringBuilder.Append(Koreankeywords[m] + "05 : ");

        //        for (int i = 0; i < NIV.Length; i++)
        //        {
        //            if (NIV[i].name.Contains("_" + Koreankeywords[m]))
        //            {
        //                collect = new List<string>(NIV[i].text.Split('\n'));
        //                stringBuilder.Append(collect.Count + ", ");
        //            }
        //        }

        //        streamWriter.WriteLine(stringBuilder.ToString());
        //        /////////////////////////////////////////////////////

        //        /////////////////////////////////////////////////////
        //        stringBuilder = new StringBuilder();
        //        collect = new List<string>();
        //        stringBuilder.Append(Koreankeywords[m] + "06 : ");

        //        for (int i = 0; i < KJV.Length; i++)
        //        {
        //            if (KJV[i].name.Contains("_" + Koreankeywords[m]))
        //            {
        //                collect = new List<string>(KJV[i].text.Split('\n'));
        //                stringBuilder.Append(collect.Count + ", ");
        //            }
        //        }

        //        streamWriter.WriteLine(stringBuilder.ToString());
        //        /////////////////////////////////////////////////////

        //        /////////////////////////////////////////////////////
        //        stringBuilder = new StringBuilder();
        //        collect = new List<string>();
        //        stringBuilder.Append(Koreankeywords[m] + "07 : ");

        //        for (int i = 0; i < NewKJV.Length; i++)
        //        {
        //            if (NewKJV[i].name.Contains("_" + Koreankeywords[m]))
        //            {
        //                collect = new List<string>(NewKJV[i].text.Split('\n'));
        //                stringBuilder.Append(collect.Count + ", ");
        //            }
        //        }

        //        streamWriter.WriteLine(stringBuilder.ToString());
        //        /////////////////////////////////////////////////////

        //        /////////////////////////////////////////////////////
        //        stringBuilder = new StringBuilder();
        //        collect = new List<string>();
        //        stringBuilder.Append(Koreankeywords[m] + "08 : ");

        //        for (int i = 0; i < ESV.Length; i++)
        //        {
        //            if (ESV[i].name.Contains("_" + Koreankeywords[m]))
        //            {
        //                collect = new List<string>(ESV[i].text.Split('\n'));
        //                stringBuilder.Append(collect.Count + ", ");
        //            }
        //        }

        //        streamWriter.WriteLine(stringBuilder.ToString());
        //        /////////////////////////////////////////////////////

        //        /////////////////////////////////////////////////////
        //        stringBuilder = new StringBuilder();
        //        collect = new List<string>();
        //        stringBuilder.Append(Koreankeywords[m] + "19 : ");

        //        for (int i = 0; i < NewRSV.Length; i++)
        //        {
        //            if (NewRSV[i].name.Contains("_" + Koreankeywords[m]))
        //            {
        //                collect = new List<string>(NewRSV[i].text.Split('\n'));
        //                stringBuilder.Append(collect.Count + ", ");
        //            }
        //        }

        //        streamWriter.WriteLine(stringBuilder.ToString());
        //        /////////////////////////////////////////////////////

        //        /////////////////////////////////////////////////////
        //        stringBuilder = new StringBuilder();
        //        collect = new List<string>();
        //        stringBuilder.Append(Koreankeywords[m] + "10 : ");

        //        for (int i = 0; i < NASB.Length; i++)
        //        {
        //            if (NASB[i].name.Contains("_" + Koreankeywords[m]))
        //            {
        //                collect = new List<string>(NASB[i].text.Split('\n'));
        //                stringBuilder.Append(collect.Count + ", ");
        //            }
        //        }

        //        streamWriter.WriteLine(stringBuilder.ToString());
        //        /////////////////////////////////////////////////////
        //        streamWriter.WriteLine("01 : RevisedRevision");
        //        streamWriter.WriteLine("02 : EasyBible");
        //        streamWriter.WriteLine("03 : KoreanBible");
        //        streamWriter.WriteLine("04 : NewStandardTranslation");
        //        streamWriter.WriteLine("05 : NIV");
        //        streamWriter.WriteLine("06 : KJV");
        //        streamWriter.WriteLine("07 : NewKJV");
        //        streamWriter.WriteLine("08 : ESV");
        //        streamWriter.WriteLine("09 : NewRSV");
        //        streamWriter.WriteLine("10 : NASB");
        //    }
        //}
        //streamWriter.Close();
    }

    /// <summary>
    /// 1189개의 쉬운성경의 파일들을 하나의 텍스트 파일로 생성하기 위한 이전 단계, 한글
    /// </summary>
    public static void PreparationForCombineFilesKorean()
    {
        string[] Koreankeywords = { "창", "출", "레", "민", "신", "수", "삿", "룻", "삼상", "삼하", "왕상", "왕하", "대상", "대하", "스", "느", "에", "욥", "시", "잠", "전", "아", "사", "렘", "애", "겔", "단", "호", "욜", "암", "옵", "욘", "미", "나", "합", "습", "학", "슥", "말", "마", "막", "눅", "요", "행", "롬", "고전", "고후", "갈", "엡", "빌", "골", "살전", "살후", "딤전", "딤후", "딛", "몬", "히", "약", "벧전", "벧후", "요일", "요이", "요삼", "유", "계" };
        string[] Englishkeywords = { "Gen", "Ex", "Lev", "Num", "Deut", "Josh", "Judg", "Ruth", "1Sam", "2Sam", "1Kin", "2Kin", "1Chr", "2Chr", "Ezra", "Neh", "Esther", "Job", "Ps", "Prov", "Eccles", "Song", "Is", "Jer", "Lam", "Ezek", "Dan", "Hos", "Joel", "Amos", "Obad", "Jonah", "Mic", "Nah", "Hab", "Zeph", "Hag", "Zech", "Mal", "Matt", "Mark", "Luke", "John", "Acts", "Rom", "1Cor", "2Cor", "Gal", "Eph", "Phil", "Col", "1Thess", "2Thess", "1Tim", "2Tim", "Titus", "Philem", "Heb", "James", "1Pet", "2Pet", "1John", "2John", "3John", "Jude", "Rev" };
        int[] chapterCount = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4, 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };

        // c:\Bible\AAA 폴더에 있는 모든 텍스트 파일들을 읽어 옵니다. 
        string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\AAA", "*.txt", SearchOption.AllDirectories);

        string newFile = string.Empty;
        // 텍스트 파일들을 대상으로 반복문 처리합니다. 
        for (int i = 0; i < CollectAllFiles.Length; i++)
        {
            // 가져온 텍스트 파일의 파일 이름을 가져옵니다. 
            string oldFile = Path.GetFileName(CollectAllFiles[i]);
            // 파일 이름은 기본적으로 쉬운성경_창1 입니다. 하나의 파일로 생성해 주기 위해서는 파일 이름 앞에 01과 같은 인덱스를 추가해 주어야 합니다. 
            // 파일들을 읽어서 파일 이름앞에 인덱스를 추가해 줍니다.
            for (int j = 0; j < Koreankeywords.Length; j++)
            {
                // 만일 파일 이름에 "창"문자열이 있다면? 
                if (oldFile.Contains(Koreankeywords[j]))
                {
                    // "쉬운성경_창1" 파일 이름을 "01쉬운성경_창1"로 변경해 줍니다. 
                    // "01쉬운성경_창1"을 "01쉬운성경_창01"로 변경해 주어야 하는데 이후에 ACDSee를 이용합니다. 
                    string result = string.Format("{0:D2}{1}", (j + 1), oldFile);
                    newFile = result;
                }
            }
            // c:\Bible\BBB\ 폴더에 저장될 파일 이름입니다. 
            newFile = @"c:\Bible\BBB\" + newFile;
            // c:\Bible\BBB\ 폴더에 파일 이름을 저장합니다. 
            System.IO.File.Copy(CollectAllFiles[i], newFile);
        }
        // 이제 파일의 내용을 수정해 주어야 합니다. 쉬운 성경의 내용들은 기본적으로 "창1:1"와 같은 내용이 없으므로 구분을 위해서 추가해 주는 것입니다. 
        // c:\Bible\BBB 폴더의 모든 파일들을 읽어 옵니다. 
        CollectAllFiles = Directory.GetFiles(@"c:\Bible\BBB", "*.txt", SearchOption.AllDirectories);
        // 읽어온 파일들을 대상으로 반복문 처리합니다. 
        for (int k = 0; k < CollectAllFiles.Length; k++)
        {
            // 확장자가 빠진 파일 이름을 가져옵니다. 
            string fileName = Path.GetFileNameWithoutExtension(CollectAllFiles[k]);

            Debug.Log("fileName" + fileName);
            // c:\Bible\CCC\ 폴더에 저장될 파일 이름입니다. 
            string outputFilePath = @"c:\Bible\CCC\" + fileName + ".txt";
            // 텍스트 파일의 내용을 문자열로 읽어 옵니다. 
            string textValue = System.IO.File.ReadAllText(CollectAllFiles[k]);
            // 읽어온 문자열을 '\n' 기준으로 분리해서 리스트 컬렉션에 저장합니다. 
            List<string> collectKorean = new List<string>(textValue.Split('\n'));
            // 최종 결과 문자열들을 저장할 배열입니다. 
            List<string> collectKoreanModify = new List<string>();
            // 저장된 collectKorean 컬렉션을 대상으로 반복문 처리합니다. 
            for (int i = 0; i < collectKorean.Count - 1; i++)
            {
                // 기본적인 파일 이름은 "01쉬운성경_창1" 입니다. "_"를 기준으로 파일 이름을 분리합니다. 
                string[] ModifyA = fileName.Split("_");

                Debug.Log("ModifyA[1]" + ModifyA[1]);

                if (ModifyA.Length > 1)
                {
                    // 파일의 내용을 읽어서 절 앞에 창1:1을 표시합니다. 
                    collectKoreanModify.Add(ModifyA[1] + ":" + (i + 1) + " " + collectKorean[i]);
                }
            }
            // 파일로 저장할 준비를 합니다. 
            StreamWriter writer = new StreamWriter(outputFilePath);

            for (int i = 0; i < collectKoreanModify.Count; i++)
            {
                // 최종 결과 문자열들을 파일에 씁니다. 
                writer.WriteLine(collectKoreanModify[i].Trim());
            }

            writer.Close();
        }
    }
    /// <summary>
    /// 1189개의 쉬운성경의 파일들을 하나의 텍스트 파일로 생성하기 위한 이전 단계, 영어
    /// </summary>
    public static void PreparationForCombineFilesEnglish()
    {
        string[] Koreankeywords = { "창", "출", "레", "민", "신", "수", "삿", "룻", "삼상", "삼하", "왕상", "왕하", "대상", "대하", "스", "느", "에", "욥", "시", "잠", "전", "아", "사", "렘", "애", "겔", "단", "호", "욜", "암", "옵", "욘", "미", "나", "합", "습", "학", "슥", "말", "마", "막", "눅", "요", "행", "롬", "고전", "고후", "갈", "엡", "빌", "골", "살전", "살후", "딤전", "딤후", "딛", "몬", "히", "약", "벧전", "벧후", "요일", "요이", "요삼", "유", "계" };
        string[] Englishkeywords = { "Gen", "Ex", "Lev", "Num", "Deut", "Josh", "Judg", "Ruth", "1Sam", "2Sam", "1Kin", "2Kin", "1Chr", "2Chr", "Ezra", "Neh", "Esther", "Job", "Ps", "Prov", "Eccles", "Song", "Is", "Jer", "Lam", "Ezek", "Dan", "Hos", "Joel", "Amos", "Obad", "Jonah", "Mic", "Nah", "Hab", "Zeph", "Hag", "Zech", "Mal", "Matt", "Mark", "Luke", "John", "Acts", "Rom", "1Cor", "2Cor", "Gal", "Eph", "Phil", "Col", "1Thess", "2Thess", "1Tim", "2Tim", "Titus", "Philem", "Heb", "James", "1Pet", "2Pet", "1John", "2John", "3John", "Jude", "Rev" };
        int[] chapterCount = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4, 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };

        // c:\Bible\AAA 폴더에 있는 모든 텍스트 파일들을 읽어 옵니다. 
        string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\AAA", "*.txt", SearchOption.AllDirectories);

        string newFile = string.Empty;
        // 텍스트 파일들을 대상으로 반복문 처리합니다. 
        for (int i = 0; i < CollectAllFiles.Length; i++)
        {
            // 가져온 텍스트 파일의 파일 이름을 가져옵니다. 
            string oldFile = Path.GetFileName(CollectAllFiles[i]);
            // 파일 이름은 기본적으로 쉬운성경_창1 입니다. 하나의 파일로 생성해 주기 위해서는 파일 이름 앞에 01과 같은 인덱스를 추가해 주어야 합니다. 
            // 파일들을 읽어서 파일 이름앞에 인덱스를 추가해 줍니다.
            for (int j = 0; j < Englishkeywords.Length; j++)
            {
                // 만일 파일 이름에 "창"문자열이 있다면? 
                if (oldFile.Contains(Englishkeywords[j]))
                {
                    // "쉬운성경_창1" 파일 이름을 "01쉬운성경_창1"로 변경해 줍니다. 
                    // "01쉬운성경_창1"을 "01쉬운성경_창01"로 변경해 주어야 하는데 이후에 ACDSee를 이용합니다. 
                    string result = string.Format("{0:D2}{1}", (j + 1), oldFile);
                    newFile = result;
                }
            }
            // c:\Bible\BBB\ 폴더에 저장될 파일 이름입니다. 
            newFile = @"c:\Bible\BBB\" + newFile;
            // c:\Bible\BBB\ 폴더에 파일 이름을 저장합니다. 
            System.IO.File.Copy(CollectAllFiles[i], newFile);
        }
        // 이제 파일의 내용을 수정해 주어야 합니다. 쉬운 성경의 내용들은 기본적으로 "창1:1"와 같은 내용이 없으므로 구분을 위해서 추가해 주는 것입니다. 
        // c:\Bible\BBB 폴더의 모든 파일들을 읽어 옵니다. 
        CollectAllFiles = Directory.GetFiles(@"c:\Bible\BBB", "*.txt", SearchOption.AllDirectories);
        // 읽어온 파일들을 대상으로 반복문 처리합니다. 
        for (int k = 0; k < CollectAllFiles.Length; k++)
        {
            // 확장자가 빠진 파일 이름을 가져옵니다. 
            string fileName = Path.GetFileNameWithoutExtension(CollectAllFiles[k]);

            Debug.Log("fileName" + fileName);
            // c:\Bible\CCC\ 폴더에 저장될 파일 이름입니다. 
            string outputFilePath = @"c:\Bible\CCC\" + fileName + ".txt";
            // 텍스트 파일의 내용을 문자열로 읽어 옵니다. 
            string textValue = System.IO.File.ReadAllText(CollectAllFiles[k]);
            // 읽어온 문자열을 '\n' 기준으로 분리해서 리스트 컬렉션에 저장합니다. 
            List<string> collectKorean = new List<string>(textValue.Split('\n'));
            // 최종 결과 문자열들을 저장할 배열입니다. 
            List<string> collectKoreanModify = new List<string>();
            // 저장된 collectKorean 컬렉션을 대상으로 반복문 처리합니다. 
            for (int i = 0; i < collectKorean.Count - 1; i++)
            {
                // 기본적인 파일 이름은 "01쉬운성경_창1" 입니다. "_"를 기준으로 파일 이름을 분리합니다. 
                string[] ModifyA = fileName.Split("_");

                Debug.Log("ModifyA[1]" + ModifyA[1]);

                if (ModifyA.Length > 1)
                {
                    // 파일의 내용을 읽어서 절 앞에 창1:1을 표시합니다. 
                    collectKoreanModify.Add(ModifyA[1] + ":" + (i + 1) + " " + collectKorean[i]);
                }
            }
            // 파일로 저장할 준비를 합니다. 
            StreamWriter writer = new StreamWriter(outputFilePath);

            for (int i = 0; i < collectKoreanModify.Count; i++)
            {
                // 최종 결과 문자열들을 파일에 씁니다. 
                writer.WriteLine(collectKoreanModify[i].Trim());
            }

            writer.Close();
        }
    }
    /// <summary>
    /// 1189개의 파일들을 하나의 파일로 생성합니다. 
    /// </summary>
    public static void Combine1189ToOne()
    {
        string[] Koreankeywords = { "창", "출", "레", "민", "신", "수", "삿", "룻", "삼상", "삼하", "왕상", "왕하", "대상", "대하", "스", "느", "에", "욥", "시", "잠", "전", "아", "사", "렘", "애", "겔", "단", "호", "욜", "암", "옵", "욘", "미", "나", "합", "습", "학", "슥", "말", "마", "막", "눅", "요", "행", "롬", "고전", "고후", "갈", "엡", "빌", "골", "살전", "살후", "딤전", "딤후", "딛", "몬", "히", "약", "벧전", "벧후", "요일", "요이", "요삼", "유", "계" };
        string[] keywords = { "Gen", "Ex", "Lev", "Num", "Deut", "Josh", "Judg", "Ruth", "1Sam", "2Sam", "1Kin", "2Kin", "1Chr", "2Chr", "Ezra", "Neh", "Esther", "Job", "Ps", "Prov", "Eccles", "Song", "Is", "Jer", "Lam", "Ezek", "Dan", "Hos", "Joel", "Amos", "Obad", "Jonah", "Mic", "Nah", "Hab", "Zeph", "Hag", "Zech", "Mal", "Matt", "Mark", "Luke", "John", "Acts", "Rom", "1Cor", "2Cor", "Gal", "Eph", "Phil", "Col", "1Thess", "2Thess", "1Tim", "2Tim", "Titus", "Philem", "Heb", "James", "1Pet", "2Pet", "1John", "2John", "3John", "Jude", "Rev" };
        int[] chapterCount = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4, 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };
        // c:\Bible\AAA 폴더에 있는 파일들을 모두 읽어 옵니다. 
        string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\CCC", "*.txt", SearchOption.TopDirectoryOnly);
        // c:\Bible\ 폴더에 개역개정A.txt 이라는 이름으로 파일을 저장할 것입니다. 
        string outputFilePath = @"c:\Bible\" + "쉬운성경A.txt";

        List<string> collectKorean = new List<string>();
        // 폴더에 있는 파일들을 대상으로 반복문 처리합니다. 
        for (int k = 0; k < CollectAllFiles.Length; k++)
        {
            // 한글 키워드들을 대상으로 반복문 처리합니다. 
            for (int i = 0; i < Koreankeywords.Length; i++)
            {
                // 만일 파일의 이름에 "_창" 문자열이 포함되어 있다면? 
                if (CollectAllFiles[k].Contains("_" + Koreankeywords[i]))
                {
                    // 파일의 내용을 문자열로 읽어 옵니다. 
                    string textValue = System.IO.File.ReadAllText(CollectAllFiles[k]);
                    // 저장된 문자열을 '\n' 문자로 구분해서 임시 리스트에 저장합니다. 
                    List<string> temp = new List<string>(textValue.Split('\n'));
                    // 맨 나중에 있는 공백은 임시 리스트에서 없애 줍니다. 
                    temp.RemoveAt(temp.Count - 1);
                    // 임시 리스트에 있는 문자열들을 collectKorean 리스트에 저장합니다. 
                    collectKorean.AddRange(temp);
                }
            }
        }
        Debug.Log("collectKorean.Count : " + collectKorean.Count);
        // 파일을 저장할 준비를 합니다. 
        StreamWriter writer = new StreamWriter(outputFilePath);
        // collectKorean 리스트를 대상으로 반복문 처리합니다. 
        for (int i = 0; i < collectKorean.Count; i++)
        {
            writer.WriteLine(collectKorean[i].Trim());
        }

        writer.Close();
    }
    public static void CombineToOne()
    {
        string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\CCC\", "*.txt", SearchOption.TopDirectoryOnly);
        // c:\Bible\ 폴더에 개역개정A.txt 이라는 이름으로 파일을 저장할 것입니다. 
        string outputFilePath = @"c:\Bible\" + "테스트.txt";

        List<string> collectKorean = new List<string>();
        // 폴더에 있는 파일들을 대상으로 반복문 처리합니다. 
        for (int k = 0; k < CollectAllFiles.Length; k++)
        {
            // 파일의 내용을 문자열로 읽어 옵니다. 
            string textValue = System.IO.File.ReadAllText(CollectAllFiles[k]);
            // 저장된 문자열을 '\n' 문자로 구분해서 임시 리스트에 저장합니다. 
            List<string> temp = new List<string>(textValue.Split('\n'));
            // 맨 나중에 있는 공백은 임시 리스트에서 없애 줍니다. 
            temp.RemoveAt(temp.Count - 1);
            // 임시 리스트에 있는 문자열들을 collectKorean 리스트에 저장합니다. 
            collectKorean.AddRange(temp);
        }
        Debug.Log("collectKorean.Count : " + collectKorean.Count);
        // 파일을 저장할 준비를 합니다. 
        StreamWriter writer = new StreamWriter(outputFilePath);
        // collectKorean 리스트를 대상으로 반복문 처리합니다. 
        for (int i = 0; i < collectKorean.Count; i++)
        {
            writer.WriteLine(collectKorean[i].Trim());
        }

        writer.Close();
    }
    /// <summary>
    /// 성경의 이름이 01로 시작한다면? 01을 "Gen"으로 변경합니다.
    /// </summary>
    public static void CheckIfBibleIsStart01()
    {
        string[] Koreankeywords = { "창", "출", "레", "민", "신", "수", "삿", "룻", "삼상", "삼하", "왕상", "왕하", "대상", "대하", "스", "느", "에", "욥", "시", "잠", "전", "아", "사", "렘", "애", "겔", "단", "호", "욜", "암", "옵", "욘", "미", "나", "합", "습", "학", "슥", "말", "마", "막", "눅", "요", "행", "롬", "고전", "고후", "갈", "엡", "빌", "골", "살전", "살후", "딤전", "딤후", "딛", "몬", "히", "약", "벧전", "벧후", "요일", "요이", "요삼", "유", "계" };
        string[] Englishkeywords = { "Gen", "Ex", "Lev", "Num", "Deut", "Josh", "Judg", "Ruth", "1Sam", "2Sam", "1Kin", "2Kin", "1Chr", "2Chr", "Ezra", "Neh", "Esther", "Job", "Ps", "Prov", "Eccles", "Song", "Is", "Jer", "Lam", "Ezek", "Dan", "Hos", "Joel", "Amos", "Obad", "Jonah", "Mic", "Nah", "Hab", "Zeph", "Hag", "Zech", "Mal", "Matt", "Mark", "Luke", "John", "Acts", "Rom", "1Cor", "2Cor", "Gal", "Eph", "Phil", "Col", "1Thess", "2Thess", "1Tim", "2Tim", "Titus", "Philem", "Heb", "James", "1Pet", "2Pet", "1John", "2John", "3John", "Jude", "Rev" };
        int[] NumberCount = { 01, 02, 03, 04, 05, 06, 07, 08, 09, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 36, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66 };
        // Resources에 있는 영어 성경을 가져와서 textFile에 저장합니다. 
        TextAsset textFile = Resources.Load("NASB 영어텍스트") as TextAsset;
        // textFile을 '\n'로 분리해서 collectKorean리스트에 저장합니다. 
        List<string> collectKorean = new List<string>(textFile.text.Split('\n'));
        List<string> collectAll = new List<string>();

        //for (int i = 0; i < collectKorean.Count; i++)
        //{
        //    Debug.Log("collectKorean[i] : " + collectKorean[i]);
        //}

        string modifyString = string.Empty;
        // collectKorean리스트를 대상으로 반복문 처리합니다. 
        for (int i = 0; i < collectKorean.Count; i++)
        {
            // 만일 collectKorean리스트의 요소가 "01 "로 시작한다면? "01 "을 영어키워드의 요소로 변경해 줍니다. 
            if (collectKorean[i].StartsWith("01 ")) modifyString = collectKorean[i].Replace("01 ", Englishkeywords[0]);
            if (collectKorean[i].StartsWith("02 ")) modifyString = collectKorean[i].Replace("02 ", Englishkeywords[1]);
            if (collectKorean[i].StartsWith("03 ")) modifyString = collectKorean[i].Replace("03 ", Englishkeywords[2]);
            if (collectKorean[i].StartsWith("04 ")) modifyString = collectKorean[i].Replace("04 ", Englishkeywords[3]);
            if (collectKorean[i].StartsWith("05 ")) modifyString = collectKorean[i].Replace("05 ", Englishkeywords[4]);
            if (collectKorean[i].StartsWith("06 ")) modifyString = collectKorean[i].Replace("06 ", Englishkeywords[5]);
            if (collectKorean[i].StartsWith("07 ")) modifyString = collectKorean[i].Replace("07 ", Englishkeywords[6]);
            if (collectKorean[i].StartsWith("08 ")) modifyString = collectKorean[i].Replace("08 ", Englishkeywords[7]);
            if (collectKorean[i].StartsWith("09 ")) modifyString = collectKorean[i].Replace("09 ", Englishkeywords[8]);
            if (collectKorean[i].StartsWith("10 ")) modifyString = collectKorean[i].Replace("10 ", Englishkeywords[9]);

            if (collectKorean[i].StartsWith("11 ")) modifyString = collectKorean[i].Replace("11 ", Englishkeywords[10]);
            if (collectKorean[i].StartsWith("12 ")) modifyString = collectKorean[i].Replace("12 ", Englishkeywords[11]);
            if (collectKorean[i].StartsWith("13 ")) modifyString = collectKorean[i].Replace("13 ", Englishkeywords[12]);
            if (collectKorean[i].StartsWith("14 ")) modifyString = collectKorean[i].Replace("14 ", Englishkeywords[13]);
            if (collectKorean[i].StartsWith("15 ")) modifyString = collectKorean[i].Replace("15 ", Englishkeywords[14]);
            if (collectKorean[i].StartsWith("16 ")) modifyString = collectKorean[i].Replace("16 ", Englishkeywords[15]);
            if (collectKorean[i].StartsWith("17 ")) modifyString = collectKorean[i].Replace("17 ", Englishkeywords[16]);
            if (collectKorean[i].StartsWith("18 ")) modifyString = collectKorean[i].Replace("18 ", Englishkeywords[17]);
            if (collectKorean[i].StartsWith("19 ")) modifyString = collectKorean[i].Replace("19 ", Englishkeywords[18]);
            if (collectKorean[i].StartsWith("20 ")) modifyString = collectKorean[i].Replace("20 ", Englishkeywords[19]);

            if (collectKorean[i].StartsWith("21 ")) modifyString = collectKorean[i].Replace("21 ", Englishkeywords[20]);
            if (collectKorean[i].StartsWith("22 ")) modifyString = collectKorean[i].Replace("22 ", Englishkeywords[21]);
            if (collectKorean[i].StartsWith("23 ")) modifyString = collectKorean[i].Replace("23 ", Englishkeywords[22]);
            if (collectKorean[i].StartsWith("24 ")) modifyString = collectKorean[i].Replace("24 ", Englishkeywords[23]);
            if (collectKorean[i].StartsWith("25 ")) modifyString = collectKorean[i].Replace("25 ", Englishkeywords[24]);
            if (collectKorean[i].StartsWith("26 ")) modifyString = collectKorean[i].Replace("26 ", Englishkeywords[25]);
            if (collectKorean[i].StartsWith("27 ")) modifyString = collectKorean[i].Replace("27 ", Englishkeywords[26]);
            if (collectKorean[i].StartsWith("28 ")) modifyString = collectKorean[i].Replace("28 ", Englishkeywords[27]);
            if (collectKorean[i].StartsWith("29 ")) modifyString = collectKorean[i].Replace("29 ", Englishkeywords[28]);
            if (collectKorean[i].StartsWith("30 ")) modifyString = collectKorean[i].Replace("30 ", Englishkeywords[29]);

            if (collectKorean[i].StartsWith("31 ")) modifyString = collectKorean[i].Replace("31 ", Englishkeywords[30]);
            if (collectKorean[i].StartsWith("32 ")) modifyString = collectKorean[i].Replace("32 ", Englishkeywords[31]);
            if (collectKorean[i].StartsWith("33 ")) modifyString = collectKorean[i].Replace("33 ", Englishkeywords[32]);
            if (collectKorean[i].StartsWith("34 ")) modifyString = collectKorean[i].Replace("34 ", Englishkeywords[33]);
            if (collectKorean[i].StartsWith("35 ")) modifyString = collectKorean[i].Replace("35 ", Englishkeywords[34]);
            if (collectKorean[i].StartsWith("36 ")) modifyString = collectKorean[i].Replace("36 ", Englishkeywords[35]);
            if (collectKorean[i].StartsWith("37 ")) modifyString = collectKorean[i].Replace("37 ", Englishkeywords[36]);
            if (collectKorean[i].StartsWith("38 ")) modifyString = collectKorean[i].Replace("38 ", Englishkeywords[37]);
            if (collectKorean[i].StartsWith("39 ")) modifyString = collectKorean[i].Replace("39 ", Englishkeywords[38]);
            if (collectKorean[i].StartsWith("40 ")) modifyString = collectKorean[i].Replace("40 ", Englishkeywords[39]);

            if (collectKorean[i].StartsWith("41 ")) modifyString = collectKorean[i].Replace("41 ", Englishkeywords[40]);
            if (collectKorean[i].StartsWith("42 ")) modifyString = collectKorean[i].Replace("42 ", Englishkeywords[41]);
            if (collectKorean[i].StartsWith("43 ")) modifyString = collectKorean[i].Replace("43 ", Englishkeywords[42]);
            if (collectKorean[i].StartsWith("44 ")) modifyString = collectKorean[i].Replace("44 ", Englishkeywords[43]);
            if (collectKorean[i].StartsWith("45 ")) modifyString = collectKorean[i].Replace("45 ", Englishkeywords[44]);
            if (collectKorean[i].StartsWith("46 ")) modifyString = collectKorean[i].Replace("46 ", Englishkeywords[45]);
            if (collectKorean[i].StartsWith("47 ")) modifyString = collectKorean[i].Replace("47 ", Englishkeywords[46]);
            if (collectKorean[i].StartsWith("48 ")) modifyString = collectKorean[i].Replace("48 ", Englishkeywords[47]);
            if (collectKorean[i].StartsWith("49 ")) modifyString = collectKorean[i].Replace("49 ", Englishkeywords[48]);
            if (collectKorean[i].StartsWith("50 ")) modifyString = collectKorean[i].Replace("50 ", Englishkeywords[49]);

            if (collectKorean[i].StartsWith("51 ")) modifyString = collectKorean[i].Replace("51 ", Englishkeywords[50]);
            if (collectKorean[i].StartsWith("52 ")) modifyString = collectKorean[i].Replace("52 ", Englishkeywords[51]);
            if (collectKorean[i].StartsWith("53 ")) modifyString = collectKorean[i].Replace("53 ", Englishkeywords[52]);
            if (collectKorean[i].StartsWith("54 ")) modifyString = collectKorean[i].Replace("54 ", Englishkeywords[53]);
            if (collectKorean[i].StartsWith("55 ")) modifyString = collectKorean[i].Replace("55 ", Englishkeywords[54]);
            if (collectKorean[i].StartsWith("56 ")) modifyString = collectKorean[i].Replace("56 ", Englishkeywords[55]);
            if (collectKorean[i].StartsWith("57 ")) modifyString = collectKorean[i].Replace("57 ", Englishkeywords[56]);
            if (collectKorean[i].StartsWith("58 ")) modifyString = collectKorean[i].Replace("58 ", Englishkeywords[57]);
            if (collectKorean[i].StartsWith("59 ")) modifyString = collectKorean[i].Replace("59 ", Englishkeywords[58]);
            if (collectKorean[i].StartsWith("60 ")) modifyString = collectKorean[i].Replace("60 ", Englishkeywords[59]);

            if (collectKorean[i].StartsWith("61 ")) modifyString = collectKorean[i].Replace("61 ", Englishkeywords[60]);
            if (collectKorean[i].StartsWith("62 ")) modifyString = collectKorean[i].Replace("62 ", Englishkeywords[61]);
            if (collectKorean[i].StartsWith("63 ")) modifyString = collectKorean[i].Replace("63 ", Englishkeywords[62]);
            if (collectKorean[i].StartsWith("64 ")) modifyString = collectKorean[i].Replace("64 ", Englishkeywords[63]);
            if (collectKorean[i].StartsWith("65 ")) modifyString = collectKorean[i].Replace("65 ", Englishkeywords[64]);
            if (collectKorean[i].StartsWith("66 ")) modifyString = collectKorean[i].Replace("66 ", Englishkeywords[65]);
            // 수정된 파일 이름을 collectAll리스트에 저장합니다. 
            collectAll.Add(modifyString);

            //for (int j = 0; j < NumberCount.Length; j++)
            //{
            //    if (collectKorean[i].StartsWith(NumberCount[j] + " "))
            //    {
            //        modifyString = collectKorean[i].Replace(NumberCount[j] + " ", Englishkeywords[j]);
            //        // Debug.Log("modifyString : " + modifyString);
            //        collectAll.Add(modifyString);
            //    }
            //}
        }

        string folderPath = @"c:\Bible\EEE\";
        // 저장될 파일 이름입니다. 
        string outputFilePath = folderPath + "NASB 영어텍스트A" + ".txt";
        // 파일로 저장할 준비를 합니다. 
        StreamWriter writer = new StreamWriter(outputFilePath);
        // collectAll리스트를 대상으로 반복문 처리합니다. 
        for (int i = 0; i < collectAll.Count; i++)
        {
            // 파일을 저장하고 공백은 없애 줍니다. 
            writer.WriteLine(collectAll[i].Trim());
        }

        writer.Close();

        Debug.Log("collectKorean.Count : " + collectKorean.Count);
        Debug.Log("collectAll.Count : " + collectAll.Count);
    }
    /// <summary>
    /// 1189개의 텍스트 파일들을 하나의 텍스트 파일로 생성해 줍니다
    /// </summary>
    public static void CreateOneTextFileInEachBable()
    {
        // c:\Bible\AAA 폴더에 있는 모든 파일들을 읽어 옵니다. 
        List<string> CollectAllFiles = Directory.GetFiles(@"c:\Bible\CCC", "*.txt", SearchOption.TopDirectoryOnly).ToList();
        // 소팅도 해 줍니다. 
        CollectAllFiles = CollectAllFiles.OrderBy(o => o[0]).ToList();

        Debug.Log("CollectAllFiles[0] : " + CollectAllFiles[0]);
        // 최종 저장될 파일 이름 입니다. 
        string outputFilePath = @"c:\Bible\쉬운성경B.txt";

        List<string> collectKorean = new List<string>();

        StreamWriter writer;
        // 모든 파일들이 저장되어 있는 컬렉션을 대상으로 반복문 처리합니다. 
        for (int k = 0; k < CollectAllFiles.Count; k++)
        {
            // 파일의 내용을 문자열로 읽어 옵니다. 
            string textValue = System.IO.File.ReadAllText(CollectAllFiles[k]);
            // 읽어 온 문자열을 '\n' 기준으로 분리해서 collectKorean리스트에 저장합니다. 
            collectKorean = new List<string>(textValue.Split('\n'));
            // 파일을 저장할 준비를 합니다. 1189개의 파일들의 내용을 하나의 텍스트 파일에 저장해야 하니 파일에 추가가 가능하도록 설정해 줍니다. 
            writer = new StreamWriter(outputFilePath, true);
            // 파일들에는 끝에 공백이 있습니다. 공백을 빼주기 위해서 collectKorean.Count - 1 해 줍니다. 
            for (int i = 0; i < collectKorean.Count - 1; i++)
            {
                // 문자열들을 파일에 저장합니다. 
                writer.WriteLine(collectKorean[i].TrimEnd());
            }

            writer.Close();
        }
    }

    /// <summary>
    /// 성경파일이름의 영어를 한글로 변경
    /// </summary>
    public static void CopyFilesWithEnglishToKorean()
    {
        string[] Koreankeywords = { "창", "출", "레", "민", "신", "수", "삿", "룻", "삼상", "삼하", "왕상", "왕하", "대상", "대하", "스", "느", "에", "욥", "시", "잠", "전", "아", "사", "렘", "애", "겔", "단", "호", "욜", "암", "옵", "욘", "미", "나", "합", "습", "학", "슥", "말", "마", "막", "눅", "요", "행", "롬", "고전", "고후", "갈", "엡", "빌", "골", "살전", "살후", "딤전", "딤후", "딛", "몬", "히", "약", "벧전", "벧후", "요일", "요이", "요삼", "유", "계" };
        string[] Englishkeywords = { "Gen", "Ex", "Lev", "Num", "Deut", "Josh", "Judg", "Ruth", "1Sam", "2Sam", "1Kin", "2Kin", "1Chr", "2Chr", "Ezra", "Neh", "Esther", "Job", "Ps", "Prov", "Eccles", "Song", "Is", "Jer", "Lam", "Ezek", "Dan", "Hos", "Joel", "Amos", "Obad", "Jonah", "Mic", "Nah", "Hab", "Zeph", "Hag", "Zech", "Mal", "Matt", "Mark", "Luke", "John", "Acts", "Rom", "1Cor", "2Cor", "Gal", "Eph", "Phil", "Col", "1Thess", "2Thess", "1Tim", "2Tim", "Titus", "Philem", "Heb", "James", "1Pet", "2Pet", "1John", "2John", "3John", "Jude", "Rev" };
        int[] chapterCount = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4, 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };
        
        string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\DDD", "*.txt", SearchOption.AllDirectories); // c:\Bible\DDD 폴더에 있는 모든 파일들을 가져옵니다. 
        string newFile = string.Empty;
        
        for (int i = 0; i < CollectAllFiles.Length; i++) // c:\Bible\DDD 폴더에 있는 모든 파일들을 대상으로 반복문 처리합니다. 
        {
            string oldFile = Path.GetFileName(CollectAllFiles[i]); // 파일 이름을 가져옵니다. 

            for (int j = 0; j < Englishkeywords.Length; j++) // 엑셀파일에 파일들의 이름의 한글로 되어 있습니다. 표준새번역_마, KJV_마
            {
                if (oldFile.Contains(Englishkeywords[j])) newFile = oldFile.Replace(Englishkeywords[j], Koreankeywords[j]); // 파일이름의 영어를 한글로 변경해 줍니다. 
            }
            
            newFile = @"c:\Bible\EEE\" + newFile; // 저장될 파일 위치입니다. 
            System.IO.File.Copy(CollectAllFiles[i], newFile); // 이름이 변경된 파일을 c:\Bible\EEE\ 폴더에 카피해 줍니다. 
        }





        //string[] Koreankeywords = { "창", "출", "레", "민", "신", "수", "삿", "룻", "삼상", "삼하", "왕상", "왕하", "대상", "대하", "스", "느", "에", "욥", "시", "잠", "전", "아", "사", "렘", "애", "겔", "단", "호", "욜", "암", "옵", "욘", "미", "나", "합", "습", "학", "슥", "말", "마", "막", "눅", "요", "행", "롬", "고전", "고후", "갈", "엡", "빌", "골", "살전", "살후", "딤전", "딤후", "딛", "몬", "히", "약", "벧전", "벧후", "요일", "요이", "요삼", "유", "계" };
        //string[] Englishkeywords = { "Gen", "Ex", "Lev", "Num", "Deut", "Josh", "Judg", "Ruth", "1Sam", "2Sam", "1Kin", "2Kin", "1Chr", "2Chr", "Ezra", "Neh", "Esther", "Job", "Ps", "Prov", "Eccles", "Song", "Is", "Jer", "Lam", "Ezek", "Dan", "Hos", "Joel", "Amos", "Obad", "Jonah", "Mic", "Nah", "Hab", "Zeph", "Hag", "Zech", "Mal", "Matt", "Mark", "Luke", "John", "Acts", "Rom", "1Cor", "2Cor", "Gal", "Eph", "Phil", "Col", "1Thess", "2Thess", "1Tim", "2Tim", "Titus", "Philem", "Heb", "James", "1Pet", "2Pet", "1John", "2John", "3John", "Jude", "Rev" };

        //string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\BBB", "*.txt", SearchOption.AllDirectories);

        //Debug.Log(string.Format("CollectAllFiles.Length {0}", CollectAllFiles.Length));

        //string newFile = string.Empty;

        //for (int i = 0; i < CollectAllFiles.Length; i++)
        //{
        //    //string oldFile = Path.GetFileName(CollectAllFiles[i]);
        //    //Debug.Log(string.Format("oldFile {0}", oldFile));

        //    for (int j = 0; j < Englishkeywords.Length; j++)
        //    {
        //        if (CollectAllFiles[i].Contains(Englishkeywords[j]))
        //        {
        //            newFile = CollectAllFiles[i].Replace(Englishkeywords[j], Koreankeywords[j]);
        //        }
        //    }

        //    // newFile = @"c:\Bible\BBB\" + "개역한글_" + oldFile;
        //    Debug.Log(string.Format("newFile {0}", newFile));

        //    System.IO.File.Copy(CollectAllFiles[i], newFile);

        //    //string oldFile = Path.GetFileName(CollectAllFiles[i]);
        //    //Debug.Log(string.Format("oldFile {0}", oldFile));

        //    //for (int j = 0; j < Englishkeywords.Length; j++)
        //    //{
        //    //    if (oldFile.Contains(Englishkeywords[j]))
        //    //    {
        //    //        newFile = Englishkeywords[j].Replace(Englishkeywords[j], Koreankeywords[j]);
        //    //    }
        //    //}

        //    //// newFile = @"c:\Bible\BBB\" + "개역한글_" + oldFile;
        //    //Debug.Log(string.Format("newFile {0}", newFile));

        //    //System.IO.File.Copy(CollectAllFiles[i], newFile);
        //}
    }

    /// <summary>
    /// 성경파일이름의 한글을 영어로 변경
    /// </summary>
    public static void CopyFilesWithKoreanToEnglish()
    {
        string[] Koreankeywords = { "창", "출", "레", "민", "신", "수", "삿", "룻", "삼상", "삼하", "왕상", "왕하", "대상", "대하", "스", "느", "에", "욥", "시", "잠", "전", "아", "사", "렘", "애", "겔", "단", "호", "욜", "암", "옵", "욘", "미", "나", "합", "습", "학", "슥", "말", "마", "막", "눅", "요", "행", "롬", "고전", "고후", "갈", "엡", "빌", "골", "살전", "살후", "딤전", "딤후", "딛", "몬", "히", "약", "벧전", "벧후", "요일", "요이", "요삼", "유", "계" };
        string[] Englishkeywords = { "Gen", "Ex", "Lev", "Num", "Deut", "Josh", "Judg", "Ruth", "1Sam", "2Sam", "1Kin", "2Kin", "1Chr", "2Chr", "Ezra", "Neh", "Esther", "Job", "Ps", "Prov", "Eccles", "Song", "Is", "Jer", "Lam", "Ezek", "Dan", "Hos", "Joel", "Amos", "Obad", "Jonah", "Mic", "Nah", "Hab", "Zeph", "Hag", "Zech", "Mal", "Matt", "Mark", "Luke", "John", "Acts", "Rom", "1Cor", "2Cor", "Gal", "Eph", "Phil", "Col", "1Thess", "2Thess", "1Tim", "2Tim", "Titus", "Philem", "Heb", "James", "1Pet", "2Pet", "1John", "2John", "3John", "Jude", "Rev" };
        int[] chapterCount = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4, 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };

        string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\DDD", "*.txt", SearchOption.AllDirectories); // c:\Bible\DDD 폴더에 있는 모든 파일들을 가져옵니다. 
        string newFile = string.Empty;

        for (int i = 0; i < CollectAllFiles.Length; i++) // c:\Bible\DDD 폴더에 있는 모든 파일들을 대상으로 반복문 처리합니다. 
        {
            string oldFile = Path.GetFileName(CollectAllFiles[i]); // 파일 이름을 가져옵니다. 

            for (int j = 0; j < Koreankeywords.Length; j++) // 엑셀파일에 파일들의 이름의 한글로 되어 있습니다. 표준새번역_마, KJV_마
            {
                if (oldFile.Contains(Koreankeywords[j])) newFile = oldFile.Replace(Koreankeywords[j], Englishkeywords[j]); // 파일이름의 영어를 한글로 변경해 줍니다. 
            }

            newFile = @"c:\Bible\EEE\" + newFile; // 저장될 파일 위치입니다. 
            System.IO.File.Copy(CollectAllFiles[i], newFile); // 이름이 변경된 파일을 c:\Bible\EEE\ 폴더에 카피해 줍니다. 
        }





        //string[] Koreankeywords = { "창", "출", "레", "민", "신", "수", "삿", "룻", "삼상", "삼하", "왕상", "왕하", "대상", "대하", "스", "느", "에", "욥", "시", "잠", "전", "아", "사", "렘", "애", "겔", "단", "호", "욜", "암", "옵", "욘", "미", "나", "합", "습", "학", "슥", "말", "마", "막", "눅", "요", "행", "롬", "고전", "고후", "갈", "엡", "빌", "골", "살전", "살후", "딤전", "딤후", "딛", "몬", "히", "약", "벧전", "벧후", "요일", "요이", "요삼", "유", "계" };
        //string[] Englishkeywords = { "Gen", "Ex", "Lev", "Num", "Deut", "Josh", "Judg", "Ruth", "1Sam", "2Sam", "1Kin", "2Kin", "1Chr", "2Chr", "Ezra", "Neh", "Esther", "Job", "Ps", "Prov", "Eccles", "Song", "Is", "Jer", "Lam", "Ezek", "Dan", "Hos", "Joel", "Amos", "Obad", "Jonah", "Mic", "Nah", "Hab", "Zeph", "Hag", "Zech", "Mal", "Matt", "Mark", "Luke", "John", "Acts", "Rom", "1Cor", "2Cor", "Gal", "Eph", "Phil", "Col", "1Thess", "2Thess", "1Tim", "2Tim", "Titus", "Philem", "Heb", "James", "1Pet", "2Pet", "1John", "2John", "3John", "Jude", "Rev" };

        //string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\BBB", "*.txt", SearchOption.AllDirectories);

        //Debug.Log(string.Format("CollectAllFiles.Length {0}", CollectAllFiles.Length));

        //string newFile = string.Empty;

        //for (int i = 0; i < CollectAllFiles.Length; i++)
        //{
        //    //string oldFile = Path.GetFileName(CollectAllFiles[i]);
        //    //Debug.Log(string.Format("oldFile {0}", oldFile));

        //    for (int j = 0; j < Englishkeywords.Length; j++)
        //    {
        //        if (CollectAllFiles[i].Contains(Englishkeywords[j]))
        //        {
        //            newFile = CollectAllFiles[i].Replace(Englishkeywords[j], Koreankeywords[j]);
        //        }
        //    }

        //    // newFile = @"c:\Bible\BBB\" + "개역한글_" + oldFile;
        //    Debug.Log(string.Format("newFile {0}", newFile));

        //    System.IO.File.Copy(CollectAllFiles[i], newFile);

        //    //string oldFile = Path.GetFileName(CollectAllFiles[i]);
        //    //Debug.Log(string.Format("oldFile {0}", oldFile));

        //    //for (int j = 0; j < Englishkeywords.Length; j++)
        //    //{
        //    //    if (oldFile.Contains(Englishkeywords[j]))
        //    //    {
        //    //        newFile = Englishkeywords[j].Replace(Englishkeywords[j], Koreankeywords[j]);
        //    //    }
        //    //}

        //    //// newFile = @"c:\Bible\BBB\" + "개역한글_" + oldFile;
        //    //Debug.Log(string.Format("newFile {0}", newFile));

        //    //System.IO.File.Copy(CollectAllFiles[i], newFile);
        //}
    }
    /// <summary>
    /// 성경파일의 내용에 공백이 있다면 공백을 없애주고 저장
    /// </summary>
    public static void RemoveTheSpace()
    {
        // c:\Bible\AAA 폴더의 모든 파일들을 가져옵니다. 
        string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\AAA", "*.txt", SearchOption.TopDirectoryOnly);

        string outputFilePath = string.Empty;

        List<string> collectKorean = new List<string>();
        // 모든 파일들을 대상으로 반복문 처리합니다. 
        for (int k = 0; k < CollectAllFiles.Length; k++)
        {
            // 파일의 내용을 문자열로 저장합니다. 
            string textValue = System.IO.File.ReadAllText(CollectAllFiles[k]);
            // 파일의 이름을 경로는 무시하고 파일이름만 가져옵니다. 
            string fileName = Path.GetFileName(CollectAllFiles[k]);
            // 저장될 파일 이름입니다. 
            outputFilePath = @"c:\Bible\BBB\" + fileName;
            // 파일의 내용이 저장된 문자열을 '\n'로 분리해서 collectKorean리스트에 저장합니다. 
            collectKorean = new List<string>(textValue.Split('\n'));

            Debug.Log("collectKorean.Count : " + collectKorean.Count);
            // 파일을 저장할 준비를 합니다. 
            StreamWriter writer = new StreamWriter(outputFilePath);
            // collectKorean리스트를 대상으로 반복문 처리합니다. 
            for (int i = 0; i < collectKorean.Count; i++)
            {
                // collectKorean리스트의 요소를 파일에 저장하고 앞뒤 공백이 있다면 없애 줍니다. 
                writer.WriteLine(collectKorean[i].Trim());
            }

            writer.Close();
        }






        //string textA = @"c:\Bible\AAA\영단어004C.txt";

        //string textValueA = System.IO.File.ReadAllText(textA);
        //List<string> collectEnglishA = new List<string>(textValueA.Split('\n'));

        //// int[] range = { 0, 200, 400, 600, 800, 1000, 1200, 1400, 1600, 1800, 2000, 2200, 2400, 2600, 2800, 3000, 3200, 3400, 3600, 3800, 4000, 4200, 4400, 4600, 4800, 5000, 5200, 5400, 5600, 5800, 5998};
        //// int[] range = { 0, 200, 400, 600, 800, 1000, 1200, 1400, 1600, 1800, 2000, 2200, 2400, 2600, 2800, 3000, 3200, 3400, 3600, 3800, 4000, 4200, 4400, 4574 };
        //int[] range = { 0, 200, 400, 600, 800, 1000, 1200, 1400, 1600, 1800, 2000, 2200, 2400, 2444};

        //int startIndex = 0;
        //int endIndex = 1;

        //for (int i = 0; i < range.Length; i++)
        //{
        //    string outputFilePathA = @"c:\Bible\BBB\영단어004C" + i + ".txt";
        //    List<string> collectAll = new List<string>();


        //    for (int j = range[startIndex]; j < range[endIndex]; j++)
        //    {
        //        collectAll.Add(collectEnglishA[j]);
        //    }

        //    StreamWriter writer = new StreamWriter(outputFilePathA);

        //    for (int j = 0; j < collectAll.Count; j++)
        //    {
        //        writer.WriteLine(collectAll[j].TrimEnd());
        //    }

        //    writer.Close();

        //    startIndex++;
        //    endIndex++;
        //}



        //string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\AAA", "*.txt", SearchOption.AllDirectories);

        //for (int k = 0; k < CollectAllFiles.Length; k++)
        //{
        //    string fileName = Path.GetFileName(CollectAllFiles[k]);
        //    string outputFilePath = @"c:\Bible\BBB\" + fileName;

        //    string textValue = System.IO.File.ReadAllText(CollectAllFiles[k]);

        //    List<string> collectKorean = new List<string>(textValue.Split('\n'));
        //    List<string> collectKoreanModify = new List<string>();

        //    Debug.Log("collectKorean.Count : " + collectKorean.Count);

        //    for (int i = 0; i < collectKorean.Count; i++)
        //    {
        //        collectKoreanModify.Add(collectKorean[i]);                        
        //    }

        //    Debug.Log("collectKoreanModify.Count : " + collectKoreanModify.Count);

        //    StreamWriter writer = new StreamWriter(outputFilePath);

        //    for (int i = 0; i < collectKoreanModify.Count; i++)
        //    {
        //        writer.WriteLine(collectKoreanModify[i].Trim());
        //        // writer.WriteLine(collectKoreanModify[i]);
        //    }

        //    writer.Close();
        //}



        //string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\AAA", "*.txt", SearchOption.AllDirectories);

        //for (int k = 0; k < CollectAllFiles.Length; k++)
        //{
        //    string fileName = Path.GetFileName(CollectAllFiles[k]);
        //    string outputFilePath = @"c:\Bible\BBB\" + fileName;

        //    string textValue = System.IO.File.ReadAllText(CollectAllFiles[k]);

        //    List<string> collectKorean = new List<string>(textValue.Split('\n'));
        //    List<string> collectKoreanModify = new List<string>();

        //    for (int i = 0; i < collectKorean.Count; i = i + 2)
        //    {
        //        //if (i % 2 == 0)
        //        //    continue;

        //        collectKoreanModify.Add(collectKorean[i]);
        //    }

        //    StreamWriter writer = new StreamWriter(outputFilePath);

        //    for (int i = 0; i < collectKoreanModify.Count; i++)
        //    {
        //        writer.WriteLine(collectKoreanModify[i].TrimEnd());
        //    }

        //    writer.Close();
        //}



        //string textA = @"c:\Bible\AAA\영단어B영어_001A.txt";
        //string textB = @"c:\Bible\AAA\영단어B한글_001A.txt";

        //string outputFilePathA = @"c:\Bible\BBB\" + "TextC.txt";

        //string textValueA = System.IO.File.ReadAllText(textA);
        //List<string> collectEnglishA = new List<string>(textValueA.Split('\n'));
        //string textValueB = System.IO.File.ReadAllText(textB);
        //List<string> collectEnglishB = new List<string>(textValueB.Split('\n'));

        //List<string> collectAll = new List<string>();

        //for (int i = 0; i < collectEnglishA.Count; i++)
        //{
        //    collectAll.Add(collectEnglishA[i]);
        //    collectAll.Add(collectEnglishB[i]);
        //}

        //StreamWriter writer = new StreamWriter(outputFilePathA);

        //for (int i = 0; i < collectAll.Count; i++)
        //{
        //    writer.WriteLine(collectAll[i].TrimEnd());
        //}

        //writer.Close();

        //string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\AAA", "*.txt", SearchOption.AllDirectories);

        //for (int k = 0; k < CollectAllFiles.Length; k++)
        //{
        //    string fileName = Path.GetFileName(CollectAllFiles[k]);
        //    string outputFilePath = @"c:\Bible\BBB\" + fileName;

        //    string textValue = System.IO.File.ReadAllText(CollectAllFiles[k]);

        //    List<string> collectKorean = new List<string>(textValue.Split('\n'));
        //    List<string> collectKoreanModify = new List<string>();

        //    for (int i = 0; i < collectKorean.Count - 1; i++)
        //    {
        //        if (!collectKorean[i].StartsWith(" "))
        //            collectKoreanModify.Add(collectKorean[i]);
        //    }

        //    StreamWriter writer = new StreamWriter(outputFilePath);

        //    for (int i = 0; i < collectKoreanModify.Count; i++)
        //    {
        //        writer.WriteLine(collectKoreanModify[i].TrimEnd());
        //    }

        //    writer.Close();
        //}



        //string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\AAA", "*.txt", SearchOption.AllDirectories);

        //for (int k = 0; k < CollectAllFiles.Length; k++)
        //{
        //    string fileName = Path.GetFileName(CollectAllFiles[k]);
        //    string outputFilePath = @"c:\Bible\BBB\" + fileName;

        //    string textValue = System.IO.File.ReadAllText(CollectAllFiles[k]);

        //    List<string> collectKorean = new List<string>(textValue.Split('\n'));
        //    List<string> collectKoreanModify = new List<string>();

        //    for (int i = 0; i < collectKorean.Count - 1; i++)
        //    {
        //        string[] ModifyA = collectKorean[i].Split(".  ");
        //        if (ModifyA.Length > 1)
        //        {
        //            collectKoreanModify.Add(ModifyA[1]);
        //        }

        //        string[] ModifyB = collectKorean[i].Split(". ");
        //        if (ModifyB.Length > 1)
        //        {
        //            collectKoreanModify.Add(ModifyB[1]);
        //        }
        //    }

        //    StreamWriter writer = new StreamWriter(outputFilePath);

        //    for (int i = 0; i < collectKoreanModify.Count; i++)
        //    {
        //        writer.WriteLine(collectKoreanModify[i].TrimEnd());
        //    }

        //    writer.Close();
        //}
    }

    /// <summary>
    /// 1. 한글이 보이도록 UTF8로 저장하기
    /// </summary>
    public static void SaveUTF8()
    {
        // c:\Bible\AAA 폴더에 있는 파일들을 모두 가져옵니다. 
        string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\AAA", "*.txt", SearchOption.AllDirectories);
        // 유니티에서 Resources의 특정 폴더에 있는 파일들을 모두 가져옵니다. 
        // TextAsset[] CollectAllFiles = Resources.LoadAll<TextAsset>("ModernManBible/");
        
        for (int i = 0; i < CollectAllFiles.Length; i++) // 파일들을 대상으로 반복문 처리합니다. 
        {
            string fileName = Path.GetFileName(CollectAllFiles[i]); // 경로를 빼고 파일의 이름을 가져옵니다. 
            
            string outputFilePath = @"c:\Bible\BBB\" + fileName; // c:\Bible\BBB\ 폴더에 저장될 파일 이름입니다. 

            // string[] inputArr = File.ReadAllLines(CollectAllFiles[i], Encoding.UTF8);
            // 폴더에 있는 파일의 내용을 UTF8로 인코딩해서 가져옵니다. 
            string[] inputArr = File.ReadAllLines(CollectAllFiles[i], Encoding.GetEncoding("euc-kr"));
            List<string> inputList = new List<string>(inputArr); // UTF8로 인코딩한 것을 리스트에 저장합니다. 
            List<string> outputList = new List<string>();

            inputList.ForEach(x => outputList.Add(string.Format("{0}", x)));
            
            File.WriteAllLines(outputFilePath, outputList, Encoding.UTF8); // 파일을 저장합니다. 
        }
    }

    /// <summary>
    /// 언리얼을 위해서 CSV파일로 저장해 줍니다. 
    /// </summary>
    public static void SaveCSV()
    {
        // c:\Bible\AAA의 모든 파일들을 가져옵니다. 
        string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\AAA", "*.txt", SearchOption.AllDirectories);
        // 모든 파일들을 대상으로 반복문 처리합니다. 
        for (int k = 0; k < CollectAllFiles.Length; k++)
        {
            // 파일의 경로는 무시하고 파일 이름을 저장합니다. 
            string fileName = Path.GetFileName(CollectAllFiles[k]);
            string outputFilePath = @"c:\Bible\BBB\" + fileName;
            // 파일의 내용을 문자열로 저장합니다. 
            string textValue = System.IO.File.ReadAllText(CollectAllFiles[k]);
            // 저장된 문자열을 '\n'로 구분해서 collectKorean리스트에 저장합니다. 
            List<string> collectKorean = new List<string>(textValue.Split('\n'));
            List<string> collectKoreanModify = new List<string>();
            // 언리얼에서는 변수에 해당하는 부분이 필요합니다. 변수를 저장해 줍니다. 
            collectKoreanModify.Add("key,message");
            // collectKorean리스트를 대상으로 반복문 처리합니다. collectKorean리스트의 맨 끝의 공백을 포함하지 않습니다. 
            for (int i = 0; i < collectKorean.Count - 1; i++)
            {
                // CSV파일은 ","로 구분됩니다. 문장안에 있는 ","를 "."로 변경해 줍니다. 
                collectKorean[i] = collectKorean[i].Replace(",", ".");
                // 문자열이 ""를 포함하고 있다면? ''로 변경해 줍니다. 
                collectKorean[i] = collectKorean[i].Replace("\"", "'");
                // 인덱스는 0부터 시작하지만 1부터 시작해야 합니다. 
                collectKorean[i] = (i + 1) + "," + collectKorean[i];

                collectKoreanModify.Add(collectKorean[i]);
            }

            StreamWriter writer = new StreamWriter(outputFilePath);

            for (int i = 0; i < collectKoreanModify.Count; i++)
            {
                writer.WriteLine(collectKoreanModify[i].TrimEnd());
            }

            writer.Close();
        }
        // c:\Bible\BBB 폴더에 있는 모든 파일들을 가져옵니다. 
        CollectAllFiles = Directory.GetFiles(@"c:\Bible\BBB", "*.txt", SearchOption.AllDirectories);
        // 모든 파일들을 대상으로 반복문 처리합니다. 
        for (int i = 0; i < CollectAllFiles.Length; i++)
        {
            // 파일에서 경로와 확장자는 무시하고 파일 이름을 가져옵니다. 
            string fileName = Path.GetFileNameWithoutExtension(CollectAllFiles[i]);
            // 최종 저장될 csv파일 이름입니다. 
            string outputFilePath = @"c:\Bible\CCC\" + fileName + ".csv";
            // csv파일로 카피해 줍니다. 
            System.IO.File.Copy(CollectAllFiles[i], outputFilePath);
        }
    }

    // public static int intCount = 0;

    public static void ConvertOver200Characters()
    {
        // 결과를 저장할 폴더입니다. 
        string BibleName = "NIV";

        string folderPath = @"C:\Bible\" + BibleName + @"\";
        DirectoryInfo di = new DirectoryInfo(folderPath);

        if (di.Exists == false) di.Create(); // 만약 폴더가 존재하지 않으면

        string[] Koreankeywords = { "창", "출", "레", "민", "신", "수", "삿", "룻", "삼상", "삼하", "왕상", "왕하", "대상", "대하", "스", "느", "에", "욥", "시", "잠", "전", "아", "사", "렘", "애", "겔", "단", "호", "욜", "암", "옵", "욘", "미", "나", "합", "습", "학", "슥", "말", "마", "막", "눅", "요", "행", "롬", "고전", "고후", "갈", "엡", "빌", "골", "살전", "살후", "딤전", "딤후", "딛", "몬", "히", "약", "벧전", "벧후", "요일", "요이", "요삼", "유", "계" };
        string[] keywords = { "Gen", "Ex", "Lev", "Num", "Deut", "Josh", "Judg", "Ruth", "1Sam", "2Sam", "1Kin", "2Kin", "1Chr", "2Chr", "Ezra", "Neh", "Esther", "Job", "Ps", "Prov", "Eccles", "Song", "Is", "Jer", "Lam", "Ezek", "Dan", "Hos", "Joel", "Amos", "Obad", "Jonah", "Mic", "Nah", "Hab", "Zeph", "Hag", "Zech", "Mal", "Matt", "Mark", "Luke", "John", "Acts", "Rom", "1Cor", "2Cor", "Gal", "Eph", "Phil", "Col", "1Thess", "2Thess", "1Tim", "2Tim", "Titus", "Philem", "Heb", "James", "1Pet", "2Pet", "1John", "2John", "3John", "Jude", "Rev" };
        int[] chapterCount = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4, 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };

        
        TextAsset[] EasyBible = Resources.LoadAll<TextAsset>(BibleName + "/");


        

        for (int j = 0; j < EasyBible.Length; j++)
        {
            List<string> EasyBibleList = new List<string>(EasyBible[j].text.Split('\n'));
            string BibleNameWithOut = Path.GetFileNameWithoutExtension(EasyBible[j].name);
            StreamWriter streamWriter = new StreamWriter(folderPath + BibleNameWithOut + ".txt", true);

            for (int i = 0; i < EasyBibleList.Count - 1; i++)
            {
                if (EasyBibleList[i].Length >= 200)
                {
                    List<string> tmepCollection = new List<string>();
                    tmepCollection = ReturnOver200Characters(EasyBibleList[i]);
                    string tempString = string.Empty;

                    if (tmepCollection.Count >= 2)
                    {
                        tempString += (tmepCollection[0].TrimEnd() + " #");
                        tempString += tmepCollection[1].TrimEnd();

                        streamWriter.WriteLine(tempString);
                    }
                }
                else if (EasyBibleList[i].Length < 200)
                {
                    streamWriter.WriteLine(EasyBibleList[i].TrimEnd());
                }
            }
            streamWriter.Close();
        }
        

        //TextAsset textFile; // 한글 성경 TextAsset을 저장할 변수입니다. 
        //List<string> result = new List<string>();

        //textFile = Resources.Load(bibleName) as TextAsset;

        //result.Clear();
        //StringReader stringReader = new StringReader(textFile.text); // textFile의 내용을 stringReader에 저장합니다. 

        //while (stringReader.Peek() >= 0) // stringReader에 저장되어 있는 문자열이 끝이 아닐 때까지 반복합니다. 
        //{
        //    // string temp = stringReader.ReadLine(); 
        //    result.Add(stringReader.ReadLine()); // 결과 리스트에 저장해 줍니다. 
        //}
        //stringReader.Close();

        //string path = @"c:\Bible\"; // 저장될 경로입니다. 
        //StreamWriter streamWriter = new StreamWriter(path + bibleName + ".txt", true); // 파일을 저장할 준비를 합니다. 

        //for (int j = 0; j < result.Count; j++)
        //    if (result[j].Length >= 200) streamWriter.WriteLine(result[j]); // 결과 리스트를 파일에 저장합니다. 

        //streamWriter.Close();
    }

    public static List<string> ReturnOver200Characters(string sourceString)
    {
        List<string> CollectResult = new List<string>();
        List<string> tempA = new List<string>(sourceString.Split(' '));
        List<string> tempB = new List<string>();

        for (int i = 0; i < tempA.Count; i++)
        {
            // if (tempA[i].Contains(".") || tempA[i].Contains(",") || tempA[i].Contains("and"))
            if (tempA[i].Contains(".") || tempA[i].Contains(",") || tempA[i].Contains(";") || tempA[i].Contains(":") || tempA[i].Contains("and"))
                tempB.Add(tempA[i]);
        }

        int keyIndex = 0;
        int checkIndex = 0;

        string resultA = string.Empty;
        string resultB = string.Empty;

        for (int i = 1; i < tempB.Count; i++)
        {
            keyIndex = sourceString.IndexOf(tempB[i]);
            resultA = sourceString.Substring(0, keyIndex);

            if (resultA.Length >= 150) break;
            else checkIndex = i;
        }

        keyIndex = sourceString.IndexOf(tempB[checkIndex]);
        resultA = sourceString.Substring(0, (keyIndex + tempB[checkIndex].Length));
        resultB = sourceString.Substring((keyIndex + tempB[checkIndex].Length));

        int resultACount = resultA.Length;
        int resultBCount = resultB.Length;

        CollectResult.Add(resultA);
        CollectResult.Add(resultB);

        return CollectResult;
    }

    public static List<string> ReturnOver200CharactersResult(string source)
    {

        List<string> ResultAll = new List<string>();
        List<string> TempAllA = new List<string>();
        List<string> TempAllB = new List<string>();
        List<string> TempAllC = new List<string>();

        if (source.Length >= 200)
        {

            ResultAll.Clear();
            TempAllA = ReturnOver200Characters(source);
            ResultAll.Add(TempAllA[0]);
            ResultAll.Add(TempAllA[1]);
        }
        if (ResultAll.Count == 2 && TempAllA[1].Length >= 200)
        {
            ResultAll.Clear();
            TempAllB = ReturnOver200Characters(TempAllA[1]);
            ResultAll.Add(TempAllA[0]);
            ResultAll.Add(TempAllB[0]);
            ResultAll.Add(TempAllB[1]);
        }
        if (ResultAll.Count == 3 && TempAllB.Count == 2 && TempAllB[1].Length >= 200)
        {
            ResultAll.Clear();
            TempAllC = ReturnOver200Characters(TempAllB[1]);
            ResultAll.Add(TempAllA[0]);
            ResultAll.Add(TempAllB[0]);
            ResultAll.Add(TempAllC[0]);
            ResultAll.Add(TempAllC[1]);
        }

        List<int> CollectIntCount = new List<int>();

        for (int i = 0; i < ResultAll.Count; i++)
            CollectIntCount.Add(ResultAll[i].Length);

        Debug.Log(string.Empty);
        return ResultAll;
    }

    /// <summary>
    /// 2. 성경TXT파일을 각 장으로 나누기
    /// </summary>
    public static void ConvertBibleEach(string bibleName, bool isNewTestament)
    {
        TextAsset textFile; // 한글 성경 TextAsset을 저장할 변수입니다. 
        List<string> result = new List<string>();

        string[] keywordsNew = {
                "Matthew", "Mark", "Luke", "John", "Acts", "Romans", "1Corinthians", "2Corinthians", "Galatians", "Ephesians", "Philippians", "Colossians",
                "1Thessalonians", "2Thessalonians", "1Timothy", "2Timothy", "Titus", "Philemon", "Hebrews", "James", "1Peter", "2Peter", "1John", "2John", "3John", "Jude", "Revelation" };

        string[] keywordsOld = {"Genesis", "Exodus", "Leviticus", "Numbers", "Deuteronomy", "Joshua", "Judges", "Ruth", "1Samuel", "2Samuel", "1Kings", "2Kings",
                "1Chronicles", "2Chronicles", "Ezra", "Nehemiah", "Esther", "Job", "Psalms", "Proverbs", "Ecclesiastes", "SongOfSongs", "Isaiah", "Jeremiah",
                "Lamentations", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos", "Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi",};

        int[] chapterCountNew = { 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };

        int[] chapterCountOld = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4};


        if (isNewTestament)
        {
            for (int m = 0; m < keywordsNew.Length; m++) // 한글 키워드를 대상으로 반복문 처리합니다. 
            {
                // Resources폴더에서 성경이름을 가져와서 한글 성경 TextAsset에 저장합니다. 
                textFile = Resources.Load("ETC/" + bibleName) as TextAsset;

                for (int i = 0; i < chapterCountNew[m]; i++) // 성경의 각 챕터들을 저장해둔 배열을 대상으로 반복문 처리합니다. 
                {
                    result.Clear();
                    StringReader stringReader = new StringReader(textFile.text); // textFile의 내용을 stringReader에 저장합니다. 

                    while (stringReader.Peek() >= 0) // stringReader에 저장되어 있는 문자열이 끝이 아닐 때까지 반복합니다. 
                    {
                        string temp = stringReader.ReadLine(); // stringReader에서 라인을 읽어 옵니다. 
                                                               // 만일 stringReader에서 읽어온 문자열이 "창1:"로 시작한다면? 
                                                               // 라인번호는 첫번째인데. 리스트의 문자열은 0부터 시작하므로 1이 되게 해 줍니다. 
                        if (temp.StartsWith(keywordsNew[m] + "" + (i + 1) + ":")) result.Add(temp); // 결과 리스트에 저장해 줍니다. 
                    }
                    stringReader.Close();

                    string path = @"c:\Bible\DDD\"; // 저장될 경로입니다. 
                    StreamWriter streamWriter = new StreamWriter(path + bibleName + "_" + keywordsNew[m] + (i + 1) + ".txt"); // 파일을 저장할 준비를 합니다. 

                    for (int j = 0; j < result.Count; j++) streamWriter.WriteLine(result[j]); // 결과 리스트를 파일에 저장합니다. 

                    streamWriter.Close();
                }
            }
        }
        else
        {
            for (int m = 0; m < keywordsOld.Length; m++) // 한글 키워드를 대상으로 반복문 처리합니다. 
            {
                // Resources폴더에서 성경이름을 가져와서 한글 성경 TextAsset에 저장합니다. 
                textFile = Resources.Load("ETC/" + bibleName) as TextAsset;

                for (int i = 0; i < chapterCountOld[m]; i++) // 성경의 각 챕터들을 저장해둔 배열을 대상으로 반복문 처리합니다. 
                {
                    result.Clear();
                    StringReader stringReader = new StringReader(textFile.text); // textFile의 내용을 stringReader에 저장합니다. 

                    while (stringReader.Peek() >= 0) // stringReader에 저장되어 있는 문자열이 끝이 아닐 때까지 반복합니다. 
                    {
                        string temp = stringReader.ReadLine(); // stringReader에서 라인을 읽어 옵니다. 
                                                               // 만일 stringReader에서 읽어온 문자열이 "창1:"로 시작한다면? 
                                                               // 라인번호는 첫번째인데. 리스트의 문자열은 0부터 시작하므로 1이 되게 해 줍니다. 
                        if (temp.StartsWith(keywordsOld[m] + "" + (i + 1) + ":")) result.Add(temp); // 결과 리스트에 저장해 줍니다. 
                    }
                    stringReader.Close();

                    string path = @"c:\Bible\DDD\"; // 저장될 경로입니다. 
                    StreamWriter streamWriter = new StreamWriter(path + bibleName + "_" + keywordsOld[m] + (i + 1) + ".txt"); // 파일을 저장할 준비를 합니다. 

                    for (int j = 0; j < result.Count; j++) streamWriter.WriteLine(result[j]); // 결과 리스트를 파일에 저장합니다. 

                    streamWriter.Close();
                }
            }
        }
    }

    /// <summary>
    /// 영어 성경TXT파일을 각 장으로 나누기
    /// </summary>
    /// <param name="bibleName"></param>
    public static void ConvertBibleEachEnglish(string bibleName)
    {
        // 영어 성경의 파일 이름은 Gen1:으로 시작할 수도 있고, Gen.1:으로 시작할 수도 있습니다. 영어 성경 TextAsset을 저장할 변수입니다. 
        TextAsset textFile;
        List<string> result = new List<string>();

        string[] keywords = { "Gen", "Ex", "Lev", "Num", "Deut", "Josh", "Judg", "Ruth", "1Sam", "2Sam", "1Kin", "2Kin", "1Chr", "2Chr", "Ezra", "Neh", "Esther", "Job", "Ps", "Prov", "Eccles", "Song", "Is", "Jer", "Lam",  "Ezek", "Dan", "Hos", "Joel", "Amos", "Obad", "Jonah", "Mic", "Nah", "Hab", "Zeph", "Hag", "Zech", "Mal", "Matt", "Mark", "Luke", "John", "Acts", "Rom", "1Cor", "2Cor", "Gal", "Eph", "Phil", "Col", "1Thess", "2Thess", "1Tim", "2Tim", "Titus", "Philem", "Heb", "James", "1Pet", "2Pet", "1John", "2John", "3John", "Jude", "Rev" };
        int[] chapterCount = { 50,    40,   27,    36,    34,     24,     21,     4,      31,     24,     22,     25,     29,     36,     10,     13,    10,       42,    150,  31,     12,       8,      66,   52,    5,      48,     12,    14,    3,      9,      1,      4,       7,     3,     3,     3,      2,     14,     4,     28,     16,     24,     21,     28,     16,    16,     13,     6,     6,     4,      4,     5,        3,        6,      4,      3,       1,        13,    5,       5,      3,      5,       1,       1,       1,      22 };
        
        for (int m = 0; m < keywords.Length; m++) // 영어 키워드를 대상으로 반복문 처리합니다. 
        {
            textFile = Resources.Load(bibleName) as TextAsset; // Resources폴더에서 성경이름을 가져와서 영어 성경 TextAsset에 저장합니다. 
            
            for (int i = 0; i < chapterCount[m]; i++) // 성경의 각 챕터들을 저장해둔 배열을 대상으로 반복문 처리합니다. 
            {
                result.Clear();
                StringReader stringReader = new StringReader(textFile.text); // textFile의 내용을 stringReader에 저장합니다. 
                
                while (stringReader.Peek() >= 0) // stringReader에 저장되어 있는 문자열이 끝이 아닐 때까지 반복합니다. 
                {
                    string temp = stringReader.ReadLine(); // stringReader에서 라인을 읽어 옵니다.  // Gen1: // Amos9:
                    // 만일 stringReader에서 읽어온 문자열이 "Gen1:"로 시작한다면? 
                    // 라인번호는 첫번째인데. 리스트의 문자열은 0부터 시작하므로 1이 되게 해 줍니다. 
                    if (temp.StartsWith(keywords[m] + (i + 1) + ":")) result.Add(temp); // 결과 리스트에 저장해 줍니다. 
                }

                stringReader.Close();

                if (result.Count > 0)
                {
                    string path = @"c:\Bible\BBB\"; // 저장될 경로입니다. 
                    StreamWriter streamWriter = new StreamWriter(path + bibleName + "_" + keywords[m] + (i + 1) + ".txt"); // 파일을 저장할 준비를 합니다. 

                    for (int j = 0; j < result.Count; j++) streamWriter.WriteLine(result[j]); // 결과 리스트를 파일에 저장합니다. 
                    streamWriter.Close();
                }
            }
        }
        
        for (int m = 0; m < keywords.Length; m++) // 영어 키워드를 대상으로 반복문 처리합니다. 
        {
            textFile = Resources.Load(bibleName) as TextAsset; // Resources폴더에서 성경이름을 가져와서 한글 성경 TextAsset에 저장합니다. 
            
            for (int i = 0; i < chapterCount[m]; i++) // 성경의 각 챕터들을 저장해둔 배열을 대상으로 반복문 처리합니다. 
            {
                result.Clear();
                StringReader stringReader = new StringReader(textFile.text); // textFile의 내용을 stringReader에 저장합니다. 
                
                while (stringReader.Peek() >= 0) // stringReader에 저장되어 있는 문자열이 끝이 아닐 때까지 반복합니다. 
                {
                    string temp = stringReader.ReadLine(); // stringReader에서 라인을 읽어 옵니다.  // Gen.1: // Amos.9:
                    // 만일 stringReader에서 읽어온 문자열이 "Gen.:"로 시작한다면? 
                    // 라인번호는 첫번째인데. 리스트의 문자열은 0부터 시작하므로 1이 되게 해 줍니다. 
                    if (temp.StartsWith(keywords[m] + "." + (i + 1) + ":")) result.Add(temp); // 결과 리스트에 저장해 줍니다. 
                }

                stringReader.Close();

                if (result.Count > 0)
                {
                    string path = @"c:\Bible\BBB\"; // 저장될 경로입니다. 
                    StreamWriter streamWriter = new StreamWriter(path + bibleName + "_" + keywords[m] + (i + 1) + ".txt"); // 파일을 저장할 준비를 합니다. 

                    for (int j = 0; j < result.Count; j++) streamWriter.WriteLine(result[j]); // 결과 리스트를 파일에 저장합니다. 

                    streamWriter.Close();
                }
            }
        }
    }

    /// <summary>
    /// 2. 성경TXT파일을 각 장으로 나누기
    /// </summary>
    public static void ConvertBibleEachA()
    {
        TextAsset textFile; // 한글 성경 TextAsset을 저장할 변수입니다. 

        List<string> result = new List<string>();

        string[] chapters = { "1-01창세기", "1-02출애굽기", "1-03레위기", "1-04민수기", "1-05신명기", "1-06여호수아", "1-07사사기", "1-08룻기", "1-09사무엘상", "1-10사무엘하", "1-11열왕기상", "1-12열왕기하", "1-13역대상", "1-14역대하", "1-15에스라", "1-16느헤미야", "1-17에스더", "1-18욥기", "1-19시편", "1-20잠언", "1-21전도서", "1-22아가", "1-23이사야", "1-24예레미야", "1-25예레미야애가", "1-26에스겔", "1-27다니엘", "1-28호세아", "1-29요엘", "1-30아모스", "1-31오바댜", "1-32요나", "1-33미가", "1-34나훔", "1-35하박국", "1-36스바냐", "1-37학개", "1-38스가랴", "1-39말라기", "2-01마태복음", "2-02마가복음", "2-03누가복음", "2-04요한복음", "2-05사도행전", "2-06로마서", "2-07고린도전서", "2-08고린도후서", "2-09갈라디아서", "2-10에베소서", "2-11빌립보서", "2-12골로새서", "2-13데살로니가전서", "2-14데살로니가후서", "2-15디모데전서", "2-16디모데후서", "2-17디도서", "2-18빌레몬서", "2-19히브리서", "2-20야고보서", "2-21베드로전서", "2-22베드로후서", "2-23요한일서", "2-24요한이서", "2-25요한삼서", "2-26유다서", "2-27요한계시록" };
        string[] keywords = { "창", "출", "레", "민", "신", "수", "삿", "룻", "삼상", "삼하", "왕상", "왕하", "대상", "대하", "스", "느", "에", "욥", "시", "잠", "전", "아", "사", "렘", "애", "겔", "단", "호", "욜", "암", "옵", "욘", "미", "나", "합", "습", "학", "슥", "말", "마", "막", "눅", "요", "행", "롬", "고전", "고후", "갈", "엡", "빌", "골", "살전", "살후", "딤전", "딤후", "딛", "몬", "히", "약", "벧전", "벧후", "요일", "요이", "요삼", "유", "계" };
        int[] chapterCount = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4, 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };

        Debug.Log(string.Format("chapters : {0}, keywords : {1}, chapterCount : {2}", chapters.Length, keywords.Length, chapterCount.Length));
        
        for (int m = 0; m < keywords.Length; m++) // 한글 키워드를 대상으로 반복문 처리합니다. 
        {
            textFile = Resources.Load(chapters[m]) as TextAsset; // Resources폴더에서 chapters리스트의 요소의 성경이름을 가져와서 한글 성경 TextAsset에 저장합니다. 
            
            for (int i = 0; i < chapterCount[m]; i++) // chapters리스트의 요소의 성경의 각 챕터들을 저장해둔 배열을 대상으로 반복문 처리합니다. 
            {
                result.Clear();
                // textFile의 내용을 stringReader에 저장합니다. 
                StringReader stringReader = new StringReader(textFile.text);
                // stringReader에 저장되어 있는 문자열이 끝이 아닐 때까지 반복합니다. 
                while (stringReader.Peek() >= 0)
                {
                    // stringReader에서 라인을 읽어 옵니다. 
                    string temp = stringReader.ReadLine();
                    // 만일 stringReader에서 읽어온 문자열이 "창1:"로 시작한다면? 
                    // 라인번호는 첫번째인데. 리스트의 문자열은 0부터 시작하므로 1이 되게 해 줍니다. 
                    if (temp.StartsWith(keywords[m] + (i + 1) + ":"))
                    {
                        result.Add(temp);
                    }
                }
                stringReader.Close();
                // string path = Application.persistentDataPath + "/";
                string path = @"c://BibleText//path1//";
                StreamWriter streamWriter = new StreamWriter(path + textFile.name + (i + 1) + ".txt");

                for (int j = 0; j < result.Count; j++)
                {
                    streamWriter.WriteLine(result[j]);
                }
                streamWriter.Close();
            }
        }
    }

    /// <summary>
    /// 2. 성경TXT파일을 각 장으로 나누기
    /// </summary>
    public static void ConvertBibleEachAll()
    {
        // 한글 성경 TextAsset을 저장할 변수입니다. 
        TextAsset textFile;

        List<string> result = new List<string>();

        string[] keywords = { "창", "출", "레", "민", "신", "수", "삿", "룻", "삼상", "삼하", "왕상", "왕하", "대상", "대하", "스", "느", "에", "욥", "시", "잠", "전", "아", "사", "렘", "애", "겔", "단", "호", "욜", "암", "옵", "욘", "미", "나", "합", "습", "학", "슥", "말", "마", "막", "눅", "요", "행", "롬", "고전", "고후", "갈", "엡", "빌", "골", "살전", "살후", "딤전", "딤후", "딛", "몬", "히", "약", "벧전", "벧후", "요일", "요이", "요삼", "유", "계" };
        int[] chapterCount = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4, 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };
        string[] biblePath = { "path2", "path3", "path4", "path5", "path6" };
        string[] bibleName = { "개역개정", "개역한글", "공동번역", "표준새번역", "현대인의성경" };

        // bibleName배열을 대상으로 반복문 처리합니다. 
        for (int k = 0; k < bibleName.Length; k++)
        {
            // 한글 키워드를 대상으로 반복문 처리합니다. 
            for (int m = 0; m < keywords.Length; m++)
            {
                // Resources폴더에서 bibleName배열의 요소의 성경이름을 가져와서 한글 성경 TextAsset에 저장합니다. 
                textFile = Resources.Load(bibleName[k]) as TextAsset;
                // 성경의 각 챕터들을 저장해둔 배열을 대상으로 반복문 처리합니다. 
                for (int i = 0; i < chapterCount[m]; i++)
                {
                    result.Clear();
                    // textFile의 내용을 stringReader에 저장합니다. 
                    StringReader stringReader = new StringReader(textFile.text);
                    // stringReader에 저장되어 있는 문자열이 끝이 아닐 때까지 반복합니다. 
                    while (stringReader.Peek() >= 0)
                    {
                        // stringReader에서 라인을 읽어 옵니다. 
                        string temp = stringReader.ReadLine();
                        // 만일 stringReader에서 읽어온 문자열이 "창1:"로 시작한다면? 
                        // 라인번호는 첫번째인데. 리스트의 문자열은 0부터 시작하므로 1이 되게 해 줍니다. 
                        if (temp.StartsWith(keywords[m] + (i + 1) + ":"))
                        {
                            // 결과 리스트에 저장해 줍니다. 
                            result.Add(temp);
                        }
                    }
                    stringReader.Close();
                    // 저장될 경로입니다. 
                    string path = @"c://BibleText//";
                    // 파일을 저장할 준비를 합니다. 
                    StreamWriter streamWriter = new StreamWriter(path + bibleName[k] + "_" + keywords[m] + (i + 1) + ".txt");

                    for (int j = 0; j < result.Count; j++)
                    {
                        // 결과 리스트를 파일에 저장합니다. 
                        streamWriter.WriteLine(result[j]);
                    }

                    streamWriter.Close();
                }
            }
        }
    }

    /// <summary>
    /// 5. 성경TXT파일 이름 변경
    /// </summary>
    public static void RenameFiles()
    {
        // c:\aaa\bbb 폴더에 있는 모든 파일들을 가져옵니다. 
        string[] CollectAllFiles = Directory.GetFiles(@"c:\aaa\bbb", "*.txt", SearchOption.AllDirectories);

        Debug.Log(string.Format("CollectAllFiles.Length {0}", CollectAllFiles.Length));
        // 가져온 파일들을 대상으로 반복문 처리합니다. 
        for (int i = 0; i < CollectAllFiles.Length; i++)
        {
            // 파일을 경로는 무시하고 파일 이름을 가져옵니다. 
            string oldFile = Path.GetFileName(CollectAllFiles[i]);
            Debug.Log(string.Format("oldFile {0}", oldFile));
            // 파일 이름을 변경해 줍니다. 
            string newFile = @"c:\aaa\ccc\" + "개역한글_" + oldFile;
            Debug.Log(string.Format("newFile {0}", newFile));
            // 변경된 파일 이름을 복사해 줍니다. 
            System.IO.File.Copy(CollectAllFiles[i], newFile);
        }
    }
    /// <summary>
    /// Youtube 자막파일에서 특정 문자열 제거
    /// </summary>
    public static void RenameFilesA()
    {
        string search1 = @"[Korean (auto-generated)] [DownloadYoutubeSubtitles.com]";
        string search2 = @"[Korean (auto-generated)] [GetSubs.cc]";

        // D:\Bible\Info\Append\ 폴더에 있는 모든 파일들을 가져옵니다. 
        string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\Info\Append\", "*.txt", SearchOption.AllDirectories);
        
        for (int i = 0; i < CollectAllFiles.Length; i++) // 가져온 파일들을 대상으로 반복문 처리합니다. 
        {
            string result;
            string oldFile = Path.GetFileNameWithoutExtension(CollectAllFiles[i]);
            // 필요없는 문장을 파일 이름에서 없애줍니다. 
            if (oldFile.Contains(search1.ToString())) result = oldFile.Replace(search1.ToString(), "");
            else if (oldFile.Contains(search2.ToString())) result = oldFile.Replace(search2.ToString(), "");
            else result = oldFile; // 변경해 줄 것이 없다면 원래 이름으로 합니다. 

            string newFile = @"c:\Bible\Info\AppendA\" + result + ".txt"; // 파일 이름을 변경해 줍니다. 
            System.IO.File.Copy(CollectAllFiles[i], newFile, true); // 변경된 파일 이름을 복사해 줍니다. 
        }
    }

    /// <summary>
    /// 4. 1 도 없애주기
    /// </summary>
    public static void Remove1()
    {
        
    }

    /// <summary>
    /// 4. 1 도 없애주기
    /// </summary>
    public static void Remove1Other()
    {
        // c:\Bible\CCC 폴더의 파일들을 모두 가져옵니다. 
        string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\DDD", "*.txt", SearchOption.AllDirectories);
        // 폴더에 있는 파일들을 대상으로 반복문 처리합니다. 
        for (int k = 0; k < CollectAllFiles.Length; k++)
        {
            // 파일의 경로는 무시하고 파일이름을 가져옵니다. 
            string fileName = Path.GetFileName(CollectAllFiles[k]);
            // 저장될 파일 이름입니다. 
            string outputFilePath = @"c:\Bible\EEE\" + fileName;
            // 파일을 읽어서 문자열로 저장합니다. 
            string textValue = System.IO.File.ReadAllText(CollectAllFiles[k]);
            // 문자열을 '\n'으로 분리해서 collectKorean리스트에 저장합니다. 
            List<string> collectKorean = new List<string>(textValue.Split('\n'));
            List<string> collectKoreanModify = new List<string>();

            List<string> result = new List<string>();
            // collectKorean리스트를 대상으로 반복문 처리합니다. 
            for (int i = 0; i < collectKorean.Count; i++)
            {
                // collectKorean리스트의 요소를 임시변수에 저장합니다. 
                string temp = collectKorean[i];
                string tempA = string.Empty;

                {
                    // 최대로 있을 수 있는 장이 시150입니다. 
                    // 만일 임시변수가 "1 "으로 시작한다면? 
                    if (temp.StartsWith("1 "))
                    {
                        // 임수변수의 "1 "를 ""으로 변경해서 tempA임시변수에 저장합니다. 
                        tempA = temp.Replace("1 ", "");
                        // 결과를 result리스트에 저장합니다. 
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("2 "))
                    {
                        tempA = temp.Replace("2 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("3 "))
                    {
                        tempA = temp.Replace("3 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("4 "))
                    {
                        tempA = temp.Replace("4 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("5 "))
                    {
                        tempA = temp.Replace("5 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("6 "))
                    {
                        tempA = temp.Replace("6 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("7 "))
                    {
                        tempA = temp.Replace("7 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("8 "))
                    {
                        tempA = temp.Replace("8 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("9 "))
                    {
                        tempA = temp.Replace("9 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("10 "))
                    {
                        tempA = temp.Replace("10 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("11 "))
                    {
                        tempA = temp.Replace("11 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("12 "))
                    {
                        tempA = temp.Replace("12 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("13 "))
                    {
                        tempA = temp.Replace("13 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("14 "))
                    {
                        tempA = temp.Replace("14 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("15 "))
                    {
                        tempA = temp.Replace("15 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("16 "))
                    {
                        tempA = temp.Replace("16 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("17 "))
                    {
                        tempA = temp.Replace("17 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("18 "))
                    {
                        tempA = temp.Replace("18 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("19 "))
                    {
                        tempA = temp.Replace("19 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("20 "))
                    {
                        tempA = temp.Replace("20 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("21 "))
                    {
                        tempA = temp.Replace("21 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("22 "))
                    {
                        tempA = temp.Replace("22 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("23 "))
                    {
                        tempA = temp.Replace("23 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("24 "))
                    {
                        tempA = temp.Replace("24 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("25 "))
                    {
                        tempA = temp.Replace("25 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("26 "))
                    {
                        tempA = temp.Replace("26 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("27 "))
                    {
                        tempA = temp.Replace("27 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("28 "))
                    {
                        tempA = temp.Replace("28 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("29 "))
                    {
                        tempA = temp.Replace("29 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("30 "))
                    {
                        tempA = temp.Replace("30 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("31 "))
                    {
                        tempA = temp.Replace("31 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("32 "))
                    {
                        tempA = temp.Replace("32 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("33 "))
                    {
                        tempA = temp.Replace("33 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("34 "))
                    {
                        tempA = temp.Replace("34 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("35 "))
                    {
                        tempA = temp.Replace("35 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("36 "))
                    {
                        tempA = temp.Replace("36 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("37 "))
                    {
                        tempA = temp.Replace("37 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("38 "))
                    {
                        tempA = temp.Replace("38 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("39 "))
                    {
                        tempA = temp.Replace("39 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("40 "))
                    {
                        tempA = temp.Replace("40 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("41 "))
                    {
                        tempA = temp.Replace("41 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("42 "))
                    {
                        tempA = temp.Replace("42 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("43 "))
                    {
                        tempA = temp.Replace("43 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("44 "))
                    {
                        tempA = temp.Replace("44 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("45 "))
                    {
                        tempA = temp.Replace("45 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("46 "))
                    {
                        tempA = temp.Replace("46 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("47 "))
                    {
                        tempA = temp.Replace("47 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("48 "))
                    {
                        tempA = temp.Replace("48 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("49 "))
                    {
                        tempA = temp.Replace("49 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("50 "))
                    {
                        tempA = temp.Replace("50 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("51 "))
                    {
                        tempA = temp.Replace("51 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("52 "))
                    {
                        tempA = temp.Replace("52 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("53 "))
                    {
                        tempA = temp.Replace("53 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("54 "))
                    {
                        tempA = temp.Replace("54 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("55 "))
                    {
                        tempA = temp.Replace("55 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("56 "))
                    {
                        tempA = temp.Replace("56 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("57 "))
                    {
                        tempA = temp.Replace("57 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("58 "))
                    {
                        tempA = temp.Replace("58 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("59 "))
                    {
                        tempA = temp.Replace("59 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("60 "))
                    {
                        tempA = temp.Replace("60 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("61 "))
                    {
                        tempA = temp.Replace("61 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("62 "))
                    {
                        tempA = temp.Replace("62 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("63 "))
                    {
                        tempA = temp.Replace("63 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("64 "))
                    {
                        tempA = temp.Replace("64 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("65 "))
                    {
                        tempA = temp.Replace("65 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("66 "))
                    {
                        tempA = temp.Replace("66 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("67 "))
                    {
                        tempA = temp.Replace("67 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("68 "))
                    {
                        tempA = temp.Replace("68 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("69 "))
                    {
                        tempA = temp.Replace("69 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("70 "))
                    {
                        tempA = temp.Replace("70 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("71 "))
                    {
                        tempA = temp.Replace("71 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("72 "))
                    {
                        tempA = temp.Replace("72 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("73 "))
                    {
                        tempA = temp.Replace("73 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("74 "))
                    {
                        tempA = temp.Replace("74 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("75 "))
                    {
                        tempA = temp.Replace("75 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("76 "))
                    {
                        tempA = temp.Replace("76 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("77 "))
                    {
                        tempA = temp.Replace("77 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("78 "))
                    {
                        tempA = temp.Replace("78 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("79 "))
                    {
                        tempA = temp.Replace("79 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("80 "))
                    {
                        tempA = temp.Replace("80 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("81 "))
                    {
                        tempA = temp.Replace("81 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("82 "))
                    {
                        tempA = temp.Replace("82 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("83 "))
                    {
                        tempA = temp.Replace("83 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("84 "))
                    {
                        tempA = temp.Replace("84 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("85 "))
                    {
                        tempA = temp.Replace("85 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("86 "))
                    {
                        tempA = temp.Replace("86 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("87 "))
                    {
                        tempA = temp.Replace("87 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("88 "))
                    {
                        tempA = temp.Replace("88 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("89  "))
                    {
                        tempA = temp.Replace("89 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("90 "))
                    {
                        tempA = temp.Replace("90 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("91 "))
                    {
                        tempA = temp.Replace("91 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("92 "))
                    {
                        tempA = temp.Replace("92 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("93 "))
                    {
                        tempA = temp.Replace("93 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("94 "))
                    {
                        tempA = temp.Replace("94 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("95 "))
                    {
                        tempA = temp.Replace("95 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("96 "))
                    {
                        tempA = temp.Replace("96 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("97 "))
                    {
                        tempA = temp.Replace("97 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("98 "))
                    {
                        tempA = temp.Replace("98 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("99 "))
                    {
                        tempA = temp.Replace("99 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("100 "))
                    {
                        tempA = temp.Replace("100 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("101 "))
                    {
                        tempA = temp.Replace("101 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("102 "))
                    {
                        tempA = temp.Replace("102 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("103 "))
                    {
                        tempA = temp.Replace("103 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("104 "))
                    {
                        tempA = temp.Replace("104 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("105 "))
                    {
                        tempA = temp.Replace("105 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("106 "))
                    {
                        tempA = temp.Replace("106 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("107 "))
                    {
                        tempA = temp.Replace("107 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("108 "))
                    {
                        tempA = temp.Replace("108 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("109 "))
                    {
                        tempA = temp.Replace("109 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("110 "))
                    {
                        tempA = temp.Replace("110 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("111 "))
                    {
                        tempA = temp.Replace("111 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("112 "))
                    {
                        tempA = temp.Replace("112 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("113 "))
                    {
                        tempA = temp.Replace("113", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("114 "))
                    {
                        tempA = temp.Replace("114 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("115 "))
                    {
                        tempA = temp.Replace("115 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("116 "))
                    {
                        tempA = temp.Replace("116 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("117 "))
                    {
                        tempA = temp.Replace("117 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("118 "))
                    {
                        tempA = temp.Replace("118 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("119 "))
                    {
                        tempA = temp.Replace("119 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("120 "))
                    {
                        tempA = temp.Replace("120 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("121 "))
                    {
                        tempA = temp.Replace("121 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("122 "))
                    {
                        tempA = temp.Replace("122 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("123 "))
                    {
                        tempA = temp.Replace("123 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("124 "))
                    {
                        tempA = temp.Replace("124 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("125 "))
                    {
                        tempA = temp.Replace("125 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("126 "))
                    {
                        tempA = temp.Replace("126 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("127 "))
                    {
                        tempA = temp.Replace("127 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("128 "))
                    {
                        tempA = temp.Replace("128 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("129 "))
                    {
                        tempA = temp.Replace("129 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("130 "))
                    {
                        tempA = temp.Replace("130 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("131 "))
                    {
                        tempA = temp.Replace("131 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("132 "))
                    {
                        tempA = temp.Replace("132 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("133 "))
                    {
                        tempA = temp.Replace("133 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("134 "))
                    {
                        tempA = temp.Replace("134 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("135 "))
                    {
                        tempA = temp.Replace("135 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("136 "))
                    {
                        tempA = temp.Replace("136 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("137 "))
                    {
                        tempA = temp.Replace("137 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("138 "))
                    {
                        tempA = temp.Replace("138 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("139 "))
                    {
                        tempA = temp.Replace("139 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("140 "))
                    {
                        tempA = temp.Replace("140 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("141 "))
                    {
                        tempA = temp.Replace("141 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("142 "))
                    {
                        tempA = temp.Replace("142 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("143 "))
                    {
                        tempA = temp.Replace("143 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("144 "))
                    {
                        tempA = temp.Replace("144 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("145 "))
                    {
                        tempA = temp.Replace("145 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("146 "))
                    {
                        tempA = temp.Replace("146 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("147 "))
                    {
                        tempA = temp.Replace("147 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("148 "))
                    {
                        tempA = temp.Replace("148 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("149 "))
                    {
                        tempA = temp.Replace("149 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("150 "))
                    {
                        tempA = temp.Replace("150 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("151 "))
                    {
                        tempA = temp.Replace("151 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("152 "))
                    {
                        tempA = temp.Replace("152 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("153 "))
                    {
                        tempA = temp.Replace("153 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("154 "))
                    {
                        tempA = temp.Replace("154 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("155 "))
                    {
                        tempA = temp.Replace("155 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("156 "))
                    {
                        tempA = temp.Replace("156 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("157 "))
                    {
                        tempA = temp.Replace("157 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("158 "))
                    {
                        tempA = temp.Replace("158 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("159 "))
                    {
                        tempA = temp.Replace("159 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("160 "))
                    {
                        tempA = temp.Replace("160 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("161 "))
                    {
                        tempA = temp.Replace("161 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("162 "))
                    {
                        tempA = temp.Replace("162 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("163 "))
                    {
                        tempA = temp.Replace("163 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("164 "))
                    {
                        tempA = temp.Replace("164 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("165 "))
                    {
                        tempA = temp.Replace("165 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("166 "))
                    {
                        tempA = temp.Replace("166 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("167 "))
                    {
                        tempA = temp.Replace("167 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("168 "))
                    {
                        tempA = temp.Replace("168 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("169 "))
                    {
                        tempA = temp.Replace("169 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("170 "))
                    {
                        tempA = temp.Replace("170 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("171 "))
                    {
                        tempA = temp.Replace("171 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("172 "))
                    {
                        tempA = temp.Replace("172 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("173 "))
                    {
                        tempA = temp.Replace("173 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("174 "))
                    {
                        tempA = temp.Replace("174 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("175 "))
                    {
                        tempA = temp.Replace("175 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("176 "))
                    {
                        tempA = temp.Replace("176 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("177 "))
                    {
                        tempA = temp.Replace("177 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("178 "))
                    {
                        tempA = temp.Replace("178 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("179 "))
                    {
                        tempA = temp.Replace("179 ", "");
                        result.Add(tempA);
                    }
                    else if (temp.StartsWith("180 "))
                    {
                        tempA = temp.Replace("180 ", "");
                        result.Add(tempA);
                    }
                    else
                    {
                        result.Add(temp);
                    }
                }
            }

            StreamWriter streamWriter = new StreamWriter(outputFilePath);

            for (int j = 0; j < result.Count - 1; j++)
            {
                streamWriter.WriteLine(result[j].TrimEnd());
            }
            streamWriter.Close();
        }        
    }    

    /// <summary>
    /// 3. 창세기1:1 에서 창세기1: 없애주기
    /// </summary>
    public static void RemoveFront()
    {
        // c:\Bible\BBB 폴더에 있는 모든 파일들을 가져 옵니다. 
        string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\CCC", "*.txt", SearchOption.AllDirectories);
        // 모든 파일들을 대상으로 반복문 처리합니다. 
        for (int k = 0; k < CollectAllFiles.Length; k++)
        {
            // 경로를 뺀 파일이름을 가져옵니다. 
            string fileName = Path.GetFileName(CollectAllFiles[k]);
            // 저장될 파일 이름을 지정해 줍니다. 
            string outputFilePath = @"c:\Bible\DDD\" + fileName;
            // 파일에 있는 문자열을 가져옵니다. 
            string textValue = System.IO.File.ReadAllText(CollectAllFiles[k]);
            // 가져온 문자열을 '\n' 문자로 구분해서 collectKorean 리스트에 저장합니다. 
            List<string> collectKorean = new List<string>(textValue.Split('\n'));
            List<string> collectKoreanModify = new List<string>();
            // collectKorean 리스트를 대상으로 반복문 처리합니다. 
            // 리스트 맨 끝에는 공백이 있습니다. 공백은 반복문 처리에서 빼 줍니다. 
            for (int i = 0; i < collectKorean.Count - 1; i++)
            {
                // 문자열을 ":"로 분리합니다. 창1:15
                string[] ModifyA = collectKorean[i].Split(":");
                if (ModifyA.Length > 1)
                {
                    // ":" 기준으로 앞부분은 날려 주고, 뒷부분만 collectKoreanModify 리스트에 추가해 줍니다. 
                    collectKoreanModify.Add(ModifyA[1]);
                }
            }

            // string outputFilePath = @"c:\Bible\DDD\" + fileName;
            StreamWriter writer = new StreamWriter(outputFilePath);

            for (int i = 0; i < collectKoreanModify.Count; i++)
            {
                // writer.WriteLine(collectKoreanModify[i].TrimEnd());
                writer.WriteLine(collectKoreanModify[i]);
            }

            writer.Close();
        }
    }

    int intCount = 0;
    /// <summary>
    /// 10가지의 성경의 내용들을 출력
    /// </summary>
    public void ExtractBible()
    {
        // 결과를 저장할 폴더입니다. 
        string folderPath = @"C:\Bible\Info\AllBible\";
        DirectoryInfo di = new DirectoryInfo(folderPath);

        if (di.Exists == false) di.Create(); // 만약 폴더가 존재하지 않으면

        string[] Koreankeywords = { "창", "출", "레", "민", "신", "수", "삿", "룻", "삼상", "삼하", "왕상", "왕하", "대상", "대하", "스", "느", "에", "욥", "시", "잠", "전", "아", "사", "렘", "애", "겔", "단", "호", "욜", "암", "옵", "욘", "미", "나", "합", "습", "학", "슥", "말", "마", "막", "눅", "요", "행", "롬", "고전", "고후", "갈", "엡", "빌", "골", "살전", "살후", "딤전", "딤후", "딛", "몬", "히", "약", "벧전", "벧후", "요일", "요이", "요삼", "유", "계" };
        string[] keywords = { "Gen", "Ex", "Lev", "Num", "Deut", "Josh", "Judg", "Ruth", "1Sam", "2Sam", "1Kin", "2Kin", "1Chr", "2Chr", "Ezra", "Neh", "Esther", "Job", "Ps", "Prov", "Eccles", "Song", "Is", "Jer", "Lam", "Ezek", "Dan", "Hos", "Joel", "Amos", "Obad", "Jonah", "Mic", "Nah", "Hab", "Zeph", "Hag", "Zech", "Mal", "Matt", "Mark", "Luke", "John", "Acts", "Rom", "1Cor", "2Cor", "Gal", "Eph", "Phil", "Col", "1Thess", "2Thess", "1Tim", "2Tim", "Titus", "Philem", "Heb", "James", "1Pet", "2Pet", "1John", "2John", "3John", "Jude", "Rev" };
        int[] chapterCount = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4, 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };

        TextAsset[] RevisedRevision = Resources.LoadAll<TextAsset>("RevisedRevision/New/");
        TextAsset[] EasyBible = Resources.LoadAll<TextAsset>("EasyBible/New/");
        TextAsset[] KoreanBible = Resources.LoadAll<TextAsset>("KoreanBible/New/"); 
        TextAsset[] NewStandardTranslation = Resources.LoadAll<TextAsset>("NewStandardTranslation/New/");

        TextAsset[] NIV = Resources.LoadAll<TextAsset>("NIV/New/");
        TextAsset[] KJV = Resources.LoadAll<TextAsset>("KJV/New/");
        TextAsset[] NewKJV = Resources.LoadAll<TextAsset>("NewKJV/New/");
        TextAsset[] ESV = Resources.LoadAll<TextAsset>("ESV/New/");
        TextAsset[] NewRSV = Resources.LoadAll<TextAsset>("NewRSV/New/");

        for (int j = 0; j < RevisedRevision.Length; j++)
        {
            string fileNameNewStandardTranslation = Path.GetFileName(NewStandardTranslation[intCount].name);
            string fileNameRevisedRevision = Path.GetFileName(RevisedRevision[intCount].name);
            string fileNameEasyBible = Path.GetFileName(EasyBible[intCount].name);
            string fileNameKoreanBible = Path.GetFileName(KoreanBible[intCount].name);

            string fileNameNIV = Path.GetFileName(NIV[intCount].name);
            string fileNameKJV = Path.GetFileName(KJV[intCount].name);
            string fileNameNewKJV = Path.GetFileName(NewKJV[intCount].name);
            string fileNameESV = Path.GetFileName(ESV[intCount].name);
            string fileNameNewRSV = Path.GetFileName(NewRSV[intCount].name);

            string tempString = fileNameNewStandardTranslation;
            string outputBibleName = string.Empty;
            string keyWord = "표준새번역";
            string outPutKeyWord = "하나님의 말씀";

            if (tempString.Contains(keyWord)) outputBibleName = tempString.Replace(keyWord, outPutKeyWord);
            else outputBibleName = fileNameNewStandardTranslation;

            string outputFilePath = @"c:\Bible\Info\AllBible\" + outputBibleName + ".txt";

            StreamWriter streamWriter = new StreamWriter(outputFilePath, true);

            List<string> RevisedRevisionList = new List<string>(RevisedRevision[intCount].text.Split('\n'));
            List<string> EasyBibleList = new List<string>(EasyBible[intCount].text.Split('\n'));
            List<string> KoreanBibleList = new List<string>(KoreanBible[intCount].text.Split('\n'));
            List<string> NewStandardTranslationList = new List<string>(NewStandardTranslation[intCount].text.Split('\n'));

            List<string> NIVList = new List<string>(NIV[intCount].text.Split('\n'));
            List<string> KJVList = new List<string>(KJV[intCount].text.Split('\n'));
            List<string> NewKJVList = new List<string>(NewKJV[intCount].text.Split('\n'));
            List<string> ESVList = new List<string>(ESV[intCount].text.Split('\n'));
            List<string> NewRSVList = new List<string>(NewRSV[intCount].text.Split('\n'));

            Debug.Log("RevisedRevisionList.Count : " + RevisedRevisionList.Count);
            Debug.Log("EasyBibleList.Count : " + EasyBibleList.Count);
            Debug.Log("KoreanBibleList.Count : " + KoreanBibleList.Count);
            Debug.Log("NewStandardTranslationList.Count : " + NewStandardTranslationList.Count);

            Debug.Log("NIVList.Count : " + NIVList.Count);
            Debug.Log("KJVList.Count : " + KJVList.Count);
            Debug.Log("NewKJVList.Count : " + NewKJVList.Count);
            Debug.Log("ESVList.Count : " + ESVList.Count);
            Debug.Log("NewRSVList.Count : " + NewRSVList.Count);

            for (int i = 0; i < RevisedRevisionList.Count; i++)
            {
                streamWriter.WriteLine((i + 1) + "절 " + NewStandardTranslationList[i].Trim() + " - " + fileNameNewStandardTranslation);
                streamWriter.WriteLine((i + 1) + "절 " + EasyBibleList[i].Trim() + " - " + fileNameEasyBible);
                streamWriter.WriteLine((i + 1) + "절 " + KoreanBibleList[i].Trim() + " - " + fileNameKoreanBible);
                streamWriter.WriteLine((i + 1) + "절 " + RevisedRevisionList[i].Trim() + " - " + fileNameRevisedRevision);

                streamWriter.WriteLine((i + 1) + "절 " + NIVList[i].Trim() + " - " + fileNameNIV);
                streamWriter.WriteLine((i + 1) + "절 " + ESVList[i].Trim() + " - " + fileNameESV);
                streamWriter.WriteLine((i + 1) + "절 " + NewRSVList[i].Trim() + " - " + fileNameNewRSV);
                streamWriter.WriteLine((i + 1) + "절 " + KJVList[i].Trim() + " - " + fileNameKJV);
                streamWriter.WriteLine((i + 1) + "절 " + NewKJVList[i].Trim() + " - " + fileNameNewKJV);

                streamWriter.WriteLine("\n");
            }

            streamWriter.Close();

            intCount++;
        }
    }

    public void CSV_To_Text()
    {
        string[] keywords1 =
                    {
"Gen", "Ex", "Lev", "Num", "Deut", "Josh", "Judg", "Ruth", "1Sam", "2Sam",
"1Kin", "2Kin", "1Chr", "2Chr", "Ezra", "Neh", "Esther", "Job", "Ps", "Prov",
"Eccles", "Song", "Is", "Jer", "Lam", "Ezek", "Dan", "Hos", "Joel", "Amos",
"Obad", "Jonah", "Mic", "Nah", "Hab", "Zeph", "Hag", "Zech", "Mal", "Matt",
"Mark", "Luke", "John", "Acts", "Rom", "1Cor", "2Cor", "Gal", "Eph", "Phil",
"Col", "1Thess", "2Thess", "1Tim", "2Tim", "Titus", "Philem", "Heb", "James", "1Pet",
"2Pet", "1John", "2John", "3John", "Jude", "Rev"
                };
        string[] Koreankeywords = { "창", "출", "레", "민", "신", "수", "삿", "룻", "삼상", "삼하", "왕상", "왕하", "대상", "대하", "스", "느", "에", "욥", "시", "잠", "전", "아", "사", "렘", "애", "겔", "단", "호", "욜", "암", "옵", "욘", "미", "나", "합", "습", "학", "슥", "말", "마", "막", "눅", "요", "행", "롬", "고전", "고후", "갈", "엡", "빌", "골", "살전", "살후", "딤전", "딤후", "딛", "몬", "히", "약", "벧전", "벧후", "요일", "요이", "요삼", "유", "계" };
        string[] English =
            {
"Genesis", "Exodus", "Leviticus", "Numbers", "Deuteronomy", "Joshua", "Judges", "Ruth", "1 Samuel", "2 Samuel",
"1 Kings", "2 Kings", "1 Chronicles", "2 Chronicles", "Ezra", "Nehemiah", "Esther", "Job", "Psalms", "Proverbs",
"Ecclesiastes", "Song of Solomon", "Isaiah", "Jeremiah", "Lamentations", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos",
"Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi", "Matthew",
"Mark", "Luke", "John", "Acts", "Romans", "1 Corinthians", "2 Corinthians", "Galatians", "Ephesians", "Philippians",
"Colossians", "1 Thessalonians", "2 Thessalonians", "1 Timothy", "2 Timothy", "Titus", "Philemon", "Hebrews", "James", "1 Peter",
"2 Peter", "1 John", "2 John", "3 John", "Jude", "Revelation"
                };
        string[] Portuguese =
{
"Gênesis", "Êxodo", "Levítico", "Números", "Deuteronômio", "Josué", "Juízes", "Rute", "1 Samuel", "2 Samuel",
"1 Reis", "2 Reis", "1 Crônicas", "2 Crônicas", "Esdras", "Neemias", "Ester", "Jó", "Salmos", "Provérbios",
"Eclesiastes", "Cantares", "Isaías", "Jeremias", "Lamentações", "Ezequiel", "Daniel", "Oseias", "Joel", "Amós",
"Obadias", "Jonas", "Miqueias", "Naum", "Habacuque", "Sofonias", "Ageu", "Zacarias", "Malaquias", "Mateus",
"Marcos", "Lucas", "João", "Atos", "Romanos", "1 Coríntios", "2 Coríntios", "Gálatas", "Efésios", "Filipenses",
"Colossenses", "1 Tessalonicenses", "2 Tessalonicenses", "1 Timóteo", "2 Timóteo", "Tito", "Filemom", "Hebreus", "Tiago", "1 Pedro",
"2 Pedro", "1 João", "2 João", "3 João", "Judas", "Apocalipse"
                };
        string[] German =
{
"1 Mose", "2 Mose", "3 Mose", "4 Mose", "5 Mose", "Josua", "Richter", "Rut", "1 Samuel", "2 Samuel",
"1 Koenige", "2 Koenige", "1 Chronik", "2 Chronik", "Esra", "Nehemia", "Ester", "Job", "Psalm", "Sprueche",
"Prediger", "Hohelied", "Jesaja", "Jeremia", "Klagelieder", "Hesekiel", "Daniel", "Hosea", "Joel", "Amos",
"Obadja", "Jona", "Mica", "Nahum", "Habakuk", "Zephanja", "Haggai", "Sacharja", "Maleachi", "Matthaeus",
"Markus", "Lukas", "Johannes", "Apostelgeschichte", "Roemers", "1 Korinther", "2 Korinther", "Galater", "Epheser", "Philipper",
"Kolosser", "1 Thessalonicher", "2 Thessalonicher", "1 Timotheus", "2 Timotheus", "Titus", "Philemon", "Hebraeer", "Jakobus", "1 Petrus",
"2 Petrus", "1 Johannes", "2 Johannes", "3 Johannes", "Judas", "Offenbarung"
                };
        string[] Japanese =
            {
"創世記", "出エジプト記", "レビ記", "民数記", "申命記", "ヨシュア記", "士師記", "ルツ記", "サムエル記Ⅰ", "サムエル記Ⅱ",
"列王記Ⅰ", "列王記Ⅱ", "歴代誌Ⅰ", "歴代誌Ⅱ", "エズラ記", "ネヘミヤ 記", "エステル 記", "ヨブ 記", "詩篇", "箴言 知恵の泉",
"伝道者の書", "雅歌", "イザヤ書", "エレミヤ書", "哀歌", "エゼキエル書", "ダニエル書", "ホセア書", "ヨエル書", "アモス書",
"オバデヤ書", "ヨナ書", "ミカ書", "ナホム書", "ハバクク書", "ゼパニヤ書", "ハガイ書", "ゼカリヤ書", "マラキ書", "マタイの福音書",
"マルコの福音書", "ルカの福音書", "ヨハネの福音書", "使徒の働き", "ローマ人への手紙", "コリント人への手紙Ⅰ", "コリント人への手紙Ⅱ", "ガラテヤ人への手紙", "エペソ人への手紙", "ピリピ人への手紙",
"コロサイ人への手紙", "テサロニケ人への手紙Ⅰ", "テサロニケ人への手紙Ⅱ", "テモテへの手紙Ⅰ", "テモテへの手紙Ⅱ", "テトスへの手紙", "ピレモンへの手紙", "へブル人への手紙", "ヤコブの手紙", "ペテロの手紙Ⅰ",
"ペテロの手紙Ⅱ", "ヨハネの手紙Ⅰ", "ヨハネの手紙Ⅱ", "ヨハネの手紙Ⅲ", "ユダの手紙", "ヨハネの黙示録"
                };
        string[] Chinese =
            {
"創 世 記", "出 埃 及 記", "利 未 記", "民 數 記", "申 命 記", "約 書 亞 記", "士 師 記", "路 得 記", "撒 母 耳 記 上", "撒 母 耳 記 下",
"列 王 紀 上", "列 王 紀 下", "歷 代 志 上", "歷 代 志 下", "以 斯 拉 記", "尼 希 米 記", "以 斯 帖 記", "約 伯 記", "詩 篇", "箴 言",
"傳 道 書", "雅 歌", "以 賽 亞 書", "耶 利 米 書", "耶 利 米 哀 歌", "以 西 結 書", "但 以 理 書", "何 西 阿 書", "約 珥 書", "阿 摩 司 書",
"俄 巴 底 亞 書", "約 拿 書", "彌 迦 書", "那 鴻 書", "哈 巴 谷 書", "西 番 雅 書", "哈 該 書", "撒 迦 利 亞", "瑪 拉 基 書", "馬 太 福 音",
"馬 可 福 音", "路 加 福 音", "約 翰 福 音", "使 徒 行 傳", "羅 馬 書", "歌 林 多 前 書", "歌 林 多 後 書", "加 拉 太 書", "以 弗 所 書", "腓 立 比 書",
"歌 羅 西 書", "帖 撒 羅 尼 迦 前 書", "帖 撒 羅 尼 迦 後 書", "提 摩 太 前 書", "提 摩 太 後 書", "提 多 書", "腓 利 門 書", "希 伯 來 書", "雅 各 書", "彼 得 前 書",
"彼 得 後 書", "約 翰 一 書", "約 翰 二 書", "約 翰 三 書", "猶 大 書", "启 示 录"
                };
        string[] Romanian =
            {
"Geneza", "Exod", "Levitic", "Numeri", "Deuteronom", "Iosua", "Judecatori", "Rut", "1 Samuel", "2 Samuel",
"1 Imparati", "2 Imparati", "1 Cronici", "2 Cronici", "Ezra", "Neemia", "Estera", "Iov", "Psalmi", "Proverbe",
"Ecclesiast", "Cantarea Cantarilor", "Isaia", "Ieremia", "Plângeri", "Ezechiel", "Daniel", "Osea", "Ioel", "Amos",
"Obadia", "Iona", "Mica", "Naum", "Habacuc", "Tefania", "Hagai", "Zaharia", "Maleahi", "Matei",
"Marcu", "Luca", "Ioan", "Faptele Apostolilor", "Romani", "1 Corinteni", "2 Corinteni", "Galateni", "Efeseni", "Filipeni",
"Coloseni", "1 Tesaloniceni", "3 Tesaloniceni", "1 Timotei", "2 Timotei", "Tit", "Filimon", "Evrei", "Iacob", "1 Petru",
"2 Petru", "1 Ioan", "2 Ioan", "3 Ioan", "Iuda", "Apocalipsa"
                };
        string[] French =
{
"Genèse", "Exode", "Lévitique", "Nombres", "Deutéronome", "Josué", "Juges", "Ruth", "1 Samuel", "2 Samuel",
"1 Rois", "2 Rois", "1 Chroniques", "2 Chroniques", "Esdras", "Néhémie", "Esther", "Job", "Psaume", "Proverbes",
"Ecclésiaste", "Cantique Des Cantiqu", "Ésaïe", "Jérémie", "Lamentations", "Ézéchiel", "Daniel", "Osée", "Joël", "Amos",
"Abdias", "Jonas", "Michée", "Nahum", "Habacuc", "Sophonie", "Aggée", "Zacharie", "Malachie", "Matthieu",
"Marc", "Luc", "Jean", "Actes", "Romains", "1 Corinthiens", "2 Corinthiens", "Galates", "Éphésiens", "Philippiens",
"Colossiens", "1 Thessaloniciens", "2 Thessaloniciens", "1 Timothée", "2 Timothée", "Tite", "Philémon", "Hébreux", "Jacques", "1 Pierre",
"2 Pierre", "1 Jean", "2 Jean", "3 Jean", "Jude", "Apocalypse"
                };
        string[] Spanish =
            {
"Génesis", "Éxodo", "Levítico", "Números", "Deuteronomio", "Josué", "Jueces", "Rut", "1 Samuel", "2 Samuel",
"1 Reyes", "2 Reyes", "1 Crónicas", "2 Crónicas", "Esdras", "Nehemías", "Esther", "Job", "Salmos", "Proverbios",
"Ecclesiastés", "Canción de canciones", "Isaías", "Jeremías", "Lamentaciones", "Ezequiel", "Daniel", "Oseas", "Joel", "Amós",
"Abdías", "Jonás", "Miqueas", "Nahum", "Habacuc", "Sofonías", "Haggeo", "Zacarías", "Malaquías", "Mateo",
"Marcos", "Lucas", "Juan", "Hechos", "Romanos", "1 Corintios", "2 Corintios", "Gálatas", "Efesios", "Filipenses",
"Colosenses", "1 Tesalonicenses", "2 Tesalonicenses", "1 Timoteo", "2 Timoteo", "Tito", "Filemón", "Hebreos", "Santiago", "1 Pedro",
"2 Pedro", "1 Juan", "2 Juan", "3 Juan", "Judas", "Revelación"
                };
        string[] Italian =
                            {
"Genesi", "Esodo", "Levitico", "Numeri", "Deuteronomio", "Giosué", "Giudici", "Rut", "1 Samuele", "2 Samuele",
"1 Re", "2 Re", "1 Cronache", "2 Cronache", "Esdra", "Neemia", "Ester", "Giobbe", "Salmi", "Proverbi",
"Ecclesiaste", "Cantico Dei Cantici", "Isaia", "Geremia", "Lamentazioni", "Ezechiele", "Daniele", "Osea", "Gioele", "Amos",
"Abdia", "Giona", "Michea", "Nahum", "Abacuc", "Sofonia", "Aggeo", "Zaccaria", "Malachia", "Matteo",
"Marco", "Luca", "Giovanni", "Atti", "Romani", "1 Corinzi", "2 Corinzi", "Galati", "Efesini", "Filippesi",
"Colossesi", "1 Tessalonicesi", "2 Tessalonicesi", "1 Timoteo", "2 Timoteo", "Tito", "Filemone", "Ebrei", "Giacomo", "1 Pietro",
"2 Pietro", "1 Giovann", "2 Giovann", "3 Giovann", "Giuda", "Apocalisse"
                };
        string[] Hungarian =
{
"1 Mózes", "2 Mózes", "3 Mózes", "4 Mózes", "5 Mózes", "Józsué", "Birák", "Ruth", "1 Sámuel", "2 Sámuel",
"1 Királyok", "2 Királyok", "1 Krónika", "2 Krónika", "Ezsdrás", "Nehemiás", "Eszter", "Jób", "Zsoltárok", "Példabeszédek",
"Prédikátor", "Énekek Éneke", "Ézsaiás", "Jeremiás", "Jeremiás Sir", "Ezékiel", "Dániel", "Hóseás", "Jóel", "Ámos",
"Abdiás", "Jónás", "Mikeás", "Náhum", "Habakuk", "Sofoniás", "Aggeus", "Zakariás", "Malakiás", "Máté",
"Márk", "Lukács", "János", "Apostolok", "Rómaiakhoz", "1 Korintus", "2 Korintus", "Galatákhoz", "Efézusiakhoz", "Filippiekhez",
"Kolosséiakhoz", "1 Tesszalonika", "2 Tesszalonika", "1 Timóteusho", "2 Timóteusho", "Titushoz", "Filemonhoz", "Zsidókhoz", "Jakab", "1 Péte",
"2 Péte", "1 János", "2 János", "3 János", "Júdás", "Jelenések"
                };
        string[] Russian =
{
"бытие", "Исход", "Левит", "Числа", "Второзаконие", "Иисус Навин", "Книга Судей", "Руфь", "1-Я Царств", "2-Я Царств",
"3-Я Царств", "4-Я Царств", "1-Я Паралипоменон", "2-Я Паралипоменон", "Ездра", "Неемия", "Есфирь", "Иов", "Псалтирь", "Притчи",
"Екклесиаст", "Песни Песней", "Исаия", "Иеремия", "Плач Иеремии", "Иезекииль", "Даниил", "Осия", "Иоиль", "Амос",
"Авдия", "Иона", "Михей", "Наум", "Аввакум", "Софония", "Аггей", "Захария", "Малахия", "От Матфея",
"Марка", "От Луки", "От Иоанна", "Деяния", "К Римлянам", "1-Е Коринфянам", "2-Е Коринфянам", "К Галатам", "К Ефесянам", "К Филиппийцам",
"К Колоссянам", "1-Е Фессалоникийцам", "2-Е Фессалоникийцам", "1-Е Тимофею", "2-Е Тимофею", "К Титу", "К Филимону", "К Евреям", "Иакова", "1-E Петра",
"2-E Петр", "1-E Иоанна", "2-E Иоанна", "3-E Иоанна", "Иуда", "Откровение"
                };
        string[] Hindi =
{
"उत्पत्ति", "निर्गमन", "लैव्यव्यवस्था", "गिनती", "व्यवस्था विवरण", "यहोशू", "न्यायियों", "रूत", "1 शमूएल", "2 शमूएल",
"1 राजा", "2 राजा", "1 इतिहास", "2 इतिहास", "एज्रा", "नहेमायाह", "एस्तेर", "अय्यूब", "भजन संहिता", "नीतिवचन",
"सभोपदेशक", "Cश्रेष्ठगीत", "यशायाह", "यिर्मयाह", "विलापगीत", "यहेजकेल", "दानिय्येल", "होशे", "योएल", "आमोस",
"ओबद्याह", "योना", "मीका", "नहूम", "हबक्कूक", "सपन्याह", "हाग्गै", "जकर्याह", "मलाकी", "मत्ती",
"मरकुस", "लूका", "यूहन्ना", "प्रेरितों के काम", "रोमियों", "1 कुरिन्थियों", "2 कुरिन्थियों", "गलातियों", "इफिसियों", "फिलिप्पियों",
"कुलुस्सियों", "1 थिस्सलुनीकियों", "2 थिस्सलुनीकियों", "1 तीमुथियुस", "2 तीमुथियुस", "तीतुस", "फिलेमोन", "इब्रानियों", "याकूब", "1 पतरस",
"2 पतरस", "1 यूहन्ना", "2 यूहन्ना", "3 यूहन्ना", "यहूदा", "प्रकाशित वाक्य"
                };
        string[] keywordsEnglish =
            {
"Genesis", "Exodus", "Leviticus", "Numbers", "Deuteronomy", "Joshua", "Judges", "Ruth", "1 Samuel", "2 Samuel",
"1 Kings", "2 Kings", "1 Chronicles", "2 Chronicles", "Ezra", "Nehemiah", "Esther", "Job", "Psalms", "Proverbs",
"Ecclesiastes", "Song of Solomon", "Isaiah", "Jeremiah", "Lamentations", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos",
"Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi", "Matthew",
"Mark", "Luke", "John", "Acts", "Romans", "1 Corinthians", "2 Corinthians", "Galatians", "Ephesians", "Philippians",
"Colossians", "1 Thessalonians", "2 Thessalonians", "1 Timothy", "2 Timothy", "Titus", "Philemon", "Hebrews", "James", "1 Peter",
"2 Peter", "1 John", "2 John", "3 John", "Jude", "Revelation"
                };

        int[] chapterCount = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4, 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };

        TextAsset[] textFiles = Resources.LoadAll<TextAsset>("ETC/");

        for (int z = 0; z < textFiles.Length; z++)
        {
            TextAsset textFile = textFiles[z];
            string fileName = Path.GetFileNameWithoutExtension(textFile.name);

            List<string> VerseIDs = new List<string>();
            List<string> BookNames = new List<string>();
            List<string> BookNumbers = new List<string>();
            List<string> Chapters = new List<string>();
            List<string> Verses = new List<string>();
            List<string> Texts = new List<string>();

            List<string> collectText = new List<string>();

            StringReader stringReader = new StringReader(textFile.text); // textFile의 내용을 stringReader에 저장합니다. 
            while (stringReader.Peek() >= 0) // stringReader에 저장되어 있는 문자열이 끝이 아닐 때까지 반복합니다. 
            {
                string temp = stringReader.ReadLine(); // stringReader에서 라인을 읽어 옵니다. 
                collectText.Add(temp + " ");
            }
            stringReader.Close();

            Debug.Log(collectText[7]);

            for (int i = 6; i < collectText.Count - 1; i++)
            {
                string[] data = collectText[i].Split(',');
                VerseIDs.Add(data[0]);
                string temp = string.Empty;

                for (int t = 0; t < keywordsEnglish.Length; t++)
                {
                    if (data[1].Contains(keywordsEnglish[t]))
                        temp = Koreankeywords[t];
                }

                string tempString = data[5];
                // csv는 ,(콤마)로 구분되므로 뒤에 콤마로 구분되는 문자열 처리를 해 주어야 함 // 처리를 해주지 않으면 문자열이 없어짐. 
                for (int t = 6; t < data.Length; t++) tempString += ("--" + data[t]);

                BookNames.Add(temp);
                BookNumbers.Add(data[2]);
                Chapters.Add(data[3]);
                Verses.Add(data[4]);
                Texts.Add(tempString);
            }

            string outputFilePath = @"c:\Bible\" + fileName;
            StreamWriter writer = new StreamWriter(outputFilePath + ".txt");

            for (int i = 0; i < Texts.Count; i++)
            {
                string tempString = string.Format("{0}{1}:{2} {3}", BookNames[i].TrimEnd(), Chapters[i].TrimEnd(), Verses[i].TrimEnd(), Texts[i].TrimEnd());
                writer.WriteLine(tempString);
            }

            writer.Close();
        }
    }

    public void CSV_To_TextOther()
    {
        // Testament,Book,Chapter,Verse,Content

        string[] keywords1 =
                    {
"Gen", "Ex", "Lev", "Num", "Deut", "Josh", "Judg", "Ruth", "1Sam", "2Sam",
"1Kin", "2Kin", "1Chr", "2Chr", "Ezra", "Neh", "Esther", "Job", "Ps", "Prov",
"Eccles", "Song", "Is", "Jer", "Lam", "Ezek", "Dan", "Hos", "Joel", "Amos",
"Obad", "Jonah", "Mic", "Nah", "Hab", "Zeph", "Hag", "Zech", "Mal", "Matt",
"Mark", "Luke", "John", "Acts", "Rom", "1Cor", "2Cor", "Gal", "Eph", "Phil",
"Col", "1Thess", "2Thess", "1Tim", "2Tim", "Titus", "Philem", "Heb", "James", "1Pet",
"2Pet", "1John", "2John", "3John", "Jude", "Rev"
                };
        string[] Koreankeywords = { "창", "출", "레", "민", "신", "수", "삿", "룻", "삼상", "삼하", "왕상", "왕하", "대상", "대하", "스", "느", "에", "욥", "시", "잠", "전", "아", "사", "렘", "애", "겔", "단", "호", "욜", "암", "옵", "욘", "미", "나", "합", "습", "학", "슥", "말", "마", "막", "눅", "요", "행", "롬", "고전", "고후", "갈", "엡", "빌", "골", "살전", "살후", "딤전", "딤후", "딛", "몬", "히", "약", "벧전", "벧후", "요일", "요이", "요삼", "유", "계" };
        string[] English =
            {
"Genesis", "Exodus", "Leviticus", "Numbers", "Deuteronomy", "Joshua", "Judges", "Ruth", "1 Samuel", "2 Samuel",
"1 Kings", "2 Kings", "1 Chronicles", "2 Chronicles", "Ezra", "Nehemiah", "Esther", "Job", "Psalms", "Proverbs",
"Ecclesiastes", "Song of Solomon", "Isaiah", "Jeremiah", "Lamentations", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos",
"Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi", "Matthew",
"Mark", "Luke", "John", "Acts", "Romans", "1 Corinthians", "2 Corinthians", "Galatians", "Ephesians", "Philippians",
"Colossians", "1 Thessalonians", "2 Thessalonians", "1 Timothy", "2 Timothy", "Titus", "Philemon", "Hebrews", "James", "1 Peter",
"2 Peter", "1 John", "2 John", "3 John", "Jude", "Revelation"
                };
        string[] Portuguese =
{
"Gênesis", "Êxodo", "Levítico", "Números", "Deuteronômio", "Josué", "Juízes", "Rute", "1 Samuel", "2 Samuel",
"1 Reis", "2 Reis", "1 Crônicas", "2 Crônicas", "Esdras", "Neemias", "Ester", "Jó", "Salmos", "Provérbios",
"Eclesiastes", "Cantares", "Isaías", "Jeremias", "Lamentações", "Ezequiel", "Daniel", "Oseias", "Joel", "Amós",
"Obadias", "Jonas", "Miqueias", "Naum", "Habacuque", "Sofonias", "Ageu", "Zacarias", "Malaquias", "Mateus",
"Marcos", "Lucas", "João", "Atos", "Romanos", "1 Coríntios", "2 Coríntios", "Gálatas", "Efésios", "Filipenses",
"Colossenses", "1 Tessalonicenses", "2 Tessalonicenses", "1 Timóteo", "2 Timóteo", "Tito", "Filemom", "Hebreus", "Tiago", "1 Pedro",
"2 Pedro", "1 João", "2 João", "3 João", "Judas", "Apocalipse"
                };
        string[] German =
{
"1 Mose", "2 Mose", "3 Mose", "4 Mose", "5 Mose", "Josua", "Richter", "Rut", "1 Samuel", "2 Samuel",
"1 Koenige", "2 Koenige", "1 Chronik", "2 Chronik", "Esra", "Nehemia", "Ester", "Job", "Psalm", "Sprueche",
"Prediger", "Hohelied", "Jesaja", "Jeremia", "Klagelieder", "Hesekiel", "Daniel", "Hosea", "Joel", "Amos",
"Obadja", "Jona", "Mica", "Nahum", "Habakuk", "Zephanja", "Haggai", "Sacharja", "Maleachi", "Matthaeus",
"Markus", "Lukas", "Johannes", "Apostelgeschichte", "Roemers", "1 Korinther", "2 Korinther", "Galater", "Epheser", "Philipper",
"Kolosser", "1 Thessalonicher", "2 Thessalonicher", "1 Timotheus", "2 Timotheus", "Titus", "Philemon", "Hebraeer", "Jakobus", "1 Petrus",
"2 Petrus", "1 Johannes", "2 Johannes", "3 Johannes", "Judas", "Offenbarung"
                };
        string[] Japanese =
            {
"創世記", "出エジプト記", "レビ記", "民数記", "申命記", "ヨシュア記", "士師記", "ルツ記", "サムエル記Ⅰ", "サムエル記Ⅱ",
"列王記Ⅰ", "列王記Ⅱ", "歴代誌Ⅰ", "歴代誌Ⅱ", "エズラ記", "ネヘミヤ 記", "エステル 記", "ヨブ 記", "詩篇", "箴言 知恵の泉",
"伝道者の書", "雅歌", "イザヤ書", "エレミヤ書", "哀歌", "エゼキエル書", "ダニエル書", "ホセア書", "ヨエル書", "アモス書",
"オバデヤ書", "ヨナ書", "ミカ書", "ナホム書", "ハバクク書", "ゼパニヤ書", "ハガイ書", "ゼカリヤ書", "マラキ書", "マタイの福音書",
"マルコの福音書", "ルカの福音書", "ヨハネの福音書", "使徒の働き", "ローマ人への手紙", "コリント人への手紙Ⅰ", "コリント人への手紙Ⅱ", "ガラテヤ人への手紙", "エペソ人への手紙", "ピリピ人への手紙",
"コロサイ人への手紙", "テサロニケ人への手紙Ⅰ", "テサロニケ人への手紙Ⅱ", "テモテへの手紙Ⅰ", "テモテへの手紙Ⅱ", "テトスへの手紙", "ピレモンへの手紙", "へブル人への手紙", "ヤコブの手紙", "ペテロの手紙Ⅰ",
"ペテロの手紙Ⅱ", "ヨハネの手紙Ⅰ", "ヨハネの手紙Ⅱ", "ヨハネの手紙Ⅲ", "ユダの手紙", "ヨハネの黙示録"
                };
        string[] Chinese =
            {
"創 世 記", "出 埃 及 記", "利 未 記", "民 數 記", "申 命 記", "約 書 亞 記", "士 師 記", "路 得 記", "撒 母 耳 記 上", "撒 母 耳 記 下",
"列 王 紀 上", "列 王 紀 下", "歷 代 志 上", "歷 代 志 下", "以 斯 拉 記", "尼 希 米 記", "以 斯 帖 記", "約 伯 記", "詩 篇", "箴 言",
"傳 道 書", "雅 歌", "以 賽 亞 書", "耶 利 米 書", "耶 利 米 哀 歌", "以 西 結 書", "但 以 理 書", "何 西 阿 書", "約 珥 書", "阿 摩 司 書",
"俄 巴 底 亞 書", "約 拿 書", "彌 迦 書", "那 鴻 書", "哈 巴 谷 書", "西 番 雅 書", "哈 該 書", "撒 迦 利 亞", "瑪 拉 基 書", "馬 太 福 音",
"馬 可 福 音", "路 加 福 音", "約 翰 福 音", "使 徒 行 傳", "羅 馬 書", "歌 林 多 前 書", "歌 林 多 後 書", "加 拉 太 書", "以 弗 所 書", "腓 立 比 書",
"歌 羅 西 書", "帖 撒 羅 尼 迦 前 書", "帖 撒 羅 尼 迦 後 書", "提 摩 太 前 書", "提 摩 太 後 書", "提 多 書", "腓 利 門 書", "希 伯 來 書", "雅 各 書", "彼 得 前 書",
"彼 得 後 書", "約 翰 一 書", "約 翰 二 書", "約 翰 三 書", "猶 大 書", "启 示 录"
                };
        string[] Romanian =
            {
"Geneza", "Exod", "Levitic", "Numeri", "Deuteronom", "Iosua", "Judecatori", "Rut", "1 Samuel", "2 Samuel",
"1 Imparati", "2 Imparati", "1 Cronici", "2 Cronici", "Ezra", "Neemia", "Estera", "Iov", "Psalmi", "Proverbe",
"Ecclesiast", "Cantarea Cantarilor", "Isaia", "Ieremia", "Plângeri", "Ezechiel", "Daniel", "Osea", "Ioel", "Amos",
"Obadia", "Iona", "Mica", "Naum", "Habacuc", "Tefania", "Hagai", "Zaharia", "Maleahi", "Matei",
"Marcu", "Luca", "Ioan", "Faptele Apostolilor", "Romani", "1 Corinteni", "2 Corinteni", "Galateni", "Efeseni", "Filipeni",
"Coloseni", "1 Tesaloniceni", "3 Tesaloniceni", "1 Timotei", "2 Timotei", "Tit", "Filimon", "Evrei", "Iacob", "1 Petru",
"2 Petru", "1 Ioan", "2 Ioan", "3 Ioan", "Iuda", "Apocalipsa"
                };
        string[] French =
{
"Genèse", "Exode", "Lévitique", "Nombres", "Deutéronome", "Josué", "Juges", "Ruth", "1 Samuel", "2 Samuel",
"1 Rois", "2 Rois", "1 Chroniques", "2 Chroniques", "Esdras", "Néhémie", "Esther", "Job", "Psaume", "Proverbes",
"Ecclésiaste", "Cantique Des Cantiqu", "Ésaïe", "Jérémie", "Lamentations", "Ézéchiel", "Daniel", "Osée", "Joël", "Amos",
"Abdias", "Jonas", "Michée", "Nahum", "Habacuc", "Sophonie", "Aggée", "Zacharie", "Malachie", "Matthieu",
"Marc", "Luc", "Jean", "Actes", "Romains", "1 Corinthiens", "2 Corinthiens", "Galates", "Éphésiens", "Philippiens",
"Colossiens", "1 Thessaloniciens", "2 Thessaloniciens", "1 Timothée", "2 Timothée", "Tite", "Philémon", "Hébreux", "Jacques", "1 Pierre",
"2 Pierre", "1 Jean", "2 Jean", "3 Jean", "Jude", "Apocalypse"
                };
        string[] Spanish =
            {
"Génesis", "Éxodo", "Levítico", "Números", "Deuteronomio", "Josué", "Jueces", "Rut", "1 Samuel", "2 Samuel",
"1 Reyes", "2 Reyes", "1 Crónicas", "2 Crónicas", "Esdras", "Nehemías", "Esther", "Job", "Salmos", "Proverbios",
"Ecclesiastés", "Canción de canciones", "Isaías", "Jeremías", "Lamentaciones", "Ezequiel", "Daniel", "Oseas", "Joel", "Amós",
"Abdías", "Jonás", "Miqueas", "Nahum", "Habacuc", "Sofonías", "Haggeo", "Zacarías", "Malaquías", "Mateo",
"Marcos", "Lucas", "Juan", "Hechos", "Romanos", "1 Corintios", "2 Corintios", "Gálatas", "Efesios", "Filipenses",
"Colosenses", "1 Tesalonicenses", "2 Tesalonicenses", "1 Timoteo", "2 Timoteo", "Tito", "Filemón", "Hebreos", "Santiago", "1 Pedro",
"2 Pedro", "1 Juan", "2 Juan", "3 Juan", "Judas", "Revelación"
                };
        string[] Italian =
                            {
"Genesi", "Esodo", "Levitico", "Numeri", "Deuteronomio", "Giosué", "Giudici", "Rut", "1 Samuele", "2 Samuele",
"1 Re", "2 Re", "1 Cronache", "2 Cronache", "Esdra", "Neemia", "Ester", "Giobbe", "Salmi", "Proverbi",
"Ecclesiaste", "Cantico Dei Cantici", "Isaia", "Geremia", "Lamentazioni", "Ezechiele", "Daniele", "Osea", "Gioele", "Amos",
"Abdia", "Giona", "Michea", "Nahum", "Abacuc", "Sofonia", "Aggeo", "Zaccaria", "Malachia", "Matteo",
"Marco", "Luca", "Giovanni", "Atti", "Romani", "1 Corinzi", "2 Corinzi", "Galati", "Efesini", "Filippesi",
"Colossesi", "1 Tessalonicesi", "2 Tessalonicesi", "1 Timoteo", "2 Timoteo", "Tito", "Filemone", "Ebrei", "Giacomo", "1 Pietro",
"2 Pietro", "1 Giovann", "2 Giovann", "3 Giovann", "Giuda", "Apocalisse"
                };
        string[] Hungarian =
{
"1 Mózes", "2 Mózes", "3 Mózes", "4 Mózes", "5 Mózes", "Józsué", "Birák", "Ruth", "1 Sámuel", "2 Sámuel",
"1 Királyok", "2 Királyok", "1 Krónika", "2 Krónika", "Ezsdrás", "Nehemiás", "Eszter", "Jób", "Zsoltárok", "Példabeszédek",
"Prédikátor", "Énekek Éneke", "Ézsaiás", "Jeremiás", "Jeremiás Sir", "Ezékiel", "Dániel", "Hóseás", "Jóel", "Ámos",
"Abdiás", "Jónás", "Mikeás", "Náhum", "Habakuk", "Sofoniás", "Aggeus", "Zakariás", "Malakiás", "Máté",
"Márk", "Lukács", "János", "Apostolok", "Rómaiakhoz", "1 Korintus", "2 Korintus", "Galatákhoz", "Efézusiakhoz", "Filippiekhez",
"Kolosséiakhoz", "1 Tesszalonika", "2 Tesszalonika", "1 Timóteusho", "2 Timóteusho", "Titushoz", "Filemonhoz", "Zsidókhoz", "Jakab", "1 Péte",
"2 Péte", "1 János", "2 János", "3 János", "Júdás", "Jelenések"
                };
        string[] Russian =
{
"бытие", "Исход", "Левит", "Числа", "Второзаконие", "Иисус Навин", "Книга Судей", "Руфь", "1-Я Царств", "2-Я Царств",
"3-Я Царств", "4-Я Царств", "1-Я Паралипоменон", "2-Я Паралипоменон", "Ездра", "Неемия", "Есфирь", "Иов", "Псалтирь", "Притчи",
"Екклесиаст", "Песни Песней", "Исаия", "Иеремия", "Плач Иеремии", "Иезекииль", "Даниил", "Осия", "Иоиль", "Амос",
"Авдия", "Иона", "Михей", "Наум", "Аввакум", "Софония", "Аггей", "Захария", "Малахия", "От Матфея",
"Марка", "От Луки", "От Иоанна", "Деяния", "К Римлянам", "1-Е Коринфянам", "2-Е Коринфянам", "К Галатам", "К Ефесянам", "К Филиппийцам",
"К Колоссянам", "1-Е Фессалоникийцам", "2-Е Фессалоникийцам", "1-Е Тимофею", "2-Е Тимофею", "К Титу", "К Филимону", "К Евреям", "Иакова", "1-E Петра",
"2-E Петр", "1-E Иоанна", "2-E Иоанна", "3-E Иоанна", "Иуда", "Откровение"
                };
        string[] Hindi =
{
"उत्पत्ति", "निर्गमन", "लैव्यव्यवस्था", "गिनती", "व्यवस्था विवरण", "यहोशू", "न्यायियों", "रूत", "1 शमूएल", "2 शमूएल",
"1 राजा", "2 राजा", "1 इतिहास", "2 इतिहास", "एज्रा", "नहेमायाह", "एस्तेर", "अय्यूब", "भजन संहिता", "नीतिवचन",
"सभोपदेशक", "Cश्रेष्ठगीत", "यशायाह", "यिर्मयाह", "विलापगीत", "यहेजकेल", "दानिय्येल", "होशे", "योएल", "आमोस",
"ओबद्याह", "योना", "मीका", "नहूम", "हबक्कूक", "सपन्याह", "हाग्गै", "जकर्याह", "मलाकी", "मत्ती",
"मरकुस", "लूका", "यूहन्ना", "प्रेरितों के काम", "रोमियों", "1 कुरिन्थियों", "2 कुरिन्थियों", "गलातियों", "इफिसियों", "फिलिप्पियों",
"कुलुस्सियों", "1 थिस्सलुनीकियों", "2 थिस्सलुनीकियों", "1 तीमुथियुस", "2 तीमुथियुस", "तीतुस", "फिलेमोन", "इब्रानियों", "याकूब", "1 पतरस",
"2 पतरस", "1 यूहन्ना", "2 यूहन्ना", "3 यूहन्ना", "यहूदा", "प्रकाशित वाक्य"
                };
        string[] keywordsEnglishX =
            {
"Genesis", "Exodus", "Leviticus", "Numbers", "Deuteronomy", "Joshua", "Judges", "Ruth", "1 Samuel", "2 Samuel",
"1 Kings", "2 Kings", "1 Chronicles", "2 Chronicles", "Ezra", "Nehemiah", "Esther", "Job", "Psalms", "Proverbs",
"Ecclesiastes", "Song of Solomon", "Isaiah", "Jeremiah", "Lamentations", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos",
"Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi", "Matthew",
"Mark", "Luke", "John", "Acts", "Romans", "1 Corinthians", "2 Corinthians", "Galatians", "Ephesians", "Philippians",
"Colossians", "1 Thessalonians", "2 Thessalonians", "1 Timothy", "2 Timothy", "Titus", "Philemon", "Hebrews", "James", "1 Peter",
"2 Peter", "1 John", "2 John", "3 John", "Jude", "Revelation"
                };

        string[] keywordsEnglish = { "Genesis", "Exodus", "Leviticus", "Numbers", "Deuteronomy", "Joshua", "Judges", "Ruth", "1Samuel", "2Samuel", "1Kings", "2Kings",
                "1Chronicles", "2Chronicles", "Ezra", "Nehemiah", "Esther", "Job", "Psalms", "Proverbs", "Ecclesiastes", "SongOfSongs", "Isaiah", "Jeremiah",
                "Lamentations", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos", "Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi",
                "Matthew", "Mark", "Luke", "John", "Acts", "Romans", "1Corinthians", "2Corinthians", "Galatians", "Ephesians", "Philippians", "Colossians",
                "1Thessalonians", "2Thessalonians", "1Timothy", "2Timothy", "Titus", "Philemon", "Hebrews", "James", "1Peter", "2Peter", "1John", "2John", "3John", "Jude", "Revelation" };

        int[] chapterCount = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4, 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };

        TextAsset[] textFiles = Resources.LoadAll<TextAsset>("ETC/");

        for (int z = 0; z < textFiles.Length; z++)
        {
            TextAsset textFile = textFiles[z];
            string fileName = Path.GetFileNameWithoutExtension(textFile.name);

            string outputFilePathA = @"c:\Bible\" + fileName;
            // StreamWriter writerA = new StreamWriter(outputFilePathA + "A.txt");

            // Testament,Book,Chapter,Verse,Content
            List<string> BookNames = new List<string>();
            List<string> Chapters = new List<string>();
            List<string> Verses = new List<string>();
            List<string> Texts = new List<string>();

            List<string> collectText = new List<string>();

            StringReader stringReader = new StringReader(textFile.text); // textFile의 내용을 stringReader에 저장합니다. 
            while (stringReader.Peek() >= 0) // stringReader에 저장되어 있는 문자열이 끝이 아닐 때까지 반복합니다. 
            {
                string temp = stringReader.ReadLine(); // stringReader에서 라인을 읽어 옵니다. 
                collectText.Add(temp + " ");
            }
            stringReader.Close();

            string test = collectText[1];

            for (int i = 1; i < collectText.Count - 1; i++)
            {
                string[] data = collectText[i].Split(',');
                string temp = string.Empty;

                string dataString = data[1];
                Debug.LogWarning("data1 : " + i + ", data.Length : " + data.Length); // 데이터 확인용, csv에 오류가 있을 때 확인할 수 있씀. 

                string result = dataString.Replace("\"", "");
                int Index;

                if (int.TryParse(result, out Index)) Debug.Log(string.Empty);
                else Debug.Log("숫자가 아닙니다.");

                temp = keywordsEnglish[Index - 1];
                string tempA = temp.Replace("\"", "");

                string tempString = data[4];
                string tempStringA = tempString.Replace("\"", "");
                // csv는 ,(콤마)로 구분되므로 뒤에 콤마로 구분되는 문자열 처리를 해 주어야 함 // 처리를 해주지 않으면 문자열이 없어짐. 
                for (int t = 5; t < data.Length; t++) tempStringA += ("--" + data[t]);

                string data2A = data[2].Replace("\"", "");
                string data3A = data[3].Replace("\"", "");

                string tempStringC = string.Format("{0}, {1} {2}:{3}", i, tempA, data2A, data3A);
                // writerA.WriteLine(tempStringC);

                BookNames.Add(tempA);
                Chapters.Add(data2A);
                Verses.Add(data3A);
                Texts.Add(tempStringA);
            }

            // writerA.Close();

            string outputFilePath = @"c:\Bible\" + fileName;
            StreamWriter writer = new StreamWriter(outputFilePath + ".txt");

            for (int i = 0; i < Texts.Count; i++)
            {
                string tempString = string.Format("{0}{1}:{2} {3}", BookNames[i].TrimEnd(), Chapters[i].TrimEnd(), Verses[i].TrimEnd(), Texts[i].TrimEnd());
                writer.WriteLine(tempString);
            }

            writer.Close();
        }
    }

    public void ExportToNewTestament()
    {
        string[] keywordsEnglishNewTestament = { 
                "Matthew", "Mark", "Luke", "John", "Acts", "Romans", "1Corinthians", "2Corinthians", "Galatians", "Ephesians", "Philippians", "Colossians",
                "1Thessalonians", "2Thessalonians", "1Timothy", "2Timothy", "Titus", "Philemon", "Hebrews", "James", "1Peter", "2Peter", "1John", "2John", "3John", "Jude", "Revelation" };

        string[] keywordsEnglishOldTestament = { "Genesis", "Exodus", "Leviticus", "Numbers", "Deuteronomy", "Joshua", "Judges", "Ruth", "1Samuel", "2Samuel", "1Kings", "2Kings",
                "1Chronicles", "2Chronicles", "Ezra", "Nehemiah", "Esther", "Job", "Psalms", "Proverbs", "Ecclesiastes", "SongOfSongs", "Isaiah", "Jeremiah",
                "Lamentations", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos", "Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi",};

        int[] chapterCount = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4, 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };

        TextAsset[] textFiles = Resources.LoadAll<TextAsset>("ETC/");

        for (int z = 0; z < textFiles.Length; z++)
        {
            TextAsset textFile = textFiles[z];
            string fileName = Path.GetFileNameWithoutExtension(textFile.name);

            string outputFilePath = @"c:\Bible\" + fileName;
            List<string> collectText = new List<string>();

            StringReader stringReader = new StringReader(textFile.text); // textFile의 내용을 stringReader에 저장합니다. 
            while (stringReader.Peek() >= 0) // stringReader에 저장되어 있는 문자열이 끝이 아닐 때까지 반복합니다. 
            {
                string temp = stringReader.ReadLine(); // stringReader에서 라인을 읽어 옵니다. 
                collectText.Add(temp + " ");
            }
            stringReader.Close();

            StreamWriter writer = new StreamWriter(outputFilePath + ".txt");

            for (int i = 0; i < collectText.Count; i++)
            {
                for (int j = 0; j < keywordsEnglishNewTestament.Length; j++)
                {
                    if (collectText[i].Contains(keywordsEnglishNewTestament[j]))
                        writer.WriteLine(collectText[i]);
                }
            }

            writer.Close();
        }
    }

    public void ExportToOldTestament()
    {
        string[] keywordsEnglishNewTestament = {
                "Matthew", "Mark", "Luke", "John", "Acts", "Romans", "1Corinthians", "2Corinthians", "Galatians", "Ephesians", "Philippians", "Colossians",
                "1Thessalonians", "2Thessalonians", "1Timothy", "2Timothy", "Titus", "Philemon", "Hebrews", "James", "1Peter", "2Peter", "1John", "2John", "3John", "Jude", "Revelation" };

        string[] keywordsEnglishOldTestament = { "Genesis", "Exodus", "Leviticus", "Numbers", "Deuteronomy", "Joshua", "Judges", "Ruth", "1Samuel", "2Samuel", "1Kings", "2Kings",
                "1Chronicles", "2Chronicles", "Ezra", "Nehemiah", "Esther", "Job", "Psalms", "Proverbs", "Ecclesiastes", "SongOfSongs", "Isaiah", "Jeremiah",
                "Lamentations", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos", "Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi",};

        int[] chapterCount = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4, 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };

        TextAsset[] textFiles = Resources.LoadAll<TextAsset>("ETC/");

        for (int z = 0; z < textFiles.Length; z++)
        {
            TextAsset textFile = textFiles[z];
            string fileName = Path.GetFileNameWithoutExtension(textFile.name);

            string outputFilePath = @"c:\Bible\" + fileName;
            List<string> collectText = new List<string>();

            StringReader stringReader = new StringReader(textFile.text); // textFile의 내용을 stringReader에 저장합니다. 
            while (stringReader.Peek() >= 0) // stringReader에 저장되어 있는 문자열이 끝이 아닐 때까지 반복합니다. 
            {
                string temp = stringReader.ReadLine(); // stringReader에서 라인을 읽어 옵니다. 
                collectText.Add(temp + " ");
            }
            stringReader.Close();

            StreamWriter writer = new StreamWriter(outputFilePath + ".txt");

            for (int i = 0; i < collectText.Count; i++)
            {
                for (int j = 0; j < keywordsEnglishOldTestament.Length; j++)
                {
                    if (collectText[i].Contains(keywordsEnglishOldTestament[j]))
                        writer.WriteLine(collectText[i]);
                }
            }

            writer.Close();
        }
    }


    public void GetOver200Characters()
    {
        // c:\Bible\AAA 폴더에 있는 모든 텍스트 파일들을 읽어 옵니다. 
        string[] CollectAllFiles = Directory.GetFiles(@"c:\Bible\AAA", "*.txt", SearchOption.AllDirectories);

        string newFile = string.Empty;
        // 이제 파일의 내용을 수정해 주어야 합니다. 쉬운 성경의 내용들은 기본적으로 "창1:1"와 같은 내용이 없으므로 구분을 위해서 추가해 주는 것입니다. 
        // c:\Bible\BBB 폴더의 모든 파일들을 읽어 옵니다. 
        // CollectAllFiles = Directory.GetFiles(@"c:\Bible\BBB", "*.txt", SearchOption.AllDirectories);
        // 읽어온 파일들을 대상으로 반복문 처리합니다. 
        for (int i = 0; i < CollectAllFiles.Length; i++)
        {
            // 확장자가 빠진 파일 이름을 가져옵니다. 
            string fileName = Path.GetFileNameWithoutExtension(CollectAllFiles[i]);

            // Debug.Log("fileName" + fileName);
            // c:\Bible\CCC\ 폴더에 저장될 파일 이름입니다. 
            string outputFilePath = @"c:\Bible\BBB\" + fileName + ".txt";

            // 텍스트 파일의 내용을 문자열로 읽어 옵니다. 
            string textValue = System.IO.File.ReadAllText(CollectAllFiles[i]);
            // 읽어온 문자열을 '\n' 기준으로 분리해서 리스트 컬렉션에 저장합니다. 
            List<string> collectKorean = new List<string>(textValue.Split('\n'));
            StreamWriter streamWriter = new StreamWriter(outputFilePath + ".txt", true);


            for (int k = 0; k < collectKorean.Count - 1; k++)
            {// ReturnOver200Characters    // ReturnOver200CharactersResult
                if (collectKorean[k].Length >= 200)
                {
                    List<string> tmepCollection = new List<string>();
                    tmepCollection = ReturnOver200Characters(collectKorean[k]);
                    string tempString = string.Empty;

                    if (tmepCollection.Count >= 2)
                    {
                        //for (int k = 0; k < tmepCollection.Count; k++)
                        //    tempString += tmepCollection[k] + " #";

                        //tempString = tempString.Substring(0, tempString.Length - 2);

                        tempString += (tmepCollection[0].TrimEnd() + " #");
                        tempString += tmepCollection[1].TrimEnd();

                        streamWriter.WriteLine(tempString);
                    }
                }
                else streamWriter.WriteLine(collectKorean[k]);
            }

            streamWriter.Close();



            // "창11:31 Terah took Abram his son and Lot the son of Haran, his grandson, and Sarai his daughter-in-law, his son Abram’s wife, and they went forth together from Ur of the Chaldeans to go into the land of Canaan, but when they came to Haran, they settled there.";
            //List<string> ReturnOver200Characters(string sourceString)
            //{
            //    List<string> CollectResult = new List<string>();
            //    List<string> tempA = new List<string>(sourceString.Split(' '));
            //    List<string> tempB = new List<string>();

            //    for (int i = 0; i < tempA.Count; i++)
            //    {
            //        if (tempA[i].Contains(".") || tempA[i].Contains(",") || tempA[i].Contains("and"))
            //            tempB.Add(tempA[i]);
            //    }

            //    int keyIndex = 0;
            //    int checkIndex = 0;

            //    string resultA = string.Empty;
            //    string resultB = string.Empty;

            //    for (int i = 1; i < tempB.Count; i++)
            //    {
            //        keyIndex = sourceString.IndexOf(tempB[i]);
            //        resultA = sourceString.Substring(0, keyIndex);

            //        if (resultA.Length >= 200) break;
            //        else checkIndex = i;
            //    }

            //    keyIndex = sourceString.IndexOf(tempB[checkIndex]);
            //    resultA = sourceString.Substring(0, keyIndex);
            //    resultB = sourceString.Substring(keyIndex);

            //    int resultACount = resultA.Length;
            //    int resultBCount = resultB.Length;

            //    CollectResult.Add(resultA);
            //    CollectResult.Add(resultB);

            //    return CollectResult;
            //}

            //List<string> ReturnOver200CharactersResult(string source)
            //{
            //    List<string> ResultAll = new List<string>();
            //    List<string> TempAllA = new List<string>();
            //    List<string> TempAllB = new List<string>();
            //    List<string> TempAllC = new List<string>();

            //    ResultAll.Clear();
            //    TempAllA = ReturnOver200Characters(source);
            //    ResultAll.Add(TempAllA[0]);
            //    ResultAll.Add(TempAllA[1]);

            //    if (ResultAll.Count == 2 && TempAllA[1].Length >= 200)
            //    {
            //        ResultAll.Clear();
            //        TempAllB = ReturnOver200Characters(TempAllA[1]);
            //        ResultAll.Add(TempAllA[0]);
            //        ResultAll.Add(TempAllB[0]);
            //        ResultAll.Add(TempAllB[1]);
            //    }

            //    if (ResultAll.Count == 3 && TempAllB.Count == 2 && TempAllB[1].Length >= 200)
            //    {
            //        ResultAll.Clear();
            //        TempAllC = ReturnOver200Characters(TempAllB[1]);
            //        ResultAll.Add(TempAllA[0]);
            //        ResultAll.Add(TempAllB[0]);
            //        ResultAll.Add(TempAllC[0]);
            //        ResultAll.Add(TempAllC[1]);
            //    }

            //    List<int> CollectIntCount = new List<int>();

            //    for (int i = 0; i < ResultAll.Count; i++)
            //        CollectIntCount.Add(ResultAll[i].Length);

            //    Debug.Log(string.Empty);
            //    return ResultAll;
            //}
        }
    }

    public void ChangeFileNameToEnglishA()
    {
        string Keyword = "영문NIV";
        string Replaceword = "NIV";
        string[] Collects = Directory.GetFiles(@"c:\Bible\ETC\AAA", "*.txt", SearchOption.AllDirectories);

        string folderPath = @"C:\Bible\ETC\BBB\";
        DirectoryInfo di = new DirectoryInfo(folderPath);

        if (di.Exists == false) di.Create(); // 만약 폴더가 존재하지 않으면

        string tempWord = string.Empty;

        for (int i = 0; i < Collects.Length; i++)
        {
            if (Collects[i].Contains(Keyword))
                tempWord = Collects[i].Replace(Keyword, Replaceword);

            string oldFile = Path.GetFileNameWithoutExtension(tempWord);
            string newFile = folderPath + oldFile + ".txt";

            System.IO.File.Copy(Collects[i], newFile);
        }
    }

    public void ChangeFileNameToEnglishB()
    {
        string[] Koreankeywords = { "창", "출", "레", "민", "신", "수", "삿", "룻", "삼상", "삼하", "왕상", "왕하", "대상", "대하", "스", "느", "에", "욥", "시", "잠", "전", "아", "사", "렘", "애", "겔", "단", "호", "욜", "암", "옵", "욘", "미", "나", "합", "습", "학", "슥", "말", "마", "막", "눅", "요", "행", "롬", "고전", "고후", "갈", "엡", "빌", "골", "살전", "살후", "딤전", "딤후", "딛", "몬", "히", "약", "벧전", "벧후", "요일", "요이", "요삼", "유", "계" };
        string[] keywords = { "Genesis", "Exodus", "Leviticus", "Numbers", "Deuteronomy", "Joshua", "Judges", "Ruth", "1Samuel", "2Samuel", "1Kings", "2Kings",
                "1Chronicles", "2Chronicles", "Ezra", "Nehemiah", "Esther", "Job", "Psalms", "Proverbs", "Ecclesiastes", "SongOfSongs", "Isaiah", "Jeremiah",
                "Lamentations", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos", "Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi",
                "Matthew", "Mark", "Luke", "John", "Acts", "Romans", "1Corinthians", "2Corinthians", "Galatians", "Ephesians", "Philippians", "Colossians",
                "1Thessalonians", "2Thessalonians", "1Timothy", "2Timothy", "Titus", "Philemon", "Hebrews", "James", "1Peter", "2Peter", "1John", "2John", "3John", "Jude", "Revelation" };
        int[] chapterCount = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4, 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };

        string[] Collects = Directory.GetFiles(@"c:\Bible\ETC\BBB", "*.txt", SearchOption.AllDirectories);

        string folderPath = @"C:\Bible\ETC\CCC\";
        DirectoryInfo di = new DirectoryInfo(folderPath);

        if (di.Exists == false) di.Create(); // 만약 폴더가 존재하지 않으면

        string Keyword = string.Empty;
        string tempWord = string.Empty;

        for (int i = 0; i < Collects.Length; i++)
        {
            for (int j = 0; j < Koreankeywords.Length; j++)
            {
                if (Collects[i].Contains(Koreankeywords[j]))
                {
                    Keyword = Koreankeywords[j];
                    tempWord = Collects[i].Replace(Keyword, keywords[j] + "_");
                }
            }

            string oldFile = Path.GetFileNameWithoutExtension(tempWord);
            string newFile = folderPath + oldFile + ".txt";

            System.IO.File.Copy(Collects[i], newFile);
        }
    }

    string myString = "Hello World";

    public void TestTest(string bibleName)
    {
        TextAsset textFile; // 한글 성경 TextAsset을 저장할 변수입니다. 
        List<string> result = new List<string>();

        string[] keywordsNew = {
                "Matthew", "Mark", "Luke", "John", "Acts", "Romans", "1Corinthians", "2Corinthians", "Galatians", "Ephesians", "Philippians", "Colossians",
                "1Thessalonians", "2Thessalonians", "1Timothy", "2Timothy", "Titus", "Philemon", "Hebrews", "James", "1Peter", "2Peter", "1John", "2John", "3John", "Jude", "Revelation" };

        string[] keywordsOld = {"Genesis", "Exodus", "Leviticus", "Numbers", "Deuteronomy", "Joshua", "Judges", "Ruth", "1Samuel", "2Samuel", "1Kings", "2Kings",
                "1Chronicles", "2Chronicles", "Ezra", "Nehemiah", "Esther", "Job", "Psalms", "Proverbs", "Ecclesiastes", "SongOfSongs", "Isaiah", "Jeremiah",
                "Lamentations", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos", "Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi",};

        int[] chapterCountNew = { 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };

        int[] chapterCountOld = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4 };

        textFile = Resources.Load("International/" + bibleName) as TextAsset;

        result.Clear();
        StringReader stringReader = new StringReader(textFile.text); // textFile의 내용을 stringReader에 저장합니다. 

        while (stringReader.Peek() >= 0) // stringReader에 저장되어 있는 문자열이 끝이 아닐 때까지 반복합니다. 
        {
            string temp = stringReader.ReadLine(); // stringReader에서 라인을 읽어 옵니다. 
            result.Add(temp); // 결과 리스트에 저장해 줍니다. 
        }
        stringReader.Close();

        string path = @"c:\Bible\"; // 저장될 경로입니다. 
        StreamWriter streamWriter = new StreamWriter(path + bibleName + ".txt"); // 파일을 저장할 준비를 합니다. 

        for (int j = 0; j < result.Count; j++)
        {
            if (!string.IsNullOrEmpty(result[j])) streamWriter.WriteLine("- " + result[j]);
            else streamWriter.WriteLine(result[j]); // 결과 리스트를 파일에 저장합니다. 
        }

        streamWriter.Close();      
    }

    public void TestTestA()
    {
        TextAsset textFile; // 한글 성경 TextAsset을 저장할 변수입니다. 
        TextAsset textFileB; // 한글 성경 TextAsset을 저장할 변수입니다. 
        List<string> result = new List<string>();

        List<string> resultB = new List<string>();

        string bibleName = "Test";

        textFile = Resources.Load("ETC/" + "BibleAA") as TextAsset;
        textFileB = Resources.Load("ETC/" + "BibleB") as TextAsset;

        result.Clear();
        StringReader stringReader = new StringReader(textFile.text); // textFile의 내용을 stringReader에 저장합니다. 

        while (stringReader.Peek() >= 0) // stringReader에 저장되어 있는 문자열이 끝이 아닐 때까지 반복합니다. 
        {
            string temp = stringReader.ReadLine(); // stringReader에서 라인을 읽어 옵니다. 
            result.Add(temp); // 결과 리스트에 저장해 줍니다. 
        }
        stringReader.Close();

        resultB.Clear();
        stringReader = new StringReader(textFileB.text); // textFile의 내용을 stringReader에 저장합니다. 

        while (stringReader.Peek() >= 0) // stringReader에 저장되어 있는 문자열이 끝이 아닐 때까지 반복합니다. 
        {
            string temp = stringReader.ReadLine(); // stringReader에서 라인을 읽어 옵니다. 
            resultB.Add(temp); // 결과 리스트에 저장해 줍니다. 
        }
        stringReader.Close();

        string path = @"c:\Bible\"; // 저장될 경로입니다. 
        StreamWriter streamWriter = new StreamWriter(path + "BibleD" + ".txt"); // 파일을 저장할 준비를 합니다. 

        

        //for (int j = 0; j < resultB.Count; j++)
        //    streamWriter.WriteLine(resultB[j] + "_" + result[j]);

        for (int i = 0; i < resultB.Count; i++)
        {
            streamWriter.WriteLine(result[0]);
            streamWriter.WriteLine(resultB[i]);

            for (int j = 2; j < result.Count; j++)
            {
                streamWriter.WriteLine(resultB[i] + "_" + result[j]);
            }

            streamWriter.WriteLine(string.Empty);
        }


        //for (int i = 0; i < result.Count; i++)
        //{
        //    string Temp = result[i];
        //    string TempA = Temp.Substring(1, result[i].Length - 2);
        //    // streamWriter.WriteLine(result[i].Trim());
        //    streamWriter.WriteLine(TempA);
        //    //if (!string.IsNullOrEmpty(result[j])) streamWriter.WriteLine("- " + result[j]);
        //    //else streamWriter.WriteLine(result[j]); // 결과 리스트를 파일에 저장합니다. 
        //}

        streamWriter.Close();



        //TextAsset textFile; // 한글 성경 TextAsset을 저장할 변수입니다. 
        //List<string> result = new List<string>();

        //string bibleName = "Test";

        ////string[] keywordsNew = {
        ////        "Matthew", "Mark", "Luke", "John", "Acts", "Romans", "1Corinthians", "2Corinthians", "Galatians", "Ephesians", "Philippians", "Colossians",
        ////        "1Thessalonians", "2Thessalonians", "1Timothy", "2Timothy", "Titus", "Philemon", "Hebrews", "James", "1Peter", "2Peter", "1John", "2John", "3John", "Jude", "Revelation" };

        ////string[] keywordsOld = {"Genesis", "Exodus", "Leviticus", "Numbers", "Deuteronomy", "Joshua", "Judges", "Ruth", "1Samuel", "2Samuel", "1Kings", "2Kings",
        ////        "1Chronicles", "2Chronicles", "Ezra", "Nehemiah", "Esther", "Job", "Psalms", "Proverbs", "Ecclesiastes", "SongOfSongs", "Isaiah", "Jeremiah",
        ////        "Lamentations", "Ezekiel", "Daniel", "Hosea", "Joel", "Amos", "Obadiah", "Jonah", "Micah", "Nahum", "Habakkuk", "Zephaniah", "Haggai", "Zechariah", "Malachi",};

        ////int[] chapterCountNew = { 28, 16, 24, 21, 28, 16, 16, 13, 6, 6, 4, 4, 5, 3, 6, 4, 3, 1, 13, 5, 5, 3, 5, 1, 1, 1, 22 };

        ////int[] chapterCountOld = { 50, 40, 27, 36, 34, 24, 21, 4, 31, 24, 22, 25, 29, 36, 10, 13, 10, 42, 150, 31, 12, 8, 66, 52, 5, 48, 12, 14, 3, 9, 1, 4, 7, 3, 3, 3, 2, 14, 4 };

        //textFile = Resources.Load("ETC/" + bibleName) as TextAsset;

        //result.Clear();
        //StringReader stringReader = new StringReader(textFile.text); // textFile의 내용을 stringReader에 저장합니다. 

        //while (stringReader.Peek() >= 0) // stringReader에 저장되어 있는 문자열이 끝이 아닐 때까지 반복합니다. 
        //{
        //    string temp = stringReader.ReadLine(); // stringReader에서 라인을 읽어 옵니다. 
        //    result.Add(temp); // 결과 리스트에 저장해 줍니다. 
        //}
        //stringReader.Close();

        //string path = @"c:\Bible\"; // 저장될 경로입니다. 
        //StreamWriter streamWriter = new StreamWriter(path + bibleName + ".txt"); // 파일을 저장할 준비를 합니다. 

        //for (int i = 0; i < result.Count; i++)
        //{
        //    string Temp = result[i];
        //    string TempA = Temp.Substring(1, result[i].Length - 2);
        //    // streamWriter.WriteLine(result[i].Trim());
        //    streamWriter.WriteLine(TempA);
        //    //if (!string.IsNullOrEmpty(result[j])) streamWriter.WriteLine("- " + result[j]);
        //    //else streamWriter.WriteLine(result[j]); // 결과 리스트를 파일에 저장합니다. 
        //}

        //streamWriter.Close();





        //string[] Collects = Directory.GetFiles(@"c:\Bible\AAA", "*.md", SearchOption.AllDirectories);

        //string folderPath = @"c:\Bible\BBB\";
        //DirectoryInfo di = new DirectoryInfo(folderPath);

        //if (di.Exists == false) di.Create();

        //for (int i = 0; i < Collects.Length; i++)
        //{
        //    string textValue = System.IO.File.ReadAllText(Collects[i]);
        //    string oldFile = Path.GetFileNameWithoutExtension(Collects[i]);
        //    List<string> collectKorean = new List<string>(textValue.Split('\n'));
        //    StreamWriter streamWriter = new StreamWriter(folderPath + oldFile + ".md", true);

        //    // string keyword = @"###### ✟ ";
        //    string keywordA = @"#### ✞ ";
        //    string keywordB = @"#### ✟ ";

        //    for (int k = 0; k < collectKorean.Count - 1; k = k + 3)
        //    {
        //        //if (!string.IsNullOrEmpty(collectKorean[k]))
        //        //    streamWriter.WriteLine(keyword + collectKorean[k]);
        //        //else
        //        //    streamWriter.WriteLine("");
        //        //if (collectKorean[k] == string.Empty)
        //        //    streamWriter.WriteLine("");
        //        //else
        //        //    streamWriter.WriteLine(keyword + collectKorean[k]);
        //        streamWriter.WriteLine("");
        //        streamWriter.WriteLine(keywordB + collectKorean[k + 1]);
        //        streamWriter.WriteLine(keywordA + collectKorean[k + 2]);
        //    }

        //    streamWriter.Close();
        //}
    }

    void OnGUI()
    {
        Repaint();

        GUILayout.BeginVertical();
        {
            myString = EditorGUILayout.TextField("Input Name:", myString);

            if (GUILayout.Button("Test", GUILayout.Height(30)))
            {
                TestTest("InternationBibles");
            }

            if (GUILayout.Button("소중한 말씀", GUILayout.Height(30)))
            {
                TestTestA();
            }

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("파일 이름 영어로 변경A", GUILayout.Height(30)))
                {
                    ChangeFileNameToEnglishA();
                }

                if (GUILayout.Button("파일 이름 영어로 변경B", GUILayout.Height(30)))
                {
                    ChangeFileNameToEnglishB();
                }
            }
            GUILayout.EndHorizontal();

            if (GUILayout.Button("문장의 길이가 200자 이상일 때 처리", GUILayout.Height(30)))
            {
                GetOver200Characters();
            }

            GUILayout.BeginHorizontal();
            {
                // 10가지의 성경의 내용들을 출력 
                if (GUILayout.Button("10가지의 성경의 내용들을 출력", GUILayout.Height(30)))
                {
                    ExtractBible();
                }
                // 성경별로 각각의 챕터들의 절들이 몇 절들인가를 확인합니다. 
                if (GUILayout.Button("성경별로 각각의 챕터들의 절들이 몇 절들인가를 확인", GUILayout.Height(30)))
                {
                    CheckChapters();
                }
            }
            GUILayout.EndHorizontal();


            // 1189개의 쉬운성경의 파일들을 하나의 텍스트 파일로 생성하기 위한 이전 단계입니다. 한글
            if (GUILayout.Button("1189개의 쉬운성경의 파일들을 하나의 텍스트 파일로 생성하기 위한 이전 단계, 한글", GUILayout.Height(30)))
            {
                PreparationForCombineFilesKorean();
            }
            // 1189개의 쉬운성경의 파일들을 하나의 텍스트 파일로 생성하기 위한 이전 단계입니다. 영어
            if (GUILayout.Button("1189개의 쉬운성경의 파일들을 하나의 텍스트 파일로 생성하기 위한 이전 단계, 영어", GUILayout.Height(30)))
            {
                PreparationForCombineFilesEnglish();
            }
            // 1189개의 파일들을 하나의 파일로 생성합니다. 
            if (GUILayout.Button("1189개의 파일들을 하나의 파일로 생성", GUILayout.Height(30)))
            {
                Combine1189ToOne();
            }
            // 1189개의 텍스트 파일들을 하나의 텍스트 파일로 생성해 줍니다. 개별적으로 저장되어 있는 쉬운 성경과 NIV 성경 파일들을 하나의 파일로 묶기 위한 과정입니다. 
            if (GUILayout.Button("1189개의 텍스트 파일들을 하나의 텍스트 파일로 생성", GUILayout.Height(30)))
            {
                CreateOneTextFileInEachBable();
            }
            // 성경의 이름이 01로 시작한다면? 01을 "Gen"으로 변경합니다.
            if (GUILayout.Button("성경의 이름이 01로 시작한다면? 01을 \"Gen\"으로 변경", GUILayout.Height(30)))
            {
                CheckIfBibleIsStart01();
            }

            // 성경파일의 내용에 공백이 있다면 공백을 없애주고 저장합니다. 
            if (GUILayout.Button("성경파일의 내용에 공백이 있다면 공백을 없애주고 저장", GUILayout.Height(30)))
            {
                RemoveTheSpace();
            }
            // 언리얼을 위해서 CSV파일로 저장해 줍니다. 
            if (GUILayout.Button("언리얼을 위해서 CSV파일로 저장", GUILayout.Height(30)))
            {
                SaveCSV();
            }
            // 1. 한글이 보이도록 UTF8로 저장하기
            if (GUILayout.Button("문장의 길이가 200자 이상일 때 처리", GUILayout.Height(30)))
            {
                // SaveUTF8();
                ConvertOver200Characters();
            }
            // 하나의 영어 성경을 "장"별로 분리해 줍니다. 
            if (GUILayout.Button("영어 성경TXT파일을 각 장으로 나누기", GUILayout.Height(30)))
            {
                ConvertBibleEachEnglish("ESV_");
            }

            GUILayout.BeginHorizontal();
            {
                // 2. 성경TXT파일을 각 장으로 나누기
                if (GUILayout.Button("2. 성경TXT파일을 각 장으로 나누기", GUILayout.Height(30)))
                {
                    TextAsset[] textFiles = Resources.LoadAll<TextAsset>("ETC/");

                    TextAsset textFile = textFiles[0];
                    string fileName = Path.GetFileNameWithoutExtension(textFile.name);

                    bool isNewTestament = true;

                    string folder1 = "C:/Bible/DDD/" + fileName + "/";
                    DirectoryInfo di = new DirectoryInfo(folder1);
                    if (di.Exists == false) di.Create();

                    if (isNewTestament)
                    {
                        string folder2 = "C:/Bible/DDD/" + fileName + "/" + "New/";
                        DirectoryInfo di2 = new DirectoryInfo(folder2);
                        if (di2.Exists == false) di2.Create();
                    }
                    else
                    {
                        string folder2 = "C:/Bible/DDD/" + fileName + "/" + "Old/";
                        DirectoryInfo di2 = new DirectoryInfo(folder2);
                        if (di2.Exists == false) di2.Create();
                    }

                    Repaint();

                    ConvertBibleEach(fileName, isNewTestament);


                }
                // 성경의 내용의 "창1:1"에서 "창1:"를 없애 줍니다. 
                if (GUILayout.Button("3. 창세기1:1 에서 창세기1: 없애주기", GUILayout.Height(30)))
                {
                    RemoveFront();
                }
                // 성경의 내용의 "창1:1"에서 "창1:"를 없애 주었습니다. "1" 도 없애 줍니다. 
                if (GUILayout.Button("4. 1 도 없애주기", GUILayout.Height(30)))
                {
                    Remove1Other();
                }
            }
            GUILayout.EndHorizontal();
            // 성경파일이름의 영어를 한글로 변경
            if (GUILayout.Button("성경파일이름의 영어를 한글로 변경", GUILayout.Height(30)))
            {
                CopyFilesWithEnglishToKorean();
            }
            // 성경파일이름의 한글을 영어로 변경
            if (GUILayout.Button("성경파일이름의 한글을 영어로 변경", GUILayout.Height(30)))
            {
                CopyFilesWithKoreanToEnglish();
            }

            GUILayout.BeginHorizontal();
            {
                // Youtube 자막파일에서 특정 문자열 제거
                if (GUILayout.Button("Youtube 자막파일에서 특정 문자열 제거", GUILayout.Height(30)))
                {
                    RenameFilesA();
                }
                // Youtube 자막 정리
                if (GUILayout.Button("Youtube 자막 정리", GUILayout.Height(30)))
                {
                    YoutubeSubtitlesSummary();
                }
                // Youtube 자막에서 특정 단어 찾기
                if (GUILayout.Button("Youtube 자막에서 특정 단어 찾기", GUILayout.Height(30)))
                {
                    YoutubeSearch("병자");
                }
            }
            GUILayout.EndHorizontal();

            if (GUILayout.Button("하나로 합치기", GUILayout.Height(30)))
            {
                CombineToOne();
            }

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("CSV파일을 텍스트 파일로", GUILayout.Height(30)))
                {
                    CSV_To_Text();
                }

                if (GUILayout.Button("CSV파일을 텍스트 파일로_Other", GUILayout.Height(30)))
                {
                    CSV_To_TextOther();
                }
            }
            GUILayout.EndHorizontal();

            GUILayout.BeginHorizontal();
            {
                if (GUILayout.Button("신약성경 익스포트", GUILayout.Height(30)))
                {
                    ExportToNewTestament();
                }

                if (GUILayout.Button("구약성경 익스포트", GUILayout.Height(30)))
                {
                    ExportToOldTestament();
                }
            }
            GUILayout.EndHorizontal();

        }
        GUILayout.EndVertical();
    }    
}
