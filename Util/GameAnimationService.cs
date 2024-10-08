public class GameAnimationService
{
    public bool IsHeroTurn { get; private set; }
    public bool HeroIsAtt { get; private set; }
    public bool EnemyIsAtt { get; private set; }
    public bool IsEnemyTurn { get; private set; }
    public bool HeroIsHealing { get; private set; }
    public bool EnemyIsHealing { get; private set; }
    public bool HeroUpgradeArmor { get; private set; }
    public bool EnemyUpgradeArmor { get; private set; }
    public bool HeroIsGettingDmg { get; private set; }
    public bool EnemyIsGettingDmg { get; private set; }
    public bool HeavyCrash { get; private set; }
    public bool EnemyIsBessing { get; private set; }
    public bool HeroIsMilkRaging { get; private set; }
    public int ArmorAdded  { get; private set; }
    public int AttackAdded  { get; private set; }
    public int HpAdded  { get; private set; }
    public int ArmorReduction  { get; private set; }
    public bool HeroBoosting { get; private set; }
    public int GettingDamage { get; private set; }
    public bool EnemyHeavyCrash { get; private set; }
    public bool IsMonster { get; private set; }
    public bool IsNympth { get; private set; }
    public bool IsReducingDamage { get; private set; }
    public int DamageReduced { get; private set; }
    public bool EnemyUsingAbility { get; private set; }
    public int eDamageAdded { get; private set; }
    public bool eIsAddingDamage { get; private set; }





       public void setEnemyUsingAbility(bool isUsingAbility)
    {
        EnemyUsingAbility = isUsingAbility;
   
    }


  public void SetHeroBoosting(bool isHero, bool isBoosting, int armorAdded, int attckAdded)
    {
        if (isHero) {
            HeroBoosting = isBoosting;
            ArmorAdded = armorAdded;
            AttackAdded= attckAdded;
        }

        else 
        {
            EnemyIsBessing = isBoosting;
            ArmorAdded = armorAdded;
            AttackAdded= attckAdded;
        }
    }


    public void SetTurn(bool isHeroTurn)
    {
        IsHeroTurn = isHeroTurn;
        IsEnemyTurn = !isHeroTurn;
    }
        public void setIsMonster(bool isMonster)
    {
        IsMonster = isMonster;
   
    }
       public void setIsNympth(bool isNympth)
    {
        IsNympth = isNympth;
   
    }

    public void SetHeavyCrash(bool isHero, bool isCrashing)
    {
        if (isHero)
            HeavyCrash = isCrashing;
        else
            EnemyHeavyCrash = isCrashing;
    }


    public void SetArmorReduction(bool isHero, int armorReduction)
    {
        if (isHero)
            ArmorReduction = armorReduction;
        else
            ArmorReduction = armorReduction;
    }



    public void SetHealing(bool isHero, bool isHealing,int hpAdded)
    {
        if (isHero){
            HeroIsHealing = isHealing;
            HpAdded = hpAdded;
        }
           
        else {
            EnemyIsHealing = isHealing;
            HpAdded = hpAdded;

        }
            
    }
    public void SetIsAtt(bool isHero, bool isAtt)
    {
        if (isHero)
            HeroIsAtt = isAtt;
        else
            EnemyIsAtt = isAtt;
    }

    public void SetUpgradeArmor(bool isHero, bool isUpgrading, int armorAdded)
    {
        if (isHero) {
            HeroUpgradeArmor = isUpgrading;
            ArmorAdded = armorAdded;
        }
        else {
            EnemyUpgradeArmor = isUpgrading;
            ArmorAdded = armorAdded;
        }

            
    }

    public void SetGettingDamage(bool isHero, bool isGettingDamage, int damageGetting)
    {
        if (isHero) {
             HeroIsGettingDmg = isGettingDamage;
            GettingDamage =  damageGetting;
        }
         
        else {
            EnemyIsGettingDmg = isGettingDamage;
            GettingDamage =  damageGetting;
        }
          
    }
        public void SetReducingDamage( bool isReducingDamage, int damageReduced)
    {
            IsReducingDamage = isReducingDamage;
            DamageReduced =  damageReduced; 
    }
            public void eSetAddingDamage( bool isAddingDamage, int damageAdded)
    {
            eIsAddingDamage = isAddingDamage;
            eDamageAdded =  damageAdded; 
    }


    public async Task ResetStatus(int delay = 1000)
    {
        await Task.Delay(delay);
        IsReducingDamage = false;
        eDamageAdded = 0;
        eIsAddingDamage = false;
        HeroIsHealing = false;
        DamageReduced = 0;
        EnemyIsHealing = false;
        HeroUpgradeArmor = false;
        EnemyUpgradeArmor = false;
        HeroIsGettingDmg = false;
        EnemyIsGettingDmg = false;
        HeroIsAtt = false;
        EnemyIsAtt = false;
        HeavyCrash = false;
        EnemyIsBessing = false;
        HeroIsMilkRaging = false;
        EnemyHeavyCrash = false;
        ArmorAdded = 0;
        HpAdded = 0;
        AttackAdded = 0;
        HeroBoosting = false;
        IsMonster = false;
        IsNympth = false;
        GettingDamage = 0;
        EnemyUsingAbility = false;

    }
}