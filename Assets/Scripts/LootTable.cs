using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LootTable : MonoBehaviour
{

    Slider hordeStrength, individualStrength, individualNum;
    LootGenerator lootGenerator;
    Dropdown money, gems, art, magicItems;
    Toggle hordeOrIndividual;

    private void Start()
    {
        hordeStrength = FindObjectOfType<HordeSlider>().GetComponent<Slider>();
        individualStrength = FindObjectOfType<IndividualSlider>().GetComponent<Slider>();
        individualNum = FindObjectOfType<IndivNumSlider>().GetComponent<Slider>();
        lootGenerator = FindObjectOfType<LootGenerator>();
        money = FindObjectOfType<MoneyLoot>().GetComponent<Dropdown>();
        gems = FindObjectOfType<GemLoot>().GetComponent<Dropdown>();
        art = FindObjectOfType<ArtLoot>().GetComponent<Dropdown>();
        magicItems = FindObjectOfType<MagicLoot>().GetComponent<Dropdown>();
        hordeOrIndividual = FindObjectOfType<Toggle>();
    }


    public void Generate()
    {
        ClearLoot();
        if (hordeOrIndividual.isOn)
        {
            int n = (int)individualStrength.value;

            switch (n){
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    IT04(((int)individualNum.value));
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    IT510(((int)individualNum.value));
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                    IT1116(((int)individualNum.value));
                    break;
                default:
                    IT17(((int)individualNum.value));
                    break;
            }
        }
        else
        {
            int n = (int)hordeStrength.value;

            switch (n)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    TH04();
                    break;
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    TH510();
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                    TH1116();
                    break;
                default:
                    TH17();
                    break;
            }
        }
    }

    void TH04()
    {
        List<string> coins = new List<string>
        {
            {"Copper " + (100 * lootGenerator.Dice(6,6)).ToString()},
            {"Silver " + (100 * lootGenerator.Dice(3,6)).ToString()},
            {"Gold " + (10 * lootGenerator.Dice(2,6)).ToString()}
        };

        int roll = Random.Range(1, 101);
        List<string> gemLoot = new List<string>();
        List<string> artLoot = new List<string>();
        List<string> magLoot = new List<string>();

        switch (roll)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
                break;
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
            case 16:
                gemLoot = new List<string>(lootGenerator.Gems10(lootGenerator.Dice(2, 6)));
                break;
            case 17:
            case 18:
            case 19:
            case 20:
            case 21:
            case 22:
            case 23:
            case 24:
            case 25:
            case 26:
                artLoot = new List<string>(lootGenerator.Art25(lootGenerator.Dice(2, 4)));
                break;
            case 27:
            case 28:
            case 29:
            case 30:
            case 31:
            case 32:
            case 33:
            case 34:
            case 35:
            case 36:
                gemLoot = new List<string>(lootGenerator.Gems50(lootGenerator.Dice(2, 6)));
                break;
            case 37:
            case 38:
            case 39:
            case 40:
            case 41:
            case 42:
            case 43:
            case 44:
                gemLoot = new List<string>(lootGenerator.Gems10(lootGenerator.Dice(2, 6)));
                magLoot = new List<string>(lootGenerator.MITA(lootGenerator.Dice(1, 6)));
                break;
            case 45:
            case 46:
            case 47:
            case 48:
            case 49:
            case 50:
            case 51:
            case 52:
                artLoot = new List<string>(lootGenerator.Art25(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITA(lootGenerator.Dice(1, 6)));
                break;
            case 53:
            case 54:
            case 55:
            case 56:
            case 57:
            case 58:
            case 59:
            case 60:
                gemLoot = new List<string>(lootGenerator.Gems50(lootGenerator.Dice(2, 6)));
                magLoot = new List<string>(lootGenerator.MITA(lootGenerator.Dice(1, 6)));
                break;
            case 61:
            case 62:
            case 63:
            case 64:
            case 65:
                gemLoot = new List<string>(lootGenerator.Gems10(lootGenerator.Dice(2, 6)));
                magLoot = new List<string>(lootGenerator.MITB(lootGenerator.Dice(1, 4)));
                break;
            case 66:
            case 67:
            case 68:
            case 69:
            case 70:
                artLoot = new List<string>(lootGenerator.Art25(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITB(lootGenerator.Dice(1, 4)));
                break;
            case 71:
            case 72:
            case 73:
            case 74:
            case 75:
                gemLoot = new List<string>(lootGenerator.Gems50(lootGenerator.Dice(2, 6)));
                magLoot = new List<string>(lootGenerator.MITB(lootGenerator.Dice(1, 4)));
                break;
            case 76:
            case 77:
            case 78:
                gemLoot = new List<string>(lootGenerator.Gems10(lootGenerator.Dice(2, 6)));
                magLoot = new List<string>(lootGenerator.MITC(lootGenerator.Dice(1, 4)));
                break;
            case 79:
            case 80:
                artLoot = new List<string>(lootGenerator.Art25(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITC(lootGenerator.Dice(1, 4)));
                break;
            case 81:
            case 82:
            case 83:
            case 84:
            case 85:
                gemLoot = new List<string>(lootGenerator.Gems50(lootGenerator.Dice(2, 6)));
                magLoot = new List<string>(lootGenerator.MITC(lootGenerator.Dice(1, 4)));
                break;
            case 86:
            case 87:
            case 88:
            case 89:
            case 90:
            case 91:
            case 92:
                artLoot = new List<string>(lootGenerator.Art25(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITF(lootGenerator.Dice(1, 4)));
                break;
            case 93:
            case 94:
            case 95:
            case 96:
            case 97:
                gemLoot = new List<string>(lootGenerator.Gems50(lootGenerator.Dice(2, 6)));
                magLoot = new List<string>(lootGenerator.MITF(lootGenerator.Dice(1, 4)));
                break;
            case 98:
            case 99:
                artLoot = new List<string>(lootGenerator.Art25(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITG(1));
                break;
            case 100:
                gemLoot = new List<string>(lootGenerator.Gems50(lootGenerator.Dice(2, 6)));
                magLoot = new List<string>(lootGenerator.MITG(1));
                break;
        }

        money.AddOptions(coins);

        if (gemLoot.Count > 0)
        {
            gems.AddOptions(gemLoot);
        }

        if (artLoot.Count > 0)
        {
            art.AddOptions(artLoot);
        }

        if (magLoot.Count > 0)
        {
            magicItems.AddOptions(magLoot);
        }
    }
    void TH510()
    {
        List<string> coins = new List<string>
        {
            {"Copper " + (100 * lootGenerator.Dice(2,6)).ToString()},
            {"Silver " + (1000 * lootGenerator.Dice(2,6)).ToString()},
            {"Gold " + (100 * lootGenerator.Dice(6,6)).ToString()},
            {"Platinum" + (10 * lootGenerator.Dice(3,6)).ToString()}
        };

        int roll = Random.Range(1, 101);
        List<string> gemLoot = new List<string>();
        List<string> artLoot = new List<string>();
        List<string> magLoot = new List<string>();

        switch (roll)
        {
            case 1:
            case 2:
            case 3:
            case 4:
                break;
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
                artLoot = new List<string>(lootGenerator.Art25(lootGenerator.Dice(2, 4)));
                break;
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
            case 16:
                gemLoot = new List<string>(lootGenerator.Gems50(lootGenerator.Dice(3, 6)));
                break;
            case 17:
            case 18:
            case 19:
            case 20:
            case 21:
            case 22:
                gemLoot = new List<string>(lootGenerator.Gems100(lootGenerator.Dice(3, 6)));
                break;
            case 23:
            case 24:
            case 25:
            case 26:
            case 27:
            case 28:
                artLoot = new List<string>(lootGenerator.Art250(lootGenerator.Dice(2, 4)));
                break;
            case 29:
            case 30:
            case 31:
            case 32:
                artLoot = new List<string>(lootGenerator.Art25(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITA(lootGenerator.Dice(1, 6)));
                break;
            case 33:
            case 34:
            case 35:
            case 36:
                gemLoot = new List<string>(lootGenerator.Gems50(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITA(lootGenerator.Dice(1, 6)));
                break;
            case 37:
            case 38:
            case 39:
            case 40:
                gemLoot = new List<string>(lootGenerator.Gems100(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITA(lootGenerator.Dice(1, 6)));
                break;
            case 41:
            case 42:
            case 43:
            case 44:
                artLoot = new List<string>(lootGenerator.Art250(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITA(lootGenerator.Dice(1, 6)));
                break;
            case 45:
            case 46:
            case 47:
            case 48:
            case 49:
                artLoot = new List<string>(lootGenerator.Art25(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITB(lootGenerator.Dice(1, 4)));
                break;
            case 50:
            case 51:
            case 52:
            case 53:
            case 54:
                gemLoot = new List<string>(lootGenerator.Gems50(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITB(lootGenerator.Dice(1, 4)));
                break;
            case 55:
            case 56:
            case 57:
            case 58:
            case 59:
                gemLoot = new List<string>(lootGenerator.Gems100(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITB(lootGenerator.Dice(1, 4)));
                break;
            case 60:
            case 61:
            case 62:
            case 63:
                artLoot = new List<string>(lootGenerator.Art250(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITB(lootGenerator.Dice(1, 4)));
                break;
            case 64:
            case 65:
            case 66:
                artLoot = new List<string>(lootGenerator.Art25(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITC(lootGenerator.Dice(1, 4)));
                break;
            case 67:
            case 68:
            case 69:
                gemLoot = new List<string>(lootGenerator.Gems50(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITC(lootGenerator.Dice(1, 4)));
                break;
            case 70:
            case 71:
            case 72:
                gemLoot = new List<string>(lootGenerator.Gems100(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITC(lootGenerator.Dice(1, 4)));
                break;
            case 73:
            case 74:
                artLoot = new List<string>(lootGenerator.Art250(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITC(lootGenerator.Dice(1, 4)));
                break;
            case 75:
            case 76:
                artLoot = new List<string>(lootGenerator.Art25(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITD(1));
                break;
            case 77:
            case 78:
                gemLoot = new List<string>(lootGenerator.Gems50(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITD(1));
                break;
            case 79:
                gemLoot = new List<string>(lootGenerator.Gems100(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITD(1));
                break;
            case 80:
                artLoot = new List<string>(lootGenerator.Art250(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITD(1));
                break;
            case 81:
            case 82:
            case 83:
            case 84:
                artLoot = new List<string>(lootGenerator.Art25(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITF(lootGenerator.Dice(1, 4)));
                break;
            case 85:
            case 86:
            case 87:
            case 88:
                gemLoot = new List<string>(lootGenerator.Gems50(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITF(lootGenerator.Dice(1, 4)));
                break;
            case 89:
            case 90:
            case 91:
                gemLoot = new List<string>(lootGenerator.Gems100(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITF(lootGenerator.Dice(1, 4)));
                break;
            case 92:
            case 93:
            case 94:
                gemLoot = new List<string>(lootGenerator.Art250(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITF(lootGenerator.Dice(1, 4)));
                break;
            case 95:
            case 96:
                gemLoot = new List<string>(lootGenerator.Gems100(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITG(lootGenerator.Dice(1, 4)));
                break;
            case 97:
            case 98:
                artLoot = new List<string>(lootGenerator.Art250(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITG(lootGenerator.Dice(1, 4)));
                break;
            case 99:
                gemLoot = new List<string>(lootGenerator.Gems100(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITH(1));
                break;
            case 100:
                artLoot = new List<string>(lootGenerator.Art250(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITH(1));
                break;
        }

        money.AddOptions(coins);

        if (gemLoot.Count > 0)
        {
            gems.AddOptions(gemLoot);
        }

        if (artLoot.Count > 0)
        {
            art.AddOptions(artLoot);
        }

        if (magLoot.Count > 0)
        {
            magicItems.AddOptions(magLoot);
        }
    }
    void TH1116()
    {
        List<string> coins = new List<string>
        {
            {"Gold " + (1000 * lootGenerator.Dice(4,6)).ToString()},
            {"Platinum" + (100 * lootGenerator.Dice(5,6)).ToString()}
        };

        int roll = Random.Range(1, 101);
        List<string> gemLoot = new List<string>();
        List<string> artLoot = new List<string>();
        List<string> magLoot = new List<string>();

        switch (roll)
        {
            case 1:
            case 2:
            case 3:
                break;
            case 4:
            case 5:
            case 6:
                artLoot = new List<string>(lootGenerator.Art250(lootGenerator.Dice(2, 4)));
                break;
            case 7:
            case 8:
            case 9:
                artLoot = new List<string>(lootGenerator.Art750(lootGenerator.Dice(2, 4)));
                break;
            case 10:
            case 11:
            case 12:
                gemLoot = new List<string>(lootGenerator.Gems500(lootGenerator.Dice(3, 6)));
                break;
            case 13:
            case 14:
            case 15:
                gemLoot = new List<string>(lootGenerator.Gems1000(lootGenerator.Dice(3, 6)));
                break;
            case 16:
            case 17:
            case 18:
            case 19:
                artLoot = new List<string>(lootGenerator.Art250(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITA(lootGenerator.Dice(1, 4)));
                magLoot.AddRange(lootGenerator.MITB(lootGenerator.Dice(1, 6)));
                break;
            case 20:
            case 21:
            case 22:
            case 23:
                artLoot = new List<string>(lootGenerator.Art750(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITA(lootGenerator.Dice(1, 4)));
                magLoot.AddRange(lootGenerator.MITB(lootGenerator.Dice(1, 6)));
                break;
            case 24:
            case 25:
            case 26:
                gemLoot = new List<string>(lootGenerator.Gems500(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITA(lootGenerator.Dice(1, 4)));
                magLoot.AddRange(lootGenerator.MITB(lootGenerator.Dice(1, 6)));
                break;
            case 27:
            case 28:
            case 29:
                gemLoot = new List<string>(lootGenerator.Gems1000(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITA(lootGenerator.Dice(1, 4)));
                magLoot.AddRange(lootGenerator.MITB(lootGenerator.Dice(1, 6)));
                break;
            case 30:
            case 31:
            case 32:
            case 33:
            case 34:
            case 35:
                artLoot = new List<string>(lootGenerator.Art250(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITC(lootGenerator.Dice(1, 6)));
                break;
            case 36:
            case 37:
            case 38:
            case 39:
            case 40:
                artLoot = new List<string>(lootGenerator.Art750(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITC(lootGenerator.Dice(1, 6)));
                break;
            case 41:
            case 42:
            case 43:
            case 44:
            case 45:
                gemLoot = new List<string>(lootGenerator.Gems500(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITC(lootGenerator.Dice(1, 6)));
                break;
            case 46:
            case 47:
            case 48:
            case 49:
            case 50:
                gemLoot = new List<string>(lootGenerator.Gems1000(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITC(lootGenerator.Dice(1, 6)));
                break;
            case 51:
            case 52:
            case 53:
            case 54:
                artLoot = new List<string>(lootGenerator.Art250(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITD(lootGenerator.Dice(1, 4)));
                break;
            case 55:
            case 56:
            case 57:
            case 58:
                artLoot = new List<string>(lootGenerator.Art750(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITD(lootGenerator.Dice(1, 4)));
                break;
            case 59:
            case 60:
            case 61:
            case 62:
                gemLoot = new List<string>(lootGenerator.Gems500(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITD(lootGenerator.Dice(1, 4)));
                break;
            case 63:
            case 64:
            case 65:
            case 66:
                gemLoot = new List<string>(lootGenerator.Gems1000(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITD(lootGenerator.Dice(1, 4)));
                break;
            case 67:
            case 68:
                artLoot = new List<string>(lootGenerator.Art250(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITE(1));
                break;
            case 69:
            case 70:
                artLoot = new List<string>(lootGenerator.Art750(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITE(1));
                break;
            case 71:
            case 72:
                gemLoot = new List<string>(lootGenerator.Gems500(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITE(1));
                break;
            case 73:
            case 74:
                gemLoot = new List<string>(lootGenerator.Gems1000(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITE(1));
                break;
            case 75:
            case 76:
                artLoot = new List<string>(lootGenerator.Art250(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITF(1));
                magLoot.AddRange(lootGenerator.MITG(lootGenerator.Dice(1, 4)));
                break;
            case 77:
            case 78:
                artLoot = new List<string>(lootGenerator.Art750(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITF(1));
                magLoot.AddRange(lootGenerator.MITG(lootGenerator.Dice(1, 4)));
                break;
            case 79:
            case 80:
                gemLoot = new List<string>(lootGenerator.Gems500(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITF(1));
                magLoot.AddRange(lootGenerator.MITG(lootGenerator.Dice(1, 4)));
                break;
            case 81:
            case 82:
                gemLoot = new List<string>(lootGenerator.Gems1000(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITF(1));
                magLoot.AddRange(lootGenerator.MITG(lootGenerator.Dice(1, 4)));
                break;
            case 83:
            case 84:
            case 85:
                artLoot = new List<string>(lootGenerator.Art250(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITH(lootGenerator.Dice(1, 4)));
                break;
            case 86:
            case 87:
            case 88:
                artLoot = new List<string>(lootGenerator.Art750(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITH(lootGenerator.Dice(1, 4)));
                break;
            case 89:
            case 90:
                gemLoot = new List<string>(lootGenerator.Gems500(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITH(lootGenerator.Dice(1, 4)));
                break;
            case 91:
            case 92:
                gemLoot = new List<string>(lootGenerator.Gems1000(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITH(lootGenerator.Dice(1, 4)));
                break;
            case 93:
            case 94:
                artLoot = new List<string>(lootGenerator.Art250(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITI(1));
                break;
            case 95:
            case 96:
                artLoot = new List<string>(lootGenerator.Art750(lootGenerator.Dice(2, 4)));
                magLoot = new List<string>(lootGenerator.MITI(1));
                break;
            case 97:
            case 98:
                gemLoot = new List<string>(lootGenerator.Gems500(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITI(1));
                break;
            case 99:
            case 100:
                gemLoot = new List<string>(lootGenerator.Gems1000(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITI(1));
                break;
        }

        money.AddOptions(coins);

        if (gemLoot.Count > 0)
        {
            gems.AddOptions(gemLoot);
        }

        if (artLoot.Count > 0)
        {
            art.AddOptions(artLoot);
        }

        if (magLoot.Count > 0)
        {
            magicItems.AddOptions(magLoot);
        }
    }
    void TH17()
    {
        List<string> coins = new List<string>
        {
            {"Gold " + (1000 * lootGenerator.Dice(12, 6)).ToString()},
            {"Platinum" + (1000 * lootGenerator.Dice(8, 6)).ToString()}
        };

        int roll = Random.Range(1, 101);
        List<string> gemLoot = new List<string>();
        List<string> artLoot = new List<string>();
        List<string> magLoot = new List<string>();

        switch (roll)
        {
            case 1:
            case 2:
                break;
            case 3:
            case 4:
            case 5:
                gemLoot = new List<string>(lootGenerator.Gems1000(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITC(lootGenerator.Dice(1, 8)));
                break;
            case 6:
            case 7:
            case 8:
                artLoot = new List<string>(lootGenerator.Art2500(lootGenerator.Dice(1, 10)));
                magLoot = new List<string>(lootGenerator.MITC(lootGenerator.Dice(1, 8)));
                break;
            case 9:
            case 10:
            case 11:
                artLoot = new List<string>(lootGenerator.Art7500(lootGenerator.Dice(1, 4)));
                magLoot = new List<string>(lootGenerator.MITC(lootGenerator.Dice(1, 8)));
                break;
            case 12:
            case 13:
            case 14:
                gemLoot = new List<string>(lootGenerator.Gems5000(lootGenerator.Dice(1, 8)));
                magLoot = new List<string>(lootGenerator.MITC(lootGenerator.Dice(1, 8)));
                break;
            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
            case 20:
            case 21:
            case 22:
                gemLoot = new List<string>(lootGenerator.Gems1000(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITD(lootGenerator.Dice(1, 6)));
                break;
            case 23:
            case 24:
            case 25:
            case 26:
            case 27:
            case 28:
            case 29:
            case 30:
                artLoot = new List<string>(lootGenerator.Art2500(lootGenerator.Dice(1, 10)));
                magLoot = new List<string>(lootGenerator.MITD(lootGenerator.Dice(1, 6)));
                break;
            case 31:
            case 32:
            case 33:
            case 34:
            case 35:
            case 36:
            case 37:
            case 38:
                artLoot = new List<string>(lootGenerator.Art7500(lootGenerator.Dice(1, 4)));
                magLoot = new List<string>(lootGenerator.MITD(lootGenerator.Dice(1, 6)));
                break;
            case 39:
            case 40:
            case 41:
            case 42:
            case 43:
            case 44:
            case 45:
            case 46:
                gemLoot = new List<string>(lootGenerator.Gems5000(lootGenerator.Dice(1, 8)));
                magLoot = new List<string>(lootGenerator.MITD(lootGenerator.Dice(1, 6)));
                break;
            case 47:
            case 48:
            case 49:
            case 50:
            case 51:
            case 52:
                gemLoot = new List<string>(lootGenerator.Gems1000(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITE(lootGenerator.Dice(1, 6)));
                break;
            case 53:
            case 54:
            case 55:
            case 56:
            case 57:
            case 58:
                artLoot = new List<string>(lootGenerator.Art2500(lootGenerator.Dice(1, 10)));
                magLoot = new List<string>(lootGenerator.MITE(lootGenerator.Dice(1, 6)));
                break;
            case 59:
            case 60:
            case 61:
            case 62:
            case 63:
                artLoot = new List<string>(lootGenerator.Art7500(lootGenerator.Dice(1, 4)));
                magLoot = new List<string>(lootGenerator.MITE(lootGenerator.Dice(1, 6)));
                break;
            case 64:
            case 65:
            case 66:
            case 67:
            case 68:
                gemLoot = new List<string>(lootGenerator.Gems5000(lootGenerator.Dice(1, 8)));
                magLoot = new List<string>(lootGenerator.MITE(lootGenerator.Dice(1, 6)));
                break;
            case 69:
                gemLoot = new List<string>(lootGenerator.Gems1000(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITG(lootGenerator.Dice(1, 4)));
                break;
            case 70:
                artLoot = new List<string>(lootGenerator.Art2500(lootGenerator.Dice(1, 10)));
                magLoot = new List<string>(lootGenerator.MITG(lootGenerator.Dice(1, 4)));
                break;
            case 71:
                artLoot = new List<string>(lootGenerator.Art7500(lootGenerator.Dice(1, 4)));
                magLoot = new List<string>(lootGenerator.MITG(lootGenerator.Dice(1, 4)));
                break;
            case 72:
                gemLoot = new List<string>(lootGenerator.Gems5000(lootGenerator.Dice(1, 8)));
                magLoot = new List<string>(lootGenerator.MITG(lootGenerator.Dice(1, 4)));
                break;
            case 73:
            case 74:
                gemLoot = new List<string>(lootGenerator.Gems1000(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITH(lootGenerator.Dice(1, 4)));
                break;
            case 75:
            case 76:
                artLoot = new List<string>(lootGenerator.Art2500(lootGenerator.Dice(1, 10)));
                magLoot = new List<string>(lootGenerator.MITH(lootGenerator.Dice(1, 4)));
                break;
            case 77:
            case 78:
                artLoot = new List<string>(lootGenerator.Art7500(lootGenerator.Dice(1, 4)));
                magLoot = new List<string>(lootGenerator.MITH(lootGenerator.Dice(1, 4)));
                break;
            case 79:
            case 80:
                gemLoot = new List<string>(lootGenerator.Gems5000(lootGenerator.Dice(1, 8)));
                magLoot = new List<string>(lootGenerator.MITH(lootGenerator.Dice(1, 4)));
                break;
            case 81:
            case 82:
            case 83:
            case 84:
            case 85:
                gemLoot = new List<string>(lootGenerator.Gems1000(lootGenerator.Dice(3, 6)));
                magLoot = new List<string>(lootGenerator.MITI(lootGenerator.Dice(1, 4)));
                break;
            case 86:
            case 87:
            case 88:
            case 89:
            case 90:
                artLoot = new List<string>(lootGenerator.Art2500(lootGenerator.Dice(1, 10)));
                magLoot = new List<string>(lootGenerator.MITI(lootGenerator.Dice(1, 4)));
                break;
            case 91:
            case 92:
            case 93:
            case 94:
            case 95:
                artLoot = new List<string>(lootGenerator.Art7500(lootGenerator.Dice(1, 4)));
                magLoot = new List<string>(lootGenerator.MITI(lootGenerator.Dice(1, 4)));
                break;
            case 96:
            case 97:
            case 98:
            case 99:
            case 100:
                gemLoot = new List<string>(lootGenerator.Gems5000(lootGenerator.Dice(1, 8)));
                magLoot = new List<string>(lootGenerator.MITI(lootGenerator.Dice(1, 4)));
                break;
        }

        money.AddOptions(coins);

        if (gemLoot.Count > 0)
        {
            gems.AddOptions(gemLoot);
        }

        if (artLoot.Count > 0)
        {
            art.AddOptions(artLoot);
        }

        if (magLoot.Count > 0)
        {
            magicItems.AddOptions(magLoot);
        }
    }

    void IT04(int num)
    {
        Dictionary<string, int> loot = new Dictionary<string, int>
        {
            {"Copper", 0},
            {"Silver", 0},
            {"Electrum", 0},
            {"Gold", 0},
            {"Platinum", 0}
        };
        int temp = 0;
        int temp1 = 0;

        for (int i = 1; i <= num; i++)
        {
            int random = Random.Range(1, 101);

            if (random <= 30)
            {
                temp = loot["Copper"];
                temp1 = lootGenerator.Dice(5, 6);
                
                loot["Copper"] = temp + temp1;
                
            }
            else if (random <= 60)
            {
                temp = loot["Silver"];
                temp1 = lootGenerator.Dice(4, 6);
                
                loot["Silver"] = temp + temp1;
                
            }
            else if (random <= 70)
            {
                temp = loot["Electrum"];
                temp1 = lootGenerator.Dice(3, 6);
              
                loot["Electrum"] = temp + temp1;
              
            }
            else if (random <= 95)
            {
                temp = loot["Gold"];
                temp1 = lootGenerator.Dice(3, 6);
               
                loot["Gold"] = temp + temp1;
               
            }
            else
            {
                temp = loot["Platinum"];
                temp1 = lootGenerator.Dice(1, 6);

                loot["Platinum"] = temp + temp1;

            }
        }

        List<string> lootList = DictionaryToList(loot);

        money.AddOptions(lootList);
    }
    void IT510(int num)
    {
        Dictionary<string, int> loot = new Dictionary<string, int>
        {
            {"Copper", 0},
            {"Silver", 0},
            {"Electrum", 0},
            {"Gold", 0},
            {"Platinum", 0}
        };

        for (int i = 1; i <= num; i++)
        {
            int random = UnityEngine.Random.Range(1, 101);

            if (random <= 30)
            {

                loot["Copper"] += (100 * lootGenerator.Dice(4, 6));
                loot["Electrum"] += (10 * lootGenerator.Dice(1, 6));
              
            }
            else if (random <= 60)
            {

                loot["Silver"] += (10 * lootGenerator.Dice(6, 6));
                loot["Gold"] += (10 * lootGenerator.Dice(2, 6));
               
            }
            else if (random <= 70)
            {

                loot["Electrum"] += (10 * lootGenerator.Dice(3, 6));
                loot["Gold"] += (10 * lootGenerator.Dice(2, 6));
               
            }
            else if (random <= 95)
            {

                loot["Gold"] += (10 * lootGenerator.Dice(4, 6));
               
            }
            else
            {

                loot["Gold"] += (10 * lootGenerator.Dice(2, 6));
                loot["Platinum"] += lootGenerator.Dice(3, 6);
                
            }
        }

        List<string> lootList = DictionaryToList(loot);

        money.AddOptions(lootList);
    }
    void IT1116(int num)
    {
        Dictionary<string, int> loot = new Dictionary<string, int>
        {
            {"Copper", 0},
            {"Silver", 0},
            {"Electrum", 0},
            {"Gold", 0},
            {"Platinum", 0}
        };

        for (int i = 1; i <= num; i++)
        {
            int random = UnityEngine.Random.Range(1, 101);

            if (random <= 20)
            {

                loot["Silver"] += (100 * lootGenerator.Dice(4, 6));
                loot["Gold"] += (100 * lootGenerator.Dice(1, 6));
                
            }
            else if (random <= 35)
            {

                loot["Electrum"] += (100 * lootGenerator.Dice(1, 6));
                loot["Gold"] += (100 * lootGenerator.Dice(1, 6));
                
            }
            else if (random <= 75)
            {

                loot["Gold"] += (100 * lootGenerator.Dice(2, 6));
                loot["Platinum"] += (10 * lootGenerator.Dice(1, 6));
                
            }
            else
            {

                loot["Gold"] += (100 * lootGenerator.Dice(2, 6));
                loot["Platinum"] += (10 * lootGenerator.Dice(2, 6));
                
            }
        }

        List<string> lootList = DictionaryToList(loot);

        money.AddOptions(lootList);
    }
    void IT17(int num)
    {
        
        Dictionary<string, int> loot = new Dictionary<string, int>
        {
            {"Electrum", 0},
            {"Gold", 0},
            {"Platinum", 0}
        };

        for (int i = 1; i <= num; i++)
        {
            int random = UnityEngine.Random.Range(1, 101);

            if (random <= 15)
            {

                loot["Electrum"] += (1000 * lootGenerator.Dice(2, 6));
                loot["Gold"] += (100 * lootGenerator.Dice(8, 6));
                
            }
            else if (random <= 55)
            {

                loot["Gold"] += (1000 * lootGenerator.Dice(1, 6));
                loot["Platinum"] += (100 * lootGenerator.Dice(1, 6));
                
            }
            else
            {

                loot["Gold"] += (1000 * lootGenerator.Dice(1, 6));
                loot["Platinum"] += (100 * lootGenerator.Dice(2, 6));
                
            }
        }

        List<string> lootList = DictionaryToList(loot);

        money.AddOptions(lootList);
    }

    List<string> DictionaryToList(Dictionary<string,int> input)
    {
        List<string> loot = new List<string>();
        List<string> value = new List<string>();

        foreach (string key in input.Keys) {
            loot.Add(key);

        }

        foreach(int qty in input.Values){
            value.Add(qty.ToString());
            
        }

        for (int i = 0; i < value.Count; i++)
        {
            loot[i] = loot[i] + " " + value[i];
            
        }

        return loot;
    }
    void ClearLoot() {
        money.ClearOptions();
        gems.ClearOptions();
        art.ClearOptions();
        magicItems.ClearOptions();
        List<string> temp1 = new List<string>();
        temp1.Add("Coins");
        money.AddOptions(temp1);
        temp1.Clear();
        temp1.Add("Gems");
        gems.AddOptions(temp1);
        temp1.Clear();
        temp1.Add("Artistic Pieces");
        art.AddOptions(temp1);
        temp1.Clear();
        temp1.Add("Magical Items");
        magicItems.AddOptions(temp1);
    }
}
