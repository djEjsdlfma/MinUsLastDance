using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TK_HealingSkill : TK_Skill
{
    public override bool CanUseSkill(Shy_Player player)
    {
        return base.CanUseSkill(player);
    }

    public override void SkillLevelUp()
    {
        base.SkillLevelUp();
    }

    public override void UseSkill(Shy_Player player, List<EJY_Enemy> targets)
    {
        base.UseSkill(player, targets);
    }
}
