using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootGenerator : MonoBehaviour {

    public string[] Gems10(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 14))
            {
                case 1:
                    loot[i] = "Azurite";
                    break;
                case 2:
                    loot[i] = "Bandaded agate";
                    break;
                case 3:
                    loot[i] = "Blue quartz";
                    break;
                case 4:
                    loot[i] = "Eye agate";
                    break;
                case 5:
                    loot[i] = "Hematite";
                    break;
                case 6:
                    loot[i] = "Lapiz lazuli";
                    break;
                case 7:
                    loot[i] = "Malachite";
                    break;
                case 8:
                    loot[i] = "Moss agate";
                    break;
                case 9:
                    loot[i] = "Obsidian";
                    break;
                case 10:
                    loot[i] = "Rhodochrosite";
                    break;
                case 11:
                    loot[i] = "Tiger eye";
                    break;
                case 12:
                    loot[i] = "Turquoise";
                    break;
            }

            loot[i] += " (10 gp)";
        }

        return loot;
    }
    public string[] Gems50(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 13))
            {
                case 1:
                    loot[i] = "Bloodstone";
                    break;
                case 2:
                    loot[i] = "Carnelian";
                    break;
                case 3:
                    loot[i] = "Chalcedony";
                    break;
                case 4:
                    loot[i] = "Chrysoprase";
                    break;
                case 5:
                    loot[i] = "Citrine";
                    break;
                case 6:
                    loot[i] = "Jasper";
                    break;
                case 7:
                    loot[i] = "Moonstone";
                    break;
                case 8:
                    loot[i] = "Onyx";
                    break;
                case 9:
                    loot[i] = "Onyx";
                    break;
                case 10:
                    loot[i] = "Sardonyx";
                    break;
                case 11:
                    loot[i] = "Star rose quartz";
                    break;
                case 12:
                    loot[i] = "Zircon";
                    break;
            }

            loot[i] += " (50 gp)";
        }

        return loot;
    }
    public string[] Gems100(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 11))
            {
                case 1:
                    loot[i] = "Amber";
                    break;
                case 2:
                    loot[i] = "Amethyst";
                    break;
                case 3:
                    loot[i] = "Chrysoberyl";
                    break;
                case 4:
                    loot[i] = "Coral";
                    break;
                case 5:
                    loot[i] = "Garnet";
                    break;
                case 6:
                    loot[i] = "Jade";
                    break;
                case 7:
                    loot[i] = "Jet";
                    break;
                case 8:
                    loot[i] = "Pearl";
                    break;
                case 9:
                    loot[i] = "Spinel";
                    break;
                case 10:
                    loot[i] = "Tourmaline";
                    break;
            }

            loot[i] += " (100 gp)";
        }

        return loot;
    }
    public string[] Gems500(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 7))
            {
                case 1:
                    loot[i] = "Alexandrite";
                    break;
                case 2:
                    loot[i] = "Aquamarine";
                    break;
                case 3:
                    loot[i] = "Black pearl";
                    break;
                case 4:
                    loot[i] = "Blue spinel";
                    break;
                case 5:
                    loot[i] = "Peridot";
                    break;
                case 6:
                    loot[i] = "Topaz";
                    break;
            }

            loot[i] += " (500 gp)";
        }

        return loot;
    }
    public string[] Gems1000(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 11))
            {
                case 1:
                    loot[i] = "Black opal";
                    break;
                case 2:
                    loot[i] = "Blue sapphire";
                    break;
                case 3:
                    loot[i] = "Emerald";
                    break;
                case 4:
                    loot[i] = "Fire opal";
                    break;
                case 5:
                    loot[i] = "Opal";
                    break;
                case 6:
                    loot[i] = "Star ruby";
                    break;
                case 7:
                    loot[i] = "Star sapphire";
                    break;
                case 8:
                    loot[i] = "Yellow sapphire";
                    break;
                case 9:
                    loot[i] = "Jacinth";
                    break;
                case 10:
                    loot[i] = "1000g Diamond";
                    break;
            }

            loot[i] += " (1000 gp)";
        }

        return loot;
    }
    public string[] Gems5000(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 5))
            {
                case 1:
                    loot[i] = "Black sapphire";
                    break;
                case 2:
                    loot[i] = "5000g Diamond";
                    break;
                case 3:
                    loot[i] = "Jacinth";
                    break;
                case 4:
                    loot[i] = "Ruby";
                    break;
            }


            loot[i] += " (5000 gp)";
        }

        return loot;
    }

    public string[] Art25(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 11))
            {
                case 1:
                    loot[i] = "Silver ewer";
                    break;
                case 2:
                    loot[i] = "Carved bone statuette";
                    break;
                case 3:
                    loot[i] = "Small gold bracelet";
                    break;
                case 4:
                    loot[i] = "Cloth-of-gold vestements";
                    break;
                case 5:
                    loot[i] = "Black velvet mask stitched with silver thread";
                    break;
                case 6:
                    loot[i] = "Copper chalice with silver filigree";
                    break;
                case 7:
                    loot[i] = "Pair of engraved bone dice";
                    break;
                case 8:
                    loot[i] = "Small mirror set in a painted wooden frame";
                    break;
                case 9:
                    loot[i] = "Embroidered silk hankerchief";
                    break;
                case 10:
                    loot[i] = "Gold locket with a painted portrait inside";
                    break;
            }
        }

        return loot;
    }
    public string[] Art250(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 11))
            {
                case 1:
                    loot[i] = "Gold ring set with bloodstones";
                    break;
                case 2:
                    loot[i] = "Carved ivory statuette";
                    break;
                case 3:
                    loot[i] = "Large gold bracelet";
                    break;
                case 4:
                    loot[i] = "Silver necklace with a gemstone pendant";
                    break;
                case 5:
                    loot[i] = "Bronze crown";
                    break;
                case 6:
                    loot[i] = "Silk robe with gold embroidery";
                    break;
                case 7:
                    loot[i] = "Large well-made tapestry";
                    break;
                case 8:
                    loot[i] = "Brass mug with jade inlay";
                    break;
                case 9:
                    loot[i] = "Box of turquoise animal figurines";
                    break;
                case 10:
                    loot[i] = "Gold bird cage with electrum filigree";
                    break;
            }
        }

        return loot;
    }
    public string[] Art750(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 11))
            {
                case 1:
                    loot[i] = "Silver chalice set with moonstones";
                    break;
                case 2:
                    loot[i] = "Silver-plated steel longsword with jet set in hilt";
                    break;
                case 3:
                    loot[i] = "Cared harp of exotic wood with ivory inlay and zircon gems";
                    break;
                case 4:
                    loot[i] = "Small gold idol";
                    break;
                case 5:
                    loot[i] = "Gold dragon comb set with red garnets as eyes";
                    break;
                case 6:
                    loot[i] = "Bottle stopper cork emossed with gold leaf and set with ametheysts";
                    break;
                case 7:
                    loot[i] = "Ceremonial electrum dagger with a black pearl in the pommel";
                    break;
                case 8:
                    loot[i] = "Silver and gold brooch";
                    break;
                case 9:
                    loot[i] = "Obsidian statuette with gold fittings and inlay";
                    break;
                case 10:
                    loot[i] = "Painted gold war mask";
                    break;
            }
        }

        return loot;
    }
    public string[] Art2500(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 11))
            {
                case 1:
                    loot[i] = "Find gold chain set with a fire opal";
                    break;
                case 2:
                    loot[i] = "Old masterpiece painting";
                    break;
                case 3:
                    loot[i] = "Embroidered silk and velvet mantle set with numerous moonstones";
                    break;
                case 4:
                    loot[i] = "Platinum bracelet set with a sapphire";
                    break;
                case 5:
                    loot[i] = "Emroidered glove set with jewel chips";
                    break;
                case 6:
                    loot[i] = "Jeweled anklet";
                    break;
                case 7:
                    loot[i] = "Gold music box";
                    break;
                case 8:
                    loot[i] = "Gold circlet set with four aquamarines";
                    break;
                case 9:
                    loot[i] = "Eye patch with a mock eye set in blue sapphire and moonstone";
                    break;
                case 10:
                    loot[i] = "A necklace string of small pink pearls";
                    break;
            }
        }

        return loot;
    }
    public string[] Art7500(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 9))
            {
                case 1:
                    loot[i] = "Jeweled gold crown";
                    break;
                case 2:
                    loot[i] = "Jeweled platinum ring";
                    break;
                case 3:
                    loot[i] = "Small gold statuette set with rubies";
                    break;
                case 4:
                    loot[i] = "Gold cup set emeralds";
                    break;
                case 5:
                    loot[i] = "Gold jewelry box with platinum filigree";
                    break;
                case 6:
                    loot[i] = "Painted gold child's sarcophagus";
                    break;
                case 7:
                    loot[i] = "Jade game board with solid gold playing pieces";
                    break;
                case 8:
                    loot[i] = "Bejeweled ivory drinking horn with gold filigree";
                    break;
            }
        }

        return loot;
    }

    public Dictionary<string, int> IT04(int num)
    {
        Dictionary<string, int> loot = new Dictionary<string, int>
        {
            {"Copper", 0},
            {"Silver", 0},
            {"Electrum", 0},
            {"Gold", 0},
            {"Platinum", 0}
        };

        for (int i = 0; i < num; i++)
        {
            int random = UnityEngine.Random.Range(1, 101);

            if (random <= 30)
            {
                loot["Copper"] += Dice(5, 6);
            }
            else if (random <= 60)
            {
                loot["Silver"] += Dice(4, 6);
            }
            else if (random <= 70)
            {
                loot["Electrum"] += Dice(3, 6);
            }
            else if (random <= 95)
            {
                loot["Gold"] += Dice(3, 6);
            }
            else
            {
                loot["Electrum"] += Dice(1, 6);
            }
        }

        return loot;
    }
    public Dictionary<string, int> IT510(int num)
    {
        Dictionary<string, int> loot = new Dictionary<string, int>
        {
            {"Copper", 0},
            {"Silver", 0},
            {"Electrum", 0},
            {"Gold", 0},
            {"Platinum", 0}
        };

        for (int i = 0; i < num; i++)
        {
            int random = UnityEngine.Random.Range(1, 101);

            if (random <= 30)
            {

                loot["Copper"] += (100 * Dice(4, 6));
                loot["Electrum"] += (10 * Dice(1, 6));

            }
            else if (random <= 60)
            {

                loot["Silver"] += (10 * Dice(6, 6));
                loot["Gold"] += (10 * Dice(2, 6));

            }
            else if (random <= 70)
            {

                loot["Electrum"] += (10 * Dice(3, 6));
                loot["Gold"] += (10 * Dice(2, 6));

            }
            else if (random <= 95)
            {

                loot["Gold"] += (10 * Dice(4, 6));

            }
            else
            {

                loot["Gold"] += (10 * Dice(2, 6));
                loot["Platinum"] += Dice(3, 6);

            }
        }

        return loot;
    }
    public Dictionary<string, int> IT1116(int num)
    {
        Dictionary<string, int> loot = new Dictionary<string, int>
        {
            {"Copper", 0},
            {"Silver", 0},
            {"Electrum", 0},
            {"Gold", 0},
            {"Platinum", 0}
        };

        for (int i = 0; i < num; i++)
        {
            int random = UnityEngine.Random.Range(1, 101);

            if (random <= 20)
            {

                loot["Silver"] += (100 * Dice(4, 6));
                loot["Gold"] += (100 * Dice(1, 6));

            }
            else if (random <= 35)
            {

                loot["Electrum"] += (100 * Dice(1, 6));
                loot["Gold"] += (100 * Dice(1, 6));

            }
            else if (random <= 75)
            {

                loot["Gold"] += (100 * Dice(2, 6));
                loot["Platinum"] += (10 * Dice(1, 6));

            }
            else
            {

                loot["Gold"] += (100 * Dice(2, 6));
                loot["Platinum"] += (10 * Dice(2, 6));

            }
        }

        return loot;
    }
    public Dictionary<string, int> IT17(int num)
    {
        Dictionary<string, int> loot = new Dictionary<string, int>
        {
            {"Electrum", 0},
            {"Gold", 0},
            {"Platinum", 0}
        };

        for (int i = 0; i < num; i++)
        {
            int random = UnityEngine.Random.Range(1, 101);

            if (random <= 15)
            {

                loot["Electrum"] += (1000 * Dice(2, 6));
                loot["Gold"] += (100 * Dice(8, 6));

            }
            else if (random <= 55)
            {

                loot["Gold"] += (1000 * Dice(1, 6));
                loot["Platinum"] += (100 * Dice(1, 6));

            }
            else
            {

                loot["Gold"] += (1000 * Dice(1, 6));
                loot["Platinum"] += (100 * Dice(2, 6));

            }
        }

        return loot;
    }

    public string[] MITA(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 101))
            {
                #region Cases 1-50
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
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
                case 37:
                case 38:
                case 39:
                case 40:
                case 41:
                case 42:
                case 43:
                case 44:
                case 45:
                case 46:
                case 47:
                case 48:
                case 49:
                case 50:
                    #endregion
                    Debug.Log("Potion of healing");
                    loot[i] = "Potion of Healing";
                    break;
                #region Cases 51-60
                case 51:
                case 52:
                case 53:
                case 54:
                case 55:
                case 56:
                case 57:
                case 58:
                case 59:
                case 60:
                    #endregion
                    Debug.Log("cantrip scroll");
                    loot[i] = "Spell scroll of " + ScrollCan();
                    break;
                #region Cases 61-70
                case 61:
                case 62:
                case 63:
                case 64:
                case 65:
                case 66:
                case 67:
                case 68:
                case 69:
                case 70:
                    #endregion
                    Debug.Log("potion of climbing");
                    loot[i] = "Potion of Climbing";
                    break;
                #region Cases 71-90
                case 71:
                case 72:
                case 73:
                case 74:
                case 75:
                case 76:
                case 77:
                case 78:
                case 79:
                case 80:
                case 81:
                case 82:
                case 83:
                case 84:
                case 85:
                case 86:
                case 87:
                case 88:
                case 89:
                case 90:
                    #endregion
                    Debug.Log("level 1 spell scroll");
                    loot[i] = "Spell scroll of " + Scroll1();
                    break;
                #region Cases 91-94
                case 91:
                case 92:
                case 93:
                case 94:
                    #endregion
                    Debug.Log("level 2 spell scroll");
                    loot[i] = "Spell scroll of " + Scroll2();
                    break;
                #region Cases 95-98
                case 95:
                case 96:
                case 97:
                case 98:
                    #endregion
                    Debug.Log("greater healing potion");
                    loot[i] = "Potion of Greater Healing";
                    break;
                case 99:
                    Debug.Log("bag of holding");
                    loot[i] = "Bag of Holding";
                    break;
                case 100:
                    Debug.Log("driftglobe");
                    loot[i] = "Driftglobe";
                    break;
            }
        }

        return loot;
    }
    public string[] MITB(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 101))
            {
                #region Cases 1-15
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    #endregion
                    loot[i] = "Potion of Greater Healing";
                    break;
                #region Cases 16-22
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                    #endregion
                    loot[i] = "Potion of Fire Breath";
                    break;
                #region Cases 23-29
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                    #endregion
                    loot[i] = "Potion of " + Elemental() + " Resistance";
                    break;
                #region Cases 30-34
                case 30:
                case 31:
                case 32:
                case 33:
                case 34:
                    #endregion
                    loot[i] = Ammunition() + ", +1";
                    break;
                #region Cases 35-39
                case 35:
                case 36:
                case 37:
                case 38:
                case 39:
                    #endregion
                    loot[i] = "Potion of Animal Friendship";
                    break;
                #region Cases 40-44
                case 40:
                case 41:
                case 42:
                case 43:
                case 44:
                    #endregion
                    loot[i] = "Potion of Hill Giant Strength";
                    break;
                #region Cases 45-49
                case 45:
                case 46:
                case 47:
                case 48:
                case 49:
                    #endregion
                    loot[i] = "Potion of Growth";
                    break;
                #region Cases 50-54
                case 50:
                case 51:
                case 52:
                case 53:
                case 54:
                    #endregion
                    loot[i] = "Potion of Water Breathing";
                    break;
                #region Cases 55-59
                case 55:
                case 56:
                case 57:
                case 58:
                case 59:
                    #endregion
                    loot[i] = "Spell scroll of " + Scroll2();
                    break;
                #region Cases 60-64
                case 60:
                case 61:
                case 62:
                case 63:
                case 64:
                    #endregion
                    loot[i] = "Spell scroll of " + Scroll3();
                    break;
                #region Cases 65-67
                case 65:
                case 66:
                case 67:
                    #endregion
                    loot[i] = "Bag of Holding";
                    break;
                #region Cases 68-70
                case 68:
                case 69:
                case 70:
                    #endregion
                    loot[i] = "Keoghtom's Ointment";
                    break;
                #region Cases 71-73
                case 71:
                case 72:
                case 73:
                    #endregion
                    loot[i] = "Oil of Slipperiness";
                    break;
                #region Cases 74-75
                case 74:
                case 75:
                    #endregion
                    loot[i] = "Dust of Disappearance";
                    break;
                #region Cases 76-77
                case 76:
                case 77:
                    #endregion
                    loot[i] = "Dust of Dryness";
                    break;
                #region Cases 78-79
                case 78:
                case 79:
                    #endregion
                    loot[i] = "Dust of Sneezing and Choking";
                    break;
                #region Cases 80-81
                case 80:
                case 81:
                    #endregion
                    switch (UnityEngine.Random.Range(1, 5))
                    {
                        case 1:
                            loot[i] = "Blue Sapphire Elemental Gem";
                            break;
                        case 2:
                            loot[i] = "Yellow Diamond Elemental Gem";
                            break;
                        case 3:
                            loot[i] = "Red Corundum Elemental Gem";
                            break;
                        case 4:
                            loot[i] = "Emerald Elemental Gem";
                            break;
                    }
                    break;
                #region Cases 82-83
                case 82:
                case 83:
                    #endregion
                    loot[i] = "Philter of Love";
                    break;
                case 84:
                    loot[i] = "Alchemy Jug";
                    break;
                case 85:
                    loot[i] = "Cap of Waterbreathing";
                    break;
                case 86:
                    loot[i] = "Cloak of the Manta Ray";
                    break;
                case 87:
                    loot[i] = "Driftglobe";
                    break;
                case 88:
                    loot[i] = "Goggles of Night";
                    break;
                case 89:
                    loot[i] = "Helm of Comprehending Languages";
                    break;
                case 90:
                    loot[i] = "Immoveable Rod";
                    break;
                case 91:
                    loot[i] = "Lantern of Revealing";
                    break;
                case 92:
                    loot[i] = "Mariner's Armor";
                    break;
                case 93:
                    loot[i] = "Mithral Armor";
                    break;
                case 94:
                    loot[i] = "Potion of Poison";
                    break;
                case 95:
                    loot[i] = "Ring of Swimming";
                    break;
                case 96:
                    loot[i] = "Robe of Useful Items";
                    break;
                case 97:
                    loot[i] = "Rope of Climbing";
                    break;
                case 98:
                    loot[i] = "Saddle of the Cavalier";
                    break;
                case 99:
                    loot[i] = "Wand of Magic Detection";
                    break;
                case 100:
                    loot[i] = "Wand of Secrets";
                    break;
            }
        }

        return loot;
    }
    public string[] MITC(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 101))
            {
                #region Cases 1-15
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    #endregion
                    loot[i] = "Potion of Superior Healing";
                    break;
                #region Cases 16-22
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                    #endregion
                    loot[i] = "Spell scroll of " + Scroll4();
                    break;
                #region Cases 23-27
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                    #endregion
                    loot[i] = Ammunition() + ", +2";
                    break;
                #region Cases 28-32
                case 28:
                case 29:
                case 30:
                case 31:
                case 32:
                    #endregion
                    loot[i] = "Potion of Clairvoyance";
                    break;
                #region Cases 33-37
                case 33:
                case 34:
                case 35:
                case 36:
                case 37:
                    #endregion
                    loot[i] = "Potion of Diminution";
                    break;
                #region Cases 38-42
                case 38:
                case 39:
                case 40:
                case 41:
                case 42:
                    #endregion
                    loot[i] = "Potion of Gaseous Form";
                    break;
                #region Cases 43-47
                case 43:
                case 44:
                case 45:
                case 46:
                case 47:
                    #endregion
                    loot[i] = "Potion of Frost Giant Strength";
                    break;
                #region Caess 48-52
                case 48:
                case 49:
                case 50:
                case 51:
                case 52:
                    #endregion
                    loot[i] = "Potion of Stone Giant Strength";
                    break;
                #region Cases 53-57
                case 53:
                case 54:
                case 55:
                case 56:
                case 57:
                    #endregion
                    loot[i] = "Potion of Heroism";
                    break;
                #region Cases 58-62
                case 58:
                case 59:
                case 60:
                case 61:
                case 62:
                    #endregion
                    loot[i] = "Potion of Invulnerabilty"; ;
                    break;
                #region Cases 63-67
                case 63:
                case 64:
                case 65:
                case 66:
                case 67:
                    #endregion
                    loot[i] = "Potion of Mind Reading";
                    break;
                #region Cases 68-72
                case 68:
                case 69:
                case 70:
                case 71:
                case 72:
                    #endregion
                    loot[i] = "Spell scroll of " + Scroll5();
                    break;
                #region Cases 73-75
                case 73:
                case 74:
                case 75:
                    #endregion
                    loot[i] = "Elixir of Health";
                    break;
                #region Cases 76-78
                case 76:
                case 77:
                case 78:
                    #endregion
                    loot[i] = "Oil of Etherealness ";
                    break;
                #region Cases 79-81
                case 79:
                case 80:
                case 81:
                    #endregion
                    loot[i] = "Potion of Fire Giant Strength";
                    break;
                #region Cases 82-84
                case 82:
                case 83:
                case 84:
                    #endregion
                    switch (UnityEngine.Random.Range(1, 21))
                    {
                        #region Cases 1-4
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                            #endregion
                            loot[i] = "Quaal's Feather Token: Anchor";
                            break;
                        #region Cases 5-7
                        case 5:
                        case 6:
                        case 7:
                            #endregion
                            loot[i] = "Quaal's Feather Token: Bird";
                            break;
                        #region Cases 8-10
                        case 8:
                        case 9:
                        case 10:
                            #endregion
                            loot[i] = "Quaal's Feather Token: Fan";
                            break;
                        #region Cases 11-13
                        case 11:
                        case 12:
                        case 13:
                            #endregion
                            loot[i] = "Quaal's Feather Token: Swan Boat";
                            break;
                        #region Cases 14-18
                        case 14:
                        case 15:
                        case 16:
                        case 17:
                        case 18:
                            #endregion
                            loot[i] = "Quaal's Feather Token: Tree";
                            break;
                        #region cases 19-20
                        case 19:
                        case 20:
                            #endregion
                            loot[i] = "Quaal's Feather Token: Whip";
                            break;
                    }
                    break;
                #region Cases 85-87
                case 85:
                case 86:
                case 87:
                    #endregion
                    loot[i] = "Scroll of " + Elemental() + " Protection";
                    break;
                #region Cases 88-89
                case 88:
                case 89:
                    #endregion
                    loot[i] = "Bag of Beans";
                    break;
                #region Cases 90-91
                case 90:
                case 91:
                    #endregion
                    loot[i] = "Bead of Force";
                    break;
                case 92:
                    loot[i] = "Chime of Opening";
                    break;
                case 93:
                    loot[i] = "Decanter of Endless Water";
                    break;
                case 94:
                    loot[i] = "Eyes of Minute Seeing";
                    break;
                case 95:
                    loot[i] = "Folding Boat";
                    break;
                case 96:
                    loot[i] = "Hewards Handy Haversack";
                    break;
                case 97:
                    loot[i] = "Horseshoes of Speed";
                    break;
                case 98:
                    loot[i] = "Necklace of Fireballs";
                    break;
                case 99:
                    loot[i] = "Periapt of Health";
                    break;
                case 100:
                    loot[i] = "Sending Stones";
                    break;
            }
        }

        return loot;
    }
    public string[] MITD(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 101))
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
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
                case 17:
                case 18:
                case 19:
                case 20:
                    loot[i] = "Potion of Supreme Healing";
                    break;
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                    loot[i] = "Potion of Invisibility";
                    break;
                case 31:
                case 32:
                case 33:
                case 34:
                case 35:
                case 36:
                case 37:
                case 38:
                case 39:
                case 40:
                    loot[i] = "Potion of Speed";
                    break;
                case 41:
                case 42:
                case 43:
                case 44:
                case 45:
                case 46:
                case 47:
                case 48:
                case 49:
                case 50:
                    loot[i] = "Spell scroll of " + Scroll6();
                    break;
                case 51:
                case 52:
                case 53:
                case 54:
                case 55:
                case 56:
                case 57:
                    loot[i] = "Spell scroll of " + Scroll7();
                    break;
                case 58:
                case 59:
                case 60:
                case 61:
                case 62:
                    loot[i] = Ammunition() + ", +3";
                    break;
                case 63:
                case 64:
                case 65:
                case 66:
                case 67:
                    loot[i] = "Oil of Sharpness";
                    break;
                case 68:
                case 69:
                case 70:
                case 71:
                case 72:
                    loot[i] = "Potion of Flying";
                    break;
                case 73:
                case 74:
                case 75:
                case 76:
                case 77:
                    loot[i] = "Potion of Cloud Giant Strength";
                    break;
                case 78:
                case 79:
                case 80:
                case 81:
                case 82:
                    loot[i] = "Potion of Longevity";
                    break;
                case 83:
                case 84:
                case 85:
                case 86:
                case 87:
                    loot[i] = "Potion of Vitality";
                    break;
                case 88:
                case 89:
                case 90:
                case 91:
                case 92:
                    loot[i] = "Spell scroll of " + Scroll8();
                    break;
                case 93:
                case 94:
                case 95:
                    loot[i] = "Horseshoes of a Zephyr";
                    break;
                case 96:
                case 97:
                case 98:
                    loot[i] = "Nolzur's Marvelous Pigments";
                    break;
                case 99:
                    loot[i] = "Bag of Devouring";
                    break;
                case 100:
                    loot[i] = "Portable Hole";
                    break;
            }
        }

        return loot;
    }
    public string[] MITE(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 101))
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
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
                case 27:
                case 28:
                case 29:
                case 30:
                    loot[i] = "Spell scroll of " + Scroll8();
                    break;
                case 31:
                case 32:
                case 33:
                case 34:
                case 35:
                case 36:
                case 37:
                case 38:
                case 39:
                case 40:
                case 41:
                case 42:
                case 43:
                case 44:
                case 45:
                case 46:
                case 47:
                case 48:
                case 49:
                case 50:
                case 51:
                case 52:
                case 53:
                case 54:
                case 55:
                    loot[i] = "Potion of Storm Giant Strength";
                    break;
                case 56:
                case 57:
                case 58:
                case 59:
                case 60:
                case 61:
                case 62:
                case 63:
                case 64:
                case 65:
                case 66:
                case 67:
                case 68:
                case 69:
                case 70:
                    loot[i] = "Potion of Supreme Healing";
                    break;
                case 71:
                case 72:
                case 73:
                case 74:
                case 75:
                case 76:
                case 77:
                case 78:
                case 79:
                case 80:
                case 81:
                case 82:
                case 83:
                case 84:
                case 85:
                    loot[i] = "Spell scroll of " + Scroll9();
                    break;
                case 86:
                case 87:
                case 88:
                case 89:
                case 90:
                case 91:
                case 92:
                case 93:
                    loot[i] = "Universal Solvent";
                    break;
                case 94:
                case 95:
                case 96:
                case 97:
                case 98:
                    loot[i] = "Arrow of " + CreatureType() + " Slaying";
                    break;
                case 99:
                case 100:
                    loot[i] = "Sovereign Glue";
                    break;
            }
        }

        return loot;
    }
    public string[] MITF(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 101))
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    loot[i] = Weapon() + ", +1";
                    break;
                case 16:
                case 17:
                case 18:
                    loot[i] = "Shield, +1";
                    break;
                case 19:
                case 20:
                case 21:
                    loot[i] = "Sentinel Shield";
                    break;
                case 22:
                case 23:
                    loot[i] = "Amulet of Proof Against Detection and Location";
                    break;
                case 24:
                case 25:
                    loot[i] = "Boots of Elevenkind";
                    break;
                case 26:
                case 27:
                    loot[i] = "Boots of Striding and Springing";
                    break;
                case 28:
                case 29:
                    loot[i] = "Bracers of Archery";
                    break;
                case 30:
                case 31:
                    loot[i] = "Brooch of Shielding";
                    break;
                case 32:
                case 33:
                    loot[i] = "Broom of Flying";
                    break;
                case 34:
                case 35:
                    loot[i] = "Cloak of Elvenkind";
                    break;
                case 36:
                case 37:
                    loot[i] = "Cloak of Protection";
                    break;
                case 38:
                case 39:
                    loot[i] = "Gauntlets of Ogre Power";
                    break;
                case 40:
                case 41:
                    loot[i] = "Hat of Disguise";
                    break;
                case 42:
                case 43:
                    loot[i] = "Javelin of Lightning";
                    break;
                case 44:
                case 45:
                    loot[i] = "Pearl of Power";
                    break;
                case 46:
                case 47:
                    loot[i] = "Rod of the Pact Keeper, +1";
                    break;
                case 48:
                case 49:
                    loot[i] = "Slippers of Spider Climbing";
                    break;
                case 50:
                case 51:
                    loot[i] = "Staff of the Adder";
                    break;
                case 52:
                case 53:
                    loot[i] = "Staff of the Python";
                    break;
                case 54:
                case 55:
                    loot[i] = "Sword of Vengeance";
                    break;
                case 56:
                case 57:
                    loot[i] = "Trident of Fish Command";
                    break;
                case 58:
                case 59:
                    loot[i] = "Wand of Magic Missiles";
                    break;
                case 60:
                case 61:
                    loot[i] = "Wand of the War Mage, +1";
                    break;
                case 62:
                case 63:
                    loot[i] = "Wand of Web";
                    break;
                case 64:
                case 65:
                    loot[i] = Weapon() + " of Warning";
                    break;
                case 66:
                    loot[i] = "Adamantine Chain Mail";
                    break;
                case 67:
                    loot[i] = "Adamantine Chain Shirt";
                    break;
                case 68:
                    loot[i] = "Adamantine Scale Mail";
                    break;
                case 69:
                    loot[i] = "Gray Bag of Tricks";
                    break;
                case 70:
                    loot[i] = "Rust Bag of Tricks";
                    break;
                case 71:
                    loot[i] = "Tan Bag of Tricks";
                    break;
                case 72:
                    loot[i] = "Boots of the Winterlands";
                    break;
                case 73:
                    loot[i] = "Circlet of Blasting";
                    break;
                case 74:
                    loot[i] = "Deck of Illusions";
                    break;
                case 75:
                    loot[i] = "Eversmoking Bottle";
                    break;
                case 76:
                    loot[i] = "Eyes of Charming";
                    break;
                case 77:
                    loot[i] = "Eyes of the Eagle";
                    break;
                case 78:
                    loot[i] = "Figurine of Wonderous Power: Silver Raven";
                    break;
                case 79:
                    loot[i] = "Gem of Brightness";
                    break;
                case 80:
                    loot[i] = "Gloves of Missile Snaring";
                    break;
                case 81:
                    loot[i] = "Gloves of Swimming and Climbing";
                    break;
                case 82:
                    loot[i] = "Gloves of Thievery";
                    break;
                case 83:
                    loot[i] = "Headband of Intellect";
                    break;
                case 84:
                    loot[i] = "Helm of Telepathy";
                    break;
                case 85:
                    loot[i] = "Instrument of the Bards: Doss Lute";
                    break;
                case 86:
                    loot[i] = "Instrument of the Bards: Fochulan Bandore";
                    break;
                case 87:
                    loot[i] = "Instrument of the Bards: Mac-Fuimidh Cittern";
                    break;
                case 88:
                    loot[i] = "Medallion of Thoughts";
                    break;
                case 89:
                    loot[i] = "Necklace of Adaptation";
                    break;
                case 90:
                    loot[i] = "Periapt of Wound Closure";
                    break;
                case 91:
                    loot[i] = "Pipes of Haunting";
                    break;
                case 92:
                    loot[i] = "Pipes of the Sewers";
                    break;
                case 93:
                    loot[i] = "Ring of Jumping";
                    break;
                case 94:
                    loot[i] = "Ring of Mind Shielding";
                    break;
                case 95:
                    loot[i] = "Ring of Warmth";
                    break;
                case 96:
                    loot[i] = "Ring of Water Walking";
                    break;
                case 97:
                    loot[i] = "Quiver of Ehlonna";
                    break;
                case 98:
                    loot[i] = "Stone of Good Luck";
                    break;
                case 99:
                    loot[i] = "Wind Fan";
                    break;
                case 100:
                    loot[i] = "Winged Boots";
                    break;
            }
        }

        return loot;
    }
    public string[] MITG(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 101))
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    loot[i] = Weapon() + ", +2";
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                    loot[i] = "Figurine of Wonderous Power: ";
                    switch (UnityEngine.Random.Range(1, 9))
                    {
                        case 1:
                            loot[i] += "Bronze Griffon";
                            break;
                        case 2:
                            loot[i] += "Ebony Fly";
                            break;
                        case 3:
                            loot[i] += "Golden Lions";
                            break;
                        case 4:
                            loot[i] += "Ivory Goats";
                            break;
                        case 5:
                            loot[i] += "Marble Elephant";
                            break;
                        case 6:
                        case 7:
                            loot[i] += "Onyx Dog";
                            break;
                        case 8:
                            loot[i] += "Serpentine Owl";
                            break;
                    }
                    break;
                case 15:
                    loot[i] = "Adamantine Breastplate";
                    break;
                case 16:
                    loot[i] = "Adamantine Splint Armor";
                    break;
                case 17:
                    loot[i] = "Amulet of Health";
                    break;
                case 18:
                    loot[i] = "Armor of Vulnerability: ";
                    switch (UnityEngine.Random.Range(1, 4))
                    {
                        case 1:
                            loot[i] += "Bludgeoning";
                            break;
                        case 2:
                            loot[i] += "Piercing";
                            break;
                        case 3:
                            loot[i] += "Slashing";
                            break;
                    }
                    break;
                case 19:
                    loot[i] = "Arrow-Catching Shield";
                    break;
                case 20:
                    loot[i] = "Belt of Dwarvenkind";
                    break;
                case 21:
                    loot[i] = "Belt of Hill Giant Strength";
                    break;
                case 22:
                    loot[i] = "Berserker Axe";
                    break;
                case 23:
                    loot[i] = "Boots of Levitation";
                    break;
                case 24:
                    loot[i] = "Boots of Speed";
                    break;
                case 25:
                    loot[i] = "Bowl of Commanding Water Elementals";
                    break;
                case 26:
                    loot[i] = "Bracers of Defense";
                    break;
                case 27:
                    loot[i] = "Brazier of Commanding Fire Elementals";
                    break;
                case 28:
                    loot[i] = "Cape of the Mountebank";
                    break;
                case 29:
                    loot[i] = "Censer of Controlling Air Elementals";
                    break;
                case 30:
                    loot[i] = "Chain Mail, +1";
                    break;
                case 31:
                    loot[i] = "Chain Mail of " + Elemental() + " Resistance";
                    break;
                case 32:
                    loot[i] = "Chain Shirt, +1";
                    break;
                case 33:
                    loot[i] = "Chain Shirt of " + Elemental() + " Resistance";
                    break;
                case 34:
                    loot[i] = "Cloak of Displacement";
                    break;
                case 35:
                    loot[i] = "Cloak of the Bat";
                    break;
                case 36:
                    loot[i] = "Cube of Force";
                    break;
                case 37:
                    loot[i] = "Daern's Instant Fortress";
                    break;
                case 38:
                    loot[i] = "Dagger of Venom";
                    break;
                case 39:
                    loot[i] = "Dimensional Shackles";
                    break;
                case 40:
                    loot[i] = "Dragon Slayer " + Blade();
                    break;
                case 41:
                    loot[i] = "Elven Chain";
                    break;
                case 42:
                    loot[i] = "Flame Tongue " + Blade();
                    break;
                case 43:
                    loot[i] = "Gem of Seeing";
                    break;
                case 44:
                    loot[i] = "Giant Slayer " + Weapon();
                    break;
                case 45:
                    loot[i] = "Glamoured Studded Leather";
                    break;
                case 46:
                    loot[i] = "Helm of Teleportation";
                    break;
                case 47:
                    loot[i] = "Horn of Blasting";
                    break;
                case 48:
                    switch (UnityEngine.Random.Range(1, 3))
                    {
                        case 1:
                            loot[i] = "Silver Horn of Valhalla";
                            break;
                        case 2:
                            loot[i] = "Brass Horn of Valhalla";
                            break;
                    }
                    break;
                case 49:
                    loot[i] = "Instrument of the Bards: Canaith Mandolin";
                    break;
                case 50:
                    loot[i] = "Instrument of the Bards: Cli Lyre";
                    break;
                case 51:
                    loot[i] = "Ioun Stone of Awareness";
                    break;
                case 52:
                    loot[i] = "Ioun Stone of Protection";
                    break;
                case 53:
                    loot[i] = "Ioun Stone of Reserve";
                    break;
                case 54:
                    loot[i] = "Ioun Stone of Sustenance";
                    break;
                case 55:
                    loot[i] = "Iron Bands of Bilarro";
                    break;
                case 56:
                    loot[i] = "Leather Armor, +1";
                    break;
                case 57:
                    loot[i] = "Leather Armor of " + Elemental() + " Resistance";
                    break;
                case 58:
                    loot[i] = "Mace of Disruption";
                    break;
                case 59:
                    loot[i] = "Mace of Smiting";
                    break;
                case 60:
                    loot[i] = "Mace of Terror";
                    break;
                case 61:
                    loot[i] = "Mantle of Spell Resistance";
                    break;
                case 62:
                    loot[i] = "Necklace of Prayer Beads";
                    break;
                case 63:
                    loot[i] = "Periapt of Proof Against Poison";
                    break;
                case 64:
                    loot[i] = "Ring of Animal Influence";
                    break;
                case 65:
                    loot[i] = "Ring of Evasion";
                    break;
                case 66:
                    loot[i] = "Ring of Feather Falling";
                    break;
                case 67:
                    loot[i] = "Ring of Free Action";
                    break;
                case 68:
                    loot[i] = "Ring of Protection";
                    break;
                case 69:
                    loot[i] = "Ring of " + Elemental() + " Resistance";
                    break;
                case 70:
                    loot[i] = "Ring of Spell Storing";
                    break;
                case 71:
                    loot[i] = "Ring of the Ram";
                    break;
                case 72:
                    loot[i] = "Ring of X-Ray Vision";
                    break;
                case 73:
                    loot[i] = "Robe of Eyes";
                    break;
                case 74:
                    loot[i] = "Rod of Rulership";
                    break;
                case 75:
                    loot[i] = "Rod of the Pact Keeper, +2";
                    break;
                case 76:
                    loot[i] = "Rope of Entanglement";
                    break;
                case 77:
                    loot[i] = "Scale Mail, +1";
                    break;
                case 78:
                    loot[i] = "Scale Mail of " + Elemental() + " Resistance";
                    break;
                case 79:
                    loot[i] = "Shield, +2";
                    break;
                case 80:
                    loot[i] = "Shield of Missile Attraction";
                    break;
                case 81:
                    loot[i] = "Staff of Charming";
                    break;
                case 82:
                    loot[i] = "Staff of Healing";
                    break;
                case 83:
                    loot[i] = "Staff of Swarming Insects";
                    break;
                case 84:
                    loot[i] = "Staff of the Woodlands";
                    break;
                case 85:
                    loot[i] = "Staff of Withering";
                    break;
                case 86:
                    loot[i] = "Stone of Controlling Earth Elementals";
                    break;
                case 87:
                    loot[i] = "Sun Blade";
                    break;
                case 88:
                    loot[i] = Blade() + " of Lifestealing";
                    break;
                case 89:
                    loot[i] = Blade() + " of Wounding";
                    break;
                case 90:
                    loot[i] = "Tentacle Rod";
                    break;
                case 91:
                    loot[i] = "Vicious " + Weapon();
                    break;
                case 92:
                    loot[i] = "Wand of Binding";
                    break;
                case 93:
                    loot[i] = "Wand of Enemy Detection";
                    break;
                case 94:
                    loot[i] = "Wand of Fear";
                    break;
                case 95:
                    loot[i] = "Wand of Fireballs";
                    break;
                case 96:
                    loot[i] = "Wand of Lightning Bolts";
                    break;
                case 97:
                    loot[i] = "Wand of Paralysis";
                    break;
                case 98:
                    loot[i] = "Wand of the War Mage, +2";
                    break;
                case 99:
                    loot[i] = "Wand of Wonder";
                    break;
                case 100:
                    loot[i] = "Wings of Flying";
                    break;
            }
        }

        return loot;
    }
    public string[] MITH(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 101))
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    loot[i] = Weapon() + ", +3";
                    break;
                case 11:
                case 12:
                    loot[i] = "Amulet of the Planes";
                    break;
                case 13:
                case 14:
                    loot[i] = "Carpet of Flying";
                    break;
                case 15:
                case 16:
                    loot[i] = "Crystal Ball (Very Rare)";
                    break;
                case 17:
                case 18:
                    loot[i] = "Ring of Regeneration";
                    break;
                case 19:
                case 20:
                    loot[i] = "Ring of Shooting Stars";
                    break;
                case 21:
                case 22:
                    loot[i] = "Ring of Telekinesis";
                    break;
                case 23:
                case 24:
                    loot[i] = "Robe of Scintillating colors";
                    break;
                case 25:
                case 26:
                    loot[i] = "Robe of Stars";
                    break;
                case 27:
                case 28:
                    loot[i] = "Rod of Absorbtion";
                    break;
                case 29:
                case 30:
                    loot[i] = "Rod of Alertness";
                    break;
                case 31:
                case 32:
                    loot[i] = "Rod of Security";
                    break;
                case 33:
                case 34:
                    loot[i] = "Rod of the Pact Keeper, +3";
                    break;
                case 35:
                case 36:
                    loot[i] = "Scimitar of Speed";
                    break;
                case 37:
                case 38:
                    loot[i] = "Shield, +3";
                    break;
                case 39:
                case 40:
                    loot[i] = "Staff of Fire";
                    break;
                case 41:
                case 42:
                    loot[i] = "Staff of Frost";
                    break;
                case 43:
                case 44:
                    loot[i] = "Staff of Power";
                    break;
                case 45:
                case 46:
                    loot[i] = "Staff of Striking";
                    break;
                case 47:
                case 48:
                    loot[i] = "Staff of Thunder and Lightning";
                    break;
                case 49:
                case 50:
                    loot[i] = Blade() + " of Sharpness";
                    break;
                case 51:
                case 52:
                    loot[i] = "Wand of Polymorph";
                    break;
                case 53:
                case 54:
                    loot[i] = "Wand of the War Mage, +3";
                    break;
                case 55:
                    loot[i] = "Adamantine Half Plate Armor";
                    break;
                case 56:
                    loot[i] = "Adamantine Plate Armor";
                    break;
                case 57:
                    loot[i] = "Animated Shield";
                    break;
                case 58:
                    loot[i] = "Belt of Fire Giant Strength";
                    break;
                case 59:
                    switch (UnityEngine.Random.Range(1, 3))
                    {
                        case 1:
                            loot[i] = "Belt of Frost Giant Strength";
                            break;
                        case 2:
                            loot[i] = "Belt of Stone Giant Strength";
                            break;
                    }
                    break;
                case 60:
                    loot[i] = "Breastplate, +1";
                    break;
                case 61:
                    loot[i] = "Breastplate of " + Elemental() + " Resistance";
                    break;
                case 62:
                    loot[i] = "Candle of Invocation";
                    break;
                case 63:
                    loot[i] = "Chain Mail, +2";
                    break;
                case 64:
                    loot[i] = "Chain Shirt, +2";
                    break;
                case 65:
                    loot[i] = "Cloak of Arachnida";
                    break;
                case 66:
                    loot[i] = "Dancing " + Blade();
                    break;
                case 67:
                    loot[i] = "Demon Armor";
                    break;
                case 68:
                    switch (UnityEngine.Random.Range(1, 11))
                    {
                        case 1:
                            loot[i] = "Black";
                            break;
                        case 2:
                            loot[i] = "Blue";
                            break;
                        case 3:
                            loot[i] = "Brass";
                            break;
                        case 4:
                            loot[i] = "Bronze";
                            break;
                        case 5:
                            loot[i] = "Copper";
                            break;
                        case 6:
                            loot[i] = "Gold";
                            break;
                        case 7:
                            loot[i] = "Green";
                            break;
                        case 8:
                            loot[i] = "Red";
                            break;
                        case 9:
                            loot[i] = "Silver";
                            break;
                        case 10:
                            loot[i] = "White";
                            break;
                    }
                    loot[i] += " Dragon Scale Mail";
                    break;
                case 69:
                    loot[i] = "Dwarven Plate";
                    break;
                case 70:
                    loot[i] = "Dwarven Thrower";
                    break;
                case 71:
                    loot[i] = "Efreeti Bottle";
                    break;
                case 72:
                    loot[i] = "Figurine of Wonderous Power: Obsidian Steed";
                    break;
                case 73:
                    loot[i] = "Frost Brand " + Weapon();
                    break;
                case 74:
                    loot[i] = "Helm of Brilliance";
                    break;
                case 75:
                    loot[i] = "Bronze Horn of Valhalla";
                    break;
                case 76:
                    loot[i] = "Instrument of the Bards: Anstruth Harp";
                    break;
                case 77:
                    loot[i] = "Ioun Stone of Absorbtion";
                    break;
                case 78:
                    loot[i] = "Ioun Stone of Agility";
                    break;
                case 79:
                    loot[i] = "Ioun Stone of Fortitude";
                    break;
                case 80:
                    loot[i] = "Ioun Stone of Insight";
                    break;
                case 81:
                    loot[i] = "Ioun Stone of Intellect";
                    break;
                case 82:
                    loot[i] = "Ioun Stone of Leadership";
                    break;
                case 83:
                    loot[i] = "Ioun Stone of Strength";
                    break;
                case 84:
                    loot[i] = "Leather Armor, +2";
                    break;
                case 85:
                    loot[i] = "Manual of Bodily Health";
                    break;
                case 86:
                    loot[i] = "Manual of Gainful Exercise";
                    break;
                case 87:
                    loot[i] = "Manual of Golems";
                    break;
                case 88:
                    loot[i] = "Manual of Quickness of Action";
                    break;
                case 89:
                    loot[i] = "Mirror of Life Trapping";
                    break;
                case 90:
                    loot[i] = "Nine Lives Stealer";
                    break;
                case 91:
                    loot[i] = "Oathbow";
                    break;
                case 92:
                    loot[i] = "Scale Mail, +2";
                    break;
                case 93:
                    loot[i] = "Spellguard Shield";
                    break;
                case 94:
                    loot[i] = "Splint Armor, +1";
                    break;
                case 95:
                    loot[i] = "Splint Armor of " + Elemental() + " Resistance";
                    break;
                case 96:
                    loot[i] = "Studded Leather Armor, +1";
                    break;
                case 97:
                    loot[i] = "Studded Leather Armor of " + Elemental() + " Resistance";
                    break;
                case 98:
                    loot[i] = "Tome of Clear Thought";
                    break;
                case 99:
                    loot[i] = "Tome of Leadership and Influence";
                    break;
                case 100:
                    loot[i] = "Tome of Understanding";
                    break;
            }
        }

        return loot;
    }
    public string[] MITI(int num)
    {
        string[] loot = new string[num];

        for (int i = 0; i < num; i++)
        {
            switch (UnityEngine.Random.Range(1, 101))
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    loot[i] = "Defender " + Blade();
                    break;
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    loot[i] = "Hammer of Thunderbolts";
                    break;
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    loot[i] = "Luck " + Blade();
                    break;
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    loot[i] = Blade() + " of Answering";
                    break;
                case 21:
                case 22:
                case 23:
                    loot[i] = "Holy Avenger " + Blade();
                    break;
                case 24:
                case 25:
                case 26:
                    loot[i] = "Ring of Djinni Summoning";
                    break;
                case 27:
                case 28:
                case 29:
                    loot[i] = "Ring of Invisibility";
                    break;
                case 30:
                case 31:
                case 32:
                    loot[i] = "Ring of Spell Turning";
                    break;
                case 33:
                case 34:
                case 35:
                    loot[i] = "Rod of Lordly Might";
                    break;
                case 36:
                case 37:
                case 38:
                    loot[i] = "Staff of the Magi";
                    break;
                case 39:
                case 40:
                case 41:
                    loot[i] = "Vorpal " + Blade();
                    break;
                case 42:
                case 43:
                    loot[i] = "Belt of Cloud Giant Strength";
                    break;
                case 44:
                case 45:
                    loot[i] = "Breastplate, +2";
                    break;
                case 46:
                case 47:
                    loot[i] = "Chain Mail, +3";
                    break;
                case 48:
                case 49:
                    loot[i] = "Chain Shirt, +3";
                    break;
                case 50:
                case 51:
                    loot[i] = "Cloak of Invisibility";
                    break;
                case 52:
                case 53:
                    loot[i] = "Crystal Ball (Legendary)";
                    break;
                case 54:
                case 55:
                    loot[i] = "Half Plate Armor, +1";
                    break;
                case 56:
                case 57:
                    loot[i] = "Iron Flask";
                    break;
                case 58:
                case 59:
                    loot[i] = "Leather Armor, +3";
                    break;
                case 60:
                case 61:
                    loot[i] = "Plate Armor, +1";
                    break;
                case 62:
                case 63:
                    loot[i] = "Robe of the Archmagi";
                    break;
                case 64:
                case 65:
                    loot[i] = "Rod of Resurrection";
                    break;
                case 66:
                case 67:
                    loot[i] = "Scale Mail, +1";
                    break;
                case 68:
                case 69:
                    loot[i] = "Scarab of Protection";
                    break;
                case 70:
                case 71:
                    loot[i] = "Splint Armor, +2";
                    break;
                case 72:
                case 73:
                    loot[i] = "Studded Leather Armor, +2";
                    break;
                case 74:
                case 75:
                    loot[i] = "Well of Many Worlds";
                    break;
                case 76:
                    switch (Random.Range(1, 13))
                    {
                        case 1:
                        case 2:
                            loot[i] = "Half Plate Armor, +2";
                            break;
                        case 3:
                        case 4:
                            loot[i] = "Plate Armor, +2";
                            break;
                        case 5:
                        case 6:
                            loot[i] = "Studded Leather Armor, +3";
                            break;
                        case 7:
                        case 8:
                            loot[i] = "Breastplate, +3";
                            break;
                        case 9:
                        case 10:
                            loot[i] = "Splint Armor, +3";
                            break;
                        case 11:
                            loot[i] = "Half Plate Armor, +3";
                            break;
                        case 12:
                            loot[i] = "Plate Armor, +3";
                            break;
                    }
                    break;
                case 77:
                    loot[i] = "Apparatus of Kwalish";
                    break;
                case 78:
                    loot[i] = "Armor of Invulnerability";
                    break;
                case 79:
                    loot[i] = "Belt of Storm Giant Strength";
                    break;
                case 80:
                    loot[i] = "Cubic Gate";
                    break;
                case 81:
                    loot[i] = "Deck of Many Things";
                    break;
                case 82:
                    loot[i] = "Efreeti Chain";
                    break;
                case 83:
                    loot[i] = "Half Plate Armor of " + Elemental() + " Resistance";
                    break;
                case 84:
                    loot[i] = "Iron Horn of Valhalla";
                    break;
                case 85:
                    loot[i] = "Instrument of the Bards: Ollamh Harp";
                    break;
                case 86:
                    loot[i] = "Ioun Stone of Greater Absorbtion";
                    break;
                case 87:
                    loot[i] = "Ioun Stone of Mastery";
                    break;
                case 88:
                    loot[i] = "Ioun Stone of Regeneration";
                    break;
                case 89:
                    loot[i] = "Plate Armor of Etherealness";
                    break;
                case 90:
                    loot[i] = "Plate Armor of " + Elemental() + " Resistance";
                    break;
                case 91:
                    loot[i] = "Ring of Air Elemental Command";
                    break;
                case 92:
                    loot[i] = "Ring of Earth Elemental Command";
                    break;
                case 93:
                    loot[i] = "Ring of Fire Elemental Command";
                    break;
                case 94:
                    loot[i] = "Ring of Three Wishes";
                    break;
                case 95:
                    loot[i] = "Ring of Water Elemental Command";
                    break;
                case 96:
                    loot[i] = "Sphere of Annihilation";
                    break;
                case 97:
                    loot[i] = "Talisman of Pure Good";
                    break;
                case 98:
                    loot[i] = "Talisman of the Sphere";
                    break;
                case 99:
                    loot[i] = "Talisman of Ultimate Evil";
                    break;
                case 100:
                    loot[i] = "Tome of the Stilled Tongue";
                    break;
            }
        }

        return loot;
    }

    public string ScrollCan()
    {
        string scroll = "";
        switch (Random.Range(1, 44))
        {
            case 1: return "Acid Splash";
            case 2: return "Blade Ward";
            case 3: return "Booming Blade";
            case 4: return "Chill Touch";
            case 5: return "Control Flames";
            case 6: return "Create Bonfire";
            case 7: return "Dancing Lights";
            case 8: return "Druidcraft";
            case 9: return "Eldritch Blast";
            case 10: return "Fire Bolt";
            case 11: return "Friends";
            case 12: return "Frostbite";
            case 13: return "Green-Flame Blade";
            case 14: return "Guidance";
            case 15: return "Gust";
            case 16: return "Infestation";
            case 17: return "Light";
            case 18: return "Lightning Lure";
            case 19: return "Mage Hand";
            case 20: return "Magic Stone";
            case 21: return "Mending";
            case 22: return "Message";
            case 23: return "Minor Illusion";
            case 24: return "Mold Earth";
            case 25: return "Poison Spray";
            case 26: return "Prestidigitation";
            case 27: return "Primal Savagery";
            case 28: return "Produce Flame";
            case 29: return "Ray of Frost";
            case 30: return "Resistance";
            case 31: return "Sacred Flame";
            case 32: return "Shape Water";
            case 33: return "Shillelagh";
            case 34: return "Shocking Grasp";
            case 35: return "Spare the Dying";
            case 36: return "Sword Burst";
            case 37: return "Thaumaturgy";
            case 38: return "Thorn Whip";
            case 39: return "Thunderclap";
            case 40: return "Toll the Dead";
            case 41: return "True Strike";
            case 42: return "Vicious Mockery";
            case 43: return "Word of Radiance";
        }
        return scroll;
    }
    public string Scroll1()
    {
        switch (Random.Range(1, 73))
        {
            case 1: return "Absorb Elements";
            case 2: return "Alarm";
            case 3: return "Animal Friendship";
            case 4: return "Armor of Agathys";
            case 5: return "Arms of Hadar";
            case 6: return "Bane";
            case 7: return "Beast Bond";
            case 8: return "Bless";
            case 9: return "Burning Hands";
            case 10: return "Catapult";
            case 11: return "Cause Fear";
            case 12: return "Ceremony";
            case 13: return "Chaos Bolt";
            case 14: return "Charm Person";
            case 15: return "Chromatic Orb";
            case 16: return "Color Spray";
            case 17: return "Command";
            case 18: return "Compelled Duel";
            case 19: return "Comprehend Languages";
            case 20: return "Create or Destroy Water";
            case 21: return "Cure Wounds";
            case 22: return "Detect Evil and Good";
            case 23: return "Detect Magic";
            case 24: return "Detect Poison and Disease";
            case 25: return "Disguise Self";
            case 26: return "Dissonant Whispers";
            case 27: return "Divine Favor";
            case 28: return "Earth Tremor";
            case 29: return "Ensnaring Strike";
            case 30: return "Entangle";
            case 31: return "Expeditious Retreat";
            case 32: return "Faerie Fire";
            case 33: return "False Life";
            case 34: return "Feather Fall";
            case 35: return "Find Familiar";
            case 36: return "Fog Cloud";
            case 37: return "Goodberry";
            case 38: return "Grease";
            case 39: return "Guiding Bolt";
            case 40: return "Hail of Thorns";
            case 41: return "Healing Word";
            case 42: return "Hellish Rebuke";
            case 43: return "Heroism";
            case 44: return "Hex";
            case 45: return "Hunter's Mark";
            case 46: return "Ice Knife";
            case 47: return "Identify";
            case 48: return "Illusory Script";
            case 49: return "Inflict Wounds";
            case 50: return "Jump";
            case 51: return "Longstrider";
            case 52: return "Mage Armor";
            case 53: return "Magic Missile";
            case 54: return "Protection from Evil and Good";
            case 55: return "Purify Food and Drink";
            case 56: return "Ray of Sickness";
            case 57: return "Sanctuary";
            case 58: return "Searing Smite";
            case 59: return "Shield";
            case 60: return "Shield of Faith";
            case 61: return "Silent Image";
            case 62: return "Sleep";
            case 63: return "Snare";
            case 64: return "Speak with Animals";
            case 65: return "Tasha's Hideous Laughter";
            case 66: return "Tenser's Floating Disk";
            case 67: return "Thunderous Smite";
            case 68: return "Thunderwave";
            case 69: return "Unseen Servant";
            case 70: return "Witch Bolt";
            case 71: return "Wrathful Smite";
            case 72: return "Zephyr Strike";
        }
        return "";
    }
    public string Scroll2()
    {
        switch (Random.Range(1, 72))
        {
            case 1: return "Aganazzar's Scorcher";
            case 2: return "Aid";
            case 3: return "Alter Self";
            case 4: return "Animal Messenger";
            case 5: return "Arcane Lock";
            case 6: return "Augury";
            case 7: return "Barkskin";
            case 8: return "Beast Sense";
            case 9: return "Blindness/Deafness";
            case 10: return "Blur";
            case 11: return "Branding Smite";
            case 12: return "Calm Emotions";
            case 13: return "Cloud of Daggers";
            case 14: return "Continual Flame";
            case 15: return "Cordon of Arrows";
            case 16: return "Crown of Madness";
            case 17: return "Darkness";
            case 18: return "Darkvision";
            case 19: return "Detect Thoughts";
            case 20: return "Dragon's Breath";
            case 21: return "Dust Devil";
            case 22: return "Earthbind";
            case 23: return "Enhance Ability";
            case 24: return "Enlarge/Reduce";
            case 25: return "Enthrall";
            case 26: return "Find Steed";
            case 27: return "Find Traps";
            case 28: return "Flame Blade";
            case 29: return "Flaming Sphere";
            case 30: return "Gentle Repose";
            case 31: return "Gust of Wind";
            case 32: return "Healing Spirit";
            case 33: return "Heat Metal";
            case 34: return "Hold Person";
            case 35: return "Invisibility";
            case 36: return "Knock";
            case 37: return "Lesser Restoration";
            case 38: return "Levitate";
            case 39: return "Locate Animals or Plants";
            case 40: return "Locate Object";
            case 41: return "Magic Mouth";
            case 42: return "Magic Weapon";
            case 43: return "Maximilian's Earthen Grasp";
            case 44: return "Melf's Acid Arrow";
            case 45: return "Mind Spike";
            case 46: return "Mirror Image";
            case 47: return "Misty Step";
            case 48: return "Moonbeam";
            case 49: return "Nystul's Magic Aura";
            case 50: return "Pass without Trace";
            case 51: return "Phantasmal Force";
            case 52: return "Prayer of Healing";
            case 53: return "Protection from Poison";
            case 54: return "Pyrotechnics";
            case 55: return "Ray of Enfeeblement";
            case 56: return "Rope Trick";
            case 57: return "Scorching Ray";
            case 58: return "See Invisibility";
            case 59: return "Shadow Blade";
            case 60: return "Shatter";
            case 61: return "Silence";
            case 62: return "Skywrite";
            case 63: return "Snilloc's Snowball Swarm";
            case 64: return "Spider Climb";
            case 65: return "Spike Growth";
            case 66: return "Spiritual Weapon";
            case 67: return "Suggestion";
            case 68: return "Warding Bond";
            case 69: return "Warding Wind";
            case 70: return "Web";
            case 71: return "Zone of Truth	";
        }
        return "";
    }
    public string Scroll3()
    {
        switch (Random.Range(1, 63))
        {
            case 1: return "Animate Dead";
            case 2: return "Aura of Vitality";
            case 3: return "Beacon of Hope";
            case 4: return "Bestow Curse";
            case 5: return "Blinding Smite";
            case 6: return "Blink";
            case 7: return "Call Lightning";
            case 8: return "Catnap";
            case 9: return "Clairvoyance";
            case 10: return "Conjure Animals";
            case 11: return "Conjure Barrage";
            case 12: return "Counterspell";
            case 13: return "Create Food and Water";
            case 14: return "Crusader's Mantle";
            case 15: return "Daylight";
            case 16: return "Dispel Magic";
            case 17: return "Elemental Weapon";
            case 18: return "Enemies Abound";
            case 19: return "Erupting Earth";
            case 20: return "Fear";
            case 21: return "Feign Death";
            case 22: return "Fireball";
            case 23: return "Flame Arrows";
            case 24: return "Fly";
            case 25: return "Gaseous Form";
            case 26: return "Glyph of Warding";
            case 27: return "Haste";
            case 28: return "Hunger of Hadar";
            case 29: return "Hypnotic Pattern";
            case 30: return "Leomund's Tiny Hut";
            case 31: return "Life Transference";
            case 32: return "Lightning Arrow";
            case 33: return "Lightning Bolt";
            case 34: return "Magic Circle";
            case 35: return "Major Image";
            case 36: return "Mass Healing Word";
            case 37: return "Meld into Stone";
            case 38: return "Melf's Minute Meteors";
            case 39: return "Nondetection";
            case 40: return "Phantom Steed";
            case 41: return "Plant Growth";
            case 42: return "Protection from Energy";
            case 43: return "Remove Curse";
            case 44: return "Revivify";
            case 45: return "Sending";
            case 46: return "Sleet Storm";
            case 47: return "Slow";
            case 48: return "Speak with Dead";
            case 49: return "Speak with Plants";
            case 50: return "Spirit Guardians";
            case 51: return "Stinking Cloud";
            case 52: return "Summon Lesser Demons";
            case 53: return "Thunder Step";
            case 54: return "Tidal Wave";
            case 55: return "Tiny Servant";
            case 56: return "Tongues";
            case 57: return "Vampiric Touch";
            case 58: return "Wall of Sand";
            case 59: return "Wall of Water";
            case 60: return "Water Breathing";
            case 61: return "Water Walk";
            case 62: return "Wind Wall";
        }
        return "";
    }
    public string Scroll4()
    {
        switch (Random.Range(1, 46))
        {
            case 1: return "Arcane Eye";
            case 2: return "Aura of Life";
            case 3: return "Aura of Purity";
            case 4: return "Banishment";
            case 5: return "Blight";
            case 6: return "Charm Monster";
            case 7: return "Compulsion";
            case 8: return "Confusion";
            case 9: return "Conjure Minor Elementals";
            case 10: return "Conjure Woodland Beings";
            case 11: return "Control Water";
            case 12: return "Death Ward";
            case 13: return "Dimension Door";
            case 14: return "Divination";
            case 15: return "Dominate Beast";
            case 16: return "Elemental Bane";
            case 17: return "Evard's Black Tentacles";
            case 18: return "Fabricate";
            case 19: return "Find Greater Steed";
            case 20: return "Fire Shield";
            case 21: return "Freedom of Movement";
            case 22: return "Giant Insect";
            case 23: return "Grasping Vine";
            case 24: return "Greater Invisibility";
            case 25: return "Guardian of Faith";
            case 26: return "Guardian of Nature";
            case 27: return "Hallucinatory Terrain";
            case 28: return "Ice Storm";
            case 29: return "Leomund's Secret Chest";
            case 30: return "Locate Creature";
            case 31: return "Mordenkainen's Faithful Hound";
            case 32: return "Mordenkainen's Private Sanctum";
            case 33: return "Otiluke's Resilient Sphere";
            case 34: return "Phantasmal Killer";
            case 35: return "Polymorph";
            case 36: return "Shadow of Moil";
            case 37: return "Sickening Radiance";
            case 38: return "Staggering Smite";
            case 39: return "Stone Shape";
            case 40: return "Stoneskin";
            case 41: return "Storm Sphere";
            case 42: return "Summon Greater Demon";
            case 43: return "Vitriolic Sphere";
            case 44: return "Wall of Fire";
            case 45: return "Watery Sphere";
        }
        return "";
    }
    public string Scroll5()
    {
        switch (Random.Range(1, 59))
        {
            case 1: return "Animate Objects";
            case 2: return "Antilife Shell";
            case 3: return "Awaken";
            case 4: return "Banishing Smite";
            case 5: return "Bigby's Hand";
            case 6: return "Circle of Power";
            case 7: return "Cloudkill";
            case 8: return "Commune";
            case 9: return "Commune with Nature";
            case 10: return "Cone of Cold";
            case 11: return "Conjure Elemental";
            case 12: return "Conjure Volley";
            case 13: return "Contact Other Plane";
            case 14: return "Contagion";
            case 15: return "Control Winds";
            case 16: return "Creation";
            case 17: return "Danse Macabre";
            case 18: return "Dawn";
            case 19: return "Destructive Wave";
            case 20: return "Dispel Evil and Good";
            case 21: return "Dominate Person";
            case 22: return "Dream";
            case 23: return "Enervation";
            case 24: return "Far Step";
            case 25: return "Flame Strike";
            case 26: return "Geas";
            case 27: return "Greater Restoration";
            case 28: return "Hallow";
            case 29: return "Hold Monster";
            case 30: return "Holy Weapon";
            case 31: return "Immolation";
            case 32: return "Infernal Calling";
            case 33: return "Insect Plague";
            case 34: return "Legend Lore";
            case 35: return "Maelstrom";
            case 36: return "Mass Cure Wounds";
            case 37: return "Mislead";
            case 38: return "Modify Memory";
            case 39: return "Negative Energy Flood";
            case 40: return "Passwall";
            case 41: return "Planar Binding";
            case 42: return "Raise Dead";
            case 43: return "Rary's Telepathic Bond";
            case 44: return "Reincarnate";
            case 45: return "Scrying";
            case 46: return "Seeming";
            case 47: return "Skill Empowerment";
            case 48: return "Steel Wind Strike";
            case 49: return "Swift Quiver";
            case 50: return "Synaptic Static";
            case 51: return "Telekinesis";
            case 52: return "Teleportation Circle";
            case 53: return "Transmute Rock";
            case 54: return "Tree Stride";
            case 55: return "Wall of Force";
            case 56: return "Wall of Light";
            case 57: return "Wall of Stone";
            case 58: return "Wrath of Nature";
        }
        return "";
    }
    public string Scroll6()
    {
        switch (Random.Range(1, 45))
        {
            case 1: return "Arcane Gate";
            case 2: return "Blade Barrier";
            case 3: return "Bones of the Earth";
            case 4: return "Chain Lightning";
            case 5: return "Circle of Death";
            case 6: return "Conjure Fey";
            case 7: return "Contingency";
            case 8: return "Create Homunculus";
            case 9: return "Create Undead";
            case 10: return "Disintegrate";
            case 11: return "Drawmij's Instant Summons";
            case 12: return "Druid Grove";
            case 13: return "Eyebite";
            case 14: return "Find the Path";
            case 15: return "Flesh to Stone";
            case 16: return "Forbiddance";
            case 17: return "Globe of Invulnerability";
            case 18: return "Guards and Wards";
            case 19: return "Harm";
            case 20: return "Heal";
            case 21: return "Heroes' Feast";
            case 22: return "Investiture of Flame";
            case 23: return "Investiture of Ice";
            case 24: return "Investiture of Stone";
            case 25: return "Investiture of Wind";
            case 26: return "Magic Jar";
            case 27: return "Mass Suggestion";
            case 28: return "Mental Prison";
            case 29: return "Move Earth";
            case 30: return "Otiluke's Freezing Sphere";
            case 31: return "Otto's Irresistible Dance";
            case 32: return "Planar Ally";
            case 33: return "Primordial Ward";
            case 34: return "Programmed Illusion";
            case 35: return "Scatter";
            case 36: return "Soul Cage";
            case 37: return "Sunbeam";
            case 38: return "Tenser's Transformation";
            case 39: return "Transport via Plants";
            case 40: return "True Seeing";
            case 41: return "Wall of Ice";
            case 42: return "Wall of Thorns";
            case 43: return "Wind Walk";
            case 44: return "Word of Recall";
        }
        return "";
    }
    public string Scroll7()
    {
        switch (Random.Range(1, 25))
        {
            case 1: return "Conjure Celestial";
            case 2: return "Crown of Stars";
            case 3: return "Delayed Blast Fireball";
            case 4: return "Divine Word";
            case 5: return "Etherealness";
            case 6: return "Finger of Death";
            case 7: return "Fire Storm";
            case 8: return "Forcecage";
            case 9: return "Mirage Arcane";
            case 10: return "Mordenkainen's Magnificent Mansion";
            case 11: return "Mordenkainen's Sword";
            case 12: return "Plane Shift";
            case 13: return "Power Word Pain";
            case 14: return "Prismatic Spray";
            case 15: return "Project Image";
            case 16: return "Regenerate";
            case 17: return "Resurrection";
            case 18: return "Reverse Gravity";
            case 19: return "Sequester";
            case 20: return "Simulacrum";
            case 21: return "Symbol";
            case 22: return "Teleport";
            case 23: return "Temple of the Gods";
            case 24: return "Whirlwind";
        }
        return "";
    }
    public string Scroll8()
    {
        switch (Random.Range(1, 23))
        {
            case 1: return "Abi-Dalzim's Horrid Wilting";
            case 2: return "Animal Shapes";
            case 3: return "Antimagic Field";
            case 4: return "Antipathy/Sympathy";
            case 5: return "Clone";
            case 6: return "Control Weather";
            case 7: return "Demiplane";
            case 8: return "Dominate Monster";
            case 9: return "Earthquake";
            case 10: return "Feeblemind";
            case 11: return "Glibness";
            case 12: return "Holy Aura";
            case 13: return "Illusory Dragon";
            case 14: return "Incendiary Cloud";
            case 15: return "Maddening Darkness";
            case 16: return "Maze";
            case 17: return "Mighty Fortress";
            case 18: return "Mind Blank";
            case 19: return "Power Word Stun";
            case 20: return "Sunburst";
            case 21: return "Telepathy";
            case 22: return "Tsunami";
        }
        return "";
    }
    public string Scroll9()
    {
        switch (Random.Range(1, 20))
        {
            case 1: return "Astral Projection";
            case 2: return "Foresight";
            case 3: return "Gate";
            case 4: return "Imprisonment";
            case 5: return "Invulnerability";
            case 6: return "Mass Heal";
            case 7: return "Mass Polymorp	";
            case 8: return "Meteor Swarm";
            case 9: return "Power Word Heal";
            case 10: return "Power Word Kill";
            case 11: return "Prismatic Wall";
            case 12: return "Psychic Scream";
            case 13: return "Shapechange";
            case 14: return "Storm of Vengeance";
            case 15: return "Time Stop";
            case 16: return "True Polymorph";
            case 17: return "True Resurrection";
            case 18: return "Weird";
            case 19: return "Wish";
        }
        return "";
    }

    public string Blade()
    {
        switch (Random.Range(1, 7))
        {
            case 1: return "Shortsword";
            case 2: return "Longsword";
            case 3: return "Greatsword";
            case 4: return "Rapier";
            case 5: return "Scimitar";
            case 6: return "Dagger";
        }

        return "Dagger";
    }
    public string Elemental()
    {
        switch (Random.Range(1, 11))
        {
            case 1: return "Acid";
            case 2: return "Cold";
            case 3: return "Fire";
            case 4: return "Force";
            case 5: return "Lightning";
            case 6: return "Necrotic";
            case 7: return "Poison";
            case 8: return "Psychic";
            case 9: return "Radiant";
            case 10: return "Thunder";
        }
        return "Acid";
    }
    public string Weapon()
    {
        switch (Random.Range(1, 35))
        {
            case 1: return "Club";
            case 2: return "Dagger";
            case 3: return "Greatclub";
            case 4: return "Handaxe";
            case 5: return "Javelin";
            case 6: return "Light Hammer";
            case 7: return "Mace";
            case 8: return "Quarterstaff";
            case 9: return "Sickle";
            case 10: return "Spear";
            case 11: return "Light Crossbow";
            case 12: return "Shortbow";
            case 13: return "Sling";
            case 14: return "Battleaxe";
            case 15: return "Flail";
            case 16: return "Glaive";
            case 17: return "Greataxe";
            case 18: return "Greatsword";
            case 19: return "Halberd";
            case 20: return "Lance";
            case 21: return "Longsword";
            case 22: return "Maul";
            case 23: return "Morningstar";
            case 24: return "Pike";
            case 25: return "Rapier";
            case 26: return "Scimitar";
            case 27: return "Shortsword";
            case 28: return "Trident";
            case 29: return "War Pick";
            case 30: return "Warhammer";
            case 31: return "Whip";
            case 32: return "Hand Crossbow";
            case 33: return "Heavy Crossbow";
            case 34: return "Longbow";
        }
        return "Whip";
    }
    public string CreatureType()
    {
        switch (Random.Range(1, 15))
        {
            case 1: return "Abberation";
            case 2: return "Beast";
            case 3: return "Celestial";
            case 4: return "Construct";
            case 5: return "Dragon";
            case 6: return "Elemental";
            case 7: return "Fey";
            case 8: return "Fiend";
            case 9: return "Giant";
            case 10: return "Humanoid";
            case 11: return "Monstrosity";
            case 12: return "Ooze";
            case 13: return "Plant";
            case 14: return "Undead";
        }
        return "Humanoid";
    }
    public string Ammunition()
    {
        switch (Random.Range(1, 5))
        {
            case 1: return "Arrow";
            case 2: return "Blowgun Needle";
            case 3: return "Crossbow Bolt";
            case 4: return "Sling Bullet";
        }
        return "Arrow";
    }

    public int Dice(int num, int size)
    {
        int result = 0;

        for (int i = 1; i <= num; i++)
        {
            result += Random.Range(1, (size +1));
        }

        return result;
    }
}