using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 玩家战斗控制器
/// </summary>
public class PlayerCombatController : MonoBehaviour
{
    ///// <summary>
    ///// 战斗启用
    ///// </summary>
    //[SerializeField] private bool combatEnabled;
    ///// <summary>
    ///// 输入计时器
    ///// </summary>
    //[SerializeField] private float inputTimer;
    ///// <summary>
    ///// 攻击1范围
    ///// </summary>
    //[SerializeField] private float attack1Radius;
    ///// <summary>
    ///// 攻击1伤害
    ///// </summary>
    //[SerializeField] private float attack1Damage;
    ///// <summary>
    ///// 眩晕伤害量
    ///// </summary>
    //[SerializeField] private float stunDamageAmount = 1f;
    ///// <summary>
    ///// 攻击1命中框位置
    ///// </summary>
    //[SerializeField] private Transform attack1HitBoxPos;
    ///// <summary>
    ///// 可伤害图层蒙版
    ///// </summary>
    //[SerializeField] private LayerMask whatIsDamageable;

    ///// <summary>
    ///// 获得输入
    ///// </summary>
    //private bool gotInput;
    ///// <summary>
    ///// 是否在攻击
    ///// </summary>
    //private bool isAttacking;
    ///// <summary>
    ///// 是否首次攻击
    ///// </summary>
    //private bool isFirstAttack;

    ///// <summary>
    ///// 上次输入时间
    ///// </summary>
    //private float lastInputTime = Mathf.NegativeInfinity;

    ///// <summary>
    ///// 攻击详情
    ///// </summary>
    //private AttackDetails attackDetails;

    //// Component
    //private Animator anim;

    //private PlayerController PC;
    //private PlayerStats PS;


    //private void Start()
    //{
    //    anim = GetComponent<Animator>();
    //    anim.SetBool("canAttack", combatEnabled);
    //    PC = GetComponent<PlayerController>();
    //    PS = GetComponent<PlayerStats>();
    //}

    //private void Update()
    //{
    //    CheckCombatInput();
    //    CheckAttacks();
    //}

    ///// <summary>
    ///// 检查战斗输入
    ///// </summary>
    //private void CheckCombatInput()
    //{
    //    if (Input.GetMouseButtonDown(0))
    //    {
    //        if (combatEnabled)
    //        {
    //            // Attempt combat
    //            gotInput = true;
    //            lastInputTime = Time.time;
    //        }
    //    }
    //}

    ///// <summary>
    ///// 检查攻击
    ///// </summary>
    //private void CheckAttacks()
    //{
    //    if (gotInput)
    //    {
    //        // Perform Attack1
    //        if (!isAttacking)
    //        {
    //            gotInput = false;
    //            isAttacking = true;
    //            isFirstAttack = !isFirstAttack;
    //            anim.SetBool("attack1", true);
    //            anim.SetBool("firstAttack", isFirstAttack);
    //            anim.SetBool("isAttacking", isAttacking);
    //        }
    //    }

    //    if (Time.time >= lastInputTime + inputTimer)
    //    {
    //        // Wait for new input
    //        gotInput = false;
    //    }
    //}

    ///// <summary>
    ///// 检查攻击命中框
    ///// </summary>
    //private void CheckAttackHitBox()
    //{
    //    Collider2D[] detectedObjects = Physics2D.OverlapCircleAll(attack1HitBoxPos.position, attack1Radius, whatIsDamageable);

    //    attackDetails.damageAmount = attack1Damage;
    //    attackDetails.position = transform.position;
    //    attackDetails.stunDamageAmount = stunDamageAmount;

    //    foreach (Collider2D collider in detectedObjects)
    //    {
    //        collider.transform.parent.SendMessage("Damage", attackDetails);
    //        // Instantiate hit particle
    //    }
    //}

    ///// <summary>
    ///// 完成攻击1
    ///// </summary>
    //private void FinishAttack1()
    //{
    //    isAttacking = false;
    //    anim.SetBool("isAttacking", isAttacking);
    //    anim.SetBool("attack1", false);
    //}

    ///// <summary>
    ///// 根据攻击详情造成伤害
    ///// </summary>
    ///// <param name="attackDetails"></param>
    //private void Damage(AttackDetails attackDetails)
    //{
    //    if (!PC.GetDashStatus())
    //    {
    //        int direction;

    //        PS.DecreaseHealth(attackDetails.damageAmount);

    //        if (attackDetails.position.x < transform.position.x)
    //        {
    //            direction = 1;
    //        }
    //        else
    //        {
    //            direction = -1;
    //        }

    //        PC.Knockback(direction);
    //    }
    //}

    //private void OnDrawGizmos()
    //{
    //    Gizmos.DrawWireSphere(attack1HitBoxPos.position, attack1Radius);
    //}
}
