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
        void GameStart()
        {
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

    }
}