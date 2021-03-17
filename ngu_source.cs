public void zone33Drop(Enemy enemy)
{
    Random.state = this.character.lootState;
    float num1 = Random.value;
    Random.Range(0, 5);
    float num2 = this.character.lootFactorRooted();
    float num3 = 0.0f;
    float num4;
    if (enemy.enemyType == enemyType.normal)
    {
        
        float num7 = 0.0f;
        if ((double)Random.value < (double)Mathf.Min(num4 = num7 + 1E-07f * num2, 0.04f))
        {
            switch (Random.Range(0, 7))
            {
                case 0:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(359, 1) + this.itemInfo.endRemark());
                    break;
                case 1:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(360, 1) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(361, 1) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(362, 1) + this.itemInfo.endRemark());
                    break;
                case 4:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(363, 1) + this.itemInfo.endRemark());
                    break;
                case 5:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(364, 1) + this.itemInfo.endRemark());
                    break;
                case 6:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(365, 1) + this.itemInfo.endRemark());
                    break;
            }
        }
        if (this.character.inventory.itemList.westernComplete)
        {
            float num8 = Random.value;
            float num9 = 0.0f;
            if ((double)num8 < (double)Mathf.Min(num4 = num9 + 2E-08f * num2, 0.12f))
                this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(366, 1) + this.itemInfo.endRemark());
        }
    }
    else if (enemy.enemyType == enemyType.boss)
    {
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(4E+14f)) + " gold! Sweet!");
        if ((double)num1 < (double)Mathf.Min(num4 = num3 + 3E-07f * num2, 0.15f))
            this.log.AddEvent(enemy.name + " also dropped " + this.character.display((double)this.character.addExp(600L)) + " EXP! Holy crap!", 3);
        float num5 = 0.0f;
        if ((double)Random.value < (double)Mathf.Min(num4 = num5 + 3E-07f * num2, 0.15f))
        {
            switch (Random.Range(0, 7))
            {
                case 0:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(359, 1) + this.itemInfo.endRemark());
                    break;
                case 1:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(360, 1) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(361, 1) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(362, 1) + this.itemInfo.endRemark());
                    break;
                case 4:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(363, 1) + this.itemInfo.endRemark());
                    break;
                case 5:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(364, 1) + this.itemInfo.endRemark());
                    break;
                case 6:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(365, 1) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num6 = Random.value;
        float num7 = 0.0f;
        if ((double)num6 < (double)Mathf.Min(num4 = num7 + 1E-06f * num2, 0.12f))
            this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(229, 1) + this.itemInfo.endRemark());
        if (this.character.inventory.itemList.westernComplete)
        {
            float num8 = Random.value;
            float num9 = 0.0f;
            if ((double)num8 < (double)Mathf.Min(num4 = num9 + 6E-08f * num2, 0.12f))
                this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(366, 1) + this.itemInfo.endRemark());
        }
        float num10 = Random.value;
        float num11 = 0.0f;
        if ((double)num10 < (double)Mathf.Min(num4 = num11 + 3E-07f * num2, 0.12f))
            this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(230, 1) + this.itemInfo.endRemark());
    }
    this.character.lootState = Random.state;
}

public void zone34Drop(Enemy enemy)
{
    if (enemy.enemyType != enemyType.boss10Guardian && enemy.enemyType != enemyType.bigBoss10V1 && (enemy.enemyType != enemyType.bigBoss10V2 && enemy.enemyType != enemyType.bigBoss10V3) && enemy.enemyType != enemyType.bigBoss10V4 || (enemy.enemyType == enemyType.boss10Guardian || enemy.enemyType != enemyType.bigBoss10V1 && enemy.enemyType != enemyType.bigBoss10V2 && (enemy.enemyType != enemyType.bigBoss10V3 && enemy.enemyType != enemyType.bigBoss10V4)))
        return;
    ++this.character.adventure.boss10Kills;
    Random.state = this.character.lootState;
    float num1 = Random.value;
    float num2 = this.character.lootFactorRooted();
    float num3 = 0.0f;
    this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(2E+15f)) + " gold! Sweet!");
    long num4 = (long)this.character.adventure.titan10Kills >= this.character.adventure.itopod.perkLevel[34] * 3L ? this.character.addExp((float)this.character.adventureController.boss10Exp() * this.higherVFactor(enemy.enemyType)) : this.character.addExp((float)this.character.adventureController.boss10Exp() * 1.5f * this.higherVFactor(enemy.enemyType));
    this.log.AddEvent("Holy crap, you just beat " + enemy.name + "! You gained " + this.character.display((double)num4) + " EXP!", 3);
    this.character.adventureController.itopod.addProgress((long)((double)this.character.adventureController.boss10PP() * (double)this.higherVFactor(enemy.enemyType)));
    if (this.character.wishes.wishes[100].level > 0)
    {
        long num5 = (long)((double)this.character.adventureController.boss10QP() * (double)this.higherVFactor(enemy.enemyType));
        this.character.beastQuest.quirkPoints += num5;
        this.log.AddEvent("You gained " + (object)num5 + " QP thanks to your wish!");
    }
    float num6 = Random.value;
    float num7 = 0.0f;
    if ((double)num6 < (double)Mathf.Min(num3 = num7 + 1E-06f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(373, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num8 = Random.value;
    float num9 = 0.0f;
    if ((double)num8 < (double)Mathf.Min(num3 = num9 + 1E-06f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(374, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num10 = Random.value;
    float num11 = 0.0f;
    if ((double)num10 < (double)Mathf.Min(num3 = num11 + 1E-06f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(375, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num12 = Random.value;
    float num13 = 0.0f;
    if ((double)num12 < (double)Mathf.Min(num3 = num13 + 1E-06f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(376, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num14 = Random.value;
    float num15 = 0.0f;
    if ((double)num14 < (double)Mathf.Min(num3 = num15 + 1E-06f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(377, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num16 = Random.value;
    float num17 = 0.0f;
    if ((double)num16 < (double)Mathf.Min(num3 = num17 + 1E-06f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(378, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num18 = Random.value;
    float num19 = 0.0f;
    if ((double)num18 < (double)Mathf.Min(num3 = num19 + 1E-06f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(379, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num20 = Random.value;
    float num21 = 0.0f;
    if ((double)num20 < (double)Mathf.Min(num3 = num21 + 1E-06f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(380, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num22 = Random.value;
    float num23 = 0.0f;
    if ((double)num22 < (double)Mathf.Min(num3 = num23 + 1E-06f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(229, 50 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num24 = Random.value;
    float num25 = 0.0f;
    if ((double)num24 < (double)Mathf.Min(num3 = num25 + 1E-06f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeTitanLevelledLoot(230, 50 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    this.dropRandomMacguffin(enemy.name, this.titanLevelBonus());
    if (enemy.enemyType == enemyType.bigBoss10V2 || enemy.enemyType == enemyType.bigBoss10V3 || enemy.enemyType == enemyType.bigBoss10V4)
    {
        float num5 = Random.value;
        float num26 = 0.0f;
        if ((double)num5 < (double)Mathf.Min(num3 = num26 + 6E-07f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(381, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num27 = Random.value;
        float num28 = 0.0f;
        if ((double)num27 < (double)Mathf.Min(num3 = num28 + 6E-07f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(382, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    }
    if (enemy.enemyType == enemyType.bigBoss10V3 || enemy.enemyType == enemyType.bigBoss10V4)
    {
        float num5 = Random.value;
        float num26 = 0.0f;
        if ((double)num5 < (double)Mathf.Min(num3 = num26 + 4E-07f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(383, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num27 = Random.value;
        float num28 = 0.0f;
        if ((double)num27 < (double)Mathf.Min(num3 = num28 + 4E-07f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(384, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    }
    if (enemy.enemyType == enemyType.bigBoss10V4)
    {
        float num5 = Random.value;
        float num26 = 0.0f;
        if ((double)num5 < (double)Mathf.Min(num3 = num26 + 3E-07f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(385, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num27 = Random.value;
        float num28 = 0.0f;
        if ((double)num27 < (double)Mathf.Min(num3 = num28 + 3E-07f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(386, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    }
    this.character.lootState = Random.state;
}

public void zone35Drop(Enemy enemy)
{
    Random.state = this.character.lootState;
    float num1 = Random.value;
    Random.Range(0, 5);
    float num2 = this.character.lootFactorRooted();
    float num3 = 0.0f;
    float num4;
    if (enemy.enemyType == enemyType.normal)
    {
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(1.2E+15f)) + " gold! Sweet!");
        if ((double)num1 < (double)Mathf.Min(num4 = num3 + 1E-07f * num2, 0.15f))
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(12) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(25) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(38) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num5 = Random.value;
        float num6 = 0.0f;
        if ((double)num5 < (double)Mathf.Min(num4 = num6 + 1E-07f * num2, 0.15f))
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(13) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(26) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(39) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num7 = 0.0f;
        if ((double)Random.value < (double)Mathf.Min(num4 = num7 + 4E-08f * num2, 0.04f))
        {
            switch (Random.Range(0, 8))
            {
                case 0:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(392, 1) + this.itemInfo.endRemark());
                    break;
                case 1:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(393, 1) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(394, 1) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(395, 1) + this.itemInfo.endRemark());
                    break;
                case 4:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(396, 1) + this.itemInfo.endRemark());
                    break;
                case 5:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(397, 1) + this.itemInfo.endRemark());
                    break;
                case 6:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(398, 1) + this.itemInfo.endRemark());
                    break;
                case 7:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(399, 1) + this.itemInfo.endRemark());
                    break;
            }
        }
    }
    else if (enemy.enemyType == enemyType.boss)
    {
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(2E+15f)) + " gold! Sweet!");
        if ((double)num1 < (double)Mathf.Min(num4 = num3 + 1.2E-07f * num2, 0.15f))
            this.log.AddEvent(enemy.name + " also dropped " + this.character.display((double)this.character.addExp(800L)) + " EXP! Holy crap!", 3);
        float num5 = 0.0f;
        if ((double)Random.value < (double)Mathf.Min(num4 = num5 + 1.2E-07f * num2, 0.15f))
        {
            switch (Random.Range(0, 8))
            {
                case 0:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(392, 1) + this.itemInfo.endRemark());
                    break;
                case 1:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(393, 1) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(394, 1) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(395, 1) + this.itemInfo.endRemark());
                    break;
                case 4:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(396, 1) + this.itemInfo.endRemark());
                    break;
                case 5:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(397, 1) + this.itemInfo.endRemark());
                    break;
                case 6:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(398, 1) + this.itemInfo.endRemark());
                    break;
                case 7:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(399, 1) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num6 = Random.value;
        float num7 = 0.0f;
        if ((double)num6 < (double)Mathf.Min(num4 = num7 + 4E-07f * num2, 0.12f))
            this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(229, 5) + this.itemInfo.endRemark());
        float num8 = Random.value;
        float num9 = 0.0f;
        if ((double)num8 < (double)Mathf.Min(num4 = num9 + 1.2E-07f * num2, 0.12f))
            this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(230, 5) + this.itemInfo.endRemark());
    }
    this.character.lootState = Random.state;
}

public void zone36Drop(Enemy enemy)
{
    Random.state = this.character.lootState;
    float num1 = Random.value;
    Random.Range(0, 5);
    float num2 = this.character.lootFactorRooted();
    float num3 = 0.0f;
    float num4;
    if (enemy.enemyType == enemyType.normal)
    {
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(2.5E+15f)) + " gold! Sweet!");
        if ((double)num1 < (double)Mathf.Min(num4 = num3 + 6E-08f * num2, 0.15f))
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(13) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(26) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(39) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num5 = Random.value;
        float num6 = 0.0f;
        if ((double)num5 < (double)Mathf.Min(num4 = num6 + 6E-08f * num2, 0.15f))
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(13) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(26) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(39) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num7 = 0.0f;
        if ((double)Random.value < (double)Mathf.Min(num4 = num7 + 2.5E-08f * num2, 0.04f))
        {
            switch (Random.Range(0, 8))
            {
                case 0:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(400, 1) + this.itemInfo.endRemark());
                    break;
                case 1:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(401, 1) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(402, 1) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(403, 1) + this.itemInfo.endRemark());
                    break;
                case 4:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(404, 1) + this.itemInfo.endRemark());
                    break;
                case 5:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(405, 1) + this.itemInfo.endRemark());
                    break;
                case 6:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(406, 1) + this.itemInfo.endRemark());
                    break;
                case 7:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(407, 1) + this.itemInfo.endRemark());
                    break;
            }
        }
    }
    else if (enemy.enemyType == enemyType.boss)
    {
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(3E+15f)) + " gold! Sweet!");
        if ((double)num1 < (double)Mathf.Min(num4 = num3 + 8E-08f * num2, 0.15f))
            this.log.AddEvent(enemy.name + " also dropped " + this.character.display((double)this.character.addExp(1000L)) + " EXP! Holy crap!", 3);
        float num5 = 0.0f;
        if ((double)Random.value < (double)Mathf.Min(num4 = num5 + 8E-08f * num2, 0.15f))
        {
            switch (Random.Range(0, 8))
            {
                case 0:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(400, 1) + this.itemInfo.endRemark());
                    break;
                case 1:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(401, 1) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(402, 1) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(403, 1) + this.itemInfo.endRemark());
                    break;
                case 4:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(404, 1) + this.itemInfo.endRemark());
                    break;
                case 5:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(405, 1) + this.itemInfo.endRemark());
                    break;
                case 6:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(406, 1) + this.itemInfo.endRemark());
                    break;
                case 7:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(407, 1) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num6 = Random.value;
        float num7 = 0.0f;
        if ((double)num6 < (double)Mathf.Min(num4 = num7 + 2.5E-07f * num2, 0.12f))
            this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(229, 15) + this.itemInfo.endRemark());
        float num8 = Random.value;
        float num9 = 0.0f;
        if ((double)num8 < (double)Mathf.Min(num4 = num9 + 8E-08f * num2, 0.12f))
            this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(230, 15) + this.itemInfo.endRemark());
    }
    this.character.lootState = Random.state;
}

public void zone37Drop(Enemy enemy)
{
    Random.state = this.character.lootState;
    float num1 = Random.value;
    Random.Range(0, 5);
    float num2 = this.character.lootFactorRooted();
    float num3 = 0.0f;
    float num4;
    if (enemy.enemyType == enemyType.normal)
    {
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(5E+15f)) + " gold! Sweet!");
        if ((double)num1 < (double)Mathf.Min(num4 = num3 + 4E-08f * num2, 0.15f))
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(13) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(26) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(39) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num5 = Random.value;
        float num6 = 0.0f;
        if ((double)num5 < (double)Mathf.Min(num4 = num6 + 4E-08f * num2, 0.15f))
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(13) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(26) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(39) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num7 = 0.0f;
        if ((double)Random.value < (double)Mathf.Min(num4 = num7 + 1.6E-08f * num2, 0.04f))
        {
            switch (Random.Range(0, 8))
            {
                case 0:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(408, 1) + this.itemInfo.endRemark());
                    break;
                case 1:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(409, 1) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(410, 1) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(411, 1) + this.itemInfo.endRemark());
                    break;
                case 4:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(412, 1) + this.itemInfo.endRemark());
                    break;
                case 5:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(413, 1) + this.itemInfo.endRemark());
                    break;
                case 6:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(414, 1) + this.itemInfo.endRemark());
                    break;
                case 7:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(415, 1) + this.itemInfo.endRemark());
                    break;
            }
        }
    }
    else if (enemy.enemyType == enemyType.boss)
    {
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(6E+15f)) + " gold! Sweet!");
        if ((double)num1 < (double)Mathf.Min(num4 = num3 + 5E-08f * num2, 0.15f))
            this.log.AddEvent(enemy.name + " also dropped " + this.character.display((double)this.character.addExp(1200L)) + " EXP! Holy crap!", 3);
        float num5 = 0.0f;
        if ((double)Random.value < (double)Mathf.Min(num4 = num5 + 5E-08f * num2, 0.15f))
        {
            switch (Random.Range(0, 8))
            {
                case 0:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(408, 1) + this.itemInfo.endRemark());
                    break;
                case 1:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(409, 1) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(410, 1) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(411, 1) + this.itemInfo.endRemark());
                    break;
                case 4:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(412, 1) + this.itemInfo.endRemark());
                    break;
                case 5:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(413, 1) + this.itemInfo.endRemark());
                    break;
                case 6:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(414, 1) + this.itemInfo.endRemark());
                    break;
                case 7:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(415, 1) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num6 = Random.value;
        float num7 = 0.0f;
        if ((double)num6 < (double)Mathf.Min(num4 = num7 + 1.6E-07f * num2, 0.12f))
            this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(229, 40) + this.itemInfo.endRemark());
        float num8 = Random.value;
        float num9 = 0.0f;
        if ((double)num8 < (double)Mathf.Min(num4 = num9 + 6E-08f * num2, 0.12f))
            this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(230, 40) + this.itemInfo.endRemark());
    }
    this.character.lootState = Random.state;
}

public void zone38Drop(Enemy enemy)
{
    if (enemy.enemyType != enemyType.bigBoss11V1 && enemy.enemyType != enemyType.bigBoss11V2 && (enemy.enemyType != enemyType.bigBoss11V3 && enemy.enemyType != enemyType.bigBoss11V4))
        return;
    ++this.character.adventure.boss11Kills;
    Random.state = this.character.lootState;
    float num1 = Random.value;
    float num2 = this.character.lootFactorRooted();
    float num3 = 0.0f;
    this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(2E+16f)) + " gold! Sweet!");
    long num4 = (long)this.character.adventure.titan11Kills >= this.character.adventure.itopod.perkLevel[34] * 3L ? this.character.addExp((float)this.character.adventureController.boss11Exp() * this.higherVFactor(enemy.enemyType)) : this.character.addExp((float)this.character.adventureController.boss11Exp() * 1.5f * this.higherVFactor(enemy.enemyType));
    this.log.AddEvent("Holy crap, you just beat " + enemy.name + "! You gained " + this.character.display((double)num4) + " EXP!", 3);
    this.character.adventureController.itopod.addProgress((long)((double)this.character.adventureController.boss11PP() * (double)this.higherVFactor(enemy.enemyType)));
    if (this.character.wishes.wishes[187].level > 0)
    {
        long num5 = (long)((double)this.character.adventureController.boss11QP() * (double)this.higherVFactor(enemy.enemyType));
        this.character.beastQuest.quirkPoints += num5;
        this.log.AddEvent("You gained " + (object)num5 + " QP thanks to your wish!");
    }
    float num6 = Random.value;
    float num7 = 0.0f;
    if ((double)num6 < (double)Mathf.Min(num3 = num7 + 1E-07f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(416, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num8 = Random.value;
    float num9 = 0.0f;
    if ((double)num8 < (double)Mathf.Min(num3 = num9 + 1E-07f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(417, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num10 = Random.value;
    float num11 = 0.0f;
    if ((double)num10 < (double)Mathf.Min(num3 = num11 + 1E-07f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(418, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num12 = Random.value;
    float num13 = 0.0f;
    if ((double)num12 < (double)Mathf.Min(num3 = num13 + 1E-07f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(419, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num14 = Random.value;
    float num15 = 0.0f;
    if ((double)num14 < (double)Mathf.Min(num3 = num15 + 1E-07f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(420, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num16 = Random.value;
    float num17 = 0.0f;
    if ((double)num16 < (double)Mathf.Min(num3 = num17 + 1E-07f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(421, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num18 = Random.value;
    float num19 = 0.0f;
    if ((double)num18 < (double)Mathf.Min(num3 = num19 + 1E-07f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(422, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num20 = Random.value;
    float num21 = 0.0f;
    if ((double)num20 < (double)Mathf.Min(num3 = num21 + 1E-07f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(423, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num22 = Random.value;
    float num23 = 0.0f;
    if ((double)num22 < (double)Mathf.Min(num3 = num23 + 1E-07f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(295, 10 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num24 = Random.value;
    float num25 = 0.0f;
    if ((double)num24 < (double)Mathf.Min(num3 = num25 + 1E-07f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeTitanLevelledLoot(296, 10 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    this.dropRandomMacguffin(enemy.name, this.titanLevelBonus());
    if (enemy.enemyType == enemyType.bigBoss11V2 || enemy.enemyType == enemyType.bigBoss11V3 || enemy.enemyType == enemyType.bigBoss11V4)
    {
        float num5 = Random.value;
        float num26 = 0.0f;
        if ((double)num5 < (double)Mathf.Min(num3 = num26 + 6.5E-08f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(424, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num27 = Random.value;
        float num28 = 0.0f;
        if ((double)num27 < (double)Mathf.Min(num3 = num28 + 6.5E-08f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(425, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    }
    if (enemy.enemyType == enemyType.bigBoss11V3 || enemy.enemyType == enemyType.bigBoss11V4)
    {
        float num5 = Random.value;
        float num26 = 0.0f;
        if ((double)num5 < (double)Mathf.Min(num3 = num26 + 4E-08f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(426, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num27 = Random.value;
        float num28 = 0.0f;
        if ((double)num27 < (double)Mathf.Min(num3 = num28 + 4E-08f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(427, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    }
    if (enemy.enemyType == enemyType.bigBoss11V4)
    {
        float num5 = Random.value;
        float num26 = 0.0f;
        if ((double)num5 < (double)Mathf.Min(num3 = num26 + 3E-08f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(428, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num27 = Random.value;
        float num28 = 0.0f;
        if ((double)num27 < (double)Mathf.Min(num3 = num28 + 3E-08f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(429, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    }
    this.character.lootState = Random.state;
}

public void zone39Drop(Enemy enemy)
{
    Random.state = this.character.lootState;
    float num1 = Random.value;
    Random.Range(0, 5);
    float num2 = this.character.lootFactorRooted();
    float num3 = 0.0f;
    float num4;
    if (enemy.enemyType == enemyType.normal)
    {
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(1E+16f)) + " gold! Sweet!");
        if ((double)num1 < (double)Mathf.Min(num4 = num3 + 2.5E-08f * num2, 0.16f))
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(13) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(26) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(39) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num5 = Random.value;
        float num6 = 0.0f;
        if ((double)num5 < (double)Mathf.Min(num4 = num6 + 2.5E-08f * num2, 0.16f))
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(13) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(26) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(39) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num7 = 0.0f;
        if ((double)Random.value < (double)Mathf.Min(num4 = num7 + 1E-08f * num2, 0.04f))
        {
            switch (Random.Range(0, 8))
            {
                case 0:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(453, 1) + this.itemInfo.endRemark());
                    break;
                case 1:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(454, 1) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(455, 1) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(456, 1) + this.itemInfo.endRemark());
                    break;
                case 4:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(457, 1) + this.itemInfo.endRemark());
                    break;
                case 5:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(458, 1) + this.itemInfo.endRemark());
                    break;
                case 6:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(459, 1) + this.itemInfo.endRemark());
                    break;
                case 7:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(460, 1) + this.itemInfo.endRemark());
                    break;
            }
        }
    }
    else if (enemy.enemyType == enemyType.boss)
    {
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(1.2E+16f)) + " gold! Sweet!");
        if ((double)num1 < (double)Mathf.Min(num4 = num3 + 4E-08f * num2, 0.15f))
            this.log.AddEvent(enemy.name + " also dropped " + this.character.display((double)this.character.addExp(1200L)) + " EXP! Holy crap!", 3);
        float num5 = 0.0f;
        if ((double)Random.value < (double)Mathf.Min(num4 = num5 + 3E-08f * num2, 0.15f))
        {
            switch (Random.Range(0, 8))
            {
                case 0:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(453, 1) + this.itemInfo.endRemark());
                    break;
                case 1:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(454, 1) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(455, 1) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(456, 1) + this.itemInfo.endRemark());
                    break;
                case 4:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(457, 1) + this.itemInfo.endRemark());
                    break;
                case 5:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(458, 1) + this.itemInfo.endRemark());
                    break;
                case 6:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(459, 1) + this.itemInfo.endRemark());
                    break;
                case 7:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(460, 1) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num6 = Random.value;
        float num7 = 0.0f;
        if ((double)num6 < (double)Mathf.Min(num4 = num7 + 1E-07f * num2, 0.12f))
            this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(295, 2) + this.itemInfo.endRemark());
        float num8 = Random.value;
        float num9 = 0.0f;
        if ((double)num8 < (double)Mathf.Min(num4 = num9 + 4E-08f * num2, 0.12f))
            this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(296, 2) + this.itemInfo.endRemark());
    }
    this.character.lootState = Random.state;
}

public void zone40Drop(Enemy enemy)
{
    Random.state = this.character.lootState;
    float num1 = Random.value;
    Random.Range(0, 5);
    float num2 = this.character.lootFactorRooted();
    float num3 = 0.0f;
    float num4;
    if (enemy.enemyType == enemyType.normal)
    {
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(2E+16f)) + " gold! Sweet!");
        if ((double)num1 < (double)Mathf.Min(num4 = num3 + 2E-08f * num2, 0.17f))
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(13) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(26) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(39) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num5 = Random.value;
        float num6 = 0.0f;
        if ((double)num5 < (double)Mathf.Min(num4 = num6 + 2E-08f * num2, 0.17f))
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(13) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(26) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(39) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num7 = 0.0f;
        if ((double)Random.value < (double)Mathf.Min(num4 = num7 + 8E-09f * num2, 0.05f))
        {
            switch (Random.Range(0, 8))
            {
                case 0:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(496, 1) + this.itemInfo.endRemark());
                    break;
                case 1:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(497, 1) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(498, 1) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(499, 1) + this.itemInfo.endRemark());
                    break;
                case 4:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(500, 1) + this.itemInfo.endRemark());
                    break;
                case 5:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(501, 1) + this.itemInfo.endRemark());
                    break;
                case 6:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(502, 1) + this.itemInfo.endRemark());
                    break;
                case 7:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(503, 1) + this.itemInfo.endRemark());
                    break;
            }
        }
    }
    else if (enemy.enemyType == enemyType.boss)
    {
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(2.4E+16f)) + " gold! Sweet!");
        if ((double)num1 < (double)Mathf.Min(num4 = num3 + 3.3E-08f * num2, 0.15f))
            this.log.AddEvent(enemy.name + " also dropped " + this.character.display((double)this.character.addExp(1200L)) + " EXP! Holy crap!", 3);
        float num5 = 0.0f;
        if ((double)Random.value < (double)Mathf.Min(num4 = num5 + 2.4E-08f * num2, 0.15f))
        {
            switch (Random.Range(0, 8))
            {
                case 0:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(496, 1) + this.itemInfo.endRemark());
                    break;
                case 1:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(497, 1) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(498, 1) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(499, 1) + this.itemInfo.endRemark());
                    break;
                case 4:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(500, 1) + this.itemInfo.endRemark());
                    break;
                case 5:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(501, 1) + this.itemInfo.endRemark());
                    break;
                case 6:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(502, 1) + this.itemInfo.endRemark());
                    break;
                case 7:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(503, 1) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num6 = Random.value;
        float num7 = 0.0f;
        if ((double)num6 < (double)Mathf.Min(num4 = num7 + 8E-08f * num2, 0.12f))
            this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(295, 4) + this.itemInfo.endRemark());
        float num8 = Random.value;
        float num9 = 0.0f;
        if ((double)num8 < (double)Mathf.Min(num4 = num9 + 3E-08f * num2, 0.12f))
            this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(296, 4) + this.itemInfo.endRemark());
    }
    this.character.lootState = Random.state;
}

public void zone41Drop(Enemy enemy)
{
    Random.state = this.character.lootState;
    float num1 = Random.value;
    Random.Range(0, 5);
    float num2 = this.character.lootFactorRooted();
    float num3 = 0.0f;
    float num4;
    if (enemy.enemyType == enemyType.normal)
    {
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(4E+16f)) + " gold! Sweet!");
        if ((double)num1 < (double)Mathf.Min(num4 = num3 + 1.6E-08f * num2, 0.17f))
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(13) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(26) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(39) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num5 = Random.value;
        float num6 = 0.0f;
        if ((double)num5 < (double)Mathf.Min(num4 = num6 + 1.6E-08f * num2, 0.17f))
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(13) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(26) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(39) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num7 = 0.0f;
        if ((double)Random.value < (double)Mathf.Min(num4 = num7 + 6E-09f * num2, 0.05f))
        {
            switch (Random.Range(0, 8))
            {
                case 0:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(461, 1) + this.itemInfo.endRemark());
                    break;
                case 1:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(462, 1) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(463, 1) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(464, 1) + this.itemInfo.endRemark());
                    break;
                case 4:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(465, 1) + this.itemInfo.endRemark());
                    break;
                case 5:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(466, 1) + this.itemInfo.endRemark());
                    break;
                case 6:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(467, 1) + this.itemInfo.endRemark());
                    break;
                case 7:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(468, 1) + this.itemInfo.endRemark());
                    break;
            }
        }
    }
    else if (enemy.enemyType == enemyType.boss)
    {
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(5E+16f)) + " gold! Sweet!");
        if ((double)num1 < (double)Mathf.Min(num4 = num3 + 1.8E-08f * num2, 0.15f))
            this.log.AddEvent(enemy.name + " also dropped " + this.character.display((double)this.character.addExp(1200L)) + " EXP! Holy crap!", 3);
        float num5 = 0.0f;
        if ((double)Random.value < (double)Mathf.Min(num4 = num5 + 1.8E-08f * num2, 0.15f))
        {
            switch (Random.Range(0, 8))
            {
                case 0:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(461, 1) + this.itemInfo.endRemark());
                    break;
                case 1:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(462, 1) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(463, 1) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(464, 1) + this.itemInfo.endRemark());
                    break;
                case 4:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(465, 1) + this.itemInfo.endRemark());
                    break;
                case 5:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(466, 1) + this.itemInfo.endRemark());
                    break;
                case 6:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(467, 1) + this.itemInfo.endRemark());
                    break;
                case 7:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(468, 1) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num6 = Random.value;
        float num7 = 0.0f;
        if ((double)num6 < (double)Mathf.Min(num4 = num7 + 6E-08f * num2, 0.12f))
            this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(295, 8) + this.itemInfo.endRemark());
        float num8 = Random.value;
        float num9 = 0.0f;
        if ((double)num8 < (double)Mathf.Min(num4 = num9 + 2.4E-08f * num2, 0.12f))
            this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(296, 8) + this.itemInfo.endRemark());
    }
    this.character.lootState = Random.state;
}

public void zone42Drop(Enemy enemy)
{
    if (enemy.enemyType != enemyType.bigBoss12V1 && enemy.enemyType != enemyType.bigBoss12V2 && (enemy.enemyType != enemyType.bigBoss12V3 && enemy.enemyType != enemyType.bigBoss12V4))
        return;
    ++this.character.adventure.boss12Kills;
    Random.state = this.character.lootState;
    float num1 = Random.value;
    float num2 = this.character.lootFactorRooted();
    float num3 = 0.0f;
    this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(1.5E+17f)) + " gold! Sweet!");
    long num4 = (long)this.character.adventure.titan12Kills >= this.character.adventure.itopod.perkLevel[34] * 3L ? this.character.addExp((float)this.character.adventureController.boss12Exp() * this.higherVFactor(enemy.enemyType)) : this.character.addExp((float)this.character.adventureController.boss12Exp() * 1.5f * this.higherVFactor(enemy.enemyType));
    this.log.AddEvent("Holy crap, you just beat " + enemy.name + "! You gained " + this.character.display((double)num4) + " EXP!", 3);
    this.character.adventureController.itopod.addProgress((long)((double)this.character.adventureController.boss12PP() * (double)this.higherVFactor(enemy.enemyType)));
    if (this.character.wishes.wishes[204].level > 0)
    {
        long num5 = (long)((double)this.character.adventureController.boss12QP() * (double)this.higherVFactor(enemy.enemyType));
        this.character.beastQuest.quirkPoints += num5;
        this.log.AddEvent("You gained " + (object)num5 + " QP thanks to your wish!");
    }
    float num6 = Random.value;
    float num7 = 0.0f;
    if ((double)num6 < (double)Mathf.Min(num3 = num7 + 1.4E-08f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(469, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num8 = Random.value;
    float num9 = 0.0f;
    if ((double)num8 < (double)Mathf.Min(num3 = num9 + 1.4E-08f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(470, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num10 = Random.value;
    float num11 = 0.0f;
    if ((double)num10 < (double)Mathf.Min(num3 = num11 + 1.4E-08f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(471, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num12 = Random.value;
    float num13 = 0.0f;
    if ((double)num12 < (double)Mathf.Min(num3 = num13 + 1.4E-08f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(472, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num14 = Random.value;
    float num15 = 0.0f;
    if ((double)num14 < (double)Mathf.Min(num3 = num15 + 1.4E-08f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(473, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num16 = Random.value;
    float num17 = 0.0f;
    if ((double)num16 < (double)Mathf.Min(num3 = num17 + 1.4E-08f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(474, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num18 = Random.value;
    float num19 = 0.0f;
    if ((double)num18 < (double)Mathf.Min(num3 = num19 + 1.4E-08f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(475, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num20 = Random.value;
    float num21 = 0.0f;
    if ((double)num20 < (double)Mathf.Min(num3 = num21 + 1.4E-08f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(476, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num22 = Random.value;
    float num23 = 0.0f;
    if ((double)num22 < (double)Mathf.Min(num3 = num23 + 1.4E-08f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(388, 50 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num24 = Random.value;
    float num25 = 0.0f;
    if ((double)num24 < (double)Mathf.Min(num3 = num25 + 1.4E-08f * num2, 0.25f))
        this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeTitanLevelledLoot(389, 50 + this.titanLevelBonus()) + this.itemInfo.endRemark());
    float num26 = Random.value;
    float num27 = 0.0f;
    if ((double)num26 < (double)Mathf.Min(num3 = num27 + 1.4E-08f * num2, 0.25f))
        this.log.AddEvent(this.itemInfo.makeTitanLevelledLoot(483, 100) + " NEARS.");
    this.dropRandomMacguffin(enemy.name, this.titanLevelBonus());
    if (enemy.enemyType == enemyType.bigBoss12V2 || enemy.enemyType == enemyType.bigBoss12V3 || enemy.enemyType == enemyType.bigBoss12V4)
    {
        float num5 = Random.value;
        float num28 = 0.0f;
        if ((double)num5 < (double)Mathf.Min(num3 = num28 + 1E-08f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(477, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num29 = Random.value;
        float num30 = 0.0f;
        if ((double)num29 < (double)Mathf.Min(num3 = num30 + 1E-08f * num2, 0.25f))
            this.log.AddEvent(this.itemInfo.makeTitanLevelledLoot(489, 100) + " NEARS.");
    }
    if (enemy.enemyType == enemyType.bigBoss12V3 || enemy.enemyType == enemyType.bigBoss12V4)
    {
        float num5 = Random.value;
        float num28 = 0.0f;
        if ((double)num5 < (double)Mathf.Min(num3 = num28 + 8E-09f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(478, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num29 = Random.value;
        float num30 = 0.0f;
        if ((double)num29 < (double)Mathf.Min(num3 = num30 + 8E-09f * num2, 0.25f))
            this.log.AddEvent(this.itemInfo.makeTitanLevelledLoot(493, 100) + " NEARS.");
    }
    if (enemy.enemyType == enemyType.bigBoss12V4)
    {
        float num5 = Random.value;
        float num28 = 0.0f;
        if ((double)num5 < (double)Mathf.Min(num3 = num28 + 6E-09f * num2, 0.25f))
            this.log.AddEvent(enemy.name + " dropped a " + this.itemInfo.makeTitanLevelledLoot(479, 4 + this.titanLevelBonus()) + this.itemInfo.endRemark());
        float num29 = Random.value;
        float num30 = 0.0f;
        if ((double)num29 < (double)Mathf.Min(num3 = num30 + 6E-09f * num2, 0.25f))
            this.log.AddEvent(this.itemInfo.makeTitanLevelledLoot(484, 100) + " NEARS.");
    }
    this.character.lootState = Random.state;
}

public void zone43Drop(Enemy enemy)
{
    Random.state = this.character.lootState;
    float num1 = Random.value;
    Random.Range(0, 5);
    float num2 = this.character.lootFactorRooted();
    float num3 = 0.0f;
    float num4;
    if (enemy.enemyType == enemyType.normal)
    {
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(8E+16f)) + " gold! Sweet!");
        if ((double)num1 < (double)Mathf.Min(num4 = num3 + 1E-08f * num2, 0.17f))
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(13) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(26) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(39) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num5 = Random.value;
        float num6 = 0.0f;
        if ((double)num5 < (double)Mathf.Min(num4 = num6 + 1E-08f * num2, 0.17f))
        {
            switch (Random.Range(1, 4))
            {
                case 1:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(13) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(26) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " dropped " + this.itemInfo.makeLoot(39) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num7 = 0.0f;
        if ((double)Random.value < (double)Mathf.Min(num4 = num7 + 4E-09f * num2, 0.05f))
        {
            switch (Random.Range(0, 8))
            {
                case 0:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(507, 1) + this.itemInfo.endRemark());
                    break;
                case 1:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(508, 1) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(509, 1) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(510, 1) + this.itemInfo.endRemark());
                    break;
                case 4:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(511, 1) + this.itemInfo.endRemark());
                    break;
                case 5:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(512, 1) + this.itemInfo.endRemark());
                    break;
                case 6:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(513, 1) + this.itemInfo.endRemark());
                    break;
                case 7:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(514, 1) + this.itemInfo.endRemark());
                    break;
            }
        }
    }
    else if (enemy.enemyType == enemyType.boss)
    {
        this.log.AddEvent(enemy.name + " dropped " + this.format.suffixFormat(this.goldDrop(1.6E+17f)) + " gold! Sweet!");
        if ((double)num1 < (double)Mathf.Min(num4 = num3 + 1.2E-08f * num2, 0.15f))
            this.log.AddEvent(enemy.name + " also dropped " + this.character.display((double)this.character.addExp(1200L)) + " EXP! Holy crap!", 3);
        float num5 = 0.0f;
        if ((double)Random.value < (double)Mathf.Min(num4 = num5 + 1.2E-08f * num2, 0.15f))
        {
            switch (Random.Range(0, 8))
            {
                case 0:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(507, 1) + this.itemInfo.endRemark());
                    break;
                case 1:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(508, 1) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(509, 1) + this.itemInfo.endRemark());
                    break;
                case 3:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(510, 1) + this.itemInfo.endRemark());
                    break;
                case 4:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(511, 1) + this.itemInfo.endRemark());
                    break;
                case 5:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(512, 1) + this.itemInfo.endRemark());
                    break;
                case 6:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(513, 1) + this.itemInfo.endRemark());
                    break;
                case 7:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(514, 1) + this.itemInfo.endRemark());
                    break;
            }
        }
        float num6 = Random.value;
        float num7 = 0.0f;
        if ((double)num6 < (double)Mathf.Min(num4 = num7 + 4E-08f * num2, 0.12f))
            this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(295, 16) + this.itemInfo.endRemark());
        float num8 = Random.value;
        float num9 = 0.0f;
        if ((double)num8 < (double)Mathf.Min(num4 = num9 + 1.8E-08f * num2, 0.12f))
            this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(296, 16) + this.itemInfo.endRemark());
    }
    this.character.lootState = Random.state;
}

public void itopodDrop(Enemy enemy, int itopodLevel)
{
    Random.state = this.character.lootState;
    float num1 = Random.value;
    Random.Range(0, 5);
    int num2 = this.itopodTier(itopodLevel);
    int id = 1;
    if (num2 > 0)
        id = Mathf.Min(num2, 24);
    if (id < 1)
        id = 1;
    if (id >= 24)
        id = 13;
    else if (id >= 18)
        id = 12;
    else if (id >= 15)
        id = 11;
    else if (id > 10)
        id = 10;
    if (id > 13)
        id = 10;
    if (enemy.enemyType == enemyType.itopod)
    {
        ++this.character.adventure.itopod.enemiesKilled;
        if ((double)Random.value < 0.140000000596046)
        {
            switch (Random.Range(0, 3))
            {
                case 0:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(id, 1) + this.itemInfo.endRemark());
                    break;
                case 1:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(13 + id, 1) + this.itemInfo.endRemark());
                    break;
                case 2:
                    this.log.AddEvent(enemy.name + " also dropped " + this.itemInfo.makeLevelledLoot(26 + id, 1) + this.itemInfo.endRemark());
                    break;
            }
        }
        if (this.character.adventure.itopod.enemiesKilled % this.killsPerAP(num2) == 0)
        {
            ++this.character.arbitrary.curArbitraryPoints;
            ++this.character.arbitrary.curLifetimePoints;
            this.log.AddEvent(enemy.name + " also dropped 1 AP!");
        }
        if (this.character.adventure.itopod.enemiesKilled % this.killsPerEXP(num2) == 0 && num2 >= 1)
            this.log.AddEvent(enemy.name + " also dropped " + this.character.display((double)this.character.addExp((long)this.itopodEXPAwarded(num2))) + " EXP! OMG!", 3);
        float num3 = Random.value;
        if (this.character.adventure.itopod.perkLevel[30] >= 1L && (double)num3 < (double)this.character.adventureController.itopod.effectPerLevel[30])
        {
            this.log.AddEvent(enemy.name + " also dropped some poop!");
            ++this.character.arbitrary.poop1Count;
        }
        if (this.character.achievements.achievementComplete[145] && this.character.adventure.itopod.perkLevel[68] >= 1L && this.character.adventure.itopod.enemiesKilled % this.killsPerMacguffin() == 0)
            this.dropRandomMacguffin(enemy.name, 0);
    }
    this.character.lootState = Random.state;
    this.checkITOPODSecret();
    this.checkExileDrop();
    this.checkEndDrop();
}
