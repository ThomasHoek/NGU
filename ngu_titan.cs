public void zone6Drop(Enemy enemy)
{
    if (enemy.enemyType != enemyType.bigBoss1)
        return;

    Random.state = this.character.lootState;
    float num1 = Random.value;
    float num2 = this.character.lootFactor();

    int num3 = Random.Range(1, 6);

    float num4 = 0.0f;
    this.itemInfo.makeTitanLoot(102);
    this.log.AddEvent("As the giant, pissed-off chef crumples, you see something fall out of his front pocket. It's a number! I wonder if you can make the number go up?");
    switch (num3)
    {
        case 1:
            this.itemInfo.makeTitanLevelledLoot(78, this.titanLevelBonus());
            this.log.AddEvent(enemy.name + " dropped a Chef's Hat!");
            break;
        case 2:
            this.itemInfo.makeTitanLevelledLoot(79, this.titanLevelBonus());
            this.log.AddEvent(enemy.name + " dropped a Chef's Apron!");
            break;
        case 3:
            this.itemInfo.makeTitanLevelledLoot(80, this.titanLevelBonus());
            this.log.AddEvent(enemy.name + " dropped a Chef's... um, chef's don't really have special pants do they? Screw it, you get regular pants.");
            break;
        case 4:
            this.itemInfo.makeTitanLevelledLoot(81, this.titanLevelBonus());
            this.log.AddEvent(enemy.name + " dropped some special non-slip kitchen shoes! Cool I guess?");
            break;
        case 5:
            this.itemInfo.makeTitanLevelledLoot(82, this.titanLevelBonus());
            this.log.AddEvent(enemy.name + " dropped a Bloody Cleaver!");
            break;
    }
    int num7 = Random.Range(1, 6);
    float num8 = Random.value;
    float num9 = 0.0f;
    if ((double)num8 < (double)(num4 = num9 + 0.5f * num2))
    {
        switch (num7)
        {
            case 1:
                this.itemInfo.makeTitanLevelledLoot(78, Random.Range(0, 3) + this.titanLevelBonus());
                this.log.AddEvent(enemy.name + " dropped a Chef's Hat!");
                break;
            case 2:
                this.itemInfo.makeTitanLevelledLoot(79, Random.Range(0, 3) + this.titanLevelBonus());
                this.log.AddEvent(enemy.name + " dropped a Chef's Apron!");
                break;
            case 3:
                this.itemInfo.makeTitanLevelledLoot(80, Random.Range(0, 3) + this.titanLevelBonus());
                this.log.AddEvent(enemy.name + " dropped a Chef's... um, chef's don't really have special pants do they? Screw it, you get regular pants.");
                break;
            case 4:
                this.itemInfo.makeTitanLevelledLoot(81, Random.Range(0, 3) + this.titanLevelBonus());
                this.log.AddEvent(enemy.name + " dropped some special non-slip kitchen shoes! Cool I guess?");
                break;
            case 5:
                this.itemInfo.makeTitanLevelledLoot(82, Random.Range(0, 3) + this.titanLevelBonus());
                this.log.AddEvent(enemy.name + " dropped a Bloody Cleaver!");
                break;
        }
    }
    float num10 = Random.value;
    float num11 = 0.0f;
    if ((double)num10 < (double)(num4 = num11 + 0.15f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(78, Random.Range(0, 5) + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num12 = Random.value;
    float num13 = 0.0f;
    if ((double)num12 < (double)(num4 = num13 + 0.15f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(79, Random.Range(0, 5) + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num14 = Random.value;
    float num15 = 0.0f;
    if ((double)num14 < (double)(num4 = num15 + 0.15f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(80, Random.Range(0, 5) + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num16 = Random.value;
    float num17 = 0.0f;
    if ((double)num16 < (double)(num4 = num17 + 0.15f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(81, Random.Range(0, 5) + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num18 = Random.value;
    float num19 = 0.0f;
    if ((double)num18 < (double)(num4 = num19 + 0.15f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(82, Random.Range(0, 5) + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num20 = Random.value;
    float num21 = 0.0f;
    if ((double)num20 < (double)(num4 = num21 + 0.15f * num2))
    {
        this.log.AddEvent(enemy.name + " also dropped a Sausage Necklace! That's really weird.");
        this.itemInfo.makeTitanLevelledLoot(83, Random.Range(0, 5) + this.titanLevelBonus());
    }
    float num22 = Random.value;
    float num23 = 0.0f;
    if ((double)num22 < (double)(num4 = num23 + 0.15f * num2))
    {
        this.log.AddEvent(enemy.name + " also dropped a Raw Slab of Meat! Sure, that can be used as an accessory I guess.");
        this.itemInfo.makeTitanLevelledLoot(84, Random.Range(0, 5) + this.titanLevelBonus());
    }
    float num24 = Random.value;
    float num25 = 0.0f;
    if ((double)num24 < (double)(num4 = num25 + 0.1f * num2))
    {
        this.itemInfo.makeTitanLevelledLoot(53, 20);
        this.log.AddEvent(enemy.name + " dropped a forest pendant! Why god why!");
    }
    float num26 = Random.value;
    float num27 = 0.0f;
    if ((double)num26 < (double)(num4 = num27 + 0.2f * num2))
    {
        this.itemInfo.makeTitanLevelledLoot(66, Random.Range(2, 5) + this.titanLevelBonus());
        this.log.AddEvent(enemy.name + " dropped a slightly less busted copy of Wandoos 98!");
    }
    else
    {
        this.itemInfo.makeTitanLevelledLoot(66, 1);
        this.log.AddEvent(enemy.name + " dropped a busted copy of Wandoos 98!");
    }
    this.character.lootState = Random.state;
}

public void zone8Drop(Enemy enemy)
{
    if (enemy.enemyType != enemyType.bigBoss2)
        return;
    Random.state = this.character.lootState;
    float num1 = Random.value;
    float num2 = this.character.lootFactor();
    float num3 = 0.0f;
    this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(400000f)) + " gold! Sweet!");
    long num4 = (long)this.character.adventure.titan2Kills >= this.character.adventure.itopod.perkLevel[34] * 3L ? this.character.addExp(this.character.adventureController.boss2Exp()) : this.character.addExp((float)this.character.adventureController.boss2Exp() * 1.5f);
    long num5 = this.character.addAP(this.character.adventureController.boss2AP());
    this.log.AddEvent("Holy crap, you just beat " + enemy.name + "! You gained " + this.character.display((double)num4) + " EXP and " + (object)num5 + " AP!", 3);
    this.itemInfo.makeTitanLevelledLoot(92, this.titanLevelBonus());
    this.log.AddEvent(enemy.name + " dropped a giant Seed!");
    this.itemInfo.makeTitanLevelledLoot(4, this.titanLevelBonus());
    this.itemInfo.makeTitanLevelledLoot(17, this.titanLevelBonus());
    this.itemInfo.makeTitanLevelledLoot(30, this.titanLevelBonus());
    this.log.AddEvent(enemy.name + " dropped a Power, Toughness, and Special Boost 10!");
    float num6 = Random.value;
    float num7 = 0.0f;
    if ((double)num6 < (double)(num3 = num7 + 0.1f * num2))
    {
        this.itemInfo.makeTitanLevelledLoot(4, this.titanLevelBonus());
        this.log.AddEvent(enemy.name + " dropped an Power Boost 10!");
    }
    float num8 = Random.value;
    float num9 = 0.0f;
    if ((double)num8 < (double)(num3 = num9 + 0.08f * num2))
    {
        this.itemInfo.makeTitanLevelledLoot(5, this.titanLevelBonus());
        this.log.AddEvent(enemy.name + " dropped an Power Boost 20!");
    }
    float num10 = Random.value;
    float num11 = 0.0f;
    if ((double)num10 < (double)(num3 = num11 + 0.05f * num2))
    {
        this.itemInfo.makeTitanLevelledLoot(6, this.titanLevelBonus());
        this.log.AddEvent(enemy.name + " dropped an Power Boost 50! Dayum!");
    }
    float num12 = Random.value;
    float num13 = 0.0f;
    if ((double)num12 < (double)(num3 = num13 + 0.05f * num2))
    {
        this.itemInfo.makeTitanLevelledLoot(7, this.titanLevelBonus());
        this.log.AddEvent(enemy.name + " dropped a Power Boost 100! WOAH.");
    }
    float num14 = Random.value;
    float num15 = 0.0f;
    if ((double)num14 < (double)(num3 = num15 + 0.1f * num2))
    {
        this.itemInfo.makeTitanLevelledLoot(17, this.titanLevelBonus());
        this.log.AddEvent(enemy.name + " dropped a Toughness Boost 10!");
    }
    float num16 = Random.value;
    float num17 = 0.0f;
    if ((double)num16 < (double)(num3 = num17 + 0.08f * num2))
    {
        this.itemInfo.makeTitanLevelledLoot(18, this.titanLevelBonus());
        this.log.AddEvent(enemy.name + " dropped a Toughness Boost 20!");
    }
    float num18 = Random.value;
    float num19 = 0.0f;
    if ((double)num18 < (double)(num3 = num19 + 0.05f * num2))
    {
        this.itemInfo.makeTitanLevelledLoot(19, this.titanLevelBonus());
        this.log.AddEvent(enemy.name + " dropped a Toughness Boost 50! Dayum!");
    }
    float num20 = Random.value;
    float num21 = 0.0f;
    if ((double)num20 < (double)(num3 = num21 + 0.05f * num2))
    {
        this.itemInfo.makeTitanLevelledLoot(20, this.titanLevelBonus());
        this.log.AddEvent(enemy.name + " dropped a Toughness Boost 100! WOAH.");
    }
    float num22 = Random.value;
    float num23 = 0.0f;
    if ((double)num22 < (double)(num3 = num23 + 0.1f * num2))
    {
        this.itemInfo.makeTitanLevelledLoot(30, this.titanLevelBonus());
        this.log.AddEvent(enemy.name + " dropped a Special Boost 10!");
    }
    float num24 = Random.value;
    float num25 = 0.0f;
    if ((double)num24 < (double)(num3 = num25 + 0.08f * num2))
    {
        this.itemInfo.makeTitanLevelledLoot(31, this.titanLevelBonus());
        this.log.AddEvent(enemy.name + " dropped a Special Boost 20!");
    }
    float num26 = Random.value;
    float num27 = 0.0f;
    if ((double)num26 < (double)(num3 = num27 + 0.08f * num2))
    {
        this.itemInfo.makeTitanLevelledLoot(32, this.titanLevelBonus());
        this.log.AddEvent(enemy.name + " dropped a Special Boost 50! Dayum!");
    }
    float num28 = Random.value;
    float num29 = 0.0f;
    if ((double)num28 < (double)(num3 = num29 + 0.05f * num2))
    {
        this.itemInfo.makeTitanLevelledLoot(33, this.titanLevelBonus());
        this.log.AddEvent(enemy.name + " dropped a Special Boost 100! WOAH.");
    }
    float num30 = Random.value;
    float num31 = 0.0f;
    if ((double)num30 < (double)(num3 = num31 + 0.01f * num2))
    {
        this.itemInfo.makeTitanLevelledLoot(93, 5 + this.titanLevelBonus());
        this.log.AddEvent(enemy.name + " dropped a mysterious vial of liquid. Looks legit.");
    }
    float num32 = Random.value;
    float num33 = 0.0f;
    if ((double)num32 < (double)(num3 = num33 + 0.1f * num2))
    {
        this.itemInfo.makeTitanLevelledLoot(53, 50 + this.titanLevelBonus());
        this.log.AddEvent(enemy.name + " dropped a forest pendant! NOT THIS AGAIN!!");
    }
    float num34 = Random.value;
    float num35 = 0.0f;
    if ((double)num34 < (double)(num3 = num35 + 0.2f * num2))
    {
        this.itemInfo.makeTitanLevelledLoot(66, Random.Range(4, 8) + this.titanLevelBonus());
        this.log.AddEvent(enemy.name + " dropped a... hey, a pretty decent copy of Wandoos 98!");
    }
    else
    {
        this.itemInfo.makeTitanLevelledLoot(66, Random.Range(3, 8) + this.titanLevelBonus());
        this.log.AddEvent(enemy.name + " dropped a busted up copy of Wandoos 98!");
    }
    this.character.lootState = Random.state;
    this.checkTreeSecret();
}

public void zone11Drop(Enemy enemy)
{
    if (enemy.enemyType != enemyType.bigBoss3)
        return;
    Random.state = this.character.lootState;
    float num1 = Random.value;
    float num2 = this.character.lootFactor();
    int num3 = Random.Range(1, 6);
    float num4 = 0.0f;
    this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(300000f)) + " gold! Sweet!");
    long num5 = (long)this.character.adventure.titan3Kills >= this.character.adventure.itopod.perkLevel[34] * 3L ? this.character.addExp(this.character.adventureController.boss3Exp()) : this.character.addExp((float)this.character.adventureController.boss3Exp() * 1.5f);
    long num6 = this.character.addAP(this.character.adventureController.boss3AP());
    this.log.AddEvent("Holy crap, you just beat " + enemy.name + "! You gained " + this.character.display((double)num5) + " EXP and " + (object)num6 + " AP!", 3);
    switch (num3)
    {
        case 1:
            this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(111, this.titanLevelBonus()) + this.itemInfo.endRemark());
            break;
        case 2:
            this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(112, this.titanLevelBonus()) + this.itemInfo.endRemark());
            break;
        case 3:
            this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(113, this.titanLevelBonus()) + this.itemInfo.endRemark());
            break;
        case 4:
            this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(114, this.titanLevelBonus()) + this.itemInfo.endRemark());
            break;
        case 5:
            this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(115, this.titanLevelBonus()) + this.itemInfo.endRemark());
            break;
    }
    float num7 = Random.value;
    float num8 = 0.0f;
    if ((double)num7 < (double)(num4 = num8 + 0.6f * num2))
    {
        switch (Random.Range(1, 6))
        {
            case 1:
                this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(111, 1 + this.titanLevelBonus()) + this.itemInfo.endRemark());
                break;
            case 2:
                this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(112, 1 + this.titanLevelBonus()) + this.itemInfo.endRemark());
                break;
            case 3:
                this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(113, 1 + this.titanLevelBonus()) + this.itemInfo.endRemark());
                break;
            case 4:
                this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(114, 1 + this.titanLevelBonus()) + this.itemInfo.endRemark());
                break;
            case 5:
                this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(115, 1 + this.titanLevelBonus()) + this.itemInfo.endRemark());
                break;
        }
    }
    float num9 = Random.value;
    float num10 = 0.0f;
    if ((double)num9 < (double)(num4 = num10 + 0.1f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(111, 2 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num11 = Random.value;
    float num12 = 0.0f;
    if ((double)num11 < (double)(num4 = num12 + 0.1f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(112, 2 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num13 = Random.value;
    float num14 = 0.0f;
    if ((double)num13 < (double)(num4 = num14 + 0.1f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(113, 2 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num15 = Random.value;
    float num16 = 0.0f;
    if ((double)num15 < (double)(num4 = num16 + 0.1f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(114, 2 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num17 = Random.value;
    float num18 = 0.0f;
    if ((double)num17 < (double)(num4 = num18 + 0.1f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(115, 2 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num19 = Random.value;
    float num20 = 0.0f;
    if ((double)num19 < (double)(num4 = num20 + 0.25f * num2))
    {
        switch (Random.Range(1, 3))
        {
            case 1:
                this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(116, 2 + this.titanLevelBonus()) + this.itemInfo.endRemark());
                break;
            case 2:
                this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(117, 2 + this.titanLevelBonus()) + this.itemInfo.endRemark());
                break;
        }
    }
    float num21 = Random.value;
    float num22 = 0.0f;
    if ((double)num21 < (double)(num4 = num22 + 0.1f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(76, 1 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num23 = Random.value;
    float num24 = 0.0f;
    if ((double)num23 < (double)(num4 = num24 + 0.1f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(33, this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num25 = Random.value;
    float num26 = 0.0f;
    if ((double)num25 < (double)(num4 = num26 + 0.1f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(20, this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num27 = Random.value;
    float num28 = 0.0f;
    if ((double)num27 < (double)(num4 = num28 + 0.1f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(7, this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num29 = Random.value;
    float num30 = 0.0f;
    if ((double)num29 < (double)(num4 = num30 + 0.02f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(118, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

    this.character.lootState = Random.state;
    this.log.AddEvent(" You notice a slip of paper in Jake's pocket! You snatch it out of his pocket, it's yours now!");
    this.itemInfo.makeTitanLevelledLoot(197, this.titanLevelBonus());
    this.checkJakeSecret();
}

public void zone14Drop(Enemy enemy)
{
    if (enemy.enemyType != enemyType.bigBoss4)
        return;
    this.character.challenges.blindChallengeUnlocked = true;
    Random.state = this.character.lootState;
    float num1 = Random.value;
    float num2 = this.character.lootFactor();
    float num3 = 0.0f;
    this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(500000f)) + " gold! Sweet!");
    long num4 = (long)this.character.adventure.titan4Kills >= this.character.adventure.itopod.perkLevel[34] * 3L ? this.character.addExp(this.character.adventureController.boss4Exp()) : this.character.addExp((float)this.character.adventureController.boss4Exp() * 1.5f);
    long num5 = this.character.addAP(this.character.adventureController.boss4AP());
    this.log.AddEvent("Holy crap, you just beat " + enemy.name + "! You gained " + this.character.display((double)num4) + "EXP and " + (object)num5 + " AP!", 3);
    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(141, this.titanLevelBonus()) + "! Ewwwwwwwwwwwwwww!");
    if (!this.character.inventory.itemList.itemDropped[136])
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(136, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num6;
    if ((double)num1 < (double)(num6 = num3 + 0.02f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(136, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num7 = Random.value;
    float num8 = 0.0f;
    if ((double)num7 < (double)(num6 = num8 + 0.02f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(137, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num9 = Random.value;
    float num10 = 0.0f;
    if ((double)num9 < (double)(num6 = num10 + 0.02f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(138, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num11 = Random.value;
    float num12 = 0.0f;
    if ((double)num11 < (double)(num6 = num12 + 0.02f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(139, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num13 = Random.value;
    float num14 = 0.0f;
    if ((double)num13 < (double)(num6 = num14 + 0.02f * num2))
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(140, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num15 = Random.value;
    float num16 = 0.0f;
    if ((double)num15 < (double)(num6 = num16 + 0.02f * num2))
    {
        this.itemInfo.makeTitanLoot(53);
        this.log.AddEvent(enemy.name + " dropped the best loot drop of all! :D ");
    }
    if (this.character.inventory.itemList.uugRingComplete)
    {
        float num17 = Random.value;
        float num18 = 0.0f;
        if ((double)num17 < (double)(num6 = num18 + 1f / 1000f * num2))
            this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(149, 4 + this.titanLevelBonus()) + "! Sexy! ;)");
    }
    this.character.lootState = Random.state;
    this.checkUUGSecret();
}

public void zone16Drop(Enemy enemy)
{
    if (enemy.enemyType != enemyType.waldo1 && enemy.enemyType != enemyType.waldo2 && (enemy.enemyType != enemyType.waldo3 && enemy.enemyType != enemyType.waldo4) && enemy.enemyType != enemyType.bigBoss5)
        return;
    if (enemy.enemyType == enemyType.waldo1)
    {
        this.character.adventure.waldoDefeats = 1;
        this.log.AddEvent("As you get the upper hand in the fight, Walderp throws down a smoke bomb and disappears!");
        this.log.AddEvent("'YOU'LL NEVER FIND ME!!' He screams, dodging in and out of the various menus that make up this game. Sigh.");
        this.log.AddEvent("Guess you'll have to go hunt down this annoying asshole. But he could be anywhere...");
    }
    else if (enemy.enemyType == enemyType.waldo2)
    {
        this.character.adventure.waldoDefeats = 2;
        this.log.AddEvent("Just as you move in for the final blow, Walderp throws down a smoke bomb and disappears! Again!");
        this.log.AddEvent("YOU'LL NEVER FIND ME!!' he screeches maniacally. 'AND THIS TIME I MEAN IT!");
    }
    else if (enemy.enemyType == enemyType.waldo3)
    {
        this.character.adventure.waldoDefeats = 3;
        this.log.AddEvent("Once again, Walderp throws down a smoke bomb and disappears! ");
        this.log.AddEvent("STOP FOLLOWING ME!!' he shrieks. 'I COULD ONLY AFFORD A 4-PACK OF THESE SMOKE BOMBS!'");
        this.log.AddEvent("AHA! If you play his stupid game enough times, he won't be able to run away!");
    }
    else if (enemy.enemyType == enemyType.waldo4)
    {
        this.character.adventure.waldoDefeats = 4;
        this.log.AddEvent("For the last time Walderp throws down a smoke bomb and disappears! ");
        this.log.AddEvent("YOU LEAVE ME WITH NO CHOICE! IF YOU COME AGAIN I'll... I'll... run out of ways to stop you :c.'");
    }
    else
    {
        if (enemy.enemyType != enemyType.bigBoss5)
            return;

        this.character.adventure.waldoDefeats = 4;
        ++this.character.adventure.boss5Kills;
        Random.state = this.character.lootState;
        float num1 = Random.value;
        float num2 = this.character.lootFactor();
        float num3 = 0.0f;
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(1000000f)) + " gold! Sweet!");
        long num4 = (long)this.character.adventure.titan5Kills >= this.character.adventure.itopod.perkLevel[34] * 3L ? this.character.addExp(this.character.adventureController.boss5Exp()) : this.character.addExp((float)this.character.adventureController.boss5Exp() * 1.5f);
        long num5 = this.character.addAP(this.character.adventureController.boss5AP());

        this.log.AddEvent("Holy crap, you just beat " + enemy.name + "! You gained " + this.character.display((double)num4) + " EXP and " + (object)num5 + " AP!", 3);
        if ((double)num1 < 0.00999999977648258)
            this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(159, this.titanLevelBonus()) + this.itemInfo.endRemark());
        else
            this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(154, 10 + this.titanLevelBonus()) + this.itemInfo.endRemark());

        float num6 = Random.value;
        float num7 = 0.0f;
        if ((double)num6 < (double)(num3 = num7 + 0.005f * num2))
            this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(150, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

        float num8 = Random.value;
        float num9 = 0.0f;
        if ((double)num8 < (double)(num3 = num9 + 0.005f * num2))
            this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(151, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

        float num10 = Random.value;
        float num11 = 0.0f;
        if ((double)num10 < (double)(num3 = num11 + 0.005f * num2))
            this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(152, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

        float num12 = Random.value;
        float num13 = 0.0f;
        if ((double)num12 < (double)(num3 = num13 + 0.005f * num2))
            this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(153, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

        float num14 = Random.value;
        float num15 = 0.0f;
        if ((double)num14 < (double)(num3 = num15 + 0.005f * num2))
        {
            float num16 = Random.value;
            num3 = 0.0f;
            if ((double)num16 < 0.00999999977648258)
                this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(159, this.titanLevelBonus()) + this.itemInfo.endRemark());
            else
                this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(154, 10 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        }
        float num17 = Random.value;
        float num18 = 0.0f;
        if ((double)num17 < (double)(num3 = num18 + 0.005f * num2))
            this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(163, 20 + this.titanLevelBonus()) + this.itemInfo.endRemark());

        float num19 = Random.value;
        float num20 = 0.0f;

        if ((double)num19 < (double)(num3 = num20 + 0.005f * num2))
            this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(155, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

        float num21 = Random.value;
        float num22 = 0.0f;
        if ((double)num21 < (double)(num3 = num22 + 0.005f * num2))
            this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(156, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

        float num23 = Random.value;
        float num24 = 0.0f;
        if ((double)num23 < (double)(num3 = num24 + 0.005f * num2))
            this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(157, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

        float num25 = Random.value;
        float num26 = 0.0f;
        if ((double)num25 < (double)(num3 = num26 + 0.005f * num2))
            this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(158, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

        float num27 = Random.value;
        float num28 = 0.0f;
        if ((double)num27 < (double)(num3 = num28 + 0.005f * num2))
            this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(76, 50 + this.titanLevelBonus()) + this.itemInfo.endRemark());

        if (this.character.inventory.itemList.waldoComplete)
        {
            float num16 = Random.value;
            float num29 = 0.0f;
            if ((double)num16 < (double)(num3 = num29 + 0.0001f * num2))
                this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(160, 10 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        }

        if (this.character.inventory.itemList.antiWaldoComplete)
        {
            float num16 = Random.value;
            float num29 = 0.0f;
            if ((double)num16 < (double)(num3 = num29 + 0.0001f * num2))
                this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(161, 10 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        }
        this.character.lootState = Random.state;
    }
}


public void zone19Drop(Enemy enemy)
{
    if (enemy.enemyType != enemyType.guardian && enemy.enemyType != enemyType.bigBoss6V1 && (enemy.enemyType != enemyType.bigBoss6V2 && enemy.enemyType != enemyType.bigBoss6V3) && enemy.enemyType != enemyType.bigBoss6V4)
        return;
    if (enemy.enemyType == enemyType.guardian)
    {
        this.itemInfo.makeLevelledLoot(179, 100);
        this.log.AddEvent("The Skeleton Guardian lets out a small sigh as it collapses to dust. What on earth was that thing??");
        this.log.AddEvent("You see a small curled note left behind in the dust and fish it out.");
    }
    else
    {
        if (enemy.enemyType != enemyType.bigBoss6V1 && enemy.enemyType != enemyType.bigBoss6V2 && (enemy.enemyType != enemyType.bigBoss6V3 && enemy.enemyType != enemyType.bigBoss6V4))
            return;
        ++this.character.adventure.boss6Kills;
        Random.state = this.character.lootState;
        float num1 = Random.value;
        float num2 = this.character.lootFactor();
        float num3 = 0.0f;
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(5000000f)) + " gold! Sweet!");
        long num4 = (long)this.character.adventure.titan6Kills >= this.character.adventure.itopod.perkLevel[34] * 3L ? this.character.addExp((float)this.character.adventureController.boss6Exp() * this.higherVFactor(enemy.enemyType)) : this.character.addExp((float)this.character.adventureController.boss6Exp() * 1.5f * this.higherVFactor(enemy.enemyType));
        this.log.AddEvent("Holy crap, you just beat " + enemy.name + "! You gained " + this.character.display((double)num4) + " EXP!", 3);
        if (this.character.wishes.wishes[73].level > 0)
        {
            long num5 = (long)((double)this.character.adventureController.boss6QP() * (double)this.higherVFactor(enemy.enemyType));
            this.character.beastQuest.quirkPoints += num5;
            this.log.AddEvent("You gained " + (object)num5 + " QP thanks to your wish!");
        }
        this.character.adventureController.itopod.addProgress((long)((double)this.character.adventureController.boss6PP() * (double)this.higherVFactor(enemy.enemyType)));
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(292, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num6 = Random.value;
        float num7 = 0.0f;
        if ((double)num6 < (double)(num3 = num7 + 0.0005f * num2))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(184, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num8 = Random.value;
        float num9 = 0.0f;
        if ((double)num8 < (double)(num3 = num9 + 0.0005f * num2))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(185, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num10 = Random.value;
        float num11 = 0.0f;
        if ((double)num10 < (double)(num3 = num11 + 0.0005f * num2))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(186, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num12 = Random.value;
        float num13 = 0.0f;
        if ((double)num12 < (double)(num3 = num13 + 0.0005f * num2))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(187, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num14 = Random.value;
        float num15 = 0.0f;
        if ((double)num14 < (double)(num3 = num15 + 0.0005f * num2))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(188, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num16 = Random.value;
        float num17 = 0.0f;
        if ((double)num16 < (double)(num3 = num17 + 0.0005f * num2))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(142, 1 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num18 = Random.value;
        float num19 = 0.0f;
        if ((double)num18 < (double)(num3 = num19 + 0.0002f * num2))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(189, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        if (enemy.enemyType == enemyType.bigBoss6V2 || enemy.enemyType == enemyType.bigBoss6V3 || enemy.enemyType == enemyType.bigBoss6V4)
        {
            float num5 = Random.value;
            float num20 = 0.0f;
            if ((double)num5 < (double)(num3 = num20 + 5E-05f * num2))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(190, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
            float num21 = Random.value;
            float num22 = 0.0f;
            if ((double)num21 < (double)(num3 = num22 + 2E-05f * num2))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(191, 1 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        }
        if (enemy.enemyType == enemyType.bigBoss6V3 || enemy.enemyType == enemyType.bigBoss6V4)
        {
            float num5 = Random.value;
            float num20 = 0.0f;
            if ((double)num5 < (double)(num3 = num20 + 1E-05f * num2))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(192, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
            float num21 = Random.value;
            float num22 = 0.0f;
            if ((double)num21 < (double)(num3 = num22 + 5E-06f * num2))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(193, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        }
        if (enemy.enemyType == enemyType.bigBoss6V4)
        {
            float num5 = Random.value;
            float num20 = 0.0f;
            if ((double)num5 < (double)(num3 = num20 + 2E-06f * num2))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(194, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
            float num21 = Random.value;
            float num22 = 0.0f;
            if ((double)num21 < (double)(num3 = num22 + 1E-06f * num2))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(195, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        }
        this.character.lootState = Random.state;
    }
}

public void zone23Drop(Enemy enemy)
{
    if (enemy.enemyType != enemyType.boss7Guardian && enemy.enemyType != enemyType.bigBoss7V1 && (enemy.enemyType != enemyType.bigBoss7V2 && enemy.enemyType != enemyType.bigBoss7V3) && enemy.enemyType != enemyType.bigBoss7V4)
        return;
    if (enemy.enemyType == enemyType.boss7Guardian)
    {
        this.character.adventure.titan7questStarted = true;
        this.character.tooltip.showOverrideTooltip("With the Greasy Nerd's mom dispatched, you head down to the basement to confront the Titan. But dammit - the door's locked with a 5 letter combination lock! You hear the nerd sneer from the other side of the door: 'Only the biggest NGU fans can find my secret passcode scattered in the beautifully crafted LORE!'", 10f);
    }
    else
    {
        if (enemy.enemyType != enemyType.bigBoss7V1 && enemy.enemyType != enemyType.bigBoss7V2 && (enemy.enemyType != enemyType.bigBoss7V3 && enemy.enemyType != enemyType.bigBoss7V4))
            return;
        ++this.character.adventure.boss7Kills;
        Random.state = this.character.lootState;
        float num1 = Random.value;
        float num2 = this.character.lootFactorRooted();
        float num3 = 0.0f;
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(1E+10f)) + " gold! Sweet!");
        long num4 = (long)this.character.adventure.titan7Kills >= this.character.adventure.itopod.perkLevel[34] * 3L ? this.character.addExp((float)this.character.adventureController.boss7Exp() * this.higherVFactor(enemy.enemyType)) : this.character.addExp((float)this.character.adventureController.boss7Exp() * 1.5f * this.higherVFactor(enemy.enemyType));
        this.log.AddEvent("Holy crap, you just beat " + enemy.name + "! You gained " + this.character.display((double)num4) + " EXP!", 3);
        this.character.adventureController.itopod.addProgress((long)((double)this.character.adventureController.boss7PP() * (double)this.higherVFactor(enemy.enemyType)));
        if (this.character.wishes.wishes[74].level > 0)
        {
            long num5 = (long)((double)this.character.adventureController.boss7QP() * (double)this.higherVFactor(enemy.enemyType));
            this.character.beastQuest.quirkPoints += num5;
            this.log.AddEvent("You gained " + (object)num5 + " QP thanks to your wish!");
        }
        switch (Random.Range(1, 8))
        {
            case 1:
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(237, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
                break;
            case 2:
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(238, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
                break;
            case 3:
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(239, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
                break;
            case 4:
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(240, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
                break;
            case 5:
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(241, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
                break;
            case 6:
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(242, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
                break;
            case 7:
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(243, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
                break;
        }
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(294, 1 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num6 = Random.value;
        float num7 = 0.0f;
        if ((double)num6 < (double)Mathf.Min(num3 = num7 + 0.00035f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(237, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

        float num8 = Random.value;
        float num9 = 0.0f;
        if ((double)num8 < (double)Mathf.Min(num3 = num9 + 0.00035f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(238, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

        float num10 = Random.value;
        float num11 = 0.0f;
        if ((double)num10 < (double)Mathf.Min(num3 = num11 + 0.00035f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(239, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

        float num12 = Random.value;
        float num13 = 0.0f;
        if ((double)num12 < (double)Mathf.Min(num3 = num13 + 0.00035f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(240, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

        float num14 = Random.value;
        float num15 = 0.0f;
        if ((double)num14 < (double)Mathf.Min(num3 = num15 + 0.00035f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(241, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

        float num16 = Random.value;
        float num17 = 0.0f;
        if ((double)num16 < (double)Mathf.Min(num3 = num17 + 0.00023f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(242, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

        float num18 = Random.value;
        float num19 = 0.0f;
        if ((double)num18 < (double)Mathf.Min(num3 = num19 + 0.00035f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(243, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

        float num20 = Random.value;
        float num21 = 0.0f;
        if ((double)num20 < (double)Mathf.Min(num3 = num21 + 0.00035f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(170, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

        this.dropRandomMacguffin(enemy.name, this.titanLevelBonus());
        if (enemy.enemyType == enemyType.bigBoss7V2 || enemy.enemyType == enemyType.bigBoss7V3 || enemy.enemyType == enemyType.bigBoss7V4)
        {
            float num5 = Random.value;
            float num22 = 0.0f;
            if ((double)num5 < (double)Mathf.Min(num3 = num22 + 0.00027f * num2, 0.25f))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(244, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

            float num23 = Random.value;
            float num24 = 0.0f;
            if ((double)num23 < (double)Mathf.Min(num3 = num24 + 0.00027f * num2, 0.25f))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(245, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        }
        if (enemy.enemyType == enemyType.bigBoss7V3 || enemy.enemyType == enemyType.bigBoss7V4)
        {
            float num5 = Random.value;
            float num22 = 0.0f;
            if ((double)num5 < (double)Mathf.Min(num3 = num22 + 0.00022f * num2, 0.25f))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(246, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

            float num23 = Random.value;
            float num24 = 0.0f;
            if ((double)num23 < (double)Mathf.Min(num3 = num24 + 0.00022f * num2, 0.25f))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(247, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        }
        if (enemy.enemyType == enemyType.bigBoss7V4)
        {
            float num5 = Random.value;
            float num22 = 0.0f;
            if ((double)num5 < (double)Mathf.Min(num3 = num22 + 0.00017f * num2, 0.25f))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(248, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());

            float num23 = Random.value;
            float num24 = 0.0f;
            if ((double)num23 < (double)Mathf.Min(num3 = num24 + 0.00017f * num2, 0.25f))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(249, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        }
        if (this.character.achievements.achievementComplete[145])
            this.dropMacguffin(enemy.name, 291, 0);

        this.character.lootState = Random.state;
    }
}

public void zone26Drop(Enemy enemy)
{
    if (enemy.enemyType != enemyType.boss8Guardian && enemy.enemyType != enemyType.bigBoss8V1 && (enemy.enemyType != enemyType.bigBoss8V2 && enemy.enemyType != enemyType.bigBoss8V3) && enemy.enemyType != enemyType.bigBoss8V4)
        return;
    if (enemy.enemyType == enemyType.boss8Guardian)
    {
        if (this.character.adventure.emptyNameWhacked && this.character.adventure.icarusWhacked && (this.character.adventure.kingCircleWhacked && this.character.adventure.robBossWhacked) && this.character.adventure.skeletonWhacked)
        {
            this.character.adventure.titan8Unlocked = true;
            this.log.AddEvent("You defeated the Consigliere, and this time for good. You pull out the Death Note he gave you.");
            this.log.AddEvent("You add his name to the bottom of the list and toss it on his body, and enter the doors to see THE GODMOTHER.");
        }
        else
        {
            this.character.adventure.titan8questStarted = true;
            this.itemInfo.makeTitanLevelledLoot(288, 100);
            this.log.AddEvent("The Consigliere wipes a trickle of blood from his mouth before delivering a massive haymaker!");
            this.log.AddEvent("You feel the air burst out of your lungs as you slam against the wall on the other side of the room.");
            this.log.AddEvent("He walks over and hands you a small piece of paper. 'Alright tough guy, you want an audience with the");
            this.log.AddEvent("Godmother? Go whack off all the guys on this list, then we'll talk.");
        }
    }
    else
    {
        if (enemy.enemyType != enemyType.bigBoss8V1 && enemy.enemyType != enemyType.bigBoss8V2 && (enemy.enemyType != enemyType.bigBoss8V3 && enemy.enemyType != enemyType.bigBoss8V4))
            return;
        ++this.character.adventure.boss8Kills;
        Random.state = this.character.lootState;
        float num1 = Random.value;
        float num2 = this.character.lootFactorRooted();
        float num3 = 0.0f;
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(1E+11f)) + " gold! Sweet!");
        long num4 = (long)this.character.adventure.titan8Kills >= this.character.adventure.itopod.perkLevel[34] * 3L ? this.character.addExp((float)this.character.adventureController.boss8Exp() * this.higherVFactor(enemy.enemyType)) : this.character.addExp((float)this.character.adventureController.boss8Exp() * 1.5f * this.higherVFactor(enemy.enemyType));
        this.log.AddEvent("Holy crap, you just beat " + enemy.name + "! You gained " + this.character.display((double)num4) + " EXP!", 3);
        this.character.adventureController.itopod.addProgress((long)((double)this.character.adventureController.boss8PP() * (double)this.higherVFactor(enemy.enemyType)));
        if (this.character.wishes.wishes[40].level > 0)
        {
            long num5 = (long)((double)this.character.adventureController.boss8QP() * (double)this.higherVFactor(enemy.enemyType));
            this.character.beastQuest.quirkPoints += num5;
            this.log.AddEvent("You gained " + (object)num5 + " QP thanks to your wish!");
        }
        float num6 = Random.value;
        float num7 = 0.0f;
        if ((double)num6 < (double)Mathf.Min(num3 = num7 + 0.0001f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(265, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num8 = Random.value;
        float num9 = 0.0f;
        if ((double)num8 < (double)Mathf.Min(num3 = num9 + 0.0001f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(266, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num10 = Random.value;
        float num11 = 0.0f;
        if ((double)num10 < (double)Mathf.Min(num3 = num11 + 0.0001f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(267, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num12 = Random.value;
        float num13 = 0.0f;
        if ((double)num12 < (double)Mathf.Min(num3 = num13 + 0.0001f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(268, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num14 = Random.value;
        float num15 = 0.0f;
        if ((double)num14 < (double)Mathf.Min(num3 = num15 + 0.0001f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(269, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num16 = Random.value;
        float num17 = 0.0f;
        if ((double)num16 < (double)Mathf.Min(num3 = num17 + 0.0001f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(270, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num18 = Random.value;
        float num19 = 0.0f;
        if ((double)num18 < (double)Mathf.Min(num3 = num19 + 0.0001f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(271, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num20 = Random.value;
        float num21 = 0.0f;
        if ((double)num20 < (double)Mathf.Min(num3 = num21 + 0.0001f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(170, 8 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num22 = Random.value;
        float num23 = 0.0f;
        if ((double)num22 < (double)Mathf.Min(num3 = num23 + 0.0001f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeTitanLevelledLoot(169, 8) + this.itemInfo.endRemark());
        this.dropRandomMacguffin(enemy.name, this.titanLevelBonus());
        if (this.character.achievements.achievementComplete[145])
        {
            float num5 = Random.value;
            float num24 = 0.0f;
            if ((double)num5 < (double)Mathf.Min(num3 = num24 + 0.0001f * num2, 0.25f))
                this.dropMacguffin(enemy.name, 298, 0);
        }
        this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeTitanLevelledLoot(343, 1) + this.itemInfo.endRemark());
        if (enemy.enemyType == enemyType.bigBoss8V2 || enemy.enemyType == enemyType.bigBoss8V3 || enemy.enemyType == enemyType.bigBoss8V4)
        {
            float num5 = Random.value;
            float num24 = 0.0f;
            if ((double)num5 < (double)Mathf.Min(num3 = num24 + 7.5E-05f * num2, 0.25f))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(272, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
            float num25 = Random.value;
            float num26 = 0.0f;
            if ((double)num25 < (double)Mathf.Min(num3 = num26 + 7.5E-05f * num2, 0.25f))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(273, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
            if (this.character.achievements.achievementComplete[145])
            {
                float num27 = Random.value;
                float num28 = 0.0f;
                if ((double)num27 < (double)Mathf.Min(num3 = num28 + 7.5E-05f * num2, 0.25f))
                    this.dropMacguffin(enemy.name, 299, 0);
            }
        }
        if (enemy.enemyType == enemyType.bigBoss8V3 || enemy.enemyType == enemyType.bigBoss8V4)
        {
            float num5 = Random.value;
            float num24 = 0.0f;
            if ((double)num5 < (double)Mathf.Min(num3 = num24 + 6E-05f * num2, 0.25f))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(274, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
            float num25 = Random.value;
            float num26 = 0.0f;
            if ((double)num25 < (double)Mathf.Min(num3 = num26 + 6E-05f * num2, 0.25f))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(275, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
            if (this.character.achievements.achievementComplete[145])
            {
                float num27 = Random.value;
                float num28 = 0.0f;
                if ((double)num27 < (double)Mathf.Min(num3 = num28 + 6E-05f * num2, 0.25f))
                    this.dropMacguffin(enemy.name, 300, 0);
            }
        }
        if (enemy.enemyType == enemyType.bigBoss8V4)
        {
            float num5 = Random.value;
            float num24 = 0.0f;
            if ((double)num5 < (double)Mathf.Min(num3 = num24 + 4.5E-05f * num2, 0.25f))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(276, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
            float num25 = Random.value;
            float num26 = 0.0f;
            if ((double)num25 < (double)Mathf.Min(num3 = num26 + 4.5E-05f * num2, 0.25f))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(277, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        }
        this.character.lootState = Random.state;
    }
}

public void zone30Drop(Enemy enemy)
{
    if (enemy.enemyType != enemyType.boss9Guardian && enemy.enemyType != enemyType.bigBoss9V1 && (enemy.enemyType != enemyType.bigBoss9V2 && enemy.enemyType != enemyType.bigBoss9V3) && enemy.enemyType != enemyType.bigBoss9V4)
        return;
    if (enemy.enemyType == enemyType.boss9Guardian)
    {
        if (this.character.inventory.weapon.id == 335)
        {
            this.itemInfo.makeTitanLevelledLoot(336, 100);
            this.log.AddEvent("You slap the Priest's bald head with the Dark Seal before he can escape!");
            this.log.AddEvent("With an unholy wail he crumbles into dust.... which begins to form into something!");
            this.log.AddEvent("It's a grotesque face! You put on some gloves and gingerly add it to your inventory. ");
        }
        else
        {
            this.itemInfo.makeTitanLevelledLoot(335, 100);
            this.log.AddEvent("The Priest disappears in a beam of black light, leaving a dark seal on the ground!");
            this.log.AddEvent("You grab it before the wind takes it away. There seems to be some writing on the back...");
        }
    }
    else
    {
        if (enemy.enemyType != enemyType.bigBoss9V1 && enemy.enemyType != enemyType.bigBoss9V2 && (enemy.enemyType != enemyType.bigBoss9V3 && enemy.enemyType != enemyType.bigBoss9V4))
            return;
        ++this.character.adventure.boss9Kills;
        Random.state = this.character.lootState;
        float num1 = Random.value;
        float num2 = this.character.lootFactorRooted();
        float num3 = 0.0f;
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(1E+12f)) + " gold! Sweet!");
        long num4 = (long)this.character.adventure.titan9Kills >= this.character.adventure.itopod.perkLevel[34] * 3L ? this.character.addExp((float)this.character.adventureController.boss9Exp() * this.higherVFactor(enemy.enemyType)) : this.character.addExp((float)this.character.adventureController.boss9Exp() * 1.5f * this.higherVFactor(enemy.enemyType));
        this.log.AddEvent("Holy crap, you just beat " + enemy.name + "! You gained " + this.character.display((double)num4) + " EXP!", 3);
        this.character.adventureController.itopod.addProgress((long)((double)this.character.adventureController.boss9PP() * (double)this.higherVFactor(enemy.enemyType)));
        if (this.character.wishes.wishes[41].level > 0)
        {
            long num5 = (long)((double)this.character.adventureController.boss9QP() * (double)this.higherVFactor(enemy.enemyType));
            this.character.beastQuest.quirkPoints += num5;
            this.log.AddEvent("You gained " + (object)num5 + " QP thanks to your wish!");
        }
        this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeTitanLevelledLoot(391, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num6 = Random.value;
        float num7 = 0.0f;
        if ((double)num6 < (double)Mathf.Min(num3 = num7 + 2E-05f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(322, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num8 = Random.value;
        float num9 = 0.0f;
        if ((double)num8 < (double)Mathf.Min(num3 = num9 + 2E-05f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(323, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num10 = Random.value;
        float num11 = 0.0f;
        if ((double)num10 < (double)Mathf.Min(num3 = num11 + 2E-05f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(324, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num12 = Random.value;
        float num13 = 0.0f;
        if ((double)num12 < (double)Mathf.Min(num3 = num13 + 2E-05f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(325, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num14 = Random.value;
        float num15 = 0.0f;
        if ((double)num14 < (double)Mathf.Min(num3 = num15 + 2E-05f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(326, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num16 = Random.value;
        float num17 = 0.0f;
        if ((double)num16 < (double)Mathf.Min(num3 = num17 + 2E-05f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(327, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num18 = Random.value;
        float num19 = 0.0f;
        if ((double)num18 < (double)Mathf.Min(num3 = num19 + 2E-05f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(328, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num20 = Random.value;
        float num21 = 0.0f;
        if ((double)num20 < (double)Mathf.Min(num3 = num21 + 1.5E-05f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(170, 50 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num22 = Random.value;
        float num23 = 0.0f;
        if ((double)num22 < (double)Mathf.Min(num3 = num23 + 1.5E-05f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeTitanLevelledLoot(169, 50 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        this.dropRandomMacguffin(enemy.name, this.titanLevelBonus());
        if (enemy.enemyType == enemyType.bigBoss9V2 || enemy.enemyType == enemyType.bigBoss9V3 || enemy.enemyType == enemyType.bigBoss9V4)
        {
            float num5 = Random.value;
            float num24 = 0.0f;
            if ((double)num5 < (double)Mathf.Min(num3 = num24 + 1E-05f * num2, 0.25f))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(329, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
            float num25 = Random.value;
            float num26 = 0.0f;
            if ((double)num25 < (double)Mathf.Min(num3 = num26 + 1E-05f * num2, 0.25f))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(330, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        }
        if (enemy.enemyType == enemyType.bigBoss9V3 || enemy.enemyType == enemyType.bigBoss9V4)
        {
            float num5 = Random.value;
            float num24 = 0.0f;
            if ((double)num5 < (double)Mathf.Min(num3 = num24 + 6E-06f * num2, 0.25f))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(331, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
            float num25 = Random.value;
            float num26 = 0.0f;
            if ((double)num25 < (double)Mathf.Min(num3 = num26 + 6E-06f * num2, 0.25f))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(332, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        }
        if (enemy.enemyType == enemyType.bigBoss9V4)
        {
            if (!this.character.settings.exilev4Defeated)
                this.character.settings.exilev4Defeated = true;
            float num5 = Random.value;
            float num24 = 0.0f;
            if ((double)num5 < (double)Mathf.Min(num3 = num24 + 4E-06f * num2, 0.25f))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(333, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
            float num25 = Random.value;
            float num26 = 0.0f;
            if ((double)num25 < (double)Mathf.Min(num3 = num26 + 4E-06f * num2, 0.25f))
                this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(334, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        }
        if (this.character.inventory.itemList.exileComplete)
        {
            float num5 = Random.value;
            num3 = 0.0f;
            if ((double)num5 < 0.0199999995529652)
                this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeTitanLevelledLoot(341, 100) + this.itemInfo.endRemark());
        }
        if (this.character.inventory.itemList.exileComplete)
        {
            float num5 = Random.value;
            num3 = 0.0f;
            if ((double)num5 < 0.25)
                this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(336, 100) + this.itemInfo.endRemark());
        }
        if (this.character.adventure.titan9SpecialReward)
        {
            float num5 = Random.value;
            float num24 = 0.0f;
            if ((double)num5 < (double)Mathf.Min(num3 = num24 + 1E-06f * num2, 0.25f))
                this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeTitanLevelledLoot(342, 0) + this.itemInfo.endRemark());
        }
        this.character.lootState = Random.state;
    }
}