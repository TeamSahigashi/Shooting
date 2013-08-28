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
        //ここのあたりに定義を書いていくでござる
        void test()
        {
            Console.WriteLine("うぇーいｗｗ");
            return;
        }

        class Object{
            protected Vector2 position;
            protected Texture2D texture;
            protected Vector2 size;
            protected int HP;
            protected Vector2 speed;
            protected bool exist;
            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="posi">初期位置</param>
            /// <param name="settexture">テクスチャ</param>
            /// <param name="setsize">サイズ</param>
            /// <param name="setHP">HP</param>
            /// <param name="setspeed">スピード</param>
            public Object(Vector2 posi, Texture2D settexture, Vector2 setsize, int setHP, Vector2 setspeed){
                position = new Vector2(posi.X, posi.Y);
                texture = settexture; //うまくいかなかったらここ
                size = new Vector2(setsize.X, setsize.Y);
                HP = setHP;
                speed = setspeed;
                exist = true;
            }
           /// <summary>
           /// 存在してるかどうか
           /// </summary>
           /// <returns>存在しているならtrue</returns>
                public bool checkExist(){
                    return exist;
                }
            /// <summary>
            /// a
            /// </summary>
            /// <returns>i</returns>
                public Vector2 locate(){
                    return position;
                }

            }
            }
        class Player : Object {
            /// <summary>
            /// hitしたら残機をへらす
            /// </summary>
            public　void zankiReduce()
            {

            }
            /// <summary>
            /// 残機を返す
            /// </summary>
            /// <returns></returns>
            public int zankiCheck()
            {
                return 0;
            }

            public void update()
            {
            }
            public void draw()
            {
            }
        }
        class Enemy : Object
        {
            public void update()
            {

            }
            public void draw()
            {
            }
        }
        class Tama : Object
        {
            public void update()
            {
            }
            public void draw()
            {
            }
        }
            
    }
    
}
