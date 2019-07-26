using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1 {
    class Aircraft {
        //幸运转盘
        int[] luckTurn = new int[5] { 12,23,65,86,14 };
        //地雷
        int[] landMine = new int[10] { 76,21,64,32,13,75,98,32,42,54 };
        //暂停
        int[] pause = new int[5] { 53,57,24,15,78 };
        //时间穿梭
        int[] timeTunnel = new int[2] { 74,77 };
        //地图
        static int[] maps = new int[100];




        static void Main(string[] ars) {
            Aircraft aircraft = new Aircraft();
            aircraft.InitArray();
            aircraft.InitMapsLine();
            aircraft.InitMapsRow();
            Console.ReadKey();
        }





        /// <summary>
        /// 游戏Title
        /// </summary>
        public void Title() {
            Console.ForegroundColor=ConsoleColor.Red;
            Console.WriteLine("************************");
            Console.ForegroundColor=ConsoleColor.Yellow;
            Console.WriteLine("************************");
            Console.ForegroundColor=ConsoleColor.Blue;
            Console.WriteLine("*******V1.0*************");
            Console.ForegroundColor=ConsoleColor.Green;
            Console.WriteLine("************************");
            Console.ForegroundColor=ConsoleColor.White;
            Console.WriteLine("************************");
        }

        /// <summary>
        /// 游戏玩家
        /// </summary>
        public void Gamer() {

            String gamer1;
            String gamer2;
            do {
                Console.WriteLine("请输入玩家1的姓名:");
                gamer1=Console.ReadLine();
                if(gamer1==null) {
                    Console.WriteLine("玩家姓名不得为空");
                    continue;
                }
            } while(gamer1==null);

            do {
                Console.WriteLine("请输入玩家2的姓名");
                gamer2=Console.ReadLine();
                if(gamer2==null) {
                    Console.WriteLine("玩家姓名不得为空");
                    continue;
                }
                if(gamer2.Equals(gamer2)) {
                    Console.WriteLine("玩家姓名不得相同");
                    continue;
                }
            } while(gamer2==null||gamer2==gamer1);


        }

        void InitArray() {
            for(int i = 0;i<luckTurn.Length;i++) {
                maps[luckTurn[i]]=1;
            }
            for(int i = 0;i<landMine.Length;i++) {
                maps[landMine[i]]=2;
            }
            for(int i = 0;i<pause.Length;i++) {
                maps[pause[i]]=3;
            }
            for(int i = 0;i<timeTunnel.Length;i++) {
                maps[timeTunnel[i]]=4;
            }
        }



        void InitMapsLine() {
            for(int i = 0;i<30;i++) {

                switch(maps[i]) {
                    case 0:
                        Console.ForegroundColor=ConsoleColor.Red;
                        Console.Write("□");
                        break;

                    case 1:
                        Console.ForegroundColor=ConsoleColor.Yellow;
                        Console.Write("◎");
                        break;
                    case 2:
                        Console.ForegroundColor=ConsoleColor.Blue;
                        Console.Write("☆");
                        break;

                    case 3:
                        Console.ForegroundColor=ConsoleColor.Green;
                        Console.Write("▲");
                        break;
                    case 4:
                        Console.ForegroundColor=ConsoleColor.Cyan;
                        Console.Write("卐");
                        break;
                }
            }
        }
        void InitMapsRow() {
            for(int i = 0;i<30;i++) {
                Console.Write(" ");
                for(int j = 31;j<35;j++) {

                }
            }
        }


    }














}
