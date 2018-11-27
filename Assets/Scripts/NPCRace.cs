using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCRace : MonoBehaviour {

    NPCName npcName;
    string nameNPC, race;

    public string Race(ref NPCBlock block)
    {
        int raceNum = Random.Range(1, 101);
        
        switch (raceNum)
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
                race = "Human";
                nameNPC = npcName.HumanName(ref block);
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
                switch (Random.Range(1, 3)) {
                    case 1:
                        race = "High Elf";
                        break;
                    case 2:
                        race = "Wood Elf";
                        break;
                }
                nameNPC = npcName.ElfName(ref block);
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
                switch (Random.Range(1, 3)) {
                    case 1:
                        race = "Mountain Dwarf";
                        break;
                    case 2:
                        race = "Hill Dwarf";
                        break;
                }
                nameNPC = npcName.DwarfName(ref block);
                break;
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
                race = "Gnome";
                nameNPC = npcName.GnomeName(ref block);
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
                race = "Half-Elf";
                switch (Random.Range(1, 3))
                {
                    case 1:
                        nameNPC = npcName.HumanName(ref block);
                        break;
                    case 2:
                        nameNPC = npcName.ElfName(ref block);
                        break;
                }
                break;
            case 81:
            case 82:
            case 83:
            case 84:
            case 85:
                race = "Halfling";
                nameNPC = npcName.HalflingName(ref block);
                break;
            case 86:
            case 87:
            case 88:
            case 89:
            case 90:
                race = "Half-Orc";
                nameNPC = npcName.HalfOrcName(ref block);
                break;
            case 91:
            case 92:
            case 93:
            case 94:
            case 95:
                race = "Dragonborn";
                nameNPC = npcName.DragonbornName(ref block);
                break;
            case 96:
            case 97:
            case 98:
            case 99:
            case 100:
                race = "Tiefling";
                nameNPC = npcName.TieflingName(ref block);
                break;
        }

        return race;
    }

    public string RaceMonster()
    {
        int raceNum = Random.Range(1, 101);
        string race = "";

        switch (raceNum)
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
            case 91:
            case 92:
            case 93:
            case 94:
            case 95:
            case 96:
            case 97:
            case 98:
            case 99:
            case 100:
                break;
        }

        return race;
    }

    public string GetRace() {
        return race;
    }

    public string GetName()
    {
        return nameNPC;
    }

    // Use this for initialization
    void Start () {
        npcName = FindObjectOfType<NPCName>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
