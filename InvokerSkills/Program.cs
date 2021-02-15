using System;
using System.Diagnostics;

namespace InvokerSkills
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Давай кастуй!");
            Console.WriteLine();
            string[] allSkills = { "ColdSnap", "GhostWalk", "IceWall", "EMP", "Tornado", "Alacrity", "SunStrike", "ForgeSpirit", "Meteorite", "Blast" };
            string[] skillCooldown = allSkills;
            string cast = null;            
            Stopwatch sw = new Stopwatch();
            
            sw.Start();
            while (skillCooldown.Length > 0 && cast != "STOP")
            {
                string combo = Console.ReadLine();
                cast = AllCombos.WhatSkill(combo);
                DeleteSkill(ref skillCooldown, cast, allSkills);
                Result(skillCooldown, cast);
            }
            sw.Stop();            
            Console.WriteLine();
            Console.WriteLine($"Время потрачено: {sw.Elapsed}");
        }

        static void DeleteSkill(ref string[] m, string cast, string[] allSkills) //то, что ниже закоментировано, это на случай метода без использования "ref"
        {
            if (cast == "Refresher")
            {
                //return allSkills;
                m = allSkills;
            }
            else
            {
                string[] m2 = new string[m.Length - 1];
                bool check = false;
                int k = 0;
                for (int i = 0; i < m.Length; i++)
                {
                    if (cast == m[i])
                    {
                        check = true;
                    }
                }
                if (check == true)
                {
                    for (int i = 0; i < m.Length; i++)
                    {
                        if (cast == m[i])
                        {
                            continue;
                        }
                        m2[k] = m[i];
                        k++;
                    }
                    //return m2;
                    m = m2;
                }
                //else
                //{
                //    return m;
                //}
            }
        }

        static void Result(string[] skillCooldown, string cast)
        {
            if (cast == "STOP")
            {
                Console.WriteLine("Ручная остановка программы");
            }
            else if (skillCooldown.Length > 0)
            {
                Console.WriteLine(skillCooldown.Length);
                Console.Write("Скиллы не в кулдауне: ");
                for (int j = 0; j < skillCooldown.Length; j++)
                {
                    Console.Write(skillCooldown[j] + " ");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Вот ты и потратил все скиллы...");
            }
            
        }
    }
}