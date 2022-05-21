using System;
using RPG.Core;
using UnityEngine;
using RPG.Movement;

namespace RPG.Combat
{
    public class Fighter : MonoBehaviour
    {
        [SerializeField] float weaponRange = 2f;
        
        private Transform target;

        private void Update()
        {
            if (target == null) return;
            
            if (!GetsIsInRange())
            {
                GetComponent<Mover>().MoveTo(target.position);
            }
            else
            {
               // Cancel();
                GetComponent<Mover>().Stop();
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
    }
} 