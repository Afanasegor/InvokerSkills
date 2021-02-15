using System;
using System.Collections.Generic;
using System.Text;

namespace InvokerSkills
{
    public static class AllCombos
    {
        public static string WhatSkill(string combo)
        {
            string skillName = null;

            if (combo == "qqq")
            {
                skillName = "ColdSnap";
            }
            else if (combo == "qqw" || combo == "qwq" || combo == "wqq")
            {
                skillName = "GhostWalk";
            }
            else if (combo == "qqe" || combo == "qeq" || combo == "eqq")
            {
                skillName = "IceWall";
            }
            else if (combo == "www")
            {
                skillName = "EMP";
            }
            else if (combo == "wwq" || combo == "wqw" || combo == "qww")
            {
                skillName = "Tornado";
            }
            else if (combo == "wwe" || combo == "wew" || combo == "eww")
            {
                skillName = "Alacrity";
            }
            else if (combo == "eee")
            {
                skillName = "SunStrike";
            }
            else if (combo == "eeq" || combo == "eqe" || combo == "qee")
            {
                skillName = "ForgeSpirit";
            }
            else if (combo == "eew" || combo == "ewe" || combo == "wee")
            {
                skillName = "Meteorite";
            }
            else if (combo == "qwe" || combo == "qew" || combo == "weq" || combo == "wqe" || combo == "eqw" || combo == "ewq")
            {
                skillName = "Blast";
            }
            else if (combo == "stop" || combo == "STOP" || combo == "Stop")
            {
                skillName = "STOP";
            }
            else if (combo == "R" || combo == "r" || combo == "Refresher" || combo == "refresher" || combo == "ref")
            {
                skillName = "Refresher";
            }
            else
            {
                skillName = "Wrong Combo!";
            }

            return skillName;
        }
    }
}
