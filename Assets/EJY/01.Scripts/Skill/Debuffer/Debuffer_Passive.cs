using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace EJY
{
<<<<<<<< HEAD:Assets/EJY/01.Scripts/Skill/BossSkill/ElectroFrog/Skill_BarrierElectro.cs
    public class Skill_BarrierElectro : Skill_Stack
========
    public class Debuffer_Passive : Skill_Stack
>>>>>>>> 41d503ae26f0e3bce19bedac156644e1834db085:Assets/EJY/01.Scripts/Skill/Debuffer/Debuffer_Passive.cs
    {
        protected float weightBarrier;
        public override void Awake()
        {
            target = GetComponentInParent<Shy_Character>();
        }

        public override bool CanUseSkill()
        {
            return true;
        }

        public override void UseSkill()
        {
<<<<<<<< HEAD:Assets/EJY/01.Scripts/Skill/BossSkill/ElectroFrog/Skill_BarrierElectro.cs
            target.stacks.Add(stackPrefab);

            //방어력 계산
            weightBarrier = 30 + (target.HealthCompo._maxHp - target.HealthCompo._currentHp) * 0.15f; 

            target.HealthCompo.GetBarrier(weightBarrier);
========
            target.stacks.Add(stackPrefab.Init(target.transform.GetChild(0)));
>>>>>>>> 41d503ae26f0e3bce19bedac156644e1834db085:Assets/EJY/01.Scripts/Skill/Debuffer/Debuffer_Passive.cs
        }
    }

}
