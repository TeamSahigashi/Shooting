using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace Shooting
{
    public partial class Game1 : Microsoft.Xna.Framework.Game
    {
        /// <summary>
        /// ゲームを開始する
        /// </summary>
        /// <param name="stagenum">ステージ番号</param>
        void GameUpdate()
        {
            player.update();
            if (EnemyList != null)
            {
                foreach (var item in EnemyList)
                {
                    item.update();
                }
            }
            if (TamaList != null)
            {
                foreach (var item in TamaList)
                {
                    item.update();
                }
            }

            switch (stagenum)
            {
                case 0:
                    Makestage1();
                    break;
                case 1:
                    Makestage2();
                    break;
                case 2:
                    Makestage3();
                    break;
                default:
                    break;
            }

            //クリアしたら次の面へいく
            if (clearflag)
            {
                stagenum++;
                clearflag = false;
            }

            //ダメージ受けたら残機減る

        }

        /// <summary>
        /// １面設定
        /// </summary>
        void Makestage1()
        {




          
        }


        /// <summary>
        /// ２面設定
        /// </summary>
        void Makestage2()
        {

        }



        /// <summary>
        /// ３面設定
        /// </summary>
        void Makestage3()
        {

        }

        /// <summary>
        /// 当たり判定
        /// </summary>
        /// <param name="A">当たるもの</param>
        /// <param name="B">当てられるもの</param>
        /// <returns>当たった:true</returns>
        bool hit(Object A, Object B)
        {
            int X0 = (int)A.locate().X;
            int X1 = (int)A.locate().X + (int)A.getSize().X;
            int Y0 = (int)A.locate().Y;
            int Y1 = (int)A.locate().Y + (int)B.getSize().Y;



        }
    }
}