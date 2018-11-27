using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateDungeon : MonoBehaviour {

    Transform mapDispaly;
    public GameObject[] mapSprites;

    public int mapWidth, mapDepth, mapFloors;
    enum Map
    {
        Wall, PassageIP, Passage, PassageOnePillar, PassageTwoPillar, PassageTall, PassageBalcony,
        Stairs, StDwnOneChm, StDwnOnePass, StDwnTwoChm, StDwnTwoPass, StDwnThrChm, StDwnThrPass, StUpOneChm,
        StUpOnePass, StUpDead, StDwnDead, ChmUpOnePass, ChmUpTwoPass, ShtDwnOneChm, ShtDwnUp, Door, WoodDoor,
        WoodDoorL, StoneDoor, StoneDoorL, IronDoor, IronDoorL, Portcullis, PortcullisL, SecretDoor, SecretDoorL,
        Room, Enter, Well, Blank
    };
    enum RoomID
    {
        StndPass, PassDrRt, PassDrLt, ShortPassDr, PassPassRt, PassPassLt, ShortPassDE, LPassLt, LPassRt,
        BeyondDoorT, BeyondDoorStr, TrappedDoor,
        Chm2020, Chm3030, Chm4040, Chm2030, Chm3040, Chm4050, Chm5080, ChmCr30, ChmCr50, ChmOct40, ChmOct60, ChmTrp,
        Stair, Default
    };

    bool incomplete;

    Map[,,] dungeon;

    public void ClearDisplay() {
        foreach (Transform child in mapDispaly)
        {
            child.GetComponent<DestroyMe>().Destroy();
        }
    }

    void Generate() {
        int xmid = (mapWidth / 2) - 1;
        int floor = Random.Range(0, mapFloors);

        incomplete = true;

        NewMap();

        RollEnterance(xmid, floor);

        while (incomplete)
        {
            SearchForIncomplete(floor);
        }

        DisplayMap();
    }

    void DisplayMap()
    {
        ClearDisplay();

        for (int f = 0; f < mapFloors; f++)
        {
            for (int x = 0; x < mapWidth; x++)
            {
                for (int y = 0; y < mapDepth; y++)
                {
                    switch (dungeon[f, x, y])
                    {
                        case Map.Wall:
                            Instantiate(mapSprites[0], new Vector3((float)(x * 0.2), (float)(y * -0.2), 0), Quaternion.identity, mapDispaly);
                            break;
                        case Map.Passage:
                            Instantiate(mapSprites[1], new Vector3((float)(x * 0.2), (float)(y * -0.2), 0), Quaternion.identity, mapDispaly);
                            break;
                        case Map.PassageOnePillar:
                            Instantiate(mapSprites[2], new Vector3((float)(x * 0.2), (float)(y * -0.2), 0), Quaternion.identity, mapDispaly);
                            break;
                        case Map.PassageTwoPillar:
                            Instantiate(mapSprites[3], new Vector3((float)(x * 0.2), (float)(y * -0.2), 0), Quaternion.identity, mapDispaly);
                            break;
                        case Map.PassageTall:
                            Instantiate(mapSprites[4], new Vector3((float)(x * 0.2), (float)(y * -0.2), 0), Quaternion.identity, mapDispaly);
                            break;
                        case Map.PassageBalcony:
                            Instantiate(mapSprites[5], new Vector3((float)(x * 0.2), (float)(y * -0.2), 0), Quaternion.identity, mapDispaly);
                            break;
                        case Map.StDwnOneChm:
                        case Map.StDwnOnePass:
                        case Map.StDwnTwoChm:
                        case Map.StDwnTwoPass:
                        case Map.StDwnThrChm:
                        case Map.StDwnThrPass:
                        case Map.StDwnDead:
                            Instantiate(mapSprites[6], new Vector3((float)(x * 0.2), (float)(y * -0.2), 0), Quaternion.identity, mapDispaly);
                            break;
                        case Map.StUpDead:
                        case Map.StUpOneChm:
                        case Map.StUpOnePass:
                            Instantiate(mapSprites[7], new Vector3((float)(x * 0.2), (float)(y * -0.2), 0), Quaternion.identity, mapDispaly);
                            break;
                        case Map.IronDoor:
                        case Map.IronDoorL:
                            Instantiate(mapSprites[8], new Vector3((float)(x * 0.2), (float)(y * -0.2), 0), Quaternion.identity, mapDispaly);
                            break;
                        case Map.StoneDoor:
                        case Map.StoneDoorL:
                            Instantiate(mapSprites[9], new Vector3((float)(x * 0.2), (float)(y * -0.2), 0), Quaternion.identity, mapDispaly);
                            break;
                        case Map.WoodDoor:
                        case Map.WoodDoorL:
                            Instantiate(mapSprites[10], new Vector3((float)(x * 0.2), (float)(y * -0.2), 0), Quaternion.identity, mapDispaly);
                            break;
                        case Map.Portcullis:
                        case Map.PortcullisL:
                            Instantiate(mapSprites[11], new Vector3((float)(x * 0.2), (float)(y * -0.2), 0), Quaternion.identity, mapDispaly);
                            break;
                        case Map.Well:
                            Instantiate(mapSprites[12], new Vector3((float)(x * 0.2), (float)(y * -0.2), 0), Quaternion.identity, mapDispaly);
                            break;
                        case Map.Enter:
                            Instantiate(mapSprites[13], new Vector3((float)(x * 0.2), (float)(y * -0.2), 0), Quaternion.identity, mapDispaly);
                            break;
                        case Map.Room:
                            Instantiate(mapSprites[14], new Vector3((float)(x * 0.2), (float)(y * -0.2), 0), Quaternion.identity, mapDispaly);
                            break;
                        case Map.SecretDoor:
                        case Map.SecretDoorL:
                            Instantiate(mapSprites[15], new Vector3((float)(x * 0.2), (float)(y * -0.2), 0), Quaternion.identity, mapDispaly);
                            break;
                        case Map.Blank:
                            Instantiate(mapSprites[16], new Vector3((float)(x * 0.2), (float)(y * -0.2), 0), Quaternion.identity, mapDispaly);
                            break;
                        case Map.Stairs:
                            Instantiate(mapSprites[17], new Vector3((float)(x * 0.2), (float)(y * -0.2), 0), Quaternion.identity, mapDispaly);
                            break;
                        default:
                            //Debug.Log("Incomplete dungeon at " + x + " " + y + ", found " + dungeon[f, x, y]);
                            //Debug.Log("Inputting wall");
                            Instantiate(mapSprites[0], new Vector3((float)(x * 0.2), (float)(y * -0.2), 0), Quaternion.identity, mapDispaly);
                            break;
                    }
                }
            }
        }
    }

    void SearchForIncomplete(int floor) {
        int direction = 5;
        int[] piece = new int[2] { 0, 0 };
        bool found = false;


        for (int x = 0; x < mapWidth; x++)
        {
            for (int y = 0; y < mapDepth; y++)
            {
                if ((dungeon[floor, x, y] == Map.PassageIP) || (dungeon[floor, x, y] == Map.Door))
                {
                    piece[0] = x;
                    piece[1] = y;
                    found = true;
                    break;
                }
            }
            if (found) { break; }
        }

        if (found)
        {
            bool fromRoom = false;
            if (dungeon[floor, piece[0] + 1, piece[1]] == Map.Room)
            {
                fromRoom = true;
                direction = 1;
            }
            else if (dungeon[floor, piece[0] - 1, piece[1]] == Map.Room)
            {
                fromRoom = true;
                direction = 0;
            }
            else if (dungeon[floor, piece[0], piece[1] + 1] == Map.Room)
            {
                fromRoom = true;
                direction = 3;
            }
            else if (dungeon[floor, piece[0], piece[1] - 1] == Map.Room)
            {
                fromRoom = true;
                direction = 2;
            }

            if (dungeon[floor, piece[0], piece[1]] == Map.PassageIP)
            {
                //RollPassage(fromRoom, new int[] { floor, piece[0], piece[1] }, direction);
            }
            if (dungeon[floor, piece[0], piece[1]] == Map.Door)
            {
                dungeon[floor, piece[0], piece[1]] = RollDoor();
                BeyondDoor(new int[] { floor, piece[0], piece[1] }, direction);
            }
            found = false;
        }
        else
        {
            incomplete = false;
        }
    }

    void BeyondDoor(int[] loc, int dir)
    {
        RoomID beyond;
        int attempts = 1;

        BEYONDDOOR:

        switch(Random.Range(1, 21))
        {
            case 1:
            case 2:
                beyond = RoomID.BeyondDoorT;
                break;
            case 3:
            case 4:
            case 5:
            case 6:
            case 7:
            case 8:
                beyond = RoomID.BeyondDoorStr;
                break;
            case 19:
                beyond = RoomID.Stair;
                break;
            case 20:
                beyond = RoomID.TrappedDoor;
                break;
            default:
                beyond = RollChamber();
                break;
        }

/*
        if (!Valid(loc, dir, beyond, 0))
        {
            if (attempts < 10)
            {
                attempts++;
                goto BEYONDDOOR;
            }
            else
            {
                dungeon[loc[0], loc[1], loc[2]] = Map.Passage;
            }
        }
*/
    }

/*    void RollPassage(bool fromRoom, int[] loc, int direction)
    {

        int passWidth = 0;

        int passNum = Random.Range(1, 21);
        RoomID passageID = RoomID.Default;
        int invalidCount = 0;
        
        if (!fromRoom)
        {
            if (dungeon[loc[0], loc[1] + 2, loc[2]] == Map.Passage)
            {
                direction = 1;
            }
            else if (dungeon[loc[0], loc[1] - 2, loc[2]] == Map.Passage)
            {
                direction = 0;
            }
            else if (dungeon[loc[0], loc[1], loc[2] - 2] == Map.Passage)
            {
                direction = 2;
            }
            else if (dungeon[loc[0], loc[1], loc[2] + 2] == Map.Passage)
            {
                direction = 3;
            }
        }

        switch (passNum)
        {
            case 1:
            case 2:
                passageID = RoomID.StndPass;
                if (fromRoom)
                    passWidth = PassWidth(20);
                else
                    passWidth = PassWidth(12);
                break;
            case 3:
                passageID = RoomID.PassDrRt;
                if (fromRoom)
                    passWidth = PassWidth(20);
                else
                    passWidth = PassWidth(12);
                break;
            case 4:
                passageID = RoomID.PassDrLt;
                if (fromRoom)
                    passWidth = PassWidth(20);
                else
                    passWidth = PassWidth(12);
                break;
            case 5:
                passageID = RoomID.ShortPassDr;
                if (fromRoom)
                    passWidth = PassWidth(20);
                else
                    passWidth = PassWidth(12);
                break;
            case 6:
            case 7:
                passageID = RoomID.PassPassRt;
                if (fromRoom)
                    passWidth = PassWidth(20);
                else
                    passWidth = PassWidth(12);
                break;
            case 8:
            case 9:
                passageID = RoomID.PassPassLt;
                if (fromRoom)
                    passWidth = PassWidth(20);
                else
                    passWidth = PassWidth(12);
                break;
            case 10:
                passageID = RoomID.ShortPassDE;
                if (fromRoom)
                    passWidth = PassWidth(20);
                else
                    passWidth = PassWidth(12);
                break;
            case 11:
            case 12:
                passageID = RoomID.LPassLt;
                if (fromRoom)
                    passWidth = PassWidth(20);
                else
                    passWidth = PassWidth(12);
                break;
            case 13:
            case 14:
                passageID = RoomID.LPassRt;
                if (fromRoom)
                    passWidth = PassWidth(20);
                else
                    passWidth = PassWidth(12);
                break;
            case 15:
            case 16:
            case 17:
            case 18:
            case 19:
                passageID = RollChamber();
                passWidth = 0;
                break;
            case 20:
                passageID = RoomID.Stair;
                passWidth = 0;
                break;
        }
        
        while ((!(Valid(loc, direction, passageID, passWidth))) && (invalidCount < 10))
        {
            //Debug.Log("Invalid: " + passageID + " at " + " " + loc[0] + " " + loc[1] + " " + loc[2] + " dir: " + direction + " size: " + passWidth);
            invalidCount++;
            passNum = Random.Range(1, 21);
            switch (passNum)
            {
                case 1:
                case 2:
                    passageID = RoomID.StndPass;
                    break;
                case 3:
                    passageID = RoomID.PassDrRt;
                    break;
                case 4:
                    passageID = RoomID.PassDrLt;
                    break;
                case 5:
                    passageID = RoomID.ShortPassDr;
                    break;
                case 6:
                case 7:
                    passageID = RoomID.PassPassRt;
                    break;
                case 8:
                case 9:
                    passageID = RoomID.PassPassLt;
                    break;
                case 10:
                    passageID = RoomID.ShortPassDE;
                    break;
                case 11:
                case 12:
                    passageID = RoomID.LPassLt;
                    break;
                case 13:
                case 14:
                    passageID = RoomID.LPassRt;
                    break;
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                    passageID = RollChamber();
                    break;
                case 20:
                    passageID = RoomID.Stair;
                    break;
            }
        }

        if (!(Valid(loc, direction, passageID, passWidth)))
            goto END;
        
        //switch (passageID)
        switch (passageID)
        {
            case RoomID.StndPass:
                //Debug.Log("Rolled simple passage");
                switch (direction)
                {
                    case 0:
                        //+x
                        //Debug.Log("Going right");
                        for (int x = loc[1]; x < loc[1] + 6; x++)
                        {
                            if (passWidth == 1)
                                dungeon[loc[0], x, loc[2]] = Map.Passage;
                            else
                                for (int y = loc[2] - (passWidth / 2) + 1; y < loc[2] + (passWidth / 2) + 1; y++)
                                    dungeon[loc[0], x, y] = Map.Passage;
                        }
                        break;
                    case 1:
                        //-x
                        //Debug.Log("Going left");
                        for (int x = loc[1]; x > loc[1] - 6; x--)
                        {
                            if (passWidth == 1)
                                dungeon[loc[0], x, loc[2]] = Map.Passage;
                            else
                                for (int y = loc[2] - (passWidth / 2) + 1; y < loc[2] + (passWidth / 2) + 1; y++)
                                {
                                    dungeon[loc[0], x, y] = Map.Passage;
                                }
                        }
                        break;
                    case 2:
                        //+y
                        //Debug.Log("Going down");
                        for (int y = loc[2]; y < loc[2] + 6; y++)
                        {
                            if (passWidth == 1)
                                dungeon[loc[0], loc[1], y] = Map.Passage;
                            else
                                for (int x = loc[1] - (passWidth / 2) + 1; x < loc[1] + (passWidth / 2) + 1; x++)
                                    dungeon[loc[0], x, y] = Map.Passage;
                        }
                        break;
                    case 3:
                        //-y
                        //Debug.Log("Going up");
                        for (int y = loc[2]; y > loc[2] - 6; y--)
                        {
                            if (passWidth == 1)
                                dungeon[loc[0], loc[1], y] = Map.Passage;
                            else
                                for (int x = loc[1] - (passWidth / 2) + 1; x < loc[1] + (passWidth / 2) + 1; x++)
                                    dungeon[loc[0], x, y] = Map.Passage;
                        }
                        break;
                }
                break;
            #region Other Cases

            case RoomID.PassDrRt:
                //Debug.Log("Rolled a passage with a door on the right after 20 feet");
                switch (direction)
                {
                    case 0:
                        //+x
                        //Debug.Log("Going right");
                        if ((loc[1] + 6) <= mapWidth)
                        {
                            for (int x = loc[1]; x <= loc[1] + 5; x++)
                            {
                                if (passWidth == 0)
                                {
                                    dungeon[loc[0], x, loc[2]] = Map.Passage;
                                    if ((x == loc[1] + 4) && (dungeon[loc[0], x, loc[2] + 1] == Map.Blank))
                                    {
                                        dungeon[loc[0], x, loc[2] + 1] = Map.Door;
                                    }
                                }
                                else
                                {
                                    for (int y = loc[2]; y < loc[2] + (2 * passWidth); y++)
                                    {
                                        dungeon[loc[0], x, y] = Map.Passage;
                                        if ((x == loc[1] + 4) && (dungeon[loc[0], x, loc[2] + 2] == Map.Blank))
                                        {
                                            dungeon[loc[0], x, loc[2] + 2] = Map.Door;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 1:
                        //-x
                        //Debug.Log("Going left");
                        if ((loc[1] - 6) > 0)
                        {
                            for (int x = loc[1]; x >= loc[1] - 5; x--)
                            {
                                if (passWidth == 0)
                                {
                                    dungeon[loc[0], x, loc[2]] = Map.Passage;
                                    if ((x == loc[1] - 4) && (dungeon[loc[0], x, loc[2] - 1] == Map.Blank))
                                    {
                                        dungeon[loc[0], x, loc[2] - 1] = Map.Door;
                                    }
                                }
                                else
                                {
                                    for (int y = loc[2]; y < loc[2] + (2 * passWidth); y++)
                                    {
                                        dungeon[loc[0], x, y] = Map.Passage;
                                        if ((x == loc[1] - 4) && (dungeon[loc[0], x, loc[2] - 1] == Map.Blank))
                                        {
                                            dungeon[loc[0], x, loc[2] - 1] = Map.Door;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 2:
                        //+y
                        //Debug.Log("Going down");
                        if ((loc[2] + 6) <= mapDepth)
                        {
                            for (int y = loc[2]; y <= loc[2] + 5; y++)
                            {
                                if (passWidth == 0)
                                {
                                    dungeon[loc[0], loc[1], y] = Map.Passage;
                                    if ((y == loc[2] + 4) && (dungeon[loc[0], loc[1] - 1, y] == Map.Blank))
                                    {
                                        dungeon[loc[0], loc[1] - 1, y] = Map.Door;
                                    }
                                }
                                else
                                {
                                    for (int x = loc[1]; x < loc[1] + (2 * passWidth); x++)
                                    {
                                        dungeon[loc[0], x, y] = Map.Passage;
                                        if ((y == loc[2] + 4) && (dungeon[loc[0], loc[1] - 1, y] == Map.Blank))
                                        {
                                            dungeon[loc[0], x - 1, y] = Map.Door;

                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        //-y
                        //Debug.Log("Going up");
                        if ((loc[2] - 6) > 0)
                        {
                            for (int y = loc[2]; y >= loc[2] - 5; y--)
                            {
                                if (passWidth == 0)
                                {
                                    dungeon[loc[0], loc[1], y] = Map.Passage;
                                    if ((y == loc[1] - 4) && (dungeon[loc[0], loc[1] + 1, y] == Map.Blank))
                                    {
                                        dungeon[loc[0], loc[1] + 1, y] = Map.Blank;
                                    }
                                }
                                else
                                {
                                    for (int x = loc[1]; x < loc[1] + (2 * passWidth); x++)
                                    {
                                        dungeon[loc[0], x, y] = Map.Passage;
                                        if ((y == loc[2] - 4) && (dungeon[loc[0], loc[1] + 2, y] == Map.Blank))
                                        {
                                            dungeon[loc[0], x + 1, y] = Map.Door;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                }
                break;
            case RoomID.PassDrLt:
                //Debug.Log("Rolled a passage with a door on the left after 20 feet");
                switch (direction)
                {
                    case 0:
                        //+x
                        //Debug.Log("Going right");
                        if ((loc[1] + 6) <= mapWidth)
                        {
                            for (int x = loc[1]; x <= loc[1] + 5; x++)
                            {
                                if (passWidth == 0)
                                {
                                    dungeon[loc[0], x, loc[2]] = Map.Passage;
                                    if ((x == loc[1] + 3) && (dungeon[loc[0], x, loc[2] + 1] == Map.Blank))
                                    {
                                        dungeon[loc[0], x, loc[2] - 1] = Map.Door;
                                    }
                                }
                                else
                                {
                                    for (int y = loc[2]; y < loc[2] + (2 * passWidth); y++)
                                    {
                                        dungeon[loc[0], x, y] = Map.Passage;
                                        if ((x == loc[1] + 3) && (dungeon[loc[0], x, loc[2] + 2] == Map.Blank))
                                        {
                                            dungeon[loc[0], x, loc[2] - 1] = Map.Door;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 1:
                        //-x
                        //Debug.Log("Going left");
                        if ((loc[1] - 6) > 0)
                        {
                            for (int x = loc[1] - 1; x >= loc[1] - 5; x--)
                            {
                                if (passWidth == 0)
                                {
                                    dungeon[loc[0], x, loc[2]] = Map.Passage;
                                    if ((x == loc[1] - 3) && (dungeon[loc[0], x, loc[2] - 1] == Map.Blank))
                                    {
                                        dungeon[loc[0], x, loc[2] + 1] = Map.Door;
                                    }
                                }
                                else
                                {
                                    for (int y = loc[2]; y < loc[2] + (2 * passWidth); y++)
                                    {
                                        dungeon[loc[0], x, y] = Map.Passage;
                                        if ((x == loc[1] - 3) && (dungeon[loc[0], x, loc[2] - 1] == Map.Blank))
                                        {
                                            dungeon[loc[0], x, loc[2] + 2] = Map.Door;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 2:
                        //+y
                        //Debug.Log("Going down");
                        if ((loc[2] + 6) <= mapDepth)
                        {
                            for (int y = loc[2] + 1; y <= loc[2] + 5; y++)
                            {
                                if (passWidth == 0)
                                {
                                    dungeon[loc[0], loc[1], y] = Map.Passage;
                                    if ((y == loc[2] + 3) && (dungeon[loc[0], loc[1] - 1, y] == Map.Blank))
                                    {
                                        dungeon[loc[0], loc[1] + 1, y] = Map.Door;
                                    }
                                }
                                else
                                {
                                    for (int x = loc[1]; x < loc[1] + (2 * passWidth); x++)
                                    {
                                        dungeon[loc[0], x, y] = Map.Passage;
                                        if ((y == loc[2] + 3) && (dungeon[loc[0], loc[1] - 1, y] == Map.Blank))
                                        {
                                            dungeon[loc[0], x + 1, y] = Map.Door;

                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        //-y
                        //Debug.Log("Going up");
                        if ((loc[2] - 6) > 0)
                        {
                            for (int y = loc[2] - 1; y >= loc[2] - 5; y--)
                            {
                                if (passWidth == 0)
                                {
                                    dungeon[loc[0], loc[1], y] = Map.Passage;
                                    if ((y == loc[1] - 3) && (dungeon[loc[0], loc[1] + 1, y] == Map.Blank))
                                    {
                                        dungeon[loc[0], loc[1] - 1, y] = Map.Door;
                                    }
                                }
                                else
                                {
                                    for (int x = loc[1]; x < loc[1] + (2 * passWidth); x++)
                                    {
                                        dungeon[loc[0], x, y] = Map.Passage;
                                        if ((y == loc[2] - 3) && (dungeon[loc[0], loc[1] + 2, y] == Map.Blank))
                                        {
                                            dungeon[loc[0], x - 1, y] = Map.Door;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                }
                break;
            case RoomID.ShortPassDr:
                //Debug.Log("Rolled a short passage with a door on the end");
                switch (direction)
                {
                    case 0:
                        //+x
                        if ((loc[1] + 4) <= mapWidth)
                        {
                            for (int x = loc[1]; x <= loc[1] + 4; x++)
                            {
                                if (passWidth == 0)
                                {
                                    if (x != loc[1] + 4)
                                    { dungeon[loc[0], x, loc[2]] = Map.Passage; }
                                    else
                                        dungeon[loc[0], x, loc[2]] = Map.Door;
                                }
                                else
                                {
                                    for (int y = loc[2]; y < loc[2] + (2 * passWidth); y++)
                                    {
                                        if (x != loc[1] + 4)
                                        { dungeon[loc[0], x, y] = Map.Passage; }
                                        else if ((dungeon[loc[0], x, y] == Map.Blank) &&
                                                 (dungeon[loc[0], x, y - 1] == Map.Blank) &&
                                                 (dungeon[loc[0], x, y + 1] == Map.Blank))
                                        {
                                            switch (Random.Range(1, 3))
                                            {
                                                case 1:
                                                    dungeon[loc[0], x, y] = Map.Door;
                                                    break;
                                                case 2:
                                                    dungeon[loc[0], x, y + 1] = Map.Door;
                                                    break;
                                            }
                                        }
                                    }
                                }
                            }

                        }
                        break;
                    case 1:
                        //-x
                        if ((loc[1] - 4) > 0)
                        {
                            for (int x = loc[1]; x >= loc[1] - 4; x--)
                            {
                                if (passWidth == 0)
                                {
                                    if (x != loc[1] - 4)
                                    { dungeon[loc[0], x, loc[2]] = Map.Passage; }
                                    else
                                        dungeon[loc[0], x, loc[2]] = Map.Door;
                                }
                                else
                                {
                                    for (int y = loc[2]; y < loc[2] + (2 * passWidth); y++)
                                    {
                                        if (x != loc[1] - 4)
                                        { dungeon[loc[0], x, y] = Map.Passage; }
                                        else if ((dungeon[loc[0], x, y] == Map.Blank) &&
                                                 (dungeon[loc[0], x, y - 1] == Map.Blank) &&
                                                 (dungeon[loc[0], x, y + 1] == Map.Blank))
                                        {
                                            dungeon[loc[0], x, y] = Map.Door;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 2:
                        //+y
                        if ((loc[2] + 4) <= mapDepth)
                        {
                            for (int y = loc[2]; y <= loc[2] + 4; y++)
                            {
                                if (passWidth == 0)
                                {
                                    if (y != loc[2] + 4)
                                    { dungeon[loc[0], loc[1], y] = Map.Passage; }
                                    else
                                        dungeon[loc[0], loc[1], y] = Map.Door;
                                }
                                else
                                {
                                    for (int x = loc[1]; x < loc[1] + (2 * passWidth); x++)
                                    {
                                        if (y != loc[2] + 4)
                                        { dungeon[loc[0], x, y] = Map.Passage; }
                                        else if ((dungeon[loc[0], x, y] == Map.Blank) &&
                                                 (dungeon[loc[0], x + 1, y] == Map.Blank) &&
                                                 (dungeon[loc[0], x - 1, y] == Map.Blank))
                                            switch (Random.Range(1, 3))
                                            {
                                                case 1:
                                                    dungeon[loc[0], x, y] = Map.Door;
                                                    break;
                                                case 2:
                                                    dungeon[loc[0], x + 1, y] = Map.Door;
                                                    break;
                                            }
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        //-y
                        if ((loc[2] - 4) > 0)
                        {
                            for (int y = loc[2]; y >= loc[2] - 4; y--)
                            {
                                if (passWidth == 0)
                                {
                                    if (y != loc[2] + 4)
                                    { dungeon[loc[0], loc[1], y] = Map.Passage; }
                                    else
                                        dungeon[loc[0], loc[1], y] = Map.Door;
                                }
                                else
                                {
                                    for (int x = loc[1]; x < loc[1] + (2 * passWidth); x++)
                                    {
                                        if (y != loc[2] - 4)
                                        { dungeon[loc[0], x, y] = Map.Passage; }
                                        else if ((dungeon[loc[0], x, y] == Map.Blank) &&
                                                 (dungeon[loc[0], x - 1, y] == Map.Blank) &&
                                                 (dungeon[loc[0], x + 1, y] == Map.Blank))
                                        {
                                            switch (Random.Range(1, 3))
                                            {
                                                case 1:
                                                    dungeon[loc[0], x, y] = Map.Door;
                                                    break;
                                                case 2:
                                                    dungeon[loc[0], x + 1, y] = Map.Door;
                                                    break;
                                            }
                                        }

                                    }
                                }
                            }
                        }
                        break;
                }
                break;
            case RoomID.PassPassRt:
                //Debug.Log("Rolled a passage with a passage on the right after 20 feet");
                switch (direction)
                {
                    case 0:
                        //+x
                        //Debug.Log("Going right");
                        if ((loc[1] + 6) <= mapWidth)
                        {
                            for (int x = loc[1]; x <= loc[1] + 5; x++)
                            {
                                if (passWidth == 0)
                                {
                                    dungeon[loc[0], x, loc[2]] = Map.Passage;
                                    if ((x == loc[1] + 3) && (dungeon[loc[0], x, loc[2] + 1] == Map.Blank))
                                    {
                                        //dungeon[loc[0], x, loc[2] + 1] = Map.PassageIP;
                                    }
                                }
                                else
                                {
                                    for (int y = loc[2]; y < loc[2] + (2 * passWidth); y++)
                                    {
                                        dungeon[loc[0], x, y] = Map.Passage;
                                        if ((x == loc[1] + 3) && (dungeon[loc[0], x, loc[2] + 2] == Map.Blank))
                                        {
                                            //dungeon[loc[0], x, loc[2] + 2] = Map.PassageIP;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 1:
                        //-x
                        //Debug.Log("Going left");
                        if ((loc[1] - 6) > 0)
                        {
                            for (int x = loc[1]; x >= loc[1] - 5; x--)
                            {
                                if (passWidth == 0)
                                {
                                    dungeon[loc[0], x, loc[2]] = Map.Passage;
                                    if ((x == loc[1] - 3) && (dungeon[loc[0], x, loc[2] - 1] == Map.Blank))
                                    {
                                        //dungeon[loc[0], x, loc[2] - 1] = Map.PassageIP;
                                    }
                                }
                                else
                                {
                                    for (int y = loc[2]; y < loc[2] + (2 * passWidth); y++)
                                    {
                                        dungeon[loc[0], x, y] = Map.Passage;
                                        if ((x == loc[1] - 3) && (dungeon[loc[0], x, loc[2] - 1] == Map.Blank))
                                        {
                                            //dungeon[loc[0], x, loc[2] - 1] = Map.PassageIP;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 2:
                        //+y
                        //Debug.Log("Going down");
                        if ((loc[2] + 6) <= mapDepth)
                        {
                            for (int y = loc[2]; y <= loc[2] + 5; y++)
                            {
                                if (passWidth == 0)
                                {
                                    dungeon[loc[0], loc[1], y] = Map.Passage;
                                    if ((y == loc[2] + 3) && (dungeon[loc[0], loc[1] - 1, y] == Map.Blank))
                                    {
                                        //dungeon[loc[0], loc[1] - 1, y] = Map.PassageIP;
                                    }
                                }
                                else
                                {
                                    for (int x = loc[1]; x < loc[1] + (2 * passWidth); x++)
                                    {
                                        dungeon[loc[0], x, y] = Map.Passage;
                                        if ((y == loc[2] + 3) && (dungeon[loc[0], loc[1] - 1, y] == Map.Blank))
                                        {
                                            //dungeon[loc[0], x - 1, y] = Map.PassageIP;

                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        //-y
                        //Debug.Log("Going up");
                        if ((loc[2] - 6) > 0)
                        {
                            for (int y = loc[2]; y >= loc[2] - 5; y--)
                            {
                                if (passWidth == 0)
                                {
                                    dungeon[loc[0], loc[1], y] = Map.Passage;
                                    if ((y == loc[1] - 3) && (dungeon[loc[0], loc[1] + 1, y] == Map.Blank))
                                    {
                                        //dungeon[loc[0], loc[1] + 1, y] = Map.PassageIP;
                                    }
                                }
                                else
                                {
                                    for (int x = loc[1]; x < loc[1] + (2 * passWidth); x++)
                                    {
                                        dungeon[loc[0], x, y] = Map.Passage;
                                        if ((y == loc[2] - 3) && (dungeon[loc[0], loc[1] + 2, y] == Map.Blank))
                                        {
                                            //dungeon[loc[0], x + 1, y] = Map.PassageIP;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                }
                break;
            case RoomID.PassPassLt:
                //Debug.Log("Rolled a passage with a passage on the left after 20 feet");
                switch (direction)
                {
                    case 0:
                        //+x
                        //Debug.Log("Going right");
                        if ((loc[1] + 6) <= mapWidth)
                        {
                            for (int x = loc[1]; x <= loc[1] + 5; x++)
                            {
                                if (passWidth == 0)
                                {
                                    dungeon[loc[0], x, loc[2]] = Map.Passage;
                                    if ((x == loc[1] + 3) && (dungeon[loc[0], x, loc[2] - 1] == Map.Blank))
                                    {
                                        dungeon[loc[0], x, loc[2] - 1] = Map.Passage;
                                    }
                                }
                                else
                                {
                                    for (int y = loc[2]; y < loc[2] + (2 * passWidth); y++)
                                    {
                                        dungeon[loc[0], x, y] = Map.Passage;
                                        if (loc[2] - 1 > 0)
                                        {
                                            if ((x == loc[1] + 3) && (dungeon[loc[0], x, loc[2] - 1] == Map.Blank))
                                            {
                                                dungeon[loc[0], x, loc[2] - 1] = Map.Passage;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 1:
                        //-x
                        //Debug.Log("Going left");
                        if ((loc[1] - 6) > 0)
                        {
                            for (int x = loc[1]; x >= loc[1] - 5; x--)
                            {
                                if (passWidth == 0)
                                {
                                    dungeon[loc[0], x, loc[2]] = Map.Passage;
                                    if ((x == loc[1] - 3) && (dungeon[loc[0], x, loc[2] + 1] == Map.Blank))
                                    {
                                        dungeon[loc[0], x, loc[2] + 1] = Map.Passage;
                                    }
                                }
                                else
                                {
                                    for (int y = loc[2]; y < loc[2] + (2 * passWidth); y++)
                                    {
                                        dungeon[loc[0], x, y] = Map.Passage;
                                        if ((x == loc[1] - 3) && (dungeon[loc[0], x, y + 1] == Map.Blank))
                                        {
                                            dungeon[loc[0], x, y + 1] = Map.Passage;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 2:
                        //+y
                        //Debug.Log("Going down");
                        if ((loc[2] + 6) <= mapDepth)
                        {
                            for (int y = loc[2]; y <= loc[2] + 5; y++)
                            {
                                if (passWidth == 0)
                                {
                                    dungeon[loc[0], loc[1], y] = Map.Passage;
                                    if ((y == loc[2] + 3) && (dungeon[loc[0], loc[1] + 1, y] == Map.Blank))
                                    {
                                        dungeon[loc[0], loc[1] + 1, y] = Map.Passage;
                                    }
                                }
                                else
                                {
                                    for (int x = loc[1]; x < loc[1] + (2 * passWidth); x++)
                                    {
                                        dungeon[loc[0], x, y] = Map.Passage;
                                        if ((y == loc[2] + 3) && (dungeon[loc[0], x + 1, y] == Map.Blank))
                                        {
                                            dungeon[loc[0], x + 1, y] = Map.Passage;

                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        //-y
                        //Debug.Log("Going up");
                        if ((loc[2] - 6) > 0)
                        {
                            for (int y = loc[2]; y >= loc[2] - 5; y--)
                            {
                                if (passWidth == 0)
                                {
                                    dungeon[loc[0], loc[1], y] = Map.Passage;
                                    if ((y == loc[1] - 3) && (dungeon[loc[0], loc[1] - 1, y] == Map.Blank))
                                    {
                                        dungeon[loc[0], loc[1] - 1, y] = Map.Passage;
                                    }
                                }
                                else
                                {
                                    for (int x = loc[1]; x < loc[1] + (2 * passWidth); x++)
                                    {
                                        dungeon[loc[0], x, y] = Map.Passage;
                                        if ((y == loc[2] - 3) && (dungeon[loc[0], loc[1] - 2, y] == Map.Blank))
                                        {
                                            dungeon[loc[0], x - 1, y] = Map.Passage;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                }
                break;
            case RoomID.ShortPassDE:
                //Debug.Log("Rolled a short passage with a dead end");
                switch (direction)
                {
                    case 0:
                        //+x
                        if ((loc[1] + 4) <= mapWidth)
                        {
                            for (int x = loc[1]; x <= loc[1] + 4; x++)
                            {
                                if (passWidth == 0)
                                {
                                    if (x != loc[1] + 4)
                                    { dungeon[loc[0], x, loc[2]] = Map.Passage; }
                                }
                                else
                                {
                                    for (int y = loc[2]; y < loc[2] + (2 * passWidth); y++)
                                    {
                                        if (x != loc[1] + 4)
                                        { dungeon[loc[0], x, y] = Map.Passage; }
                                    }
                                }
                            }
                        }
                        break;
                    case 1:
                        //-x
                        if ((loc[1] - 4) > 0)
                        {
                            for (int x = loc[1]; x >= loc[1] - 4; x--)
                            {
                                if (passWidth == 0)
                                {
                                    if (x != loc[1] - 4)
                                    { dungeon[loc[0], x, loc[2]] = Map.Passage; }
                                }
                                else
                                {
                                    for (int y = loc[2]; y < loc[2] + (2 * passWidth); y++)
                                    {
                                        if (x != loc[1] - 4)
                                        { dungeon[loc[0], x, y] = Map.Passage; }
                                    }
                                }
                            }
                        }
                        break;
                    case 2:
                        //+y
                        if ((loc[2] + 4) <= mapDepth)
                        {
                            for (int y = loc[2]; y <= loc[2] + 4; y++)
                            {
                                if (passWidth == 0)
                                {
                                    if (y != loc[2] + 4)
                                    { dungeon[loc[0], loc[1], y] = Map.Passage; }
                                }
                                else
                                {
                                    for (int x = loc[1]; x < loc[1] + (2 * passWidth); x++)
                                    {
                                        if (y != loc[2] + 4)
                                        { dungeon[loc[0], x, y] = Map.Passage; }
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        //-y
                        if ((loc[2] - 4) > 0)
                        {
                            for (int y = loc[2]; y >= loc[2] - 4; y--)
                            {
                                if (passWidth == 0)
                                {
                                    if (y != loc[2] + 4)
                                    { dungeon[loc[0], loc[1], y] = Map.Passage; }
                                }
                                else
                                {
                                    for (int x = loc[1]; x < loc[1] + (2 * passWidth); x++)
                                    {
                                        if (y != loc[2] - 4)
                                        { dungeon[loc[0], x, y] = Map.Passage; }
                                    }
                                }
                            }
                        }
                        break;
                }
                break;
            case RoomID.LPassLt:
                //Debug.Log("Rolled an L-shaped passage to the left");
                switch (direction)
                {
                    case 0:
                        //+x
                        //Debug.Log("Going right");
                        if (((loc[1] + 6) <= mapWidth) && ((loc[2] - 2) >= 0))
                        {
                            for (int x = loc[1]; x <= loc[1] + 5; x++)
                            {
                                if (passWidth == 0)
                                {
                                    if (x <= loc[1] + 3)
                                    {
                                        if (x != loc[1] + 6)
                                        { dungeon[loc[0], x, loc[2]] = Map.Passage; }
                                    }
                                    else if (x < loc[1] + 5)
                                    {
                                        dungeon[loc[0], x - 1, loc[2]] = Map.Passage;
                                        dungeon[loc[0], x, loc[2] - 2] = Map.Passage;
                                        dungeon[loc[0], x, loc[2] - 1] = Map.Passage;
                                        if (loc[2] - 3 > 0)
                                        {
                                            //dungeon[loc[0], x, loc[2] - 3] = Map.PassageIP;
                                        }
                                    }
                                }
                                else
                                {
                                    if (x <= loc[1] + 3)
                                    {
                                        for (int y = loc[2]; y < loc[2] + (2 * passWidth); y++)
                                        {
                                            if (x != loc[1] + 6)
                                            { dungeon[loc[0], x, y] = Map.Passage; }
                                        }
                                    }
                                    else
                                    {
                                        for (int y = loc[2] - 2; y < loc[2] + (2 * passWidth); y++)
                                        {
                                            dungeon[loc[0], x, y] = Map.Passage;
                                        }
                                        if (loc[2] - 3 > 0)
                                        {
                                            //dungeon[loc[0], x, loc[2] - 3] = Map.PassageIP;
                                        }
                                    }
                                }
                            }

                        }
                        break;
                    case 1:
                        //-x
                        //Debug.Log("Going left");
                        if ((loc[1] - 6) > 0)
                        {
                            for (int x = loc[1]; x >= loc[1] - 5; x--)
                            {
                                if (passWidth == 0)
                                {
                                    if (x != loc[1] - 5)
                                    { dungeon[loc[0], x, loc[2]] = Map.Passage; }
                                    if (x == loc[1] - 4)
                                    {
                                        dungeon[loc[0], x, loc[2] + 1] = Map.Passage;
                                        dungeon[loc[0], x, loc[2] + 2] = Map.Passage;
                                        //dungeon[loc[0], x, loc[2] + 3] = Map.PassageIP;
                                    }
                                }
                                else
                                {
                                    if (x > loc[1] - 4)
                                    {
                                        for (int y = loc[2]; y < loc[2] + (2 * passWidth); y++)
                                        {
                                            dungeon[loc[0], x, y] = Map.Passage;
                                        }
                                    }
                                    else
                                    {
                                        for (int y = loc[2]; y < loc[2] + (2 * passWidth) + 2; y++)
                                        {
                                            dungeon[loc[0], x, y] = Map.Passage;
                                        }
                                        //dungeon[loc[0], x, loc[2] + 3] = Map.PassageIP;
                                    }
                                }
                            }
                        }
                        break;
                    case 2:
                        //+y
                        //Debug.Log("Going down");
                        if ((loc[2] + 6) <= mapDepth)
                        {
                            for (int y = loc[2]; y <= loc[2] + 5; y++)
                            {
                                if (passWidth == 0)
                                {
                                    if (y != loc[2] + 5)
                                    { dungeon[loc[0], loc[1], y] = Map.Passage; }
                                    else
                                    {
                                        dungeon[loc[0], loc[1], y] = Map.Passage;
                                        dungeon[loc[0], loc[1], y + 1] = Map.Passage;
                                        dungeon[loc[0], loc[1], y + 2] = Map.Passage;
                                        //dungeon[loc[0],loc[1],y + 3] = Map.PassageIP;
                                    }
                                }
                                else
                                {
                                    if (y < loc[2] + 4)
                                    {
                                        for (int x = loc[1]; x < loc[1] + (2 * passWidth); x++)
                                        {
                                            dungeon[loc[0], x, y] = Map.Passage;
                                        }
                                    }
                                    else
                                    {
                                        for (int x = loc[1]; x < loc[1] + (2 * passWidth) + 2; x++)
                                        {
                                            dungeon[loc[0], x, y] = Map.Passage;
                                        }
                                        //dungeon[loc[0], loc[1] + (2 * passWidth) + 3, y] = Map.PassageIP;
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        //-y
                        //Debug.Log("Going up");
                        if ((loc[2] - 6) > 0)
                        {
                            for (int y = loc[2]; y >= loc[2] - 5; y--)
                            {
                                if (passWidth == 0)
                                {
                                    if (y < loc[2] - 5)
                                    {
                                        dungeon[loc[0], loc[1], y] = Map.Passage;
                                        if (y == loc[2] - 4)
                                        {
                                            dungeon[loc[0], loc[1] - 2, y] = Map.Passage;
                                            dungeon[loc[0], loc[1] - 1, y] = Map.Passage;
                                            //dungeon[loc[0], loc[1] - 3, y] = Map.PassageIP;
                                        }
                                    }
                                }
                                else
                                {
                                    if (y < loc[2] - 4)
                                    {
                                        for (int x = loc[1]; x < loc[1] + (2 * passWidth); x++)
                                        {
                                            dungeon[loc[0], x, y] = Map.Passage;
                                        }
                                    }
                                    else
                                    {
                                        for (int x = loc[1] - 3; x < loc[1] + (2 * passWidth); x++)
                                        {
                                            if (x == loc[1] - 3)
                                            {
                                                //dungeon[loc[0], x, y] = Map.PassageIP;
                                            }
                                            else
                                                dungeon[loc[0], x, y] = Map.Passage;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                }
                break;
            case RoomID.LPassRt:
                //Debug.Log("Rolled an L-shaped passage to the right");
                switch (direction)
                {
                    case 0:
                        //+x
                        if (((loc[1] + 6) <= mapWidth) && (loc[2] + 4 <= mapDepth))
                        {
                            if (passWidth == 0)
                            {
                                for (int x = loc[1]; x < loc[1] + 5; x++)
                                {
                                    if (x < loc[1] + 4)
                                    {
                                        dungeon[loc[0], x, loc[2]] = Map.Passage;
                                    }
                                    else
                                    {
                                        for (int y = loc[2]; y < loc[2] + 4; y++)
                                        {
                                            if (y < loc[2] + 3)
                                            { dungeon[loc[0], x, y] = Map.Passage; }
                                            else
                                                dungeon[loc[0], x, y] = Map.PassageIP;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                for (int x = loc[1]; x < loc[1] + 6; x++)
                                {
                                    if (x < loc[1] + 4)
                                    {
                                        for (int y = loc[2] - passWidth / 2; y < loc[2] + passWidth / 2 + 2; y++)
                                        {
                                            dungeon[loc[0], x, y] = Map.Passage;
                                        }
                                    }
                                    else
                                    {
                                        for (int y = loc[2] - passWidth / 2; y < loc[2] + passWidth / 2 + 5; y++)
                                        {
                                            if (y < loc[2] + passWidth / 2 + 4)
                                            { dungeon[loc[0], x, y] = Map.Passage; }
                                            else
                                                dungeon[loc[0], x, y] = Map.PassageIP;
                                        }
                                    }
                                } }
                        }
                        break;
                    case 1:
                        //-x
                        if (((loc[1] - 6) >= 0) && (loc[2] - 3 >= 0))
                        {
                            if (passWidth == 0)
                            {
                                for (int x = loc[1]; x > loc[1] - 5; x--)
                                {
                                    if (x > loc[1] - 4)
                                    {
                                        dungeon[loc[0], x, loc[2]] = Map.Passage;
                                    }
                                    else
                                    {
                                        for (int y = loc[2]; y > loc[2] - 4; y--)
                                        {
                                            if (y > loc[2] - 3)
                                            {
                                                dungeon[loc[0], x, y] = Map.Passage;
                                            }
                                            else
                                                dungeon[loc[0], x, y] = Map.PassageIP;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                for (int x = loc[1]; x > loc[1] - 6; x--)
                                {
                                    if (x > loc[1] - 4)
                                    {
                                        for (int y = loc[2] - passWidth / 2; y < loc[2] + passWidth / 2 + 2; y++)
                                        {
                                            dungeon[loc[0], x, y] = Map.Passage;
                                        }
                                    }
                                    else
                                    {
                                        for (int y = loc[2] - 3; y < loc[2] + passWidth / 2 + 2; y++)
                                        {
                                            if (y != loc[2] - 3)
                                            {
                                                dungeon[loc[0], x, y] = Map.Passage;
                                            }
                                            else
                                                dungeon[loc[0], x, y] = Map.PassageIP;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 2:
                        //+y
                        if (((loc[1] - 4) >= 0) && (loc[2] + 6 <= mapDepth))
                        {
                            if (passWidth == 0)
                            {
                                for (int y = loc[2]; y < loc[2] + 5; y++)
                                {
                                    if (y < loc[2] + 4)
                                    {
                                        dungeon[loc[0], loc[1], y] = Map.Passage;
                                    }
                                    else
                                    {
                                        for (int x = loc[1]; x > loc[1] - 4; x--)
                                        {
                                            if (x > loc[1] - 3)
                                            {
                                                dungeon[loc[0], x, y] = Map.Passage;
                                            }
                                            else
                                                dungeon[loc[0], x, y] = Map.PassageIP;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                for (int y = loc[2]; y < loc[2] + 6; y++)
                                {
                                    if (y < loc[2] + 4)
                                    {
                                        for (int x = loc[1] + passWidth / 2 + 1; x > loc[1] - passWidth / 2 - 1; x--)
                                        {
                                            dungeon[loc[0], x, y] = Map.Passage;
                                        }
                                    }
                                    else
                                    {
                                        for (int x = loc[1] + passWidth / 2 + 1; x > loc[1] - passWidth / 2 - 4; x--)
                                        {
                                            if (x != loc[1] - passWidth / 2 - 3)
                                            {
                                                dungeon[loc[0], x, y] = Map.Passage;
                                            }
                                            else
                                                dungeon[loc[0], x, y] = Map.PassageIP;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        //-y
                        if (((loc[1] + 4) <= mapWidth) && (loc[2] - 6 >= 0))
                        {
                            if (passWidth == 0)
                            {
                                for (int y = loc[2]; y > loc[2] - 5; y--)
                                {
                                    if (y > loc[2] - 4)
                                    {
                                        dungeon[loc[0], loc[1], y] = Map.Passage;
                                    }
                                    else
                                    {
                                        for (int x = loc[1]; x < loc[1] + 4; x++)
                                        {
                                            if (x != loc[1] + 3)
                                            {
                                                dungeon[loc[0], x, y] = Map.Passage;
                                            }
                                            else
                                                dungeon[loc[0], x, y] = Map.PassageIP;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                for (int y = loc[2]; y > loc[2] - 6; y--)
                                {
                                    if (y < loc[2] - 4)
                                    {
                                        for (int x = loc[1] - passWidth / 2; x < loc[1] + passWidth / 2 + 1; x++)
                                        {
                                            dungeon[loc[0], x, y] = Map.Passage;
                                        }
                                    }
                                    else
                                    {
                                        for (int x = loc[1] - passWidth / 2; x < loc[1] + passWidth / 2 + 3; x++)
                                        {
                                            if (x != loc[1] + passWidth / 2 + 2)
                                            {
                                                dungeon[loc[0], x, y] = Map.Passage;
                                            }
                                            else
                                                dungeon[loc[0], x, y] = Map.PassageIP;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                }
                break;
            case RoomID.Stair:
                //Debug.Log("Rolled stairs at " + loc[0] + " " + loc[1] + " " + loc[2]);
                dungeon[loc[0], loc[1], loc[2]] = Map.Stairs;
                break;
            default:
                //Debug.Log("Rolled a chamber");
                RoomID chamber = RollChamber();
                //Debug.Log(chamber);
                int attempts = 1;
                int exits = Random.Range(1, 20);

                while (!Valid(loc, direction, chamber, 0))
                {
                    if (attempts <= 10)
                    {
                        Debug.Log("Trying again...");
                        chamber = RollChamber();
                        attempts++;
                    }
                    else
                        goto END;
                }
                switch (direction)
                {
                    case 0:
                        //+x
                        switch (chamber)
                        {
                            case RoomID.Chm2020:
                                for (int x = loc[1] + 1; x < loc[1] + 5; x++)
                                    for (int y = loc[2] - 1; y < loc[2] + 3; y++)
                                        dungeon[loc[0], x, y] = Map.Room;
                                break;
                            case RoomID.Chm2030:
                                if (loc[1] + 7 <= mapWidth)
                                {
                                    for (int x = loc[1] + 1; x < loc[1] + 7; x++)
                                        for (int y = loc[2] - 1; y < loc[2] + 3; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                else
                                {
                                    for (int x = loc[1] + 1; x < loc[1] + 5; x++)
                                        for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                break;
                            case RoomID.Chm3030:
                                for (int x = loc[1] + 1; x < loc[1] + 7; x++)
                                    for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                        dungeon[loc[0], x, y] = Map.Room;
                                break;
                            case RoomID.Chm3040:
                                if (loc[1] + 9 <= mapWidth)
                                {
                                    for (int x = loc[1] + 1; x < loc[1] + 9; x++)
                                        for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                else
                                {
                                    for (int x = loc[1] + 1; x < loc[1] + 7; x++)
                                        for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                break;
                            case RoomID.Chm4040:
                                for (int x = loc[1] + 1; x < loc[1] + 9; x++)
                                    for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                        dungeon[loc[0], x, y] = Map.Room;
                                break;
                            case RoomID.Chm4050:
                                if (loc[1] + 11 <= mapWidth)
                                {
                                    for (int x = loc[1] + 1; x < loc[1] + 11; x++)
                                        for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                else
                                {
                                    for (int x = loc[1] + 1; x < loc[1] + 7; x++)
                                        for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                break;
                            case RoomID.Chm5080:
                                if (loc[1] + 17 <= mapWidth)
                                {
                                    for (int x = loc[1] + 1; x < loc[1] + 17; x++)
                                        for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                else
                                {
                                    for (int x = loc[1] + 1; x < loc[1] + 10; x++)
                                        for (int y = loc[2] - 7; y < loc[2] + 9; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                break;
                            case RoomID.ChmCr30:
                                for (int x = loc[1] + 1; x < loc[1] + 7; x++)
                                {
                                    if ((x == loc[1] + 1) || (x == loc[1] + 6))
                                    {
                                        for (int y = loc[2] - 1; y < loc[2] + 3; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                    {
                                        for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                }
                                break;
                            case RoomID.ChmCr50:
                                for (int x = loc[1] + 1; x < loc[1] + 11; x++)
                                {
                                    if ((x == loc[1] + 1) || (x == loc[1] + 10))
                                    {
                                        for (int y = loc[2] - 2; y < loc[2] + 3; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if ((x == loc[1] + 2) || (x == loc[1] + 3) || (x == loc[1] + 9) || (x == loc[1] + 8))
                                    {
                                        for (int y = loc[2] - 3; y < loc[2] + 4; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                        for (int y = loc[2] - 4; y < loc[2] + 5; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                break;
                            case RoomID.ChmOct40:
                                for (int x = loc[1] + 1; x < loc[1] + 9; x++)
                                {
                                    if ((x == loc[1] + 1) || (x == loc[1] + 8))
                                    {
                                        for (int y = loc[2] - 1; y < loc[2] + 3; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if ((x == loc[1] + 2) || (x == loc[1] + 7))
                                    {
                                        for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                    {
                                        for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                }
                                break;
                            case RoomID.ChmOct60:
                                for (int x = loc[1] + 1; x < loc[1] + 13; x++)
                                {
                                    if ((x == loc[1] + 1) || (x == loc[1] + 12))
                                    {
                                        for (int y = loc[2] - 1; y < loc[2] + 3; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if ((x == loc[1] + 2) || (x == loc[1] + 11))
                                    {
                                        for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if ((x == loc[2] + 3) || (x == loc[1] + 10))
                                    {
                                        for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                    {
                                        for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                }
                                break;
                            case RoomID.ChmTrp:
                                for (int x = loc[1] + 1; x < loc[1] + 9; x++)
                                {
                                    if (x < loc[1] + 3)
                                    {
                                        for (int y = loc[2] - 5; y < loc[2] + 7; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if (x < loc[1] + 5)
                                    {
                                        for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if (x < loc[1] + 7)
                                    {
                                        for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if (x < loc[1] + 8)
                                    {
                                        for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                    {
                                        for (int y = loc[2] - 1; y < loc[2] + 3; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                }
                                break;
                        }
                        break;
                    case 1:
                        //-x
                        switch (chamber)
                        {
                            case RoomID.Chm2020:
                                for (int x = loc[1] - 1; x > loc[1] - 5; x--)
                                    for (int y = loc[2] - 1; y < loc[2] + 3; y++)
                                        dungeon[loc[0], x, y] = Map.Room;
                                break;
                            case RoomID.Chm2030:
                                if (loc[1] - 7 >= mapWidth)
                                {
                                    for (int x = loc[1] - 1; x > loc[1] - 7; x--)
                                        for (int y = loc[2] - 1; y < loc[2] + 3; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                else
                                {
                                    for (int x = loc[1] - 1; x > loc[1] - 5; x--)
                                        for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                break;
                            case RoomID.Chm3030:
                                for (int x = loc[1] - 1; x > loc[1] - 7; x--)
                                    for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                        dungeon[loc[0], x, y] = Map.Room;
                                break;
                            case RoomID.Chm3040:
                                if (loc[1] - 9 >= mapWidth)
                                {
                                    for (int x = loc[1] - 1; x > loc[1] - 9; x--)
                                        for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                else
                                {
                                    for (int x = loc[1] - 1; x > loc[1] - 7; x--)
                                        for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                break;
                            case RoomID.Chm4040:
                                for (int x = loc[1] - 1; x > loc[1] - 9; x--)
                                    for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                        dungeon[loc[0], x, y] = Map.Room;
                                break;
                            case RoomID.Chm4050:
                                if (loc[1] - 11 >= mapWidth)
                                {
                                    for (int x = loc[1] - 1; x > loc[1] - 11; x--)
                                        for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                else
                                {
                                    for (int x = loc[1] - 1; x > loc[1] - 7; x--)
                                        for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                break;
                            case RoomID.Chm5080:
                                if (loc[1] - 17 >= mapWidth)
                                {
                                    for (int x = loc[1] - 1; x > loc[1] - 17; x--)
                                        for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                else
                                {
                                    for (int x = loc[1] - 1; x > loc[1] - 10; x--)
                                        for (int y = loc[2] - 7; y < loc[2] + 9; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                break;
                            case RoomID.ChmCr30:
                                for (int x = loc[1] - 1; x > loc[1] - 7; x--)
                                {
                                    if ((x == loc[1] - 1) || (x == loc[1] - 6))
                                    {
                                        for (int y = loc[2] - 1; y < loc[2] + 3; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                    {
                                        for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                }
                                break;
                            case RoomID.ChmCr50:
                                for (int x = loc[1] - 1; x > loc[1] - 11; x--)
                                {
                                    if ((x == loc[1] - 1) || (x == loc[1] - 10))
                                    {
                                        for (int y = loc[2] - 2; y < loc[2] + 3; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if ((x == loc[1] - 2) || (x == loc[1] - 3) || (x == loc[1] - 9) || (x == loc[1] - 8))
                                    {
                                        for (int y = loc[2] - 3; y < loc[2] + 4; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                        for (int y = loc[2] - 4; y < loc[2] + 5; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                break;
                            case RoomID.ChmOct40:
                                for (int x = loc[1] - 1; x > loc[1] - 9; x--)
                                {
                                    if ((x == loc[1] - 1) || (x == loc[1] - 8))
                                    {
                                        for (int y = loc[2] - 1; y < loc[2] + 3; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if ((x == loc[1] - 2) || (x == loc[1] - 7))
                                    {
                                        for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                    {
                                        for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                }
                                break;
                            case RoomID.ChmOct60:
                                for (int x = loc[1] - 1; x > loc[1] - 13; x--)
                                {
                                    if ((x == loc[1] - 1) || (x == loc[1] - 12))
                                    {
                                        for (int y = loc[2] - 1; y < loc[2] + 3; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if ((x == loc[1] - 2) || (x == loc[1] - 11))
                                    {
                                        for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if ((x == loc[2] - 3) || (x == loc[1] - 10))
                                    {
                                        for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                    {
                                        for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                }
                                break;
                            case RoomID.ChmTrp:
                                for (int x = loc[1] - 1; x > loc[1] - 9; x--)
                                {
                                    if (x > loc[1] - 3)
                                    {
                                        for (int y = loc[2] - 5; y < loc[2] + 7; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if (x > loc[1] - 5)
                                    {
                                        for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if (x > loc[1] - 7)
                                    {
                                        for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if (x > loc[1] - 8)
                                    {
                                        for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                    {
                                        for (int y = loc[2] - 1; y < loc[2] + 3; y++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                }
                                break;
                        }
                        break;
                    case 2:
                        //+y
                        switch (chamber)
                        {
                            case RoomID.Chm2020:
                                for (int y = loc[2] + 1; y < loc[2] + 5; y++)
                                    for (int x = loc[1] - 1; x < loc[1] + 3; x++)
                                        dungeon[loc[0], x, y] = Map.Room;
                                break;
                            case RoomID.Chm2030:
                                if (loc[2] + 7 <= mapDepth)
                                {
                                    for (int y = loc[2] + 1; y < loc[2] + 7; y++)
                                        for (int x = loc[1] - 1; x < loc[1] + 3; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                else
                                {
                                    for (int y = loc[2] + 1; y < loc[2] + 5; y++)
                                        for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                break;
                            case RoomID.Chm3030:
                                for (int y = loc[2] + 1; y < loc[2] + 7; y++)
                                    for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                        dungeon[loc[0], x, y] = Map.Room;
                                break;
                            case RoomID.Chm3040:
                                if (loc[2] + 9 <= mapDepth)
                                {
                                    for (int y = loc[2] + 1; y < loc[2] + 9; y++)
                                        for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                else
                                {
                                    for (int y = loc[2] + 1; y < loc[2] + 7; y++)
                                        for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                break;
                            case RoomID.Chm4040:
                                for (int y = loc[2] + 1; y < loc[2] + 9; y++)
                                    for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                        dungeon[loc[0], x, y] = Map.Room;
                                break;
                            case RoomID.Chm4050:
                                if (loc[2] + 11 <= mapDepth)
                                {
                                    for (int y = loc[2] + 1; y < loc[2] + 11; y++)
                                        for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                else
                                {
                                    for (int y = loc[2] + 1; y < loc[2] + 9; y++)
                                        for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                break;
                            case RoomID.Chm5080:
                                if (loc[2] + 17 <= mapDepth)
                                {
                                    for (int y = loc[2] + 1; y < loc[2] + 17; y++)
                                        for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                else
                                {
                                    for (int y = loc[2] + 1; y < loc[2] + 11; y++)
                                        for (int x = loc[1] - 7; x < loc[1] + 9; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                break;
                            case RoomID.ChmCr30:
                                for (int y = loc[2] + 1; y < loc[2] + 7; y++)
                                {
                                    if ((y == loc[2] + 1) || (y == loc[2] + 6))
                                    {
                                        for (int x = loc[1] - 1; x < loc[1] + 3; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                    {
                                        for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                }
                                break;
                            case RoomID.ChmCr50:
                                for (int y = loc[2] + 1; y < loc[2] + 11; y++)
                                {
                                    if ((y == loc[2] + 1) || (y == loc[1] + 10))
                                    {
                                        for (int x = loc[1] - 1; x < loc[1] + 3; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if ((y == loc[2] + 2) || (y == loc[2] + 3) || (y == loc[2] + 8) || (y == loc[2] + 9))
                                    {
                                        for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                    {
                                        for (int x = loc[1] - 3; x < loc[2] + 5; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                }
                                break;
                            case RoomID.ChmOct40:
                                for (int y = loc[2] + 1; y < loc[2] + 9; y++)
                                {
                                    if ((y == loc[2] + 1) || (y == loc[2] + 8))
                                    {
                                        for (int x = loc[1] - 1; x < loc[1] + 3; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if ((y == loc[2] + 2) || (y == loc[2] + 7))
                                    {
                                        for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                    {
                                        for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                }
                                break;
                            case RoomID.ChmOct60:
                                for (int y = loc[2] + 1; y < loc[2] + 13; y++)
                                {
                                    if ((y == loc[2] + 1) || (y == loc[2] + 12))
                                    {
                                        for (int x = loc[1] - 1; x < loc[1] + 3; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if ((y == loc[2] + 2) || (y == loc[2] + 11))
                                    {
                                        for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if ((y == loc[2] + 3) || (y == loc[2] + 10))
                                    {
                                        for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                    {
                                        for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                }
                                break;
                            case RoomID.ChmTrp:
                                for (int y = loc[1] + 1; y < loc[2] + 9; y++)
                                {
                                    if (y < loc[2] + 3)
                                    {
                                        for (int x = loc[1] - 5; x < loc[1] + 7; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if (y < loc[2] + 5)
                                    {
                                        for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if (y < loc[2] + 7)
                                    {
                                        for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if (y < loc[2] + 8)
                                    {
                                        for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                    {
                                        for (int x = loc[1] - 1; x < loc[1] + 3; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                }
                                break;
                        }
                        break;
                    case 3:
                        //-y
                        switch (chamber)
                        {
                            case RoomID.Chm2020:
                                for (int y = loc[2] - 1; y > loc[2] - 5; y--)
                                    for (int x = loc[1] - 1; x < loc[1] + 3; x++)
                                        dungeon[loc[0], x, y] = Map.Room;
                                break;
                            case RoomID.Chm2030:
                                if (loc[2] - 7 >= mapDepth)
                                {
                                    for (int y = loc[2] - 1; y > loc[2] - 7; y--)
                                        for (int x = loc[1] - 1; x < loc[1] + 3; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                else
                                {
                                    for (int y = loc[2] - 1; y > loc[2] - 5; y--)
                                        for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                break;
                            case RoomID.Chm3030:
                                for (int y = loc[2] - 1; y > loc[2] - 7; y--)
                                    for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                        dungeon[loc[0], x, y] = Map.Room;
                                break;
                            case RoomID.Chm3040:
                                if (loc[2] - 9 >= mapDepth)
                                {
                                    for (int y = loc[2] - 1; y > loc[2] - 9; y--)
                                        for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                else
                                {
                                    for (int y = loc[2] - 1; y > loc[2] - 7; y--)
                                        for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                break;
                            case RoomID.Chm4040:
                                for (int y = loc[2] - 1; y > loc[2] - 9; y--)
                                    for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                        dungeon[loc[0], x, y] = Map.Room;
                                break;
                            case RoomID.Chm4050:
                                if (loc[2] - 11 >= mapDepth)
                                {
                                    for (int y = loc[2] - 1; y > loc[2] - 11; y--)
                                        for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                else
                                {
                                    for (int y = loc[2] - 1; y > loc[2] - 9; y--)
                                        for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                break;
                            case RoomID.Chm5080:
                                if (loc[2] - 17 >= mapDepth)
                                {
                                    for (int y = loc[2] - 1; y > loc[2] - 17; y--)
                                        for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                else
                                {
                                    for (int y = loc[2] - 1; y > loc[2] - 11; y--)
                                        for (int x = loc[1] - 7; x < loc[1] + 9; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                }
                                break;
                            case RoomID.ChmCr30:
                                for (int y = loc[2] - 1; y > loc[2] - 7; y--)
                                {
                                    if ((y == loc[2] - 1) || (y == loc[2] - 6))
                                    {
                                        for (int x = loc[1] - 1; x < loc[1] + 3; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                    {
                                        for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                }
                                break;
                            case RoomID.ChmCr50:
                                for (int y = loc[2] - 1; y > loc[2] - 11; y--)
                                {
                                    if ((y == loc[2] - 1) || (y == loc[1] - 10))
                                    {
                                        for (int x = loc[1] - 1; x < loc[1] + 3; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if ((y == loc[2] - 2) || (y == loc[2] - 3) || (y == loc[2] - 8) || (y == loc[2] - 9))
                                    {
                                        for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                    {
                                        for (int x = loc[1] - 3; x < loc[2] + 5; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                }
                                break;
                            case RoomID.ChmOct40:
                                for (int y = loc[2] - 1; y > loc[2] - 9; y--)
                                {
                                    if ((y == loc[2] - 1) || (y == loc[2] - 8))
                                    {
                                        for (int x = loc[1] - 1; x < loc[1] + 3; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if ((y == loc[2] - 2) || (y == loc[2] - 7))
                                    {
                                        for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                    {
                                        for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                }
                                break;
                            case RoomID.ChmOct60:
                                for (int y = loc[2] - 1; y > loc[2] - 13; y--)
                                {
                                    if ((y == loc[2] - 1) || (y == loc[2] - 12))
                                    {
                                        for (int x = loc[1] - 1; x < loc[1] + 3; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if ((y == loc[2] - 2) || (y == loc[2] - 11))
                                    {
                                        for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if ((y == loc[2] - 3) || (y == loc[2] - 10))
                                    {
                                        for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                    {
                                        for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                }
                                break;
                            case RoomID.ChmTrp:
                                for (int y = loc[1] - 1; y > loc[2] - 9; y--)
                                {
                                    if (y > loc[2] - 3)
                                    {
                                        for (int x = loc[1] - 5; x < loc[1] + 7; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if (y > loc[2] - 5)
                                    {
                                        for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if (y > loc[2] - 7)
                                    {
                                        for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else if (y > loc[2] - 8)
                                    {
                                        for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                    else
                                    {
                                        for (int x = loc[1] - 1; x < loc[1] + 3; x++)
                                            dungeon[loc[0], x, y] = Map.Room;
                                    }
                                }
                                break;
                        }
                        break;
                }
                break;
                #endregion
        }

    END:
        dungeon[loc[0], loc[1], loc[2]] = Map.Passage;
    }
*/
    int PassWidth(int die)
    {
        int width = 5;
        switch (Random.Range(1, die + 1))
        {
            case 1:
            case 2:
                //Debug.Log("Passage width: 5");
                width = 1;
                break;
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
                //Debug.Log("Passage Width: 10");
                width = 2;
                break;
            case 13:
            case 14:
                //Debug.Log("Passage Width: 20");
                width = 4;
                break;
            case 15:
            case 16:
                //Debug.Log("Passage Width: 30");
                width = 6;
                break;
            case 17:
                //Debug.Log("Passage Width: 40");
                width = 8;
                break;
            case 18:
                //Debug.Log("Passage Width: 40");
                width = 8;
                break;
            case 19:
                //Debug.Log("Passage Width: 40");
                width = 8;
                break;
            case 20:
                //Debug.Log("Passage Width: 40");
                width = 8;
                break;
        }

        return width;
    }

    RoomID RollChamber() {
        switch(Random.Range(1, 21))
        {
            case 3:
            case 4:
                return RoomID.Chm3030;
            case 5:
            case 6:
                return RoomID.Chm4040;
            case 7:
            case 8:
            case 9:
                return RoomID.Chm2030;
            case 10:
            case 11:
            case 12:
                return RoomID.Chm3040;
            case 13:
            case 14:
                return RoomID.Chm4050;
            case 15:
                return RoomID.Chm5080;
            case 16:
                return RoomID.ChmCr30;
            case 17:
                return RoomID.ChmCr50;
            case 18:
                return RoomID.ChmOct40;
            case 19:
                return RoomID.ChmOct60;
            case 20:
                return RoomID.ChmTrp;
            default:
                return RoomID.Chm2020;
        }
    } 

    void RollExit(int[] loc)
    {

    }

    Map RollDoor() {

        switch (Random.Range(1, 21))
        {
            case 11:
            case 12:
                return Map.WoodDoorL;
            case 13:
                return Map.StoneDoor;
            case 14:
                return Map.StoneDoorL;
            case 15:
                return Map.IronDoor;
            case 16:
                return Map.IronDoorL;
            case 17:
                return Map.Portcullis;
            case 18:
                return Map.PortcullisL;
            case 19:
                return Map.SecretDoor;
            case 20:
                return Map.SecretDoorL;
            default:
                return Map.WoodDoor;
        }
    }

    void RollEnterance(int enter, int floor) {
        //switch (Random.Range(1,11))
        switch (Random.Range(1,11))
        {
            #region Case 1
            case 1:
                //Debug.Log("Rolled enterance 1");
                for (int x = enter - 1; x < enter + 3; x++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        dungeon[floor, x, y] = Map.Room;
                    }
                }

                dungeon[floor, enter - 2, 2] = Map.PassageIP;
                dungeon[floor, enter + 3, 2] = Map.PassageIP;
                dungeon[floor, enter, 4] = Map.PassageIP;
                break;
            #endregion
            #region Case 2
            case 2:
                //Debug.Log("Rolled enterance 2");
                for (int x = enter -1; x < enter +3; x++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        dungeon[floor, x, y] = Map.Room;
                    }
                }

                switch (Random.Range(0, 3))
                {
                    case 0:
                        dungeon[floor, enter - 2, 2] = Map.Door;                        

                        dungeon[floor, enter + 3, 2] = Map.Door;

                        dungeon[floor, enter + 0, 4] = Map.PassageIP;
                        break;
                    case 1:
                        dungeon[floor, enter - 2, 2] = Map.Door;

                        dungeon[floor, enter + 3, 2] = Map.PassageIP;

                        dungeon[floor, enter + 0, 4] = Map.Door;
                        break;
                    case 2:
                        dungeon[floor, enter - 2, 2] = Map.PassageIP;

                        dungeon[floor, enter + 3, 2] = Map.Door;

                        dungeon[floor, enter + 0, 4] = Map.Door;
                        break;
                }
                break;
            #endregion
            #region Case 3
            case 3:
                //Debug.Log("Rolled enterance 3");
                for (int x = enter - 3; x < enter + 5; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        dungeon[floor, x, y] = Map.Room;
                    }
                }
                dungeon[floor, enter - 4, 3] = Map.Door;
                dungeon[floor, enter + 5, 3] = Map.Door;
                dungeon[floor, enter + 0, 8] = Map.Door;
                break;
            #endregion
            #region Case 4
            case 4:
                //Debug.Log("Rolled enterance 4");
                for (int x = enter - 7; x < enter + 9; x++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        dungeon[floor, x, y] = Map.Room;
                    }
                }

                dungeon[floor, enter - 4, 4] = Map.PassageIP;
                dungeon[floor, enter + 4, 4] = Map.PassageIP;

                dungeon[floor, enter - 8, 2] = Map.Door;
                dungeon[floor, enter + 9, 2] = Map.Door;
                break;
            #endregion
            #region Case 5
            case 5:
                //Debug.Log("Rolled enterance 5");
                for (int x = enter - 1; x < enter + 3; x++)
                {
                    for (int y = 0; y < 8; y++)
                    {
                        dungeon[floor, x, y] = Map.Room;
                    }
                }

                dungeon[floor, enter - 2, 3] = Map.PassageIP;
                dungeon[floor, enter + 3, 3] = Map.PassageIP;
                dungeon[floor, enter + 0, 8] = Map.PassageIP;
                break;
                #endregion
            #region Case 6
            case 6:
                //Debug.Log("Rolled enterance 6");
                for (int x = enter - 3; x < enter +5; x++)
                {
                    if ((x == enter - 3) || (x == enter + 4))
                    {
                        for (int y = 2; y < 6; y++)
                        {
                            dungeon[floor, x, y] = Map.Room;
                        }
                    }
                    else if ((x == enter - 2) || (x == enter + 3))
                    {
                        for (int y = 1; y < 7; y++)
                        {
                            dungeon[floor,x,y] = Map.Room;
                        }
                    }
                    else
                    {
                        for (int y = 0; y < 8; y++)
                        {
                            dungeon[floor, x, y] = Map.Room;
                        }
                    }
                }

                dungeon[floor, enter - 4, 3] = Map.PassageIP;
                dungeon[floor, enter + 5, 3] = Map.PassageIP;
                dungeon[floor, enter + 0, 8] = Map.PassageIP;
                break;
                #endregion
            #region Case 7
            case 7:
                //Debug.Log("Rolled enterance 7");
                for (int x = enter - 3; x < enter + 5; x++)
                {
                    if ((x == enter - 3) || (x == enter + 4))
                    {
                        for (int y = 2; y < 6; y++)
                        {
                            dungeon[floor, x, y] = Map.Room;
                        }
                    }
                    else if ((x == enter - 2) || (x == enter + 3))
                    {
                        for (int y = 1; y < 7; y++)
                        {
                            dungeon[floor, x, y] = Map.Room;
                        }
                    }
                    else
                    {
                        for (int y = 0; y < 8; y++)
                        {
                            dungeon[floor, x, y] = Map.Room;
                        }
                    }
                }

                dungeon[floor, enter - 4, 3] = Map.PassageIP;
                dungeon[floor, enter + 5, 3] = Map.PassageIP;
                dungeon[floor, enter + 0, 8] = Map.PassageIP;
                for (int x = enter; x < enter +2; x++)
                {
                    for (int y = 3; y < 5; y++)
                    {
                        dungeon[floor, x, y] = Map.Well;
                    }
                }
                break;
                #endregion
            #region Case 8
            case 8:
                //Debug.Log("Rolled enterance 8");
                for (int x = enter - 1; x < enter + 3; x++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        dungeon[floor, x, y] = Map.Room;
                    }
                }

                switch (Random.Range(1, 7))
                {
                    case 1:
                        dungeon[floor, enter - 2, 2] = Map.SecretDoor;
                        
                        dungeon[floor, enter + 0, 4] = Map.Door;
                        
                        dungeon[floor, enter + 3, 2] = Map.PassageIP;
                        break;
                    case 2:
                        dungeon[floor, enter - 2, 2] = Map.SecretDoor;
                        
                        dungeon[floor, enter + 3, 2] = Map.Door;
                        
                        dungeon[floor, enter + 0, 4] = Map.PassageIP;
                        break;
                    case 3:
                        dungeon[floor, enter + 0, 4] = Map.SecretDoor;
                        
                        dungeon[floor, enter - 2, 2] = Map.Door;
                        
                        dungeon[floor, enter + 3, 2] = Map.PassageIP;
                        break;
                    case 4:
                        dungeon[floor, enter + 0, 4] = Map.SecretDoor;
                        
                        dungeon[floor, enter + 3, 2] = Map.Door;
                        
                        dungeon[floor, enter - 2, 2] = Map.PassageIP;
                        break;
                    case 5:
                        dungeon[floor, enter + 3, 2] = Map.SecretDoor;
                        
                        dungeon[floor, enter - 2, 2] = Map.Door;
                        
                        dungeon[floor, enter + 0, 4] = Map.PassageIP;
                        break;
                    case 6:
                        dungeon[floor, enter + 3, 2] = Map.SecretDoor;
                        
                        dungeon[floor, enter + 0, 4] = Map.Door;
                        
                        dungeon[floor, enter - 2, 2] = Map.PassageIP;
                        break;
                }
                break;
                #endregion
            #region Case 9
            case 9:
                //Debug.Log("Rolled enterance 9");
                for (int x = enter; x < enter + 2; x++)
                {
                    for (int y = 0; y < 4; y++)
                    {
                        dungeon[floor, x, y] = Map.Passage;
                    }
                }
                dungeon[floor, enter - 1, 3] = Map.PassageIP;
                dungeon[floor, enter + 2, 3] = Map.PassageIP;
                break;
                #endregion
            #region Case 10
            case 10:
                //Debug.Log("Rolled enterance 10");
                for (int x = enter; x < enter + 2; x++)
                {
                    for (int y = 0; y < 5; y++)
                    {
                        dungeon[floor, x, y] = Map.Passage;
                    }
                }
                dungeon[floor, enter - 1, 2] = Map.PassageIP;
                dungeon[floor, enter + 0, 5] = Map.PassageIP;
                dungeon[floor, enter + 2, 2] = Map.PassageIP;
                break;
                #endregion
        }


        dungeon[floor, enter, 0] = Map.Enter;
        dungeon[floor, enter + 1, 0] = Map.Enter;
    }

/*    bool Valid(int[] loc, int direction, RoomID id, int size)
    {
        bool orient1 = true;
        bool orient2 = true;

        Map storedValue = dungeon[loc[0], loc[1], loc[2]];

        dungeon[loc[0], loc[1], loc[2]] = Map.Blank;

        string dir = "";

        switch (direction)
        {
            case 0:
                dir = "going right";
                break;
            case 1:
                dir = "going left";
                break;
            case 2:
                dir = "going down";
                break;
            case 3:
                dir = "going up";
                break;
        }

        Debug.Log("Checking validation: " + id + " at " + loc[0] + " " + loc[1] + " " + loc[2] + ", " + dir + " with size " + size);

        switch (id)
        {
            case RoomID.StndPass:
                switch (direction)
                {
                    case 0:
                        if ((loc[1] + 7 >= mapWidth) || (loc[2] - (size / 2) - 1 < 0) || ((loc[2] + (size / 2) + 1) >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1]; x < loc[1] + 7; x++)
                        {
                            if (size == 1)
                            {
                                for (int y = loc[2] - 1; y < loc[2] + 2; y++)
                                {
                                    if (dungeon[loc[0], x, loc[2]] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0],x,loc[2]] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                            else
                            {
                                for (int y = loc[2] - (size / 2); y < loc[2] + (size / 2 + 2); y++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                        }
                        break;
                    case 1:
                        if ((loc[1] - 7 < 0) || (loc[2] - (size / 2) - 1 < 0) || ((loc[2] + (size / 2) + 1) >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1]; x > loc[1] - 7; x--)
                        {
                            if (size == 1)
                            {
                                for (int y = loc[2] - 1; y < loc[2] + 2; y++)
                                {
                                    if (dungeon[loc[0], x, loc[2]] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                            else
                            {
                                for (int y = loc[2] - (size / 2); y < loc[2] + (size / 2 + 2); y++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                        }
                        break;
                    case 2:
                        if ((loc[2] + 7 >= mapDepth) || (loc[1] - (size / 2) - 1 < 0) || (loc[1] + (size / 2) + 1 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2]; y < loc[2] + 7; y++)
                        {
                            if (size == 1)
                            {
                                for (int x = loc[1] - 1; x < loc[1] + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                            else
                            {
                                for (int x = loc[1] - (size / 2); x < loc[1] + (size / 2) + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        if ((loc[2] - 7 < 0) || (loc[1] - (size / 2) - 1 < 0) || (loc[1] + (size / 2) + 1 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2]; y > loc[2] - 7; y--)
                        {
                            if (size == 1)
                            {
                                for (int x = loc[1] - 1; x < loc[1] + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                            else
                            {
                                for (int x = loc[1] - (size / 2); x < loc[1] + (size / 2) + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                        }
                        break;
                }
                break;
            case RoomID.PassDrRt:
            case RoomID.PassPassRt:
                switch (direction)
                {
                    case 0:
                        if ((loc[1] + 7 >= mapWidth) || (loc[2] + (size / 2) + 1 >= mapDepth) || (loc[2] - (size / 2) - 1 < 0))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1]; x < loc[1] + 7; x++)
                        {
                            if (size == 1)
                            {
                                for (int y = loc[2] - 1; y < loc[2] + 2; y++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                    if ((x >= loc[1] + 2) && (x <= loc[1] + 4))
                                        if (dungeon[loc[0], x, y + 1] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                            else
                            {
                                for (int y = loc[2] - (size / 2); y < loc[2] + (size/2) + 2; y++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                    if ((x >= loc[1] + 2) && (x <= loc[1] + 4))
                                        if (dungeon[loc[0], x, y + 1] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                        }
                        break;
                    case 1:
                        if ((loc[1] - 7 < 0) || (loc[2] - (size / 2) - 1 < 0) || (loc[2] + (size / 2) + 1 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1]; x > loc[1] - 7; x--)
                        {
                            if (size == 1)
                            {
                                for (int y = loc[2] - 1; y < loc[2] + 2; y++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                    if ((x <= loc[1] - 2) && (x >= loc[1] - 4))
                                        if (dungeon[loc[0], x, y - 1] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                            else
                            {
                                for (int y = loc[2] - (size / 2); y < loc[2] + (size / 2) + 2; y++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                    if ((x <= loc[1] - 2) && (x >= loc[1] - 4))
                                        if (dungeon[loc[0], x, y - 1] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                        }
                        break;
                    case 2:
                        if ((loc[2] + 7 >= mapDepth) || (loc[1] - (size / 2) - 1 < 0) || (loc[1] + (size / 2) + 1 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2]; y < loc[2] + 7; y++)
                        {
                            if (size == 1)
                            {
                                for (int x = loc[1] - 1; x < loc[1] + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                    if ((y >= loc[2] + 2) && (y <= loc[2] + 4))
                                        if (dungeon[loc[0], x - 1, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                            else
                            {
                                for (int x = loc[1] - (size / 2); x < loc[1] + (size / 2) + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                    if ((y >= loc[2] + 2) && (y <= loc[2] + 4))
                                        if (dungeon[loc[0], x - 1, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                        }
                        break;
                    case 3:
                        if ((loc[2] - 7 < 0) || (loc[1] + (size / 2) + 1 >= mapWidth) || (loc[1] - (size / 2) - 1 < 0))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2]; y > loc[2] - 7; y--)
                        {
                            if (size == 1)
                            {
                                for (int x = loc[1] - 1; x < loc[1] + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                    if ((y <= loc[2] - 2) && (y >= loc[2] - 4))
                                        if (dungeon[loc[0], x + 1, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                            else
                            {
                                for (int x = loc[1] - (size / 2); x < loc[1] + (size / 2) + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    if ((y <= loc[2] - 2) && (y >= loc[2] - 4))
                                        if (dungeon[loc[0], x + 1, y] != Map.Blank)
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                }
                            }
                        }
                        break;
                }
                break;
            case RoomID.PassDrLt:
            case RoomID.PassPassLt:
                switch (direction)
                {
                    case 0:
                        if ((loc[1] + 7 >= mapWidth) || (loc[2] - (size / 2) - 1 < 0) || (loc[2] + (size / 2) + 1 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1]; x < loc[1] + 7; x++)
                        {
                            if (size == 1)
                            {
                                for (int y = loc[2] - 1; y < loc[2] + 2; y++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                    if ((x >= loc[1] + 2) && (x <= loc[1] + 4))
                                        if (dungeon[loc[0], x, y - 1] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                            else
                            {
                                for (int y = loc[2] - (size / 2); y < loc[2] + (size / 2) + 2; y++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    if ((x >= loc[1] + 2) && (x <= loc[1] + 4))
                                        if (dungeon[loc[0], x, y - 1] != Map.Blank)
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                }
                            }
                        }
                        break;
                    case 1:
                        if ((loc[1] - 7 < 0) || (loc[2] + (size / 2) + 1 >= mapDepth) || (loc[2] - (size / 2) - 1 < 0))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1]; x > loc[1] - 7; x--)
                        {
                            if (size == 1)
                            {
                                for (int y = loc[2] - 1; y < loc[2] + 2; y++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                    if ((x <= loc[1] - 2) && (x >= loc[1] - 4))
                                        if (dungeon[loc[0], x, y + 1] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                            else
                            {
                                for (int y = loc[2] - (size / 2); y < loc[2] + (size / 2) + 2; y++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                    if ((x <= loc[1] - 2) && (x >= loc[1] - 4))
                                        if (dungeon[loc[0], x, y + 1] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                        }
                        break;
                    case 2:
                        if ((loc[2] + 7 > mapDepth) || (loc[1] + (size / 2) + 1 >= mapWidth) || (loc[1] - (size / 2) - 1 < 0))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2]; y < loc[2] + 7; y++)
                        {
                            if (size == 1)
                            {
                                for (int x = loc[1] - 1; x < loc[1] + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                    if ((y >= loc[2] + 2) && (y <= loc[2] + 4))
                                        if (dungeon[loc[0], x + 1, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                            else
                            {
                                for (int x = loc[1] - (size / 2); x < loc[1] + (size / 2) + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                    if ((y >= loc[2] + 2) && (y <= loc[2] + 4))
                                        if (dungeon[loc[0], x + 1, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                        }
                        break;
                    case 3:
                        if ((loc[2] - 7 < 0) || (loc[1] - (size / 2) - 1 < 0) || (loc[1] + (size / 2) + 1 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2]; y > loc[2] - 7; y--)
                        {
                            if (size == 1)
                            {
                                for (int x = loc[1] - 1; x < loc[1] + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                    if ((y <= loc[2] - 2) && (y >= loc[2] - 4))
                                        if (dungeon[loc[0], x - 1, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                            else
                            {
                                for (int x = loc[1] - (size / 2); x < loc[1] + (size / 2) + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                    if ((y <= loc[2] - 2) && (y >= loc[2] - 4))
                                        if (dungeon[loc[0], x - 1, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                        }
                        break;
                }
                break;
            case RoomID.ShortPassDE:
                switch (direction)
                {
                    case 0:
                        if ((loc[1] + 5 >= mapWidth) || (loc[2] - (size / 2) - 1 < 0) || (loc[2] + (size / 2) + 1 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1]; x < loc[1] + 5; x++)
                        {
                            if (size == 1)
                            {
                                for (int y = loc[2] - 1; y < loc[2] + 2; y++)
                                {
                                    if (dungeon[loc[0], x, loc[2]] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                            else
                            {
                                for (int y = loc[2] - (size / 2); y < loc[2] + (size / 2 + 2); y++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                        }
                        break;
                    case 1:
                        if ((loc[1] - 5 < 0) || (loc[2] - (size / 2) - 1 < 0) || (loc[2] + (size / 2) + 1 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1]; x > loc[1] - 5; x--)
                        {
                            if (size == 1)
                            {
                                for (int y = loc[2] - 1; y < loc[2] + 2; y++)
                                {
                                    if (dungeon[loc[0], x, loc[2]] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                            else
                            {
                                for (int y = loc[2] - (size / 2); y < loc[2] + (size / 2 + 2); y++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                        }
                        break;
                    case 2:
                        if ((loc[2] + 5 >= mapDepth) || (loc[1] - (size / 2) - 1 < 0) || (loc[1] + (size / 2) + 1 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2]; y < loc[2] + 5; y++)
                        {
                            if (size == 1)
                            {
                                for (int x = loc[1] - 1; x < loc[1] + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                            else
                            {
                                for (int x = loc[1] - (size / 2); x < loc[1] + (size / 2) + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        if ((loc[2] - 5 < 0) || (loc[1] - (size / 2) - 1 < 0) || (loc[1] + (size / 2) + 1 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2]; y > loc[2] - 5; y--)
                        {
                            if (size == 1)
                            {
                                for (int x = loc[1] - 1; x < loc[1] + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                            else
                            {
                                for (int x = loc[1] - (size / 2); x < loc[1] + (size / 2) + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                        }
                        break;
                }
                break;
            case RoomID.ShortPassDr:
                switch (direction)
                {
                    case 0:
                        if ((loc[1] + 6 >= mapWidth) || (loc[2] - 1 - (size / 2) < 0) || (loc[2] + (size / 2) + 2 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1]; x < loc[1] + 6; x++)
                        {
                            if (size == 1)
                            {
                                for (int y = loc[2] - 1; y < loc[2] + 2; y++)
                                {
                                    if (dungeon[loc[0], x, loc[2]] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                            else
                            {
                                for (int y = loc[2] - (size / 2); y < loc[2] + (size / 2) + 2; y++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                        }
                        break;
                    case 1:
                        if ((loc[1] - 6 < 0) || (loc[2] - (size / 2) - 1 < 0) || (loc[2] + 2 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1]; x > loc[1] - 6; x--)
                        {
                            if (size == 1)
                            {
                                for (int y = loc[2] - 1; y < loc[2] + 2; y++)
                                {
                                    if (dungeon[loc[0], x, loc[2]] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                            else
                            {
                                for (int y = loc[2] - (size / 2); y < loc[2] + (size / 2) + 2; y++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                        }
                        break;
                    case 2:
                        if ((loc[2] + 6 >= mapDepth) || (loc[1] - 1 < 0) || (loc [1] + 2 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2]; y < loc[2] + 6; y++)
                        {
                            if (size == 1)
                            {
                                for (int x = loc[1] - 1; x < loc[1] + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                            else
                            {
                                for (int x = loc[1] - (size / 2); x < loc[1] + (size / 2) + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                        }
                        break;
                    case 3:
                        if ((loc[2] - 6 < 0) || (loc[1] - 1 < 0) || (loc[1] + 2 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2]; y > loc[2] - 6; y--)
                        {
                            if (size == 1)
                            {
                                for (int x = loc[1] - 1; x < loc[1] + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                            else
                            {
                                for (int x = loc[1] - (size / 2); x < loc[1] + (size / 2) + 2; x++)
                                {
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                                }
                            }
                        }
                        break;
                }
                break;
            case RoomID.LPassLt:
                switch (direction)
                {
                    case 0:
                        if ((loc[1] + 5 + size >= mapWidth) || (loc[2] - 3 - (size / 2) < 0) || (loc[2] + (size / 2) + 2 > mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1]; x < loc[1] + 5 + size; x++)
                        {
                            if (size == 1)
                            {
                                if (x < loc[1] + 3)
                                {
                                    for (int y = loc[2] - 1; y < loc[2] + 2; y++)
                                    {
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                    }
                                }
                                else
                                {
                                    for (int y = loc[2] - 3; y < loc[2] + 2; y++)
                                    {
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (x < loc[1] + 3)
                                {
                                    for (int y = loc[2] - 1 - (size / 2); y < loc[2] + 2 + (size/2); y++)
                                    {
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                    }
                                }
                                else
                                {
                                    for (int y = loc[2] - 3 - (size / 2); y < loc[2] + 2 + (size / 2); y++)
                                    {
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 1:
                        if ((loc[1] - 5 - size < 0) || (loc[2] + 4 + (size / 2) >= mapDepth) || (loc[2] - 2 < 0))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1]; x > loc[1] - 5 - size; x--)
                        {
                            if (size == 1)
                            {
                                if (x > loc[1] - 3)
                                {
                                    for (int y = loc[2] - 1; y < loc[2] + 2; y++)
                                    {
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                    }
                                }
                                else
                                {
                                    for (int y = loc[2] - 1; y < loc[2] + 4; y++)
                                    {
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (x > loc[1] - 3)
                                {
                                    for (int y = loc[2] - (size / 2); y < loc[2] + 1 + (size / 2); y++)
                                    {
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                    }
                                }
                                else
                                {
                                    for (int y = loc[2] - (size / 2); y < loc[2] + 4 + (size / 2); y++)
                                    {
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                    }
                                }
                            }
                        }
                        break;
                    case 2:
                        if ((loc[1] + 4 + (size / 2) >= mapWidth) || (loc[2] + 4 + size >= mapDepth) || (loc[1] - 1 < 0))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2]; y < loc[2] + 4 + size; y++)
                        {
                            if (size == 1)
                            {
                                if (y < loc[2] + 3)
                                {
                                    for (int x = loc[1] - 1; x < loc[1] + 2; x++)
                                    {
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                    }
                                }
                                else
                                {
                                    for (int x = loc[1] - 1; x < loc[1] + 4; x++)
                                    {
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (y < loc[2] + 3)
                                {
                                    for (int x = loc[1] - 1; x < loc[1] + 2 + (size / 2); x++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                                else
                                {
                                    for (int x = loc[1] - 1; x < loc[1] + 4 + (size / 2); x++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                        }
                        break;
                    case 3:
                        if ((loc[1] - 2 - (size / 2) < 0) || (loc[2] - 4 - size < 0) || (loc[1] + 2 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2]; y > loc[2] - 4 - size; y--)
                        {
                            if (size == 1)
                            {
                                if (y > loc[2] - 3)
                                {
                                    for (int x = loc[1] - 1; x < loc[1] + 2; x++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                                else
                                {
                                    for (int x = loc[1] - 3; x < loc[1] + 2; x++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                            else
                            {
                                if (y > loc[2] - 3)
                                {
                                    for (int x = loc[1] - (size / 2); x < loc[1] + 2 + (size / 2); x++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                                else
                                {
                                    for (int x = loc[1] - (size / 2) - 2; x < loc[2] + 2 + (size / 2); x++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                        }
                        break;
                }
                break;
            case RoomID.LPassRt:
                switch (direction)
                {
                    case 0:
                        if ((loc[1] + 4 + size >= mapWidth) || (loc[2] + 4 + (size / 2) >= mapDepth) || (loc[2] - (size / 2) < 0))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1]; x < loc[1] + 5 + size; x++)
                        {
                            if (size == 1)
                            {
                                if (x < loc[1] + 3)
                                {
                                    for (int y = loc[2] - 1; y < loc[2] + 2; y++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                                else
                                {
                                    for (int y = loc[2] - 1; y < loc[2] + 4; y++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                            else
                            {
                                if (x < loc[1] + 3)
                                {
                                    for (int y = loc[2] - (size / 2); y < loc[2] + (size / 2) + 2; y++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                                else
                                {
                                    for (int y = loc[2] - (size / 2); y < loc[2] + (size / 2) + 4; y++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                        }
                        break;
                    case 1:
                        if ((loc[1] - 4 - size < 0) || (loc[2] - 3 - (size / 2) < 0) || (loc[2] + (size / 2) + 2 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1]; x > loc[1] - 5 - size; x--)
                        {
                            if (size == 1)
                            {
                                if (x > loc[1] - 3)
                                {
                                    for (int y = loc[2] - 1; y < loc[2] + 2; y++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                                else
                                {
                                    for (int y = loc[2] - 3; y < loc[2] + 2; y++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                            else
                            {
                                if (x > loc[1] - 3)
                                {
                                    for (int y = loc[2] - (size / 2); y < loc[2] + (size / 2) + 2; y++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                                else
                                {
                                    for (int y = loc[2] - (size / 2) - 2; y < loc[2] + (size / 2) + 2; y++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                        }
                        break;
                    case 2:
                        if ((loc[1] - 2 - (size / 2) < 0) || (loc[2] + 5 + size >= mapDepth) || (loc[1] + (size / 2) + 2 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2]; y < loc[2] + 5 + size; y++)
                        {
                            if (size == 1)
                            {
                                if (y < loc[2] + 3)
                                {
                                    for (int x = loc[1] - 1; x < loc[1] + 2; x++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                                else
                                {
                                    for (int x = loc[1] - 3; x < loc[1] + 2; x++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                            else
                            {
                                if (y < loc[2] + 3)
                                {
                                    for (int x = loc[1] - (size / 2); x < loc[1] + (size / 2) + 2; x++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                                else
                                {
                                    for (int x = loc[1] - (size / 2) - 2; x < loc[1] + (size / 2) + 2; x++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                        }
                        break;
                    case 3:
                        if ((loc[1] + 4 + (size / 2) >= mapWidth) || (loc[2] - 4 - size < 0) || (loc[1] - (size / 2) < 0))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2]; y > loc[2] - 5 - size; y--)
                        {
                            if (size == 1)
                            {
                                if (y > loc[2] - 3)
                                {
                                    for (int x = loc[1] - 1; x < loc[1] + 2; x++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                                else
                                {
                                    for (int x = loc[1] - 1; x < loc[1] + 4; x++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                            else
                            {
                                if (y > loc[2] - 3)
                                {
                                    for (int x = loc[1] - (size / 2); x < loc[1] + (size / 2) + 2; x++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                                else
                                {
                                    for (int x = loc[1] - (size / 2); x < loc[1] + (size / 2) + 4; x++)
                                        if (dungeon[loc[0], x, y] != Map.Blank)
                                        {
                                            Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                            dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                        }
                                }
                            }
                        }
                        break;
                }
                break;
            case RoomID.Chm2020:
                switch (direction)
                {
                    case 0:
                        if ((loc[1] + 6 >= mapWidth) || (loc[2] + 4 >= mapDepth) || (loc[2] - 2 < 0))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] + 1; x < loc[1] + 6; x++)
                            for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                }
                        break;
                    case 1:
                        if ((loc[1] - 6 < 0) || (loc[2] + 4 >= mapDepth) || (loc[2] - 2 < 0))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] - 1; x > loc[1] - 6; x--)
                            for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                }
                        break;
                    case 2:
                        if ((loc[2] + 6 >= mapDepth) || (loc[1] + 4 >= mapWidth) || (loc[1] - 2 < 0))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                            for (int y = loc[2] + 1; y < loc[2] + 6; y++)
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                }
                        break;
                    case 3:
                        if ((loc[2] - 6 < 0) || (loc[1] + 4 >= mapWidth) || (loc[1] - 2 < 0))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                            for (int y = loc[2] - 1; y > loc[2] - 6; y--)
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                }
                        break;
                }
                break;
            case RoomID.Chm2030:
                orient1 = true;
                orient2 = true;
                switch (direction)
                {
                    case 0:
                        for (int x = loc[1] + 1; x < loc[1] + 8; x++)
                        {
                            if ((loc[1] + 8 >= mapWidth) || (loc[2] + 4 >= mapWidth) || (loc[2] - 2 < 0))
                            {
                                orient1 = false;
                                Debug.Log("Orientation 1 out of bounds");
                                break;
                            }
                            for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient1 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient1)
                                break;
                        }
                        for (int x = loc[1] + 1; x < loc[1] + 6; x++)
                        {
                            if ((loc[1] + 6 >= mapWidth) || (loc[2] - 3 < 0) || (loc[2] + 5 >= mapWidth))
                            {
                                orient2 = false;
                                Debug.Log("Orientation 2 out of bounds");
                                break;
                            }
                            for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient2 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient2)
                                break;
                        }
                        break;
                    case 1:
                        for (int x = loc[1] - 1; x > loc[1] - 8; x--)
                        {
                            if ((loc[1] - 8 < 0) || (loc[2] - 2 < 0) || (loc[2] + 4 >= mapWidth))
                            {
                                orient1 = false;
                                Debug.Log("Orientation 1 out of bounds");
                                break;
                            }
                            for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient1 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient1)
                                break;
                        }
                        for (int x = loc[1] - 1; x > loc[1] - 6; x--)
                        {
                            if ((loc[1] - 6 < 0) || (loc[2] - 3 < 0) || (loc[2] + 5 >= mapDepth))
                            {
                                orient2 = false;
                                Debug.Log("Orientation 2 out of bounds");
                                break;
                            }
                            for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient2 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient2)
                                break;
                        }
                        break;
                    case 2:
                        for (int y = loc[2] + 1; y < loc[2] + 8; y++)
                        {
                            if ((loc[2] + 8 >= mapDepth) || (loc[1] - 2 < 0) || (loc[1] + 4 >= mapDepth))
                            {
                                orient1 = false;
                                Debug.Log("Orientation 1 out of bounds");
                                break;
                            }
                            for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient1 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient1)
                                break;
                        }
                        for (int y = loc[2] + 1; y < loc[2] + 6; y++)
                        {
                            if ((loc[2] + 6 >= mapDepth) || (loc[1] - 3 < 0) || (loc[1] + 5 >= mapWidth))
                            {
                                orient2 = false;
                                Debug.Log("Orientation 2 out of bounds");
                                break;
                            }
                            for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient2 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient2)
                                break;
                        }
                        break;
                    case 3:
                        for (int y = loc[2] - 1; y > loc[2] - 8; y--)
                        {
                            if ((loc[2] - 8 < 0) || (loc[1] - 2 < 0) || (loc[1] + 4 >= mapWidth))
                            {
                                orient1 = false;
                                Debug.Log("Orientation 1 out of bounds");
                                break;
                            }
                            for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient1 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient1)
                                break;
                        }
                        for (int y = loc[2] - 1; y > loc[2] - 6; y--)
                        {
                            if ((loc[2] - 6 < 0) || (loc[1] - 3 < 0) || (loc[1] + 5 >= mapWidth))
                            {
                                orient2 = false;
                                Debug.Log("Orientation 2 out of bounds");
                                break;
                            }
                            for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient2 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient2)
                                break;
                        }
                        break;
                }
                if ((!orient1) && (!orient2))
                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                break;
            case RoomID.Chm3030:
                switch (direction)
                {
                    case 0:
                        if ((loc[1] + 8 >= mapWidth) || (loc[2] - 3 < 0) || (loc[2] + 5 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] + 1; x < loc[1] + 8; x++)
                            for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                }
                        break;
                    case 1:
                        if ((loc[1] - 8 < 0) || (loc[2] - 3 < 0) || (loc[2] + 5 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] - 1; x > loc[1] - 8; x--)
                            for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                }
                        break;
                    case 2:
                        if ((loc[2] + 8 >= mapDepth) || (loc[1] - 3 < 0) || (loc[1] + 5 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                            for (int y = loc[2] + 1; y < loc[2] + 8; y++)
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                        break;
                    case 3:
                        if ((loc[2] - 8 < 0) || (loc[1] - 3 < 0) || (loc[1] + 5 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                            for (int y = loc[2] - 1; y > loc[2] - 8; y--)
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                }
                        break;
                }
                break;
            case RoomID.Chm3040:
                orient1 = true;
                orient2 = true;
                switch (direction)
                {
                    case 0:
                        for (int x = loc[1] + 1; x < loc[1] + 10; x++)
                        {
                            if ((loc[1] + 10 >= mapWidth) || (loc[2] - 3 < 0) || (loc[2] + 5 >= mapWidth))
                            {
                                orient1 = false;
                                Debug.Log("Orientation 1 out of bounds");
                                break;
                            }
                            for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient1 = false;
                                    break;
                                }
                            }
                            if (!orient1)
                                break;
                        }
                        for (int x = loc[1] + 1; x < loc[1] + 8; x++)
                        {
                            if ((loc[1] + 8 >= mapWidth) || (loc[2] - 4 < 0) || (loc[2] + 6 >= mapDepth))
                            {
                                orient2 = false;
                                Debug.Log("Orientation 2 out of bounds");
                                break;
                            }
                            for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient2 = false;
                                    break;
                                }
                            }
                            if (!orient2)
                                break;
                        }
                        break;
                    case 1:
                        for (int x = loc[1] - 1; x > loc[1] - 10; x--)
                        {
                            if ((loc[1] - 10 < 0) || (loc[2] - 3 < 0) || (loc[2] + 5 >= mapDepth))
                            {
                                orient1 = false;
                                Debug.Log("Orientation 1 out of bounds");
                                break;
                            }
                            for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient1 = false;
                                    break;
                                }
                            }
                            if (!orient1)
                                break;
                        }
                        for (int x = loc[1] - 1; x > loc[1] - 8; x--)
                        {
                            if ((loc[1] - 8 < 0) || (loc[2] - 4 < 0) || (loc[2] + 6 >= mapDepth))
                            {
                                orient2 = false;
                                Debug.Log("Orientation 2 out of bounds");
                                break;
                            }
                            for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient2 = false;
                                    break;
                                }
                            }
                            if (!orient2)
                                break;
                        }
                        break;
                    case 2:
                        for (int y = loc[2] + 1; y < loc[2] + 10; y++)
                        {
                            if ((loc[2] + 10 >= mapDepth) || (loc[1] - 3 < 0) || (loc[1] + 5 >= mapWidth))
                            {
                                orient1 = false;
                                Debug.Log("Orientation 1 out of bounds");
                                break;
                            }
                            for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient1 = false;
                                    break;
                                }
                            }
                            if (!orient1)
                                break;
                        }
                        for (int y = loc[2] + 1; y < loc[2] + 8; y++)
                        {
                            if ((loc[2] + 8 >= mapDepth) || (loc[1] - 4 < 0) || (loc[1] + 6 >= mapWidth))
                            {
                                orient2 = false;
                                Debug.Log("Orientation 2 out of bounds");
                                break;
                            }
                            for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient2 = false;
                                    break;
                                }
                            }
                            if (!orient2)
                                break;
                        }
                        break;
                    case 3:
                        for (int y = loc[2] - 1; y > loc[2] - 10; y--)
                        {
                            if ((loc[2] - 10 < 0) || (loc[1] - 3 < 0) || (loc[1] + 5 >= mapWidth))
                            {
                                orient1 = false;
                                Debug.Log("Orientation 1 out of bounds");
                                break;
                            }
                            for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient1 = false;
                                    break;
                                }
                            }
                            if (!orient1)
                                break;
                        }
                        for (int y = loc[2] - 1; y > loc[2] - 8; y--)
                        {
                            if ((loc[2] - 8 < 0) || (loc[1] - 4 < 0) || (loc[1] + 6 >= mapWidth))
                            {
                                orient2 = false;
                                Debug.Log("Orientation 2 out of bounds");
                                break;
                            }
                            for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient2 = false;
                                    break;
                                }
                            }
                            if (!orient2)
                                break;
                        }
                        break;
                }
                if ((!orient1) && (!orient2))
                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                break;
            case RoomID.Chm4040:
                switch (direction)
                {
                    case 0:
                        if ((loc[1] + 10 >= mapWidth) || (loc[2] - 4 < 0) || (loc[2] + 6 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] + 1; x < loc[1] + 10; x++)
                            for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                }
                        break;
                    case 1:
                        if ((loc[1] - 10 < 0) || (loc[2] - 4 < 0) || (loc[2] + 6 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] - 1; x > loc[1] - 10; x--)
                            for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                }
                        break;
                    case 2:
                        if ((loc[1] + 6 >= mapWidth) || (loc[2] + 10 >= mapWidth) || (loc[1] - 4 < 0))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                            for (int y = loc[2] + 1; y < loc[2] + 10; y++)
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                }
                        break;
                    case 3:
                        if ((loc[1] - 4 < 0) || ( loc[1] + 6 >= mapWidth) || (loc[2] - 10 < 0))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                            for (int y = loc[2] - 1; y > loc[2] - 10; y--)
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                }
                        break;
                }
                break;
            case RoomID.Chm4050:
                orient1 = true;
                orient2 = true;
                switch (direction)
                {
                    case 0:
                        for (int x = loc[1] + 1; x < loc[1] + 12; x++)
                        {
                            if ((loc[1] + 12 >= mapWidth) || (loc[2] - 4 < 0) || (loc[2] + 6 >= mapWidth))
                            {
                                orient1 = false;
                                Debug.Log("Orientation 1 out of bounds");
                                break;
                            }
                            for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient1 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient1)
                                break;
                        }
                        for (int x = loc[1] + 1; x < loc[1] + 10; x++)
                        {
                            if ((loc[1] + 10 >= mapWidth) || (loc[2] - 5 < 0) || (loc[2] + 8 >= mapWidth))
                            {
                                orient2 = false;
                                Debug.Log("Orientation 2 out of bounds");
                                break;
                            }
                            for (int y = loc[2] - 5; y < loc[2] + 8; y++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient2 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient2)
                                break;
                        }
                        break;
                    case 1:
                        for (int x = loc[1] - 1; x > loc[1] - 12; x--)
                        {
                            if ((loc[1] - 12 < 0) || (loc[2] - 4 < 0) || (loc[2] + 6 >= mapDepth))
                            {
                                orient1 = false;
                                Debug.Log("Orientation 1 out of bounds");
                                break;
                            }
                            for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient1 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient1)
                                break;
                        }
                        for (int x = loc[1] - 1; x > loc[1] - 10; x--)
                        {
                            if ((loc[1] - 10 < 0) || (loc[2] - 5 < 0) || (loc[2] + 7 >= mapDepth))
                            {
                                orient2 = false;
                                Debug.Log("Orientation 2 out of bounds");
                                break;
                            }
                            for (int y = loc[2] - 5; y < loc[2] + 7; y++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient2 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient2)
                                break;
                        }
                        break;
                    case 2:
                        for (int y = loc[2] + 1; y < loc[2] + 12; y++)
                        {
                            if ((loc[2] + 12 >= mapDepth) || (loc[1] - 4 < 0) || (loc[1] + 6 >= mapWidth))
                            {
                                orient1 = false;
                                Debug.Log("Orientation 1 out of bounds");
                                break;
                            }
                            for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient1 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient1)
                                break;
                        }
                        for (int y = loc[2] + 1; y < loc[2] + 10; y++)
                        {
                            if ((loc[2] + 10 >= mapDepth) || (loc[1] - 5 < 0) || (loc[1] + 8 >= mapWidth))
                            {
                                orient2 = false;
                                Debug.Log("Orientation 2 out of bounds");
                                break;
                            }
                            for (int x = loc[1] - 5; x < loc[1] + 8; x++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient2 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient2)
                                break;
                        }
                        break;
                    case 3:
                        for (int y = loc[2] - 1; y > loc[2] - 12; y--)
                        {
                            if ((loc[2] - 12 < 0) || (loc[1] - 4 < 0) || (loc[1] + 6 >= mapWidth))
                            {
                                orient1 = false;
                                Debug.Log("Orientation 1 out of bounds");
                                break;
                            }
                            for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient1 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient1)
                                break;
                        }
                        for (int y = loc[2] - 1; y > loc[2] - 10; y--)
                        {
                            if ((loc[2] - 10 < 0) || (loc[1] - 5 < 0) || (loc[1] + 7 >= mapWidth))
                            {
                                orient2 = false;
                                Debug.Log("Orientation 2 out of bounds");
                                break;
                            }
                            for (int x = loc[1] - 5; x < loc[1] + 7; x++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient2 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient2)
                                break;
                        }
                        break;
                }
                if ((!orient1) && (!orient2))
                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                break;
            case RoomID.Chm5080:
                orient1 = true;
                orient2 = true;
                switch (direction)
                {
                    case 0:
                        for (int x = loc[1] + 1; x < loc[1] + 18; x++)
                        {
                            if ((loc[1] + 18 >= mapWidth) || (loc[2] - 5 < 0) || (loc[2] + 7 >= mapWidth))
                            {
                                orient1 = false;
                                Debug.Log("Orientation 1 out of bounds");
                                break;
                            }
                            for (int y = loc[2] - 5; y < loc[2] + 7; y++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient1 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient1)
                                break;
                        }
                        for (int x = loc[1] + 1; x < loc[1] + 12; x++)
                        {
                            if ((loc[1] + 12 >= mapWidth) || (loc[2] - 8 < 0) || (loc[2] + 10 >= mapDepth))
                            {
                                orient2 = false;
                                Debug.Log("Orientation 2 out of bounds");
                                break;
                            }
                            for (int y = loc[2] - 8; y < loc[2] + 10; y++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient2 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient2)
                                break;
                        }
                        break;
                    case 1:
                        for (int x = loc[1] - 1; x > loc[1] - 18; x--)
                        {
                            if ((loc[1] - 18 < 0) || (loc[2] - 5 < 0) || (loc[2] + 7 >= mapWidth))
                            {
                                orient1 = false;
                                Debug.Log("Orientation 1 out of bounds");
                                break;
                            }
                            for (int y = loc[2] - 5; y < loc[2] + 7; y++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient1 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient1)
                                break;
                        }
                        for (int x = loc[1] - 1; x > loc[1] - 12; x--)
                        {
                            if ((loc[1] - 12 < 0) || (loc[2] - 8 < 0) || (loc[2] + 10 >= mapDepth))
                            {
                                orient2 = false;
                                Debug.Log("Orientation 2 out of bounds");
                                break;
                            }
                            for (int y = loc[2] - 8; y < loc[2] + 10; y++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient2 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient2)
                                break;
                        }
                        break;
                    case 2:
                        for (int y = loc[2] + 1; y < loc[2] + 18; y++)
                        {
                            if ((loc[2] + 18 >= mapDepth) || (loc[1] - 5 < 0) || (loc[1] + 7 >= mapWidth))
                            {
                                orient1 = false;
                                Debug.Log("Orientation 1 out of bounds");
                                break;
                            }
                            for (int x = loc[1] - 5; x < loc[1] + 7; x++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient1 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient1)
                                break;
                        }
                        for (int y = loc[2] + 1; y < loc[2] + 12; y++)
                        {
                            if ((loc[2] + 12 >= mapDepth) || (loc[1] - 8 < 0) || (loc[1] + 10 >= mapWidth))
                            {
                                orient2 = false;
                                Debug.Log("Orientation 2 out of bounds");
                                break;
                            }
                            for (int x = loc[1] - 8; x < loc[1] + 10; x++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient2 = false;
                                    break;
                                }
                            }
                            if (!orient2)
                                break;
                        }
                        break;
                    case 3:
                        for (int y = loc[2] - 1; y > loc[2] - 18; y--)
                        {
                            if ((loc[2] - 18 < 0) || (loc[1] - 5 < 0) || (loc[1] + 7 >= mapWidth))
                            {
                                orient1 = false;
                                Debug.Log("Orientation 1 out of bounds");
                                break;
                            }
                            for (int x = loc[1] - 5; x < loc[1] + 7; x++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient1 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient1)
                                break;
                        }
                        for (int y = loc[2] - 1; y > loc[2] - 12; y--)
                        {
                            if ((loc[2] - 12 < 0) || (loc[1] - 8 < 0) || (loc[1] + 10 >= mapWidth))
                            {
                                orient2 = false;
                                Debug.Log("Orientation 2 out of bounds");
                                break;
                            }
                            for (int x = loc[1] - 8; x < loc[1] + 10; x++)
                            {
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    orient2 = false;
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    break;
                                }
                            }
                            if (!orient2)
                                break;
                        }
                        break;
                }
                if ((!orient1) && (!orient2))
                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                break;
            case RoomID.ChmCr30:
                switch (direction)
                {
                    case 0:
                        if ((loc[1] + 8 >= mapWidth) || (loc[2] - 3 < 0) || (loc[2] + 5 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] + 1; x < loc[1] + 8; x++)
                        {
                            if ((x == loc[1] + 1) || (x == loc[1] + 6))
                            {
                                for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                    case 1:
                        if ((loc[1] - 8 < 0) || (loc[2] - 3 < 0) || (loc[2] + 5 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] - 1; x > loc[1] - 8; x--)
                        {
                            if ((x == loc[1] - 1) || (x == loc[1] - 6))
                            {
                                for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                    case 2:
                        if ((loc[2] + 8 >= mapDepth) || (loc[1] - 3 < 0) || (loc[1] + 5 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2] + 1; y < loc[2] + 8; y++)
                        {
                            if ((y == loc[2] + 1) || (y == loc[2] + 6))
                            {
                                for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                    case 3:
                        if ((loc[2] - 8 < 0) || (loc[1] - 3 < 0) || (loc[1] + 5 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2] - 1; y > loc[2] - 8; y--)
                        {
                            if ((y == loc[2] - 1) || (y == loc[2] - 6))
                            {
                                for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                }
                break;
            case RoomID.ChmCr50:
                switch (direction)
                {
                    case 0:
                        if ((loc[1] + 12 >= mapWidth) || (loc[2] - 5 < 0) || (loc[2] + 8 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] + 1; x < loc[1] + 12; x++)
                        {
                            if ((x == loc[1] + 1) || (x == loc[1] + 10))
                            {
                                for (int y = loc[2] - 3; y < loc[2] + 6; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if (((x > loc[1] + 1) && (x < loc[1] + 4)) || ((x > loc[1] + 7) && (x < loc[1] + 10)))
                            {
                                for (int y = loc[2] - 4; y < loc[2] + 7; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int y = loc[2] - 5; y < loc[2] + 8; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                    case 1:
                        if ((loc[1] - 12 < 0) || (loc[2] - 5 < 0) || (loc[2] + 8 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] - 1; x > loc[1] - 12; x--)
                        {
                            if ((x == loc[1] - 1) || (x == loc[1] - 10))
                            {
                                for (int y = loc[2] - 3; y < loc[2] + 6; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if (((x < loc[1] - 1) && (x > loc[1] - 4)) || ((x < loc[1] - 7) && (x > loc[1] - 10)))
                            {
                                for (int y = loc[2] - 4; y < loc[2] + 7; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int y = loc[2] - 5; y < loc[2] + 8; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                    case 2:
                        if ((loc[2] + 12 >= mapDepth) || (loc[1] - 5 < 0) || (loc[1] + 8 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2] + 1; y < loc[2] + 12; y++)
                        {
                            if ((y == loc[2] + 1) || (y == loc[2] + 10))
                            {
                                for (int x = loc[1] - 3; x < loc[2] + 6; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if(((y > loc[2] + 1) && (y < loc[2] + 4)) || ((y > loc[2] +7) && (y < loc[2] + 10)))
                            {
                                for (int x = loc[1] - 4; x < loc[1] + 7; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int x = loc[1] - 5; x < loc[1] + 8; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                    case 3:
                        if ((loc[2] - 12 < 0) || (loc[1] - 5 < 0) || (loc[1] + 8 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2] - 1; y > loc[2] - 12; y--)
                        {
                            if ((y == loc[2] - 1) || (y == loc[2] - 10))
                            {
                                for (int x = loc[1] - 3; x < loc[1] + 6; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if (((y < loc[2] - 1) && (y > loc[2] - 4)) || ((y < loc[2] - 7) && (y > loc[2] - 10)))
                            {
                                for (int x = loc[1] - 4; x < loc[1] + 7; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int x = loc[1] - 5; x < loc[1] + 8; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                }
                break;
            case RoomID.ChmOct40:
                switch (direction)
                {
                    case 0:
                        if ((loc[1] + 10 >= mapWidth) || (loc[2] - 4 < 0) || (loc[2] + 6 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] + 1; x < loc[1] + 10; x++)
                        {
                            if ((x == loc[1] + 1) || (x == loc[1] + 8))
                            {
                                for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if ((x == loc[1] + 2) || (x == loc[1] + 7))
                            {
                                for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                    case 1:
                        if ((loc[1] - 10 < 0) || (loc[2] - 4 < 0) || (loc[2] + 6 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] - 1; x > loc[1] - 10; x--)
                        {
                            if ((x == loc[1] - 1) || (x == loc[1] - 8))
                            {
                                for (int y = loc[2] - 2; y < loc[2] + 4; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if ((x == loc[1] - 2) || (x == loc[1] - 7))
                            {
                                for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                    case 2:
                        if ((loc[2] + 10 >= mapDepth) || (loc[1] - 4 < 0) || (loc[1] + 6 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2] + 1; y < loc[2] + 10; y++)
                        {
                            if ((y == loc[2] + 1 ) || (y == loc[2] + 8))
                            {
                                for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if ((y == loc[2] + 2) || (y == loc[2] + 7))
                            {
                                for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                    case 3:
                        if ((loc[2] - 10 < 0) || (loc[1] - 4 < 0) || (loc[1] + 6 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2] - 1; y > loc[2] - 10; y--)
                        {
                            if ((y == loc[2] - 1) || (y == loc[2] - 8))
                            {
                                for (int x = loc[1] - 2; x < loc[1] + 4; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if ((y == loc[2] - 2) || (y == loc[2] - 7))
                            {
                                for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                }
                break;
            case RoomID.ChmOct60:
                switch (direction)
                {
                    case 0:
                        if ((loc[1] + 14 >= mapWidth) || (loc[2] - 6 < 0) || (loc[2] + 8 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] + 1; x < loc[1] + 14; x++)
                        {
                            if ((x == loc[1] + 1) || (x == loc[1] + 12))
                            {
                                for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if ((x == loc[1] + 2) || (x == loc[1] + 11))
                            {
                                for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if ((x == loc[1] + 3) || (x == loc[1] + 10))
                            {
                                for (int y = loc[2] - 5; y < loc[2] + 7; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int y = loc[2] - 6; y < loc[2] + 8; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                    case 1:
                        if ((loc[1] - 14 < 0) || (loc[2] - 6 < 0) || (loc[2] + 8 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] - 1; x > loc[1] - 14; x--)
                        {
                            if ((x == loc[1] - 1) || (x == loc[1] - 12))
                            {
                                for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if ((x == loc[1] - 2) || (x == loc[1] - 11))
                            {
                                for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if ((x == loc[1] - 3) || (x == loc[1] - 10))
                            {
                                for (int y = loc[2] - 5; y < loc[2] + 7; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int y = loc[2] - 6; y < loc[2] + 8; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                    case 2:
                        if ((loc[2] + 14 >= mapDepth) || (loc[1] - 6 < 0) || (loc[1] + 8 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2] + 1; y < loc[2] + 14; y++)
                        {
                            if ((y == loc[2] + 1) || (y == loc[2] + 12))
                            {
                                for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if ((y == loc[2] + 2) || (y == loc[2] + 11))
                            {
                                for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if ((y == loc[2] + 3) || (y == loc[2] + 10))
                            {
                                for (int x = loc[1] - 5; x < loc[1] + 7; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int x = loc[1] - 6; x < loc[1] + 8; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                    case 3:
                        if ((loc[2] - 14 < 0) || (loc[1] - 6 < 0) || (loc[1] + 8 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2] - 1; y > loc[2] - 14; y--)
                        {
                            if ((y == loc[2] - 1) || (y == loc[2] - 12))
                            {
                                for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if ((y == loc[2] - 2) || (y == loc[2] - 11))
                            {
                                for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if ((y == loc[2] - 3) || (y == loc[2] - 10))
                            {
                                for (int x = loc[1] - 5; x < loc[1] + 7; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int x = loc[1] - 6; x < loc[1] + 8; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                }
                break;
            case RoomID.ChmTrp:
                switch (direction)
                {
                    case 0:
                        if ((loc[1] + 9 >= mapWidth) || (loc[2] - 6 < 0) || (loc[2] + 8 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] + 1; x < loc[1] + 9; x++)
                        {
                            if (x < loc[1] + 3)
                            {
                                for (int y = loc[2] - 6; y < loc[2] + 8; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if (x < loc[1] + 6)
                            {
                                for (int y = loc[2] - 5; y < loc[2] + 7; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if (x < loc[1] + 8)
                            {
                                for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                    case 1:
                        if ((loc[1] - 9 < 0) || (loc[2] - 3 < 0) || (loc[2] + 5 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] - 1; x > loc[1] - 9; x--)
                        {
                            if (x > loc[1] - 3)
                            {
                                for (int y = loc[2] - 6; y < loc[2] + 8; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if (x > loc[1] - 6)
                            {
                                for (int y = loc[2] - 5; y < loc[2] + 7; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if (x > loc[1] - 8)
                            {
                                for (int y = loc[2] - 4; y < loc[2] + 6; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                    case 2:
                        if ((loc[2] + 9 >= mapDepth) || (loc[1] - 3 < 0) || (loc[1] + 5 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2] + 1; y < loc[2] + 9; y++)
                        {
                            if (y < loc[2] + 3)
                            {
                                for (int x = loc[1] - 6; x < loc[1] + 8; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if (y < loc[2] + 6)
                            {
                                for (int x = loc[1] - 5; x < loc[1] + 7; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if (y < loc[2] + 8)
                            {
                                for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                    case 3:
                        if ((loc[2] - 9 < 0) || (loc[1] - 3 < 0) || (loc[1] + 5 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2] - 1; y > loc[2] + 9; y--)
                        {
                            if (y > loc[2] - 3)
                            {
                                for (int x = loc[1] - 6; x < loc[1] + 8; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if (y > loc[2] - 6)
                            {
                                for (int x = loc[1] - 5; x < loc[1] + 7; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else if (y > loc[2] - 8)
                            {
                                for (int x = loc[1] - 4; x < loc[1] + 6; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                }
                break;
            case RoomID.BeyondDoorT:
                switch (direction)
                {
                    case 0:
                        if ((loc[1] + 6 >= mapWidth) || (loc[2] - 3 < 0) || (loc[2] + 5 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] + 1; x < loc[1] + 6; x++)
                        {
                            if (x == loc[1] + 1)
                            {
                                for (int y = loc[2] - 1; y < loc[2] + 3; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                    case 1:
                        if ((loc[1] - 6 < 0) || (loc[2] - 3 < 0) || (loc[2] + 5 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1] - 1; x > loc[1] + 6; x--)
                        {
                            if (x == loc[1] - 1)
                            {
                                for (int y = loc[2] - 1; y < loc[2] + 3; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int y = loc[2] - 3; y < loc[2] + 5; y++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                    case 2:
                        if ((loc[2] + 6 >= mapDepth) || (loc[1] - 3 < 0) || (loc[1] + 5 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2] + 1; y < loc[2] + 6; y++)
                        {
                            if (y == loc[2] + 1)
                            {
                                for (int x = loc[1] - 1; x < loc[1] + 2; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                    case 3:
                        if ((loc[2] - 6 < 0) || (loc[1] - 3 < 0) || (loc[1] + 5 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2] - 1; y > loc[2] - 6; y--)
                        {
                            if (y == loc[2] - 1)
                            {
                                for (int x = loc[1] - 1; x < loc[1] + 2; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                            else
                            {
                                for (int x = loc[1] - 3; x < loc[1] + 5; x++)
                                    if (dungeon[loc[0], x, y] != Map.Blank)
                                    {
                                        Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                        dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                    }
                            }
                        }
                        break;
                }
                break;
            case RoomID.BeyondDoorStr:
                switch (direction)
                {
                    case 0:
                        if ((loc[1] + 5 >= mapWidth) || (loc[2] - 1 < 0) || (loc[2] + 2 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1]; x < loc[1] + 5; x++)
                            for (int y = loc[2] - 1; y < loc[2] + 2; y++)
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                }
                        break;
                    case 1:
                        if ((loc[1] - 5 < 0) || (loc[2] - 1 < 0) || (loc[2] + 2 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int x = loc[1]; x > loc[1] - 5; x--)
                            for (int y = loc[2] - 1; y < loc[2] + 2; y++)
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                }
                        break;
                    case 2:
                        if ((loc[2] + 5 >= mapDepth) || (loc[1] - 1 < 0) || (loc[1] + 2 >= mapWidth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2]; y < loc[2] + 5; y++)
                            for (int x = loc[1] - 1; x < loc[1] + 2; x++)
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                }
                        break;
                    case 3:
                        if ((loc[2] - 5 < 0) || (loc[1] - 1 < 0) || (loc[1] + 2 >= mapDepth))
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        for (int y = loc[2]; y > loc[2] - 5; y--)
                            for (int x = loc[1] - 1; x < loc[1] + 2; x++)
                                if (dungeon[loc[0], x, y] != Map.Blank)
                                {
                                    Debug.Log("Found " + dungeon[loc[0], x, y] + " at " + loc[0] + " " + x + " " + y);
                                    dungeon[loc[0], loc[1], loc[2]] = storedValue; return false;
                                }
                        break;
                }
                break;
            case RoomID.Stair:
                switch (direction)
                {
                    case 0:
                        if (loc[1] + 2 >= mapWidth)
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        dungeon[loc[0], loc[1] + 1, loc[2]] = Map.Stairs;
                        break;
                    case 1:
                        if (loc[1] - 2 < 0)
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        dungeon[loc[0], loc[1] - 1, loc[2]] = Map.Stairs;
                        break;
                    case 2:
                        if (loc[2] + 2 >= mapDepth)
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        dungeon[loc[0], loc[1], loc[2] + 1] = Map.Stairs;
                        break;
                    case 3:
                        if (loc[2] - 2 < 0)
                        { Debug.Log("Out of bounds"); dungeon[loc[0], loc[1], loc[2]] = storedValue; return false; }
                        dungeon[loc[0], loc[1], loc[2] - 1] = Map.Stairs;
                        break;
                }
                break;
            default:
                break;
        }

        dungeon[loc[0], loc[1], loc[2]] = storedValue;
        return true;
    }
*/
    private void Start()
    {
        mapDispaly = GameObject.FindGameObjectWithTag("Map Display").GetComponent<Transform>();
        if (mapWidth == 0)
        {
            mapWidth = 100;
        }
        if (mapDepth == 0)
        {
            mapDepth = 100;
        }
        if (mapFloors == 0)
        {
            mapFloors = 1;
        }

        dungeon = new Map[mapFloors, mapWidth, mapDepth];
        //NewMap();
    }

    private void NewMap()
    {
        dungeon = new Map[mapFloors, mapWidth, mapDepth];
        for (int f = 0; f < mapFloors; f++)
        {
            for (int w = 0; w < mapWidth; w++)
            {
                for (int d = 0; d < mapDepth; d++)
                {
                    dungeon[f, w, d] = Map.Blank;
                }
            }
        }
        
        DisplayMap();
    }
}
