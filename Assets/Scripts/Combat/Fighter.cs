using System;
using RPG.Core;
using UnityEngine;
using RPG.Movement;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour, IAction
    {
        [SerializeField] float weaponRange = 2f;
        [SerializeField] float timeBetweenAttacks = 1f;

        private Transform target;
        private float timeScienceLastAttack = 0f;

        private void Update()
        {
            timeScienceLastAttack += Time.deltaTime;
            print(timeScienceLastAttack);

            if (target == null) return;
            
            if (!GetsIsInRange())
            {
                GetComponent<Mover>().MoveTo(target.position);
            }
            else
            {
                GetComponent<Mover>().Cancel();
                AttackBehaviour();
            }
        }

        private void AttackBehaviour()
        {
            if (timeScienceLastAttack > timeBetweenAttacks)
            {
                GetComponent<Animator>().SetTrigger("attack");
                timeScienceLastAttack = 0;
            }
        }

        private bool GetsIsInRange()
        {
            return Vector3.Distance(transform.position,target.position) < weaponRange;
        }

        public void Attack(CombatTarget combatTarget)
        {
            GetComponent<ActionSchedular>().StartAction(this);
            target = combatTarget.transform;
        }

        public void Cancel()
        {
            target = null;
        }

        // Animation Event
        private void Hit()
        {
            
        }
    }
} 