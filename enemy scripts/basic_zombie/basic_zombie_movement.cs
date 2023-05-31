using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class basic_zombie_movement : MonoBehaviour
{
    Rigidbody2D rb;
    GameObject target;
    public float moveSpeed;
    Vector3 directionToTarget;
    public GameObject explosion;
    public GameObject FloatingText;

    public GameObject GoldText;

    public float enemyhealthAmount = 0f;
    public float tempenemyhealthAmount = 0f;
    public int scorePlus = 1;

    public int GoldPlus = 2;

    private Material damageEffect;
    private Material matDefault;

    private Animator anim;

    public GameObject blood;
    Quaternion bloodPath;

    public static float bz_attack = 15f;

    public string level;

    public GameObject Poison;
    public GameObject Fire;
    public GameObject Slow;
    public GameObject Ice;

    private bool isPoison = false;
    private bool isFire = false;
    private bool isSlow = false;

    private int deathNum = 0;

    BoxCollider2D col;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
        target = GameObject.Find("Player");
        rb = GetComponent<Rigidbody2D>();
        Quaternion bloodPath = Quaternion.identity;

        level = CharacterSelection.difficultyLevel;

        if (level.Equals("easy"))
        {
            enemyhealthAmount = 250f;
            tempenemyhealthAmount = 250f;
            bz_attack = 10f;
            moveSpeed = 20f;
            GoldPlus = 2;
        }

        if (level.Equals("medium"))
        {
            enemyhealthAmount = 520f;
            tempenemyhealthAmount = 520f;
            bz_attack = 25f;
            moveSpeed = 25f;
            GoldPlus = 4;
        }

        if (level.Equals("hard"))
        {
            enemyhealthAmount = 800f;
            tempenemyhealthAmount = 800f;
            bz_attack = 40f;
            moveSpeed = 30f;
            GoldPlus = 6;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyhealthAmount <= 0 && deathNum == 0)
        {
            var go = Instantiate(GoldText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = "+ " + GoldPlus.ToString();
            ScoreScript.scoreValue += scorePlus;
            moveSpeed = 0;
            enemyhealthAmount = 0;
            anim.SetTrigger("Death");
            col.enabled = !col.enabled;
            Destroy(gameObject, 1);
            GameManagerScript.goldAmount += GoldPlus;
            deathNum += 1;
        }

        MoveMonster();
    }

    void MoveMonster()
    {
        if (target != null)
        {
            directionToTarget = (target.transform.position - transform.position).normalized;
            rb.velocity = new Vector2(directionToTarget.x * moveSpeed, 0);
        }
        else
            rb.velocity = Vector3.zero;

        if (directionToTarget.x  > 0.15)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            anim.SetBool("isWalk", true);
            anim.SetBool("isAttack", false);
            bloodPath.eulerAngles = new Vector3(0, 180, 0);
            
        }
        else if (directionToTarget.x < -0.15)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            anim.SetBool("isWalk", true);
            anim.SetBool("isAttack", false);
            bloodPath.eulerAngles = new Vector3(0, 0, 0);
        }

        else
        {
            bloodPath.eulerAngles = new Vector3(0, 270, 0);
            if (directionToTarget.y < 0.2)
            {
                anim.SetBool("isAttack", true);
                
            }
            else
            {
                anim.SetBool("isWalk", false);
            } 
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.name.Equals("Bullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Pistol_Bullet.pistoldamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Pistol_Bullet.pistoldamage;

            Destroy(col.gameObject);
        }

        if (col.gameObject.name.Equals("sniperBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Sniper_Bullet.sniperdamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Sniper_Bullet.sniperdamage;

            Destroy(col.gameObject);

        }

        if (col.gameObject.name.Equals("rifleBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Rifle_Bullet.rifledamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Rifle_Bullet.rifledamage;

            Destroy(col.gameObject);

        }

        if (col.gameObject.name.Equals("shotgunBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Shotgun_Bullet.shotgundamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Shotgun_Bullet.shotgundamage;

            Destroy(col.gameObject);

        }

        if (col.gameObject.name.Equals("minigunBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Minigun_Bullet.minigundamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Minigun_Bullet.minigundamage;

            Destroy(col.gameObject);

        }

        if (col.gameObject.name.Equals("tommyBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Tommy_Bullet.tommydamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Tommy_Bullet.tommydamage;

            Destroy(col.gameObject);

        }

        if (col.gameObject.name.Equals("harpoonBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Harpoon_Bullet.harpoondamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Harpoon_Bullet.harpoondamage;

        }

        if (col.gameObject.name.Equals("laserBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Laser_Bullet.laserdamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Laser_Bullet.laserdamage;

        }

        if (col.gameObject.name.Equals("chefKnife(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Chef_Bullet.chefdamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Chef_Bullet.chefdamage;

            Destroy(col.gameObject);

        }

        if (col.gameObject.name.Equals("ninjaBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Ninja_Bullet.ninjadamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Ninja_Bullet.ninjadamage;

            Destroy(col.gameObject);
        }

        if (col.gameObject.name.Equals("boneBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Bone_Bullet.bonedamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Bone_Bullet.bonedamage;

        }

        if (col.gameObject.name.Equals("Axe(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Axe_Attack.axedamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Axe_Attack.axedamage;

        }

        if (col.gameObject.name.Equals("PickAxe(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Mine_Attack.minedamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Mine_Attack.minedamage;

            if (isSlow == false)
            {
                isSlow = true;
                Slow.SetActive(true);
                moveSpeed /= 2;
            }

            Destroy(col.gameObject);

        }

        if (col.gameObject.name.Equals("robberKnife(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Robber_Attack.robberdamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Robber_Attack.robberdamage;

            InvokeRepeating("RobberAttack", 2f, 0f);

            Destroy(col.gameObject);

        }

        if (col.gameObject.name.Equals("Spear(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Sparta_Attack.spartadamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Sparta_Attack.spartadamage;

        }

        if (col.gameObject.name.Equals("LaserSword(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Lasersword_Attack.lasersworddamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Lasersword_Attack.lasersworddamage;

        }

        if (col.gameObject.name.Equals("lasergunBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = LaserGun_Attack.lasergundamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= LaserGun_Attack.lasergundamage;
            
        }

        if (col.gameObject.name.Equals("FireWizardBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);
            enemyhealthAmount -= Firewizard_Attack.firewizarddamage;
            SoundManagerScript.PlaySound("bullethit");

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Firewizard_Attack.firewizarddamage.ToString();

            if (isFire == false)
            {
                isFire = true;
                Fire.SetActive(true);
                InvokeRepeating("FireWizardAttack", 1, 1.0f);

            }

            Destroy(col.gameObject);
        }

        if (col.gameObject.name.Equals("PoisonWizardBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);
            enemyhealthAmount -= Poisonwizard_Attack.poisonwizarddamage;
            SoundManagerScript.PlaySound("bullethit");

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Poisonwizard_Attack.poisonwizarddamage.ToString();

            if (isPoison == false)
            {
                isPoison = true;
                Poison.SetActive(true);
                InvokeRepeating("PoisonWizardAttack", 1, 1.0f);
            }

            Destroy(col.gameObject);
        }

        if (col.gameObject.name.Equals("ElectricWizardBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = ElectricWizard_Attack.electricwizarddamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= ElectricWizard_Attack.electricwizarddamage;

        }

        if (col.gameObject.name.Equals("SamuraiSword(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Samurai_Attack.samuraidamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Samurai_Attack.samuraidamage;

            InvokeRepeating("SamuraiAttack", 2f, 0f);

        }

        if (col.gameObject.name.Equals("Grenade(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Grenade_Attack.grenadedamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Grenade_Attack.grenadedamage;

            Destroy(col.gameObject);
        }

        if (col.gameObject.name.Equals("grenadeExplosion(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Grenade_Attack.explodeDamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Grenade_Attack.explodeDamage;
        }

        if (col.gameObject.name.Equals("BazookaBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Bazooka_Bullet.bazookadamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Bazooka_Bullet.bazookadamage;

            Destroy(col.gameObject);
        }

        if (col.gameObject.name.Equals("bazookaExplosion(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Bazooka_Bullet.explodeDamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Bazooka_Bullet.explodeDamage;
        }

        if (col.gameObject.name.Equals("GirlStudentBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = GirlStudent_Bullet.girlstudentdamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= GirlStudent_Bullet.girlstudentdamage;

            Destroy(col.gameObject);
        }

        if (col.gameObject.name.Equals("ElectricSaw(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Constructor_Attack.constructordamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Constructor_Attack.constructordamage;

        }

        if (col.gameObject.name.Equals("Viking2(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Viking2_Attack.viking2damage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Viking2_Attack.viking2damage;

        }

        if (col.gameObject.name.Equals("needle(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);
            enemyhealthAmount -= Nurse_Attack.nursedamage;
            SoundManagerScript.PlaySound("bullethit");

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Nurse_Attack.nursedamage.ToString();

            if (isPoison == false)
            {
                isPoison = true;
                Poison.SetActive(true);
                InvokeRepeating("NurseAttack", 1, 1.0f);
            }

            Destroy(col.gameObject);
        }

        if (col.gameObject.name.Equals("chalk(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Teacher_Attack.teacherdamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Teacher_Attack.teacherdamage;

            Destroy(col.gameObject);
        }

        if (col.gameObject.name.Equals("artistBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Artist_Attack.artistdamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Artist_Attack.artistdamage;
        }

        if (col.gameObject.name.Equals("baseballballBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = BaseballBall_Attack.baseballBalldamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= BaseballBall_Attack.baseballBalldamage;

            Destroy(col.gameObject);
        }

        if (col.gameObject.name.Equals("basketballBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Basketball_Attack.basketballdamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Basketball_Attack.basketballdamage;

            Destroy(col.gameObject);

        }

        if (col.gameObject.name.Equals("demonBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);
            enemyhealthAmount -= Demon_Attack.demondamage;
            SoundManagerScript.PlaySound("bullethit");

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Demon_Attack.demondamage.ToString();

            if (isFire == false)
            {
                isFire = true;
                Fire.SetActive(true);
                InvokeRepeating("DemonAttack", 1, 1.0f);

            }

            Destroy(col.gameObject);

        }

        if (col.gameObject.name.Equals("englandsoldierBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = EnglandSoldier_Attack.englandsoldierdamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= EnglandSoldier_Attack.englandsoldierdamage;

            Destroy(col.gameObject);
        }

        if (col.gameObject.name.Equals("gangsterBossBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = GangsterBoss_Attack.gangsterbossdamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= GangsterBoss_Attack.gangsterbossdamage;

            Destroy(col.gameObject);
        }

        if (col.gameObject.name.Equals("girlNinja(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = GirlNinja_Attack.girlninjadamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= GirlNinja_Attack.girlninjadamage;

            Destroy(col.gameObject);
        }

        if (col.gameObject.name.Equals("indianBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);
            enemyhealthAmount -= Indian_Attack.indiandamage;
            SoundManagerScript.PlaySound("bullethit");

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Indian_Attack.indiandamage.ToString();

            if (isPoison == false)
            {
                isPoison = true;
                Poison.SetActive(true);
                InvokeRepeating("IndianAttack", 1, 1.0f);
            }

            Destroy(col.gameObject);
        }

        if (col.gameObject.name.Equals("pirateBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Pirate_Attack.piratedamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Pirate_Attack.piratedamage;

        }

        if (col.gameObject.name.Equals("pirateCaptainBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = PirateCaptain_Attack.piratecaptaindamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= PirateCaptain_Attack.piratecaptaindamage;

            if (isSlow == false)
            {
                isSlow = true;
                Slow.SetActive(true);
                moveSpeed /= 2;
            }

            Destroy(col.gameObject);

        }

        if (col.gameObject.name.Equals("policeBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Police_Attack.policedamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Police_Attack.policedamage;

        }

        if (col.gameObject.name.Equals("rockerBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Rocker_Attack.rockerdamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Rocker_Attack.rockerdamage;

        }

        if (col.gameObject.name.Equals("skiBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Ski_Attack.skidamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Ski_Attack.skidamage;

            Destroy(col.gameObject);

            Ice.SetActive(true);
            moveSpeed = 0;
            InvokeRepeating("SkiAttack", 3, 0);
        }

        if (col.gameObject.name.Equals("vampireBullet(Clone)"))
        {
            Instantiate(blood, transform.position, bloodPath);

            var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
            go.GetComponent<TextMesh>().text = Vampire_Attack.vampiredamage.ToString();

            SoundManagerScript.PlaySound("bullethit");
            enemyhealthAmount -= Vampire_Attack.vampiredamage;

            if (enemyhealthAmount <= 0)
            {
                Health_Player.playerhealthAmount += tempenemyhealthAmount/20;
            }

            Destroy(col.gameObject);

        }

    }

    void IndianAttack()
    {
        var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
        go.GetComponent<TextMesh>().text = Indian_Attack.indiandamage.ToString();

        SoundManagerScript.PlaySound("bullethit");
        enemyhealthAmount -= Indian_Attack.indiandamage/2;

    }

    void PoisonWizardAttack()
    {
        var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
        go.GetComponent<TextMesh>().text = Poisonwizard_Attack.poisondamage.ToString();

        SoundManagerScript.PlaySound("bullethit");
        enemyhealthAmount -= Poisonwizard_Attack.poisondamage;

    }

    void NurseAttack()
    {
        var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
        go.GetComponent<TextMesh>().text = Nurse_Attack.nursedamage.ToString();

        SoundManagerScript.PlaySound("bullethit");
        enemyhealthAmount -= Nurse_Attack.nursedamage / 2;

    }

    void DemonAttack()
    {
        var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
        go.GetComponent<TextMesh>().text = Demon_Attack.demondamage.ToString();

        SoundManagerScript.PlaySound("bullethit");
        enemyhealthAmount -= Demon_Attack.demondamage/2;

    }

    void FireWizardAttack()
    {
        var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
        go.GetComponent<TextMesh>().text = Firewizard_Attack.firedamage.ToString();

        SoundManagerScript.PlaySound("bullethit");
        enemyhealthAmount -= Firewizard_Attack.firedamage;

    }

    void SamuraiAttack()
    {
        Instantiate(blood, transform.position, bloodPath);

        var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
        go.GetComponent<TextMesh>().text = Samurai_Attack.samuraidamage.ToString();

        SoundManagerScript.PlaySound("bullethit");
        enemyhealthAmount -= Samurai_Attack.samuraidamage / 2;

    }

    void RobberAttack()
    {
        Instantiate(blood, transform.position, bloodPath);

        var go = Instantiate(FloatingText, transform.position, Quaternion.identity, transform);
        go.GetComponent<TextMesh>().text = Robber_Attack.robberdamage.ToString();

        SoundManagerScript.PlaySound("bullethit");
        enemyhealthAmount -= Robber_Attack.robberdamage / 2;

    }

    void SkiAttack()
    {
        Ice.SetActive(false);

        if (level.Equals("easy"))
        {
            moveSpeed = 20f;
        }

        if (level.Equals("medium"))
        {
            moveSpeed = 25f;
        }

        if (level.Equals("hard"))
        {
            moveSpeed = 30f;
        }
    }
}
