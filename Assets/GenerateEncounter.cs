using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateEncounter : MonoBehaviour {

    Slider playerLevel, numPlayer;
    Dropdown environment, encounterDropdown, moneyLoot;
    int exp, copper, silver, etherium, gold, platinum;
    LootGenerator lootGen;
    Dictionary<int, List<string>> arcticMonsters, coastalMonsters, desertMonsters, forestMonsters,
        grasslandMonsters, hillMonsters, mountainMonsters, swampMonsters, underdarkMonsters,
        underwaterMonsters, urbanMonsters;

    public void GenerateEasy()
    {
        exp = 0;
        int level = (int)playerLevel.value;
        int number = (int)numPlayer.value;
        int budget = 0;

        switch (level)
        {
            case 1: budget = 25; break;
            case 2: budget = 50; break;
            case 3: budget = 75; break;
            case 4: budget = 125; break;
            case 5: budget = 250; break;
            case 6: budget = 300; break;
            case 7: budget = 350; break;
            case 8: budget = 450; break;
            case 9: budget = 550; break;
            case 10: budget = 600; break;
            case 11: budget = 800; break;
            case 12: budget = 1000; break;
            case 13: budget = 1100; break;
            case 14: budget = 1250; break;
            case 15: budget = 1400; break;
            case 16: budget = 1600; break;
            case 17: budget = 2000; break;
            case 18: budget = 2100; break;
            case 19: budget = 2400; break;
            case 20: budget = 2800; break;
        }

        budget = budget * number;

        Generate(budget);
    }
    public void GenerateMedium()
    {
        exp = 0;
        int level = (int)playerLevel.value;
        int number = (int)numPlayer.value;
        int budget = 0;

        switch (level)
        {
            case 1: budget = 50; break;
            case 2: budget = 100; break;
            case 3: budget = 150; break;
            case 4: budget = 250; break;
            case 5: budget = 500; break;
            case 6: budget = 600; break;
            case 7: budget = 750; break;
            case 8: budget = 900; break;
            case 9: budget = 1100; break;
            case 10: budget = 1200; break;
            case 11: budget = 1600; break;
            case 12: budget = 2000; break;
            case 13: budget = 2200; break;
            case 14: budget = 2500; break;
            case 15: budget = 2800; break;
            case 16: budget = 3200; break;
            case 17: budget = 3900; break;
            case 18: budget = 4200; break;
            case 19: budget = 4900; break;
            case 20: budget = 5700; break;
        }

        budget = budget * number;

        Generate(budget);
    }
    public void GenerateHard()
    {
        exp = 0;
        int level = (int)playerLevel.value;
        int number = (int)numPlayer.value;
        int budget = 0;

        switch (level)
        {
            case 1: budget = 75; break;
            case 2: budget = 150; break;
            case 3: budget = 225; break;
            case 4: budget = 375; break;
            case 5: budget = 750; break;
            case 6: budget = 900; break;
            case 7: budget = 1100; break;
            case 8: budget = 1400; break;
            case 9: budget = 1600; break;
            case 10: budget = 1900; break;
            case 11: budget = 2400; break;
            case 12: budget = 3000; break;
            case 13: budget = 3400; break;
            case 14: budget = 3800; break;
            case 15: budget = 4300; break;
            case 16: budget = 4800; break;
            case 17: budget = 5900; break;
            case 18: budget = 6300; break;
            case 19: budget = 7300; break;
            case 20: budget = 8500; break;
        }

        budget = budget * number;

        Generate(budget);
    }
    public void GenerateDeadly()
    {
        exp = 0;
        int level = (int)playerLevel.value;
        int number = (int)numPlayer.value;
        int budget = 0;

        switch (level)
        {
            case 1: budget = 100; break;
            case 2: budget = 200; break;
            case 3: budget = 400; break;
            case 4: budget = 500; break;
            case 5: budget = 1100; break;
            case 6: budget = 1400; break;
            case 7: budget = 1700; break;
            case 8: budget = 2100; break;
            case 9: budget = 2400; break;
            case 10: budget = 2800; break;
            case 11: budget = 3600; break;
            case 12: budget = 4500; break;
            case 13: budget = 5100; break;
            case 14: budget = 5700; break;
            case 15: budget = 6400; break;
            case 16: budget = 7200; break;
            case 17: budget = 8800; break;
            case 18: budget = 9500; break;
            case 19: budget = 10900; break;
            case 20: budget = 12700; break;
        }

        budget = budget * number;

        Generate(budget);
    }

    void Generate(int budget)
    {
        double adjusted = 0;
        List<string> encounter = new List<string>();


        encounterDropdown.ClearOptions();
        encounterDropdown.AddOptions(new List<string> { "Monsters" });
        moneyLoot.ClearOptions();
        moneyLoot.AddOptions(new List<string> { "Loot" });

        copper = 0;
        silver = 0;
        etherium = 0;
        gold = 0;
        platinum = 0;

        while (adjusted < budget)
        {

            switch (environment.value)
            {
                case 0: encounter.Add(Arctic((budget - exp))); break;
                case 1: encounter.Add(Coastal((budget-exp))); break;
                case 2: encounter.Add(Desert((budget - exp))); break;
                case 3: encounter.Add(Forest((budget - exp))); break;
                case 4: encounter.Add(Grassland((budget - exp))); break;
                case 5: encounter.Add(Hill((budget - exp))); break;
                case 6: encounter.Add(Mountain((budget - exp))); break;
                case 7: encounter.Add(Swamp((budget - exp))); break;
                case 8: encounter.Add(Underdark((budget - exp))); break;
                case 9: encounter.Add(Underwater((budget - exp))); break;
                case 10: encounter.Add(Urban((budget - exp))); break;
            }

            if (encounter.Count == 2)
            {
                adjusted = exp * 1.5;
                Debug.Log("Adjusted exp: " + adjusted);
            }
            else if ((encounter.Count <= 6))
            {
                adjusted = exp * 2;
                Debug.Log("Adjusted exp: " + adjusted);
            }
            else if ((encounter.Count <= 10))
            {
                adjusted = exp * 2.5;
                Debug.Log("Adjusted exp: " + adjusted);
            }
            else if ((encounter.Count <= 14))
            {
                adjusted = exp * 3;
                Debug.Log("Adjusted exp: " + adjusted);
            }
            else
            {
                adjusted = exp * 4;
                Debug.Log("Adjusted exp: " + adjusted);
            }
        }

        encounterDropdown.AddOptions(encounter);

        moneyLoot.AddOptions(new List<string> {
            { "Copper: " + copper },
            { "Silver: " + silver },
            { "Etherium: " + etherium},
            { "Gold: " + gold},
            { "Platinum: " + platinum } });
    }

    string Arctic(int budget) {
        string encounter = "";
        List<int> expValues = new List<int>();
        List<string> monsters = new List<string>();

        foreach (int q in arcticMonsters.Keys) {
            expValues.Add(q);
        }

        int j = 0;
        int i = Random.Range(0, expValues.Count - 1);

        while (expValues[i] > budget) {
            i = Random.Range(0, expValues.Count - 1);
        }

        exp += expValues[i];

        RollTreasure(expValues[i]);

        j = expValues[i];

        monsters = arcticMonsters[j];

        i = Random.Range(0, monsters.Count);

        encounter = monsters[i];

        return encounter;
    }
    string Coastal(int budget) {
        string encounter = "";
        List<int> expValues = new List<int>();
        List<string> monsters = new List<string>();

        foreach (int q in coastalMonsters.Keys)
        {
            expValues.Add(q);
        }

        int j = 0;
        int i = Random.Range(0, expValues.Count - 1);

        while (expValues[i] > budget)
        {
            i = Random.Range(0, expValues.Count - 1);
        }

        exp += expValues[i];

        RollTreasure(expValues[i]);
        
        j = expValues[i];

        monsters = coastalMonsters[j];

        i = Random.Range(0, monsters.Count);

        encounter = monsters[i];

        return encounter;
    }
    string Desert(int budget) {
        string encounter = "";
        List<int> expValues = new List<int>();
        List<string> monsters = new List<string>();

        foreach (int q in desertMonsters.Keys)
        {
            expValues.Add(q);
        }

        int j = 0;
        int i = Random.Range(0, expValues.Count - 1);

        while (expValues[i] > budget)
        {
            i = Random.Range(0, expValues.Count - 1);
        }

        exp += expValues[i];

        RollTreasure(expValues[i]);

        j = expValues[i];

        monsters = desertMonsters[j];

        i = Random.Range(0, monsters.Count);

        encounter = monsters[i];

        return encounter;
    }
    string Forest(int budget) {
        string encounter = "";
        List<int> expValues = new List<int>();
        List<string> monsters = new List<string>();

        foreach (int q in forestMonsters.Keys)
        {
            expValues.Add(q);
        }

        int j = 0;
        int i = Random.Range(0, expValues.Count - 1);

        while (expValues[i] > budget)
        {
            i = Random.Range(0, expValues.Count - 1);
        }

        exp += expValues[i];

        RollTreasure(expValues[i]);

        j = expValues[i];

        monsters = forestMonsters[j];

        i = Random.Range(0, monsters.Count);

        encounter = monsters[i];

        return encounter;
    }
    string Grassland(int budget) {
        string encounter = "";
        List<int> expValues = new List<int>();
        List<string> monsters = new List<string>();

        foreach (int q in grasslandMonsters.Keys)
        {
            expValues.Add(q);
        }

        int j = 0;
        int i = Random.Range(0, expValues.Count - 1);

        while (expValues[i] > budget)
        {
            i = Random.Range(0, expValues.Count - 1);
        }

        exp += expValues[i];

        RollTreasure(expValues[i]);

        j = expValues[i];

        monsters = grasslandMonsters[j];

        i = Random.Range(0, monsters.Count);

        encounter = monsters[i];

        return encounter;
    }
    string Hill(int budget) {
        string encounter = "";
        List<int> expValues = new List<int>();
        List<string> monsters = new List<string>();

        foreach (int q in hillMonsters.Keys)
        {
            expValues.Add(q);
        }

        int j = 0;
        int i = Random.Range(0, expValues.Count - 1);

        while (expValues[i] > budget)
        {
            i = Random.Range(0, expValues.Count - 1);
        }

        exp += expValues[i];

        RollTreasure(expValues[i]);

        j = expValues[i];

        monsters = hillMonsters[j];

        i = Random.Range(0, monsters.Count);

        encounter = monsters[i];

        return encounter;
    }
    string Mountain(int budget) {
        string encounter = "";
        List<int> expValues = new List<int>();
        List<string> monsters = new List<string>();

        foreach (int q in mountainMonsters.Keys)
        {
            expValues.Add(q);
        }

        int j = 0;
        int i = Random.Range(0, expValues.Count - 1);

        while (expValues[i] > budget)
        {
            i = Random.Range(0, expValues.Count - 1);
        }

        exp += expValues[i];

        RollTreasure(expValues[i]);

        j = expValues[i];

        monsters = mountainMonsters[j];

        i = Random.Range(0, monsters.Count);

        encounter = monsters[i];

        return encounter;
    }
    string Swamp(int budget) {
        string encounter = "";
        List<int> expValues = new List<int>();
        List<string> monsters = new List<string>();

        foreach (int q in swampMonsters.Keys)
        {
            expValues.Add(q);
        }

        int j = 0;
        int i = Random.Range(0, expValues.Count - 1);

        while (expValues[i] > budget)
        {
            i = Random.Range(0, expValues.Count - 1);
        }

        exp += expValues[i];

        RollTreasure(expValues[i]);

        j = expValues[i];

        monsters = swampMonsters[j];

        i = Random.Range(0, monsters.Count);

        encounter = monsters[i];

        return encounter;
    }
    string Underdark(int budget) {
        string encounter = "";
        List<int> expValues = new List<int>();
        List<string> monsters = new List<string>();

        foreach (int q in underdarkMonsters.Keys)
        {
            expValues.Add(q);
        }

        int j = 0;
        int i = Random.Range(0, expValues.Count - 1);

        while (expValues[i] > budget)
        {
            i = Random.Range(0, expValues.Count - 1);
        }

        exp += expValues[i];

        RollTreasure(expValues[i]);

        j = expValues[i];

        monsters = underdarkMonsters[j];

        i = Random.Range(0, monsters.Count);

        encounter = monsters[i];

        return encounter;
    }
    string Underwater(int budget) {
        string encounter = "";
        List<int> expValues = new List<int>();
        List<string> monsters = new List<string>();

        foreach (int q in underwaterMonsters.Keys)
        {
            expValues.Add(q);
        }

        int j = 0;
        int i = Random.Range(0, expValues.Count - 1);

        while (expValues[i] > budget)
        {
            i = Random.Range(0, expValues.Count - 1);
        }

        exp += expValues[i];

        RollTreasure(expValues[i]);

        j = expValues[i];

        monsters = underwaterMonsters[j];

        i = Random.Range(0, monsters.Count);

        encounter = monsters[i];

        return encounter;
    }
    string Urban(int budget) {
        string encounter = "";
        List<int> expValues = new List<int>();
        List<string> monsters = new List<string>();

        foreach (int q in urbanMonsters.Keys)
        {
            expValues.Add(q);
        }

        int j = 0;
        int i = Random.Range(0, expValues.Count - 1);

        while (expValues[i] > budget)
        {
            i = Random.Range(0, expValues.Count - 1);
        }

        exp += expValues[i];

        RollTreasure(expValues[i]);

        j = expValues[i];

        monsters = urbanMonsters[j];

        i = Random.Range(0, monsters.Count);

        encounter = monsters[i];

        return encounter;
    }
    
    void Start () {
        playerLevel = FindObjectOfType<IndividualSlider>().GetComponent<Slider>();
        numPlayer = FindObjectOfType<IndivNumSlider>().GetComponent<Slider>();
        environment = FindObjectOfType<Environment>().GetComponent<Dropdown>();
        encounterDropdown = FindObjectOfType<EncounterDropdown>().GetComponent<Dropdown>();
        moneyLoot = FindObjectOfType<MoneyLoot>().GetComponent<Dropdown>();
        lootGen = FindObjectOfType<LootGenerator>();

        exp = 0;
        copper = 0;
        silver = 0;
        etherium = 0;
        gold = 0;
        platinum = 0;

        arcticMonsters = new Dictionary<int, List<string>> 
        {
            { 10, new List<string> { { "Commoner" }, { "Owl" } } },
            { 25, new List<string> { { "Bandit" }, { "Blood Hawk" }, { "Kobold" }, { "Tribal Warrior" } } },
            { 50, new List<string> { { "Giant Owl" }, { "Winged Kobold" } } },
            { 100, new List<string> { { "Ice Mephit" }, { "Orc" }, { "Scout" } } },
            { 200, new List<string> { { "Brown Bear" }, { "Half-Ogre" } } },
            { 450, new List<string> { { "Bandit Captain" }, { "Berserker" }, { "Druid" }, { "Griffon" },
                { "Ogre" }, { "Orc Eye of Grummush" }, { "Orog" }, { "Polar Bear" }, { "Saber-toothed Tiger" } } },
            { 700, new List<string> { { "Manticore" }, { "Veteran" }, { "Winter Wolf" }, { "Yeti" } } },
            { 1800, new List<string> { { "Revenant" }, { "Troll" }, { "Wereboar" }, { "Young Remorhaz" } } },
            { 2300, new List<string> { { "Mammoth" }, { "Young White Dragon" } } },
            { 3900, new List<string> { { "Frost Giant" } } },
            { 5000, new List<string> { { "Abominable Yeti" } } },
            { 7200, new List<string> { { "Remorhaz" }, { "Roc" } } },
            { 10000, new List<string> { { "Adult White Dragon" } } },
            { 25000, new List<string> { { "Ancient White Dragon" } } }
        };
        coastalMonsters = new Dictionary<int, List<string>>
        {
            {10, new List<string> { { "Commoner" }, { "Crab" }, { "Eagle" } } },
            {25, new List<string> { { "Bandit" }, { "Blood Hawk" }, { "Giant Crab" },
                { "Guard" }, { "Kobold" }, { "Merfolk" }, { "Poisonous Snake" },
                { "Stirge" }, { "Tribal Warrior" } }},
            {50, new List<string> { { "Giant Lizard" }, { "Giant Wolf Spider" },
                { "Pseudodragon" }, { "Pteradon" }, { "Winged Kobold" } }},
            {100, new List<string> { { "Sahuagin" }, { "Scout" } }},
            {200, new List<string> { { "Giant Eagle" }, { "Giant Toad" }, { "Harpy" } }},
            {450, new List<string> { { "Bandit Captain" }, { "Berserker" }, { "Druid" }, { "Griffon" },
                { "Ogre" }, { "Merrow" }, { "Plesiosaurus" }, { "Sahuagin Priestess" }, { "Sea Hag" } } },
            {700, new List<string> { { "Manticore" }, { "Veteran" } }},
            {1100, new List<string> { { "Banshee" } }},
            {1800, new List<string> { { "Sahuagin Baron" }, { "Water Elemental" } }},
            {2300, new List<string> { { "Cyclops" } }},
            {3900, new List<string> { { "Young Bronze Dragon" } }},
            {5000, new List<string> { { "Young Blue Dragon" } }},
            {7200, new List<string> { { "Djinni" }, { "Marid" }, { "Roc" } }},
            {10000, new List<string> { { "Storm Giant" } }},
            {13000, new List<string> { { "Adult Bronze Dragon" } }},
            {15000, new List<string> { { "Adult Blue Dragon" } }},
            {18000, new List<string> { { "Dragon Turtle" } }},
            {30000, new List<string> { { "Ancient Bronze Dragon" } }},
            {50000, new List<string> { { "Ancient Blue Dragon" } }}
        };
        desertMonsters = new Dictionary<int, List<string>>
        {
            {10, new List<string>{ { "Cat" }, { "Commoner" }, { "Hyena" },
                { "Jackal" }, { "Scorpion" }, { "Vulture" } } },
            {25, new List<string>{ { "Bandit" }, { "Camel" }, { "Flying Snake" }, { "Guard" },
                { "Kobold" }, { "Mule" }, { "Poisonous Snake" }, { "Stirge" }, { "Tribal Warrior" } }},
            {50, new List<string>{ { "Constrictor Snake" }, { "Giant Lizard" }, { "Giant Poisonous Snake" },
                { "Giant Wolf Spider" }, { "Pseudodragon" }, { "Winged Kobold" } }},
            {100, new List<string>{ { "Dust Mephit" }, { "Gnoll" }, { "Hobgoblin" }, { "Jackalwere" },
                { "Scout" }, { "Swarm of Insects" } }},
            {200, new List<string>{ { "Death Dog" }, { "Giant Hyena" }, { "Giant Spider" }, { "Giant Toad" },
                { "Giant Vulture" }, { "Half-Ogre" }, { "Lion" }, { "Thri-kreen" }, { "Yuan-ti Pureblood" } }},
            {450, new List<string>{ { "Bandit Captain" }, { "Berserker" }, { "Druid" },
                { "Giant Constrictor Snake" }, { "Gnoll Pack Lord" }, { "Ogre" } }},
            {700, new List<string>{ { "Giant Scorpion" }, { "Hobgoblin Captain" }, { "Mummy" },
                { "Phase Spider" }, { "Wight" }, { "Yuan-ti Malison" } }},
            {1100, new List<string>{ { "Couatl" }, { "Gnoll Fang of Yeenoghu" }, { "Lamia" }, { "Weretiger" } }},
            {1800, new List<string>{ { "Air Elemental" }, { "Fire Elemental" }, { "Revenant" } }},
            {2300, new List<string>{ { "Cyclops" }, { "Medusa" }, { "Young Brass Dragon" } }},
            {2900, new List<string>{ { "Yuan-ti Abomination" } }},
            {5000, new List<string>{ { "Young Blue Dragon" } }},
            {5900, new List<string>{ { "Guardian Naga" }  }},
            {7200, new List<string>{ { "Efreeti" }, { "Gynosphinx" }, { "Roc" } }},
            {10000, new List<string>{ { "Adult Brass Dragon" } }},
            {13000, new List<string>{ { "Mummy Lord" }, { "Purple Worm" } }},
            {15000, new List<string>{ { "Adult Blue Dragon" } }},
            {18000, new List<string>{ { "Adult Blue Dracolich" }, { "Androsphinx" } }},
            {25000, new List<string>{ { "Ancient Brass Dragon" } }},
            {50000, new List<string>{ { "Ancient Blue Dragon" } }}
        };
        forestMonsters = new Dictionary<int, List<string>>
        {
            {10, new List<string>{ { "Awakened Shrub" }, { "Baboon" }, { "Badger" },
                { "Cat" }, { "Commoner" }, { "Deer" }, { "Hyena" }, { "Owl" } } },
            {25, new List<string>{ { "Bandit" }, { "Blood Hawk" }, { "Flying Snake" },
                { "Giant Rat" }, { "Giant Weasel" }, { "Guard" }, { "Kobold" }, { "Mastiff" },
                { "Poisonous Snake" }, { "Stirge" }, { "Tribal Warrior" }, { "Twig Blight" } } },
            {50, new List<string>{ { "Blink Dog" }, { "Boar" }, { "Constrictor Snake" }, { "Elk" },
                { "Giant Badger" }, { "Giant Bat" }, { "Giant Frog" }, { "Giant Lizard" },
                { "Giant Owl" }, { "Giant Poisonous Snake" }, { "Giant Wolf Spider" },
                { "Goblin" }, { "Kenkou" }, { "Needle Blight" }, { "Panther" }, { "Pixie" },
                { "Pseudodragon" }, { "Sprite" }, { "Swarm of Ravens" }, { "Winged Kobold" }, { "Wolf" } } },
            {100, new List<string>{ { "Ape" }, { "Black Bear" }, { "Giant Wasp" }, { "Gnoll" },
                { "Hobgoblin" }, { "Lizardfolk" }, { "Orc" }, { "Satyr" }, { "Scout" },
                { "Swarm of Insects" }, { "Vine Blight" }, { "Worg" } } },
            {200, new List<string>{ { "Brown Bear" }, { "Bugbear" }, { "Dire Wolf" },
                { "Dryad" }, { "Faerie Dragon (Yellow or younger)" }, { "Giant Hyena" },
                { "Giant Spider" }, { "Giant Toad" }, { "Goblin Boss" }, { "Half-Ogre" },
                { "Harpy" }, { "Tiger" }, { "Yuan-ti Pureblood" } } },
            {450, new List<string>{ { "Ankheg" }, { "Awakened Tree" }, { "Bandit Captain" },
                { "Berserker" }, { "Druid" }, { "Centaur" }, { "Druid" }, { "Ettercap" },
                { "Faerie Dragon (green or older)" }, { "Giant Boar" }, { "Giant Constrictor Snake" },
                { "Giant Elk" }, { "Gnoll Pack Lord" }, { "Grick" }, { "Lizardfolk Shaman" },
                { "Ogre" }, { "Orc Eye of Gruumsh" }, { "Orog" }, { "Pegasus" }, { "Swarm of Poisonous Snakes" },
                { "Wererat" }, { "Will-o'-Wisp" } } },
            {700, new List<string>{ { "Displacer Beast" }, { "Green Hag" }, { "Hobgoblin Captain" },
                { "Owlbear" }, { "Phase Spider" }, { "Veteran" }, { "Werewolf" }, { "Yuan-ti Malison" } } },
            {1100, new List<string>{ { "Banshee" }, { "Couatl" }, { "Gnoll Fang of Yeenoghu" },
                { "Wereboar" }, { "Weretiger" } } },
            {1800, new List<string>{ { "Gorgon" }, { "Revenant" }, { "Shambling Mound" },
                { "Troll" }, { "Unicorn" }, { "Weretiger" } } },
            {2900, new List<string>{ { "Giant Ape" }, { "Grick Alpha" }, { "Oni" }, { "Yuan-ti Abomination" } } },
            {3900, new List<string>{ { "Young Green Dragon" } } },
            {5000, new List<string>{ { "Treant" } } },
            {5900, new List<string>{ { "Guardian Naga" }, { "Young Gold Dragon" } } },
            {13000, new List<string>{ { "Adult Green Dragon" } } },
            {18000, new List<string>{ { "Adult Gold Dragon" } } },
            {41000, new List<string>{ { "Ancient Green Dragon" } } },
            {62000, new List<string>{ { "Ancient Gold Dragon" } } }
        };
        grasslandMonsters = new Dictionary<int, List<string>>
        {
            {10, new List<string> { { "Cat" }, { "Commoner" }, { "Deer" },
                { "Eagle" }, { "Goat" }, { "Hyena" }, { "Jackal" }, { "Vulture" } } },
            {25, new List<string>{ { "Blood Hawk" }, { "Flying Snake" },
                { "Giant Weasel" }, { "Guard" }, { "Poisonous Snake" },
                { "Stirge" }, { "Tribal Warrior" } } },
            {50, new List<string>{ { "Axe Beak" }, { "Boar" }, { "Elk" },
                { "Giant Poisonous Snake" }, { "Giant Wolf Spider" },
                { "Goblin" }, { "Panther (Leopard)" }, { "Pteranodon" },
                { "Riding Horse" }, { "Wolf" } } },
            {100, new List<string>{ { "Cockatrice" }, { "Giant Goat" }, { "Giant Wasp" },
                { "Gnoll" }, { "Hobgoblin" }, { "Jackalwere" }, { "Orc" }, { "Scout" },
                { "Swarm of Insects" }, { "Worg" } } },
            {200, new List<string>{ { "Bugbear" }, { "Giant Eagle" }, { "Giant Hyena" },
                { "Giant Vulture" }, { "Goblin Boss" }, { "Hippogriff" }, { "Lion" },
                { "Scarecrow" }, { "Thri-kreen" }, { "Tiger" } } },
            {450, new List<string>{ { "Allosaurus" }, { "Ankheg" }, { "Centaur" }, { "Druid" },
                { "Giant Boar" }, { "Giant Elk" }, { "Gnoll Pack Lord" }, { "Griffon" }, { "Ogre" },
                { "Orc Eye of Gruumsh" }, { "Orog" }, { "Pegasus" }, { "Rhinoceros" } } },
            {700, new List<string>{ { "Anklyosaurus" }, { "Hobgoblin Captain" }, { "Manticore" },
                { "Phase Spider" }, { "Veteran" } } },
            {1100, new List<string>{ { "Couatl" }, { "Elephant" }, { "Gnoll Fang of Yeenoghu" },
                { "Wereboar" }, { "Weretiger" } } },
            {1800, new List<string>{ { "Bulette" }, { "Gorgon" }, { "Triceratops" } } },
            {2300, new List<string>{ { "Chimera" }, { "Cyclops" } } },
            {3900, new List<string>{ { "Tyrannosaurus Rex" } } },
            {5900, new List<string>{ { "Young Gold Dragon" } } },
            {18000, new List<string>{ { "Adult Gold Dragon" } } },
            {62000, new List<string>{ { "Ancient Gold Dragon" } } }
        };
        hillMonsters = new Dictionary<int, List<string>>
        {
            {10, new List<string> { { "Baboon" }, { "Commoner" }, { "Eagle" }, { "Goat" },
                { "Hyena" }, { "Raven" }, { "Vulture" } } },
            {25, new List<string> { { "Bandit" }, { "Blood Hawk" }, { "Giant Weasel" }, { "Guard" },
                { "Kobold" }, { "Mastiff" }, { "Mule" }, { "Poisonous Snake" }, { "Stirge" },
                { "Tribal Warrior" } } },
            {50, new List<string> { { "Axe Beak" }, { "Boar" }, { "Elk" }, { "Giant Owl" },
                { "Giant Wolf Spider" }, { "Goblin" }, { "Panther (Cougar)" }, { "Pseudodragon" },
                { "Swarm of Bats" }, { "Swarm of Ravens" }, { "Winged Kobold" }, { "Wolf" } } },
            {100, new List<string> { { "Giant Goat" }, { "Gnoll" }, { "Hobgoblin" }, { "Orc" },
                { "Scout" }, { "Swarm of Insects" }, { "Worg" } } },
            {200, new List<string> { { "Brown Bear" }, { "Dire Wolf" }, { "Giant Eagle" },
                { "Giant Hyena" }, { "Goblin Boss" }, { "Half-Ogre" }, { "Harpy" }, { "Hippogriff" },
                { "Lion" } } },
            {450, new List<string> { { "Bandit Captain" }, { "Berserker" }, { "Druid" },
                { "Giant Boar" }, { "Giant Elk" }, { "Gnoll Pack Lord" }, { "Griffon" },
                { "Ogre" }, { "Orc Eye of Gruumsh" }, { "Orog" }, { "Pegasus" }, { "Peryton" } } },
            {700, new List<string> { { "Green Hag" }, { "Hobgoblin Captain" }, { "Manticore" },
                { "Phase Spider" }, { "Veteran" }, { "Werewolf" } } },
            {1100, new List<string> { { "Ettin" }, { "Gnoll Fang of Yeenoghu" }, { "Wereboar" } } },
            {1800, new List<string> { { "Bulette" }, { "Gorgon" }, { "Hill Giant" }, { "Revenant" },
                { "Troll" }, { "Werebear" } } },
            {2300, new List<string> { { "Chimera" }, { "Cyclops" }, { "Galeb Duhr" }, { "Wyvern" } } },
            {2900, new List<string> { { "Stone Giant" }, { "Young Copper Dragon" } } },
            {5900, new List<string> { { "Young Red Dragon" } } },
            {7200, new List<string> { { "Roc" } } },
            {11500, new List<string> { { "Adult Copepr Dragon" } } },
            {18000, new List<string> { { "Adult Red Dragon" } } },
            {33000, new List<string> { { "Ancient Copper Dragon" } } },
            {62000, new List<string> { { "Ancient Red Dragon" } } }
        };
        mountainMonsters = new Dictionary<int, List<string>>
        {
            {10, new List<string> { { "Eagle" }, { "Goat" } } },
            {25, new List<string> { { "Blood Hawk" }, { "Guard" }, { "Kobold" },
                { "Stirge" }, { "Tribal Warrior" } } },
            {50, new List<string> { { "Aarakocra" }, { "Pseudodragon" },
                { "Pteranodon" }, { "Swarm of Bats" }, { "Winged Kobold" } } },
            {100, new List<string> { { "Giant Goat" }, { "Orc" }, { "Scout" } } },
            {200, new List<string> { { "Giant Eagle" }, { "Half-Ogre" }, { "Harpy" },
                {"Hippogriff" }, { "Lion" } } },
            {450, new List<string> { { "Berserker" }, { "Druid" }, { "Giant Elk" },
                { "Griffon" }, { "Ogre" }, { "Orc Eye of Gruumsh" }, { "Orog" },
                { "Peryton" }, { "Saber-Toothed Tiger" } } },
            {700, new List<string> { { "Basilisk" }, { "Hell Hound" },
                { "Manticore" }, { "Veteran" } } },
            {1100, new List<string> { { "Ettin" } } },
            {1800, new List<string> { { "Air Elemental" }, { "Bulette" }, { "Troll" } } },
            {2300, new List<string> { { "Chimera" }, { "Cyclops" },
                { "Galeb Duhr" }, { "Wyvern" } } },
            {2900, new List<string> { { "Stone Giant" } } },
            {3900, new List<string> { { "Frost Giant" } } },
            {5000, new List<string> { { "Cloud Giant" }, { "Fire Giant" }, { "Young Silver Dragon" } } },
            {5900, new List<string> { { "Young Red Dragon" } } },
            {7200, new List<string> { { "Roc" } } },
            {15000, new List<string> { { "Adult Silver Dragon" } } },
            {18000, new List<string> { { "Adult Red Dragon" } } },
            {50000, new List<string> { { "Ancient Silver Dragon" } } },
            {62000, new List<string> { { "Ancient Red Dragon" } } }
        };
        swampMonsters = new Dictionary<int, List<string>>
        {
            {10, new List<string> { { "Rat" }, { "Raven" } } },
            {25, new List<string> { { "Giant Rat" }, { "Kobold" }, { "Poisonous Snake" },
                { "Stirge" }, { "Tribal Warrior" } } },
            {50, new List<string> { { "Bullywug" }, { "Constrictor Snake" },
                { "Giant Frog" }, { "Giant Lizard" }, { "Giant Poisonous Snake" },
                { "Mud Mephit" }, { "Swarm of Rats" }, { "Swarm of Ravens" },
                { "Winged Kobold" } } },
            {100, new List<string> { { "Crocodile" }, { "Lizardfolk" }, { "Orc" },
                { "Scout" }, { "Swarm of Insects" } } },
            {200, new List<string> { { "Ghoul" }, { "Giant Spider" },
                { "Giant Toad" }, { "Yuan-ti Pureblood" } } },
            {450, new List<string> { { "Druid" }, { "Ghast" },
                { "Giant Constrictor Snake" }, { "Lizardfolk Shaman" },
                { "Ogre" }, { "Orc Eye of Gruumsh" }, { "Swarm of Poisonous Snakes" },
                { "Will-o'-Wisp" } } },
            {700, new List<string> { { "Green Hag" }, { "Wight" },
                { "Yuan-ti Malison" } } },
            {1800, new List<string> { { "Giant Crocodile" }, { "Revenant" },
                { "Shambling Mound" }, { "Troll" }, { "Water Elemental" } } },
            {2900, new List<string> { { "Young Black Dragon" }, { "Yuan-ti Abomination" } } },
            {3900, new List<string> { { "Hydra" } } },
            {11500, new List<string> { { "Adult Black Dragon" } } },
            {33000, new List<string> { { "Ancient Black Dragon" } } }
        };
        underdarkMonsters = new Dictionary<int, List<string>>
        {
            {10, new List<string> { { "Giant Fire Beetle" }, { "Shrieker" },
                { "Myconid Sprout" } } },
            {25, new List<string> { { "Flumph" }, { "Giant Rat" }, { "Kobold" },
                { "Stirge" }, { "Tribal Warrior" } } },
            {50, new List<string> { { "Drow" }, { "Giant Bat" }, { "Giant Centipede" },
                { "Giant Lizard" }, { "Giant Poisonous Snake" }, { "Goblin" },
                { "Grimlock" }, { "Kuo-Toa" }, { "Swarm of Bats" }, { "Troglodyte" },
                { "Violet Fungus" }, { "Winged Kobold" } } },
            {100, new List<string> { { "Darkmantle" }, { "Deep Gnome" },
                { "Gas Spore" }, { "Gray Ooze" }, { "Hobgoblin" }, { "Magma Mephit" },
                { "Myconid Adult" }, { "Orc" }, { "Piercer" }, { "Rust Monster" },
                { "Scout" }, { "Shadow" }, { "Swarm of Insects" } } },
            {200, new List<string> { { "Bugbear" }, { "Duergar" }, { "Fire Snake" },
                { "Ghoul" }, { "Giant Spider" }, { "Giant Toad" }, { "Goblin Boss" },
                { "Half-Ogre" }, { "Kuo-Toa Whip" }, { "Quaggoth" },
                { "Spore Servant" }, { "Specter" } } },
            {450, new List<string> { { "Carrion Crawler" }, { "Druid" },
                { "Gargoyle" }, { "Gelatinous Cube" }, { "Ghast" },
                { "Giant Constrictor Snake" }, { "Gibbering Mouther" }, { "Grick" },
                { "Intellect Devourer" }, { "Mimic" }, { "Minotaur Skeleton" },
                { "Nothic" }, { "Ochre Jelly" }, { "Ogre" }, { "Orc Eye of Gruumsh" },
                { "Orog" }, { "Polar Bear (Cave Bear)" }, { "Quaggoth" } } },
            {700, new List<string> { { "Doppelganger" }, { "Grell" },
                { "Hobgoblin Captain" }, { "Hell Hound" }, { "Hook Horror" },
                { "Kuo-Toa Monitor" }, { "Minotaur" }, { "Quaggoth Thonot" },
                { "Phase Spider" }, { "Spectator" }, { "Veteran" },
                { "Water Weird" }, { "Wight" } } },
            {1100, new List<string> { { "Black Pudding" }, { "Bone Naga" },
                { "Chuul" }, { "Ettin" }, { "Flameskull" }, { "Ghost" } } },
            {1800, new List<string> { { "Beholder Zombie" }, { "Drow Elite Warrior" },
                { "Earth Elemental" }, { "Otyugh" }, { "Roper" }, { "Salamander" },
                { "Troll" }, { "Umber Hulk" }, { "Vampire Spawn" }, { "Wraith" }, { "Xorn" } } },
            {2300, new List<string> { { "Chimera" }, { "Cyclops" }, { "Drider" } } },
            {2900, new List<string> { { "Drow Mage" }, { "Grick Alpha" },
                { "Mind Flayer" }, { "Stone Giant" } } },
            {3900, new List<string> { { "Cloaker" }, { "Fomorian" },
                { "Mind Flayer Arcanist" }, { "Spirit Naga" } } },
            {5000, new List<string> { { "Fire Giant" } } },
            {5900, new List<string> { { "Aboleth" } } },
            {7200, new List<string> { { "Behir" }, { "Dao" } } },
            {10000, new List<string> { { "Beholder" }, { "Young Red Shadow Dragon" } } },
            {11500, new List<string> { { "Death Tyrant" } } },
            {13000, new List<string> { { "Purple Worm" } } }
        };
        underwaterMonsters = new Dictionary<int, List<string>>
        {
            {10, new List<string> { { "Quipper" } } },
            {25, new List<string> { { "Merfolk" } } },
            {50, new List<string> { { "Constrictor Snake" }, { "Steam Mephit" } } },
            {100, new List<string> { { "Giant Sea Horse" }, { "Reef Shark" },
                { "Sahuagin" } } },
            {200, new List<string> { { "Giant Octopus" }, { "Swarm of Quippers" } } },
            {450, new List<string> { { "Giant Constrictor Snake" }, { "Hunter Shark" },
                { "Merrow" }, { "Plesiosaurus" }, { "Sahuagin Priestess" },
                { "Sea Hag" } } },
            {700, new List<string> { { "Killer Whale" } } },
            {1800, new List<string> { {"Giant Shark" }, { "Sahuagin Baron" },
                { "Water Elemental" } } },
            {7200, new List<string> { { "Marid" } } },
            {10000, new List<string> { { "Storm Giant" } } },
            {18000, new List<string> { { "Dragon Turtle" } } },
            {50000, new List<string> { { "Kraken" } } }
        };
        urbanMonsters = new Dictionary<int, List<string>>
        {
            {10, new List<string> { { "Cat" }, { "Commoner" }, { "Goat" },
                { "Rat" }, { "Raven" } } },
            {25, new List<string> { { "Bandit" }, { "Cultist" }, { "Flying Snake" },
                { "Giant Rat" }, { "Guard" }, { "Kobold" }, { "Mastiff" }, { "Mule" },
                { "Noble" }, { "Pony" }, { "Stirge" } } },
            {50, new List<string> { { "Acolyte" }, { "Draft Horse" },
                { "Giant Centipede" }, { "Giant Poisonous Snake" }, { "Kenku" },
                { "Pseudodragon" }, { "Riding Horse" }, { "Skeleton" },
                { "Smoke Mephit" }, { "Swarm of Bats" }, { "Swarm of Rats" },
                { "Swarm of Ravens" }, { "Winged Kobold" }, { "Zombie" } } },
            {100, new List<string> { { "Crocodile" }, { "Giant Wasp" },
                { "Shadow" }, { "Swarm of Insects" }, { "Thug" }, { "Warhorse" } } },
            {200, new List<string> { { "Ghoul" }, { "Giant Spider" },
                { "Half-Ogre" }, { "Specter" }, { "Spy" }, { "Yuan-ti Pureblood" } } },
            {450, new List<string> { { "Bandit Captain" }, { "Cult Fanatic" },
                { "Gargoyle" }, { "Ghast" }, { "Mimic" }, { "Priest" }, { "Wererat" },
                { "Will-o'-Wisp" } } },
            {700, new List<string> { { "Doppelganger" }, { "Knight" },
                { "Phase Spider" }, { "Veteran" }, { "Water Weird" }, { "Wight" } } },
            {1100, new List<string> { { "Couatl" }, { "Ghost" }, { "Succubus" },
                { "Incubus" } } },
            {1800, new List<string> { { "Cambion" }, { "Gladiator" }, { "Revenant" },
                { "Vampire Spawn" } } },
            {2300, new List<string> { { "Invisible Stalker" }, { "Mage" } } },
            {2900, new List<string> { { "Oni" }, { "Shield Guardian" } } },
            {3900, new List<string> { { "Assassin" } } },
            {5000, new List<string> { { "Gray Slaad" }, { "Young Silver Dragon" } } },
            {8400, new List<string> { { "Archmage" } } },
            {10000, new List<string> { { "Rakshasa" }, { "Vampire" } } },
            {13000, new List<string> { { "Spellcaster Vampire" }, { "Warrior Vampire" } } },
            {15000, new List<string> { { "Adult Silver Dragon" } } },
            {50000, new List<string> { { "Ancient Silver Dragon" } } },
            {155000, new List<string> { { "Tarrasque" } } }
        };
    }

    void RollTreasure(int exp) {
        if (exp <= 1100) {
            Treasure04();
        }
        else if (exp <= 5900) {
            Treasure510();
        }
        else if (exp <= 15000) {
            Treasure1116();
        }
        else {
            Treasure17();
        }
    }

    void Treasure04() {
        switch (Random.Range(0, 20) + 1) {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
                copper += lootGen.Dice(5, 6);
                break;
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
                silver += lootGen.Dice(4, 6);
                break;
            case 13:
            case 14:
                etherium += lootGen.Dice(3, 6);
                break;
            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
                gold += lootGen.Dice(3, 6);
                break;
            case 20:
                platinum += lootGen.Dice(1, 6);
                break;
        }
    }
    void Treasure510() {
        switch (Random.Range(0, 20) + 1)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
            case 6:
                copper += (lootGen.Dice(4, 6) * 100);
                etherium += (lootGen.Dice(1, 6) * 10);
                break;
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
                silver += (lootGen.Dice(6, 6) * 10);
                gold += (lootGen.Dice(2, 6) * 10);
                break;
            case 13:
            case 14:
                etherium += (lootGen.Dice(3, 6) * 10);
                gold += (lootGen.Dice(2, 6) * 10);
                break;
            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
                gold += (lootGen.Dice(4, 6) * 10);
                break;
            case 20:
                gold += (lootGen.Dice(2, 6) * 10);
                platinum = lootGen.Dice(3, 6);
                break;
        }
    }
    void Treasure1116() {
        switch (Random.Range(0, 20) + 1)
        {
            case 1:
            case 2:
            case 3:
            case 4:
                silver += (lootGen.Dice(4, 6) * 100);
                gold += (lootGen.Dice(1, 6) * 100);
                break;
            case 5:
            case 6:
            case 7:
                etherium += (lootGen.Dice(1, 6) * 100);
                gold += (lootGen.Dice(1, 6) * 100);
                break;
            case 8:
            case 9:
            case 10:
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
                gold += (lootGen.Dice(2, 6) * 100);
                platinum += (lootGen.Dice(1, 6) * 10);
                break;
            case 16:
            case 17:
            case 18:
            case 19:
            case 20:
                gold += (lootGen.Dice(2, 6) * 100);
                platinum += (lootGen.Dice(2, 6) * 10);
                break;
        }
    }
    void Treasure17() {
        switch (Random.Range(0, 20) + 1)
        {
            case 1:
            case 2:
            case 3:
                etherium += (lootGen.Dice(2, 6) * 1000);
                gold += (lootGen.Dice(8, 6) * 100);
                break;
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
            case 9:
            case 10:
            case 11:
                gold += (lootGen.Dice(1, 6) * 1000);
                platinum += (lootGen.Dice(1, 6) * 100);
                break;
            case 12:
            case 13:
            case 14:
            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
            case 20:
                gold += (lootGen.Dice(1, 6) * 1000);
                platinum += (lootGen.Dice(2, 6) * 100);
                break;
        }
    }
}
