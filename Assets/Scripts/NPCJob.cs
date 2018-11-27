using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCJob : MonoBehaviour {

    public string Occupation() {
        string job = "";

        switch (Random.Range(1, 21)) {
            case 1: job = LesserNobility(); break;
            case 2: job = Religious(); break;
            case 3: job = LegalJudicial(); break;
            case 4:
            case 5:
            case 6: job = Military(); break;
            case 7: job = Academic(); break;
            case 8:
            case 9: job = Merchant(); break;
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
            case 16:
            case 17:
            case 18: job = Agriculture(); break;
            case 19: job = Entertainment(); break;
            case 20: job = Underclass(); break;
        }

        return job;
    }

    string LesserNobility() {
        string job = "";

        switch (Random.Range(1, 9)) {
            case 1: job = "Adventurer"; break;
            case 2: job = "Dilettante"; break;
            case 3: job = "Diplomat"; break;
            case 4: job = "Knight"; break;
            case 5: job = "Minister"; break;
            case 6: job = "Nobleman"; break;
            case 7: job = "Page"; break;
            case 8: job = "Squire"; break;
        }

        return job;
    }

    string Religious() {
        string job = "";

        switch (Random.Range(1, 9)) {
            case 1: job = "Beadle"; break;
            case 2: job = "Curate"; break;
            case 3: job = "Reeve"; break;
            case 4: job = "Sexton"; break;
            case 5: job = "Theologian"; break;
            case 6: job = "Acolyte"; break;
            case 7: job = "Ward"; break;
            case 8: job = "Cleric"; break;
        }

        return job;
    }

    string LegalJudicial() {
        string job = "";

        switch (Random.Range(1, 9)) {
            case 1: job = "Bailiff"; break;
            case 2: job = "Chamberlain"; break;
            case 3: job = "Chancellor"; break;
            case 4: job = "Constable"; break;
            case 5: job = "Diplomat"; break;
            case 6: job = "Exchequer"; break;
            case 7: job = "Jailer"; break;
            case 8: job = "Judge"; break;
        }

        return job;
    }

    string Military() {
        string job = "";

        switch (Random.Range(1, 21)) {
            case 1: job = "Aid-de-camp"; break;
            case 2: job = "Archer"; break;
            case 3: job = "Bodyguard"; break;
            case 4: job = "Bounty Hunter"; break;
            case 5: job = "Cavalry"; break;
            case 6: job = "Engineer"; break;
            case 7: job = "Forester"; break;
            case 8: job = "Gate/Toll Keeper"; break;
            case 9: job = "Jailer"; break;
            case 10: job = "Mariner"; break;
            case 11: job = "Mercenary"; break;
            case 12: job = "Navigator"; break;
            case 13: job = "Scout"; break;
            case 14: job = "Soldier"; break;
            case 15: job = "Soldier"; break;
            case 16: job = "Soldier"; break;
            case 17: job = "Soldier"; break;
            case 18: job = "Soldier"; break;
            case 19: job = "Torturer"; break;
            case 20: job = "Watchman"; break;
        }

        return job;
    }

    string Academic() {
        string job = "";

        switch (Random.Range(1, 21)) {
            case 1: job = "Alchemist"; break;
            case 2: job = "Architect"; break;
            case 3: job = "Ascetic"; break;
            case 4: job = "Astrologer"; break;
            case 5: job = "Barber"; break;
            case 6: job = "Barrister"; break;
            case 7: job = "Bureaucrat"; break;
            case 8: job = "Cartographer"; break;
            case 9: job = "Engineer"; break;
            case 10: job = "Herald"; break;
            case 11: job = "Historian"; break;
            case 12: job = "Illuminator"; break;
            case 13: job = "Librarian"; break;
            case 14: job = "Mathemetician"; break;
            case 15: job = "Monk/Nun"; break;
            case 16: job = "Philosopher"; break;
            case 17: job = "Sage"; break;
            case 18: job = "Scholar"; break;
            case 19: job = "Scrivener"; break;
            case 20: job = "Tutor"; break;
        }

        return job;
    }

    string Merchant() {
        string job = "";

        switch (Random.Range(1, 90)) {
            case 1: job = "Apothecary"; break;
            case 2: job = "Architect"; break;
            case 3: job = "Armorer"; break;
            case 4: job = "Artist"; break;
            case 5: job = "Baker"; break;
            case 6: job = "Banker"; break;
            case 7: job = "Barber"; break;
            case 8: job = "Beadle"; break;
            case 9: job = "Blacksmith"; break;
            case 10: job = "Boatman"; break;
            case 11: job = "Bookbinder"; break;
            case 12: job = "Bowyer"; break;
            case 13: job = "Brazier"; break;
            case 14: job = "Brewer"; break;
            case 15: job = "Bricklayer"; break;
            case 16: job = "Butcher"; break;
            case 17: job = "Carpenter"; break;
            case 18: job = "Cartographer"; break;
            case 19: job = "Cartwright"; break;
            case 20: job = "Chandler"; break;
            case 21: job = "Chapman"; break;
            case 22: job = "Clerk"; break;
            case 23: job = "Clothier"; break;
            case 24: job = "Coachman"; break;
            case 25: job = "Cobbler"; break;
            case 26: job = "Cook"; break;
            case 27: job = "Cooper"; break;
            case 28: job = "Curate"; break;
            case 29: job = "Draper"; break;
            case 30: job = "Dyer"; break;
            case 31: job = "Engraver"; break;
            case 32: job = "Farmer"; break;
            case 33: job = "Farmer"; break;
            case 34: job = "Fisherman"; break;
            case 35: job = "Fisherman"; break;
            case 36: job = "Fishmonger"; break;
            case 37: job = "Forester"; break;
            case 38: job = "Fortune Teller"; break;
            case 39: job = "Furrier"; break;
            case 40: job = "Gardener"; break;
            case 41: job = "Glassblower"; break;
            case 42: job = "Glazier"; break;
            case 43: job = "Gold/Silversmith"; break;
            case 44: job = "Gravedigger"; break;
            case 45: job = "Grocer"; break;
            case 46: job = "Groom"; break;
            case 47: job = "Hatter"; break;
            case 48: job = "Herdsman"; break;
            case 49: job = "Hunter"; break;
            case 50: job = "Trapper"; break;
            case 51: job = "Innkeeper"; break;
            case 52: job = "Jeweler"; break;
            case 53: job = "Joiner"; break;
            case 54: job = "Laundress"; break;
            case 55: job = "Leatherworker"; break;
            case 56: job = "Link Boy"; break;
            case 57: job = "Locksmith"; break;
            case 58: job = "Maid"; break;
            case 59: job = "Mason"; break;
            case 60: job = "Mercer"; break;
            case 61: job = "Merchant"; break;
            case 62: job = "Messenger"; break;
            case 63: job = "Miller"; break;
            case 64: job = "Miner"; break;
            case 65: job = "Moneylender"; break;
            case 66: job = "Ostler"; break;
            case 67: job = "Painter"; break;
            case 68: job = "Peddler"; break;
            case 69: job = "Porter"; break;
            case 70: job = "Ratcatcher"; break;
            case 71: job = "Reeve"; break;
            case 72: job = "Sailor"; break;
            case 73: job = "Scribe"; break;
            case 74: job = "Seamstress"; break;
            case 75: job = "Servant"; break;
            case 76: job = "Sexton"; break;
            case 77: job = "Shipwright"; break;
            case 78: job = "Spinster"; break;
            case 79: job = "Stevedore"; break;
            case 80: job = "Tailor"; break;
            case 81: job = "Tanner"; break;
            case 82: job = "Tax Collector"; break;
            case 83: job = "Thatcher"; break;
            case 84: job = "Tinker"; break;
            case 85: job = "Torturer"; break;
            case 86: job = "Trader"; break;
            case 87: job = "Usurer"; break;
            case 88: job = "Vintner"; break;
            case 89: job = "Weaver"; break;
        }

        return job;
    }

    string Agriculture() {
        string job = "";

        switch (Random.Range(1, 11)) {
            case 1: job = "Cooper"; break;
            case 2: job = "Farmer"; break;
            case 3: job = "Falconer"; break;
            case 4: job = "Fisherman"; break;
            case 5: job = "Forester"; break;
            case 6: job = "Herdsman"; break;
            case 7: job = "Houndsman"; break;
            case 8: job = "Hunter"; break;
            case 9: job = "Ostler"; break;
            case 10: job = "Woodsman"; break;
        }

        return job;
    }

    string Entertainment() {
        string job = "";

        switch (Random.Range(1, 11)) {
            case 1: job = "Acrobat"; break;
            case 2: job = "Actor"; break;
            case 3: job = "Clown"; break;
            case 4: job = "Dancer"; break;
            case 5: job = "Fortune Teller"; break;
            case 6: job = "Juggler"; break;
            case 7: job = "Musician"; break;
            case 8: job = "Player"; break;
            case 9: job = "Prestidigitator"; break;
            case 10: job = "Storyteller"; break;
        }

        return job;
    }

    string Underclass() {
        string job = "";

        switch (Random.Range(1, 13)) {
            case 1: job = "Bandit/Mugger/Thug"; break;
            case 2: job = "Beggar"; break;
            case 3: job = "Burglar"; break;
            case 4: job = "Fence"; break;
            case 5: job = "Gambler"; break;
            case 6: job = "Pickpocket"; break;
            case 7: job = "Procurer"; break;
            case 8: job = "Prostitute"; break;
            case 9: job = "Slaver"; break;
            case 10: job = "Smuggler"; break;
            case 11: job = "Usurer"; break;
            case 12: job = "Wanderer"; break;
        }

        return job;
    }

    void Start () {
		
	}
	
	
    void Update () {
		
	}
}
