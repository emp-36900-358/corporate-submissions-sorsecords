using System;


namespace Stage
{

    [Serializable]
    public class NormalStges
    {

        static int[,] blockmap1 = new int[,]{{1, 5 ,3, 1, 2, 4, 3},
                                             {3, 1, 2, 4, 1, 5, 2},
                                             {5, 2, 4, 3, 5, 1, 4}};

        static int[,] blockmap2 = new int[,]{{1, 5, 3, 1, 2, 4, 3},
                                             {3, 1, 2, 4, 1, 5, 2},
                                             {5, 2, 4, 3, 5, 1, 4},
                                             {1, 3, 4, 3, 5, 2, 1}};


        static int[,] blockmap3 = new int[,]{{1, 5, 3, 1, 2, 4, 3},
                                             {3, 1, 2, 4, 1, 5, 2},
                                             {5, 2, 4, 3, 5, 1, 4},
                                             {1, 3, 2, 3, 5, 2, 1},
                                             {5, 1, 3, 2, 3, 4, 2}};


        static int[,] blockmap4_7 = new int[,]{{1, 5, 3, 1, 2, 4, 3},
                                               {3, 1, 2, 4, 1, 5, 2},
                                               {5, 2, 4, 3, 5, 1, 4},
                                               {3, 1, 5, 2, 3, 2, 5},
                                               {6, 6, 6, 6, 6, 6, 6}};

        static int[,] blockmap8 = new int[,]{{0, 6, 6, 6, 6, 6, 0},
                                             {0, 6, 0, 0, 0, 6, 0},
                                             {0, 6, 0, 0, 0, 6, 0},
                                             {0, 6, 0, 0, 0, 6, 0},
                                             {0, 6, 6, 6, 6, 6, 0},
                                             {0, 3, 3, 3, 3, 3, 0},
                                             {0, 3, 3, 3, 3, 3, 0},
                                             {0, 6, 6, 6, 6, 6, 0},
                                             {0, 6, 6, 6, 6, 6, 0}};

        static int[,] blockmap9 = new int[,] {{0, 6, 0, 0, 0, 6, 0},
                                              {6, 0, 6, 0, 6, 0, 6},
                                              {0, 6, 0, 0, 0, 6, 0},
                                              {6, 6, 6, 6, 6, 6, 6},
                                              {3, 3, 3, 3, 3, 3, 3},
                                              {6, 6, 6, 6, 6, 6, 6},
                                              {6, 0, 0, 6, 0, 6, 6},
                                              {6, 0, 0, 6, 0, 6, 0},
                                              {6, 6, 6, 6, 6, 6, 6},
                                              {6, 6, 6, 6, 6, 6, 6},
                                              {6, 6, 6, 6, 6, 6, 6},
                                              {3, 3, 3, 3, 3, 3, 3},
                                              {3, 3, 3, 3, 3, 3, 3},
                                              {6, 6, 6, 6, 6, 6, 6},
                                              {6, 6, 6, 6, 6, 6, 6}};

        static int[,] blockmap10 = new int[,]{{0, 6, 6, 6, 6, 6, 0},
                                              {0, 6, 0, 0, 0, 6, 0},
                                              {0, 6, 0, 0, 0, 6, 0},
                                              {0, 6, 0, 0, 0, 6, 0},
                                              {0, 6, 6, 6, 6, 6, 0},
                                              {0, 1, 1, 1, 1, 1, 0},
                                              {0, 1, 1, 1, 1, 1, 0},
                                              {0, 6, 6, 6, 6, 6, 0},
                                              {0, 6, 6, 6, 6, 6, 0}};

        static int[,] blockmap11 = new int[,]{{0, 6, 0, 0, 0, 6, 0},
                                              {6, 0, 6, 0, 6, 0, 6},
                                              {0, 6, 0, 0, 0, 6, 0},
                                              {6, 6, 6, 6, 6, 6, 6},
                                              {1, 1, 1, 1, 1, 1, 1},
                                              {6, 6, 6, 6, 6, 6, 6},
                                              {6, 0, 0, 6, 0, 6, 6},
                                              {6, 0, 0, 6, 0, 6, 0},
                                              {6, 6, 6, 6, 6, 6, 6},
                                              {6, 6, 6, 6, 6, 6, 6},
                                              {6, 6, 6, 6, 6, 6, 6},
                                              {4, 4, 4, 4, 4, 4, 4},
                                              {4, 4, 4, 4, 4, 4, 4},
                                              {6, 6, 6, 6, 6, 6, 6},
                                              {6, 6, 6, 6, 6, 6, 6}};

        static int[,] blockmap12 = new int[,]{{0, 6, 6, 6, 6, 6, 0},
                                             {0, 6, 0, 0, 0, 6, 0},
                                             {0, 6, 0, 0, 0, 6, 0},
                                             {0, 6, 0, 0, 0, 6, 0},
                                             {0, 6, 6, 6, 6, 6, 0},
                                             {0, 4, 4, 4, 4, 4, 0},
                                             {0, 4, 4, 4, 4, 4, 0},
                                             {0, 6, 6, 6, 6, 6, 0},
                                             {0, 6, 6, 6, 6, 6, 0}};

        static int[,] blockmap13 = new int[,]{{0, 6, 6, 6, 6, 6, 0},
                                              {0, 6, 0, 0, 0, 6, 0},
                                              {0, 6, 0, 0, 0, 6, 0},
                                              {0, 6, 0, 0, 0, 6, 0},
                                              {0, 6, 6, 6, 6, 6, 0},
                                              {0, 2, 2, 2, 2, 2, 0},
                                              {0, 2, 2, 2, 2, 2, 0},
                                              {0, 6, 6, 6, 6, 6, 0},
                                              {0, 6, 6, 6, 6, 6, 0}};

        static int[,] blockmap14 = new int[,]{{0, 6, 0, 0, 0, 6, 0},
                                              {6, 0, 6, 0, 6, 0, 6},
                                              {0, 6, 0, 0, 0, 6, 0},
                                              {6, 6, 6, 6, 6, 6, 6},
                                              {2, 2, 2, 2, 2, 2, 2},
                                              {6, 6, 6, 6, 6, 6, 6},
                                              {6, 0, 0, 6, 0, 6, 6},
                                              {6, 0, 0, 6, 0, 6, 0},
                                              {6, 6, 6, 6, 6, 6, 6},
                                              {6, 6, 6, 6, 6, 6, 6},
                                              {6, 6, 6, 6, 6, 6, 6},
                                              {2, 2, 2, 2, 2, 2, 2},
                                              {2, 2, 2, 2, 2, 2, 2},
                                              {6, 6, 6, 6, 6, 6, 6},
                                              {6, 6, 6, 6, 6, 6, 6}};

        static int[,] blockmap115 = new int[,]{{0, 6, 6, 6, 6, 6, 0},
                                               {0, 6, 0, 0, 0, 6, 0},
                                               {0, 6, 0, 0, 0, 6, 0},
                                               {0, 6, 0, 0, 0, 6, 0},
                                               {0, 6, 6, 6, 6, 6, 0},
                                               {0, 5, 5, 5, 5, 5, 0},
                                               {0, 5, 5, 5, 5, 5, 0},
                                               {0, 6, 6, 6, 6, 6, 0},
                                               {0, 6, 6, 6, 6, 6, 0}};

        static int[,] blockmap16 = new int[,] {{0, 6, 0, 0, 0, 6, 0},
                                               {6, 0, 6, 0, 6, 0, 6},
                                               {0, 6, 0, 0, 0, 6, 0},
                                               {6, 6, 6, 6, 6, 6, 6},
                                               {5, 5, 5, 5, 5, 5, 5},
                                               {6, 6, 6, 6, 6, 6, 6},
                                               {6, 0, 0, 6, 0, 6, 6},
                                               {6, 0, 0, 6, 0, 6, 0},
                                               {6, 6, 6, 6, 6, 6, 6},
                                               {6, 6, 6, 6, 6, 6, 6},
                                               {6, 6, 6, 6, 6, 6, 6},
                                               {5, 5, 5, 6, 5, 5, 5},
                                               {6, 6, 5, 5, 5, 6, 6},
                                               {6, 6, 6, 6, 6, 6, 6},
                                               {6, 6, 6, 6, 6, 6, 6}};

        /*static int[,] blockmap17 = new int[,]{{1, 5, 3, 1, 2, 4, 3},
                                             {3, 1, 2, 4, 1, 5, 2},
                                             {5, 2, 4, 3, 5, 1, 4},
                                             {3, 1, 5, 2, 3, 2, 5},
                                             {6, 6, 6, 6, 6, 6, 6}};*/

        /*static int[,] blockmap18 = new int[,]{{1, 5, 3, 1, 2, 4, 3},
                                     {3, 1, 2, 4, 1, 5, 2},
                                     {5, 2, 4, 3, 5, 1, 4},
                                     {3, 1, 5, 2, 3, 2, 5},
                                     {6, 6, 6, 6, 6, 6, 6}};*/

        /*static int[,] blockmap19 = new int[,]{{1, 5, 3, 1, 2, 4, 3},
                                             {3, 1, 2, 4, 1, 5, 2},
                                             {5, 2, 4, 3, 5, 1, 4},
                                             {3, 1, 5, 2, 3, 2, 5},
                                             {6, 6, 6, 6, 6, 6, 6}};*/

        /*static int[,] blockmap20 = new int[,]{{1, 5, 3, 1, 2, 4, 3},
                                     {3, 1, 2, 4, 1, 5, 2},
                                     {5, 2, 4, 3, 5, 1, 4},
                                     {3, 1, 5, 2, 3, 2, 5},
                                     {6, 6, 6, 6, 6, 6, 6}};*/

        /*static int[,] blockmap21 = new int[,]{{1, 5, 3, 1, 2, 4, 3},
                                     {3, 1, 2, 4, 1, 5, 2},
                                     {5, 2, 4, 3, 5, 1, 4},
                                     {3, 1, 5, 2, 3, 2, 5},
                                     {6, 6, 6, 6, 6, 6, 6}};*/

        /*static int[,] blockmap22 = new int[,]{{1, 5, 3, 1, 2, 4, 3},
                                     {3, 1, 2, 4, 1, 5, 2},
                                     {5, 2, 4, 3, 5, 1, 4},
                                     {3, 1, 5, 2, 3, 2, 5},
                                     {6, 6, 6, 6, 6, 6, 6}};*/

        /*static int[,] blockmap23 = new int[,]{{1, 5, 3, 1, 2, 4, 3},
                                     {3, 1, 2, 4, 1, 5, 2},
                                     {5, 2, 4, 3, 5, 1, 4},
                                     {3, 1, 5, 2, 3, 2, 5},
                                     {6, 6, 6, 6, 6, 6, 6}};*/

        /*static int[,] blockmap24 = new int[,]{{1, 5, 3, 1, 2, 4, 3},
                                     {3, 1, 2, 4, 1, 5, 2},
                                     {5, 2, 4, 3, 5, 1, 4},
                                     {3, 1, 5, 2, 3, 2, 5},
                                     {6, 6, 6, 6, 6, 6, 6}};*/

        /*static int[,] blockmap25 = new int[,]{{1, 5, 3, 1, 2, 4, 3},
                                     {3, 1, 2, 4, 1, 5, 2},
                                     {5, 2, 4, 3, 5, 1, 4},
                                     {3, 1, 5, 2, 3, 2, 5},
                                     {6, 6, 6, 6, 6, 6, 6}};*/

        /*static int[,] blockmap26 = new int[,]{{1, 5, 3, 1, 2, 4, 3},
                                     {3, 1, 2, 4, 1, 5, 2},
                                     {5, 2, 4, 3, 5, 1, 4},
                                     {3, 1, 5, 2, 3, 2, 5},
                                     {6, 6, 6, 6, 6, 6, 6}};*/

        public static int[,] map1 { get{ return blockmap1; } }
        public static int[,] map2 { get{ return blockmap2; } }
        public static int[,] map3 { get{ return blockmap3; } }
        public static int[,] map4_7 { get{ return blockmap4_7; } }
        public static int[,] map8 { get{ return blockmap8; } }
        public static int[,] map9 { get{ return blockmap9; } }
        //public static int[,] map10 { get{ return blockmap10; } }
        //public static int[,] map11 { get{ return blockmap11; } }
        //public static int[,] map12 { get{ return blockmap12; } }
        //public static int[,] map13 { get{ return blockmap13; } }
        //public static int[,] map14 { get{ return blockmap14; } }
        //public static int[,] map15 { get{ return blockmap15; } }
        //public static int[,] map16 { get{ return blockmap16; } }
        //public static int[,] map17 { get{ return blockmap17; } }
        //public static int[,] map18 { get{ return blockmap18; } }
        //public static int[,] map19 { get{ return blockmap19; } }
        //public static int[,] map20 { get{ return blockmap20; } }
        //public static int[,] map21 { get{ return blockmap22; } }
        //public static int[,] map22 { get{ return blockmap23; } }
        //public static int[,] map23 { get{ return blockmap22; } }
        //public static int[,] map24 { get{ return blockmap24; } }
        //public static int[,] map25 { get{ return blockmap25; } }
        //public static int[,] map26 { get{ return blockmap26; } }

    }

    [Serializable]
    public class RareStages
    {

        static int[,] blockmapR1 = new int[,]{{1, 5, 3, 1, 2, 4, 3},
                                     {3, 1, 2, 4, 1, 5, 2},
                                     {5, 2, 4, 3, 5, 1, 4},
                                     {3, 1, 5, 2, 3, 2, 5},
                                     {6, 6, 6, 6, 6, 6, 6}};


        static int[,] blockmapR2 = new int[,]{{1, 5, 3, 1, 2, 4, 3},
                                             {3, 1, 2, 4, 1, 5, 2},
                                             {5, 2, 4, 3, 5, 1, 4},
                                             {3, 1, 5, 2, 3, 2, 5},
                                             {6, 6, 6, 6, 6, 6, 6}};
    
        /*static int[,] blockmapR3 = new int[,]{{1, 5, 3, 1, 2, 4, 3},
                                             {3, 1, 2, 4, 1, 5, 2},
                                             {5, 2, 4, 3, 5, 1, 4},
                                             {3, 1, 5, 2, 3, 2, 5},
                                             {6, 6, 6, 6, 6, 6, 6}};*/
     
        /*static int[,] blockmapR4 = new int[,]{{1, 5, 3, 1, 2, 4, 3},
                                             {3, 1, 2, 4, 1, 5, 2},
                                             {5, 2, 4, 3, 5, 1, 4},
                                             {3, 1, 5, 2, 3, 2, 5},
                                             {6, 6, 6, 6, 6, 6, 6}};*/
    
        /*static int[,] blockmapR5 = new int[,]{{1, 5, 3, 1, 2, 4, 3},
                                             {3, 1, 2, 4, 1, 5, 2},
                                             {5, 2, 4, 3, 5, 1, 4},
                                             {3, 1, 5, 2, 3, 2, 5},
                                             {6, 6, 6, 6, 6, 6, 6}};*/
     
        /*static int[,] blockmapR6 = new int[,]{{1, 5, 3, 1, 2, 4, 3},
                                             {3, 1, 2, 4, 1, 5, 2},
                                             {5, 2, 4, 3, 5, 1, 4},
                                             {3, 1, 5, 2, 3, 2, 5},
                                             {6, 6, 6, 6, 6, 6, 6}};*/

        public static int[,] reremap1 { get{ return blockmapR1; } }
        public static int[,] reremap2 { get{ return blockmapR2; } }
        //public static int[,] reremap3 { get{ return blockmapR3; } }
        //public static int[,] reremap4 { get{ return blockmapR4; } }
        //public static int[,] reremap5 { get{ return blockmapR5; } }
        //public static int[,] reremap6 { get{ return blockmapR6; } }

    }

    [Serializable]
    public class Stage_List
    {


        public  enum stages {st1, st2, st3, st4, st5, st6, st7, st8, st9, st10,
                            st11, st12, st13, st14, st15, st16, st17, st18, st19, st20,
                            st21, st22, st23, st24, st25, st26,
                            rst1, rst2, rst3, rst4, rst5, rst6};
        stages list;

        public stages stage_list { get{ return list; } }

        public class Stages
        {
            public int level;

            public Stages(int lvl)
            {
                level = lvl;
            }
        }

    }

}
