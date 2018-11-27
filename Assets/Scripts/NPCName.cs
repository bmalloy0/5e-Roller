using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPCName : MonoBehaviour {
    enum Gender {Male, Female};
    
    Gender gender;

    Text npcName, npcRace;

    public string HumanName(ref NPCBlock block)
    {
        string name = "";

        switch (Random.Range(1, 3))
        {
            case 1:
                gender = Gender.Female;
                block.race = ("Female " + block.race);
                break;
            case 2:
                gender = Gender.Male;
                block.race = ("Male " + block.race);
                break;
        }

        switch (Random.Range(1, 18))
        {
            case 1: name = HumanArabic(); break;
            case 2: name = HumanCeltic(); break;
            case 3: name = HumanChinese(); break;
            case 4: name = HumanEgyptian(); break;
            case 5: name = HumanEnglish(); break;
            case 6: name = HumanFrench(); break;
            case 7: name = HumanGerman(); break;
            case 8: name = HumanGreek(); break;
            case 9: name = HumanIndian(); break;
            case 10: name = HumanJapanese(); break;
            case 11: name = HumanMesoamerican(); break;
            case 12: name = HumanNigerCongo(); break;
            case 13: name = HumanNorse(); break;
            case 14: name = HumanPolynesian(); break;
            case 15: name = HumanRoman(); break;
            case 16: name = HumanSlavic(); break;
            case 17: name = HumanSpanish(); break;
        }

        return name;
    }

    #region Human Names
    public string HumanArabic()
    {
        string givenName;
        givenName = "";

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Aaliyah"; break;
                case 2: givenName = "Aida"; break;
                case 3: givenName = "Akilah"; break;
                case 4: givenName = "Alia"; break;
                case 5: givenName = "Amina"; break;
                case 6: givenName = "Atefeh"; break;
                case 7: givenName = "Chaima"; break;
                case 8: givenName = "Dalia"; break;
                case 9: givenName = "Ehsan"; break;
                case 10: givenName = "Elham"; break;
                case 11: givenName = "Farah"; break;
                case 12: givenName = "Fatemah"; break;
                case 13: givenName = "Gamila"; break;
                case 14: givenName = "Iesha"; break;
                case 15: givenName = "Inbar"; break;
                case 16: givenName = "Kamaria"; break;
                case 17: givenName = "Khadija"; break;
                case 18: givenName = "Layla"; break;
                case 19: givenName = "Lupe"; break;
                case 20: givenName = "Nabila"; break;
                case 21: givenName = "Nadine"; break;
                case 22: givenName = "Naima"; break;
                case 23: givenName = "Najila"; break;
                case 24: givenName = "Najwa"; break;
                case 25: givenName = "Nakia"; break;
                case 26: givenName = "Nashwa"; break;
                case 27: givenName = "Nawra"; break;
                case 28: givenName = "Nuha"; break;
                case 29: givenName = "Nura"; break;
                case 30: givenName = "Oma"; break;
                case 31: givenName = "Qadira"; break;
                case 32: givenName = "Qamar"; break;
                case 33: givenName = "Qistina"; break;
                case 34: givenName = "Rahima"; break;
                case 35: givenName = "Rihanna"; break;
                case 36: givenName = "Saadia"; break;
                case 37: givenName = "Sabah"; break;
                case 38: givenName = "Sada"; break;
                case 39: givenName = "Saffron"; break;
                case 40: givenName = "Sahar"; break;
                case 41: givenName = "Salma"; break;
                case 42: givenName = "Satha"; break;
                case 43: givenName = "Tahira"; break;
                case 44: givenName = "Takisha"; break;
                case 45: givenName = "Thana"; break;
                case 46: givenName = "Yadira"; break;
                case 47: givenName = "Zahra"; break;
                case 48: givenName = "Zaida"; break;
                case 49: givenName = "Zaina"; break;
                case 50: givenName = "Zeinab"; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Abbad"; break;
                case 2: givenName = "Abdul"; break;
                case 3: givenName = "Achmed"; break;
                case 4: givenName = "Akeem"; break;
                case 5: givenName = "Alif"; break;
                case 6: givenName = "Amir"; break;
                case 7: givenName = "Asim"; break;
                case 8: givenName = "Bashir"; break;
                case 9: givenName = "Bassam"; break;
                case 10: givenName = "Fahim"; break;
                case 11: givenName = "Farid"; break;
                case 12: givenName = "Farouk"; break;
                case 13: givenName = "Fayez"; break;
                case 14: givenName = "Fayyaad"; break;
                case 15: givenName = "Fazil"; break;
                case 16: givenName = "Hakim"; break;
                case 17: givenName = "Halil"; break;
                case 18: givenName = "Hamid"; break;
                case 19: givenName = "Hazim"; break;
                case 20: givenName = "Heydar"; break;
                case 21: givenName = "Hussein"; break;
                case 22: givenName = "Jabari"; break;
                case 23: givenName = "Jafar"; break;
                case 24: givenName = "Jahid"; break;
                case 25: givenName = "Jamal"; break;
                case 26: givenName = "Kalim"; break;
                case 27: givenName = "Karim"; break;
                case 28: givenName = "Kazim"; break;
                case 29: givenName = "Khadim"; break;
                case 30: givenName = "Khalid"; break;
                case 31: givenName = "Mahmud"; break;
                case 32: givenName = "Mansour"; break;
                case 33: givenName = "Musharraf"; break;
                case 34: givenName = "Mustafa"; break;
                case 35: givenName = "Nadir"; break;
                case 36: givenName = "Nazim"; break;
                case 37: givenName = "Omar"; break;
                case 38: givenName = "Qadir"; break;
                case 39: givenName = "Qusay"; break;
                case 40: givenName = "Rafiq"; break;
                case 41: givenName = "Rakim"; break;
                case 42: givenName = "Rashad"; break;
                case 43: givenName = "Rauf"; break;
                case 44: givenName = "Saladin"; break;
                case 45: givenName = "Sami"; break;
                case 46: givenName = "Samir"; break;
                case 47: givenName = "Talib"; break;
                case 48: givenName = "Tamir"; break;
                case 49: givenName = "Tariq"; break;
                case 50: givenName = "Yazid"; break;
            }
        }
        
        return (givenName);
    }
    public string HumanCeltic()
    {
        string givenName;
        givenName = "";

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Aife"; break;
                case 2: givenName = "Aina"; break;
                case 3: givenName = "Alane"; break;
                case 4: givenName = "Ardena"; break;
                case 5: givenName = "Arienh"; break;
                case 6: givenName = "Beatha"; break;
                case 7: givenName = "Birgit"; break;
                case 8: givenName = "Briann"; break;
                case 9: givenName = "Caomh"; break;
                case 10: givenName = "Cara"; break;
                case 11: givenName = "Cinnia"; break;
                case 12: givenName = "Cordelia"; break;
                case 13: givenName = "Dehune"; break;
                case 14: givenName = "Divone"; break;
                case 15: givenName = "Donia"; break;
                case 16: givenName = "Doreena"; break;
                case 17: givenName = "Elsha"; break;
                case 18: givenName = "Enid"; break;
                case 19: givenName = "Ethne"; break;
                case 20: givenName = "Evelina"; break;
                case 21: givenName = "Fianna"; break;
                case 22: givenName = "Genevieve"; break;
                case 23: givenName = "Gilda"; break;
                case 24: givenName = "Gitta"; break;
                case 25: givenName = "Grania"; break;
                case 26: givenName = "Gwyndolin"; break;
                case 27: givenName = "Idelisa"; break;
                case 28: givenName = "Isolde"; break;
                case 29: givenName = "Keelin"; break;
                case 30: givenName = "Kennocha"; break;
                case 31: givenName = "Lavena"; break;
                case 32: givenName = "Lesley"; break;
                case 33: givenName = "Linnette"; break;
                case 34: givenName = "Lyonesse"; break;
                case 35: givenName = "Mabina"; break;
                case 36: givenName = "Marvina"; break;
                case 37: givenName = "Mavis"; break;
                case 38: givenName = "Mirna"; break;
                case 39: givenName = "Morgan"; break;
                case 40: givenName = "Muriel"; break;
                case 41: givenName = "Nareena"; break;
                case 42: givenName = "Oriana"; break;
                case 43: givenName = "Regan"; break;
                case 44: givenName = "Ronat"; break;
                case 45: givenName = "Rowena"; break;
                case 46: givenName = "Selma"; break;
                case 47: givenName = "Ula"; break;
                case 48: givenName = "Venetia"; break;
                case 49: givenName = "Wynne"; break;
                case 50: givenName = "Yseult"; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Airell"; break;
                case 2: givenName = "Airic"; break;
                case 3: givenName = "Alan"; break;
                case 4: givenName = "Anghus"; break;
                case 5: givenName = "Aodh"; break;
                case 6: givenName = "Bardon"; break;
                case 7: givenName = "Bearacb"; break;
                case 8: givenName = "Bevyn"; break;
                case 9: givenName = "Boden"; break;
                case 10: givenName = "Bran"; break;
                case 11: givenName = "Brasil"; break;
                case 12: givenName = "Bredon"; break;
                case 13: givenName = "Brian"; break;
                case 14: givenName = "Bricriu"; break;
                case 15: givenName = "Bryant"; break;
                case 16: givenName = "Cadman"; break;
                case 17: givenName = "Caradoc"; break;
                case 18: givenName = "Cedric"; break;
                case 19: givenName = "Conalt"; break;
                case 20: givenName = "Conchobar"; break;
                case 21: givenName = "Condon"; break;
                case 22: givenName = "Darcy"; break;
                case 23: givenName = "Devin"; break;
                case 24: givenName = "Dillion"; break;
                case 25: givenName = "Donaghy"; break;
                case 26: givenName = "Donall"; break;
                case 27: givenName = "Duer"; break;
                case 28: givenName = "Eghan"; break;
                case 29: givenName = "Ewyn"; break;
                case 30: givenName = "Ferghus"; break;
                case 31: givenName = "Galvyn"; break;
                case 32: givenName = "Gildas"; break;
                case 33: givenName = "Guy"; break;
                case 34: givenName = "Harvey"; break;
                case 35: givenName = "Iden"; break;
                case 36: givenName = "Irven"; break;
                case 37: givenName = "Karney"; break;
                case 38: givenName = "Kayne"; break;
                case 39: givenName = "Kelvyn"; break;
                case 40: givenName = "Kunsgnos"; break;
                case 41: givenName = "Leigh"; break;
                case 42: givenName = "Maccus"; break;
                case 43: givenName = "Moryn"; break;
                case 44: givenName = "Neale"; break;
                case 45: givenName = "Owyn"; break;
                case 46: givenName = "Pryderi"; break;
                case 47: givenName = "Reaghan"; break;
                case 48: givenName = "Taliesin"; break;
                case 49: givenName = "Tiernay"; break;
                case 50: givenName = "Turi"; break;
            }
        }
        
        return (givenName);
    }
    public string HumanChinese() {
        string givenName, lastName;
        givenName = "";
        lastName = "";

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Ai"; break;
                case 2: givenName = "Anming"; break;
                case 3: givenName = "Baozhai"; break;
                case 4: givenName = "Bei"; break;
                case 5: givenName = "Caixia"; break;
                case 6: givenName = "Changchang"; break;
                case 7: givenName = "Chen"; break;
                case 8: givenName = "Chou"; break;
                case 9: givenName = "Chunhua"; break;
                case 10: givenName = "Daianna"; break;
                case 11: givenName = "Daiyu"; break;
                case 12: givenName = "Die"; break;
                case 13: givenName = "Ehuang"; break;
                case 14: givenName = "Fenfang"; break;
                case 15: givenName = "Ge"; break;
                case 16: givenName = "Hong"; break;
                case 17: givenName = "Huan"; break;
                case 18: givenName = "Huifang"; break;
                case 19: givenName = "Jia"; break;
                case 20: givenName = "Jiao"; break;
                case 21: givenName = "Jiaying"; break;
                case 22: givenName = "Jingfei"; break;
                case 23: givenName = "Jinjing"; break;
                case 24: givenName = "Lan"; break;
                case 25: givenName = "Li"; break;
                case 26: givenName = "Lihua"; break;
                case 27: givenName = "Lin"; break;
                case 28: givenName = "Ling"; break;
                case 29: givenName = "Liu"; break;
                case 30: givenName = "Meili"; break;
                case 31: givenName = "Ning"; break;
                case 32: givenName = "Qi"; break;
                case 33: givenName = "Qiao"; break;
                case 34: givenName = "Rong"; break;
                case 35: givenName = "Shu"; break;
                case 36: givenName = "Shuang"; break;
                case 37: givenName = "Song"; break;
                case 38: givenName = "Ting"; break;
                case 39: givenName = "Wen"; break;
                case 40: givenName = "Xia"; break;
                case 41: givenName = "Xiaodan"; break;
                case 42: givenName = "Xiaoli"; break;
                case 43: givenName = "Xingjuan"; break;
                case 44: givenName = "Xue"; break;
                case 45: givenName = "Ya"; break;
                case 46: givenName = "Yan"; break;
                case 47: givenName = "Ying"; break;
                case 48: givenName = "Yuan"; break;
                case 49: givenName = "Yue"; break;
                case 50: givenName = "Yun"; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Bingwen"; break;
                case 2: givenName = "Bo"; break;
                case 3: givenName = "Bolin"; break;
                case 4: givenName = "Chang"; break;
                case 5: givenName = "Chao"; break;
                case 6: givenName = "Chen"; break;
                case 7: givenName = "Cheng"; break;
                case 8: givenName = "Da"; break;
                case 9: givenName = "Dingxiang"; break;
                case 10: givenName = "Fang"; break;
                case 11: givenName = "Feng"; break;
                case 12: givenName = "Fu"; break;
                case 13: givenName = "Gang"; break;
                case 14: givenName = "Guang"; break;
                case 15: givenName = "Hai"; break;
                case 16: givenName = "Heng"; break;
                case 17: givenName = "Hong"; break;
                case 18: givenName = "Huan"; break;
                case 19: givenName = "Huang"; break;
                case 20: givenName = "Huiliang"; break;
                case 21: givenName = "Huizhong"; break;
                case 22: givenName = "Jian"; break;
                case 23: givenName = "Jiayi"; break;
                case 24: givenName = "Junjie"; break;
                case 25: givenName = "Kang"; break;
                case 26: givenName = "Lei"; break;
                case 27: givenName = "Liang"; break;
                case 28: givenName = "Ling"; break;
                case 29: givenName = "Liwei"; break;
                case 30: givenName = "Meilin"; break;
                case 31: givenName = "Niu"; break;
                case 32: givenName = "Peizhi"; break;
                case 33: givenName = "Peng"; break;
                case 34: givenName = "Ping"; break;
                case 35: givenName = "Qiang"; break;
                case 36: givenName = "Qiu"; break;
                case 37: givenName = "Quan"; break;
                case 38: givenName = "Renshu"; break;
                case 39: givenName = "Rong"; break;
                case 40: givenName = "Ru"; break;
                case 41: givenName = "Shan"; break;
                case 42: givenName = "Shen"; break;
                case 43: givenName = "Tengfei"; break;
                case 44: givenName = "Wei"; break;
                case 45: givenName = "Xiaobo"; break;
                case 46: givenName = "Xiaoli"; break;
                case 47: givenName = "Xin"; break;
                case 48: givenName = "Yang"; break;
                case 49: givenName = "Ying"; break;
                case 50: givenName = "Zhong"; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: lastName = ""; break;
            case 2: lastName = ""; break;
            case 3: lastName = ""; break;
            case 4: lastName = ""; break;
            case 5: lastName = ""; break;
            case 6: lastName = ""; break;
            case 7: lastName = ""; break;
            case 8: lastName = ""; break;
            case 9: lastName = ""; break;
            case 10: lastName = ""; break;
            case 11: lastName = ""; break;
            case 12: lastName = ""; break;
            case 13: lastName = ""; break;
            case 14: lastName = ""; break;
            case 15: lastName = ""; break;
            case 16: lastName = ""; break;
            case 17: lastName = ""; break;
            case 18: lastName = ""; break;
            case 19: lastName = ""; break;
            case 20: lastName = ""; break;
            case 21: lastName = ""; break;
            case 22: lastName = ""; break;
            case 23: lastName = ""; break;
            case 24: lastName = ""; break;
            case 25: lastName = ""; break;
            case 26: lastName = ""; break;
            case 27: lastName = ""; break;
            case 28: lastName = ""; break;
            case 29: lastName = ""; break;
            case 30: lastName = ""; break;
            case 31: lastName = ""; break;
            case 32: lastName = ""; break;
            case 33: lastName = ""; break;
            case 34: lastName = ""; break;
            case 35: lastName = ""; break;
            case 36: lastName = ""; break;
            case 37: lastName = ""; break;
            case 38: lastName = ""; break;
            case 39: lastName = ""; break;
            case 40: lastName = ""; break;
            case 41: lastName = ""; break;
            case 42: lastName = ""; break;
            case 43: lastName = ""; break;
            case 44: lastName = ""; break;
            case 45: lastName = ""; break;
            case 46: lastName = ""; break;
            case 47: lastName = ""; break;
            case 48: lastName = ""; break;
            case 49: lastName = ""; break;
            case 50: lastName = ""; break;
        }

        return (givenName + ' ' + lastName);
    }
    public string HumanEgyptian() {
        string givenName, lastName;
        givenName = "";
        lastName = "";

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "A'at"; break;
                case 2: givenName = "Ahset"; break;
                case 3: givenName = "Amunet"; break;
                case 4: givenName = "Aneksi"; break;
                case 5: givenName = "Atet"; break;
                case 6: givenName = "Baketamon"; break;
                case 7: givenName = "Betrest"; break;
                case 8: givenName = "Bunefer"; break;
                case 9: givenName = "Dedyet"; break;
                case 10: givenName = "Hatshepsut"; break;
                case 11: givenName = "Hentie"; break;
                case 12: givenName = "Herit"; break;
                case 13: givenName = "Hetepheres"; break;
                case 14: givenName = "Intakes"; break;
                case 15: givenName = "Ipwet"; break;
                case 16: givenName = "Itet"; break;
                case 17: givenName = "Joba"; break;
                case 18: givenName = "Kasmut"; break;
                case 19: givenName = "Kemanub"; break;
                case 20: givenName = "Khemut"; break;
                case 21: givenName = "Kiya"; break;
                case 22: givenName = "Maia"; break;
                case 23: givenName = "Menhet"; break;
                case 24: givenName = "Merit"; break;
                case 25: givenName = "Meritamen"; break;
                case 26: givenName = "Merneith"; break;
                case 27: givenName = "Merseger"; break;
                case 28: givenName = "Muyet"; break;
                case 29: givenName = "Nebet"; break;
                case 30: givenName = "Nebetah"; break;
                case 31: givenName = "Nedjemmut"; break;
                case 32: givenName = "Nefertiti"; break;
                case 33: givenName = "Neferu"; break;
                case 34: givenName = "Neithotep"; break;
                case 35: givenName = "Nit"; break;
                case 36: givenName = "Nofret"; break;
                case 37: givenName = "Nubemiunu"; break;
                case 38: givenName = "Peseshet"; break;
                case 39: givenName = "Pyguy"; break;
                case 40: givenName = "Qalhata"; break;
                case 41: givenName = "Rai"; break;
                case 42: givenName = "Redji"; break;
                case 43: givenName = "Sadeh"; break;
                case 44: givenName = "Sadek"; break;
                case 45: givenName = "Sitamun"; break;
                case 46: givenName = "Sitre"; break;
                case 47: givenName = "Takhat"; break;
                case 48: givenName = "Tarset"; break;
                case 49: givenName = "Taweret"; break;
                case 50: givenName = "Werenro"; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Ahmose"; break;
                case 2: givenName = "Akhom"; break;
                case 3: givenName = "Amasis"; break;
                case 4: givenName = "Amenemhet"; break;
                case 5: givenName = "Anen"; break;
                case 6: givenName = "Banefre"; break;
                case 7: givenName = "Bek"; break;
                case 8: givenName = "Djedefre"; break;
                case 9: givenName = "Djoser"; break;
                case 10: givenName = "Hekaib"; break;
                case 11: givenName = "Henenu"; break;
                case 12: givenName = "Horemheb"; break;
                case 13: givenName = "Horwedja"; break;
                case 14: givenName = "Huya"; break;
                case 15: givenName = "Idebi"; break;
                case 16: givenName = "Idu"; break;
                case 17: givenName = "Imhotep"; break;
                case 18: givenName = "Ineni"; break;
                case 19: givenName = "Ipuki"; break;
                case 20: givenName = "Irsu"; break;
                case 21: givenName = "Kagemni"; break;
                case 22: givenName = "Kawab"; break;
                case 23: givenName = "Kenamon"; break;
                case 24: givenName = "Kewap"; break;
                case 25: givenName = "Khaemwaset"; break;
                case 26: givenName = "Khafra"; break;
                case 27: givenName = "Khusbek"; break;
                case 28: givenName = "Masaharta"; break;
                case 29: givenName = "Meketre"; break;
                case 30: givenName = "Menkhaf"; break;
                case 31: givenName = "Merenre"; break;
                case 32: givenName = "Metjen"; break;
                case 33: givenName = "Nebamun"; break;
                case 34: givenName = "Nebetka"; break;
                case 35: givenName = "Nehi"; break;
                case 36: givenName = "Nekure"; break;
                case 37: givenName = "Nessumontu"; break;
                case 38: givenName = "Pakhom"; break;
                case 39: givenName = "Pawah"; break;
                case 40: givenName = "Pawero"; break;
                case 41: givenName = "Ramose"; break;
                case 42: givenName = "Rudjek"; break;
                case 43: givenName = "Sabaf"; break;
                case 44: givenName = "Sebek-khu"; break;
                case 45: givenName = "Sebni"; break;
                case 46: givenName = "Senusret"; break;
                case 47: givenName = "Shabaka"; break;
                case 48: givenName = "Somintu"; break;
                case 49: givenName = "Thaneni"; break;
                case 50: givenName = "Theti"; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: lastName = ""; break;
            case 2: lastName = ""; break;
            case 3: lastName = ""; break;
            case 4: lastName = ""; break;
            case 5: lastName = ""; break;
            case 6: lastName = ""; break;
            case 7: lastName = ""; break;
            case 8: lastName = ""; break;
            case 9: lastName = ""; break;
            case 10: lastName = ""; break;
            case 11: lastName = ""; break;
            case 12: lastName = ""; break;
            case 13: lastName = ""; break;
            case 14: lastName = ""; break;
            case 15: lastName = ""; break;
            case 16: lastName = ""; break;
            case 17: lastName = ""; break;
            case 18: lastName = ""; break;
            case 19: lastName = ""; break;
            case 20: lastName = ""; break;
            case 21: lastName = ""; break;
            case 22: lastName = ""; break;
            case 23: lastName = ""; break;
            case 24: lastName = ""; break;
            case 25: lastName = ""; break;
            case 26: lastName = ""; break;
            case 27: lastName = ""; break;
            case 28: lastName = ""; break;
            case 29: lastName = ""; break;
            case 30: lastName = ""; break;
            case 31: lastName = ""; break;
            case 32: lastName = ""; break;
            case 33: lastName = ""; break;
            case 34: lastName = ""; break;
            case 35: lastName = ""; break;
            case 36: lastName = ""; break;
            case 37: lastName = ""; break;
            case 38: lastName = ""; break;
            case 39: lastName = ""; break;
            case 40: lastName = ""; break;
            case 41: lastName = ""; break;
            case 42: lastName = ""; break;
            case 43: lastName = ""; break;
            case 44: lastName = ""; break;
            case 45: lastName = ""; break;
            case 46: lastName = ""; break;
            case 47: lastName = ""; break;
            case 48: lastName = ""; break;
            case 49: lastName = ""; break;
            case 50: lastName = ""; break;
        }

        return (givenName + ' ' + lastName);
    }
    public string HumanEnglish() {
        string givenName, lastName;
        givenName = "";
        lastName = "";

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Adelaide"; break;
                case 2: givenName = "Agatha"; break;
                case 3: givenName = "Agnes"; break;
                case 4: givenName = "Alice"; break;
                case 5: givenName = "Aline"; break;
                case 6: givenName = "Anne"; break;
                case 7: givenName = "Avelina"; break;
                case 8: givenName = "Avice"; break;
                case 9: givenName = "Beatrice"; break;
                case 10: givenName = "Cecily"; break;
                case 11: givenName = "Egelina"; break;
                case 12: givenName = "Eleanor"; break;
                case 13: givenName = "Elizabeth"; break;
                case 14: givenName = "Ella"; break;
                case 15: givenName = "Eloise"; break;
                case 16: givenName = "Elysande"; break;
                case 17: givenName = "Emeny"; break;
                case 18: givenName = "Emma"; break;
                case 19: givenName = "Emmeline"; break;
                case 20: givenName = "Ermina"; break;
                case 21: givenName = "Eva"; break;
                case 22: givenName = "Galiena"; break;
                case 23: givenName = "Geva"; break;
                case 24: givenName = "Giselle"; break;
                case 25: givenName = "Griselda"; break;
                case 26: givenName = "Hadwisa"; break;
                case 27: givenName = "Helen"; break;
                case 28: givenName = "Herleva"; break;
                case 29: givenName = "Hugolina"; break;
                case 30: givenName = "Ida"; break;
                case 31: givenName = "Isabella"; break;
                case 32: givenName = "Jacoba"; break;
                case 33: givenName = "Jane"; break;
                case 34: givenName = "Joan"; break;
                case 35: givenName = "Juliana"; break;
                case 36: givenName = "Katherine"; break;
                case 37: givenName = "Margery"; break;
                case 38: givenName = "Mary"; break;
                case 39: givenName = "Matilda"; break;
                case 40: givenName = "Maynild"; break;
                case 41: givenName = "Millicent"; break;
                case 42: givenName = "Oriel"; break;
                case 43: givenName = "Rohesia"; break;
                case 44: givenName = "Rosalind"; break;
                case 45: givenName = "Rosamund"; break;
                case 46: givenName = "Sarah"; break;
                case 47: givenName = "Susannah"; break;
                case 48: givenName = "Sybil"; break;
                case 49: givenName = "Williamina"; break;
                case 50: givenName = "Yvonne"; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Adam"; break;
                case 2: givenName = "Adelard"; break;
                case 3: givenName = "Aldous"; break;
                case 4: givenName = "Anselm"; break;
                case 5: givenName = "Arnold"; break;
                case 6: givenName = "Bernard"; break;
                case 7: givenName = "Bertram"; break;
                case 8: givenName = "Charles"; break;
                case 9: givenName = "Clerebold"; break;
                case 10: givenName = "Conrad"; break;
                case 11: givenName = "Diggory"; break;
                case 12: givenName = "Drogo"; break;
                case 13: givenName = "Everard"; break;
                case 14: givenName = "Frederick"; break;
                case 15: givenName = "Geoffrey"; break;
                case 16: givenName = "Gerald"; break;
                case 17: givenName = "Gilbert"; break;
                case 18: givenName = "Godfrey"; break;
                case 19: givenName = "Gunter"; break;
                case 20: givenName = "Guy"; break;
                case 21: givenName = "Henry"; break;
                case 22: givenName = "Heward"; break;
                case 23: givenName = "Hubert"; break;
                case 24: givenName = "Hugh"; break;
                case 25: givenName = "Jocelyn"; break;
                case 26: givenName = "John"; break;
                case 27: givenName = "Lance"; break;
                case 28: givenName = "Manfred"; break;
                case 29: givenName = "Miles"; break;
                case 30: givenName = "Nicholas"; break;
                case 31: givenName = "Norman"; break;
                case 32: givenName = "Odo"; break;
                case 33: givenName = "Percival"; break;
                case 34: givenName = "Peter"; break;
                case 35: givenName = "Ralf"; break;
                case 36: givenName = "Randal"; break;
                case 37: givenName = "Raymond"; break;
                case 38: givenName = "Reynard"; break;
                case 39: givenName = "Richard"; break;
                case 40: givenName = "Robert"; break;
                case 41: givenName = "Roger"; break;
                case 42: givenName = "Roland"; break;
                case 43: givenName = "Rolf"; break;
                case 44: givenName = "Simon"; break;
                case 45: givenName = "Thobald"; break;
                case 46: givenName = "Theodoric"; break;
                case 47: givenName = "Thomas"; break;
                case 48: givenName = "Timm"; break;
                case 49: givenName = "William"; break;
                case 50: givenName = "Wymar"; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: lastName = ""; break;
            case 2: lastName = ""; break;
            case 3: lastName = ""; break;
            case 4: lastName = ""; break;
            case 5: lastName = ""; break;
            case 6: lastName = ""; break;
            case 7: lastName = ""; break;
            case 8: lastName = ""; break;
            case 9: lastName = ""; break;
            case 10: lastName = ""; break;
            case 11: lastName = ""; break;
            case 12: lastName = ""; break;
            case 13: lastName = ""; break;
            case 14: lastName = ""; break;
            case 15: lastName = ""; break;
            case 16: lastName = ""; break;
            case 17: lastName = ""; break;
            case 18: lastName = ""; break;
            case 19: lastName = ""; break;
            case 20: lastName = ""; break;
            case 21: lastName = ""; break;
            case 22: lastName = ""; break;
            case 23: lastName = ""; break;
            case 24: lastName = ""; break;
            case 25: lastName = ""; break;
            case 26: lastName = ""; break;
            case 27: lastName = ""; break;
            case 28: lastName = ""; break;
            case 29: lastName = ""; break;
            case 30: lastName = ""; break;
            case 31: lastName = ""; break;
            case 32: lastName = ""; break;
            case 33: lastName = ""; break;
            case 34: lastName = ""; break;
            case 35: lastName = ""; break;
            case 36: lastName = ""; break;
            case 37: lastName = ""; break;
            case 38: lastName = ""; break;
            case 39: lastName = ""; break;
            case 40: lastName = ""; break;
            case 41: lastName = ""; break;
            case 42: lastName = ""; break;
            case 43: lastName = ""; break;
            case 44: lastName = ""; break;
            case 45: lastName = ""; break;
            case 46: lastName = ""; break;
            case 47: lastName = ""; break;
            case 48: lastName = ""; break;
            case 49: lastName = ""; break;
            case 50: lastName = ""; break;
        }

        return (givenName + ' ' + lastName);
    }
    public string HumanFrench() {
        string givenName, lastName;
        givenName = "";
        lastName = "";

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Aalis"; break;
                case 2: givenName = "Agatha"; break;
                case 3: givenName = "Agnez"; break;
                case 4: givenName = "Alberea"; break;
                case 5: givenName = "Alips"; break;
                case 6: givenName = "Amee"; break;
                case 7: givenName = "Amelot"; break;
                case 8: givenName = "Anne"; break;
                case 9: givenName = "Avelina"; break;
                case 10: givenName = "Blancha"; break;
                case 11: givenName = "Cateline"; break;
                case 12: givenName = "Cecilia"; break;
                case 13: givenName = "Claricia"; break;
                case 14: givenName = "Collette"; break;
                case 15: givenName = "Denisete"; break;
                case 16: givenName = "Dorian"; break;
                case 17: givenName = "Edelina"; break;
                case 18: givenName = "Emelina"; break;
                case 19: givenName = "Emmelot"; break;
                case 20: givenName = "Ermentrudis"; break;
                case 21: givenName = "Gibelina"; break;
                case 22: givenName = "Gila"; break;
                case 23: givenName = "Gillette"; break;
                case 24: givenName = "Guiburgis"; break;
                case 25: givenName = "Guillemette"; break;
                case 26: givenName = "Guoite"; break;
                case 27: givenName = "Hecelina"; break;
                case 28: givenName = "Heloysis"; break;
                case 29: givenName = "Helyoudis"; break;
                case 30: givenName = "Hodeardis"; break;
                case 31: givenName = "Isabellis"; break;
                case 32: givenName = "Jaquette"; break;
                case 33: givenName = "Jehan"; break;
                case 34: givenName = "Johanna"; break;
                case 35: givenName = "Juiliote"; break;
                case 36: givenName = "Katerine"; break;
                case 37: givenName = "Lucianna"; break;
                case 38: givenName = "Margot"; break;
                case 39: givenName = "Marguerite"; break;
                case 40: givenName = "Maria"; break;
                case 41: givenName = "Marie"; break;
                case 42: givenName = "Melisende"; break;
                case 43: givenName = "Odelina"; break;
                case 44: givenName = "Perrette"; break;
                case 45: givenName = "Petronilla"; break;
                case 46: givenName = "Sedilia"; break;
                case 47: givenName = "Stephana"; break;
                case 48: givenName = "Sybilla"; break;
                case 49: givenName = "Ysabeau"; break;
                case 50: givenName = "Ysabel"; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Ambroys"; break;
                case 2: givenName = "Ame"; break;
                case 3: givenName = "Andri"; break;
                case 4: givenName = "Andriet"; break;
                case 5: givenName = "Anthione"; break;
                case 6: givenName = "Bernard"; break;
                case 7: givenName = "Charles"; break;
                case 8: givenName = "Charlot"; break;
                case 9: givenName = "Colin"; break;
                case 10: givenName = "Denis"; break;
                case 11: givenName = "Durant"; break;
                case 12: givenName = "Edouart"; break;
                case 13: givenName = "Eremon"; break;
                case 14: givenName = "Ernault"; break;
                case 15: givenName = "Ethor"; break;
                case 16: givenName = "Felix"; break;
                case 17: givenName = "Floquart"; break;
                case 18: givenName = "Gelleren"; break;
                case 19: givenName = "Gaultier"; break;
                case 20: givenName = "Gilles"; break;
                case 21: givenName = "Guy"; break;
                case 22: givenName = "Henry"; break;
                case 23: givenName = "Hugo"; break;
                case 24: givenName = "Imbert"; break;
                case 25: givenName = "Jacques"; break;
                case 26: givenName = "Jacquot"; break;
                case 27: givenName = "Jean"; break;
                case 28: givenName = "Jehannin"; break;
                case 29: givenName = "Louis"; break;
                case 30: givenName = "Louys"; break;
                case 31: givenName = "Loys"; break;
                case 32: givenName = "Martin"; break;
                case 33: givenName = "Michel"; break;
                case 34: givenName = "Mille"; break;
                case 35: givenName = "Morelet"; break;
                case 36: givenName = "Nicolas"; break;
                case 37: givenName = "Nicolle"; break;
                case 38: givenName = "Oudart"; break;
                case 39: givenName = "Perrin"; break;
                case 40: givenName = "Philippe"; break;
                case 41: givenName = "Pierre"; break;
                case 42: givenName = "Regnault"; break;
                case 43: givenName = "Richart"; break;
                case 44: givenName = "Robert"; break;
                case 45: givenName = "Robinet"; break;
                case 46: givenName = "Sauvage"; break;
                case 47: givenName = "Simon"; break;
                case 48: givenName = "Talbot"; break;
                case 49: givenName = "Tanguy"; break;
                case 50: givenName = "Vincent"; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: lastName = ""; break;
            case 2: lastName = ""; break;
            case 3: lastName = ""; break;
            case 4: lastName = ""; break;
            case 5: lastName = ""; break;
            case 6: lastName = ""; break;
            case 7: lastName = ""; break;
            case 8: lastName = ""; break;
            case 9: lastName = ""; break;
            case 10: lastName = ""; break;
            case 11: lastName = ""; break;
            case 12: lastName = ""; break;
            case 13: lastName = ""; break;
            case 14: lastName = ""; break;
            case 15: lastName = ""; break;
            case 16: lastName = ""; break;
            case 17: lastName = ""; break;
            case 18: lastName = ""; break;
            case 19: lastName = ""; break;
            case 20: lastName = ""; break;
            case 21: lastName = ""; break;
            case 22: lastName = ""; break;
            case 23: lastName = ""; break;
            case 24: lastName = ""; break;
            case 25: lastName = ""; break;
            case 26: lastName = ""; break;
            case 27: lastName = ""; break;
            case 28: lastName = ""; break;
            case 29: lastName = ""; break;
            case 30: lastName = ""; break;
            case 31: lastName = ""; break;
            case 32: lastName = ""; break;
            case 33: lastName = ""; break;
            case 34: lastName = ""; break;
            case 35: lastName = ""; break;
            case 36: lastName = ""; break;
            case 37: lastName = ""; break;
            case 38: lastName = ""; break;
            case 39: lastName = ""; break;
            case 40: lastName = ""; break;
            case 41: lastName = ""; break;
            case 42: lastName = ""; break;
            case 43: lastName = ""; break;
            case 44: lastName = ""; break;
            case 45: lastName = ""; break;
            case 46: lastName = ""; break;
            case 47: lastName = ""; break;
            case 48: lastName = ""; break;
            case 49: lastName = ""; break;
            case 50: lastName = ""; break;
        }

        return (givenName + ' ' + lastName);
    }
    public string HumanGerman() {
        string givenName, lastName;
        givenName = "";
        lastName = "";

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Adelhayt"; break;
                case 2: givenName = "Affra"; break;
                case 3: givenName = "Agatha"; break;
                case 4: givenName = "Allet"; break;
                case 5: givenName = "Angnes"; break;
                case 6: givenName = "Anna"; break;
                case 7: givenName = "Apell"; break;
                case 8: givenName = "Applonia"; break;
                case 9: givenName = "Barbara"; break;
                case 10: givenName = "Brida"; break;
                case 11: givenName = "Brigita"; break;
                case 12: givenName = "Cecilia"; break;
                case 13: givenName = "Clara"; break;
                case 14: givenName = "Cristina"; break;
                case 15: givenName = "Dorothea"; break;
                case 16: givenName = "Duretta"; break;
                case 17: givenName = "Ella"; break;
                case 18: givenName = "Els"; break;
                case 19: givenName = "Elsbeth"; break;
                case 20: givenName = "Engel"; break;
                case 21: givenName = "Enlein"; break;
                case 22: givenName = "Enndlin"; break;
                case 23: givenName = "Eva"; break;
                case 24: givenName = "Fela"; break;
                case 25: givenName = "Fronicka"; break;
                case 26: givenName = "Genefe"; break;
                case 27: givenName = "Geras"; break;
                case 28: givenName = "Gerhauss"; break;
                case 29: givenName = "Gertrudt"; break;
                case 30: givenName = "Guttel"; break;
                case 31: givenName = "Helena"; break;
                case 32: givenName = "Irmel"; break;
                case 33: givenName = "Jonata"; break;
                case 34: givenName = "Katerina"; break;
                case 35: givenName = "Kuen"; break;
                case 36: givenName = "Kungund"; break;
                case 37: givenName = "Lucia"; break;
                case 38: givenName = "Madalena"; break;
                case 39: givenName = "Magdalen"; break;
                case 40: givenName = "Margret"; break;
                case 41: givenName = "Marlein"; break;
                case 42: givenName = "Martha"; break;
                case 43: givenName = "Otilia"; break;
                case 44: givenName = "Ottilg"; break;
                case 45: givenName = "Peternella"; break;
                case 46: givenName = "Reusin"; break;
                case 47: givenName = "Sibilla"; break;
                case 48: givenName = "Ursel"; break;
                case 49: givenName = "Vrsula"; break;
                case 50: givenName = "Walpurg"; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: lastName = ""; break;
            case 2: lastName = ""; break;
            case 3: lastName = ""; break;
            case 4: lastName = ""; break;
            case 5: lastName = ""; break;
            case 6: lastName = ""; break;
            case 7: lastName = ""; break;
            case 8: lastName = ""; break;
            case 9: lastName = ""; break;
            case 10: lastName = ""; break;
            case 11: lastName = ""; break;
            case 12: lastName = ""; break;
            case 13: lastName = ""; break;
            case 14: lastName = ""; break;
            case 15: lastName = ""; break;
            case 16: lastName = ""; break;
            case 17: lastName = ""; break;
            case 18: lastName = ""; break;
            case 19: lastName = ""; break;
            case 20: lastName = ""; break;
            case 21: lastName = ""; break;
            case 22: lastName = ""; break;
            case 23: lastName = ""; break;
            case 24: lastName = ""; break;
            case 25: lastName = ""; break;
            case 26: lastName = ""; break;
            case 27: lastName = ""; break;
            case 28: lastName = ""; break;
            case 29: lastName = ""; break;
            case 30: lastName = ""; break;
            case 31: lastName = ""; break;
            case 32: lastName = ""; break;
            case 33: lastName = ""; break;
            case 34: lastName = ""; break;
            case 35: lastName = ""; break;
            case 36: lastName = ""; break;
            case 37: lastName = ""; break;
            case 38: lastName = ""; break;
            case 39: lastName = ""; break;
            case 40: lastName = ""; break;
            case 41: lastName = ""; break;
            case 42: lastName = ""; break;
            case 43: lastName = ""; break;
            case 44: lastName = ""; break;
            case 45: lastName = ""; break;
            case 46: lastName = ""; break;
            case 47: lastName = ""; break;
            case 48: lastName = ""; break;
            case 49: lastName = ""; break;
            case 50: lastName = ""; break;
        }

        return (givenName + ' ' + lastName);
    }
    public string HumanGreek() {
        string givenName, lastName;
        givenName = "";
        lastName = "";

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: lastName = ""; break;
            case 2: lastName = ""; break;
            case 3: lastName = ""; break;
            case 4: lastName = ""; break;
            case 5: lastName = ""; break;
            case 6: lastName = ""; break;
            case 7: lastName = ""; break;
            case 8: lastName = ""; break;
            case 9: lastName = ""; break;
            case 10: lastName = ""; break;
            case 11: lastName = ""; break;
            case 12: lastName = ""; break;
            case 13: lastName = ""; break;
            case 14: lastName = ""; break;
            case 15: lastName = ""; break;
            case 16: lastName = ""; break;
            case 17: lastName = ""; break;
            case 18: lastName = ""; break;
            case 19: lastName = ""; break;
            case 20: lastName = ""; break;
            case 21: lastName = ""; break;
            case 22: lastName = ""; break;
            case 23: lastName = ""; break;
            case 24: lastName = ""; break;
            case 25: lastName = ""; break;
            case 26: lastName = ""; break;
            case 27: lastName = ""; break;
            case 28: lastName = ""; break;
            case 29: lastName = ""; break;
            case 30: lastName = ""; break;
            case 31: lastName = ""; break;
            case 32: lastName = ""; break;
            case 33: lastName = ""; break;
            case 34: lastName = ""; break;
            case 35: lastName = ""; break;
            case 36: lastName = ""; break;
            case 37: lastName = ""; break;
            case 38: lastName = ""; break;
            case 39: lastName = ""; break;
            case 40: lastName = ""; break;
            case 41: lastName = ""; break;
            case 42: lastName = ""; break;
            case 43: lastName = ""; break;
            case 44: lastName = ""; break;
            case 45: lastName = ""; break;
            case 46: lastName = ""; break;
            case 47: lastName = ""; break;
            case 48: lastName = ""; break;
            case 49: lastName = ""; break;
            case 50: lastName = ""; break;
        }

        return (givenName + ' ' + lastName);
    }
    public string HumanIndian() {
        string givenName, lastName;
        givenName = "";
        lastName = "";

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: lastName = ""; break;
            case 2: lastName = ""; break;
            case 3: lastName = ""; break;
            case 4: lastName = ""; break;
            case 5: lastName = ""; break;
            case 6: lastName = ""; break;
            case 7: lastName = ""; break;
            case 8: lastName = ""; break;
            case 9: lastName = ""; break;
            case 10: lastName = ""; break;
            case 11: lastName = ""; break;
            case 12: lastName = ""; break;
            case 13: lastName = ""; break;
            case 14: lastName = ""; break;
            case 15: lastName = ""; break;
            case 16: lastName = ""; break;
            case 17: lastName = ""; break;
            case 18: lastName = ""; break;
            case 19: lastName = ""; break;
            case 20: lastName = ""; break;
            case 21: lastName = ""; break;
            case 22: lastName = ""; break;
            case 23: lastName = ""; break;
            case 24: lastName = ""; break;
            case 25: lastName = ""; break;
            case 26: lastName = ""; break;
            case 27: lastName = ""; break;
            case 28: lastName = ""; break;
            case 29: lastName = ""; break;
            case 30: lastName = ""; break;
            case 31: lastName = ""; break;
            case 32: lastName = ""; break;
            case 33: lastName = ""; break;
            case 34: lastName = ""; break;
            case 35: lastName = ""; break;
            case 36: lastName = ""; break;
            case 37: lastName = ""; break;
            case 38: lastName = ""; break;
            case 39: lastName = ""; break;
            case 40: lastName = ""; break;
            case 41: lastName = ""; break;
            case 42: lastName = ""; break;
            case 43: lastName = ""; break;
            case 44: lastName = ""; break;
            case 45: lastName = ""; break;
            case 46: lastName = ""; break;
            case 47: lastName = ""; break;
            case 48: lastName = ""; break;
            case 49: lastName = ""; break;
            case 50: lastName = ""; break;
        }

        return (givenName + ' ' + lastName);
    }
    public string HumanJapanese() {
        string givenName, lastName;
        givenName = "";
        lastName = "";

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: lastName = ""; break;
            case 2: lastName = ""; break;
            case 3: lastName = ""; break;
            case 4: lastName = ""; break;
            case 5: lastName = ""; break;
            case 6: lastName = ""; break;
            case 7: lastName = ""; break;
            case 8: lastName = ""; break;
            case 9: lastName = ""; break;
            case 10: lastName = ""; break;
            case 11: lastName = ""; break;
            case 12: lastName = ""; break;
            case 13: lastName = ""; break;
            case 14: lastName = ""; break;
            case 15: lastName = ""; break;
            case 16: lastName = ""; break;
            case 17: lastName = ""; break;
            case 18: lastName = ""; break;
            case 19: lastName = ""; break;
            case 20: lastName = ""; break;
            case 21: lastName = ""; break;
            case 22: lastName = ""; break;
            case 23: lastName = ""; break;
            case 24: lastName = ""; break;
            case 25: lastName = ""; break;
            case 26: lastName = ""; break;
            case 27: lastName = ""; break;
            case 28: lastName = ""; break;
            case 29: lastName = ""; break;
            case 30: lastName = ""; break;
            case 31: lastName = ""; break;
            case 32: lastName = ""; break;
            case 33: lastName = ""; break;
            case 34: lastName = ""; break;
            case 35: lastName = ""; break;
            case 36: lastName = ""; break;
            case 37: lastName = ""; break;
            case 38: lastName = ""; break;
            case 39: lastName = ""; break;
            case 40: lastName = ""; break;
            case 41: lastName = ""; break;
            case 42: lastName = ""; break;
            case 43: lastName = ""; break;
            case 44: lastName = ""; break;
            case 45: lastName = ""; break;
            case 46: lastName = ""; break;
            case 47: lastName = ""; break;
            case 48: lastName = ""; break;
            case 49: lastName = ""; break;
            case 50: lastName = ""; break;
        }

        return (givenName + ' ' + lastName);
    }
    public string HumanMesoamerican() {
        string givenName, lastName;
        givenName = "";
        lastName = "";

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: lastName = ""; break;
            case 2: lastName = ""; break;
            case 3: lastName = ""; break;
            case 4: lastName = ""; break;
            case 5: lastName = ""; break;
            case 6: lastName = ""; break;
            case 7: lastName = ""; break;
            case 8: lastName = ""; break;
            case 9: lastName = ""; break;
            case 10: lastName = ""; break;
            case 11: lastName = ""; break;
            case 12: lastName = ""; break;
            case 13: lastName = ""; break;
            case 14: lastName = ""; break;
            case 15: lastName = ""; break;
            case 16: lastName = ""; break;
            case 17: lastName = ""; break;
            case 18: lastName = ""; break;
            case 19: lastName = ""; break;
            case 20: lastName = ""; break;
            case 21: lastName = ""; break;
            case 22: lastName = ""; break;
            case 23: lastName = ""; break;
            case 24: lastName = ""; break;
            case 25: lastName = ""; break;
            case 26: lastName = ""; break;
            case 27: lastName = ""; break;
            case 28: lastName = ""; break;
            case 29: lastName = ""; break;
            case 30: lastName = ""; break;
            case 31: lastName = ""; break;
            case 32: lastName = ""; break;
            case 33: lastName = ""; break;
            case 34: lastName = ""; break;
            case 35: lastName = ""; break;
            case 36: lastName = ""; break;
            case 37: lastName = ""; break;
            case 38: lastName = ""; break;
            case 39: lastName = ""; break;
            case 40: lastName = ""; break;
            case 41: lastName = ""; break;
            case 42: lastName = ""; break;
            case 43: lastName = ""; break;
            case 44: lastName = ""; break;
            case 45: lastName = ""; break;
            case 46: lastName = ""; break;
            case 47: lastName = ""; break;
            case 48: lastName = ""; break;
            case 49: lastName = ""; break;
            case 50: lastName = ""; break;
        }

        return (givenName + ' ' + lastName);
    }
    public string HumanNigerCongo() {
        string givenName, lastName;
        givenName = "";
        lastName = "";

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: lastName = ""; break;
            case 2: lastName = ""; break;
            case 3: lastName = ""; break;
            case 4: lastName = ""; break;
            case 5: lastName = ""; break;
            case 6: lastName = ""; break;
            case 7: lastName = ""; break;
            case 8: lastName = ""; break;
            case 9: lastName = ""; break;
            case 10: lastName = ""; break;
            case 11: lastName = ""; break;
            case 12: lastName = ""; break;
            case 13: lastName = ""; break;
            case 14: lastName = ""; break;
            case 15: lastName = ""; break;
            case 16: lastName = ""; break;
            case 17: lastName = ""; break;
            case 18: lastName = ""; break;
            case 19: lastName = ""; break;
            case 20: lastName = ""; break;
            case 21: lastName = ""; break;
            case 22: lastName = ""; break;
            case 23: lastName = ""; break;
            case 24: lastName = ""; break;
            case 25: lastName = ""; break;
            case 26: lastName = ""; break;
            case 27: lastName = ""; break;
            case 28: lastName = ""; break;
            case 29: lastName = ""; break;
            case 30: lastName = ""; break;
            case 31: lastName = ""; break;
            case 32: lastName = ""; break;
            case 33: lastName = ""; break;
            case 34: lastName = ""; break;
            case 35: lastName = ""; break;
            case 36: lastName = ""; break;
            case 37: lastName = ""; break;
            case 38: lastName = ""; break;
            case 39: lastName = ""; break;
            case 40: lastName = ""; break;
            case 41: lastName = ""; break;
            case 42: lastName = ""; break;
            case 43: lastName = ""; break;
            case 44: lastName = ""; break;
            case 45: lastName = ""; break;
            case 46: lastName = ""; break;
            case 47: lastName = ""; break;
            case 48: lastName = ""; break;
            case 49: lastName = ""; break;
            case 50: lastName = ""; break;
        }

        return (givenName + ' ' + lastName);
    }
    public string HumanNorse() {
        string givenName, lastName;
        givenName = "";
        lastName = "";

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: lastName = ""; break;
            case 2: lastName = ""; break;
            case 3: lastName = ""; break;
            case 4: lastName = ""; break;
            case 5: lastName = ""; break;
            case 6: lastName = ""; break;
            case 7: lastName = ""; break;
            case 8: lastName = ""; break;
            case 9: lastName = ""; break;
            case 10: lastName = ""; break;
            case 11: lastName = ""; break;
            case 12: lastName = ""; break;
            case 13: lastName = ""; break;
            case 14: lastName = ""; break;
            case 15: lastName = ""; break;
            case 16: lastName = ""; break;
            case 17: lastName = ""; break;
            case 18: lastName = ""; break;
            case 19: lastName = ""; break;
            case 20: lastName = ""; break;
            case 21: lastName = ""; break;
            case 22: lastName = ""; break;
            case 23: lastName = ""; break;
            case 24: lastName = ""; break;
            case 25: lastName = ""; break;
            case 26: lastName = ""; break;
            case 27: lastName = ""; break;
            case 28: lastName = ""; break;
            case 29: lastName = ""; break;
            case 30: lastName = ""; break;
            case 31: lastName = ""; break;
            case 32: lastName = ""; break;
            case 33: lastName = ""; break;
            case 34: lastName = ""; break;
            case 35: lastName = ""; break;
            case 36: lastName = ""; break;
            case 37: lastName = ""; break;
            case 38: lastName = ""; break;
            case 39: lastName = ""; break;
            case 40: lastName = ""; break;
            case 41: lastName = ""; break;
            case 42: lastName = ""; break;
            case 43: lastName = ""; break;
            case 44: lastName = ""; break;
            case 45: lastName = ""; break;
            case 46: lastName = ""; break;
            case 47: lastName = ""; break;
            case 48: lastName = ""; break;
            case 49: lastName = ""; break;
            case 50: lastName = ""; break;
        }

        return (givenName + ' ' + lastName);
    }
    public string HumanPolynesian() {
        string givenName, lastName;
        givenName = "";
        lastName = "";

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: lastName = ""; break;
            case 2: lastName = ""; break;
            case 3: lastName = ""; break;
            case 4: lastName = ""; break;
            case 5: lastName = ""; break;
            case 6: lastName = ""; break;
            case 7: lastName = ""; break;
            case 8: lastName = ""; break;
            case 9: lastName = ""; break;
            case 10: lastName = ""; break;
            case 11: lastName = ""; break;
            case 12: lastName = ""; break;
            case 13: lastName = ""; break;
            case 14: lastName = ""; break;
            case 15: lastName = ""; break;
            case 16: lastName = ""; break;
            case 17: lastName = ""; break;
            case 18: lastName = ""; break;
            case 19: lastName = ""; break;
            case 20: lastName = ""; break;
            case 21: lastName = ""; break;
            case 22: lastName = ""; break;
            case 23: lastName = ""; break;
            case 24: lastName = ""; break;
            case 25: lastName = ""; break;
            case 26: lastName = ""; break;
            case 27: lastName = ""; break;
            case 28: lastName = ""; break;
            case 29: lastName = ""; break;
            case 30: lastName = ""; break;
            case 31: lastName = ""; break;
            case 32: lastName = ""; break;
            case 33: lastName = ""; break;
            case 34: lastName = ""; break;
            case 35: lastName = ""; break;
            case 36: lastName = ""; break;
            case 37: lastName = ""; break;
            case 38: lastName = ""; break;
            case 39: lastName = ""; break;
            case 40: lastName = ""; break;
            case 41: lastName = ""; break;
            case 42: lastName = ""; break;
            case 43: lastName = ""; break;
            case 44: lastName = ""; break;
            case 45: lastName = ""; break;
            case 46: lastName = ""; break;
            case 47: lastName = ""; break;
            case 48: lastName = ""; break;
            case 49: lastName = ""; break;
            case 50: lastName = ""; break;
        }

        return (givenName + ' ' + lastName);
    }
    public string HumanRoman() {
        string givenName, lastName;
        givenName = "";
        lastName = "";

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: lastName = ""; break;
            case 2: lastName = ""; break;
            case 3: lastName = ""; break;
            case 4: lastName = ""; break;
            case 5: lastName = ""; break;
            case 6: lastName = ""; break;
            case 7: lastName = ""; break;
            case 8: lastName = ""; break;
            case 9: lastName = ""; break;
            case 10: lastName = ""; break;
            case 11: lastName = ""; break;
            case 12: lastName = ""; break;
            case 13: lastName = ""; break;
            case 14: lastName = ""; break;
            case 15: lastName = ""; break;
            case 16: lastName = ""; break;
            case 17: lastName = ""; break;
            case 18: lastName = ""; break;
            case 19: lastName = ""; break;
            case 20: lastName = ""; break;
            case 21: lastName = ""; break;
            case 22: lastName = ""; break;
            case 23: lastName = ""; break;
            case 24: lastName = ""; break;
            case 25: lastName = ""; break;
            case 26: lastName = ""; break;
            case 27: lastName = ""; break;
            case 28: lastName = ""; break;
            case 29: lastName = ""; break;
            case 30: lastName = ""; break;
            case 31: lastName = ""; break;
            case 32: lastName = ""; break;
            case 33: lastName = ""; break;
            case 34: lastName = ""; break;
            case 35: lastName = ""; break;
            case 36: lastName = ""; break;
            case 37: lastName = ""; break;
            case 38: lastName = ""; break;
            case 39: lastName = ""; break;
            case 40: lastName = ""; break;
            case 41: lastName = ""; break;
            case 42: lastName = ""; break;
            case 43: lastName = ""; break;
            case 44: lastName = ""; break;
            case 45: lastName = ""; break;
            case 46: lastName = ""; break;
            case 47: lastName = ""; break;
            case 48: lastName = ""; break;
            case 49: lastName = ""; break;
            case 50: lastName = ""; break;
        }

        return (givenName + ' ' + lastName);
    }
    public string HumanSlavic() {
        string givenName, lastName;
        givenName = "";
        lastName = "";

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: lastName = ""; break;
            case 2: lastName = ""; break;
            case 3: lastName = ""; break;
            case 4: lastName = ""; break;
            case 5: lastName = ""; break;
            case 6: lastName = ""; break;
            case 7: lastName = ""; break;
            case 8: lastName = ""; break;
            case 9: lastName = ""; break;
            case 10: lastName = ""; break;
            case 11: lastName = ""; break;
            case 12: lastName = ""; break;
            case 13: lastName = ""; break;
            case 14: lastName = ""; break;
            case 15: lastName = ""; break;
            case 16: lastName = ""; break;
            case 17: lastName = ""; break;
            case 18: lastName = ""; break;
            case 19: lastName = ""; break;
            case 20: lastName = ""; break;
            case 21: lastName = ""; break;
            case 22: lastName = ""; break;
            case 23: lastName = ""; break;
            case 24: lastName = ""; break;
            case 25: lastName = ""; break;
            case 26: lastName = ""; break;
            case 27: lastName = ""; break;
            case 28: lastName = ""; break;
            case 29: lastName = ""; break;
            case 30: lastName = ""; break;
            case 31: lastName = ""; break;
            case 32: lastName = ""; break;
            case 33: lastName = ""; break;
            case 34: lastName = ""; break;
            case 35: lastName = ""; break;
            case 36: lastName = ""; break;
            case 37: lastName = ""; break;
            case 38: lastName = ""; break;
            case 39: lastName = ""; break;
            case 40: lastName = ""; break;
            case 41: lastName = ""; break;
            case 42: lastName = ""; break;
            case 43: lastName = ""; break;
            case 44: lastName = ""; break;
            case 45: lastName = ""; break;
            case 46: lastName = ""; break;
            case 47: lastName = ""; break;
            case 48: lastName = ""; break;
            case 49: lastName = ""; break;
            case 50: lastName = ""; break;
        }

        return (givenName + ' ' + lastName);
    }
    public string HumanSpanish() {
        string givenName, lastName;
        givenName = "";
        lastName = "";

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = ""; break;
                case 2: givenName = ""; break;
                case 3: givenName = ""; break;
                case 4: givenName = ""; break;
                case 5: givenName = ""; break;
                case 6: givenName = ""; break;
                case 7: givenName = ""; break;
                case 8: givenName = ""; break;
                case 9: givenName = ""; break;
                case 10: givenName = ""; break;
                case 11: givenName = ""; break;
                case 12: givenName = ""; break;
                case 13: givenName = ""; break;
                case 14: givenName = ""; break;
                case 15: givenName = ""; break;
                case 16: givenName = ""; break;
                case 17: givenName = ""; break;
                case 18: givenName = ""; break;
                case 19: givenName = ""; break;
                case 20: givenName = ""; break;
                case 21: givenName = ""; break;
                case 22: givenName = ""; break;
                case 23: givenName = ""; break;
                case 24: givenName = ""; break;
                case 25: givenName = ""; break;
                case 26: givenName = ""; break;
                case 27: givenName = ""; break;
                case 28: givenName = ""; break;
                case 29: givenName = ""; break;
                case 30: givenName = ""; break;
                case 31: givenName = ""; break;
                case 32: givenName = ""; break;
                case 33: givenName = ""; break;
                case 34: givenName = ""; break;
                case 35: givenName = ""; break;
                case 36: givenName = ""; break;
                case 37: givenName = ""; break;
                case 38: givenName = ""; break;
                case 39: givenName = ""; break;
                case 40: givenName = ""; break;
                case 41: givenName = ""; break;
                case 42: givenName = ""; break;
                case 43: givenName = ""; break;
                case 44: givenName = ""; break;
                case 45: givenName = ""; break;
                case 46: givenName = ""; break;
                case 47: givenName = ""; break;
                case 48: givenName = ""; break;
                case 49: givenName = ""; break;
                case 50: givenName = ""; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: lastName = ""; break;
            case 2: lastName = ""; break;
            case 3: lastName = ""; break;
            case 4: lastName = ""; break;
            case 5: lastName = ""; break;
            case 6: lastName = ""; break;
            case 7: lastName = ""; break;
            case 8: lastName = ""; break;
            case 9: lastName = ""; break;
            case 10: lastName = ""; break;
            case 11: lastName = ""; break;
            case 12: lastName = ""; break;
            case 13: lastName = ""; break;
            case 14: lastName = ""; break;
            case 15: lastName = ""; break;
            case 16: lastName = ""; break;
            case 17: lastName = ""; break;
            case 18: lastName = ""; break;
            case 19: lastName = ""; break;
            case 20: lastName = ""; break;
            case 21: lastName = ""; break;
            case 22: lastName = ""; break;
            case 23: lastName = ""; break;
            case 24: lastName = ""; break;
            case 25: lastName = ""; break;
            case 26: lastName = ""; break;
            case 27: lastName = ""; break;
            case 28: lastName = ""; break;
            case 29: lastName = ""; break;
            case 30: lastName = ""; break;
            case 31: lastName = ""; break;
            case 32: lastName = ""; break;
            case 33: lastName = ""; break;
            case 34: lastName = ""; break;
            case 35: lastName = ""; break;
            case 36: lastName = ""; break;
            case 37: lastName = ""; break;
            case 38: lastName = ""; break;
            case 39: lastName = ""; break;
            case 40: lastName = ""; break;
            case 41: lastName = ""; break;
            case 42: lastName = ""; break;
            case 43: lastName = ""; break;
            case 44: lastName = ""; break;
            case 45: lastName = ""; break;
            case 46: lastName = ""; break;
            case 47: lastName = ""; break;
            case 48: lastName = ""; break;
            case 49: lastName = ""; break;
            case 50: lastName = ""; break;
        }

        return (givenName + ' ' + lastName);
    }
    #endregion

    public string DragonbornName(ref NPCBlock block)
    {
        string givenName, clanName;
        givenName = "";
        clanName = "";

        switch (Random.Range(1,3)){
            case 1:
                gender = Gender.Female;
                block.race = ("Female " + block.race);
                break;
            case 2:
                gender = Gender.Male;
                block.race = ("Male " + block.race);
                break;
        }

        if (gender == Gender.Male)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Adrex"; break;
                case 2: givenName = "Arjhan"; break;
                case 3: givenName = "Azzakh"; break;
                case 4: givenName = "Balasar"; break;
                case 5: givenName = "Baradad"; break;
                case 6: givenName = "Bharash"; break;
                case 7: givenName = "Bidreked"; break;
                case 8: givenName = "Dadalan"; break;
                case 9: givenName = "Dazzazn"; break;
                case 10: givenName = "Direcris"; break;
                case 11: givenName = "Donaar"; break;
                case 12: givenName = "Fax"; break;
                case 13: givenName = "Gargax"; break;
                case 14: givenName = "Ghesh"; break;
                case 15: givenName = "Gorbundus"; break;
                case 16: givenName = "Greethen"; break;
                case 17: givenName = "Heskan"; break;
                case 18: givenName = "Hirrathak"; break;
                case 19: givenName = "Ildrex"; break;
                case 20: givenName = "Kaladan"; break;
                case 21: givenName = "Ikerkad"; break;
                case 22: givenName = "Kiirith"; break;
                case 23: givenName = "Kriv"; break;
                case 24: givenName = "Maagog"; break;
                case 25: givenName = "Medrash"; break;
                case 26: givenName = "Mehen"; break;
                case 27: givenName = "Mozikth"; break;
                case 28: givenName = "Mreksh"; break;
                case 29: givenName = "Mugrunden"; break;
                case 30: givenName = "Nadarr"; break;
                case 31: givenName = "Nithther"; break;
                case 32: givenName = "Norkruuth"; break;
                case 33: givenName = "Nykkan"; break;
                case 34: givenName = "Pandjed"; break;
                case 35: givenName = "Patrin"; break;
                case 36: givenName = "Pij'jirik"; break;
                case 37: givenName = "Quarethon"; break;
                case 38: givenName = "Rathkran"; break;
                case 39: givenName = "Rhogar"; break;
                case 40: givenName = "Rivaan"; break;
                case 41: givenName = "Sethrekar"; break;
                case 42: givenName = "Shamash"; break;
                case 43: givenName = "Shedinn"; break;
                case 44: givenName = "Srorthen"; break;
                case 45: givenName = "Tarhun"; break;
                case 46: givenName = "Torinn"; break;
                case 47: givenName = "Trynnicus"; break;
                case 48: givenName = "Valorean"; break;
                case 49: givenName = "Vrondiss"; break;
                case 50: givenName = "Zedaar"; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Akra"; break;
                case 2: givenName = "Aasathra"; break;
                case 3: givenName = "Antrara"; break;
                case 4: givenName = "Arava"; break;
                case 5: givenName = "Biri"; break;
                case 6: givenName = "Blendaeth"; break;
                case 7: givenName = "Burana"; break;
                case 8: givenName = "Chassath"; break;
                case 9: givenName = "Daar"; break;
                case 10: givenName = "Dentratha"; break;
                case 11: givenName = "Doudra"; break;
                case 12: givenName = "Driindar"; break;
                case 13: givenName = "Eggren"; break;
                case 14: givenName = "Farideh"; break;
                case 15: givenName = "Findex"; break;
                case 16: givenName = "Furrele"; break;
                case 17: givenName = "Gesrethe"; break;
                case 18: givenName = "Gilkass"; break;
                case 19: givenName = "Harann"; break;
                case 20: givenName = "Havilar"; break;
                case 21: givenName = "Hethress"; break;
                case 22: givenName = "Hillanot"; break;
                case 23: givenName = "Jaxi"; break;
                case 24: givenName = "Jezean"; break;
                case 25: givenName = "Jheri"; break;
                case 26: givenName = "Kadana"; break;
                case 27: givenName = "Kava"; break;
                case 28: givenName = "Korinn"; break;
                case 29: givenName = "Megren"; break;
                case 30: givenName = "Mijira"; break;
                case 31: givenName = "Mishann"; break;
                case 32: givenName = "Nala"; break;
                case 33: givenName = "Nuthra"; break;
                case 34: givenName = "Perra"; break;
                case 35: givenName = "Pogranix"; break;
                case 36: givenName = "Pyxrin"; break;
                case 37: givenName = "Quespa"; break;
                case 38: givenName = "Ralann"; break;
                case 39: givenName = "Rezena"; break;
                case 40: givenName = "Ruloth"; break;
                case 41: givenName = "Saphara"; break;
                case 42: givenName = "Savaran"; break;
                case 43: givenName = "Sora"; break;
                case 44: givenName = "Surina"; break;
                case 45: givenName = "Synthrin"; break;
                case 46: givenName = "Tatyan"; break;
                case 47: givenName = "Thava"; break;
                case 48: givenName = "Uadjit"; break;
                case 49: givenName = "Vezera"; break;
                case 50: givenName = "Zykroff"; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: clanName= "Akambherylliax"; break;
            case 2: clanName= "Argenthrixus"; break;
            case 3: clanName= "Baharoosh"; break;
            case 4: clanName= "Beryntolthropal"; break;
            case 5: clanName= "Bhenkumbyrzaax"; break;
            case 6: clanName= "Caavylteradyn"; break;
            case 7: clanName= "Chumbyxirinnish"; break;
            case 8: clanName= "Clethinthiallor"; break;
            case 9: clanName= "Daardendrian"; break;
            case 10: clanName= "Delmirev"; break;
            case 11: clanName= "Dhyrkelonis"; break;
            case 12: clanName= "Ebynichtomonis"; break;
            case 13: clanName= "Esstyriynn"; break;
            case 14: clanName= "Fharngnarthnost"; break;
            case 15: clanName= "Ghaal'lixirn"; break;
            case 16: clanName= "Grrmmballhyst"; break;
            case 17: clanName= "Gygazzylyshrift"; break;
            case 18: clanName= "Hashphronyxadyn"; break;
            case 19: clanName= "Hshhsstoroth"; break;
            case 20: clanName= "Imbixtellrhyst"; break;
            case 21: clanName= "Jerynomonis"; break;
            case 22: clanName= "Jharthraxyn"; break;
            case 23: clanName= "Kerrhylon"; break;
            case 24: clanName= "Kimbatuul"; break;
            case 25: clanName= "Lhamboldennish"; break;
            case 26: clanName= "Linxakasendalor"; break;
            case 27: clanName= "Mohradyllion"; break;
            case 28: clanName= "Mystan"; break;
            case 29: clanName= "Nemmonis"; break;
            case 30: clanName= "Norixius"; break;
            case 31: clanName= "Ophinshtalajiir"; break;
            case 32: clanName= "Orexijandilin"; break;
            case 33: clanName= "Pfaphnyrennish"; break;
            case 34: clanName= "Phradrandon"; break;
            case 35: clanName= "Pyraxtallinost"; break;
            case 36: clanName= "Qyxpahrgh"; break;
            case 37: clanName= "Ragthroknaar"; break;
            case 38: clanName= "Shestendeliath"; break;
            case 39: clanName= "Skaarzborroosh"; break;
            case 40: clanName= "Sumnargh'thrysh"; break;
            case 41: clanName= "Tiammanthyllish"; break;
            case 42: clanName= "Turnuroth"; break;
            case 43: clanName= "Umbyrphrael"; break;
            case 44: clanName= "Vangdondalor"; break;
            case 45: clanName= "Verthisathurgiesh"; break;
            case 46: clanName= "Wivvyrholdalhiax"; break;
            case 47: clanName= "Wystongjiir"; break;
            case 48: clanName= "Xephyrbahnor"; break;
            case 49: clanName= "Yarjerit"; break;
            case 50: clanName= "Zzzxaaxthroth"; break;
        }

        return (givenName + " " + clanName);
    }

    public string DwarfName(ref NPCBlock block)
    {
        string givenName, clanName;
        givenName = "";
        clanName = "";

        switch (Random.Range(1,3))
        {
            case 1:
                gender = Gender.Female;
                block.race = ("Female " + block.race);
                break;
            case 2:
                gender = Gender.Male;
                block.race = ("Male " + block.race);
                break;
        }

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Anbera"; break;
                case 2: givenName = "Artin"; break;
                case 3: givenName = "Audhild"; break;
                case 4: givenName = "Balifra"; break;
                case 5: givenName = "Barbena"; break;
                case 6: givenName = "Bardryn"; break;
                case 7: givenName = "Bolhild"; break;
                case 8: givenName = "Dagnal"; break;
                case 9: givenName = "Dariff"; break;
                case 10: givenName = "Delre"; break;
                case 11: givenName = "Diesa"; break;
                case 12: givenName = "Eldeth"; break;
                case 13: givenName = "Eridred"; break;
                case 14: givenName = "Falkrunn"; break;
                case 15: givenName = "Fallthra"; break;
                case 16: givenName = "Finellen"; break;
                case 17: givenName = "Gillydd"; break;
                case 18: givenName = "Gunnloda"; break;
                case 19: givenName = "Gurdis"; break;
                case 20: givenName = "Helgret"; break;
                case 21: givenName = "Helja"; break;
                case 22: givenName = "Hlin"; break;
                case 23: givenName = "Ilde"; break;
                case 24: givenName = "Jarana"; break;
                case 25: givenName = "Kathra"; break;
                case 26: givenName = "Kilia"; break;
                case 27: givenName = "Kristryd"; break;
                case 28: givenName = "Liftrasa"; break;
                case 29: givenName = "Marastyr"; break;
                case 30: givenName = "Mardred"; break;
                case 31: givenName = "Morana"; break;
                case 32: givenName = "Nalaed"; break;
                case 33: givenName = "Nora"; break;
                case 34: givenName = "Nurkara"; break;
                case 35: givenName = "Oriff"; break;
                case 36: givenName = "Ovina"; break;
                case 37: givenName = "Riswynn"; break;
                case 38: givenName = "Sannl"; break;
                case 39: givenName = "Therlin"; break;
                case 40: givenName = "Thodris"; break;
                case 41: givenName = "Torbera"; break;
                case 42: givenName = "Tordrid"; break;
                case 43: givenName = "Torgga"; break;
                case 44: givenName = "Urshar"; break;
                case 45: givenName = "Valida"; break;
                case 46: givenName = "Vistra"; break;
                case 47: givenName = "Vonana"; break;
                case 48: givenName = "Werydd"; break;
                case 49: givenName = "Whurdred"; break;
                case 50: givenName = "Yurgunn"; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Adrik"; break;
                case 2: givenName = "Alberich"; break;
                case 3: givenName = "Baern"; break;
                case 4: givenName = "Barendd"; break;
                case 5: givenName = "Beloril"; break;
                case 6: givenName = "Brottor"; break;
                case 7: givenName = "Dain"; break;
                case 8: givenName = "Dalgal"; break;
                case 9: givenName = "Darrak"; break;
                case 10: givenName = "Delg"; break;
                case 11: givenName = "Duergath"; break;
                case 12: givenName = "Dworic"; break;
                case 13: givenName = "Eberk"; break;
                case 14: givenName = "Einkil"; break;
                case 15: givenName = "Elaim"; break;
                case 16: givenName = "Erias"; break;
                case 17: givenName = "Fallond"; break;
                case 18: givenName = "Fargrim"; break;
                case 19: givenName = "Gardain"; break;
                case 20: givenName = "Gilthur"; break;
                case 21: givenName = "Gimgem"; break;
                case 22: givenName = "Gimurt"; break;
                case 23: givenName = "Harbek"; break;
                case 24: givenName = "Kildrak"; break;
                case 25: givenName = "Kilvar"; break;
                case 26: givenName = "Morgran"; break;
                case 27: givenName = "Morkral"; break;
                case 28: givenName = "Nalral"; break;
                case 29: givenName = "Nordak"; break;
                case 30: givenName = "Nuraval"; break;
                case 31: givenName = "Oloric"; break;
                case 32: givenName = "Olunt"; break;
                case 33: givenName = "Orsik"; break;
                case 34: givenName = "Oskar"; break;
                case 35: givenName = "Rangrim"; break;
                case 36: givenName = "Reirak"; break;
                case 37: givenName = "Rurik"; break;
                case 38: givenName = "Taklinn"; break;
                case 39: givenName = "Thoradin"; break;
                case 40: givenName = "Thorin"; break;
                case 41: givenName = "Thradal"; break;
                case 42: givenName = "Tordek"; break;
                case 43: givenName = "Traubon"; break;
                case 44: givenName = "Travok"; break;
                case 45: givenName = "Ulfgar"; break;
                case 46: givenName = "Uraim"; break;
                case 47: givenName = "Veit"; break;
                case 48: givenName = "Vonbin"; break;
                case 49: givenName = "Vondal"; break;
                case 50: givenName = "Whurbin"; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: clanName = "Aranore"; break;
            case 2: clanName = "Balderk"; break;
            case 3: clanName = "Battlehammer"; break;
            case 4: clanName = "Bigtoe"; break;
            case 5: clanName = "Bloodkith"; break;
            case 6: clanName = "Bofdann"; break;
            case 7: clanName = "Brawnanvil"; break;
            case 8: clanName = "Brazzik"; break;
            case 9: clanName = "Broodfist"; break;
            case 10: clanName = "Burrowfound"; break;
            case 11: clanName = "Caebrek"; break;
            case 12: clanName = "Daerdahk"; break;
            case 13: clanName = "Dankil"; break;
            case 14: clanName = "Daraln"; break;
            case 15: clanName = "Deepdelver"; break;
            case 16: clanName = "Durthane"; break;
            case 17: clanName = "Eversharp"; break;
            case 18: clanName = "Fallak"; break;
            case 19: clanName = "Fireforge"; break;
            case 20: clanName = "Foamtankard"; break;
            case 21: clanName = "Frostbeard"; break;
            case 22: clanName = "Glanhig"; break;
            case 23: clanName = "Goblinbane"; break;
            case 24: clanName = "Goldfinder"; break;
            case 25: clanName = "Gorunn"; break;
            case 26: clanName = "Graybeard"; break;
            case 27: clanName = "Hammerstone"; break;
            case 28: clanName = "Helcral"; break;
            case 29: clanName = "Holderhek"; break;
            case 30: clanName = "Ironfist"; break;
            case 31: clanName = "Loderr"; break;
            case 32: clanName = "Lutgehr"; break;
            case 33: clanName = "Morigak"; break;
            case 34: clanName = "Orcfoe"; break;
            case 35: clanName = "Rakankrak"; break;
            case 36: clanName = "Ruby-Eye"; break;
            case 37: clanName = "Rumnaheim"; break;
            case 38: clanName = "Silveraxe"; break;
            case 39: clanName = "Silverstone"; break;
            case 40: clanName = "Steelfist"; break;
            case 41: clanName = "Stoutale"; break;
            case 42: clanName = "Strakeln"; break;
            case 43: clanName = "Strongheart"; break;
            case 44: clanName = "Thrahak"; break;
            case 45: clanName = "Torevir"; break;
            case 46: clanName = "Torunn"; break;
            case 47: clanName = "Trollbleeder"; break;
            case 48: clanName = "Trueanvil"; break;
            case 49: clanName = "Trueblood"; break;
            case 50: clanName = "Ungart"; break;
        }

        return (givenName + " " + clanName);
    }

    public string ElfName(ref NPCBlock block)
    {
        string givenName, familyName;
        givenName = "";
        familyName = "";

        switch (Random.Range(1,3))
        {
            case 1:
                gender = Gender.Female;
                block.race = ("Female " + block.race);
                break;
            case 2:
                gender = Gender.Male;
                block.race = ("Male " + block.race);
                break;
        }

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Adrie"; break;
                case 2: givenName = "Ahinar"; break;
                case 3: givenName = "Althaea"; break;
                case 4: givenName = "Anastrianna"; break;
                case 5: givenName = "Andraste"; break;
                case 6: givenName = "Antinua"; break;
                case 7: givenName = "Arara"; break;
                case 8: givenName = "Baelitae"; break;
                case 9: givenName = "Bethrynna"; break;
                case 10: givenName = "Birel"; break;
                case 11: givenName = "Caelynn"; break;
                case 12: givenName = "Chaedi"; break;
                case 13: givenName = "Claira"; break;
                case 14: givenName = "Dara"; break;
                case 15: givenName = "Drusilia"; break;
                case 16: givenName = "Elama"; break;
                case 17: givenName = "Enna"; break;
                case 18: givenName = "Faral"; break;
                case 19: givenName = "Felosial"; break;
                case 20: givenName = "Hatae"; break;
                case 21: givenName = "Ielenia"; break;
                case 22: givenName = "Ilanis"; break;
                case 23: givenName = "Irann"; break;
                case 24: givenName = "Jarsali"; break;
                case 25: givenName = "Jelenneth"; break;
                case 26: givenName = "Keyleth"; break;
                case 27: givenName = "Leshanna"; break;
                case 28: givenName = "Lia"; break;
                case 29: givenName = "Maiathah"; break;
                case 30: givenName = "Malquis"; break;
                case 31: givenName = "Meriele"; break;
                case 32: givenName = "Mialee"; break;
                case 33: givenName = "Myathethil"; break;
                case 34: givenName = "Naivara"; break;
                case 35: givenName = "Quelenna"; break;
                case 36: givenName = "Quillathe"; break;
                case 37: givenName = "Ridaro"; break;
                case 38: givenName = "Sariel"; break;
                case 39: givenName = "Shanairla"; break;
                case 40: givenName = "Shava"; break;
                case 41: givenName = "Silaqui"; break;
                case 42: givenName = "Sumnes"; break;
                case 43: givenName = "Theirastra"; break;
                case 44: givenName = "Thiala"; break;
                case 45: givenName = "Tiaathque"; break;
                case 46: givenName = "Traulam"; break;
                case 47: givenName = "Vadania"; break;
                case 48: givenName = "Valanthe"; break;
                case 49: givenName = "Valna"; break;
                case 50: givenName = "Xanaphia"; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Adran"; break;
                case 2: givenName = "Aelar"; break;
                case 3: givenName = "Aerdeth"; break;
                case 4: givenName = "Ahvain"; break;
                case 5: givenName = "Aramil"; break;
                case 6: givenName = "Arannis"; break;
                case 7: givenName = "Aust"; break;
                case 8: givenName = "Azaki"; break;
                case 9: givenName = "Beiro"; break;
                case 10: givenName = "Berrian"; break;
                case 11: givenName = "Caeldrim"; break;
                case 12: givenName = "Carric"; break;
                case 13: givenName = "Dayereth"; break;
                case 14: givenName = "Dreali"; break;
                case 15: givenName = "Efferil"; break;
                case 16: givenName = "Eiravel"; break;
                case 17: givenName = "Enialis"; break;
                case 18: givenName = "Erdan"; break;
                case 19: givenName = "Erevan"; break;
                case 20: givenName = "Fivin"; break;
                case 21: givenName = "Galinndan"; break;
                case 22: givenName = "Gennal"; break;
                case 23: givenName = "Hadarai"; break;
                case 24: givenName = "Halimath"; break;
                case 25: givenName = "Heian"; break;
                case 26: givenName = "Himo"; break;
                case 27: givenName = "Immeral"; break;
                case 28: givenName = "Ivellios"; break;
                case 29: givenName = "Korfel"; break;
                case 30: givenName = "Lamlis"; break;
                case 31: givenName = "Laucian"; break;
                case 32: givenName = "Lucan"; break;
                case 33: givenName = "Mindartis"; break;
                case 34: givenName = "Naal"; break;
                case 35: givenName = "Nutae"; break;
                case 36: givenName = "Paelias"; break;
                case 37: givenName = "Peren"; break;
                case 38: givenName = "Quarion"; break;
                case 39: givenName = "Riardon"; break;
                case 40: givenName = "Rolen"; break;
                case 41: givenName = "Soveliss"; break;
                case 42: givenName = "Suhnae"; break;
                case 43: givenName = "Thamior"; break;
                case 44: givenName = "Tharivol"; break;
                case 45: givenName = "Theren"; break;
                case 46: givenName = "Theriatis"; break;
                case 47: givenName = "Thervan"; break;
                case 48: givenName = "Uthemar"; break;
                case 49: givenName = "Vanuath"; break;
                case 50: givenName = "Varis"; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: familyName = "Aloro"; break;
            case 2: familyName = "Amakiir"; break;
            case 3: familyName = "Amastacia"; break;
            case 4: familyName = "Ariessus"; break;
            case 5: familyName = "Arnuanna"; break;
            case 6: familyName = "Berevan"; break;
            case 7: familyName = "Caerdonel"; break;
            case 8: familyName = "Caphaxath"; break;
            case 9: familyName = "Casilltenirra"; break;
            case 10: familyName = "Cithreth"; break;
            case 11: familyName = "Dalanthan"; break;
            case 12: familyName = "Eathalena"; break;
            case 13: familyName = "Erenaeth"; break;
            case 14: familyName = "Ethanasath"; break;
            case 15: familyName = "Fasharash"; break;
            case 16: familyName = "Firahel"; break;
            case 17: familyName = "Floshem"; break;
            case 18: familyName = "Galanodel"; break;
            case 19: familyName = "Goltorah"; break;
            case 20: familyName = "Hanali"; break;
            case 21: familyName = "Holimion"; break;
            case 22: familyName = "Horineth"; break;
            case 23: familyName = "Iathrana"; break;
            case 24: familyName = "Ilphelkiir"; break;
            case 25: familyName = "Iriphana"; break;
            case 26: familyName = "Koehlanna"; break;
            case 27: familyName = "Lathalas"; break;
            case 28: familyName = "Liadon"; break;
            case 29: familyName = "Meliamne"; break;
            case 30: familyName = "Mellerelel"; break;
            case 31: familyName = "Mystralath"; break;
            case 32: familyName = "Na'Ilo"; break;
            case 33: familyName = "Netyoive"; break;
            case 34: familyName = "Ofandrus"; break;
            case 35: familyName = "Ostoroth"; break;
            case 36: familyName = "Othronus"; break;
            case 37: familyName = "Qualanthri"; break;
            case 38: familyName = "Raethran"; break;
            case 39: familyName = "Rothenel"; break;
            case 40: familyName = "Selevarun"; break;
            case 41: familyName = "Siannodel"; break;
            case 42: familyName = "Suithrasas"; break;
            case 43: familyName = "Sylvaranth"; break;
            case 44: familyName = "Teinithra"; break;
            case 45: familyName = "Tiltathana"; break;
            case 46: familyName = "Wasanthi"; break;
            case 47: familyName = "Withrethin"; break;
            case 48: familyName = "Xilosient"; break;
            case 49: familyName = "Xistsrith"; break;
            case 50: familyName = "Yaeldrin"; break;
        }

        return (givenName + " " + familyName);
    }

    public string GnomeName(ref NPCBlock block)
    {
        string givenName, clanName;
        givenName = "";
        clanName = "";

        switch (Random.Range(1,3))
        {
            case 1:
                gender = Gender.Female;
                block.race = ("Female " + block.race);
                break;
            case 2:
                gender = Gender.Male;
                block.race = ("Male " + block.race);
                break;
        }

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Abalba"; break;
                case 2: givenName = "Bimpnottin"; break;
                case 3: givenName = "Breena"; break;
                case 4: givenName = "Buvvie"; break;
                case 5: givenName = "Callybon"; break;
                case 6: givenName = "Caramip"; break;
                case 7: givenName = "Carlin"; break;
                case 8: givenName = "Cumpen"; break;
                case 9: givenName = "Dalaba"; break;
                case 10: givenName = "Donella"; break;
                case 11: givenName = "Duvamil"; break;
                case 12: givenName = "Ella"; break;
                case 13: givenName = "Ellyjoybell"; break;
                case 14: givenName = "Ellywick"; break;
                case 15: givenName = "Enidda"; break;
                case 16: givenName = "Lilli"; break;
                case 17: givenName = "Loopmottin"; break;
                case 18: givenName = "Lorilla"; break;
                case 19: givenName = "Luthra"; break;
                case 20: givenName = "Mardnab"; break;
                case 21: givenName = "Meena"; break;
                case 22: givenName = "Menny"; break;
                case 23: givenName = "Mumpena"; break;
                case 24: givenName = "Nissa"; break;
                case 25: givenName = "Numba"; break;
                case 26: givenName = "Nyx"; break;
                case 27: givenName = "Oda"; break;
                case 28: givenName = "Oppah"; break;
                case 29: givenName = "Orlah"; break;
                case 30: givenName = "Panana"; break;
                case 31: givenName = "Pyntle"; break;
                case 32: givenName = "Quilla"; break;
                case 33: givenName = "Ranala"; break;
                case 34: givenName = "Reddlepop"; break;
                case 35: givenName = "Roywyn"; break;
                case 36: givenName = "Salanop"; break;
                case 37: givenName = "Shamil"; break;
                case 38: givenName = "Siffress"; break;
                case 39: givenName = "Symma"; break;
                case 40: givenName = "Tana"; break;
                case 41: givenName = "Tenena"; break;
                case 42: givenName = "Tervaround"; break;
                case 43: givenName = "Tippletoe"; break;
                case 44: givenName = "Ulla"; break;
                case 45: givenName = "Unvera"; break;
                case 46: givenName = "Veloptima"; break;
                case 47: givenName = "Virra"; break;
                case 48: givenName = "Waywocket"; break;
                case 49: givenName = "Yebe"; break;
                case 50: givenName = "Zanna"; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Alston"; break;
                case 2: givenName = "Alvyn"; break;
                case 3: givenName = "Anverth"; break;
                case 4: givenName = "Arumawann"; break;
                case 5: givenName = "Bilbron"; break;
                case 6: givenName = "Boddynock"; break;
                case 7: givenName = "Brocc"; break;
                case 8: givenName = "Burgell"; break;
                case 9: givenName = "Cockaby"; break;
                case 10: givenName = "Crampernap"; break;
                case 11: givenName = "Dabbledob"; break;
                case 12: givenName = "Delebean"; break;
                case 13: givenName = "Dimble"; break;
                case 14: givenName = "Eberdeb"; break;
                case 15: givenName = "Eldon"; break;
                case 16: givenName = "Erky"; break;
                case 17: givenName = "Fablen"; break;
                case 18: givenName = "Fibblestib"; break;
                case 19: givenName = "Fonkin"; break;
                case 20: givenName = "Fouse"; break;
                case 21: givenName = "Frug"; break;
                case 22: givenName = "Gerbo"; break;
                case 23: givenName = "Gimble"; break;
                case 24: givenName = "Glim"; break;
                case 25: givenName = "Igden"; break;
                case 26: givenName = "Jabble"; break;
                case 27: givenName = "Jebeddo"; break;
                case 28: givenName = "Kellen"; break;
                case 29: givenName = "Kipper"; break;
                case 30: givenName = "Namfoodle"; break;
                case 31: givenName = "Oppleby"; break;
                case 32: givenName = "Orryn"; break;
                case 33: givenName = "Paggen"; break;
                case 34: givenName = "Pallabar"; break;
                case 35: givenName = "Pog"; break;
                case 36: givenName = "Qualen"; break;
                case 37: givenName = "Ribbles"; break;
                case 38: givenName = "Rimple"; break;
                case 39: givenName = "Roondar"; break;
                case 40: givenName = "Sapply"; break;
                case 41: givenName = "Seebo"; break;
                case 42: givenName = "Senteq"; break;
                case 43: givenName = "Sindri"; break;
                case 44: givenName = "Umpen"; break;
                case 45: givenName = "Warryn"; break;
                case 46: givenName = "Wiggens"; break;
                case 47: givenName = "Wobbles"; break;
                case 48: givenName = "Wrenn"; break;
                case 49: givenName = "Zaffrab"; break;
                case 50: givenName = "Zook"; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: clanName = "Albaratie"; break;
            case 2: clanName = "Bafflestone"; break;
            case 3: clanName = "Beren"; break;
            case 4: clanName = "Boondiggles"; break;
            case 5: clanName = "Cobblelob"; break;
            case 6: clanName = "Daergel"; break;
            case 7: clanName = "Dunben"; break;
            case 8: clanName = "Fabblestabble"; break;
            case 9: clanName = "Fabblestamp"; break;
            case 10: clanName = "Fiddlefen"; break;
            case 11: clanName = "Folkor"; break;
            case 12: clanName = "Garrik"; break;
            case 13: clanName = "Gimlen"; break;
            case 14: clanName = "Glittergem"; break;
            case 15: clanName = "Gobblefirn"; break;
            case 16: clanName = "Gummen"; break;
            case 17: clanName = "Horcusporcus"; break;
            case 18: clanName = "Humplebumple"; break;
            case 19: clanName = "Ironhide"; break;
            case 20: clanName = "Leffery"; break;
            case 21: clanName = "Lingenhall"; break;
            case 22: clanName = "Loofolle"; break;
            case 23: clanName = "Maekkelferce"; break;
            case 24: clanName = "Miggledy"; break;
            case 25: clanName = "Munggen"; break;
            case 26: clanName = "Murnig"; break;
            case 27: clanName = "Musgraben"; break;
            case 28: clanName = "Nackle"; break;
            case 29: clanName = "Ningel"; break;
            case 30: clanName = "Nopenstallen"; break;
            case 31: clanName = "Nucklestamp"; break;
            case 32: clanName = "Offund"; break;
            case 33: clanName = "Oomtrowl"; break;
            case 34: clanName = "Pilwicken"; break;
            case 35: clanName = "Pingun"; break;
            case 36: clanName = "Quillsharpener"; break;
            case 37: clanName = "Raulnor"; break;
            case 38: clanName = "Reese"; break;
            case 39: clanName = "Rofferton"; break;
            case 40: clanName = "Scheppen"; break;
            case 41: clanName = "Shadowcloak"; break;
            case 42: clanName = "Silverthread"; break;
            case 43: clanName = "Sympony"; break;
            case 44: clanName = "Tarkelby"; break;
            case 45: clanName = "Timbers"; break;
            case 46: clanName = "Turen"; break;
            case 47: clanName = "Umbodoben"; break;
            case 48: clanName = "Waggletop"; break;
            case 49: clanName = "Welber"; break;
            case 50: clanName = "Wildwander"; break;
        }

        return (givenName + " " + clanName);
    }

    public string HalflingName(ref NPCBlock block)
    {
        string givenName, familyName;
        givenName = "";
        familyName = "";

        switch (Random.Range(1,3))
        {
            case 1:
                gender = Gender.Female;
                block.race = ("Female " + block.race);
                break;
            case 2:
                gender = Gender.Male;
                block.race = ("Male " + block.race);
                break;
        }

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Alain"; break;
                case 2: givenName = "Andry"; break;
                case 3: givenName = "Anne"; break;
                case 4: givenName = "Bella"; break;
                case 5: givenName = "Blossom"; break;
                case 6: givenName = "Bree"; break;
                case 7: givenName = "Callie"; break;
                case 8: givenName = "Chenna"; break;
                case 9: givenName = "Cora"; break;
                case 10: givenName = "Dee"; break;
                case 11: givenName = "Dell"; break;
                case 12: givenName = "Eida"; break;
                case 13: givenName = "Eran"; break;
                case 14: givenName = "Euphemia"; break;
                case 15: givenName = "Georgina"; break;
                case 16: givenName = "Gynnie"; break;
                case 17: givenName = "Harriet"; break;
                case 18: givenName = "Jasmine"; break;
                case 19: givenName = "Jillian"; break;
                case 20: givenName = "Jo"; break;
                case 21: givenName = "Kithri"; break;
                case 22: givenName = "Lavinia"; break;
                case 23: givenName = "Lidda"; break;
                case 24: givenName = "Maegan"; break;
                case 25: givenName = "Marigold"; break;
                case 26: givenName = "Merla"; break;
                case 27: givenName = "Myria"; break;
                case 28: givenName = "Nedda"; break;
                case 29: givenName = "Nikki"; break;
                case 30: givenName = "Nora"; break;
                case 31: givenName = "Olivia"; break;
                case 32: givenName = "Paela"; break;
                case 33: givenName = "Pearl"; break;
                case 34: givenName = "Pennie"; break;
                case 35: givenName = "Philomena"; break;
                case 36: givenName = "Portia"; break;
                case 37: givenName = "Robbie"; break;
                case 38: givenName = "Rose"; break;
                case 39: givenName = "Saral"; break;
                case 40: givenName = "Seraphina"; break;
                case 41: givenName = "Shaena"; break;
                case 42: givenName = "Stacee"; break;
                case 43: givenName = "Tawna"; break;
                case 44: givenName = "Thea"; break;
                case 45: givenName = "Trym"; break;
                case 46: givenName = "Tyna"; break;
                case 47: givenName = "Vani"; break;
                case 48: givenName = "Verna"; break;
                case 49: givenName = "Wella"; break;
                case 50: givenName = "Willow"; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Alton"; break;
                case 2: givenName = "Ander"; break;
                case 3: givenName = "Bernie"; break;
                case 4: givenName = "Bobbin"; break;
                case 5: givenName = "Cade"; break;
                case 6: givenName = "Callus"; break;
                case 7: givenName = "Corrin"; break;
                case 8: givenName = "Dannad"; break;
                case 9: givenName = "Danniel"; break;
                case 10: givenName = "Eddie"; break;
                case 11: givenName = "Egart"; break;
                case 12: givenName = "Eldon"; break;
                case 13: givenName = "Errich"; break;
                case 14: givenName = "Fildo"; break;
                case 15: givenName = "Finnan"; break;
                case 16: givenName = "Franklin"; break;
                case 17: givenName = "Garret"; break;
                case 18: givenName = "Garth"; break;
                case 19: givenName = "Gilbert"; break;
                case 20: givenName = "Gob"; break;
                case 21: givenName = "Harol"; break;
                case 22: givenName = "Igor"; break;
                case 23: givenName = "Jasper"; break;
                case 24: givenName = "Keith"; break;
                case 25: givenName = "Kevin"; break;
                case 26: givenName = "Lazam"; break;
                case 27: givenName = "Lerry"; break;
                case 28: givenName = "Lindal"; break;
                case 29: givenName = "Lyle"; break;
                case 30: givenName = "Merric"; break;
                case 31: givenName = "Mican"; break;
                case 32: givenName = "Milo"; break;
                case 33: givenName = "Morrin"; break;
                case 34: givenName = "Nebin"; break;
                case 35: givenName = "Nevil"; break;
                case 36: givenName = "Osborn"; break;
                case 37: givenName = "Ostran"; break;
                case 38: givenName = "Oswalt"; break;
                case 39: givenName = "Perrin"; break;
                case 40: givenName = "Poppy"; break;
                case 41: givenName = "Reed"; break;
                case 42: givenName = "Roscoe"; break;
                case 43: givenName = "Sam"; break;
                case 44: givenName = "Shardon"; break;
                case 45: givenName = "Tye"; break;
                case 46: givenName = "Ulmo"; break;
                case 47: givenName = "Wellby"; break;
                case 48: givenName = "Wendel"; break;
                case 49: givenName = "Wenner"; break;
                case 50: givenName = "Wes"; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: familyName = "Abbleblossom"; break;
            case 2: familyName = "Bigheart"; break;
            case 3: familyName = "Brightmoon"; break;
            case 4: familyName = "Brushgather"; break;
            case 5: familyName = "Cherrycheeks"; break;
            case 6: familyName = "Copperkettle"; break;
            case 7: familyName = "Deephollow"; break;
            case 8: familyName = "Elderberry"; break;
            case 9: familyName = "Fastfoot"; break;
            case 10: familyName = "Fatrabbit"; break;
            case 11: familyName = "Glenfellow"; break;
            case 12: familyName = "Goldfound"; break;
            case 13: familyName = "Goodbarrel"; break;
            case 14: familyName = "Goodearth"; break;
            case 15: familyName = "Greenbottle"; break;
            case 16: familyName = "Greenleaf"; break;
            case 17: familyName = "High-Hill"; break;
            case 18: familyName = "Hilltopple"; break;
            case 19: familyName = "Hogcollar"; break;
            case 20: familyName = "Honeypot"; break;
            case 21: familyName = "Jamjar"; break;
            case 22: familyName = "Kettlewhistle"; break;
            case 23: familyName = "Leagallow"; break;
            case 24: familyName = "Littlefoot"; break;
            case 25: familyName = "Nimblefingers"; break;
            case 26: familyName = "Porridgepot"; break;
            case 27: familyName = "Quickstep"; break;
            case 28: familyName = "Reedfellow"; break;
            case 29: familyName = "Shadowquick"; break;
            case 30: familyName = "Silvereyes"; break;
            case 31: familyName = "Smoothhands"; break;
            case 32: familyName = "Stonebridge"; break;
            case 33: familyName = "Stoutbridge"; break;
            case 34: familyName = "Stoutman"; break;
            case 35: familyName = "Strongbones"; break;
            case 36: familyName = "Sunmeadow"; break;
            case 37: familyName = "Swiftwhistle"; break;
            case 38: familyName = "Tallfellow"; break;
            case 39: familyName = "Tealeaf"; break;
            case 40: familyName = "Tenpenny"; break;
            case 41: familyName = "Thistletop"; break;
            case 42: familyName = "Thorngage"; break;
            case 43: familyName = "Tosscobble"; break;
            case 44: familyName = "Underbough"; break;
            case 45: familyName = "Underfoot"; break;
            case 46: familyName = "Warmwater"; break;
            case 47: familyName = "Whispermouse"; break;
            case 48: familyName = "Wildcloak"; break;
            case 49: familyName = "Wildheart"; break;
            case 50: familyName = "Wiseacre"; break;
        }

        return (givenName + " " + familyName);
    }

    public string HalfOrcName(ref NPCBlock block)
    {
        string name;
        name = "";

        switch (Random.Range(1,3))
        {
            case 1:
                gender = Gender.Female;
                block.race = ("Female " + block.race);
                break;
            case 2:
                gender = Gender.Male;
                block.race = ("Male " + block.race);
                break;
        }

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: name = "Arha"; break;
                case 2: name = "Baggi"; break;
                case 3: name = "Bendoo"; break;
                case 4: name = "Bilga"; break;
                case 5: name = "Brakka"; break;
                case 6: name = "Creega"; break;
                case 7: name = "Drenna"; break;
                case 8: name = "Ekk"; break;
                case 9: name = "Emen"; break;
                case 10: name = "Engong"; break;
                case 11: name = "Fistula"; break;
                case 12: name = "Gaaki"; break;
                case 13: name = "Gorga"; break;
                case 14: name = "Grai"; break;
                case 15: name = "Greeba"; break;
                case 16: name = "Grigi"; break;
                case 17: name = "Gynk"; break;
                case 18: name = "Hrathy"; break;
                case 19: name = "Huru"; break;
                case 20: name = "Ilga"; break;
                case 21: name = "Kabbarg"; break;
                case 22: name = "Kansif"; break;
                case 23: name = "Lagazi"; break;
                case 24: name = "Lezre"; break;
                case 25: name = "Murgen"; break;
                case 26: name = "Murook"; break;
                case 27: name = "Myev"; break;
                case 28: name = "Nagrette"; break;
                case 29: name = "Neega"; break;
                case 30: name = "Nella"; break;
                case 31: name = "Nogu"; break;
                case 32: name = "Oolah"; break;
                case 33: name = "Ootah"; break;
                case 34: name = "Ovak"; break;
                case 35: name = "Ownka"; break;
                case 36: name = "Puyet"; break;
                case 37: name = "Reeza"; break;
                case 38: name = "Shautha"; break;
                case 39: name = "Silgre"; break;
                case 40: name = "Sutha"; break;
                case 41: name = "Tagga"; break;
                case 42: name = "Tawar"; break;
                case 43: name = "Tomph"; break;
                case 44: name = "Ubada"; break;
                case 45: name = "Vanchu"; break;
                case 46: name = "Vola"; break;
                case 47: name = "Volen"; break;
                case 48: name = "Vorka"; break;
                case 49: name = "Yevelda"; break;
                case 50: name = "Zagga"; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: name = "Argran"; break;
                case 2: name = "Braak"; break;
                case 3: name = "Brug"; break;
                case 4: name = "Cagak"; break;
                case 5: name = "Dench"; break;
                case 6: name = "Dorn"; break;
                case 7: name = "Dren"; break;
                case 8: name = "Druuk"; break;
                case 9: name = "Feng"; break;
                case 10: name = "Gell"; break;
                case 11: name = "Gnarsh"; break;
                case 12: name = "Grumbar"; break;
                case 13: name = "Gubrash"; break;
                case 14: name = "Hagren"; break;
                case 15: name = "Henk"; break;
                case 16: name = "Hogar"; break;
                case 17: name = "Holg"; break;
                case 18: name = "Imsh"; break;
                case 19: name = "Karash"; break;
                case 20: name = "Karg"; break;
                case 21: name = "Keth"; break;
                case 22: name = "Korag"; break;
                case 23: name = "Krusk"; break;
                case 24: name = "Lubash"; break;
                case 25: name = "Megged"; break;
                case 26: name = "Mhurren"; break;
                case 27: name = "Mord"; break;
                case 28: name = "Morg"; break;
                case 29: name = "Nil"; break;
                case 30: name = "Nybarg"; break;
                case 31: name = "Odorr"; break;
                case 32: name = "Ohr"; break;
                case 33: name = "Rendar"; break;
                case 34: name = "Resh"; break;
                case 35: name = "Ront"; break;
                case 36: name = "Rrath"; break;
                case 37: name = "Sark"; break;
                case 38: name = "Scrag"; break;
                case 39: name = "Sheggen"; break;
                case 40: name = "Shump"; break;
                case 41: name = "Tanglar"; break;
                case 42: name = "Tarak"; break;
                case 43: name = "Thar"; break;
                case 44: name = "Thokk"; break;
                case 45: name = "Trag"; break;
                case 46: name = "Ugarth"; break;
                case 47: name = "Varg"; break;
                case 48: name = "Vilberg"; break;
                case 49: name = "Yurk"; break;
                case 50: name = "Zed"; break;
            }
        }

        return name;
    }

    public string TieflingName(ref NPCBlock block)
    {
        string givenName, virtue;
        givenName = "";
        virtue = "";

        switch (Random.Range(1,3))
        {
            case 1:
                gender = Gender.Female;
                block.race = ("Female " + block.race);
                break;
            case 2:
                gender = Gender.Male;
                block.race = ("Male " + block.race);
                break;
        }

        if (gender == Gender.Female)
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Akta"; break;
                case 2: givenName = "Anakis"; break;
                case 3: givenName = "Armara"; break;
                case 4: givenName = "Astaro"; break;
                case 5: givenName = "Aym"; break;
                case 6: givenName = "Azza"; break;
                case 7: givenName = "Beleth"; break;
                case 8: givenName = "Bryseis"; break;
                case 9: givenName = "Bune"; break;
                case 10: givenName = "Criella"; break;
                case 11: givenName = "Damaia"; break;
                case 12: givenName = "Decarabia"; break;
                case 13: givenName = "Ea"; break;
                case 14: givenName = "Gadreel"; break;
                case 15: givenName = "Gomory"; break;
                case 16: givenName = "Hecat"; break;
                case 17: givenName = "Ishte"; break;
                case 18: givenName = "Jezebeth"; break;
                case 19: givenName = "Kali"; break;
                case 20: givenName = "Kallista"; break;
                case 21: givenName = "Kasdeya"; break;
                case 22: givenName = "Lerissa"; break;
                case 23: givenName = "Lilith"; break;
                case 24: givenName = "Makaria"; break;
                case 25: givenName = "Manea"; break;
                case 26: givenName = "Markosian"; break;
                case 27: givenName = "Mastema"; break;
                case 28: givenName = "Naamah"; break;
                case 29: givenName = "Nemia"; break;
                case 30: givenName = "Nija"; break;
                case 31: givenName = "Orianna"; break;
                case 32: givenName = "Osah"; break;
                case 33: givenName = "Phelaia"; break;
                case 34: givenName = "Prosperine"; break;
                case 35: givenName = "Purah"; break;
                case 36: givenName = "Pyra"; break;
                case 37: givenName = "Rieta"; break;
                case 38: givenName = "Ronobe"; break;
                case 39: givenName = "Ronwe"; break;
                case 40: givenName = "Seddit"; break;
                case 41: givenName = "Seere"; break;
                case 42: givenName = "Sekhmet"; break;
                case 43: givenName = "Semyaza"; break;
                case 44: givenName = "Shava"; break;
                case 45: givenName = "Shax"; break;
                case 46: givenName = "Sorath"; break;
                case 47: givenName = "Uzza"; break;
                case 48: givenName = "Vapula"; break;
                case 49: givenName = "Vepar"; break;
                case 50: givenName = "Verin"; break;
            }
        }
        else
        {
            switch (Random.Range(1, 51))
            {
                case 1: givenName = "Abad"; break;
                case 2: givenName = "Ahrim"; break;
                case 3: givenName = "Akmen"; break;
                case 4: givenName = "Amnon"; break;
                case 5: givenName = "Andram"; break;
                case 6: givenName = "Astar"; break;
                case 7: givenName = "Balam"; break;
                case 8: givenName = "Barakas"; break;
                case 9: givenName = "Bathin"; break;
                case 10: givenName = "Caim"; break;
                case 11: givenName = "Chem"; break;
                case 12: givenName = "Cimer"; break;
                case 13: givenName = "Cressel"; break;
                case 14: givenName = "Damakos"; break;
                case 15: givenName = "Ekemon"; break;
                case 16: givenName = "Euron"; break;
                case 17: givenName = "Fenriz"; break;
                case 18: givenName = "Forcas"; break;
                case 19: givenName = "Habor"; break;
                case 20: givenName = "Iados"; break;
                case 21: givenName = "Kairon"; break;
                case 22: givenName = "Leucis"; break;
                case 23: givenName = "Mamnen"; break;
                case 24: givenName = "Mantus"; break;
                case 25: givenName = "Marbas"; break;
                case 26: givenName = "Melech"; break;
                case 27: givenName = "Merihim"; break;
                case 28: givenName = "Modean"; break;
                case 29: givenName = "Mordai"; break;
                case 30: givenName = "Mormo"; break;
                case 31: givenName = "Morthos"; break;
                case 32: givenName = "Nicor"; break;
                case 33: givenName = "Nirgel"; break;
                case 34: givenName = "Oriax"; break;
                case 35: givenName = "Paymon"; break;
                case 36: givenName = "Pelaios"; break;
                case 37: givenName = "Purson"; break;
                case 38: givenName = "Qemuel"; break;
                case 39: givenName = "Raam"; break;
                case 40: givenName = "Rimmon"; break;
                case 41: givenName = "Sammal"; break;
                case 42: givenName = "Skamos"; break;
                case 43: givenName = "Tethren"; break;
                case 44: givenName = "Thamuz"; break;
                case 45: givenName = "Therai"; break;
                case 46: givenName = "Valafar"; break;
                case 47: givenName = "Vassago"; break;
                case 48: givenName = "Xappan"; break;
                case 49: givenName = "Zepar"; break;
                case 50: givenName = "Zephan"; break;
            }
        }

        switch (Random.Range(1, 51))
        {
            case 1: virtue = "Ambition"; break;
            case 2: virtue = "Art"; break;
            case 3: virtue = "Carrion"; break;
            case 4: virtue = "Chant"; break;
            case 5: virtue = "Creed"; break;
            case 6: virtue = "Death"; break;
            case 7: virtue = "Debauchery"; break;
            case 8: virtue = "Despair"; break;
            case 9: virtue = "Doom"; break;
            case 10: virtue = "Doubt"; break;
            case 11: virtue = "Dread"; break;
            case 12: virtue = "Extacy"; break;
            case 13: virtue = "Ennui"; break;
            case 14: virtue = "Entropy"; break;
            case 15: virtue = "Excellence"; break;
            case 16: virtue = "Fear"; break;
            case 17: virtue = "Glory"; break;
            case 18: virtue = "Gluttony"; break;
            case 19: virtue = "Grief"; break;
            case 20: virtue = "Hate"; break;
            case 21: virtue = "Hope"; break;
            case 22: virtue = "Horror"; break;
            case 23: virtue = "Ideal"; break;
            case 24: virtue = "Ignomony"; break;
            case 25: virtue = "Laughter"; break;
            case 26: virtue = "Love"; break;
            case 27: virtue = "Lust"; break;
            case 28: virtue = "Mayhem"; break;
            case 29: virtue = "Mockery"; break;
            case 30: virtue = "Murder"; break;
            case 31: virtue = "Muse"; break;
            case 32: virtue = "Music"; break;
            case 33: virtue = "Mystery"; break;
            case 34: virtue = "Nowhere"; break;
            case 35: virtue = "Open"; break;
            case 36: virtue = "Pain"; break;
            case 37: virtue = "Passion"; break;
            case 38: virtue = "Poetry"; break;
            case 39: virtue = "Quest"; break;
            case 40: virtue = "Random"; break;
            case 41: virtue = "Reverence"; break;
            case 42: virtue = "Revulsion"; break;
            case 43: virtue = "Sorrow"; break;
            case 44: virtue = "Temerity"; break;
            case 45: virtue = "Torment"; break;
            case 46: virtue = "Tragedy"; break;
            case 47: virtue = "Vice"; break;
            case 48: virtue = "Virtue"; break;
            case 49: virtue = "Weary"; break;
            case 50: virtue = "Wit"; break;
        }

        return (givenName + " " + virtue);
    }

    public string Input(ref NPCBlock block) {
        string name = "";

        switch (block.race) {
            case "Human": name = HumanName(ref block); break;
            case "High Elf":
            case "Wood Elf": name = ElfName(ref block); break;
            case "Mountain Dwarf":
            case "Hill Dwarf": name = DwarfName(ref block); break;
            case "Gnome": name = GnomeName(ref block); break;
            case "Half-Elf":
                switch (Random.Range(1, 3))
                {
                    case 1:
                        name = HumanName(ref block);
                        break;
                    case 2:
                        name = ElfName(ref block);
                        break;
                }
                break;
            case "Halfling": name = HalflingName(ref block); break;
            case "Half-Orc": name = HalfOrcName(ref block); break;
            case "Dragonborn": name = DragonbornName(ref block); break;
            case "Tiefling": name = TieflingName(ref block); break;
        }

        return name;
    }

	void Start () {
        npcName = FindObjectOfType<NPCName>().GetComponent<Text>();
        npcRace = FindObjectOfType<NPCRace>().GetComponent<Text>();
	}
}